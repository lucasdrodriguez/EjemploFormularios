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
    public partial class FrmHijo : FrmPadre
    {
        public FrmHijo()
        {
            InitializeComponent();
        }

        private void FrmHijo_Load(object sender, EventArgs e)
        {
            base.CambiarTitulo(" Dale luke...Podria ser peor... afloja amigo...");
            base.CambiarUrl("https://examenprog.000webhostapp.com/Ystp2.mp4");
        }

    }
}
