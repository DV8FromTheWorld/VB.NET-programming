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
        Me.lblRadiusPrompt = New System.Windows.Forms.Label()
        Me.txtRadiusInput = New System.Windows.Forms.TextBox()
        Me.btnCalculateArea = New System.Windows.Forms.Button()
        Me.lblAreaDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRadiusPrompt
        '
        Me.lblRadiusPrompt.Location = New System.Drawing.Point(12, 27)
        Me.lblRadiusPrompt.Name = "lblRadiusPrompt"
        Me.lblRadiusPrompt.Size = New System.Drawing.Size(128, 22)
        Me.lblRadiusPrompt.TabIndex = 0
        Me.lblRadiusPrompt.Text = "Enter circle radius:"
        '
        'txtRadiusInput
        '
        Me.txtRadiusInput.Location = New System.Drawing.Point(118, 24)
        Me.txtRadiusInput.Name = "txtRadiusInput"
        Me.txtRadiusInput.Size = New System.Drawing.Size(64, 20)
        Me.txtRadiusInput.TabIndex = 1
        '
        'btnCalculateArea
        '
        Me.btnCalculateArea.Location = New System.Drawing.Point(50, 118)
        Me.btnCalculateArea.Name = "btnCalculateArea"
        Me.btnCalculateArea.Size = New System.Drawing.Size(100, 33)
        Me.btnCalculateArea.TabIndex = 2
        Me.btnCalculateArea.Text = "Calculate Area"
        Me.btnCalculateArea.UseVisualStyleBackColor = True
        '
        'lblAreaDisplay
        '
        Me.lblAreaDisplay.Location = New System.Drawing.Point(12, 67)
        Me.lblAreaDisplay.Name = "lblAreaDisplay"
        Me.lblAreaDisplay.Size = New System.Drawing.Size(189, 48)
        Me.lblAreaDisplay.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 172)
        Me.Controls.Add(Me.lblAreaDisplay)
        Me.Controls.Add(Me.btnCalculateArea)
        Me.Controls.Add(Me.txtRadiusInput)
        Me.Controls.Add(Me.lblRadiusPrompt)
        Me.Name = "Form1"
        Me.Text = "Area of a Circle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRadiusPrompt As System.Windows.Forms.Label
    Friend WithEvents txtRadiusInput As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculateArea As System.Windows.Forms.Button
    Friend WithEvents lblAreaDisplay As System.Windows.Forms.Label

End Class
