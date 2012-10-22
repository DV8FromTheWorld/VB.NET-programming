Public Class Form1
    'Austin Keener
    'SuperSize
    '10/19/2012

    Dim dblCost As Double = 0.0
    Dim Generate As New Random()

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        updatePriceVariables()
        updateTicketNumber()
        updatePriceDisplay()
    End Sub
    Public Sub updatePriceVariables()
        dblCost = 0.0
        If chkHamburger.Checked Then
            dblCost = dblCost + 2.95
        End If
        If chkCheeseburger.Checked Then
            dblCost = dblCost + 3.95
        End If
        If chkFries.Checked Then
            dblCost = dblCost + 1.95
        End If
        If chkOnionRings.Checked Then
            dblCost = dblCost + 2.5
        End If
        If (chkHamburger.Checked Or chkCheeseburger.Checked Or chkFries.Checked Or chkOnionRings.Checked) And radSuperSize.Checked Then
            dblCost += 2
        End If
    End Sub
    Public Sub updateticketNumber()
        lblOrderNumber.Text = "Ticket number: #" & Generate.Next(100, 1000)
    End Sub
    Public Sub updatePriceDisplay()
        lblCostDisplay.Text = "Your total cost is: " & dblCost.toString("$##0.00")
    End Sub
End Class
