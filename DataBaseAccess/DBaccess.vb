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
            MsgBox("ERROR COMPRUEBE LA CONEXIÓN A INTERNET::" & ex.Message)
            conn.Close()
            Return False
        End Try
    End Function

    Public Function DevolverTabla(consulta) As DataTable
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

    'Public Function DevolverParaComboBox(consulta As String) As DataSet
    '    Dim dataSet As New DataSet
    '    Dim adapter As MySqlDataAdapter
    '    Dim commadnSQL As MySqlCommand

    '    Try
    '        conn.Open()
    '        commadnSQL = New MySqlCommand()
    '        commadnSQL.CommandText = consulta
    '        commadnSQL.CommandType = CommandType.Text
    '        commadnSQL.Connection = conn

    '        adapter = New MySqlDataAdapter(commadnSQL)
    '        adapter.Fill(dataSet)
    '        conn.Close()
    '    Catch ex As Exception
    '        MsgBox("Error:: " & ex.Message)
    '        conn.Close()
    '    End Try
    '    Return dataSet
    'End Function


End Class
