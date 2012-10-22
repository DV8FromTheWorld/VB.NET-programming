Public Class Form1
    'Austin Keener
    'CellPhone
    '10/19/2012

    Dim intMinutes As Integer = 0
    Dim dblCostForMinutes As Double = 0.0
    Dim dblTaxCost As Double = 0.0
    Dim dblTotal As Double = 0.0
    Const dblMonthlyCost As Double = 9.95

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        updatePriceVariables()
        updatePriceDisplay()
    End Sub

    Private Sub txtMinutes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMinutes.TextChanged

        Try
            intMinutes = txtMinutes.Text
        Catch ex As Exception
            intMinutes = 0
        End Try

    End Sub
    Public Sub updatePriceVariables()
        dblTaxCost = (dblMonthlyCost + dblCostForMinutes) * 0.07
        dblTotal = dblMonthlyCost + dblCostForMinutes + dblTaxCost
    End Sub
    Public Sub updatePriceDisplay()
        lblDisplay.Text = _
            "Regular Fee: " & dblMonthlyCost.ToString("$##0.00") & vbCrLf & _
            "Minutes Cost: " & dblCostForMinutes.ToString("$##0.00") & vbCrLf & _
            "Taxes: " & dblTaxCost.ToString("$##0.00") & vbCrLf & _
            "Total Charge: " & dblTotal.ToString("$##0.00")
    End Sub
End Class