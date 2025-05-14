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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double m = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                textBox3.Clear();

                for (double x = -10; x <= 10; x += 1)
                {
                    double y = m * x + b;
                    textBox3.AppendText($"x = {x:F2}, y = {y:F2}{Environment.NewLine}");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form v9 = new Form9();
            v9.Show();
        }
    }
}
