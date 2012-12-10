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
        Me.btnBirthdays = New System.Windows.Forms.Button()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnBirthdays
        '
        Me.btnBirthdays.Location = New System.Drawing.Point(31, 12)
        Me.btnBirthdays.Name = "btnBirthdays"
        Me.btnBirthdays.Size = New System.Drawing.Size(217, 46)
        Me.btnBirthdays.TabIndex = 0
        Me.btnBirthdays.Text = "Birthdays"
        Me.btnBirthdays.UseVisualStyleBackColor = True
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(35, 74)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(213, 121)
        Me.lstDisplay.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.btnBirthdays)
        Me.Name = "Form1"
        Me.Text = "Birthdays"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBirthdays As System.Windows.Forms.Button
    Friend WithEvents lstDisplay As System.Windows.Forms.ListBox

End Class
