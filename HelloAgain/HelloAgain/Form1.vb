Public Class Form1
    'Austin Keener
    '4.0 Exercise 1
    ' 9/26/2012

    Dim nameEntered As String = ""
    Dim greetingMessage As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblPromt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPromt.Click

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        nameEntered = txtName.Text
        greetingMessage = "Hello, " & nameEntered
    End Sub

    Private Sub btnHello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click
        displayGreeting()
    End Sub

    Public Sub displayGreeting()
        If nameEntered = String.Empty Then
            MsgBox("No name entered, please enter a name in the input box.")
        Else
            MsgBox(greetingMessage)
        End If
    End Sub
End Class
