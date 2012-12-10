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
        Me.btnEnterFoods = New System.Windows.Forms.Button()
        Me.btnShowFoods = New System.Windows.Forms.Button()
        Me.lstFoodDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnEnterFoods
        '
        Me.btnEnterFoods.Location = New System.Drawing.Point(28, 12)
        Me.btnEnterFoods.Name = "btnEnterFoods"
        Me.btnEnterFoods.Size = New System.Drawing.Size(226, 31)
        Me.btnEnterFoods.TabIndex = 0
        Me.btnEnterFoods.Text = "Enter Your Favorite Foods"
        Me.btnEnterFoods.UseVisualStyleBackColor = True
        '
        'btnShowFoods
        '
        Me.btnShowFoods.Location = New System.Drawing.Point(28, 59)
        Me.btnShowFoods.Name = "btnShowFoods"
        Me.btnShowFoods.Size = New System.Drawing.Size(226, 31)
        Me.btnShowFoods.TabIndex = 1
        Me.btnShowFoods.Text = "Display Your Favorite Foods"
        Me.btnShowFoods.UseVisualStyleBackColor = True
        '
        'lstFoodDisplay
        '
        Me.lstFoodDisplay.FormattingEnabled = True
        Me.lstFoodDisplay.Location = New System.Drawing.Point(32, 114)
        Me.lstFoodDisplay.Name = "lstFoodDisplay"
        Me.lstFoodDisplay.Size = New System.Drawing.Size(221, 108)
        Me.lstFoodDisplay.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstFoodDisplay)
        Me.Controls.Add(Me.btnShowFoods)
        Me.Controls.Add(Me.btnEnterFoods)
        Me.Name = "Form1"
        Me.Text = "My Favorite Foods"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterFoods As System.Windows.Forms.Button
    Friend WithEvents btnShowFoods As System.Windows.Forms.Button
    Friend WithEvents lstFoodDisplay As System.Windows.Forms.ListBox

End Class
