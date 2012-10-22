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
        Me.grpCondiments = New System.Windows.Forms.GroupBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkMayonaise = New System.Windows.Forms.CheckBox()
        Me.lblSandwichChoices = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.cbCheeseSelector = New System.Windows.Forms.ComboBox()
        Me.radHam = New System.Windows.Forms.RadioButton()
        Me.radTurkey = New System.Windows.Forms.RadioButton()
        Me.grpMainChoice = New System.Windows.Forms.GroupBox()
        Me.grpCondiments.SuspendLayout()
        Me.grpMainChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCondiments
        '
        Me.grpCondiments.Controls.Add(Me.chkCheese)
        Me.grpCondiments.Controls.Add(Me.chkMustard)
        Me.grpCondiments.Controls.Add(Me.chkMayonaise)
        Me.grpCondiments.Location = New System.Drawing.Point(103, 123)
        Me.grpCondiments.Name = "grpCondiments"
        Me.grpCondiments.Size = New System.Drawing.Size(282, 58)
        Me.grpCondiments.TabIndex = 1
        Me.grpCondiments.TabStop = False
        Me.grpCondiments.Text = "Condiments"
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(183, 19)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 2
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Location = New System.Drawing.Point(96, 19)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(64, 17)
        Me.chkMustard.TabIndex = 1
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkMayonaise
        '
        Me.chkMayonaise.AutoSize = True
        Me.chkMayonaise.Location = New System.Drawing.Point(9, 19)
        Me.chkMayonaise.Name = "chkMayonaise"
        Me.chkMayonaise.Size = New System.Drawing.Size(77, 17)
        Me.chkMayonaise.TabIndex = 0
        Me.chkMayonaise.Text = "Mayonaise"
        Me.chkMayonaise.UseVisualStyleBackColor = True
        '
        'lblSandwichChoices
        '
        Me.lblSandwichChoices.Location = New System.Drawing.Point(191, 240)
        Me.lblSandwichChoices.Name = "lblSandwichChoices"
        Me.lblSandwichChoices.Size = New System.Drawing.Size(321, 136)
        Me.lblSandwichChoices.TabIndex = 2
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(159, 195)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(159, 28)
        Me.btnOrder.TabIndex = 3
        Me.btnOrder.Text = "Order Sandwich"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'cbCheeseSelector
        '
        Me.cbCheeseSelector.Enabled = False
        Me.cbCheeseSelector.FormattingEnabled = True
        Me.cbCheeseSelector.Items.AddRange(New Object() {"Swiss", "American", "Cheddar", "Pepper-Jack", "Provolone"})
        Me.cbCheeseSelector.Location = New System.Drawing.Point(391, 138)
        Me.cbCheeseSelector.Name = "cbCheeseSelector"
        Me.cbCheeseSelector.Size = New System.Drawing.Size(121, 21)
        Me.cbCheeseSelector.TabIndex = 4
        Me.cbCheeseSelector.Text = "Select Cheese Type"
        '
        'radHam
        '
        Me.radHam.AutoSize = True
        Me.radHam.Location = New System.Drawing.Point(58, 30)
        Me.radHam.Name = "radHam"
        Me.radHam.Size = New System.Drawing.Size(47, 17)
        Me.radHam.TabIndex = 0
        Me.radHam.TabStop = True
        Me.radHam.Text = "Ham"
        Me.radHam.UseVisualStyleBackColor = True
        '
        'radTurkey
        '
        Me.radTurkey.AutoSize = True
        Me.radTurkey.Location = New System.Drawing.Point(160, 30)
        Me.radTurkey.Name = "radTurkey"
        Me.radTurkey.Size = New System.Drawing.Size(58, 17)
        Me.radTurkey.TabIndex = 1
        Me.radTurkey.TabStop = True
        Me.radTurkey.Text = "Turkey"
        Me.radTurkey.UseVisualStyleBackColor = True
        '
        'grpMainChoice
        '
        Me.grpMainChoice.Controls.Add(Me.radTurkey)
        Me.grpMainChoice.Controls.Add(Me.radHam)
        Me.grpMainChoice.Location = New System.Drawing.Point(101, 38)
        Me.grpMainChoice.Name = "grpMainChoice"
        Me.grpMainChoice.Size = New System.Drawing.Size(284, 67)
        Me.grpMainChoice.TabIndex = 0
        Me.grpMainChoice.TabStop = False
        Me.grpMainChoice.Text = "Main Choice"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 385)
        Me.Controls.Add(Me.cbCheeseSelector)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblSandwichChoices)
        Me.Controls.Add(Me.grpCondiments)
        Me.Controls.Add(Me.grpMainChoice)
        Me.Name = "Form1"
        Me.Text = "Sandwich Shop"
        Me.grpCondiments.ResumeLayout(False)
        Me.grpCondiments.PerformLayout()
        Me.grpMainChoice.ResumeLayout(False)
        Me.grpMainChoice.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCondiments As System.Windows.Forms.GroupBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkMustard As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayonaise As System.Windows.Forms.CheckBox
    Friend WithEvents lblSandwichChoices As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents cbCheeseSelector As System.Windows.Forms.ComboBox
    Friend WithEvents radHam As System.Windows.Forms.RadioButton
    Friend WithEvents radTurkey As System.Windows.Forms.RadioButton
    Friend WithEvents grpMainChoice As System.Windows.Forms.GroupBox

End Class
