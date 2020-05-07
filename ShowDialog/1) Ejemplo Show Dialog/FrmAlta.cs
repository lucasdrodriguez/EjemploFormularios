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
    public partial class FrmAlta : Form
    {
        string mensaje;
        public FrmAlta()
        {
            InitializeComponent();
        }

        public string Mensaje
        {
            get { return this.mensaje; }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            mensaje = textBox1.Text;
            if (Mensaje != string.Empty)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("no puede dejar el campo vacio");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
