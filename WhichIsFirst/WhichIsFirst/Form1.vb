Public Class Form1
    'Austin Keener
    '1/2/2013
    'Which Is First

    Private Sub btnWhichWordFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWhichWordFirst.Click
        lblDisplay.ResetText()
        Select Case String.Compare(txtWord1.Text, txtWord2.Text)
            Case 1
                lblDisplay.Text = txtWord2.Text & " comes before " & txtWord1.Text
            Case -1
                lblDisplay.Text = txtWord1.Text & " comes before " & txtWord2.Text
            Case Else
                MessageBox.Show("Error, please try again")
        End Select
    End Sub
End Class
