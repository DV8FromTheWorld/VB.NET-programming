Public Class Form1
    'Austin Keener
    '11/30/2012
    'Football Game

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim intQ1Score, intQ2Score, intQ3Score, intQ4Score As Integer               'Defines required variables
        lblDisplay.Text = ""                                                        'Label Reset
        If Int32.TryParse(txtQ1.Text, intQ1Score) Then                              'Checks that the user entered integers for the Quarters 
            If Int32.TryParse(txtQ2.Text, intQ2Score) Then
                If Int32.TryParse(txtQ3.Text, intQ3Score) Then
                    If Int32.TryParse(txtQ4.Text, intQ4Score) Then
                        calcTotal(intQ1Score, intQ2Score, intQ3Score, intQ4Score)
                    Else
                        MessageBox.Show("Please enter an interger for Quarter 4")   'User Debug
                    End If
                Else
                    MessageBox.Show("Please enter an integer for Quarter 3")        'User Debug
                End If
            Else
                MessageBox.Show("Please enter an integer for Quarter 2")            'User Debug
            End If
        Else
            MessageBox.Show("Please enter an integer for Quarter 1")                'User Debug
        End If
    End Sub

    Public Sub calcTotal(ByVal intQ1 As Integer, ByVal intQ2 As Integer, ByVal intQ3 As Integer, ByVal intQ4 As Integer)
        lblDisplay.Text = _
            "The total number of points is " & (intQ1 + intQ2 + intQ3 + intQ4)
    End Sub
End Class
