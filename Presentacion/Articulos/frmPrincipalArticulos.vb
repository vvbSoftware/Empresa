Public Class frmPrincipalArticulos
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        frmInicio.Show()
    End Sub

    Private Sub btnAddArt_Click(sender As Object, e As EventArgs) Handles btnAddArt.Click
        frmInicio.OpenChildForm(frmAddArt, panelArt)
    End Sub

    Private Sub btnElimA_Click(sender As Object, e As EventArgs) Handles btnElimA.Click
        frmInicio.OpenChildForm(frmDelArt, panelArt)
    End Sub

    Private Sub btnModifA_Click(sender As Object, e As EventArgs) Handles btnModifA.Click
        frmInicio.OpenChildForm(frmModifArt, panelArt)
    End Sub

    Private Sub btnListarA_Click(sender As Object, e As EventArgs) Handles btnListarA.Click
        frmInicio.OpenChildForm(frmListarArt, panelArt)
    End Sub
End Class