<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSquare = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSign = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRound = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 35)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(81, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter a Number"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(214, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MainToolStripMenuItem
        '
        Me.MainToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MathToolStripMenuItem, Me.mnuClose})
        Me.MainToolStripMenuItem.Name = "MainToolStripMenuItem"
        Me.MainToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.MainToolStripMenuItem.Text = "Main"
        '
        'MathToolStripMenuItem
        '
        Me.MathToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbs, Me.mnuSquare, Me.mnuSign, Me.mnuRound})
        Me.MathToolStripMenuItem.Name = "MathToolStripMenuItem"
        Me.MathToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MathToolStripMenuItem.Text = "Math"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'mnuAbs
        '
        Me.mnuAbs.Name = "mnuAbs"
        Me.mnuAbs.Size = New System.Drawing.Size(153, 22)
        Me.mnuAbs.Text = "Absolute Value"
        '
        'mnuSquare
        '
        Me.mnuSquare.Name = "mnuSquare"
        Me.mnuSquare.Size = New System.Drawing.Size(153, 22)
        Me.mnuSquare.Text = "Square Root"
        '
        'mnuSign
        '
        Me.mnuSign.Name = "mnuSign"
        Me.mnuSign.Size = New System.Drawing.Size(153, 22)
        Me.mnuSign.Text = "Sign"
        '
        'mnuRound
        '
        Me.mnuRound.Name = "mnuRound"
        Me.mnuRound.Size = New System.Drawing.Size(153, 22)
        Me.mnuRound.Text = "Round"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(111, 32)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(84, 20)
        Me.txtNum.TabIndex = 2
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(12, 79)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(175, 133)
        Me.lblDisplay.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Math Fun"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MainToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSquare As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSign As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRound As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
