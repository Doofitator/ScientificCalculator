<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_quadratics
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_x1 = New System.Windows.Forms.TextBox()
        Me.txt_x2 = New System.Windows.Forms.TextBox()
        Me.nud_a = New System.Windows.Forms.NumericUpDown()
        Me.nud_b = New System.Windows.Forms.NumericUpDown()
        Me.nud_c = New System.Windows.Forms.NumericUpDown()
        CType(Me.nud_a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_b, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_c, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "x^2 + "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x +"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "x ="
        '
        'txt_x1
        '
        Me.txt_x1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_x1.Location = New System.Drawing.Point(62, 93)
        Me.txt_x1.Name = "txt_x1"
        Me.txt_x1.Size = New System.Drawing.Size(290, 29)
        Me.txt_x1.TabIndex = 6
        '
        'txt_x2
        '
        Me.txt_x2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_x2.Location = New System.Drawing.Point(62, 128)
        Me.txt_x2.Name = "txt_x2"
        Me.txt_x2.Size = New System.Drawing.Size(290, 29)
        Me.txt_x2.TabIndex = 7
        '
        'nud_a
        '
        Me.nud_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_a.Location = New System.Drawing.Point(19, 37)
        Me.nud_a.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nud_a.Name = "nud_a"
        Me.nud_a.Size = New System.Drawing.Size(71, 29)
        Me.nud_a.TabIndex = 8
        '
        'nud_b
        '
        Me.nud_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_b.Location = New System.Drawing.Point(162, 37)
        Me.nud_b.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nud_b.Name = "nud_b"
        Me.nud_b.Size = New System.Drawing.Size(71, 29)
        Me.nud_b.TabIndex = 9
        '
        'nud_c
        '
        Me.nud_c.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_c.Location = New System.Drawing.Point(281, 37)
        Me.nud_c.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nud_c.Name = "nud_c"
        Me.nud_c.Size = New System.Drawing.Size(71, 29)
        Me.nud_c.TabIndex = 10
        '
        'frm_quadratics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 183)
        Me.Controls.Add(Me.nud_c)
        Me.Controls.Add(Me.nud_b)
        Me.Controls.Add(Me.nud_a)
        Me.Controls.Add(Me.txt_x2)
        Me.Controls.Add(Me.txt_x1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_quadratics"
        Me.Text = "Quadratic solver"
        CType(Me.nud_a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_b, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_c, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_x1 As TextBox
    Friend WithEvents txt_x2 As TextBox
    Friend WithEvents nud_a As NumericUpDown
    Friend WithEvents nud_b As NumericUpDown
    Friend WithEvents nud_c As NumericUpDown
End Class
