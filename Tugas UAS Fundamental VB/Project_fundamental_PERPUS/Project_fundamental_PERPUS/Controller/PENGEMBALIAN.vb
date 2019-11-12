Imports MySql.Data.MySqlClient
Public Class PENGEMBALIAN
    Inherits Class_CRUD
    Dim obj_crud As New Class_CRUD
    Private _idkbl As String
    Private _telat As String
    Private _lama As String
    Private _denda As String

    Public Property denda() As String
        Get
            Return _denda
        End Get
        Set(ByVal value As String)
            _denda = value
        End Set
    End Property
    Public Property idkbl() As String
        Get
            Return _idkbl
        End Get
        Set(ByVal value As String)
            _idkbl = value
        End Set
    End Property
    Public Property telat() As String
        Get
            Return _telat
        End Get
        Set(ByVal value As String)
            _telat = value
        End Set
    End Property
    Public Property lama() As String
        Get
            Return _lama
        End Get
        Set(ByVal value As String)
            _lama = value
        End Set
    End Property


    '---------- Method Tampil -----------
    Public Function lht_kembali() As DataTable
        query = "SELECT * FROM tb_pengembalian"
        Try
            dt = obj_crud.tampil_data(query)
        Catch ex As Exception

        End Try
        Return dt
    End Function

    '---------- Method Tambah -----------
    Public Function tbh_kembali() As Boolean
        Dim hasil As Boolean = False
        Try
            query = "INSERT INTO tb_pengembalian VALUES('" & _kembali.idkbl & " ','" & _anggota.namamhs & "','" & _buku.judul & "','" & _pinjam.tgl_kbl & "','" & _kembali.lama & "','" & _kembali.telat & "','" & _kembali.denda & "','" & _pinjam.status & "','" & _pinjam.ket & "')"
            cmd = New MySqlCommand(query, bukaKoneksi)
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
End Class
