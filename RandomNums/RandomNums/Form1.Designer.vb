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
        Me.btnGen = New System.Windows.Forms.Button()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGen
        '
        Me.btnGen.Location = New System.Drawing.Point(23, 12)
        Me.btnGen.Name = "btnGen"
        Me.btnGen.Size = New System.Drawing.Size(184, 27)
        Me.btnGen.TabIndex = 0
        Me.btnGen.Text = "Generate Numbers"
        Me.btnGen.UseVisualStyleBackColor = True
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(23, 45)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(88, 22)
        Me.btnHigh.TabIndex = 1
        Me.btnHigh.Text = "Show High"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(119, 45)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(88, 22)
        Me.btnLow.TabIndex = 2
        Me.btnLow.Text = "Show Low"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(23, 81)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(183, 134)
        Me.lstNumbers.TabIndex = 3
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(20, 229)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(186, 20)
        Me.lblDisplay.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.btnGen)
        Me.Name = "Form1"
        Me.Text = "Generate Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGen As System.Windows.Forms.Button
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents btnLow As System.Windows.Forms.Button
    Friend WithEvents lstNumbers As System.Windows.Forms.ListBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
