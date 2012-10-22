Public Class Form1

    Dim gradeQ1 As Integer
    Dim gradeQ2 As Integer
    Dim gradeFE As Integer
    Dim finalGrade As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtQ1Grade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQ1Grade.TextChanged
        gradeQ1 = txtQ1Grade.Text
        updateGrade()
    End Sub

    Private Sub txtQ2Grade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQ2Grade.TextChanged
        gradeQ2 = txtQ2Grade.Text
        updateGrade()
    End Sub

    Private Sub txtFEGrade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFEGrade.TextChanged
        gradeFE = txtFEGrade.Text
        updateGrade()
    End Sub

    Private Sub btnShowGrade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowGrade.Click
        lblGrades.Text = finalGrade.ToString
    End Sub

    Public Sub updateGrade()
        finalGrade = (0.4 * gradeQ1) + (0.4 * gradeQ2) + (0.2 * gradeFE)
    End Sub
End Class
