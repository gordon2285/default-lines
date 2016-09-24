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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Soccer_AFav_HTot = New System.Windows.Forms.Button()
        Me.Soccer_HFav_HTot = New System.Windows.Forms.Button()
        Me.Soccer_AFav_NTot = New System.Windows.Forms.Button()
        Me.Soccer_HFav_NTot = New System.Windows.Forms.Button()
        Me.Soccer_Standard = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Basetball_LrgAwFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgHmFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_SmAwFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_SmHmFav_HiTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgAwFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_LrgHmFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_SmAwFav_LoTot = New System.Windows.Forms.Button()
        Me.Basketball_SmHmFav_LoTot = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a sport:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(37, 102)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 331)
        Me.TabControl1.TabIndex = 2
        Me.TabControl1.Visible = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Soccer_AFav_HTot)
        Me.TabPage1.Controls.Add(Me.Soccer_HFav_HTot)
        Me.TabPage1.Controls.Add(Me.Soccer_AFav_NTot)
        Me.TabPage1.Controls.Add(Me.Soccer_HFav_NTot)
        Me.TabPage1.Controls.Add(Me.Soccer_Standard)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(434, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Soccer"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Tennis_WClay_P2)
        Me.TabPage2.Controls.Add(Me.Tennis_WHard_P2)
        Me.TabPage2.Controls.Add(Me.Tennis_WGrass_P2)
        Me.TabPage2.Controls.Add(Me.Tennis_WClay_Avg)
        Me.TabPage2.Controls.Add(Me.Tennis_WHard_Avg)
        Me.TabPage2.Controls.Add(Me.Tennis_WGrass_Avg)
        Me.TabPage2.Controls.Add(Me.Tennis_WClay_P1)
        Me.TabPage2.Controls.Add(Me.Tennis_WHard_P1)
        Me.TabPage2.Controls.Add(Me.Tennis_WGrass_P1)
        Me.TabPage2.Controls.Add(Me.Tennis_MClay_P2)
        Me.TabPage2.Controls.Add(Me.Tennis_MHard_P2)
        Me.TabPage2.Controls.Add(Me.Tennis_MGrass_P2)
        Me.TabPage2.Controls.Add(Me.Tennis_MClay_Avg)
        Me.TabPage2.Controls.Add(Me.Tennis_MHard_Avg)
        Me.TabPage2.Controls.Add(Me.Tennis_MGrass_Avg)
        Me.TabPage2.Controls.Add(Me.Tennis_MClay_P1)
        Me.TabPage2.Controls.Add(Me.Tennis_MHard_P1)
        Me.TabPage2.Controls.Add(Me.Tennis_MGrass_P1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(434, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tennis"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Basetball_LrgAwFav_HiTot)
        Me.TabPage3.Controls.Add(Me.Basketball_LrgHmFav_HiTot)
        Me.TabPage3.Controls.Add(Me.Basketball_SmAwFav_HiTot)
        Me.TabPage3.Controls.Add(Me.Basketball_SmHmFav_HiTot)
        Me.TabPage3.Controls.Add(Me.Basketball_LrgAwFav_LoTot)
        Me.TabPage3.Controls.Add(Me.Basketball_LrgHmFav_LoTot)
        Me.TabPage3.Controls.Add(Me.Basketball_SmAwFav_LoTot)
        Me.TabPage3.Controls.Add(Me.Basketball_SmHmFav_LoTot)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(434, 305)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Basketball"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Grass"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Hard"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Clay"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Grass"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Hard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Clay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Men"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Women"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 445)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SportSelectBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SportSelectBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
