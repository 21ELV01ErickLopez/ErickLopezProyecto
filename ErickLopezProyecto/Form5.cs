using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErickLopezProyecto
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(textBox1.Text);
                double k = Convert.ToDouble(textBox2.Text);
                double a = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox4.Text);

                if (a == 0 || b == 0)
                {
                    MessageBox.Show("Los valores de a y b deben ser diferentes de cero.");
                    return;
                }
                textBox5.Clear();
                for (double x = h - a; x <= h + a; x += 0.5)
                {
                    double xTerm = ((x - h) * (x - h)) / (a * a);
                    double ySquare = b * b * (1 - xTerm);

                    if (ySquare >= 0)
                    {
                        double y1 = k + Math.Sqrt(ySquare);
                        double y2 = k - Math.Sqrt(ySquare);

                        textBox5.AppendText($"x = {x:F2}, y1 = {y1:F2}, y2 = {y2:F2}{Environment.NewLine}");
                    }
                }

                if (textBox5.Text == "")
                {
                    textBox5.Text = "No se encontraron valores reales para y.";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form v6 = new Form6();
            v6.Show();
        }
    }
}

