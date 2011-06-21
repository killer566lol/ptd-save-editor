Imports System.Net, System.Text, System.Text.Encoding
Imports System.Collections.Specialized
Imports System.IO

Public Class Form1_Main

#Region "Lists"
    Private Const MOVE_NONE As String = "(none)"

    Friend Shared PokemonList As String() = {"Bulbasaur", "Ivysaur", "Venusaur", "Charmander", _
                                             "Charmeleon", "Charizard", "Squirtle", "Wartortle", _
                                             "Blastoise", "Caterpie", "Metapod", "Butterfree", _
                                             "Weedle", "Kakuna", "Beedrill", "Pidgey", _
                                             "Pidgeotto", "Pidgeot", "Rattata", "Raticate", _
                                             "Spearow", "Fearow", "Ekans", "Arbok", _
                                             "Pikachu", "Raichu", "Sandshrew", "Sandslash", _
                                             "Nidoran" & ChrW(9792), "Nidorina", "Nidoqueen", "Nidoran" & ChrW(9794), _
                                             "Nidorino", "Nidoking", "Clefairy", "Clefable", _
                                             "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", _
                                             "Zubat", "Golbat", "Oddish", "Gloom", _
                                             "Vileplume", "Paras", "Parasect", "Venonat", _
                                             "Venomoth", "Diglett", "Dugtrio", "Meowth", _
                                             "Persian", "Psyduck", "Golduck", "Mankey", _
                                             "Primeape", "Growlithe", "Arcanine", "Poliwag", _
                                             "Poliwhirl", "Poliwrath", "Abra", "Kadabra", _
                                             "Alakazam", "Machop", "Machoke", "Machamp", _
                                             "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", _
                                             "Tentacruel", "Geodude", "Graveler", "Golem", _
                                             "Ponyta", "Rapidash", "Slowpoke", "Slowbro", _
                                             "Magnemite", "Magneton", "Farfetch'd", "Doduo", _
                                             "Dodrio", "Seel", "Dewgong", "Grimer", _
                                             "Muk", "Shellder", "Cloyster", "Gastly", _
                                             "Haunter", "Gengar", "Onix", "Drowzee", _
                                             "Hypno", "Krabby", "Kingler", "Voltorb", _
                                             "Electrode", "Exeggcute", "Exeggutor", "Cubone", _
                                             "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", _
                                             "Koffing", "Weezing", "Rhyhorn", "Rhydon", _
                                             "Chansey", "Tangela", "Kangaskhan", "Horsea", _
                                             "Seadra", "Goldeen", "Seaking", "Staryu", _
                                             "Starmie", "Mr. Mime", "Scyther", "Jynx", _
                                             "Electabuzz", "Magmar", "Pinsir", "Tauros", _
                                             "Magikarp", "Gyarados", "Lapras", "Ditto", _
                                             "Eevee", "Vaporeon", "Jolteon", "Flareon", _
                                             "Porygon", "Omanyte", "Omastar", "Kabuto", _
                                             "Kabutops", "Aerodactyl", "Snorlax", "Articuno", _
                                             "Zapdos", "Moltres", "Dratini", "Dragonair", _
                                             "Dragonite", "Mewtwo", "Mew", "Chikorita", _
                                             "Bayleef", "Meganium", "Cyndaquil", "Quilava", _
                                             "Typhlosion", "Totodile", "Croconaw", "Feraligatr", _
                                             "Sentret", "Furret", "Hoothoot", "Noctowl", _
                                             "Ledyba", "Ledian", "Spinarak", "Ariados", _
                                             "Crobat", "Chinchou", "Lanturn", "Pichu", _
                                             "Cleffa", "Igglybuff", "Togepi", "Togetic", _
                                             "Natu", "Xatu", "Mareep", "Flaaffy", _
                                             "Ampharos", "Bellossom", "Marill", "Azumarill", _
                                             "Sudowoodo", "Politoed", "Hoppip", "Skiploom", _
                                             "Jumpluff", "Aipom", "Sunkern", "Sunflora", _
                                             "Yanma", "Wooper", "Quagsire", "Espeon", _
                                             "Umbreon", "Murkrow", "Slowking", "Misdreavus", _
                                             "Unown", "Wobbuffet", "Girafarig", "Pineco", _
                                             "Forretress", "Dunsparce", "Gligar", "Steelix", _
                                             "Snubbull", "Granbull", "Qwilfish", "Scizor", _
                                             "Shuckle", "Heracross", "Sneasel", "Teddiursa", _
                                             "Ursaring", "Slugma", "Magcargo", "Swinub", _
                                             "Piloswine", "Corsola", "Remoraid", "Octillery", _
                                             "Delibird", "Mantine", "Skarmory", "Houndour", _
                                             "Houndoom", "Kingdra", "Phanpy", "Donphan", _
                                             "Porygon2", "Stantler", "Smeargle", "Tyrogue", _
                                             "Hitmontop", "Smoochum", "Elekid", "Magby", _
                                             "Miltank", "Blissey", "Raikou", "Entei", _
                                             "Suicune", "Larvitar", "Pupitar", "Tyranitar", _
                                             "Lugia", "Ho-Oh", "Celebi", "Treecko", _
                                             "Grovyle", "Sceptile", "Torchic", "Combusken", _
                                             "Blaziken", "Mudkip", "Marshtomp", "Swampert", _
                                             "Poochyena", "Mightyena", "Zigzagoon", "Linoone", _
                                             "Wurmple", "Silcoon", "Beautifly", "Cascoon", _
                                             "Dustox", "Lotad", "Lombre", "Ludicolo", _
                                             "Seedot", "Nuzleaf", "Shiftry", "Taillow", _
                                             "Swellow", "Wingull", "Pelipper", "Ralts", _
                                             "Kirlia", "Gardevoir", "Surskit", "Masquerain", _
                                             "Shroomish", "Breloom", "Slakoth", "Vigoroth", _
                                             "Slaking", "Nincada", "Ninjask", "Shedinja", _
                                             "Whismur", "Loudred", "Exploud", "Makuhita", _
                                             "Hariyama", "Azurill", "Nosepass", "Skitty", _
                                             "Delcatty", "Sableye", "Mawile", "Aron", _
                                             "Lairon", "Aggron", "Meditite", "Medicham", _
                                             "Electrike", "Manectric", "Plusle", "Minun", _
                                             "Volbeat", "Illumise", "Roselia", "Gulpin", _
                                             "Swalot", "Carvanha", "Sharpedo", "Wailmer", _
                                             "Wailord", "Numel", "Camerupt", "Torkoal", _
                                             "Spoink", "Grumpig", "Spinda", "Trapinch", _
                                             "Vibrava", "Flygon", "Cacnea", "Cacturne", _
                                             "Swablu", "Altaria", "Zangoose", "Seviper", _
                                             "Lunatone", "Solrock", "Barboach", "Whiscash", _
                                             "Corphish", "Crawdaunt", "Baltoy", "Claydol", _
                                             "Lileep", "Cradily", "Anorith", "Armaldo", _
                                             "Feebas", "Milotic", "Castform", "Kecleon", _
                                             "Shuppet", "Banette", "Duskull", "Dusclops", _
                                             "Tropius", "Chimecho", "Absol", "Wynaut", _
                                             "Snorunt", "Glalie", "Spheal", "Sealeo", _
                                             "Walrein", "Clamperl", "Huntail", "Gorebyss", _
                                             "Relicanth", "Luvdisc", "Bagon", "Shelgon", _
                                             "Salamence", "Beldum", "Metang", "Metagross", _
                                             "Regirock", "Regice", "Registeel", "Latias", _
                                             "Latios", "Kyogre", "Groudon", "Rayquaza", _
                                             "Jirachi", "Deoxys"}

    Friend Shared AttackList As String() = {MOVE_NONE, "Tackle", "Sand Attack", "Tail Whip", _
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
                                            "Bubblebeam", "Lucky Chant", "Body Slam", "Recover", _
                                            "Teleport", "Miracle Eye", "Ally Switch", "Lick", _
                                            "Lovely Kiss", "Powder Snow", "Ice Punch", "Heart Stamp", _
                                            "Swallow", "Slam", "Spit Up", "Double-Edge", _
                                            "Sand Tomb", "Safeguard", "Slash", "Knock Off", _
                                            "Leaf Tornado", "Aqua Tail", "Silver Wind", "Pin Missile", _
                                            "Super Fang", "Acid Spray", "Cosmic Power", "Mud Shot", _
                                            "Fake Tears", "Splash", "Thunderbolt", "Rest", _
                                            "Selfdestruct", "Tailwind", "Reflect", "Flail", _
                                            "Psychic", "Worry Seed", "Skull Bash", "Will-O-Wisp", _
                                            "Belly Drum", "Petal Dance", "DynamicPunch", "Bulldoze", _
                                            "Ice Fang", "Synthesis", "Roost", "Mud Bomb", _
                                            "Gyro Ball", "Flatter", "Acrobatics", "Moonlight", _
                                            "Swagger", "Iron Defense", "Rage Powder", "Endeavor", _
                                            "Feint", "Payback", "Telekinesis", "Thrash", _
                                            "Gastro Acid", "Stealth Rock", "Kyogre's Rest", "Fake Out", _
                                            "Faint Attack", "Taunt", "Pay Day", "Power Gem", _
                                            "Swords Dance", "Night Slash", "Poison Jab"}

    Friend Shared ItemList As String() = {"(none)", "Moon Stone", "Leaf Stone", "Thunderstone", _
                                          "Water Stone", "Fire Stone", "Old Rod"}

    Private Shared implementedPokemonList As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, _
                                                          11, 12, 13, 14, 15, 16, 17, 18, 19, 20, _
                                                          21, 22, 23, 24, 25, 26, 27, 28, 29, 30, _
                                                          31, 32, 33, 34, 35, 36, 37, 38, 39, 40, _
                                                          41, 42, 43, 44, 45, 46, 47, 52, 53, 56, _
                                                          57, 58, 59, 60, 61, 62, 63, 64, 65, 66, _
                                                          69, 70, 71, 72, 73, 74, 75, 76, 77, 81, _
                                                          83, 90, 95, 100, 116, 118, 120, 121, 124, 129, _
                                                          130, 151, 382}
#End Region

#Region "Definitions"
    Private profile1, profile2, profile3 As Save
    Private profile1Set, profile2Set, profile3Set As Boolean

    Friend tmpTeam As List(Of Save.Pokemon)
    Private tmpPoke As Save.Pokemon
    Private tmpMoveList As List(Of Integer)
    Friend tmpInv As List(Of Integer)
    Private previousPokeId As Integer = -1

    Private updatingDisplay As Boolean = False
    Private savingPoke As Boolean = False
    Private canSavePoke As Boolean = True

    Private Const SERVER_LINK As String = "http://www.sndgames.com/php/poke.php"
    Private Const SERVER_LINK_TRADE As String = "http://www.sndgames.com/php/trading.php"
    Private Const SERVER_LINK_ACHIEVEMENTS As String = "http://www.sndgames.com/php/achieve.php"
    Private Const USER_AGENT As String = "Mozilla/5.0 (Windows NT 6.1; rv:5.0) Gecko/20100101 Firefox/5.0"
    Private serverEncoding As Encoding = UTF8

    Private Const HEADER_PFL2 As String = "PFL2" & Chr(0) & Chr(0) & Chr(0) & Chr(0)
    Private Const HEADER_PKM2 As String = "PKM2" & Chr(0) & Chr(0) & Chr(0) & Chr(0)
    'Private Const HEADER_SAV2 As String = "SAV2" & Chr(0) & Chr(0) & Chr(0) & Chr(0)

    Friend achievements As String = "0000"
    Friend currentAchievements As String = "0000"

    Dim sortedPl(PokemonList.Length - 1) As String
    Dim sortedAl(AttackList.Length - 1) As String
    Dim sortedPlIndices As New List(Of Integer)
    Dim sortedAlIndices As New List(Of Integer)
#End Region

#Region "Structures and Enums"
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
            Public shiny As Boolean         ' Is Pokémon shiny ?
            Public m As List(Of Integer)    ' Move list
            Public moveSel As Byte          ' Currently selected move

            Public ReadOnly Property numMoves() As Integer ' Number of moves
                Get
                    Return If(m Is Nothing, 0, m.Count())
                End Get
            End Property

            Public ReadOnly Property fourMoves() As List(Of Integer)
                Get
                    Dim tmpMoveArr As Integer() = {0, 0, 0, 0}

                    For i As Integer = 0 To Me.numMoves - 1
                        tmpMoveArr(i) = Me.m(i)
                    Next i

                    Return New List(Of Integer)(tmpMoveArr)
                End Get
            End Property

            Public Sub New(ByVal dataStr As String)
                If dataStr.StartsWith(HEADER_PKM2) Then
                    dataStr = dataStr.Substring(HEADER_PKM2.Length)
                End If

                Dim pos As Integer = 0

                Dim dataArr As String() = dataStr.Split("|")

                Me.num = CInt(dataArr(pos))
                pos += 1
                Me.lvl = CInt(dataArr(pos))
                pos += 1
                Me.exp = CInt(dataArr(pos))
                pos += 1
                Dim _numMoves As Integer = CInt(dataArr(pos))

                If num > PokemonList.Length() OrElse _numMoves > 4 OrElse num < 0 OrElse _numMoves < 0 Then
                    Throw New Exception("Invalid Pokémon data.")
                End If

                pos += 1
                Me.shiny = (dataArr(pos) <> "0")
                pos += 1

                Me.m = New List(Of Integer)

                For m As Integer = 1 To _numMoves
                    If dataArr(pos) > AttackList.Length() OrElse dataArr(pos) < 0 Then
                        Throw New Exception("Move not implemented yet.")
                    End If

                    Me.m.Add(CInt(dataArr(pos)))

                    pos += 1
                Next m

                Me.moveSel = CInt(dataArr(pos))

                If moveSel > 4 OrElse moveSel < 0 Then
                    Throw New Exception("Invalid Pokémon data.")
                End If

                If Me.moveSel > Me.m.Count Then
                    Me.moveSel = Me.m.Count
                End If
            End Sub

            Public Shared Function NewEmpty() As Pokemon
                NewEmpty = New Save.Pokemon("1|1|0|1|0|1|1")
            End Function

            Public Function makeShiny() As Pokemon
                Me.shiny = True
                Return Me
            End Function

            Public Overrides Function ToString() As String
                ToString = Me.num & "|"
                ToString &= Me.lvl & "|"
                ToString &= Me.exp & "|"
                ToString &= Me.numMoves & "|"
                ToString &= If(Me.shiny, "1", "0") & "|"

                For Each mv As Integer In Me.m
                    ToString &= mv & "|"
                Next mv

                ToString &= Me.moveSel
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
        Public CLevel1CodeUsed As String    ' In-game events (as of v3.0 : Shiny Geodude, Jynx and Farfetch'd)

        Public Const EMPTY_ACCOUNT As String = "Satoshi|0|0|0|0|0|0|0|0|0"

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
            If dataStr.StartsWith(HEADER_PFL2) Then
                dataStr = dataStr.Substring(HEADER_PFL2.Length)
            End If

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

                If tmpPokeBuild.moveSel > tmpPokeBuild.m.Count Then
                    tmpPokeBuild.moveSel = tmpPokeBuild.m.Count
                End If

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
                Me.CLevel1CodeUsed = dataArr(pos)
                pos += 1
            Else
                Me.CLevelCompleted = 0
                Me.CLevel1CodeUsed = "0"
            End If
        End Sub

        Public Overrides Function ToString() As String
            If Me.name Is Nothing Then Return ""

            ToString = Me.name & "|"
            ToString &= Me.badges & "|"
            ToString &= Me.money & "|"
            ToString &= Me.unlocked & "|"
            ToString &= Me.levelAttempted & "|"
            ToString &= CStr(Me.ver) & "|"
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
            ToString &= "|" & Me.CLevel1CodeUsed
        End Function

        Public Shared Function NewEmpty() As Save
            Return New Save(EMPTY_ACCOUNT)
        End Function
    End Structure

    Private Enum FileTypes As Byte
        UNKNOWN = 0
        PFL2 = 1
        PKM2 = 2
        'SAV2 = 3
    End Enum
#End Region

#Region "Subs and Functions"
    Private Function GetTime() As Long
        Return Int((Date.UtcNow - New Date(1970, 1, 1)).TotalMilliseconds)
    End Function

    Private Function ServerRequest(ByVal values As NameValueCollection, ByVal uri As String, ByVal email As String, ByVal pass As String) As String
        Dim wc As New WebClient()
        values.Add("Email", email)
        values.Add("Pass", pass.Substring(0, Math.Min(pass.Length, 10)))
        wc.Headers.Add(HttpRequestHeader.UserAgent, USER_AGENT)

        Return serverEncoding.GetString(wc.UploadValues(uri & "?Date=" & GetTime(), values))
    End Function

    Private Function ImportAccount(ByVal email As String, ByVal pass As String) As String
        Dim nc As New NameValueCollection()
        nc.Add("Action", "importAccount")

        Return ServerRequest(nc, SERVER_LINK, email, pass)
    End Function

    Private Function GetAchievements(ByVal email As String, ByVal pass As String) As String
        Dim nc As New NameValueCollection()
        nc.Add("Action", "checkAccount")

        Return ServerRequest(nc, SERVER_LINK_ACHIEVEMENTS, email, pass)
    End Function

    Private Function SaveAccount(ByVal email As String, ByVal pass As String) As String
        Dim nc As New NameValueCollection()
        nc.Add("Action", "saveAccount")
        nc.Add("Info1", profile1.ToString())
        nc.Add("Info2", profile2.ToString())
        nc.Add("Info3", profile3.ToString())

        Return ServerRequest(nc, SERVER_LINK, email, pass)
    End Function

    Private Function UpdateAchievement(ByVal email As String, ByVal pass As String, ByVal pos As Integer) As String
        Dim nc As New NameValueCollection()
        nc.Add("Action", "updateAccount")
        nc.Add("type", "1")
        nc.Add("pos", CStr(pos))

        Return ServerRequest(nc, SERVER_LINK_ACHIEVEMENTS, email, pass)
    End Function

    Private Function CreateCode(ByVal poke As Save.Pokemon) As String
        Dim isShiny As String = If(poke.shiny, "1", "0")
        Dim moves As List(Of Integer) = poke.fourMoves()

        Dim nc As New NameValueCollection()
        nc.Add("Action", "createCode")
        nc.Add("Info1", "")
        nc.Add("Info2", "")
        nc.Add("Info3", "")
        nc.Add("Code", poke.num & poke.lvl & moves(0) & moves(1) & moves(2) & moves(3) & isShiny)
        nc.Add("num", poke.num)
        nc.Add("lvl", poke.lvl)
        nc.Add("shiny", isShiny)
        nc.Add("move1", moves(0))
        nc.Add("move2", moves(1))
        nc.Add("move3", moves(2))
        nc.Add("move4", moves(3))

        Return ServerRequest(nc, SERVER_LINK_TRADE, "accountforcodes", "gimmecodes")
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

        gb_Data.Text = "Data (Profile " & profileId.ToString() & ")"

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
            b_DelOrCreateProfile.Text = "Delete Profile"
            b_DelOrCreateProfile.Tag = "Del"
        Else
            gb_Data.Enabled = False
            b_DelOrCreateProfile.Text = "New Profile"
            b_DelOrCreateProfile.Tag = "New"
            Exit Sub
        End If

        lbl_Name.Text = profile.name

        nud_Badges.Value = profile.badges

        tb_Money.Text = profile.money

        lb_Team.Items.Clear()
        For Each p As Save.Pokemon In profile.team
            lb_Team.Items.Add(PokemonList(p.num - 1))
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
        cb_ShinyGeodude.Checked = profile.CLevel1CodeUsed(0) = "1"
        cb_Jynx.Checked = profile.CLevel1CodeUsed.Length > 1 AndAlso profile.CLevel1CodeUsed(1) = "1"
        cb_Farfetchd.Checked = profile.CLevel1CodeUsed.Length > 2 AndAlso profile.CLevel1CodeUsed(2) = "1"
    End Sub

    Private Sub updateProfile(ByVal profileId As Integer)
        Dim profile As Save

        Select Case profileId
            Case 1
                profile = profile1

            Case 2
                profile = profile2

            Case 3
                profile = profile3

            Case Else
                Exit Sub
        End Select

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
        profile.CLevel1CodeUsed = If(cb_ShinyGeodude.Checked, "1", "0") & _
                                  If(cb_Jynx.Checked, "1", "0") & _
                                  If(cb_Farfetchd.Checked, "1", "") & _
                                  If(profile.CLevel1CodeUsed.Length > 3, profile.CLevel1CodeUsed.Substring(3), "")

        Select Case profileId
            Case 1
                profile1 = profile

            Case 2
                profile2 = profile

            Case 3
                profile3 = profile
        End Select
    End Sub

    Private Function GetCurrentProfileNumber() As Integer
        If rb_Profile1.Checked Then
            Return 1
        ElseIf rb_Profile2.Checked Then
            Return 2
        ElseIf rb_Profile3.Checked Then
            Return 3
        Else
            Return 0
        End If
    End Function

    Private Sub updateCurrentProfile()
        updateProfile(GetCurrentProfileNumber())
    End Sub

    Private Sub resetPokeValues()
        previousPokeId = -1

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
        tb_PreviewCode.Text = ""
        tb_SecurityCode.Text = ""
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
        cb_Jynx.Checked = False

        resetPokeDisplay()
    End Sub

    Private Sub resetPokeDisplay()
        For Each c As Control In gb_Pokemon.Controls
            If Not (c.Equals(lb_Team) OrElse c.Equals(b_AddPoke)) Then
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
        gb_Data.Text = "Data"
        b_DelOrCreateProfile.Enabled = False
        b_Achievements.Enabled = False
        b_ImportProfile.Enabled = False
        resetValues()
    End Sub

    Private Sub saveCurrentPokeData()
        tmpPoke.num = If(cb_SortAlpha.Checked, sortedPlIndices(cb_Specie.SelectedIndex) + 1, cb_Specie.SelectedIndex + 1)
        tmpPoke.lvl = nud_Level.Value
        tmpPoke.exp = CInt(tb_Exp.Text)
        tmpPoke.shiny = cb_Shiny.Checked

        Dim tmpMoves As New List(Of Integer)
        Dim invalidMovesCnt As Integer = 0

        If cb_Move1.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(If(cb_SortAlpha.Checked, sortedAlIndices(cb_Move1.SelectedIndex), cb_Move1.SelectedIndex))

            If rb_SelMove1.Checked Then
                tmpPoke.moveSel = 1
            End If
        End If

        If cb_Move2.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(If(cb_SortAlpha.Checked, sortedAlIndices(cb_Move2.SelectedIndex), cb_Move2.SelectedIndex))

            If rb_SelMove2.Checked Then
                tmpPoke.moveSel = 2 - invalidMovesCnt
            End If
        End If

        If cb_Move3.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(If(cb_SortAlpha.Checked, sortedAlIndices(cb_Move3.SelectedIndex), cb_Move3.SelectedIndex))

            If rb_SelMove3.Checked Then
                tmpPoke.moveSel = 3 - invalidMovesCnt
            End If
        End If

        If cb_Move4.SelectedIndex < 1 Then
            invalidMovesCnt += 1
        Else
            tmpMoves.Add(If(cb_SortAlpha.Checked, sortedAlIndices(cb_Move4.SelectedIndex), cb_Move4.SelectedIndex))

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

    Private Sub savePokeData(ByVal pkmId As Integer)
        If Not canSavePoke Then Exit Sub

        savingPoke = True

        saveCurrentPokeData()

        tmpTeam(pkmId) = tmpPoke
        lb_Team.Items(pkmId) = PokemonList(tmpPoke.num - 1)

        savingPoke = False
    End Sub

    Private Sub updatePokeData()
        updatingDisplay = True

        If lb_Team.SelectedIndex = -1 Then
            resetPokeDisplay()
        Else
            enablePokeFields()

            tmpPoke = tmpTeam(lb_Team.SelectedIndex)

            lbl_ID.Text = "ID : " & tmpPoke.id
            cb_Specie.SelectedIndex = If(cb_SortAlpha.Checked, sortedPlIndices.IndexOf(tmpPoke.num - 1), tmpPoke.num - 1)
            nud_Level.Value = tmpPoke.lvl
            tb_Exp.Text = tmpPoke.exp
            cb_Shiny.Checked = tmpPoke.shiny

            tmpMoveList = tmpPoke.fourMoves()

            cb_Move1.SelectedIndex = If(cb_SortAlpha.Checked, sortedAlIndices.IndexOf(tmpMoveList(0)), tmpMoveList(0))
            cb_Move2.SelectedIndex = If(cb_SortAlpha.Checked, sortedAlIndices.IndexOf(tmpMoveList(1)), tmpMoveList(1))
            cb_Move3.SelectedIndex = If(cb_SortAlpha.Checked, sortedAlIndices.IndexOf(tmpMoveList(2)), tmpMoveList(2))
            cb_Move4.SelectedIndex = If(cb_SortAlpha.Checked, sortedAlIndices.IndexOf(tmpMoveList(3)), tmpMoveList(3))

            CType(gb_Moves.Controls("rb_SelMove" & tmpPoke.moveSel), RadioButton).Checked = True
        End If

        updatingDisplay = False
    End Sub

    Friend Sub addPokeToTeam(ByVal poke As Save.Pokemon, Optional ByVal autoIncrId As Boolean = True)
        If autoIncrId Then
            poke.id = If(tmpTeam.Count < 1, 1, tmpTeam.Max(New Func(Of Save.Pokemon, Integer)(Function(p As Save.Pokemon) p.id)) + 1)
        End If

        tmpTeam.Add(poke)
        lb_Team.Items.Add(PokemonList(poke.num - 1))
        lb_Team.SelectedIndex = lb_Team.Items.Count - 1
    End Sub

    Private Function VersionProg() As String
        With System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location)

            If .FileBuildPart = 0 Then

                If .FilePrivatePart = 0 Then
                    VersionProg = .FileMajorPart & "." & .FileMinorPart
                Else
                    VersionProg = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart & "." & .FilePrivatePart
                End If

            Else

                If .FilePrivatePart = 0 Then
                    VersionProg = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart
                Else
                    VersionProg = .FileMajorPart & "." & .FileMinorPart & "." & .FileBuildPart & "." & .FilePrivatePart
                End If

            End If
        End With

#If BETA Then
        VersionProg &= " beta"
#End If
    End Function

    Private Sub refreshSprite()
        Dim rm As Resources.ResourceManager = New Resources.ResourceManager("PTD_Save_Editor.Resources", GetType(Form1_Main).Assembly)
        PictureBox1.Image = CType(rm.GetObject("_" & If(cb_SortAlpha.Checked AndAlso cb_Specie.SelectedIndex > -1, sortedPlIndices(cb_Specie.SelectedIndex) + 1, cb_Specie.SelectedIndex + 1) & If(cb_Shiny.Checked, "s", "")), Drawing.Bitmap)
        If PictureBox1.Image Is Nothing Then
            PictureBox1.Image = PictureBox1.ErrorImage
        End If
    End Sub

    Private Sub sortLists(ByVal sorted As Boolean)
        Dim oldPokeValue As Integer = cb_Specie.SelectedIndex, _
            oldMove1Value As Integer = cb_Move1.SelectedIndex, _
            oldMove2Value As Integer = cb_Move2.SelectedIndex, _
            oldMove3Value As Integer = cb_Move3.SelectedIndex, _
            oldMove4Value As Integer = cb_Move4.SelectedIndex

        cb_Specie.Items.Clear()
        cb_Move1.Items.Clear()
        cb_Move2.Items.Clear()
        cb_Move3.Items.Clear()
        cb_Move4.Items.Clear()

        If sorted Then
            cb_Specie.Items.AddRange(sortedPl)
            cb_Specie.SelectedIndex = sortedPlIndices.IndexOf(oldPokeValue)

            cb_Move1.Items.AddRange(sortedAl)
            cb_Move1.SelectedIndex = sortedAlIndices.IndexOf(oldMove1Value)

            cb_Move2.Items.AddRange(sortedAl)
            cb_Move2.SelectedIndex = sortedAlIndices.IndexOf(oldMove2Value)

            cb_Move3.Items.AddRange(sortedAl)
            cb_Move3.SelectedIndex = sortedAlIndices.IndexOf(oldMove3Value)

            cb_Move4.Items.AddRange(sortedAl)
            cb_Move4.SelectedIndex = sortedAlIndices.IndexOf(oldMove4Value)
        Else
            cb_Specie.Items.AddRange(PokemonList)
            cb_Specie.SelectedIndex = sortedPlIndices(oldPokeValue)

            cb_Move1.Items.AddRange(AttackList)
            cb_Move1.SelectedIndex = sortedAlIndices(oldMove1Value)

            cb_Move2.Items.AddRange(AttackList)
            cb_Move2.SelectedIndex = sortedAlIndices(oldMove2Value)

            cb_Move3.Items.AddRange(AttackList)
            cb_Move3.SelectedIndex = sortedAlIndices(oldMove3Value)

            cb_Move4.Items.AddRange(AttackList)
            cb_Move4.SelectedIndex = sortedAlIndices(oldMove4Value)
        End If
    End Sub

    Private Sub saveCurrentProfile()
        If tb_Name.Visible AndAlso tb_Name.Text.Length > 0 Then
            lbl_Name.Text = tb_Name.Text
        End If

        tb_Name.Visible = False

        b_SavePoke.PerformClick()
        updateCurrentProfile()
    End Sub

    Private Function GetCurrentProfile() As Save
        If rb_Profile2.Checked Then
            Return profile2
        ElseIf rb_Profile3.Checked Then
            Return profile3
        Else
            Return profile1
        End If
    End Function

    Private Sub setCurrentProfile(ByVal profile As Save)
        If rb_Profile1.Checked Then
            profile1 = profile
            profile1Set = True
            loadProfile(1)
        ElseIf rb_Profile2.Checked Then
            profile2 = profile
            profile2Set = True
            loadProfile(2)
        ElseIf rb_Profile3.Checked Then
            profile3 = profile
            profile3Set = True
            loadProfile(3)
        End If
    End Sub

    Private Function ReplaceInvalidFileNameChars(ByVal fileName As String) As String
        For Each c As Char In Path.GetInvalidFileNameChars
            fileName = fileName.Replace(c, "_"c)
        Next c

        Return fileName
    End Function

    Private Function GetFileType(ByVal fileName As String) As FileTypes
        Dim fileContents As String = File.ReadAllText(fileName, UTF8)

        If fileContents.StartsWith(HEADER_PFL2) Then
            Return FileTypes.PFL2
        ElseIf fileContents.StartsWith(HEADER_PKM2) Then
            Return FileTypes.PKM2
            'ElseIf fileContents.StartsWith(HEADER_SAV2) Then
            '    Return FileTypes.SAV2
        Else
            Return FileTypes.UNKNOWN
        End If
    End Function

    Private Sub exportPKM2(ByVal fileName As String, ByVal poke As Save.Pokemon)
        File.WriteAllText(fileName, HEADER_PKM2 & poke.ToString(), Encoding.UTF8)
    End Sub

    Private Sub importMultiplePKM2(ByVal fileNames As String())
        For Each fileName As String In fileNames
            Try
                addPokeToTeam(New Save.Pokemon(File.ReadAllText(fileName, Encoding.UTF8)))
            Catch ex As Exception
                If fileNames.Length = 1 Then
                    MsgBox("This file is not a valid .ptdpkm file." & vbNewLine & vbNewLine & _
                           "Error was : " & ex.Message, MsgBoxStyle.Critical, "Invalid Pokémon file")
                End If
            End Try
        Next fileName
    End Sub

    Private Sub exportPFL2(ByVal fileName As String, ByVal profile As Save)
        File.WriteAllText(fileName, HEADER_PFL2 & profile.ToString(), Encoding.UTF8)
    End Sub

    Private Sub importPFL2(ByVal fileName As String)
        Try
            setCurrentProfile(New Save(File.ReadAllText(fileName, Encoding.UTF8)))
        Catch ex As Exception
            MsgBox("This file is not a valid .ptdpfl file." & vbNewLine & vbNewLine & _
                   "Error was : " & ex.Message, MsgBoxStyle.Critical, "Invalid profile file")
        End Try
    End Sub
#End Region

#Region "Events"
    Private Sub Form1_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_Pass.UseSystemPasswordChar = True

        Me.Text = Me.Text.Replace("{version}", VersionProg())
        lbl_ProgramVersion.Text = lbl_ProgramVersion.Text.Replace("{version}", VersionProg())

        cb_Specie.Items.AddRange(PokemonList)

        cb_Move1.Items.AddRange(AttackList)
        cb_Move2.Items.AddRange(AttackList)
        cb_Move3.Items.AddRange(AttackList)
        cb_Move4.Items.AddRange(AttackList)

        For i As Integer = 0 To PokemonList.Length - 1
            sortedPlIndices.Add(i)
        Next i

        For i As Integer = 0 To AttackList.Length - 1
            sortedAlIndices.Add(i)
        Next i

        Array.Copy(PokemonList, sortedPl, PokemonList.Length)
        Array.Copy(AttackList, sortedAl, AttackList.Length)

        Dim tmpIndices As Integer() = sortedAlIndices.ToArray()
        Array.Sort(sortedAl, tmpIndices)
        sortedAlIndices = New List(Of Integer)(tmpIndices)

        tmpIndices = sortedPlIndices.ToArray()
        Array.Sort(sortedPl, tmpIndices)
        sortedPlIndices = New List(Of Integer)(tmpIndices)

        Form2_Inv_Adv.cb_ItemList.Items.AddRange(ItemList)

        PictureBox1.Image = PictureBox1.ErrorImage

        gb_Data.AllowDrop = True
        gb_Pokemon.AllowDrop = True
    End Sub

    Private Sub Form1_Main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            b_SaveProfile.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub b_ImportAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ImportAccount.Click
        lbl_Status.Text = "Loading savefile..."
        gb_Login.Refresh()

        Dim resultData, achiev As Dictionary(Of String, String)

        Try
            resultData = GetDictionaryFromString(ImportAccount(tb_Email.Text, tb_Pass.Text))

            lbl_Status.Text = "Loading achievements..."
            gb_Login.Refresh()
            achiev = GetDictionaryFromString(GetAchievements(tb_Email.Text, tb_Pass.Text))
        Catch
            MsgBox("An error occurred while fetching data from the server." & vbNewLine & _
                   "Please retry.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
            resetDisplay()
            lbl_Status.Text = "Error."
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

            If achiev.ContainsKey("Result") AndAlso achiev("Result") = "Success" AndAlso achiev.ContainsKey("Ach1") Then
                achievements = achiev("Ach1")
                currentAchievements = achievements
            End If

            gb_Profiles.Enabled = True
            b_SaveAccount.Enabled = True

            b_Achievements.Enabled = True
            b_ImportProfile.Enabled = True

            rb_Profile1.Checked = False
            rb_Profile1.Checked = True

            lbl_Status.Text = "Load complete."
        Else
            Dim complInfo As String = ""

            If resultData.ContainsKey("Reason") Then
                Select Case resultData("Reason")
                    Case "NotFound"
                        complInfo = " : account doesn't exist or wrong password"

                    Case "DatabaseConnection"
                        complInfo = " : database is experiencing problems"
                End Select
            End If

            resetDisplay()
            lbl_Status.Text = "Error."

            MsgBox("An error occurred while loading" & complInfo & "." & vbNewLine & _
                   "Please retry.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error.")
        End If
    End Sub

    Private Sub rb_Profile_CheckedChanged(ByVal sender As RadioButton, ByVal e As System.EventArgs) Handles rb_Profile1.CheckedChanged, rb_Profile2.CheckedChanged, rb_Profile3.CheckedChanged
        If Not sender.Checked Then Exit Sub

        Select Case sender.Tag.ToString()
            Case "1", "2", "3"
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

    Private Sub tb_Numeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tb_Money.KeyPress, tb_Exp.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse AscW(e.KeyChar) = 8 OrElse My.Computer.Keyboard.CtrlKeyDown)
    End Sub

    Private Sub lb_Team_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lb_Team.KeyDown
        If e.KeyCode = Keys.Delete Then
            b_DelPoke.PerformClick()
        End If
    End Sub

    Private Sub lb_Team_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lb_Team.SelectedIndexChanged
        If savingPoke Then Exit Sub

        If previousPokeId >= 0 Then
            savePokeData(previousPokeId)
        End If

        previousPokeId = lb_Team.SelectedIndex

        updatePokeData()
    End Sub

    Private Sub cb_Move_SelectedIndexChanged(ByVal sender As ComboBox, ByVal e As System.EventArgs) Handles cb_Move1.SelectedIndexChanged, cb_Move2.SelectedIndexChanged, cb_Move3.SelectedIndexChanged, cb_Move4.SelectedIndexChanged
        If cb_Move1.SelectedIndex = 0 AndAlso cb_Move2.SelectedIndex = 0 AndAlso cb_Move3.SelectedIndex = 0 AndAlso cb_Move4.SelectedIndex = 0 Then
            If Not updatingDisplay Then
                sender.SelectedIndex = If(cb_SortAlpha.Checked, sortedAlIndices.IndexOf(tmpMoveList(CInt(sender.Tag) - 1)), tmpMoveList(CInt(sender.Tag) - 1))
                Beep()
            End If
        Else
            If Not updatingDisplay Then
                tmpMoveList(CInt(sender.Tag) - 1) = If(cb_SortAlpha.Checked AndAlso sender.SelectedIndex > -1, sortedAlIndices(sender.SelectedIndex), sender.SelectedIndex)
            End If

            Dim tmpControl As Control = gb_Moves.Controls("rb_SelMove" & sender.Tag.ToString)

            If sender.SelectedIndex > 0 Then
                tmpControl.Enabled = True
            Else
                tmpControl.Enabled = False

                If CType(tmpControl, RadioButton).Checked Then
                    For i = 1 To 4
                        tmpControl = gb_Moves.Controls("rb_SelMove" & i)
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
        savePokeData(lb_Team.SelectedIndex)
        updatePokeData()
    End Sub

    Private Sub nud_Attempted_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nud_Attempted.ValueChanged
        nud_Unlocked.Maximum = nud_Attempted.Value
    End Sub

    Private Sub b_SaveProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_SaveProfile.Click
        saveCurrentProfile()
    End Sub

    Private Sub b_EditInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_EditInv.Click
        Form2_Inv.ShowDialog()
    End Sub

    Private Sub b_SaveAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_SaveAccount.Click
        If Not MsgBox("Are you sure you want to update the save on the server ?", _
                      MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, _
                      "Confirm") = MsgBoxResult.Yes Then
            Exit Sub
        End If

        lbl_Status.Text = "Saving savefile..."
        gb_Login.Refresh()

        b_SaveProfile.PerformClick()

        Dim resultData, achiev As Dictionary(Of String, String)

        Try
            resultData = GetDictionaryFromString(SaveAccount(tb_Email.Text, tb_Pass.Text))

            lbl_Status.Text = "Saving achievements..."
            gb_Login.Refresh()

            Dim tmpAchievements As String = achievements

            For i As Integer = 0 To currentAchievements.Length - 1
                If achievements(i) = "0"c AndAlso currentAchievements(i) <> "0"c Then
                    achiev = GetDictionaryFromString(UpdateAchievement(tb_Email.Text, tb_Pass.Text, i))

                    If achiev.ContainsKey("Result") AndAlso achiev("Result") = "Success" AndAlso achiev.ContainsKey("Ach1") Then
                        tmpAchievements = achiev("Ach1")
                    End If
                End If
            Next i

            achievements = tmpAchievements
            currentAchievements = tmpAchievements
        Catch
            MsgBox("An error occurred while updating the save on the server." & vbNewLine & _
                   "Please retry.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")

            lbl_Status.Text = "Error."
            Exit Sub
        End Try

        If resultData.ContainsKey("Result") AndAlso resultData("Result") = "Success" Then
            If resultData.ContainsKey("Reason") AndAlso resultData("Reason") = "saved" Then
                lbl_Status.Text = "Save successful."

                MsgBox("Save successful.", MsgBoxStyle.Information, "Save successful.")
            End If
        Else
            Dim complInfo As String = ""

            If resultData.ContainsKey("Reason") Then
                Select Case resultData("Reason")
                    Case "NotFound"
                        complInfo = " : account doesn't exist or wrong password"

                    Case "DatabaseConnection"
                        complInfo = " : database is experiencing problems"
                End Select
            End If

            lbl_Status.Text = "Error."

            MsgBox("An error occurred while saving" & complInfo & "." & vbNewLine & _
                   "Please retry.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error.")
        End If
    End Sub

    Private Sub b_DelPoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DelPoke.Click
        Dim tmpIndex As Integer = lb_Team.SelectedIndex

        canSavePoke = False

        tmpTeam.RemoveAt(tmpIndex)
        lb_Team.Items.RemoveAt(tmpIndex)
        lb_Team.SelectedIndex = If(tmpIndex < lb_Team.Items.Count, tmpIndex, lb_Team.Items.Count - 1)

        canSavePoke = True
    End Sub

    Private Sub b_AddPoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_AddPoke.Click
        tmpPoke = Save.Pokemon.NewEmpty()

        addPokeToTeam(tmpPoke)
    End Sub

    Private Sub b_PokeUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_PokeUp.Click
        Dim tmpIndex As Integer = lb_Team.SelectedIndex
        If tmpIndex < 1 Then Exit Sub

        canSavePoke = False
        saveCurrentPokeData()

        tmpTeam.Insert(tmpIndex - 1, tmpTeam(tmpIndex))
        tmpTeam.RemoveAt(tmpIndex + 1)
        lb_Team.Items.Insert(tmpIndex - 1, lb_Team.Items(tmpIndex))
        lb_Team.Items.RemoveAt(tmpIndex + 1)
        lb_Team.SelectedIndex = tmpIndex - 1

        sender.Focus()

        canSavePoke = True
    End Sub

    Private Sub b_PokeDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_PokeDown.Click
        Dim tmpIndex As Integer = lb_Team.SelectedIndex
        If tmpIndex > lb_Team.Items.Count - 2 Then Exit Sub

        canSavePoke = False
        saveCurrentPokeData()

        tmpTeam.Insert(tmpIndex + 2, tmpTeam(tmpIndex))
        tmpTeam.RemoveAt(tmpIndex)
        lb_Team.Items.Insert(tmpIndex + 2, lb_Team.Items(tmpIndex))
        lb_Team.Items.RemoveAt(tmpIndex)
        lb_Team.SelectedIndex = tmpIndex + 1

        sender.Focus()

        canSavePoke = True
    End Sub

    Private Sub b_Duplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Duplicate.Click
        saveCurrentPokeData()
        tmpPoke.id = If(tmpTeam.Count < 1, 1, tmpTeam.Max(New Func(Of Save.Pokemon, Integer)(Function(p As Save.Pokemon) p.id)) + 1)

        tmpTeam.Insert(lb_Team.SelectedIndex + 1, tmpPoke)
        lb_Team.Items.Insert(lb_Team.SelectedIndex + 1, PokemonList(tmpPoke.num - 1))
        lb_Team.SelectedIndex = lb_Team.SelectedIndex + 1
    End Sub

    Private Sub b_DelOrCreateProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_DelOrCreateProfile.Click
        If b_DelOrCreateProfile.Tag.ToString() = "Del" Then
            If MsgBox("Are you sure you want to delete this profile ?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Delete profile ?") = MsgBoxResult.Yes Then
                If rb_Profile1.Checked Then
                    profile1 = Nothing
                    profile1Set = False
                    loadProfile(1)
                ElseIf rb_Profile2.Checked Then
                    profile2 = Nothing
                    profile2Set = False
                    loadProfile(2)
                ElseIf rb_Profile3.Checked Then
                    profile3 = Nothing
                    profile3Set = False
                    loadProfile(3)
                End If
            End If
        ElseIf b_DelOrCreateProfile.Tag.ToString() = "New" Then
            If rb_Profile1.Checked Then
                profile1 = Save.NewEmpty()
                profile1Set = True
                loadProfile(1)
            ElseIf rb_Profile2.Checked Then
                profile2 = Save.NewEmpty()
                profile2Set = True
                loadProfile(2)
            ElseIf rb_Profile3.Checked Then
                profile3 = Save.NewEmpty()
                profile3Set = True
                loadProfile(3)
            End If
        End If
    End Sub

    Private Sub llbl_Sam_Blog_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_Sam_Blog.LinkClicked
        System.Diagnostics.Process.Start("http://samdangames.blogspot.com/")
    End Sub

    Private Sub b_Events_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Events.Click
        Form3_Evts.ShowDialog()
    End Sub

    Private Sub tb_Numeric_LostFocus(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles tb_Money.LostFocus, tb_Exp.LostFocus
        If sender.Text = "" Then
            sender.Text = "0"
        Else
            Dim sb As New StringBuilder(sender.Text.Length - 1)

            For Each c As Char In sender.Text
                If Char.IsDigit(c) Then sb.Append(c)
            Next c

            If sb.Length = 0 Then sb.Append("0"c)

            sender.Text = Int(sb.ToString())
        End If
    End Sub

    Private Sub cb_Specie_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Specie.SelectedIndexChanged
        lbl_NotYetImplemented.Visible = cb_Specie.SelectedIndex > -1 AndAlso Not implementedPokemonList.Contains(If(cb_SortAlpha.Checked, sortedPlIndices(cb_Specie.SelectedIndex) + 1, cb_Specie.SelectedIndex + 1))
        refreshSprite()
    End Sub

    Private Sub tb_PreviewCode_Click(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles tb_PreviewCode.Click, tb_SecurityCode.Click
        sender.SelectAll()
    End Sub

    Private Sub b_GenerateCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_GenerateCode.Click
        saveCurrentPokeData()

        Dim resultData As Dictionary(Of String, String)

        tb_PreviewCode.Text = ""
        tb_SecurityCode.Text = ""
        tb_PreviewCode.BackColor = Drawing.SystemColors.Control

        Try
            Dim tmpResult As String = CreateCode(tmpPoke)
            resultData = GetDictionaryFromString(tmpResult)
        Catch
            tb_PreviewCode.Text = "Erreur, réessayez."

            Exit Sub
        End Try

        If resultData.ContainsKey("Result") AndAlso resultData("Result") = "Success" Then
            If resultData.ContainsKey("Reason") AndAlso resultData("Reason") = "saved" Then
                If resultData.ContainsKey("PreviewCode") Then tb_PreviewCode.Text = resultData("PreviewCode")
                If resultData.ContainsKey("SecurityCode") Then tb_SecurityCode.Text = resultData("SecurityCode")
            End If
        Else
            Dim complInfo As String = ""

            If resultData.ContainsKey("Reason") Then
                complInfo = " : " & resultData("Reason")
            End If

            tb_PreviewCode.BackColor = Drawing.Color.Salmon

            tb_PreviewCode.Text = "Err" & complInfo
        End If
    End Sub

    Private Sub b_CopyCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_CopyCode.Click
        If tb_SecurityCode.Text <> "" AndAlso tb_PreviewCode.Text <> "" Then
            Clipboard.SetText(tb_PreviewCode.Text & vbTab & tb_SecurityCode.Text)
        End If
    End Sub

    Private Sub tb_SecurityCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_SecurityCode.TextChanged
        b_CopyCode.Enabled = tb_SecurityCode.Text <> "" AndAlso tb_PreviewCode.Text <> ""
    End Sub

    Private Sub nud_Level_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nud_Level.ValueChanged
        Try
            lbl_MaxExp.Text = "/" & Math.Pow(nud_Level.Value, 3)
        Catch
            lbl_MaxExp.Text = ""
        End Try
    End Sub

    Private Sub b_Achievements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_Achievements.Click
        Form4_Achvts.ShowDialog()
    End Sub

    Private Sub cb_Shiny_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Shiny.CheckedChanged
        refreshSprite()
    End Sub

    Private Sub b_CancelPoke_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_CancelPoke.Click
        updatePokeData()
    End Sub

    Private Sub llbl_PTDSE_Website_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llbl_PTDSE_Website.LinkClicked
        System.Diagnostics.Process.Start("http://code.google.com/p/ptd-save-editor/")
    End Sub

    Private Sub cb_SortAlpha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_SortAlpha.CheckedChanged
        sortLists(cb_SortAlpha.Checked)
    End Sub

    Private Sub b_ExportPkm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ExportPkm.Click
        Dim sfd As New SaveFileDialog()
        sfd.AddExtension = True
        sfd.OverwritePrompt = True
        sfd.DefaultExt = ".ptdpkm"
        sfd.FileName = ReplaceInvalidFileNameChars(PokemonList(cb_Specie.SelectedIndex))
        sfd.Filter = "PTD Pokémon file|*.ptdpkm"
        sfd.Title = "Save Pokémon file as..."

        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            saveCurrentPokeData()
            exportPKM2(sfd.FileName, tmpPoke)
        End If
    End Sub

    Private Sub b_ImportPkm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ImportPkm.Click
        Dim ofd As New OpenFileDialog()
        ofd.AddExtension = True
        ofd.CheckFileExists = True
        ofd.DefaultExt = ".ptdpkm"
        ofd.FileName = ""
        ofd.Filter = "PTD Pokémon file|*.ptdpkm"
        ofd.Multiselect = True
        ofd.Title = "Please choose one or more Pokémon files..."

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
             importMultiplePKM2(ofd.FileNames)
        End If
    End Sub

    Private Sub gb_Pokemon_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gb_Pokemon.DragDrop
        Dim fileNames As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())

        If GetFileType(fileNames(0)) = FileTypes.PFL2 Then
            importPFL2(fileNames(0))
        Else
            importMultiplePKM2(fileNames)
        End If
    End Sub

    Private Sub gb_Pokemon_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gb_Pokemon.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub b_ExportProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ExportProfile.Click
        Dim sfd As New SaveFileDialog()
        sfd.AddExtension = True
        sfd.OverwritePrompt = True
        sfd.DefaultExt = ".ptdpfl"
        sfd.FileName = ReplaceInvalidFileNameChars("Profile_" & GetCurrentProfileNumber() & "_" & lbl_Name.Text)
        sfd.Filter = "PTD profile file|*.ptdpfl"
        sfd.Title = "Save profile file as......"

        If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            saveCurrentProfile()
            exportPFL2(sfd.FileName, GetCurrentProfile())
        End If
    End Sub

    Private Sub b_ImportProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ImportProfile.Click
        Dim ofd As New OpenFileDialog()
        ofd.AddExtension = True
        ofd.CheckFileExists = True
        ofd.DefaultExt = ".ptdpfl"
        ofd.FileName = ""
        ofd.Filter = "PTD profile file|*.ptdpfl"
        ofd.Title = "Please choose a profile file..."

        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            importPFL2(ofd.FileName)
        End If
    End Sub

    Private Sub gb_Data_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gb_Data.DragDrop
        Dim fileNames As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())

        importPFL2(fileNames(0))
    End Sub

    Private Sub gb_Data_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gb_Data.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
#End Region
End Class
