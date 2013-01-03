Public Class Form1
    'Austin Keener
    '1/3/2013
    'New Word

    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        lblDisplay.Text = "The new word is " & txtWord.Text.Replace(txtLetterToReplace.Text, txtReplacementLetter.Text)
    End Sub
End Class
