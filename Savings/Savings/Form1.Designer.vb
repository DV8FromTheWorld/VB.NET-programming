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
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 21)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(215, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the amount put in savings each month"
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 53)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(290, 13)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "Enter the number of months you deposited money in savings"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(317, 18)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(58, 20)
        Me.txtAmount.TabIndex = 2
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(317, 50)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(58, 20)
        Me.txtMonths.TabIndex = 3
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(46, 82)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(308, 30)
        Me.lblDisplay.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(115, 124)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(177, 24)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate the Amount of Savings"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 149)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtMonths)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
