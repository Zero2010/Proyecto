using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class FrmPrincipal : Form
    {

        public Maestra maestra = new Maestra();
        public FrmUsuario usuario = new FrmUsuario();

        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmUsuario Frmusuario = new FrmUsuario();
            Frmusuario.MdiParent = this;
            Frmusuario.Show();
        }
    }
}
