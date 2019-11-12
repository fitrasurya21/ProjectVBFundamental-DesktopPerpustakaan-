Public Class Ubah_Anggota
    Dim jk As String

    Private Sub hps_ubah_anggota()
        txt_id_anggota_ubah.Clear()
        txt_nis_anggota_ubah.Clear()
        txt_nama_anggota_ubah.Clear()
        rdio_lk_anggota_ubah.Checked = False
        rdio_prm_anggota_ubah.Checked = False
        cbx_jurusan_anggota_ubah.Text = "- - - - Pilih - - - -"
        txt_alamat_anggota_ubah.Clear()
        txt_no_anggota_ubah.Clear()
        pct_anggota_ubah.Image = Nothing
        txt_alamatgbr_ubah.Clear()
    End Sub

    Private Sub btn_gbr_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gbr_anggota_ubah.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pct_anggota_ubah.ImageLocation = OpenFileDialog1.FileName
            txt_alamatgbr_ubah.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_simpan_anggota_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_anggota_ubah.Click
        If rdio_lk_anggota_ubah.Checked Then
            jk = "Laki - laki"
        ElseIf rdio_prm_anggota_ubah.Checked = True Then
            jk = "Perempuan"
        End If
        _anggota.nismhs = txt_nis_anggota_ubah.Text
        _anggota.namamhs = txt_nama_anggota_ubah.Text
        _anggota.jk = jk
        _anggota.tgllhr = dtpc_tgl_anggota_ubah.Text
        _anggota.jurusan = cbx_jurusan_anggota_ubah.Text
        _anggota.alamat = txt_alamat_anggota_ubah.Text
        _anggota.nohp = txt_no_anggota_ubah.Text
        _anggota.foto = txt_alamatgbr_ubah.Text
        ty = MsgBox("Anda yakin ingin mengubah data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _anggota.ubh_anggota(_anggota)
            hps_ubah_anggota()
            lihat_anggota()
            Me.Close()
        End If
    End Sub

    Private Sub btn_btl_anggota_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_anggota_ubah.Click
        ty = MsgBox("Anda yakin ingin menghapus data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _anggota.hps_anggota()
            lihat_anggota()
            Me.Close()
        End If
    End Sub

    Private Sub txt_nis_anggota_ubah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nis_anggota_ubah.KeyPress
        val_angka(e)
    End Sub

    Private Sub txt_nama_anggota_ubah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nama_anggota_ubah.KeyPress
        val_nama(e)
    End Sub

    Private Sub cbx_jurusan_anggota_ubah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_jurusan_anggota_ubah.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txt_no_anggota_ubah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_no_anggota_ubah.KeyPress
        val_angka(e)
    End Sub
End Class