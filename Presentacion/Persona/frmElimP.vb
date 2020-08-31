Public Class frmElimP

    Dim p As New Empresa.Persona

    Private Sub bttnElimP_Click(sender As Object, e As EventArgs) Handles bttnElimP.Click
        If txtci.Text = "" Then
            MsgBox("Debe ingresar una cédula valida!")
        Else
            If p.elimPersona(txtci.Text) = True Then
                MsgBox("Persona eliminada con éxito!")
                txtci.Text = ""
            End If
        End If
    End Sub

    Private Sub bttnBuscar_Click(sender As Object, e As EventArgs) Handles bttnBuscar.Click

        If txtci.Text = "" Then
            MsgBox("Debe ingresar una cédula valida!")
        Else
            dgvPersona.Visible() = True
            Try
                dgvPersona.DataSource = p.Buscar(txtci.Text)
            Catch ex As Exception
                MsgBox("Error al conectar a la BD")
            End Try

        End If

    End Sub

End Class