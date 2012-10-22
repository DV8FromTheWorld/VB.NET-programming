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
        Me.lblPromt = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPromt
        '
        Me.lblPromt.Location = New System.Drawing.Point(32, 34)
        Me.lblPromt.Name = "lblPromt"
        Me.lblPromt.Size = New System.Drawing.Size(89, 24)
        Me.lblPromt.TabIndex = 0
        Me.lblPromt.Text = "Enter your name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(127, 34)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(91, 20)
        Me.txtName.TabIndex = 1
        '
        'btnHello
        '
        Me.btnHello.Location = New System.Drawing.Point(73, 177)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(145, 34)
        Me.btnHello.TabIndex = 3
        Me.btnHello.Text = "Say Hello"
        Me.btnHello.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPromt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPromt As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnHello As System.Windows.Forms.Button

End Class
