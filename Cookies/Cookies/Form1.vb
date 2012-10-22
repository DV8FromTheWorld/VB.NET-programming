Public Class Form1

    'Austin Keener
    	
    Dim cookieChoice As String = "You chose our chocolate chip cookies."
    Dim orderAmount As Double
    Dim chocolateChip As Boolean = False
    Dim oatmeal As Boolean = False
    Dim bob As Integer
    Dim peanutButter As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblChoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblChoice.Click

    End Sub

    Private Sub grpChoices_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpChoices.Enter

    End Sub

    Private Sub radChocChip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radChocChip.CheckedChanged
        If chocolateChip Then
            chocolateChip = False
            updateOrder()
        Else
            chocolateChip = True
            lblChoice.Text = "You chose our chocolate chip cookies."
            updateOrder()
        End If
    End Sub

    Private Sub radOatmeal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOatmeal.CheckedChanged
        If oatmeal Then
            oatmeal = False
            updateOrder()
        Else
            oatmeal = True
            lblChoice.Text = "You chose our oatmeal raisin chip cookies."
            updateOrder()
        End If
    End Sub

    Private Sub radPeanutButter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPeanutButter.CheckedChanged
        If peanutButter Then
            peanutButter = False
            updateOrder()
        Else
            peanutButter = True
            lblChoice.Text = "You chose our peanut butter cookies."
            updateOrder()
        End If
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        lblChoice.Text = cookieChoice

    End Sub

    Private Sub updateOrder()
        If chocolateChip Then
            cookieChoice = "You ordered " & orderAmount & " chocolate chip cookies."
        End If

        If oatmeal Then
            cookieChoice = "You ordered " & orderAmount & " oatmeal raisin chip cookies."
        End If

        If peanutButter Then
            cookieChoice = "You ordered " & orderAmount & " peanut butter cookies."
        End If
    End Sub

    Private Sub lblCookieAmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCookieAmount.Click

    End Sub

    Private Sub nudOrderAmount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudOrderAmount.ValueChanged
        orderAmount = nudOrderAmount.Value
        updateOrder()
    End Sub
End Class
