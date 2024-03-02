<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkedList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LinkedList))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox6 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.delete_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.new_num_tb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.update_tb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.search_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.insert_btn = New System.Windows.Forms.Button()
        Me.insert_tb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LL_panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox5 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1488, 171)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'RichTextBox7
        '
        Me.RichTextBox7.Font = New System.Drawing.Font("Jokerman", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.RichTextBox7.Location = New System.Drawing.Point(55, 46)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.Size = New System.Drawing.Size(397, 72)
        Me.RichTextBox7.TabIndex = 15
        Me.RichTextBox7.Text = " AlgorithmicAtlas"
        '
        'RichTextBox6
        '
        Me.RichTextBox6.BackColor = System.Drawing.Color.White
        Me.RichTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox6.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox6.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox6.Location = New System.Drawing.Point(55, 190)
        Me.RichTextBox6.Name = "RichTextBox6"
        Me.RichTextBox6.ReadOnly = True
        Me.RichTextBox6.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox6.TabIndex = 16
        Me.RichTextBox6.Text = "Linked List"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.Color.White
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(55, 249)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(1295, 91)
        Me.RichTextBox2.TabIndex = 17
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'RichTextBox3
        '
        Me.RichTextBox3.BackColor = System.Drawing.Color.White
        Me.RichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox3.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox3.Location = New System.Drawing.Point(55, 346)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.ReadOnly = True
        Me.RichTextBox3.Size = New System.Drawing.Size(348, 38)
        Me.RichTextBox3.TabIndex = 18
        Me.RichTextBox3.Text = "Basic Linked List Operations"
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.White
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(55, 390)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.ReadOnly = True
        Me.RichTextBox4.Size = New System.Drawing.Size(694, 145)
        Me.RichTextBox4.TabIndex = 19
        Me.RichTextBox4.Text = "We will look at some commonly used linked list operations in this tutorial:" & Global.Microsoft.VisualBasic.ChrW(10) & "1) In" & _
            "sert elements" & Global.Microsoft.VisualBasic.ChrW(10) & "2) Search elements" & Global.Microsoft.VisualBasic.ChrW(10) & "3) Update elements" & Global.Microsoft.VisualBasic.ChrW(10) & "4) Delete elements"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Plum
        Me.Panel1.Controls.Add(Me.reset)
        Me.Panel1.Controls.Add(Me.delete_btn)
        Me.Panel1.Controls.Add(Me.delete_tb)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.new_num_tb)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.update_btn)
        Me.Panel1.Controls.Add(Me.update_tb)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.search_btn)
        Me.Panel1.Controls.Add(Me.search_tb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.insert_btn)
        Me.Panel1.Controls.Add(Me.insert_tb)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LL_panel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(55, 541)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 400)
        Me.Panel1.TabIndex = 20
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.delete_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.Location = New System.Drawing.Point(345, 290)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(62, 34)
        Me.delete_btn.TabIndex = 33
        Me.delete_btn.Text = "Go"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'delete_tb
        '
        Me.delete_tb.BackColor = System.Drawing.Color.White
        Me.delete_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.delete_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_tb.Location = New System.Drawing.Point(185, 291)
        Me.delete_tb.Multiline = True
        Me.delete_tb.Name = "delete_tb"
        Me.delete_tb.Size = New System.Drawing.Size(123, 33)
        Me.delete_tb.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 23)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Delete element:"
        '
        'new_num_tb
        '
        Me.new_num_tb.BackColor = System.Drawing.Color.White
        Me.new_num_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.new_num_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_num_tb.Location = New System.Drawing.Point(524, 233)
        Me.new_num_tb.Multiline = True
        Me.new_num_tb.Name = "new_num_tb"
        Me.new_num_tb.Size = New System.Drawing.Size(123, 33)
        Me.new_num_tb.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(343, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 23)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "With new element:"
        '
        'update_btn
        '
        Me.update_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.update_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.White
        Me.update_btn.Location = New System.Drawing.Point(667, 233)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(62, 34)
        Me.update_btn.TabIndex = 28
        Me.update_btn.Text = "Go"
        Me.update_btn.UseVisualStyleBackColor = False
        '
        'update_tb
        '
        Me.update_tb.BackColor = System.Drawing.Color.White
        Me.update_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.update_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_tb.Location = New System.Drawing.Point(187, 232)
        Me.update_tb.Multiline = True
        Me.update_tb.Name = "update_tb"
        Me.update_tb.Size = New System.Drawing.Size(123, 33)
        Me.update_tb.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Update element:"
        '
        'search_btn
        '
        Me.search_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.search_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_btn.ForeColor = System.Drawing.Color.White
        Me.search_btn.Location = New System.Drawing.Point(345, 177)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(62, 34)
        Me.search_btn.TabIndex = 25
        Me.search_btn.Text = "Go"
        Me.search_btn.UseVisualStyleBackColor = False
        '
        'search_tb
        '
        Me.search_tb.BackColor = System.Drawing.Color.White
        Me.search_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.search_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_tb.Location = New System.Drawing.Point(185, 179)
        Me.search_tb.Multiline = True
        Me.search_tb.Name = "search_tb"
        Me.search_tb.Size = New System.Drawing.Size(123, 32)
        Me.search_tb.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Search element:"
        '
        'insert_btn
        '
        Me.insert_btn.BackColor = System.Drawing.Color.DodgerBlue
        Me.insert_btn.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_btn.ForeColor = System.Drawing.Color.White
        Me.insert_btn.Location = New System.Drawing.Point(345, 126)
        Me.insert_btn.Name = "insert_btn"
        Me.insert_btn.Size = New System.Drawing.Size(62, 34)
        Me.insert_btn.TabIndex = 22
        Me.insert_btn.Text = "Go"
        Me.insert_btn.UseVisualStyleBackColor = False
        '
        'insert_tb
        '
        Me.insert_tb.BackColor = System.Drawing.Color.White
        Me.insert_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.insert_tb.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert_tb.Location = New System.Drawing.Point(185, 126)
        Me.insert_tb.Multiline = True
        Me.insert_tb.Name = "insert_tb"
        Me.insert_tb.Size = New System.Drawing.Size(123, 32)
        Me.insert_tb.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Insert element:"
        '
        'LL_panel
        '
        Me.LL_panel.Location = New System.Drawing.Point(159, 12)
        Me.LL_panel.Name = "LL_panel"
        Me.LL_panel.Size = New System.Drawing.Size(1162, 108)
        Me.LL_panel.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 27)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Linked List:"
        '
        'RichTextBox5
        '
        Me.RichTextBox5.BackColor = System.Drawing.Color.White
        Me.RichTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox5.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox5.ForeColor = System.Drawing.Color.MediumOrchid
        Me.RichTextBox5.Location = New System.Drawing.Point(890, 376)
        Me.RichTextBox5.Name = "RichTextBox5"
        Me.RichTextBox5.ReadOnly = True
        Me.RichTextBox5.Size = New System.Drawing.Size(285, 38)
        Me.RichTextBox5.TabIndex = 21
        Me.RichTextBox5.Text = "Ready to test yourself?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(921, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 54)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Take Quiz"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.DodgerBlue
        Me.reset.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.ForeColor = System.Drawing.Color.White
        Me.reset.Location = New System.Drawing.Point(938, 308)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(108, 49)
        Me.reset.TabIndex = 23
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'LinkedList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1482, 953)
        Me.Controls.Add(Me.RichTextBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RichTextBox4)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.RichTextBox6)
        Me.Controls.Add(Me.RichTextBox7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "LinkedList"
        Me.Text = "LinkedList"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RichTextBox7 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox6 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox4 As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RichTextBox5 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LL_panel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents insert_btn As System.Windows.Forms.Button
    Friend WithEvents insert_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents search_btn As System.Windows.Forms.Button
    Friend WithEvents search_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents new_num_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents update_btn As System.Windows.Forms.Button
    Friend WithEvents update_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents delete_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents reset As System.Windows.Forms.Button
End Class
