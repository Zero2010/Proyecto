Imports Controlador

Public Class FrmEliminarPatente

    Dim ObjElimarPatente As New classInventario

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        ObjElimarPatente.Patente = txtPatente.Text
        ObjElimarPatente.EliminarPat()
        ObjElimarPatente.Limpiar()
        FrmInventario.Show()
        Me.Close()
    End Sub
End Class