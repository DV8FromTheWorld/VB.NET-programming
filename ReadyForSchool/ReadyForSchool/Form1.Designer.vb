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
        Me.grpMorningTasks = New System.Windows.Forms.GroupBox()
        Me.chkBrushTeeth = New System.Windows.Forms.CheckBox()
        Me.chkBreakfast = New System.Windows.Forms.CheckBox()
        Me.chkHomework = New System.Windows.Forms.CheckBox()
        Me.lblReadyMessage = New System.Windows.Forms.Label()
        Me.btnReady = New System.Windows.Forms.Button()
        Me.grpMorningTasks.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMorningTasks
        '
        Me.grpMorningTasks.Controls.Add(Me.chkBrushTeeth)
        Me.grpMorningTasks.Controls.Add(Me.chkBreakfast)
        Me.grpMorningTasks.Controls.Add(Me.chkHomework)
        Me.grpMorningTasks.Location = New System.Drawing.Point(71, 23)
        Me.grpMorningTasks.Name = "grpMorningTasks"
        Me.grpMorningTasks.Size = New System.Drawing.Size(170, 105)
        Me.grpMorningTasks.TabIndex = 0
        Me.grpMorningTasks.TabStop = False
        Me.grpMorningTasks.Text = "Morning Task"
        '
        'chkBrushTeeth
        '
        Me.chkBrushTeeth.AutoSize = True
        Me.chkBrushTeeth.Location = New System.Drawing.Point(28, 74)
        Me.chkBrushTeeth.Name = "chkBrushTeeth"
        Me.chkBrushTeeth.Size = New System.Drawing.Size(84, 17)
        Me.chkBrushTeeth.TabIndex = 2
        Me.chkBrushTeeth.Text = "Brush Teeth"
        Me.chkBrushTeeth.UseVisualStyleBackColor = True
        '
        'chkBreakfast
        '
        Me.chkBreakfast.AutoSize = True
        Me.chkBreakfast.Location = New System.Drawing.Point(28, 51)
        Me.chkBreakfast.Name = "chkBreakfast"
        Me.chkBreakfast.Size = New System.Drawing.Size(90, 17)
        Me.chkBreakfast.TabIndex = 1
        Me.chkBreakfast.Text = "Eat Breakfast"
        Me.chkBreakfast.UseVisualStyleBackColor = True
        '
        'chkHomework
        '
        Me.chkHomework.AutoSize = True
        Me.chkHomework.Location = New System.Drawing.Point(28, 28)
        Me.chkHomework.Name = "chkHomework"
        Me.chkHomework.Size = New System.Drawing.Size(106, 17)
        Me.chkHomework.TabIndex = 0
        Me.chkHomework.Text = "Homework Done"
        Me.chkHomework.UseVisualStyleBackColor = True
        '
        'lblReadyMessage
        '
        Me.lblReadyMessage.Location = New System.Drawing.Point(38, 145)
        Me.lblReadyMessage.Name = "lblReadyMessage"
        Me.lblReadyMessage.Size = New System.Drawing.Size(262, 96)
        Me.lblReadyMessage.TabIndex = 1
        '
        'btnReady
        '
        Me.btnReady.Location = New System.Drawing.Point(85, 253)
        Me.btnReady.Name = "btnReady"
        Me.btnReady.Size = New System.Drawing.Size(120, 30)
        Me.btnReady.TabIndex = 2
        Me.btnReady.Text = "Are You Ready!"
        Me.btnReady.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 306)
        Me.Controls.Add(Me.btnReady)
        Me.Controls.Add(Me.lblReadyMessage)
        Me.Controls.Add(Me.grpMorningTasks)
        Me.Name = "Form1"
        Me.Text = "Ready for School"
        Me.grpMorningTasks.ResumeLayout(False)
        Me.grpMorningTasks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMorningTasks As System.Windows.Forms.GroupBox
    Friend WithEvents chkBrushTeeth As System.Windows.Forms.CheckBox
    Friend WithEvents chkBreakfast As System.Windows.Forms.CheckBox
    Friend WithEvents chkHomework As System.Windows.Forms.CheckBox
    Friend WithEvents lblReadyMessage As System.Windows.Forms.Label
    Friend WithEvents btnReady As System.Windows.Forms.Button

End Class
