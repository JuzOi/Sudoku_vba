Public Class Classement
    Private Sub Classement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Public Sub Init()
        AfficherClassement()
        InitialiserComboBox()
    End Sub

    Public Sub AfficherClassement()
        lstNom.Items.Clear()
        lstScore.Items.Clear()
        For i As Integer = 0 To GetNbJoueurs() - 1
            With GetJoueurs(i)
                lstNom.Items.Add(.nom)
                If (.meilleurTemps = 1 / 0) Then
                    lstScore.Items.Add("--:--")
                Else
                    Dim minute As Integer = .meilleurTemps / 60
                    Dim seconde As Integer = .meilleurTemps Mod 60
                    lstScore.Items.Add(String.Format("{0:D2}:{1:D2}", minute, seconde) & " en " & .difficulte)
                End If
            End With
        Next
    End Sub

    Public Sub InitialiserComboBox()
        cmbBoxnom.Items.Clear()
        For i As Integer = 0 To GetNbJoueurs() - 1
            cmbBoxnom.Items.Add(GetJoueurs(i).nom)
        Next
    End Sub

    Private Sub btnTrieNom_Click(sender As Object, e As EventArgs) Handles btnTrieNom.Click
        TrierParNom()
        AfficherClassement()
    End Sub

    Private Sub btnTrieScore_Click(sender As Object, e As EventArgs) Handles btnTrieScore.Click
        TrierParScore()
        AfficherClassement()
    End Sub

    Private Sub Synchroniser(index As Integer)
        lstNom.SelectedIndex = index
        lstScore.SelectedIndex = index
        cmbBoxnom.Text = lstNom.Text
    End Sub

    Private Sub lstNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNom.SelectedIndexChanged
        Synchroniser(lstNom.SelectedIndex)
    End Sub

    Private Sub lstScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstScore.SelectedIndexChanged
        Synchroniser(lstScore.SelectedIndex)
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        Principale.Show()
    End Sub

    Private Sub btnInfoJoueur_Click(sender As Object, e As EventArgs) Handles btnStatistique.Click
        For i As Integer = 0 To GetNbJoueurs() - 1
            With GetJoueurs(i)
                If cmbBoxnom.Text = .nom Then
                    MsgBox("Les statistiques complétes du joueur : " & .nom & ": " & vbCrLf & vbCrLf & "- Meilleur temps : " & .meilleurTemps & vbCrLf & vbCrLf &
                           "- Nombre de parties jouées : " & .nbPartieJoue & vbCrLf & vbCrLf & "- Temps de jeux : " & .cumul, vbYes, "INFORMATION")
                End If
            End With
        Next
    End Sub

    Private Sub cmbBoxnom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxnom.SelectedIndexChanged
        Dim selectedNom As String = cmbBoxnom.SelectedItem.ToString()
        For i As Integer = 0 To lstNom.Items.Count - 1
            If lstNom.Items(i).ToString() = selectedNom Then
                Synchroniser(i)
                Exit For
            End If
        Next
    End Sub

End Class