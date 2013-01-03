Public Class Form1
    'Austin Keener
    '1/2/2013
    'Math Fun

    Private Sub mnuAbs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbs.Click
        lblDisplay.Text = ""
        Dim dblNum As Double
        If Double.TryParse(txtNum.Text, dblNum) Then
            lblDisplay.Text = "The absolute value of " & dblNum & " is " & Math.Abs(dblNum)
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub mnuSquare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSquare.Click
        lblDisplay.Text = ""
        Dim dblNum As Double
        If Double.TryParse(txtNum.Text, dblNum) Then
            lblDisplay.Text = dblNum & " squared is " & Math.Sqrt(dblNum)
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub mnuSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSign.Click
        lblDisplay.Text = ""
        Dim dblNum As Double
        If Double.TryParse(txtNum.Text, dblNum) Then
            Select Case Math.Sign(dblNum)
                Case 1
                    lblDisplay.Text = "The sign of " & dblNum & " is positive"
                Case -1
                    lblDisplay.Text = "The sign of " & dblNum & " is negative"
                Case 0
                    lblDisplay.Text = "There is no sign of " & dblNum & " because it is 0"
            End Select

        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub mnuRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRound.Click
        lblDisplay.Text = ""
        Dim dblNum As Double
        If Double.TryParse(txtNum.Text, dblNum) Then
            lblDisplay.Text = dblNum & " rounded to 2 places is " & Math.Round(dblNum, 2)
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class
