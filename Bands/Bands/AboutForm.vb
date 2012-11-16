Public Class AboutForm
    'Austin Keener
    '11/15/2012
    'Bands - About Form

    'Executes when the Close button is selected
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()          'Closes the AboutForm.
        Form1.Show()        'Re-Displays the DefaultForm
    End Sub
End Class