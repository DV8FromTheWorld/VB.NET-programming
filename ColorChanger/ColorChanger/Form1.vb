Public Class Form1
    'Austin Keener
    '11/13/2012
    'Color Changer


    Private Sub mnuRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRed.Click
        Me.BackColor = Color.Red
    End Sub

    Private Sub mnuBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBlue.Click
        Me.BackColor = Color.Blue
    End Sub

    Private Sub mnuGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGreen.Click
        Me.BackColor = Color.Green
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class
