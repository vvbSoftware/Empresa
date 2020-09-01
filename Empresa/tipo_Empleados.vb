Public Class tipo_Empleados
    Private tipo_empleado As String

    Public Sub New()
    End Sub

    Public Sub New(tipo_empleado As String)
        Me.tipo_empleado = tipo_empleado
    End Sub

    Dim dbt_e As New DataBaseAccess.DBtipo_emp

    Public Function AddTE() As Boolean
        Return dbt_e.insertTE(Me.tipo_empleado)
    End Function

    Public Function modifTE(tipo, id) As Boolean
        Return dbt_e.update(tipo, id)
    End Function

    Public Function borrarTE(id) As Boolean
        Return dbt_e.delete(id)
    End Function

    Public Function ver()
        Return dbt_e.listarTE()
    End Function
End Class
