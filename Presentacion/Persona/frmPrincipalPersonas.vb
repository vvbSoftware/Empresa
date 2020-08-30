Public Class frmPrincipalPersonas
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmInicio.Show()
        Me.Close()
    End Sub

    Dim frmIn As New frmInicio

    Private Sub btnAddPer_Click(sender As Object, e As EventArgs) Handles btnAddPer.Click
        frmIn.OpenChildForm(frmAltaP, panelPer)
    End Sub

    Private Sub btnModifP_Click(sender As Object, e As EventArgs) Handles btnModifP.Click
        frmIn.OpenChildForm(frmModifP, panelPer)
    End Sub

    Private Sub btnElimP_Click(sender As Object, e As EventArgs) Handles btnElimP.Click
        frmIn.OpenChildForm(frmElimP, panelPer)
    End Sub

    Private Sub btnListarP_Click(sender As Object, e As EventArgs) Handles btnListarP.Click
        frmIn.OpenChildForm(frmListarP, panelPer)
    End Sub
End Class