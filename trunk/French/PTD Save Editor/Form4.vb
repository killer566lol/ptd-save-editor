Imports System.Text

Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tmpCb As CheckBox
        For i As Integer = 0 To Form1.currentAchievements.Length - 1
            tmpCb = CType(gb_Achieve1.Controls.Find("cb_Achieve1_" & (i + 1), False)(0), CheckBox)
            tmpCb.Checked = Form1.currentAchievements(i) <> "0"c

            tmpCb.Enabled = Form1.achievements(i) = "0"c
        Next i
    End Sub

    Private Sub b_Validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Validate.Click
        Dim sb As New StringBuilder(gb_Achieve1.Controls.Count())
        sb.Append("0"c, gb_Achieve1.Controls.Count())

        For Each c As CheckBox In gb_Achieve1.Controls
            sb(CInt(c.Tag)) = If(c.Checked, "1"c, "0"c)
        Next c

        Form1.currentAchievements = sb.ToString()

        Close()
    End Sub
End Class