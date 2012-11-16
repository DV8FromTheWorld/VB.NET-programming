Public Class Form1
    'Austin Keener
    '11/13/2012
    'Birthday Presents

    'Executed when the button is clicked
    Private Sub bntPresents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntPresents.Click
        Dim strFavoriteRestaurant As String = ""
        lstPresents.Items.Clear()                'Clears the previous items from the list box.
        For intLoopCounter As Integer = 1 To 5      'Loops 5 times
            lstPresents.Items.Add(InputBox("Enter a present"))
        Next
        If MessageBox.Show("Do you have a favorite restaurant you like to go to on your birthday?", "Favorite Restaurant", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            strFavoriteRestaurant = InputBox("What is your favorite restaurant?")
            If Not String.IsNullOrEmpty(strFavoriteRestaurant) Then
                MessageBox.Show("For your birthday, you would like to go to " & strFavoriteRestaurant)
            End If
        End If
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class
