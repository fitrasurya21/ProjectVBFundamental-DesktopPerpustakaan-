Public Class PENGUNJUNG
    Inherits Class_CRUD
    Dim obj_crud As New Class_CRUD

    Private _namapgj As String
    Private _jkpgj As String
    Private _jurusanpjg As String
    Private _kprluanpjg As String
    Private _dicaripjg As String
    Private _saranpjg As String
    Private _tglpjg As String
    Private _jampjg As String

    Public Property namapgj() As String
        Get
            Return _namapgj
        End Get
        Set(ByVal value As String)
            _namapgj = value
        End Set
    End Property

    Public Property jkpgj() As String
        Get
            Return _jkpgj
        End Get
        Set(ByVal value As String)
            _jkpgj = value
        End Set
    End Property
    Public Property jurusanpjg() As String
        Get
            Return _jurusanpjg
        End Get
        Set(ByVal value As String)
            _jurusanpjg = value
        End Set
    End Property
    Public Property kprluanpjg() As String
        Get
            Return _kprluanpjg
        End Get
        Set(ByVal value As String)
            _kprluanpjg = value
        End Set
    End Property
    Public Property dicaripjg() As String
        Get
            Return _dicaripjg
        End Get
        Set(ByVal value As String)
            _dicaripjg = value
        End Set
    End Property
    Public Property saranpjg() As String
        Get
            Return _saranpjg
        End Get
        Set(ByVal value As String)
            _saranpjg = value
        End Set
    End Property
    Public Property tglpjg() As String
        Get
            Return _tglpjg
        End Get
        Set(ByVal value As String)
            _tglpjg = value
        End Set
    End Property
    Public Property jampjg() As String
        Get
            Return _jampjg
        End Get
        Set(ByVal value As String)
            _jampjg = value
        End Set
    End Property

    '---------- Method Tampil -----------
    Public Function lht_pengunjung() As DataTable
        query = "SELECT No,Nama_pengunjung,Jenis_kelamin,Jurusan,Keperluan,Dicari,Tanggal_berkunjung,Jam FROM tb_pengunjung"
        Try
            dt = obj_crud.tampil_data(query)
        Catch ex As Exception

        End Try
        Return dt
    End Function

    '---------- Method Tambah -----------
    Public Function tbh_pengunjung(ByVal _pengunjung As PENGUNJUNG) As Boolean
        Dim hasil As Boolean = False
        query = "INSERT INTO tb_pengunjung VALUES('" & "" & "','" & _pengunjung.namapgj & "','" & _pengunjung.jkpgj & "','" & _pengunjung.jurusanpjg & "','" & _pengunjung.kprluanpjg & "','" & _pengunjung.dicaripjg & "','" & _pengunjung.saranpjg & "','" & _pengunjung.tglpjg & "','" & _pengunjung.jampjg & "')"
        Try
            hasil = obj_crud.CRUD_data(query)
        Catch ex As Exception

        End Try
        Return hasil
    End Function
End Class
