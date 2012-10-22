Public Class Form1
    Dim Gen As New Random()
    Dim intSecret As Integer = 0
    Dim intGuess As Integer = 0
    Dim intTries As Integer = 0
    Private Sub txtGuess_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuess.TextChanged
        Try
            intGuess = txtGuess.Text
        Catch ex As Exception
            intGuess = 0
        End Try
    End Sub

    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        intTries = intTries + 1
        If intGuess > intSecret Then
            lblDisplay.Text = "Nope!  Guess is too high!"
        ElseIf intGuess < intSecret Then
            lblDisplay.Text = "Nope!  Guess is too low!"
        Else
            MessageBox.Show("Great job! You got it right!")
            lblDisplay.Text = "You took " & intTries & " tries."
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intSecret = Gen.Next(50)
    End Sub
End Class
