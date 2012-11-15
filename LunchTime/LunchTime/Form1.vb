Public Class Form1
    'Austin Keener
    '11/15/2012
    'Lunch Time

    'Defines and initalizes the variables required by the program
    Dim strChoice As String = ""
    Dim strDrink As String = ""
    Dim strDrinkSize As String = ""
    Dim dblSizePrice As Double = 0.0
    Dim dblChoicePrice As Double = 0.0

    'Executed when the user changes the selected Drink
    Private Sub cboDrinks_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDrinks.SelectedIndexChanged
        Try
            strDrink = cboDrinks.Text
        Catch ex As Exception
            strChoice = ""          'Set to empty for boolean check in the Calculate button method
        End Try
    End Sub

    'Executed when the user changes the selected Drink Size
    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged
        Select Case cboSize.Text                '
            Case "Small"
                strDrinkSize = "Small"
                dblSizePrice = 0.99
            Case "Medium"
                strDrinkSize = "Medium"
                dblSizePrice = 1.49
            Case "Large"
                strDrinkSize = "Large"
                dblSizePrice = 1.99
            Case Else                   'Catches any mistakes.
                strDrinkSize = ""       'Set to empty for boolean check in the calculate buttom method
                dblSizePrice = 0.0      'Set to 0.0 for boolean check in the calculate buttom method
        End Select
    End Sub

    'Executed when the Calculate button is clicked
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If Not dblChoicePrice.Equals(0.0) And Not String.IsNullOrEmpty(strChoice) Then  'Checks that the a Meal Choice has been selected
            If Not String.IsNullOrEmpty(strDrink) Then                                  'Checks that a Drink has been selected
                If Not dblSizePrice.Equals(0.0) And Not String.IsNullOrEmpty(strDrinkSize) Then 'Checks that a Drink Size has been selected
                    lblDisplay.Text = _
                        "You ordered: " & strChoice & vbCrLf & _
                        "Your drink is: " & strDrink & vbCrLf & _
                        "Drink Size: " & strDrinkSize & vbCrLf & _
                        "Total Cost: " & ((dblChoicePrice + dblSizePrice) * 1.07).ToString("$##0.00")

                Else
                    MessageBox.Show("Please choose a drink size")           'Informs the user of their mistake in ordering
                End If
            Else
                MessageBox.Show("Please choose a drink")                    'Informs the user of their mistake in ordering
            End If
        Else
            MessageBox.Show("Please choose a meal from the choices listed") 'Informs the user of their mistake in ordering
        End If
    End Sub

    'Executed when the Close option is selected in the main menu
    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()              'Closes the program
    End Sub

    'Executed when the program first starts.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboSize.Text = "Chose a drink size"         'Sets the text displayed in the Drink Size combo box on startup (just for show, not required)
        cboDrinks.Text = "Chose a drink"            'Sets the text displayed in the Drink combo box on startup (just for show, not required
    End Sub

    'Executes when the user changes the selected Choice of Meal
    Private Sub lstChoices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstChoices.SelectedIndexChanged
        Select Case lstChoices.SelectedIndex
            Case -1
                strChoice = ""          'Set to empty for boolean check in the Calculate button method
                dblChoicePrice = 0.0    'Set to 0.0 for boolean check in the Calculate button method
            Case 0
                strChoice = "Chef Salad"
                dblChoicePrice = 3.99
                MessageBox.Show("We only use the freshest ingredients in our salads!")
            Case 1
                strChoice = "Garden Salad"
                dblChoicePrice = 2.99
                MessageBox.Show("We only use the freshest ingredients in our salads!")
            Case 2
                strChoice = "Hamburger"
                dblChoicePrice = "2.99"
            Case 3
                strChoice = "Cheeseburger"
                dblChoicePrice = 3.49
            Case 4
                strChoice = "Chicken Sandwich"
                dblChoicePrice = 3.99
        End Select
    End Sub

End Class
