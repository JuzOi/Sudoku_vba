Public Class Classement
    Private Sub Classement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AfficherClassement()
    End Sub

    Public Sub AfficherClassement()
        lstNom.Items.Clear()
        lstScore.Items.Clear()
        For i As Integer = 0 To nbJoueurs - 1
            With joueurs(i)
                lstNom.Items.Add(.nom)
                lstScore.Items.Add(.meilleurTemps)
            End With
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
End Class