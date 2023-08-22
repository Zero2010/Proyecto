<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmPrincipal
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
        Me.Administrador = New System.Windows.Forms.MenuItem
        Me.Inventario = New System.Windows.Forms.MenuItem
        Me.CrearTxt = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.Salir = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.Administrador)
        Me.MenuItem1.MenuItems.Add(Me.Inventario)
        Me.MenuItem1.MenuItems.Add(Me.CrearTxt)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem6)
        Me.MenuItem1.MenuItems.Add(Me.Salir)
        Me.MenuItem1.Text = "Opciones"
        '
        'Administrador
        '
        Me.Administrador.Checked = True
        Me.Administrador.Text = "Administrador"
        '
        'Inventario
        '
        Me.Inventario.Checked = True
        Me.Inventario.Text = "Inventario"
        '
        'CrearTxt
        '
        Me.CrearTxt.Checked = True
        Me.CrearTxt.Text = "Crear Txt"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "-"
        '
        'Salir
        '
        Me.Salir.Checked = True
        Me.Salir.Text = "Salir"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(638, 455)
        Me.Menu = Me.mainMenu1
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Administrador As System.Windows.Forms.MenuItem
    Friend WithEvents Inventario As System.Windows.Forms.MenuItem
    Friend WithEvents CrearTxt As System.Windows.Forms.MenuItem
    Friend WithEvents Salir As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
End Class
