Public Class Form1
    'Austin Keener
    '11/8/2012
    'Unlock

    'Executes when the Unlock Button is clicked
    Private Sub btnUnlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnlock.Click

        'Defines variables and initializes them
        Dim strPassword As String = ""
        Dim strGuess As String = ""
        Dim blnPasswordCorrect As Boolean = False
        Dim intCounter As Integer = 0

        strPassword = InputBox("Please set your password")  'Sets the password

        While Not blnPasswordCorrect            'Loop that continues as long as the variable "blnPasswordCorrect" is set to false
            strGuess = InputBox("Please enter your password to unlock")     'Gets the user's guess at the password
            intCounter += 1                     'Increases the Counter by 1 each loop

            If strGuess = strPassword Then      'Checks if the user's guess is the same as the password previously set
                MessageBox.Show("Correct! It took you " & intCounter & " attempt(s)")   'Pops up a message box telling the user that their guess was correct and how many attempts it took.
                blnPasswordCorrect = True       'Sets the boolean to true to break out of the while loop, If this code isnt executed (guess was incorrect), then the while loop executes again.
            Else
                MessageBox.Show("Incorrect password, Please try again")     'Tells the user that their guess was incorrect.  
            End If
        End While

    End Sub
End Class
