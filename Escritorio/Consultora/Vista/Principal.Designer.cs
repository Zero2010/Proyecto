namespace Vista
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnFinalizarAtencion = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelAtencion = new System.Windows.Forms.Panel();
            this.lblErrorRut = new System.Windows.Forms.Label();
            this.subpanelAtencion = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblLetra = new System.Windows.Forms.Label();
            this.btnSerie = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLlamadoNumero = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblEstadoAtencionOficina = new System.Windows.Forms.Label();
            this.lblEstadoAtencion = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTiempoAtencion = new System.Windows.Forms.Label();
            this.lblEsperaAtencion = new System.Windows.Forms.Label();
            this.lblTiempoEspera = new System.Windows.Forms.Label();
            this.lblEsperaOficina = new System.Windows.Forms.Label();
            this.lblEstado_Oficina = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEjecutivo = new System.Windows.Forms.Label();
            this.lblOficina = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnEstado = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTelefono = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnInicioAtencion = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.IniciarAtencion = new System.Windows.Forms.Timer(this.components);
            this.btnExcepción = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Hactual = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.btnLlego = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panelAtencion.SuspendLayout();
            this.subpanelAtencion.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRut
            // 
            this.txtRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(63, 39);
            this.txtRut.MaxLength = 12;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(115, 20);
            this.txtRut.TabIndex = 18;
            this.txtRut.TabStop = false;
            this.txtRut.TabIndexChanged += new System.EventHandler(this.txtRut_TabIndexChanged);
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(63, 13);
            this.txtNumero.MaxLength = 3;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(34, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TabStop = false;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // btnFinalizarAtencion
            // 
            this.btnFinalizarAtencion.Location = new System.Drawing.Point(7, 80);
            this.btnFinalizarAtencion.Name = "btnFinalizarAtencion";
            this.btnFinalizarAtencion.Size = new System.Drawing.Size(238, 33);
            this.btnFinalizarAtencion.TabIndex = 20;
            this.btnFinalizarAtencion.TabStop = false;
            this.btnFinalizarAtencion.Text = "Finalizar Atención";
            this.btnFinalizarAtencion.UseVisualStyleBackColor = true;
            this.btnFinalizarAtencion.Click += new System.EventHandler(this.btnFinalizarAtencion_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(126, 42);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(119, 32);
            this.btnAnular.TabIndex = 19;
            this.btnAnular.TabStop = false;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnVolver);
            this.panel5.Location = new System.Drawing.Point(271, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(420, 120);
            this.panel5.TabIndex = 15;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Green;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(10, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 33);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.TabStop = false;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelAtencion
            // 
            this.panelAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAtencion.Controls.Add(this.lblErrorRut);
            this.panelAtencion.Controls.Add(this.subpanelAtencion);
            this.panelAtencion.Location = new System.Drawing.Point(271, 125);
            this.panelAtencion.Name = "panelAtencion";
            this.panelAtencion.Size = new System.Drawing.Size(420, 160);
            this.panelAtencion.TabIndex = 14;
            // 
            // lblErrorRut
            // 
            this.lblErrorRut.AutoSize = true;
            this.lblErrorRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRut.ForeColor = System.Drawing.Color.Red;
            this.lblErrorRut.Location = new System.Drawing.Point(216, 72);
            this.lblErrorRut.Name = "lblErrorRut";
            this.lblErrorRut.Size = new System.Drawing.Size(0, 13);
            this.lblErrorRut.TabIndex = 10;
            // 
            // subpanelAtencion
            // 
            this.subpanelAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subpanelAtencion.Controls.Add(this.txtTelefono);
            this.subpanelAtencion.Controls.Add(this.lblLetra);
            this.subpanelAtencion.Controls.Add(this.btnSerie);
            this.subpanelAtencion.Controls.Add(this.btnLimpiar);
            this.subpanelAtencion.Controls.Add(this.lblTelefono);
            this.subpanelAtencion.Controls.Add(this.txtRut);
            this.subpanelAtencion.Controls.Add(this.txtNumero);
            this.subpanelAtencion.Controls.Add(this.lblRut);
            this.subpanelAtencion.Controls.Add(this.lblNumero);
            this.subpanelAtencion.Enabled = false;
            this.subpanelAtencion.Location = new System.Drawing.Point(10, 18);
            this.subpanelAtencion.Name = "subpanelAtencion";
            this.subpanelAtencion.Size = new System.Drawing.Size(200, 123);
            this.subpanelAtencion.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(63, 63);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(115, 20);
            this.txtTelefono.TabIndex = 26;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetra.ForeColor = System.Drawing.Color.Red;
            this.lblLetra.Location = new System.Drawing.Point(156, 15);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(2, 15);
            this.lblLetra.TabIndex = 25;
            // 
            // btnSerie
            // 
            this.btnSerie.Location = new System.Drawing.Point(102, 13);
            this.btnSerie.Name = "btnSerie";
            this.btnSerie.Size = new System.Drawing.Size(45, 20);
            this.btnSerie.TabIndex = 22;
            this.btnSerie.TabStop = false;
            this.btnSerie.Text = "Letra";
            this.btnSerie.UseVisualStyleBackColor = true;
            this.btnSerie.Click += new System.EventHandler(this.btnSerie_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(15, 93);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(13, 70);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 19;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(13, 42);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(24, 13);
            this.lblRut.TabIndex = 16;
            this.lblRut.Text = "Rut";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(13, 15);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 13);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Nº";
            // 
            // lblLlamadoNumero
            // 
            this.lblLlamadoNumero.AutoSize = true;
            this.lblLlamadoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamadoNumero.Location = new System.Drawing.Point(73, 42);
            this.lblLlamadoNumero.Name = "lblLlamadoNumero";
            this.lblLlamadoNumero.Size = new System.Drawing.Size(87, 20);
            this.lblLlamadoNumero.TabIndex = 8;
            this.lblLlamadoNumero.Text = "Llamando";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblEstadoAtencionOficina);
            this.panel3.Controls.Add(this.lblEstadoAtencion);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lblLlamadoNumero);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.lblTiempoAtencion);
            this.panel3.Controls.Add(this.lblEsperaAtencion);
            this.panel3.Controls.Add(this.lblTiempoEspera);
            this.panel3.Controls.Add(this.lblEsperaOficina);
            this.panel3.Controls.Add(this.lblEstado_Oficina);
            this.panel3.Location = new System.Drawing.Point(12, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 160);
            this.panel3.TabIndex = 13;
            // 
            // lblEstadoAtencionOficina
            // 
            this.lblEstadoAtencionOficina.AutoSize = true;
            this.lblEstadoAtencionOficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAtencionOficina.Location = new System.Drawing.Point(60, 18);
            this.lblEstadoAtencionOficina.Name = "lblEstadoAtencionOficina";
            this.lblEstadoAtencionOficina.Size = new System.Drawing.Size(147, 20);
            this.lblEstadoAtencionOficina.TabIndex = 15;
            this.lblEstadoAtencionOficina.Text = "Estado Atención:";
            // 
            // lblEstadoAtencion
            // 
            this.lblEstadoAtencion.AutoSize = true;
            this.lblEstadoAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoAtencion.ForeColor = System.Drawing.Color.Green;
            this.lblEstadoAtencion.Location = new System.Drawing.Point(53, 50);
            this.lblEstadoAtencion.Name = "lblEstadoAtencion";
            this.lblEstadoAtencion.Size = new System.Drawing.Size(0, 20);
            this.lblEstadoAtencion.TabIndex = 14;
            this.lblEstadoAtencion.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vista.Properties.Resources.alarm_clock;
            this.pictureBox3.Location = new System.Drawing.Point(136, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Vista.Properties.Resources.alarm_clock;
            this.pictureBox4.Location = new System.Drawing.Point(136, 73);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 16);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // lblTiempoAtencion
            // 
            this.lblTiempoAtencion.AutoSize = true;
            this.lblTiempoAtencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoAtencion.Location = new System.Drawing.Point(168, 74);
            this.lblTiempoAtencion.Name = "lblTiempoAtencion";
            this.lblTiempoAtencion.Size = new System.Drawing.Size(55, 15);
            this.lblTiempoAtencion.TabIndex = 11;
            this.lblTiempoAtencion.Text = "00:00:00";
            this.lblTiempoAtencion.Visible = false;
            // 
            // lblEsperaAtencion
            // 
            this.lblEsperaAtencion.AutoSize = true;
            this.lblEsperaAtencion.Location = new System.Drawing.Point(29, 76);
            this.lblEsperaAtencion.Name = "lblEsperaAtencion";
            this.lblEsperaAtencion.Size = new System.Drawing.Size(100, 13);
            this.lblEsperaAtencion.TabIndex = 10;
            this.lblEsperaAtencion.Text = "Espera de Atención";
            this.lblEsperaAtencion.Visible = false;
            // 
            // lblTiempoEspera
            // 
            this.lblTiempoEspera.AutoSize = true;
            this.lblTiempoEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoEspera.Location = new System.Drawing.Point(167, 55);
            this.lblTiempoEspera.Name = "lblTiempoEspera";
            this.lblTiempoEspera.Size = new System.Drawing.Size(55, 15);
            this.lblTiempoEspera.TabIndex = 9;
            this.lblTiempoEspera.Text = "00:00:00";
            this.lblTiempoEspera.Visible = false;
            // 
            // lblEsperaOficina
            // 
            this.lblEsperaOficina.AutoSize = true;
            this.lblEsperaOficina.Location = new System.Drawing.Point(29, 57);
            this.lblEsperaOficina.Name = "lblEsperaOficina";
            this.lblEsperaOficina.Size = new System.Drawing.Size(91, 13);
            this.lblEsperaOficina.TabIndex = 8;
            this.lblEsperaOficina.Text = "Espera de Oficina";
            this.lblEsperaOficina.Visible = false;
            // 
            // lblEstado_Oficina
            // 
            this.lblEstado_Oficina.AutoSize = true;
            this.lblEstado_Oficina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado_Oficina.Location = new System.Drawing.Point(53, 18);
            this.lblEstado_Oficina.Name = "lblEstado_Oficina";
            this.lblEstado_Oficina.Size = new System.Drawing.Size(154, 20);
            this.lblEstado_Oficina.TabIndex = 7;
            this.lblEstado_Oficina.Text = "Tiempo de Espera";
            this.lblEstado_Oficina.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.lblEjecutivo);
            this.panel2.Controls.Add(this.lblOficina);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BtnEstado);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(12, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 61);
            this.panel2.TabIndex = 17;
            // 
            // lblEjecutivo
            // 
            this.lblEjecutivo.AutoSize = true;
            this.lblEjecutivo.Location = new System.Drawing.Point(121, 35);
            this.lblEjecutivo.Name = "lblEjecutivo";
            this.lblEjecutivo.Size = new System.Drawing.Size(40, 13);
            this.lblEjecutivo.TabIndex = 19;
            this.lblEjecutivo.Text = "Oficina";
            // 
            // lblOficina
            // 
            this.lblOficina.AutoSize = true;
            this.lblOficina.Location = new System.Drawing.Point(121, 11);
            this.lblOficina.Name = "lblOficina";
            this.lblOficina.Size = new System.Drawing.Size(40, 13);
            this.lblOficina.TabIndex = 18;
            this.lblOficina.Text = "Oficina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ejecutivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Oficina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado Atención";
            this.label2.Visible = false;
            // 
            // BtnEstado
            // 
            this.BtnEstado.BackColor = System.Drawing.Color.IndianRed;
            this.BtnEstado.Enabled = false;
            this.BtnEstado.ForeColor = System.Drawing.Color.White;
            this.BtnEstado.Location = new System.Drawing.Point(366, 30);
            this.BtnEstado.Name = "BtnEstado";
            this.BtnEstado.Size = new System.Drawing.Size(100, 23);
            this.BtnEstado.TabIndex = 14;
            this.BtnEstado.TabStop = false;
            this.BtnEstado.Text = "Pausa";
            this.BtnEstado.UseVisualStyleBackColor = false;
            this.BtnEstado.Visible = false;
            this.BtnEstado.Click += new System.EventHandler(this.BtnEstado_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.logoCliente2;
            this.pictureBox2.Location = new System.Drawing.Point(7, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 46);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(472, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTelefono);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnInicioAtencion);
            this.panel1.Controls.Add(this.btnPausa);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 31);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Opción Teléfono";
            this.label1.Visible = false;
            // 
            // cboTelefono
            // 
            this.cboTelefono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTelefono.Enabled = false;
            this.cboTelefono.FormattingEnabled = true;
            this.cboTelefono.Items.AddRange(new object[] {
            "15  carácteres-->(00)0-0000-0000",
            "10  carácteres-->00000-0000",
            "8    carácteres-->0000-0000"});
            this.cboTelefono.Location = new System.Drawing.Point(179, 5);
            this.cboTelefono.Name = "cboTelefono";
            this.cboTelefono.Size = new System.Drawing.Size(129, 21);
            this.cboTelefono.TabIndex = 12;
            this.cboTelefono.TabStop = false;
            this.cboTelefono.Visible = false;
            this.cboTelefono.SelectedIndexChanged += new System.EventHandler(this.cboTelefono_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(598, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Visible = false;
            // 
            // btnInicioAtencion
            // 
            this.btnInicioAtencion.Location = new System.Drawing.Point(319, 4);
            this.btnInicioAtencion.Name = "btnInicioAtencion";
            this.btnInicioAtencion.Size = new System.Drawing.Size(96, 23);
            this.btnInicioAtencion.TabIndex = 10;
            this.btnInicioAtencion.TabStop = false;
            this.btnInicioAtencion.Text = "Inicio Atención";
            this.btnInicioAtencion.UseVisualStyleBackColor = true;
            this.btnInicioAtencion.Click += new System.EventHandler(this.btnInicioAtencion_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Enabled = false;
            this.btnPausa.Location = new System.Drawing.Point(8, 5);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(75, 23);
            this.btnPausa.TabIndex = 9;
            this.btnPausa.TabStop = false;
            this.btnPausa.Text = "| | Pausa";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // IniciarAtencion
            // 
            this.IniciarAtencion.Enabled = true;
            this.IniciarAtencion.Tick += new System.EventHandler(this.IniciarAtencion_Tick);
            // 
            // btnExcepción
            // 
            this.btnExcepción.Location = new System.Drawing.Point(7, 42);
            this.btnExcepción.Name = "btnExcepción";
            this.btnExcepción.Size = new System.Drawing.Size(113, 32);
            this.btnExcepción.TabIndex = 18;
            this.btnExcepción.TabStop = false;
            this.btnExcepción.Text = "Excepción";
            this.btnExcepción.UseVisualStyleBackColor = true;
            this.btnExcepción.Click += new System.EventHandler(this.btnExcepción_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hactual,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Hactual
            // 
            this.Hactual.Name = "Hactual";
            this.Hactual.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Llego_Tick);
            // 
            // btnLlego
            // 
            this.btnLlego.Location = new System.Drawing.Point(7, 3);
            this.btnLlego.Name = "btnLlego";
            this.btnLlego.Size = new System.Drawing.Size(238, 33);
            this.btnLlego.TabIndex = 22;
            this.btnLlego.TabStop = false;
            this.btnLlego.Text = "Llego";
            this.btnLlego.UseVisualStyleBackColor = true;
            this.btnLlego.Click += new System.EventHandler(this.btnLlego_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnLlego);
            this.panelMenu.Controls.Add(this.btnExcepción);
            this.panelMenu.Controls.Add(this.btnFinalizarAtencion);
            this.panelMenu.Controls.Add(this.btnAnular);
            this.panelMenu.Enabled = false;
            this.panelMenu.Location = new System.Drawing.Point(12, 291);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(253, 120);
            this.panelMenu.TabIndex = 16;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 453);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panelAtencion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel5.ResumeLayout(false);
            this.panelAtencion.ResumeLayout(false);
            this.panelAtencion.PerformLayout();
            this.subpanelAtencion.ResumeLayout(false);
            this.subpanelAtencion.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizarAtencion;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelAtencion;
        private System.Windows.Forms.Label lblErrorRut;
        private System.Windows.Forms.Panel subpanelAtencion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLlamadoNumero;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTiempoAtencion;
        private System.Windows.Forms.Label lblEsperaAtencion;
        private System.Windows.Forms.Label lblEstado_Oficina;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTelefono;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInicioAtencion;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Timer IniciarAtencion;
        private System.Windows.Forms.Button BtnEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcepción;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblEjecutivo;
        private System.Windows.Forms.Label lblOficina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Hactual;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTiempoEspera;
        private System.Windows.Forms.Label lblEsperaOficina;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.Button btnSerie;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Button btnLlego;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblEstadoAtencion;
        private System.Windows.Forms.Label lblEstadoAtencionOficina;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}

