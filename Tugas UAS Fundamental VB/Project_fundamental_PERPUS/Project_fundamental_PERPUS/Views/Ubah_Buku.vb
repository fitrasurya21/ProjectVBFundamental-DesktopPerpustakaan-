Imports MySql.Data.MySqlClient
Public Class Ubah_Buku
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader

    Sub tampilDataComboBox()
        Dim str As String
        str = "select Kategori from tb_kategori_buku"
        Try
            cmd = New MySqlCommand(str, cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                Do While rd.Read
                    cbx_ktg_buku.Items.Add(rd("Kategori"))
                Loop
            End If
        Catch ex As Exception

        Finally
            rd.Close()
            cr.bukaKoneksi()
        End Try
    End Sub
    Sub hps_ubah_buku()
        cbx_ktg_buku.Text = "- - - - Pilih - - - -"
        txt_judul_buku.Clear()
        txt_pngrng_buku.Clear()
        txt_penerbit_buku.Clear()
        txt_thun_buku.Clear()
        txt_lokasi_buku.Clear()
        dtpc_tgl_buku.Value = "2015-03-06"
        txt_harga_buku.Clear()
        txt_stok_buku.Clear()
        pct_gbr_buku.Image = Nothing
    End Sub

    Private Sub tampilrak()
        Try
            cmd = New MySqlCommand("select * from tb_kategori_buku where Kategori='" & cbx_ktg_buku.Text & "'", cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                txt_lokasi_buku.Text = rd.Item("Kode_ddc")
            End If
        Catch ex As Exception

        Finally
            rd.Close()
            cr.bukaKoneksi()
        End Try
    End Sub

    Private Sub btn_simpan_buku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_simpan_buku.Click
        _buku.kodebuku = txt_kode_buku.Text
        _buku.kategori = cbx_ktg_buku.Text
        _buku.judul = txt_judul_buku.Text
        _buku.pengarang = txt_pngrng_buku.Text
        _buku.penerbit = txt_penerbit_buku.Text
        _buku.tahunterbit = txt_thun_buku.Text
        _buku.lokasi = txt_lokasi_buku.Text
        _buku.tglmasuk = dtpc_tgl_buku.Text
        _buku.harga = txt_harga_buku.Text
        _buku.stok = txt_stok_buku.Text
        _buku.foto = txt_alamatgbr_ubah.Text
        ty = MsgBox("Anda yakin ingin mengubah data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _buku.ubh_buku()
            hps_ubah_buku()
            lihat_buku("buku")
            bk.oto()
            Me.Close()
        End If
    End Sub

    Private Sub btn_carigbr_buku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carigbr_buku.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pct_gbr_buku.ImageLocation = OpenFileDialog1.FileName
            txt_alamatgbr_ubah.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_btl_buku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_buku.Click
        ty = MsgBox("Anda yakin ingin menghapus data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _buku.hps_buku()
            lihat_buku("buku")
            Me.Close()
            bk.oto()
        End If
    End Sub

    Private Sub Ubah_Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilDataComboBox()
    End Sub

    Private Sub cbx_ktg_buku_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_ktg_buku.SelectedIndexChanged
        tampilrak()
    End Sub

    Private Sub cbx_ktg_buku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbx_ktg_buku.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub txt_pngrng_buku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pngrng_buku.KeyPress
        val_nama(e)
    End Sub

    Private Sub txt_thun_buku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_thun_buku.KeyPress
        val_angka(e)
    End Sub

    Private Sub txt_harga_buku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_harga_buku.KeyPress
        val_angka(e)
    End Sub

    Private Sub txt_stok_buku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_stok_buku.KeyPress
            val_angka(e)

    End Sub

    Private Sub txt_stok_buku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_stok_buku.TextChanged

    End Sub
End Class