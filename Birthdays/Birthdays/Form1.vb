Public Class Form1
    'Austin Keener
    '12/7/2012
    'Birthdays

    Private Sub btnBirthdays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBirthdays.Click
        lstDisplay.Items.Clear()
        Dim strNames(3) As String
        Dim strBirthdays(3) As String
        For intCounter As Integer = 0 To 3
            strNames(intCounter) = InputBox("Enter the name of the person", "Person's Name")
            strBirthdays(intCounter) = InputBox("Enter the birthday of the person", "Person's Birthday")
            lstDisplay.Items.Add(strNames(intCounter) & Space(1) & strBirthdays(intCounter))
        Next
    End Sub
End Class
