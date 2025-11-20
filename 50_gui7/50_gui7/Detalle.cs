using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50_gui7
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            //marcar el formulario como que se hizo click en el boton Aceptar
            this.DialogResult = DialogResult.OK;
            //cerrar el formulario sin destruirlo
            this.Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            //marcar el formulario como que se hizo click en el boton Cancelar
            this.DialogResult = DialogResult.Cancel;
            //cerrar el formulario sin destruirlo
            this.Close();
        }
    }
}
