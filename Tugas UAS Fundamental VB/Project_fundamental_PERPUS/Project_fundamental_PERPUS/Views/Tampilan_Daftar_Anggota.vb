Public Class Tampilan_Daftar_Anggota
    Dim almt_gbr, jk As String

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
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gbr_anggota.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pct_anggota.ImageLocation = OpenFileDialog1.FileName
            almt_gbr = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_tambah_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tampilan_Daftar_Anggota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cbx_jurusan_anggota.Items
            .Add("IPA")
            .Add("IPS")
        End With
    End Sub

    Private Sub btn_btl_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ty = MsgBox("Ingin membatalkan ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            hps_input_anggota()
            Me.Hide()
        End If
        
    End Sub

    Private Sub btn_simpan_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_admin.Click
        Dim _anggota As New ANGGOTA

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
        _anggota.foto = almt_gbr
        Dim ty As String = MsgBox("Simpan Data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _anggota.tbh_anggota(_anggota)
            hps_input_anggota()
            Me.Close()
        End If
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

    Private Sub txt_no_anggota_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_no_anggota.KeyPress
        val_angka(e)
    End Sub
End Class