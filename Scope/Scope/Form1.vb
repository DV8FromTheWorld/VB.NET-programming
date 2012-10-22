Public Class Form1
    Dim x As Integer = 10

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblScopeAnswer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblScopeAnswer.Click

    End Sub

    Private Sub btnLocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocal.Click
        Dim x As Integer = 5
        lblScopeAnswer.Text = x
    End Sub

    Private Sub btnGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobal.Click
        lblScopeAnswer.Text = x
    End Sub
End Class
