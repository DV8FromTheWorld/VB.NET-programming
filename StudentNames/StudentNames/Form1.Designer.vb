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
        Me.lstStudentNames = New System.Windows.Forms.ListBox()
        Me.btnAddNames = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstStudentNames
        '
        Me.lstStudentNames.FormattingEnabled = True
        Me.lstStudentNames.Location = New System.Drawing.Point(22, 26)
        Me.lstStudentNames.Name = "lstStudentNames"
        Me.lstStudentNames.Size = New System.Drawing.Size(145, 199)
        Me.lstStudentNames.TabIndex = 0
        '
        'btnAddNames
        '
        Me.btnAddNames.Location = New System.Drawing.Point(186, 41)
        Me.btnAddNames.Name = "btnAddNames"
        Me.btnAddNames.Size = New System.Drawing.Size(86, 35)
        Me.btnAddNames.TabIndex = 1
        Me.btnAddNames.Text = "Add Names"
        Me.btnAddNames.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnAddNames)
        Me.Controls.Add(Me.lstStudentNames)
        Me.Name = "Form1"
        Me.Text = "Student Names"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstStudentNames As System.Windows.Forms.ListBox
    Friend WithEvents btnAddNames As System.Windows.Forms.Button

End Class
