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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblCounterDisplay = New System.Windows.Forms.Label()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(89, 195)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(102, 35)
        Me.btnGo.TabIndex = 5
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblCounterDisplay
        '
        Me.lblCounterDisplay.Location = New System.Drawing.Point(39, 119)
        Me.lblCounterDisplay.Name = "lblCounterDisplay"
        Me.lblCounterDisplay.Size = New System.Drawing.Size(207, 52)
        Me.lblCounterDisplay.TabIndex = 4
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.radScissors)
        Me.grpChoices.Controls.Add(Me.radPaper)
        Me.grpChoices.Controls.Add(Me.radRock)
        Me.grpChoices.Location = New System.Drawing.Point(38, 33)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(209, 70)
        Me.grpChoices.TabIndex = 3
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Choose Your Throw"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(133, 33)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(74, 33)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(17, 33)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblCounterDisplay)
        Me.Controls.Add(Me.grpChoices)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblCounterDisplay As System.Windows.Forms.Label
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton

End Class
