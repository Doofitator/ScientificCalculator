<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_F2C
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
        Me.nud_cel = New System.Windows.Forms.NumericUpDown()
        Me.nud_far = New System.Windows.Forms.NumericUpDown()
        Me.lbl_cel = New System.Windows.Forms.Label()
        Me.bl_far = New System.Windows.Forms.Label()
        Me.lbl_hint = New System.Windows.Forms.Label()
        CType(Me.nud_cel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_far, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nud_cel
        '
        Me.nud_cel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_cel.Location = New System.Drawing.Point(119, 12)
        Me.nud_cel.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_cel.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_cel.Name = "nud_cel"
        Me.nud_cel.Size = New System.Drawing.Size(142, 29)
        Me.nud_cel.TabIndex = 0
        '
        'nud_far
        '
        Me.nud_far.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nud_far.Location = New System.Drawing.Point(119, 47)
        Me.nud_far.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nud_far.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.nud_far.Name = "nud_far"
        Me.nud_far.Size = New System.Drawing.Size(142, 29)
        Me.nud_far.TabIndex = 1
        '
        'lbl_cel
        '
        Me.lbl_cel.AutoSize = True
        Me.lbl_cel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cel.Location = New System.Drawing.Point(12, 14)
        Me.lbl_cel.Name = "lbl_cel"
        Me.lbl_cel.Size = New System.Drawing.Size(71, 24)
        Me.lbl_cel.TabIndex = 2
        Me.lbl_cel.Text = "Celsius"
        '
        'bl_far
        '
        Me.bl_far.AutoSize = True
        Me.bl_far.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bl_far.Location = New System.Drawing.Point(12, 49)
        Me.bl_far.Name = "bl_far"
        Me.bl_far.Size = New System.Drawing.Size(90, 24)
        Me.bl_far.TabIndex = 3
        Me.bl_far.Text = "Farenheit"
        '
        'lbl_hint
        '
        Me.lbl_hint.Location = New System.Drawing.Point(13, 80)
        Me.lbl_hint.Name = "lbl_hint"
        Me.lbl_hint.Size = New System.Drawing.Size(248, 23)
        Me.lbl_hint.TabIndex = 4
        Me.lbl_hint.Text = "(Enter to begin conversion)"
        Me.lbl_hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_F2C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 105)
        Me.Controls.Add(Me.lbl_hint)
        Me.Controls.Add(Me.bl_far)
        Me.Controls.Add(Me.lbl_cel)
        Me.Controls.Add(Me.nud_far)
        Me.Controls.Add(Me.nud_cel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_F2C"
        Me.Text = "Farenheit to Celsius Calculator"
        CType(Me.nud_cel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_far, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nud_cel As NumericUpDown
    Friend WithEvents nud_far As NumericUpDown
    Friend WithEvents lbl_cel As Label
    Friend WithEvents bl_far As Label
    Friend WithEvents lbl_hint As Label
End Class
