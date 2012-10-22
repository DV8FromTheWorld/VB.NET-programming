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
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.radOatmeal = New System.Windows.Forms.RadioButton()
        Me.radPeanutButter = New System.Windows.Forms.RadioButton()
        Me.radChocChip = New System.Windows.Forms.RadioButton()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.nudOrderAmount = New System.Windows.Forms.NumericUpDown()
        Me.lblCookieAmount = New System.Windows.Forms.Label()
        Me.grpChoices.SuspendLayout()
        CType(Me.nudOrderAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.radOatmeal)
        Me.grpChoices.Controls.Add(Me.radPeanutButter)
        Me.grpChoices.Controls.Add(Me.radChocChip)
        Me.grpChoices.Location = New System.Drawing.Point(52, 12)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(223, 108)
        Me.grpChoices.TabIndex = 0
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Your Choices"
        '
        'radOatmeal
        '
        Me.radOatmeal.AutoSize = True
        Me.radOatmeal.Location = New System.Drawing.Point(37, 51)
        Me.radOatmeal.Name = "radOatmeal"
        Me.radOatmeal.Size = New System.Drawing.Size(100, 17)
        Me.radOatmeal.TabIndex = 2
        Me.radOatmeal.TabStop = True
        Me.radOatmeal.Text = "Oatmeal Raison"
        Me.radOatmeal.UseVisualStyleBackColor = True
        '
        'radPeanutButter
        '
        Me.radPeanutButter.AutoSize = True
        Me.radPeanutButter.Location = New System.Drawing.Point(37, 74)
        Me.radPeanutButter.Name = "radPeanutButter"
        Me.radPeanutButter.Size = New System.Drawing.Size(90, 17)
        Me.radPeanutButter.TabIndex = 1
        Me.radPeanutButter.TabStop = True
        Me.radPeanutButter.Text = "Peanut Butter"
        Me.radPeanutButter.UseVisualStyleBackColor = True
        '
        'radChocChip
        '
        Me.radChocChip.AutoSize = True
        Me.radChocChip.Location = New System.Drawing.Point(37, 28)
        Me.radChocChip.Name = "radChocChip"
        Me.radChocChip.Size = New System.Drawing.Size(97, 17)
        Me.radChocChip.TabIndex = 0
        Me.radChocChip.TabStop = True
        Me.radChocChip.Text = "Chocolate Chip"
        Me.radChocChip.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(52, 152)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(223, 27)
        Me.btnOrder.TabIndex = 1
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblChoice
        '
        Me.lblChoice.Location = New System.Drawing.Point(16, 213)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(289, 35)
        Me.lblChoice.TabIndex = 2
        '
        'nudOrderAmount
        '
        Me.nudOrderAmount.Location = New System.Drawing.Point(165, 126)
        Me.nudOrderAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudOrderAmount.Name = "nudOrderAmount"
        Me.nudOrderAmount.Size = New System.Drawing.Size(56, 20)
        Me.nudOrderAmount.TabIndex = 3
        Me.nudOrderAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblCookieAmount
        '
        Me.lblCookieAmount.AutoSize = True
        Me.lblCookieAmount.Location = New System.Drawing.Point(82, 128)
        Me.lblCookieAmount.Name = "lblCookieAmount"
        Me.lblCookieAmount.Size = New System.Drawing.Size(77, 13)
        Me.lblCookieAmount.TabIndex = 4
        Me.lblCookieAmount.Text = "Order amount: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 302)
        Me.Controls.Add(Me.lblCookieAmount)
        Me.Controls.Add(Me.nudOrderAmount)
        Me.Controls.Add(Me.lblChoice)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.grpChoices)
        Me.Name = "Form1"
        Me.Text = "Cookie Shop"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        CType(Me.nudOrderAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox
    Friend WithEvents radOatmeal As System.Windows.Forms.RadioButton
    Friend WithEvents radPeanutButter As System.Windows.Forms.RadioButton
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblChoice As System.Windows.Forms.Label
    Friend WithEvents radChocChip As System.Windows.Forms.RadioButton
    Friend WithEvents nudOrderAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCookieAmount As System.Windows.Forms.Label

End Class
