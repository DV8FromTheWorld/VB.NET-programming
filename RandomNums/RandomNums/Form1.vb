Public Class Form1
    'Austin Keener
    '12/10/2012
    'Random Nums

    Dim Gen As New Random()
    Dim intRandomNumbers(9) As Integer

    Private Sub btnGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGen.Click
        lstNumbers.Items.Clear()
        lblDisplay.Text = ""
        For intCounter As Integer = 0 To 9
            intRandomNumbers(intCounter) = Gen.Next(1, 101)
            lstNumbers.Items.Add(intRandomNumbers(intCounter))
        Next
    End Sub

    Private Sub btnHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        Array.Sort(intRandomNumbers)
        Array.Reverse(intRandomNumbers)
        lblDisplay.Text = "High Number: " & intRandomNumbers(0)
    End Sub

    Private Sub btnLow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLow.Click
        Array.Sort(intRandomNumbers)
        lblDisplay.Text = "Low Number: " & intRandomNumbers(0)
    End Sub
End Class
