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

    Private Sub cmbom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBoxnom.SelectedIndexChanged
        If cmbBoxnom.Text = lstNom.Text Then
            lstNom.Select()
        End If
    End Sub

    Private Sub btnInfoJoueur_Click(sender As Object, e As EventArgs) Handles btnInfoJoueur.Click
        For i As Integer = 0 To nbJoueurs - 1
            With joueurs(i)
                If cmbBoxnom.Text = .nom Then
                    MsgBox("Les statistiques complétes du joueur : " & .nom & ": " & vbCrLf & vbCrLf & "- Meilleur temps" & .meilleurTemps & vbCrLf & vbCrLf &
                           "- Nombre de parties jouées" & .nbPartieJoue & vbCrLf & vbCrLf & "- Temps joué" & .cumul, vbYes, "INFORMATION")
                End If
            End With
        Next
    End Sub
End Class