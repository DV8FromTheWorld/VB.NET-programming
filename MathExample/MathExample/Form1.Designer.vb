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
        Me.btnAbsoluteValue = New System.Windows.Forms.Button()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAbsoluteValue
        '
        Me.btnAbsoluteValue.Location = New System.Drawing.Point(27, 57)
        Me.btnAbsoluteValue.Name = "btnAbsoluteValue"
        Me.btnAbsoluteValue.Size = New System.Drawing.Size(135, 23)
        Me.btnAbsoluteValue.TabIndex = 0
        Me.btnAbsoluteValue.Text = "Absolute Value"
        Me.btnAbsoluteValue.UseVisualStyleBackColor = True
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.Location = New System.Drawing.Point(27, 86)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(135, 23)
        Me.btnSquareRoot.TabIndex = 1
        Me.btnSquareRoot.Text = "Square Root"
        Me.btnSquareRoot.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(27, 115)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(135, 23)
        Me.btnSign.TabIndex = 2
        Me.btnSign.Text = "Sign"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'btnRound
        '
        Me.btnRound.Location = New System.Drawing.Point(27, 144)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(135, 23)
        Me.btnRound.TabIndex = 3
        Me.btnRound.Text = "Round It"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(24, 29)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(84, 13)
        Me.lblPrompt.TabIndex = 4
        Me.lblPrompt.Text = "Enter a Number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(114, 26)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(48, 20)
        Me.txtNumber.TabIndex = 5
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(24, 180)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(138, 30)
        Me.lblDisplay.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(185, 228)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.btnAbsoluteValue)
        Me.Name = "Form1"
        Me.Text = "Math Class Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAbsoluteValue As System.Windows.Forms.Button
    Friend WithEvents btnSquareRoot As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnRound As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
