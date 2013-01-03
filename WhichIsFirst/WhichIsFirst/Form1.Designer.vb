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
        Me.btnWhichWordFirst = New System.Windows.Forms.Button()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtWord1 = New System.Windows.Forms.TextBox()
        Me.txtWord2 = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnWhichWordFirst
        '
        Me.btnWhichWordFirst.Location = New System.Drawing.Point(12, 12)
        Me.btnWhichWordFirst.Name = "btnWhichWordFirst"
        Me.btnWhichWordFirst.Size = New System.Drawing.Size(204, 25)
        Me.btnWhichWordFirst.TabIndex = 0
        Me.btnWhichWordFirst.Text = "Which word comes first?"
        Me.btnWhichWordFirst.UseVisualStyleBackColor = True
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(12, 55)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(67, 13)
        Me.lblPrompt1.TabIndex = 1
        Me.lblPrompt1.Text = "Enter a word"
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 80)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(67, 13)
        Me.lblPrompt2.TabIndex = 2
        Me.lblPrompt2.Text = "Enter a word"
        '
        'txtWord1
        '
        Me.txtWord1.Location = New System.Drawing.Point(104, 52)
        Me.txtWord1.Name = "txtWord1"
        Me.txtWord1.Size = New System.Drawing.Size(100, 20)
        Me.txtWord1.TabIndex = 3
        '
        'txtWord2
        '
        Me.txtWord2.Location = New System.Drawing.Point(104, 77)
        Me.txtWord2.Name = "txtWord2"
        Me.txtWord2.Size = New System.Drawing.Size(100, 20)
        Me.txtWord2.TabIndex = 4
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(12, 109)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(192, 43)
        Me.lblDisplay.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 170)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtWord2)
        Me.Controls.Add(Me.txtWord1)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Controls.Add(Me.btnWhichWordFirst)
        Me.Name = "Form1"
        Me.Text = "Which is first?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWhichWordFirst As System.Windows.Forms.Button
    Friend WithEvents lblPrompt1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents txtWord1 As System.Windows.Forms.TextBox
    Friend WithEvents txtWord2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
