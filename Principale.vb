Public Class Principale
    Private Sub btnLancer_Click(sender As Object, e As EventArgs) Handles btnLancer.Click
        If boxNom.Text.Trim <> "" Then
            boxNom.Items.Add(boxNom.Text)
            Me.Hide()
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

End Class