Public Class frmAltaE

    Dim emp As New Empresa.Empleado
    Private Sub frmAltaE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'emp.cargarComboBox(cbTipoEmp)
        dgvTipoEmp.DataSource = emp.cargarTipoEmp()
    End Sub

    Private Sub bttnIngE_Click(sender As Object, e As EventArgs) Handles bttnIngE.Click
        If (txtci.Text = "" Or txtSueldo.Text = "" Or txtTipoEmp.Text = "") Then
            MsgBox("Todos los campos son obligatorios!")
        Else
            Dim emp As New Empresa.Empleado(txtTipoEmp.Text, txtSueldo.Text)
            If emp.addEmpleado(txtci.Text) = True Then
                MsgBox("Empleado agregado correctamente!")
                txtci.Text = ""
                txtSueldo.Text = ""
                txtTipoEmp.Text = ""
            Else
                MsgBox("No se pudo agregar al empleado!")
            End If
        End If
    End Sub

    Private Sub dgvTipoEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoEmp.CellClick
        Try
            Dim i As Integer
            i = dgvTipoEmp.CurrentRow.Index
            txtTipoEmp.Text = dgvTipoEmp.Item(0, i).Value().ToString
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


End Class