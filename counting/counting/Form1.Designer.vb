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
        Me.btnDimVariable = New System.Windows.Forms.Button()
        Me.btnStaticVariable = New System.Windows.Forms.Button()
        Me.lblVariableDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDimVariable
        '
        Me.btnDimVariable.Location = New System.Drawing.Point(20, 26)
        Me.btnDimVariable.Name = "btnDimVariable"
        Me.btnDimVariable.Size = New System.Drawing.Size(114, 31)
        Me.btnDimVariable.TabIndex = 0
        Me.btnDimVariable.Text = "Dim Variable"
        Me.btnDimVariable.UseVisualStyleBackColor = True
        '
        'btnStaticVariable
        '
        Me.btnStaticVariable.Location = New System.Drawing.Point(149, 26)
        Me.btnStaticVariable.Name = "btnStaticVariable"
        Me.btnStaticVariable.Size = New System.Drawing.Size(115, 30)
        Me.btnStaticVariable.TabIndex = 1
        Me.btnStaticVariable.Text = "Static Variable"
        Me.btnStaticVariable.UseVisualStyleBackColor = True
        '
        'lblVariableDisplay
        '
        Me.lblVariableDisplay.Location = New System.Drawing.Point(23, 82)
        Me.lblVariableDisplay.Name = "lblVariableDisplay"
        Me.lblVariableDisplay.Size = New System.Drawing.Size(240, 56)
        Me.lblVariableDisplay.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 152)
        Me.Controls.Add(Me.lblVariableDisplay)
        Me.Controls.Add(Me.btnStaticVariable)
        Me.Controls.Add(Me.btnDimVariable)
        Me.Name = "Form1"
        Me.Text = "Counter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDimVariable As System.Windows.Forms.Button
    Friend WithEvents btnStaticVariable As System.Windows.Forms.Button
    Friend WithEvents lblVariableDisplay As System.Windows.Forms.Label

End Class
