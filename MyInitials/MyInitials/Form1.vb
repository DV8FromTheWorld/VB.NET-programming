Public Class Form1
    'Austin Keener
    '1/3/2013
    'My Initials

    Private Sub btnInitials_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInitials.Click
        'String to set      Gets first initial  /  adds space / gets character at index / gets index of the space and adds 1 / Sets the whole string to upper case
        lblDisplay.Text = (txtInitials.Text.Chars(0) & Space(1) & txtInitials.Text.Chars(txtInitials.Text.IndexOf(" ") + 1)).ToUpper
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class
