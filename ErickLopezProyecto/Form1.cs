namespace ErickLopezProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double x;

                if (a == 0)
                {
                    if (b == 0)
                    {
                        textBox3.Text = "La ecuaci�n tiene infinitas soluciones.";
                    }
                    else
                    {
                        textBox3.Text = "La ecuaci�n no tiene soluci�n.";
                    }
                }
                else
                {
                    x = -b / a;
                    textBox3.Text = "La soluci�n es x = " + x.ToString();
                }
            }
            catch (FormatException)
            {
                textBox3.Text = "Por favor, ingrese valores num�ricos v�lidos.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form v2 = new Form2();
            v2.Show();
        }
    }
}

