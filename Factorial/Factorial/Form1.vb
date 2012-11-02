Public Class Form1
    'Austin Keener
    '11/1/2012
    'Factorial

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim intFactorial As Integer = 0 'Initializes the variable which will store the factorial
        Dim answer As System.Int64 = 1  'Needs to be an Int64 because Int32 cannot always contain the complete factorization.  Also needs to be a 1 so that the multiplication works.
        lblDisplay.Text = ""        'Resets the label's text

        Try                 'Try Catch to prevent crashing when something besides and integer is entered
            intFactorial = InputBox("Enter the number which you would like to factor")
        Catch ex As Exception
            MessageBox.Show("Error, Please input an integer")       'Tells the users that what the entered was incorrect
        End Try

        For intLoopCounter = 0 To (intFactorial - 1) Step 1
            answer = answer * (intFactorial - intLoopCounter)       'Calculates the current factorial, and multiplies it to the total
        Next

        lblDisplay.Text = answer        'Display the factorial answer
    End Sub
End Class
