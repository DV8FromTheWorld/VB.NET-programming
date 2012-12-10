Public Class Form1
    'Austin Keener
    '11/4/2012
    'Friends Array

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        lblDisplay.Text = ""                                'resets the label   
        Dim strFriendsArray(4) As String                    'defines an array, for strings, with 5 elements (0 - 4)
        For intCounter As Integer = 0 To (strFriendsArray.Length - 1)
            strFriendsArray(intCounter) = InputBox("Enter a friends's name.", "BFF")
        Next
        Array.Sort(strFriendsArray)
        For intCounter As Integer = 0 To (strFriendsArray.Length - 1)
            lblDisplay.Text &= strFriendsArray(intCounter) & vbCrLf
        Next
    End Sub
End Class
