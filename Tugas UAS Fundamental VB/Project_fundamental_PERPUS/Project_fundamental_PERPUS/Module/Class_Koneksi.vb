Imports MySql.Data.MySqlClient
Public Class Class_Koneksi
    Dim str As String = "server=localhost;uid=root;pswd=;database=db_perpustakaan"
    Private conn As New MySqlConnection(str)
    Public query As String
    Public query1 As String
    Public query2 As String
    Protected adpt As MySqlDataAdapter
    Protected cmd As MySqlCommand
    Protected rd As MySqlDataReader
    Protected dt As DataTable


    Public Function bukaKoneksi() As MySqlConnection
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        Else
            conn.Close()
        End If
        Return conn
    End Function
End Class
