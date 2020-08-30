Imports MySql.Data.MySqlClient
Public Class DBaccess

    Private connString As String = "server=localhost;database=empresa;user id=root;password=;port=3306;"
    Private conn As New MySqlConnection

    Public Sub New(connString As String, conn As MySqlConnection)
        Me.connString = connString
        Me.conn = conn
    End Sub

    Protected Sub New()
        conn = New MySqlConnection(connString)
    End Sub

    'Protected Function GetConnection() As MySqlConnection
    '    Return New MySqlConnection(connString)
    'End Function

    'Public Sub OpenConnection() 'Metodo para abrir conexion
    '    conn.Open()
    'End Sub

    'Public Sub CloseConnection() 'Metodo para cerrar conexion
    '    conn.Close()
    'End Sub

    ' Para ejecutar las consultas
    Public Function consultaEjecutar(consulta As String)
        Dim commandSQL As New MySqlCommand(consulta, conn)
        Try
            conn.Open()
            commandSQL.ExecuteNonQuery()
            conn.Close()
            Return True
        Catch ex As Exception
            MsgBox("ERROR::" & ex.Message)
            Return False
            conn.Close()
        End Try
    End Function

    Public Function ListarTabla(consulta) As DataTable
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter

        Try
            da = New MySqlDataAdapter(consulta, conn)
            conn.Open()
            da.Fill(ds)
            dt = ds.Tables(0)
            conn.Close()
        Catch ex As Exception
            MsgBox("Error de conexión, verifique que tenga acceso a internet. " & ex.Message)
        End Try
        Return dt
    End Function


End Class
