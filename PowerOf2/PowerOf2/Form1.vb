Public Class Form1
    'Austin Keener
    '10/29/2012
    'Power Of 2

    'Executed when the calculate button is clicked
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        lblDisplay.Text = ""  'Sets the text in lblDisplay to nothing so that if the button is clicked again, it wont duplicate text.

        For power As Integer = 1 To 10 Step 1       'creates a variable called "power" to be used in the loop.  sets it to 1 and will increase it by 1 each time the loop is run to a max of 10 which will stop the loop  
            lblDisplay.Text &= "2 to the " & power & " equals " & 2 ^ power & vbCrLf    'Adds the text and the variables defined to the current string defined by lblDisplay.text
        Next

    End Sub
End Class
