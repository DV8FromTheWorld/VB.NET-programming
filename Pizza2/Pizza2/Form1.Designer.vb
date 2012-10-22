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
        Me.lblCrustPrompt = New System.Windows.Forms.Label()
        Me.lblTopping1Prompt = New System.Windows.Forms.Label()
        Me.lblTopping2Prompt = New System.Windows.Forms.Label()
        Me.cbCrust = New System.Windows.Forms.ComboBox()
        Me.cbTopping1 = New System.Windows.Forms.ComboBox()
        Me.cbTopping2 = New System.Windows.Forms.ComboBox()
        Me.lblOrderDisplay = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCrustPrompt
        '
        Me.lblCrustPrompt.Location = New System.Drawing.Point(12, 34)
        Me.lblCrustPrompt.Name = "lblCrustPrompt"
        Me.lblCrustPrompt.Size = New System.Drawing.Size(150, 22)
        Me.lblCrustPrompt.TabIndex = 0
        Me.lblCrustPrompt.Text = "Select your choice of crust:"
        '
        'lblTopping1Prompt
        '
        Me.lblTopping1Prompt.Location = New System.Drawing.Point(12, 68)
        Me.lblTopping1Prompt.Name = "lblTopping1Prompt"
        Me.lblTopping1Prompt.Size = New System.Drawing.Size(174, 22)
        Me.lblTopping1Prompt.TabIndex = 1
        Me.lblTopping1Prompt.Text = "Select your first topping:"
        '
        'lblTopping2Prompt
        '
        Me.lblTopping2Prompt.Location = New System.Drawing.Point(12, 100)
        Me.lblTopping2Prompt.Name = "lblTopping2Prompt"
        Me.lblTopping2Prompt.Size = New System.Drawing.Size(182, 20)
        Me.lblTopping2Prompt.TabIndex = 2
        Me.lblTopping2Prompt.Text = "Select your second topping:"
        '
        'cbCrust
        '
        Me.cbCrust.FormattingEnabled = True
        Me.cbCrust.Items.AddRange(New Object() {"Hand-tossed", "Thin", "Stuffed-Crust", "Deep-Dish"})
        Me.cbCrust.Location = New System.Drawing.Point(168, 31)
        Me.cbCrust.Name = "cbCrust"
        Me.cbCrust.Size = New System.Drawing.Size(103, 21)
        Me.cbCrust.TabIndex = 3
        Me.cbCrust.Text = "Select crust type"
        '
        'cbTopping1
        '
        Me.cbTopping1.FormattingEnabled = True
        Me.cbTopping1.Items.AddRange(New Object() {"Pepperoni", "Extra Cheese", "Ground Beef", "Bacon", "Green Peppers", "Onions", "Banana Peppers", "Mushrooms", "Sausage", "Ham"})
        Me.cbTopping1.Location = New System.Drawing.Point(168, 65)
        Me.cbTopping1.Name = "cbTopping1"
        Me.cbTopping1.Size = New System.Drawing.Size(103, 21)
        Me.cbTopping1.TabIndex = 4
        Me.cbTopping1.Text = "First topping"
        '
        'cbTopping2
        '
        Me.cbTopping2.FormattingEnabled = True
        Me.cbTopping2.Items.AddRange(New Object() {"Pepperoni", "Extra Cheese", "Ground Beef", "Bacon", "Green Peppers", "Onions", "Banana Peppers", "Mushrooms", "Sausage", "Ham"})
        Me.cbTopping2.Location = New System.Drawing.Point(168, 93)
        Me.cbTopping2.Name = "cbTopping2"
        Me.cbTopping2.Size = New System.Drawing.Size(103, 21)
        Me.cbTopping2.TabIndex = 5
        Me.cbTopping2.Text = "Second topping"
        '
        'lblOrderDisplay
        '
        Me.lblOrderDisplay.Location = New System.Drawing.Point(77, 134)
        Me.lblOrderDisplay.Name = "lblOrderDisplay"
        Me.lblOrderDisplay.Size = New System.Drawing.Size(135, 85)
        Me.lblOrderDisplay.TabIndex = 6
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(80, 222)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(124, 37)
        Me.btnOrder.TabIndex = 7
        Me.btnOrder.Text = "Order Pizza"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblOrderDisplay)
        Me.Controls.Add(Me.cbTopping2)
        Me.Controls.Add(Me.cbTopping1)
        Me.Controls.Add(Me.cbCrust)
        Me.Controls.Add(Me.lblTopping2Prompt)
        Me.Controls.Add(Me.lblTopping1Prompt)
        Me.Controls.Add(Me.lblCrustPrompt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCrustPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTopping1Prompt As System.Windows.Forms.Label
    Friend WithEvents lblTopping2Prompt As System.Windows.Forms.Label
    Friend WithEvents cbCrust As System.Windows.Forms.ComboBox
    Friend WithEvents cbTopping1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbTopping2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrderDisplay As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button

End Class
