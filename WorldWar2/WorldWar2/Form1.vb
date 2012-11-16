Public Class Form1
    'Austin Keener
    '11/16/2012
    'World War 2

    'Executes when the Add Fact menu is selected
    Private Sub mnuAddFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAddFact.Click
        Dim strFact As String = ""
        Dim intFactAmount As Integer = 0
        If MessageBox.Show("Would you like to enter a fact?", "World War 2 Facts", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try                 'Try catch used to prevent errors if something besides and integer is input
                intFactAmount = InputBox("How many facts would you like to enter?")
            Catch ex As Exception
                MessageBox.Show("Please enter a integer larger than 0 to proceed")
                intFactAmount = 0
            End Try
            For intCounter As Integer = 1 To intFactAmount
                strFact = InputBox("Input fact about World War 2", "World War 2 Facts")     'Gets the item that needs to be added to the list box
                lstFacts.Items.Add(strFact)     'Adds the item that was given by the user in the inputbox
            Next
        End If
    End Sub

    'Executes when the Remove Fact menu is selected
    Private Sub mnuRemoveFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRemoveFact.Click
        If Not lstFacts.SelectedIndex.Equals(-1) Then
            If MessageBox.Show("Are you sure you wish to remove the selected fact?", "Remove Fact", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                lstFacts.Items.Remove(lstFacts.SelectedItem.ToString)       'Removes the item that is currently selected from list box
            End If
        Else
            MessageBox.Show("No fact selected to remove, please selected a fact if you wish to remove it.")
        End If
        
    End Sub

    'Executed when the Clear menu is selected
    Private Sub mnuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClear.Click
        If MessageBox.Show("Are you sure you wish to clear all facts?", "Clear all facts", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            lstFacts.Items.Clear()      'Clears all items from the list box
        End If
    End Sub

    'Executed when the Close menu is selected
    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()      'closes the program
    End Sub
End Class
