Module Main
    Structure Joueur
        Dim nom As String
        Dim meilleurScore As Double
        Dim nbPartieJoue As Integer
        Dim cumul As Integer
    End Structure

    Public joueurs() As Joueur
    Public nbJoueurs As Integer
    Const PAS_EXT As Integer = 2
    Sub Main()
        nbJoueurs = 0
        ReDim joueurs(0)
        Application.Run(Principale)
    End Sub

    Public Sub Ajout(j As Joueur)
        If UBound(joueurs) = nbJoueurs - 1 Then
            ReDim Preserve joueurs(PAS_EXT * nbJoueurs)
        End If
        joueurs(nbJoueurs) = j
        nbJoueurs += 1
    End Sub

    Public Sub ActualiserScore(nom As String, newScore As Integer)
        For i As Integer = 0 To nbJoueurs - 1
            If joueurs(i).nom.Equals(nom) And newScore > joueurs(i).meilleurScore Then
                joueurs(i).meilleurScore = newScore
            End If
        Next
    End Sub

    Public Sub TrierParScore()
        For i As Integer = 1 To nbJoueurs - 1
            Dim joueurTemp As Joueur = joueurs(i)
            Dim j As Integer = i - 1

            While j >= 0 AndAlso joueurs(j).meilleurScore < joueurTemp.meilleurScore
                joueurs(j + 1) = joueurs(j)
                j -= 1
            End While

            joueurs(j + 1) = joueurTemp
        Next
    End Sub

    Public Sub AjouterTemps(nom As String, temps As Integer)
        For i As Integer = 0 To nbJoueurs - 1
            If joueurs(i).nom.Equals(nom) And temps > joueurs(i).meilleurScore Then
                joueurs(i).cumul = temps
            End If
        Next
    End Sub
End Module
