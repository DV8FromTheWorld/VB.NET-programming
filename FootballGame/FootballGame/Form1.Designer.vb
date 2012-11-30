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
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblPromt1 = New System.Windows.Forms.Label()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.lblPrompt3 = New System.Windows.Forms.Label()
        Me.lblPormpt4 = New System.Windows.Forms.Label()
        Me.txtQ1 = New System.Windows.Forms.TextBox()
        Me.txtQ3 = New System.Windows.Forms.TextBox()
        Me.txtQ4 = New System.Windows.Forms.TextBox()
        Me.txtQ2 = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(15, 115)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(224, 23)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Compute the Total Number of Points"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblPromt1
        '
        Me.lblPromt1.AutoSize = True
        Me.lblPromt1.Location = New System.Drawing.Point(12, 15)
        Me.lblPromt1.Name = "lblPromt1"
        Me.lblPromt1.Size = New System.Drawing.Size(136, 13)
        Me.lblPromt1.TabIndex = 1
        Me.lblPromt1.Text = "Enter the first Quater Points"
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 40)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(158, 13)
        Me.lblPrompt2.TabIndex = 2
        Me.lblPrompt2.Text = "Enter the second Quarter Points"
        '
        'lblPrompt3
        '
        Me.lblPrompt3.AutoSize = True
        Me.lblPrompt3.Location = New System.Drawing.Point(12, 66)
        Me.lblPrompt3.Name = "lblPrompt3"
        Me.lblPrompt3.Size = New System.Drawing.Size(143, 13)
        Me.lblPrompt3.TabIndex = 3
        Me.lblPrompt3.Text = "Enter the third Quarter Points"
        '
        'lblPormpt4
        '
        Me.lblPormpt4.AutoSize = True
        Me.lblPormpt4.Location = New System.Drawing.Point(12, 92)
        Me.lblPormpt4.Name = "lblPormpt4"
        Me.lblPormpt4.Size = New System.Drawing.Size(150, 13)
        Me.lblPormpt4.TabIndex = 4
        Me.lblPormpt4.Text = "Enter the fourth Quarter Points"
        '
        'txtQ1
        '
        Me.txtQ1.Location = New System.Drawing.Point(178, 12)
        Me.txtQ1.Name = "txtQ1"
        Me.txtQ1.Size = New System.Drawing.Size(61, 20)
        Me.txtQ1.TabIndex = 5
        '
        'txtQ3
        '
        Me.txtQ3.Location = New System.Drawing.Point(178, 63)
        Me.txtQ3.Name = "txtQ3"
        Me.txtQ3.Size = New System.Drawing.Size(61, 20)
        Me.txtQ3.TabIndex = 6
        '
        'txtQ4
        '
        Me.txtQ4.Location = New System.Drawing.Point(178, 89)
        Me.txtQ4.Name = "txtQ4"
        Me.txtQ4.Size = New System.Drawing.Size(61, 20)
        Me.txtQ4.TabIndex = 7
        '
        'txtQ2
        '
        Me.txtQ2.Location = New System.Drawing.Point(178, 37)
        Me.txtQ2.Name = "txtQ2"
        Me.txtQ2.Size = New System.Drawing.Size(61, 20)
        Me.txtQ2.TabIndex = 8
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(12, 155)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(226, 32)
        Me.lblDisplay.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtQ2)
        Me.Controls.Add(Me.txtQ4)
        Me.Controls.Add(Me.txtQ3)
        Me.Controls.Add(Me.txtQ1)
        Me.Controls.Add(Me.lblPormpt4)
        Me.Controls.Add(Me.lblPrompt3)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPromt1)
        Me.Controls.Add(Me.btnTotal)
        Me.Name = "Form1"
        Me.Text = "Football Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents lblPromt1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt3 As System.Windows.Forms.Label
    Friend WithEvents lblPormpt4 As System.Windows.Forms.Label
    Friend WithEvents txtQ1 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ3 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ4 As System.Windows.Forms.TextBox
    Friend WithEvents txtQ2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
