<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Me.SportSelectBox = New System.Windows.Forms.ComboBox()
        Me.LblSportSelect = New System.Windows.Forms.Label()
        Me.Soccer_AFav_HTot = New System.Windows.Forms.Button()
        Me.Soccer_HFav_HTot = New System.Windows.Forms.Button()
        Me.Soccer_AFav_NTot = New System.Windows.Forms.Button()
        Me.Soccer_HFav_NTot = New System.Windows.Forms.Button()
        Me.Soccer_Standard = New System.Windows.Forms.Button()
        Me.Basetball_LrgAwFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgHmFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_SmAwFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_SmHmFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgAwFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgHmFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_SmAwFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_SmHmFav_LoTot = New System.Windows.Forms.Button()
        Me.Soccer_Panel = New System.Windows.Forms.Panel()
        Me.Basketball_Panel = New System.Windows.Forms.Panel()
        Me.Tennis_Panel = New System.Windows.Forms.Panel()
        Me.LblTennisWomen = New System.Windows.Forms.Label()
        Me.Tennis_MGrass_P1 = New System.Windows.Forms.Button()
        Me.LblTennisWClay = New System.Windows.Forms.Label()
        Me.LblTennisMen = New System.Windows.Forms.Label()
        Me.LblTennisWHard = New System.Windows.Forms.Label()
        Me.Tennis_MGrass_Avg = New System.Windows.Forms.Button()
        Me.LblTennisWGrass = New System.Windows.Forms.Label()
        Me.Tennis_MGrass_P2 = New System.Windows.Forms.Button()
        Me.Tennis_WClay_P2 = New System.Windows.Forms.Button()
        Me.Tennis_MHard_P1 = New System.Windows.Forms.Button()
        Me.Tennis_WHard_P2 = New System.Windows.Forms.Button()
        Me.Tennis_MHard_Avg = New System.Windows.Forms.Button()
        Me.Tennis_WGrass_P2 = New System.Windows.Forms.Button()
        Me.LblTennisMClay = New System.Windows.Forms.Label()
        Me.Tennis_WClay_Avg = New System.Windows.Forms.Button()
        Me.Tennis_MHard_P2 = New System.Windows.Forms.Button()
        Me.Tennis_WHard_Avg = New System.Windows.Forms.Button()
        Me.LblTennisMHard = New System.Windows.Forms.Label()
        Me.Tennis_WGrass_Avg = New System.Windows.Forms.Button()
        Me.Tennis_MClay_P1 = New System.Windows.Forms.Button()
        Me.Tennis_WClay_P1 = New System.Windows.Forms.Button()
        Me.LblTennisMGrass = New System.Windows.Forms.Label()
        Me.Tennis_WHard_P1 = New System.Windows.Forms.Button()
        Me.Tennis_MClay_Avg = New System.Windows.Forms.Button()
        Me.Tennis_WGrass_P1 = New System.Windows.Forms.Button()
        Me.Tennis_MClay_P2 = New System.Windows.Forms.Button()
        Me.MainPageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.American_Football_Panel = New System.Windows.Forms.Panel()
        Me.AmF_LrgHmFav_LrgTot = New System.Windows.Forms.Button()
        Me.AmF_LrgAwFav_LrgTot = New System.Windows.Forms.Button()
        Me.AmF_HmFav_LrgTot = New System.Windows.Forms.Button()
        Me.AmF_AwFav_LrgTotal = New System.Windows.Forms.Button()
        Me.AmF_LrgHmFav_RegTot = New System.Windows.Forms.Button()
        Me.AmF_LrgAwFav_RegTot = New System.Windows.Forms.Button()
        Me.AmF_HmFav_RegTot = New System.Windows.Forms.Button()
        Me.AmF_AwFav_RegTot = New System.Windows.Forms.Button()
        Me.Soccer_Panel.SuspendLayout()
        Me.Basketball_Panel.SuspendLayout()
        Me.Tennis_Panel.SuspendLayout()
        CType(Me.MainPageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.American_Football_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SportSelectBox
        '
        Me.SportSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SportSelectBox.FormattingEnabled = True
        Me.SportSelectBox.Items.AddRange(New Object() {"American Football", "Aussie Rules", "Basketball", "Soccer", "Tennis"})
        Me.SportSelectBox.Location = New System.Drawing.Point(216, 45)
        Me.SportSelectBox.Name = "SportSelectBox"
        Me.SportSelectBox.Size = New System.Drawing.Size(121, 21)
        Me.SportSelectBox.TabIndex = 0
        '
        'LblSportSelect
        '
        Me.LblSportSelect.AutoSize = True
        Me.LblSportSelect.Location = New System.Drawing.Point(135, 48)
        Me.LblSportSelect.Name = "LblSportSelect"
        Me.LblSportSelect.Size = New System.Drawing.Size(75, 13)
        Me.LblSportSelect.TabIndex = 1
        Me.LblSportSelect.Text = "Select a sport:"
        '
        'Soccer_AFav_HTot
        '
        Me.Soccer_AFav_HTot.Location = New System.Drawing.Point(262, 185)
        Me.Soccer_AFav_HTot.Name = "Soccer_AFav_HTot"
        Me.Soccer_AFav_HTot.Size = New System.Drawing.Size(91, 43)
        Me.Soccer_AFav_HTot.TabIndex = 4
        Me.Soccer_AFav_HTot.Text = "Lrg Away Fav/ High Total"
        Me.Soccer_AFav_HTot.UseVisualStyleBackColor = True
        '
        'Soccer_HFav_HTot
        '
        Me.Soccer_HFav_HTot.Location = New System.Drawing.Point(75, 180)
        Me.Soccer_HFav_HTot.Name = "Soccer_HFav_HTot"
        Me.Soccer_HFav_HTot.Size = New System.Drawing.Size(106, 43)
        Me.Soccer_HFav_HTot.TabIndex = 3
        Me.Soccer_HFav_HTot.Text = "Lrg Home Fav/ High Total"
        Me.Soccer_HFav_HTot.UseVisualStyleBackColor = True
        '
        'Soccer_AFav_NTot
        '
        Me.Soccer_AFav_NTot.Location = New System.Drawing.Point(262, 101)
        Me.Soccer_AFav_NTot.Name = "Soccer_AFav_NTot"
        Me.Soccer_AFav_NTot.Size = New System.Drawing.Size(91, 49)
        Me.Soccer_AFav_NTot.TabIndex = 2
        Me.Soccer_AFav_NTot.Text = "Lrg Away fav/ Normal Total"
        Me.Soccer_AFav_NTot.UseVisualStyleBackColor = True
        '
        'Soccer_HFav_NTot
        '
        Me.Soccer_HFav_NTot.Location = New System.Drawing.Point(75, 99)
        Me.Soccer_HFav_NTot.Name = "Soccer_HFav_NTot"
        Me.Soccer_HFav_NTot.Size = New System.Drawing.Size(106, 49)
        Me.Soccer_HFav_NTot.TabIndex = 1
        Me.Soccer_HFav_NTot.Text = "Lrg Home fav/ Normal Total"
        Me.Soccer_HFav_NTot.UseVisualStyleBackColor = True
        '
        'Soccer_Standard
        '
        Me.Soccer_Standard.Location = New System.Drawing.Point(178, 28)
        Me.Soccer_Standard.Name = "Soccer_Standard"
        Me.Soccer_Standard.Size = New System.Drawing.Size(86, 36)
        Me.Soccer_Standard.TabIndex = 0
        Me.Soccer_Standard.Text = "Standard Match"
        Me.Soccer_Standard.UseVisualStyleBackColor = True
        '
        'Basetball_LrgAwFav_HiTot
        '
        Me.Basetball_LrgAwFav_HiTot.Location = New System.Drawing.Point(270, 234)
        Me.Basetball_LrgAwFav_HiTot.Name = "Basetball_LrgAwFav_HiTot"
        Me.Basetball_LrgAwFav_HiTot.Size = New System.Drawing.Size(105, 44)
        Me.Basetball_LrgAwFav_HiTot.TabIndex = 7
        Me.Basetball_LrgAwFav_HiTot.Text = "Large Away Fav/ High Total"
        Me.Basetball_LrgAwFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_LrgHmFav_HiTot
        '
        Me.Basketball_LrgHmFav_HiTot.Location = New System.Drawing.Point(75, 232)
        Me.Basketball_LrgHmFav_HiTot.Name = "Basketball_LrgHmFav_HiTot"
        Me.Basketball_LrgHmFav_HiTot.Size = New System.Drawing.Size(114, 44)
        Me.Basketball_LrgHmFav_HiTot.TabIndex = 6
        Me.Basketball_LrgHmFav_HiTot.Text = "Large Home Fav/ High Total"
        Me.Basketball_LrgHmFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmAwFav_HiTot
        '
        Me.Basketball_SmAwFav_HiTot.Location = New System.Drawing.Point(270, 163)
        Me.Basketball_SmAwFav_HiTot.Name = "Basketball_SmAwFav_HiTot"
        Me.Basketball_SmAwFav_HiTot.Size = New System.Drawing.Size(105, 41)
        Me.Basketball_SmAwFav_HiTot.TabIndex = 5
        Me.Basketball_SmAwFav_HiTot.Text = "Small Away Fav/ High Total"
        Me.Basketball_SmAwFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmHmFav_HiTot
        '
        Me.Basketball_SmHmFav_HiTot.Location = New System.Drawing.Point(75, 163)
        Me.Basketball_SmHmFav_HiTot.Name = "Basketball_SmHmFav_HiTot"
        Me.Basketball_SmHmFav_HiTot.Size = New System.Drawing.Size(114, 41)
        Me.Basketball_SmHmFav_HiTot.TabIndex = 4
        Me.Basketball_SmHmFav_HiTot.Text = "Small Home Fav/ High Total"
        Me.Basketball_SmHmFav_HiTot.UseVisualStyleBackColor = True
        '
        'Basketball_LrgAwFav_LoTot
        '
        Me.Basketball_LrgAwFav_LoTot.Location = New System.Drawing.Point(270, 92)
        Me.Basketball_LrgAwFav_LoTot.Name = "Basketball_LrgAwFav_LoTot"
        Me.Basketball_LrgAwFav_LoTot.Size = New System.Drawing.Size(105, 45)
        Me.Basketball_LrgAwFav_LoTot.TabIndex = 3
        Me.Basketball_LrgAwFav_LoTot.Text = "Large Away Fav/ Low Total"
        Me.Basketball_LrgAwFav_LoTot.UseVisualStyleBackColor = True
        '
        'Basketball_LrgHmFav_LoTot
        '
        Me.Basketball_LrgHmFav_LoTot.Location = New System.Drawing.Point(75, 92)
        Me.Basketball_LrgHmFav_LoTot.Name = "Basketball_LrgHmFav_LoTot"
        Me.Basketball_LrgHmFav_LoTot.Size = New System.Drawing.Size(114, 45)
        Me.Basketball_LrgHmFav_LoTot.TabIndex = 2
        Me.Basketball_LrgHmFav_LoTot.Text = "Large Home Fav/ Low Total"
        Me.Basketball_LrgHmFav_LoTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmAwFav_LoTot
        '
        Me.Basketball_SmAwFav_LoTot.Location = New System.Drawing.Point(270, 24)
        Me.Basketball_SmAwFav_LoTot.Name = "Basketball_SmAwFav_LoTot"
        Me.Basketball_SmAwFav_LoTot.Size = New System.Drawing.Size(105, 45)
        Me.Basketball_SmAwFav_LoTot.TabIndex = 1
        Me.Basketball_SmAwFav_LoTot.Text = "Small Away Fav/ Low Total"
        Me.Basketball_SmAwFav_LoTot.UseVisualStyleBackColor = True
        '
        'Basketball_SmHmFav_LoTot
        '
        Me.Basketball_SmHmFav_LoTot.Location = New System.Drawing.Point(75, 25)
        Me.Basketball_SmHmFav_LoTot.Name = "Basketball_SmHmFav_LoTot"
        Me.Basketball_SmHmFav_LoTot.Size = New System.Drawing.Size(114, 44)
        Me.Basketball_SmHmFav_LoTot.TabIndex = 0
        Me.Basketball_SmHmFav_LoTot.Text = "Small Home Fav/ Low Total"
        Me.Basketball_SmHmFav_LoTot.UseVisualStyleBackColor = True
        '
        'Soccer_Panel
        '
        Me.Soccer_Panel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Soccer_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Soccer_Panel.Controls.Add(Me.Soccer_Standard)
        Me.Soccer_Panel.Controls.Add(Me.Soccer_HFav_NTot)
        Me.Soccer_Panel.Controls.Add(Me.Soccer_AFav_NTot)
        Me.Soccer_Panel.Controls.Add(Me.Soccer_HFav_HTot)
        Me.Soccer_Panel.Controls.Add(Me.Soccer_AFav_HTot)
        Me.Soccer_Panel.Location = New System.Drawing.Point(38, 87)
        Me.Soccer_Panel.Name = "Soccer_Panel"
        Me.Soccer_Panel.Size = New System.Drawing.Size(450, 300)
        Me.Soccer_Panel.TabIndex = 0
        Me.Soccer_Panel.Visible = False
        '
        'Basketball_Panel
        '
        Me.Basketball_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Basketball_Panel.Controls.Add(Me.Basketball_LrgHmFav_HiTot)
        Me.Basketball_Panel.Controls.Add(Me.Basetball_LrgAwFav_HiTot)
        Me.Basketball_Panel.Controls.Add(Me.Basketball_SmHmFav_HiTot)
        Me.Basketball_Panel.Controls.Add(Me.Basketball_SmHmFav_LoTot)
        Me.Basketball_Panel.Controls.Add(Me.Basketball_SmAwFav_LoTot)
        Me.Basketball_Panel.Controls.Add(Me.Basketball_LrgHmFav_LoTot)
        Me.Basketball_Panel.Controls.Add(Me.Basketball_SmAwFav_HiTot)
        Me.Basketball_Panel.Controls.Add(Me.Basketball_LrgAwFav_LoTot)
        Me.Basketball_Panel.Location = New System.Drawing.Point(38, 87)
        Me.Basketball_Panel.Name = "Basketball_Panel"
        Me.Basketball_Panel.Size = New System.Drawing.Size(450, 300)
        Me.Basketball_Panel.TabIndex = 4
        Me.Basketball_Panel.Visible = False
        '
        'Tennis_Panel
        '
        Me.Tennis_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tennis_Panel.Controls.Add(Me.LblTennisWomen)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MGrass_P1)
        Me.Tennis_Panel.Controls.Add(Me.LblTennisWClay)
        Me.Tennis_Panel.Controls.Add(Me.LblTennisMen)
        Me.Tennis_Panel.Controls.Add(Me.LblTennisWHard)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MGrass_Avg)
        Me.Tennis_Panel.Controls.Add(Me.LblTennisWGrass)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MGrass_P2)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WClay_P2)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MHard_P1)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WHard_P2)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MHard_Avg)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WGrass_P2)
        Me.Tennis_Panel.Controls.Add(Me.LblTennisMClay)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WClay_Avg)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MHard_P2)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WHard_Avg)
        Me.Tennis_Panel.Controls.Add(Me.LblTennisMHard)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WGrass_Avg)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MClay_P1)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WClay_P1)
        Me.Tennis_Panel.Controls.Add(Me.LblTennisMGrass)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WHard_P1)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MClay_Avg)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_WGrass_P1)
        Me.Tennis_Panel.Controls.Add(Me.Tennis_MClay_P2)
        Me.Tennis_Panel.Location = New System.Drawing.Point(38, 87)
        Me.Tennis_Panel.Name = "Tennis_Panel"
        Me.Tennis_Panel.Size = New System.Drawing.Size(450, 300)
        Me.Tennis_Panel.TabIndex = 3
        Me.Tennis_Panel.Visible = False
        '
        'LblTennisWomen
        '
        Me.LblTennisWomen.AutoSize = True
        Me.LblTennisWomen.Location = New System.Drawing.Point(13, 215)
        Me.LblTennisWomen.Name = "LblTennisWomen"
        Me.LblTennisWomen.Size = New System.Drawing.Size(44, 13)
        Me.LblTennisWomen.TabIndex = 25
        Me.LblTennisWomen.Text = "Women"
        '
        'Tennis_MGrass_P1
        '
        Me.Tennis_MGrass_P1.Location = New System.Drawing.Point(115, 13)
        Me.Tennis_MGrass_P1.Name = "Tennis_MGrass_P1"
        Me.Tennis_MGrass_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MGrass_P1.TabIndex = 0
        Me.Tennis_MGrass_P1.Text = "P1 Big Fav"
        Me.Tennis_MGrass_P1.UseVisualStyleBackColor = True
        '
        'LblTennisWClay
        '
        Me.LblTennisWClay.AutoSize = True
        Me.LblTennisWClay.Location = New System.Drawing.Point(63, 258)
        Me.LblTennisWClay.Name = "LblTennisWClay"
        Me.LblTennisWClay.Size = New System.Drawing.Size(27, 13)
        Me.LblTennisWClay.TabIndex = 23
        Me.LblTennisWClay.Text = "Clay"
        '
        'LblTennisMen
        '
        Me.LblTennisMen.AutoSize = True
        Me.LblTennisMen.Location = New System.Drawing.Point(13, 60)
        Me.LblTennisMen.Name = "LblTennisMen"
        Me.LblTennisMen.Size = New System.Drawing.Size(28, 13)
        Me.LblTennisMen.TabIndex = 24
        Me.LblTennisMen.Text = "Men"
        '
        'LblTennisWHard
        '
        Me.LblTennisWHard.AutoSize = True
        Me.LblTennisWHard.Location = New System.Drawing.Point(63, 215)
        Me.LblTennisWHard.Name = "LblTennisWHard"
        Me.LblTennisWHard.Size = New System.Drawing.Size(30, 13)
        Me.LblTennisWHard.TabIndex = 22
        Me.LblTennisWHard.Text = "Hard"
        '
        'Tennis_MGrass_Avg
        '
        Me.Tennis_MGrass_Avg.Location = New System.Drawing.Point(224, 13)
        Me.Tennis_MGrass_Avg.Name = "Tennis_MGrass_Avg"
        Me.Tennis_MGrass_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MGrass_Avg.TabIndex = 3
        Me.Tennis_MGrass_Avg.Text = "Avg Match"
        Me.Tennis_MGrass_Avg.UseVisualStyleBackColor = True
        '
        'LblTennisWGrass
        '
        Me.LblTennisWGrass.AutoSize = True
        Me.LblTennisWGrass.Location = New System.Drawing.Point(63, 164)
        Me.LblTennisWGrass.Name = "LblTennisWGrass"
        Me.LblTennisWGrass.Size = New System.Drawing.Size(34, 13)
        Me.LblTennisWGrass.TabIndex = 21
        Me.LblTennisWGrass.Text = "Grass"
        '
        'Tennis_MGrass_P2
        '
        Me.Tennis_MGrass_P2.Location = New System.Drawing.Point(325, 13)
        Me.Tennis_MGrass_P2.Name = "Tennis_MGrass_P2"
        Me.Tennis_MGrass_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MGrass_P2.TabIndex = 6
        Me.Tennis_MGrass_P2.Text = "P2 Big Fav"
        Me.Tennis_MGrass_P2.UseVisualStyleBackColor = True
        '
        'Tennis_WClay_P2
        '
        Me.Tennis_WClay_P2.Location = New System.Drawing.Point(325, 253)
        Me.Tennis_WClay_P2.Name = "Tennis_WClay_P2"
        Me.Tennis_WClay_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WClay_P2.TabIndex = 17
        Me.Tennis_WClay_P2.Text = "P2 Big Fav"
        Me.Tennis_WClay_P2.UseVisualStyleBackColor = True
        '
        'Tennis_MHard_P1
        '
        Me.Tennis_MHard_P1.Location = New System.Drawing.Point(115, 55)
        Me.Tennis_MHard_P1.Name = "Tennis_MHard_P1"
        Me.Tennis_MHard_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MHard_P1.TabIndex = 1
        Me.Tennis_MHard_P1.Text = "P1 Big Fav"
        Me.Tennis_MHard_P1.UseVisualStyleBackColor = True
        '
        'Tennis_WHard_P2
        '
        Me.Tennis_WHard_P2.Location = New System.Drawing.Point(325, 210)
        Me.Tennis_WHard_P2.Name = "Tennis_WHard_P2"
        Me.Tennis_WHard_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WHard_P2.TabIndex = 16
        Me.Tennis_WHard_P2.Text = "P2 Big Fav"
        Me.Tennis_WHard_P2.UseVisualStyleBackColor = True
        '
        'Tennis_MHard_Avg
        '
        Me.Tennis_MHard_Avg.Location = New System.Drawing.Point(224, 55)
        Me.Tennis_MHard_Avg.Name = "Tennis_MHard_Avg"
        Me.Tennis_MHard_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MHard_Avg.TabIndex = 4
        Me.Tennis_MHard_Avg.Text = "Avg Match"
        Me.Tennis_MHard_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_WGrass_P2
        '
        Me.Tennis_WGrass_P2.Location = New System.Drawing.Point(325, 166)
        Me.Tennis_WGrass_P2.Name = "Tennis_WGrass_P2"
        Me.Tennis_WGrass_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WGrass_P2.TabIndex = 15
        Me.Tennis_WGrass_P2.Text = "P2 Big Fav"
        Me.Tennis_WGrass_P2.UseVisualStyleBackColor = True
        '
        'LblTennisMClay
        '
        Me.LblTennisMClay.AutoSize = True
        Me.LblTennisMClay.Location = New System.Drawing.Point(63, 108)
        Me.LblTennisMClay.Name = "LblTennisMClay"
        Me.LblTennisMClay.Size = New System.Drawing.Size(27, 13)
        Me.LblTennisMClay.TabIndex = 20
        Me.LblTennisMClay.Text = "Clay"
        '
        'Tennis_WClay_Avg
        '
        Me.Tennis_WClay_Avg.Location = New System.Drawing.Point(224, 253)
        Me.Tennis_WClay_Avg.Name = "Tennis_WClay_Avg"
        Me.Tennis_WClay_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WClay_Avg.TabIndex = 14
        Me.Tennis_WClay_Avg.Text = "Avg Match"
        Me.Tennis_WClay_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_MHard_P2
        '
        Me.Tennis_MHard_P2.Location = New System.Drawing.Point(325, 55)
        Me.Tennis_MHard_P2.Name = "Tennis_MHard_P2"
        Me.Tennis_MHard_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MHard_P2.TabIndex = 7
        Me.Tennis_MHard_P2.Text = "P2 Big Fav"
        Me.Tennis_MHard_P2.UseVisualStyleBackColor = True
        '
        'Tennis_WHard_Avg
        '
        Me.Tennis_WHard_Avg.Location = New System.Drawing.Point(224, 210)
        Me.Tennis_WHard_Avg.Name = "Tennis_WHard_Avg"
        Me.Tennis_WHard_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WHard_Avg.TabIndex = 13
        Me.Tennis_WHard_Avg.Text = "Avg Match"
        Me.Tennis_WHard_Avg.UseVisualStyleBackColor = True
        '
        'LblTennisMHard
        '
        Me.LblTennisMHard.AutoSize = True
        Me.LblTennisMHard.Location = New System.Drawing.Point(63, 60)
        Me.LblTennisMHard.Name = "LblTennisMHard"
        Me.LblTennisMHard.Size = New System.Drawing.Size(30, 13)
        Me.LblTennisMHard.TabIndex = 19
        Me.LblTennisMHard.Text = "Hard"
        '
        'Tennis_WGrass_Avg
        '
        Me.Tennis_WGrass_Avg.Location = New System.Drawing.Point(224, 166)
        Me.Tennis_WGrass_Avg.Name = "Tennis_WGrass_Avg"
        Me.Tennis_WGrass_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WGrass_Avg.TabIndex = 12
        Me.Tennis_WGrass_Avg.Text = "Avg Match"
        Me.Tennis_WGrass_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_MClay_P1
        '
        Me.Tennis_MClay_P1.Location = New System.Drawing.Point(115, 103)
        Me.Tennis_MClay_P1.Name = "Tennis_MClay_P1"
        Me.Tennis_MClay_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MClay_P1.TabIndex = 2
        Me.Tennis_MClay_P1.Text = "P1 Big Fav"
        Me.Tennis_MClay_P1.UseVisualStyleBackColor = True
        '
        'Tennis_WClay_P1
        '
        Me.Tennis_WClay_P1.Location = New System.Drawing.Point(115, 253)
        Me.Tennis_WClay_P1.Name = "Tennis_WClay_P1"
        Me.Tennis_WClay_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WClay_P1.TabIndex = 11
        Me.Tennis_WClay_P1.Text = "P1 Big Fav"
        Me.Tennis_WClay_P1.UseVisualStyleBackColor = True
        '
        'LblTennisMGrass
        '
        Me.LblTennisMGrass.AutoSize = True
        Me.LblTennisMGrass.Location = New System.Drawing.Point(63, 18)
        Me.LblTennisMGrass.Name = "LblTennisMGrass"
        Me.LblTennisMGrass.Size = New System.Drawing.Size(34, 13)
        Me.LblTennisMGrass.TabIndex = 18
        Me.LblTennisMGrass.Text = "Grass"
        '
        'Tennis_WHard_P1
        '
        Me.Tennis_WHard_P1.Location = New System.Drawing.Point(115, 210)
        Me.Tennis_WHard_P1.Name = "Tennis_WHard_P1"
        Me.Tennis_WHard_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WHard_P1.TabIndex = 10
        Me.Tennis_WHard_P1.Text = "P1 Big Fav"
        Me.Tennis_WHard_P1.UseVisualStyleBackColor = True
        '
        'Tennis_MClay_Avg
        '
        Me.Tennis_MClay_Avg.Location = New System.Drawing.Point(224, 103)
        Me.Tennis_MClay_Avg.Name = "Tennis_MClay_Avg"
        Me.Tennis_MClay_Avg.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MClay_Avg.TabIndex = 5
        Me.Tennis_MClay_Avg.Text = "Avg Match"
        Me.Tennis_MClay_Avg.UseVisualStyleBackColor = True
        '
        'Tennis_WGrass_P1
        '
        Me.Tennis_WGrass_P1.Location = New System.Drawing.Point(115, 166)
        Me.Tennis_WGrass_P1.Name = "Tennis_WGrass_P1"
        Me.Tennis_WGrass_P1.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_WGrass_P1.TabIndex = 9
        Me.Tennis_WGrass_P1.Text = "P1 Big Fav"
        Me.Tennis_WGrass_P1.UseVisualStyleBackColor = True
        '
        'Tennis_MClay_P2
        '
        Me.Tennis_MClay_P2.Location = New System.Drawing.Point(325, 103)
        Me.Tennis_MClay_P2.Name = "Tennis_MClay_P2"
        Me.Tennis_MClay_P2.Size = New System.Drawing.Size(75, 23)
        Me.Tennis_MClay_P2.TabIndex = 8
        Me.Tennis_MClay_P2.Text = "P2 Big Fav"
        Me.Tennis_MClay_P2.UseVisualStyleBackColor = True
        '
        'MainPageBindingSource
        '
        Me.MainPageBindingSource.DataSource = GetType(Default_Lines.MainPage)
        '
        'American_Football_Panel
        '
        Me.American_Football_Panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.American_Football_Panel.Controls.Add(Me.AmF_LrgHmFav_LrgTot)
        Me.American_Football_Panel.Controls.Add(Me.AmF_LrgAwFav_LrgTot)
        Me.American_Football_Panel.Controls.Add(Me.AmF_HmFav_LrgTot)
        Me.American_Football_Panel.Controls.Add(Me.AmF_AwFav_LrgTotal)
        Me.American_Football_Panel.Controls.Add(Me.AmF_LrgHmFav_RegTot)
        Me.American_Football_Panel.Controls.Add(Me.AmF_LrgAwFav_RegTot)
        Me.American_Football_Panel.Controls.Add(Me.AmF_HmFav_RegTot)
        Me.American_Football_Panel.Controls.Add(Me.AmF_AwFav_RegTot)
        Me.American_Football_Panel.Location = New System.Drawing.Point(36, 86)
        Me.American_Football_Panel.Name = "American_Football_Panel"
        Me.American_Football_Panel.Size = New System.Drawing.Size(450, 300)
        Me.American_Football_Panel.TabIndex = 5
        Me.American_Football_Panel.Visible = False
        '
        'AmF_LrgHmFav_LrgTot
        '
        Me.AmF_LrgHmFav_LrgTot.Location = New System.Drawing.Point(236, 254)
        Me.AmF_LrgHmFav_LrgTot.Name = "AmF_LrgHmFav_LrgTot"
        Me.AmF_LrgHmFav_LrgTot.Size = New System.Drawing.Size(107, 39)
        Me.AmF_LrgHmFav_LrgTot.TabIndex = 7
        Me.AmF_LrgHmFav_LrgTot.Text = "Large Home Fav / Large Total"
        Me.AmF_LrgHmFav_LrgTot.UseVisualStyleBackColor = True
        '
        'AmF_LrgAwFav_LrgTot
        '
        Me.AmF_LrgAwFav_LrgTot.Location = New System.Drawing.Point(68, 254)
        Me.AmF_LrgAwFav_LrgTot.Name = "AmF_LrgAwFav_LrgTot"
        Me.AmF_LrgAwFav_LrgTot.Size = New System.Drawing.Size(104, 39)
        Me.AmF_LrgAwFav_LrgTot.TabIndex = 6
        Me.AmF_LrgAwFav_LrgTot.Text = "Large Away Fav / Large Total"
        Me.AmF_LrgAwFav_LrgTot.UseVisualStyleBackColor = True
        '
        'AmF_HmFav_LrgTot
        '
        Me.AmF_HmFav_LrgTot.Location = New System.Drawing.Point(236, 186)
        Me.AmF_HmFav_LrgTot.Name = "AmF_HmFav_LrgTot"
        Me.AmF_HmFav_LrgTot.Size = New System.Drawing.Size(107, 43)
        Me.AmF_HmFav_LrgTot.TabIndex = 5
        Me.AmF_HmFav_LrgTot.Text = "Home Fav / Large Total"
        Me.AmF_HmFav_LrgTot.UseVisualStyleBackColor = True
        '
        'AmF_AwFav_LrgTotal
        '
        Me.AmF_AwFav_LrgTotal.Location = New System.Drawing.Point(68, 190)
        Me.AmF_AwFav_LrgTotal.Name = "AmF_AwFav_LrgTotal"
        Me.AmF_AwFav_LrgTotal.Size = New System.Drawing.Size(104, 39)
        Me.AmF_AwFav_LrgTotal.TabIndex = 4
        Me.AmF_AwFav_LrgTotal.Text = "Away Fav / Large Total"
        Me.AmF_AwFav_LrgTotal.UseVisualStyleBackColor = True
        '
        'AmF_LrgHmFav_RegTot
        '
        Me.AmF_LrgHmFav_RegTot.Location = New System.Drawing.Point(236, 100)
        Me.AmF_LrgHmFav_RegTot.Name = "AmF_LrgHmFav_RegTot"
        Me.AmF_LrgHmFav_RegTot.Size = New System.Drawing.Size(107, 51)
        Me.AmF_LrgHmFav_RegTot.TabIndex = 3
        Me.AmF_LrgHmFav_RegTot.Text = "Large Home Fav / Regular Total"
        Me.AmF_LrgHmFav_RegTot.UseVisualStyleBackColor = True
        '
        'AmF_LrgAwFav_RegTot
        '
        Me.AmF_LrgAwFav_RegTot.Location = New System.Drawing.Point(68, 104)
        Me.AmF_LrgAwFav_RegTot.Name = "AmF_LrgAwFav_RegTot"
        Me.AmF_LrgAwFav_RegTot.Size = New System.Drawing.Size(104, 47)
        Me.AmF_LrgAwFav_RegTot.TabIndex = 2
        Me.AmF_LrgAwFav_RegTot.Text = "Large Away Fav / Regular Total"
        Me.AmF_LrgAwFav_RegTot.UseVisualStyleBackColor = True
        '
        'AmF_HmFav_RegTot
        '
        Me.AmF_HmFav_RegTot.Location = New System.Drawing.Point(236, 29)
        Me.AmF_HmFav_RegTot.Name = "AmF_HmFav_RegTot"
        Me.AmF_HmFav_RegTot.Size = New System.Drawing.Size(107, 45)
        Me.AmF_HmFav_RegTot.TabIndex = 1
        Me.AmF_HmFav_RegTot.Text = "Home Fav / Regular Total"
        Me.AmF_HmFav_RegTot.UseVisualStyleBackColor = True
        '
        'AmF_AwFav_RegTot
        '
        Me.AmF_AwFav_RegTot.Location = New System.Drawing.Point(68, 30)
        Me.AmF_AwFav_RegTot.Name = "AmF_AwFav_RegTot"
        Me.AmF_AwFav_RegTot.Size = New System.Drawing.Size(104, 44)
        Me.AmF_AwFav_RegTot.TabIndex = 0
        Me.AmF_AwFav_RegTot.Text = "Away Fav / Normal Total"
        Me.AmF_AwFav_RegTot.UseVisualStyleBackColor = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(542, 461)
        Me.Controls.Add(Me.LblSportSelect)
        Me.Controls.Add(Me.SportSelectBox)
        Me.Controls.Add(Me.American_Football_Panel)
        Me.Controls.Add(Me.Tennis_Panel)
        Me.Controls.Add(Me.Soccer_Panel)
        Me.Controls.Add(Me.Basketball_Panel)
        Me.Name = "MainPage"
        Me.Text = "Default Lines"
        Me.Soccer_Panel.ResumeLayout(False)
        Me.Basketball_Panel.ResumeLayout(False)
        Me.Tennis_Panel.ResumeLayout(False)
        Me.Tennis_Panel.PerformLayout()
        CType(Me.MainPageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.American_Football_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SportSelectBox As ComboBox
    Friend WithEvents LblSportSelect As Label
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
    Friend WithEvents Soccer_Panel As Panel
    Friend WithEvents Basketball_Panel As Panel
    Friend WithEvents Tennis_Panel As Panel
    Friend WithEvents LblTennisWomen As Label
    Friend WithEvents Tennis_MGrass_P1 As Button
    Friend WithEvents LblTennisWClay As Label
    Friend WithEvents LblTennisMen As Label
    Friend WithEvents LblTennisWHard As Label
    Friend WithEvents Tennis_MGrass_Avg As Button
    Friend WithEvents LblTennisWGrass As Label
    Friend WithEvents Tennis_MGrass_P2 As Button
    Friend WithEvents Tennis_WClay_P2 As Button
    Friend WithEvents Tennis_MHard_P1 As Button
    Friend WithEvents Tennis_WHard_P2 As Button
    Friend WithEvents Tennis_MHard_Avg As Button
    Friend WithEvents Tennis_WGrass_P2 As Button
    Friend WithEvents LblTennisMClay As Label
    Friend WithEvents Tennis_WClay_Avg As Button
    Friend WithEvents Tennis_MHard_P2 As Button
    Friend WithEvents Tennis_WHard_Avg As Button
    Friend WithEvents LblTennisMHard As Label
    Friend WithEvents Tennis_WGrass_Avg As Button
    Friend WithEvents Tennis_MClay_P1 As Button
    Friend WithEvents Tennis_WClay_P1 As Button
    Friend WithEvents LblTennisMGrass As Label
    Friend WithEvents Tennis_WHard_P1 As Button
    Friend WithEvents Tennis_MClay_Avg As Button
    Friend WithEvents Tennis_WGrass_P1 As Button
    Friend WithEvents Tennis_MClay_P2 As Button
    Friend WithEvents MainPageBindingSource As BindingSource
    Friend WithEvents American_Football_Panel As Panel
    Friend WithEvents AmF_AwFav_RegTot As Button
    Friend WithEvents AmF_LrgAwFav_RegTot As Button
    Friend WithEvents AmF_HmFav_RegTot As Button
    Friend WithEvents AmF_LrgHmFav_RegTot As Button
    Friend WithEvents AmF_LrgHmFav_LrgTot As Button
    Friend WithEvents AmF_LrgAwFav_LrgTot As Button
    Friend WithEvents AmF_HmFav_LrgTot As Button
    Friend WithEvents AmF_AwFav_LrgTotal As Button
End Class
