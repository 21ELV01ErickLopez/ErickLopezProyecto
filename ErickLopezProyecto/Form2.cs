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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de a, b y c desde los TextBox
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);

                // Calcular el discriminante
                double discriminante = b * b - 4 * a * c;

                if (a == 0)
                {
                    textBox4.Text = "El valor de 'a' no puede ser 0 para una ecuación cuadrática.";
                    return;
                }

                if (discriminante > 0)
                {
                    // Dos soluciones reales diferentes
                    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    textBox4.Text = $"Las soluciones son: x1 = {x1}, x2 = {x2}";
                }
                else if (discriminante == 0)
                {
                    // Una solución real (doble)
                    double x = -b / (2 * a);
                    textBox4.Text = $"La solución es: x = {x}";
                }
                else
                {
                    // Soluciones complejas
                    double realParte = -b / (2 * a);
                    double imaginarioParte = Math.Sqrt(-discriminante) / (2 * a);
                    textBox4.Text = $"Las soluciones son complejas: x1 = {realParte} + {imaginarioParte}i, x2 = {realParte} - {imaginarioParte}i";
                }
            }
            catch (FormatException)
            {
                textBox4.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form v3 = new Form3();
            v3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

