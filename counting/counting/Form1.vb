Public Class Form1

    Dim bob As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDimVariable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDimVariable.Click
        Dim bob As Integer = 0
        bob = bob + 1
        lblVariableDisplay.Text = bob.ToString
    End Sub

    Private Sub btnStaticVariable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStaticVariable.Click
        bob = bob + 1
        lblVariableDisplay.Text = bob.ToString
    End Sub

    Private Sub lblVariableDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblVariableDisplay.Click

    End Sub
End Class
