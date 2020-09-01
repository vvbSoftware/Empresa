Imports DataBaseAccess
Public Class DBtipo_emp
    Inherits DBaccess

    Public Function insertTE(tipo_empleado As String) As Boolean
        Dim consulta As String = "insert into tipos_empleados(tipo_empleado) values ('" & tipo_empleado.ToString.ToUpper & "')"
        Return consultaEjecutar(consulta)
    End Function

    Public Function update(tipo As String, id As String) As Boolean
        Dim consulta As String = "update tipos_empleados set tipo_empleado='" & tipo.ToString.ToUpper & "' where id_tipo_empleado='" & id.ToString & "';"
        Return consultaEjecutar(consulta)
    End Function

    Public Function delete(id As String) As Boolean
        Dim consulta As String = "delete from tipos_empleados where id_tipo_empleado='" & id.ToString & "';"
        Return consultaEjecutar(consulta)
    End Function

    Public Function listarTE() As DataTable
        Dim consulta As String = "select * from tipos_empleados"
        Return DevolverTabla(consulta)
    End Function
End Class
