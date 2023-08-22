using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Configuration;
using System.IO;

namespace Vista
{
    public partial class Configuracion : Form
    {

        Principal principal = new Principal();
        Controlador.Estados.Transmicion transmicion = new Controlador.Estados.Transmicion();

        string[] cadena;
        string[] respuesta;
        string OptionTransmitir;

        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciatatencion = new IniciarSesion();
            //no permite que el formulario se abra dos veces si este esta activo.
            if (Application.OpenForms["IniciarSesion"] != null)
            {
                this.Hide();
                iniciatatencion.Show();
            }
            else
            {
                this.Hide();
                iniciatatencion.Show();
            }
        }

        private void btnIniciarAtencion_Click(object sender, EventArgs e)
        {
            Form sesion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Principal").SingleOrDefault<Form>();
            if (sesion != null)
            {
                sesion.WindowState = FormWindowState.Normal;
                sesion.BringToFront();
                sesion.Show();
                this.Hide();
            }
            else
            {
                principal.Show();
                this.Hide();
            }
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void btnTransmitir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(@"C:\Consultora\envio\"))
                {
                    string[] archivos = System.IO.Directory.GetFiles(@"C:\Consultora\envio\");

                    foreach (var a in archivos)
                    {
                        string[] cadena;
                        cadena = transmicion.motivotransmicion(a);
                        OptionTransmitir = "";
                        foreach (var item in cadena)
                        {
                            respuesta = item.ToString().Split('|');

                            for (int i = 2; i < respuesta.Length; i++)
                            {
                                OptionTransmitir += respuesta[2] + "|";
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
