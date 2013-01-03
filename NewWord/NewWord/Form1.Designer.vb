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
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.txtReplacementLetter = New System.Windows.Forms.TextBox()
        Me.txtLetterToReplace = New System.Windows.Forms.TextBox()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(66, 98)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(158, 23)
        Me.btnReplace.TabIndex = 14
        Me.btnReplace.Text = "Replace Letter"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'txtReplacementLetter
        '
        Me.txtReplacementLetter.Location = New System.Drawing.Point(211, 63)
        Me.txtReplacementLetter.Name = "txtReplacementLetter"
        Me.txtReplacementLetter.Size = New System.Drawing.Size(53, 20)
        Me.txtReplacementLetter.TabIndex = 13
        '
        'txtLetterToReplace
        '
        Me.txtLetterToReplace.Location = New System.Drawing.Point(211, 37)
        Me.txtLetterToReplace.Name = "txtLetterToReplace"
        Me.txtLetterToReplace.Size = New System.Drawing.Size(53, 20)
        Me.txtLetterToReplace.TabIndex = 12
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(117, 13)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(147, 20)
        Me.txtWord.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Enter the replacement letter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter the letter to replace"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter a Word"
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(63, 135)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(181, 53)
        Me.lblDisplay.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.txtReplacementLetter)
        Me.Controls.Add(Me.txtLetterToReplace)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "New Word"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents txtReplacementLetter As System.Windows.Forms.TextBox
    Friend WithEvents txtLetterToReplace As System.Windows.Forms.TextBox
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
