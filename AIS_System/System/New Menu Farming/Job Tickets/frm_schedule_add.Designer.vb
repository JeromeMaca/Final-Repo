﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_schedule_job_ticket_add
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
        Me.components = New System.ComponentModel.Container()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.dw_lot = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.dw_manpower = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.tw_schedule = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.DocumentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_schedule_add_hdr = New Telerik.WinControls.UI.RadListView()
        Me.dt_ST_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_ST_purpose = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_add_request = New Telerik.WinControls.UI.RadButton()
        Me.cms_schedule_add_menu = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refresh_data = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.assign_data = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.tw_schedule.SuspendLayout()
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip2.SuspendLayout()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip2.SuspendLayout()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.lv_schedule_add_hdr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip2)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(838, 371)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-363, -189)
        Me.DocumentContainer1.UseSplitterButtons = True
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.AllowShowFocusCues = True
        Me.DocumentTabStrip1.CanUpdateChildIndex = True
        Me.DocumentTabStrip1.Controls.Add(Me.dw_lot)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(640, 371)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'dw_lot
        '
        Me.dw_lot.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.dw_lot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dw_lot.Location = New System.Drawing.Point(6, 29)
        Me.dw_lot.Name = "dw_lot"
        Me.dw_lot.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.dw_lot.Size = New System.Drawing.Size(628, 336)
        Me.dw_lot.Text = "Location Job Schedule"
        '
        'dw_manpower
        '
        Me.dw_manpower.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.dw_manpower.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dw_manpower.Location = New System.Drawing.Point(6, 29)
        Me.dw_manpower.Name = "dw_manpower"
        Me.dw_manpower.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.dw_manpower.Size = New System.Drawing.Size(627, 336)
        Me.dw_manpower.Text = "Manpower Job Schedule"
        '
        'ToolWindow1
        '
        Me.ToolWindow1.AutoScroll = True
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(4, 4)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(314, 599)
        Me.ToolWindow1.Text = "ToolWindow1"
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.dw_lot
        Me.RadDock1.Controls.Add(Me.ToolTabStrip2)
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.Size = New System.Drawing.Size(1293, 708)
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        Me.RadDock1.UseSplitterButtons = True
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(322, 607)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(322, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(122, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'tw_schedule
        '
        Me.tw_schedule.Caption = Nothing
        Me.tw_schedule.Controls.Add(Me.RadGroupBox2)
        Me.tw_schedule.Controls.Add(Me.RadGroupBox1)
        Me.tw_schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tw_schedule.Location = New System.Drawing.Point(1, 22)
        Me.tw_schedule.Name = "tw_schedule"
        Me.tw_schedule.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.tw_schedule.Size = New System.Drawing.Size(1281, 299)
        Me.tw_schedule.Text = "Job Ticket Schedule"
        Me.tw_schedule.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'ToolTabStrip2
        '
        Me.ToolTabStrip2.CanUpdateChildIndex = True
        Me.ToolTabStrip2.Controls.Add(Me.tw_schedule)
        Me.ToolTabStrip2.Location = New System.Drawing.Point(5, 5)
        Me.ToolTabStrip2.Name = "ToolTabStrip2"
        '
        '
        '
        Me.ToolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip2.SelectedIndex = 0
        Me.ToolTabStrip2.Size = New System.Drawing.Size(1283, 323)
        Me.ToolTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 323)
        Me.ToolTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 123)
        Me.ToolTabStrip2.TabIndex = 2
        Me.ToolTabStrip2.TabStop = False
        '
        'DocumentTabStrip2
        '
        Me.DocumentTabStrip2.CanUpdateChildIndex = True
        Me.DocumentTabStrip2.Controls.Add(Me.dw_manpower)
        Me.DocumentTabStrip2.Location = New System.Drawing.Point(644, 0)
        Me.DocumentTabStrip2.Name = "DocumentTabStrip2"
        '
        '
        '
        Me.DocumentTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip2.SelectedIndex = 0
        Me.DocumentTabStrip2.Size = New System.Drawing.Size(639, 371)
        Me.DocumentTabStrip2.TabIndex = 1
        Me.DocumentTabStrip2.TabStop = False
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox1.Controls.Add(Me.btn_add_request)
        Me.RadGroupBox1.Controls.Add(Me.dp_location)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.txt_ST_purpose)
        Me.RadGroupBox1.Controls.Add(Me.dt_ST_date)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadGroupBox1.FooterImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderText = "Fill-up Information"
        Me.RadGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(446, 299)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.Text = "Fill-up Information"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox2.Controls.Add(Me.RadButton1)
        Me.RadGroupBox2.Controls.Add(Me.lv_schedule_add_hdr)
        Me.RadGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox2.FooterImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox2.HeaderText = "Queued Data Item"
        Me.RadGroupBox2.HeaderTextAlignment = System.Drawing.ContentAlignment.BottomCenter
        Me.RadGroupBox2.Location = New System.Drawing.Point(446, 0)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(835, 299)
        Me.RadGroupBox2.TabIndex = 1
        Me.RadGroupBox2.Text = "Queued Data Item"
        '
        'lv_schedule_add_hdr
        '
        Me.lv_schedule_add_hdr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_schedule_add_hdr.ItemSpacing = -1
        Me.lv_schedule_add_hdr.Location = New System.Drawing.Point(2, 20)
        Me.lv_schedule_add_hdr.Name = "lv_schedule_add_hdr"
        Me.lv_schedule_add_hdr.Size = New System.Drawing.Size(831, 247)
        Me.lv_schedule_add_hdr.TabIndex = 0
        Me.lv_schedule_add_hdr.Text = "RadListView1"
        Me.lv_schedule_add_hdr.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'dt_ST_date
        '
        Me.dt_ST_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_ST_date.Location = New System.Drawing.Point(107, 39)
        Me.dt_ST_date.Name = "dt_ST_date"
        Me.dt_ST_date.Size = New System.Drawing.Size(235, 20)
        Me.dt_ST_date.TabIndex = 33
        Me.dt_ST_date.TabStop = False
        Me.dt_ST_date.Text = "Monday, December 28, 2015"
        Me.dt_ST_date.Value = New Date(2015, 12, 28, 0, 0, 0, 0)
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(22, 40)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel4.TabIndex = 32
        Me.RadLabel4.Text = "Date Needed:"
        '
        'txt_ST_purpose
        '
        Me.txt_ST_purpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ST_purpose.AutoSize = False
        Me.txt_ST_purpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ST_purpose.ForeColor = System.Drawing.Color.Black
        Me.txt_ST_purpose.Location = New System.Drawing.Point(31, 84)
        Me.txt_ST_purpose.Multiline = True
        Me.txt_ST_purpose.Name = "txt_ST_purpose"
        Me.txt_ST_purpose.NullText = "<Optional>"
        Me.txt_ST_purpose.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_ST_purpose.Size = New System.Drawing.Size(387, 79)
        Me.txt_ST_purpose.TabIndex = 104
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(22, 64)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel1.TabIndex = 105
        Me.RadLabel1.Text = "Remarks:"
        '
        'dp_location
        '
        Me.dp_location.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.Location = New System.Drawing.Point(135, 184)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "<Required>"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(283, 20)
        Me.dp_location.TabIndex = 106
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(22, 184)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(107, 18)
        Me.RadLabel2.TabIndex = 107
        Me.RadLabel2.Text = "Officer In Changer:"
        '
        'btn_add_request
        '
        Me.btn_add_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add_request.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_add_request.Location = New System.Drawing.Point(308, 253)
        Me.btn_add_request.Name = "btn_add_request"
        Me.btn_add_request.Size = New System.Drawing.Size(110, 24)
        Me.btn_add_request.TabIndex = 108
        Me.btn_add_request.Text = "ADD TO QUEUE"
        '
        'cms_schedule_add_menu
        '
        Me.cms_schedule_add_menu.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refresh_data, Me.RadMenuSeparatorItem1, Me.assign_data})
        '
        'refresh_data
        '
        Me.refresh_data.Name = "refresh_data"
        Me.refresh_data.Text = "Refresh Data"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'assign_data
        '
        Me.assign_data.Name = "assign_data"
        Me.assign_data.Text = "Assign Lots And Manpower"
        '
        'RadButton1
        '
        Me.RadButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton1.Location = New System.Drawing.Point(701, 271)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(131, 24)
        Me.RadButton1.TabIndex = 109
        Me.RadButton1.Text = "Save All Queued Data"
        '
        'Frm_schedule_job_ticket_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 708)
        Me.Controls.Add(Me.RadDock1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_schedule_job_ticket_add"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_schedule_job_ticket_add"
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.tw_schedule.ResumeLayout(False)
        CType(Me.ToolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip2.ResumeLayout(False)
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip2.ResumeLayout(False)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.lv_schedule_add_hdr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents dw_manpower As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents dw_lot As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents tw_schedule As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentTabStrip2 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lv_schedule_add_hdr As Telerik.WinControls.UI.RadListView
    Friend WithEvents dt_ST_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_ST_purpose As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_add_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents cms_schedule_add_menu As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refresh_data As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents assign_data As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

