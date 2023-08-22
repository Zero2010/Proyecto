<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmUsuarioAdmin
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
        Me.btnVolver = New System.Windows.Forms.Button
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtRut
        '
        Me.txtRut.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtRut.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtRut.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtRut.Location = New System.Drawing.Point(94, 24)
        Me.txtRut.MaxLength = 20
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(124, 19)
        Me.txtRut.TabIndex = 119
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.Text = "Rut:"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(19, 56)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(66, 21)
        Me.btnVolver.TabIndex = 123
        Me.btnVolver.Text = "Volver"
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(19, 94)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(202, 114)
        Me.lblMensaje.Visible = False
        '
        'FrmUsuarioAdmin
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
        Me.Name = "FrmUsuarioAdmin"
        Me.Text = "Usuario Administrador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRut As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
