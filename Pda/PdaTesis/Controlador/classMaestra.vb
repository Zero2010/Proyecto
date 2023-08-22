Imports Modelo
Imports System.IO

Public Class classMaestra
    Dim objConexion As New classConexion
    Dim sql As String

    Public StrMensaje As String
    Public StrRespuesta As String

    Public Property Mensaje() As String
        Get
            Return StrMensaje
        End Get
        Set(ByVal value As String)
            StrMensaje = value
        End Set
    End Property

    Public Property Respuesta() As String
        Get
            Return StrRespuesta
        End Get
        Set(ByVal value As String)
            StrRespuesta = value
        End Set
    End Property

    Function CrearBase() As Integer

        Try

            If IO.File.Exists("\My Documents\Eso.sdf") Then
            Else
                objConexion.BD.LocalConnectionString = "Data Source=\My Documents\Eso.sdf"
                objConexion.BD.CreateDatabase()

                'CREAR TABLA MAESTRA
                objConexion.CrearResultados("Create Table Maestra (Ean nvarchar(20), Descripcion nvarchar(100),sku nvarchar(20))")

                'CREAR INDEXACION EN LA MAESTRA
                objConexion.CrearResultados("Create Unique Index Idcodigo ON Maestra (Ean)")

                'CREAR TABLA CAPTURA
                objConexion.CrearResultados("Create Table Captura (Id nvarchar(20), Ean nvarchar(20), Sku nvarchar(20), Descripcion nvarchar(100), Patente nvarchar(20), Fecha nvarchar(20), Usuario nvarchar(20), Cantidad nvarchar(5))")

                'CREAR TABLA USUARIO
                objConexion.CrearResultados("Create Table Usuario (Rut nvarchar(10), Nombre nvarchar(30), Tipo nvarchar(1))")

                CrearBase = 1

                MsgBox("Base Creada, se cargara la base...", MsgBoxStyle.Information, "Ok")
                'Cargar_Maestra()
                Cargar_Usuario()
                Beep()
            End If

        Catch ex As Exception When CrearBase = 0
            Beep()
            MsgBox(ex.Message.ToString)
        End Try

    End Function

    Sub Cargar_Maestra()
        Try

            objConexion.ConsultarId("Select count(*) from Maestra")

            If objConexion.oDR.Read() Then
                Respuesta = objConexion.oDR.Item(0)

                If Respuesta = "0" Then
                    Dim Separa As String = "|"
                    Dim linea As String
                    Dim fileslist As String() = Directory.GetFiles("\My Documents\Maestra\")
                    Dim count As Integer

                    For Each item As String In fileslist
                        Dim lector As New System.IO.StreamReader(item)
                        Do
                            linea = lector.ReadLine
                            If String.IsNullOrEmpty(linea) Then
                                Continue Do
                            End If

                            Dim Vector() As String = linea.Split(Separa)

                            'INSERTAR DATOS A LA TABLA
                            objConexion.InsertRegistros("Insert Into Maestra(Ean,Descripcion,Sku)values('" & Vector(0) & "','" & Vector(1) & "','" & Vector(2) & "')", Vector(0))

                            count += 1

                        Loop Until linea Is Nothing
                    Next
                    objConexion.Desconectar()
                    MsgBox("Registros Cargados :" & count)
                    Mensaje = "ok"
                Else
                    Mensaje = "No se puede volver a cargar los productos..."
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub Cargar_Usuario()
        Try
            Dim Separa As String = "|"
            Dim linea As String
            Dim fileslist As String() = Directory.GetFiles("\My Documents\Usuario\")
            Dim count As Integer

            For Each item As String In fileslist
                Dim lector As New System.IO.StreamReader(item)
                Do
                    linea = lector.ReadLine
                    If String.IsNullOrEmpty(linea) Then
                        Continue Do
                    End If

                    Dim Vector() As String = linea.Split(Separa)

                    'INSERTAR DATOS A LA TABLA
                    objConexion.InsertRegistros("Insert Into Usuario(Rut,Nombre,Tipo)values('" & Vector(0) & "','" & Vector(1) & "','" & Vector(2) & "')", Vector(0))

                    count += 1

                Loop Until linea Is Nothing
            Next
            objConexion.Desconectar()
            MsgBox("Registros Cargados :" & count)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
