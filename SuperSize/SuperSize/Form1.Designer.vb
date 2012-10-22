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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radSuperSize = New System.Windows.Forms.RadioButton()
        Me.chkHamburger = New System.Windows.Forms.CheckBox()
        Me.chkCheeseburger = New System.Windows.Forms.CheckBox()
        Me.chkFries = New System.Windows.Forms.CheckBox()
        Me.chkOnionRings = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblOrderNumber = New System.Windows.Forms.Label()
        Me.lblCostDisplay = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSuperSize)
        Me.GroupBox1.Controls.Add(Me.radRegular)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(228, 58)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOnionRings)
        Me.GroupBox2.Controls.Add(Me.chkFries)
        Me.GroupBox2.Controls.Add(Me.chkCheeseburger)
        Me.GroupBox2.Controls.Add(Me.chkHamburger)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 70)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose"
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(18, 19)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(62, 17)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radSuperSize
        '
        Me.radSuperSize.AutoSize = True
        Me.radSuperSize.Location = New System.Drawing.Point(114, 19)
        Me.radSuperSize.Name = "radSuperSize"
        Me.radSuperSize.Size = New System.Drawing.Size(73, 17)
        Me.radSuperSize.TabIndex = 1
        Me.radSuperSize.TabStop = True
        Me.radSuperSize.Text = "SuperSize"
        Me.radSuperSize.UseVisualStyleBackColor = True
        '
        'chkHamburger
        '
        Me.chkHamburger.AutoSize = True
        Me.chkHamburger.Location = New System.Drawing.Point(20, 19)
        Me.chkHamburger.Name = "chkHamburger"
        Me.chkHamburger.Size = New System.Drawing.Size(78, 17)
        Me.chkHamburger.TabIndex = 0
        Me.chkHamburger.Text = "Hamburger"
        Me.chkHamburger.UseVisualStyleBackColor = True
        '
        'chkCheeseburger
        '
        Me.chkCheeseburger.AutoSize = True
        Me.chkCheeseburger.Location = New System.Drawing.Point(20, 42)
        Me.chkCheeseburger.Name = "chkCheeseburger"
        Me.chkCheeseburger.Size = New System.Drawing.Size(92, 17)
        Me.chkCheeseburger.TabIndex = 1
        Me.chkCheeseburger.Text = "Cheeseburger"
        Me.chkCheeseburger.UseVisualStyleBackColor = True
        '
        'chkFries
        '
        Me.chkFries.AutoSize = True
        Me.chkFries.Location = New System.Drawing.Point(116, 19)
        Me.chkFries.Name = "chkFries"
        Me.chkFries.Size = New System.Drawing.Size(48, 17)
        Me.chkFries.TabIndex = 2
        Me.chkFries.Text = "Fries"
        Me.chkFries.UseVisualStyleBackColor = True
        '
        'chkOnionRings
        '
        Me.chkOnionRings.AutoSize = True
        Me.chkOnionRings.Location = New System.Drawing.Point(116, 42)
        Me.chkOnionRings.Name = "chkOnionRings"
        Me.chkOnionRings.Size = New System.Drawing.Size(84, 17)
        Me.chkOnionRings.TabIndex = 3
        Me.chkOnionRings.Text = "Onion Rings"
        Me.chkOnionRings.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(34, 164)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(123, 35)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "Place Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblOrderNumber
        '
        Me.lblOrderNumber.Location = New System.Drawing.Point(175, 166)
        Me.lblOrderNumber.Name = "lblOrderNumber"
        Me.lblOrderNumber.Size = New System.Drawing.Size(87, 32)
        Me.lblOrderNumber.TabIndex = 3
        '
        'lblCostDisplay
        '
        Me.lblCostDisplay.Location = New System.Drawing.Point(37, 213)
        Me.lblCostDisplay.Name = "lblCostDisplay"
        Me.lblCostDisplay.Size = New System.Drawing.Size(119, 36)
        Me.lblCostDisplay.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblCostDisplay)
        Me.Controls.Add(Me.lblOrderNumber)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "SuperSize"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSuperSize As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOnionRings As System.Windows.Forms.CheckBox
    Friend WithEvents chkFries As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheeseburger As System.Windows.Forms.CheckBox
    Friend WithEvents chkHamburger As System.Windows.Forms.CheckBox
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblOrderNumber As System.Windows.Forms.Label
    Friend WithEvents lblCostDisplay As System.Windows.Forms.Label

End Class
