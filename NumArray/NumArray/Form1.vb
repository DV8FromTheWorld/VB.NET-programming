Public Class Form1
    'Austin Keener
    '12/5/2012
    'Num Array

    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim dblNumbersArray(2) As Double
        addToArray(dblNumbersArray)
        lblDisplay.Text = "The average of the numbers is " & getAverage(dblNumbersArray)
    End Sub

    Private Sub addToArray(ByRef dblNumbers() As Double)
        For intCounter As Integer = 0 To (dblNumbers.Length - 1)
            dblNumbers(intCounter) = InputBox("Enter a number to be be averaged", "Averaging")
        Next
    End Sub

    Private Function getAverage(ByVal dblNumbers() As Double)
        Dim dblAns As Double = 0.0
        For intcounter As Integer = 0 To (dblNumbers.Length - 1)
            dblAns += dblNumbers(intcounter)
        Next
        dblAns = (dblAns / dblNumbers.Length)
        Return dblAns
    End Function
End Class
