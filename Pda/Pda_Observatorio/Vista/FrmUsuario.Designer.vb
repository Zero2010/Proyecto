<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmUsuario
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRut = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.Lbl_Ean = New System.Windows.Forms.Label
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtRut
        '
        Me.txtRut.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtRut.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtRut.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtRut.Location = New System.Drawing.Point(99, 28)
        Me.txtRut.MaxLength = 20
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(124, 19)
        Me.txtRut.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.Text = "Rut:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtUsuario.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtUsuario.Location = New System.Drawing.Point(99, 52)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(124, 19)
        Me.txtUsuario.TabIndex = 116
        '
        'Lbl_Ean
        '
        Me.Lbl_Ean.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Lbl_Ean.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Ean.Location = New System.Drawing.Point(21, 53)
        Me.Lbl_Ean.Name = "Lbl_Ean"
        Me.Lbl_Ean.Size = New System.Drawing.Size(61, 18)
        Me.Lbl_Ean.Text = "Usuario:"
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(21, 108)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(202, 114)
        Me.lblMensaje.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(21, 77)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(61, 17)
        Me.btnVolver.TabIndex = 121
        Me.btnVolver.Text = "Volver"
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Lbl_Ean)
        Me.Name = "FrmUsuario"
        Me.Text = "Usuario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ean As System.Windows.Forms.Label
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
