<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmAdministrador
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
        Me.lblMensaje = New System.Windows.Forms.Label
        Me.btnVolver = New System.Windows.Forms.Button
        Me.btnEliminarArea = New System.Windows.Forms.Button
        Me.btnCrearUsuario = New System.Windows.Forms.Button
        Me.btnCargarMaestra = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(28, 148)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(115, 54)
        Me.lblMensaje.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(28, 110)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(115, 23)
        Me.btnVolver.TabIndex = 18
        Me.btnVolver.Text = "Volver"
        '
        'btnEliminarArea
        '
        Me.btnEliminarArea.Location = New System.Drawing.Point(28, 81)
        Me.btnEliminarArea.Name = "btnEliminarArea"
        Me.btnEliminarArea.Size = New System.Drawing.Size(115, 23)
        Me.btnEliminarArea.TabIndex = 17
        Me.btnEliminarArea.Text = "Eliminar Area"
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.Location = New System.Drawing.Point(28, 51)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(115, 24)
        Me.btnCrearUsuario.TabIndex = 16
        Me.btnCrearUsuario.Text = "Crear Usuario"
        '
        'btnCargarMaestra
        '
        Me.btnCargarMaestra.Location = New System.Drawing.Point(28, 26)
        Me.btnCargarMaestra.Name = "btnCargarMaestra"
        Me.btnCargarMaestra.Size = New System.Drawing.Size(115, 19)
        Me.btnCargarMaestra.TabIndex = 15
        Me.btnCargarMaestra.Text = "Cargar Maestra"
        '
        'FrmAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(638, 455)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnEliminarArea)
        Me.Controls.Add(Me.btnCrearUsuario)
        Me.Controls.Add(Me.btnCargarMaestra)
        Me.Menu = Me.mainMenu1
        Me.Name = "FrmAdministrador"
        Me.Text = "Administrador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnEliminarArea As System.Windows.Forms.Button
    Friend WithEvents btnCrearUsuario As System.Windows.Forms.Button
    Friend WithEvents btnCargarMaestra As System.Windows.Forms.Button

End Class
