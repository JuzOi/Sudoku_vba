Public Class Options
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitScrollBar()
        pnlThemeSombre.Visible = False
        rbtClair.Checked = True
        rbtMinecraft.Checked = True
        rbtVolumeOn.Checked = True
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

    Private Sub rbtMario_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMario.CheckedChanged
        Principale.BackgroundImage = Sudoku.My.Resources.Resources.MarioTheme
        Jeu.BackgroundImage = Sudoku.My.Resources.Resources.MarioTheme
        rbtClair.Checked = True
        pnlThemeSombre.Visible = True
        If rbtVolumeOn.Checked = True Then
            My.Computer.Audio.Play("SuperMarioBrosThemeSong.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub rbtMinecraft_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMinecraft.CheckedChanged
        Principale.BackgroundImage = Sudoku.My.Resources.Resources.MinecraftTheme
        Jeu.BackgroundImage = Sudoku.My.Resources.Resources.MinecraftTheme
        rbtClair.Checked = True
        pnlThemeSombre.Visible = True

        If rbtVolumeOn.Checked = True Then
            My.Computer.Audio.Play("MinecraftThemeSong.wav", AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub rbtClair_CheckedChanged(sender As Object, e As EventArgs) Handles rbtClair.CheckedChanged
        If rbtMario.Checked = True Then
            Principale.BackgroundImage = Sudoku.My.Resources.Resources.MarioTheme
            Jeu.BackgroundImage = Sudoku.My.Resources.Resources.MarioDark___Copie

        Else
            Principale.BackgroundImage = Sudoku.My.Resources.Resources.MinecraftTheme
            Jeu.BackgroundImage = Sudoku.My.Resources.Resources.MinecraftDark
        End If

        If rbtVolumeOn.Checked = True Then
            If rbtMario.Checked = True Then
                My.Computer.Audio.Play("SuperMarioBrosThemeSong.wav", AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Play("MinecraftDarkSong.wav", AudioPlayMode.BackgroundLoop)
            End If
        End If

    End Sub

    Private Sub rbtSombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbtSombre.CheckedChanged
        If rbtMario.Checked = True Then
            Principale.BackgroundImage = Sudoku.My.Resources.Resources.MarioDark___Copie
            Jeu.BackgroundImage = Sudoku.My.Resources.Resources.MarioDark___Copie
        Else
            Principale.BackgroundImage = Sudoku.My.Resources.Resources.MinecraftDark
            Jeu.BackgroundImage = Sudoku.My.Resources.Resources.MinecraftDark
        End If

        If rbtVolumeOn.Checked = True Then
            If rbtMario.Checked = True Then
                My.Computer.Audio.Play("MarioDarkSong.wav", AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Play("MinecraftDarkSong.wav", AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub

    Private Sub rbtVolumeOff_CheckedChanged(sender As Object, e As EventArgs) Handles rbtVolumeOff.CheckedChanged
        My.Computer.Audio.Stop()
    End Sub

    Private Sub rbtVolumeOn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtVolumeOn.CheckedChanged
        If rbtMinecraft.Checked = True Then
            If rbtClair.Checked = True Then
                My.Computer.Audio.Play("MinecraftThemeSong.wav", AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Play("MinecraftDarkSong.wav", AudioPlayMode.BackgroundLoop)
            End If
        Else
            If rbtClair.Checked = True Then
                My.Computer.Audio.Play("SuperMarioBrosThemeSong.wav", AudioPlayMode.BackgroundLoop)
            Else
                My.Computer.Audio.Play("MinecraftDarkSong.wav", AudioPlayMode.BackgroundLoop)
            End If
        End If


    End Sub
End Class