Public Class Uc_Info_Awal
    Dim rnd As New Random

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer = 1
        slide.Image = My.Resources.ResourceManager.GetObject("image" & rnd.Next(i, 12))
    End Sub

    Private Sub Uc_Info_Awal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
