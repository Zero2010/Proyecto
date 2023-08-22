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
    public partial class FinalizarAtencion : Form
    {

        Controlador.Estados.Motivo motivos = new Controlador.Estados.Motivo();
        string[] cadena;
        string[] respuesta;
        string OptionMotivo;

        public FinalizarAtencion()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FinalizarAtencion_Load(object sender, EventArgs e)
        {
            cadena = motivos.motivocierre();
            int count = 0;

            OptionMotivo = "";
            Array.Sort(cadena,1,1);
            cadena.OrderBy(x => x);

            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 2; i < respuesta.Length; i++)
                {
                    OptionMotivo += respuesta[2] + "|";
                    break;
                }
            }

            foreach (var item in OptionMotivo.Remove(OptionMotivo.Length - 1).Split('|'))
            {
                count += 1;
                checkedListBox1.Items.Add(item);
            }
            checkedListBox1.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int i;
            int count = 0;
            for (i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                    count++;

                if (count > 1)
                {
                    MessageBox.Show("Solo Puede seleccionar 1 opción", "Advertencia...");
                    break;
                }
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

