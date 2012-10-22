Public Class Form1

    Dim pepperoni As Boolean = False
    Dim cheese As Boolean = False
    Dim mushrooms As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub grpChoices_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpChoices.Enter

    End Sub

    Private Sub chkPepperoni_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPepperoni.CheckedChanged
        If pepperoni Then
            lblChoice1.Text = ""
            pepperoni = False
        Else
            lblChoice1.Text = "You chose to add pepperoni"
            pepperoni = True
        End If
    End Sub

    Private Sub chkCheese_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCheese.CheckedChanged
        If cheese Then
            lblChoice2.Text = ""
            cheese = False
        Else
            lblChoice2.Text = "You chose to add cheese."
            cheese = True
        End If
    End Sub

    Private Sub chkMushrooms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMushrooms.CheckedChanged
        If mushrooms Then
            lblChoice3.Text = ""
            mushrooms = False
        Else
            lblChoice3.Text = "You chose to add mushrooms."
            mushrooms = True
        End If
    End Sub
End Class
