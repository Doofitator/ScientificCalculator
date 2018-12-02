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
        Me.txt_result = New System.Windows.Forms.TextBox()
        Me.stp_menuBar = New System.Windows.Forms.ToolStrip()
        Me.tssddbtn_file = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmi_history = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_openHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_saveHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_deleteHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsddbtn_advanced = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmi_Quadratic = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_F2C = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_ohms = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_std = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_seven = New System.Windows.Forms.Button()
        Me.btn_eight = New System.Windows.Forms.Button()
        Me.btn_nine = New System.Windows.Forms.Button()
        Me.btn_six = New System.Windows.Forms.Button()
        Me.btn_five = New System.Windows.Forms.Button()
        Me.btn_four = New System.Windows.Forms.Button()
        Me.btn_three = New System.Windows.Forms.Button()
        Me.btn_two = New System.Windows.Forms.Button()
        Me.btn_one = New System.Windows.Forms.Button()
        Me.btn_equals = New System.Windows.Forms.Button()
        Me.btn_zero = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_minus = New System.Windows.Forms.Button()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_square = New System.Windows.Forms.Button()
        Me.btn_squareRoot = New System.Windows.Forms.Button()
        Me.btn_toThePowerOf = New System.Windows.Forms.Button()
        Me.btn_root = New System.Windows.Forms.Button()
        Me.btn_openBracket = New System.Windows.Forms.Button()
        Me.btn_closeBracket = New System.Windows.Forms.Button()
        Me.btn_Sine = New System.Windows.Forms.Button()
        Me.btn_Cos = New System.Windows.Forms.Button()
        Me.btn_Tan = New System.Windows.Forms.Button()
        Me.btn_inverseSine = New System.Windows.Forms.Button()
        Me.btn_inverseCos = New System.Windows.Forms.Button()
        Me.btn_inverseTan = New System.Windows.Forms.Button()
        Me.btn_backspace = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stp_menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_result
        '
        Me.txt_result.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_result.Location = New System.Drawing.Point(12, 72)
        Me.txt_result.Multiline = True
        Me.txt_result.Name = "txt_result"
        Me.txt_result.Size = New System.Drawing.Size(411, 46)
        Me.txt_result.TabIndex = 29
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
        Me.tsmi_history.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_openHistory, Me.tsmi_saveHistory, Me.tsmi_deleteHistory})
        Me.tsmi_history.Name = "tsmi_history"
        Me.tsmi_history.Size = New System.Drawing.Size(140, 22)
        Me.tsmi_history.Text = "History"
        '
        'tsmi_openHistory
        '
        Me.tsmi_openHistory.Name = "tsmi_openHistory"
        Me.tsmi_openHistory.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmi_openHistory.Size = New System.Drawing.Size(177, 22)
        Me.tsmi_openHistory.Text = "Open"
        '
        'tsmi_saveHistory
        '
        Me.tsmi_saveHistory.Name = "tsmi_saveHistory"
        Me.tsmi_saveHistory.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmi_saveHistory.Size = New System.Drawing.Size(177, 22)
        Me.tsmi_saveHistory.Text = "Save as Text"
        '
        'tsmi_deleteHistory
        '
        Me.tsmi_deleteHistory.Name = "tsmi_deleteHistory"
        Me.tsmi_deleteHistory.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.tsmi_deleteHistory.Size = New System.Drawing.Size(177, 22)
        Me.tsmi_deleteHistory.Text = "Delete"
        '
        'tsmi_exit
        '
        Me.tsmi_exit.Name = "tsmi_exit"
        Me.tsmi_exit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F14), System.Windows.Forms.Keys)
        Me.tsmi_exit.Size = New System.Drawing.Size(140, 22)
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
        'btn_divide
        '
        Me.btn_divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_divide.Location = New System.Drawing.Point(329, 266)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(94, 64)
        Me.btn_divide.TabIndex = 22
        Me.btn_divide.Text = "/"
        Me.btn_divide.UseVisualStyleBackColor = True
        '
        'btn_seven
        '
        Me.btn_seven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_seven.Location = New System.Drawing.Point(12, 266)
        Me.btn_seven.Name = "btn_seven"
        Me.btn_seven.Size = New System.Drawing.Size(94, 64)
        Me.btn_seven.TabIndex = 19
        Me.btn_seven.Text = "7"
        Me.btn_seven.UseVisualStyleBackColor = True
        '
        'btn_eight
        '
        Me.btn_eight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eight.Location = New System.Drawing.Point(112, 266)
        Me.btn_eight.Name = "btn_eight"
        Me.btn_eight.Size = New System.Drawing.Size(94, 64)
        Me.btn_eight.TabIndex = 20
        Me.btn_eight.Text = "8"
        Me.btn_eight.UseVisualStyleBackColor = True
        '
        'btn_nine
        '
        Me.btn_nine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nine.Location = New System.Drawing.Point(212, 266)
        Me.btn_nine.Name = "btn_nine"
        Me.btn_nine.Size = New System.Drawing.Size(94, 64)
        Me.btn_nine.TabIndex = 21
        Me.btn_nine.Text = "9"
        Me.btn_nine.UseVisualStyleBackColor = True
        '
        'btn_six
        '
        Me.btn_six.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_six.Location = New System.Drawing.Point(212, 336)
        Me.btn_six.Name = "btn_six"
        Me.btn_six.Size = New System.Drawing.Size(94, 64)
        Me.btn_six.TabIndex = 18
        Me.btn_six.Text = "6"
        Me.btn_six.UseVisualStyleBackColor = True
        '
        'btn_five
        '
        Me.btn_five.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_five.Location = New System.Drawing.Point(112, 336)
        Me.btn_five.Name = "btn_five"
        Me.btn_five.Size = New System.Drawing.Size(94, 64)
        Me.btn_five.TabIndex = 17
        Me.btn_five.Text = "5"
        Me.btn_five.UseVisualStyleBackColor = True
        '
        'btn_four
        '
        Me.btn_four.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_four.Location = New System.Drawing.Point(12, 336)
        Me.btn_four.Name = "btn_four"
        Me.btn_four.Size = New System.Drawing.Size(94, 64)
        Me.btn_four.TabIndex = 16
        Me.btn_four.Text = "4"
        Me.btn_four.UseVisualStyleBackColor = True
        '
        'btn_three
        '
        Me.btn_three.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_three.Location = New System.Drawing.Point(212, 406)
        Me.btn_three.Name = "btn_three"
        Me.btn_three.Size = New System.Drawing.Size(94, 64)
        Me.btn_three.TabIndex = 15
        Me.btn_three.Text = "3"
        Me.btn_three.UseVisualStyleBackColor = True
        '
        'btn_two
        '
        Me.btn_two.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_two.Location = New System.Drawing.Point(112, 406)
        Me.btn_two.Name = "btn_two"
        Me.btn_two.Size = New System.Drawing.Size(94, 64)
        Me.btn_two.TabIndex = 14
        Me.btn_two.Text = "2"
        Me.btn_two.UseVisualStyleBackColor = True
        '
        'btn_one
        '
        Me.btn_one.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_one.Location = New System.Drawing.Point(12, 406)
        Me.btn_one.Name = "btn_one"
        Me.btn_one.Size = New System.Drawing.Size(94, 64)
        Me.btn_one.TabIndex = 13
        Me.btn_one.Text = "1"
        Me.btn_one.UseVisualStyleBackColor = True
        '
        'btn_equals
        '
        Me.btn_equals.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equals.Location = New System.Drawing.Point(212, 475)
        Me.btn_equals.Name = "btn_equals"
        Me.btn_equals.Size = New System.Drawing.Size(94, 64)
        Me.btn_equals.TabIndex = 26
        Me.btn_equals.Text = "="
        Me.btn_equals.UseVisualStyleBackColor = True
        '
        'btn_zero
        '
        Me.btn_zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_zero.Location = New System.Drawing.Point(12, 476)
        Me.btn_zero.Name = "btn_zero"
        Me.btn_zero.Size = New System.Drawing.Size(194, 64)
        Me.btn_zero.TabIndex = 12
        Me.btn_zero.Text = "0"
        Me.btn_zero.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_multiply.Location = New System.Drawing.Point(329, 336)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(94, 64)
        Me.btn_multiply.TabIndex = 23
        Me.btn_multiply.Text = "*"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'btn_minus
        '
        Me.btn_minus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minus.Location = New System.Drawing.Point(329, 406)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(94, 64)
        Me.btn_minus.TabIndex = 24
        Me.btn_minus.Text = "-"
        Me.btn_minus.UseVisualStyleBackColor = True
        '
        'btn_plus
        '
        Me.btn_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_plus.Location = New System.Drawing.Point(329, 476)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(94, 64)
        Me.btn_plus.TabIndex = 25
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = True
        '
        'btn_square
        '
        Me.btn_square.Location = New System.Drawing.Point(13, 220)
        Me.btn_square.Name = "btn_square"
        Me.btn_square.Size = New System.Drawing.Size(93, 23)
        Me.btn_square.TabIndex = 9
        Me.btn_square.Text = "^2"
        Me.btn_square.UseVisualStyleBackColor = True
        '
        'btn_squareRoot
        '
        Me.btn_squareRoot.Location = New System.Drawing.Point(113, 220)
        Me.btn_squareRoot.Name = "btn_squareRoot"
        Me.btn_squareRoot.Size = New System.Drawing.Size(93, 23)
        Me.btn_squareRoot.TabIndex = 10
        Me.btn_squareRoot.Text = "√"
        Me.btn_squareRoot.UseVisualStyleBackColor = True
        '
        'btn_toThePowerOf
        '
        Me.btn_toThePowerOf.Location = New System.Drawing.Point(13, 191)
        Me.btn_toThePowerOf.Name = "btn_toThePowerOf"
        Me.btn_toThePowerOf.Size = New System.Drawing.Size(93, 23)
        Me.btn_toThePowerOf.TabIndex = 6
        Me.btn_toThePowerOf.Text = "^x"
        Me.btn_toThePowerOf.UseVisualStyleBackColor = True
        '
        'btn_root
        '
        Me.btn_root.Location = New System.Drawing.Point(113, 191)
        Me.btn_root.Name = "btn_root"
        Me.btn_root.Size = New System.Drawing.Size(93, 23)
        Me.btn_root.TabIndex = 7
        Me.btn_root.Text = "x√"
        Me.btn_root.UseVisualStyleBackColor = True
        '
        'btn_openBracket
        '
        Me.btn_openBracket.Location = New System.Drawing.Point(212, 219)
        Me.btn_openBracket.Name = "btn_openBracket"
        Me.btn_openBracket.Size = New System.Drawing.Size(94, 23)
        Me.btn_openBracket.TabIndex = 11
        Me.btn_openBracket.Text = "("
        Me.btn_openBracket.UseVisualStyleBackColor = True
        '
        'btn_closeBracket
        '
        Me.btn_closeBracket.Location = New System.Drawing.Point(212, 191)
        Me.btn_closeBracket.Name = "btn_closeBracket"
        Me.btn_closeBracket.Size = New System.Drawing.Size(94, 23)
        Me.btn_closeBracket.TabIndex = 8
        Me.btn_closeBracket.Text = ")"
        Me.btn_closeBracket.UseVisualStyleBackColor = True
        '
        'btn_Sine
        '
        Me.btn_Sine.Location = New System.Drawing.Point(12, 162)
        Me.btn_Sine.Name = "btn_Sine"
        Me.btn_Sine.Size = New System.Drawing.Size(94, 23)
        Me.btn_Sine.TabIndex = 3
        Me.btn_Sine.Text = "sine("
        Me.btn_Sine.UseVisualStyleBackColor = True
        '
        'btn_Cos
        '
        Me.btn_Cos.Location = New System.Drawing.Point(112, 162)
        Me.btn_Cos.Name = "btn_Cos"
        Me.btn_Cos.Size = New System.Drawing.Size(94, 23)
        Me.btn_Cos.TabIndex = 4
        Me.btn_Cos.Text = "cosine("
        Me.btn_Cos.UseVisualStyleBackColor = True
        '
        'btn_Tan
        '
        Me.btn_Tan.Location = New System.Drawing.Point(212, 162)
        Me.btn_Tan.Name = "btn_Tan"
        Me.btn_Tan.Size = New System.Drawing.Size(94, 23)
        Me.btn_Tan.TabIndex = 5
        Me.btn_Tan.Text = "tangent("
        Me.btn_Tan.UseVisualStyleBackColor = True
        '
        'btn_inverseSine
        '
        Me.btn_inverseSine.Location = New System.Drawing.Point(12, 133)
        Me.btn_inverseSine.Name = "btn_inverseSine"
        Me.btn_inverseSine.Size = New System.Drawing.Size(94, 23)
        Me.btn_inverseSine.TabIndex = 0
        Me.btn_inverseSine.Text = "sine-1("
        Me.btn_inverseSine.UseVisualStyleBackColor = True
        '
        'btn_inverseCos
        '
        Me.btn_inverseCos.Location = New System.Drawing.Point(112, 133)
        Me.btn_inverseCos.Name = "btn_inverseCos"
        Me.btn_inverseCos.Size = New System.Drawing.Size(94, 23)
        Me.btn_inverseCos.TabIndex = 1
        Me.btn_inverseCos.Text = "cosine-1("
        Me.btn_inverseCos.UseVisualStyleBackColor = True
        '
        'btn_inverseTan
        '
        Me.btn_inverseTan.Location = New System.Drawing.Point(212, 133)
        Me.btn_inverseTan.Name = "btn_inverseTan"
        Me.btn_inverseTan.Size = New System.Drawing.Size(94, 23)
        Me.btn_inverseTan.TabIndex = 2
        Me.btn_inverseTan.Text = "tangent-1("
        Me.btn_inverseTan.UseVisualStyleBackColor = True
        '
        'btn_backspace
        '
        Me.btn_backspace.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backspace.Location = New System.Drawing.Point(329, 126)
        Me.btn_backspace.Name = "btn_backspace"
        Me.btn_backspace.Size = New System.Drawing.Size(94, 64)
        Me.btn_backspace.TabIndex = 27
        Me.btn_backspace.Text = "Delete"
        Me.btn_backspace.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(329, 196)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(94, 64)
        Me.btn_clear.TabIndex = 28
        Me.btn_clear.Text = "AC"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 42)
        Me.Label1.TabIndex = 35
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frm_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 551)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_backspace)
        Me.Controls.Add(Me.btn_inverseTan)
        Me.Controls.Add(Me.btn_inverseCos)
        Me.Controls.Add(Me.btn_inverseSine)
        Me.Controls.Add(Me.btn_Tan)
        Me.Controls.Add(Me.btn_Cos)
        Me.Controls.Add(Me.btn_Sine)
        Me.Controls.Add(Me.btn_closeBracket)
        Me.Controls.Add(Me.btn_openBracket)
        Me.Controls.Add(Me.btn_root)
        Me.Controls.Add(Me.btn_toThePowerOf)
        Me.Controls.Add(Me.btn_squareRoot)
        Me.Controls.Add(Me.btn_square)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_equals)
        Me.Controls.Add(Me.btn_zero)
        Me.Controls.Add(Me.btn_three)
        Me.Controls.Add(Me.btn_two)
        Me.Controls.Add(Me.btn_one)
        Me.Controls.Add(Me.btn_six)
        Me.Controls.Add(Me.btn_five)
        Me.Controls.Add(Me.btn_four)
        Me.Controls.Add(Me.btn_nine)
        Me.Controls.Add(Me.btn_eight)
        Me.Controls.Add(Me.btn_seven)
        Me.Controls.Add(Me.btn_divide)
        Me.Controls.Add(Me.stp_menuBar)
        Me.Controls.Add(Me.txt_result)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_Calculator"
        Me.Text = "Calculator"
        Me.stp_menuBar.ResumeLayout(False)
        Me.stp_menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_result As TextBox
    Friend WithEvents stp_menuBar As ToolStrip
    Friend WithEvents tssddbtn_file As ToolStripDropDownButton
    Friend WithEvents tsmi_history As ToolStripMenuItem
    Friend WithEvents tsddbtn_advanced As ToolStripDropDownButton
    Friend WithEvents tsmi_Quadratic As ToolStripMenuItem
    Friend WithEvents tsmi_F2C As ToolStripMenuItem
    Friend WithEvents tsmi_ohms As ToolStripMenuItem
    Friend WithEvents tsmi_std As ToolStripMenuItem
    Friend WithEvents btn_divide As Button
    Friend WithEvents btn_seven As Button
    Friend WithEvents btn_eight As Button
    Friend WithEvents btn_nine As Button
    Friend WithEvents btn_six As Button
    Friend WithEvents btn_five As Button
    Friend WithEvents btn_four As Button
    Friend WithEvents btn_three As Button
    Friend WithEvents btn_two As Button
    Friend WithEvents btn_one As Button
    Friend WithEvents btn_equals As Button
    Friend WithEvents btn_zero As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_square As Button
    Friend WithEvents btn_squareRoot As Button
    Friend WithEvents btn_toThePowerOf As Button
    Friend WithEvents btn_root As Button
    Friend WithEvents btn_openBracket As Button
    Friend WithEvents btn_closeBracket As Button
    Friend WithEvents btn_Sine As Button
    Friend WithEvents btn_Cos As Button
    Friend WithEvents btn_Tan As Button
    Friend WithEvents btn_inverseSine As Button
    Friend WithEvents btn_inverseCos As Button
    Friend WithEvents btn_inverseTan As Button
    Friend WithEvents btn_backspace As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents tsmi_exit As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents tsmi_openHistory As ToolStripMenuItem
    Friend WithEvents tsmi_saveHistory As ToolStripMenuItem
    Friend WithEvents tsmi_deleteHistory As ToolStripMenuItem
End Class
