Public Class Form1

    Const pi As Double = 3.1457
    Dim radius As Double
    Dim radiusEntered As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtRadiusInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRadiusInput.TextChanged
        Try
            radius = Convert.ToDouble(txtRadiusInput.Text)
            radiusEntered = True
        Catch
            lblAreaDisplay.Text = "Please enter a valid value for the radius"
        End Try
    End Sub

    Private Sub btnCalculateArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateArea.Click
        If radiusEntered Then
            lblAreaDisplay.Text = "Radius equals: " & (pi * radius * radius).ToString
        Else
            lblAreaDisplay.Text = "Please enter a value for the radius"
        End If

    End Sub
End Class
