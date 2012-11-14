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
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.lblAverageDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(64, 31)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(167, 50)
        Me.btnAverage.TabIndex = 0
        Me.btnAverage.Text = "Calculate Your Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'lblAverageDisplay
        '
        Me.lblAverageDisplay.Location = New System.Drawing.Point(12, 102)
        Me.lblAverageDisplay.Name = "lblAverageDisplay"
        Me.lblAverageDisplay.Size = New System.Drawing.Size(260, 141)
        Me.lblAverageDisplay.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblAverageDisplay)
        Me.Controls.Add(Me.btnAverage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents lblAverageDisplay As System.Windows.Forms.Label

End Class
