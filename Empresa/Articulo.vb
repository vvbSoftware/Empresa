Imports DataBaseAccess

Public Class Articulo
    Private codigo As Integer
    'Private foto
    Private descripcion As String
    Private precio As Double
    Private fecha_fabricacion As String

    Public Sub New(codigo As Integer, descripcion As String, precio As Double, fecha_fabricacion As String)
        Me.codigo = codigo
        Me.descripcion = descripcion
        Me.precio = precio
        Me.fecha_fabricacion = fecha_fabricacion
    End Sub

    Public Sub New()
    End Sub

    Dim dba As New DBarticulo

    Public Function addArt() As Boolean
        Return dba.insertArt(Me.codigo, Me.descripcion, Me.precio, Me.fecha_fabricacion)
    End Function

    Public Function removeArt(idArt) As Boolean
        Return dba.deleteArt(idArt)
    End Function

    Public Function listarArt()
        Return dba.listadoArt()
    End Function

    Public Function buscarArt(codigo)
        Return dba.Buscar(codigo)
    End Function

    Public Function modifArt(idArt, cod, descrip, fecha, precio)
        Return dba.modifcar(idArt, cod, descrip, fecha, precio)
    End Function


End Class
