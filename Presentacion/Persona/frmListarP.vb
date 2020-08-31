Public Class frmListarP

    Dim p As New Empresa.Persona
    Private Sub bttnBuscar_Click(sender As Object, e As EventArgs) Handles bttnBuscar.Click
        dgvListado.Visible() = True
        Try
            dgvListado.DataSource = p.listado
        Catch ex As Exception
            MsgBox("Error al conectar a la BD")
        End Try

    End Sub

End Class