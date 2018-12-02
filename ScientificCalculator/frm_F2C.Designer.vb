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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Celsius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Farenheit"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "(Enter to begin conversion)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_F2C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 105)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
