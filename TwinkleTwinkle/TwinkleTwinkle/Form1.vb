Public Class Form1
    'Austin Keener
    '11/27/2012
    'Twinkle Twinkle

    Private Sub btnPoemShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoemShow.Click
        displayPoem()
    End Sub

    Private Sub displayPoem()
        lblDisplay.Text = _
            "Twinkle Twinkle Little Star" & vbCrLf & _
            "How I wonder what you are" & vbCrLf & _
            "Up above the world so bright" & vbCrLf & _
            "Like a diamond in the night."
    End Sub
End Class
