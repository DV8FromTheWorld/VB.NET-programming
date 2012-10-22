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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtDenominator = New System.Windows.Forms.TextBox()
        Me.txtNumerator = New System.Windows.Forms.TextBox()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.lblAnswerPrompt = New System.Windows.Forms.Label()
        Me.lblAnswerDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(67, 112)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtDenominator
        '
        Me.txtDenominator.Location = New System.Drawing.Point(107, 51)
        Me.txtDenominator.Name = "txtDenominator"
        Me.txtDenominator.Size = New System.Drawing.Size(68, 20)
        Me.txtDenominator.TabIndex = 1
        '
        'txtNumerator
        '
        Me.txtNumerator.Location = New System.Drawing.Point(107, 25)
        Me.txtNumerator.Name = "txtNumerator"
        Me.txtNumerator.Size = New System.Drawing.Size(68, 20)
        Me.txtNumerator.TabIndex = 2
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(34, 28)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(56, 13)
        Me.lblPrompt1.TabIndex = 3
        Me.lblPrompt1.Text = "Numerator"
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(34, 54)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(67, 13)
        Me.lblPrompt2.TabIndex = 4
        Me.lblPrompt2.Text = "Denominator"
        '
        'lblAnswerPrompt
        '
        Me.lblAnswerPrompt.AutoSize = True
        Me.lblAnswerPrompt.Location = New System.Drawing.Point(34, 80)
        Me.lblAnswerPrompt.Name = "lblAnswerPrompt"
        Me.lblAnswerPrompt.Size = New System.Drawing.Size(45, 13)
        Me.lblAnswerPrompt.TabIndex = 5
        Me.lblAnswerPrompt.Text = "Answer:"
        '
        'lblAnswerDisplay
        '
        Me.lblAnswerDisplay.Location = New System.Drawing.Point(104, 80)
        Me.lblAnswerDisplay.Name = "lblAnswerDisplay"
        Me.lblAnswerDisplay.Size = New System.Drawing.Size(62, 18)
        Me.lblAnswerDisplay.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(188, 148)
        Me.Controls.Add(Me.lblAnswerDisplay)
        Me.Controls.Add(Me.lblAnswerPrompt)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Controls.Add(Me.txtNumerator)
        Me.Controls.Add(Me.txtDenominator)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Fraction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtDenominator As System.Windows.Forms.TextBox
    Friend WithEvents txtNumerator As System.Windows.Forms.TextBox
    Friend WithEvents lblPrompt1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents lblAnswerPrompt As System.Windows.Forms.Label
    Friend WithEvents lblAnswerDisplay As System.Windows.Forms.Label

End Class
