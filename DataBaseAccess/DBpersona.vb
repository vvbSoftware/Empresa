Imports MySql.Data.MySqlClient
Public Class DBpersona
    Inherits DBaccess
    Dim foto As String = "prueba"
    Dim db As New DBaccess
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
            db.consultaEjecutar(consulta)
            Return True
        Catch ex As Exception
            MsgBox("Fallo la conexión con la DB")
            Return False
        End Try

    End Function

    Public Function deleteP(cedula As String) As Boolean
        Dim consulta As String = "Delete from empleados where id_Persona=(select id_Persona from personas where cedula=" & cedula.ToString & ");"
        consulta = consulta & "Delete from personas where id_Persona=(select id_Persona from personas where cedula=" & cedula.ToString & ");"
        Try
            db.consultaEjecutar(consulta)
            Return True
        Catch ex As Exception
            MsgBox("Fallo la conexión con la DB")
            Return False
        End Try
    End Function

    Public Function buscarPersona(ced) As DataTable
        Dim consulta As String = "select id_persona, cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, telefono, direccion from personas where cedula=" & ced & ";"
        Return db.DevolverTabla(consulta)
    End Function

    Public Function listarPersonas() As DataTable
        Dim consulta As String = "select id_persona, cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, telefono, direccion from personas"
        Return db.DevolverTabla(consulta)
    End Function

    Public Function update(id,ced,pN,sN,pA,sA,tel,dir)
        Dim consulta As String = "update personas set "
        consulta = consulta & "cedula= '" & ced.ToString & "', "
        consulta = consulta & "primer_nombre= '" & pN & "', "
        consulta = consulta & "segundo_nombre= '" & sN & "', "
        consulta = consulta & "primer_apellido= '" & pA & "', "
        consulta = consulta & "segundo_apellido= '" & sA & "', "
        consulta = consulta & "telefono= '" & tel.ToString & "', "
        consulta = consulta & "direccion= '" & dir & "' "
        consulta = consulta & " where id_persona=" & id

        Return db.consultaEjecutar(consulta)
    End Function

End Class