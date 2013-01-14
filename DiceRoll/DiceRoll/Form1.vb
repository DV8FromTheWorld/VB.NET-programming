Public Class Form1
    'Austin Keener
    '1/10/2013
    'Dice Roll

    Dim Gen As New Random()

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        tmrInterval.Start()
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        tmrInterval.Stop()
    End Sub

    Private Sub tmrInterval_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrInterval.Tick
        imageChange(Gen.Next(1, 7), pic1)
        imageChange(Gen.Next(1, 7), pic2)
        imageChange(Gen.Next(1, 7), pic3)
    End Sub

    Private Sub imageChange(ByVal dblRand As Double, ByRef picBox As PictureBox)
        Select Case dblRand
            Case 1
                picBox.Image = My.Resources.die_face_1
            Case 2
                picBox.Image = My.Resources.die_face_2
            Case 3
                picBox.Image = My.Resources.die_face_3
            Case 4
                picBox.Image = My.Resources.die_face_4
            Case 5
                picBox.Image = My.Resources.die_face_5
            Case 6
                picBox.Image = My.Resources.die_face_6
        End Select
    End Sub
End Class
