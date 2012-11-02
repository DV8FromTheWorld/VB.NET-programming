Public Class Form1
    'Austin Keener
    'Doughnut Order

    Dim intDoughnutAmount As Integer = 0
    Dim orderPrice As Double = 0.0
    Dim dblPricePerDoughnut As Double = 0.0
    Dim strDoughnutType As String = ""
    Dim strDoughnutPrice As String = ""

    Private Sub btnOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder.Click
        'This If statment calls the function "checkValidOrder". 
        'If the function returns true, it opens the MessageBox, and displays the given text.
        If checkValidOrder() Then
            MessageBox.Show("Thank you for your order." & vbCrLf & "Have a nice day!")
        End If

    End Sub

    'Method called when the radGlazed radio button is checked or u
    Private Sub radGlazed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGlazed.CheckedChanged
        updateOrderVariables("glazed", "$.50", 0.5)

    End Sub

    Private Sub radChocolate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radChocolate.CheckedChanged
        updateOrderVariables("chocolate", "$.65", 0.65)

    End Sub

    Private Sub radBlueberry_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radBlueberry.CheckedChanged
        updateOrderVariables("blueberry", "$.75", 0.75)

    End Sub

    Private Sub radLemon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLemon.CheckedChanged
        updateOrderVariables("lemon", "$.60", 0.6)

    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        Try
            intDoughnutAmount = txtAmount.Text
            updateOrderDisplay()
        Catch ex As Exception
            intDoughnutAmount = 0
            updateOrderDisplay()
        End Try
    End Sub

    Public Sub updateOrderVariables(ByVal doughnutType As String, ByVal doughnutPriceString As String, ByVal doughnutPricePerEach As Double)
        strDoughnutPrice = doughnutPriceString
        strDoughnutType = doughnutType
        dblPricePerDoughnut = doughnutPricePerEach
        updateOrderDisplay()
    End Sub

    Public Sub updateOrderDisplay()
        orderPrice = dblPricePerDoughnut * intDoughnutAmount * 1.075
        lblDisplayOrder.Text = _
            "You chose the " & strDoughnutType & " doughnut." & vbCrLf & _
            "They are " & strDoughnutPrice & " each." & vbCrLf & _
            "Including 7.5% tax, your total cost is " & orderPrice.ToString("$##.00")
    End Sub

    Public Function checkValidOrder() As Boolean
        If radBlueberry.Checked Or radChocolate.Checked Or radGlazed.Checked Or radLemon.Checked Then
            If intDoughnutAmount.Equals(0) Then
                MessageBox.Show("You did not specify how many doughnuts you would like to order.")
                Return False
            Else
                Return True
            End If
        Else
            MessageBox.Show("You did not specify the type of doughnut you would like to order.")
            Return False
        End If
    End Function
End Class
