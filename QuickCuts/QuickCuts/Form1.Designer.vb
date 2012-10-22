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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkHairCut = New System.Windows.Forms.CheckBox()
        Me.chkShampoo = New System.Windows.Forms.CheckBox()
        Me.chkStyle = New System.Windows.Forms.CheckBox()
        Me.chkMassage = New System.Windows.Forms.CheckBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkMassage)
        Me.GroupBox1.Controls.Add(Me.chkStyle)
        Me.GroupBox1.Controls.Add(Me.chkShampoo)
        Me.GroupBox1.Controls.Add(Me.chkHairCut)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose Your Options"
        '
        'chkHairCut
        '
        Me.chkHairCut.AutoSize = True
        Me.chkHairCut.Location = New System.Drawing.Point(26, 20)
        Me.chkHairCut.Name = "chkHairCut"
        Me.chkHairCut.Size = New System.Drawing.Size(91, 17)
        Me.chkHairCut.TabIndex = 0
        Me.chkHairCut.Text = "HairCut $9.95"
        Me.chkHairCut.UseVisualStyleBackColor = True
        '
        'chkShampoo
        '
        Me.chkShampoo.AutoSize = True
        Me.chkShampoo.Location = New System.Drawing.Point(26, 43)
        Me.chkShampoo.Name = "chkShampoo"
        Me.chkShampoo.Size = New System.Drawing.Size(101, 17)
        Me.chkShampoo.TabIndex = 1
        Me.chkShampoo.Text = "Shampoo $3.95"
        Me.chkShampoo.UseVisualStyleBackColor = True
        '
        'chkStyle
        '
        Me.chkStyle.AutoSize = True
        Me.chkStyle.Location = New System.Drawing.Point(26, 66)
        Me.chkStyle.Name = "chkStyle"
        Me.chkStyle.Size = New System.Drawing.Size(79, 17)
        Me.chkStyle.TabIndex = 2
        Me.chkStyle.Text = "Style $5.95"
        Me.chkStyle.UseVisualStyleBackColor = True
        '
        'chkMassage
        '
        Me.chkMassage.AutoSize = True
        Me.chkMassage.Location = New System.Drawing.Point(26, 89)
        Me.chkMassage.Name = "chkMassage"
        Me.chkMassage.Size = New System.Drawing.Size(128, 17)
        Me.chkMassage.TabIndex = 3
        Me.chkMassage.Text = "Neck Massage $2.95"
        Me.chkMassage.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(37, 159)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(199, 48)
        Me.lblDisplay.TabIndex = 1
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(34, 229)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(202, 30)
        Me.btnTotal.TabIndex = 2
        Me.btnTotal.Text = "Total Cost"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 262)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Quick Cuts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMassage As System.Windows.Forms.CheckBox
    Friend WithEvents chkStyle As System.Windows.Forms.CheckBox
    Friend WithEvents chkShampoo As System.Windows.Forms.CheckBox
    Friend WithEvents chkHairCut As System.Windows.Forms.CheckBox
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button

End Class
