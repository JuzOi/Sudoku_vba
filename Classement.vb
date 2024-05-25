Public Class Classement
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Principale.Show()
    End Sub

    Private Sub Classement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Sorted = True
    End Sub
End Class