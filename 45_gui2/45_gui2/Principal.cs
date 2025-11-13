namespace _45_gui2
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //Los MessageBox pausan la ejecución del código hasta que lo cierra
            MessageBox.Show("Hola estudiante");
            //cambiar el Text de etiqueta1:
            etiqueta1.Text = "Gerardo";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            //cambiar el titulo del Form
            //cuando nos referimos al Form actual usamos
            //el objeto this (clase actual)
            this.Text = "Ingenieria en Sistemas UNAH";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            //impedir la edición de la caja1
            //forma 1: deshabilitarla
            //caja1.Enabled = false;
            //forma 2: hacer la caja de solo lectura
            caja1.ReadOnly = true;
            //forma 3: ocultar la caja
            //caja1.Visible = false;
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            //permitir la edición de la caja1
            //forma 1: habilitarla
            //caja1.Enabled = true;
            //forma 2: quitar a la caja el solo lectura
            caja1.ReadOnly = false;
            //forma 3: mostrar la caja
            //caja1.Visible = true;
        }

        private void reloj1_Tick(object sender, EventArgs e)
        {
            //evento que ejecuta reloj1 cuando se cumple el interval
            //y se esta reptiendo cada tiempo establecido en interval
            etiqueta2.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt");
        }

        private void reloj2_Tick(object sender, EventArgs e)
        {
            //colocar un color de fondo al azar a etiqueta3
            //de acuerdo a un numero del 1 al 6
            //1 = rojo, 2 = verde, 3 = azul, 4 = amarillo, 5 = gris, 6 = naranja
            Random r = new Random();
            int color = r.Next(1,7);
            switch (color)
            {
                case 1: etiqueta3.BackColor = Color.Red; break;
                case 2: etiqueta3.BackColor = Color.Green; break;
                case 3: etiqueta3.BackColor = Color.Blue; break;
                case 4: etiqueta3.BackColor = Color.Yellow; break;
                case 5: etiqueta3.BackColor = Color.Gray; break;
                case 6: etiqueta3.BackColor = Color.Orange; break;
            }
        }
    }
}
