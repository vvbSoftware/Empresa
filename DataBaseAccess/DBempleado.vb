Imports MySql.Data.MySqlClient
Public Class DBempleado
    Inherits DBaccess

    Dim db As New DBaccess
    Public Function InsertEmpleado(idEmp As Integer, idPersona As Integer, idTipo As Integer, sueldoMensual As Double) As Boolean
        Dim consulta As String = "insert into empleados VALUES ("
        consulta = consulta & "'" & idEmp.ToString & "',"
        consulta = consulta & idPersona.ToString & ","
        consulta = consulta & "'" & idTipo.ToString & "',"
        consulta = consulta & "'" & sueldoMensual.ToString & "')"

        Try
            db.consultaEjecutar(consulta)
            Return True
        Catch ex As Exception
            MsgBox("Fallo la conexión con la DB")
            Return False
        End Try

    End Function

    Public Function DeleteEmpelado(id As String) As Boolean
        Dim consulta As String = "Delete from Empleados where idEmp=" & id & ";"
        Try
            db.consultaEjecutar(consulta)
            Return True
        Catch ex As Exception
            MsgBox("Fallo la conexión con la DB")
            Return False
        End Try
    End Function

End Class
