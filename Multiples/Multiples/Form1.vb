Public Class Form1
    'Austin Keener
    '11/28/2012
    'Multiples

    Private Sub btnMultiples_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiples.Click
        Dim intEntered As Integer = 0
        lblDisplay.Text = ""            'Clears the display label
        If Int32.TryParse(txtEntered.Text, intEntered) Then
            showMultiples(intEntered)
        Else
            MessageBox.Show("Please enter an interger.")
        End If
    End Sub

    Private Sub showMultiples(ByVal intNumber As Integer)
        For intcounter As Integer = 1 To 10
            lblDisplay.Text &= intNumber & " x " & intcounter & " = " & (intNumber * intcounter) & vbCrLf
        Next
    End Sub
End Class
