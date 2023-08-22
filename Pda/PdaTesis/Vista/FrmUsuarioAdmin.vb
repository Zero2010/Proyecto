Imports Controlador

Public Class FrmUsuarioAdmin

    Dim ObjUsuario As New classUsuario
    Dim ObjCrearBase As New classMaestra

    Private Sub txtRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRut.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtRut.Text <> "" Then

                ObjUsuario.Rut = txtRut.Text
                ObjUsuario.BuscarAdmin()

                If ObjUsuario.Mensaje = "Ok" Then
                    lblMensaje.Text = ""
                    txtRut.Text = ""
                    FrmAdministrador.Show()
                    Me.Hide()
                Else
                    btnVolver.Visible = True
                    lblMensaje.Visible = True
                    txtRut.Text = "Sin Privilegios..."
                    lblMensaje.Text = ObjUsuario.Mensaje
                End If

            End If
        End If

    End Sub
    Private Sub btnVolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        txtRut.Text = ""
        lblMensaje.Text = ""
        ObjUsuario.Mensaje = ""
        txtRut.Text = ""
        FrmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub FrmUsuarioAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ObjCrearBase.CrearBase()
    End Sub
End Class