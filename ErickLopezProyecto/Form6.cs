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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double h = Convert.ToDouble(textBox2.Text);
                double k = Convert.ToDouble(textBox3.Text);

                textBox4.Clear();

                for (double x = h - 10; x <= h + 10; x += 0.5)
                {
                    double y = a * Math.Pow(x - h, 2) + k;
                    textBox4.AppendText($"x = {x:F2}, y = {y:F2}{Environment.NewLine}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa valores numéricos válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form v7 = new Form7();
            v7.Show();
        }
    }
}

