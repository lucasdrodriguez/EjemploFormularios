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
    public partial class FrmPadre : Form
    {
        public FrmPadre()
        {
            InitializeComponent();
        }

        protected void CambiarTitulo(string mensaje)
        {
            this.lb_mensaje.Text = mensaje;
        }
        protected void CambiarUrl(string url)
        {
            this.wmp_video.URL = url;
        }
        private void FrmPadre_Load(object sender, EventArgs e)
        {
            this.lb_mensaje.Text = "SI LUKE! ES ÉL! CREELO MAN! ÉL ES TU PADRE!!!";
            this.wmp_video.URL = "https://examenprog.000webhostapp.com/Ystp1.mp4";
        }
    }
}
