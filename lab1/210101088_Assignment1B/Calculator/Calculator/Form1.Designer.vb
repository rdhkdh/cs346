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
        Me.display = New System.Windows.Forms.TextBox()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.dotbutton = New System.Windows.Forms.Button()
        Me.equalbutton = New System.Windows.Forms.Button()
        Me.subtractbutton = New System.Windows.Forms.Button()
        Me.multiplybutton = New System.Windows.Forms.Button()
        Me.dividebutton = New System.Windows.Forms.Button()
        Me.clearbutton = New System.Windows.Forms.Button()
        Me.signbutton = New System.Windows.Forms.Button()
        Me.backspace = New System.Windows.Forms.Button()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'display
        '
        Me.display.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.display.Location = New System.Drawing.Point(21, 22)
        Me.display.Multiline = True
        Me.display.Name = "display"
        Me.display.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.display.Size = New System.Drawing.Size(334, 87)
        Me.display.TabIndex = 1
        Me.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.ForeColor = System.Drawing.Color.White
        Me.Button0.Location = New System.Drawing.Point(21, 470)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(70, 70)
        Me.Button0.TabIndex = 10
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'dotbutton
        '
        Me.dotbutton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.dotbutton.Font = New System.Drawing.Font("Microsoft Tai Le", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dotbutton.ForeColor = System.Drawing.Color.White
        Me.dotbutton.Location = New System.Drawing.Point(111, 470)
        Me.dotbutton.Name = "dotbutton"
        Me.dotbutton.Size = New System.Drawing.Size(70, 70)
        Me.dotbutton.TabIndex = 11
        Me.dotbutton.Text = "."
        Me.dotbutton.UseVisualStyleBackColor = False
        '
        'equalbutton
        '
        Me.equalbutton.BackColor = System.Drawing.Color.Gold
        Me.equalbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.equalbutton.Location = New System.Drawing.Point(200, 470)
        Me.equalbutton.Name = "equalbutton"
        Me.equalbutton.Size = New System.Drawing.Size(155, 70)
        Me.equalbutton.TabIndex = 12
        Me.equalbutton.Text = "="
        Me.equalbutton.UseVisualStyleBackColor = False
        '
        'subtractbutton
        '
        Me.subtractbutton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.subtractbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtractbutton.ForeColor = System.Drawing.Color.White
        Me.subtractbutton.Location = New System.Drawing.Point(285, 216)
        Me.subtractbutton.Name = "subtractbutton"
        Me.subtractbutton.Size = New System.Drawing.Size(70, 70)
        Me.subtractbutton.TabIndex = 13
        Me.subtractbutton.Text = "-"
        Me.subtractbutton.UseVisualStyleBackColor = False
        '
        'multiplybutton
        '
        Me.multiplybutton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.multiplybutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplybutton.ForeColor = System.Drawing.Color.White
        Me.multiplybutton.Location = New System.Drawing.Point(285, 298)
        Me.multiplybutton.Name = "multiplybutton"
        Me.multiplybutton.Size = New System.Drawing.Size(70, 70)
        Me.multiplybutton.TabIndex = 14
        Me.multiplybutton.Text = "*"
        Me.multiplybutton.UseVisualStyleBackColor = False
        '
        'dividebutton
        '
        Me.dividebutton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.dividebutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividebutton.ForeColor = System.Drawing.Color.White
        Me.dividebutton.Location = New System.Drawing.Point(285, 383)
        Me.dividebutton.Name = "dividebutton"
        Me.dividebutton.Size = New System.Drawing.Size(70, 70)
        Me.dividebutton.TabIndex = 15
        Me.dividebutton.Text = "/"
        Me.dividebutton.UseVisualStyleBackColor = False
        '
        'clearbutton
        '
        Me.clearbutton.BackColor = System.Drawing.Color.Gold
        Me.clearbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbutton.Location = New System.Drawing.Point(21, 134)
        Me.clearbutton.Name = "clearbutton"
        Me.clearbutton.Size = New System.Drawing.Size(70, 70)
        Me.clearbutton.TabIndex = 17
        Me.clearbutton.Text = "C"
        Me.clearbutton.UseVisualStyleBackColor = False
        '
        'signbutton
        '
        Me.signbutton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.signbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signbutton.ForeColor = System.Drawing.Color.White
        Me.signbutton.Location = New System.Drawing.Point(111, 134)
        Me.signbutton.Name = "signbutton"
        Me.signbutton.Size = New System.Drawing.Size(70, 70)
        Me.signbutton.TabIndex = 18
        Me.signbutton.Text = "+/-"
        Me.signbutton.UseVisualStyleBackColor = False
        '
        'backspace
        '
        Me.backspace.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.backspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backspace.ForeColor = System.Drawing.Color.White
        Me.backspace.Location = New System.Drawing.Point(200, 134)
        Me.backspace.Name = "backspace"
        Me.backspace.Size = New System.Drawing.Size(70, 70)
        Me.backspace.TabIndex = 19
        Me.backspace.Text = "Back"
        Me.backspace.UseVisualStyleBackColor = False
        '
        'addbutton
        '
        Me.addbutton.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.addbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbutton.ForeColor = System.Drawing.Color.White
        Me.addbutton.Location = New System.Drawing.Point(285, 134)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(70, 70)
        Me.addbutton.TabIndex = 20
        Me.addbutton.Text = "+"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(21, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(111, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 70)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(200, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 70)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(21, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 70)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(111, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 70)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(200, 298)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 70)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(21, 383)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 70)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(111, 383)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 70)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(200, 383)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 70)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(375, 560)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.addbutton)
        Me.Controls.Add(Me.backspace)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.signbutton)
        Me.Controls.Add(Me.clearbutton)
        Me.Controls.Add(Me.dividebutton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.multiplybutton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.subtractbutton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.equalbutton)
        Me.Controls.Add(Me.dotbutton)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.display)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents display As System.Windows.Forms.TextBox
    Friend WithEvents Button0 As System.Windows.Forms.Button
    Friend WithEvents dotbutton As System.Windows.Forms.Button
    Friend WithEvents equalbutton As System.Windows.Forms.Button
    Friend WithEvents subtractbutton As System.Windows.Forms.Button
    Friend WithEvents multiplybutton As System.Windows.Forms.Button
    Friend WithEvents dividebutton As System.Windows.Forms.Button
    Friend WithEvents clearbutton As System.Windows.Forms.Button
    Friend WithEvents signbutton As System.Windows.Forms.Button
    Friend WithEvents backspace As System.Windows.Forms.Button
    Friend WithEvents addbutton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button

End Class
