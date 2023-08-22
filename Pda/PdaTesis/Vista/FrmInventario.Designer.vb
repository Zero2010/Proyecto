<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmInventario
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
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.Inicio = New System.Windows.Forms.MenuItem
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbSku = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Lbl_Detalle = New System.Windows.Forms.Label
        Me.txtEan = New System.Windows.Forms.TextBox
        Me.Lbl_Ean = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.Inicio)
        Me.MenuItem1.Text = "Opcion"
        '
        'Inicio
        '
        Me.Inicio.Text = "Inicio"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(16, 93)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(220, 90)
        Me.txtDescripcion.TabIndex = 153
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.txtCantidad.Location = New System.Drawing.Point(78, 189)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(68, 18)
        Me.txtCantidad.TabIndex = 152
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(16, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.Text = "Cantidad:"
        '
        'lbSku
        '
        Me.lbSku.BackColor = System.Drawing.Color.NavajoWhite
        Me.lbSku.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lbSku.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbSku.Location = New System.Drawing.Point(54, 41)
        Me.lbSku.Name = "lbSku"
        Me.lbSku.Size = New System.Drawing.Size(181, 15)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.Text = "Sku:"
        '
        'Lbl_Detalle
        '
        Me.Lbl_Detalle.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Lbl_Detalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Detalle.Location = New System.Drawing.Point(15, 78)
        Me.Lbl_Detalle.Name = "Lbl_Detalle"
        Me.Lbl_Detalle.Size = New System.Drawing.Size(97, 14)
        Me.Lbl_Detalle.Text = "Descripción:"
        '
        'txtEan
        '
        Me.txtEan.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtEan.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtEan.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtEan.Location = New System.Drawing.Point(54, 14)
        Me.txtEan.MaxLength = 20
        Me.txtEan.Name = "txtEan"
        Me.txtEan.Size = New System.Drawing.Size(181, 19)
        Me.txtEan.TabIndex = 151
        '
        'Lbl_Ean
        '
        Me.Lbl_Ean.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Lbl_Ean.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Ean.Location = New System.Drawing.Point(12, 16)
        Me.Lbl_Ean.Name = "Lbl_Ean"
        Me.Lbl_Ean.Size = New System.Drawing.Size(43, 18)
        Me.Lbl_Ean.Text = "Ean :"
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(638, 455)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSku)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Detalle)
        Me.Controls.Add(Me.txtEan)
        Me.Controls.Add(Me.Lbl_Ean)
        Me.Menu = Me.mainMenu1
        Me.Name = "FrmInventario"
        Me.Text = "Inventario"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbSku As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_Detalle As System.Windows.Forms.Label
    Friend WithEvents txtEan As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Ean As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Inicio As System.Windows.Forms.MenuItem
End Class
