Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Channels
Imports System.Security.Cryptography.X509Certificates

Public Class Jeu
    Private Const TAILLE_BOX As Integer = 20
    Dim compteurTemps As Integer = 0
    Dim solution(,) As Integer
    Dim abandon As Boolean

    Dim boxTab()() As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub
    Public Sub Init()
        DetruireGrille()
        initForm()
        initTimer()
        initGrille()
    End Sub
    Private Sub initTimer()
        compteurTemps = TEMPS_LIMITE
        monTimer.Interval = 1000
        monTimer.Start()
    End Sub

    Private Sub initGrille()
        pnlGrille.Size = New Size(450, 450)

        boxTab = New TextBox(taille_grille)() {}
        For i As Integer = 0 To taille_grille - 1
            boxTab(i) = New TextBox(taille_grille) {}
        Next


        For i As Integer = 0 To taille_grille - 1
            For j As Integer = 0 To taille_grille - 1
                Dim tbx As New TextBox

                Dim x As Integer = i * 5 + (i \ taille_zone) * 7
                Dim y As Integer = j * 2 + (j \ taille_zone) * 7

                With tbx
                    .Size = New Size(TAILLE_BOX, 1)
                    .Location = New Point(i * TAILLE_BOX + x, j * TAILLE_BOX + y)
                    .MaxLength = 1
                    .Tag = New Point(i, j)
                End With

                AddHandler tbx.KeyPress, AddressOf Jeu_KeyPress

                boxTab(i)(j) = tbx
                pnlGrille.Controls.Add(tbx)
            Next
        Next

        GenererSudoku()
    End Sub

    Private Sub initForm()
        abandon = False
        lblNom.Text = Principale.boxNom.Text
    End Sub

    Private Sub Jeu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar <> vbBack AndAlso (Not Char.IsDigit(e.KeyChar) Or e.KeyChar = "0") Then
            e.Handled = True
        End If
        VerifSaisie(sender, e)
    End Sub

    Private Sub VerifSaisie(sender As Object, e As KeyPressEventArgs)
        Dim txtbox As TextBox = CType(sender, TextBox)
        Dim pos As Point = txtbox.Tag

        If txtbox.Text <> "" Then
            Exit Sub
        End If

        txtbox.ForeColor = Color.Black

        If Not EstNombreValide(pos.X, pos.Y, e.KeyChar) Then
            txtbox.ForeColor = Color.Red
        End If

    End Sub

    Private Function EstNombreValide(ligne As Integer, colonne As Integer, elt As String) As Boolean
        For x As Integer = 0 To taille_grille - 1
            If boxTab(ligne)(x).Text = elt OrElse boxTab(x)(colonne).Text = elt Then
                Return False
            End If
        Next

        Dim debutLigne As Integer = (ligne \ taille_zone) * taille_zone
        Dim debutColonne As Integer = (colonne \ taille_zone) * taille_zone

        For i As Integer = debutLigne To debutLigne + taille_zone - 1
            For j As Integer = debutColonne To debutColonne + taille_zone - 1
                If boxTab(i)(j).Text = elt Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Sub monTimer_Tick(sender As Object, e As EventArgs) Handles monTimer.Tick
        If compteurTemps > 0 Then
            Dim minutes As Integer = compteurTemps \ 60
            Dim seconde As Integer = compteurTemps Mod 60
            lblTimer.Text = String.Format("{0:D2}:{1:D2}", minutes, seconde)
        End If
        compteurTemps -= 1

        If estRemplis() And compteurTemps <> 0 Then
            monTimer.Stop()
            ActualiserScore(lblNom.Text, compteurTemps)
            MsgBox("Bravo, tu a résolu le sudoku. " & vbCrLf & " Ton temps va être affiché dans le classement, nous t'inviter à le regarder !!!", vbYes)
            abandon = True
        End If

        If compteurTemps = 0 Then
            monTimer.Stop()
            AjouterTemps(lblNom.Text, compteurTemps)
            MsgBox("Dommage tu n'as pas résolu le sudoku", vbYes)
            btnSolution.Select()
        End If
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        If abandon Then
            Me.Hide()
            Principale.Show()
            Exit Sub
        End If

        If MsgBox("Souhaitez-vous vraiment abandonner ?", vbYesNo) = vbYes Then
            abandon = True
            AjouterTemps(lblNom.Text, compteurTemps)
            monTimer.Stop()
            If MsgBox("Voulez-vous voir la solution ?", vbYesNo) = vbYes Then
                MontrerSolution()
            Else
                Me.Hide()
                Principale.Show()
            End If
        End If
    End Sub

    Private Function PeutPlacerNombre(ligne As Integer, colonne As Integer, num As Integer) As Boolean
        For x As Integer = 0 To taille_grille - 1
            If solution(ligne, x) = num Or solution(x, colonne) = num Then
                Return False
            End If
        Next

        Dim debutLigne As Integer = ligne - ligne Mod taille_zone
        Dim debutColonne As Integer = colonne - colonne Mod taille_zone

        For i As Integer = 0 To taille_zone - 1
            For j As Integer = 0 To taille_zone - 1
                If solution(i + debutLigne, j + debutColonne) = num Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Private Function GenererSolution() As Boolean
        For ligne As Integer = 0 To taille_grille - 1
            For colonne As Integer = 0 To taille_grille - 1
                If solution(ligne, colonne) = 0 Then
                    Dim nums As List(Of Integer) = MelangerNombres()
                    For Each num As Integer In nums
                        If PeutPlacerNombre(ligne, colonne, num) Then
                            solution(ligne, colonne) = num
                            If GenererSolution() Then
                                Return True
                            End If
                            solution(ligne, colonne) = 0
                        End If
                    Next
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Function MelangerNombres() As List(Of Integer)
        Dim nums As New List(Of Integer)(Enumerable.Range(1, taille_grille))
        Dim rand As New Random()
        For i As Integer = 0 To nums.Count - 1
            Dim j As Integer = rand.Next(i, nums.Count)
            Dim temp As Integer = nums(i)
            nums(i) = nums(j)
            nums(j) = temp
        Next
        Return nums
    End Function


    Private Sub RemplirGrille()
        Dim rnd As New Random()
        Dim compteur As Integer = celluleASupprimer

        While compteur > 0
            Dim ligne As Integer = rnd.Next(taille_grille)
            Dim colonne As Integer = rnd.Next(taille_grille)

            If boxTab(ligne)(colonne).Text = "" Then
                boxTab(ligne)(colonne).Text = solution(ligne, colonne)
                boxTab(ligne)(colonne).Enabled = False
                compteur -= 1
            End If
        End While
    End Sub

    Private Sub GenererSudoku()
        ReDim solution(taille_grille - 1, taille_grille - 1)
        GenererSolution()
        RemplirGrille()
    End Sub

    Private Sub ClearGrille()
        For i As Integer = 0 To taille_grille - 1
            For j As Integer = 0 To taille_grille - 1
                boxTab(i)(j).Text = ""
                boxTab(i)(j).Enabled = True
            Next
        Next
    End Sub

    Private Sub btnRegenerer_Click(sender As Object, e As EventArgs) Handles btnRegenerer.Click
        ClearGrille()
        GenererSudoku()
    End Sub

    Private Sub MontrerSolution()
        For i As Integer = 0 To taille_grille - 1
            For j As Integer = 0 To taille_grille - 1
                If boxTab(i)(j).Text <> solution(i, j).ToString Then
                    boxTab(i)(j).Text = solution(i, j).ToString
                End If
            Next
        Next
    End Sub
    Private Sub btnSolution_Click(sender As Object, e As EventArgs) Handles btnSolution.Click
        MontrerSolution()
    End Sub

    Private Function estRemplis() As Boolean
        For i As Integer = 0 To taille_grille - 1
            For j As Integer = 0 To taille_grille - 1
                If boxTab(i)(j).Text = "" Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Sub DetruireGrille()
        pnlGrille.Controls.Clear()

        If boxTab IsNot Nothing Then
            For i As Integer = 0 To boxTab.Length - 1
                If boxTab(i) IsNot Nothing Then
                    For j As Integer = 0 To boxTab(i).Length - 1
                        If boxTab(i)(j) IsNot Nothing Then
                            boxTab(i)(j).Dispose()
                            boxTab(i)(j) = Nothing
                        End If
                    Next
                    boxTab(i) = Nothing
                End If
            Next
            boxTab = Nothing
        End If
    End Sub

End Class