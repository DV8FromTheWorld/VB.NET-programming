Public Class Form1

    'Austin Keener
    '9/21/2012
    '

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblGameInfo.Text = "Press a button relating to a game to see information about it"
    End Sub

    Private Sub btnGame1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame1.Click
        'Halo 
        lblGameInfo.Text = "Halo is a game series placed in a universe set in the year 2556." & vbCrLf & _
                           "Humans have spread throughout the galaxy, aquiring many planets and setting up colonies." & vbCrLf & _
                           "Through out this spread, they have made enemies with an alliance of aliens called 'The Covenant'."

    End Sub

    Private Sub btnGame2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame2.Click
        'Battlefield 3 
        lblGameInfo.Text = "Battlefield 3 is the long awaited sequel to Battlefield 2." & vbCrLf & _
                           "It is a game based mostly around multiplay play, encouraging teamwork and strategy."

    End Sub

    Private Sub btnGame3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame3.Click
        'Call of Duty 
        lblGameInfo.Text = "Call of Duty is a game series that has many game releases." & vbCrLf & _
                           "A few examples are:  Modern Warfare 2, Black Ops and World at War" & vbCrLf & _
                           "These games are based mostly around multiplay play, encouraging 'run and gun' play style"

    End Sub

    Private Sub btnGame4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGame4.Click
        'Team Fortress 2 
        lblGameInfo.Text = "Team Fortress 2 (TF2) is the sequel to the original Team Fortress." & vbCrLf & _
                           "TF2 is based on the 'Source' game engine developed by valve." & vbCrLf & _
                           "It has no campaign and is soly based on multiplayer, but this does not detract from the quality of the game" & vbCrLf & _
                           "While TF2 is a First Person Shooter, it is unique because it requires team responsibility."

    End Sub

    Private Sub lblGameInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGameInfo.Click

    End Sub
End Class
