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
        Me.grpDoughnutType = New System.Windows.Forms.GroupBox()
        Me.radLemon = New System.Windows.Forms.RadioButton()
        Me.radBlueberry = New System.Windows.Forms.RadioButton()
        Me.radChocolate = New System.Windows.Forms.RadioButton()
        Me.radGlazed = New System.Windows.Forms.RadioButton()
        Me.lblDisplayOrder = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblAmountPrompt = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.grpDoughnutType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDoughnutType
        '
        Me.grpDoughnutType.BackColor = System.Drawing.SystemColors.Control
        Me.grpDoughnutType.Controls.Add(Me.radLemon)
        Me.grpDoughnutType.Controls.Add(Me.radBlueberry)
        Me.grpDoughnutType.Controls.Add(Me.radChocolate)
        Me.grpDoughnutType.Controls.Add(Me.radGlazed)
        Me.grpDoughnutType.Location = New System.Drawing.Point(40, 45)
        Me.grpDoughnutType.Name = "grpDoughnutType"
        Me.grpDoughnutType.Size = New System.Drawing.Size(242, 93)
        Me.grpDoughnutType.TabIndex = 0
        Me.grpDoughnutType.TabStop = False
        Me.grpDoughnutType.Text = "Types of Doughnuts"
        '
        'radLemon
        '
        Me.radLemon.AutoSize = True
        Me.radLemon.Location = New System.Drawing.Point(124, 51)
        Me.radLemon.Name = "radLemon"
        Me.radLemon.Size = New System.Drawing.Size(81, 17)
        Me.radLemon.TabIndex = 3
        Me.radLemon.Text = "Lemon $.60"
        Me.radLemon.UseVisualStyleBackColor = True
        '
        'radBlueberry
        '
        Me.radBlueberry.AutoSize = True
        Me.radBlueberry.Location = New System.Drawing.Point(124, 28)
        Me.radBlueberry.Name = "radBlueberry"
        Me.radBlueberry.Size = New System.Drawing.Size(93, 17)
        Me.radBlueberry.TabIndex = 2
        Me.radBlueberry.Text = "Blueberry $.75"
        Me.radBlueberry.UseVisualStyleBackColor = True
        '
        'radChocolate
        '
        Me.radChocolate.AutoSize = True
        Me.radChocolate.Location = New System.Drawing.Point(21, 51)
        Me.radChocolate.Name = "radChocolate"
        Me.radChocolate.Size = New System.Drawing.Size(97, 17)
        Me.radChocolate.TabIndex = 1
        Me.radChocolate.Text = "Chocolate $.65"
        Me.radChocolate.UseVisualStyleBackColor = True
        '
        'radGlazed
        '
        Me.radGlazed.AutoSize = True
        Me.radGlazed.Location = New System.Drawing.Point(21, 28)
        Me.radGlazed.Name = "radGlazed"
        Me.radGlazed.Size = New System.Drawing.Size(82, 17)
        Me.radGlazed.TabIndex = 0
        Me.radGlazed.Text = "Glazed $.50"
        Me.radGlazed.UseVisualStyleBackColor = True
        '
        'lblDisplayOrder
        '
        Me.lblDisplayOrder.Location = New System.Drawing.Point(40, 141)
        Me.lblDisplayOrder.Name = "lblDisplayOrder"
        Me.lblDisplayOrder.Size = New System.Drawing.Size(242, 72)
        Me.lblDisplayOrder.TabIndex = 1
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(87, 216)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(137, 38)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "Submit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblAmountPrompt
        '
        Me.lblAmountPrompt.Location = New System.Drawing.Point(24, 8)
        Me.lblAmountPrompt.Name = "lblAmountPrompt"
        Me.lblAmountPrompt.Size = New System.Drawing.Size(210, 26)
        Me.lblAmountPrompt.TabIndex = 3
        Me.lblAmountPrompt.Text = "How many doughnuts would you like?"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(225, 8)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(57, 20)
        Me.txtAmount.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 266)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmountPrompt)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblDisplayOrder)
        Me.Controls.Add(Me.grpDoughnutType)
        Me.Name = "Form1"
        Me.Text = "Doughnut Order"
        Me.grpDoughnutType.ResumeLayout(False)
        Me.grpDoughnutType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpDoughnutType As System.Windows.Forms.GroupBox
    Friend WithEvents radLemon As System.Windows.Forms.RadioButton
    Friend WithEvents radBlueberry As System.Windows.Forms.RadioButton
    Friend WithEvents radChocolate As System.Windows.Forms.RadioButton
    Friend WithEvents radGlazed As System.Windows.Forms.RadioButton
    Friend WithEvents lblDisplayOrder As System.Windows.Forms.Label
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents lblAmountPrompt As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox

End Class
