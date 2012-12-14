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
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.btnConcat = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnIndexOf = New System.Windows.Forms.Button()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.btnToLower = New System.Windows.Forms.Button()
        Me.btnToUpper = New System.Windows.Forms.Button()
        Me.btnTrim = New System.Windows.Forms.Button()
        Me.txtString1 = New System.Windows.Forms.TextBox()
        Me.txtString2 = New System.Windows.Forms.TextBox()
        Me.btnTrimEnd = New System.Windows.Forms.Button()
        Me.btwInsert = New System.Windows.Forms.Button()
        Me.btnTrimStart = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Location = New System.Drawing.Point(12, 12)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(74, 13)
        Me.lblPrompt1.TabIndex = 0
        Me.lblPrompt1.Text = "Enter a String:"
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Location = New System.Drawing.Point(12, 34)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(74, 13)
        Me.lblPrompt2.TabIndex = 1
        Me.lblPrompt2.Text = "Enter a String:"
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(11, 64)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 3
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'btnConcat
        '
        Me.btnConcat.Location = New System.Drawing.Point(11, 93)
        Me.btnConcat.Name = "btnConcat"
        Me.btnConcat.Size = New System.Drawing.Size(75, 23)
        Me.btnConcat.TabIndex = 4
        Me.btnConcat.Text = "Concat"
        Me.btnConcat.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(11, 122)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(75, 23)
        Me.btnEquals.TabIndex = 5
        Me.btnEquals.Text = "Equals"
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnIndexOf
        '
        Me.btnIndexOf.Location = New System.Drawing.Point(11, 151)
        Me.btnIndexOf.Name = "btnIndexOf"
        Me.btnIndexOf.Size = New System.Drawing.Size(75, 23)
        Me.btnIndexOf.TabIndex = 6
        Me.btnIndexOf.Text = "IndexOf"
        Me.btnIndexOf.UseVisualStyleBackColor = True
        '
        'btnReplace
        '
        Me.btnReplace.Location = New System.Drawing.Point(104, 64)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 7
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'btnToLower
        '
        Me.btnToLower.Location = New System.Drawing.Point(104, 93)
        Me.btnToLower.Name = "btnToLower"
        Me.btnToLower.Size = New System.Drawing.Size(75, 23)
        Me.btnToLower.TabIndex = 8
        Me.btnToLower.Text = "ToLower"
        Me.btnToLower.UseVisualStyleBackColor = True
        '
        'btnToUpper
        '
        Me.btnToUpper.Location = New System.Drawing.Point(104, 122)
        Me.btnToUpper.Name = "btnToUpper"
        Me.btnToUpper.Size = New System.Drawing.Size(75, 23)
        Me.btnToUpper.TabIndex = 9
        Me.btnToUpper.Text = "ToUpper"
        Me.btnToUpper.UseVisualStyleBackColor = True
        '
        'btnTrim
        '
        Me.btnTrim.Location = New System.Drawing.Point(104, 151)
        Me.btnTrim.Name = "btnTrim"
        Me.btnTrim.Size = New System.Drawing.Size(75, 23)
        Me.btnTrim.TabIndex = 10
        Me.btnTrim.Text = "Trim"
        Me.btnTrim.UseVisualStyleBackColor = True
        '
        'txtString1
        '
        Me.txtString1.Location = New System.Drawing.Point(92, 9)
        Me.txtString1.Name = "txtString1"
        Me.txtString1.Size = New System.Drawing.Size(87, 20)
        Me.txtString1.TabIndex = 11
        '
        'txtString2
        '
        Me.txtString2.Location = New System.Drawing.Point(92, 31)
        Me.txtString2.Name = "txtString2"
        Me.txtString2.Size = New System.Drawing.Size(87, 20)
        Me.txtString2.TabIndex = 12
        '
        'btnTrimEnd
        '
        Me.btnTrimEnd.Location = New System.Drawing.Point(104, 180)
        Me.btnTrimEnd.Name = "btnTrimEnd"
        Me.btnTrimEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnTrimEnd.TabIndex = 14
        Me.btnTrimEnd.Text = "TrimEnd"
        Me.btnTrimEnd.UseVisualStyleBackColor = True
        '
        'btwInsert
        '
        Me.btwInsert.Location = New System.Drawing.Point(11, 180)
        Me.btwInsert.Name = "btwInsert"
        Me.btwInsert.Size = New System.Drawing.Size(75, 23)
        Me.btwInsert.TabIndex = 13
        Me.btwInsert.Text = "Insert"
        Me.btwInsert.UseVisualStyleBackColor = True
        '
        'btnTrimStart
        '
        Me.btnTrimStart.Location = New System.Drawing.Point(104, 209)
        Me.btnTrimStart.Name = "btnTrimStart"
        Me.btnTrimStart.Size = New System.Drawing.Size(75, 23)
        Me.btnTrimStart.TabIndex = 16
        Me.btnTrimStart.Text = "TrimStart"
        Me.btnTrimStart.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 209)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(12, 247)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(170, 47)
        Me.lblDisplay.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 303)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnTrimStart)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnTrimEnd)
        Me.Controls.Add(Me.btwInsert)
        Me.Controls.Add(Me.txtString2)
        Me.Controls.Add(Me.txtString1)
        Me.Controls.Add(Me.btnTrim)
        Me.Controls.Add(Me.btnToUpper)
        Me.Controls.Add(Me.btnToLower)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.btnIndexOf)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnConcat)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Name = "Form1"
        Me.Text = "String Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt1 As System.Windows.Forms.Label
    Friend WithEvents lblPrompt2 As System.Windows.Forms.Label
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Friend WithEvents btnConcat As System.Windows.Forms.Button
    Friend WithEvents btnEquals As System.Windows.Forms.Button
    Friend WithEvents btnIndexOf As System.Windows.Forms.Button
    Friend WithEvents btnReplace As System.Windows.Forms.Button
    Friend WithEvents btnToLower As System.Windows.Forms.Button
    Friend WithEvents btnToUpper As System.Windows.Forms.Button
    Friend WithEvents btnTrim As System.Windows.Forms.Button
    Friend WithEvents txtString1 As System.Windows.Forms.TextBox
    Friend WithEvents txtString2 As System.Windows.Forms.TextBox
    Friend WithEvents btnTrimEnd As System.Windows.Forms.Button
    Friend WithEvents btwInsert As System.Windows.Forms.Button
    Friend WithEvents btnTrimStart As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents lblDisplay As System.Windows.Forms.Label

End Class
