Imports MySql.Data.MySqlClient
Public Class Ubah_Pinjam
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Sub tampil_siswa()
        Try
            cmd = New MySqlCommand("select * from tb_anggota where id_kartu_anggota='" & txt_nis_pinjam_ubah.Text & "'", cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txt_nama_pinjam_ubah.Text = rd.Item("Nama_siswa")
            Else
                txt_nama_pinjam_ubah.Text = "Tidak ada"
            End If
            rd.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cr.bukaKoneksi()
        End Try
    End Sub

    Sub tampil_judul()
        Try
            cmd = New MySqlCommand("select * from tb_buku where Kode_buku='" & txt_kodebuku_pinjam_ubah.Text & "'", cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txt_judul_pinjam_ubah.Text = rd.Item("Judul")
                pct_gbr_pinjam_ubah.ImageLocation = rd.Item("Alamat_gambar")
            Else
                txt_judul_pinjam_ubah.Text = "Tidak ada"
            End If
            rd.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cr.bukaKoneksi()
        End Try

    End Sub
    Sub hps_ubah_pinjam()
        txt_nis_pinjam_ubah.Clear()
        txt_nama_pinjam_ubah.Text = "Tidak ada"
        txt_kodebuku_pinjam_ubah.Clear()
        txt_judul_pinjam_ubah.Text = "Tidak ada"
        txt_ket_pinjam_ubah.Clear()
        pct_gbr_pinjam_ubah.Image = Nothing
    End Sub
    Private Sub btn_simpan_pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubah.Click
        _anggota.nismhs = txt_nis_pinjam_ubah.Text
        _anggota.namamhs = txt_nama_pinjam_ubah.Text
        _buku.kodebuku = txt_kodebuku_pinjam_ubah.Text
        _buku.judul = txt_judul_pinjam_ubah.Text
        _pinjam.tglpinjam = txt_tgl_pinjam_ubah.Text
        _pinjam.tgl_kbl = dtpc_kmbli_pinjam_ubah.Text
        _pinjam.status = txt_status_pinjam_ubah.Text
        _pinjam.ket = txt_ket_pinjam_ubah.Text
        ty = MsgBox("Anda yakin ingin mengubah data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _pinjam.ubh_pinjam()
            hps_ubah_pinjam()
            lihat_pinjam("pinjam")
            Me.Close()
        End If
    End Sub

    Private Sub txt_nis_pinjam_ubah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nis_pinjam_ubah.TextChanged
        tampil_siswa()
    End Sub

    Private Sub txt_kodebuku_pinjam_ubah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_kodebuku_pinjam_ubah.TextChanged
        tampil_judul()
    End Sub

    Private Sub btn_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hapus.Click
        ty = MsgBox("Anda yakin ingin menghapus data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _pinjam.hps_pinjam()
            lihat_pinjam("pinjam")
            Me.Close()
        End If
    End Sub

    Private Sub Ubah_Pinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub txt_nis_pinjam_ubah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nis_pinjam_ubah.KeyPress
        val_angka(e)
    End Sub
End Class