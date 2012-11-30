Public Class Form1
    'Austin Keener
    '11/30/2012
    'Savings

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dblAmountPerMonth As Double
        Dim intMonthTotal As Integer
        If Double.TryParse(txtAmount.Text, dblAmountPerMonth) Then
            If Int32.TryParse(txtMonths.Text, intMonthTotal) Then
                lblDisplay.Text = "You deposited a total amount of " & calcDeposit(dblAmountPerMonth, intMonthTotal).ToString("$##0.00")
            Else
                MessageBox.Show("Please an enter interger for the amount of months")            'User Debug
            End If
        Else
            MessageBox.Show("Please enter an number for the amount deposited each month")       'User Debug
        End If
    End Sub

    Private Function calcDeposit(ByVal dblAmount As Double, ByVal intMonths As Integer) As Double
        Return (dblAmount * intMonths)      'Calculates the total and returns it.
    End Function
End Class
