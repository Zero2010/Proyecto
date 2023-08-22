namespace Vista
{
    partial class Configuracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnIniciarAtencion = new System.Windows.Forms.Button();
            this.btnTransmitir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(12, 21);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(102, 48);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Configuración";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnIniciarAtencion
            // 
            this.btnIniciarAtencion.BackColor = System.Drawing.Color.Green;
            this.btnIniciarAtencion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarAtencion.Location = new System.Drawing.Point(135, 21);
            this.btnIniciarAtencion.Name = "btnIniciarAtencion";
            this.btnIniciarAtencion.Size = new System.Drawing.Size(102, 48);
            this.btnIniciarAtencion.TabIndex = 13;
            this.btnIniciarAtencion.TabStop = false;
            this.btnIniciarAtencion.Text = "Iniciar Atención";
            this.btnIniciarAtencion.UseVisualStyleBackColor = false;
            this.btnIniciarAtencion.Click += new System.EventHandler(this.btnIniciarAtencion_Click);
            // 
            // btnTransmitir
            // 
            this.btnTransmitir.BackColor = System.Drawing.Color.IndianRed;
            this.btnTransmitir.ForeColor = System.Drawing.Color.White;
            this.btnTransmitir.Location = new System.Drawing.Point(12, 75);
            this.btnTransmitir.Name = "btnTransmitir";
            this.btnTransmitir.Size = new System.Drawing.Size(102, 48);
            this.btnTransmitir.TabIndex = 14;
            this.btnTransmitir.TabStop = false;
            this.btnTransmitir.Text = "Transmitir";
            this.btnTransmitir.UseVisualStyleBackColor = false;
            this.btnTransmitir.Click += new System.EventHandler(this.btnTransmitir_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 145);
            this.Controls.Add(this.btnTransmitir);
            this.Controls.Add(this.btnIniciarAtencion);
            this.Controls.Add(this.btnLogin);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnIniciarAtencion;
        private System.Windows.Forms.Button btnTransmitir;
    }
}