<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmRevision
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
        Me.components = New System.ComponentModel.Container
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnInicio = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblId = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnCerrarArea = New System.Windows.Forms.Button
        Me.btnVolver = New System.Windows.Forms.Button
        Me.Btn_Siguiente = New System.Windows.Forms.Button
        Me.Btn_Anterior = New System.Windows.Forms.Button
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.lblEan = New System.Windows.Forms.Label
        Me.LblArea = New System.Windows.Forms.Label
        Me.txtModificar = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(183, 171)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(43, 20)
        Me.btnUltimo.TabIndex = 76
        Me.btnUltimo.Text = ">>>"
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(134, 171)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(38, 20)
        Me.btnInicio.TabIndex = 75
        Me.btnInicio.Text = "<<<"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(14, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 20)
        Me.Label6.Text = "Descripción"
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblId.Location = New System.Drawing.Point(177, 11)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(49, 20)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(151, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.Text = "Id"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblDescripcion.Location = New System.Drawing.Point(14, 77)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(213, 41)
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(134, 196)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 20)
        Me.btnEliminar.TabIndex = 74
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(14, 196)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(92, 20)
        Me.btnModificar.TabIndex = 73
        Me.btnModificar.Text = "Modificar"
        '
        'btnCerrarArea
        '
        Me.btnCerrarArea.Location = New System.Drawing.Point(134, 220)
        Me.btnCerrarArea.Name = "btnCerrarArea"
        Me.btnCerrarArea.Size = New System.Drawing.Size(92, 20)
        Me.btnCerrarArea.TabIndex = 72
        Me.btnCerrarArea.Text = "Cerrar Area"
        Me.btnCerrarArea.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(14, 220)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(92, 20)
        Me.btnVolver.TabIndex = 71
        Me.btnVolver.Text = "Volver"
        '
        'Btn_Siguiente
        '
        Me.Btn_Siguiente.Location = New System.Drawing.Point(63, 173)
        Me.Btn_Siguiente.Name = "Btn_Siguiente"
        Me.Btn_Siguiente.Size = New System.Drawing.Size(43, 20)
        Me.Btn_Siguiente.TabIndex = 70
        Me.Btn_Siguiente.Text = ">"
        '
        'Btn_Anterior
        '
        Me.Btn_Anterior.Location = New System.Drawing.Point(14, 173)
        Me.Btn_Anterior.Name = "Btn_Anterior"
        Me.Btn_Anterior.Size = New System.Drawing.Size(38, 20)
        Me.Btn_Anterior.TabIndex = 69
        Me.Btn_Anterior.Text = "<"
        '
        'lblCantidad
        '
        Me.lblCantidad.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblCantidad.Location = New System.Drawing.Point(107, 122)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(120, 20)
        '
        'lblEan
        '
        Me.lblEan.BackColor = System.Drawing.Color.NavajoWhite
        Me.lblEan.Location = New System.Drawing.Point(107, 35)
        Me.lblEan.Name = "lblEan"
        Me.lblEan.Size = New System.Drawing.Size(120, 20)
        '
        'LblArea
        '
        Me.LblArea.BackColor = System.Drawing.Color.NavajoWhite
        Me.LblArea.Location = New System.Drawing.Point(107, 11)
        Me.LblArea.Name = "LblArea"
        Me.LblArea.Size = New System.Drawing.Size(38, 20)
        '
        'txtModificar
        '
        Me.txtModificar.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtModificar.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtModificar.Location = New System.Drawing.Point(107, 146)
        Me.txtModificar.MaxLength = 7
        Me.txtModificar.Name = "txtModificar"
        Me.txtModificar.Size = New System.Drawing.Size(120, 23)
        Me.txtModificar.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(14, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.Text = "Modificar"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(14, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(14, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.Text = "Ubicación"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(14, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.Text = "Ean"
        '
        'frmRevision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(240, 294)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnCerrarArea)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Btn_Siguiente)
        Me.Controls.Add(Me.Btn_Anterior)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblEan)
        Me.Controls.Add(Me.LblArea)
        Me.Controls.Add(Me.txtModificar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRevision"
        Me.Text = "Revision"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCerrarArea As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Btn_Siguiente As System.Windows.Forms.Button
    Friend WithEvents Btn_Anterior As System.Windows.Forms.Button
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblEan As System.Windows.Forms.Label
    Friend WithEvents LblArea As System.Windows.Forms.Label
    Friend WithEvents txtModificar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
