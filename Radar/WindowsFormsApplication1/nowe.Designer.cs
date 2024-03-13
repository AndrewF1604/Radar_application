namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series51 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series52 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series53 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series54 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LOAD = new System.Windows.Forms.Button();
            this.DRAW = new System.Windows.Forms.Button();
            this.IDEAL = new System.Windows.Forms.Button();
            this.cBoxCOM = new System.Windows.Forms.ComboBox();
            this.cBoxBR = new System.Windows.Forms.ComboBox();
            this.cBoxRounding = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BUFF_SIZE = new System.Windows.Forms.Label();
            this.BUFFER_SIZE = new System.Windows.Forms.NumericUpDown();
            this.textBoxDetectors = new System.Windows.Forms.TextBox();
            this.textBoxReceivers = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PROBES = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ROUNDING = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.Label();
            this.textBoxProbes = new System.Windows.Forms.TextBox();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.BR = new System.Windows.Forms.Label();
            this.SAVE = new System.Windows.Forms.Button();
            this.dataGridView_SFCW_cal_params = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SCALE = new System.Windows.Forms.NumericUpDown();
            this.cBoxINTERVAL = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUFFER_SIZE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SFCW_cal_params)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCALE)).BeginInit();
            this.SuspendLayout();
            // 
            // LOAD
            // 
            this.LOAD.Location = new System.Drawing.Point(724, 4);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(75, 23);
            this.LOAD.TabIndex = 4;
            this.LOAD.Text = "LOAD";
            this.LOAD.UseVisualStyleBackColor = true;
            this.LOAD.Click += new System.EventHandler(this.LOAD_Click);
            // 
            // DRAW
            // 
            this.DRAW.Location = new System.Drawing.Point(202, 316);
            this.DRAW.Name = "DRAW";
            this.DRAW.Size = new System.Drawing.Size(75, 23);
            this.DRAW.TabIndex = 5;
            this.DRAW.Text = "DRAW";
            this.DRAW.UseVisualStyleBackColor = true;
            this.DRAW.Click += new System.EventHandler(this.DRAW_Click);
            // 
            // IDEAL
            // 
            this.IDEAL.Location = new System.Drawing.Point(724, 35);
            this.IDEAL.Name = "IDEAL";
            this.IDEAL.Size = new System.Drawing.Size(75, 23);
            this.IDEAL.TabIndex = 6;
            this.IDEAL.Text = "IDEAL";
            this.IDEAL.UseVisualStyleBackColor = true;
            this.IDEAL.Click += new System.EventHandler(this.IDEAL_Click);
            // 
            // cBoxCOM
            // 
            this.cBoxCOM.FormattingEnabled = true;
            this.cBoxCOM.Location = new System.Drawing.Point(96, 30);
            this.cBoxCOM.Name = "cBoxCOM";
            this.cBoxCOM.Size = new System.Drawing.Size(121, 24);
            this.cBoxCOM.TabIndex = 7;
            // 
            // cBoxBR
            // 
            this.cBoxBR.FormattingEnabled = true;
            this.cBoxBR.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.cBoxBR.Location = new System.Drawing.Point(96, 60);
            this.cBoxBR.Name = "cBoxBR";
            this.cBoxBR.Size = new System.Drawing.Size(121, 24);
            this.cBoxBR.TabIndex = 8;
            this.cBoxBR.Text = "115200";
            // 
            // cBoxRounding
            // 
            this.cBoxRounding.FormattingEnabled = true;
            this.cBoxRounding.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cBoxRounding.Location = new System.Drawing.Point(96, 210);
            this.cBoxRounding.Name = "cBoxRounding";
            this.cBoxRounding.Size = new System.Drawing.Size(121, 24);
            this.cBoxRounding.TabIndex = 11;
            this.cBoxRounding.Text = "15";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BUFF_SIZE);
            this.groupBox1.Controls.Add(this.BUFFER_SIZE);
            this.groupBox1.Controls.Add(this.textBoxDetectors);
            this.groupBox1.Controls.Add(this.textBoxReceivers);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PROBES);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ROUNDING);
            this.groupBox1.Controls.Add(this.COM);
            this.groupBox1.Controls.Add(this.textBoxProbes);
            this.groupBox1.Controls.Add(this.textBoxFreq);
            this.groupBox1.Controls.Add(this.cBoxRounding);
            this.groupBox1.Controls.Add(this.BR);
            this.groupBox1.Controls.Add(this.cBoxCOM);
            this.groupBox1.Controls.Add(this.cBoxBR);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 275);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // BUFF_SIZE
            // 
            this.BUFF_SIZE.AutoSize = true;
            this.BUFF_SIZE.Location = new System.Drawing.Point(8, 240);
            this.BUFF_SIZE.Name = "BUFF_SIZE";
            this.BUFF_SIZE.Size = new System.Drawing.Size(81, 17);
            this.BUFF_SIZE.TabIndex = 24;
            this.BUFF_SIZE.Text = "BUFF_SIZE";
            // 
            // BUFFER_SIZE
            // 
            this.BUFFER_SIZE.Location = new System.Drawing.Point(97, 240);
            this.BUFFER_SIZE.Name = "BUFFER_SIZE";
            this.BUFFER_SIZE.Size = new System.Drawing.Size(120, 22);
            this.BUFFER_SIZE.TabIndex = 20;
            this.BUFFER_SIZE.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BUFFER_SIZE.ValueChanged += new System.EventHandler(this.BUFFER_SIZE_ValueChanged);
            // 
            // textBoxDetectors
            // 
            this.textBoxDetectors.Location = new System.Drawing.Point(97, 120);
            this.textBoxDetectors.Name = "textBoxDetectors";
            this.textBoxDetectors.Size = new System.Drawing.Size(100, 22);
            this.textBoxDetectors.TabIndex = 23;
            this.textBoxDetectors.Text = "3";
            this.textBoxDetectors.TextChanged += new System.EventHandler(this.textBoxFreq_TextChanged);
            this.textBoxDetectors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDetectors_KeyPress);
            // 
            // textBoxReceivers
            // 
            this.textBoxReceivers.Location = new System.Drawing.Point(97, 92);
            this.textBoxReceivers.Name = "textBoxReceivers";
            this.textBoxReceivers.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceivers.TabIndex = 22;
            this.textBoxReceivers.Text = "4";
            this.textBoxReceivers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxReceivers_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 34);
            this.label6.TabIndex = 20;
            this.label6.Text = "Detectors\r\nper_channel";
            // 
            // PROBES
            // 
            this.PROBES.AutoSize = true;
            this.PROBES.Location = new System.Drawing.Point(20, 181);
            this.PROBES.Name = "PROBES";
            this.PROBES.Size = new System.Drawing.Size(65, 17);
            this.PROBES.TabIndex = 21;
            this.PROBES.Text = "PROBES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Receivers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Freq[kHz]";
            // 
            // ROUNDING
            // 
            this.ROUNDING.AutoSize = true;
            this.ROUNDING.Location = new System.Drawing.Point(6, 213);
            this.ROUNDING.Name = "ROUNDING";
            this.ROUNDING.Size = new System.Drawing.Size(83, 17);
            this.ROUNDING.TabIndex = 19;
            this.ROUNDING.Text = "ROUNDING";
            // 
            // COM
            // 
            this.COM.AutoSize = true;
            this.COM.Location = new System.Drawing.Point(20, 30);
            this.COM.Name = "COM";
            this.COM.Size = new System.Drawing.Size(39, 17);
            this.COM.TabIndex = 15;
            this.COM.Text = "COM";
            // 
            // textBoxProbes
            // 
            this.textBoxProbes.Location = new System.Drawing.Point(96, 178);
            this.textBoxProbes.Name = "textBoxProbes";
            this.textBoxProbes.Size = new System.Drawing.Size(100, 22);
            this.textBoxProbes.TabIndex = 15;
            this.textBoxProbes.Text = "5";
            this.textBoxProbes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxProbes_KeyPress);
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(96, 150);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(100, 22);
            this.textBoxFreq.TabIndex = 16;
            this.textBoxFreq.Text = "10";
            this.textBoxFreq.TextChanged += new System.EventHandler(this.textBoxFreq_TextChanged);
            this.textBoxFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFreq_KeyPress);
            // 
            // BR
            // 
            this.BR.AutoSize = true;
            this.BR.Location = new System.Drawing.Point(20, 60);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(27, 17);
            this.BR.TabIndex = 16;
            this.BR.Text = "BR";
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(724, 64);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 23);
            this.SAVE.TabIndex = 17;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // dataGridView_SFCW_cal_params
            // 
            this.dataGridView_SFCW_cal_params.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SFCW_cal_params.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a,
            this.b,
            this.q,
            this.a0,
            this.b0});
            this.dataGridView_SFCW_cal_params.Location = new System.Drawing.Point(12, 327);
            this.dataGridView_SFCW_cal_params.Name = "dataGridView_SFCW_cal_params";
            this.dataGridView_SFCW_cal_params.RowTemplate.Height = 24;
            this.dataGridView_SFCW_cal_params.Size = new System.Drawing.Size(184, 132);
            this.dataGridView_SFCW_cal_params.TabIndex = 18;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            // 
            // q
            // 
            this.q.HeaderText = "q";
            this.q.Name = "q";
            // 
            // a0
            // 
            this.a0.HeaderText = "a0";
            this.a0.Name = "a0";
            // 
            // b0
            // 
            this.b0.HeaderText = "b0";
            this.b0.Name = "b0";
            // 
            // Plot
            // 
            chartArea7.Name = "ChartArea1";
            this.Plot.ChartAreas.Add(chartArea7);
            this.Plot.Location = new System.Drawing.Point(335, 138);
            this.Plot.Name = "Plot";
            this.Plot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series49.BorderWidth = 2;
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series49.Color = System.Drawing.Color.Black;
            series49.LabelForeColor = System.Drawing.Color.Gray;
            series49.Legend = "Legend1";
            series49.MarkerSize = 1;
            series49.Name = "Series1";
            series50.BorderWidth = 2;
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series50.Color = System.Drawing.Color.Blue;
            series50.Legend = "Legend1";
            series50.Name = "Series2";
            series51.BorderWidth = 2;
            series51.ChartArea = "ChartArea1";
            series51.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series51.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series51.Legend = "Legend1";
            series51.Name = "Series3";
            series52.BorderWidth = 2;
            series52.ChartArea = "ChartArea1";
            series52.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series52.Color = System.Drawing.Color.ForestGreen;
            series52.Legend = "Legend1";
            series52.Name = "Series4";
            series53.BorderWidth = 3;
            series53.ChartArea = "ChartArea1";
            series53.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series53.Color = System.Drawing.Color.Black;
            series53.MarkerSize = 8;
            series53.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series53.Name = "Series1_0";
            series54.BorderWidth = 2;
            series54.ChartArea = "ChartArea1";
            series54.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series54.Color = System.Drawing.Color.Blue;
            series54.MarkerSize = 8;
            series54.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series54.Name = "Series2_0";
            series55.BorderWidth = 4;
            series55.ChartArea = "ChartArea1";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series55.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series55.MarkerSize = 8;
            series55.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series55.Name = "Series3_0";
            series55.YValuesPerPoint = 2;
            series56.BorderWidth = 5;
            series56.ChartArea = "ChartArea1";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series56.Color = System.Drawing.Color.ForestGreen;
            series56.MarkerSize = 8;
            series56.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series56.Name = "Series4_0";
            this.Plot.Series.Add(series49);
            this.Plot.Series.Add(series50);
            this.Plot.Series.Add(series51);
            this.Plot.Series.Add(series52);
            this.Plot.Series.Add(series53);
            this.Plot.Series.Add(series54);
            this.Plot.Series.Add(series55);
            this.Plot.Series.Add(series56);
            this.Plot.Size = new System.Drawing.Size(557, 361);
            this.Plot.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "OFFSET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "NORM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SCALE
            // 
            this.SCALE.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SCALE.Location = new System.Drawing.Point(254, 7);
            this.SCALE.Name = "SCALE";
            this.SCALE.Size = new System.Drawing.Size(120, 22);
            this.SCALE.TabIndex = 23;
            this.SCALE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SCALE.ValueChanged += new System.EventHandler(this.SCALE_ValueChanged);
            // 
            // cBoxINTERVAL
            // 
            this.cBoxINTERVAL.FormattingEnabled = true;
            this.cBoxINTERVAL.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.cBoxINTERVAL.Location = new System.Drawing.Point(254, 35);
            this.cBoxINTERVAL.Name = "cBoxINTERVAL";
            this.cBoxINTERVAL.Size = new System.Drawing.Size(121, 24);
            this.cBoxINTERVAL.TabIndex = 25;
            this.cBoxINTERVAL.Text = "1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(459, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 493);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cBoxINTERVAL);
            this.Controls.Add(this.SCALE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.dataGridView_SFCW_cal_params);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IDEAL);
            this.Controls.Add(this.DRAW);
            this.Controls.Add(this.LOAD);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BUFFER_SIZE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SFCW_cal_params)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCALE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LOAD;
        private System.Windows.Forms.Button DRAW;
        private System.Windows.Forms.Button IDEAL;
        private System.Windows.Forms.ComboBox cBoxCOM;
        private System.Windows.Forms.ComboBox cBoxBR;
        private System.Windows.Forms.ComboBox cBoxRounding;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxProbes;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PROBES;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ROUNDING;
        private System.Windows.Forms.Label COM;
        private System.Windows.Forms.Label BR;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.DataGridView dataGridView_SFCW_cal_params;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn a0;
        private System.Windows.Forms.DataGridViewTextBoxColumn b0;
        private System.Windows.Forms.DataVisualization.Charting.Chart Plot;
        private System.Windows.Forms.TextBox textBoxDetectors;
        private System.Windows.Forms.TextBox textBoxReceivers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label BUFF_SIZE;
        private System.Windows.Forms.NumericUpDown BUFFER_SIZE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown SCALE;
        private System.Windows.Forms.ComboBox cBoxINTERVAL;
        private System.Windows.Forms.Button button3;
    }
}

