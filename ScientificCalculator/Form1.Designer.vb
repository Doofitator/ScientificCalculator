<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Calculator))
        Me.txt_formula = New System.Windows.Forms.TextBox()
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.stp_menuBar = New System.Windows.Forms.ToolStrip()
        Me.tssddbtn_file = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmi_history = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsddbtn_advanced = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmi_Quadratic = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_F2C = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_ohms = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_std = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.stp_menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_formula
        '
        Me.txt_formula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_formula.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_formula.Location = New System.Drawing.Point(12, 28)
        Me.txt_formula.Multiline = True
        Me.txt_formula.Name = "txt_formula"
        Me.txt_formula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_formula.Size = New System.Drawing.Size(411, 46)
        Me.txt_formula.TabIndex = 0
        Me.txt_formula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_result
        '
        Me.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_result.Location = New System.Drawing.Point(12, 74)
        Me.txt_result.Multiline = True
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(411, 46)
        Me.txt_result.TabIndex = 1
        Me.txt_result.Text = "00"
        Me.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'stp_menuBar
        '
        Me.stp_menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssddbtn_file, Me.tsddbtn_advanced})
        Me.stp_menuBar.Location = New System.Drawing.Point(0, 0)
        Me.stp_menuBar.Name = "stp_menuBar"
        Me.stp_menuBar.Size = New System.Drawing.Size(435, 25)
        Me.stp_menuBar.TabIndex = 3
        Me.stp_menuBar.Text = "Menu bar"
        '
        'tssddbtn_file
        '
        Me.tssddbtn_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssddbtn_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_history, Me.tsmi_exit})
        Me.tssddbtn_file.Image = CType(resources.GetObject("tssddbtn_file.Image"), System.Drawing.Image)
        Me.tssddbtn_file.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssddbtn_file.Name = "tssddbtn_file"
        Me.tssddbtn_file.Size = New System.Drawing.Size(38, 22)
        Me.tssddbtn_file.Text = "File"
        '
        'tsmi_history
        '
        Me.tsmi_history.Name = "tsmi_history"
        Me.tsmi_history.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmi_history.Size = New System.Drawing.Size(187, 22)
        Me.tsmi_history.Text = "Open History"
        '
        'tsmi_exit
        '
        Me.tsmi_exit.Name = "tsmi_exit"
        Me.tsmi_exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F14), System.Windows.Forms.Keys)
        Me.tsmi_exit.Size = New System.Drawing.Size(187, 22)
        Me.tsmi_exit.Text = "Exit"
        '
        'tsddbtn_advanced
        '
        Me.tsddbtn_advanced.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsddbtn_advanced.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Quadratic, Me.tsmi_F2C, Me.tsmi_ohms, Me.tsmi_std})
        Me.tsddbtn_advanced.Image = CType(resources.GetObject("tsddbtn_advanced.Image"), System.Drawing.Image)
        Me.tsddbtn_advanced.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsddbtn_advanced.Name = "tsddbtn_advanced"
        Me.tsddbtn_advanced.Size = New System.Drawing.Size(73, 22)
        Me.tsddbtn_advanced.Text = "Advanced"
        '
        'tsmi_Quadratic
        '
        Me.tsmi_Quadratic.Name = "tsmi_Quadratic"
        Me.tsmi_Quadratic.Size = New System.Drawing.Size(186, 22)
        Me.tsmi_Quadratic.Text = "Quadratic Formula"
        '
        'tsmi_F2C
        '
        Me.tsmi_F2C.Name = "tsmi_F2C"
        Me.tsmi_F2C.Size = New System.Drawing.Size(186, 22)
        Me.tsmi_F2C.Text = "Farenheit to Celsius"
        '
        'tsmi_ohms
        '
        Me.tsmi_ohms.Name = "tsmi_ohms"
        Me.tsmi_ohms.Size = New System.Drawing.Size(186, 22)
        Me.tsmi_ohms.Text = "Ohm's Law"
        '
        'tsmi_std
        '
        Me.tsmi_std.Name = "tsmi_std"
        Me.tsmi_std.Size = New System.Drawing.Size(186, 22)
        Me.tsmi_std.Text = "Speed, time & distance"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(329, 266)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 64)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "/"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 64)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "7"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(112, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 64)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "8"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(212, 266)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 64)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "9"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(212, 336)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 64)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "6"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(112, 336)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(94, 64)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "5"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(12, 336)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(94, 64)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "4"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(212, 406)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(94, 64)
        Me.Button8.TabIndex = 15
        Me.Button8.Text = "3"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(112, 406)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(94, 64)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "2"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(12, 406)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(94, 64)
        Me.Button10.TabIndex = 13
        Me.Button10.Text = "1"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(212, 475)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(94, 64)
        Me.Button12.TabIndex = 17
        Me.Button12.Text = "="
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(12, 476)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(194, 64)
        Me.Button13.TabIndex = 16
        Me.Button13.Text = "0"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(329, 336)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(94, 64)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "*"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(329, 406)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(94, 64)
        Me.Button14.TabIndex = 19
        Me.Button14.Text = "-"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(329, 476)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(94, 64)
        Me.Button15.TabIndex = 20
        Me.Button15.Text = "+"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(13, 220)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(93, 23)
        Me.Button16.TabIndex = 21
        Me.Button16.Text = "^2"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(113, 220)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(93, 23)
        Me.Button17.TabIndex = 22
        Me.Button17.Text = "√"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(13, 191)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(93, 23)
        Me.Button18.TabIndex = 23
        Me.Button18.Text = "^x"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(113, 191)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(93, 23)
        Me.Button19.TabIndex = 24
        Me.Button19.Text = "x√"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(212, 219)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(94, 23)
        Me.Button20.TabIndex = 25
        Me.Button20.Text = "("
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(212, 191)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(94, 23)
        Me.Button21.TabIndex = 26
        Me.Button21.Text = ")"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(12, 162)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(94, 23)
        Me.Button22.TabIndex = 27
        Me.Button22.Text = "sine("
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(112, 162)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(94, 23)
        Me.Button23.TabIndex = 28
        Me.Button23.Text = "cosine("
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(212, 162)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(94, 23)
        Me.Button24.TabIndex = 29
        Me.Button24.Text = "tangent("
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(12, 133)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(94, 23)
        Me.Button25.TabIndex = 30
        Me.Button25.Text = "sine-1("
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(112, 133)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(94, 23)
        Me.Button26.TabIndex = 31
        Me.Button26.Text = "cosine-1("
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(212, 133)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(94, 23)
        Me.Button27.TabIndex = 32
        Me.Button27.Text = "tangent-1("
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Location = New System.Drawing.Point(329, 126)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(94, 64)
        Me.Button28.TabIndex = 33
        Me.Button28.Text = "Delete"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(329, 196)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(94, 64)
        Me.Button29.TabIndex = 34
        Me.Button29.Text = "AC"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'frm_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 551)
        Me.Controls.Add(Me.Button29)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button27)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.stp_menuBar)
        Me.Controls.Add(Me.txt_result)
        Me.Controls.Add(Me.txt_formula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Calculator"
        Me.Text = "Calculator"
        Me.stp_menuBar.ResumeLayout(False)
        Me.stp_menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_formula As TextBox
    Friend WithEvents txt_result As TextBox
    Friend WithEvents stp_menuBar As ToolStrip
    Friend WithEvents tssddbtn_file As ToolStripDropDownButton
    Friend WithEvents tsmi_history As ToolStripMenuItem
    Friend WithEvents tsddbtn_advanced As ToolStripDropDownButton
    Friend WithEvents tsmi_Quadratic As ToolStripMenuItem
    Friend WithEvents tsmi_F2C As ToolStripMenuItem
    Friend WithEvents tsmi_ohms As ToolStripMenuItem
    Friend WithEvents tsmi_std As ToolStripMenuItem
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents tsmi_exit As ToolStripMenuItem
End Class
