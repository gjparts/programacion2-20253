namespace _44_gui1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            //Evento click de boton1
            MessageBox.Show("Ha hecho click en el boton1");
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caja.Text);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Evento que se ejecuta antes de dibujar el Form en pantalla
            MessageBox.Show("Bienvenido");
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            //Evento que sucede cuanto ya se ha dibujado el Form en pantalla
            MessageBox.Show("Un gusto saludarle");
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Adios.");
        }
    }
}
