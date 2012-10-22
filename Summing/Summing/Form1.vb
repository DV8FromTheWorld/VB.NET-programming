Public Class Form1
    'Austin Keener
    '5.02 Exercise 1 - Summing
    'October 9, 2012

    'Declares and initializes all variables. 
    'NOTE: Since the test scores are initialized as 0, they will not affect the average if they are not used.
    Dim dblTestScore1 As Double = 0
    Dim dblTestScore2 As Double = 0
    Dim dblTestScore3 As Double = 0
    Dim dblTestScore4 As Double = 0
    Dim dblAverage As Double = 0
    Dim intTestAmount As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtTest1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTest1.TextChanged
        'Try statements are used because if the user "backspaces/deletes" the numbers in the text box, it will break without the try statement
        Try
            dblTestScore1 = txtTest1.Text
        Catch ex As Exception
            'We set the test score to 0 here if the try statement doesnt work because there is an invalid character in the text box.
            'This way, it wont affect the avarage because if the value for the variable was set previous,
            'but then it was removed, it wouldnt changed due to the try statement failing if we did not have this code here, which would mess up the average.
            dblTestScore1 = 0
        End Try
    End Sub

    Private Sub txtTest2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTest2.TextChanged
        'Try statements are used because if the user "backspaces/deletes" the numbers in the text box, it will break without the try statement
        Try
            dblTestScore2 = txtTest2.Text
        Catch ex As Exception
            'We set the test score to 0 here if the try statement doesnt work because there is an invalid character in the text box.
            'This way, it wont affect the avarage because if the value for the variable was set previous,
            'but then it was removed, it wouldnt changed due to the try statement failing if we did not have this code here, which would mess up the average.
            dblTestScore2 = 0
        End Try
    End Sub

    Private Sub txtTest3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTest3.TextChanged
        'Try statements are used because if the user "backspaces/deletes" the numbers in the text box, it will break without the try statement
        Try
            dblTestScore3 = txtTest3.Text
        Catch ex As Exception
            'We set the test score to 0 here if the try statement doesnt work because there is an invalid character in the text box.
            'This way, it wont affect the avarage because if the value for the variable was set previous,
            'but then it was removed, it wouldnt changed due to the try statement failing if we did not have this code here, which would mess up the average.
            dblTestScore3 = 0
        End Try
    End Sub

    Private Sub txtTest4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTest4.TextChanged
        'Try statements are used because if the user "backspaces/deletes" the numbers in the text box, it will break without the try statement
        Try
            dblTestScore4 = txtTest4.Text
        Catch ex As Exception
            'We set the test score to 0 here if the try statement doesnt work because there is an invalid character in the text box.
            'This way, it wont affect the avarage because if the value for the variable was set previous,
            'but then it was removed, it wouldnt changed due to the try statement failing if we did not have this code here, which would mess up the average.
            dblTestScore4 = 0
        End Try
    End Sub

    Private Sub btnCalcAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcAverage.Click
        'this line "getTestAmount()" calls a method below.  For information on it, check the method's comments.
        getTestAmount()

        'Calculates the average and then displays it.
        dblAverage = (dblTestScore1 + dblTestScore2 + dblTestScore3 + dblTestScore4) / intTestAmount
        lblAverageDisplay.Text = "Your average test grade is: " & dblAverage.ToString("###.#")
    End Sub

    Private Sub lblAverageDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAverageDisplay.Click

    End Sub

    Public Sub getTestAmount()
        'This method figures out how many tests are being averaged.

        'We set the amount of tests to 0 each method run to accurately calculate the amount of tests being averaged.
        intTestAmount = 0

        'This if statment calls a method called "IsNullOrEmpty", which requires a string to check, which we provide as the textbox's text
        'It checks to see if the string is empty or null.  If it is empty, it returns true, if it isnt empty, it returns false.
        'The if statement is looking for a false return (not).  If it isnt empty (returns false), then it will execute the code in the if statment.
        'The code in the if statement takes the variable "intTestAmount" and adds 1 to it. This process is repeated for each test textbox.
        If Not String.IsNullOrEmpty(txtTest1.Text) Then
            intTestAmount = intTestAmount + 1
        End If
        If Not String.IsNullOrEmpty(txtTest2.Text) Then
            intTestAmount = intTestAmount + 1
        End If
        If Not String.IsNullOrEmpty(txtTest3.Text) Then
            intTestAmount = intTestAmount + 1
        End If
        If Not String.IsNullOrEmpty(txtTest4.Text) Then
            intTestAmount = intTestAmount + 1
        End If

    End Sub
End Class
