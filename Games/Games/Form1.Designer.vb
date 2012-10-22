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
        Me.btnGame1 = New System.Windows.Forms.Button()
        Me.btnGame2 = New System.Windows.Forms.Button()
        Me.btnGame3 = New System.Windows.Forms.Button()
        Me.btnGame4 = New System.Windows.Forms.Button()
        Me.lblGameInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGame1
        '
        Me.btnGame1.Location = New System.Drawing.Point(149, 30)
        Me.btnGame1.Name = "btnGame1"
        Me.btnGame1.Size = New System.Drawing.Size(103, 29)
        Me.btnGame1.TabIndex = 0
        Me.btnGame1.Text = "Halo"
        Me.btnGame1.UseVisualStyleBackColor = True
        '
        'btnGame2
        '
        Me.btnGame2.Location = New System.Drawing.Point(303, 31)
        Me.btnGame2.Name = "btnGame2"
        Me.btnGame2.Size = New System.Drawing.Size(109, 28)
        Me.btnGame2.TabIndex = 1
        Me.btnGame2.Text = "Battlefield 3"
        Me.btnGame2.UseVisualStyleBackColor = True
        '
        'btnGame3
        '
        Me.btnGame3.Location = New System.Drawing.Point(149, 94)
        Me.btnGame3.Name = "btnGame3"
        Me.btnGame3.Size = New System.Drawing.Size(101, 29)
        Me.btnGame3.TabIndex = 2
        Me.btnGame3.Text = "Call of Duty"
        Me.btnGame3.UseVisualStyleBackColor = True
        '
        'btnGame4
        '
        Me.btnGame4.Location = New System.Drawing.Point(304, 95)
        Me.btnGame4.Name = "btnGame4"
        Me.btnGame4.Size = New System.Drawing.Size(108, 28)
        Me.btnGame4.TabIndex = 3
        Me.btnGame4.Text = "Team Fortress 2"
        Me.btnGame4.UseVisualStyleBackColor = True
        '
        'lblGameInfo
        '
        Me.lblGameInfo.Location = New System.Drawing.Point(55, 170)
        Me.lblGameInfo.Name = "lblGameInfo"
        Me.lblGameInfo.Size = New System.Drawing.Size(514, 136)
        Me.lblGameInfo.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 347)
        Me.Controls.Add(Me.lblGameInfo)
        Me.Controls.Add(Me.btnGame4)
        Me.Controls.Add(Me.btnGame3)
        Me.Controls.Add(Me.btnGame2)
        Me.Controls.Add(Me.btnGame1)
        Me.Name = "Form1"
        Me.Text = "Video Games"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGame1 As System.Windows.Forms.Button
    Friend WithEvents btnGame2 As System.Windows.Forms.Button
    Friend WithEvents btnGame3 As System.Windows.Forms.Button
    Friend WithEvents btnGame4 As System.Windows.Forms.Button
    Friend WithEvents lblGameInfo As System.Windows.Forms.Label

End Class
