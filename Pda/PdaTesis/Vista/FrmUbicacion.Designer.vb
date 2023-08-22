<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmUbicacion
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
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnVolver = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.txtPatente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLocal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPasillo = New System.Windows.Forms.TextBox
        Me.Lbl_Ean = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(14, 115)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(202, 84)
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(155, 92)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(61, 20)
        Me.btnVolver.TabIndex = 130
        Me.btnVolver.Text = "Volver"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(84, 92)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(61, 20)
        Me.btnLimpiar.TabIndex = 129
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(14, 92)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(61, 20)
        Me.btnAgregar.TabIndex = 128
        Me.btnAgregar.Text = "Agregar"
        '
        'txtPatente
        '
        Me.txtPatente.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtPatente.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtPatente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPatente.Location = New System.Drawing.Point(92, 59)
        Me.txtPatente.MaxLength = 20
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(124, 19)
        Me.txtPatente.TabIndex = 127
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(14, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.Text = "Patente:"
        '
        'txtLocal
        '
        Me.txtLocal.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtLocal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtLocal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtLocal.Location = New System.Drawing.Point(92, 11)
        Me.txtLocal.MaxLength = 20
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(124, 19)
        Me.txtLocal.TabIndex = 126
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.Text = "Local :"
        '
        'txtPasillo
        '
        Me.txtPasillo.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtPasillo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtPasillo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPasillo.Location = New System.Drawing.Point(92, 35)
        Me.txtPasillo.MaxLength = 20
        Me.txtPasillo.Name = "txtPasillo"
        Me.txtPasillo.Size = New System.Drawing.Size(124, 19)
        Me.txtPasillo.TabIndex = 125
        '
        'Lbl_Ean
        '
        Me.Lbl_Ean.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Lbl_Ean.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Ean.Location = New System.Drawing.Point(14, 36)
        Me.Lbl_Ean.Name = "Lbl_Ean"
        Me.Lbl_Ean.Size = New System.Drawing.Size(61, 18)
        Me.Lbl_Ean.Text = "Pasillo:"
        '
        'FrmUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(638, 455)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtPatente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLocal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPasillo)
        Me.Controls.Add(Me.Lbl_Ean)
        Me.Name = "FrmUbicacion"
        Me.Text = "Ubicación"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtPatente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPasillo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ean As System.Windows.Forms.Label
End Class
