Public Class frmModifP

    Dim p As New Empresa.Persona
    Private Sub bttnBuscar_Click(sender As Object, e As EventArgs) Handles bttnBuscar.Click
        dgvModifP.Visible() = True
        If txtci.Text = "" Then
            dgvModifP.DataSource = p.listado()
        Else
            dgvModifP.DataSource = p.Buscar(txtci.Text)
        End If
        mostrarTodo()
    End Sub


    Private Sub dgvModifP_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvModifP.CellDoubleClick
        Try
            Dim i As Integer
            i = dgvModifP.CurrentRow.Index
            txtIdP.Text = dgvModifP.Item(0, i).Value().ToString
            txtcedula.Text = dgvModifP.Item(1, i).Value().ToString
            'txtFoto.Text = dgvModifP.Item(2, i).Value()
            txtPnom.Text = dgvModifP.Item(2, i).Value()
            txtSnom.Text = dgvModifP.Item(3, i).Value().ToString
            txtPape.Text = dgvModifP.Item(4, i).Value()
            txtSape.Text = dgvModifP.Item(5, i).Value().ToString
            txtTel.Text = dgvModifP.Item(6, i).Value().ToString
            txtDir.Text = dgvModifP.Item(7, i).Value()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub mostrarTodo()
        txtcedula.Visible = True
        txtDir.Visible = True
        txtPape.Visible = True
        txtPnom.Visible = True
        txtSape.Visible = True
        txtSnom.Visible = True
        txtTel.Visible = True
        bttnGuardar.Visible = True

        lblci.Visible = True
        lblDir.Visible = True
        lblpA.Visible = True
        lblpN.Visible = True
        lblsA.Visible = True
        lblsN.Visible = True
        lblTel.Visible = True
    End Sub

    Private Sub bttnGuardar_Click(sender As Object, e As EventArgs) Handles bttnGuardar.Click
        If (p.modificar(txtIdP.Text, txtcedula.Text, txtPnom.Text, txtSnom.Text, txtPape.Text, txtSape.Text, txtTel.Text, txtDir.Text)) = True Then
            MsgBox("Persona editada correctamente!")
        End If
    End Sub


End Class