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
    public partial class Serie : Form
    {
        //RadioButton radio = new RadioButton();
        Controlador.Estados.Urgencia serie = new Controlador.Estados.Urgencia();
        Controlador.Global global = new Controlador.Global();
        string[] cadena;
        string[] respuesta;
        string OptionSerie;
        
        public Serie()
        {
            InitializeComponent();
        }

        private void Serie_Load(object sender, EventArgs e)
        {
            cadena = serie.motivourgencia();

            OptionSerie = "";
            //OptionPause = "--Seleccione Opción--|";
            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 2; i < respuesta.Length; i++)
                {
                    OptionSerie += respuesta[2] + "|";
                    break;
                }
            }

            int y = 20;
            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 4; i < respuesta.Length; i++)
                {
                    RadioButton radio = new RadioButton();
                    radio.AutoSize = true;
                    radio.Name = respuesta[1];
                    radio.Text = respuesta[3] + "-" + respuesta[4];
                    radio.Location = new Point(20, y);
                    radio.Click += new EventHandler(Seleccionar_Click);
                    groupBox1.Controls.Add(radio);
                    y = radio.Bounds.Bottom + 1;
                    break;
                }

            }
        }

        void Seleccionar_Click(object sender, EventArgs e)
        {
            RadioButton radio= sender as RadioButton;

            var radioserie = radio.Text.Split('-');
            Global.RespuestaLetra = radioserie[0];
            Global.RespuestaSerie =Convert.ToInt16(radio.Name);
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            this.Close();

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
