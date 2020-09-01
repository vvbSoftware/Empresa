Imports MySql.Data.MySqlClient
Public Class DBarticulo
    Inherits DBaccess

    Dim consulta As String


    Public Function insertArt(codigo As Integer, descripcion As String, precio As Double, fecha_fabricacion As String) As Boolean
        consulta = "insert into articulos(`codigo`,`descripcion`, `precio`, `fecha_fabricacion`) values ("
        consulta = consulta & codigo.ToString & ","
        consulta = consulta & "'" & descripcion & "',"
        consulta = consulta & "'" & precio.ToString & "',"
        consulta = consulta & "'" & fecha_fabricacion & "');"

        Return consultaEjecutar(consulta)
    End Function

    Public Function deleteArt(idArt As String) As Boolean
        consulta = "delete from articulos where id_articulo=" & idArt & ";"
        Return consultaEjecutar(consulta)
    End Function

    Public Function listadoArt() As DataTable
        consulta = "select id_articulo, codigo, descripcion, precio, fecha_fabricacion from articulos"
        Return DevolverTabla(consulta)
    End Function

    Public Function Buscar(codigo As String) As DataTable
        consulta = "select id_articulo, codigo, descripcion, precio, fecha_fabricacion from articulos where codigo='" & codigo & "';"
        Return DevolverTabla(consulta)
    End Function

    Public Function modifcar(id, cod, desc, precio, fech) As Boolean
        consulta = "update articulos set "
        consulta = consulta & "codigo='" & cod.ToString & "',"
        consulta = consulta & "descripcion='" & desc & "',"
        consulta = consulta & "fecha_fabricacion='" & fech & "',"
        consulta = consulta & "precio='" & precio.ToString & "' where id_articulo=" & id & ";"
        Return consultaEjecutar(consulta)
    End Function
End Class
