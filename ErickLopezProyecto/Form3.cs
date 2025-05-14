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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private double EvaluarPolinomio(double a, double b, double c, double d, double x)
        {
            return a * x * x * x + b * x * x + c * x + d;
        }
        private double? BuscarRaizReal(double a, double b, double c, double d, double min, double max, double tolerancia = 1e-6, int maxIter = 100)
        {
            double fMin = EvaluarPolinomio(a, b, c, d, min);
            double fMax = EvaluarPolinomio(a, b, c, d, max);

            if (fMin * fMax > 0)
                return null; // No hay cambio de signo ⇒ no hay raíz en el intervalo

            for (int i = 0; i < maxIter; i++)
            {
                double mid = (min + max) / 2;
                double fMid = EvaluarPolinomio(a, b, c, d, mid);

                if (Math.Abs(fMid) < tolerancia)
                    return mid;

                if (fMin * fMid < 0)
                {
                    max = mid;
                    fMax = fMid;
                }
                else
                {
                    min = mid;
                    fMin = fMid;
                }
            }

            return (min + max) / 2; // aproximación final
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double d = Convert.ToDouble(textBox4.Text);

                if (a == 0)
                {
                    textBox5.Text = "No es una ecuación cúbica (a no puede ser 0).";
                    return;
                }

                // Buscar una raíz real entre -100 y 100
                double? raiz = BuscarRaizReal(a, b, c, d, -100, 100);

                if (raiz.HasValue)
                {
                    textBox5.Text = $"Raíz real aproximada: x ≈ {raiz.Value:F6}";
                }
                else
                {
                    textBox5.Text = "No se encontró una raíz real en el intervalo [-100, 100].";
                }
            }
            catch (FormatException)
            {
                textBox5.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form v4 = new Form4();
            v4.Show();
        }
    }
}

