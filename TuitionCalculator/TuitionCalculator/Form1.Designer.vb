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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstDegrees = New System.Windows.Forms.ListBox()
        Me.lblPromptV2 = New System.Windows.Forms.Label()
        Me.cboHours = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(25, 17)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(72, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Course Level:"
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(25, 101)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(247, 23)
        Me.lblDisplay.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(179, 66)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstDegrees
        '
        Me.lstDegrees.FormattingEnabled = True
        Me.lstDegrees.Items.AddRange(New Object() {"Undergraduate", "Graduate", "Thesis and Dissertation"})
        Me.lstDegrees.Location = New System.Drawing.Point(28, 33)
        Me.lstDegrees.Name = "lstDegrees"
        Me.lstDegrees.Size = New System.Drawing.Size(135, 56)
        Me.lstDegrees.TabIndex = 3
        '
        'lblPromptV2
        '
        Me.lblPromptV2.AutoSize = True
        Me.lblPromptV2.Location = New System.Drawing.Point(181, 17)
        Me.lblPromptV2.Name = "lblPromptV2"
        Me.lblPromptV2.Size = New System.Drawing.Size(65, 13)
        Me.lblPromptV2.TabIndex = 5
        Me.lblPromptV2.Text = "Credit Hours"
        '
        'cboHours
        '
        Me.cboHours.FormattingEnabled = True
        Me.cboHours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18"})
        Me.cboHours.Location = New System.Drawing.Point(181, 37)
        Me.cboHours.Name = "cboHours"
        Me.cboHours.Size = New System.Drawing.Size(64, 21)
        Me.cboHours.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 144)
        Me.Controls.Add(Me.cboHours)
        Me.Controls.Add(Me.lblPromptV2)
        Me.Controls.Add(Me.lstDegrees)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Tuition Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstDegrees As System.Windows.Forms.ListBox
    Friend WithEvents lblPromptV2 As System.Windows.Forms.Label
    Friend WithEvents cboHours As System.Windows.Forms.ComboBox

End Class
