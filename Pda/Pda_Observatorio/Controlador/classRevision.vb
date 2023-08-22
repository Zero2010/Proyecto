Imports Modelo

Public Class classRevision

    Public strEan As String
    Public strSku As String
    Public strDescripcion As String
    Public strPatente As String
    Public strCantidad As String

    Public Property Ean() As String
        Get
            Return strEan
        End Get
        Set(ByVal value As String)
            strEan = value
        End Set
    End Property

    Public Property Sku() As String
        Get
            Return strSku
        End Get
        Set(ByVal value As String)
            strSku = value
        End Set
    End Property

    Public Property Patente() As String
        Get
            Return strPatente
        End Get
        Set(ByVal value As String)
            strPatente = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return strDescripcion
        End Get
        Set(ByVal value As String)
            strDescripcion = value
        End Set
    End Property

    Public Property Cantidad() As String
        Get
            Return strCantidad
        End Get
        Set(ByVal value As String)
            strCantidad = value
        End Set
    End Property

    Sub Anterior()
        'Try
        '    Lbl_Ean.DataBindings.Clear() : Lbl_Patente.DataBindings.Clear() : Lbl_Cantidad.DataBindings.Clear() : lblDescripcion.DataBindings.Clear() : lblId.DataBindings.Clear()
        '    BindingSource1.MovePrevious()
        '    Lbl_Ean.DataBindings.Add("Text", BindingSource1, "ean") : Lbl_Patente.DataBindings.Add("Text", BindingSource1, "patente")
        '    Lbl_Cantidad.DataBindings.Add("Text", BindingSource1, "cantidad") : lblDescripcion.DataBindings.Add("Text", BindingSource1, "Descripcion")
        '    lblId.DataBindings.Add("Text", BindingSource1, "Id")
        '    Txt_Modificar.Focus()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub

    Sub Siguiente()
        'Try
        '    Lbl_Ean.DataBindings.Clear() : Lbl_Patente.DataBindings.Clear() : Lbl_Cantidad.DataBindings.Clear() : lblDescripcion.DataBindings.Clear() : lblId.DataBindings.Clear()
        '    BindingSource1.MovePrevious()
        '    Lbl_Ean.DataBindings.Add("Text", BindingSource1, "ean") : Lbl_Patente.DataBindings.Add("Text", BindingSource1, "patente")
        '    Lbl_Cantidad.DataBindings.Add("Text", BindingSource1, "cantidad") : lblDescripcion.DataBindings.Add("Text", BindingSource1, "Descripcion")
        '    lblId.DataBindings.Add("Text", BindingSource1, "Id")
        '    Txt_Modificar.Focus()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub

End Class
