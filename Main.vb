Module Main
    Structure Joueur
        Dim nom As String
        Dim meilleurTemps As Double
        Dim nbPartieJoue As Integer
        Dim cumul As Integer
    End Structure

    Public joueurs() As Joueur
    Public nbJoueurs As Integer
    Const PAS_EXT As Integer = 2

    Public taille_zone As Integer
    Public taille_grille As Integer
    Public celluleASupprimer As Integer
    Public difficulte As Collection
    Public Const TEMPS_LIMITE As Integer = 420

    Sub Main()
        nbJoueurs = 0
        ReDim joueurs(0)

        difficulte = New Collection From {
            {50, "Facile"},
            {35, "Moyen"},
            {20, "Difficile"}
        }

        Application.Run(Principale)
    End Sub

    Public Sub Ajout(j As Joueur)
        If UBound(joueurs) = nbJoueurs - 1 Then
            ReDim Preserve joueurs(PAS_EXT * nbJoueurs)
        End If
        joueurs(nbJoueurs) = j
        nbJoueurs += 1
    End Sub

    Public Sub ActualiserScore(nom As String, newTemps As Integer)
        Dim tempsDeJeu As Integer = TEMPS_LIMITE - newTemps
        For i As Integer = 0 To nbJoueurs - 1
            If joueurs(i).nom.Equals(nom) And joueurs(i).meilleurTemps > tempsDeJeu Then
                joueurs(i).meilleurTemps = tempsDeJeu
            End If
        Next
    End Sub

    Public Sub AjouterTemps(nom As String, temps As Integer)
        For i As Integer = 0 To nbJoueurs - 1
            If joueurs(i).nom.Equals(nom) And temps > joueurs(i).meilleurTemps Then
                joueurs(i).cumul = temps
            End If
        Next
    End Sub

    Public Sub TrierParNom()
        For i As Integer = 0 To nbJoueurs - 2
            For j As Integer = i + 1 To nbJoueurs - 1
                If joueurs(i).nom.CompareTo(joueurs(j).nom) > 0 Then
                    Dim temp As Joueur = joueurs(i)
                    joueurs(i) = joueurs(j)
                    joueurs(j) = temp
                End If
            Next
        Next
    End Sub

    Public Sub TrierParScore()
        For i As Integer = 0 To nbJoueurs - 2
            For j As Integer = i + 1 To nbJoueurs - 1
                If joueurs(i).meilleurTemps > joueurs(j).meilleurTemps Then
                    Dim temp As Joueur = joueurs(i)
                    joueurs(i) = joueurs(j)
                    joueurs(j) = temp
                End If
            Next
        Next
    End Sub



End Module
