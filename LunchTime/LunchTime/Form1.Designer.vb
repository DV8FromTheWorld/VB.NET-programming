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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstChoices = New System.Windows.Forms.ListBox()
        Me.lblChoicePrompt = New System.Windows.Forms.Label()
        Me.cboDrinks = New System.Windows.Forms.ComboBox()
        Me.lblDrinkPrompt = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.lblSizePrompt = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMain})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMain
        '
        Me.mnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(46, 20)
        Me.mnuMain.Text = "Main"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(103, 22)
        Me.mnuClose.Text = "Close"
        '
        'lstChoices
        '
        Me.lstChoices.FormattingEnabled = True
        Me.lstChoices.Items.AddRange(New Object() {"Chef Salad", "Garden Salad", "Hamburger", "Cheeseburger", "Chicken Sandwich"})
        Me.lstChoices.Location = New System.Drawing.Point(12, 59)
        Me.lstChoices.Name = "lstChoices"
        Me.lstChoices.Size = New System.Drawing.Size(123, 108)
        Me.lstChoices.TabIndex = 1
        '
        'lblChoicePrompt
        '
        Me.lblChoicePrompt.AutoSize = True
        Me.lblChoicePrompt.Location = New System.Drawing.Point(12, 43)
        Me.lblChoicePrompt.Name = "lblChoicePrompt"
        Me.lblChoicePrompt.Size = New System.Drawing.Size(85, 13)
        Me.lblChoicePrompt.TabIndex = 2
        Me.lblChoicePrompt.Text = "Today's Choices"
        '
        'cboDrinks
        '
        Me.cboDrinks.FormattingEnabled = True
        Me.cboDrinks.Items.AddRange(New Object() {"Sprite", "Coke", "Sundrop", "Unsweet Tea", "Sweet Tea", "Lemonade"})
        Me.cboDrinks.Location = New System.Drawing.Point(156, 59)
        Me.cboDrinks.Name = "cboDrinks"
        Me.cboDrinks.Size = New System.Drawing.Size(116, 21)
        Me.cboDrinks.TabIndex = 3
        '
        'lblDrinkPrompt
        '
        Me.lblDrinkPrompt.AutoSize = True
        Me.lblDrinkPrompt.Location = New System.Drawing.Point(169, 43)
        Me.lblDrinkPrompt.Name = "lblDrinkPrompt"
        Me.lblDrinkPrompt.Size = New System.Drawing.Size(37, 13)
        Me.lblDrinkPrompt.TabIndex = 4
        Me.lblDrinkPrompt.Text = "Drinks"
        '
        'cboSize
        '
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(156, 108)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(116, 21)
        Me.cboSize.TabIndex = 5
        '
        'lblSizePrompt
        '
        Me.lblSizePrompt.AutoSize = True
        Me.lblSizePrompt.Location = New System.Drawing.Point(169, 92)
        Me.lblSizePrompt.Name = "lblSizePrompt"
        Me.lblSizePrompt.Size = New System.Drawing.Size(55, 13)
        Me.lblSizePrompt.TabIndex = 6
        Me.lblSizePrompt.Text = "Drink Size"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(156, 148)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 27)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(19, 187)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(252, 64)
        Me.lblDisplay.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSizePrompt)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.lblDrinkPrompt)
        Me.Controls.Add(Me.cboDrinks)
        Me.Controls.Add(Me.lblChoicePrompt)
        Me.Controls.Add(Me.lstChoices)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "LunchTime"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstChoices As System.Windows.Forms.ListBox
    Friend WithEvents lblChoicePrompt As System.Windows.Forms.Label
    Friend WithEvents cboDrinks As System.Windows.Forms.ComboBox
    Friend WithEvents lblDrinkPrompt As System.Windows.Forms.Label
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents lblSizePrompt As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
