Imports System.IO

Module Main
    Structure Joueur
        Dim nom As String
        Dim meilleurTemps As Double
        Dim difficulte As String
        Dim nbPartieJoue As Integer
        Dim cumul As Integer
    End Structure

    Private joueurs() As Joueur
    Private nbJoueurs As Integer
    Private Const PAS_EXT As Integer = 2
    Public difficulte As Collection

    Private son As System.Media.SoundPlayer
    Private SonEnFond As Boolean = True

    Public taille_zone As Integer
    Public taille_grille As Integer

    Private Theme As String = "Sonic"
    Private ThemeSetting As String = "Clair"



    Sub Main()
        nbJoueurs = 0
        ReDim joueurs(0)
        difficulte = New Collection From {
            {60, "Facile"},
            {45, "Moyen"},
            {30, "Difficile"}
        }

        ChangerBackground()
        LancerMusic()
        ChargerJoueurs()

        Options.InitScrollBar()
        Application.Run(Principale)
    End Sub

    Private Sub ChargerJoueurs()
        Dim F1 As Integer = FreeFile()
        FileOpen(F1, "Joueur.txt", OpenMode.Random)
        Dim joueur As New Joueur
        Do Until EOF(F1)
            FileGet(F1, joueur)
            AjouterJoueur(joueur)
        Loop
        FileClose(F1)
    End Sub
    Public Sub AjouterJoueur(j As Joueur)
        If UBound(joueurs) = nbJoueurs - 1 Then
            ReDim Preserve joueurs(PAS_EXT * nbJoueurs)
        End If
        joueurs(nbJoueurs) = j
        nbJoueurs += 1
    End Sub

    Public Sub ActualiserScore(nom As String, temps As Integer, difficulte As String)
        Dim newTemps As Integer = Options.scrollTime.Value - temps
        For i As Integer = 0 To nbJoueurs - 1
            If joueurs(i).nom.Equals(nom) Then
                If joueurs(i).meilleurTemps > newTemps Then
                    joueurs(i).meilleurTemps = newTemps
                    joueurs(i).difficulte = difficulte
                End If
            End If
        Next
    End Sub

    Public Sub AjouterTemps(nom As String, temps As Integer)
        Dim tempsDeJeu As Integer = Options.scrollTime.Value - temps
        For i As Integer = 0 To nbJoueurs - 1
            If joueurs(i).nom.Equals(nom) Then
                joueurs(i).cumul += tempsDeJeu
            End If
        Next
    End Sub

    Public Sub IncPartie(nom As String)
        For i As Integer = 0 To nbJoueurs - 1
            If joueurs(i).nom = nom Then
                joueurs(i).nbPartieJoue += 1
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



    Public Function GetNbJoueurs() As Integer
        Return nbJoueurs
    End Function

    Public Function GetJoueurs(index As Integer) As Joueur
        If index >= 0 And index < nbJoueurs Then
            Return joueurs(index)
        End If
        Return Nothing
    End Function

    Public Function NouveauJoueur(nom As String) As Joueur
        Dim newJoueur As Joueur
        With newJoueur
            .nom = nom
            .meilleurTemps = 1 / 0
            .difficulte = ""
            .nbPartieJoue = 0
            .cumul = 0
        End With
        Return newJoueur
    End Function

    Public Function getImage() As String
        Return Theme & ThemeSetting
    End Function

    Public Function getSon() As String
        Return Theme & ThemeSetting
    End Function

    Public Sub ChangerThemeSetting(NewThemeSetting As String)
        ThemeSetting = NewThemeSetting
        ChangerBackground()
        ChangerMusique()
    End Sub
    Public Sub ChangerTheme(NewTheme As String)
        Theme = NewTheme
        ChangerBackground()
        ChangerMusique()
    End Sub

    Public Sub ChangerBackground()
        Dim img As String = getImage()

        Principale.BackgroundImage = Image.FromFile(Application.StartupPath & "\..\..\My Project\Images\" & img & ".png")
        Jeu.BackgroundImage = Image.FromFile(Application.StartupPath & "\..\..\My Project\Images\" & img & ".png")
        Classement.BackgroundImage = Image.FromFile(Application.StartupPath & "\..\..\My Project\Images\" & img & ".png")
    End Sub


    Public Sub AllumerSon()
        SonEnFond = True
        ChangerMusique()
    End Sub

    Public Sub CouperSon()
        SonEnFond = False
        ChangerMusique()
    End Sub

    Public Sub LancerMusic()
        son = New Media.SoundPlayer(Application.StartupPath & "\..\..\My Project\Sons\" & getSon() & ".wav")
        son.Load()
        son.PlayLooping()
    End Sub

    Public Sub ChangerMusique()
        If SonEnFond Then
            LancerMusic()
        Else
            son.Stop()
            son.Dispose()
        End If
    End Sub

    Public Function GetSonEnFond()
        Return SonEnFond
    End Function

End Module
