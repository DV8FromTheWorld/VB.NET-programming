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
        Me.lblAmountPrompt = New System.Windows.Forms.Label()
        Me.lblServings = New System.Windows.Forms.Label()
        Me.lblAmountLeft = New System.Windows.Forms.Label()
        Me.lblServingsText = New System.Windows.Forms.Label()
        Me.lblAmountLeftText = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAmountPrompt
        '
        Me.lblAmountPrompt.Location = New System.Drawing.Point(12, 12)
        Me.lblAmountPrompt.Name = "lblAmountPrompt"
        Me.lblAmountPrompt.Size = New System.Drawing.Size(187, 23)
        Me.lblAmountPrompt.TabIndex = 0
        Me.lblAmountPrompt.Text = "Enter the number of mints in the bag"
        '
        'lblServings
        '
        Me.lblServings.Location = New System.Drawing.Point(40, 52)
        Me.lblServings.Name = "lblServings"
        Me.lblServings.Size = New System.Drawing.Size(51, 23)
        Me.lblServings.TabIndex = 1
        '
        'lblAmountLeft
        '
        Me.lblAmountLeft.Location = New System.Drawing.Point(40, 75)
        Me.lblAmountLeft.Name = "lblAmountLeft"
        Me.lblAmountLeft.Size = New System.Drawing.Size(51, 23)
        Me.lblAmountLeft.TabIndex = 2
        '
        'lblServingsText
        '
        Me.lblServingsText.Location = New System.Drawing.Point(97, 52)
        Me.lblServingsText.Name = "lblServingsText"
        Me.lblServingsText.Size = New System.Drawing.Size(142, 23)
        Me.lblServingsText.TabIndex = 3
        Me.lblServingsText.Text = "Number of servings per bag"
        '
        'lblAmountLeftText
        '
        Me.lblAmountLeftText.Location = New System.Drawing.Point(97, 75)
        Me.lblAmountLeftText.Name = "lblAmountLeftText"
        Me.lblAmountLeftText.Size = New System.Drawing.Size(133, 23)
        Me.lblAmountLeftText.TabIndex = 4
        Me.lblAmountLeftText.Text = "Mints Left Over"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(205, 9)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(54, 20)
        Me.txtAmount.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(111, 102)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(67, 28)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 174)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmountLeftText)
        Me.Controls.Add(Me.lblServingsText)
        Me.Controls.Add(Me.lblAmountLeft)
        Me.Controls.Add(Me.lblServings)
        Me.Controls.Add(Me.lblAmountPrompt)
        Me.Name = "Form1"
        Me.Text = "Mints"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmountPrompt As System.Windows.Forms.Label
    Friend WithEvents lblServings As System.Windows.Forms.Label
    Friend WithEvents lblAmountLeft As System.Windows.Forms.Label
    Friend WithEvents lblServingsText As System.Windows.Forms.Label
    Friend WithEvents lblAmountLeftText As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
