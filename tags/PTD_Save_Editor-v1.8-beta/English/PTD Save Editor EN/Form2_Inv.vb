Public Class Form2_Inv

    Friend tmpItems, tmpItemCount As List(Of Integer)

    Private Sub refreshItems()
        tmpItemCount = New List(Of Integer)()

        For i As Integer = 1 To Form1_Main.ItemList.Count - 1
            tmpItemCount.Add(0)
        Next i

        For Each i As Integer In tmpItems
            If i > 0 Then
                tmpItemCount(i - 1) += 1
            End If
        Next i

        gb_Items.Controls.Clear()

        For i As Integer = 0 To tmpItemCount.Count - 1
            Dim lbl As New Label()
            lbl.AutoSize = True
            lbl.Text = Form1_Main.ItemList(i + 1)
            lbl.Location = New Drawing.Point(6, 26 * i + 21)

            Dim nud As New NumericUpDown()
            nud.Minimum = 0

            Dim max As Integer = If(i = 5, 1, 99)

            nud.Maximum = Math.Max(max, tmpItemCount(i))

            nud.Value = tmpItemCount(i)
            nud.Location = New Drawing.Point(85, 26 * i + 19)
            nud.Width = 40
            nud.Tag = i + 1

            gb_Items.Controls.AddRange(New Control() {lbl, nud})
        Next i
    End Sub

    Private Sub updateItems()
        Dim tmpNud As NumericUpDown
        tmpItems = New List(Of Integer)()

        For Each c As Control In gb_Items.Controls
            If TypeOf c Is NumericUpDown Then
                tmpNud = CType(c, NumericUpDown)

                For i As Integer = 1 To tmpNud.Value
                    tmpItems.Add(CInt(tmpNud.Tag))
                Next i
            End If
        Next c
    End Sub

    Private Sub Form2_Inv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmpItems = New List(Of Integer)(Form1_Main.tmpInv)

        refreshItems()

        Me.Height = 26 * tmpItemCount.Count + 127
        Me.Top = Form1_Main.Top + (Form1_Main.Height - Me.Height) / 2
    End Sub

    Private Sub b_Validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Validate.Click
        updateItems()

        Form1_Main.tmpInv = New List(Of Integer)(tmpItems)
        Close()
    End Sub

    Private Sub b_AdvancedMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_AdvancedMode.Click
        updateItems()
        Form2_Inv_Adv.ShowDialog()
        refreshItems()
    End Sub
End Class