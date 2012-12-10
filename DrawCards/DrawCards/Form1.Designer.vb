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
        Me.btnDrawCards = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtDraws = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDrawCards
        '
        Me.btnDrawCards.Location = New System.Drawing.Point(28, 17)
        Me.btnDrawCards.Name = "btnDrawCards"
        Me.btnDrawCards.Size = New System.Drawing.Size(171, 25)
        Me.btnDrawCards.TabIndex = 0
        Me.btnDrawCards.Text = "Draw Cards"
        Me.btnDrawCards.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(30, 58)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(94, 13)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "How many draws?"
        '
        'txtDraws
        '
        Me.txtDraws.Location = New System.Drawing.Point(145, 55)
        Me.txtDraws.Name = "txtDraws"
        Me.txtDraws.Size = New System.Drawing.Size(54, 20)
        Me.txtDraws.TabIndex = 2
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(29, 89)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(169, 132)
        Me.lblDisplay.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 233)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtDraws)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnDrawCards)
        Me.Name = "Form1"
        Me.Text = "Draw Cards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDrawCards As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtDraws As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
