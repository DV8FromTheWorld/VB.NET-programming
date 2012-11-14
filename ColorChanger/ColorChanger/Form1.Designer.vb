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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMainMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Main"
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRed, Me.mnuBlue, Me.mnuGreen, Me.mnuClose})
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(46, 20)
        Me.mnuMainMenu.Text = "Main"
        '
        'mnuRed
        '
        Me.mnuRed.Name = "mnuRed"
        Me.mnuRed.Size = New System.Drawing.Size(152, 22)
        Me.mnuRed.Text = "Red"
        '
        'mnuBlue
        '
        Me.mnuBlue.Name = "mnuBlue"
        Me.mnuBlue.Size = New System.Drawing.Size(152, 22)
        Me.mnuBlue.Text = "Blue"
        '
        'mnuGreen
        '
        Me.mnuGreen.Name = "mnuGreen"
        Me.mnuGreen.Size = New System.Drawing.Size(152, 22)
        Me.mnuGreen.Text = "Green"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Color Changer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMainMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem

End Class
