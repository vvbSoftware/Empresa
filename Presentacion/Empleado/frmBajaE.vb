Public Class frmBajaE

    Dim emp As New Empresa.Empleado

    Private Sub frmBajaE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBaja.DataSource = emp.cargarEmpleados()
    End Sub
End Class