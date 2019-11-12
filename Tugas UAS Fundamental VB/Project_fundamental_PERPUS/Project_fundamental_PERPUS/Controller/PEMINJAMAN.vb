Imports MySql.Data.MySqlClient
Public Class PEMINJAMAN
    Inherits Class_CRUD
    Dim obj_crud As New Class_CRUD
    Private _tglpinjam As String
    Private _tgl_kbl As String
    Private _status As String
    Private _ket As String


    Public Property tglpinjam() As String
        Get
            Return _tglpinjam
        End Get
        Set(ByVal value As String)
            _tglpinjam = value
        End Set
    End Property

    Public Property tgl_kbl() As String
        Get
            Return _tgl_kbl
        End Get
        Set(ByVal value As String)
            _tgl_kbl = value
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
    Public Property ket() As String
        Get
            Return _ket
        End Get
        Set(ByVal value As String)
            _ket = value
        End Set
    End Property

    '---------- Method Tampil -----------
    Public Function lht_pinjam() As DataTable
        query = "SELECT * FROM tb_peminjaman"
        Try
            dt = obj_crud.tampil_data(query)
        Catch ex As Exception

        End Try
        Return dt
    End Function

    '---------- Method Tambah -----------
    Public Function tbh_pinjam() As Boolean
        Dim hasil As Boolean = False
        Try
            query = "INSERT INTO tb_peminjaman VALUES('" & "" & "','" & _anggota.nismhs & "','" & _anggota.namamhs & "','" & _buku.kodebuku & "','" & _buku.judul & "','" & _pinjam.tglpinjam & "','" & _pinjam.tgl_kbl & "','" & _pinjam.status & "','" & _pinjam.ket & "',@Foto)"
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
    Public Function ubh_pinjam() As Boolean
        Dim hasil As Boolean = False
        Try
            query = "UPDATE tb_peminjaman set Id_kartu_anggota='" & _anggota.nismhs & "',Nama_siswa='" & _anggota.namamhs & "',Kode_buku='" & _buku.kodebuku & "',Judul='" & _buku.judul & "',Tgl_pinjam='" & _pinjam.tglpinjam & "',Tgl_kembali='" & _pinjam.tgl_kbl & "',Status='" & _pinjam.status & "',Keterangan='" & _pinjam.ket & "' where Id_peminjaman='" & Ubah_Pinjam.txt_id_pinjam_ubah.Text & "'"
            cmd = New MySqlCommand(query, bukaKoneksi)
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

    '---------- Method diperpanjang -----------
    Public Function ubh_perpanjang() As Boolean
        Dim hasil As Boolean = False
        Try
            query = "UPDATE tb_peminjaman set Tgl_pinjam='" & Format(Now, "yyyy-MM-dd") & "',Tgl_kembali='" & kbl.dtpc_prpj.Text & "',Status='" & _pinjam.status & "',Keterangan='" & _pinjam.ket & "' where Id_peminjaman='" & kbl.key & "'"
            cmd = New MySqlCommand(query, bukaKoneksi)
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

    '---------- Method Ubah setelah dikembalikan -----------
    Public Function ubh_uppjm() As Boolean
        Dim hasil As Boolean = False
        Try
            query = "UPDATE tb_peminjaman set Status='" & _pinjam.status & "',Keterangan='" & _pinjam.ket & "' where Id_peminjaman='" & kbl.key & "'"
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.ExecuteNonQuery()
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
    Public Function hps_pinjam() As Boolean
        Dim hasil As Boolean = False
        query = "DELETE FROM tb_peminjaman where Id_peminjaman='" & Ubah_Pinjam.txt_id_pinjam_ubah.Text & "'"
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
End Class
