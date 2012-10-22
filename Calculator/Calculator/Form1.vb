Public Class Form1
    ''' Austin Keener
    ''' Case Study - Calculator

    Dim dblFirstOperand As Double = 0.0
    Dim dblSecondOperand As Double = 0.0
    Dim dblAnswer As Double = 0.0
    Dim mathOperator As String = ""


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFirstOperand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstOperand.TextChanged
        Try
            dblFirstOperand = txtFirstOperand.Text
        Catch ex As Exception
            dblFirstOperand = 0.0
        End Try
        updateCalculatorDisplay()
    End Sub

    Private Sub txtSecondOperand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSecondOperand.TextChanged
        Try
            dblSecondOperand = txtSecondOperand.Text
        Catch ex As Exception
            dblSecondOperand = 0.0
        End Try
        updateCalculatorDisplay()
    End Sub

    Private Sub radAddition_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radAddition.CheckedChanged
        mathOperator = "add"
        updateCalculatorDisplay()
    End Sub

    Private Sub radSubtraction_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radSubtraction.CheckedChanged
        mathOperator = "subtract"
        updateCalculatorDisplay()
    End Sub

    Private Sub radDivision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDivision.CheckedChanged
        mathOperator = "divide"
        updateCalculatorDisplay()
    End Sub

    Private Sub radMultiplication_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMultiplication.CheckedChanged
        mathOperator = "multiply"
        updateCalculatorDisplay()
    End Sub

    Private Sub radDivisionInteger_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDivisionInteger.CheckedChanged
        mathOperator = "integer-divide"
        updateCalculatorDisplay()
    End Sub

    Private Sub radModulus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radModulus.CheckedChanged
        mathOperator = "modulus"
        updateCalculatorDisplay()
    End Sub

    Private Sub radExponent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radExponent.CheckedChanged
        mathOperator = "exponent"
        updateCalculatorDisplay()
    End Sub

    Public Sub updateCalculatorDisplay()
        Select Case mathOperator
            Case "add"
                dblAnswer = dblFirstOperand + dblSecondOperand
            Case "subtract"
                dblAnswer = dblFirstOperand - dblSecondOperand
            Case "divide"
                Try
                    dblAnswer = dblFirstOperand / dblSecondOperand
                Catch ex As Exception
                    MessageBox.Show("Cannot divide by zero")
                End Try
            Case "multiply"
                dblAnswer = dblFirstOperand * dblSecondOperand
            Case "integer-divide"
                Try
                    dblAnswer = dblFirstOperand \ dblSecondOperand
                Catch ex As Exception

                End Try
            Case "modulus"
                Try
                    dblAnswer = dblFirstOperand Mod dblSecondOperand
                Catch ex As Exception
                    MessageBox.Show("Cannot divide by zero")
                End Try
            Case "exponent"
                dblAnswer = dblFirstOperand ^ dblSecondOperand
        End Select
        lblAnswerDisplay.Text = dblAnswer
    End Sub
End Class
