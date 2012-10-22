Public Class baseGUI
    'Austin Keener 
    'September 19, 2012
    'Hello - Walkthrough Exercise

    Public helloMessage As String = "No Language selected.  Please select a language from the choices below."
    Public goodbyeMessage As String = "No Language selected.  Please select a language from the choices below."
    Public noGreeting As String = "No greeting type selected. Please select a greeting type from the choices below."
    Public hello As Boolean = False
    Public goodbye As Boolean = False
    Public english As Boolean = False
    Public french As Boolean = False
    Public german As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHello.Click
        displayMessage()
    End Sub

    Private Sub lblMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub radEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEnglish.CheckedChanged
        helloMessage = "Hello"
    End Sub

    Private Sub radFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFrench.CheckedChanged
        helloMessage = "Bonjour"
    End Sub

    Private Sub radGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGerman.CheckedChanged
        helloMessage = "Guten Tag"
    End Sub

    Private Sub chkEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEnglish.CheckedChanged
        If english Then
            english = False
            updateGoodbyeMessage()
        Else
            english = True
            updateGoodbyeMessage()
        End If
    End Sub

    Private Sub chkFrench_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFrench.CheckedChanged
        If french Then
            french = False
            updateGoodbyeMessage()
        Else
            french = True
            updateGoodbyeMessage()
        End If
    End Sub

    Private Sub chkGerman_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGerman.CheckedChanged
        If german Then
            german = False
            updateGoodbyeMessage()
        Else
            german = True
            updateGoodbyeMessage()
        End If
    End Sub
    Public Sub updateGoodbyeMessage()
        goodbyeMessage = ""

        If english Then
            goodbyeMessage = goodbyeMessage & vbCrLf &
                "GoodBye"
        End If
        If french Then
            goodbyeMessage = goodbyeMessage & vbCrLf & _
                "Au Revoir"
        End If
        If german Then
            goodbyeMessage = goodbyeMessage & vbCrLf & _
                "Auf wiedersehen"
        End If
        If Not english And Not french And Not german Then
            goodbyeMessage = "No language chosen for the currently selected greeting."
        End If
    End Sub

    Public Sub displayMessage()
        If hello Then
            lblMessage.Text = helloMessage
        Else
            If goodbye Then
                lblMessage.Text = goodbyeMessage
            Else
                lblMessage.Text = noGreeting
            End If
        End If
    End Sub

    Private Sub radHello_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHello.CheckedChanged
        If hello Then
            hello = False
        Else
            hello = True
        End If
    End Sub

    Private Sub radGoodbye_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGoodbye.CheckedChanged
        If goodbye Then
            goodbye = False
        Else
            goodbye = True
        End If
    End Sub
End Class
