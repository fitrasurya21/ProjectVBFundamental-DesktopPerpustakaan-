Public Class Ubah_Admin


    Private Sub hps_ubah_admin()
        txt_admin_nama_ubah.Clear()
        txt_admin_user_ubah.Clear()
        txt_admin_pass_ubah.Clear()
        cbx_admin_status_ubah.Text = "- - - - Pilih - - - -"
        txt_admin_alamat_ubah.Clear()
        pct_gbr_admin_ubah.Image = Nothing
    End Sub

    Private Sub Ubah_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cbx_admin_status_ubah.Items
            .Add("Admin")
            .Add("Pustakawan")
        End With
    End Sub

    Private Sub btn_admin_carigambar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_admin_carigambar_ubah.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pct_gbr_admin_ubah.ImageLocation = OpenFileDialog1.FileName
            txt_admin_alamat_ubah.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_ubah_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ubah_admin.Click
        _admin.namaadmin = txt_admin_nama_ubah.Text
        _admin.usadmin = txt_admin_user_ubah.Text
        _admin.passadmin = txt_admin_pass_ubah.Text
        _admin.status = cbx_admin_status_ubah.Text
        _admin.alamatgbr = txt_admin_alamat_ubah.Text
        ty = MsgBox("Anda yakin ingin mengubah data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _admin.ubh_admin(_admin)
            hps_ubah_admin()
            lihat_admin()
            lihat_pustakawan()
            Me.Close()
        End If
       
    End Sub

    Private Sub btn_hpus_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hpus_admin.Click
        ty = MsgBox("Anda yakin ingin menghapus data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _admin.hps_admin()
            lihat_admin()
            lihat_pustakawan()
            Me.Close()
        End If
    End Sub

    Private Sub txt_admin_nama_ubah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_admin_nama_ubah.KeyPress
        val_nama(e)
    End Sub

    Private Sub cbx_admin_status_ubah_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_admin_status_ubah.KeyPress
        e.KeyChar = Chr(0)
    End Sub
End Class