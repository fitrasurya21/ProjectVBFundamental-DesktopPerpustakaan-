Imports MySql.Data.MySqlClient
Public Class ANGGOTA
    Inherits Class_CRUD
    Dim obj_crud As New Class_CRUD
    Private _idmhs As String
    Private _nismhs As String
    Private _namamhs As String
    Private _jk As String
    Private _tgllhr As String
    Private _jurusan As String
    Private _alamat As String
    Private _nohp As String
    Private _foto As String

    Public Property idmhs() As String
        Get
            Return _idmhs
        End Get
        Set(ByVal value As String)
            _idmhs = value
        End Set
    End Property
    Public Property nismhs() As String
        Get
            Return _nismhs
        End Get
        Set(ByVal value As String)
            _nismhs = value
        End Set
    End Property

    Public Property namamhs() As String
        Get
            Return _namamhs
        End Get
        Set(ByVal value As String)
            _namamhs = value
        End Set
    End Property

    Public Property jk() As String
        Get
            Return _jk
        End Get
        Set(ByVal value As String)
            _jk = value
        End Set
    End Property

    Public Property tgllhr() As String
        Get
            Return _tgllhr
        End Get
        Set(ByVal value As String)
            _tgllhr = value
        End Set
    End Property

    Public Property jurusan() As String
        Get
            Return _jurusan
        End Get
        Set(ByVal value As String)
            _jurusan = value
        End Set
    End Property

    Public Property alamat() As String
        Get
            Return _alamat
        End Get
        Set(ByVal value As String)
            _alamat = value
        End Set
    End Property

    Public Property nohp() As String
        Get
            Return _nohp
        End Get
        Set(ByVal value As String)
            _nohp = value
        End Set
    End Property

    Public Property foto() As String
        Get
            Return _foto
        End Get
        Set(ByVal value As String)
            _foto = value
        End Set
    End Property

    '---------- Method Tampil -----------
    Public Function lht_anggota() As DataTable
        query = "SELECT * FROM tb_anggota"
        Try
            dt = obj_crud.tampil_data(query)
        Catch ex As Exception

        End Try
        Return dt
    End Function


    '---------- Method Tambah -----------
    Public Function tbh_anggota(ByVal _anggota As ANGGOTA) As Boolean
        Dim hasil As Boolean = False
        query = "INSERT INTO tb_anggota VALUES('" & "" & "','" & _anggota.nismhs & "','" & _anggota.namamhs & "','" & _anggota.jk & "','" & _anggota.tgllhr & "','" & _anggota.jurusan & "','" & _anggota.alamat & "','" & _anggota.nohp & "',@Foto)"
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.Parameters.Add("Foto", MySqlDbType.VarChar).Value = _anggota.foto
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
    Public Function ubh_anggota(ByVal _anggota As ANGGOTA) As Boolean
        Dim hasil As Boolean = False
        query = "UPDATE tb_anggota SET Nis_siswa='" & _anggota.nismhs & "',Nama_siswa='" & _anggota.namamhs & "',Jk='" & _anggota.jk & "',Tgl_lahir='" & _anggota.tgllhr & "',Jurusan='" & _anggota.jurusan & "',Alamat='" & _anggota.alamat & "',No_hp='" & _anggota.nohp & "',Foto=@Foto where Id_kartu_anggota='" & Ubah_Anggota.txt_id_anggota_ubah.Text & "'"
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.Parameters.Add("Foto", MySqlDbType.VarChar).Value = _anggota.foto
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

    '---------- Method Hapus -----------
    Public Function hps_anggota() As Boolean
        Dim hasil As Boolean = False
        query = "DELETE FROM tb_peminjaman where Id_kartu_anggota='" & Ubah_Anggota.txt_id_anggota_ubah.Text & "'"
        query1 = "DELETE FROM tb_pengembalian where Nama_siswa='" & Ubah_Anggota.txt_nama_anggota_ubah.Text & "'"
        query2 = "DELETE FROM tb_anggota where Id_kartu_anggota='" & Ubah_Anggota.txt_id_anggota_ubah.Text & "'"
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.ExecuteNonQuery()
            bukaKoneksi()
            cmd = New MySqlCommand(query1, bukaKoneksi)
            cmd.ExecuteNonQuery()
            bukaKoneksi()
            cmd = New MySqlCommand(query2, bukaKoneksi)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil dihapus !!!", MsgBoxStyle.Information, "Informasi")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            bukaKoneksi()
        End Try
        Return hasil
    End Function

End Class
