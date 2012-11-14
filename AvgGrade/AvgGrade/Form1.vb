Public Class Form1
    'Austin Keener
    'AvgGrade
    '11/9/2012


    'Exectutes when the Average Button is clicked
    Private Sub btnAverage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim intGradeAccumilator As Integer = 0
        Dim dblAverage As Double = 0.0
        Dim grade(5) As Integer
        Dim strGradeDisplay As String = ""

        For intLoopCounter As Integer = 1 To 5
            grade(intLoopCounter) = InputBox("Enter grade " & intLoopCounter)
            intGradeAccumilator += grade(intLoopCounter)
            strGradeDisplay &= "Grade Entered: " & grade(intLoopCounter) & vbCrLf
        Next

        dblAverage = intGradeAccumilator / 5
        strGradeDisplay &= "Grade Average: " & dblAverage.ToString("###.#")
        lblAverageDisplay.Text = strGradeDisplay

    End Sub
End Class
