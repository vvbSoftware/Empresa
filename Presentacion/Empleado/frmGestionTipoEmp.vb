
Imports Empresa
Public Class frmGestionTipoEmp
    Dim idT As String

    Private Sub bttnAddTE_Click(sender As Object, e As EventArgs) Handles bttnAddTE.Click
        Dim Temp As New tipo_Empleados(txtIngTE.Text)
        If Temp.AddTE() = True Then
            MsgBox("Tipo de empleado agregado correctamente!")
            txtIngTE.Text = ""
        Else
            MsgBox("Error de conexion")
        End If
    End Sub

    Dim Temp As New tipo_Empleados


    Private Sub dgvTipoEmp_DoubleClick(sender As Object, e As EventArgs) Handles dgvTipoEmp.DoubleClick
        Try
            Dim i As Integer
            i = dgvTipoEmp.CurrentRow.Index
            idT = dgvTipoEmp.Item(0, i).Value().ToString
            txtModifTE.Text = dgvTipoEmp.Item(1, i).Value().ToString
            txtModifTE.Enabled = True
            btnElimTE.Enabled = True
            bttnModif.Enabled = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        dgvTipoEmp.DataSource = Temp.ver()
    End Sub

    Private Sub bttnModif_Click(sender As Object, e As EventArgs) Handles bttnModif.Click
        If Temp.modifTE(txtModifTE.Text, idT) = True Then
            MsgBox("Tipo de empleado modificado correctamente!")
            dgvTipoEmp.DataSource = Temp.ver()

        Else
            MsgBox("Error de conexion")
        End If
    End Sub

    Private Sub btnElimTE_Click(sender As Object, e As EventArgs) Handles btnElimTE.Click

        If MessageBox.Show("Seguro que desea eliminar al tipo de empleado nro:" & idT, "Advertencia",
         MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If Temp.borrarTE(idT) = True Then
                MsgBox("Eliminado correctamente!")
                dgvTipoEmp.DataSource = Temp.ver()
            End If
        End If



    End Sub
End Class