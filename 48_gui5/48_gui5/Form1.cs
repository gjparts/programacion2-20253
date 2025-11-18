namespace _48_gui5
{
    public partial class Form1 : Form
    {
        //funcion para calcular:
        public void calcular()
        {
            try
            {
                double a, b, c, d, sumatoria;
                a = Double.Parse(caja1.Text);
                b = Double.Parse(caja2.Text);
                c = Double.Parse(caja3.Text);
                d = Double.Parse(caja4.Text);
                sumatoria = a + b + c + d;
                total.Text = sumatoria.ToString();
            }
            catch (Exception)
            {
                total.Text = "Solo se admite números";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void caja1_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void caja2_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void caja3_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void caja4_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }
    }
}
