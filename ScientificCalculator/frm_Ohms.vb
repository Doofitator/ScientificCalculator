Public Class frm_Ohms
    Dim v As Integer = 0
    Dim i As Integer = 0
    Dim r As Integer = 0

    Private Sub nud_v_ValueChanged(sender As Object, e As EventArgs) Handles nud_v.ValueChanged
        v = nud_v.Value
    End Sub

    Private Sub nud_i_ValueChanged(sender As Object, e As EventArgs) Handles nud_i.ValueChanged
        i = nud_i.Value
    End Sub

    Private Sub nud_r_ValueChanged(sender As Object, e As EventArgs) Handles nud_r.ValueChanged
        r = nud_r.Value
    End Sub

    Private Sub nud_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nud_r.KeyDown, nud_i.KeyDown, nud_v.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not v = 0 And Not i = 0 Then
                nud_r.Value = v * i
            ElseIf Not v = 0 And Not r = 0 Then
                nud_i.Value = v * r
            ElseIf Not r = 0 And Not i = 0 Then
                nud_v.Value = r * i
            End If
        End If
    End Sub
End Class