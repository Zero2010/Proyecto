using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Finalizar : Form
    {
        List<string> valores = new List<string>();
        Controlador.Estados.Motivo motivos = new Controlador.Estados.Motivo();
        string[] respuesta;

        CheckBox check = new CheckBox();
        TextBox texto = new TextBox();
        string chk, txt;

        public Finalizar()
        {
            InitializeComponent();
        }

        private void Finalizar_Load(object sender, EventArgs e)
        {
            var cadena = motivos.motivocierre();
            int y = 20;

            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 2; i < respuesta.Length; i++)
                {
                    check = new CheckBox();
                    check.AutoSize = true;
                    check.Name = respuesta[1];
                    check.Text = respuesta[2];
                    check.Location = new Point(20, y);
                    panel1.Controls.Add(check);

                    texto = new TextBox();
                    texto.AutoSize = true;
                    texto.Name = respuesta[1];
                    texto.Tag = "1";
                    texto.Text = texto.Tag.ToString();
                    texto.Location = new Point(300, y);
                    panel1.Controls.Add(texto);
                    y = texto.Bounds.Bottom + 1;
                    valores.Add(check.Name + "," + check.Text + "," + texto.Text);
                    break;
                }
            }
            //Global.txtfinalizar = valores.ToArray();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txt = "";
            chk = "";
            foreach (var item in panel1.Controls)
            {
                if (item is CheckBox)
                {
                    var tb = item as CheckBox;
                    if (tb.Checked == true)
                    {
                        chk = tb.Name;
                    }
                }

                if (item is TextBox)
                {
                    var l = item as TextBox;

                    if (l.Name == chk)
                    {
                        txt += l.Name + ";" + l.Text + "|";
                    }

                }
            }
            txt = txt.Remove(txt.Length - 1);
            Global.txtfinalizar = txt.Split('|');
            this.Hide();
            this.Close();
        }
    }
}
