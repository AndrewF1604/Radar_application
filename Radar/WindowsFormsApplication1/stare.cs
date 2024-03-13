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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        long freq;
        int M;   //M-detektor
        int N;   //N-probki
        int receivers;
        double[,] p_meas;
        double[,] ADC_values;
        double[,] watts;
        Complex[] Ts;
        SerialPort serialPort1 = new SerialPort();
        Parameters parameters1 = new Parameters();
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
            M = Convert.ToInt16(cBoxDetectors.Text);
            N = Convert.ToInt32(textBoxProbes.Text);
            freq = Convert.ToInt64(textBoxFreq.Text);
            receivers = Convert.ToInt16(cBoxReceivers.Text);
            p_meas = new double[M, N];
            ADC_values = new double[M, N];
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
                long freq = Convert.ToInt64(textBoxFreq.Text);
                if (Convert.ToInt64(textBoxFreq.Text) > 500)
                    textBoxFreq.Text = "500";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }
        }
        public void Detectors_readout()
        {
            string tablica = textBox2.Text;
            int probes = Convert.ToInt16(textBoxProbes.Text);
            int detektory = HowMany(3, 4);
            ADC_values = new double[detektory, probes];
            p_meas = new double[detektory, probes];
            string[] posegregowany = tablica.Split(' ');
            for (int x = 0; x < detektory; x++)
            {
                for (int i = 0; i < probes; i++)
                {
                    ADC_values[x, i] = Convert.ToDouble(posegregowany[x + 1 + i + x * probes]);
                    p_meas[x, i] = (ADC_values[x, i] - 1700.0) / 39.0;
                }
            }
        }
        public void Watt()
        {
            int detektory = HowMany(3, 4);
            int probes = Convert.ToInt16(textBoxProbes.Text);
            watts = new double[detektory, probes];
            for (int x = 0; x < detektory; x++)
            {
                for (int i = 0; i < probes; i++)
                {
                    watts[x, i] = Math.Pow(10, (p_meas[x, i]) / 10);
                }
            }
        }
        public int HowMany(int receivers, int detectors)
        {
            return receivers * detectors;
        }
        private void READ_Click(object sender, EventArgs e)
        {
            Detectors_readout();
            Watt();
            textBox1.Text = Convert.ToString(watts[1, 1]);
        }
        private void SEND_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Set();
                string data = textBox1.Text;
                serialPort1.Write("c" + "\n" + textBoxProbes.Text + "\n" + textBoxFreq.Text + "\n");
                string dane = serialPort1.ReadLine();
                textBox2.Text = dane;
            }
        }
        private void SAVE_Click(object sender, EventArgs e)
        {
                Detectors_readout();
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = @"C:\Users\Andrzejek\source\repos\WinFormsApp3\WinFormsApp3",
                RestoreDirectory = true,
                FileName = "dane.txt",
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int probes = Convert.ToInt16(textBoxProbes.Text);
                int detektory = HowMany(3, 4);

                System.IO.Stream fileStream = sfd.OpenFile();
                System.IO.StreamWriter sw = new System.IO.StreamWriter(fileStream);
                for (int x = 0; x < detektory; x++)
                {
                    for (int i = 0; i < probes; i++)
                    {
                        sw.Write(Math.Round(p_meas[x, i], Convert.ToInt16(cBoxRounding.Text)).ToString().Replace(',','.'));
                        if(i < probes - 1)
                            sw.Write("\t");
                    }
                    if (x < detektory-1)
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
                InitialDirectory = @"C:\Users\Andrzejek\source\repos\WinFormsApp3\WinFormsApp3"
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
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOM.Items.AddRange(ports);
        }
        private void IDEAL_Click(object sender, EventArgs e)
        {
            double[] tempa = new double[receivers];
            double[] tempb = new double[receivers];
            double[] tempq = new double[receivers];
            double[] temp0 = { 0 };
            for (int m = 0; m < receivers; m++)
            {
                double phi;
                phi = -(double)m / receivers * 2 * Math.PI + Math.PI;
                dataGridView_SFCW_cal_params.Rows.Add();
                dataGridView_SFCW_cal_params.Rows[m].Cells[0].Value = Math.Round(Math.Cos(phi), 15); // real[Ai] a 
                dataGridView_SFCW_cal_params.Rows[m].Cells[1].Value = Math.Round(Math.Sin(phi), 15); // imag[Ai] b
                dataGridView_SFCW_cal_params.Rows[m].Cells[2].Value = 1.0 / receivers; // qi q
            }
            dataGridView_SFCW_cal_params.Rows[0].Cells[3].Value = 0; // real[A0]   a0
            dataGridView_SFCW_cal_params.Rows[0].Cells[4].Value = 0; // imag[A0]   b0

            for (int i = 0; i < receivers; i++)
            {
                tempa[i] = (double)dataGridView_SFCW_cal_params.Rows[i].Cells[0].Value;
                parameters1.a = tempa;
            }
            for (int i = 0; i < receivers; i++)
            {
                tempb[i] = (double)dataGridView_SFCW_cal_params.Rows[i].Cells[1].Value;
                parameters1.b = tempb;
            }
            for (int i = 0; i < receivers; i++)
            {
                tempq[i] = (double)dataGridView_SFCW_cal_params.Rows[i].Cells[1].Value;
                parameters1.b = tempq;
            }
            parameters1.a0 = temp0;
            parameters1.b0 = temp0;
            textBox1.Text = Convert.ToString(parameters1.a[1]);
        }
        private void DRAW_Click(object sender, EventArgs e)
        {
            Watt();
            int probes = Convert.ToInt16(textBoxProbes.Text);
            double[] mean = new double[HowMany(3,4)];
            double real;
            double imag;
            Ts = new Complex[receivers];
            for (int x= 0; x < HowMany(3, 4); x++)
            {
                for(int i=0; i < probes; i++)
                {
                    mean[x] += watts[x, i];
                }
                mean[x] = mean[x] / probes;
            }
            for(int i=0; i<receivers;i++)
            {
                real = 0;
                imag = 0;
                for (int x = 0; x < 3; x++)
                {
                    real += mean[x] * parameters1.a[x];
                    imag += mean[x] * parameters1.b[x];
                }
                Ts[i] = new Complex(real, imag);
            }
            textBox1.Text = Convert.ToString(mean[0]);
            textBox2.Text = Convert.ToString(Ts[0]);
            Plot.Series["Series1"].Points.AddXY(Ts[0].Real, Ts[0].Imaginary);
        }
    }
}
