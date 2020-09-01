Public Class frmModifArt

    Dim art As New Empresa.Articulo
    Dim idArt As String

    Private Sub bttnBuscar_Click(sender As Object, e As EventArgs) Handles bttnBuscar.Click
        If txtIdArt.Text = "" Then
            dgvDelArt.DataSource = art.listarArt()
        Else
            dgvDelArt.DataSource = art.buscarArt(txtIdArt.Text)
        End If
    End Sub

    Private Sub mostrarTodo()
        txtFecha.Visible = True
        txtIdArt.Visible = True
        txtcod.Visible = True
        txtPrecio.Visible = True
        txtDesc.Visible = True

        lblCod.Visible = True
        lblDesc.Visible = True
        lblFech.Visible = True
        lblForm.Visible = True
        lblPre.Visible = True
    End Sub

    Private Sub dgvDelArt_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDelArt.CellDoubleClick
        Try
            Dim i As Integer
            i = dgvDelArt.CurrentRow.Index
            idArt = dgvDelArt.Item(0, i).Value()
            txtcod.Text = dgvDelArt.Item(1, i).Value()
            txtDesc.Text = dgvDelArt.Item(2, i).Value()
            txtPrecio.Text = dgvDelArt.Item(3, i).Value()
            txtFecha.Text = dgvDelArt.Item(4, i).Value()
            mostrarTodo()
            bttnModif.Visible = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub bttnModif_Click(sender As Object, e As EventArgs) Handles bttnModif.Click
        If art.modifArt(idArt, txtcod.Text, txtDesc.Text, txtPrecio.Text, txtFecha.Text) = True Then
            MsgBox("Articulo modificado correctamente!")
            dgvDelArt.DataSource = art.listarArt()
        End If
    End Sub
End Class