<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_request_form_update
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
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel11 = New Telerik.WinControls.UI.RadPanel()
        Me.chk_updateinclude = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadPanel10 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_reqno = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_cancel_update = New Telerik.WinControls.UI.RadButton()
        Me.btn_savechanges = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_ST_purpose = New Telerik.WinControls.UI.RadTextBox()
        Me.tp_ST_neededtime = New Telerik.WinControls.UI.RadTimePicker()
        Me.dp_workoperations = New Telerik.WinControls.UI.RadDropDownList()
        Me.dp_location_lot = New Telerik.WinControls.UI.RadDropDownList()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.dt_ST_date = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel11.SuspendLayout()
        CType(Me.chk_updateinclude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_reqno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_savechanges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tp_ST_neededtime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_workoperations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location_lot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(636, 52)
        Me.RadPanel1.TabIndex = 35
        Me.RadPanel1.Text = "REQUEST TRIP TICKET SCHEDULE"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.RadPanel8)
        Me.gb_menu.Controls.Add(Me.RadPanel11)
        Me.gb_menu.Controls.Add(Me.RadPanel10)
        Me.gb_menu.Controls.Add(Me.txt_reqno)
        Me.gb_menu.Controls.Add(Me.btn_cancel_update)
        Me.gb_menu.Controls.Add(Me.btn_savechanges)
        Me.gb_menu.Controls.Add(Me.RadPanel9)
        Me.gb_menu.Controls.Add(Me.RadPanel7)
        Me.gb_menu.Controls.Add(Me.RadPanel6)
        Me.gb_menu.Controls.Add(Me.RadPanel5)
        Me.gb_menu.Controls.Add(Me.RadPanel4)
        Me.gb_menu.Controls.Add(Me.RadPanel2)
        Me.gb_menu.Controls.Add(Me.RadPanel3)
        Me.gb_menu.Controls.Add(Me.txt_ST_purpose)
        Me.gb_menu.Controls.Add(Me.tp_ST_neededtime)
        Me.gb_menu.Controls.Add(Me.dp_workoperations)
        Me.gb_menu.Controls.Add(Me.dp_location_lot)
        Me.gb_menu.Controls.Add(Me.dp_location)
        Me.gb_menu.Controls.Add(Me.dt_ST_date)
        Me.gb_menu.Controls.Add(Me.RadLabel3)
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(0, 52)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(636, 355)
        Me.gb_menu.TabIndex = 36
        Me.gb_menu.ThemeName = "Office2013Light"
        '
        'RadPanel8
        '
        Me.RadPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel8.Location = New System.Drawing.Point(348, 170)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel8.TabIndex = 138
        '
        'RadPanel11
        '
        Me.RadPanel11.BackColor = System.Drawing.Color.White
        Me.RadPanel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel11.Controls.Add(Me.chk_updateinclude)
        Me.RadPanel11.Location = New System.Drawing.Point(397, 170)
        Me.RadPanel11.Name = "RadPanel11"
        Me.RadPanel11.Size = New System.Drawing.Size(230, 39)
        Me.RadPanel11.TabIndex = 139
        Me.RadPanel11.ThemeName = "Office2013Light"
        '
        'chk_updateinclude
        '
        Me.chk_updateinclude.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_updateinclude.Location = New System.Drawing.Point(4, 11)
        Me.chk_updateinclude.Name = "chk_updateinclude"
        Me.chk_updateinclude.Size = New System.Drawing.Size(220, 18)
        Me.chk_updateinclude.TabIndex = 4
        Me.chk_updateinclude.Text = "Save All Data Changes in Noted Field"
        Me.chk_updateinclude.ThemeName = "Office2013Light"
        '
        'RadPanel10
        '
        Me.RadPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel10.Location = New System.Drawing.Point(16, 14)
        Me.RadPanel10.Name = "RadPanel10"
        Me.RadPanel10.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel10.TabIndex = 136
        '
        'txt_reqno
        '
        Me.txt_reqno.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_reqno.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txt_reqno.Location = New System.Drawing.Point(65, 14)
        Me.txt_reqno.Name = "txt_reqno"
        Me.txt_reqno.NullText = "Requeust Number  (System Generated)"
        Me.txt_reqno.ReadOnly = True
        '
        '
        '
        Me.txt_reqno.RootElement.StretchVertically = True
        Me.txt_reqno.Size = New System.Drawing.Size(273, 39)
        Me.txt_reqno.TabIndex = 0
        Me.txt_reqno.TabStop = False
        Me.txt_reqno.ThemeName = "Office2013Light"
        '
        'btn_cancel_update
        '
        Me.btn_cancel_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_update.BackColor = System.Drawing.Color.Black
        Me.btn_cancel_update.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancel_update.Location = New System.Drawing.Point(348, 276)
        Me.btn_cancel_update.Name = "btn_cancel_update"
        Me.btn_cancel_update.Size = New System.Drawing.Size(279, 39)
        Me.btn_cancel_update.TabIndex = 135
        Me.btn_cancel_update.Text = "CANCEL CHANGES"
        Me.btn_cancel_update.ThemeName = "Office2013Dark"
        CType(Me.btn_cancel_update.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_cancel_update.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "CANCEL CHANGES"
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_cancel_update.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btn_savechanges
        '
        Me.btn_savechanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_savechanges.BackColor = System.Drawing.Color.Black
        Me.btn_savechanges.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_savechanges.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_savechanges.Location = New System.Drawing.Point(348, 225)
        Me.btn_savechanges.Name = "btn_savechanges"
        Me.btn_savechanges.Size = New System.Drawing.Size(279, 39)
        Me.btn_savechanges.TabIndex = 0
        Me.btn_savechanges.Text = "SAVE CHANGES"
        Me.btn_savechanges.ThemeName = "Office2013Dark"
        CType(Me.btn_savechanges.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_savechanges.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "SAVE CHANGES"
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_savechanges.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel9
        '
        Me.RadPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel9.Location = New System.Drawing.Point(16, 276)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel9.TabIndex = 132
        '
        'RadPanel7
        '
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Location = New System.Drawing.Point(16, 225)
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
        Me.RadPanel6.Location = New System.Drawing.Point(348, 14)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(279, 28)
        Me.RadPanel6.TabIndex = 130
        Me.RadPanel6.Text = "Request Purpose"
        Me.RadPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel5
        '
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Location = New System.Drawing.Point(16, 170)
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
        Me.RadPanel4.Location = New System.Drawing.Point(170, 116)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(118, 39)
        Me.RadPanel4.TabIndex = 1
        Me.RadPanel4.Text = "Select Time Needed"
        Me.RadPanel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Location = New System.Drawing.Point(16, 116)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel2.TabIndex = 127
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Location = New System.Drawing.Point(16, 65)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel3.TabIndex = 126
        '
        'txt_ST_purpose
        '
        Me.txt_ST_purpose.AutoSize = False
        Me.txt_ST_purpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ST_purpose.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.txt_ST_purpose.ForeColor = System.Drawing.Color.Black
        Me.txt_ST_purpose.Location = New System.Drawing.Point(348, 41)
        Me.txt_ST_purpose.Multiline = True
        Me.txt_ST_purpose.Name = "txt_ST_purpose"
        Me.txt_ST_purpose.NullText = "Purpose  (Optional)"
        Me.txt_ST_purpose.Size = New System.Drawing.Size(279, 114)
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
        Me.tp_ST_neededtime.Location = New System.Drawing.Point(65, 116)
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
        Me.tp_ST_neededtime.Value = New Date(2016, 9, 15, 7, 0, 0, 0)
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
        Me.dp_workoperations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_workoperations.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dp_workoperations.Location = New System.Drawing.Point(65, 276)
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
        CType(Me.dp_workoperations.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_workoperations.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_workoperations.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        '
        'dp_location_lot
        '
        Me.dp_location_lot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location_lot.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dp_location_lot.Location = New System.Drawing.Point(65, 225)
        Me.dp_location_lot.Name = "dp_location_lot"
        Me.dp_location_lot.NullText = "Select lot number  (Required)"
        '
        '
        '
        Me.dp_location_lot.RootElement.StretchVertically = True
        Me.dp_location_lot.Size = New System.Drawing.Size(273, 39)
        Me.dp_location_lot.TabIndex = 38
        Me.dp_location_lot.ThemeName = "Office2013Light"
        CType(Me.dp_location_lot.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_location_lot.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_location_lot.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        '
        'dp_location
        '
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dp_location.Location = New System.Drawing.Point(65, 170)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "Select location  (Required)"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(273, 39)
        Me.dp_location.TabIndex = 1
        Me.dp_location.ThemeName = "Office2013Light"
        CType(Me.dp_location.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_location.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_location.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.dp_location.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        '
        'dt_ST_date
        '
        Me.dt_ST_date.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Bold)
        Me.dt_ST_date.Location = New System.Drawing.Point(65, 65)
        Me.dt_ST_date.Name = "dt_ST_date"
        Me.dt_ST_date.NullText = "Select date needed  (Required)"
        '
        '
        '
        Me.dt_ST_date.RootElement.StretchVertically = True
        Me.dt_ST_date.Size = New System.Drawing.Size(273, 39)
        Me.dt_ST_date.TabIndex = 31
        Me.dt_ST_date.TabStop = False
        Me.dt_ST_date.ThemeName = "Office2013Light"
        Me.dt_ST_date.Value = New Date(CType(0, Long))
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.ForeColor = System.Drawing.Color.DimGray
        Me.RadLabel3.Location = New System.Drawing.Point(12, 320)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(649, 34)
        Me.RadLabel3.TabIndex = 137
        Me.RadLabel3.Text = "NOTE: If you make changes to the following fields  (Date Needed, Time Needed, Loc" &
    "ation, and Purpose) all the item        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           under the same Request No. " &
    "will be modified."
        CType(Me.RadLabel3.GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "NOTE: If you make changes to the following fields  (Date Needed, Time Needed, Loc" &
    "ation, and Purpose) all the item        " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           under the same Request No. " &
    "will be modified."
        CType(Me.RadLabel3.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchHorizontally = True
        CType(Me.RadLabel3.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).StretchVertically = True
        CType(Me.RadLabel3.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextWrap = True
        CType(Me.RadLabel3.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.TopLeft
        '
        'Frm_request_form_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 406)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.gb_menu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_request_form_update"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Trip Ticket Request"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel11.ResumeLayout(False)
        Me.RadPanel11.PerformLayout()
        CType(Me.chk_updateinclude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_reqno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_savechanges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tp_ST_neededtime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_workoperations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location_lot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ST_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_cancel_update As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_savechanges As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_ST_purpose As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents tp_ST_neededtime As Telerik.WinControls.UI.RadTimePicker
    Friend WithEvents dp_workoperations As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dp_location_lot As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dt_ST_date As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents txt_reqno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel10 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel11 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents chk_updateinclude As Telerik.WinControls.UI.RadCheckBox
End Class

