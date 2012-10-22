Public Class Form1
    ''' Austin Keener
    ''' 10/10/2012

    Dim intMints As String = 0

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        Try
            intMints = txtAmount.Text
        Catch ex As Exception
            intMints = 0
        End Try
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblServings.Text = intMints \ 3
        lblAmountLeft.Text = intMints Mod 3
    End Sub
End Class
