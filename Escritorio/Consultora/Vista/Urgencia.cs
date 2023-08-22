using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class Urgencia : Form
    {
        Controlador.Estados.Urgencia urgencia = new Controlador.Estados.Urgencia();
        string[] cadena;
        string[] respuesta;
        string OptionUrgencia;

        public Urgencia()
        {
            InitializeComponent();
        }

        private void Urgencia_Load(object sender, EventArgs e)
        {

            cadena = urgencia.motivourgencia();

            OptionUrgencia = "";

            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 4; i < respuesta.Length; i++)
                {
                    OptionUrgencia += respuesta[4] + "|";
                    break;
                }
            }

            int y = 20;
            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 2; i < respuesta.Length; i++)
                {
                    RadioButton radio = new RadioButton();
                    radio.AutoSize = true;
                    radio.Name = respuesta[1];
                    radio.Text = respuesta[3] + " - " +respuesta[4];
                    radio.Location = new Point(20, y);
                    groupBox1.Controls.Add(radio);
                    y = radio.Bounds.Bottom + 1;
                    break;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (var item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    var tb = item as RadioButton;
                    if (tb.Checked == true)
                    {
                        Global.RespuestaIdUrgencia = Convert.ToInt16(tb.Name);
                        Global.RespuestaSerie = Convert.ToInt16(tb.Name);
                        var Letra = tb.Text.Split('-');
                        Global.RespuestaLetra = Letra[0];
                        Global.numeroUrgencia = txtNumero.Text;
                        //Global.RespuestaSerie;
                        count++;
                    }
                }
            }

            if (count != 0)
            {
                this.Hide();
                this.Close();
            }


        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Form sesion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Principal").SingleOrDefault<Form>();
            if (sesion != null)
            {
                sesion.WindowState = FormWindowState.Normal;
                sesion.BringToFront();
                this.Hide();
                this.Close();
            }
            else
            {
                Principal principal = new Principal();
                principal.Show();
                this.Hide();
                this.Close();
            }
        }
    }
}
