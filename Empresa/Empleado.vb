Imports System.Windows.Forms
Imports DataBaseAccess.DBempleado
Public Class Empleado : Inherits Persona
    Private idTipo As Integer
    Private sueldoMensual As Double

    Public Sub New(ciPersona As String, pNom As String, sNom As String, pApe As String, sApe As String, tel As String, dir As String, idEmp As Integer, idTipo As Integer, sueldoMensual As Double)
        MyBase.New(ciPersona, pNom, sNom, pApe, sApe, tel, dir)
        Me.idTipo = idTipo
        Me.sueldoMensual = sueldoMensual
    End Sub

    Public Sub New(idTipo As Integer, sueldoMensual As Double)
        Me.idTipo = idTipo
        Me.sueldoMensual = sueldoMensual
    End Sub

    Public Sub New()
    End Sub

    Dim dbe As New DataBaseAccess.DBempleado

    Public Function addEmpleado(ci) As Boolean
        Return dbe.InsertEmpleado(ci, Me.idTipo, Me.sueldoMensual)
    End Function

    Public Function cargarTipoEmp()
        Return dbe.ObtenerTipoEmp()
    End Function

    Public Function cargarEmpleados()
        Return dbe.listarEmp()
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
