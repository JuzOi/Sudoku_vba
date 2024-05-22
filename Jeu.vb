Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Channels
Imports System.Security.Cryptography.X509Certificates

Public Class Jeu
    Private Const TAILLE As Integer = 9
    Private Const TAILLE_BOX As Integer = 20
    Dim compteurTemps As Integer = 0
    Dim solution(,) As Integer

    Dim boxTab()() As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initForm()
        initGrille()
        initTimer()
        GenererSudoku()
    End Sub

    Private Sub initTimer()
        monTimer.Interval = 1000
        monTimer.Start()
        compteurTemps = 420
    End Sub

    Private Sub initGrille()
        pnlGrille.Size = New Size(450, 450)

        boxTab = New TextBox(TAILLE)() {}
        For i As Integer = 0 To TAILLE - 1
            boxTab(i) = New TextBox(TAILLE) {}
        Next


        For i As Integer = 0 To TAILLE - 1
            For j As Integer = 0 To TAILLE - 1
                Dim tbx As New TextBox
                tbx.Size = New Size(TAILLE_BOX, 1)

                Dim x As Integer = i * 5 + (i \ 3) * 7
                Dim y As Integer = j * 2 + (j \ 3) * 7
                tbx.Location = New Point(i * TAILLE_BOX + x, j * TAILLE_BOX + y)

                tbx.MaxLength = 1
                tbx.Tag = New Point(i, j)

                AddHandler tbx.KeyPress, AddressOf Jeu_KeyPress

                boxTab(i)(j) = tbx
                pnlGrille.Controls.Add(tbx)
            Next
        Next

    End Sub

    Private Sub initForm()
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
        txtbox.ForeColor = Color.Black

        If estSurLigne(pos.Y, e.KeyChar) Or estSurColonne(pos.X, e.KeyChar) Or estDansZone(pos.Y, pos.X, e.KeyChar) Then
            txtbox.ForeColor = Color.Red
        End If

    End Sub

    Private Function estSurLigne(ligne As Integer, elt As String) As Boolean
        For i As Integer = 0 To TAILLE - 1
            If boxTab(i)(ligne).Text = elt Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function estSurColonne(colonne As Integer, elt As String) As Boolean
        For j As Integer = 0 To TAILLE - 1
            If boxTab(colonne)(j).Text = elt Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function estDansZone(ligne As Integer, colonne As Integer, elt As String) As Boolean
        Dim debutLigne As Integer = (ligne \ 3) * 3
        Dim debutColonne As Integer = (colonne \ 3) * 3

        For i As Integer = debutColonne To debutColonne + 2
            For j As Integer = debutLigne To debutLigne + 2
                If boxTab(i)(j).Text = elt Then
                    Return True
                End If
            Next
        Next
        Return False
    End Function

    Private Sub monTimer_Tick(sender As Object, e As EventArgs) Handles monTimer.Tick
        If compteurTemps > 0 Then
            Dim minutes As Integer = compteurTemps \ 60
            Dim seconds As Integer = compteurTemps Mod 60
            lblTimer.Text = String.Format("{0:D2}:{1:D2}", minutes, seconds)
        End If
        compteurTemps -= 1
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        Principale.Show()
    End Sub

    Private Function PeutPlacerNombre(plateau(,) As Integer, ligne As Integer, colonne As Integer, num As Integer) As Boolean
        For x As Integer = 0 To TAILLE - 1
            If plateau(ligne, x) = num Or plateau(x, colonne) = num Then
                Return False
            End If
        Next

        Dim debutLigne As Integer = ligne - ligne Mod 3
        Dim debutColonne As Integer = colonne - colonne Mod 3

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If plateau(i + debutLigne, j + debutColonne) = num Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Private Function ResoudreSudoku(plateau(,) As Integer) As Boolean
        For ligne As Integer = 0 To TAILLE - 1
            For colonne As Integer = 0 To TAILLE - 1
                If plateau(ligne, colonne) = 0 Then
                    Dim nums As List(Of Integer) = MelangerNombres()
                    For Each num As Integer In nums
                        If PeutPlacerNombre(plateau, ligne, colonne, num) Then
                            plateau(ligne, colonne) = num
                            If ResoudreSudoku(plateau) Then
                                Return True
                            End If
                            plateau(ligne, colonne) = 0
                        End If
                    Next
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Function MelangerNombres() As List(Of Integer)
        Dim nums As New List(Of Integer)(Enumerable.Range(1, TAILLE))
        Dim rand As New Random()
        For i As Integer = 0 To nums.Count - 1
            Dim j As Integer = rand.Next(i, nums.Count)
            Dim temp As Integer = nums(i)
            nums(i) = nums(j)
            nums(j) = temp
        Next
        Return nums
    End Function

    Private Function GenererSolutionSudoku() As Integer(,)
        Dim plateau(TAILLE - 1, TAILLE - 1) As Integer
        ResoudreSudoku(plateau)
        Return plateau
    End Function

    Private Sub SupprimerCellules(plateau(,) As Integer, celluleASupprimer As Integer)
        Dim rnd As New Random()
        Dim compteur As Integer = celluleASupprimer

        While compteur > 0
            Dim ligne As Integer = rnd.Next(TAILLE)
            Dim colonne As Integer = rnd.Next(TAILLE)

            If plateau(ligne, colonne) <> 0 Then
                plateau(ligne, colonne) = 0
                compteur -= 1
            End If
        End While
    End Sub

    Private Sub RemplirCases(plateau(,) As Integer)
        For i As Integer = 0 To TAILLE - 1
            For j As Integer = 0 To TAILLE - 1
                If plateau(i, j) = 0 Then
                    boxTab(i)(j).Text = ""
                Else
                    boxTab(i)(j).Text = plateau(i, j).ToString()
                End If
            Next
        Next
    End Sub
    Private Sub GenererSudoku()
        Dim plateauComplet As Integer(,) = GenererSolutionSudoku()
        solution = New Integer(TAILLE, TAILLE) {}
        For i As Integer = 0 To TAILLE - 1
            For j As Integer = 0 To TAILLE - 1
                solution(i, j) = plateauComplet(i, j)
            Next
        Next

        Dim CelluleASupprimer As Integer = 40
        SupprimerCellules(plateauComplet, CelluleASupprimer)
        RemplirCases(plateauComplet)
    End Sub

    Private Sub btnRegenerer_Click(sender As Object, e As EventArgs) Handles btnRegenerer.Click
        GenererSudoku()
    End Sub

    Private Sub btnSolution_Click(sender As Object, e As EventArgs) Handles btnSolution.Click
        For i As Integer = 0 To TAILLE - 1
            For j As Integer = 0 To TAILLE - 1
                If boxTab(i)(j).Text <> solution(i, j).ToString Then
                    boxTab(i)(j).Text = solution(i, j).ToString
                End If
            Next
        Next
    End Sub
End Class