Public Class Form1
    'Austin Keener
    '11/2/2012
    'UniqueRandomNumbers

    'Executes when Button Generate is clicked.
    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        'Defines all variables that will be used.
        Dim blnGreaterThan3 As Boolean = False
        Dim blnIntegerEntered As Boolean = False
        Dim intUserNumber As Integer = 0
        Dim intRandomNumber1 As Integer = 0
        Dim intRandomNumber2 As Integer = 0
        Dim intRandomNumber3 As Integer = 0
        Dim intCounter As Integer = 0
        Dim Generate As New Random()


        While Not blnGreaterThan3
            blnIntegerEntered = False       'Resets the boolean so the inputBox loop will resume.  (prevents infinite loop)

            While Not blnIntegerEntered
                Try
                    intUserNumber = InputBox("Enter a number larger than 3")        'Gets the integer entered
                    blnIntegerEntered = True                                    'Used to exit the loop
                Catch ex As Exception
                    MessageBox.Show("Error, Please enter an integer value")
                    blnIntegerEntered = False                                   'Used to stay in the loop to enter a correct integer
                End Try
            End While

            If intUserNumber <= 3 Then          'If statements check that the number is greater than 3
                blnGreaterThan3 = False                 'Used to stay in the loop, causing the user to start over again, needing to re-enter an integer
                MessageBox.Show("Sorry, your number was not greater than 3, please enter a number greater than 3")
            ElseIf intUserNumber > 3 Then
                blnGreaterThan3 = True          'Used to exit the loop set because the integer is greater than 3
            End If

        End While

        intRandomNumber1 = Generate.Next(1, intUserNumber)  ' }
        intRandomNumber2 = Generate.Next(1, intUserNumber)  ' }  Used to initially generate the random numbers
        intRandomNumber3 = Generate.Next(1, intUserNumber)  ' }
        intCounter = 1      'Adds 1 to the counter, because this is the first loop to generate numbers

        'Checks to see if ANY of the numbers are the same, if they are, it executes.
        While (intRandomNumber1 = intRandomNumber2) Or (intRandomNumber1 = intRandomNumber3) Or (intRandomNumber2 = intRandomNumber3)

            While intRandomNumber1 = intRandomNumber3       'checks if num1 and num3 are the same
                intRandomNumber3 = Generate.Next(1, intUserNumber)  'Generates a new num for num3
                intCounter += 1                                     'Adds 1 to the loop counter
            End While

            While intRandomNumber1 = intRandomNumber2       'checks if num1 and num 2 are the same
                intRandomNumber2 = Generate.Next(1, intUserNumber)  'Generates a new num for num2
                intCounter += 1                             'Adds 1 to the loop counter
            End While

            While intRandomNumber2 = intRandomNumber3       'Checks if num2 and num3 are the same
                intRandomNumber3 = Generate.Next(1, intUserNumber)      'Generates a new num for num3
                intCounter += 1                             'Adds 1 to the loop counter
            End While
        End While


        'Displays the randomly generated numbers and the amount of loops needed
        lblNumberGeneratedDisplay.Text = intRandomNumber1 & Space(5) & intRandomNumber2 & Space(5) & intRandomNumber3
        lblLoopCounterDisplay.Text = intCounter & " loop(s) needed to generate unique numbers"

    End Sub

End Class
