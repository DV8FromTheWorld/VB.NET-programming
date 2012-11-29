Public Class Form1
    'Austin Keener
    '11/29/2012
    'Reasons

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        showReasons()
    End Sub

    Private Sub showReasons()
        lblDisplay.Text = _
            "CS teaches critical thinking." & vbCrLf & _
            "CS touches everyone, everyday" & vbCrLf & _
            "Computering jobs are in high demand."
    End Sub
End Class
