Public Class Form1
    'Austin Keener
    '12/5/2012
    'Test Data

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblDisplay.Text = ""
        Dim strTestNameArray(2) As String
        Dim intTestGradeArray(2) As String
        For intCounter As Integer = 0 To 2
            strTestNameArray(intCounter) = InputBox("Enter the name of the Test", "Test Name")
            intTestGradeArray(intCounter) = InputBox("Enter the grade received on test", "Test Grade")
            lblDisplay.Text &= strTestNameArray(intCounter) & " has a grade of " & intTestGradeArray(intCounter) & vbCrLf
        Next
    End Sub
End Class
