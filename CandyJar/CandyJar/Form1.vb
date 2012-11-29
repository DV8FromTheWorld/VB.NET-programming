Public Class Form1
    'Austin Keener
    '11/19/2012
    'Candy Jar

    'Initialize required variables
    Dim intGuess As Integer = 0

    'Executed when the Guess button is clicked.
    Private Sub btnGuess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuess.Click
        If Int32.TryParse(txtGuess.Text, intGuess) Then     'Attempts to convert the string given by the textbox to an integer and returns a boolean value based on conversion success.
            Select Case intGuess
                Case 0 To 236
                    lblDisplay.Text = "Nope, too low. Try again!"
                Case 237
                    lblDisplay.Text = "You guessed it!"
                Case 238 To 300
                    lblDisplay.Text = "Nope, too high. Try again!"
                Case Else
                    lblDisplay.Text = "Within 0 - 300 please."              'User debug.
            End Select
        Else
            MessageBox.Show("Please enter an integer for your guess")       'User debug.
        End If
    End Sub
End Class
