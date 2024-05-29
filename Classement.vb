Public Class Classement

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        lstClassement.Items.Clear()
        Principale.Show()
    End Sub

    Private Sub Classement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AfficherClassement()
    End Sub

    Public Sub AfficherClassement()
        For i As Integer = 0 To nbJoueurs - 1
            With joueurs(i)
                lstClassement.Items.Add(.nom & " " & .meilleurScore)
            End With
        Next
        lstClassement.Sorted = True
    End Sub
End Class