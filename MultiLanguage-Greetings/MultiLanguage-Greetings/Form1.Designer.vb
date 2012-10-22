<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class baseGUI
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
        Me.btnHello = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.grpChoices = New System.Windows.Forms.GroupBox()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.grpChoices2 = New System.Windows.Forms.GroupBox()
        Me.chkGerman = New System.Windows.Forms.CheckBox()
        Me.chkFrench = New System.Windows.Forms.CheckBox()
        Me.chkEnglish = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radGoodbye = New System.Windows.Forms.RadioButton()
        Me.radHello = New System.Windows.Forms.RadioButton()
        Me.grpChoices.SuspendLayout()
        Me.grpChoices2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(309, 38)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(107, 50)
        Me.btnHello.TabIndex = 0
        Me.btnHello.Text = "Greetings"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AllowDrop = True
        Me.lblMessage.Location = New System.Drawing.Point(260, 299)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(205, 113)
        Me.lblMessage.TabIndex = 1
        '
        'grpChoices
        '
        Me.grpChoices.Controls.Add(Me.radGerman)
        Me.grpChoices.Controls.Add(Me.radFrench)
        Me.grpChoices.Controls.Add(Me.radEnglish)
        Me.grpChoices.Location = New System.Drawing.Point(102, 181)
        Me.grpChoices.Name = "grpChoices"
        Me.grpChoices.Size = New System.Drawing.Size(200, 100)
        Me.grpChoices.TabIndex = 2
        Me.grpChoices.TabStop = False
        Me.grpChoices.Text = "Language Hello"
        '
        'radGerman
        '
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(16, 68)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(62, 17)
        Me.radGerman.TabIndex = 2
        Me.radGerman.TabStop = True
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(16, 44)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 1
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(16, 20)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 0
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'grpChoices2
        '
        Me.grpChoices2.Controls.Add(Me.chkGerman)
        Me.grpChoices2.Controls.Add(Me.chkFrench)
        Me.grpChoices2.Controls.Add(Me.chkEnglish)
        Me.grpChoices2.Location = New System.Drawing.Point(425, 181)
        Me.grpChoices2.Name = "grpChoices2"
        Me.grpChoices2.Size = New System.Drawing.Size(200, 100)
        Me.grpChoices2.TabIndex = 3
        Me.grpChoices2.TabStop = False
        Me.grpChoices2.Text = "Language Goodbye"
        '
        'chkGerman
        '
        Me.chkGerman.AutoSize = True
        Me.chkGerman.Location = New System.Drawing.Point(24, 68)
        Me.chkGerman.Name = "chkGerman"
        Me.chkGerman.Size = New System.Drawing.Size(63, 17)
        Me.chkGerman.TabIndex = 2
        Me.chkGerman.Text = "German"
        Me.chkGerman.UseVisualStyleBackColor = True
        '
        'chkFrench
        '
        Me.chkFrench.AutoSize = True
        Me.chkFrench.Location = New System.Drawing.Point(24, 44)
        Me.chkFrench.Name = "chkFrench"
        Me.chkFrench.Size = New System.Drawing.Size(59, 17)
        Me.chkFrench.TabIndex = 1
        Me.chkFrench.Text = "French"
        Me.chkFrench.UseVisualStyleBackColor = True
        '
        'chkEnglish
        '
        Me.chkEnglish.AutoSize = True
        Me.chkEnglish.Location = New System.Drawing.Point(24, 25)
        Me.chkEnglish.Name = "chkEnglish"
        Me.chkEnglish.Size = New System.Drawing.Size(60, 17)
        Me.chkEnglish.TabIndex = 0
        Me.chkEnglish.Text = "English"
        Me.chkEnglish.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radGoodbye)
        Me.GroupBox1.Controls.Add(Me.radHello)
        Me.GroupBox1.Location = New System.Drawing.Point(293, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 72)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a greeting type"
        '
        'radGoodbye
        '
        Me.radGoodbye.AutoSize = True
        Me.radGoodbye.Location = New System.Drawing.Point(16, 44)
        Me.radGoodbye.Name = "radGoodbye"
        Me.radGoodbye.Size = New System.Drawing.Size(119, 17)
        Me.radGoodbye.TabIndex = 1
        Me.radGoodbye.TabStop = True
        Me.radGoodbye.Text = "Language Goodbye"
        Me.radGoodbye.UseVisualStyleBackColor = True
        '
        'radHello
        '
        Me.radHello.AutoSize = True
        Me.radHello.Location = New System.Drawing.Point(16, 21)
        Me.radHello.Name = "radHello"
        Me.radHello.Size = New System.Drawing.Size(100, 17)
        Me.radHello.TabIndex = 0
        Me.radHello.TabStop = True
        Me.radHello.Text = "Language Hello"
        Me.radHello.UseVisualStyleBackColor = True
        '
        'baseGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpChoices2)
        Me.Controls.Add(Me.grpChoices)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnHello)
        Me.Name = "baseGUI"
        Me.Text = "Multi-Language Greetings"
        Me.grpChoices.ResumeLayout(False)
        Me.grpChoices.PerformLayout()
        Me.grpChoices2.ResumeLayout(False)
        Me.grpChoices2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHello As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents grpChoices As System.Windows.Forms.GroupBox

    Private Sub GroupBox1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpChoices.Enter

    End Sub
    Friend WithEvents radGerman As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents grpChoices2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGerman As System.Windows.Forms.CheckBox
    Friend WithEvents chkFrench As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radGoodbye As System.Windows.Forms.RadioButton
    Friend WithEvents radHello As System.Windows.Forms.RadioButton
End Class
