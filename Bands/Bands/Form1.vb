Public Class Form1
    'Austin Keener
    '11/13/2012
    'Bands

    Private Sub mnuDragonForce_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDragonForce.Click
        lblDisplay.Text = _
            "ZP Theart - Lead Singer" & vbCrLf & _
            "Herman Li - Lead Guitar" & vbCrLf & _
            "Sam Totman - Lead Guitar" & vbCrLf & _
            "Frédéric Leclercq - Bass Guitar" & vbCrLf & _
            "Dave Mackintosh - Drums" & vbCrLf & _
            "Vadim Pruzhanov - Keyboard"
        If MessageBox.Show("Do you like DragonForce?", "DragonForce Survey", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("DragonForce is Awesome!")
        Else
            MessageBox.Show("Maybe you've never heard of DragonForce?")
        End If

    End Sub
    Private Sub mnuNightwish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNightwish.Click
        lblDisplay.Text = _
            "Anette Olzon  - Lead Singer" & vbCrLf & _
            "Emppu Vuorinen - Lead Guitar" & vbCrLf & _
            "Marco Hietala - Bass Guitar" & vbCrLf & _
            "Jukka Nevalainen - Drums" & vbCrLf & _
            "Tuomas Holopainen - Keyboard"
        If MessageBox.Show("Do you like Nightwish?", "Nightwish Survey", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("Nightwish is Awesome!")
        Else
            MessageBox.Show("Maybe you've never heard of Nightwish?")
        End If

    End Sub

    Private Sub mnuProtomen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProtomen.Click
        lblDisplay.Text = _
            "Raul Panther III - Vocals/Multi-Instrument" & vbCrLf & _
            "Commander B. Hawkins Jr. - Synth" & vbCrLf & _
            "Murphy Weller - Bass/Synth" & vbCrLf & _
            "TURBO LOVER - Vocals/Multi-Instrument" & vbCrLf & _
            "Sir Robert Bakker - Guitar/Violin" & vbCrLf & _
            "Ringo Segundo - Guitar" & vbCrLf & _
            "The Gambler - Vocals/Synth" & vbCrLf & _
            "Reanimator - Drums" & vbCrLf & _
            "K.I.L.R.O.Y. - Armorer and Sledgehammer"
        If MessageBox.Show("Do you like The Protomen?", "Protomen Survey", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            MessageBox.Show("The Protomen are Awesome!")
        Else
            MessageBox.Show("Maybe you've never heard of The Protomen?")
        End If
    End Sub
    Private Sub mnuClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClose.Click
        Application.Exit()
    End Sub

    'Executes when the About menu is selected
    Private Sub mnuAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        AboutForm.Show()        'Opens the About Form
        Me.Hide()               'Hides the Main form for later use.
    End Sub
End Class
