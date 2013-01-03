Public Class Form1
    'Austin Keener
    '1/3/2013
    'My Name

    Private Sub btnName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnName.Click
        lblDisplay.Text = ""
        Dim strFirstName, strLastName As String
        strFirstName = InputBox("Input your first name", "First Name")
        strLastName = InputBox("Input your last name", "Last Name")
        strFirstName.Trim()
        strLastName.Trim()
        lblDisplay.Text = String.Concat(strFirstName & Space(1), strLastName)
    End Sub
End Class
