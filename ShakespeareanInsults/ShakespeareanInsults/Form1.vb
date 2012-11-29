Public Class Form1
    'Austin Keener
    '11/29/2012
    'Shakespearean Insults

    'Defines and initializes required variables.
    Dim strInsultDisplay As String = ""
    Dim Gen As New Random()

    'Executed when the Insult Button is clicked
    Private Sub bntInsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntInsult.Click
        Dim intRandom As Integer
        intRandom = Gen.Next(1, 6)   'You use 1 to 6 because it doesnt include the 6, this will generate a number between 1 and 5
        showInsult(intRandom, strInsultDisplay)
        lblDisplay.Text = strInsultDisplay
    End Sub

    'Takes the integer generated from the previous method and set an insult based on its value.
    Private Sub showInsult(ByVal intRnd As Integer, ByRef strInsult As String)
        Select Case intRnd
            Case 1
                strInsult = "I think he be transformed into a beast; for I can nowhere find him like a man"     'As You Like It
            Case 2
                strInsult = "Lets meet as little as we can"                         'As You Like It
            Case 3
                strInsult = "I desire that we be better strangers"                  'As You Like It
            Case 4
                strInsult = "Boys, apes, braggarts, jackes, milksops!"              'Much Ado About Nothing
            Case 5
                strInsult = "This is the silliest stuff that I ever heard"          'A Midsummer Night's Dream
        End Select
    End Sub
End Class
