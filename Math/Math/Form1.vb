Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnFirstProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstProblem.Click
        lblFirstProblem.Text = 6 + 3 / 2
    End Sub

    Private Sub btnSecondProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecondProblem.Click
        lblSecondProblem.Text = (6 + 3) / 2
    End Sub

    Private Sub btnThirdProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThirdProblem.Click
        lblThirdProblem.Text = 9 * 2 / 5
    End Sub

    Private Sub btnFourthProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFourthProblem.Click
        lblFourthProblem.Text = 9.0 * 2 / 5
    End Sub

    Private Sub btnFifthProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFifthProblem.Click
        lblFifthProblem.Text = 7 / 2
    End Sub

    Private Sub btnSixthProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSixthProblem.Click
        lblSixthProblem.Text = 7 \ 2
    End Sub

    Private Sub btnSeventhProblem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeventhProblem.Click
        lblSeventhProblem.Text = 7 Mod 3
    End Sub
End Class
