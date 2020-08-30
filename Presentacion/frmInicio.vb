Public Class frmInicio

    Protected currentForm As Form = Nothing 'form en el panel no esta visible porque es el inicio de la app
    'Metodo para abrir ventanas dentro de la principal
    Public Sub OpenChildForm(childForm As Form, PanelChildForm As Panel)
        If currentForm IsNot Nothing Then currentForm.Close() 'prenguto si hay un form abierto
        currentForm = childForm 'cargo el form que quiero abrir
        'Le pongo los estilos que necesito
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        'muestro el form
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub btnGestionP_Click(sender As Object, e As EventArgs) Handles btnGestionP.Click
        Me.Hide()
        frmPrincipalPersonas.Show()
    End Sub

    Private Sub btnGestionE_Click(sender As Object, e As EventArgs) Handles btnGestionE.Click
        Me.Hide()
        frmPrincipalPersonas.Show()
    End Sub

    Private Sub btnGestionA_Click(sender As Object, e As EventArgs) Handles btnGestionA.Click
        Me.Hide()
        frmPrincipalArticulos.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
