namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.graf1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCal = new System.Windows.Forms.Button();
            this.graf2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.TB_T = new System.Windows.Forms.TextBox();
            this.TB_N = new System.Windows.Forms.TextBox();
            this.TB_P = new System.Windows.Forms.TextBox();
            this.LB_Valor = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graf1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // graf1
            // 
            this.graf1.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.graf1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.graf1.Legends.Add(legend1);
            this.graf1.Location = new System.Drawing.Point(672, 80);
            this.graf1.Name = "graf1";
            this.graf1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Enabled = false;
            series1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graf1.Series.Add(series1);
            this.graf1.Size = new System.Drawing.Size(600, 300);
            this.graf1.SuppressExceptions = true;
            this.graf1.TabIndex = 0;
            this.graf1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.graf1.Titles.Add(title1);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(423, 134);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(203, 75);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Calcular";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // graf2
            // 
            chartArea2.Name = "ChartArea1";
            this.graf2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.graf2.Legends.Add(legend2);
            this.graf2.Location = new System.Drawing.Point(672, 434);
            this.graf2.Name = "graf2";
            this.graf2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Enabled = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graf2.Series.Add(series2);
            this.graf2.Size = new System.Drawing.Size(600, 300);
            this.graf2.TabIndex = 2;
            this.graf2.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TB_P);
            this.groupBox1.Controls.Add(this.TB_N);
            this.groupBox1.Controls.Add(this.TB_T);
            this.groupBox1.Controls.Add(this.TB_A);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(26, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 650);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 75);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 75);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 73);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serie de Fourier";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Arial Black", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(674, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senoide:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Arial Black", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(674, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harmonico:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(423, 456);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 75);
            this.button3.TabIndex = 9;
            this.button3.Text = "Creditos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amplitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tau (τ):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 38);
            this.label6.TabIndex = 2;
            this.label6.Text = "Periodo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "N:";
            // 
            // TB_A
            // 
            this.TB_A.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_A.Location = new System.Drawing.Point(31, 116);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(286, 46);
            this.TB_A.TabIndex = 4;
            // 
            // TB_T
            // 
            this.TB_T.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.TB_T.Location = new System.Drawing.Point(31, 257);
            this.TB_T.Name = "TB_T";
            this.TB_T.Size = new System.Drawing.Size(286, 46);
            this.TB_T.TabIndex = 5;
            // 
            // TB_N
            // 
            this.TB_N.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.TB_N.Location = new System.Drawing.Point(31, 537);
            this.TB_N.Name = "TB_N";
            this.TB_N.Size = new System.Drawing.Size(286, 46);
            this.TB_N.TabIndex = 6;
            // 
            // TB_P
            // 
            this.TB_P.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.TB_P.Location = new System.Drawing.Point(31, 398);
            this.TB_P.Name = "TB_P";
            this.TB_P.Size = new System.Drawing.Size(286, 46);
            this.TB_P.TabIndex = 7;
            this.TB_P.TextChanged += new System.EventHandler(this.TB_P_TextChanged);
            // 
            // LB_Valor
            // 
            this.LB_Valor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Valor.FormattingEnabled = true;
            this.LB_Valor.ItemHeight = 20;
            this.LB_Valor.Location = new System.Drawing.Point(1291, 80);
            this.LB_Valor.Name = "LB_Valor";
            this.LB_Valor.Size = new System.Drawing.Size(181, 644);
            this.LB_Valor.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Arial Black", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(1283, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 48);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LB_Valor);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.graf2);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.graf1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Serie de Fourier ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.graf1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graf2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graf1;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TB_P;
        private System.Windows.Forms.TextBox TB_N;
        private System.Windows.Forms.TextBox TB_T;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.ListBox LB_Valor;
        private System.Windows.Forms.Label label8;
    }
}

