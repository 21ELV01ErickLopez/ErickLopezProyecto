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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double h = Convert.ToDouble(textBox1.Text);
                double k = Convert.ToDouble(textBox2.Text);
                double r = Convert.ToDouble(textBox3.Text);

                if (r <= 0)
                {
                    MessageBox.Show("El radio debe ser mayor que cero.");
                    return;
                }

                textBox4.Clear();

                for (double x = h - r; x <= h + r; x += 0.5)
                {
                    double xTerm = Math.Pow(x - h, 2);
                    double yTerm = r * r - xTerm;

                    if (yTerm >= 0)
                    {
                        double y1 = k + Math.Sqrt(yTerm);
                        double y2 = k - Math.Sqrt(yTerm);

                        textBox4.AppendText($"x = {x:F2}, y1 = {y1:F2}, y2 = {y2:F2}{Environment.NewLine}");
                    }
                }

                if (textBox4.Text == "")
                    textBox4.Text = "No hay puntos reales para la circunferencia.";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
            }
        }
    }
}
