Imports MySql.Data.MySqlClient
Public Class Menu_Awal
    Dim tkn As Integer = 1
    Public gbr As String
    Private Sub tpl_profil()
        If tkn Mod 2 = 0 Then
            profile.Height = 214
            tkn += 1
        ElseIf tkn Mod 2 = 1 Then
            profile.Height = 0
            tkn += 1
        End If
    End Sub

    Private Sub KELUARToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        tpl_profil()
    End Sub

    Private Sub Menu_Awal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tpl_profil()
        tmpil_awal.Controls.Add(info)
        PictureBox1.ImageLocation = gbr
        Label1.Text = "Copyright" + Chr(169) + "PkPnNk_MFAA 2019"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim jwb As String = MsgBox("Yakin ingin keluar ?", MsgBoxStyle.OkCancel, "Informasi")
        If jwb = vbOK Then
            tpl_profil()
            tmpil_awal.Controls.Clear()
            tmpil_awal.Controls.Add(info)
            Me.Hide()
            Login.Show()
        End If
    End Sub

    Private Sub ADMINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADMINToolStripMenuItem.Click
        tmpil_awal.Controls.Clear()
        tmpil_awal.Controls.Add(ad)
    End Sub

    Private Sub ANGGOTAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANGGOTAToolStripMenuItem.Click
        tmpil_awal.Controls.Clear()
        tmpil_awal.Controls.Add(agt)
    End Sub

    Private Sub BUKUToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUKUToolStripMenuItem.Click
        tmpil_awal.Controls.Clear()
        tmpil_awal.Controls.Add(bk)
        bk.oto()
    End Sub

    Private Sub PEMINJAMANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PEMINJAMANToolStripMenuItem.Click
        tmpil_awal.Controls.Clear()
        tmpil_awal.Controls.Add(pjm)
    End Sub

    Private Sub PENGEMBALIANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENGEMBALIANToolStripMenuItem.Click
        tmpil_awal.Controls.Clear()
        tmpil_awal.Controls.Add(kbl)
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        lbl_tgl.Text = Format(Now, "ddd, dd MMMM yyyy")
        Timer1.Start()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub HOMEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HOMEToolStripMenuItem.Click
        tmpil_awal.Controls.Clear()
        tmpil_awal.Controls.Add(info)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_jam.Text = TimeOfDay
    End Sub
End Class