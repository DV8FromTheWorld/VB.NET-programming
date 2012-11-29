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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEntered = New System.Windows.Forms.TextBox()
        Me.btnMultiples = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number:"
        '
        'txtEntered
        '
        Me.txtEntered.Location = New System.Drawing.Point(167, 27)
        Me.txtEntered.Name = "txtEntered"
        Me.txtEntered.Size = New System.Drawing.Size(55, 20)
        Me.txtEntered.TabIndex = 1
        '
        'btnMultiples
        '
        Me.btnMultiples.Location = New System.Drawing.Point(94, 63)
        Me.btnMultiples.Name = "btnMultiples"
        Me.btnMultiples.Size = New System.Drawing.Size(101, 23)
        Me.btnMultiples.TabIndex = 2
        Me.btnMultiples.Text = "Show Multiples"
        Me.btnMultiples.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(54, 100)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(168, 137)
        Me.lblDisplay.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnMultiples)
        Me.Controls.Add(Me.txtEntered)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Multiples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEntered As System.Windows.Forms.TextBox
    Friend WithEvents btnMultiples As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
