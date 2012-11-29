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
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.lblPrompt3 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtCandy = New System.Windows.Forms.TextBox()
        Me.txtOunces = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(12, 22)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(125, 13)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "Enter your favorite candy"
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 47)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(152, 13)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "Enter number of ounces to buy"
        '
        'lblPrompt3
        '
        Me.lblPrompt3.AutoSize = True
        Me.lblPrompt3.Location = New System.Drawing.Point(12, 73)
        Me.lblPrompt3.Name = "lblPrompt3"
        Me.lblPrompt3.Size = New System.Drawing.Size(127, 13)
        Me.lblPrompt3.TabIndex = 2
        Me.lblPrompt3.Text = "Enter the price per ounce"
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(52, 141)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(177, 93)
        Me.lblDisplay.TabIndex = 3
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(99, 106)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(96, 23)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Calculate Cost"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtCandy
        '
        Me.txtCandy.Location = New System.Drawing.Point(188, 19)
        Me.txtCandy.Name = "txtCandy"
        Me.txtCandy.Size = New System.Drawing.Size(52, 20)
        Me.txtCandy.TabIndex = 5
        '
        'txtOunces
        '
        Me.txtOunces.Location = New System.Drawing.Point(188, 44)
        Me.txtOunces.Name = "txtOunces"
        Me.txtOunces.Size = New System.Drawing.Size(52, 20)
        Me.txtOunces.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(188, 70)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(52, 20)
        Me.txtPrice.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtOunces)
        Me.Controls.Add(Me.txtCandy)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblPrompt3)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "Form1"
        Me.Text = "Candy Store"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt3 As System.Windows.Forms.Label
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents txtCandy As System.Windows.Forms.TextBox
    Friend WithEvents txtOunces As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox

End Class
