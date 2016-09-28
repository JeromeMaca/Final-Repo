<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_schedule_printing
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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_purpose = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_save_request = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel12 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel11 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_approvedby = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel10 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_requestedby = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_driver = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_implement_code = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_equipment_no = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_equipment_type = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_destination = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_tripdate = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_tripticket_no = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.rp_trip_ticket_scheduled = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_approvedby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_requestedby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_driver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_implement_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipment_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_equipment_type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_destination, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tripdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tripticket_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
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
        Me.RadPanel1.Size = New System.Drawing.Size(1222, 52)
        Me.RadPanel1.TabIndex = 33
        Me.RadPanel1.Text = "SCHEDULED TRIP TICKET"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox1.Controls.Add(Me.txt_purpose)
        Me.RadGroupBox1.Controls.Add(Me.btn_save_request)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel12)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel11)
        Me.RadGroupBox1.Controls.Add(Me.txt_approvedby)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel10)
        Me.RadGroupBox1.Controls.Add(Me.txt_requestedby)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel9)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel8)
        Me.RadGroupBox1.Controls.Add(Me.txt_driver)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel7)
        Me.RadGroupBox1.Controls.Add(Me.txt_implement_code)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel5)
        Me.RadGroupBox1.Controls.Add(Me.txt_equipment_no)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel4)
        Me.RadGroupBox1.Controls.Add(Me.txt_equipment_type)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel3)
        Me.RadGroupBox1.Controls.Add(Me.txt_destination)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel2)
        Me.RadGroupBox1.Controls.Add(Me.txt_tripdate)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel6)
        Me.RadGroupBox1.Controls.Add(Me.txt_tripticket_no)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 52)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(350, 600)
        Me.RadGroupBox1.TabIndex = 34
        Me.RadGroupBox1.ThemeName = "Office2013Light"
        '
        'txt_purpose
        '
        Me.txt_purpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_purpose.AutoSize = False
        Me.txt_purpose.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_purpose.Location = New System.Drawing.Point(53, 361)
        Me.txt_purpose.Multiline = True
        Me.txt_purpose.Name = "txt_purpose"
        Me.txt_purpose.NullText = "Purpose  (System Generated)"
        Me.txt_purpose.ReadOnly = True
        Me.txt_purpose.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_purpose.Size = New System.Drawing.Size(296, 75)
        Me.txt_purpose.TabIndex = 88
        Me.txt_purpose.ThemeName = "Office2013Light"
        '
        'btn_save_request
        '
        Me.btn_save_request.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save_request.BackColor = System.Drawing.Color.Black
        Me.btn_save_request.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save_request.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_save_request.Location = New System.Drawing.Point(4, 545)
        Me.btn_save_request.Name = "btn_save_request"
        Me.btn_save_request.Size = New System.Drawing.Size(345, 50)
        Me.btn_save_request.TabIndex = 0
        Me.btn_save_request.Text = "PRINT DIRECTLY"
        Me.btn_save_request.ThemeName = "Office2013Dark"
        CType(Me.btn_save_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_save_request.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "PRINT DIRECTLY"
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
        'RadPanel12
        '
        Me.RadPanel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadPanel12.ForeColor = System.Drawing.Color.White
        Me.RadPanel12.Location = New System.Drawing.Point(4, 6)
        Me.RadPanel12.Name = "RadPanel12"
        Me.RadPanel12.Size = New System.Drawing.Size(345, 39)
        Me.RadPanel12.TabIndex = 151
        Me.RadPanel12.Text = "Basic Ticket Information"
        Me.RadPanel12.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel11
        '
        Me.RadPanel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel11.Location = New System.Drawing.Point(4, 487)
        Me.RadPanel11.Name = "RadPanel11"
        Me.RadPanel11.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel11.TabIndex = 150
        '
        'txt_approvedby
        '
        Me.txt_approvedby.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_approvedby.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_approvedby.Location = New System.Drawing.Point(53, 487)
        Me.txt_approvedby.Name = "txt_approvedby"
        Me.txt_approvedby.NullText = "Approved By  (System Generated)"
        Me.txt_approvedby.ReadOnly = True
        '
        '
        '
        Me.txt_approvedby.RootElement.StretchVertically = True
        Me.txt_approvedby.Size = New System.Drawing.Size(296, 39)
        Me.txt_approvedby.TabIndex = 149
        Me.txt_approvedby.ThemeName = "Office2013Light"
        '
        'RadPanel10
        '
        Me.RadPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel10.Location = New System.Drawing.Point(4, 442)
        Me.RadPanel10.Name = "RadPanel10"
        Me.RadPanel10.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel10.TabIndex = 148
        '
        'txt_requestedby
        '
        Me.txt_requestedby.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_requestedby.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_requestedby.Location = New System.Drawing.Point(53, 442)
        Me.txt_requestedby.Name = "txt_requestedby"
        Me.txt_requestedby.NullText = "Requested By  (System Generated)"
        Me.txt_requestedby.ReadOnly = True
        '
        '
        '
        Me.txt_requestedby.RootElement.StretchVertically = True
        Me.txt_requestedby.Size = New System.Drawing.Size(296, 39)
        Me.txt_requestedby.TabIndex = 147
        Me.txt_requestedby.ThemeName = "Office2013Light"
        '
        'RadPanel9
        '
        Me.RadPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel9.Location = New System.Drawing.Point(4, 361)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(49, 75)
        Me.RadPanel9.TabIndex = 146
        '
        'RadPanel8
        '
        Me.RadPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel8.Location = New System.Drawing.Point(4, 317)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel8.TabIndex = 144
        '
        'txt_driver
        '
        Me.txt_driver.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_driver.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_driver.Location = New System.Drawing.Point(53, 317)
        Me.txt_driver.Name = "txt_driver"
        Me.txt_driver.NullText = "Driver Name  (System Generated)"
        Me.txt_driver.ReadOnly = True
        '
        '
        '
        Me.txt_driver.RootElement.StretchVertically = True
        Me.txt_driver.Size = New System.Drawing.Size(296, 39)
        Me.txt_driver.TabIndex = 143
        Me.txt_driver.ThemeName = "Office2013Light"
        '
        'RadPanel7
        '
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Location = New System.Drawing.Point(4, 273)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel7.TabIndex = 142
        '
        'txt_implement_code
        '
        Me.txt_implement_code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_implement_code.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_implement_code.Location = New System.Drawing.Point(53, 273)
        Me.txt_implement_code.Name = "txt_implement_code"
        Me.txt_implement_code.NullText = "Implement Code  (System Generated)"
        Me.txt_implement_code.ReadOnly = True
        '
        '
        '
        Me.txt_implement_code.RootElement.StretchVertically = True
        Me.txt_implement_code.Size = New System.Drawing.Size(296, 39)
        Me.txt_implement_code.TabIndex = 141
        Me.txt_implement_code.ThemeName = "Office2013Light"
        '
        'RadPanel5
        '
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Location = New System.Drawing.Point(4, 229)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel5.TabIndex = 140
        '
        'txt_equipment_no
        '
        Me.txt_equipment_no.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_equipment_no.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_equipment_no.Location = New System.Drawing.Point(53, 229)
        Me.txt_equipment_no.Name = "txt_equipment_no"
        Me.txt_equipment_no.NullText = "Equipment No  (System Generated)"
        Me.txt_equipment_no.ReadOnly = True
        '
        '
        '
        Me.txt_equipment_no.RootElement.StretchVertically = True
        Me.txt_equipment_no.Size = New System.Drawing.Size(296, 39)
        Me.txt_equipment_no.TabIndex = 139
        Me.txt_equipment_no.ThemeName = "Office2013Light"
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Location = New System.Drawing.Point(4, 185)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel4.TabIndex = 138
        '
        'txt_equipment_type
        '
        Me.txt_equipment_type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_equipment_type.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_equipment_type.Location = New System.Drawing.Point(53, 185)
        Me.txt_equipment_type.Name = "txt_equipment_type"
        Me.txt_equipment_type.NullText = "Equipment Type  (System Generated)"
        Me.txt_equipment_type.ReadOnly = True
        '
        '
        '
        Me.txt_equipment_type.RootElement.StretchVertically = True
        Me.txt_equipment_type.Size = New System.Drawing.Size(296, 39)
        Me.txt_equipment_type.TabIndex = 137
        Me.txt_equipment_type.ThemeName = "Office2013Light"
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Location = New System.Drawing.Point(4, 141)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel3.TabIndex = 136
        '
        'txt_destination
        '
        Me.txt_destination.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_destination.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_destination.Location = New System.Drawing.Point(53, 141)
        Me.txt_destination.Name = "txt_destination"
        Me.txt_destination.NullText = "Destination  (System Generated)"
        Me.txt_destination.ReadOnly = True
        '
        '
        '
        Me.txt_destination.RootElement.StretchVertically = True
        Me.txt_destination.Size = New System.Drawing.Size(296, 39)
        Me.txt_destination.TabIndex = 135
        Me.txt_destination.ThemeName = "Office2013Light"
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Location = New System.Drawing.Point(4, 97)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel2.TabIndex = 134
        '
        'txt_tripdate
        '
        Me.txt_tripdate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tripdate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_tripdate.Location = New System.Drawing.Point(53, 97)
        Me.txt_tripdate.Name = "txt_tripdate"
        Me.txt_tripdate.NullText = "Trip Date  (System Generated)"
        Me.txt_tripdate.ReadOnly = True
        '
        '
        '
        Me.txt_tripdate.RootElement.StretchVertically = True
        Me.txt_tripdate.Size = New System.Drawing.Size(296, 39)
        Me.txt_tripdate.TabIndex = 133
        Me.txt_tripdate.ThemeName = "Office2013Light"
        '
        'RadPanel6
        '
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Location = New System.Drawing.Point(4, 53)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel6.TabIndex = 132
        '
        'txt_tripticket_no
        '
        Me.txt_tripticket_no.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_tripticket_no.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_tripticket_no.Location = New System.Drawing.Point(53, 53)
        Me.txt_tripticket_no.Name = "txt_tripticket_no"
        Me.txt_tripticket_no.NullText = "Trip Ticket No  (System Generated)"
        Me.txt_tripticket_no.ReadOnly = True
        '
        '
        '
        Me.txt_tripticket_no.RootElement.StretchVertically = True
        Me.txt_tripticket_no.Size = New System.Drawing.Size(296, 39)
        Me.txt_tripticket_no.TabIndex = 131
        Me.txt_tripticket_no.ThemeName = "Office2013Light"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.Controls.Add(Me.rp_trip_ticket_scheduled)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(351, 52)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(869, 601)
        Me.RadGroupBox2.TabIndex = 35
        Me.RadGroupBox2.ThemeName = "Office2013Light"
        '
        'rp_trip_ticket_scheduled
        '
        Me.rp_trip_ticket_scheduled.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rp_trip_ticket_scheduled.Font = New System.Drawing.Font("Segoe UI", 5.0!, System.Drawing.FontStyle.Bold)
        Me.rp_trip_ticket_scheduled.Location = New System.Drawing.Point(5, 5)
        Me.rp_trip_ticket_scheduled.Name = "rp_trip_ticket_scheduled"
        Me.rp_trip_ticket_scheduled.Size = New System.Drawing.Size(864, 594)
        Me.rp_trip_ticket_scheduled.TabIndex = 0
        '
        'Frm_schedule_printing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 653)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_schedule_printing"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Trip Ticket Scheduled"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_approvedby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_requestedby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_driver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_implement_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipment_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_equipment_type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_destination, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tripdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tripticket_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents rp_trip_ticket_scheduled As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_tripticket_no As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel11 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_approvedby As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel10 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_requestedby As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_driver As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_implement_code As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_equipment_no As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_equipment_type As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_destination As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_tripdate As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel12 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_save_request As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_purpose As Telerik.WinControls.UI.RadTextBox
End Class

