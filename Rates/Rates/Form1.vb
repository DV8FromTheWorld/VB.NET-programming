Public Class Form1
    'Austin Keener
    '12/6/2012
    'Rates

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        Dim dblNumberArray() As Double = {2.3, 2.2, 2.0, 2.1, 2.4}
        Array.Sort(dblNumberArray)
        lblDisplay.Text = "The lowest rate is " & dblNumberArray(0) & "%"
    End Sub
End Class
