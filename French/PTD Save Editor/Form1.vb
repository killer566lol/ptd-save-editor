Imports System.Net, System.Text.Encoding

Public Class Form1

#Region "    Lists"
    Friend PokemonList As String() = {"-", "Bulbizarre", "Herbizarre", "Florizarre", _
                                       "Salamèche", "Reptincel", "Dracaufeu", "Carapuce", _
                                       "Carabaffe", "Tortank", "Chenipan", "Chrysacier", _
                                       "Papilusion", "Aspicot", "Coconfort", "Dardargnan", _
                                       "Roucool", "Roucoups", "Roucarnage", "Rattata", _
                                       "Rattatac", "Piafabec", "Rapasdepic", "Abo", _
                                       "Arbok", "Pikachu", "Raichu", "Sabelette", _
                                       "Sablaireau", "Nidoran" & ChrW(9792), "Nidorina", "Nidoqueen", _
                                       "Nidoran" & ChrW(9794), "Nidorino", "Nidoking", "Mélofée", _
                                       "Mélodelfe", "Goupix", "Feunard", "Rondoudou", _
                                       "Grodoudou", "Nosferapti", "Nosferalto", "Mystherbe", _
                                       "Ortide", "Rafflesia", "Paras", "Parasect", _
                                       "Mimitoss", "Aéromite", "Taupiqueur", "Triopikeur", _
                                       "Miaouss", "Persian", "Psykokwak", "Akwakwak", _
                                       "Férosinge", "Colossinge", "Caninos", "Arcanin", _
                                       "Ptitard", "Têtarte", "Tartard", "Abra", _
                                       "Kadabra", "Alakazam", "Machoc", "Machopeur", _
                                       "Mackogneur", "Chétiflor", "Boustiflor", "Empiflor", _
                                       "Tentacool", "Tentacruel", "Racaillou", "Gravalanch", _
                                       "Grolem", "Ponyta", "Galopa", "Ramoloss", _
                                       "Flagadoss", "Magnéti", "Magnéton", "Canarticho", _
                                       "Doduo", "Dodrio", "Otaria", "Lamantine", _
                                       "Tadmorv", "Grotadmorv", "Kokiyas", "Crustabri", _
                                       "Fantominus", "Spectrum", "Ectoplasma", "Onix", _
                                       "Soporifik", "Hypnomade", "Krabby", "Krabboss", _
                                       "Voltorbe", "Électrode", "Noeunoeuf", "Noadkoko", _
                                       "Osselait", "Ossatueur", "Kicklee", "Tygnon", _
                                       "Excelangue", "Smogo", "Smogogo", "Rhinocorne", _
                                       "Rhinoféros", "Leveinard", "Saquedeneu", "Kangourex", _
                                       "Hypotrempe", "Hypocéan", "Poissirène", "Poissoroy", _
                                       "Stari", "Staross", "M. Mime", "Insécateur", _
                                       "Lippoutou", "Élektek", "Magmar", "Scarabrute", _
                                       "Tauros", "Magicarpe", "Léviator", "Lokhlass", _
                                       "Métamorph", "Évoli", "Aquali", "Voltali", _
                                       "Pyroli", "Porygon", "Amonita", "Amonistar", _
                                       "Kabuto", "Kabutops", "Ptéra", "Ronflex", _
                                       "Artikodin", "Électhor", "Sulfura", "Minidraco", _
                                       "Draco", "Dracolosse", "Mewtwo", "Mew"}

    Friend AttackList As String() = {"(aucune)", "Tackle", "Sand Attack", "Tail Whip", _
                                      "Quick Attack", "Growl", "Scratch", "String Shot", _
                                      "Poison Sting", "Leech Seed", "Ember", "Bubble", _
                                      "Focus Energy", "Bug Bite", "Harden", "Gust", _
                                      "Vine Whip", "Smokescreen", "Withdraw", "Bite", _
                                      "Confusion", "Fury Attack", "Thundershock", "Thunderwave", _
                                      "Poison Powder", "Defense Curl", "Sleep Powder", "Take Down", _
                                      "Razor Leaf", "Dragon Rage", "Scary Face", "Water Gun", _
                                      "Rapid Spin", "Pursuit", "Hyper Fang", "Sucker Punch", _
                                      "Whirlwind", "Stun Spore", "Supersonic", "Twineedle", _
                                      "Rage", "Electro Ball", "Peck", "Leer", _
                                      "Aerial Ace", "Double Kick", "Fury Swipes", "Sing", _
                                      "Pound", "Disable", "Round", "Low Kick", _
                                      "Karate Chop", "Seismic Toss", "Leech Life", "Fury Cutter", _
                                      "Transform", "Reflect Type", "Metronome", "Mega Punch", _
                                      "Encore", "Double Slap", "Follow Me", "Minimize", _
                                      "Mud Sport", "Rock Polish", "Rock Throw", "Magnitude", _
                                      "Rollout", "Swift", "Wrap", "Glare", _
                                      "Screech", "Acid", "Astonish", "Wing Attack", _
                                      "Sweet Scent", "Twister", "Mirror Move", "Double Team", _
                                      "Horn Attack", "Confuse Ray", "Rock Blast", "Protect", _
                                      "Crunch", "Crush Claw", "Wake-Up Slap", "Spore", _
                                      "Chip Away", "Psybeam", "Smack Down", "Growth", _
                                      "Fire Fang", "Water Pulse", "Toxic Spikes", "Featherdance", _
                                      "Assurance", "Agility", "Stockpile", "Helping Hand", _
                                      "Air Cutter", "Roar", "Odor Sleuth", "Flame Wheel", _
                                      "Reversal", "Fire Spin", "Flame Burst", "Absorb", _
                                      "Mega Drain", "Water Sport", "Hypnosis", "Rain Dance", _
                                      "Bubblebeam", "Lucky Chant", "Body Slam"}

    Friend ItemList As String() = {"(aucun)", "Pierre Lune", "Pierre Plante", "Pierre Foudre", "Pierre Eau", "Pierre Feu"}
#End Region

    Private profile1, profile2, profile3 As Save
    Private profile1Set, profile2Set, profile3Set As Boolean

    Friend tmpTeam As List(Of Save.Pokemon)
    Private tmpPoke As Save.Pokemon
    Private tmpMoveList As List(Of Integer)
    Friend tmpInv As List(Of Integer)

    Private updatingDisplay As Boolean = False

    Private Const SERVER_LINK As String = "http://www.sndgames.com/php/poke.php"
    Private Const USER_AGENT As String = "Mozilla/5.0 (Windows NT 6.0; rv:2.0.1) Gecko/20100101 Firefox/4.0.1"


    Friend Structure Save
        Enum Versions As Byte
            UNDEFINED = 0
            RED = 1
            BLUE = 2
        End Enum

        Structure Pokemon
            Public id As Integer            ' Pokémon's ID (catch order)
            Public num As Integer           ' Pokédex number
            Public lvl As Integer           ' Level
            Public exp As Integer           ' Experience points
            Public shiny As Boolean         ' Pokémon is shiny ?
            Public m As List(Of Integer)    ' Move list
            Public moveSel As Byte          ' Currently selected move

            Public ReadOnly Property numMoves() As Byte ' Number of moves
                Get
                    Return If(m Is Nothing, 0, m.Count())
                End Get
            End Property

            Public Shared Function NewEmpty() As Pokemon
                NewEmpty = New Save.Pokemon()
                NewEmpty.id = 0
                NewEmpty.num = 1
                NewEmpty.lvl = 1
                NewEmpty.exp = 0
                NewEmpty.shiny = False
                'NewEmpty.m = New Integer() {1}.ToList()
                NewEmpty.m = New List(Of Integer)(New Integer() {1})
                NewEmpty.moveSel = 1
            End Function

            Public Function makeShiny() As Pokemon
                Me.shiny = True
                Return Me
            End Function
        End Structure

        Public name As String               ' Profile name
        Public badges As Byte               ' Number of badges
        Public money As Integer             ' Amount of money
        Public unlocked As Integer          ' Number of Levels unlocked
        Public levelAttempted As Integer    ' Number of Levels attempted
        Public ver As Versions              ' Game version (Red/Blue)
        Public team As List(Of Pokemon)     ' Pokémon team
        Public Inv As List(Of Integer)      ' Inventory
        Public CLevelCompleted As Integer   ' Challenge Levels completed
        Public CLevel1CodeUsed As Boolean   ' Shiny Geodude obtained ?

        Public Const EMPTY_ACCOUNT As String = "Satoshi|0|undefined|undefined|undefined|undefined|0|0|0|0"

        Public ReadOnly Property hmp() As Integer
            Get
                Return If(team Is Nothing, 0, team.Count())
            End Get
        End Property

        Public ReadOnly Property numInv() As Integer
            Get
                Return If(Inv Is Nothing, 0, Inv.Count())
            End Get
        End Property

        Public Sub New(ByVal dataStr As String)
            Dim pos As Integer = 0

            Dim dataArr As String() = dataStr.Split("|")

            Me.name = dataArr(pos)
            pos += 1
            Me.badges = If(dataArr(pos) = "undefined", 0, CInt(dataArr(pos)))
            pos += 1
            Me.money = If(dataArr(pos) = "undefined", 0, CInt(dataArr(pos)))
            pos += 1
            Me.unlocked = If(dataArr(pos) = "undefined", 0, CInt(dataArr(pos)))
            pos += 1
            Me.levelAttempted = If(dataArr(pos) = "undefined", 0, CInt(dataArr(pos)))
            pos += 1
            Me.ver = If(dataArr(pos) = "undefined", Versions.UNDEFINED, CByte(dataArr(pos)))
            pos += 1
            Dim _hmp As Integer = CInt(dataArr(pos))
            pos += 1

            Me.team = New List(Of Save.Pokemon)

            For p As Integer = 1 To _hmp
                Dim tmpPokeBuild As New Save.Pokemon()

                tmpPokeBuild.id = CInt(dataArr(pos))
                pos += 1
                tmpPokeBuild.num = CInt(dataArr(pos))
                pos += 1
                tmpPokeBuild.lvl = CInt(dataArr(pos))
                pos += 1
                tmpPokeBuild.exp = CInt(dataArr(pos))
                pos += 1
                Dim _numMoves As Integer = CInt(dataArr(pos))
                pos += 1
                tmpPokeBuild.shiny = (dataArr(pos) <> "0")
                pos += 1

                tmpPokeBuild.m = New List(Of Integer)

                For m As Integer = 1 To _numMoves
                    tmpPokeBuild.m.Add(CInt(dataArr(pos)))
                    pos += 1
                Next m

                tmpPokeBuild.moveSel = CInt(dataArr(pos))
                pos += 1

                Me.team.Add(tmpPokeBuild)
            Next p

            Dim _numInv As Integer = CInt(dataArr(pos))
            pos += 1

            Me.Inv = New List(Of Integer)

            For i As Integer = 1 To _numInv
                Me.Inv.Add(CInt(dataArr(pos)))
                pos += 1
            Next i

            If dataArr.Length > pos Then
                Me.CLevelCompleted = CInt(dataArr(pos))
                pos += 1
                Me.CLevel1CodeUsed = (dataArr(pos) <> "0")
                pos += 1
            Else
                Me.CLevelCompleted = 0
                Me.CLevel1CodeUsed = False
            End If
        End Sub

        'Public Shared Function FromString(ByVal dataStr As String) As Save
        '    Return New Save(dataStr)
        'End Function

        Public Overrides Function ToString() As String
            If Me.name Is Nothing Then Return ""

            ToString = Me.name & "|"
            ToString &= Me.badges & "|"
            ToString &= Me.money & "|"
            ToString &= Me.unlocked & "|"
            ToString &= Me.levelAttempted & "|"
            ToString &= If(Me.ver = Versions.UNDEFINED, "undefined", CStr(Me.ver)) & "|"
            ToString &= Me.hmp

            For Each p As Pokemon In Me.team
                ToString &= "|" & p.id & "|"
                ToString &= p.num & "|"
                ToString &= p.lvl & "|"
                ToString &= p.exp & "|"
                ToString &= p.numMoves & "|"
                ToString &= If(p.shiny, "1", "0") & "|"

                For Each m As Integer In p.m
                    ToString &= m & "|"
                Next m

                ToString &= p.moveSel
            Next p

            ToString &= "|" & Me.numInv

            For Each i As Integer In Me.Inv
                ToString &= "|" & i
            Next i

            ToString &= "|" & Me.CLevelCompleted
            ToString &= "|" & If(Me.CLevel1CodeUsed, "1", "0")
        End Function

        Public Shared Function NewEmpty() As Save
            Return New Save(EMPTY_ACCOUNT)
        End Function
    End Structure


    Private Function GetTime() As Long
        Return Int((Date.UtcNow - New Date(1970, 1, 1)).TotalMilliseconds)
    End Function

    Private Function ImportAccount(ByVal email As String, ByVal pass As String) As String
        Dim nc As New System.Collections.Specialized.NameValueCollection()
        nc.Add("Action", "importAccount")
        nc.Add("Email", email)
        nc.Add("Pass", pass)

        Dim wc As New WebClient()
        wc.Headers.Add(HttpRequestHeader.UserAgent, USER_AGENT)

        Return GetEncoding("iso-8859-1").GetString(wc.UploadValues(SERVER_LINK & "?Date=" & GetTime(), nc))
    End Function

    Private Function SaveAccount(ByVal email As String, ByVal pass As String) As String
        Dim nc As New System.Collections.Specialized.NameValueCollection()
        nc.Add("Action", "saveAccount")
        nc.Add("Email", email)
        nc.Add("Pass", pass)
        nc.Add("Info1", profile1.ToString())
        nc.Add("Info2", profile2.ToString())
        nc.Add("Info3", profile3.ToString())

        Dim wc As New WebClient()
        wc.Headers.Add(HttpRequestHeader.UserAgent, USER_AGENT)

        Return GetEncoding("iso-8859-1").GetString(wc.UploadValues(SERVER_LINK & "?Date=" & GetTime(), nc))
    End Function

    Private Function GetDictionaryFromString(ByVal dataStr As String) As Dictionary(Of String, String)
        Dim keyValues As String() = dataStr.Split("&")

        GetDictionaryFromString = New Dictionary(Of String, String)

        Dim keyValue As String()

        For Each s As String In keyValues
            keyValue = s.Split("=")
            GetDictionaryFromString.Add(keyValue(0), keyValue(1))
        Next s
    End Function

    Private Sub loadProfile(ByVal profileId As Integer)
        Dim profile As Save = Nothing
        Dim profileSet As Boolean = False

        Select Case profileId
            Case 1
                If profile1Set Then
                    profileSet = True
                    profile = profile1
                End If

            Case 2
                If profile2Set Then
                    profileSet = True
                    profile = profile2
                End If

            Case 3
                If profile3Set Then
                    profileSet = True
                    profile = profile3
                End If

            Case Else
                rb_Profile1.Checked = True
                Exit Sub
        End Select

        resetValues()
        b_DelOrCreateProfile.Enabled = True

        If profileSet Then
            gb_Data.Enabled = True
            b_DelOrCreateProfile.Text = "Effacer Profil"
            b_DelOrCreateProfile.Tag = "Del"
        Else
            gb_Data.Enabled = False
            b_DelOrCreateProfile.Text = "Nouveau Profil"
            b_DelOrCreateProfile.Tag = "New"
            Exit Sub
        End If

        lbl_Name.Text = profile.name

        nud_Badges.Value = profile.badges

        tb_Money.Text = profile.money

        lb_Team.Items.Clear()
        For Each p As Save.Pokemon In profile.team
            lb_Team.Items.Add(PokemonList(p.num))
        Next p

        nud_Attempted.Value = profile.levelAttempted
        nud_Unlocked.Value = profile.unlocked

        Select Case profile.ver
            Case Save.Versions.RED
                rb_Red.Checked = True

            Case Save.Versions.BLUE
                rb_Blue.Checked = True
        End Select

        tmpTeam = New List(Of Save.Pokemon)(profile.team)
        tmpInv = New List(Of Integer)(profile.Inv)

        nud_Challenge.Value = profile.CLevelCompleted
        cb_ShinyGeodude.Checked = profile.CLevel1CodeUsed
    End Sub

    Private Sub updateProfile(ByVal profileId As Integer)
        Dim profile As Save = New Save()

        profile.name = lbl_Name.Text
        profile.badges = nud_Badges.Value
        profile.money = CInt(tb_Money.Text)
        profile.unlocked = nud_Unlocked.Value
        profile.levelAttempted = nud_Attempted.Value

        If rb_Red.Checked Then
            profile.ver = Save.Versions.RED
        ElseIf rb_Blue.Checked Then
            profile.ver = Save.Versions.BLUE
        Else
            profile.ver = Save.Versions.UNDEFINED
        End If

        profile.team = New List(Of Save.Pokemon)(tmpTeam)
        profile.Inv = New List(Of Integer)(tmpInv)
        profile.CLevelCompleted = nud_Challenge.Value
        profile.CLevel1CodeUsed = cb_ShinyGeodude.Checked

        Select Case profileId
            Case 1
                profile1 = profile

            Case 2
                profile2 = profile

            Case 3
                profile3 = profile
        End Select
    End Sub

    Private Sub updateCurrentProfile()
        If rb_Profile1.Checked Then
            updateProfile(1)
        ElseIf rb_Profile2.Checked Then
            updateProfile(2)
        ElseIf rb_Profile3.Checked Then
            updateProfile(3)
        End If
    End Sub

    Private Sub resetPokeValues()
        lbl_ID.Text = "ID :"
        cb_Specie.SelectedIndex = -1
        nud_Level.Value = 1
        tb_Exp.Text = ""
        cb_Shiny.Checked = False
        cb_Move1.SelectedIndex = -1
        cb_Move2.SelectedIndex = -1
        cb_Move3.SelectedIndex = -1
        cb_Move4.SelectedIndex = -1
        rb_SelMove1.Checked = False
        rb_SelMove2.Checked = False
        rb_SelMove3.Checked = False
        rb_SelMove4.Checked = False
    End Sub

    Private Sub resetValues()
        lbl_Name.Text = ""
        tb_Name.Visible = False
        lb_Team.Items.Clear()
        nud_Badges.Value = 0
        tb_Money.Text = ""
        rb_Red.Checked = False
        rb_Blue.Checked = False
        lb_Team.SelectedIndex = -1
        nud_Attempted.Value = 0
        nud_Unlocked.Value = 0
        nud_Challenge.Value = 0
        cb_ShinyGeodude.Checked = False

        resetPokeDisplay()
    End Sub

    Private Sub resetPokeDisplay()
        For Each c As Control In gb_Pokemon.Controls
            If Not (c.Equals(lb_Team) OrElse c.Equals(b_AddPoke) OrElse c.Equals(b_Events)) Then
                c.Enabled = False
            End If
        Next c

        resetPokeValues()
    End Sub

    Private Sub enablePokeFields()
        For Each c As Control In gb_Pokemon.Controls
            c.Enabled = True
        Next c
    End Sub

    Private Sub resetDisplay()
        gb_Profiles.Enabled = False
        rb_Profile1.Checked = False
        rb_Profile2.Checked = False
        rb_Profile3.Checked = False

        b_SaveAccount.Enabled = False

        gb_Data.Enabled = False
        gb_Data.Text = "Données"
        b_DelOrCreateProfile.Enabled = False
        resetValues()
    End Sub

    Private Sub updatePokeData()
        tmpPoke.num = cb_Specie.SelectedIndex + 1
        tmpPoke.lvl = nud_Level.Value
        tmpPoke.exp = CInt(tb_Exp.Text)
        tmpPoke.shiny = cb_Shiny.Checked

        Dim tmpMoves As New List(Of Integer)
        Dim invalidMovesCnt As Integer = 0

        If cb_Move1.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(cb_Move1.SelectedIndex)

            If rb_SelMove1.Checked Then
                tmpPoke.moveSel = 1
            End If
        End If

        If cb_Move2.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(cb_Move2.SelectedIndex)

            If rb_SelMove2.Checked Then
                tmpPoke.moveSel = 2 - invalidMovesCnt
            End If
        End If

        If cb_Move3.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(cb_Move3.SelectedIndex)

            If rb_SelMove3.Checked Then
                tmpPoke.moveSel = 3 - invalidMovesCnt
            End If
        End If

        If cb_Move4.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(cb_Move4.SelectedIndex)

            If rb_SelMove4.Checked Then
                tmpPoke.moveSel = 4 - invalidMovesCnt
            End If
        End If

        If invalidMovesCnt = 4 Then
            tmpMoves.Add(1)
            tmpPoke.moveSel = 1
        End If

        tmpPoke.m = New List(Of Integer)(tmpMoves)
    End Sub

    Friend Sub addPokeToTeam(ByVal poke As Save.Pokemon, Optional ByVal autoIncrId As Boolean = True)
        If autoIncrId Then
            poke.id = If(tmpTeam.Count < 1, 1, tmpTeam.Max(New Func(Of Save.Pokemon, Integer)(Function(p As Save.Pokemon) p.id)) + 1)
        End If

        tmpTeam.Add(poke)
        lb_Team.Items.Add(PokemonList(poke.num))
        lb_Team.SelectedIndex = lb_Team.Items.Count - 1
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Pass.UseSystemPasswordChar = True

        For i = 1 To PokemonList.Length - 1
            cb_Specie.Items.Add(PokemonList(i))
        Next i

        cb_Move1.Items.AddRange(AttackList)
        cb_Move2.Items.AddRange(AttackList)
        cb_Move3.Items.AddRange(AttackList)
        cb_Move4.Items.AddRange(AttackList)

        Form2.cb_ItemList.Items.AddRange(ItemList)
    End Sub

    Private Sub b_ImportAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ImportAccount.Click
        lbl_Status.Text = "Chargement..."
        gb_Login.Refresh()

        Dim resultData As Dictionary(Of String, String)

        Try
            Dim tmpResult As String = ImportAccount(tb_Email.Text, tb_Pass.Text)
            resultData = GetDictionaryFromString(tmpResult)
        Catch
            MsgBox("Erreur lors de la récupération des données sur le serveur." & vbNewLine & _
                   "Veuillez réessayer.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Erreur")
            resetDisplay()
            lbl_Status.Text = "Erreur."
            Exit Sub
        End Try

        If resultData.ContainsKey("Result") AndAlso resultData("Result") = "Success" Then
            If resultData.ContainsKey("info1") AndAlso resultData("info1") <> "" Then
                profile1 = New Save(resultData("info1"))
                profile1Set = True
            Else
                profile1 = Nothing
                profile1Set = False
            End If

            If resultData.ContainsKey("info2") AndAlso resultData("info2") <> "" Then
                profile2 = New Save(resultData("info2"))
                profile2Set = True
            Else
                profile2 = Nothing
                profile2Set = False
            End If

            If resultData.ContainsKey("info3") AndAlso resultData("info3") <> "" Then
                profile3 = New Save(resultData("info3"))
                profile3Set = True
            Else
                profile3 = Nothing
                profile3Set = False
            End If

            gb_Profiles.Enabled = True
            'gb_Data.Enabled = True
            b_SaveAccount.Enabled = True

            rb_Profile1.Checked = False
            rb_Profile1.Checked = True

            lbl_Status.Text = "Chargement effectué."
        Else
            Dim complInfo As String = ""

            If resultData.ContainsKey("Reason") Then
                Select Case resultData("Reason")
                    Case "NotFound"
                        complInfo = " : compte inexistant ou mot de passe incorrect"

                    Case "DatabaseConnection"
                        complInfo = " : la base de données rencontre des problèmes"
                End Select
            End If

            resetDisplay()
            lbl_Status.Text = "Erreur."

            MsgBox("Erreur lors du chargement" & complInfo & "." & vbNewLine & _
                   "Veuillez réessayer.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Erreur lors du chargement.")
        End If
    End Sub

    Private Sub rb_Profile_CheckedChanged(ByVal sender As RadioButton, ByVal e As System.EventArgs) Handles rb_Profile1.CheckedChanged, rb_Profile2.CheckedChanged, rb_Profile3.CheckedChanged
        If Not sender.Checked Then Exit Sub

        Select Case sender.Tag.ToString()
            Case "1", "2", "3"
                gb_Data.Text = "Données (Profil " & sender.Tag.ToString() & ")"
                loadProfile(CInt(sender.Tag))

            Case Else
                rb_Profile1.Checked = True
        End Select
    End Sub

    Private Sub tb_Email_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_Email.KeyDown
        If e.KeyCode = Keys.Return Then
            b_ImportAccount.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_Pass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_Pass.KeyDown
        If e.KeyCode = Keys.Return Then
            b_ImportAccount.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub lbl_Name_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Name.DoubleClick
        tb_Name.Text = lbl_Name.Text
        tb_Name.Visible = True
        tb_Name.Focus()
    End Sub

    Private Sub tb_Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tb_Name.KeyDown
        If e.KeyCode = Keys.Return Then
            If tb_Name.Text.Length > 0 Then
                lbl_Name.Text = tb_Name.Text
                tb_Name.Visible = False
                e.SuppressKeyPress = True
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            tb_Name.Visible = False
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub tb_Money_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Money.KeyPress, tb_Exp.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse AscW(e.KeyChar) = 8 OrElse My.Computer.Keyboard.CtrlKeyDown)
    End Sub

    Private Sub lb_Team_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_Team.KeyDown
        If e.KeyCode = Keys.Delete Then
            b_DelPoke.PerformClick()
        End If
    End Sub

    Private Sub lb_Team_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_Team.SelectedIndexChanged
        updatingDisplay = True

        If lb_Team.SelectedIndex = -1 Then
            resetPokeDisplay()
        Else
            enablePokeFields()

            tmpPoke = tmpTeam(lb_Team.SelectedIndex)

            lbl_ID.Text = "ID : " & tmpPoke.id
            cb_Specie.SelectedIndex = tmpPoke.num - 1
            nud_Level.Value = tmpPoke.lvl
            tb_Exp.Text = tmpPoke.exp
            cb_Shiny.Checked = tmpPoke.shiny

            tmpMoveList = New List(Of Integer)(tmpPoke.m)
            While tmpMoveList.Count < 4
                tmpMoveList.Add(0)
            End While

            cb_Move1.SelectedIndex = tmpMoveList(0)
            cb_Move2.SelectedIndex = tmpMoveList(1)
            cb_Move3.SelectedIndex = tmpMoveList(2)
            cb_Move4.SelectedIndex = tmpMoveList(3)

            CType(gb_Moves.Controls.Find("rb_SelMove" & tmpPoke.moveSel, False)(0), RadioButton).Checked = True
        End If

        updatingDisplay = False
    End Sub

    Private Sub cb_Move_SelectedIndexChanged(ByVal sender As ComboBox, ByVal e As System.EventArgs) Handles cb_Move1.SelectedIndexChanged, cb_Move2.SelectedIndexChanged, cb_Move3.SelectedIndexChanged, cb_Move4.SelectedIndexChanged
        If cb_Move1.SelectedIndex = 0 AndAlso cb_Move2.SelectedIndex = 0 AndAlso cb_Move3.SelectedIndex = 0 AndAlso cb_Move4.SelectedIndex = 0 Then
            If Not updatingDisplay Then
                sender.SelectedIndex = tmpMoveList(CInt(sender.Tag) - 1)
                Beep()
            End If
        Else
            If Not updatingDisplay Then
                tmpMoveList(CInt(sender.Tag) - 1) = sender.SelectedIndex
            End If

            Dim tmpControl As Control = gb_Moves.Controls.Find("rb_SelMove" & sender.Tag.ToString, False)(0)

            If sender.SelectedIndex > 0 Then
                tmpControl.Enabled = True
            Else
                tmpControl.Enabled = False

                If CType(tmpControl, RadioButton).Checked Then
                    For i = 1 To 4
                        tmpControl = gb_Moves.Controls.Find("rb_SelMove" & i, False)(0)
                        If tmpControl.Enabled Then
                            CType(tmpControl, RadioButton).Checked = True
                            Exit For
                        End If
                    Next i
                End If
            End If
        End If
    End Sub

    Private Sub b_SavePoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_SavePoke.Click
        updatePokeData()

        tmpTeam(lb_Team.SelectedIndex) = tmpPoke
        'Dim tmpTopIndex As Integer = lb_Team.TopIndex
        lb_Team.Items(lb_Team.SelectedIndex) = PokemonList(tmpPoke.num)
        'lb_Team.TopIndex = tmpTopIndex
    End Sub

    Private Sub nud_Attempted_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nud_Attempted.ValueChanged
        nud_Unlocked.Maximum = nud_Attempted.Value
    End Sub

    Private Sub b_SaveProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_SaveProfile.Click
        If tb_Name.Visible AndAlso tb_Name.Text.Length > 0 Then
            lbl_Name.Text = tb_Name.Text
        End If

        tb_Name.Visible = False

        b_SavePoke.PerformClick()
        updateCurrentProfile()
    End Sub

    Private Sub b_EditInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_EditInv.Click
        Form2.ShowDialog()
    End Sub

    Private Sub b_SaveAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_SaveAccount.Click
        If Not MsgBox("Êtes vous sûr de vouloir mettre à jour la sauvegarde sur le serveur ?", _
                      MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, _
                      "Confirmation de l'envoi sur le serveur") = MsgBoxResult.Yes Then
            Exit Sub
        End If

        lbl_Status.Text = "Enregistrement..."
        gb_Login.Refresh()

        b_SaveProfile.PerformClick()

        Dim resultData As Dictionary(Of String, String)

        Try
            Dim tmpResult As String = SaveAccount(tb_Email.Text, tb_Pass.Text)
            resultData = GetDictionaryFromString(tmpResult)
        Catch
            MsgBox("Erreur lors de la sauvegarde sur le serveur." & vbNewLine & _
                   "Veuillez réessayer.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Erreur")

            lbl_Status.Text = "Erreur."
            Exit Sub
        End Try

        If resultData.ContainsKey("Result") AndAlso resultData("Result") = "Success" Then
            If resultData.ContainsKey("Reason") AndAlso resultData("Reason") = "saved" Then
                lbl_Status.Text = "Enregistrement effectué."

                MsgBox("Sauvegarde effectuée.", MsgBoxStyle.Information, "Sauvegarde effectuée.")
            End If
        Else
            Dim complInfo As String = ""

            If resultData.ContainsKey("Reason") Then
                Select Case resultData("Reason")
                    Case "NotFound"
                        complInfo = " : compte inexistant ou mot de passe incorrect"

                    Case "DatabaseConnection"
                        complInfo = " : la base de données rencontre des problèmes"
                End Select
            End If

            lbl_Status.Text = "Erreur."

            MsgBox("Erreur lors de la sauvegarde" & complInfo & "." & vbNewLine & _
                   "Veuillez réessayer.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Erreur lors de la sauvegarde.")
        End If
    End Sub

    Private Sub b_DelPoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DelPoke.Click
        Dim tmpIndex As Integer = lb_Team.SelectedIndex

        tmpTeam.RemoveAt(tmpIndex)
        lb_Team.Items.RemoveAt(tmpIndex)
        'lb_Team.Focus()
        lb_Team.SelectedIndex = If(tmpIndex < lb_Team.Items.Count, tmpIndex, lb_Team.Items.Count - 1)

        'sender.Focus()
    End Sub

    Private Sub b_AddPoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_AddPoke.Click
        tmpPoke = Save.Pokemon.NewEmpty()

        addPokeToTeam(tmpPoke)
    End Sub

    Private Sub b_PokeUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_PokeUp.Click
        Dim tmpIndex As Integer = lb_Team.SelectedIndex
        If tmpIndex < 1 Then Exit Sub

        tmpTeam.Insert(tmpIndex - 1, tmpTeam(tmpIndex))
        tmpTeam.RemoveAt(tmpIndex + 1)
        lb_Team.Items.Insert(tmpIndex - 1, lb_Team.Items(tmpIndex))
        lb_Team.Items.RemoveAt(tmpIndex + 1)
        lb_Team.SelectedIndex = tmpIndex - 1

        sender.Focus()
    End Sub

    Private Sub b_PokeDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_PokeDown.Click
        Dim tmpIndex As Integer = lb_Team.SelectedIndex
        If tmpIndex > lb_Team.Items.Count - 2 Then Exit Sub

        tmpTeam.Insert(tmpIndex + 2, tmpTeam(tmpIndex))
        tmpTeam.RemoveAt(tmpIndex)
        lb_Team.Items.Insert(tmpIndex + 2, lb_Team.Items(tmpIndex))
        lb_Team.Items.RemoveAt(tmpIndex)
        lb_Team.SelectedIndex = tmpIndex + 1

        sender.Focus()
    End Sub

    Private Sub b_Duplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Duplicate.Click
        tmpPoke.id = If(tmpTeam.Count < 1, 1, tmpTeam.Max(New Func(Of Save.Pokemon, Integer)(Function(p As Save.Pokemon) p.id)) + 1)

        tmpTeam.Insert(lb_Team.SelectedIndex + 1, tmpPoke)
        lb_Team.Items.Insert(lb_Team.SelectedIndex + 1, PokemonList(tmpPoke.num))
        lb_Team.SelectedIndex = lb_Team.SelectedIndex + 1
        'lb_Team.TopIndex = lb_Team.SelectedIndex + 1

        'sender.Focus()
    End Sub

    Private Sub b_DelOrCreateProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DelOrCreateProfile.Click
        If b_DelOrCreateProfile.Tag.ToString() = "Del" Then
            If MsgBox("Êtes-vous sûr de vouloir effacer ce profil ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Effacer le profil ?") = MsgBoxResult.Yes Then
                If rb_Profile1.Checked Then
                    profile1 = Nothing
                    profile1Set = False
                    rb_Profile1.Checked = False
                    rb_Profile1.Checked = True
                ElseIf rb_Profile2.Checked Then
                    profile2 = Nothing
                    profile2Set = False
                    rb_Profile2.Checked = False
                    rb_Profile2.Checked = True
                ElseIf rb_Profile3.Checked Then
                    profile3 = Nothing
                    profile3Set = False
                    rb_Profile3.Checked = False
                    rb_Profile3.Checked = True
                End If
            End If
        ElseIf b_DelOrCreateProfile.Tag.ToString() = "New" Then
            If rb_Profile1.Checked Then
                profile1 = Save.NewEmpty()
                profile1Set = True
                rb_Profile1.Checked = False
                rb_Profile1.Checked = True
            ElseIf rb_Profile2.Checked Then
                profile2 = Save.NewEmpty()
                profile2Set = True
                rb_Profile2.Checked = False
                rb_Profile2.Checked = True
            ElseIf rb_Profile3.Checked Then
                profile3 = Save.NewEmpty()
                profile3Set = True
                rb_Profile3.Checked = False
                rb_Profile3.Checked = True
            End If
        End If
    End Sub

    Private Sub llbl_Website_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_Website.LinkClicked
        System.Diagnostics.Process.Start("http://samdangames.blogspot.com/")
    End Sub

    Private Sub b_Events_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Events.Click
        Form3.ShowDialog()
    End Sub
End Class
