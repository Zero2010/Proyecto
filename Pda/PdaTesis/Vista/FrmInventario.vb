Imports Controlador

Public Class FrmInventario

    Dim ObjCaptura As New classInventario

    Private Sub FrmInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtEan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEan.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtEan.Text <> "" Then
                ObjCaptura.Ean = Me.txtEan.Text
                ObjCaptura.Captura()

                txtDescripcion.Text = ObjCaptura.Descripcion
                lbSku.Text = ObjCaptura.Sku
                txtCantidad.Focus()

            End If
        End If
    End Sub

    Private Sub txtEan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEan.TextChanged

    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ObjCaptura.Descripcion = txtDescripcion.Text
        ObjCaptura.Cantidad = txtCantidad.Text
        ObjCaptura.Sku = lbSku.Text

        ObjCaptura.Inventario()
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            If txtCantidad.Text <> "" Then

                ObjCaptura.Descripcion = txtDescripcion.Text
                ObjCaptura.Cantidad = txtCantidad.Text
                ObjCaptura.Sku = lbSku.Text
                ObjCaptura.Ean = txtEan.Text
                ObjCaptura.Fecha = Now

                ObjCaptura.Inventario()
                ObjCaptura.Limpiar()

                txtEan.Text = ObjCaptura.Ean
                lbSku.Text = ObjCaptura.Sku
                txtDescripcion.Text = ObjCaptura.Descripcion
                txtCantidad.Text = ""
                txtEan.Focus()

            End If
        End If

    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub Inicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inicio.Click
        FrmPrincipal.Show()
        Me.Hide()
    End Sub
End Class