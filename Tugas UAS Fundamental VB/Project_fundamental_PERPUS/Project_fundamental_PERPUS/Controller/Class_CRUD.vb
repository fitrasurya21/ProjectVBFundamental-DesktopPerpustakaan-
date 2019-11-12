Imports MySql.Data.MySqlClient
Public Class Class_CRUD
    Inherits Class_Koneksi

    Function tampil_data(ByVal query As String) As DataTable
        Dim hasil As New DataTable
        Try
            adpt = New MySqlDataAdapter(query, bukaKoneksi)
            adpt.Fill(hasil)
            Return hasil
        Catch ex As Exception
            Return hasil
        Finally
            bukaKoneksi()
        End Try
    End Function

    Function CRUD_data(ByVal query As String) As Boolean
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        Finally
            bukaKoneksi()
        End Try
    End Function

    Public Function src_anggota(ByVal find As String) As DataTable
        Dim hasil As New DataTable
        Try
            adpt = New MySqlDataAdapter("Select * from tb_anggota where Nis_siswa like '%" & find & "%' or Nama_siswa like '%" & find & "%' or Jurusan like '%" & find & "%' or Alamat like '%" & find & "%'", bukaKoneksi())
            adpt.Fill(hasil)
        Catch ex As Exception
            MsgBox("ERROR !!!" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
        bukaKoneksi()
    End Function

    Public Function src_kembali(ByVal find As String) As DataTable
        Dim hasil As New DataTable
        Try
            adpt = New MySqlDataAdapter("Select * from tb_pengembalian where Id_pengembalian like '%" & find & "%' or Nama_siswa like '%" & find & "%' or Judul like '%" & find & "%'", bukaKoneksi())
            adpt.Fill(hasil)
        Catch ex As Exception
            MsgBox("ERROR !!!" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
        bukaKoneksi()
    End Function


    Public Function src_pengunjung(ByVal find As String) As DataTable
        Dim hasil As New DataTable
        Try
            adpt = New MySqlDataAdapter("Select * from tb_pengunjung where Nama_pengunjung like '%" & find & "%' or Jurusan like '%" & find & "%' or Tanggal_berkunjung like '%" & find & "%'", bukaKoneksi())
            adpt.Fill(hasil)
        Catch ex As Exception
            MsgBox("ERROR !!!" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
        bukaKoneksi()
    End Function

    Public Function src_buku(ByVal find As String) As DataTable
        Dim hasil As New DataTable

        Try
            adpt = New MySqlDataAdapter("Select * from tb_buku where Kode_buku like '%" & find & "%' or Kategori like '%" & find & "%' or Judul like '%" & find & "%' or Pengarang like '%" & find & "%'", bukaKoneksi())
            adpt.Fill(hasil)
        Catch ex As Exception
            MsgBox("ERROR !!!" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
        bukaKoneksi()
    End Function

    Public Function src_pinjam(ByVal find As String) As DataTable
        Dim hasil As New DataTable
        Try
            adpt = New MySqlDataAdapter("Select * from tb_peminjaman where Id_kartu_anggota like '%" & find & "%' or Nama_siswa like '%" & find & "%' or Kode_buku like '%" & find & "%' or Judul like '%" & find & "%' or Tgl_pinjam like '%" & find & "%'", bukaKoneksi())
            adpt.Fill(hasil)
        Catch ex As Exception
            MsgBox("ERROR !!!" + ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Return hasil
        bukaKoneksi()
    End Function



    Function cek_login(ByVal query As String, ByVal cek As String) As Boolean
        Try
            cmd = New MySqlCommand(query, bukaKoneksi)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                If cek = "Admin" Then
                    Menu_Awal.KELUARToolStripMenuItem.Text = rd.Item("Nama_admin")
                    Menu_Awal.Label5.Text = rd.Item("Nama_admin")
                    Menu_Awal.Label6.Text = rd.Item("Status")
                    Menu_Awal.ADMINToolStripMenuItem.Enabled = True
                    Login.Hide()
                    Menu_Awal.Show()
                ElseIf cek = "Pustakawan" Then
                    Menu_Awal.KELUARToolStripMenuItem.Text = rd.Item("Nama_admin")
                    Menu_Awal.Label5.Text = rd.Item("Nama_admin")
                    Menu_Awal.Label6.Text = rd.Item("Status")
                    Menu_Awal.ADMINToolStripMenuItem.Enabled = False
                    Login.Hide()
                    Menu_Awal.Show()
                End If
            Else
                rd.Close()
                MsgBox("Login Gagal !!!", MsgBoxStyle.Critical, "Invalid !!!")
            End If
        Catch ex As Exception
            Return False
        Finally
            bukaKoneksi()
        End Try
        Return True
    End Function

End Class
