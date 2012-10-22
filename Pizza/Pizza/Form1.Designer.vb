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
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.lblChoice1 = New System.Windows.Forms.Label()
        Me.lblChoice2 = New System.Windows.Forms.Label()
        Me.lblChoice3 = New System.Windows.Forms.Label()
        Me.grpChoices.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.chkMushrooms)
        Me.grpChoices.Controls.Add(Me.chkCheese)
        Me.grpChoices.Controls.Add(Me.chkPepperoni)
        Me.grpChoices.Location = New System.Drawing.Point(35, 36)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(142, 119)
        Me.grpChoices.TabIndex = 0
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Your Choices"
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(24, 19)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chkPepperoni.TabIndex = 0
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(24, 52)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 1
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Location = New System.Drawing.Point(24, 85)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(80, 17)
        Me.chkMushrooms.TabIndex = 2
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'lblChoice1
        '
        Me.lblChoice1.Location = New System.Drawing.Point(32, 181)
        Me.lblChoice1.Name = "lblChoice1"
        Me.lblChoice1.Size = New System.Drawing.Size(175, 18)
        Me.lblChoice1.TabIndex = 1
        '
        'lblChoice2
        '
        Me.lblChoice2.Location = New System.Drawing.Point(32, 199)
        Me.lblChoice2.Name = "lblChoice2"
        Me.lblChoice2.Size = New System.Drawing.Size(175, 23)
        Me.lblChoice2.TabIndex = 2
        '
        'lblChoice3
        '
        Me.lblChoice3.Location = New System.Drawing.Point(32, 222)
        Me.lblChoice3.Name = "lblChoice3"
        Me.lblChoice3.Size = New System.Drawing.Size(175, 22)
        Me.lblChoice3.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(219, 380)
        Me.Controls.Add(Me.lblChoice3)
        Me.Controls.Add(Me.lblChoice2)
        Me.Controls.Add(Me.lblChoice1)
        Me.Controls.Add(Me.grpChoices)
        Me.Name = "Form1"
        Me.Text = "Your Pizza"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents lblChoice1 As System.Windows.Forms.Label
    Friend WithEvents lblChoice2 As System.Windows.Forms.Label
    Friend WithEvents lblChoice3 As System.Windows.Forms.Label

End Class
