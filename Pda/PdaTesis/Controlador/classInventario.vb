Imports Modelo

Public Class classInventario
    Dim ObjConexion As New classConexion
    Dim objUbicacion As New classUbicacion

    'variables de inventario
    Public strPatente As String
    Public strCantidad As String

    'variables
    Public strEan As String
    Public strSku As String
    Public strDescripcion As String
    Public strFecha As String
    Public strUsuario As String
    Public strId As String

    Public Property Patente() As String
        Get
            Return strPatente
        End Get
        Set(ByVal value As String)
            strPatente = value
        End Set
    End Property

    Public Property Id() As String
        Get
            Return strId
        End Get
        Set(ByVal value As String)
            strId = value
        End Set
    End Property

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

    Public Property Fecha() As String
        Get
            Return strFecha
        End Get
        Set(ByVal value As String)
            strFecha = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return strUsuario
        End Get
        Set(ByVal value As String)
            strUsuario = value
        End Set
    End Property

    Sub Captura()

        ObjConexion.CrearResultados("Select Ean,Descripcion,Sku from Maestra where Ean='" & Ean & "'")
        'Limpiar()
        If ObjConexion.oDR.Read() Then
            Ean = ObjConexion.oDR.GetString(0)
            Descripcion = ObjConexion.oDR.GetString(1)
            Sku = ObjConexion.oDR.GetString(2)
        Else
            MsgBox("Articulo no encontrado.", MsgBoxStyle.Critical, "Advertencia'...")
            Limpiar()
        End If

    End Sub

    Public Sub CrearTxt()

        Dim TextoPlano As String
        Dim Fic As String = "My Documents\Captura\Inventario.txt"
        Dim Sw As New System.IO.StreamWriter(Fic, True)

        ObjConexion.CrearResultados("select * from captura")
        Dim sumar As Integer = 0

        While (ObjConexion.oDR.Read())
            TextoPlano = ObjConexion.oDR.Item(0) & "|" & ObjConexion.oDR.Item(1) & "|" & ObjConexion.oDR.Item(2) & "|" & ObjConexion.oDR.Item(3) & "|" & ObjConexion.oDR.Item(4) & "|" & ObjConexion.oDR.Item(5) & "|" & ObjConexion.oDR.Item(6) & "|" & ObjConexion.oDR.Item(7)
            Sw.WriteLine(TextoPlano)
        End While
        Sw.Close()

        MsgBox("Archivo Creado", MsgBoxStyle.Information, "Txt creado")
    End Sub

    Public Sub Inventario()
        Try
            GenerarId()
            ObjConexion.CrearResultados("Insert Into Captura(Id, Ean, Sku, Descripcion, Patente, Fecha, Usuario, Cantidad)values( '" & Id & "','" & Ean & "','" & Sku & "','" & Descripcion & "','" & objUbicacion.Patente & "' ,'" & Fecha & "','" & Usuario & "','" & Cantidad & "')")
            MsgBox("Registro :" & Ean & " Insertado-Producto :" & Descripcion, MsgBoxStyle.Information, "Inserción realizada")
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Limpiar()
        End Try
    End Sub

    Public Sub EliminarPat()
        Try
            ObjConexion.EliminarPatente("Delete From Captura Where=" & Patente, "")
            MsgBox("Patente " & Patente & " fue Eliminado con Exito", MsgBoxStyle.Information, "Eliminación realizada")
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Limpiar()
        End Try
    End Sub

    Public Sub EliminarRegistro()
        Try
            ObjConexion.EliminarPatente("Delete From Captura Where=" & Patente & " and Ean=" & Ean & "and Id=" & Id, "")
            MsgBox("Patente " & Patente & " fue Eliminado con Exito", MsgBoxStyle.Information, "Eliminación realizada")
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Limpiar()
        End Try
    End Sub

    Sub GenerarId()
        ObjConexion.CrearResultados("Select count(*) + 1 from Captura")
        'Limpiar
        If ObjConexion.oDR.Read() Then
            Id = ObjConexion.oDR.Item(0)
        Else
            MsgBox("Articulo no encontrado.", MsgBoxStyle.Critical, "Advertencia'...")
            Limpiar()

        End If
    End Sub

    Sub Limpiar()
        Ean = ""
        Descripcion = ""
        Usuario = ""
        Fecha = ""
        Patente = ""
        Id = ""
        Sku = ""
    End Sub
End Class
