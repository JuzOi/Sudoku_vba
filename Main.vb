﻿Imports System.IO

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
    Const PAS_EXT As Integer = 2
    Public difficulte As Collection
    Public son As System.Media.SoundPlayer

    Public taille_zone As Integer
    Public taille_grille As Integer

    Sub Main()
        nbJoueurs = 0
        ReDim joueurs(0)
        difficulte = New Collection From {
            {60, "Facile"},
            {45, "Moyen"},
            {30, "Difficile"}
        }

        ChangerBackground("\..\..\My Project\Images\MinecraftTheme.png")
        ChangerMusique("\..\..\My Project\Sons\MinecraftThemeSong.wav")
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

    Public Sub ChangerMusique(chemin As String)
        If son IsNot Nothing Then
            son.Stop()
            son.Dispose()
        End If
        son = New Media.SoundPlayer(Application.StartupPath & chemin)
        son.Load()
        son.PlayLooping()
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

    Public Sub ChangerBackground(chemin As String)
        Principale.BackgroundImage = Image.FromFile(Application.StartupPath & chemin)
        Jeu.BackgroundImage = Image.FromFile(Application.StartupPath & chemin)
        Classement.BackgroundImage = Image.FromFile(Application.StartupPath & chemin)
    End Sub
End Module
