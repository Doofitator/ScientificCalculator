Public Class frm_history
    Private Sub frm_history_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        txt_history.Width = Me.Width - 40
        txt_history.Height = Me.Height - 60
    End Sub

    Private Sub frm_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = frm_Calculator.Left + frm_Calculator.Width + 10
        Me.Height = frm_Calculator.Height
        Me.Top = frm_Calculator.Top
        writeHistory()

    End Sub
    Private Declare Function GetActiveWindow Lib "user32" Alias "GetActiveWindow" () As IntPtr

    Function writeHistory()
        txt_history.Text = ""
        Try
            For Each line As String In My.Settings.History
                txt_history.AppendText(line & vbCrLf)
            Next
        Catch
            txt_history.Text = "No history yet."
        End Try
    End Function
End Class