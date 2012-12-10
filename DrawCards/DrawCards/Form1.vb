Public Class Form1
    'Austin Keener
    '12/10/2012
    'Draw Cards

    Dim Gen As New Random()

    Private Sub btnDrawCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrawCards.Click
        lblDisplay.Text = ""
        Dim intCardDrawCounter(8) As Integer
        Dim intDrawTimes As Integer
        If Integer.TryParse(txtDraws.Text, intDrawTimes) Then
            drawCards(intCardDrawCounter, intDrawTimes)
            showCards(intCardDrawCounter)
        Else
            MessageBox.Show("Please enter a valid integer")
        End If
    End Sub

    Private Sub drawCards(ByRef intCardCounter() As Integer, ByVal intTimes As Integer)
        For intCounter = 1 To intTimes
            intCardCounter(Gen.Next(0, 9)) += 1
        Next
    End Sub

    Private Sub showCards(ByVal intCardCounter() As Integer)
        For intCounter = 0 To 8
            lblDisplay.Text &= _
            "Card #" & (intCounter + 2) & " was drawn " & intCardCounter(intCounter) & " times." & vbCrLf
        Next
    End Sub
End Class
