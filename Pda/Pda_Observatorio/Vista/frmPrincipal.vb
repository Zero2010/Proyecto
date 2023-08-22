Imports Controlador

Public Class frmPrincipal

    Dim objInventario As New classInventario

    Private Sub mInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mInventario.Click
        FrmUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub mAdministrador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mAdministrador.Click
        FrmUsuarioAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub mSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mSalir.Click
        Me.Close()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        objInventario.CrearTxt()
    End Sub
End Class
