Public Class Uc_Anggota
    Dim jk As String
    Dim jum As Integer

    Private Sub hps_input_anggota()
        txt_nis_anggota.Clear()
        txt_nama_anggota.Clear()
        rdio_lk_anggota.Checked = False
        rdio_prm_anggota.Checked = False
        dtpc_tgl_anggota.Value = "1997-01-01"
        cbx_jurusan_anggota.Text = "- - - - Pilih - - - -"
        txt_alamat_anggota.Clear()
        txt_no_anggota.Clear()
        pct_anggota.Image = Nothing
        txt_alamatgbr_anggota.Clear()
    End Sub

    Private Sub btn_simpan_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_anggota.Click
        If rdio_lk_anggota.Checked Then
            jk = "Laki - laki"
        ElseIf rdio_prm_anggota.Checked = True Then
            jk = "Perempuan"
        End If
        _anggota.nismhs = txt_nis_anggota.Text
        _anggota.namamhs = txt_nama_anggota.Text
        _anggota.jk = jk
        _anggota.tgllhr = dtpc_tgl_anggota.Text
        _anggota.jurusan = cbx_jurusan_anggota.Text
        _anggota.alamat = txt_alamat_anggota.Text
        _anggota.nohp = txt_no_anggota.Text
        _anggota.foto = txt_alamatgbr_anggota.Text
        ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _anggota.tbh_anggota(_anggota)
            hps_input_anggota()
            lihat_anggota()
        End If
    End Sub

    Private Sub btn_gbr_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gbr_anggota.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pct_anggota.ImageLocation = OpenFileDialog1.FileName
            txt_alamatgbr_anggota.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Uc_Anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cbx_jurusan_anggota.Items
            .Add("IPA")
            .Add("IPS")
        End With
        lihat_anggota()
    End Sub

    Private Sub btn_btl_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_anggota.Click
        ty = MsgBox("Ingin membatalkan ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            hps_input_anggota()
            Menu_Awal.tmpil_awal.Controls.Clear()
            Menu_Awal.tmpil_awal.Controls.Add(info)
        End If
    End Sub

    Private Sub dgv_anggota_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_anggota.CellClick
        Dim row As DataGridViewRow = dgv_anggota.CurrentRow
        Ubah_Anggota.txt_id_anggota_ubah.Text = row.Cells(0).Value.ToString
        Ubah_Anggota.txt_nis_anggota_ubah.Text = row.Cells(1).Value.ToString
        Ubah_Anggota.txt_nama_anggota_ubah.Text = row.Cells(2).Value.ToString
        jk = row.Cells(3).Value.ToString
        If jk = "Laki - laki" Then
            Ubah_Anggota.rdio_lk_anggota_ubah.Checked = True
        ElseIf jk = "Perempuan" Then
            Ubah_Anggota.rdio_prm_anggota_ubah.Checked = True
        End If
        Ubah_Anggota.dtpc_tgl_anggota_ubah.Text = row.Cells(4).Value.ToString
        Ubah_Anggota.cbx_jurusan_anggota_ubah.Text = row.Cells(5).Value.ToString
        Ubah_Anggota.txt_alamat_anggota_ubah.Text = row.Cells(6).Value.ToString
        Ubah_Anggota.txt_no_anggota_ubah.Text = row.Cells(7).Value.ToString
        Ubah_Anggota.pct_anggota_ubah.ImageLocation = row.Cells(8).Value.ToString
        Ubah_Anggota.txt_alamatgbr_ubah.Text = row.Cells(8).Value.ToString
        Ubah_Anggota.Show()
    End Sub

    Private Sub btn_cari_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_anggota.Click
        dgv_anggota.DataSource = cr.src_anggota(txt_cari_anggota.Text)
        txt_cari_anggota.Clear()
    End Sub

    Public Function htnganggota() As Integer
        jum = dgv_anggota.RowCount - 1
        Return jum
    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub dgv_anggota_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_anggota.CellContentClick

    End Sub

    Private Sub txt_nis_anggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nis_anggota.KeyPress
        val_angka(e)
    End Sub

    Private Sub txt_nama_anggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nama_anggota.KeyPress
        val_nama(e)
    End Sub

    Private Sub cbx_jurusan_anggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_jurusan_anggota.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txt_alamat_anggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_alamat_anggota.KeyPress
        val_alamat(e)
    End Sub

    Private Sub txt_no_anggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_no_anggota.KeyPress
        val_angka(e)
    End Sub

    Private Sub txt_cari_anggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari_anggota.KeyPress
        val_karakter(e)
    End Sub

    Private Sub txt_cari_anggota_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cari_anggota.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgv_anggota.DataSource = cr.src_anggota(txt_cari_anggota.Text)
            txt_cari_anggota.Clear()
        End If
    End Sub
End Class
