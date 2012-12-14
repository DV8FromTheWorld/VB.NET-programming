Public Class Form1
    'Austin Keener
    '12/12/2012
    'Math Example

    Private Sub btnAbsoluteValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbsoluteValue.Click
        lblDisplay.Text = ""
        Dim dblUserInput As Double
        If Double.TryParse(txtNumber.Text, dblUserInput) Then
            lblDisplay.Text = Math.Abs(dblUserInput)
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub btnSquareRoot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSquareRoot.Click
        lblDisplay.Text = ""
        Dim dblUserInput As Double
        If Double.TryParse(txtNumber.Text, dblUserInput) Then
            lblDisplay.Text = Math.Sqrt(dblUserInput)
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub btnSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSign.Click
        lblDisplay.Text = ""
        Dim dblUserInput As Double
        If Double.TryParse(txtNumber.Text, dblUserInput) Then
            Select Case Math.Sign(dblUserInput)
                Case 0
                    lblDisplay.Text = "The number is zero"
                Case 1
                    lblDisplay.Text = "The number is positive."
                Case -1
                    lblDisplay.Text = "The number is negative"
            End Select
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub

    Private Sub btnRound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRound.Click
        lblDisplay.Text = ""
        Dim dblUserInput As Decimal
        Dim intPlacesToRound As Integer
        If Double.TryParse(txtNumber.Text, dblUserInput) Then
            If Int32.TryParse(InputBox("How many places would you like to round to?", "Rounding"), intPlacesToRound) Then
                lblDisplay.Text = Math.Round(dblUserInput, intPlacesToRound)  'Rounding seems to be bugged, not sure why..
            Else
                MessageBox.Show("Please enter an integer to specify how many places to round to")
            End If
        Else
            MessageBox.Show("Please enter a valid number")
        End If
    End Sub
End Class
