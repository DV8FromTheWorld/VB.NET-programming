Public Class Form1
    'Austin Keener
    '11/19/2012
    'Cost Calculator

    'Initializes required variables.
    Dim dblCost As Double = 0.0
    Dim dblAmount As Double = 0.0

    'Executed when the Calulcate button is clicked.
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If Double.TryParse(txtCost.Text, dblCost) Then
            If Double.TryParse(txtAmount.Text, dblAmount) Then
                lblDisplay.Text = "The total cost of your items is " & (dblCost * dblAmount).ToString("$##0.00")
            Else
                lblDisplay.Text = "Please enter a number for the amount of item(s)."    'User debug
            End If
        Else
            lblDisplay.Text = "Please enter a number for the cost of the item."         'User debug
        End If
    End Sub

    'Executed when the Close menu is selected.
    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()      'Closes the program
    End Sub
End Class
