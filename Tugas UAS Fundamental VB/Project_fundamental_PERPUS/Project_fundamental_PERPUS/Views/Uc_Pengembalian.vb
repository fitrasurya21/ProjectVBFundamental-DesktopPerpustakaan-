Imports MySql.Data.MySqlClient
Public Class Uc_Pengembalian
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader
    Dim tlt, lm As String
    Public key As String
    Sub hps_inputan_kembali()
        auto_kbl()
        txt_nis_kbl.Clear()
        txt_nis_kbl.Text = "Tidak ada"
        txt_nama_kbl.Clear()
        txt_kodebuku_kbl.Text = "Tidak ada"
        txt_judul_kbl.Clear()
        txt_tglpjm.Clear()
        txt_tgl_kbl.Clear()
        txt_denda_kbl.Clear()
        cbx_status_kbl.Text = "- - - - Pilih - - - -"
        txt_ket_kbl.Clear()
        txt_bayar.Clear()
        pct_gbr_kbl.Image = Nothing
    End Sub
    Sub auto_kbl()
        Dim strsmntr As String = ""
        Dim strisi As String = ""
        Try
            cmd = New MySqlCommand("SELECT * FROM tb_pengembalian order by Id_pengembalian desc", cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            If rd.Read Then
                strsmntr = Mid(rd.Item("Id_pengembalian"), 2, 2)
                strisi = Val(strsmntr) + 1
                txt_id_pinjam.Text = "P" + Mid("0", 1, 2 - strisi.Length) & strisi
            Else
                txt_id_pinjam.Text = "P01"
            End If
        Catch ex As Exception

        Finally
            rd.Close()
            cr.bukaKoneksi()
        End Try

    End Sub
    Private Sub Uc_Pengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lihat_kembali()
        auto_kbl()
        With cbx_status_kbl.Items
            .Add("Ada")
            .Add("Diperpanjang")
        End With
        lihat_pinjam("kembali")
    End Sub

    Private Sub dgv_pinjam_kbl_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pinjam_kbl.CellClick
        Dim row As DataGridViewRow = dgv_pinjam_kbl.CurrentRow
        Dim ck As String
        ck = row.Cells(7).Value.ToString
        If ck = "Ada" Then
            MsgBox("Buku telah dikembalikan !!!", MsgBoxStyle.Information, "Informasi")
        Else
            key = row.Cells(0).Value.ToString
            txt_nis_kbl.Text = row.Cells(1).Value.ToString
            txt_nama_kbl.Text = row.Cells(2).Value.ToString
            txt_kodebuku_kbl.Text = row.Cells(3).Value.ToString
            txt_judul_kbl.Text = row.Cells(4).Value.ToString
            txt_tglpjm.Text = Format(row.Cells(5).Value, "yyyy-MM-dd").ToString
            txt_tgl_kbl.Text = Format(row.Cells(6).Value, "yyyy-MM-dd").ToString
            txt_ket_kbl.Text = row.Cells(8).Value.ToString
            pct_gbr_kbl.ImageLocation = row.Cells(9).Value.ToString
        End If
        
    End Sub

    Private Sub btn_simpan_pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_pinjam.Click
        dtpc_prpj.Visible = False
        _kembali.idkbl = txt_id_pinjam.Text
        _anggota.namamhs = txt_nama_kbl.Text
        _buku.judul = txt_judul_kbl.Text
        _pinjam.tgl_kbl = txt_tgl_kbl.Text
        _kembali.lama = "3 Hari"
        _kembali.telat = tlt
        _kembali.denda = txt_denda_kbl.Text
        _pinjam.status = cbx_status_kbl.Text
        _pinjam.ket = txt_ket_kbl.Text
        If cbx_status_kbl.Text = "- - - - Pilih - - - -" Or txt_id_pinjam.Text = "" Then
            MsgBox("Data belum lengkap !!!", MsgBoxStyle.Exclamation, "Informasi")
        ElseIf cbx_status_kbl.Text = "Diperpanjang" Then
            If txt_denda_kbl.Text <> "0" Then
                If String.IsNullOrEmpty(txt_bayar.Text) Then
                    MsgBox("Bayar terlebih dahulu !!!", MsgBoxStyle.Exclamation, "Informasi")
                ElseIf Val(txt_denda_kbl.Text) = Val(txt_bayar.Text) Then
                    MsgBox("Uang anda pass !!!", MsgBoxStyle.Information, "Informasi")
                    ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
                    If ty = vbOK Then
                        _kembali.tbh_kembali()
                        _pinjam.ubh_perpanjang()
                        hps_inputan_kembali()
                        lihat_kembali()
                        lihat_pinjam("pinjam")
                        lihat_pinjam("kembali")
                    End If
                ElseIf Val(txt_denda_kbl.Text) < Val(txt_bayar.Text) Then
                    MsgBox("Kembalian anda Rp." & Val(txt_bayar.Text) - Val(txt_denda_kbl.Text), MsgBoxStyle.Information, "Informasi")
                    ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
                    If ty = vbOK Then
                        _kembali.tbh_kembali()
                        _pinjam.ubh_perpanjang()
                        hps_inputan_kembali()
                        lihat_kembali()
                        lihat_pinjam("kembali")
                        lihat_pinjam("pinjam")
                    End If
                ElseIf Val(txt_denda_kbl.Text) > Val(txt_bayar.Text) Then
                    MsgBox("Uang anda kurang !!! masukan lagi ?", MsgBoxStyle.Exclamation, "Informasi")
                    txt_bayar.Clear()
                    txt_bayar.Focus()
                End If
            Else
                If ty = vbOK Then
                    _kembali.tbh_kembali()
                    _pinjam.ubh_perpanjang()
                    hps_inputan_kembali()
                    lihat_kembali()
                    lihat_pinjam("kembali")
                    lihat_pinjam("pinjam")
                End If
            End If
        Else
            If txt_denda_kbl.Text <> "0" Then
                If String.IsNullOrEmpty(txt_bayar.Text) Then
                    MsgBox("Bayar terlebih dahulu !!!", MsgBoxStyle.Exclamation, "Informasi")
                ElseIf Val(txt_denda_kbl.Text) = Val(txt_bayar.Text) Then
                    MsgBox("Uang anda pass !!!", MsgBoxStyle.Information, "Informasi")
                    ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
                    If ty = vbOK Then
                        _kembali.tbh_kembali()
                        _pinjam.ubh_uppjm()
                        hps_inputan_kembali()
                        lihat_kembali()
                        lihat_pinjam("pinjam")
                        lihat_pinjam("kembali")
                    End If
                ElseIf Val(txt_denda_kbl.Text) < Val(txt_bayar.Text) Then
                    MsgBox("Kembalian anda Rp." & Val(txt_bayar.Text) - Val(txt_denda_kbl.Text), MsgBoxStyle.Information, "Informasi")
                    ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
                    If ty = vbOK Then
                        _kembali.tbh_kembali()
                        _pinjam.ubh_uppjm()
                        hps_inputan_kembali()
                        lihat_kembali()
                        lihat_pinjam("kembali")
                        lihat_pinjam("pinjam")
                    End If
                ElseIf Val(txt_denda_kbl.Text) > Val(txt_bayar.Text) Then
                    MsgBox("Uang anda kurang !!! masukan lagi ?", MsgBoxStyle.Exclamation, "Informasi")
                    txt_bayar.Clear()
                    txt_bayar.Focus()
                End If
            Else
                ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
                If ty = vbOK Then
                    _kembali.tbh_kembali()
                    _pinjam.ubh_uppjm()
                    hps_inputan_kembali()
                    lihat_kembali()
                    lihat_pinjam("pinjam")
                    lihat_pinjam("kembali")
                End If
            End If
        End If
    End Sub

    Private Sub btn_cari_pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_pinjam.Click
        dgv_pinjam_kbl.DataSource = cr.src_pinjam(txt_cari_pinjam_ubh.Text)
        txt_cari_pinjam_ubh.Clear()
    End Sub

    Private Sub btn_btl_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_anggota.Click
        dtpc_prpj.Visible = False
        ty = MsgBox("Ingin membatalkan ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            hps_inputan_kembali()
            Menu_Awal.tmpil_awal.Controls.Clear()
            Menu_Awal.tmpil_awal.Controls.Add(info)
        End If
    End Sub

    Private Sub txt_tgl_kbl_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_tgl_kbl.TextChanged
        Dim pinjam As String
        Dim kembali As Date
        Dim selisih As TimeSpan
        If txt_tgl_kbl.Text <> "" Then
            pinjam = Me.txt_tgl_kbl.Text
            kembali = Format(Now, "yyyy-MM-dd")
            If kembali <= pinjam Then
                txt_denda_kbl.Text = "0"
            Else
                selisih = kembali.Subtract(pinjam)
                tlt = selisih.Days
                Me.txt_denda_kbl.Text = tlt * 2000
            End If
        Else
            txt_denda_kbl.Clear()
        End If
    End Sub

    Private Sub dgv_pinjam_kbl_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_pinjam_kbl.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cbx_status_kbl_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_status_kbl.SelectedIndexChanged
        If cbx_status_kbl.Text = "Diperpanjang" Then
            dtpc_prpj.Visible = True
        End If
    End Sub

    Private Sub btn_format_pinjam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dtpc_prpj.Visible = False
    End Sub

    Private Sub cbx_status_kbl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_status_kbl.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txt_bayar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_bayar.KeyPress
        val_angka(e)
    End Sub

    Private Sub txt_cari_pngmblian_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari_pngmblian.KeyPress
        val_karakter(e)
    End Sub

    Private Sub txt_cari_pinjam_ubh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari_pinjam_ubh.KeyPress
        val_karakter(e)
    End Sub

    Private Sub txt_cari_pinjam_ubh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cari_pinjam_ubh.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgv_pinjam_kbl.DataSource = cr.src_pinjam(txt_cari_pinjam_ubh.Text)
            txt_cari_pinjam_ubh.Clear()
        End If
    End Sub

    Private Sub btn_pngmblian_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pngmblian.Click
        dgv_kembali.DataSource = cr.src_kembali(txt_cari_pngmblian.Text)
        txt_cari_pngmblian.Clear()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
