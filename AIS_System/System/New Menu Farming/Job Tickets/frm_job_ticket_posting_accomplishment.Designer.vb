<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_job_ticket_posting_accomplishment
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lv_scheduled_info = New Telerik.WinControls.UI.RadListView()
        Me.lv_lots_info = New Telerik.WinControls.UI.RadListView()
        Me.lv_mapower_info = New Telerik.WinControls.UI.RadListView()
        Me.lv_jobticket_for_posting = New Telerik.WinControls.UI.RadListView()
        Me.cms_menu_posting = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refresh = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.check = New Telerik.WinControls.UI.RadMenuItem()
        Me.uncheck = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.gb_approved = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_post_all = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox7 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.lv_scheduled_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_lots_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_mapower_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_jobticket_for_posting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_approved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_approved.SuspendLayout()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_post_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel4.SuspendLayout()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.RadGroupBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox7.SuspendLayout()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel5.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_scheduled_info
        '
        Me.lv_scheduled_info.AllowColumnReorder = False
        Me.lv_scheduled_info.AllowEdit = False
        Me.lv_scheduled_info.AllowRemove = False
        Me.lv_scheduled_info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_scheduled_info.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_scheduled_info.ItemSpacing = -1
        Me.lv_scheduled_info.Location = New System.Drawing.Point(1, 1)
        Me.lv_scheduled_info.Name = "lv_scheduled_info"
        Me.lv_scheduled_info.SelectLastAddedItem = False
        Me.lv_scheduled_info.Size = New System.Drawing.Size(809, 154)
        Me.lv_scheduled_info.TabIndex = 2
        Me.lv_scheduled_info.Text = "RadListView3"
        Me.lv_scheduled_info.ThemeName = "VisualStudio2012Light"
        Me.lv_scheduled_info.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_scheduled_info.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lv_lots_info
        '
        Me.lv_lots_info.AllowColumnReorder = False
        Me.lv_lots_info.AllowEdit = False
        Me.lv_lots_info.AllowRemove = False
        Me.lv_lots_info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lots_info.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_lots_info.ItemSpacing = -1
        Me.lv_lots_info.Location = New System.Drawing.Point(1, 1)
        Me.lv_lots_info.Name = "lv_lots_info"
        Me.lv_lots_info.SelectLastAddedItem = False
        Me.lv_lots_info.Size = New System.Drawing.Size(809, 154)
        Me.lv_lots_info.TabIndex = 1
        Me.lv_lots_info.Text = "RadListView2"
        Me.lv_lots_info.ThemeName = "VisualStudio2012Light"
        Me.lv_lots_info.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_lots_info.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lv_mapower_info
        '
        Me.lv_mapower_info.AllowColumnReorder = False
        Me.lv_mapower_info.AllowEdit = False
        Me.lv_mapower_info.AllowRemove = False
        Me.lv_mapower_info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_mapower_info.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_mapower_info.ItemSpacing = -1
        Me.lv_mapower_info.Location = New System.Drawing.Point(1, 1)
        Me.lv_mapower_info.Name = "lv_mapower_info"
        Me.lv_mapower_info.SelectLastAddedItem = False
        Me.lv_mapower_info.Size = New System.Drawing.Size(808, 154)
        Me.lv_mapower_info.TabIndex = 0
        Me.lv_mapower_info.Text = "RadListView1"
        Me.lv_mapower_info.ThemeName = "VisualStudio2012Light"
        Me.lv_mapower_info.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_mapower_info.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lv_jobticket_for_posting
        '
        Me.lv_jobticket_for_posting.AllowColumnReorder = False
        Me.lv_jobticket_for_posting.AllowEdit = False
        Me.lv_jobticket_for_posting.AllowRemove = False
        Me.lv_jobticket_for_posting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_jobticket_for_posting.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick
        Me.lv_jobticket_for_posting.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_jobticket_for_posting.ItemSpacing = -1
        Me.lv_jobticket_for_posting.Location = New System.Drawing.Point(1, 1)
        Me.lv_jobticket_for_posting.Name = "lv_jobticket_for_posting"
        Me.lv_jobticket_for_posting.SelectLastAddedItem = False
        Me.lv_jobticket_for_posting.ShowCheckBoxes = True
        Me.lv_jobticket_for_posting.Size = New System.Drawing.Size(406, 510)
        Me.lv_jobticket_for_posting.TabIndex = 0
        Me.lv_jobticket_for_posting.Text = "RadListView1"
        Me.lv_jobticket_for_posting.ThemeName = "VisualStudio2012Light"
        Me.lv_jobticket_for_posting.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_jobticket_for_posting.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cms_menu_posting
        '
        Me.cms_menu_posting.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refresh, Me.RadMenuSeparatorItem1, Me.check, Me.uncheck})
        '
        'refresh
        '
        Me.refresh.Name = "refresh"
        Me.refresh.Text = "Refresh Data"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'check
        '
        Me.check.Name = "check"
        Me.check.Text = "Check all"
        '
        'uncheck
        '
        Me.uncheck.Name = "uncheck"
        Me.uncheck.Text = "Uncheck all"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1242, 44)
        Me.RadPanel1.TabIndex = 11
        Me.RadPanel1.Text = "ACCOMPLISHED JOB TICKET FOR POSTING"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_approved
        '
        Me.gb_approved.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_approved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_approved.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_approved.Controls.Add(Me.btn_post_all)
        Me.gb_approved.Controls.Add(Me.RadGroupBox1)
        Me.gb_approved.HeaderText = ""
        Me.gb_approved.Location = New System.Drawing.Point(0, 45)
        Me.gb_approved.Name = "gb_approved"
        Me.gb_approved.Size = New System.Drawing.Size(418, 594)
        Me.gb_approved.TabIndex = 16
        Me.gb_approved.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox1.Controls.Add(Me.RadPanel2)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderText = "TICKET LIST FOR POSTING"
        Me.RadGroupBox1.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(408, 580)
        Me.RadGroupBox1.TabIndex = 10
        Me.RadGroupBox1.Text = "TICKET LIST FOR POSTING"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Light"
        '
        'btn_post_all
        '
        Me.btn_post_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_post_all.BackColor = System.Drawing.Color.Black
        Me.btn_post_all.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_post_all.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_post_all.Location = New System.Drawing.Point(5, 551)
        Me.btn_post_all.Name = "btn_post_all"
        Me.btn_post_all.Size = New System.Drawing.Size(408, 38)
        Me.btn_post_all.TabIndex = 176
        Me.btn_post_all.Text = "POST ALL CHECK ITEM"
        Me.btn_post_all.ThemeName = "Office2013Dark"
        CType(Me.btn_post_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_post_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "POST ALL CHECK ITEM"
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_post_all.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel2
        '
        Me.RadPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Controls.Add(Me.lv_jobticket_for_posting)
        Me.RadPanel2.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(408, 512)
        Me.RadPanel2.TabIndex = 130
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox2.Controls.Add(Me.RadGroupBox3)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(421, 45)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(821, 194)
        Me.RadGroupBox2.TabIndex = 17
        Me.RadGroupBox2.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox3.Controls.Add(Me.RadPanel3)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox3.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox3.HeaderText = "SCHEDULE INFORMATION"
        Me.RadGroupBox3.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(811, 180)
        Me.RadGroupBox3.TabIndex = 10
        Me.RadGroupBox3.Text = "SCHEDULE INFORMATION"
        Me.RadGroupBox3.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel3
        '
        Me.RadPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Controls.Add(Me.lv_scheduled_info)
        Me.RadPanel3.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(811, 156)
        Me.RadPanel3.TabIndex = 130
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox4.Controls.Add(Me.RadGroupBox5)
        Me.RadGroupBox4.HeaderText = ""
        Me.RadGroupBox4.Location = New System.Drawing.Point(421, 245)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(821, 194)
        Me.RadGroupBox4.TabIndex = 18
        Me.RadGroupBox4.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox5.Controls.Add(Me.RadPanel4)
        Me.RadGroupBox5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox5.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox5.HeaderText = "LOTS INFORMATION"
        Me.RadGroupBox5.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        Me.RadGroupBox5.Size = New System.Drawing.Size(811, 180)
        Me.RadGroupBox5.TabIndex = 10
        Me.RadGroupBox5.Text = "LOTS INFORMATION"
        Me.RadGroupBox5.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel4
        '
        Me.RadPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Controls.Add(Me.lv_lots_info)
        Me.RadPanel4.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(811, 156)
        Me.RadPanel4.TabIndex = 130
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox6.Controls.Add(Me.RadGroupBox7)
        Me.RadGroupBox6.HeaderText = ""
        Me.RadGroupBox6.Location = New System.Drawing.Point(421, 445)
        Me.RadGroupBox6.Name = "RadGroupBox6"
        Me.RadGroupBox6.Size = New System.Drawing.Size(821, 194)
        Me.RadGroupBox6.TabIndex = 19
        Me.RadGroupBox6.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox7
        '
        Me.RadGroupBox7.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox7.Controls.Add(Me.RadPanel5)
        Me.RadGroupBox7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox7.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox7.HeaderText = "MANPOWER INFORMATION"
        Me.RadGroupBox7.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox7.Name = "RadGroupBox7"
        Me.RadGroupBox7.Size = New System.Drawing.Size(811, 180)
        Me.RadGroupBox7.TabIndex = 10
        Me.RadGroupBox7.Text = "MANPOWER INFORMATION"
        Me.RadGroupBox7.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel5
        '
        Me.RadPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Controls.Add(Me.lv_mapower_info)
        Me.RadPanel5.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(811, 156)
        Me.RadPanel5.TabIndex = 130
        '
        'Frm_job_ticket_posting_accomplishment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 639)
        Me.Controls.Add(Me.RadGroupBox6)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.gb_approved)
        Me.Controls.Add(Me.RadPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_job_ticket_posting_accomplishment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Job Ticket"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.lv_scheduled_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_lots_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_mapower_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_jobticket_for_posting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_approved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_approved.ResumeLayout(False)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.btn_post_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel4.ResumeLayout(False)
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        CType(Me.RadGroupBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox7.ResumeLayout(False)
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel5.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_jobticket_for_posting As Telerik.WinControls.UI.RadListView
    Friend WithEvents cms_menu_posting As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refresh As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents check As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents uncheck As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents lv_scheduled_info As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_lots_info As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_mapower_info As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents gb_approved As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_post_all As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox7 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
End Class

