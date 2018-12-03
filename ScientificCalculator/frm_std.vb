Public Class frm_std
    Dim d As Decimal = 0
    Dim s As Decimal = 0
    Dim t As Decimal = 0

    Private Sub nud_d_ValueChanged(sender As Object, e As EventArgs) Handles nud_d.ValueChanged
        d = nud_d.Value
    End Sub

    Private Sub nud_s_ValueChanged(sender As Object, e As EventArgs) Handles nud_s.ValueChanged
        s = nud_s.Value
    End Sub

    Private Sub nud_t_ValueChanged(sender As Object, e As EventArgs) Handles nud_t.ValueChanged
        t = nud_t.Value
    End Sub

    Private Sub nud_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nud_d.KeyDown, nud_s.KeyDown, nud_t.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not d = 0 And Not s = 0 Then
                nud_t.Value = d / s
            ElseIf Not d = 0 And Not t = 0 Then
                nud_s.Value = d / t
            ElseIf Not s = 0 And Not t = 0 Then
                nud_d.Value = s * t
            End If
        End If
    End Sub

    Private Sub frm_std_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nud_d.DecimalPlaces = 3
        nud_s.DecimalPlaces = 3
        nud_t.DecimalPlaces = 3
    End Sub
End Class