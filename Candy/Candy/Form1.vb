Public Class Form1
    'Austin Keener
    '11/29/2012
    'Candy

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim dblAmountOunces As Double
        Dim dblCostPerOunce As Double
        If Not String.IsNullOrEmpty(txtCandy.Text) Then     'checks that the user entered a candy (string)
            If Not String.IsNullOrEmpty(txtOunces.Text) And Double.TryParse(txtOunces.Text, dblAmountOunces) Then   'Checks that the user entered an amount (integer or double)
                If Not String.IsNullOrEmpty(txtPrice.Text) And Double.TryParse(txtPrice.Text, dblCostPerOunce) Then 'Checks that the user entered a price per ounce (integer or double)
                    Calculate(txtCandy.Text, dblAmountOunces, dblCostPerOunce)      'Calls the Calculate method to print out the price
                Else
                    MessageBox.Show("Please enter a price per ounce")       'User Debug 
                End If
            Else
                MessageBox.Show("Please enter an amount of ounces")         'User Debug
            End If
        Else
            MessageBox.Show("Please enter a type of candy")                 'User Debug
        End If
    End Sub

    Public Sub Calculate(ByVal strCandyType As String, ByVal dblOunces As Double, ByVal dblPerOunce As Double)
        lblDisplay.Text = _
            dblOunces & " ounces of " & strCandyType & " at a cost of " & dblPerOunce.ToString("$##0.00") & " per oz. costs " & (dblOunces * dblPerOunce).ToString("$##0.00")
    End Sub
End Class
