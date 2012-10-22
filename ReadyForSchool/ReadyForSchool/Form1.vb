Public Class Form1

    Dim readyMessage As String = ""
    Dim bob As String = ""
    Dim cat As String = ""
    Dim joe As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateReadyMessage()
    End Sub

    Private Sub grpMorningTasks_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpMorningTasks.Enter

    End Sub

    Private Sub chkHomework_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHomework.CheckedChanged
        updateReadyMessage()
    End Sub

    Private Sub chkBreakfast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBreakfast.CheckedChanged
        updateReadyMessage()
    End Sub

    Private Sub chkBrushTeeth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBrushTeeth.CheckedChanged
        updateReadyMessage()
    End Sub

    Private Sub lblReadyMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReadyMessage.Click

    End Sub

    Private Sub btnReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReady.Click
        lblReadyMessage.Text = readyMessage
    End Sub

    Public Sub updateReadyMessage()

        readyMessage = "Homework done? "
        If chkHomework.Checked Then
            readyMessage = readyMessage + vbCrLf & "      Yep! Good job!"
        Else
            readyMessage = readyMessage + vbCrLf & "      Nope, teacher is going to be mad.."
        End If

        readyMessage = readyMessage + vbCrLf & "Did you eat breakfast?"
        If chkBreakfast.Checked Then
            readyMessage = readyMessage + vbCrLf & "      Yep! Now you won't be hungry before lunch."
        Else
            readyMessage = readyMessage + vbCrLf & "      Nope, you're probably gonna get hungry..."
        End If

        readyMessage = readyMessage + vbCrLf & "Did you brush your teeth?"
        If chkBrushTeeth.Checked Then
            readyMessage = readyMessage + vbCrLf & "      Yep! Thats good, now you will have fresh breath."
        Else
            readyMessage = readyMessage + vbCrLf & "      Nope, go brush them now!"
        End If
    End Sub
End Class
