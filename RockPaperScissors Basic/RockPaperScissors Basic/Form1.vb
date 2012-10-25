Public Class Form1
    'Austin Keener
    'RockPaperScissors - Basic version
    '10/24/2012

    'Defining global variables and initializing them for use.
    Dim intComputerChoice As Integer = 0
    Dim intWins As Integer = 0
    Dim intLosses As Integer = 0
    Dim intTies As Integer = 0

    'Needed for the use of Generate.Next(1, 4) to generate a random number for the computer's choice.
    Dim Generate As New Random()

    'Executed when the program FIRST starts.  This is needed so that the computer's choice is selected from the very beginning.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        intComputerChoice = Generate.Next(1, 4)
    End Sub

    'Executed when the button is clicked.
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        '1 represents Rock, 2 represents Paper, 3 represents Scissors

        If radRock.Checked Then          'Checks if the user has the "Rock" choice selected
            Select Case intComputerChoice       'Selects the variable "intComputerChoice" to match cases against
                Case 1
                    intTies += 1
                    MessageBox.Show("Your choice: Paper,  Computer choice: Rock,  You tied.")      'For information on this method/code, please check the method at the bottom for an indepth explination.
                Case 2
                    intLosses += 1
                    MessageBox.Show("Your choice: Paper,  Computer choice: Paper,  You lost.")
                Case 3
                    intWins += 1
                    MessageBox.Show("Your choice: Paper,  Computer choice: Scissors,  You win!")
                Case Else
                    MessageBox.Show("Error, something went wrong with the computer generated choice")   'Not nessesarily needed, just here to catch errors
            End Select

        ElseIf radPaper.Checked Then         'Checks if the user has the "Paper" choice selected
            Select Case intComputerChoice       'Selects the variable "intComputerChoice" to match cases against
                Case 1
                    intWins += 1
                    MessageBox.Show("Your choice: Paper,  Computer choice: Rock,  You win!")
                Case 2
                    intTies += 1
                    MessageBox.Show("Your choice: Paper,  Computer choice: Paper,  You tied.")
                Case 3
                    intLosses += 1
                    MessageBox.Show("Your choice: Paper,  Computer choice: Scissors,  You lost.")
                Case Else
                    MessageBox.Show("Error, something went wrong with the computer generated choice")   'Not nessesarily needed, just here to catch errors
            End Select

        ElseIf radScissors.Checked Then     'Checks if the user has the "Rock" choice selected
            Select Case intComputerChoice       'Selects the variable "intComputerChoice" to match cases against
                Case 1
                    intLosses += 1
                    MessageBox.Show("Your choice: Scissors,  Computer choice: Rock,  You lost.")
                Case 2
                    intWins += 1
                    MessageBox.Show("Your choice: Scissors,  Computer choice: Paper,  You win!")
                Case 3
                    intTies += 1
                    MessageBox.Show("Your choice: Scissors,  Computer choice: Scissors,  You tied.")
                Case Else
                    MessageBox.Show("Error, something went wrong with the computer generated choice")   'Not nessesarily needed, just here to catch errors
            End Select
        Else
            MessageBox.Show("No choice selected, Please select one of the 3 choice to play")    'Shown when none of the Radio buttons have been selected.
        End If

        'This code updates the label with the correct scores.
        lblCounterDisplay.Text = _
            "Wins: " & intWins & vbCrLf & _
            "Losses: " & intLosses & vbCrLf & _
            "Ties: " & intTies

        'This code updates the computers choice.
        'This code generates a random integer between 1 and 4, but 4 is not inclusive, meaning the only possibilities are 1, 2 and 3
        '1 represents Rock, 2 represents Paper, 3 represents Scissors
        intComputerChoice = Generate.Next(1, 4)
    End Sub
End Class
