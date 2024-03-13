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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SEND = new System.Windows.Forms.Button();
            this.READ = new System.Windows.Forms.Button();
            this.LOAD = new System.Windows.Forms.Button();
            this.DRAW = new System.Windows.Forms.Button();
            this.IDEAL = new System.Windows.Forms.Button();
            this.cBoxCOM = new System.Windows.Forms.ComboBox();
            this.cBoxBR = new System.Windows.Forms.ComboBox();
            this.cBoxRounding = new System.Windows.Forms.ComboBox();
            this.cBoxDetectors = new System.Windows.Forms.ComboBox();
            this.cBoxReceivers = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PROBES = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ROUNDING = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.Label();
            this.textBoxProbes = new System.Windows.Forms.TextBox();
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.BR = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SAVE = new System.Windows.Forms.Button();
            this.dataGridView_SFCW_cal_params = new System.Windows.Forms.DataGridView();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SFCW_cal_params)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).BeginInit();
            this.SuspendLayout();
            // 
            // SEND
            // 
            this.SEND.Location = new System.Drawing.Point(386, 152);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(75, 23);
            this.SEND.TabIndex = 1;
            this.SEND.Text = "SEND";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // READ
            // 
            this.READ.Location = new System.Drawing.Point(481, 152);
            this.READ.Name = "READ";
            this.READ.Size = new System.Drawing.Size(75, 23);
            this.READ.TabIndex = 3;
            this.READ.Text = "READ";
            this.READ.UseVisualStyleBackColor = true;
            this.READ.Click += new System.EventHandler(this.READ_Click);
            // 
            // LOAD
            // 
            this.LOAD.Location = new System.Drawing.Point(765, 20);
            this.LOAD.Name = "LOAD";
            this.LOAD.Size = new System.Drawing.Size(75, 23);
            this.LOAD.TabIndex = 4;
            this.LOAD.Text = "LOAD";
            this.LOAD.UseVisualStyleBackColor = true;
            this.LOAD.Click += new System.EventHandler(this.LOAD_Click);
            // 
            // DRAW
            // 
            this.DRAW.Location = new System.Drawing.Point(562, 152);
            this.DRAW.Name = "DRAW";
            this.DRAW.Size = new System.Drawing.Size(75, 23);
            this.DRAW.TabIndex = 5;
            this.DRAW.Text = "DRAW";
            this.DRAW.UseVisualStyleBackColor = true;
            this.DRAW.Click += new System.EventHandler(this.DRAW_Click);
            // 
            // IDEAL
            // 
            this.IDEAL.Location = new System.Drawing.Point(765, 51);
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
            // cBoxDetectors
            // 
            this.cBoxDetectors.FormattingEnabled = true;
            this.cBoxDetectors.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cBoxDetectors.Location = new System.Drawing.Point(96, 120);
            this.cBoxDetectors.Name = "cBoxDetectors";
            this.cBoxDetectors.Size = new System.Drawing.Size(121, 24);
            this.cBoxDetectors.TabIndex = 12;
            this.cBoxDetectors.Text = "3";
            // 
            // cBoxReceivers
            // 
            this.cBoxReceivers.FormattingEnabled = true;
            this.cBoxReceivers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cBoxReceivers.Location = new System.Drawing.Point(96, 90);
            this.cBoxReceivers.Name = "cBoxReceivers";
            this.cBoxReceivers.Size = new System.Drawing.Size(121, 24);
            this.cBoxReceivers.TabIndex = 13;
            this.cBoxReceivers.Text = "4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PROBES);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ROUNDING);
            this.groupBox1.Controls.Add(this.COM);
            this.groupBox1.Controls.Add(this.textBoxProbes);
            this.groupBox1.Controls.Add(this.textBoxFreq);
            this.groupBox1.Controls.Add(this.cBoxReceivers);
            this.groupBox1.Controls.Add(this.cBoxRounding);
            this.groupBox1.Controls.Add(this.BR);
            this.groupBox1.Controls.Add(this.cBoxCOM);
            this.groupBox1.Controls.Add(this.cBoxDetectors);
            this.groupBox1.Controls.Add(this.cBoxBR);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 249);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Detectors";
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
            this.label3.Location = new System.Drawing.Point(20, 97);
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
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(96, 150);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(100, 22);
            this.textBoxFreq.TabIndex = 16;
            this.textBoxFreq.Text = "10";
            this.textBoxFreq.TextChanged += new System.EventHandler(this.textBoxFreq_TextChanged);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(329, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 144);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(539, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 125);
            this.textBox2.TabIndex = 16;
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(765, 80);
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
            this.dataGridView_SFCW_cal_params.Location = new System.Drawing.Point(51, 279);
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
            chartArea5.Name = "ChartArea1";
            this.Plot.ChartAreas.Add(chartArea5);
            this.Plot.Location = new System.Drawing.Point(434, 181);
            this.Plot.Name = "Plot";
            this.Plot.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Name = "Series1";
            this.Plot.Series.Add(series5);
            this.Plot.Size = new System.Drawing.Size(406, 249);
            this.Plot.TabIndex = 19;
            this.Plot.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 498);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.dataGridView_SFCW_cal_params);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IDEAL);
            this.Controls.Add(this.DRAW);
            this.Controls.Add(this.LOAD);
            this.Controls.Add(this.READ);
            this.Controls.Add(this.SEND);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SFCW_cal_params)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.Button READ;
        private System.Windows.Forms.Button LOAD;
        private System.Windows.Forms.Button DRAW;
        private System.Windows.Forms.Button IDEAL;
        private System.Windows.Forms.ComboBox cBoxCOM;
        private System.Windows.Forms.ComboBox cBoxBR;
        private System.Windows.Forms.ComboBox cBoxRounding;
        private System.Windows.Forms.ComboBox cBoxDetectors;
        private System.Windows.Forms.ComboBox cBoxReceivers;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.DataGridView dataGridView_SFCW_cal_params;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn a0;
        private System.Windows.Forms.DataGridViewTextBoxColumn b0;
        private System.Windows.Forms.DataVisualization.Charting.Chart Plot;
    }
}

