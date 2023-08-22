using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Controlador;


namespace Vista
{
    public partial class frmConsume : Form
    {
        public frmConsume()
        {
            InitializeComponent();
        }

        classConsume ObjConsume = new classConsume();
        

        private void frmConsume_Load(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\Sea\");

            ObjConsume.escribirFichero("");

            foreach (var fi in di.GetFiles())
            {
                var destinoArchivo = ObjConsume.moverFichero(di.FullName, fi.Name.Replace(".txt", ""));
                ObjConsume.Abrir_Archivo(destinoArchivo, fi.Name.Replace(".txt", ""));
            }

            FinalizeComponent();
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            
        }


    }
}
