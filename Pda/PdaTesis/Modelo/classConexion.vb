
Imports System.Data.SqlServerCe
Imports System.IO

Public Class classConexion

    Public sql As String
    Public BD As New SqlCeEngine
    Public oDR As SqlCeDataReader

    Public con As New SqlCeConnection
    Public dt As New Data.DataTable
    Public cmd As New SqlCeCommand
    Public da As New SqlCeDataAdapter
    Public dt2 As New DataTable

    Public count As Integer

    Public Function EjecutarDatatable() As DataTable
        dt = New DataTable
        da = New SqlCeDataAdapter(cmd)
        da.Fill(dt)
        EjecutarDatatable = dt
    End Function

    Public Sub conectar()
        Try
            con.ConnectionString = "Data Source=\My Documents\Eso.sdf"
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Desconectar()
        End Try
    End Sub

    Public Sub CrearComando(ByVal Consulta As String)
        Try
            If con.State <> ConnectionState.Open Then
                conectar()
            End If
            cmd = New SqlCeCommand(Consulta, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Desconectar()
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Public Sub ConsultarId(ByVal Consulta As String)
        Try
            If con.State <> ConnectionState.Open Then
                conectar()
            End If
            cmd.Connection = con
            cmd.CommandText = Consulta
            oDR = cmd.ExecuteReader

        Catch ex As Exception
            Desconectar()
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub Desconectar()
        con.Close()
    End Sub

    Public Sub CrearResultados(ByVal Consulta As String)
        Try
            If con.State <> ConnectionState.Open Then
                conectar()
            End If
            cmd.Connection = con
            cmd.CommandText = Consulta
            oDR = cmd.ExecuteReader
        Catch ex As Exception
            Desconectar()
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub InsertRegistros(ByVal Consulta As String, ByVal id As String)
        Try
            If con.State <> ConnectionState.Open Then
                conectar()
            End If

            cmd.Connection = con
            cmd.CommandText = Consulta
            cmd.ExecuteNonQuery()
            count += 1
        Catch ex As Exception
            Desconectar()
            MsgBox(ex.Message.ToString & " Este Id " & id & " no cargado")
        End Try
    End Sub

    Public Sub EliminarPatente(ByVal Consulta As String, ByVal id As String)
        Try
            If con.State <> ConnectionState.Open Then
                conectar()
            End If

            cmd.Connection = con
            cmd.CommandText = Consulta
            cmd.ExecuteNonQuery()
            count += 1
        Catch ex As Exception
            Desconectar()
            MsgBox(ex.Message.ToString & " Está Patente " & id & " no Eliminada")
        End Try
    End Sub

End Class
