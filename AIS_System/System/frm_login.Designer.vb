<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.Office2013LightTheme1 = New Telerik.WinControls.Themes.Office2013LightTheme()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.Windows7Theme1 = New Telerik.WinControls.Themes.Windows7Theme()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btn_login = New Telerik.WinControls.UI.RadButton()
        Me.sbtn_themes = New Telerik.WinControls.UI.RadSplitButton()
        Me.defaultT = New Telerik.WinControls.UI.RadMenuItem()
        Me.aqua = New Telerik.WinControls.UI.RadMenuItem()
        Me.desert = New Telerik.WinControls.UI.RadMenuItem()
        Me.breeze = New Telerik.WinControls.UI.RadMenuItem()
        Me.MetroT = New Telerik.WinControls.UI.RadMenuItem()
        Me.MetroBT = New Telerik.WinControls.UI.RadMenuItem()
        Me.office2010blue = New Telerik.WinControls.UI.RadMenuItem()
        Me.office2010silver = New Telerik.WinControls.UI.RadMenuItem()
        Me.office2010black = New Telerik.WinControls.UI.RadMenuItem()
        Me.LightT = New Telerik.WinControls.UI.RadMenuItem()
        Me.DarkT = New Telerik.WinControls.UI.RadMenuItem()
        Me.LightT2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.darkT2 = New Telerik.WinControls.UI.RadMenuItem()
        Me.win7 = New Telerik.WinControls.UI.RadMenuItem()
        Me.win8 = New Telerik.WinControls.UI.RadMenuItem()
        Me.btn_database = New Telerik.WinControls.UI.RadButton()
        Me.RadMenuItem1 = New Telerik.WinControls.UI.RadDropDownMenu()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
        Me.BreezeTheme1 = New Telerik.WinControls.Themes.BreezeTheme()
        Me.DesertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
        Me.Office2013DarkTheme1 = New Telerik.WinControls.Themes.Office2013DarkTheme()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_username = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_password = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbtn_themes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_database, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMenuItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(-14, 38)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(457, 191)
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_login.Location = New System.Drawing.Point(139, 138)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(145, 39)
        Me.btn_login.TabIndex = 3
        Me.btn_login.TabStop = False
        Me.btn_login.Text = "Logi&n"
        Me.btn_login.ThemeName = "Office2013Dark"
        CType(Me.btn_login.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Logi&n"
        CType(Me.btn_login.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_login.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_login.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sbtn_themes
        '
        Me.sbtn_themes.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.sbtn_themes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.sbtn_themes.Items.AddRange(New Telerik.WinControls.RadItem() {Me.defaultT, Me.aqua, Me.desert, Me.breeze, Me.MetroT, Me.MetroBT, Me.office2010blue, Me.office2010silver, Me.office2010black, Me.LightT, Me.DarkT, Me.LightT2, Me.darkT2, Me.win7, Me.win8})
        Me.sbtn_themes.Location = New System.Drawing.Point(290, 138)
        Me.sbtn_themes.Name = "sbtn_themes"
        Me.sbtn_themes.Size = New System.Drawing.Size(141, 39)
        Me.sbtn_themes.TabIndex = 4
        Me.sbtn_themes.TabStop = False
        Me.sbtn_themes.Text = "&Appearance"
        Me.sbtn_themes.ThemeName = "Office2013Dark"
        CType(Me.sbtn_themes.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).Text = "&Appearance"
        CType(Me.sbtn_themes.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.sbtn_themes.GetChildAt(0), Telerik.WinControls.UI.RadSplitButtonElement).CanFocus = True
        CType(Me.sbtn_themes.GetChildAt(0).GetChildAt(1).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.sbtn_themes.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.sbtn_themes.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
        CType(Me.sbtn_themes.GetChildAt(0).GetChildAt(1).GetChildAt(1).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'defaultT
        '
        Me.defaultT.Name = "defaultT"
        Me.defaultT.Text = "Default Theme"
        '
        'aqua
        '
        Me.aqua.Name = "aqua"
        Me.aqua.Text = "Aqua Theme"
        '
        'desert
        '
        Me.desert.Name = "desert"
        Me.desert.Text = "Desert Theme"
        '
        'breeze
        '
        Me.breeze.Name = "breeze"
        Me.breeze.Text = "Breeze Theme"
        '
        'MetroT
        '
        Me.MetroT.Name = "MetroT"
        Me.MetroT.Text = "Metro Theme"
        '
        'MetroBT
        '
        Me.MetroBT.Name = "MetroBT"
        Me.MetroBT.Text = "Metro Blue Theme"
        '
        'office2010blue
        '
        Me.office2010blue.Name = "office2010blue"
        Me.office2010blue.Text = "Office 2010 Blue"
        '
        'office2010silver
        '
        Me.office2010silver.Name = "office2010silver"
        Me.office2010silver.Text = "Office 2010 Silver"
        '
        'office2010black
        '
        Me.office2010black.Name = "office2010black"
        Me.office2010black.Text = "Office 2010 Black"
        '
        'LightT
        '
        Me.LightT.Name = "LightT"
        Me.LightT.Text = "2012 Light Theme"
        '
        'DarkT
        '
        Me.DarkT.Name = "DarkT"
        Me.DarkT.Text = "2012 Dark Theme"
        '
        'LightT2
        '
        Me.LightT2.Name = "LightT2"
        Me.LightT2.Text = "2013 Light Theme"
        '
        'darkT2
        '
        Me.darkT2.Name = "darkT2"
        Me.darkT2.Text = "2013 Dark Theme"
        '
        'win7
        '
        Me.win7.Name = "win7"
        Me.win7.Text = "Window 7 Theme"
        '
        'win8
        '
        Me.win8.Name = "win8"
        Me.win8.Text = "Window 8 Theme"
        '
        'btn_database
        '
        Me.btn_database.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_database.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_database.Location = New System.Drawing.Point(139, 183)
        Me.btn_database.Name = "btn_database"
        Me.btn_database.Size = New System.Drawing.Size(292, 39)
        Me.btn_database.TabIndex = 5
        Me.btn_database.TabStop = False
        Me.btn_database.Text = "&Database"
        Me.btn_database.ThemeName = "Office2013Dark"
        CType(Me.btn_database.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "&Database"
        CType(Me.btn_database.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_database.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_database.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadMenuItem1
        '
        Me.RadMenuItem1.AnimationEnabled = True
        Me.RadMenuItem1.AnimationFrames = 1
        Me.RadMenuItem1.AnimationType = Telerik.WinControls.UI.PopupAnimationTypes.Fade
        Me.RadMenuItem1.AutoSize = True
        Me.RadMenuItem1.DropDownAnimationDirection = Telerik.WinControls.UI.RadDirection.Down
        Me.RadMenuItem1.DropShadow = True
        Me.RadMenuItem1.EasingType = Telerik.WinControls.RadEasingType.InQuad
        Me.RadMenuItem1.EnableAeroEffects = False
        Me.RadMenuItem1.FadeAnimationFrames = 10
        Me.RadMenuItem1.FadeAnimationSpeed = 10
        Me.RadMenuItem1.FadeAnimationType = Telerik.WinControls.UI.FadeAnimationType.FadeIn
        Me.RadMenuItem1.FitToScreenMode = CType((Telerik.WinControls.UI.FitToScreenModes.FitWidth Or Telerik.WinControls.UI.FitToScreenModes.FitHeight), Telerik.WinControls.UI.FitToScreenModes)
        Me.RadMenuItem1.HorizontalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.SnapToOuterEdges
        Me.RadMenuItem1.Location = New System.Drawing.Point(0, 0)
        Me.RadMenuItem1.Maximum = New System.Drawing.Size(0, 0)
        Me.RadMenuItem1.Minimum = New System.Drawing.Size(0, 0)
        Me.RadMenuItem1.Name = "RadMenuItem1"
        Me.RadMenuItem1.Opacity = 1.0!
        Me.RadMenuItem1.ProcessKeyboard = False
        Me.RadMenuItem1.RollOverItemSelection = True
        Me.RadMenuItem1.Size = New System.Drawing.Size(0, 0)
        Me.RadMenuItem1.TabIndex = 0
        Me.RadMenuItem1.VerticalAlignmentCorrectionMode = Telerik.WinControls.UI.AlignmentCorrectionMode.SnapToOuterEdges
        Me.RadMenuItem1.Visible = False
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(443, 45)
        Me.RadPanel1.TabIndex = 0
        Me.RadPanel1.Text = "USER LOGIN"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel7
        '
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Location = New System.Drawing.Point(139, 51)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel7.TabIndex = 0
        '
        'txt_username
        '
        Me.txt_username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_username.Location = New System.Drawing.Point(188, 51)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.NullText = "U&sername  (Rrequired)"
        '
        '
        '
        Me.txt_username.RootElement.StretchVertically = True
        Me.txt_username.Size = New System.Drawing.Size(243, 39)
        Me.txt_username.TabIndex = 1
        Me.txt_username.TabStop = False
        Me.txt_username.Text = "Jerome"
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_username.ThemeName = "Office2013Light"
        '
        'txt_password
        '
        Me.txt_password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_password.Location = New System.Drawing.Point(188, 96)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.NullText = "Us&erpassword  (Required)"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        '
        '
        '
        Me.txt_password.RootElement.StretchVertically = True
        Me.txt_password.Size = New System.Drawing.Size(243, 39)
        Me.txt_password.TabIndex = 2
        Me.txt_password.TabStop = False
        Me.txt_password.Text = "thunder"
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.ThemeName = "Office2013Light"
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Location = New System.Drawing.Point(139, 96)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel2.TabIndex = 135
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 229)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.RadPanel7)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.btn_database)
        Me.Controls.Add(Me.sbtn_themes)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_login"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Agrikulto System"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_login, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbtn_themes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_database, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMenuItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Office2013LightTheme1 As Telerik.WinControls.Themes.Office2013LightTheme
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents Windows7Theme1 As Telerik.WinControls.Themes.Windows7Theme
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents btn_login As Telerik.WinControls.UI.RadButton
    Friend WithEvents sbtn_themes As Telerik.WinControls.UI.RadSplitButton
    Friend WithEvents btn_database As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadMenuItem1 As Telerik.WinControls.UI.RadDropDownMenu
    Friend WithEvents MetroT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents MetroBT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents LightT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents DarkT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents LightT2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents win7 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents win8 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents defaultT As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents office2010black As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents office2010blue As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents office2010silver As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Friend WithEvents BreezeTheme1 As Telerik.WinControls.Themes.BreezeTheme
    Friend WithEvents DesertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Friend WithEvents aqua As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents desert As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents breeze As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents Office2013DarkTheme1 As Telerik.WinControls.Themes.Office2013DarkTheme
    Friend WithEvents darkT2 As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_username As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
End Class
