using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            graf1.Series.Clear();
            graf2.Series.Clear();


            LB_Valor.Items.Clear();


            graf1.Series.Add("Senoide");
            graf1.Series.Add("Ponto");


            graf2.Series.Add("Barra");

            graf1.Series["Senoide"].ChartType = SeriesChartType.Spline;
            graf1.Series["Ponto"].ChartType = SeriesChartType.Point;
            graf2.Series["Barra"].ChartType = SeriesChartType.Column;


            int A = int.Parse(TB_A.Text);
            int TAL = int.Parse(TB_T.Text);
            int P = int.Parse(TB_P.Text);

            int N = int.Parse(TB_N.Text);


            int A0 = (A * TAL) / P;

            graf1.Series["Senoide"].Points.AddXY(0, A0);
            graf1.Series["Ponto"].Points.AddXY(0, A0);
            graf2.Series["Barra"].Points.AddXY(0, A0);
            LB_Valor.Items.Add("0º N = " + A0.ToString());

            for (int i = 1; i < N + 1; i++)
            {
                double An = ((2 * A) / (i * Math.PI)) * Math.Sin((i * Math.PI * TAL) / P);
                graf1.Series["Senoide"].Points.AddXY(i, An);
                graf1.Series["Ponto"].Points.AddXY(i, An);
                graf2.Series["Barra"].Points.AddXY(i, An);
                if (Math.Round(An, 2) == 0)
                {
                    LB_Valor.Items.Add(i + "º N = " + (Math.Round(An, 2)).ToString());
                }
                else
                {
                    LB_Valor.Items.Add(i + "º N = " + (2 * A).ToString() + "/" + i + "π");
                }

            }

        }

        private void TB_P_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LB_Valor.Items.Clear();
            TB_A.Clear();
            TB_N.Clear();
            TB_P.Clear();
            TB_T.Clear();
            graf1.Series.Clear();
            graf2.Series.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nichollas de Farias Leonides dos Santos, RA: 182348\nNickolas de Souza Silveira Correia, RA: 185823\nVictor Rico Moura Santos, RA: 191068\nGeovanne Pelozone Nery, RA: 185335​", "Integrantes:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo);


            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
