<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_schedule_confirm_posting
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
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_process_all = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel30 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_for_confirmation = New Telerik.WinControls.UI.RadListView()
        Me.RadPanel31 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel15 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel21 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_work_operation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel11 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_loc = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.tp_ja_timeout = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.tp_ja_timein = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.tp_e_timein = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadPanel18 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel19 = New Telerik.WinControls.UI.RadPanel()
        Me.tp_e_timeout = New Telerik.WinControls.UI.RadTimePicker()
        Me.RadPanel10 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_ticketno = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_lot_information = New Telerik.WinControls.UI.RadListView()
        Me.cms_check_uncheck = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refresh = New Telerik.WinControls.UI.RadMenuItem()
        Me.sep1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.checkall = New Telerik.WinControls.UI.RadMenuItem()
        Me.uncheckall = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel30.SuspendLayout()
        CType(Me.lv_for_confirmation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadPanel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_work_operation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_loc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tp_ja_timeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tp_ja_timein, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tp_e_timein, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tp_e_timeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ticketno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.lv_lot_information, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel2.ForeColor = System.Drawing.Color.White
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(1250, 41)
        Me.RadPanel2.TabIndex = 9
        Me.RadPanel2.Text = "SCHEDULED TRIP TICKET CONFIRMATION"
        Me.RadPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox1.Controls.Add(Me.btn_process_all)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel30)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel31)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(1, 41)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(334, 507)
        Me.RadGroupBox1.TabIndex = 10
        Me.RadGroupBox1.ThemeName = "Office2013Light"
        '
        'btn_process_all
        '
        Me.btn_process_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_process_all.BackColor = System.Drawing.Color.Black
        Me.btn_process_all.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_process_all.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_process_all.Location = New System.Drawing.Point(0, 465)
        Me.btn_process_all.Name = "btn_process_all"
        Me.btn_process_all.Size = New System.Drawing.Size(334, 38)
        Me.btn_process_all.TabIndex = 175
        Me.btn_process_all.Text = "PROCESS ALL CHECK DATA"
        Me.btn_process_all.ThemeName = "Office2013Dark"
        CType(Me.btn_process_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_process_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "PROCESS ALL CHECK DATA"
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
        'RadPanel30
        '
        Me.RadPanel30.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel30.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel30.Controls.Add(Me.lv_for_confirmation)
        Me.RadPanel30.Location = New System.Drawing.Point(0, 45)
        Me.RadPanel30.Name = "RadPanel30"
        Me.RadPanel30.Size = New System.Drawing.Size(334, 417)
        Me.RadPanel30.TabIndex = 174
        '
        'lv_for_confirmation
        '
        Me.lv_for_confirmation.AllowEdit = False
        Me.lv_for_confirmation.AllowRemove = False
        Me.lv_for_confirmation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_for_confirmation.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick
        Me.lv_for_confirmation.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_for_confirmation.ItemSpacing = -1
        Me.lv_for_confirmation.Location = New System.Drawing.Point(1, 1)
        Me.lv_for_confirmation.Name = "lv_for_confirmation"
        Me.lv_for_confirmation.SelectLastAddedItem = False
        Me.lv_for_confirmation.ShowCheckBoxes = True
        Me.lv_for_confirmation.Size = New System.Drawing.Size(332, 415)
        Me.lv_for_confirmation.TabIndex = 0
        Me.lv_for_confirmation.ThemeName = "VisualStudio2012Light"
        Me.lv_for_confirmation.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_for_confirmation.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'RadPanel31
        '
        Me.RadPanel31.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadPanel31.ForeColor = System.Drawing.Color.White
        Me.RadPanel31.Location = New System.Drawing.Point(0, 5)
        Me.RadPanel31.Name = "RadPanel31"
        Me.RadPanel31.Size = New System.Drawing.Size(334, 39)
        Me.RadPanel31.TabIndex = 173
        Me.RadPanel31.Text = "FOR CONFIRMATION LIST"
        Me.RadPanel31.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox2.Controls.Add(Me.RadPanel15)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel21)
        Me.RadGroupBox2.Controls.Add(Me.txt_work_operation)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel11)
        Me.RadGroupBox2.Controls.Add(Me.txt_loc)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel8)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel9)
        Me.RadGroupBox2.Controls.Add(Me.tp_ja_timeout)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel5)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel7)
        Me.RadGroupBox2.Controls.Add(Me.tp_ja_timein)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel4)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel6)
        Me.RadGroupBox2.Controls.Add(Me.tp_e_timein)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel18)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel19)
        Me.RadGroupBox2.Controls.Add(Me.tp_e_timeout)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel10)
        Me.RadGroupBox2.Controls.Add(Me.txt_ticketno)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel3)
        Me.RadGroupBox2.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(338, 41)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(912, 507)
        Me.RadGroupBox2.TabIndex = 11
        Me.RadGroupBox2.ThemeName = "Office2013Light"
        '
        'RadPanel15
        '
        Me.RadPanel15.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel15.Location = New System.Drawing.Point(6, 130)
        Me.RadPanel15.Name = "RadPanel15"
        Me.RadPanel15.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel15.TabIndex = 193
        '
        'RadPanel21
        '
        Me.RadPanel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel21.ForeColor = System.Drawing.Color.White
        Me.RadPanel21.Location = New System.Drawing.Point(293, 46)
        Me.RadPanel21.Name = "RadPanel21"
        Me.RadPanel21.Size = New System.Drawing.Size(81, 39)
        Me.RadPanel21.TabIndex = 189
        Me.RadPanel21.Text = "Trip Ticket No"
        Me.RadPanel21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_work_operation
        '
        Me.txt_work_operation.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_work_operation.Location = New System.Drawing.Point(55, 130)
        Me.txt_work_operation.Name = "txt_work_operation"
        Me.txt_work_operation.NullText = "Work Operation  (System Generated)"
        Me.txt_work_operation.ReadOnly = True
        '
        '
        '
        Me.txt_work_operation.RootElement.StretchVertically = True
        Me.txt_work_operation.Size = New System.Drawing.Size(243, 39)
        Me.txt_work_operation.TabIndex = 192
        Me.txt_work_operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_work_operation.ThemeName = "Office2013Light"
        '
        'RadPanel11
        '
        Me.RadPanel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel11.Location = New System.Drawing.Point(6, 88)
        Me.RadPanel11.Name = "RadPanel11"
        Me.RadPanel11.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel11.TabIndex = 191
        '
        'txt_loc
        '
        Me.txt_loc.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_loc.Location = New System.Drawing.Point(55, 88)
        Me.txt_loc.Name = "txt_loc"
        Me.txt_loc.NullText = "Location  (System Generated)"
        Me.txt_loc.ReadOnly = True
        '
        '
        '
        Me.txt_loc.RootElement.StretchVertically = True
        Me.txt_loc.Size = New System.Drawing.Size(244, 39)
        Me.txt_loc.TabIndex = 190
        Me.txt_loc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_loc.ThemeName = "Office2013Light"
        '
        'RadPanel8
        '
        Me.RadPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel8.ForeColor = System.Drawing.Color.White
        Me.RadPanel8.Location = New System.Drawing.Point(768, 130)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(133, 39)
        Me.RadPanel8.TabIndex = 188
        Me.RadPanel8.Text = "Jobsite Departure Time"
        Me.RadPanel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel9
        '
        Me.RadPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel9.Location = New System.Drawing.Point(614, 130)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel9.TabIndex = 187
        '
        'tp_ja_timeout
        '
        Me.tp_ja_timeout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_ja_timeout.Location = New System.Drawing.Point(663, 130)
        Me.tp_ja_timeout.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.tp_ja_timeout.MinValue = New Date(CType(0, Long))
        Me.tp_ja_timeout.Name = "tp_ja_timeout"
        Me.tp_ja_timeout.NullText = "System Generated"
        Me.tp_ja_timeout.ReadOnly = True
        '
        '
        '
        Me.tp_ja_timeout.RootElement.PositionOffset = New System.Drawing.SizeF(0!, 0!)
        Me.tp_ja_timeout.RootElement.StretchVertically = True
        Me.tp_ja_timeout.Size = New System.Drawing.Size(105, 39)
        Me.tp_ja_timeout.TabIndex = 186
        Me.tp_ja_timeout.TabStop = False
        Me.tp_ja_timeout.ThemeName = "Office2013Light"
        Me.tp_ja_timeout.Value = New Date(2016, 9, 22, 7, 0, 0, 0)
        CType(Me.tp_ja_timeout.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.tp_ja_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).Text = "7:00 AM"
        CType(Me.tp_ja_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.tp_ja_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).StretchVertically = True
        CType(Me.tp_ja_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.tp_ja_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadTimeDropDownButtonElement).PositionOffset = New System.Drawing.SizeF(10.0!, 0!)
        CType(Me.tp_ja_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel5
        '
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel5.ForeColor = System.Drawing.Color.White
        Me.RadPanel5.Location = New System.Drawing.Point(768, 88)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(133, 39)
        Me.RadPanel5.TabIndex = 185
        Me.RadPanel5.Text = "Jobsite Arrival Time"
        Me.RadPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel7
        '
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Location = New System.Drawing.Point(614, 88)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel7.TabIndex = 184
        '
        'tp_ja_timein
        '
        Me.tp_ja_timein.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_ja_timein.Location = New System.Drawing.Point(663, 88)
        Me.tp_ja_timein.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.tp_ja_timein.MinValue = New Date(CType(0, Long))
        Me.tp_ja_timein.Name = "tp_ja_timein"
        Me.tp_ja_timein.NullText = "System Generated"
        Me.tp_ja_timein.ReadOnly = True
        '
        '
        '
        Me.tp_ja_timein.RootElement.PositionOffset = New System.Drawing.SizeF(0!, 0!)
        Me.tp_ja_timein.RootElement.StretchVertically = True
        Me.tp_ja_timein.Size = New System.Drawing.Size(105, 39)
        Me.tp_ja_timein.TabIndex = 183
        Me.tp_ja_timein.TabStop = False
        Me.tp_ja_timein.ThemeName = "Office2013Light"
        Me.tp_ja_timein.Value = New Date(2016, 9, 22, 7, 0, 0, 0)
        CType(Me.tp_ja_timein.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.tp_ja_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).Text = "7:00 AM"
        CType(Me.tp_ja_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.tp_ja_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).StretchVertically = True
        CType(Me.tp_ja_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.tp_ja_timein.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadTimeDropDownButtonElement).PositionOffset = New System.Drawing.SizeF(10.0!, 0!)
        CType(Me.tp_ja_timein.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel4.ForeColor = System.Drawing.Color.White
        Me.RadPanel4.Location = New System.Drawing.Point(460, 130)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(144, 39)
        Me.RadPanel4.TabIndex = 182
        Me.RadPanel4.Text = "Equipment Checkin Time"
        Me.RadPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel6
        '
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Location = New System.Drawing.Point(306, 130)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel6.TabIndex = 181
        '
        'tp_e_timein
        '
        Me.tp_e_timein.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_e_timein.Location = New System.Drawing.Point(355, 130)
        Me.tp_e_timein.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.tp_e_timein.MinValue = New Date(CType(0, Long))
        Me.tp_e_timein.Name = "tp_e_timein"
        Me.tp_e_timein.NullText = "System Generated"
        Me.tp_e_timein.ReadOnly = True
        '
        '
        '
        Me.tp_e_timein.RootElement.PositionOffset = New System.Drawing.SizeF(0!, 0!)
        Me.tp_e_timein.RootElement.StretchVertically = True
        Me.tp_e_timein.Size = New System.Drawing.Size(105, 39)
        Me.tp_e_timein.TabIndex = 180
        Me.tp_e_timein.TabStop = False
        Me.tp_e_timein.ThemeName = "Office2013Light"
        Me.tp_e_timein.Value = New Date(2016, 9, 22, 7, 0, 0, 0)
        CType(Me.tp_e_timein.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.tp_e_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).Text = "7:00 AM"
        CType(Me.tp_e_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.tp_e_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).StretchVertically = True
        CType(Me.tp_e_timein.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.tp_e_timein.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadTimeDropDownButtonElement).PositionOffset = New System.Drawing.SizeF(10.0!, 0!)
        CType(Me.tp_e_timein.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel18
        '
        Me.RadPanel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel18.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel18.ForeColor = System.Drawing.Color.White
        Me.RadPanel18.Location = New System.Drawing.Point(459, 88)
        Me.RadPanel18.Name = "RadPanel18"
        Me.RadPanel18.Size = New System.Drawing.Size(144, 39)
        Me.RadPanel18.TabIndex = 179
        Me.RadPanel18.Text = "Equipment Checkout Time"
        Me.RadPanel18.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel19
        '
        Me.RadPanel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel19.Location = New System.Drawing.Point(305, 88)
        Me.RadPanel19.Name = "RadPanel19"
        Me.RadPanel19.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel19.TabIndex = 178
        '
        'tp_e_timeout
        '
        Me.tp_e_timeout.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tp_e_timeout.Location = New System.Drawing.Point(354, 88)
        Me.tp_e_timeout.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.tp_e_timeout.MinValue = New Date(CType(0, Long))
        Me.tp_e_timeout.Name = "tp_e_timeout"
        Me.tp_e_timeout.NullText = "System Generated"
        Me.tp_e_timeout.ReadOnly = True
        '
        '
        '
        Me.tp_e_timeout.RootElement.PositionOffset = New System.Drawing.SizeF(0!, 0!)
        Me.tp_e_timeout.RootElement.StretchVertically = True
        Me.tp_e_timeout.Size = New System.Drawing.Size(105, 39)
        Me.tp_e_timeout.TabIndex = 177
        Me.tp_e_timeout.TabStop = False
        Me.tp_e_timeout.ThemeName = "Office2013Light"
        Me.tp_e_timeout.Value = New Date(2016, 9, 22, 7, 0, 0, 0)
        CType(Me.tp_e_timeout.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.tp_e_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).Text = "7:00 AM"
        CType(Me.tp_e_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.tp_e_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).StretchVertically = True
        CType(Me.tp_e_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.tp_e_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadTimeDropDownButtonElement).PositionOffset = New System.Drawing.SizeF(10.0!, 0!)
        CType(Me.tp_e_timeout.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel10
        '
        Me.RadPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel10.Location = New System.Drawing.Point(6, 46)
        Me.RadPanel10.Name = "RadPanel10"
        Me.RadPanel10.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel10.TabIndex = 176
        '
        'txt_ticketno
        '
        Me.txt_ticketno.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ticketno.Location = New System.Drawing.Point(55, 46)
        Me.txt_ticketno.Name = "txt_ticketno"
        Me.txt_ticketno.NullText = "Trip Ticket No  (System Generated)"
        Me.txt_ticketno.ReadOnly = True
        '
        '
        '
        Me.txt_ticketno.RootElement.StretchVertically = True
        Me.txt_ticketno.Size = New System.Drawing.Size(243, 39)
        Me.txt_ticketno.TabIndex = 175
        Me.txt_ticketno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_ticketno.ThemeName = "Office2013Light"
        '
        'RadPanel3
        '
        Me.RadPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadPanel3.ForeColor = System.Drawing.Color.White
        Me.RadPanel3.Location = New System.Drawing.Point(3, 5)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(906, 39)
        Me.RadPanel3.TabIndex = 174
        Me.RadPanel3.Text = "ENCODED INFORMATION"
        Me.RadPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel1
        '
        Me.RadPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel1.Controls.Add(Me.lv_lot_information)
        Me.RadPanel1.Location = New System.Drawing.Point(5, 175)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(902, 328)
        Me.RadPanel1.TabIndex = 170
        '
        'lv_lot_information
        '
        Me.lv_lot_information.AllowEdit = False
        Me.lv_lot_information.AllowRemove = False
        Me.lv_lot_information.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lot_information.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_lot_information.ItemSpacing = -1
        Me.lv_lot_information.Location = New System.Drawing.Point(1, 1)
        Me.lv_lot_information.Name = "lv_lot_information"
        Me.lv_lot_information.SelectLastAddedItem = False
        Me.lv_lot_information.Size = New System.Drawing.Size(900, 326)
        Me.lv_lot_information.TabIndex = 0
        Me.lv_lot_information.ThemeName = "VisualStudio2012Light"
        Me.lv_lot_information.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_lot_information.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'cms_check_uncheck
        '
        Me.cms_check_uncheck.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refresh, Me.sep1, Me.checkall, Me.uncheckall})
        Me.cms_check_uncheck.ThemeName = "Office2013Light"
        '
        'refresh
        '
        Me.refresh.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh.Name = "refresh"
        Me.refresh.Text = "Refresh"
        '
        'sep1
        '
        Me.sep1.Name = "sep1"
        Me.sep1.Text = "RadMenuSeparatorItem1"
        Me.sep1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'checkall
        '
        Me.checkall.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.checkall.Name = "checkall"
        Me.checkall.Text = "Check All"
        '
        'uncheckall
        '
        Me.uncheckall.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.uncheckall.Name = "uncheckall"
        Me.uncheckall.Text = "Uncheck All"
        '
        'Frm_schedule_confirm_posting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 547)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_schedule_confirm_posting"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Trip Ticket Scheduled"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel30.ResumeLayout(False)
        CType(Me.lv_for_confirmation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.RadPanel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_work_operation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_loc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tp_ja_timeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tp_ja_timein, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tp_e_timein, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tp_e_timeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ticketno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.lv_lot_information, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel31 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel30 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lv_for_confirmation As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lv_lot_information As Telerik.WinControls.UI.RadListView
    Friend WithEvents btn_process_all As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel21 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents tp_ja_timeout As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents tp_ja_timein As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents tp_e_timein As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadPanel18 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel19 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents tp_e_timeout As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents RadPanel10 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_ticketno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel15 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_work_operation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel11 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_loc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cms_check_uncheck As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refresh As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents sep1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents checkall As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents uncheckall As Telerik.WinControls.UI.RadMenuItem
End Class

