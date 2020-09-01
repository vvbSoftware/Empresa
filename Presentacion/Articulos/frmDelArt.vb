Public Class frmDelArt

    Dim art As New Empresa.Articulo
    Dim idArt As New Integer
    Private Sub bttnBuscar_Click(sender As Object, e As EventArgs) Handles bttnBuscar.Click
        If txtIdArt.Text = "" Then
            dgvDelArt.DataSource = art.listarArt()
        Else
            dgvDelArt.DataSource = art.buscarArt(txtIdArt.Text)
        End If
    End Sub

    Private Sub bttnElimA_Click(sender As Object, e As EventArgs) Handles bttnElimA.Click
        If art.removeArt(idArt) = True Then
            MsgBox("Articulo eliminado exitosamente!")
            dgvDelArt.DataSource = art.listarArt()
        Else
            MsgBox("No se pudo finalizar la accion, intente mas tarde!")
        End If
    End Sub

    Private Sub dgvDelArt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDelArt.CellDoubleClick
        Try
            Dim i As Integer
            i = dgvDelArt.CurrentRow.Index
            idArt = dgvDelArt.Item(0, i).Value().ToString
            bttnElimA.Visible = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class