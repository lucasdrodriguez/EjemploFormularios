using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowDialog
{
    public partial class FrmSolicitud : Form
    {
        string nombre;
        int año;
        string personajePrincipal;

        public FrmSolicitud()
        {
            InitializeComponent();
        }
      

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text) || string.IsNullOrEmpty(this.textBox3.Text) || !(int.TryParse(textBox2.Text, out this.año)))
            {
                this.DialogResult = DialogResult.Abort;
            }

            else
            {
                this.nombre = this.textBox1.Text;
                this.personajePrincipal = this.textBox3.Text;
                // el año ya fue asignado a la variable año en el int.tryParse  ;)
                       
                this.DialogResult = DialogResult.OK; // da cierre al form enviando el resultado OK al otro form.
            }
        }

        public Pelicula RetornarPelicula()
        {
            if (this.nombre == "")
                this.nombre = "Nombre Pelicula no declarado";
            if (this.personajePrincipal == "")
                this.personajePrincipal = "Personaje no declarado";

            return new Pelicula(this.nombre, this.año, this.personajePrincipal);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void SetCamposModificar(Pelicula info)
        {
            this.textBox1.Enabled = false;
            this.textBox1.Text = info.Nombre;
            this.textBox2.Text = info.Año.ToString();
            this.textBox3.Text = info.PersonajePrincipal;
            this.BackColor = Color.Pink;
            this.btnConfirmar.Text = "Modificar";

        }
    }
}
