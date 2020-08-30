Imports DataBaseAccess.DBempleado
Public Class Empleado : Inherits Persona
    Private idEmp As Integer
    Private idTipo As Integer
    Private sueldoMensual As Double

    Public Sub New(ciPersona As String, pNom As String, sNom As String, pApe As String, sApe As String, tel As String, dir As String, idEmp As Integer, idTipo As Integer, sueldoMensual As Double)
        MyBase.New(ciPersona, pNom, sNom, pApe, sApe, tel, dir)
        Me.idEmp = idEmp
        Me.idTipo = idTipo
        Me.sueldoMensual = sueldoMensual
    End Sub

    Dim dbEmp As New DataBaseAccess.DBempleado
    Public Function addEmpleado() As Boolean
        Return dbEmp.InsertEmpleado(Me.idEmp, "", Me.idTipo, Me.sueldoMensual)
    End Function


End Class
