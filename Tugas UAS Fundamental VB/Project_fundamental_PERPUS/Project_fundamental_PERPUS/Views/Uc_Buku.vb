Imports MySql.Data.MySqlClient
Public Class Uc_Buku
    Dim cmd As MySqlCommand
    Dim rd As MySqlDataReader


    Sub hps_inputan_buku()
        oto()
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

    Sub oto()
        Dim strsmntr As String = ""
        Dim strisi As String = ""
        Try
            cmd = New MySqlCommand("SELECT * FROM tb_buku order by Kode_buku desc", cr.bukaKoneksi)
            rd = cmd.ExecuteReader
            If rd.Read Then
                strsmntr = Mid(rd.Item("Kode_buku"), 2, 2)
                strisi = Val(strsmntr) + 1
                txt_kode_buku.Text = "B" + Mid("0", 1, 2 - strisi.Length) & strisi
            Else
                txt_kode_buku.Text = "B01"
            End If
            cbx_ktg_buku.Focus()
        Catch ex As Exception

        Finally
            rd.Close()
            cr.bukaKoneksi()
        End Try

    End Sub

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

            cr.bukaKoneksi()
        End Try
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

    Private Sub btn_btl_anggota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_btl_buku.Click
        ty = MsgBox("Ingin membatalkan ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            hps_inputan_buku()
            Menu_Awal.tmpil_awal.Controls.Clear()
            Menu_Awal.tmpil_awal.Controls.Add(info)
        End If
    End Sub


    Private Sub Uc_Buku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lihat_buku("buku")
        tampilDataComboBox()

    End Sub

    Private Sub cbx_ktg_buku_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_ktg_buku.SelectedIndexChanged
        tampilrak()
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
        _buku.foto = txt_alamatgbr_buku.Text
        ty = MsgBox("Simpan data ???", vbOKCancel, "Informasi")
        If ty = vbOK Then
            _buku.tbh_buku()
            hps_inputan_buku()
            lihat_buku("buku")
            lihat_buku("buku_awal")
        End If

    End Sub

    Private Sub btn_carigbr_buku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_carigbr_buku.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pct_gbr_buku.ImageLocation = OpenFileDialog1.FileName
            txt_alamatgbr_buku.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_cari_buku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari_buku.Click
        dgv_buku.DataSource = cr.src_buku(txt_cari_buku.Text)
        txt_cari_buku.Clear()
    End Sub

    Private Sub dgv_buku_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_buku.CellClick
        Dim row As DataGridViewRow = dgv_buku.CurrentRow
        Ubah_Buku.txt_kode_buku.Text = row.Cells(0).Value.ToString
        Ubah_Buku.cbx_ktg_buku.Text = row.Cells(1).Value.ToString
        Ubah_Buku.txt_judul_buku.Text = row.Cells(2).Value.ToString
        Ubah_Buku.txt_pngrng_buku.Text = row.Cells(3).Value.ToString
        Ubah_Buku.txt_penerbit_buku.Text = row.Cells(4).Value.ToString
        Ubah_Buku.txt_thun_buku.Text = row.Cells(5).Value.ToString
        Ubah_Buku.txt_lokasi_buku.Text = row.Cells(6).Value.ToString
        Ubah_Buku.dtpc_tgl_buku.Text = row.Cells(7).Value.ToString
        Ubah_Buku.txt_harga_buku.Text = row.Cells(8).Value.ToString
        Ubah_Buku.txt_stok_buku.Text = row.Cells(9).Value.ToString
        Ubah_Buku.pct_gbr_buku.ImageLocation = row.Cells(10).Value.ToString
        Ubah_Buku.txt_alamatgbr_ubah.Text = row.Cells(10).Value.ToString
        Ubah_Buku.Show()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

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

    Private Sub txt_cari_buku_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cari_buku.KeyPress
        val_karakter(e)
    End Sub

    Private Sub txt_cari_buku_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_cari_buku.KeyDown
        If e.KeyCode = Keys.Enter Then
            dgv_buku.DataSource = cr.src_buku(txt_cari_buku.Text)
            txt_cari_buku.Clear()
        End If
    End Sub

    Private Sub txt_stok_buku_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_stok_buku.TextChanged

    End Sub
End Class
