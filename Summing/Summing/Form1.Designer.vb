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
        Me.lblTest1Prompt = New System.Windows.Forms.Label()
        Me.lblTest2Prompt = New System.Windows.Forms.Label()
        Me.lblTest3Prompt = New System.Windows.Forms.Label()
        Me.lblTest4Prompt = New System.Windows.Forms.Label()
        Me.txtTest1 = New System.Windows.Forms.TextBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        Me.txtTest3 = New System.Windows.Forms.TextBox()
        Me.txtTest4 = New System.Windows.Forms.TextBox()
        Me.btnCalcAverage = New System.Windows.Forms.Button()
        Me.lblAverageDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTest1Prompt
        '
        Me.lblTest1Prompt.AutoSize = True
        Me.lblTest1Prompt.Location = New System.Drawing.Point(31, 23)
        Me.lblTest1Prompt.Name = "lblTest1Prompt"
        Me.lblTest1Prompt.Size = New System.Drawing.Size(72, 13)
        Me.lblTest1Prompt.TabIndex = 0
        Me.lblTest1Prompt.Text = "Enter Test #1"
        '
        'lblTest2Prompt
        '
        Me.lblTest2Prompt.AutoSize = True
        Me.lblTest2Prompt.Location = New System.Drawing.Point(31, 47)
        Me.lblTest2Prompt.Name = "lblTest2Prompt"
        Me.lblTest2Prompt.Size = New System.Drawing.Size(72, 13)
        Me.lblTest2Prompt.TabIndex = 1
        Me.lblTest2Prompt.Text = "Enter Test #2"
        '
        'lblTest3Prompt
        '
        Me.lblTest3Prompt.AutoSize = True
        Me.lblTest3Prompt.Location = New System.Drawing.Point(31, 74)
        Me.lblTest3Prompt.Name = "lblTest3Prompt"
        Me.lblTest3Prompt.Size = New System.Drawing.Size(72, 13)
        Me.lblTest3Prompt.TabIndex = 2
        Me.lblTest3Prompt.Text = "Enter Test #3"
        '
        'lblTest4Prompt
        '
        Me.lblTest4Prompt.AutoSize = True
        Me.lblTest4Prompt.Location = New System.Drawing.Point(31, 103)
        Me.lblTest4Prompt.Name = "lblTest4Prompt"
        Me.lblTest4Prompt.Size = New System.Drawing.Size(72, 13)
        Me.lblTest4Prompt.TabIndex = 3
        Me.lblTest4Prompt.Text = "Enter Test #4"
        '
        'txtTest1
        '
        Me.txtTest1.Location = New System.Drawing.Point(125, 20)
        Me.txtTest1.Name = "txtTest1"
        Me.txtTest1.Size = New System.Drawing.Size(57, 20)
        Me.txtTest1.TabIndex = 4
        '
        'txtTest2
        '
        Me.txtTest2.Location = New System.Drawing.Point(125, 44)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(57, 20)
        Me.txtTest2.TabIndex = 5
        '
        'txtTest3
        '
        Me.txtTest3.Location = New System.Drawing.Point(125, 71)
        Me.txtTest3.Name = "txtTest3"
        Me.txtTest3.Size = New System.Drawing.Size(57, 20)
        Me.txtTest3.TabIndex = 6
        '
        'txtTest4
        '
        Me.txtTest4.Location = New System.Drawing.Point(125, 100)
        Me.txtTest4.Name = "txtTest4"
        Me.txtTest4.Size = New System.Drawing.Size(57, 20)
        Me.txtTest4.TabIndex = 7
        '
        'btnCalcAverage
        '
        Me.btnCalcAverage.Location = New System.Drawing.Point(34, 136)
        Me.btnCalcAverage.Name = "btnCalcAverage"
        Me.btnCalcAverage.Size = New System.Drawing.Size(148, 24)
        Me.btnCalcAverage.TabIndex = 8
        Me.btnCalcAverage.Text = "Get the Average"
        Me.btnCalcAverage.UseVisualStyleBackColor = True
        '
        'lblAverageDisplay
        '
        Me.lblAverageDisplay.Location = New System.Drawing.Point(31, 180)
        Me.lblAverageDisplay.Name = "lblAverageDisplay"
        Me.lblAverageDisplay.Size = New System.Drawing.Size(174, 43)
        Me.lblAverageDisplay.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(208, 234)
        Me.Controls.Add(Me.lblAverageDisplay)
        Me.Controls.Add(Me.btnCalcAverage)
        Me.Controls.Add(Me.txtTest4)
        Me.Controls.Add(Me.txtTest3)
        Me.Controls.Add(Me.txtTest2)
        Me.Controls.Add(Me.txtTest1)
        Me.Controls.Add(Me.lblTest4Prompt)
        Me.Controls.Add(Me.lblTest3Prompt)
        Me.Controls.Add(Me.lblTest2Prompt)
        Me.Controls.Add(Me.lblTest1Prompt)
        Me.Name = "Form1"
        Me.Text = "Summing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTest1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblTest2Prompt As System.Windows.Forms.Label
    Friend WithEvents lblTest3Prompt As System.Windows.Forms.Label
    Friend WithEvents lblTest4Prompt As System.Windows.Forms.Label
    Friend WithEvents txtTest1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest4 As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcAverage As System.Windows.Forms.Button
    Friend WithEvents lblAverageDisplay As System.Windows.Forms.Label

End Class
