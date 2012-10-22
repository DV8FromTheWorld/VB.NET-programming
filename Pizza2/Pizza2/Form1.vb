Public Class Form1

    Dim crustSelected As Boolean = False
    Dim firstToppingSelected As Boolean = False
    Dim secondToppingSelected As Boolean = False
    Dim crust As String = ""
    Dim firstTopping As String = ""
    Dim secondTopping As String = ""
    Dim order As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateOrder()
    End Sub

    Private Sub cbCrust_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCrust.SelectedIndexChanged
        crust = cbCrust.Text
        crustSelected = True
        updateOrder()
    End Sub

    Private Sub cbTopping1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTopping1.SelectedIndexChanged
        firstTopping = cbTopping1.Text
        firstToppingSelected = True
        updateOrder()
    End Sub

    Private Sub cbTopping2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTopping2.SelectedIndexChanged
        secondTopping = cbTopping2.Text
        secondToppingSelected = True
        updateOrder()
    End Sub

    Private Sub lblOrderDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOrderDisplay.Click

    End Sub

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        lblOrderDisplay.Text = order
    End Sub

    Private Sub updateOrder()
        If crustSelected Then
            If firstToppingSelected Then

                If secondToppingSelected Then
                    order = _
                        "     Your Pizza Order" & vbCrLf & _
                        "Crust:" & vbCrLf & _
                        "    - " & crust & vbCrLf & _
                        "Toppings:" & vbCrLf & _
                        "    - " & firstTopping & vbCrLf & _
                        "    - " & secondTopping

                Else
                    order = "Please select your second topping"
                End If

            Else
                order = "Please select your first topping"
            End If

        Else
            order = "Please select a crust type"
        End If
    End Sub
End Class
