Public Class Options
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitScrollBar()

        rbtMinecraft.Tag = "Minecraft"
        rbtMario.Tag = "Mario"
        rbtSonic.Tag = "Sonic"
        rbtDragonBall.Tag = "DragonBall"

        rbtDark.Tag = "Dark"
        rbtClair.Tag = "Clair"

        rbtClair.PerformClick()
        rbtSonic.PerformClick()

        If GetSonEnFond() Then
            rbtVolumeOn.PerformClick()
        Else
            rbtVolumeOff.PerformClick()
        End If


    End Sub

    Public Sub InitScrollBar()
        scrollTime.Minimum = 0
        scrollTime.Maximum = 3600
        scrollTime.SmallChange = 1
        scrollTime.LargeChange = 120
        scrollTime.Maximum += scrollTime.LargeChange - 1
        scrollTime.Value = 420
        scrollTime_Scroll(scrollTime, New ScrollEventArgs(ScrollEventType.EndScroll, scrollTime.Value))
    End Sub

    Private Sub scrollTime_Scroll(sender As Object, e As ScrollEventArgs) Handles scrollTime.Scroll
        Dim minute As Integer = scrollTime.Value / 60
        Dim seconde As Integer = scrollTime.Value Mod 60
        lblTimeActuel.Text = String.Format("{0:D2}:{1:D2}", minute, seconde)
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        Principale.Init()
        Principale.Show()
    End Sub

    Private Sub rbtTheme_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMinecraft.CheckedChanged, rbtMario.CheckedChanged, rbtSonic.CheckedChanged, rbtDragonBall.CheckedChanged
        ChangerTheme(sender.Tag)
    End Sub

    Private Sub rbtThemeSetting_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDark.CheckedChanged, rbtClair.CheckedChanged
        ChangerThemeSetting(sender.Tag)
    End Sub

    Private Sub rbtVolumeOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtVolumeOn.CheckedChanged
        AllumerSon()
    End Sub

    Private Sub rbtVolumeOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtVolumeOff.CheckedChanged
        CouperSon()
    End Sub
End Class