Public Class Uc_Admin
    Private Sub hps_inputan_admin()
        txt_admin_nama.Clear()
        txt_admin_user.Clear()
        txt_admin_pass.Clear()
        cbx_admin_status.Text = "- - - - Pilih - - - -"
        txt_admin_alamat.Clear()
        pct_gbr_admin.Image = Nothing
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_admin_carigambar.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pct_gbr_admin.ImageLocation = OpenFileDialog1.FileName
            txt_admin_alamat.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Uc_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With cbx_admin_status.Items
            .Add("Admin")
            .Add("Pustakawan")
        End With
        lihat_admin()
        lihat_pustakawan()
    End Sub

    Private Sub btn_admin_tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub cbx_admin_status_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_admin_status.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_admin.Click
        _admin.namaadmin = txt_admin_nama.Text
        _admin.usadmin = txt_admin_user.Text
        _admin.passadmin = txt_admin_pass.Text
        _admin.status = cbx_admin_status.Text
        _admin.alamatgbr = txt_admin_alamat.Text
        ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _admin.tbh_admin(_admin)
            hps_inputan_admin()
            lihat_admin()
            lihat_pustakawan()
        End If
        
    End Sub

    Private Sub btn_btl_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_admin.Click
        ty = MsgBox("Ingin membatalkan ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            hps_inputan_admin()
            Menu_Awal.tmpil_awal.Controls.Clear()
            Menu_Awal.tmpil_awal.Controls.Add(info)
        End If
       
    End Sub


    Private Sub dgv_admin_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_admin.CellClick
        Dim row As DataGridViewRow = dgv_admin.CurrentRow
        Ubah_Admin.txt_admin_id_ubah.Text = row.Cells(0).Value.ToString
        Ubah_Admin.txt_admin_nama_ubah.Text = row.Cells(1).Value.ToString
        Ubah_Admin.txt_admin_user_ubah.Text = row.Cells(2).Value.ToString
        Ubah_Admin.txt_admin_pass_ubah.Text = row.Cells(3).Value.ToString
        Ubah_Admin.cbx_admin_status_ubah.Text = row.Cells(4).Value.ToString
        Ubah_Admin.txt_admin_alamat_ubah.Text = row.Cells(5).Value.ToString
        Ubah_Admin.pct_gbr_admin_ubah.ImageLocation = row.Cells(5).Value.ToString
        Ubah_Admin.Show()
    End Sub

    Private Sub dgv_pustakawan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pustakawan.CellClick
        Dim row As DataGridViewRow = dgv_pustakawan.CurrentRow
        Ubah_Admin.txt_admin_id_ubah.Text = row.Cells(0).Value.ToString
        Ubah_Admin.txt_admin_nama_ubah.Text = row.Cells(1).Value.ToString
        Ubah_Admin.txt_admin_user_ubah.Text = row.Cells(2).Value.ToString
        Ubah_Admin.txt_admin_pass_ubah.Text = row.Cells(3).Value.ToString
        Ubah_Admin.cbx_admin_status_ubah.Text = row.Cells(4).Value.ToString
        Ubah_Admin.txt_admin_alamat_ubah.Text = row.Cells(5).Value.ToString
        Ubah_Admin.pct_gbr_admin_ubah.ImageLocation = row.Cells(5).Value.ToString
        Ubah_Admin.Show()
    End Sub

    Private Sub txt_admin_nama_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_admin_nama.KeyPress
        val_nama(e)
    End Sub
End Class
