
Imports MySql.Data.MySqlClient

Public Class Login
    Dim aks As String
    Dim cr As New Class_CRUD
    Dim tkn As Integer = 0

    Sub gmr()
        Dim cmd As New MySqlCommand("select * from tb_admin where Username='" & txt_username_ad.Text & "'", cr.bukaKoneksi)
        Dim rd As MySqlDataReader
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            PictureBox1.ImageLocation = rd.Item("Foto")
        End If
        rd.Close()
        cr.bukaKoneksi()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = "Copyright" + Chr(169) + "PkPnNk_MFAA 2019"
        txt_password_ad.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        End
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Dim _admin As New ADMIN
        If rdio_admin.Checked = True Then
            aks = "Admin"
        ElseIf rdio_petugas.Checked = True Then
            aks = "Pustakawan"
        End If
        _admin.usadmin = txt_username_ad.Text
        _admin.passadmin = txt_password_ad.Text
        _admin.akses = aks
        _admin.ck_logadmin(_admin)
        txt_username_ad.Clear()
        txt_password_ad.Clear()
        rdio_admin.Checked = False
        rdio_petugas.Checked = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Tampilan_Awal.Refresh()
        Tampilan_Awal.Show()
    End Sub

    Private Sub txt_username_ad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username_ad.TextChanged
        gmr()
        If txt_username_ad.Text = "" Then
            PictureBox1.Image = My.Resources.tmpl_admin
        End If
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        If tkn Mod 2 = 0 Then
            txt_password_ad.UseSystemPasswordChar = False
            tkn += 1
        End If
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        If tkn Mod 2 = 1 Then
            txt_password_ad.UseSystemPasswordChar = True
            tkn += 1
        End If
    End Sub

  
End Class
