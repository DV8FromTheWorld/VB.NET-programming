Public Class Form1
    'Austin Keener
    'CellPhone
    '10/19/2012

    Dim intMinutes As Integer = 0
    Dim dblCostForMinutes As Double = 0.0
    Dim dblTaxCost As Double = 0.0
    Dim dblTotal As Double = 0.0

    'Called as a constant because the price per month on the phone bill has a set monthly charge of $9.95
    Const dblMonthlyCost As Double = 9.95


    'Method called on button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'does a case select to calculate the cost for minutes (first 200 minutes are free)
        Select Case intMinutes
            Case 0 To 200
                dblCostForMinutes = 0
            Case 201 To 300
                dblCostForMinutes = (intMinutes - 200) * 0.17
            Case 301 To 500
                dblCostForMinutes = (intMinutes - 200) * 0.15
            Case Is > 500
                dblCostForMinutes = (intMinutes - 200) * 0.12
        End Select

        'called to calculate final costs and display them
        updatePriceVariables()
        updatePriceDisplay()
    End Sub

    'updated the varible that contains the amount of minutes used.
    Private Sub txtMinutes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinutes.TextChanged

        'uses a try catch statment so that if a double/decimal or a string is entered, it wont crash the program
        Try
            intMinutes = txtMinutes.Text
        Catch ex As Exception

            'sets the variable to 0 if a string is entered ("" which is nothing entered is considered a string)
            intMinutes = 0
        End Try
    End Sub

    'calculated the totals and the taxes to be displayed
    Public Sub updatePriceVariables()
        dblTaxCost = (dblMonthlyCost + dblCostForMinutes) * 0.07
        dblTotal = dblMonthlyCost + dblCostForMinutes + dblTaxCost
    End Sub

    'Method updated the lblDisplay with the prices calculated by updatePriceVariables()
    Public Sub updatePriceDisplay()
        lblDisplay.Text = _
            "Regular Fee: " & dblMonthlyCost.ToString("$##0.00") & vbCrLf & _
            "Minutes Cost: " & dblCostForMinutes.ToString("$##0.00") & vbCrLf & _
            "Taxes: " & dblTaxCost.ToString("$##0.00") & vbCrLf & _
            "Total Charge: " & dblTotal.ToString("$##0.00")
    End Sub
End Class