Imports MySql.Data.MySqlClient
Public Class DBarticulo
    Inherits DBaccess

    Dim consulta As String


    Public Function insertArt(codigo As Integer, descripcion As String, precio As Double, fecha_fabricacion As String) As Boolean
        consulta = "insert into articulos values ("
        consulta = consulta & "'',"
        consulta = consulta & codigo.ToString & ","
        consulta = consulta & "'" & descripcion & "',"
        consulta = consulta & "'" & fecha_fabricacion & "',"
        consulta = consulta & "'" & precio.ToString & "');"

        Return consultaEjecutar(consulta)
    End Function

    Public Function deleteArt(idArt As String) As Boolean
        consulta = "delete from articulos where id_articulo=" & idArt & ";"
        Return consultaEjecutar(consulta)
    End Function

    Public Function listadoArt() As DataTable
        consulta = "select * from articulos"
        Return DevolverTabla(consulta)
    End Function

    Public Function Buscar(codigo As String) As DataTable
        consulta = "select * from articulos where codigo=" & codigo & ";"
        Return DevolverTabla(consulta)
    End Function

    Public Function modifcar(id, cod, desc, fech, precio) As Boolean
        consulta = "update articulos set"
        consulta = consulta & "codigo='" & cod.ToString & "',"
        consulta = consulta & "descripcion='" & desc & "',"
        consulta = consulta & "fecha_fabricacion='" & fech & "',"
        consulta = consulta & "precio='" & precio.ToString & "' where id_articulo=" & id & ";"
        Return consultaEjecutar(consulta)
    End Function
End Class
