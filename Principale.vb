Public Class Principale
    Private Sub Principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub
    Public Sub Init()
        btnGrille3.PerformClick()
        btnFacile.Checked = True
    End Sub
    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        If boxNom.Text.Trim <> "" Then
            If Not boxNom.Items.Contains(boxNom.Text) Then
                boxNom.Items.Add(boxNom.Text)

                Dim newJoueur As Joueur
                With newJoueur
                    .nom = boxNom.Text
                    .meilleurScore = 0
                    .nbPartieJoue = 1
                    .cumul = 0
                End With
                Ajout(newJoueur)
            End If
            taille_grille = taille_zone * taille_zone
            Me.Hide()
            Jeu.Init()
            Jeu.Show()
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
    Private Sub btnRegle_Click(sender As Object, e As EventArgs) Handles btnRegle.Click
        MsgBox("Notre sudoku marche ainsi : " & vbCrLf & vbCrLf & "-Rentrez un pseudo " & vbCrLf & vbCrLf &
               "-Choisir un niveau (la taille de la grille et du nombre de cases cachées) " & vbCrLf &
               "Puis, quand la partie aura commencé, vous aurez 7 minutes pour résoudre le sudoku." & vbCrLf & vbCrLf &
               " Vous pouvez bien sûr abandonner en cliquant sur la flèche, ce qui vous permettra d'afficher la solution." & vbCrLf & vbCrLf &
               " Si vous arrivez à résoudre le sudoku dans le temps imparti, votre score sera affiché dans le tableau de classement. Pour le voir, 
               il vous suffira de cliquer sur le bouton classement.", vbYes, "Régle")
    End Sub

    Private Sub btnGrille4_Click(sender As Object, e As EventArgs) Handles btnGrille4.Click
        taille_zone = 4
        btnGrille4.BackColor = Color.Gray
        btnGrille3.BackColor = Color.White
    End Sub

    Private Sub btnGrille3_Click(sender As Object, e As EventArgs) Handles btnGrille3.Click
        taille_zone = 3
        btnGrille3.BackColor = Color.Gray
        btnGrille4.BackColor = Color.White
    End Sub

    Private Sub btnFacile_CheckedChanged(sender As Object, e As EventArgs) Handles btnFacile.CheckedChanged, btnMoyen.CheckedChanged, btnDifficile.CheckedChanged
        Dim btn As RadioButton = CType(sender, RadioButton)
        If btn.Checked = True Then
            celluleASupprimer = difficulte(btn.Text)
        End If
    End Sub
End Class