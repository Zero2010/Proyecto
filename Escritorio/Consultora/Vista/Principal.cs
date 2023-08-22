using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;


namespace Vista
{
    public partial class Principal : Form, IForm
    {
        Controlador.Cryptography seguridad = new Controlador.Cryptography();
        Controlador.AtencionesTxt txt = new Controlador.AtencionesTxt();
        Controlador.Transaction transaccion = new Controlador.Transaction();
        Controlador.ValidacionRut Vrut = new Controlador.ValidacionRut();
        Controlador.FPrincipal Formulario = new Controlador.FPrincipal();
        Stopwatch relojAtencion = new Stopwatch();
        Stopwatch relojLlego = new Stopwatch();

        Controlador.Estados.Ejecutivo ejecutivo = new Controlador.Estados.Ejecutivo();
        Controlador.Estados.Sucursal sucursal = new Controlador.Estados.Sucursal();
        Controlador.Metodos.Metodos metodos = new Controlador.Metodos.Metodos();
        Controlador.Servicio.Respaldo.Respaldo respaldo = new Controlador.Servicio.Respaldo.Respaldo();

        Controlador.Configuracion configuracion = new Controlador.Configuracion();
        Controlador.Estados.NumeroUrgencia numeroUrgencia = new Controlador.Estados.NumeroUrgencia();
        public string RespuestaSerie { get; set; }

        public int IdSerie;
        public string Descripcion;
        public string Letra;
        int numero =0;

        string[] cadena;
        string[] respuesta;
        string[] motivo;

        string verificarRut;

        public string Mensaje;
        public bool Respuesta;

        private Timer ti;
        public static Principal Fprincipal;

        public Principal()
        {
            InitializeComponent();

            cboTelefono.SelectionChangeCommitted += cboTelefono_SelectionChangeCommitted; // Registro al evento

            // Añadir Items
            cboTelefono.DataSource = Formulario.Telefono().ToList();// Cargar valores del enum
            cboTelefono.DisplayMember = "Value"; // Mostramos Value del Ditionary
            cboTelefono.ValueMember = "Key"; // Retornamos Key al SeletedValue

            Principal.Fprincipal = this;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Form sesion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "IniciarSesion").SingleOrDefault<Form>();
            if (sesion != null)
            {
                sesion.WindowState = FormWindowState.Normal;
                sesion.BringToFront();
            }
            else
            {
                IniciarSesion habilitarsesion = new IniciarSesion();
                habilitarsesion.Show();
            }
        }

        private void btnExcepción_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizarAtencion_Click(object sender, EventArgs e)
        {
            Finalizar finalizar = new Finalizar();
            string respuesta = metodos.IsNumeric(txtTelefono.Text);

            if (txtNumero.Text != "" && txtRut.Text != "" && respuesta != "False" && lblLetra.Text != "")
            {
                //no permite que el formulario se abra dos veces si este esta activo.
                if (Application.OpenForms["Finalizar"] != null)
                {
                    Application.OpenForms["Finalizar"].Activate();
                }
                else
                {
                    btnLlego.Enabled = true;
                    Global.HFin = toolStripStatusLabel1.Text;
                    Global.HFin = Global.HFin.Replace("La hora es : ", "").Trim();

                    int validacion= numeroUrgencia.GenerarNumero(Convert.ToString(Global.RespuestaSerie), Global.RespuestaLetra, @"C:\Consultora\Envio\ATE.txt", txtNumero.Text,2);

                    if (validacion == -1)
                    {
                        MessageBox.Show("¡Este Número ya había sido Ingresado!");
                    }
                    else
                    {
                        finalizar.ShowDialog(this);
                        Global.ATE = ("ATE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + Global.RespuestaSerie + "~" + configuracion.idEscritorio + "~" + configuracion.idEje + "~" + txtNumero.Text + "~" + Global.HInicio + "~" + Global.HFin + "~" + txtRut.Text + "~" + txtTelefono.Text + "~");
                        respaldo.GenerarRespaldo(Global.ATE, "ATE");

                        foreach (var item in Global.txtfinalizar)
                        {
                            motivo = item.Split(';');
                            Global.MOT = ("MOT" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + Global.RespuestaSerie + "~" + txtNumero.Text + "~" + motivo[0] + "~" + motivo[1]);
                            respaldo.GenerarRespaldo(Global.MOT, "MOT");
                        }
                        numero = Convert.ToInt16(txtNumero.Text);

                        if (numero < 0)
                        {
                            Global.URG = (Global.RespuestaSerie + ";" + txtNumero.Text);
                            respaldo.GenerarRespaldo(Global.URG, "URG");
                            numeroUrgencia.GenerarNumero(Convert.ToString(Global.RespuestaSerie), Global.RespuestaLetra, @"C:\Consultora\NumeroUrgencia", txtNumero.Text, 3);
                        }

                        if (btnInicioAtencion.Enabled==false)
                        {
                            btnInicioAtencion.Enabled = true;
                        }
                    }

                    btnVolver.Enabled = true;

                }
            }
            else if (txtNumero.Text == "")
            {
                lblErrorRut.Text = "Debe Ingresar un Número";
                txtNumero.Focus();
            }
            else if (txtRut.Text == "")
            {
                lblErrorRut.Text = "Debe Ingresar un Rut";
                txtRut.Focus();
            }
            else if (respuesta == "False")
            {
                lblErrorRut.Text = "Debe Ingresar un Teléfono";
                txtTelefono.Focus();
            }
            else if (lblLetra.Text == "")
            {
                lblErrorRut.Text = "Ingrese una Letra de Atención";
                lblLetra.Focus();
            }

            if (BtnEstado.Text == "Atendiendo")
            {
                if (txtNumero.Text != "" && txtRut.Text != "" && respuesta != "False" && lblLetra.Text != "")
                {
                    btnFinalizarAtencion.Enabled = false;
                    btnLlego.Enabled = true;
                    btnAnular.Enabled = true;
                    btnExcepción.Enabled = false;
                    lblLlamadoNumero.Text = "ESPERANDO";
                    lblEstadoAtencion.Visible = true;
                    subpanelAtencion.Enabled = false;
                    Limpiar();
                }
            }
            else if (BtnEstado.Text == "Pausa")
            {
                btnFinalizarAtencion.Enabled = false;
                btnLlego.Enabled = false;
                lblLlamadoNumero.Text = "PAUSA";
                lblEstadoAtencion.Visible = true;
                subpanelAtencion.Enabled = false;
                btnVolver.Visible = true;
                btnExcepción.Enabled = true;
                btnInicioAtencion.Enabled = true;
                Limpiar();
            }
        }

        private void btnllego_Click(object sender, EventArgs e)
        {
            lblTiempoAtencion.Text = "00:00:00";
            relojLlego.Start();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.txtNumero.Focus();

            cadena = ejecutivo.nombreEjecutivo();

            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 1; i < respuesta.Length; i++)
                {
                    lblEjecutivo.Text = respuesta[1];
                    break;
                }
            }


            cadena = sucursal.nombreSucursal();

            foreach (var item in cadena)
            {
                respuesta = item.ToString().Split('|');

                for (int i = 1; i < respuesta.Length; i++)
                {
                    lblOficina.Text = respuesta[1];
                    break;
                }
            }
            //Inicio aplicacion
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            ti.Enabled = true;

            Global.HInicio = DateTime.Now.ToString("hh:mm:ss tt");
            Global.EJE = ("EJE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + configuracion.idEje + "~" + configuracion.idEscritorio + "~" + "I" + "~" + Global.HInicio.Replace("La hora es : ", "").Trim() + "~" );
            respaldo.GenerarRespaldo(Global.EJE, "EJE");
 
            //pausa aplicacion
            Global.HInicio = DateTime.Now.ToString("hh:mm:ss tt");
            Global.EJE = ("EJE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + configuracion.idEje + "~" + configuracion.idEscritorio + "~" + "P" + "~" + Global.HInicio.Replace("La hora es : ", "").Trim() + "~" );
            respaldo.GenerarRespaldo(Global.EJE, "EJE");

            panelMenu.Enabled = true;
            //botones bloqueados
            btnAnular.Enabled = false;
            btnFinalizarAtencion.Enabled = false;
            btnLlego.Enabled = false;
            lblLlamadoNumero.Text = "PAUSA";
            lblLlamadoNumero.ForeColor = Color.Red;
            cboTelefono.Enabled = true;
            btnVolver.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_Validated(object sender, EventArgs e)
        {
            txtRut.Text = Vrut.formatearRut(txtRut.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                btnSerie.Focus();
            }
            else
               if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtLetra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                lblLetra.Text = lblLetra.Text.ToUpper();
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                lblLetra.Text = lblLetra.Text.ToUpper();
                e.Handled = false;
            }
            else
            {
                lblLetra.Text = lblLetra.Text.ToUpper();
                e.Handled = true;
            }
        }

        private void txtLetra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar ==13)
            {
                verificarRut = Vrut.SepararRut(txtRut.Text);

                if (verificarRut == "False")
                {
                    lblErrorRut.Text = "<--- ¡Rut Ingresado no es válido!";
                    txtRut.Text = ""; txtRut.Focus();
                }
                else if (verificarRut == "True")
                {
                    lblErrorRut.Text = "";
                    transaccion.Ingreso(txtRut.Text, txtTelefono.Text, txtNumero.Text);
                    txtTelefono.Focus();
                }
                else if (verificarRut != "True" && verificarRut != "False")
                {
                    txtRut.Text = "";
                    txtRut.Focus();
                    lblErrorRut.Text = verificarRut;
                }
            }
        }

        private void txtTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cboTelefono_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cboTelefono_Click(object sender, EventArgs e)
        {

        }

        private void btnPausa_Click(object sender, EventArgs e)
        {
            Pausa pausa = new Pausa();
            //no permite que el formulario se abra dos veces si este esta activo.
            if (Application.OpenForms["Pausa"] != null)
            {
                Application.OpenForms["Pausa"].Activate();
            }
            else
            {
                pausa.ShowDialog(this);
                Global.HInicio = toolStripStatusLabel1.Text;
                Global.EJE = ("EJE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + configuracion.idEje + "~" + configuracion.idEscritorio + "~" + "P" + "~" + Global.HInicio.Replace("La hora es : ", "").Trim() + "~" + Global.RespuestaIdPausa);
                //Global.EstadosEjecutivo = new string[] { Global.EJE };
                respaldo.GenerarRespaldo(Global.EJE, "EJE");

                panelMenu.Enabled = true;
                //botones bloqueados
                btnAnular.Enabled = false;
                btnFinalizarAtencion.Enabled = false;
                btnLlego.Enabled = false;
                lblLlamadoNumero.Text = "PAUSA";
                lblLlamadoNumero.ForeColor = Color.Red;
                cboTelefono.Enabled = true;
                btnExcepción.Enabled = true;
                btnVolver.Visible = true;

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IniciarAtencion_Tick(object sender, EventArgs e)
        {

        }

        private void btnInicioAtencion_Click(object sender, EventArgs e)
        {
            if (!relojAtencion.IsRunning)
            {
                lblTiempoEspera.Text = "00:00:00";
                relojAtencion.Start();
                BtnEstado.BackColor=Color.Green;
                BtnEstado.Text = "Atendiendo";

                btnFinalizarAtencion.Enabled = false;
                btnLlego.Enabled = true;
                btnAnular.Enabled = true;
                btnExcepción.Enabled = false;
                lblLlamadoNumero.Text = "ESPERANDO";
                lblLlamadoNumero.ForeColor = Color.Green;
            }
            Global.HInicio = toolStripStatusLabel1.Text;
            Global.EJE = ("EJE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + configuracion.idEje + "~" + configuracion.idEscritorio + "~" + "A" + "~" + Global.HInicio.Replace("La hora es : ", "").Trim() + "~");
            respaldo.GenerarRespaldo(Global.EJE, "EJE");

            //menus bloqueados
            //subpanelAtencion.Enabled = true;
            txtNumero.Focus();
            btnPausa.Enabled = true;
            txtNumero.Enabled = true;
            txtNumero.Focus();
            btnSerie.Enabled = true;
        }

        private void lblTiempoEspera_Click(object sender, EventArgs e)
        {

        }

        private void txtLetra_KeyDown(object sender, KeyEventArgs e)
        {
            lblLetra.Text = lblLetra.Text.ToUpper();
        }

        private void txtLetra_KeyUp(object sender, KeyEventArgs e)
        {
            lblLetra.Text = lblLetra.Text.ToUpper();
        }

        private void Llego_Tick(object sender, EventArgs e)
        {
           
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTelefono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {

        }

        public void ChangeButton(int estado, string[] TipoPausa)
        {
            if (estado==1)
            {
                BtnEstado.BackColor = Color.Green;
                BtnEstado.Text = "Iniciado";
                BtnEstado.ForeColor = Color.White;                
            }
            else
            {
                BtnEstado.BackColor = Color.Red;
                BtnEstado.Text = "Pausa";
                BtnEstado.ForeColor = Color.White;
            }
        }


        private void txtRut_TabIndexChanged(object sender, EventArgs e)
        {
                verificarRut = Vrut.SepararRut(txtRut.Text);

                if (verificarRut == "False")
                {
                    lblErrorRut.Text = "<--- ¡Rut Ingresado no es válido!";
                    txtRut.Text = ""; txtRut.Focus();
                }
                else if (verificarRut == "True")
                {
                    lblErrorRut.Text = "";
                    transaccion.Ingreso(txtRut.Text, txtTelefono.Text, txtNumero.Text);
                }
                else if (verificarRut != "True" && verificarRut != "False")
                {
                    txtRut.Text = "";
                    txtRut.Focus();
                    lblErrorRut.Text = verificarRut;
                }
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

        private void btnllego_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFinalizarAtencion_Click_1(object sender, EventArgs e)
        {

            FinalizarAtencion finalizaratencion = new FinalizarAtencion();
            string respuesta = metodos.IsNumeric(txtTelefono.Text);//NumericString.IsNumeric(edad.Text);
            string ATE, MOT, EJE;

            if (txtNumero.Text != "" && txtRut.Text != "" && respuesta != "False" && lblLetra.Text != "")
            {
                //no permite que el formulario se abra dos veces si este esta activo.
                if (Application.OpenForms["FinalizarAtencion"] != null)
                {
                    Application.OpenForms["FinalizarAtencion"].Activate();
                }
                else
                {
                    Global.HFin = toolStripStatusLabel1.Text.Replace("La hora es: ", "");
                    finalizaratencion.Show(this);
                    ATE = ("ATE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + IdSerie + "~" + configuracion.idEscritorio + "~" + configuracion.idEje + "~" + txtNumero.Text );
                    MOT = ("MOT" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + IdSerie + "~" + txtNumero.Text);
                    EJE = ("EJE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + configuracion.idEje + "~" + configuracion.idEscritorio);
                    //respaldo.GenerarRespaldo(ATE, MOT, EJE);
                }
            }
            else if (txtNumero.Text == "")
            {
                lblErrorRut.Text = "Debe Ingresar un Número";
                txtNumero.Focus();

            }
            else if (txtRut.Text == "")
            {
                lblErrorRut.Text = "Debe Ingresar un Rut";
                txtRut.Focus();
            }
            else if (respuesta == "False")
            {
                lblErrorRut.Text = "Debe Ingresar un Teléfono";
                txtTelefono.Focus();
            }
            else if (lblLetra.Text == "")
            {
                lblErrorRut.Text = "Debe Ingresar una Letra de Atención";
                lblLetra.Focus();
            }

        }

        private void btnExcepción_Click_1(object sender, EventArgs e)
        {
            Urgencia urgencia = new Urgencia();

            //no permite que el formulario se abra dos veces si este esta activo.
            if (Application.OpenForms["Urgencia"] != null)
            {
                Application.OpenForms["Urgencia"].Activate();
            }
            else
            {
                urgencia.ShowDialog(this);
                if (Global.numeroUrgencia == "0")
                {
                    lblLetra.Text = Global.RespuestaLetra;
                    subpanelAtencion.Enabled = true;
                    btnSerie.Enabled = false;
                    txtNumero.Enabled = false;
                    txtNumero.Text = Convert.ToString(numeroUrgencia.GenerarNumero(Convert.ToString(Global.RespuestaSerie), Global.RespuestaLetra, @"C:\Consultora\NumeroUrgencia\","",1) );

                    if (txtNumero.Text=="0")
                    {
                        Global.URG = (Global.RespuestaSerie + ";" + "-1");
                        respaldo.GenerarRespaldo(Global.URG, "URG");
                        txtNumero.Text = "-1";
                    }

                    txtRut.Focus();
                    btnFinalizarAtencion.Enabled = true;
                    btnInicioAtencion.Enabled = false;
                    //lblLlamadoNumero.Visible = false;
                    btnExcepción.Enabled = false;
                }
                else
                {
                    btnExcepción.Enabled = false;
                    lblLetra.Text = Global.RespuestaLetra;
                    subpanelAtencion.Enabled = true;
                    btnSerie.Enabled = false;
                    txtNumero.Enabled = false;
                    txtNumero.Text = Global.numeroUrgencia;
                    txtRut.Focus();
                    btnFinalizarAtencion.Enabled = true;
                    btnInicioAtencion.Enabled = false;
                    //lblEstadoEmisor.Visible = false;
                }


            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            toolStripStatusLabel1.Text = "La hora es : " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }

        private void btnSerie_Click(object sender, EventArgs e)
        {
            Serie serie = new Serie();
            //no permite que el formulario se abra dos veces si este esta activo.
            if (Application.OpenForms["Serie"] != null)
            {
                Application.OpenForms["Serie"].Activate();
            }
            else
            {
                serie.ShowDialog(this);
            }

            lblLetra.Text = Global.RespuestaLetra;
            IdSerie = Global.RespuestaSerie;
            txtRut.Focus();

        }

        private void btnLlego_Click(object sender, EventArgs e)
        {
            Global.HInicio = toolStripStatusLabel1.Text;
            Global.HInicio = Global.HInicio.Replace("La hora es : ", "").Trim();
            btnLlego.Enabled = false;
            btnAnular.Enabled = false;
            btnFinalizarAtencion.Enabled = true;
            lblLlamadoNumero.Text = "ATENDIENDO";
            lblLlamadoNumero.ForeColor = Color.Green;
            subpanelAtencion.Enabled = true;
            txtNumero.Focus();
            btnVolver.Visible = false;

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtNumero.Text = "";
            lblLetra.Text = "";
            txtRut.Text = "";
            txtTelefono.Text = "";
            lblErrorRut.Text = "";
            txtNumero.Focus();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.HInicio = toolStripStatusLabel1.Text;
            Global.EJE = ("EJE" + "~" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "~" + configuracion.idEje + "~" + configuracion.idEscritorio + "~" + "F" + "~" + Global.HInicio.Replace("La hora es : ", "").Trim() + "~" );
            respaldo.GenerarRespaldo(Global.EJE, "EJE");

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                var validacion = metodos.validarTelefono(txtTelefono.Text);

                if (validacion == 1)
                {
                    lblErrorRut.Text = "";
                    btnFinalizarAtencion.Focus();
                }
                else if (validacion == -1)
                {
                    lblErrorRut.Text = "<--- ¡Teléfono Incompleto!";
                    txtTelefono.Text = "";
                    txtTelefono.Focus();
                }

            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
