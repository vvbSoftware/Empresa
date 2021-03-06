﻿Imports MySql.Data.MySqlClient
Public Class DBempleado
    Inherits DBaccess

    Dim db As New DBaccess


    Public Function InsertEmpleado(ci As String, nomTipo As String, sueldoMensual As Double) As Boolean
        Dim consultaParaIdPersona As String = "(select id_persona from personas where cedula=" & ci & ")"
        Dim consultaParaIdTipoEmp As String = "(select id_tipo_empleado from tipos_empleados where tipo_empleado='" & nomTipo.ToString & "')"
        Dim consulta As String = "insert into empleados VALUES ("
        consulta = consulta & "'',"
        consulta = consulta & consultaParaIdPersona.ToString & ","
        consulta = consulta & consultaParaIdTipoEmp.ToString & ","
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
        Dim consulta As String = "Delete from Empleados where id_empleado='" & id.ToString & "';"
        Try
            db.consultaEjecutar(consulta)
            Return True
        Catch ex As Exception
            MsgBox("Fallo la conexión con la DB")
            Return False
        End Try
    End Function

    Public Function ObtenerTipoEmp() As DataTable
        Dim consulta As String = "select tipo_empleado from tipos_empleados"
        Return db.DevolverTabla(consulta)
    End Function

    Public Function listarEmp() As DataTable
        Dim consulta As String = "select E.id_persona,id_empleado,cedula,primer_nombre,primer_apellido,tipo_empleado,sueldoMens,telefono,direccion from empleados E,tipos_empleados,personas P where P.id_persona=E.id_persona and id_tipo=id_tipo_empleado"
        Return db.DevolverTabla(consulta)
    End Function

    Public Function buscar(id As String) As DataTable
        Dim consulta As String
        If (id = "") Then
            consulta = "select * from empleados;"
        Else
            consulta = "select * from empleados where id_empleado=" & id.ToString & ";"
        End If

        Return db.DevolverTabla(consulta)
    End Function

    Public Function modificar(idEmp As String, Sueldo As String) As Boolean
        Dim consulta As String = "update empleados set sueldoMens='" & Sueldo.ToString & "' where id_empleado='" & idEmp & "';"
        Return db.consultaEjecutar(consulta)
    End Function

    'Public Function tablaTipoEmp() As DataSet
    '    Dim consulta As String = "Select * from tipos_empleados"
    '    Return DevolverParaComboBox(consulta)
    'End Function


End Class
