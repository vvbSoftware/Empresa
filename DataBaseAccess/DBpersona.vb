Imports MySql.Data.MySqlClient
Public Class DBpersona
    Inherits DBaccess
    Dim foto As String = "prueba"
    Dim dbp As New DBaccess
    Public Function InsertPersona(ciPersona As String, 'foto As String,'
                                  pNom As String, sNom As String, pApe As String, sApe As String, tel As String, dir As String) As Boolean
        Dim consulta As String = "insert into personas VALUES ("
        consulta = consulta & "'" & "',"
        consulta = consulta & "'" & ciPersona.ToString & "',"
        consulta = consulta & "'" & Me.foto & "',"
        consulta = consulta & "'" & pNom & "',"
        consulta = consulta & "'" & sNom & "',"
        consulta = consulta & "'" & pApe & "',"
        consulta = consulta & "'" & sApe & "',"
        consulta = consulta & "'" & tel & "',"
        consulta = consulta & "'" & dir & "')"

        Try
            dbp.consultaEjecutar(consulta)
            Return True
        Catch ex As Exception
            MsgBox("Fallo la conexión con la DB")
            Return False
        End Try

    End Function

    Public Function DeleteEmpelado(id As String) As Boolean
        Dim consulta As String = "Delete from Empleados where idEmp=" & id & ";"
        Try
            dbp.consultaEjecutar(consulta)

            Return True
        Catch ex As Exception
            MsgBox("Fallo la conexión con la DB")
            Return False
        End Try
    End Function

End Class
