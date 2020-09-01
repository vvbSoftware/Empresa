Public Class frmPrincipalEmpleados
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        frmInicio.Show()
    End Sub

    Dim frmIn As New frmInicio

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs) Handles btnAddEmp.Click
        frmIn.OpenChildForm(frmAltaE, panelEmp)
    End Sub

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        frmIn.OpenChildForm(frmModifE, panelEmp)
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        frmIn.OpenChildForm(frmListarE, panelEmp)
    End Sub

    Private Sub btnElim_Click(sender As Object, e As EventArgs) Handles btnElim.Click
        frmIn.OpenChildForm(frmBajaE, panelEmp)
    End Sub

    Private Sub btnGestTipoEmp_Click(sender As Object, e As EventArgs) Handles btnGestTipoEmp.Click
        frmIn.OpenChildForm(frmGestionTipoEmp, panelEmp)
    End Sub
End Class