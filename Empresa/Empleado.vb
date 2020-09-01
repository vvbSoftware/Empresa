Imports System.Windows.Forms
Imports DataBaseAccess
Imports DataBaseAccess.DBempleado
Public Class Empleado : Inherits Persona
    Private TipoEmp As String
    Private sueldoMensual As Double

    Public Sub New(ciPersona As String, pNom As String, sNom As String, pApe As String, sApe As String, tel As String, dir As String, idEmp As Integer, idTipo As Integer, sueldoMensual As Double)
        MyBase.New(ciPersona, pNom, sNom, pApe, sApe, tel, dir)
        Me.TipoEmp = idTipo
        Me.sueldoMensual = sueldoMensual
    End Sub

    Public Sub New(tipoEmp As String, sueldoMensual As Double)
        Me.TipoEmp = tipoEmp
        Me.sueldoMensual = sueldoMensual
    End Sub

    Public Sub New()
    End Sub

    Dim dbe As New DBempleado

    Public Function addEmpleado(ci) As Boolean
        Return dbe.InsertEmpleado(ci, Me.TipoEmp, Me.sueldoMensual)
    End Function

    Public Function cargarTipoEmp()
        Return dbe.ObtenerTipoEmp()
    End Function

    Public Function cargarEmpleados()
        Return dbe.listarEmp()
    End Function

    Public Function elimEmp(idEmp) As Boolean
        Return dbe.DeleteEmpelado(idEmp)
    End Function


    Public Function buscarEmp(idEmp)
        Return dbe.buscar(idEmp)
    End Function

    Public Function modifEm(id, sueldo)
        Return dbe.modificar(id, sueldo)
    End Function

    'Public Sub cargarComboBox(cb As ComboBox)
    '    With cb
    '        .DataSource = dbe.tablaTipoEmp.Tables(0)
    '        .DisplayMember = "tipo_empleado" 'el nombre de tu columna de tu base de datos que deseas mostrar
    '        .ValueMember = "id_tipo_empleado" 'el id de tu tabla relacionada con el nombre que muestras 
    '        .Text = "TIPO"
    '    End With

    'End Sub

End Class
