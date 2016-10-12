<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_emodequipment
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
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.rv_emod_tractors = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.gb_approved = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.dt_enddate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.dp_cropyear = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.dt_startdate = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadPanel25 = New Telerik.WinControls.UI.RadPanel()
        Me.btn_preview = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.gb_approved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_approved.SuspendLayout()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_enddate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_cropyear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_startdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_preview, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadPanel2.Size = New System.Drawing.Size(1060, 58)
        Me.RadPanel2.TabIndex = 165
        Me.RadPanel2.Text = "EMOD EQUIPMENT (TRUCTOR)"
        Me.RadPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox3.Controls.Add(Me.RadGroupBox4)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(395, 59)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(665, 484)
        Me.RadGroupBox3.TabIndex = 180
        Me.RadGroupBox3.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox4.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox4.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox4.HeaderText = "Report Preview"
        Me.RadGroupBox4.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(655, 470)
        Me.RadGroupBox4.TabIndex = 10
        Me.RadGroupBox4.Text = "Report Preview"
        Me.RadGroupBox4.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel1
        '
        Me.RadPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel1.Controls.Add(Me.rv_emod_tractors)
        Me.RadPanel1.Location = New System.Drawing.Point(0, 21)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(655, 449)
        Me.RadPanel1.TabIndex = 130
        '
        'rv_emod_tractors
        '
        Me.rv_emod_tractors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rv_emod_tractors.Location = New System.Drawing.Point(0, 0)
        Me.rv_emod_tractors.Name = "rv_emod_tractors"
        Me.rv_emod_tractors.Size = New System.Drawing.Size(655, 449)
        Me.rv_emod_tractors.TabIndex = 0
        '
        'gb_approved
        '
        Me.gb_approved.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_approved.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_approved.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_approved.Controls.Add(Me.RadGroupBox1)
        Me.gb_approved.HeaderText = ""
        Me.gb_approved.Location = New System.Drawing.Point(0, 59)
        Me.gb_approved.Name = "gb_approved"
        Me.gb_approved.Size = New System.Drawing.Size(394, 484)
        Me.gb_approved.TabIndex = 17
        Me.gb_approved.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox1.Controls.Add(Me.RadPanel3)
        Me.RadGroupBox1.Controls.Add(Me.dt_enddate)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel7)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel6)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel5)
        Me.RadGroupBox1.Controls.Add(Me.dp_cropyear)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel4)
        Me.RadGroupBox1.Controls.Add(Me.dt_startdate)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel25)
        Me.RadGroupBox1.Controls.Add(Me.btn_preview)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderText = "FILLUP ALL INFORMATION"
        Me.RadGroupBox1.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(384, 470)
        Me.RadGroupBox1.TabIndex = 10
        Me.RadGroupBox1.Text = "FILLUP ALL INFORMATION"
        Me.RadGroupBox1.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel3.ForeColor = System.Drawing.Color.White
        Me.RadPanel3.Location = New System.Drawing.Point(255, 131)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(121, 39)
        Me.RadPanel3.TabIndex = 192
        Me.RadPanel3.Text = "End Date"
        Me.RadPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dt_enddate
        '
        Me.dt_enddate.Culture = New System.Globalization.CultureInfo("en-PH")
        Me.dt_enddate.CustomFormat = "M D,YYYY"
        Me.dt_enddate.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dt_enddate.Location = New System.Drawing.Point(52, 131)
        Me.dt_enddate.Name = "dt_enddate"
        Me.dt_enddate.NullText = "Date End  (Required)"
        '
        '
        '
        Me.dt_enddate.RootElement.StretchVertically = True
        Me.dt_enddate.Size = New System.Drawing.Size(204, 39)
        Me.dt_enddate.TabIndex = 191
        Me.dt_enddate.TabStop = False
        Me.dt_enddate.ThemeName = "Office2013Light"
        Me.dt_enddate.Value = New Date(CType(0, Long))
        '
        'RadPanel7
        '
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Location = New System.Drawing.Point(5, 131)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel7.TabIndex = 190
        '
        'RadPanel6
        '
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel6.ForeColor = System.Drawing.Color.White
        Me.RadPanel6.Location = New System.Drawing.Point(255, 86)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(121, 39)
        Me.RadPanel6.TabIndex = 189
        Me.RadPanel6.Text = "Start Date"
        Me.RadPanel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel5
        '
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel5.ForeColor = System.Drawing.Color.White
        Me.RadPanel5.Location = New System.Drawing.Point(255, 41)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(121, 39)
        Me.RadPanel5.TabIndex = 188
        Me.RadPanel5.Text = "Crop Year"
        Me.RadPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dp_cropyear
        '
        Me.dp_cropyear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_cropyear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp_cropyear.Location = New System.Drawing.Point(53, 41)
        Me.dp_cropyear.Name = "dp_cropyear"
        Me.dp_cropyear.NullText = "Crop Year  (Required)"
        '
        '
        '
        Me.dp_cropyear.RootElement.StretchVertically = True
        Me.dp_cropyear.Size = New System.Drawing.Size(203, 39)
        Me.dp_cropyear.TabIndex = 186
        Me.dp_cropyear.ThemeName = "Office2013Light"
        CType(Me.dp_cropyear.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        CType(Me.dp_cropyear.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadDropDownListEditableAreaElement).DrawText = False
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Text = ""
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Crop Year  (Required)"
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).StretchHorizontally = False
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).StretchVertically = False
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Image = Nothing
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.dp_cropyear.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Location = New System.Drawing.Point(5, 41)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel4.TabIndex = 187
        '
        'dt_startdate
        '
        Me.dt_startdate.Culture = New System.Globalization.CultureInfo("en-PH")
        Me.dt_startdate.CustomFormat = "M D,YYYY"
        Me.dt_startdate.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dt_startdate.Location = New System.Drawing.Point(52, 86)
        Me.dt_startdate.Name = "dt_startdate"
        Me.dt_startdate.NullText = "Date Start  (Required)"
        Me.dt_startdate.ReadOnly = True
        '
        '
        '
        Me.dt_startdate.RootElement.StretchVertically = True
        Me.dt_startdate.Size = New System.Drawing.Size(204, 39)
        Me.dt_startdate.TabIndex = 178
        Me.dt_startdate.TabStop = False
        Me.dt_startdate.ThemeName = "Office2013Light"
        Me.dt_startdate.Value = New Date(CType(0, Long))
        '
        'RadPanel25
        '
        Me.RadPanel25.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel25.Location = New System.Drawing.Point(5, 86)
        Me.RadPanel25.Name = "RadPanel25"
        Me.RadPanel25.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel25.TabIndex = 177
        '
        'btn_preview
        '
        Me.btn_preview.BackColor = System.Drawing.Color.Black
        Me.btn_preview.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_preview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_preview.Location = New System.Drawing.Point(194, 186)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(182, 38)
        Me.btn_preview.TabIndex = 176
        Me.btn_preview.Text = "REPORT PREVIEW"
        Me.btn_preview.ThemeName = "Office2013Dark"
        CType(Me.btn_preview.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_preview.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "REPORT PREVIEW"
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'Frm_emodequipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 543)
        Me.Controls.Add(Me.gb_approved)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadPanel2)
        Me.Name = "Frm_emodequipment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_emodequipment"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.gb_approved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_approved.ResumeLayout(False)
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_enddate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_cropyear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_startdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rv_emod_tractors As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents gb_approved As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents dt_startdate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadPanel25 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_preview As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dp_cropyear As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dt_enddate As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
End Class

