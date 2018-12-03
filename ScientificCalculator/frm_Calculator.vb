Imports System.IO
Imports System.Linq

Public Class frm_Calculator
    Private Sub tsmi_exit_Click(sender As Object, e As EventArgs) Handles tsmi_exit.Click
        Me.Close()
    End Sub

    Private Sub tsmi_Quadratic_Click(sender As Object, e As EventArgs) Handles tsmi_Quadratic.Click
        frm_quadratics.ShowDialog()
    End Sub

    Private Sub tsmi_F2C_Click(sender As Object, e As EventArgs) Handles tsmi_F2C.Click
        frm_F2C.ShowDialog()
    End Sub

    Private Sub tsmi_ohms_Click(sender As Object, e As EventArgs) Handles tsmi_ohms.Click
        frm_Ohms.ShowDialog()
    End Sub

    Private Sub tsmi_std_Click(sender As Object, e As EventArgs) Handles tsmi_std.Click
        frm_std.ShowDialog()
    End Sub

    Private Sub tsmi_saveHistory_Click(sender As Object, e As EventArgs) Handles tsmi_saveHistory.Click
        If sfd_History.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using SaveFile As StreamWriter = File.AppendText(sfd_History.FileName)
                For Each HistoryPoint As String In My.Settings.History
                    SaveFile.WriteLine(HistoryPoint)
                Next
                SaveFile.Close()
            End Using
        End If
    End Sub

    Private Sub btn_number_Click(sender As Object, e As EventArgs) Handles btn_point.Click, btn_zero.Click, btn_one.Click, btn_two.Click, btn_three.Click, btn_four.Click, btn_five.Click, btn_six.Click, btn_seven.Click, btn_eight.Click, btn_nine.Click, btn_plus.Click, btn_minus.Click, btn_divide.Click, btn_multiply.Click
        lbl_formula.Text += CType(sender, Button).Text
    End Sub

    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click
        Dim equationString As String = lbl_formula.Text
        Dim math As Decimal = New DataTable().Compute(equationString, Nothing)
        txt_result.Text = math
        'write to history
        My.Settings.History.Add(equationString & "=" & math)
        My.Settings.Save()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lbl_formula.Text = ""
        txt_result.Text = ""
    End Sub

    Private Sub btn_backspace_Click(sender As Object, e As EventArgs) Handles btn_backspace.Click
        lbl_formula.Text = lbl_formula.Text.Substring(0, lbl_formula.Text.Length - 1)
    End Sub
End Class
