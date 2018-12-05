<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_history
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_history = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt_history
        '
        Me.txt_history.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_history.Location = New System.Drawing.Point(13, 13)
        Me.txt_history.Multiline = True
        Me.txt_history.Name = "txt_history"
        Me.txt_history.ReadOnly = True
        Me.txt_history.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_history.Size = New System.Drawing.Size(489, 578)
        Me.txt_history.TabIndex = 0
        '
        'frm_history
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 603)
        Me.Controls.Add(Me.txt_history)
        Me.Name = "frm_history"
        Me.Text = "frm_history"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txt_history As TextBox
End Class
