Public Class frmAddArt

    Dim fecha As String
    Private Sub bttnIngArt_Click(sender As Object, e As EventArgs) Handles bttnIngArt.Click
        If (txtcod.Text = "" Or txtDesc.Text = "" Or txtDia.Text = "" Or txtMes.Text = "" Or txtAnio.Text = "" Or txtPrecio.Text = "") Then
            MsgBox("Todos los campos son obligatorios!")
        Else
            fecha = txtDia.Text & "/" & txtMes.Text & "/" & txtAnio.Text
            Dim art As New Empresa.Articulo(txtcod.Text, txtDesc.Text, txtPrecio.Text, fecha)
            If art.addArt() = True Then
                MsgBox("Articulo agregado correctamente!")
            End If
        End If
    End Sub

End Class