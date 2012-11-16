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
        Me.mnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDragonForce = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNightwish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProtomen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMain})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMain
        '
        Me.mnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDragonForce, Me.mnuNightwish, Me.mnuProtomen, Me.mnuAbout, Me.mnuClose})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(46, 20)
        Me.mnuMain.Text = "Main"
        '
        'mnuDragonForce
        '
        Me.mnuDragonForce.Name = "mnuDragonForce"
        Me.mnuDragonForce.Size = New System.Drawing.Size(152, 22)
        Me.mnuDragonForce.Text = "DragonForce"
        '
        'mnuNightwish
        '
        Me.mnuNightwish.Name = "mnuNightwish"
        Me.mnuNightwish.Size = New System.Drawing.Size(152, 22)
        Me.mnuNightwish.Text = "Nightwish"
        '
        'mnuProtomen
        '
        Me.mnuProtomen.Name = "mnuProtomen"
        Me.mnuProtomen.Size = New System.Drawing.Size(152, 22)
        Me.mnuProtomen.Text = "The Protomen"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(152, 22)
        Me.mnuClose.Text = "Close"
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(19, 81)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(249, 153)
        Me.lblDisplay.TabIndex = 1
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Bands"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDragonForce As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNightwish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProtomen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem

End Class
