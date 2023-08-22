using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class IniciarSesion : Form
    {

        Controlador.Configuracion datoConexion = new Controlador.Configuracion();
        Controlador.Servidor.Servidor servidor = new Controlador.Servidor.Servidor();
        string respuesta;
        

        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            //no permite que el formulario se abra dos veces si este esta activo.
            if (Application.OpenForms["Configuracion"] != null)
            {
                this.Hide();
                configuracion.Show();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            respuesta = "";
            datoConexion.Usuario = txtEjecutivo.Text;
            datoConexion.Contrasenia = txtContrasenia.Text;
            respuesta = servidor.Conectar(txtEjecutivo.Text, txtContrasenia.Text);
            Configuracion configuracion = new Configuracion();

            if (respuesta == "ok")
            {
                MessageBox.Show("Respaldo Realizado con Exito");
                configuracion.Show();
                this.Hide();
            }
            else if(respuesta!= null && respuesta != "ok" && respuesta != "")
            {
                MessageBox.Show(respuesta);
                txtEjecutivo.Focus();
                txtContrasenia.Text = "";
                txtEjecutivo.Text = "";
            }
            else if (respuesta == "" || respuesta==null)
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
                txtEjecutivo.Focus(); txtContrasenia.Text = "";
                txtEjecutivo.Text = "";
            }
        }

        private void cboLimpiar_Click(object sender, EventArgs e)
        {
            txtEjecutivo.Text = "";
            txtContrasenia.Text = "";
            txtEjecutivo.Focus();
        }
    }
}
