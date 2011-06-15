Imports System.Text

Public Class Form4_Achvts

    Private Sub Form4_Achvts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tmpCb As CheckBox
        For i As Integer = 0 To Form1_Main.currentAchievements.Length - 1
            tmpCb = CType(gb_Achieve1.Controls("cb_Achieve1_" & (i + 1)), CheckBox)
            tmpCb.Checked = Form1_Main.currentAchievements(i) <> "0"c

            tmpCb.Enabled = Form1_Main.achievements(i) = "0"c
        Next i
    End Sub

    Private Sub b_Validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Validate.Click
        Dim sb As New StringBuilder(gb_Achieve1.Controls.Count())
        sb.Append("0"c, gb_Achieve1.Controls.Count())

        For Each c As CheckBox In gb_Achieve1.Controls
            sb(CInt(c.Tag)) = If(c.Checked, "1"c, "0"c)
        Next c

        Form1_Main.currentAchievements = sb.ToString()

        Close()
    End Sub
End Class