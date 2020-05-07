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
    public partial class FrmPrincipal : Form
    {
        private Pelicula unaPeli;
        private  List<string> listaItems;

        public FrmPrincipal()
        {
            InitializeComponent();
            listaItems = new List<string>();
        }

        private void btn_cargarNuevo_Click(object sender, EventArgs e)
        {
            FrmAlta formAlta = new FrmAlta();
            DialogResult resultado = formAlta.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                rtb_mostrarLista.Clear();
                listaItems.Add(formAlta.Mensaje);
                foreach (string item in listaItems)
                {
                    rtb_mostrarLista.Text += item + "\n";
                }
            }
            else
            {
                MessageBox.Show("Evento cancelado");
            }
        }

        private void bt_altaPeliculas_Click(object sender, EventArgs e)
        {
            FrmSolicitud solicitud = new FrmSolicitud();

            DialogResult resultado = solicitud.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.unaPeli = solicitud.RetornarPelicula();
                richTextBox1.Text = unaPeli.ToString();
            }
            else if (resultado == DialogResult.Cancel)
            {
                MessageBox.Show("se canceló con exito");
            }
            else
                MessageBox.Show("Informacion Incorrecta.Proceso abortado. Validar la informacion y reintentar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!(unaPeli is null))
                {
                FrmSolicitud modificacion = new FrmSolicitud();
                modificacion.SetCamposModificar(this.unaPeli);
                DialogResult resultado = modificacion.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.unaPeli = modificacion.RetornarPelicula();
                    richTextBox1.Text = unaPeli.ToString();
                }
                else if (resultado == DialogResult.Cancel)
                {
                    MessageBox.Show("se canceló con exito");
                }
                else
                    MessageBox.Show("Informacion Incorrecta.Proceso abortado. Validar la informacion y reintentar");
            }
            else
            {
                MessageBox.Show("No hay pelicula que modificar.Primero cargue una nueva");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPadre formularioPadre = new FrmPadre();
            formularioPadre.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmHijo formularioHijo = new FrmHijo();
            formularioHijo.Show();
        }
    }
}
