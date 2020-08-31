Public Class frmModifE

    Dim emp As New Empresa.Empleado
    Dim idEmp As String
    Private Sub dgvModifP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvModifP.CellDoubleClick
        Try
            Dim i As Integer
            i = dgvModifP.CurrentRow.Index
            idEmp = dgvModifP.Item(0, i).Value().ToString
            txtSueldo.Text = dgvModifP.Item(3, i).Value().ToString
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub bttnBuscar_Click(sender As Object, e As EventArgs) Handles bttnBuscar.Click
        If (txtidEmp.Text = "") Then
            dgvModifP.DataSource = emp.buscarEmp("")
        Else
            dgvModifP.DataSource = emp.buscarEmp(txtidEmp.Text)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If emp.modifEm(idEmp, txtSueldo.Text) = True Then
            MsgBox("Empleado actualizado correctamente")
            dgvModifP.DataSource = emp.buscarEmp(idEmp)
        End If
    End Sub
End Class