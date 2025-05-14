using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ErickLopezProyecto
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(textBox1.Text);
            double k = Convert.ToDouble(textBox2.Text);
            double a = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);

            textBox5.Clear();

            for (double x = h - 10 * a; x <= h + 10 * a; x += 0.5)
            {
                double xTerm = ((x - h) * (x - h)) / (a * a);
                double ySquare = b * b * (xTerm - 1);

                if (ySquare >= 0)
                {
                    double y1 = k + Math.Sqrt(ySquare);
                    double y2 = k - Math.Sqrt(ySquare);

                    textBox5.AppendText($"x = {x:F2}, y1 = {y1:F2}, y2 = {y2:F2}{Environment.NewLine}");
                }
            }

            if (textBox5.Text == "")
            {
                textBox5.Text = "No hay valores reales para y en el intervalo.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form v5 = new Form5();
            v5.Show();
        }
    }
}

