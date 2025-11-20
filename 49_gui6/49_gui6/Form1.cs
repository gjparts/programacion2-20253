namespace _49_gui6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
            //evento que sucede cuando marca/desmarca a check1
            if (check1.Checked == true)
                label1.Text = "check1 está marcado";
            else
                label1.Text = "check1 está desmarcado";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //evento que sucede al carga el formulario en pantalla
            //mandar a llamar la funcion para el evento CheckedChanged de check1:
            check1_CheckedChanged(sender, e);

            //llenar el combobox con frutas
            frutas.Items.Clear(); //limpiar los items que ya estaban en el combobox
            frutas.Items.Add("Manzana");
            frutas.Items.Add("Pera");
            frutas.Items.Add("Sandia");
            frutas.Items.Add("Kiwi");
            frutas.Items.Add("Banana");
            frutas.Items.Add("Melón");
            frutas.Items.Add("Naranja");
            frutas.Items.Add("Ciruela");
            //colocar el primer item como seleccionado:
            frutas.SelectedIndex = 0;
            //configurar combo1 para que no se pueda escribir libremente en el:
            frutas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El valor de check1 es {check1.Checked}");
        }

        private void frutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //evento que sucede al pedir un item de la lista en el combobox frutas
            //obtener los valores y el indice del item seleccionado y ponerlos
            //en diferentes label:
            label2.Text = $"Indice: {frutas.SelectedIndex}";
            label3.Text = $"Valor: {frutas.Text}";

            //si selecciona Kiwi el fondo será verde, sino se regresa al de fabrica
            if (frutas.Text == "Kiwi")
                this.BackColor = Color.DarkOliveGreen;
            else
                this.BackColor = Control.DefaultBackColor;
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            frutas.Text = "Sandia";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            frutas.SelectedIndex = 5;
        }
    }
}
