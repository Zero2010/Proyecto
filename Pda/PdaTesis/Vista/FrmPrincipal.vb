Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Administrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Administrador.Click
        FrmUsuarioAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Inventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inventario.Click
        FrmUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub CrearTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearTxt.Click

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub
End Class