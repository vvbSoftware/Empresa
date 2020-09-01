Public Class frmListarArt

    Dim art As New Empresa.Articulo
    Private Sub btnCargarGrilla_Click(sender As Object, e As EventArgs) Handles btnCargarGrilla.Click
        dgvListArt.DataSource = art.listarArt()
    End Sub
End Class