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
        Me.btnAddGPAs = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAddGPAs
        '
        Me.btnAddGPAs.Location = New System.Drawing.Point(12, 12)
        Me.btnAddGPAs.Name = "btnAddGPAs"
        Me.btnAddGPAs.Size = New System.Drawing.Size(166, 43)
        Me.btnAddGPAs.TabIndex = 0
        Me.btnAddGPAs.Text = "Add GPA's"
        Me.btnAddGPAs.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(12, 61)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(166, 121)
        Me.lstDisplay.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 194)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnAddGPAs)
        Me.Name = "Form1"
        Me.Text = "GPA Array"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddGPAs As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox

End Class
