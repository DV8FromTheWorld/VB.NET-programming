Public Class Form1
    Dim dblGrade As Double = -1

    Private Sub txtGrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGrade.TextChanged
        Try
            dblGrade = txtGrade.Text
        Catch ex As Exception
            dblGrade = -1
        End Try
    End Sub

    Private Sub btnGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrade.Click
        Select Case dblGrade
            Case 0 To 69
                lblDisplay.Text = "Study More!"
            Case 70 To 76
                lblDisplay.Text = "You made a D."
            Case 77 To 84
                lblDisplay.Text = "You made a C."
            Case 85 To 92
                lblDisplay.Text = "You made a B."
            Case 93 To 100
                lblDisplay.Text = "You made an A."
            Case -1
                lblDisplay.Text = "No grade entered."
        End Select
    End Sub
End Class
