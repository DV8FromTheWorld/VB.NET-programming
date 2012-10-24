Public Class Form1
    'Austin Keener
    'RockPaperScissors - Advanced version
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
        updatecomputerChoice()
    End Sub

    'Executed when the button is clicked.
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        '1 represents Rock, 2 represents Paper, 3 represents Scissors

        If radRock.Checked Then          'Checks if the user has the "Rock" choice selected
            Select Case intComputerChoice       'Selects the variable "intComputerChoice" to match cases against
                Case 1
                    intTies += 1
                    displayResult("Rock", "Rock", "tied.")      'For information on this method/code, please check the method at the bottom for an indepth explination.
                Case 2
                    intLosses += 1
                    displayResult("Rock", "Paper", "lost.")
                Case 3
                    intWins += 1
                    displayResult("Rock", "Scissors", "won!")
                Case Else
                    MessageBox.Show("Error, something went wrong with the computer generated choice")   'Not nessesarily needed, just here to catch errors
            End Select

        ElseIf radPaper.Checked Then         'Checks if the user has the "Paper" choice selected
            Select Case intComputerChoice       'Selects the variable "intComputerChoice" to match cases against
                Case 1
                    intWins += 1
                    displayResult("Paper", "Rock", "won!")
                Case 2
                    intTies += 1
                    displayResult("Paper", "Paper", "tied.")
                Case 3
                    intLosses += 1
                    displayResult("Paper", "Scissors", "lost.")
                Case Else
                    MessageBox.Show("Error, something went wrong with the computer generated choice")   'Not nessesarily needed, just here to catch errors
            End Select

        ElseIf radScissors.Checked Then     'Checks if the user has the "Rock" choice selected
            Select Case intComputerChoice       'Selects the variable "intComputerChoice" to match cases against
                Case 1
                    intLosses += 1
                    displayResult("Scissors", "Rock", "lost.")
                Case 2
                    intWins += 1
                    displayResult("Scissors", "Paper", "won!")
                Case 3
                    intTies += 1
                    displayResult("Scissors", "Scissors", "tied.")
                Case Else
                    MessageBox.Show("Error, something went wrong with the computer generated choice")   'Not nessesarily needed, just here to catch errors
            End Select
        Else
            MessageBox.Show("No choice selected, Please select one of the 3 choice to play")    'Shown when none of the Radio buttons have been selected.
        End If

        'These methods are called to change the computer's choice for the next round and to update the scoreboard.
        'For information on each specific method, check the comments and code relating to the methods.
        updateScoreBoard()
        updatecomputerChoice()

    End Sub

    'This method updates the computers choice.
    Public Sub updatecomputerChoice()

        'This code generates a random integer between 1 and 4, but 4 is not inclusive, meaning the only possibilities are 1, 2 and 3
        '1 represents Rock, 2 represents Paper, 3 represents Scissors
        intComputerChoice = Generate.Next(1, 4)
    End Sub

    'This method updates the label with the correct scores.
    Public Sub updateScoreBoard()
        lblCounterDisplay.Text = _
            "Wins: " & intWins & vbCrLf & _
            "Losses: " & intLosses & vbCrLf & _
            "Ties: " & intTies
    End Sub


    'This method displays the results of each round in a MessageBox
    'This method is useful so that you do not need to have the code for a message box in every case in the case selects above.  It is more efficent this way.
    'When you call this method, you need to provide 3 strings.
    'An example of how to use this method is as follows:   displayResult("cat", "jimmy", "house")
    'This would populate the variable "playerChoice" with the string: "cat"
    'This would populate the variable "computerChoice" with the string: "jimmy"
    'This would populate the variable"house" with the string: "house
    'So, when the "displayResult("cat", "jimmy", "house") is executed, it will populate those variables and run the code in the method, 
    'Cause the messagebox to display the following:   "Your choice: cat,  Computer choice: jimmy,  You house"
    Public Sub displayResult(ByVal playerChoice As String, ByVal computerChoice As String, ByVal result As String)

        MessageBox.Show("Your choice: " & playerChoice & ",  Computer choice: " & computerChoice & ",  You " & result)
    End Sub
End Class
