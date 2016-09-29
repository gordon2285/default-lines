<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SportSelectBox = New System.Windows.Forms.ComboBox()
        Me.LblSportSelect = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.SoccerTabPage = New System.Windows.Forms.TabPage()
        Me.Soccer_AFav_HTot = New System.Windows.Forms.Button()
        Me.Soccer_HFav_HTot = New System.Windows.Forms.Button()
        Me.Soccer_AFav_NTot = New System.Windows.Forms.Button()
        Me.Soccer_HFav_NTot = New System.Windows.Forms.Button()
        Me.Soccer_Standard = New System.Windows.Forms.Button()
        Me.TennisTabPage = New System.Windows.Forms.TabPage()
        Me.LblTennisWomen = New System.Windows.Forms.Label()
        Me.LblTennisMen = New System.Windows.Forms.Label()
        Me.LblTennisWClay = New System.Windows.Forms.Label()
        Me.LblTennisWHard = New System.Windows.Forms.Label()
        Me.LblTennisWGrass = New System.Windows.Forms.Label()
        Me.LblTennisMClay = New System.Windows.Forms.Label()
        Me.LblTennisMHard = New System.Windows.Forms.Label()
        Me.LblTennisMGrass = New System.Windows.Forms.Label()
        Me.Tennis_WClay_P2 = New System.Windows.Forms.Button()
        Me.Tennis_WHard_P2 = New System.Windows.Forms.Button()
        Me.Tennis_WGrass_P2 = New System.Windows.Forms.Button()
        Me.Tennis_WClay_Avg = New System.Windows.Forms.Button()
        Me.Tennis_WHard_Avg = New System.Windows.Forms.Button()
        Me.Tennis_WGrass_Avg = New System.Windows.Forms.Button()
        Me.Tennis_WClay_P1 = New System.Windows.Forms.Button()
        Me.Tennis_WHard_P1 = New System.Windows.Forms.Button()
        Me.Tennis_WGrass_P1 = New System.Windows.Forms.Button()
        Me.Tennis_MClay_P2 = New System.Windows.Forms.Button()
        Me.Tennis_MHard_P2 = New System.Windows.Forms.Button()
        Me.Tennis_MGrass_P2 = New System.Windows.Forms.Button()
        Me.Tennis_MClay_Avg = New System.Windows.Forms.Button()
        Me.Tennis_MHard_Avg = New System.Windows.Forms.Button()
        Me.Tennis_MGrass_Avg = New System.Windows.Forms.Button()
        Me.Tennis_MClay_P1 = New System.Windows.Forms.Button()
        Me.Tennis_MHard_P1 = New System.Windows.Forms.Button()
        Me.Tennis_MGrass_P1 = New System.Windows.Forms.Button()
        Me.BasketballTabPage = New System.Windows.Forms.TabPage()
        Me.Basetball_LrgAwFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgHmFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_SmAwFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_SmHmFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgAwFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgHmFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_SmAwFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_SmHmFav_LoTot = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.SoccerTabPage.SuspendLayout()
        Me.TennisTabPage.SuspendLayout()
        Me.BasketballTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'SportSelectBox
        '
        Me.SportSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SportSelectBox.FormattingEnabled = True
        Me.SportSelectBox.Items.AddRange(New Object() {"Soccer", "Tennis", "Basketball"})
        Me.SportSelectBox.Location = New System.Drawing.Point(240, 47)
        Me.SportSelectBox.Name = "SportSelectBox"
        Me.SportSelectBox.Size = New System.Drawing.Size(121, 21)
        Me.SportSelectBox.TabIndex = 0
        '
        'LblSportSelect
        '
        Me.LblSportSelect.AutoSize = True
        Me.LblSportSelect.Location = New System.Drawing.Point(136, 55)
        Me.LblSportSelect.Name = "LblSportSelect"
        Me.LblSportSelect.Size = New System.Drawing.Size(75, 13)
        Me.LblSportSelect.TabIndex = 1
        Me.LblSportSelect.Text = "Select a sport:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SoccerTabPage)
        Me.TabControl1.Controls.Add(Me.TennisTabPage)
        Me.TabControl1.Controls.Add(Me.BasketballTabPage)
        Me.TabControl1.Location = New System.Drawing.Point(37, 102)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 331)
        Me.TabControl1.TabIndex = 2
        '
        'SoccerTabPage
        '
        Me.SoccerTabPage.Controls.Add(Me.Soccer_AFav_HTot)
        Me.SoccerTabPage.Controls.Add(Me.Soccer_HFav_HTot)
        Me.SoccerTabPage.Controls.Add(Me.Soccer_AFav_NTot)
        Me.SoccerTabPage.Controls.Add(Me.Soccer_HFav_NTot)
        Me.SoccerTabPage.Controls.Add(Me.Soccer_Standard)
        Me.SoccerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SoccerTabPage.Name = "SoccerTabPage"
        Me.SoccerTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SoccerTabPage.Size = New System.Drawing.Size(434, 305)
        Me.SoccerTabPage.TabIndex = 0
        Me.SoccerTabPage.Text = "Soccer"
        Me.SoccerTabPage.UseVisualStyleBackColor = True
        '
        'Soccer_AFav_HTot
        '
        Me.Soccer_AFav_HTot.Location = New System.Drawing.Point(282, 173)
        Me.Soccer_AFav_HTot.Name = "Soccer_AFav_HTot"
        Me.Soccer_AFav_HTot.Size = New System.Drawing.Size(91, 43)
        Me.Soccer_AFav_HTot.TabIndex = 4
        Me.Soccer_AFav_HTot.Text = "Lrg Away Fav/ High Total"
        Me.Soccer_AFav_HTot.UseVisualStyleBackColor = True
        '
        'Soccer_HFav_HTot
        '
        Me.Soccer_HFav_HTot.Location = New System.Drawing.Point(50, 173)
        Me.Soccer_HFav_HTot.Name = "Soccer_HFav_HTot"
        Me.Soccer_HFav_HTot.Size = New System.Drawing.Size(106, 43)
        Me.Soccer_HFav_HTot.TabIndex = 3
        Me.Soccer_HFav_HTot.Text = "Lrg Home Fav/ High Total"
        Me.Soccer_HFav_HTot.UseVisualStyleBackColor = True
        '
        'Soccer_AFav_NTot
        '
        Me.Soccer_AFav_NTot.Location = New System.Drawing.Point(282, 77)
        Me.Soccer_AFav_NTot.Name = "Soccer_AFav_NTot"
        Me.Soccer_AFav_NTot.Size = New System.Drawing.Size(91, 49)
        Me.Soccer_AFav_NTot.TabIndex = 2
        Me.Soccer_AFav_NTot.Text = "Lrg Away fav/ Normal Total"
        Me.Soccer_AFav_NTot.UseVisualStyleBackColor = True
        '
        'Soccer_HFav_NTot
        '
        Me.Soccer_HFav_NTot.Location = New System.Drawing.Point(50, 77)
        Me.Soccer_HFav_NTot.Name = "Soccer_HFav_NTot"
        Me.Soccer_HFav_NTot.Size = New System.Drawing.Size(106, 49)
        Me.Soccer_HFav_NTot.TabIndex = 1
        Me.Soccer_HFav_NTot.Text = "Lrg Home fav/ Normal Total"
        Me.Soccer_HFav_NTot.UseVisualStyleBackColor = True
        '
        'Soccer_Standard
        '
        Me.Soccer_Standard.Location = New System.Drawing.Point(166, 31)
        Me.Soccer_Standard.Name = "Soccer_Standard"
        Me.Soccer_Standard.Size = New System.Drawing.Size(86, 36)
        Me.Soccer_Standard.TabIndex = 0
        Me.Soccer_Standard.Text = "Standard Match"
        Me.Soccer_Standard.UseVisualStyleBackColor = True
        '
        'TennisTabPage
        '
        Me.TennisTabPage.Controls.Add(Me.LblTennisWomen)
        Me.TennisTabPage.Controls.Add(Me.LblTennisMen)
        Me.TennisTabPage.Controls.Add(Me.LblTennisWClay)
        Me.TennisTabPage.Controls.Add(Me.LblTennisWHard)
        Me.TennisTabPage.Controls.Add(Me.LblTennisWGrass)
        Me.TennisTabPage.Controls.Add(Me.LblTennisMClay)
        Me.TennisTabPage.Controls.Add(Me.LblTennisMHard)
        Me.TennisTabPage.Controls.Add(Me.LblTennisMGrass)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WClay_P2)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WHard_P2)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WGrass_P2)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WClay_Avg)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WHard_Avg)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WGrass_Avg)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WClay_P1)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WHard_P1)
        Me.TennisTabPage.Controls.Add(Me.Tennis_WGrass_P1)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MClay_P2)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MHard_P2)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MGrass_P2)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MClay_Avg)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MHard_Avg)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MGrass_Avg)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MClay_P1)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MHard_P1)
        Me.TennisTabPage.Controls.Add(Me.Tennis_MGrass_P1)
        Me.TennisTabPage.Location = New System.Drawing.Point(4, 22)
        Me.TennisTabPage.Name = "TennisTabPage"
        Me.TennisTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TennisTabPage.Size = New System.Drawing.Size(434, 305)
        Me.TennisTabPage.TabIndex = 1
        Me.TennisTabPage.Text = "Tennis"
        Me.TennisTabPage.UseVisualStyleBackColor = True
        '
        'LblTennisWomen
        '
        Me.LblTennisWomen.AutoSize = True
        Me.LblTennisWomen.Location = New System.Drawing.Point(7, 219)
        Me.LblTennisWomen.Name = "LblTennisWomen"
        Me.LblTennisWomen.Size = New System.Drawing.Size(44, 13)
        Me.LblTennisWomen.TabIndex = 25
        Me.LblTennisWomen.Text = "Women"
        '
        'LblTennisMen
        '
        Me.LblTennisMen.AutoSize = True
        Me.LblTennisMen.Location = New System.Drawing.Point(18, 85)
        Me.LblTennisMen.Name = "LblTennisMen"
        Me.LblTennisMen.Size = New System.Drawing.Size(28, 13)
        Me.LblTennisMen.TabIndex = 24
        Me.LblTennisMen.Text = "Men"
        '
        'LblTennisWClay
        '
        Me.LblTennisWClay.AutoSize = True
        Me.LblTennisWClay.Location = New System.Drawing.Point(57, 248)
        Me.LblTennisWClay.Name = "LblTennisWClay"
        Me.LblTennisWClay.Size = New System.Drawing.Size(27, 13)
        Me.LblTennisWClay.TabIndex = 23
        Me.LblTennisWClay.Text = "Clay"
        '
        'LblTennisWHard
        '
        Me.LblTennisWHard.AutoSize = True
        Me.LblTennisWHard.Location = New System.Drawing.Point(57, 219)
        Me.LblTennisWHard.Name = "LblTennisWHard"
        Me.LblTennisWHard.Size = New System.Drawing.Size(30, 13)
        Me.LblTennisWHard.TabIndex = 22
        Me.LblTennisWHard.Text = "Hard"
        '
        'LblTennisWGrass
        '
        Me.LblTennisWGrass.AutoSize = True
        Me.LblTennisWGrass.Location = New System.Drawing.Point(57, 190)
        Me.LblTennisWGrass.Name = "LblTennisWGrass"
        Me.LblTennisWGrass.Size = New System.Drawing.Size(34, 13)
        Me.LblTennisWGrass.TabIndex = 21
        Me.LblTennisWGrass.Text = "Grass"
        '
        'LblTennisMClay
        '
        Me.LblTennisMClay.AutoSize = True
        Me.LblTennisMClay.Location = New System.Drawing.Point(57, 114)
        Me.LblTennisMClay.Name = "LblTennisMClay"
        Me.LblTennisMClay.Size = New System.Drawing.Size(27, 13)
        Me.LblTennisMClay.TabIndex = 20
        Me.LblTennisMClay.Text = "Clay"
        '
        'LblTennisMHard
        '
        Me.LblTennisMHard.AutoSize = True
        Me.LblTennisMHard.Location = New System.Drawing.Point(57, 85)
        Me.LblTennisMHard.Name = "LblTennisMHard"
        Me.LblTennisMHard.Size = New System.Drawing.Size(30, 13)
        Me.LblTennisMHard.TabIndex = 19
        Me.LblTennisMHard.Text = "Hard"
        '
        'LblTennisMGrass
        '
        Me.LblTennisMGrass.AutoSize = True
        Me.LblTennisMGrass.Location = New System.Drawing.Point(57, 55)
        Me.LblTennisMGrass.Name = "LblTennisMGrass"
        Me.LblTennisMGrass.Size = New System.Drawing.Size(34, 13)
        Me.LblTennisMGrass.TabIndex = 18
        Me.LblTennisMGrass.Text = "Grass"
        '
        'Tennis_WClay_P2
        '
        Me.Tennis_WClay_P2.Location = New System.Drawing.Point(291, 238)
        Me.Tennis_WClay_P2.Name = "Tennis_WClay_P2"
        Me.Tennis_WClay_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WClay_P2.TabIndex = 17
        Me.Tennis_WClay_P2.Text = "P2 Big Fav"
        Me.Tennis_WClay_P2.UseVisualStyleBackColor = True
        '
        'Tennis_WHard_P2
        '
        Me.Tennis_WHard_P2.Location = New System.Drawing.Point(291, 209)
        Me.Tennis_WHard_P2.Name = "Tennis_WHard_P2"
        Me.Tennis_WHard_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WHard_P2.TabIndex = 16
        Me.Tennis_WHard_P2.Text = "P2 Big Fav"
        Me.Tennis_WHard_P2.UseVisualStyleBackColor = True
        '
        'Tennis_WGrass_P2
        '
        Me.Tennis_WGrass_P2.Location = New System.Drawing.Point(291, 180)
        Me.Tennis_WGrass_P2.Name = "Tennis_WGrass_P2"
        Me.Tennis_WGrass_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WGrass_P2.TabIndex = 15
        Me.Tennis_WGrass_P2.Text = "P2 Big Fav"
        Me.Tennis_WGrass_P2.UseVisualStyleBackColor = True
        '
        'Tennis_WClay_Avg
        '
        Me.Tennis_WClay_Avg.Location = New System.Drawing.Point(209, 238)
        Me.Tennis_WClay_Avg.Name = "Tennis_WClay_Avg"
        Me.Tennis_WClay_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WClay_Avg.TabIndex = 14
        Me.Tennis_WClay_Avg.Text = "Avg Match"
        Me.Tennis_WClay_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_WHard_Avg
        '
        Me.Tennis_WHard_Avg.Location = New System.Drawing.Point(209, 209)
        Me.Tennis_WHard_Avg.Name = "Tennis_WHard_Avg"
        Me.Tennis_WHard_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WHard_Avg.TabIndex = 13
        Me.Tennis_WHard_Avg.Text = "Avg Match"
        Me.Tennis_WHard_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_WGrass_Avg
        '
        Me.Tennis_WGrass_Avg.Location = New System.Drawing.Point(209, 180)
        Me.Tennis_WGrass_Avg.Name = "Tennis_WGrass_Avg"
        Me.Tennis_WGrass_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WGrass_Avg.TabIndex = 12
        Me.Tennis_WGrass_Avg.Text = "Avg Match"
        Me.Tennis_WGrass_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_WClay_P1
        '
        Me.Tennis_WClay_P1.Location = New System.Drawing.Point(127, 238)
        Me.Tennis_WClay_P1.Name = "Tennis_WClay_P1"
        Me.Tennis_WClay_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WClay_P1.TabIndex = 11
        Me.Tennis_WClay_P1.Text = "P1 Big Fav"
        Me.Tennis_WClay_P1.UseVisualStyleBackColor = True
        '
        'Tennis_WHard_P1
        '
        Me.Tennis_WHard_P1.Location = New System.Drawing.Point(127, 209)
        Me.Tennis_WHard_P1.Name = "Tennis_WHard_P1"
        Me.Tennis_WHard_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WHard_P1.TabIndex = 10
        Me.Tennis_WHard_P1.Text = "P1 Big Fav"
        Me.Tennis_WHard_P1.UseVisualStyleBackColor = True
        '
        'Tennis_WGrass_P1
        '
        Me.Tennis_WGrass_P1.Location = New System.Drawing.Point(127, 180)
        Me.Tennis_WGrass_P1.Name = "Tennis_WGrass_P1"
        Me.Tennis_WGrass_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WGrass_P1.TabIndex = 9
        Me.Tennis_WGrass_P1.Text = "P1 Big Fav"
        Me.Tennis_WGrass_P1.UseVisualStyleBackColor = True
        '
        'Tennis_MClay_P2
        '
        Me.Tennis_MClay_P2.Location = New System.Drawing.Point(290, 104)
        Me.Tennis_MClay_P2.Name = "Tennis_MClay_P2"
        Me.Tennis_MClay_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MClay_P2.TabIndex = 8
        Me.Tennis_MClay_P2.Text = "P2 Big Fav"
        Me.Tennis_MClay_P2.UseVisualStyleBackColor = True
        '
        'Tennis_MHard_P2
        '
        Me.Tennis_MHard_P2.Location = New System.Drawing.Point(290, 75)
        Me.Tennis_MHard_P2.Name = "Tennis_MHard_P2"
        Me.Tennis_MHard_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MHard_P2.TabIndex = 7
        Me.Tennis_MHard_P2.Text = "P2 Big Fav"
        Me.Tennis_MHard_P2.UseVisualStyleBackColor = True
        '
        'Tennis_MGrass_P2
        '
        Me.Tennis_MGrass_P2.Location = New System.Drawing.Point(290, 46)
        Me.Tennis_MGrass_P2.Name = "Tennis_MGrass_P2"
        Me.Tennis_MGrass_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MGrass_P2.TabIndex = 6
        Me.Tennis_MGrass_P2.Text = "P2 Big Fav"
        Me.Tennis_MGrass_P2.UseVisualStyleBackColor = True
        '
        'Tennis_MClay_Avg
        '
        Me.Tennis_MClay_Avg.Location = New System.Drawing.Point(209, 104)
        Me.Tennis_MClay_Avg.Name = "Tennis_MClay_Avg"
        Me.Tennis_MClay_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MClay_Avg.TabIndex = 5
        Me.Tennis_MClay_Avg.Text = "Avg Match"
        Me.Tennis_MClay_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_MHard_Avg
        '
        Me.Tennis_MHard_Avg.Location = New System.Drawing.Point(209, 75)
        Me.Tennis_MHard_Avg.Name = "Tennis_MHard_Avg"
        Me.Tennis_MHard_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MHard_Avg.TabIndex = 4
        Me.Tennis_MHard_Avg.Text = "Avg Match"
        Me.Tennis_MHard_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_MGrass_Avg
        '
        Me.Tennis_MGrass_Avg.Location = New System.Drawing.Point(209, 46)
        Me.Tennis_MGrass_Avg.Name = "Tennis_MGrass_Avg"
        Me.Tennis_MGrass_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MGrass_Avg.TabIndex = 3
        Me.Tennis_MGrass_Avg.Text = "Avg Match"
        Me.Tennis_MGrass_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_MClay_P1
        '
        Me.Tennis_MClay_P1.Location = New System.Drawing.Point(128, 104)
        Me.Tennis_MClay_P1.Name = "Tennis_MClay_P1"
        Me.Tennis_MClay_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MClay_P1.TabIndex = 2
        Me.Tennis_MClay_P1.Text = "P1 Big Fav"
        Me.Tennis_MClay_P1.UseVisualStyleBackColor = True
        '
        'Tennis_MHard_P1
        '
        Me.Tennis_MHard_P1.Location = New System.Drawing.Point(128, 75)
        Me.Tennis_MHard_P1.Name = "Tennis_MHard_P1"
        Me.Tennis_MHard_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MHard_P1.TabIndex = 1
        Me.Tennis_MHard_P1.Text = "P1 Big Fav"
        Me.Tennis_MHard_P1.UseVisualStyleBackColor = True
        '
        'Tennis_MGrass_P1
        '
        Me.Tennis_MGrass_P1.Location = New System.Drawing.Point(128, 46)
        Me.Tennis_MGrass_P1.Name = "Tennis_MGrass_P1"
        Me.Tennis_MGrass_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MGrass_P1.TabIndex = 0
        Me.Tennis_MGrass_P1.Text = "P1 Big Fav"
        Me.Tennis_MGrass_P1.UseVisualStyleBackColor = True
        '
        'BasketballTabPage
        '
        Me.BasketballTabPage.Controls.Add(Me.Basetball_LrgAwFav_HiTot)
        Me.BasketballTabPage.Controls.Add(Me.Basketball_LrgHmFav_HiTot)
        Me.BasketballTabPage.Controls.Add(Me.Basketball_SmAwFav_HiTot)
        Me.BasketballTabPage.Controls.Add(Me.Basketball_SmHmFav_HiTot)
        Me.BasketballTabPage.Controls.Add(Me.Basketball_LrgAwFav_LoTot)
        Me.BasketballTabPage.Controls.Add(Me.Basketball_LrgHmFav_LoTot)
        Me.BasketballTabPage.Controls.Add(Me.Basketball_SmAwFav_LoTot)
        Me.BasketballTabPage.Controls.Add(Me.Basketball_SmHmFav_LoTot)
        Me.BasketballTabPage.Location = New System.Drawing.Point(4, 22)
        Me.BasketballTabPage.Name = "BasketballTabPage"
        Me.BasketballTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.BasketballTabPage.Size = New System.Drawing.Size(434, 305)
        Me.BasketballTabPage.TabIndex = 2
        Me.BasketballTabPage.Text = "Basketball"
        Me.BasketballTabPage.UseVisualStyleBackColor = True
        '
        'Basetball_LrgAwFav_HiTot
        '
        Me.Basetball_LrgAwFav_HiTot.Location = New System.Drawing.Point(265, 211)
        Me.Basetball_LrgAwFav_HiTot.Name = "Basetball_LrgAwFav_HiTot"
        Me.Basetball_LrgAwFav_HiTot.Size = New System.Drawing.Size(105, 44)
        Me.Basetball_LrgAwFav_HiTot.TabIndex = 7
        Me.Basetball_LrgAwFav_HiTot.Text = "Large Away Fav/ High Total"
        Me.Basetball_LrgAwFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_LrgHmFav_HiTot
        '
        Me.Basketball_LrgHmFav_HiTot.Location = New System.Drawing.Point(56, 211)
        Me.Basketball_LrgHmFav_HiTot.Name = "Basketball_LrgHmFav_HiTot"
        Me.Basketball_LrgHmFav_HiTot.Size = New System.Drawing.Size(114, 44)
        Me.Basketball_LrgHmFav_HiTot.TabIndex = 6
        Me.Basketball_LrgHmFav_HiTot.Text = "Large Home Fav/ High Total"
        Me.Basketball_LrgHmFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmAwFav_HiTot
        '
        Me.Basketball_SmAwFav_HiTot.Location = New System.Drawing.Point(265, 153)
        Me.Basketball_SmAwFav_HiTot.Name = "Basketball_SmAwFav_HiTot"
        Me.Basketball_SmAwFav_HiTot.Size = New System.Drawing.Size(105, 41)
        Me.Basketball_SmAwFav_HiTot.TabIndex = 5
        Me.Basketball_SmAwFav_HiTot.Text = "Small Away Fav/ High Total"
        Me.Basketball_SmAwFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmHmFav_HiTot
        '
        Me.Basketball_SmHmFav_HiTot.Location = New System.Drawing.Point(56, 153)
        Me.Basketball_SmHmFav_HiTot.Name = "Basketball_SmHmFav_HiTot"
        Me.Basketball_SmHmFav_HiTot.Size = New System.Drawing.Size(114, 41)
        Me.Basketball_SmHmFav_HiTot.TabIndex = 4
        Me.Basketball_SmHmFav_HiTot.Text = "Small Home Fav/ High Total"
        Me.Basketball_SmHmFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_LrgAwFav_LoTot
        '
        Me.Basketball_LrgAwFav_LoTot.Location = New System.Drawing.Point(265, 87)
        Me.Basketball_LrgAwFav_LoTot.Name = "Basketball_LrgAwFav_LoTot"
        Me.Basketball_LrgAwFav_LoTot.Size = New System.Drawing.Size(105, 45)
        Me.Basketball_LrgAwFav_LoTot.TabIndex = 3
        Me.Basketball_LrgAwFav_LoTot.Text = "Large Away Fav/ Low Total"
        Me.Basketball_LrgAwFav_LoTot.UseVisualStyleBackColor = True
        '
        'Basketball_LrgHmFav_LoTot
        '
        Me.Basketball_LrgHmFav_LoTot.Location = New System.Drawing.Point(56, 87)
        Me.Basketball_LrgHmFav_LoTot.Name = "Basketball_LrgHmFav_LoTot"
        Me.Basketball_LrgHmFav_LoTot.Size = New System.Drawing.Size(114, 45)
        Me.Basketball_LrgHmFav_LoTot.TabIndex = 2
        Me.Basketball_LrgHmFav_LoTot.Text = "Large Home Fav/ Low Total"
        Me.Basketball_LrgHmFav_LoTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmAwFav_LoTot
        '
        Me.Basketball_SmAwFav_LoTot.Location = New System.Drawing.Point(265, 26)
        Me.Basketball_SmAwFav_LoTot.Name = "Basketball_SmAwFav_LoTot"
        Me.Basketball_SmAwFav_LoTot.Size = New System.Drawing.Size(105, 45)
        Me.Basketball_SmAwFav_LoTot.TabIndex = 1
        Me.Basketball_SmAwFav_LoTot.Text = "Small Away Fav/ Low Total"
        Me.Basketball_SmAwFav_LoTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmHmFav_LoTot
        '
        Me.Basketball_SmHmFav_LoTot.Location = New System.Drawing.Point(56, 27)
        Me.Basketball_SmHmFav_LoTot.Name = "Basketball_SmHmFav_LoTot"
        Me.Basketball_SmHmFav_LoTot.Size = New System.Drawing.Size(114, 44)
        Me.Basketball_SmHmFav_LoTot.TabIndex = 0
        Me.Basketball_SmHmFav_LoTot.Text = "Small Home Fav/ Low Total"
        Me.Basketball_SmHmFav_LoTot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 445)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LblSportSelect)
        Me.Controls.Add(Me.SportSelectBox)
        Me.Name = "Form1"
        Me.Text = "Default Lines"
        Me.TabControl1.ResumeLayout(False)
        Me.SoccerTabPage.ResumeLayout(False)
        Me.TennisTabPage.ResumeLayout(False)
        Me.TennisTabPage.PerformLayout()
        Me.BasketballTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SportSelectBox As ComboBox
    Friend WithEvents LblSportSelect As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents SoccerTabPage As TabPage
    Friend WithEvents TennisTabPage As TabPage
    Friend WithEvents BasketballTabPage As TabPage
    Friend WithEvents Soccer_AFav_HTot As Button
    Friend WithEvents Soccer_HFav_HTot As Button
    Friend WithEvents Soccer_AFav_NTot As Button
    Friend WithEvents Soccer_HFav_NTot As Button
    Friend WithEvents Soccer_Standard As Button
    Friend WithEvents Basetball_LrgAwFav_HiTot As Button
    Friend WithEvents Basketball_LrgHmFav_HiTot As Button
    Friend WithEvents Basketball_SmAwFav_HiTot As Button
    Friend WithEvents Basketball_SmHmFav_HiTot As Button
    Friend WithEvents Basketball_LrgAwFav_LoTot As Button
    Friend WithEvents Basketball_LrgHmFav_LoTot As Button
    Friend WithEvents Basketball_SmAwFav_LoTot As Button
    Friend WithEvents Basketball_SmHmFav_LoTot As Button
    Friend WithEvents Tennis_WClay_P2 As Button
    Friend WithEvents Tennis_WHard_P2 As Button
    Friend WithEvents Tennis_WGrass_P2 As Button
    Friend WithEvents Tennis_WClay_Avg As Button
    Friend WithEvents Tennis_WHard_Avg As Button
    Friend WithEvents Tennis_WGrass_Avg As Button
    Friend WithEvents Tennis_WClay_P1 As Button
    Friend WithEvents Tennis_WHard_P1 As Button
    Friend WithEvents Tennis_WGrass_P1 As Button
    Friend WithEvents Tennis_MClay_P2 As Button
    Friend WithEvents Tennis_MHard_P2 As Button
    Friend WithEvents Tennis_MGrass_P2 As Button
    Friend WithEvents Tennis_MClay_Avg As Button
    Friend WithEvents Tennis_MHard_Avg As Button
    Friend WithEvents Tennis_MGrass_Avg As Button
    Friend WithEvents Tennis_MClay_P1 As Button
    Friend WithEvents Tennis_MHard_P1 As Button
    Friend WithEvents Tennis_MGrass_P1 As Button
    Friend WithEvents LblTennisWClay As Label
    Friend WithEvents LblTennisWHard As Label
    Friend WithEvents LblTennisWGrass As Label
    Friend WithEvents LblTennisMClay As Label
    Friend WithEvents LblTennisMHard As Label
    Friend WithEvents LblTennisMGrass As Label
    Friend WithEvents LblTennisWomen As Label
    Friend WithEvents LblTennisMen As Label
End Class
