Imports MySql.Data.MySqlClient
Public Class BUKU
    Inherits Class_CRUD
    Dim obj_crud As New Class_CRUD
    Private _kodebuku As String
    Private _kategori As String
    Private _judul As String
    Private _pengarang As String
    Private _penerbit As String
    Private _tahunterbit As String
    Private _lokasi As String
    Private _tglmasuk As String
    Private _harga As String
    Private _alamat As String
    Private _stok As String
    Private _foto As String

    Public Property foto() As String
        Get
            Return _foto
        End Get
        Set(ByVal value As String)
            _foto = value
        End Set
    End Property
    Public Property stok() As String
        Get
            Return _stok
        End Get
        Set(ByVal value As String)
            _stok = value
        End Set
    End Property

    Public Property kodebuku() As String
        Get
            Return _kodebuku
        End Get
        Set(ByVal value As String)
            _kodebuku = value
        End Set
    End Property

    Public Property kategori() As String
        Get
            Return _kategori
        End Get
        Set(ByVal value As String)
            _kategori = value
        End Set
    End Property

    Public Property judul() As String
        Get
            Return _judul
        End Get
        Set(ByVal value As String)
            _judul = value
        End Set
    End Property

    Public Property pengarang() As String
        Get
            Return _pengarang
        End Get
        Set(ByVal value As String)
            _pengarang = value
        End Set
    End Property

    Public Property penerbit() As String
        Get
            Return _penerbit
        End Get
        Set(ByVal value As String)
            _penerbit = value
        End Set
    End Property

    Public Property tahunterbit() As String
        Get
            Return _tahunterbit
        End Get
        Set(ByVal value As String)
            _tahunterbit = value
        End Set
    End Property

    Public Property lokasi() As String
        Get
            Return _lokasi
        End Get
        Set(ByVal value As String)
            _lokasi = value
        End Set
    End Property

    Public Property tglmasuk() As String
        Get
            Return _tglmasuk
        End Get
        Set(ByVal value As String)
            _tglmasuk = value
        End Set
    End Property

    Public Property harga() As String
        Get
            Return _harga
        End Get
        Set(ByVal value As String)
            _harga = value
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

    '---------- Method Tampil -----------
    Public Function lht_buku() As DataTable
        query = "SELECT * FROM tb_buku"
        Try
            dt = obj_crud.tampil_data(query)
        Catch ex As Exception

        End Try
        Return dt
    End Function

    '---------- Method Tambah -----------
    Public Function tbh_buku() As Boolean
        Dim hasil As Boolean = False
        Try
            query = "INSERT INTO tb_buku VALUES('" & _buku.kodebuku & "','" & _buku.kategori & "','" & _buku.judul & "','" & _buku.pengarang & "','" & _buku.penerbit & "','" & _buku.tahunterbit & "','" & _buku.lokasi & "','" & _buku.tglmasuk & "','" & _buku.harga & "','" & _buku.stok & "',@Foto)"
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.Parameters.Add("Foto", MySqlDbType.VarChar).Value = _buku.foto
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan !!!", MsgBoxStyle.Information, "Informasi")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            bukaKoneksi()
        End Try
        Return hasil
    End Function


    '---------- Method Ubah -----------
    Public Function ubh_buku() As Boolean
        Dim hasil As Boolean = False
        query = "UPDATE tb_buku SET Kode_buku='" & _buku.kodebuku & "',Kategori='" & _buku.kategori & "',Judul='" & _buku.judul & "',Pengarang='" & _buku.pengarang & "',Penerbit='" & _buku.penerbit & "',Tahun_terbit='" & _buku.tahunterbit & "',Lokasi='" & _buku.lokasi & "',Tgl_masuk='" & _buku.tglmasuk & "',Harga='" & _buku.harga & "',Stok='" & _buku.stok & "',Alamat_gambar=@Foto where Kode_buku='" & Ubah_Buku.txt_kode_buku.Text & "'"
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.Parameters.Add("Foto", MySqlDbType.VarChar).Value = _buku.foto
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan !!!", MsgBoxStyle.Information, "Informasi")
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            bukaKoneksi()
        End Try
        Return hasil
    End Function

    '---------- Method Hapus -----------
    Public Function hps_buku() As Boolean
        Dim hasil As Boolean = False
        query = "DELETE FROM tb_peminjaman where Kode_buku='" & Ubah_Buku.txt_kode_buku.Text & "'"
        query1 = "DELETE FROM tb_pengembalian where Judul='" & Ubah_Buku.txt_judul_buku.Text & "'"
        query2 = "DELETE FROM tb_buku where Kode_buku='" & Ubah_Buku.txt_kode_buku.Text & "'"
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
