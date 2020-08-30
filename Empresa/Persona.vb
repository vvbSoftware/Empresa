Public Class Persona
    Private ciPersona As String
    'Private foto As String
    Private pNom As String
    Private sNom As String
    Private pApe As String
    Private sApe As String
    Private tel As String
    Private dir As String

    Public Sub New()

    End Sub

    Public Sub New(ciPersona As String,' foto As String'
                   pNom As String, sNom As String, pApe As String, sApe As String, tel As String, dir As String)
        Me.ciPersona = ciPersona
        'Me.foto = foto
        Me.pNom = pNom
        Me.sNom = sNom
        Me.pApe = pApe
        Me.sApe = sApe
        Me.tel = tel
        Me.dir = dir
    End Sub



    Dim dbp As New DataBaseAccess.DBpersona

    Public Function addPersona() As Boolean
        Return dbp.InsertPersona(Me.ciPersona,' Me.foto,'
                                 Me.pNom, Me.sNom, Me.pApe, Me.sApe, Me.tel, Me.dir)
    End Function


End Class