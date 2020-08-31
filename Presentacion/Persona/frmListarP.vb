Public Class frmListarP

    Dim p As New Empresa.Persona
    Private Sub bttnBuscar_Click(sender As Object, e As EventArgs) Handles bttnBuscar.Click
        dgvListado.Visible() = True
        dgvListado.DataSource = p.listado
    End Sub
End Class