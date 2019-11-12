Imports MySql.Data.MySqlClient
Module Module1
    Public cr As New Class_CRUD
    Public ty As String
    Public _admin As New ADMIN
    Public _anggota As New ANGGOTA
    Public _buku As New BUKU
    Public _pinjam As New PEMINJAMAN
    Public _kembali As New PENGEMBALIAN
    Public info As New Uc_Info_Awal
    Public ad As New Uc_Admin
    Public agt As New Uc_Anggota
    Public bk As New Uc_Buku

    Public pjm As New btn_btl_pinjam
    Public kbl As New Uc_Pengembalian
    Private obj_adm As New ADMIN
    Private obj_agt As New ANGGOTA
    Private obj_bku As New BUKU
    Private obj_pinjam As New PEMINJAMAN
    Private obj_kembali As New PENGEMBALIAN
    Private obj_pgj As New PENGUNJUNG

    Public Sub val_angka(ByVal e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
            MsgBox("Harus Angka", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Public Sub val_huruf(ByVal e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("Harus Huruf !!!", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Public Sub val_nama(ByVal e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "a" And e.KeyChar <= "z") Or (e.KeyChar >= "A" And e.KeyChar <= "Z") Or Char.IsWhiteSpace(e.KeyChar) Or "'".Contains(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("Harus Huruf !!!", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Public Sub val_karakter(ByVal e As KeyPressEventArgs)
        If Not (Char.IsLetterOrDigit(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("Tidak Boleh Simbol !!!", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Public Sub val_alamat(ByVal e As KeyPressEventArgs)
        If Not (Char.IsLetterOrDigit(e.KeyChar) Or "./".Contains(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or e.KeyChar = Chr(Keys.Back)) Then
            e.Handled = True
            MsgBox("Tidak Boleh Simbol !!!", MsgBoxStyle.Exclamation, "Informasi")
        End If
    End Sub

    Sub lihat_admin()
        ad.dgv_admin.DataSource = obj_adm.lht_admin
        ad.dgv_admin.Refresh()
    End Sub

    Sub lihat_pustakawan()
        ad.dgv_pustakawan.DataSource = obj_adm.lht_pustakawan
        ad.dgv_pustakawan.Refresh()
    End Sub

    Sub lihat_anggota()
        agt.dgv_anggota.DataSource = obj_agt.lht_anggota
        agt.dgv_anggota.Refresh()
    End Sub

    Sub lihat_buku(ByVal ck As String)
        If ck = "buku_awal" Then
            Tampilan_Awal.dgv_buku_awl.DataSource = obj_bku.lht_buku
            Tampilan_Awal.dgv_buku_awl.Refresh()
        ElseIf ck = "buku" Then
            bk.dgv_buku.DataSource = obj_bku.lht_buku
            bk.dgv_buku.Refresh()
        End If
        
    End Sub

    Sub lihat_pengunjung()
        Tampilan_Awal.dgv_pengunjung.DataSource = obj_pgj.lht_pengunjung
        Tampilan_Awal.dgv_pengunjung.Refresh()
    End Sub

    Sub lihat_pinjam(ByVal ck As String)
        If ck = "pinjam" Then
            pjm.dgv_pinjam.DataSource = obj_pinjam.lht_pinjam
            pjm.dgv_pinjam.Refresh()
        ElseIf ck = "kembali" Then
            kbl.dgv_pinjam_kbl.DataSource = obj_pinjam.lht_pinjam
            kbl.dgv_pinjam_kbl.Refresh()
        End If
        
    End Sub


    Sub lihat_kembali()
        kbl.dgv_kembali.DataSource = obj_kembali.lht_kembali
        kbl.dgv_kembali.Refresh()
    End Sub

End Module
