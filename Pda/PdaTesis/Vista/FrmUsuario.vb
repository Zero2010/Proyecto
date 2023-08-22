Imports Controlador

Public Class FrmUsuario

    Dim ObjUsuario As New classUsuario

    Private Sub txtRut_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub lblMensaje_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub txtRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRut.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtRut.Text <> "" Then

                ObjUsuario.Rut = txtRut.Text
                ObjUsuario.BuscarUsuario()

                If ObjUsuario.Mensaje = "Ok" Then
                    txtUsuario.Text = ObjUsuario.strUsuario
                    lblMensaje.Text = ""
                    txtRut.Text = ""
                    txtUsuario.Text = ""
                    FrmUbicacion.Show()
                    Me.Hide()
                Else
                    btnVolver.Visible = True
                    lblMensaje.Visible = True
                    txtRut.Text = "Rut no Existe..."
                    txtUsuario.Text = "Usuario no Existe..."
                    lblMensaje.Text = ObjUsuario.Mensaje
                End If

            End If
        End If
    End Sub

    Private Sub lblMensaje_ParentChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMensaje.ParentChanged

    End Sub

    Private Sub FrmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRut.Focus()
    End Sub

    Private Sub txtRut_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRut.TextChanged

    End Sub
End Class