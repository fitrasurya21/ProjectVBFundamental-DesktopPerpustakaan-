Public Class Tampilan_Awal
    Dim jk As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub hitungbuku()
        Dim stok As Integer
        stok = 0
        For a As Integer = 0 To dgv_buku_awl.Rows.Count - 1
            stok = stok + Val(dgv_buku_awl.Rows(a).Cells(9).Value)
        Next
        Label4.Text = stok
    End Sub

   
    Private Sub hps_pjg()
        txt_nama_awal.Clear()
        rdio_lk_awal.Checked = False
        rdio_pr_awal.Checked = False
        cbx_jurusan_awal.Text = "- - - - Pilih - - - -"
        txt_kprl_awal.Clear()
        txt_cari_awal.Clear()
        txt_saran_awal.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Tampilan_Awal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "Copyright" + Chr(169) + "PkPnNk_MFAA 2019"
        txt_tgl_awal.Text = Format(Now, "yyyy-MM-dd")
        txt_jam_awal.Text = TimeOfDay
        With cbx_jurusan_awal.Items
            .Add("IPA")
            .Add("IPS")
        End With
        lihat_buku("buku_awal")
        hitungbuku()
        lihat_pengunjung()
        Label6.Text = dgv_pengunjung.RowCount - 1
        lihat_anggota()
        Label5.Text = agt.htnganggota

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_awal.Click
        Dim _pengunjung As New PENGUNJUNG
        If rdio_lk_awal.Checked Then
            jk = "Laki - laki"
        ElseIf rdio_pr_awal.Checked = True Then
            jk = "Perempuan"
        End If
        _pengunjung.namapgj = txt_nama_awal.Text
        _pengunjung.jkpgj = jk
        _pengunjung.jurusanpjg = cbx_jurusan_awal.Text
        _pengunjung.kprluanpjg = txt_kprl_awal.Text
        _pengunjung.dicaripjg = txt_cari_awal.Text
        _pengunjung.saranpjg = txt_saran_awal.Text
        _pengunjung.tglpjg = txt_tgl_awal.Text
        _pengunjung.jampjg = txt_jam_awal.Text
        ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _pengunjung.tbh_pengunjung(_pengunjung)
            lihat_pengunjung()
            Label6.Text = dgv_pengunjung.RowCount - 1
            hps_pjg()
        End If
        Me.Refresh()
    End Sub

    Private Sub btn_btl_awal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_awal.Click
        ty = MsgBox("Ingin membatalkan ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            hps_pjg()
        End If

    End Sub

    Private Sub btn_admin_awal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_admin_awal.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub btn_tbh_awal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tbh_awal.Click
        Tampilan_Daftar_Anggota.Show()
    End Sub

    Private Sub btn_caripgj_awal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_caripgj_awal.Click
        dgv_pengunjung.DataSource = cr.src_pengunjung(txt_caripgj_awal.Text)
        txt_caripgj_awal.Clear()
    End Sub

    Private Sub btn_caribuku_awal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_caribuku_awal.Click
        dgv_buku_awl.DataSource = cr.src_buku(txt_caribuku_awal.Text)
        txt_caribuku_awal.Clear()
    End Sub

    Private Sub txt_caribuku_awal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_caribuku_awal.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgv_buku_awl.DataSource = cr.src_buku(txt_caribuku_awal.Text)
            txt_caribuku_awal.Clear()
        End If
    End Sub

    Private Sub txt_caripgj_awal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_caripgj_awal.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgv_pengunjung.DataSource = cr.src_pengunjung(txt_caripgj_awal.Text)
            txt_caripgj_awal.Clear()
        End If
    End Sub

   
    Private Sub txt_caribuku_awal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_caribuku_awal.KeyPress
        val_karakter(e)
    End Sub

    Private Sub txt_caripgj_awal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_caripgj_awal.KeyPress
        val_karakter(e)
    End Sub

    Private Sub txt_nama_awal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nama_awal.KeyPress
        val_nama(e)
    End Sub

    Private Sub cbx_jurusan_awal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_jurusan_awal.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txt_kprl_awal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_kprl_awal.KeyPress
        val_huruf(e)
    End Sub
End Class