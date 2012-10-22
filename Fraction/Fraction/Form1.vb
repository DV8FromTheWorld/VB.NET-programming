Public Class Form1
    'Austin Keener
    '5.01 & 5.02 Exercise 5 - Fraction
    '10-9-2012

    Dim intNumerator As Integer = 0
    Dim intDenominator As Integer = 0
    Dim dblAnswer As Double = 0.0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtNumerator_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumerator.TextChanged
        Try
            intNumerator = txtNumerator.Text
        Catch ex As Exception
            intNumerator = 0
        End Try
    End Sub

    Private Sub txtDenominator_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDenominator.TextChanged
        Try
            intDenominator = txtDenominator.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblAnswerDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnswerDisplay.Click

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        dblAnswer = intNumerator / intDenominator
        lblAnswerDisplay.Text = dblAnswer.ToString("###.###")
    End Sub
End Class
