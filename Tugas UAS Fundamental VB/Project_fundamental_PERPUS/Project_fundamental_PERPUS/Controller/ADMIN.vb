Imports MySql.Data.MySqlClient
Public Class ADMIN
    Inherits Class_CRUD
    Dim obj_crud As New Class_CRUD
    Private _namaadmin As String
    Private _usadmin As String
    Private _passadmin As String
    Private _akses As String
    Private _status As String
    Private _alamatgbr As String

    Public Property alamatgbr() As String
        Get
            Return _alamatgbr
        End Get
        Set(ByVal value As String)
            _alamatgbr = value
        End Set
    End Property

    Public Property status() As String
        Get
            Return _status
        End Get
        Set(ByVal value As String)
            _status = value
        End Set
    End Property

    Public Property akses() As String
        Get
            Return _akses
        End Get
        Set(ByVal value As String)
            _akses = value
        End Set
    End Property

    Public Property namaadmin() As String
        Get
            Return _namaadmin
        End Get
        Set(ByVal value As String)
            _namaadmin = value
        End Set
    End Property

    Public Property usadmin() As String
        Get
            Return _usadmin
        End Get
        Set(ByVal value As String)
            _usadmin = value
        End Set
    End Property

    Public Property passadmin() As String
        Get
            Return _passadmin
        End Get
        Set(ByVal value As String)
            _passadmin = value
        End Set
    End Property

    '---------- Method Tampil -----------
    Public Function lht_admin() As DataTable
        query = "SELECT * FROM tb_admin where Status='" & "Admin" & "'"
        Try
            dt = obj_crud.tampil_data(query)
        Catch ex As Exception

        End Try
        Return dt
    End Function

    Public Function lht_pustakawan() As DataTable
        query = "SELECT * FROM tb_admin where Status='" & "Pustakawan" & "'"
        Try
            dt = obj_crud.tampil_data(query)
        Catch ex As Exception

        End Try
        Return dt
    End Function

    '---------- Method Tambah -----------
    Public Function tbh_admin(ByVal _admin As ADMIN) As Boolean
        Dim hasil As Boolean = False
        query = "INSERT INTO tb_admin VALUES('" & "" & "','" & _admin.namaadmin & "','" & _admin.usadmin & "','" & _admin.passadmin & "','" & _admin.status & "',@Foto)"
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.Parameters.Add("Foto", MySqlDbType.VarChar).Value = _admin.alamatgbr
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan !!!", MsgBoxStyle.Information, "Informasi")
            Return True
        Catch ex As Exception
            Return False
        Finally
            bukaKoneksi()
        End Try
        Return hasil
    End Function

    '---------- Method Ubah -----------
    Public Function ubh_admin(ByVal _admin As ADMIN) As Boolean
        Dim hasil As Boolean = False
        query = "UPDATE tb_admin SET Nama_admin='" & _admin.namaadmin & "',Username='" & _admin.usadmin & "',Password='" & _admin.passadmin & "',Status='" & _admin.status & "',Foto=@Foto where User_id='" & Ubah_Admin.txt_admin_id_ubah.Text & "'"
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.Parameters.Add("Foto", MySqlDbType.VarChar).Value = _admin.alamatgbr
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diubah !!!", MsgBoxStyle.Information, "Informasi")
            Return True
        Catch ex As Exception
            Return False
        Finally
            bukaKoneksi()
        End Try
        Return hasil
    End Function

    '---------- Method Hapus -----------
    Public Function hps_admin() As Boolean
        Dim hasil As Boolean = False
        query = "DELETE FROM tb_admin where User_id='" & Ubah_Admin.txt_admin_id_ubah.Text & "'"
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus !!!", MsgBoxStyle.Information, "Informasi")
            Return True
        Catch ex As Exception
            Return False
        Finally
            bukaKoneksi()
        End Try
        Return hasil
    End Function

    '---------- Method cek -----------
    Public Function ck_logadmin(ByVal _admin As ADMIN) As Boolean
        Dim hasil As Boolean = False
        query = "select * from tb_admin where Username='" & _admin.usadmin & "' and password='" & _admin.passadmin & "' and Status='" & _admin.akses & "'"
        Try
            hasil = obj_crud.cek_login(query, _admin.akses)
        Catch ex As Exception

        End Try
        Return hasil
    End Function
End Class
