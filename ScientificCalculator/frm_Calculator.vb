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
End Class
