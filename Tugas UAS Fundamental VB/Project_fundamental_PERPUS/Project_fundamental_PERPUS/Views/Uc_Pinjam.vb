Imports MySql.Data.MySqlClient
Public Class btn_btl_pinjam
    Dim rd As MySqlDataReader
    Dim cmd As New MySqlCommand
    Dim tmp_gbr As String
    Sub tmpil_siswa()
        Try
            cmd = New MySqlCommand("select * from tb_anggota where id_kartu_anggota='" & txt_nis_pinjam.Text & "'", cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txt_nama_pinjam.Text = rd.Item("Nama_siswa")
            Else
                txt_nama_pinjam.Text = "Tidak ada"
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
            cmd = New MySqlCommand("select * from tb_buku where Kode_buku='" & txt_kodebuku_pinjam.Text & "'", cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txt_judul_pinjam.Text = rd.Item("Judul")
                tmp_gbr = rd.Item("Alamat_gambar")
                pct_gbr_pinjam.ImageLocation = rd.Item("Alamat_gambar")
            Else
                txt_judul_pinjam.Text = "Tidak ada"
            End If
            rd.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cr.bukaKoneksi()
        End Try

    End Sub

    Sub hps_inputan_pinjam()
        txt_nis_pinjam.Clear()
        txt_nama_pinjam.Text = "Tidak ada"
        txt_kodebuku_pinjam.Clear()
        txt_judul_pinjam.Text = "Tidak ada"
        txt_ket_pinjam.Clear()
        pct_gbr_pinjam.Image = Nothing
    End Sub

    Private Sub txt_nis_anggota_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_nis_pinjam.TextChanged
        tmpil_siswa()
    End Sub

    Private Sub txt_kodebuku_pinjam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_kodebuku_pinjam.TextChanged
        tampil_judul()
    End Sub

    Private Sub btn_btl_pinjam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lihat_pinjam("pinjam")
        txt_tgl_pinjam.Text = Format(Now, "yyyy-MM-dd")
    End Sub

    Private Sub btn_simpan_pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_pinjam.Click
        _anggota.nismhs = txt_nis_pinjam.Text
        _anggota.namamhs = txt_nama_pinjam.Text
        _buku.kodebuku = txt_kodebuku_pinjam.Text
        _buku.judul = txt_judul_pinjam.Text
        _pinjam.tglpinjam = txt_tgl_pinjam.Text
        _pinjam.tgl_kbl = dtpc_kmbli_pinjam.Text
        _pinjam.status = txt_status_pinjam.Text
        _pinjam.ket = txt_ket_pinjam.Text
        _buku.foto = tmp_gbr
        ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _pinjam.tbh_pinjam()
            hps_inputan_pinjam()
            lihat_pinjam("pinjam")
        End If
    End Sub

    Private Sub btn_btl_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_anggota.Click
        ty = MsgBox("Ingin membatalkan ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            hps_inputan_pinjam()
            Menu_Awal.tmpil_awal.Controls.Clear()
            Menu_Awal.tmpil_awal.Controls.Add(info)
        End If
    End Sub

    Private Sub dgv_pinjam_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pinjam.CellClick
        Dim row As DataGridViewRow = dgv_pinjam.CurrentRow
        Ubah_Pinjam.txt_id_pinjam_ubah.Text = row.Cells(0).Value.ToString
        Ubah_Pinjam.txt_nis_pinjam_ubah.Text = row.Cells(1).Value.ToString
        Ubah_Pinjam.txt_nama_pinjam_ubah.Text = row.Cells(2).Value.ToString
        Ubah_Pinjam.txt_kodebuku_pinjam_ubah.Text = row.Cells(3).Value.ToString
        Ubah_Pinjam.txt_judul_pinjam_ubah.Text = row.Cells(4).Value.ToString
        Ubah_Pinjam.txt_tgl_pinjam_ubah.Text = Format(row.Cells(5).Value, "yyyy-MM-dd").ToString
        Ubah_Pinjam.dtpc_kmbli_pinjam_ubah.Text = row.Cells(6).Value.ToString
        Ubah_Pinjam.txt_status_pinjam_ubah.Text = row.Cells(7).Value.ToString
        Ubah_Pinjam.txt_ket_pinjam_ubah.Text = row.Cells(8).Value.ToString
        Ubah_Pinjam.Show()
    End Sub

    Private Sub btn_cari_pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_pinjam.Click
        dgv_pinjam.DataSource = cr.src_pinjam(txt_cari_pinjam.Text)
        txt_cari_pinjam.Clear()
    End Sub

    Private Sub txt_nis_pinjam_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nis_pinjam.KeyPress
        val_angka(e)
    End Sub

    Private Sub txt_cari_pinjam_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari_pinjam.KeyPress
        val_karakter(e)
    End Sub

    Private Sub txt_cari_pinjam_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cari_pinjam.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgv_pinjam.DataSource = cr.src_pinjam(txt_cari_pinjam.Text)
            txt_cari_pinjam.Clear()
        End If
    End Sub
End Class
