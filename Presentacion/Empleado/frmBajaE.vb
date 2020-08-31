Public Class frmBajaE

    Dim emp As New Empresa.Empleado
    Private idemp As String
    Private Sub frmBajaE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBaja.DataSource = emp.cargarEmpleados()
    End Sub

    Private Sub dgvBaja_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaja.CellDoubleClick
        Try
            Dim i As Integer
            i = dgvBaja.CurrentRow.Index
            idemp = dgvBaja.Item(1, i).Value().ToString
            btnElim.Visible = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnElim_Click(sender As Object, e As EventArgs) Handles btnElim.Click

        If MessageBox.Show("Seguro que desea eliminar al empleado nro:" & idemp, "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                If (emp.elimEmp(idemp)) = True Then
                    dgvBaja.DataSource = emp.cargarEmpleados()
                    MsgBox("Empleado eliminado correctamente")
                Else
                    MsgBox("Error fatal, no se pudo eliminar empleado")
                End If
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End If

    End Sub
End Class