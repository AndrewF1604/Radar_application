using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Numerics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ElementPosition chart_SFCW_ipp0 = null; 
        int offset_flag=1;
        long freq;
        int detectors_perch;  
        int probes;
        double[] mean;
        int receivers;
        double[,] p_meas;
        double[,] ADC_values;
        double[,] watts;
        int chartoffset_x;
        int chartoffset_y;
        Complex[] Ts;
        Complex[] Offset;
        Complex[] Norm;
        SerialPort serialPort1 = new SerialPort();
        Parameters parameters1 = new Parameters();
        Ring_buffer buffer1;
        class Ring_buffer {
            int max;
            int count;
            public int tail;
            public int receivers_;
            public Complex[,] Ts_buffer;
            public Ring_buffer(int receivers, int size)
            {
                tail = -1;
                count = 0;
                max = size;
                Ts_buffer = new Complex[receivers,size];
                receivers_ = receivers;
            }
            public void insert(int receivers,Complex[] points){
                if (count == max)
                {
                    return;
                }
                else
                {
                    tail = (tail + 1) % max;
                    for (int i = 0; i < receivers; i++)
                    {
                        Ts_buffer[i,tail] = points[i];
                    }
                }
            }
        }
        struct Parameters
        {
            public double[] f;
            public double[] a;
            public double[] b;
            public double[] q;
            public double[] a0;
            public double[] b0;
        }
        void Set()
        {
            detectors_perch = Convert.ToInt16(textBoxDetectors.Text);
            probes = Convert.ToInt32(textBoxProbes.Text);
            freq = Convert.ToInt64(textBoxFreq.Text);
            receivers = Convert.ToInt16(textBoxReceivers.Text);
            p_meas = new double[detectors_perch*receivers, probes];
            ADC_values = new double[detectors_perch*receivers, probes];
            watts = new double[detectors_perch * receivers, probes];
            mean = new double[detectors_perch * receivers];
            buffer1 = new Ring_buffer(receivers, Convert.ToInt16(BUFFER_SIZE.Value));
            Norm = new Complex[receivers];
            Offset = new Complex[receivers];
            for(int i=0; i<receivers;i++){
                Offset[i]=new Complex(0,0);
                Norm[i] = new Complex(1,0);
            }
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = cBoxCOM.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cBoxBR.Text);
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = (StopBits)1;
                    serialPort1.ReceivedBytesThreshold = 1024;
                    serialPort1.ReadTimeout = 500;
                    serialPort1.WriteTimeout = 500;
                    serialPort1.Open();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxFreq_TextChanged(object sender, EventArgs e) 
        {
            try
            {
                if (textBoxFreq.Text!="")
                {
                    long freq = Convert.ToInt64(textBoxFreq.Text);
                    if (Convert.ToInt64(textBoxFreq.Text) > 500)
                        textBoxFreq.Text = "500";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }
        public void Detectors_readout()
        {
            string tablica = serialPort1.ReadLine();
            string[] posegregowany = tablica.Split(' ');
            for (int x = 0; x < detectors_perch*receivers; x++)
            {
                for (int i = 0; i < probes; i++)
                {
                    ADC_values[x, i] = Convert.ToDouble(posegregowany[x + 1 + i + x * probes]);
                    p_meas[x, i] = (ADC_values[x, i] - 1700.0) / 39.0;
                    watts[x, i] = Math.Pow(10, (p_meas[x, i]) / 10);
                    mean[x] += watts[x, i];
                }
                mean[x] = mean[x] / probes;
            }
        }
        private void SAVE_Click(object sender, EventArgs e)
        {
            Set();
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("c" + "\n" + textBoxProbes.Text + "\n" + textBoxFreq.Text + "\n");
            }
            Detectors_readout();
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = @"C:\Users\Andrzej\Documents\Visual Studio 2010\Projects\WindowsFormsApplication1",
                RestoreDirectory = true,
                FileName = "dane.txt",
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int probes = Convert.ToInt16(textBoxProbes.Text);
                System.IO.Stream fileStream = sfd.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                for (int x = 0; x < detectors_perch*receivers; x++)
                {
                    for (int i = 0; i < probes; i++)
                    {
                        sw.Write(Math.Round(watts[x, i], Convert.ToInt16(cBoxRounding.Text)).ToString().Replace(',','.'));
                        if(i < probes - 1)
                            sw.Write("\t");
                    }
                    if (x < detectors_perch*receivers - 1)
                        sw.Write("\n");
                }
                sw.Close();
                fileStream.Close();
            }
        }
        private void LOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                InitialDirectory = @"C:\Users\Andrzej\source\repos\WinFormsApp3\WinFormsApp3"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = System.IO.File.ReadAllLines(ofd.FileName).ToList();
                foreach (string line in lines)
                {
                    string[] Splitted = line.Split(' ');
                    double[] temporary = new double[Splitted.Length];
                    if (Splitted[0] == "f")
                    {
                        temporary[0] = Convert.ToDouble(Splitted[1].Replace('.', ','));
                        parameters1.f = temporary; 
                    }
                    else if (Splitted[0] == "a")
                    {
                        for (int a = 0; a < Splitted.Length-1; a++)
                        {
                            temporary[a] = Convert.ToDouble(Splitted[1 + a].Replace('.', ','));
                        }
                        parameters1.a = temporary;  
                    }
                    else if (Splitted[0] == "b")
                    {
                        for (int a = 0; a < Splitted.Length-1;a++)
                        {
                            temporary[a] = Convert.ToDouble(Splitted[1 + a].Replace('.', ','));
                        }
                        parameters1.b = temporary;
                    }
                    else if (Splitted[0] == "q")
                    {
                        for (int a = 0; a < Splitted.Length-1; a++)
                        {
                            temporary[a] = Convert.ToDouble(Splitted[1 + a].Replace('.', ','));
                        }
                        parameters1.q = temporary; 
                    }
                    else if (Splitted[0] == "a0")
                    {
                        for (int a = 0; a < Splitted.Length-1; a++)
                        {
                            temporary[a] = Convert.ToDouble(Splitted[1 + a].Replace('.', ','));
                        }
                        parameters1.a0 = temporary;
                    }
                    else if (Splitted[0] == "b0")
                    {
                        for (int a = 0; a < Splitted.Length-1; a++)
                        {
                            temporary[a] = Convert.ToDouble(Splitted[1 + a].Replace('.', ','));
                        }
                        parameters1.b0 = temporary;  
                    }
                }
            }
        }
        private void IDEAL_Click(object sender, EventArgs e)
        {
            Set();
            double[] tempa = new double[detectors_perch];
            double[] tempb = new double[detectors_perch];
            double[] tempq = new double[detectors_perch];
            double[] temp0 = { 0 };
            for (int m = 0; m < detectors_perch; m++)
            {
                double phi;
                phi = -(double)m / detectors_perch * 2 * Math.PI + Math.PI;
                dataGridView_SFCW_cal_params.Rows.Add();
                dataGridView_SFCW_cal_params.Rows[m].Cells[0].Value = Math.Round(Math.Cos(phi), 15); // real[Ai] a 
                dataGridView_SFCW_cal_params.Rows[m].Cells[1].Value = Math.Round(Math.Sin(phi), 15); // imag[Ai] b
                dataGridView_SFCW_cal_params.Rows[m].Cells[2].Value = 1.0 / detectors_perch; // qi q
            }
            dataGridView_SFCW_cal_params.Rows[0].Cells[3].Value = 0; // real[A0]   a0
            dataGridView_SFCW_cal_params.Rows[0].Cells[4].Value = 0; // imag[A0]   b0
            for (int i = 0; i < detectors_perch; i++)
            {
                tempa[i] = (double)dataGridView_SFCW_cal_params.Rows[i].Cells[0].Value;
                parameters1.a = tempa;
            }
            for (int i = 0; i < detectors_perch; i++)
            {
                tempb[i] = (double)dataGridView_SFCW_cal_params.Rows[i].Cells[1].Value;
                parameters1.b = tempb;
            }
            for (int i = 0; i < detectors_perch; i++)
            {
                tempq[i] = (double)dataGridView_SFCW_cal_params.Rows[i].Cells[2].Value;
                parameters1.q = tempq;
            }
            parameters1.a0 = temp0;
            parameters1.b0 = temp0;
        }
        private Complex[] Single_measure()
        {
            double real;
            double imag;
            Complex[] Measured = new Complex[receivers];
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("c" + "\n" + textBoxProbes.Text + "\n" + textBoxFreq.Text + "\n");
            }
            Detectors_readout();
            for (int i = 0; i < receivers; i++)
            {
                real = 0;
                imag = 0;
                for (int x = 0; x < detectors_perch; x++)
                {
                    real += mean[detectors_perch * i + x] * parameters1.a[x];
                    imag += mean[detectors_perch * i + x] * parameters1.b[x];
                }
                Measured[i] = new Complex(real, imag);
            }
            return Measured;
        }
        private void Chart_update()
        {
            double real;
            double imag;
            int bs = (int)BUFFER_SIZE.Value;
            Ts = new Complex[detectors_perch * receivers];
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("c" + "\n" + textBoxProbes.Text + "\n" + textBoxFreq.Text + "\n");
            }
            Detectors_readout();
            for (int i = 0; i < receivers; i++)
            {
                real = 0;     
                imag = 0;
                for (int x = 0; x < detectors_perch; x++)        
                {
                    real += mean[detectors_perch * i + x] * parameters1.a[x];
                    imag += mean[detectors_perch * i + x] * parameters1.b[x];
                }
                Ts[i] = new Complex(real, imag);
                
                    Plot.Series[i].Points.Clear();
                    Plot.Series[i+receivers].Points.Clear();
            }
            buffer1.insert(receivers,Ts);
            int t = buffer1.tail;
            Complex test;
            for (int i = 0; i < receivers; i++)
            {
                for (int x = 0; x < BUFFER_SIZE.Value; x++)
                {
                    if (offset_flag%2 == 0)
                    {
                        test = (buffer1.Ts_buffer[i, t] - Offset[i]) * Norm[i];
                    }
                    else {
                        test = (buffer1.Ts_buffer[i, t]) * Norm[i];
                    }
                    if (x == 0)
                    {
                    Plot.Series[i + receivers].Points.AddXY(test.Real, test.Imaginary);
                    }
                    Plot.Series[i].Points.AddXY(test.Real, test.Imaginary);
                    t--;
                    t = (t % bs + bs) % bs; 
                }   
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Offset = Single_measure();
            offset_flag++;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Complex[] Measured = new Complex[receivers];
            Measured = Single_measure();
            for (int i = 0; i < receivers; i++)
            {
                Norm[i] = 1 / (Measured[i] - Offset[i]);
            }
        }
        private void Plot_Update(){
            double round = Math.Round((double)SCALE.Value,2);
            double interval = Convert.ToDouble(cBoxINTERVAL.Text);
            Plot.ChartAreas[0].AxisX.Minimum = -round;           
            Plot.ChartAreas[0].AxisY.Minimum = -round;
            Plot.ChartAreas[0].AxisX.Maximum = round;
            Plot.ChartAreas[0].AxisY.Maximum = round;
            Plot.ChartAreas[0].AxisY.Interval = Math.Round(round /(interval),2);
            Plot.ChartAreas[0].AxisX.Interval = Math.Round(round / (interval), 2);
        }
        private void DRAW_Click(object sender, EventArgs e)
        {
            timer1.Enabled=!timer1.Enabled;  
        }
        private void textBoxFreq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxProbes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxReceivers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBoxDetectors_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Plot_Update();
            Chart_update(); 
        }
        private void SCALE_ValueChanged(object sender, EventArgs e)
        {
            SCALE.DecimalPlaces = 2;
            SCALE.Increment = 0.1M;
            SCALE.Minimum = 0.1M;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chartoffset_x = this.Width - Plot.Width;
            chartoffset_y= this.Height - Plot.Height;
            resizer();
            string[] ports = SerialPort.GetPortNames();
            cBoxCOM.Items.AddRange(ports);
        }
        private void resizer() {
            Plot.Height = this.Height - chartoffset_y - 45;
            Plot.Width = Plot.Height;
        }
        private void resizer2() {

            ChartArea ca = Plot.ChartAreas[0];

            // store the original value:
            if (chart_SFCW_ipp0 == null)
            {
                chart_SFCW_ipp0 = ca.InnerPlotPosition;
            }

            // get the current chart area :
            ElementPosition cap = ca.Position;

            // get both area sizes in pixels:
            Size CaSize = new Size((int)(cap.Width * Plot.ClientSize.Width / 100f),
            (int)(cap.Height * Plot.ClientSize.Height / 100f));

            Size IppSize = new Size((int)(chart_SFCW_ipp0.Width * CaSize.Width / 100f),
            (int)(chart_SFCW_ipp0.Height * CaSize.Height / 100f));

            // we need to use the smaller side:
            int ippNewSide = Math.Min(IppSize.Width, IppSize.Height);

            // calculate the scaling factors
            float px = chart_SFCW_ipp0.Width / IppSize.Width * ippNewSide;
            float py = chart_SFCW_ipp0.Height / IppSize.Height * ippNewSide;

            // use one or the other:
            if (IppSize.Width < IppSize.Height)
                ca.InnerPlotPosition = new ElementPosition(chart_SFCW_ipp0.X, chart_SFCW_ipp0.Y, chart_SFCW_ipp0.Width, py);
            else
                ca.InnerPlotPosition = new ElementPosition(chart_SFCW_ipp0.X, chart_SFCW_ipp0.Y, px, chart_SFCW_ipp0.Height);
            /*
           double i =1.05*Plot.Height;
               Plot.Height = this.Height - chartoffset_y - 45;
               Plot.Width =(int)i;
            * */

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizer();
        }
        private void BUFFER_SIZE_ValueChanged(object sender, EventArgs e)
        {
            buffer1 = new Ring_buffer(receivers, Convert.ToInt16(BUFFER_SIZE.Value));
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            resizer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resizer();
        }
    }
}
/*
ChartArea ca = chart_SFCW_signal.ChartAreas[0];

// store the original value:
if (chart_SFCW_ipp0 == null)
{
chart_SFCW_ipp0 = ca.InnerPlotPosition;
}

// get the current chart area :
ElementPosition cap = ca.Position;

// get both area sizes in pixels:
Size CaSize = new Size((int)(cap.Width * chart_SFCW_signal.ClientSize.Width / 100f),
(int)(cap.Height * chart_SFCW_signal.ClientSize.Height / 100f));

Size IppSize = new Size((int)(chart_SFCW_ipp0.Width * CaSize.Width / 100f),
(int)(chart_SFCW_ipp0.Height * CaSize.Height / 100f));

// we need to use the smaller side:
int ippNewSide = Math.Min(IppSize.Width, IppSize.Height);

// calculate the scaling factors
float px = chart_SFCW_ipp0.Width / IppSize.Width * ippNewSide;
float py = chart_SFCW_ipp0.Height / IppSize.Height * ippNewSide;

// use one or the other:
if (IppSize.Width < IppSize.Height)
ca.InnerPlotPosition = new ElementPosition(chart_SFCW_ipp0.X, chart_SFCW_ipp0.Y, chart_SFCW_ipp0.Width, py);
else
ca.InnerPlotPosition = new ElementPosition(chart_SFCW_ipp0.X, chart_SFCW_ipp0.Y, px, chart_SFCW_ipp0.Height);
*/

/*
ChartArea ca = chart_SFCW_signal.ChartAreas[0];

// store the original value:
if (chart_SFCW_ipp0 == null)
{
chart_SFCW_ipp0 = ca.InnerPlotPosition;
}

// get the current chart area :
ElementPosition cap = ca.Position;

// get both area sizes in pixels:
Size CaSize = new Size((int)(cap.Width * chart_SFCW_signal.ClientSize.Width / 100f),
(int)(cap.Height * chart_SFCW_signal.ClientSize.Height / 100f));

Size IppSize = new Size((int)(chart_SFCW_ipp0.Width * CaSize.Width / 100f),
(int)(chart_SFCW_ipp0.Height * CaSize.Height / 100f));

// we need to use the smaller side:
int ippNewSide = Math.Min(IppSize.Width, IppSize.Height);

// calculate the scaling factors
float px = chart_SFCW_ipp0.Width / IppSize.Width * ippNewSide;
float py = chart_SFCW_ipp0.Height / IppSize.Height * ippNewSide;

// use one or the other:
if (IppSize.Width < IppSize.Height)
ca.InnerPlotPosition = new ElementPosition(chart_SFCW_ipp0.X, chart_SFCW_ipp0.Y, chart_SFCW_ipp0.Width, py);
else
ca.InnerPlotPosition = new ElementPosition(chart_SFCW_ipp0.X, chart_SFCW_ipp0.Y, px, chart_SFCW_ipp0.Height);

 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * private void Chart_update()
        {
            double real;
            double imag;
            int bs = (int)BUFFER_SIZE.Value;
            Ts = new Complex[detectors_perch * receivers];
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("c" + "\n" + textBoxProbes.Text + "\n" + textBoxFreq.Text + "\n");
            }
            Detectors_readout();
            for (int i = 0; i < receivers; i++)
            {
                real = 0;     
                imag = 0;
                for (int x = 0; x < detectors_perch; x++)        
                {
                    real += mean[detectors_perch * i + x] * parameters1.a[x];
                    imag += mean[detectors_perch * i + x] * parameters1.b[x];
                }
                Ts[i] = new Complex(real, imag);
                
                    Plot.Series[i].Points.Clear();               
            }
            buffer1.insert(receivers,Ts);
            int t = buffer1.tail;
            Complex test;
            
            for (int i = 0; i < receivers; i++)
            {
                for (int x = 0; x < BUFFER_SIZE.Value; x++)
                {
                    if (offset_flag%2 == 0)
                    {
                        test = (buffer1.Ts_buffer[i, t] - Offset[i]) * Norm[i];
                    }
                    else {
                        test = (buffer1.Ts_buffer[i, t]) * Norm[i];
                    }
                    Plot.Series[i].Points.AddXY(test.Real, test.Imaginary);
                    t--;
                    t = (t % bs + bs) % bs;
                    
                }
            }
        }
*/