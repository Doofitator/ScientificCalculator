Imports System.IO
Imports System.Text.RegularExpressions
Imports org.mariuszgromada.math.mxparser

Public Class frm_Calculator

    Dim deleteOnNextInput As Boolean = False

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

    Private Sub btn_number_Click(sender As Object, e As EventArgs) Handles btn_point.Click, btn_zero.Click, btn_one.Click, btn_two.Click, btn_three.Click, btn_four.Click, btn_five.Click, btn_six.Click, btn_seven.Click, btn_eight.Click, btn_nine.Click, btn_plus.Click, btn_minus.Click, btn_divide.Click, btn_multiply.Click, btn_openBracket.Click, btn_closeBracket.Click
        If deleteOnNextInput Then
            lbl_formula.Text = ""
            txt_result.Text = ""
            deleteOnNextInput = False
        End If

        'If lbl_formula.Text.EndsWith("sin(") Or lbl_formula.Text.EndsWith("cos(") Or lbl_formula.Text.EndsWith("tan(") Or lbl_formula.Text.EndsWith("arcsin(") Or lbl_formula.Text.EndsWith("arccos(") Or lbl_formula.Text.EndsWith("arctan(") Then
        'lbl_formula.Text += CType(sender, Button).Text & "*[" & tsbtn_deg_rad.Text & "]" 'could change to happen in btn_equals.click with find and replace?
        'Else
        lbl_formula.Text += CType(sender, Button).Text
        'End If
    End Sub

    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click
        Dim equationString As String = Regex.Replace(lbl_formula.Text, "(sin|cos|tan)(\(.?.?.?.?.?.?)(\))", "$1$2" + "*[" & tsbtn_deg_rad.Text & "]$3")
        Dim calculation As Expression = New Expression(equationString)
        Dim Math As String = calculation.calculate()
        txt_result.Text = Math
        'write to history
        Try
            My.Settings.History.Add(equationString & "=" & Math)
            My.Settings.Save()
        Catch
            My.Settings.History = New Specialized.StringCollection()
            My.Settings.History.Add(equationString & "=" & Math)
            My.Settings.Save()
        End Try
        deleteOnNextInput = True

        frm_history.writeHistory()
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        lbl_formula.Text = ""
        txt_result.Text = ""
    End Sub

    Private Sub btn_backspace_Click(sender As Object, e As EventArgs) Handles btn_backspace.Click
        Try
            lbl_formula.Text = lbl_formula.Text.Substring(0, lbl_formula.Text.Length - 1)
        Catch
            'lbl already has nothing in it
        End Try
    End Sub

    Private Sub tsmi_openHistory_Click(sender As Object, e As EventArgs) Handles tsmi_openHistory.Click
        frm_history.Show()
    End Sub

    Private Sub tsmi_deleteHistory_Click(sender As Object, e As EventArgs) Handles tsmi_deleteHistory.Click
        My.Settings.History.Clear()
        My.Settings.Save()
    End Sub

    Private Sub btn_SineCosTan_Click(sender As Object, e As EventArgs) Handles btn_Sine.Click, btn_Tan.Click, btn_Cos.Click
        Dim trig As String = ""

        If CType(sender, Button) Is btn_Sine Then
            trig = "sin("
        ElseIf CType(sender, Button) Is btn_Cos Then
            trig = "cos("
        Else
            trig = "tan("
        End If

        If deleteOnNextInput Then
            lbl_formula.Text = ""
            txt_result.Text = ""
            deleteOnNextInput = False
        End If

        'If lbl_formula.Text.EndsWith("sin(") Or lbl_formula.Text.EndsWith("cos(") Or lbl_formula.Text.EndsWith("tan(") Or lbl_formula.Text.EndsWith("arcsin(") Or lbl_formula.Text.EndsWith("arccos(") Or lbl_formula.Text.EndsWith("arctan(") Then
        'lbl_formula.Text += trig & "*[" & tsbtn_deg_rad.Text & "]" 'could change to happen in btn_equals.click with find and replace?
        'Else
        lbl_formula.Text += trig
        'End If
    End Sub

    Private Sub tsbtn_deg_rad_Click(sender As Object, e As EventArgs) Handles tsbtn_deg_rad.Click
        If tsbtn_deg_rad.Text = "rad" Then
            tsbtn_deg_rad.Text = "deg"
            My.Settings.Radians = False
        Else
            tsbtn_deg_rad.Text = "rad"
            My.Settings.Radians = True
        End If
        My.Settings.Save()
    End Sub

    Private Sub frm_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Radians Then
            tsbtn_deg_rad.Text = "rad"
        Else
            tsbtn_deg_rad.Text = "deg"
        End If
    End Sub

    Private Sub btn_inverseSineCosTan_Click(sender As Object, e As EventArgs) Handles btn_inverseSine.Click, btn_inverseCos.Click, btn_inverseTan.Click
        Dim trig As String = ""

        If CType(sender, Button) Is btn_inverseSine Then
            trig = "arcsin("
        ElseIf CType(sender, Button) Is btn_inverseCos Then
            trig = "arccos("
        Else
            trig = "arctan("
        End If

        If deleteOnNextInput Then
            lbl_formula.Text = ""
            txt_result.Text = ""
            deleteOnNextInput = False
        End If

        'If lbl_formula.Text.EndsWith("sin(") Or lbl_formula.Text.EndsWith("cos(") Or lbl_formula.Text.EndsWith("tan(") Or lbl_formula.Text.EndsWith("arcsin(") Or lbl_formula.Text.EndsWith("arccos(") Or lbl_formula.Text.EndsWith("arctan(") Then
        ' lbl_formula.Text += trig & "*[" & tsbtn_deg_rad.Text & "]" 'could change to happen in btn_equals.click with find and replace?
        ' Else
        lbl_formula.Text += trig
        ' End If
    End Sub

    Private Sub btn_x_Click(sender As Object, e As EventArgs) Handles btn_toThePowerOf.Click, btn_root.Click, btn_square.Click, btn_squareRoot.Click
        Dim btn As Button = CType(sender, Button)
        Dim strText As String
        If btn Is btn_toThePowerOf Then
            strText = "^"
        ElseIf btn Is btn_root Then
retry:
            Dim rootNum As String = InputBox("What root? ", "x root", "3")
            If IsValid(rootNum) Then
                strText = "^(1/" & rootNum & ")"
            Else
                GoTo retry
            End If
        ElseIf btn Is btn_square Then
            strText = "^2"
        ElseIf btn Is btn_squareRoot Then
            strText = "sqrt("
        End If

        If deleteOnNextInput Then
            lbl_formula.Text = ""
            txt_result.Text = ""
            deleteOnNextInput = False
        End If

        lbl_formula.Text += strText
    End Sub

    Function IsValid(ByVal inputString As String) As Boolean
        Dim validValues As New Regex("^[1-9]?[0-9]{1}$|^100$")
        Return validValues.IsMatch(inputString)
    End Function
End Class
