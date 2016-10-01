<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_job_ticket_for_processing_accomplishment
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
        Me.lv_for_processing = New Telerik.WinControls.UI.RadListView()
        Me.lv_scheduled = New Telerik.WinControls.UI.RadListView()
        Me.lv_manpower = New Telerik.WinControls.UI.RadListView()
        Me.lv_lots = New Telerik.WinControls.UI.RadListView()
        Me.cms_for_processing = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refresh = New Telerik.WinControls.UI.RadMenuItem()
        Me.sep_1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.check_all = New Telerik.WinControls.UI.RadMenuItem()
        Me.uncheck_all = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.gb_approved = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_process_all = New Telerik.WinControls.UI.RadButton()
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
        CType(Me.lv_for_processing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_scheduled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_approved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_approved.SuspendLayout()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lv_for_processing
        '
        Me.lv_for_processing.AllowColumnReorder = False
        Me.lv_for_processing.AllowEdit = False
        Me.lv_for_processing.AllowRemove = False
        Me.lv_for_processing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_for_processing.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_for_processing.ItemSpacing = -1
        Me.lv_for_processing.Location = New System.Drawing.Point(1, 1)
        Me.lv_for_processing.Name = "lv_for_processing"
        Me.lv_for_processing.SelectLastAddedItem = False
        Me.lv_for_processing.ShowCheckBoxes = True
        Me.lv_for_processing.Size = New System.Drawing.Size(406, 308)
        Me.lv_for_processing.TabIndex = 0
        Me.lv_for_processing.Text = "RadListView1"
        Me.lv_for_processing.ThemeName = "VisualStudio2012Light"
        Me.lv_for_processing.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_for_processing.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lv_scheduled
        '
        Me.lv_scheduled.AllowColumnReorder = False
        Me.lv_scheduled.AllowEdit = False
        Me.lv_scheduled.AllowRemove = False
        Me.lv_scheduled.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_scheduled.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_scheduled.ItemSpacing = -1
        Me.lv_scheduled.Location = New System.Drawing.Point(1, 1)
        Me.lv_scheduled.Name = "lv_scheduled"
        Me.lv_scheduled.SelectLastAddedItem = False
        Me.lv_scheduled.Size = New System.Drawing.Size(879, 101)
        Me.lv_scheduled.TabIndex = 1
        Me.lv_scheduled.Text = "RadListView2"
        Me.lv_scheduled.ThemeName = "VisualStudio2012Light"
        Me.lv_scheduled.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_scheduled.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'lv_manpower
        '
        Me.lv_manpower.AllowColumnReorder = False
        Me.lv_manpower.AllowEdit = False
        Me.lv_manpower.AllowRemove = False
        Me.lv_manpower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_manpower.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_manpower.ItemSpacing = -1
        Me.lv_manpower.Location = New System.Drawing.Point(1, 1)
        Me.lv_manpower.Name = "lv_manpower"
        Me.lv_manpower.SelectLastAddedItem = False
        Me.lv_manpower.Size = New System.Drawing.Size(879, 208)
        Me.lv_manpower.TabIndex = 3
        Me.lv_manpower.Text = "RadListView4"
        Me.lv_manpower.ThemeName = "VisualStudio2012Light"
        Me.lv_manpower.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_manpower.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer))
        '
        'lv_lots
        '
        Me.lv_lots.AllowColumnReorder = False
        Me.lv_lots.AllowEdit = False
        Me.lv_lots.AllowRemove = False
        Me.lv_lots.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_lots.ItemSpacing = -1
        Me.lv_lots.Location = New System.Drawing.Point(1, 1)
        Me.lv_lots.Name = "lv_lots"
        Me.lv_lots.SelectLastAddedItem = False
        Me.lv_lots.Size = New System.Drawing.Size(1303, 165)
        Me.lv_lots.TabIndex = 2
        Me.lv_lots.Text = "RadListView3"
        Me.lv_lots.ThemeName = "VisualStudio2012Light"
        Me.lv_lots.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_lots.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cms_for_processing
        '
        Me.cms_for_processing.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refresh, Me.sep_1, Me.check_all, Me.uncheck_all})
        '
        'refresh
        '
        Me.refresh.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.refresh.Name = "refresh"
        Me.refresh.Text = "Refresh Data"
        '
        'sep_1
        '
        Me.sep_1.Name = "sep_1"
        Me.sep_1.Text = "RadMenuSeparatorItem1"
        Me.sep_1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'check_all
        '
        Me.check_all.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_all.Name = "check_all"
        Me.check_all.Text = "Check All Items"
        '
        'uncheck_all
        '
        Me.uncheck_all.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.uncheck_all.Name = "uncheck_all"
        Me.uncheck_all.Text = "Uncheck All Items"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1315, 44)
        Me.RadPanel1.TabIndex = 11
        Me.RadPanel1.Text = "SCHEDULED JOB TICKET PROCESS ALL ENCODED ACCOMPLISHMENT"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_approved
        '
        Me.gb_approved.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_approved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_approved.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_approved.Controls.Add(Me.RadGroupBox1)
        Me.gb_approved.HeaderText = ""
        Me.gb_approved.Location = New System.Drawing.Point(0, 45)
        Me.gb_approved.Name = "gb_approved"
        Me.gb_approved.Size = New System.Drawing.Size(418, 390)
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
        Me.RadGroupBox1.Controls.Add(Me.btn_process_all)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel2)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderText = "TICKET FOR CONFIRMATION"
        Me.RadGroupBox1.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(408, 376)
        Me.RadGroupBox1.TabIndex = 10
        Me.RadGroupBox1.Text = "TICKET FOR CONFIRMATION"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Light"
        '
        'btn_process_all
        '
        Me.btn_process_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_process_all.BackColor = System.Drawing.Color.Black
        Me.btn_process_all.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_process_all.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_process_all.Location = New System.Drawing.Point(0, 338)
        Me.btn_process_all.Name = "btn_process_all"
        Me.btn_process_all.Size = New System.Drawing.Size(408, 38)
        Me.btn_process_all.TabIndex = 176
        Me.btn_process_all.Text = "PROCEED ENCODING"
        Me.btn_process_all.ThemeName = "Office2013Dark"
        CType(Me.btn_process_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_process_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "PROCEED ENCODING"
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_process_all.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel2
        '
        Me.RadPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Controls.Add(Me.lv_for_processing)
        Me.RadPanel2.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(408, 310)
        Me.RadPanel2.TabIndex = 130
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox2.Controls.Add(Me.RadGroupBox3)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(424, 45)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(891, 141)
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
        Me.RadGroupBox3.HeaderText = "TICKET SCHEDULED INFORMATION"
        Me.RadGroupBox3.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(881, 127)
        Me.RadGroupBox3.TabIndex = 10
        Me.RadGroupBox3.Text = "TICKET SCHEDULED INFORMATION"
        Me.RadGroupBox3.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel3
        '
        Me.RadPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Controls.Add(Me.lv_scheduled)
        Me.RadPanel3.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(881, 103)
        Me.RadPanel3.TabIndex = 130
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox4.Controls.Add(Me.RadGroupBox5)
        Me.RadGroupBox4.HeaderText = ""
        Me.RadGroupBox4.Location = New System.Drawing.Point(424, 187)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(891, 248)
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
        Me.RadGroupBox5.HeaderText = "TICKET MANPOWER INFORMATION"
        Me.RadGroupBox5.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        Me.RadGroupBox5.Size = New System.Drawing.Size(881, 234)
        Me.RadGroupBox5.TabIndex = 10
        Me.RadGroupBox5.Text = "TICKET MANPOWER INFORMATION"
        Me.RadGroupBox5.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel4
        '
        Me.RadPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Controls.Add(Me.lv_manpower)
        Me.RadPanel4.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(881, 210)
        Me.RadPanel4.TabIndex = 130
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox6.Controls.Add(Me.RadGroupBox7)
        Me.RadGroupBox6.HeaderText = ""
        Me.RadGroupBox6.Location = New System.Drawing.Point(0, 441)
        Me.RadGroupBox6.Name = "RadGroupBox6"
        Me.RadGroupBox6.Size = New System.Drawing.Size(1315, 205)
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
        Me.RadGroupBox7.HeaderText = "TICKET LOTS INFORMATION"
        Me.RadGroupBox7.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox7.Name = "RadGroupBox7"
        Me.RadGroupBox7.Size = New System.Drawing.Size(1305, 191)
        Me.RadGroupBox7.TabIndex = 10
        Me.RadGroupBox7.Text = "TICKET LOTS INFORMATION"
        Me.RadGroupBox7.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel5
        '
        Me.RadPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Controls.Add(Me.lv_lots)
        Me.RadPanel5.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(1305, 167)
        Me.RadPanel5.TabIndex = 130
        '
        'Frm_job_ticket_for_processing_accomplishment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 647)
        Me.Controls.Add(Me.RadGroupBox6)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.gb_approved)
        Me.Controls.Add(Me.RadPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_job_ticket_for_processing_accomplishment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Job Ticket"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.lv_for_processing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_scheduled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_approved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_approved.ResumeLayout(False)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lv_for_processing As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_scheduled As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_lots As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_manpower As Telerik.WinControls.UI.RadListView
    Friend WithEvents cms_for_processing As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents check_all As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents uncheck_all As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents gb_approved As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_process_all As Telerik.WinControls.UI.RadButton
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
    Friend WithEvents refresh As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents sep_1 As Telerik.WinControls.UI.RadMenuSeparatorItem
End Class

