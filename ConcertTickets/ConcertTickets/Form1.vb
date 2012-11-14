Public Class Form1
    'Austin Keener
    '11/13/2012
    'ConcertTickets


    'Initializes the variables used.
    Dim blnEventSelected As Boolean = False
    Dim blnTicketSelected As Boolean = False
    Dim dblEventPrice As Double = 0.0
    Dim intTicketAmount As Integer = 0
    Dim strEvent As String = ""

    'Executed when an event is selected.
    Private Sub lstEvents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEvents.SelectedIndexChanged
        If lstEvents.SelectedItem = "" Then
            dblEventPrice = 0.0
            blnEventSelected = False
            strEvent = ""
        ElseIf lstEvents.SelectedItem = "Concert" Then
            dblEventPrice = 49.99
            blnEventSelected = True
            strEvent = "Concert"
        ElseIf lstEvents.SelectedItem = "Orchestra" Then
            dblEventPrice = 35.99
            blnEventSelected = True
            strEvent = "Orchestra"
        ElseIf lstEvents.SelectedItem = "Play" Then
            dblEventPrice = 24.99
            blnEventSelected = True
            strEvent = "Play"
        ElseIf lstEvents.SelectedItem = "Musical" Then
            dblEventPrice = 29.99
            blnEventSelected = True
            strEvent = "Musical"
        End If
    End Sub

    'Executed when the Ticket Amount combo-box is changed.
    Private Sub cboTicketAmount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTicketAmount.SelectedIndexChanged
        Try
            intTicketAmount = cboTicketAmount.Text
            blnTicketSelected = True
        Catch ex As Exception
            intTicketAmount = 0
            blnTicketSelected = False
        End Try
    End Sub

    'Executed when the Display option is clicked.
    Private Sub mnuDisplayCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDisplayCost.Click
        lblDisplay.Text = ""
        If blnEventSelected Then
            If blnTicketSelected Then
                lblDisplay.Text = "The total cost of your " & strEvent & " is " & (dblEventPrice * intTicketAmount).ToString("$##0.00")
            Else
                MessageBox.Show("Please selected a valid ticket amount. ")
            End If
        Else
            MessageBox.Show("No event selected, please select an event.")
        End If
    End Sub

    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub
End Class
