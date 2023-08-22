Imports Controlador

Public Class FrmAdministrador

    Dim ObjCarga As New classMaestra

    Private Sub btnCargarMaestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarMaestra.Click
        ObjCarga.Cargar_Maestra()

        If ObjCarga.Mensaje = "ok" Then
            lblMensaje.Visible = False
            frmPrincipal.Show()
            Me.Hide()
        Else
            lblMensaje.Visible = True
            lblMensaje.Text = ObjCarga.Mensaje
        End If

    End Sub

    Private Sub frmAdministrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnEliminarArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarArea.Click
        FrmEliminarPatente.Show()
        Me.Hide()
    End Sub

    Private Sub btnCrearUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearUsuario.Click
        FrmAgregarUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub lblMensaje_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMensaje.ParentChanged

    End Sub
End Class
