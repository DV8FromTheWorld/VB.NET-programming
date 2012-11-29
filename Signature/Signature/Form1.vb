Public Class Form1
    'Austin Keener
    '11/29/2012
    'Signature

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        lblDisplay.Text = ""                                    'Resets the label
        If Not String.IsNullOrEmpty(txtSignature.Text) Then     'Makes sure that the user entered their name
            lblDisplay.Text = Signature(txtSignature.Text)      'Calls the Signature method which returns a string to be set in lblDisplay
        Else
            MessageBox.Show("Please enter your name")           'User Debug
        End If
    End Sub

    Function Signature(ByVal strName As String) As String
        Dim strSignatureReturn As String                        'Defines a string to be use in the return statement
        strSignatureReturn = "Created by " & strName            'Assigns a string value to the return string
        Return strSignatureReturn                               'Returns the string.
    End Function
End Class
