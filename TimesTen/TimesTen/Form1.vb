Public Class Form1
    'Austin Keener
    '11/29/2012
    'Times Ten

    'Defines and Initializes required variables.
    Dim intAnswer As Integer

    'Executed when the Show Button is clicked
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim intEntered As Integer
        lblDisplay.Text = ""
        If Not String.IsNullOrEmpty(txtNumberEntered.Text) And Int32.TryParse(txtNumberEntered.Text, intEntered) Then
            MultiplyByTen(intEntered, intAnswer)
            lblDisplay.Text = intAnswer
        Else
            MessageBox.Show("Please enter an integer")      'User debug
        End If
    End Sub

    Private Sub MultiplyByTen(ByVal intNumberEntered As Integer, ByRef intAns As Integer)
        intAns = (intNumberEntered * 10)
    End Sub
End Class
