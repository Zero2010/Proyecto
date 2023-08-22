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
    public partial class Pausa : Form
    {

        Controlador.Pausa pausa = new Controlador.Pausa();
        string[] cadena;
        string[] respuesta;
        string OptionPause;

        public Pausa()
        {
            InitializeComponent();
        }

        private void cboPausa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pausa_Load(object sender, EventArgs e)
        {
            cadena = pausa.motivosPausa();

            OptionPause = "";
            //OptionPause = "--Seleccione Opción--|";
            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 2; i < respuesta.Length; i++)
                {
                    OptionPause += respuesta[2] + "|";
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
                    radio.Text = respuesta[2];
                    radio.Location = new Point(20, y);
                    groupBox1.Controls.Add(radio);
                    y = radio.Bounds.Bottom + 1;
                }
            }


        }

        private void Aceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int count =0;

            foreach (var item in groupBox1.Controls)
            {
                if (item is RadioButton)
                {
                    var tb = item as RadioButton;
                    if (tb.Checked == true)
                    {
                        Global.RespuestaIdPausa = Convert.ToInt16(tb.Name);
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