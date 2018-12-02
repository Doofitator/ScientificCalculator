Public Class frm_F2C
    Private Sub frm_F2C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nud_cel.DecimalPlaces = 5
        nud_cel.Increment = 1
        nud_far.DecimalPlaces = 5
        nud_far.Increment = 1
    End Sub

    Private Sub nud_cel_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nud_cel.KeyDown
        If e.KeyCode = Keys.Enter Then nud_far.Value = Math.Round(((nud_cel.Value - 32) * 5) / 9, 5)
    End Sub
    Private Sub nud_far_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nud_far.KeyDown
        If e.KeyCode = Keys.Enter Then nud_cel.Value = Math.Round(((nud_far.Value + 32) / 5) * 9, 5)
    End Sub
End Class