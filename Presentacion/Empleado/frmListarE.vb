Public Class frmListarE

    Dim emp As New Empresa.Empleado

    Private Sub btnCargarDGV_Click(sender As Object, e As EventArgs) Handles btnCargarDGV.Click
        dgvListarE.DataSource = emp.cargarEmpleados()
    End Sub
End Class