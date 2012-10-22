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
        Me.lblFirstOperandPrompt = New System.Windows.Forms.Label()
        Me.lblSecondOperandPrompt = New System.Windows.Forms.Label()
        Me.txtFirstOperand = New System.Windows.Forms.TextBox()
        Me.txtSecondOperand = New System.Windows.Forms.TextBox()
        Me.grpOperators = New System.Windows.Forms.GroupBox()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.radModulus = New System.Windows.Forms.RadioButton()
        Me.radDivisionInteger = New System.Windows.Forms.RadioButton()
        Me.radDivision = New System.Windows.Forms.RadioButton()
        Me.radMultiplication = New System.Windows.Forms.RadioButton()
        Me.radExponent = New System.Windows.Forms.RadioButton()
        Me.lblResultPrompt = New System.Windows.Forms.Label()
        Me.lblAnswerDisplay = New System.Windows.Forms.Label()
        Me.grpOperators.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstOperandPrompt
        '
        Me.lblFirstOperandPrompt.Location = New System.Drawing.Point(12, 21)
        Me.lblFirstOperandPrompt.Name = "lblFirstOperandPrompt"
        Me.lblFirstOperandPrompt.Size = New System.Drawing.Size(74, 23)
        Me.lblFirstOperandPrompt.TabIndex = 0
        Me.lblFirstOperandPrompt.Text = "First Operand:"
        '
        'lblSecondOperandPrompt
        '
        Me.lblSecondOperandPrompt.AutoSize = True
        Me.lblSecondOperandPrompt.Location = New System.Drawing.Point(155, 21)
        Me.lblSecondOperandPrompt.Name = "lblSecondOperandPrompt"
        Me.lblSecondOperandPrompt.Size = New System.Drawing.Size(91, 13)
        Me.lblSecondOperandPrompt.TabIndex = 1
        Me.lblSecondOperandPrompt.Text = "Second Operand:"
        '
        'txtFirstOperand
        '
        Me.txtFirstOperand.Location = New System.Drawing.Point(92, 18)
        Me.txtFirstOperand.Name = "txtFirstOperand"
        Me.txtFirstOperand.Size = New System.Drawing.Size(41, 20)
        Me.txtFirstOperand.TabIndex = 2
        '
        'txtSecondOperand
        '
        Me.txtSecondOperand.Location = New System.Drawing.Point(252, 18)
        Me.txtSecondOperand.Name = "txtSecondOperand"
        Me.txtSecondOperand.Size = New System.Drawing.Size(41, 20)
        Me.txtSecondOperand.TabIndex = 3
        '
        'grpOperators
        '
        Me.grpOperators.Controls.Add(Me.radSubtraction)
        Me.grpOperators.Controls.Add(Me.radAddition)
        Me.grpOperators.Controls.Add(Me.radModulus)
        Me.grpOperators.Controls.Add(Me.radDivisionInteger)
        Me.grpOperators.Controls.Add(Me.radDivision)
        Me.grpOperators.Controls.Add(Me.radMultiplication)
        Me.grpOperators.Controls.Add(Me.radExponent)
        Me.grpOperators.Location = New System.Drawing.Point(15, 68)
        Me.grpOperators.Name = "grpOperators"
        Me.grpOperators.Size = New System.Drawing.Size(278, 46)
        Me.grpOperators.TabIndex = 4
        Me.grpOperators.TabStop = False
        Me.grpOperators.Text = "Select an Operator"
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Location = New System.Drawing.Point(43, 18)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(28, 17)
        Me.radSubtraction.TabIndex = 6
        Me.radSubtraction.TabStop = True
        Me.radSubtraction.Text = "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Location = New System.Drawing.Point(6, 18)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(31, 17)
        Me.radAddition.TabIndex = 5
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "+"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'radModulus
        '
        Me.radModulus.AutoSize = True
        Me.radModulus.Location = New System.Drawing.Point(179, 18)
        Me.radModulus.Name = "radModulus"
        Me.radModulus.Size = New System.Drawing.Size(46, 17)
        Me.radModulus.TabIndex = 4
        Me.radModulus.TabStop = True
        Me.radModulus.Text = "Mod"
        Me.radModulus.UseVisualStyleBackColor = True
        '
        'radDivisionInteger
        '
        Me.radDivisionInteger.AutoSize = True
        Me.radDivisionInteger.Location = New System.Drawing.Point(143, 18)
        Me.radDivisionInteger.Name = "radDivisionInteger"
        Me.radDivisionInteger.Size = New System.Drawing.Size(30, 17)
        Me.radDivisionInteger.TabIndex = 3
        Me.radDivisionInteger.TabStop = True
        Me.radDivisionInteger.Text = "\"
        Me.radDivisionInteger.UseVisualStyleBackColor = True
        '
        'radDivision
        '
        Me.radDivision.AutoSize = True
        Me.radDivision.Location = New System.Drawing.Point(77, 18)
        Me.radDivision.Name = "radDivision"
        Me.radDivision.Size = New System.Drawing.Size(30, 17)
        Me.radDivision.TabIndex = 2
        Me.radDivision.TabStop = True
        Me.radDivision.Text = "/"
        Me.radDivision.UseVisualStyleBackColor = True
        '
        'radMultiplication
        '
        Me.radMultiplication.AutoSize = True
        Me.radMultiplication.Location = New System.Drawing.Point(113, 18)
        Me.radMultiplication.Name = "radMultiplication"
        Me.radMultiplication.Size = New System.Drawing.Size(29, 17)
        Me.radMultiplication.TabIndex = 1
        Me.radMultiplication.TabStop = True
        Me.radMultiplication.Text = "*"
        Me.radMultiplication.UseVisualStyleBackColor = True
        '
        'radExponent
        '
        Me.radExponent.AutoSize = True
        Me.radExponent.Location = New System.Drawing.Point(231, 18)
        Me.radExponent.Name = "radExponent"
        Me.radExponent.Size = New System.Drawing.Size(31, 17)
        Me.radExponent.TabIndex = 0
        Me.radExponent.TabStop = True
        Me.radExponent.Text = "^"
        Me.radExponent.UseVisualStyleBackColor = True
        '
        'lblResultPrompt
        '
        Me.lblResultPrompt.Location = New System.Drawing.Point(65, 137)
        Me.lblResultPrompt.Name = "lblResultPrompt"
        Me.lblResultPrompt.Size = New System.Drawing.Size(40, 17)
        Me.lblResultPrompt.TabIndex = 5
        Me.lblResultPrompt.Text = "Result:"
        '
        'lblAnswerDisplay
        '
        Me.lblAnswerDisplay.Location = New System.Drawing.Point(111, 131)
        Me.lblAnswerDisplay.Name = "lblAnswerDisplay"
        Me.lblAnswerDisplay.Size = New System.Drawing.Size(100, 23)
        Me.lblAnswerDisplay.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 169)
        Me.Controls.Add(Me.lblAnswerDisplay)
        Me.Controls.Add(Me.lblResultPrompt)
        Me.Controls.Add(Me.grpOperators)
        Me.Controls.Add(Me.txtSecondOperand)
        Me.Controls.Add(Me.txtFirstOperand)
        Me.Controls.Add(Me.lblSecondOperandPrompt)
        Me.Controls.Add(Me.lblFirstOperandPrompt)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.grpOperators.ResumeLayout(False)
        Me.grpOperators.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstOperandPrompt As System.Windows.Forms.Label
    Friend WithEvents lblSecondOperandPrompt As System.Windows.Forms.Label
    Friend WithEvents txtFirstOperand As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondOperand As System.Windows.Forms.TextBox
    Friend WithEvents grpOperators As System.Windows.Forms.GroupBox
    Friend WithEvents radSubtraction As System.Windows.Forms.RadioButton
    Friend WithEvents radAddition As System.Windows.Forms.RadioButton
    Friend WithEvents radModulus As System.Windows.Forms.RadioButton
    Friend WithEvents radDivisionInteger As System.Windows.Forms.RadioButton
    Friend WithEvents radDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents radExponent As System.Windows.Forms.RadioButton
    Friend WithEvents lblResultPrompt As System.Windows.Forms.Label
    Friend WithEvents lblAnswerDisplay As System.Windows.Forms.Label

End Class
