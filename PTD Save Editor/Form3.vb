Imports PTD_Save_Editor.Form1

Public Class Form3

    Private Function GetStarterIndex(ByVal team As List(Of Save.Pokemon)) As Integer
        Try
            Return team.IndexOf(team.OrderBy(New Func(Of Save.Pokemon, Integer) _
                                                     (Function(pkm As Save.Pokemon) pkm.id)).First(New Func(Of Save.Pokemon, Boolean) _
                                                                                                   (Function(pkm As Save.Pokemon) pkm.num <= 9)))
        Catch
            Return -1
        End Try
    End Function

    Private Sub b_DoEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DoEvent.Click
        Dim tmpEventPoke As Save.Pokemon

        If lb_Events.SelectedIndex > 0 Then
            tmpEventPoke = New Save.Pokemon()
            tmpEventPoke.lvl = 1
            tmpEventPoke.exp = 0
            tmpEventPoke.shiny = True
            tmpEventPoke.moveSel = 1
        End If

        Select Case lb_Events.SelectedIndex
            Case 0  ' Shiny Starter
                Dim tmpIndex As Integer = GetStarterIndex(Form1.tmpTeam)
                If tmpIndex < 0 Then Exit Select

                Form1.tmpTeam(tmpIndex) = Form1.tmpTeam(tmpIndex).makeShiny()
                Form1.lb_Team.SelectedIndex = tmpIndex
                Form1.cb_Shiny.Checked = True

                Exit Sub

            Case 1  ' Shiny Bulbasaur
                tmpEventPoke.num = 1
                tmpEventPoke.lvl = 5
                tmpEventPoke.m = New List(Of Integer)(New Integer() {1, 5}) ' Tackle, Growl

            Case 2  ' Shiny Charmander
                tmpEventPoke.num = 4
                tmpEventPoke.lvl = 5
                tmpEventPoke.m = New List(Of Integer)(New Integer() {6, 5}) ' Scratch, Growl

            Case 3  ' Shiny Squirtle
                tmpEventPoke.num = 7
                tmpEventPoke.lvl = 5
                tmpEventPoke.m = New List(Of Integer)(New Integer() {1, 3}) ' Tackle, Tail Whip

            Case 4  ' Shiny Mew
                tmpEventPoke.num = 151
                tmpEventPoke.m = New List(Of Integer)(New Integer() {48, 57, 56}) ' Pound, Reflect Type, Transform

            Case 5  ' Shiny Pikachu
                tmpEventPoke.num = 25
                tmpEventPoke.m = New List(Of Integer)(New Integer() {22, 5}) ' Thundershock, Growl

            Case 6  ' Shiny Pidgey
                tmpEventPoke.num = 16
                tmpEventPoke.m = New List(Of Integer)(New Integer() {1}) ' Tackle

            Case 7  ' Shiny Geodude
                tmpEventPoke.num = 74
                tmpEventPoke.m = New List(Of Integer)(New Integer() {1, 25}) ' Tackle, Defense Curl

            Case Else
                Exit Sub

        End Select

        If lb_Events.SelectedIndex > 0 Then
            Form1.addPokeToTeam(tmpEventPoke)
        End If
    End Sub

    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub lb_Events_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_Events.SelectedIndexChanged
        b_DoEvent.Enabled = lb_Events.SelectedIndex >= 0
    End Sub
End Class