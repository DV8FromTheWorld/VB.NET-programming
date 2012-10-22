Public Class Form1
    'Austin Keener
    'Quick Cuts
    '10/19/2012

    Dim dblTotal As Double = 0.0

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        dblTotal = 0.0
        If chkHairCut.Checked Then
            dblTotal = dblTotal + 9.95
        End If
        If chkShampoo.Checked Then
            dblTotal = dblTotal + 3.95
        End If
        If chkStyle.Checked Then
            dblTotal = dblTotal + 5.95
        End If
        If chkMassage.Checked Then
            dblTotal = dblTotal + 2.95
        End If
        updateDisplay()
    End Sub
    Public Sub updateDisplay()
        lblDisplay.Text = "Your total is: " & dblTotal.ToString("$#0.00")
    End Sub
End Class
