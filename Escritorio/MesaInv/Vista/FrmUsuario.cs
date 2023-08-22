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
    public partial class FrmUsuario : Form
    {

        Usuario usu             = new Usuario();
        private int respuesta   = 0;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Shown(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            respuesta = usu.ValidarUsuario(txtUsuario.Text, txtContrasena.Text);

            if (respuesta == 1){
                MessageBox.Show("Bienvenido al sistema");
            }
            else {
                MessageBox.Show("Usuario Ingresado no existe...");
            }

        }
    }
}
