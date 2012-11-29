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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtNumberEntered = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(73, 85)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(41, 24)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(82, 13)
        Me.lblPrompt.TabIndex = 1
        Me.lblPrompt.Text = "Enter a number:"
        '
        'txtNumberEntered
        '
        Me.txtNumberEntered.Location = New System.Drawing.Point(129, 24)
        Me.txtNumberEntered.Name = "txtNumberEntered"
        Me.txtNumberEntered.Size = New System.Drawing.Size(65, 20)
        Me.txtNumberEntered.TabIndex = 2
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(70, 47)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(108, 26)
        Me.lblDisplay.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 120)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtNumberEntered)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "Form1"
        Me.Text = "Times Ten"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtNumberEntered As System.Windows.Forms.TextBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
