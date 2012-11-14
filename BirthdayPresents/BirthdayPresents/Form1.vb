Public Class Form1
    'Austin Keener
    'Birthday Presents
    '11/13/2012

    'Executed when the button is clicked
    Private Sub bntPresents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntPresents.Click
        lstPresents.Items.Clear()                'Clears the previous items from the list box.
        For intLoopCounter As Integer = 1 To 5      'Loops 5 times
            lstPresents.Items.Add(InputBox("Enter a present"))
        Next
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class
