<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmUbicacion
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
        Me.txtPasillo = New System.Windows.Forms.TextBox
        Me.Lbl_Ean = New System.Windows.Forms.Label
        Me.txtLocal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPatente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.btnVolver = New System.Windows.Forms.Button
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtPasillo
        '
        Me.txtPasillo.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtPasillo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtPasillo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPasillo.Location = New System.Drawing.Point(97, 39)
        Me.txtPasillo.MaxLength = 20
        Me.txtPasillo.Name = "txtPasillo"
        Me.txtPasillo.Size = New System.Drawing.Size(124, 19)
        Me.txtPasillo.TabIndex = 110
        '
        'Lbl_Ean
        '
        Me.Lbl_Ean.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Lbl_Ean.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Ean.Location = New System.Drawing.Point(19, 40)
        Me.Lbl_Ean.Name = "Lbl_Ean"
        Me.Lbl_Ean.Size = New System.Drawing.Size(61, 18)
        Me.Lbl_Ean.Text = "Pasillo:"
        '
        'txtLocal
        '
        Me.txtLocal.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtLocal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtLocal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtLocal.Location = New System.Drawing.Point(97, 15)
        Me.txtLocal.MaxLength = 20
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(124, 19)
        Me.txtLocal.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.Text = "Local :"
        '
        'txtPatente
        '
        Me.txtPatente.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtPatente.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtPatente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtPatente.Location = New System.Drawing.Point(97, 63)
        Me.txtPatente.MaxLength = 20
        Me.txtPatente.Name = "txtPatente"
        Me.txtPatente.Size = New System.Drawing.Size(124, 19)
        Me.txtPatente.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(19, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.Text = "Patente:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(19, 96)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(61, 20)
        Me.btnAgregar.TabIndex = 118
        Me.btnAgregar.Text = "Agregar"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(89, 96)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(61, 20)
        Me.btnLimpiar.TabIndex = 119
        Me.btnLimpiar.Text = "Limpiar"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(160, 96)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(61, 20)
        Me.btnVolver.TabIndex = 120
        Me.btnVolver.Text = "Volver"
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(19, 119)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(202, 84)
        '
        'frmUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(240, 294)
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
        Me.Name = "frmUbicacion"
        Me.Text = "Ubicación Producto"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPasillo As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ean As System.Windows.Forms.Label
    Friend WithEvents txtLocal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPatente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
End Class
