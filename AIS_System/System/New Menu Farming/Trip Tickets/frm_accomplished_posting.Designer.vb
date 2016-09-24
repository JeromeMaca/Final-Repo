<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_accomplished_posting
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
        Me.RadLabel23 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_totalamount = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_trip_ticket_no = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_grandtotal = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_update = New Telerik.WinControls.UI.RadButton()
        Me.lv_posting = New Telerik.WinControls.UI.RadListView()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.se_area_finish = New Telerik.WinControls.UI.RadSpinEditor()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.txt_operation_performed = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_lotno = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_process_all = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel30 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_for_confirmation = New Telerik.WinControls.UI.RadListView()
        Me.RadPanel31 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_totalamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.txt_trip_ticket_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_grandtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_posting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.se_area_finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_operation_performed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lotno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel30, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel30.SuspendLayout()
        CType(Me.lv_for_confirmation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel23
        '
        Me.RadLabel23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel23.Location = New System.Drawing.Point(302, 70)
        Me.RadLabel23.Name = "RadLabel23"
        Me.RadLabel23.Size = New System.Drawing.Size(98, 21)
        Me.RadLabel23.TabIndex = 117
        Me.RadLabel23.Text = "Total Amount:"
        '
        'txt_totalamount
        '
        Me.txt_totalamount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_totalamount.Location = New System.Drawing.Point(356, 91)
        Me.txt_totalamount.Name = "txt_totalamount"
        Me.txt_totalamount.ReadOnly = True
        Me.txt_totalamount.Size = New System.Drawing.Size(142, 20)
        Me.txt_totalamount.TabIndex = 116
        Me.txt_totalamount.TabStop = False
        Me.txt_totalamount.Text = "₱0.00"
        Me.txt_totalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel22
        '
        Me.RadLabel22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel22.Location = New System.Drawing.Point(302, 21)
        Me.RadLabel22.Name = "RadLabel22"
        Me.RadLabel22.Size = New System.Drawing.Size(77, 21)
        Me.RadLabel22.TabIndex = 115
        Me.RadLabel22.Text = "Area Done:"
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_data.Controls.Add(Me.RadPanel3)
        Me.gb_data.Controls.Add(Me.RadPanel1)
        Me.gb_data.Controls.Add(Me.txt_trip_ticket_no)
        Me.gb_data.Controls.Add(Me.RadLabel4)
        Me.gb_data.Controls.Add(Me.txt_grandtotal)
        Me.gb_data.Controls.Add(Me.RadLabel3)
        Me.gb_data.Controls.Add(Me.btn_update)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(339, 51)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(724, 384)
        Me.gb_data.TabIndex = 119
        Me.gb_data.ThemeName = "Office2013Light"
        '
        'txt_trip_ticket_no
        '
        Me.txt_trip_ticket_no.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_trip_ticket_no.Location = New System.Drawing.Point(229, 352)
        Me.txt_trip_ticket_no.Name = "txt_trip_ticket_no"
        Me.txt_trip_ticket_no.NullText = "<System Generated>"
        Me.txt_trip_ticket_no.ReadOnly = True
        Me.txt_trip_ticket_no.Size = New System.Drawing.Size(122, 20)
        Me.txt_trip_ticket_no.TabIndex = 123
        Me.txt_trip_ticket_no.TabStop = False
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(121, 353)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(104, 21)
        Me.RadLabel4.TabIndex = 122
        Me.RadLabel4.Text = "Trip Ticket No.:"
        '
        'txt_grandtotal
        '
        Me.txt_grandtotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_grandtotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_grandtotal.Location = New System.Drawing.Point(494, 353)
        Me.txt_grandtotal.Name = "txt_grandtotal"
        Me.txt_grandtotal.ReadOnly = True
        Me.txt_grandtotal.Size = New System.Drawing.Size(217, 20)
        Me.txt_grandtotal.TabIndex = 121
        Me.txt_grandtotal.TabStop = False
        Me.txt_grandtotal.Text = "₱0.00"
        Me.txt_grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel3.Location = New System.Drawing.Point(357, 352)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(134, 21)
        Me.RadLabel3.TabIndex = 120
        Me.RadLabel3.Text = "Grand Total Amount:"
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_update.Location = New System.Drawing.Point(5, 351)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(110, 24)
        Me.btn_update.TabIndex = 118
        Me.btn_update.Text = "Update"
        '
        'lv_posting
        '
        Me.lv_posting.AllowEdit = False
        Me.lv_posting.AllowRemove = False
        Me.lv_posting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_posting.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lv_posting.ItemSpacing = -1
        Me.lv_posting.Location = New System.Drawing.Point(1, 1)
        Me.lv_posting.Name = "lv_posting"
        Me.lv_posting.SelectLastAddedItem = False
        Me.lv_posting.ShowGridLines = True
        Me.lv_posting.Size = New System.Drawing.Size(714, 300)
        Me.lv_posting.TabIndex = 0
        Me.lv_posting.ThemeName = "VisualStudio2012Light"
        Me.lv_posting.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_posting.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.Location = New System.Drawing.Point(600, 93)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(110, 24)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Cancel"
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_menu.Controls.Add(Me.txt_lotno)
        Me.gb_menu.Controls.Add(Me.se_area_finish)
        Me.gb_menu.Controls.Add(Me.btn_save)
        Me.gb_menu.Controls.Add(Me.txt_operation_performed)
        Me.gb_menu.Controls.Add(Me.RadLabel2)
        Me.gb_menu.Controls.Add(Me.RadLabel1)
        Me.gb_menu.Controls.Add(Me.RadLabel22)
        Me.gb_menu.Controls.Add(Me.txt_totalamount)
        Me.gb_menu.Controls.Add(Me.btn_cancel)
        Me.gb_menu.Controls.Add(Me.RadLabel23)
        Me.gb_menu.Enabled = False
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(340, 436)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(723, 137)
        Me.gb_menu.TabIndex = 120
        Me.gb_menu.ThemeName = "Office2013Light"
        '
        'se_area_finish
        '
        Me.se_area_finish.DecimalPlaces = 3
        Me.se_area_finish.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.se_area_finish.Location = New System.Drawing.Point(356, 44)
        Me.se_area_finish.Name = "se_area_finish"
        '
        '
        '
        Me.se_area_finish.RootElement.StretchVertically = True
        Me.se_area_finish.Size = New System.Drawing.Size(112, 20)
        Me.se_area_finish.TabIndex = 109
        Me.se_area_finish.TabStop = False
        Me.se_area_finish.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.Location = New System.Drawing.Point(600, 63)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(110, 24)
        Me.btn_save.TabIndex = 122
        Me.btn_save.Text = "Save"
        '
        'txt_operation_performed
        '
        Me.txt_operation_performed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_operation_performed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_operation_performed.Location = New System.Drawing.Point(22, 103)
        Me.txt_operation_performed.Name = "txt_operation_performed"
        Me.txt_operation_performed.NullText = "<System Generated>"
        Me.txt_operation_performed.ReadOnly = True
        Me.txt_operation_performed.Size = New System.Drawing.Size(288, 20)
        Me.txt_operation_performed.TabIndex = 121
        Me.txt_operation_performed.TabStop = False
        '
        'txt_lotno
        '
        Me.txt_lotno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lotno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_lotno.Location = New System.Drawing.Point(22, 44)
        Me.txt_lotno.Name = "txt_lotno"
        Me.txt_lotno.NullText = "<System Generated>"
        Me.txt_lotno.ReadOnly = True
        Me.txt_lotno.Size = New System.Drawing.Size(288, 20)
        Me.txt_lotno.TabIndex = 120
        Me.txt_lotno.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(22, 70)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(145, 21)
        Me.RadLabel2.TabIndex = 119
        Me.RadLabel2.Text = "Operation Performed:"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(19, 21)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(86, 21)
        Me.RadLabel1.TabIndex = 119
        Me.RadLabel1.Text = "Lot Number:"
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel2.ForeColor = System.Drawing.Color.White
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(1062, 51)
        Me.RadPanel2.TabIndex = 121
        Me.RadPanel2.Text = "ACCOMPLISHED TRIP TICKET POSTING"
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
        Me.RadGroupBox1.Location = New System.Drawing.Point(2, 51)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(334, 526)
        Me.RadGroupBox1.TabIndex = 122
        Me.RadGroupBox1.ThemeName = "Office2013Light"
        '
        'btn_process_all
        '
        Me.btn_process_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_process_all.BackColor = System.Drawing.Color.Black
        Me.btn_process_all.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_process_all.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_process_all.Location = New System.Drawing.Point(0, 484)
        Me.btn_process_all.Name = "btn_process_all"
        Me.btn_process_all.Size = New System.Drawing.Size(334, 40)
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
        Me.RadPanel30.Size = New System.Drawing.Size(334, 436)
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
        Me.lv_for_confirmation.Size = New System.Drawing.Size(332, 434)
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
        Me.RadPanel31.Text = "FOR POSTING TICKET"
        Me.RadPanel31.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(5, 5)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(716, 39)
        Me.RadPanel1.TabIndex = 174
        Me.RadPanel1.Text = "TICKET DETAIL"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Controls.Add(Me.lv_posting)
        Me.RadPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadPanel3.ForeColor = System.Drawing.Color.White
        Me.RadPanel3.Location = New System.Drawing.Point(5, 45)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(716, 302)
        Me.RadPanel3.TabIndex = 175
        Me.RadPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_accomplished_posting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 577)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.gb_menu)
        Me.Controls.Add(Me.gb_data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_accomplished_posting"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_accomplished_posting"
        Me.ThemeName = "Office2010Silver"
        CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_totalamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.txt_trip_ticket_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_grandtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_posting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.se_area_finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_operation_performed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lotno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel30, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel30.ResumeLayout(False)
        CType(Me.lv_for_confirmation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel23 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_totalamount As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents RadLabel22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_update As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_posting As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_operation_performed As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_lotno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_grandtotal As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents txt_trip_ticket_no As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents se_area_finish As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_process_all As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel30 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lv_for_confirmation As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadPanel31 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
End Class

