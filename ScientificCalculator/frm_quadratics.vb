Public Class frm_quadratics
    Private Sub frm_quadratics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nud_a.DecimalPlaces = 2
        nud_a.Increment = 0.1
        nud_b.DecimalPlaces = 2
        nud_b.Increment = 0.1
        nud_c.DecimalPlaces = 2
        nud_c.Increment = 0.1
    End Sub

    Private Sub nud_ValueChanged(sender As Object, e As EventArgs) Handles nud_a.ValueChanged, nud_b.ValueChanged, nud_c.ValueChanged
        Dim answerOne As String = "~"
        Dim answerTwo As String = "~"

        If ((nud_b.Value ^ 2) - (4 * nud_a.Value * nud_c.Value)) > 0 Then
            answerOne = Math.Round((-nud_b.Value + Math.Sqrt(nud_b.Value ^ 2 - 4 * nud_a.Value * nud_c.Value)) / (2 * nud_a.Value), 20)
            answerTwo = Math.Round((-nud_b.Value - Math.Sqrt(nud_b.Value ^ 2 - 4 * nud_a.Value * nud_c.Value)) / (2 * nud_a.Value), 20)
        End If

        txt_x1.Text = answerOne
        txt_x2.Text = answerTwo
    End Sub
End Class