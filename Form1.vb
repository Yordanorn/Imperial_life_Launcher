Public Class Form1
    Private Sub OnClickBtnWebSite(sender As Object, e As EventArgs) Handles BtnWebSite.Click
        System.Diagnostics.Process.Start("https://imperial-life.fr/")
    End Sub

    Private Sub OnClickPlay(sender As Object, e As EventArgs) Handles BtnPlay.Click
        System.Diagnostics.Process.Start("")
    End Sub

    Private Sub OnClick_BtnDiscord(sender As Object, e As EventArgs) Handles BtnDiscord.Click
        System.Diagnostics.Process.Start("https://discord.gg/j34MKM94dd")
    End Sub

End Class
