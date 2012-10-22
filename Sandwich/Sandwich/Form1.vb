Public Class Form1

    Dim meat As String = ""
    Dim condiments As String = ""
    Dim sandwichOrder As String = ""
    Dim cheeseType As String = "No cheese selected, please choose from above"
    Dim ham As Boolean = False
    Dim turkey As Boolean = False
    Dim cheese As Boolean = False
    Dim mustard As Boolean = False
    Dim mayo As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grpMainChoice_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpMainChoice.Enter

    End Sub

    Private Sub radHam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radHam.CheckedChanged
        If ham Then
            ham = False
            updateMeat()
        Else
            ham = True
            updateMeat()
        End If

    End Sub

    Private Sub radTurkey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radTurkey.CheckedChanged
        If turkey Then
            turkey = False
            updateMeat()
        Else
            turkey = True
            updateMeat()
        End If
    End Sub

    Private Sub grpCondiments_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpCondiments.Enter

    End Sub

    Private Sub chkMayonaise_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMayonaise.CheckedChanged
        If mayo Then
            mayo = False
            updateCondiments()
        Else
            mayo = True
            updateCondiments()
        End If
    End Sub

    Private Sub chkMustard_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMustard.CheckedChanged
        If mustard Then
            mustard = False
            updateCondiments()
        Else
            mustard = True
            updateCondiments()
        End If
    End Sub

    Private Sub chkCheese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheese.CheckedChanged
        If cheese Then
            cheese = False
            cbCheeseSelector.Enabled = False
            updateCondiments()

        Else
            cheese = True
            cbCheeseSelector.Enabled = True
            updateCondiments()
        End If

    End Sub
    Public Sub updateMeat()
        meat = "Your sandwich meat:"
        If ham Then
            meat = meat & vbCrLf & "    - Ham"
            updateCondiments()
        End If
        If turkey Then
            meat = meat & vbCrLf & "    - Turkey"
            updateCondiments()
        End If
    End Sub
    Public Sub updateCondiments()
        sandwichOrder = "        Your order" & vbCrLf & meat & vbCrLf & "Sandwich condiments:"
        If cheese Then
            sandwichOrder = sandwichOrder & vbCrLf & "    - Cheese: " & cheeseType

        End If

        If mustard Then
            sandwichOrder = sandwichOrder & vbCrLf & "    - Mustard"
        End If

        If mayo Then
            sandwichOrder = sandwichOrder & vbCrLf & "    - Mayonaise"
        End If

        If Not cheese And Not mustard And Not mayo Then
            sandwichOrder = sandwichOrder & vbCrLf & "    - None"
        End If
    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        lblSandwichChoices.Text = sandwichOrder
    End Sub

    Private Sub cbCheeseSelector_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCheeseSelector.SelectedIndexChanged
        cheeseType = cbCheeseSelector.Text
        updateCondiments()
    End Sub
End Class
