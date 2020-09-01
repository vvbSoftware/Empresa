Imports Empresa.Persona
Public Class frmAltaP

    Private Sub bttnIngP_Click(sender As Object, e As EventArgs) Handles bttnIngP.Click
        If (txtci.Text = "" Or txtPnom.Text = "" Or txtPape.Text = "" Or txtSape.Text = "" Or txtDir.Text = "" Or txtTel.Text = "") Then
            MsgBox("Los campos con * son obligatorios!")
        Else
            Dim per As New Empresa.Persona(txtci.Text, txtPnom.Text, txtSnom.Text, txtPape.Text, txtSape.Text, txtTel.Text, txtDir.Text)
            If (per.addPersona()) = True Then
                MsgBox("Persona Agregada correctamente!")
                txtci.Text = ""
                txtDir.Text = ""
                txtPape.Text = ""
                txtPnom.Text = ""
                txtSape.Text = ""
                txtSnom.Text = ""
                txtTel.Text = ""
            Else
                MsgBox("Error de conexion")
            End If
        End If
    End Sub
End Class