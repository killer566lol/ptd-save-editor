Public Class Form2

    Private tmpItems As List(Of Integer)

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmpItems = New List(Of Integer)(Form1.tmpInv)

        lb_Items.Items.Clear()
        For Each i As Integer In Form1.tmpInv
            lb_Items.Items.Add(Form1.ItemList(i))
        Next i

        lb_Items.SelectedIndex = -1
        cb_ItemList.SelectedIndex = -1
        cb_ItemList.Enabled = False
        b_Modify.Enabled = False
        b_Delete.Enabled = False
    End Sub

    Private Sub b_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Delete.Click
        Dim tmpIndex As Integer = lb_Items.SelectedIndex

        tmpItems.RemoveAt(tmpIndex)
        lb_Items.Items.RemoveAt(tmpIndex)
        'lb_Items.Focus()
        lb_Items.SelectedIndex = If(tmpIndex < lb_Items.Items.Count, tmpIndex, lb_Items.Items.Count - 1)
    End Sub

    Private Sub lb_Items_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_Items.KeyDown
        If e.KeyCode = Keys.Delete Then
            b_Delete.PerformClick()
        ElseIf e.KeyCode = Keys.Insert Then
            b_Add.PerformClick()
        End If
    End Sub

    Private Sub lb_Items_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_Items.SelectedIndexChanged
        If lb_Items.SelectedIndex < 0 Then
            cb_ItemList.SelectedIndex = -1
            cb_ItemList.Enabled = False
            b_Modify.Enabled = False
            b_Delete.Enabled = False
        Else
            cb_ItemList.SelectedIndex = tmpItems(lb_Items.SelectedIndex)
            cb_ItemList.Enabled = True
            b_Modify.Enabled = True
            b_Delete.Enabled = True
        End If
    End Sub

    Private Sub b_Validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Validate.Click
        Form1.tmpInv = New List(Of Integer)(tmpItems)
    End Sub

    Private Sub b_Modify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Modify.Click
        tmpItems(lb_Items.SelectedIndex) = cb_ItemList.SelectedIndex
        lb_Items.Items(lb_Items.SelectedIndex) = Form1.ItemList(cb_ItemList.SelectedIndex)
    End Sub

    Private Sub b_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Add.Click
        tmpItems.Add(If(cb_ItemList.SelectedIndex < 1, 0, cb_ItemList.SelectedIndex))
        lb_Items.Items.Add(Form1.ItemList(If(cb_ItemList.SelectedIndex < 1, 0, cb_ItemList.SelectedIndex)))
        lb_Items.SelectedIndex = lb_Items.Items.Count - 1
    End Sub
End Class