Imports Controlador

Public Class FrmUbicacion

    Dim ObjUbicacion As New classUbicacion

    Private Sub txtLocal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmAdministrador.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If (txtLocal.Text <> "") And (txtPasillo.Text <> "") And (txtPatente.Text <> "") Then
            ObjUbicacion.Local = txtLocal.Text
            ObjUbicacion.Pasillo = txtPasillo.Text
            ObjUbicacion.strPatente = txtPatente.Text
            FrmInventario.Show()
            Me.Hide()
        ElseIf (txtLocal.Text <> "Campo Vacío") Or (txtPasillo.Text <> "Campo Vacío") Or (txtPatente.Text <> "Campo Vacío") Then
            lblMensaje.Text = "Debe LLenar los campos Marcados..."

            If txtLocal.Text = "" Then
                txtLocal.BackColor = Color.Red
            Else
                txtLocal.BackColor = Color.White
            End If

            If txtPasillo.Text = "" Then
                txtPasillo.BackColor = Color.Red
            Else
                txtPasillo.BackColor = Color.White
            End If

            If txtPatente.Text = "" Then
                txtPatente.BackColor = Color.Red
            Else
                txtPatente.BackColor = Color.White
            End If


        End If
    End Sub
End Class