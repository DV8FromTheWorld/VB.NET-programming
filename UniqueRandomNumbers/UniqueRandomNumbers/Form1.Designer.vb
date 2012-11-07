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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblLoopCounterDisplay = New System.Windows.Forms.Label()
        Me.lblNumberGeneratedDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(53, 136)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(128, 23)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblLoopCounterDisplay
        '
        Me.lblLoopCounterDisplay.Location = New System.Drawing.Point(50, 92)
        Me.lblLoopCounterDisplay.Name = "lblLoopCounterDisplay"
        Me.lblLoopCounterDisplay.Size = New System.Drawing.Size(222, 23)
        Me.lblLoopCounterDisplay.TabIndex = 4
        '
        'lblNumberGeneratedDisplay
        '
        Me.lblNumberGeneratedDisplay.Location = New System.Drawing.Point(110, 41)
        Me.lblNumberGeneratedDisplay.Name = "lblNumberGeneratedDisplay"
        Me.lblNumberGeneratedDisplay.Size = New System.Drawing.Size(124, 27)
        Me.lblNumberGeneratedDisplay.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblLoopCounterDisplay)
        Me.Controls.Add(Me.lblNumberGeneratedDisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblLoopCounterDisplay As System.Windows.Forms.Label
    Friend WithEvents lblNumberGeneratedDisplay As System.Windows.Forms.Label

End Class
