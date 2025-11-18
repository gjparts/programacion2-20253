namespace _46_gui3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonSumar_Click(object sender, EventArgs e)
        {
            try
            {
                //declarar variables numericas para poder hacer las operaciones
                double a, b, c;
                //recuperar el texto de cada TextBox y colocarlo en cada variable numerica
                a = Double.Parse(caja1.Text);
                b = Double.Parse(caja2.Text);
                //hacer la operacion:
                c = a + b;
                //colocar el resultado en la caja de texto respectiva:
                total.Text = c.ToString();
            }
            catch (Exception ex)
            {
                total.Text = "ERROR";
                MessageBox.Show("Solo se acepta números");
            }
        }
    }
}
