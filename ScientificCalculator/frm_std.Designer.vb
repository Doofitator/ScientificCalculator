<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_std
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
        Me.lbl_hint = New System.Windows.Forms.Label()
        Me.lbl_t = New System.Windows.Forms.Label()
        Me.nud_t = New System.Windows.Forms.NumericUpDown()
        Me.lbl_s = New System.Windows.Forms.Label()
        Me.lbl_d = New System.Windows.Forms.Label()
        Me.nud_s = New System.Windows.Forms.NumericUpDown()
        Me.nud_d = New System.Windows.Forms.NumericUpDown()
        CType(Me.nud_t, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_s, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_d, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_hint
        '
        Me.lbl_hint.Location = New System.Drawing.Point(12, 108)
        Me.lbl_hint.Name = "lbl_hint"
        Me.lbl_hint.Size = New System.Drawing.Size(304, 23)
        Me.lbl_hint.TabIndex = 17
        Me.lbl_hint.Text = "(Enter to begin conversion, at least two values must be filled)"
        Me.lbl_hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_t
        '
        Me.lbl_t.AutoSize = True
        Me.lbl_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_t.Location = New System.Drawing.Point(42, 79)
        Me.lbl_t.Name = "lbl_t"
        Me.lbl_t.Size = New System.Drawing.Size(53, 24)
        Me.lbl_t.TabIndex = 16
        Me.lbl_t.Text = "Time"
        '
        'nud_t
        '
        Me.nud_t.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_t.Location = New System.Drawing.Point(149, 77)
        Me.nud_t.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_t.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_t.Name = "nud_t"
        Me.nud_t.Size = New System.Drawing.Size(142, 29)
        Me.nud_t.TabIndex = 15
        '
        'lbl_s
        '
        Me.lbl_s.AutoSize = True
        Me.lbl_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_s.Location = New System.Drawing.Point(42, 44)
        Me.lbl_s.Name = "lbl_s"
        Me.lbl_s.Size = New System.Drawing.Size(66, 24)
        Me.lbl_s.TabIndex = 14
        Me.lbl_s.Text = "Speed"
        '
        'lbl_d
        '
        Me.lbl_d.AutoSize = True
        Me.lbl_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_d.Location = New System.Drawing.Point(42, 9)
        Me.lbl_d.Name = "lbl_d"
        Me.lbl_d.Size = New System.Drawing.Size(82, 24)
        Me.lbl_d.TabIndex = 13
        Me.lbl_d.Text = "Distance"
        '
        'nud_s
        '
        Me.nud_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_s.Location = New System.Drawing.Point(149, 42)
        Me.nud_s.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_s.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_s.Name = "nud_s"
        Me.nud_s.Size = New System.Drawing.Size(142, 29)
        Me.nud_s.TabIndex = 12
        '
        'nud_d
        '
        Me.nud_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_d.Location = New System.Drawing.Point(149, 7)
        Me.nud_d.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_d.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_d.Name = "nud_d"
        Me.nud_d.Size = New System.Drawing.Size(142, 29)
        Me.nud_d.TabIndex = 11
        '
        'frm_std
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 132)
        Me.Controls.Add(Me.lbl_hint)
        Me.Controls.Add(Me.lbl_t)
        Me.Controls.Add(Me.nud_t)
        Me.Controls.Add(Me.lbl_s)
        Me.Controls.Add(Me.lbl_d)
        Me.Controls.Add(Me.nud_s)
        Me.Controls.Add(Me.nud_d)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_std"
        Me.Text = "Speed, time and distance calculator"
        CType(Me.nud_t, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_s, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_d, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_hint As Label
    Friend WithEvents lbl_t As Label
    Friend WithEvents nud_t As NumericUpDown
    Friend WithEvents lbl_s As Label
    Friend WithEvents lbl_d As Label
    Friend WithEvents nud_s As NumericUpDown
    Friend WithEvents nud_d As NumericUpDown
End Class
