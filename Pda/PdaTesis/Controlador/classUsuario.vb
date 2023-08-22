Imports Modelo

Public Class classUsuario
    Dim ObjConexion As New classConexion

    Public strRut As String
    Public strUsuario As String
    Public strMensaje As String

    Public Property Rut() As String
        Get
            Return strRut
        End Get
        Set(ByVal value As String)
            strRut = value
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

    Public Property Mensaje() As String
        Get
            Return strMensaje
        End Get
        Set(ByVal value As String)
            strMensaje = value
        End Set
    End Property

    Sub BuscarUsuario()

        ObjConexion.CrearResultados("Select * From Usuario where Rut='" & Rut & "'")
        'Limpiar()
        If ObjConexion.oDR.Read() Then
            Rut = ObjConexion.oDR.GetString(0)
            Usuario = ObjConexion.oDR.GetString(1)
            Mensaje = "Ok"

        Else
            Mensaje = "El Usuario no Existe, Solicite al Administrador que lo Cree."
        End If

    End Sub

    Sub BuscarAdmin()

        ObjConexion.CrearResultados("Select * From Usuario where Rut='" & Rut & "' and tipo=1")
        'Limpiar()
        If ObjConexion.oDR.Read() Then
            Rut = ObjConexion.oDR.GetString(0)
            Usuario = ObjConexion.oDR.GetString(1)
            Mensaje = "Ok"

        Else
            Mensaje = "El Usuario no Tiene Privilegios de Administrador."
        End If

    End Sub

    Sub Limpiar()
        Rut = ""
        Usuario = ""
        Mensaje = ""
    End Sub

End Class



