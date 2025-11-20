namespace _50_gui7
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista1.Items.Clear(); //limpiar items que habia previamente
            lista1.Items.Add("Loro");
            lista1.Items.Add("Perro ovejero");
            lista1.Items.Add("Gato montés");
            lista1.Items.Add("Gato doméstico");
            lista1.Items.Add("Iguana");
        }

        private void agregar1_Click(object sender, EventArgs e)
        {
            //agregar a la lista lo que esta en caja
            //primero valide que la caja no sea un String en blanco
            if (caja.Text.Trim().Length > 0)
            {
                lista1.Items.Add(caja.Text);
                caja.Text = ""; //limpiar la caja de texto
            }
            else
                MessageBox.Show("Debe llenar la caja de texto.");
        }

        private void agregar2_Click(object sender, EventArgs e)
        {
            //Agregar a la lista lo que se escriba en el formulario Detalle
            //instanciar un nuevo objeto de clase Detalle
            Detalle d = new Detalle();
            d.ShowDialog(); //mostrar la ventana de detalle de forma MODAL (encima)

            //solo si hizo click en Aceptar se agrega a la lista:
            if (d.DialogResult == DialogResult.OK)
            {
                //Importante! En Detalle la caja de texto valor
                //debe tener su propiedad Modifiers como Public
                if (d.valor.Text.Trim().Length > 0)
                {
                    lista1.Items.Add(d.valor.Text);
                }
                else
                    MessageBox.Show("No se permite items en blanco.");
            }

            //destruir el objeto de Detalle de la memoria
            d.Dispose();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            //Verificar que se ha seleccionado un item en lista1
            if (lista1.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un item de la lista");
            else
            {
                //instanciar un nuevo objeto de clase Detalle
                Detalle d = new Detalle();
                //antes de dibujar el objeto llene la caja de texto valor
                //con el texto del item seleccionado en lista1
                d.valor.Text = lista1.Text;
                //dibujar el formulario Detalle
                d.ShowDialog();

                //si hizo click en Aceptar:
                if( d.DialogResult == DialogResult.OK)
                {
                    if (d.valor.Text.Trim().Length > 0)
                    {
                        //modificar el item seleccionado en lista1:
                        lista1.Items[lista1.SelectedIndex] = d.valor.Text;
                    }
                    else
                        MessageBox.Show("No se permite texto en blanco.");
                }

                //destruir el objeto Detalle
                d.Dispose();
            }
        }
    }
}
