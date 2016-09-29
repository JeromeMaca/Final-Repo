<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_job_ticket_scheduled_printing
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
        Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
        Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.lv_lots = New Telerik.WinControls.UI.RadListView()
        Me.ToolTabStrip5 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.lv_manpower = New Telerik.WinControls.UI.RadListView()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_generate_report = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_schedule = New Telerik.WinControls.UI.RadListView()
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.rpt_job_ticket = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip3.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip5.SuspendLayout()
        Me.ToolWindow3.SuspendLayout()
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.btn_generate_report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.lv_schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel9.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadSplitContainer2
        '
        Me.RadSplitContainer2.IsCleanUpTarget = True
        Me.RadSplitContainer2.Location = New System.Drawing.Point(5, 5)
        Me.RadSplitContainer2.Name = "RadSplitContainer2"
        Me.RadSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadSplitContainer2.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadSplitContainer2.Size = New System.Drawing.Size(443, 506)
        Me.RadSplitContainer2.SizeInfo.AbsoluteSize = New System.Drawing.Size(443, 200)
        Me.RadSplitContainer2.SizeInfo.SplitterCorrection = New System.Drawing.Size(243, 0)
        Me.RadSplitContainer2.TabIndex = 7
        Me.RadSplitContainer2.TabStop = False
        Me.RadSplitContainer2.UseSplitterButtons = True
        '
        'ToolTabStrip3
        '
        Me.ToolTabStrip3.CanUpdateChildIndex = True
        Me.ToolTabStrip3.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip3.Location = New System.Drawing.Point(0, 221)
        Me.ToolTabStrip3.Name = "ToolTabStrip3"
        '
        '
        '
        Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.ToolTabStrip3.SelectedIndex = 0
        Me.ToolTabStrip3.Size = New System.Drawing.Size(443, 285)
        Me.ToolTabStrip3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.004950505!)
        Me.ToolTabStrip3.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -7)
        Me.ToolTabStrip3.TabIndex = 9
        Me.ToolTabStrip3.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.lv_lots)
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(4, 4)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(435, 277)
        Me.ToolWindow1.Text = "Job Ticket Lots"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_lots
        '
        Me.lv_lots.AllowColumnReorder = False
        Me.lv_lots.AllowEdit = False
        Me.lv_lots.AllowRemove = False
        Me.lv_lots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_lots.ItemSpacing = -1
        Me.lv_lots.Location = New System.Drawing.Point(3, 2)
        Me.lv_lots.Name = "lv_lots"
        Me.lv_lots.SelectLastAddedItem = False
        Me.lv_lots.Size = New System.Drawing.Size(435, 120)
        Me.lv_lots.TabIndex = 1
        Me.lv_lots.Text = "RadListView2"
        Me.lv_lots.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'ToolTabStrip5
        '
        Me.ToolTabStrip5.CanUpdateChildIndex = True
        Me.ToolTabStrip5.Controls.Add(Me.ToolWindow3)
        Me.ToolTabStrip5.Location = New System.Drawing.Point(0, 304)
        Me.ToolTabStrip5.Name = "ToolTabStrip5"
        '
        '
        '
        Me.ToolTabStrip5.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.ToolTabStrip5.SelectedIndex = 0
        Me.ToolTabStrip5.Size = New System.Drawing.Size(443, 202)
        Me.ToolTabStrip5.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.07260725!)
        Me.ToolTabStrip5.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 172)
        Me.ToolTabStrip5.TabIndex = 7
        Me.ToolTabStrip5.TabStop = False
        '
        'ToolWindow3
        '
        Me.ToolWindow3.Caption = Nothing
        Me.ToolWindow3.Controls.Add(Me.lv_manpower)
        Me.ToolWindow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow3.Location = New System.Drawing.Point(4, 4)
        Me.ToolWindow3.Name = "ToolWindow3"
        Me.ToolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow3.Size = New System.Drawing.Size(435, 194)
        Me.ToolWindow3.Text = "Job Ticket Manpowers"
        Me.ToolWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_manpower
        '
        Me.lv_manpower.AllowColumnReorder = False
        Me.lv_manpower.AllowEdit = False
        Me.lv_manpower.AllowRemove = False
        Me.lv_manpower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_manpower.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_manpower.ItemSpacing = -1
        Me.lv_manpower.Location = New System.Drawing.Point(3, 3)
        Me.lv_manpower.Name = "lv_manpower"
        Me.lv_manpower.SelectLastAddedItem = False
        Me.lv_manpower.Size = New System.Drawing.Size(429, 169)
        Me.lv_manpower.TabIndex = 2
        Me.lv_manpower.Text = "RadListView3"
        Me.lv_manpower.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1292, 44)
        Me.RadPanel1.TabIndex = 9
        Me.RadPanel1.Text = "SCHEDULED JOB TICKET PRINTING"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox4.Controls.Add(Me.btn_generate_report)
        Me.RadGroupBox4.Controls.Add(Me.RadGroupBox1)
        Me.RadGroupBox4.HeaderText = ""
        Me.RadGroupBox4.Location = New System.Drawing.Point(0, 45)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(422, 562)
        Me.RadGroupBox4.TabIndex = 14
        Me.RadGroupBox4.ThemeName = "TelerikMetroBlue"
        '
        'btn_generate_report
        '
        Me.btn_generate_report.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate_report.BackColor = System.Drawing.Color.Black
        Me.btn_generate_report.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_generate_report.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_generate_report.Location = New System.Drawing.Point(5, 519)
        Me.btn_generate_report.Name = "btn_generate_report"
        Me.btn_generate_report.Size = New System.Drawing.Size(411, 38)
        Me.btn_generate_report.TabIndex = 176
        Me.btn_generate_report.Text = "GENERATE HARDCOPY"
        Me.btn_generate_report.ThemeName = "Office2013Dark"
        CType(Me.btn_generate_report.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_generate_report.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "GENERATE HARDCOPY"
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_generate_report.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
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
        Me.RadGroupBox1.HeaderText = "APPROVED TICKET"
        Me.RadGroupBox1.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(412, 548)
        Me.RadGroupBox1.TabIndex = 10
        Me.RadGroupBox1.Text = "APPROVED TICKET"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel2
        '
        Me.RadPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Controls.Add(Me.lv_schedule)
        Me.RadPanel2.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(412, 482)
        Me.RadPanel2.TabIndex = 130
        '
        'lv_schedule
        '
        Me.lv_schedule.AllowColumnReorder = False
        Me.lv_schedule.AllowEdit = False
        Me.lv_schedule.AllowRemove = False
        Me.lv_schedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_schedule.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_schedule.ItemSpacing = -1
        Me.lv_schedule.Location = New System.Drawing.Point(1, 1)
        Me.lv_schedule.Name = "lv_schedule"
        Me.lv_schedule.SelectLastAddedItem = False
        Me.lv_schedule.Size = New System.Drawing.Size(410, 480)
        Me.lv_schedule.TabIndex = 0
        Me.lv_schedule.Text = "RadListView1"
        Me.lv_schedule.ThemeName = "VisualStudio2012Light"
        Me.lv_schedule.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_schedule.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox5.Controls.Add(Me.RadGroupBox6)
        Me.RadGroupBox5.HeaderText = ""
        Me.RadGroupBox5.Location = New System.Drawing.Point(423, 45)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        Me.RadGroupBox5.Size = New System.Drawing.Size(869, 562)
        Me.RadGroupBox5.TabIndex = 16
        Me.RadGroupBox5.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox6.Controls.Add(Me.RadPanel9)
        Me.RadGroupBox6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox6.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox6.HeaderText = "JOB TICKET HARDCOPY"
        Me.RadGroupBox6.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox6.Name = "RadGroupBox6"
        Me.RadGroupBox6.Size = New System.Drawing.Size(859, 548)
        Me.RadGroupBox6.TabIndex = 10
        Me.RadGroupBox6.Text = "JOB TICKET HARDCOPY"
        Me.RadGroupBox6.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel9
        '
        Me.RadPanel9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel9.Controls.Add(Me.rpt_job_ticket)
        Me.RadPanel9.Location = New System.Drawing.Point(0, 24)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(859, 524)
        Me.RadPanel9.TabIndex = 131
        '
        'rpt_job_ticket
        '
        Me.rpt_job_ticket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rpt_job_ticket.Location = New System.Drawing.Point(0, 0)
        Me.rpt_job_ticket.Name = "rpt_job_ticket"
        Me.rpt_job_ticket.ShowBackButton = False
        Me.rpt_job_ticket.ShowExportButton = False
        Me.rpt_job_ticket.ShowFindControls = False
        Me.rpt_job_ticket.ShowRefreshButton = False
        Me.rpt_job_ticket.ShowStopButton = False
        Me.rpt_job_ticket.Size = New System.Drawing.Size(859, 524)
        Me.rpt_job_ticket.TabIndex = 0
        '
        'Frm_job_ticket_scheduled_printing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1292, 607)
        Me.Controls.Add(Me.RadGroupBox5)
        Me.Controls.Add(Me.RadGroupBox4)
        Me.Controls.Add(Me.RadPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_job_ticket_scheduled_printing"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "AIS: Job Ticket"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip3.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip5.ResumeLayout(False)
        Me.ToolWindow3.ResumeLayout(False)
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.btn_generate_report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.lv_schedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel9.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents lv_lots As Telerik.WinControls.UI.RadListView
    Friend WithEvents ToolTabStrip5 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents lv_manpower As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_generate_report As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lv_schedule As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rpt_job_ticket As Microsoft.Reporting.WinForms.ReportViewer
End Class

