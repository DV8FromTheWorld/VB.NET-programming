Public Class Form1
    'Austin Keener
    '11/29/2012
    'Sort Nums

    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        lblDisplay.Text = ""        'Resets the label
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        If Int32.TryParse(InputBox("Enter first number to be sorted"), intNum1) Then        'Makes sure that the user entered an integer
            If Int32.TryParse(InputBox("Enter second number to sorted"), intNum2) Then      'Makes sure that the user entered an integer
                sortNum(intNum1, intNum2)
            Else
                MessageBox.Show("Please enter an integer")  'User Debug
            End If
        Else
            MessageBox.Show("Please enter an integer")      'User Debug
        End If
    End Sub

    Private Sub sortNum(ByVal intTemp1 As Integer, ByVal intTemp2 As Integer)
        If intTemp1 < intTemp2 Then
            lblDisplay.Text = "The low number is " & intTemp1 & " and the high number is " & intTemp2
        ElseIf intTemp1 > intTemp2 Then
            lblDisplay.Text = "The low number is " & intTemp2 & " and the high number is " & intTemp1
        ElseIf intTemp1 = intTemp2 Then
            lblDisplay.Text = "The numbers are equal."
        Else
            lblDisplay.Text = "Error, please try again"     'User/Programmer Debug
        End If
    End Sub
End Class
