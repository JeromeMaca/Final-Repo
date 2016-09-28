<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_request_form_add
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
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel12 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_oldlotno = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_cancel_add = New Telerik.WinControls.UI.RadButton()
        Me.btn_new_request = New Telerik.WinControls.UI.RadButton()
        Me.btn_add_request = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_ST_purpose = New Telerik.WinControls.UI.RadTextBox()
        Me.tp_ST_neededtime = New Telerik.WinControls.UI.RadTimePicker()
        Me.dp_workoperations = New Telerik.WinControls.UI.RadDropDownList()
        Me.txt_planter = New Telerik.WinControls.UI.RadTextBox()
        Me.dp_location_lot = New Telerik.WinControls.UI.RadDropDownList()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.dt_ST_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_save_request = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel_all_queued_request = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel_selected_queued = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel11 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel10 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_queued = New Telerik.WinControls.UI.RadListView()
        Me.chk_group = New System.Windows.Forms.CheckBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_oldlotno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_new_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tp_ST_neededtime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_workoperations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_planter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location_lot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_all_queued_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_selected_queued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel10.SuspendLayout()
        CType(Me.lv_queued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.RadPanel12)
        Me.gb_menu.Controls.Add(Me.txt_oldlotno)
        Me.gb_menu.Controls.Add(Me.btn_cancel_add)
        Me.gb_menu.Controls.Add(Me.btn_new_request)
        Me.gb_menu.Controls.Add(Me.btn_add_request)
        Me.gb_menu.Controls.Add(Me.RadPanel9)
        Me.gb_menu.Controls.Add(Me.RadPanel8)
        Me.gb_menu.Controls.Add(Me.RadPanel7)
        Me.gb_menu.Controls.Add(Me.RadPanel6)
        Me.gb_menu.Controls.Add(Me.RadPanel5)
        Me.gb_menu.Controls.Add(Me.RadPanel4)
        Me.gb_menu.Controls.Add(Me.RadPanel2)
        Me.gb_menu.Controls.Add(Me.RadPanel3)
        Me.gb_menu.Controls.Add(Me.txt_ST_purpose)
        Me.gb_menu.Controls.Add(Me.tp_ST_neededtime)
        Me.gb_menu.Controls.Add(Me.dp_workoperations)
        Me.gb_menu.Controls.Add(Me.txt_planter)
        Me.gb_menu.Controls.Add(Me.dp_location_lot)
        Me.gb_menu.Controls.Add(Me.dp_location)
        Me.gb_menu.Controls.Add(Me.dt_ST_date)
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(0, 52)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(1081, 173)
        Me.gb_menu.TabIndex = 30
        Me.gb_menu.ThemeName = "Office2013Light"
        '
        'RadPanel12
        '
        Me.RadPanel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel12.Location = New System.Drawing.Point(674, 14)
        Me.RadPanel12.Name = "RadPanel12"
        Me.RadPanel12.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel12.TabIndex = 137
        '
        'txt_oldlotno
        '
        Me.txt_oldlotno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_oldlotno.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_oldlotno.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txt_oldlotno.Location = New System.Drawing.Point(723, 14)
        Me.txt_oldlotno.Name = "txt_oldlotno"
        Me.txt_oldlotno.NullText = "Old Lot No (System Generated)"
        Me.txt_oldlotno.ReadOnly = True
        '
        '
        '
        Me.txt_oldlotno.RootElement.StretchVertically = True
        Me.txt_oldlotno.Size = New System.Drawing.Size(194, 39)
        Me.txt_oldlotno.TabIndex = 136
        Me.txt_oldlotno.TabStop = False
        Me.txt_oldlotno.ThemeName = "Office2013Light"
        '
        'btn_cancel_add
        '
        Me.btn_cancel_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_add.BackColor = System.Drawing.Color.Black
        Me.btn_cancel_add.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_add.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancel_add.Location = New System.Drawing.Point(933, 109)
        Me.btn_cancel_add.Name = "btn_cancel_add"
        Me.btn_cancel_add.Size = New System.Drawing.Size(139, 38)
        Me.btn_cancel_add.TabIndex = 135
        Me.btn_cancel_add.Text = "CANCEL"
        Me.btn_cancel_add.ThemeName = "Office2013Dark"
        CType(Me.btn_cancel_add.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_cancel_add.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "CANCEL"
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_cancel_add.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btn_new_request
        '
        Me.btn_new_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_new_request.BackColor = System.Drawing.Color.Black
        Me.btn_new_request.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_new_request.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_new_request.Location = New System.Drawing.Point(933, 62)
        Me.btn_new_request.Name = "btn_new_request"
        Me.btn_new_request.Size = New System.Drawing.Size(139, 38)
        Me.btn_new_request.TabIndex = 134
        Me.btn_new_request.Text = "NEW REQUEST"
        Me.btn_new_request.ThemeName = "Office2013Dark"
        CType(Me.btn_new_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_new_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "NEW REQUEST"
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_new_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btn_add_request
        '
        Me.btn_add_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add_request.BackColor = System.Drawing.Color.Black
        Me.btn_add_request.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_add_request.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_add_request.Location = New System.Drawing.Point(933, 15)
        Me.btn_add_request.Name = "btn_add_request"
        Me.btn_add_request.Size = New System.Drawing.Size(139, 38)
        Me.btn_add_request.TabIndex = 133
        Me.btn_add_request.Text = "ADD TO QUEUED"
        Me.btn_add_request.ThemeName = "Office2013Dark"
        CType(Me.btn_add_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_add_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "ADD TO QUEUED"
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_add_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel9
        '
        Me.RadPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel9.Location = New System.Drawing.Point(336, 119)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel9.TabIndex = 132
        '
        'RadPanel8
        '
        Me.RadPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel8.Location = New System.Drawing.Point(336, 65)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel8.TabIndex = 132
        '
        'RadPanel7
        '
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Location = New System.Drawing.Point(336, 14)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel7.TabIndex = 131
        '
        'RadPanel6
        '
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel6.ForeColor = System.Drawing.Color.White
        Me.RadPanel6.Location = New System.Drawing.Point(674, 65)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(243, 28)
        Me.RadPanel6.TabIndex = 130
        Me.RadPanel6.Text = "Request Purpose"
        Me.RadPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel5
        '
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Location = New System.Drawing.Point(10, 119)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel5.TabIndex = 129
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel4.ForeColor = System.Drawing.Color.White
        Me.RadPanel4.Location = New System.Drawing.Point(164, 65)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(118, 39)
        Me.RadPanel4.TabIndex = 128
        Me.RadPanel4.Text = "Select Time Needed"
        Me.RadPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Location = New System.Drawing.Point(10, 65)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel2.TabIndex = 127
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Location = New System.Drawing.Point(10, 14)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel3.TabIndex = 126
        '
        'txt_ST_purpose
        '
        Me.txt_ST_purpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ST_purpose.AutoSize = False
        Me.txt_ST_purpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ST_purpose.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txt_ST_purpose.ForeColor = System.Drawing.Color.Black
        Me.txt_ST_purpose.Location = New System.Drawing.Point(674, 91)
        Me.txt_ST_purpose.Multiline = True
        Me.txt_ST_purpose.Name = "txt_ST_purpose"
        Me.txt_ST_purpose.NullText = "Purpose  (Optional)"
        Me.txt_ST_purpose.Size = New System.Drawing.Size(243, 67)
        Me.txt_ST_purpose.TabIndex = 102
        Me.txt_ST_purpose.ThemeName = "Office2013Light"
        CType(Me.txt_ST_purpose.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.txt_ST_purpose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Purpose  (Optional)"
        CType(Me.txt_ST_purpose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
        CType(Me.txt_ST_purpose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        CType(Me.txt_ST_purpose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.txt_ST_purpose.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.txt_ST_purpose.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        '
        'tp_ST_neededtime
        '
        Me.tp_ST_neededtime.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.tp_ST_neededtime.Location = New System.Drawing.Point(59, 65)
        Me.tp_ST_neededtime.MaxValue = New Date(9999, 12, 31, 23, 59, 59, 0)
        Me.tp_ST_neededtime.MinValue = New Date(CType(0, Long))
        Me.tp_ST_neededtime.Name = "tp_ST_neededtime"
        Me.tp_ST_neededtime.NullText = "Select Time Needed  (Required)"
        '
        '
        '
        Me.tp_ST_neededtime.RootElement.PositionOffset = New System.Drawing.SizeF(0!, 0!)
        Me.tp_ST_neededtime.RootElement.StretchVertically = True
        Me.tp_ST_neededtime.Size = New System.Drawing.Size(105, 39)
        Me.tp_ST_neededtime.TabIndex = 99
        Me.tp_ST_neededtime.TabStop = False
        Me.tp_ST_neededtime.ThemeName = "Office2013Light"
        Me.tp_ST_neededtime.Value = New Date(2016, 9, 28, 7, 0, 0, 0)
        CType(Me.tp_ST_neededtime.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.tp_ST_neededtime.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).Text = "7:00 AM"
        CType(Me.tp_ST_neededtime.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.tp_ST_neededtime.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTimeMaskedEditBoxElement).StretchVertically = True
        CType(Me.tp_ST_neededtime.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.tp_ST_neededtime.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadTimeDropDownButtonElement).PositionOffset = New System.Drawing.SizeF(10.0!, 0!)
        CType(Me.tp_ST_neededtime.GetChildAt(0).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'dp_workoperations
        '
        Me.dp_workoperations.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_workoperations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_workoperations.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dp_workoperations.Location = New System.Drawing.Point(385, 119)
        Me.dp_workoperations.Name = "dp_workoperations"
        Me.dp_workoperations.NullText = "Select work operation  (Required)"
        '
        '
        '
        Me.dp_workoperations.RootElement.StretchVertically = True
        Me.dp_workoperations.Size = New System.Drawing.Size(273, 39)
        Me.dp_workoperations.TabIndex = 43
        Me.dp_workoperations.ThemeName = "Office2013Light"
        CType(Me.dp_workoperations.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        CType(Me.dp_workoperations.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        '
        'txt_planter
        '
        Me.txt_planter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_planter.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_planter.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txt_planter.Location = New System.Drawing.Point(385, 65)
        Me.txt_planter.Name = "txt_planter"
        Me.txt_planter.NullText = "Planter Name  (System Generated)"
        Me.txt_planter.ReadOnly = True
        '
        '
        '
        Me.txt_planter.RootElement.StretchVertically = True
        Me.txt_planter.Size = New System.Drawing.Size(273, 39)
        Me.txt_planter.TabIndex = 33
        Me.txt_planter.TabStop = False
        Me.txt_planter.ThemeName = "Office2013Light"
        '
        'dp_location_lot
        '
        Me.dp_location_lot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_location_lot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location_lot.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dp_location_lot.Location = New System.Drawing.Point(385, 14)
        Me.dp_location_lot.Name = "dp_location_lot"
        Me.dp_location_lot.NullText = "Select lot number  (Required)"
        '
        '
        '
        Me.dp_location_lot.RootElement.StretchVertically = True
        Me.dp_location_lot.Size = New System.Drawing.Size(273, 39)
        Me.dp_location_lot.TabIndex = 38
        Me.dp_location_lot.ThemeName = "Office2013Light"
        CType(Me.dp_location_lot.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        '
        'dp_location
        '
        Me.dp_location.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dp_location.Location = New System.Drawing.Point(59, 119)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "Select location  (Required)"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(267, 39)
        Me.dp_location.TabIndex = 0
        Me.dp_location.ThemeName = "Office2013Light"
        CType(Me.dp_location.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        '
        'dt_ST_date
        '
        Me.dt_ST_date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_ST_date.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dt_ST_date.Location = New System.Drawing.Point(59, 14)
        Me.dt_ST_date.Name = "dt_ST_date"
        Me.dt_ST_date.NullText = "Select date needed  (Required)"
        '
        '
        '
        Me.dt_ST_date.RootElement.StretchVertically = True
        Me.dt_ST_date.Size = New System.Drawing.Size(267, 39)
        Me.dt_ST_date.TabIndex = 31
        Me.dt_ST_date.TabStop = False
        Me.dt_ST_date.ThemeName = "Office2013Light"
        Me.dt_ST_date.Value = New Date(CType(0, Long))
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.btn_save_request)
        Me.gb_data.Controls.Add(Me.btn_cancel_all_queued_request)
        Me.gb_data.Controls.Add(Me.btn_cancel_selected_queued)
        Me.gb_data.Controls.Add(Me.RadPanel11)
        Me.gb_data.Controls.Add(Me.RadPanel10)
        Me.gb_data.Controls.Add(Me.chk_group)
        Me.gb_data.Controls.Add(Me.RadLabel3)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(1, 226)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(1081, 338)
        Me.gb_data.TabIndex = 31
        Me.gb_data.ThemeName = "Office2013Light"
        '
        'btn_save_request
        '
        Me.btn_save_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save_request.BackColor = System.Drawing.Color.Black
        Me.btn_save_request.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_request.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_save_request.Location = New System.Drawing.Point(862, 296)
        Me.btn_save_request.Name = "btn_save_request"
        Me.btn_save_request.Size = New System.Drawing.Size(218, 38)
        Me.btn_save_request.TabIndex = 136
        Me.btn_save_request.Text = "SAVE ALL REQUEST"
        Me.btn_save_request.ThemeName = "Office2013Dark"
        CType(Me.btn_save_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_save_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "SAVE ALL REQUEST"
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_save_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btn_cancel_all_queued_request
        '
        Me.btn_cancel_all_queued_request.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_all_queued_request.BackColor = System.Drawing.Color.Black
        Me.btn_cancel_all_queued_request.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_all_queued_request.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancel_all_queued_request.Location = New System.Drawing.Point(599, 296)
        Me.btn_cancel_all_queued_request.Name = "btn_cancel_all_queued_request"
        Me.btn_cancel_all_queued_request.Size = New System.Drawing.Size(259, 38)
        Me.btn_cancel_all_queued_request.TabIndex = 135
        Me.btn_cancel_all_queued_request.Text = "CANCEL ALL QUEUED REQUEST"
        Me.btn_cancel_all_queued_request.ThemeName = "Office2013Dark"
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "CANCEL ALL QUEUED REQUEST"
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_cancel_all_queued_request.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btn_cancel_selected_queued
        '
        Me.btn_cancel_selected_queued.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_selected_queued.BackColor = System.Drawing.Color.Black
        Me.btn_cancel_selected_queued.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_selected_queued.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancel_selected_queued.Location = New System.Drawing.Point(335, 296)
        Me.btn_cancel_selected_queued.Name = "btn_cancel_selected_queued"
        Me.btn_cancel_selected_queued.Size = New System.Drawing.Size(259, 38)
        Me.btn_cancel_selected_queued.TabIndex = 134
        Me.btn_cancel_selected_queued.Text = "CANCEL SELECTED QUEUED REQUEST"
        Me.btn_cancel_selected_queued.ThemeName = "Office2013Dark"
        CType(Me.btn_cancel_selected_queued.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_cancel_selected_queued.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "CANCEL SELECTED QUEUED REQUEST"
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_cancel_selected_queued.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel11
        '
        Me.RadPanel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel11.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel11.ForeColor = System.Drawing.Color.White
        Me.RadPanel11.Location = New System.Drawing.Point(4, 5)
        Me.RadPanel11.Name = "RadPanel11"
        Me.RadPanel11.Size = New System.Drawing.Size(1074, 39)
        Me.RadPanel11.TabIndex = 131
        Me.RadPanel11.Text = "Request Queued Item"
        CType(Me.RadPanel11.GetChildAt(0), Telerik.WinControls.UI.RadPanelElement).Text = "Request Queued Item"
        CType(Me.RadPanel11.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        '
        'RadPanel10
        '
        Me.RadPanel10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel10.Controls.Add(Me.lv_queued)
        Me.RadPanel10.Location = New System.Drawing.Point(4, 45)
        Me.RadPanel10.Name = "RadPanel10"
        Me.RadPanel10.Size = New System.Drawing.Size(1073, 246)
        Me.RadPanel10.TabIndex = 127
        '
        'lv_queued
        '
        Me.lv_queued.AllowEdit = False
        Me.lv_queued.AllowRemove = False
        Me.lv_queued.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_queued.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_queued.ItemSpacing = -1
        Me.lv_queued.Location = New System.Drawing.Point(1, 1)
        Me.lv_queued.Name = "lv_queued"
        Me.lv_queued.SelectLastAddedItem = False
        Me.lv_queued.Size = New System.Drawing.Size(1071, 244)
        Me.lv_queued.TabIndex = 44
        Me.lv_queued.ThemeName = "VisualStudio2012Light"
        Me.lv_queued.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_queued.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'chk_group
        '
        Me.chk_group.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chk_group.AutoSize = True
        Me.chk_group.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_group.Location = New System.Drawing.Point(12, 317)
        Me.chk_group.Name = "chk_group"
        Me.chk_group.Size = New System.Drawing.Size(107, 17)
        Me.chk_group.TabIndex = 46
        Me.chk_group.Text = "Group By CODE"
        Me.chk_group.UseVisualStyleBackColor = True
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadLabel3.Location = New System.Drawing.Point(8, 298)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(280, 18)
        Me.RadLabel3.TabIndex = 45
        Me.RadLabel3.Text = "NOTE: Queued request data is group by LOCATION."
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1084, 52)
        Me.RadPanel1.TabIndex = 32
        Me.RadPanel1.Text = "REQUEST TRIP TICKET SCHEDULE"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_request_form_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 564)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.gb_menu)
        Me.Controls.Add(Me.gb_data)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_request_form_add"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Trip Ticket Request"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_oldlotno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_new_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tp_ST_neededtime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_workoperations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_planter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location_lot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_all_queued_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_selected_queued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel10.ResumeLayout(False)
        CType(Me.lv_queued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_planter As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dp_location_lot As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dt_ST_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents dp_workoperations As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents lv_queued As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents chk_group As System.Windows.Forms.CheckBox
    Friend WithEvents tp_ST_neededtime As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents txt_ST_purpose As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_add_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_new_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel_add As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel10 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel11 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_cancel_selected_queued As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel_all_queued_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_save_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel12 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_oldlotno As Telerik.WinControls.UI.RadTextBox
End Class

