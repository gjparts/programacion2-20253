namespace _47_gui4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //variables de trabajo
                double a, b, c, x1, x2;
                //extraer los datos de las cajas de texto:
                a = Double.Parse(caja1.Text);
                b = Double.Parse(caja2.Text);
                c = Double.Parse(caja3.Text);
                //Hacer las operaciones
                //a no puede ser CERO
                if (a == 0)
                    MessageBox.Show("el valor de a no puede ser cero.");
                else
                {
                    //discriminante no puede ser cero
                    double disciminante = Math.Pow(b, 2) - 4 * a * c;
                    if( disciminante < 0)
                        MessageBox.Show("Discriminante negativo, no podemos continuar.");
                    else
                    {
                        x1 = (-b + Math.Sqrt(disciminante)) / (2*a);
                        x2 = (-b - Math.Sqrt(disciminante)) / (2 * a);

                        //redondear a 4 decimales:
                        x1 = Math.Round(x1, 4);
                        x2 = Math.Round(x2, 4);

                        //mostrar resultado en cajas de texto respectivas:
                        sol1.Text = x1.ToString();
                        sol2.Text = x2.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                sol1.Text = "ERROR";
                sol2.Text = "ERROR";
                MessageBox.Show("Solo se permite números.");
            }
        }
    }
}
