<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ohms
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
        Me.bl_i = New System.Windows.Forms.Label()
        Me.lbl_v = New System.Windows.Forms.Label()
        Me.nud_i = New System.Windows.Forms.NumericUpDown()
        Me.nud_v = New System.Windows.Forms.NumericUpDown()
        Me.lbl_r = New System.Windows.Forms.Label()
        Me.nud_r = New System.Windows.Forms.NumericUpDown()
        Me.lbl_hint = New System.Windows.Forms.Label()
        CType(Me.nud_i, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_v, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bl_i
        '
        Me.bl_i.AutoSize = True
        Me.bl_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bl_i.Location = New System.Drawing.Point(41, 45)
        Me.bl_i.Name = "bl_i"
        Me.bl_i.Size = New System.Drawing.Size(72, 24)
        Me.bl_i.TabIndex = 7
        Me.bl_i.Text = "Current"
        '
        'lbl_v
        '
        Me.lbl_v.AutoSize = True
        Me.lbl_v.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_v.Location = New System.Drawing.Point(41, 10)
        Me.lbl_v.Name = "lbl_v"
        Me.lbl_v.Size = New System.Drawing.Size(74, 24)
        Me.lbl_v.TabIndex = 6
        Me.lbl_v.Text = "Voltage"
        '
        'nud_i
        '
        Me.nud_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_i.Location = New System.Drawing.Point(148, 43)
        Me.nud_i.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_i.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_i.Name = "nud_i"
        Me.nud_i.Size = New System.Drawing.Size(142, 29)
        Me.nud_i.TabIndex = 5
        '
        'nud_v
        '
        Me.nud_v.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_v.Location = New System.Drawing.Point(148, 8)
        Me.nud_v.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_v.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_v.Name = "nud_v"
        Me.nud_v.Size = New System.Drawing.Size(142, 29)
        Me.nud_v.TabIndex = 4
        '
        'lbl_r
        '
        Me.lbl_r.AutoSize = True
        Me.lbl_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_r.Location = New System.Drawing.Point(41, 80)
        Me.lbl_r.Name = "lbl_r"
        Me.lbl_r.Size = New System.Drawing.Size(102, 24)
        Me.lbl_r.TabIndex = 9
        Me.lbl_r.Text = "Resistance"
        '
        'nud_r
        '
        Me.nud_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_r.Location = New System.Drawing.Point(148, 78)
        Me.nud_r.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_r.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_r.Name = "nud_r"
        Me.nud_r.Size = New System.Drawing.Size(142, 29)
        Me.nud_r.TabIndex = 8
        '
        'lbl_hint
        '
        Me.lbl_hint.Location = New System.Drawing.Point(11, 109)
        Me.lbl_hint.Name = "lbl_hint"
        Me.lbl_hint.Size = New System.Drawing.Size(304, 23)
        Me.lbl_hint.TabIndex = 10
        Me.lbl_hint.Text = "(Enter to begin conversion, at least two values must be filled)"
        Me.lbl_hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_Ohms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 132)
        Me.Controls.Add(Me.lbl_hint)
        Me.Controls.Add(Me.lbl_r)
        Me.Controls.Add(Me.nud_r)
        Me.Controls.Add(Me.bl_i)
        Me.Controls.Add(Me.lbl_v)
        Me.Controls.Add(Me.nud_i)
        Me.Controls.Add(Me.nud_v)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_Ohms"
        Me.Text = "Ohms Law Calculator"
        CType(Me.nud_i, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_v, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bl_i As Label
    Friend WithEvents lbl_v As Label
    Friend WithEvents nud_i As NumericUpDown
    Friend WithEvents nud_v As NumericUpDown
    Friend WithEvents lbl_r As Label
    Friend WithEvents nud_r As NumericUpDown
    Friend WithEvents lbl_hint As Label
End Class
