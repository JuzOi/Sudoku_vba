Public Class Principale
    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        If boxNom.Text.Trim <> "" Then
            If Not boxNom.Items.Contains(boxNom.Text) Then
                boxNom.Items.Add(boxNom.Text)

                Dim newJoueur As Joueur
                With newJoueur
                    .nom = boxNom.Text
                    .score = 0
                End With
                Ajout(newJoueur)
            End If

            Me.Hide()
            Jeu.Show()
            Jeu.Init()
        Else
            MsgBox("Veuillez saisir un nom")
        End If
    End Sub

    Private Sub boxNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boxNom.KeyPress
        boxNom.DroppedDown = True
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Jeu.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Classement.Show()
        Classement.AfficherClassement()
    End Sub

End Class