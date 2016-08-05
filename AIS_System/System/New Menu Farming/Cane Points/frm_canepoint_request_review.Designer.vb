<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_canepoint_request_review
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
        Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.lv_for_approval_list = New Telerik.WinControls.UI.RadListView()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadTextBoxControl1 = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.dt_dateneeded = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_lot_no = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_variety = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.rb_pickup = New Telerik.WinControls.UI.RadRadioButton()
        Me.rb_deliver = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_approved = New Telerik.WinControls.UI.RadButton()
        Me.btn_cancel_clear = New Telerik.WinControls.UI.RadButton()
        Me.txt_owner_name = New Telerik.WinControls.UI.RadTextBoxControl()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.lv_for_approval_list, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_dateneeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_lot_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_variety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_pickup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rb_deliver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_approved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel_clear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_owner_name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTabStrip3
        '
        Me.ToolTabStrip3.CanUpdateChildIndex = True
        Me.ToolTabStrip3.Location = New System.Drawing.Point(5, 209)
        Me.ToolTabStrip3.Name = "ToolTabStrip3"
        '
        '
        '
        Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip3.Size = New System.Drawing.Size(1074, 135)
        Me.ToolTabStrip3.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 135)
        Me.ToolTabStrip3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.1631799!)
        Me.ToolTabStrip3.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -143)
        Me.ToolTabStrip3.TabIndex = 1
        Me.ToolTabStrip3.TabStop = False
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.DocumentWindow1
        Me.RadDock1.Controls.Add(Me.ToolTabStrip1)
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDock1.Size = New System.Drawing.Size(977, 496)
        Me.RadDock1.SplitterWidth = 0
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 176)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -126)
        Me.DocumentContainer1.SplitterWidth = 0
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.txt_owner_name)
        Me.DocumentWindow1.Controls.Add(Me.RadLabel7)
        Me.DocumentWindow1.Controls.Add(Me.RadGroupBox1)
        Me.DocumentWindow1.Controls.Add(Me.txt_variety)
        Me.DocumentWindow1.Controls.Add(Me.RadLabel6)
        Me.DocumentWindow1.Controls.Add(Me.dp_lot_no)
        Me.DocumentWindow1.Controls.Add(Me.RadLabel5)
        Me.DocumentWindow1.Controls.Add(Me.RadLabel1)
        Me.DocumentWindow1.Controls.Add(Me.dp_location)
        Me.DocumentWindow1.Controls.Add(Me.RadLabel3)
        Me.DocumentWindow1.Controls.Add(Me.dt_dateneeded)
        Me.DocumentWindow1.Controls.Add(Me.RadLabel2)
        Me.DocumentWindow1.Controls.Add(Me.btn_cancel_clear)
        Me.DocumentWindow1.Controls.Add(Me.btn_approved)
        Me.DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 31)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow1.Size = New System.Drawing.Size(955, 123)
        Me.DocumentWindow1.Text = "Options"
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.CanUpdateChildIndex = True
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(967, 160)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.RadTextBoxControl1)
        Me.ToolWindow1.Controls.Add(Me.RadLabel4)
        Me.ToolWindow1.Controls.Add(Me.lv_for_approval_list)
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(965, 302)
        Me.ToolWindow1.Text = "ALL DATA LIST (For Aprroval)"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
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
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(967, 326)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 326)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 126)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'lv_for_approval_list
        '
        Me.lv_for_approval_list.AllowColumnReorder = False
        Me.lv_for_approval_list.AllowEdit = False
        Me.lv_for_approval_list.AllowRemove = False
        Me.lv_for_approval_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_for_approval_list.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_for_approval_list.ItemSpacing = -1
        Me.lv_for_approval_list.Location = New System.Drawing.Point(3, 37)
        Me.lv_for_approval_list.Name = "lv_for_approval_list"
        Me.lv_for_approval_list.SelectLastAddedItem = False
        Me.lv_for_approval_list.Size = New System.Drawing.Size(959, 263)
        Me.lv_for_approval_list.TabIndex = 0
        Me.lv_for_approval_list.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(7, 12)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(122, 18)
        Me.RadLabel4.TabIndex = 133
        Me.RadLabel4.Text = "Find Some Data Here:"
        '
        'RadTextBoxControl1
        '
        Me.RadTextBoxControl1.Location = New System.Drawing.Point(126, 10)
        Me.RadTextBoxControl1.Name = "RadTextBoxControl1"
        Me.RadTextBoxControl1.NullText = "<Conditional>"
        Me.RadTextBoxControl1.Size = New System.Drawing.Size(381, 20)
        Me.RadTextBoxControl1.TabIndex = 134
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(3, 13)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(78, 18)
        Me.RadLabel1.TabIndex = 138
        Me.RadLabel1.Text = "Validity Date:"
        '
        'dp_location
        '
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dp_location.Location = New System.Drawing.Point(64, 45)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "<Required>"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(216, 20)
        Me.dp_location.TabIndex = 140
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(3, 47)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel3.TabIndex = 141
        Me.RadLabel3.Text = "Location:"
        '
        'dt_dateneeded
        '
        Me.dt_dateneeded.Location = New System.Drawing.Point(88, 13)
        Me.dt_dateneeded.Name = "dt_dateneeded"
        Me.dt_dateneeded.Size = New System.Drawing.Size(192, 20)
        Me.dt_dateneeded.TabIndex = 139
        Me.dt_dateneeded.TabStop = False
        Me.dt_dateneeded.Text = "Friday, August 5, 2016"
        Me.dt_dateneeded.Value = New Date(2015, 12, 28, 0, 0, 0, 0)
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(306, 13)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(65, 18)
        Me.RadLabel2.TabIndex = 143
        Me.RadLabel2.Text = "Lot Owner:"
        '
        'dp_lot_no
        '
        Me.dp_lot_no.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_lot_no.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dp_lot_no.Location = New System.Drawing.Point(82, 79)
        Me.dp_lot_no.Name = "dp_lot_no"
        Me.dp_lot_no.NullText = "<Required>"
        '
        '
        '
        Me.dp_lot_no.RootElement.StretchVertically = True
        Me.dp_lot_no.Size = New System.Drawing.Size(198, 20)
        Me.dp_lot_no.TabIndex = 144
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel5.Location = New System.Drawing.Point(3, 81)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel5.TabIndex = 145
        Me.RadLabel5.Text = "Lot Number:"
        '
        'txt_variety
        '
        Me.txt_variety.IsReadOnlyCaretVisible = True
        Me.txt_variety.Location = New System.Drawing.Point(374, 44)
        Me.txt_variety.Name = "txt_variety"
        Me.txt_variety.NullText = "<System Generated>"
        Me.txt_variety.Size = New System.Drawing.Size(237, 20)
        Me.txt_variety.TabIndex = 147
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(306, 46)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel6.TabIndex = 146
        Me.RadLabel6.Text = "Crop Class:"
        '
        'rb_pickup
        '
        Me.rb_pickup.BackColor = System.Drawing.Color.Transparent
        Me.rb_pickup.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_pickup.Location = New System.Drawing.Point(131, 4)
        Me.rb_pickup.Name = "rb_pickup"
        Me.rb_pickup.Size = New System.Drawing.Size(60, 18)
        Me.rb_pickup.TabIndex = 148
        Me.rb_pickup.TabStop = False
        Me.rb_pickup.Text = "Pick Up"
        '
        'rb_deliver
        '
        Me.rb_deliver.BackColor = System.Drawing.Color.Transparent
        Me.rb_deliver.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rb_deliver.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rb_deliver.Location = New System.Drawing.Point(24, 4)
        Me.rb_deliver.Name = "rb_deliver"
        Me.rb_deliver.Size = New System.Drawing.Size(58, 18)
        Me.rb_deliver.TabIndex = 149
        Me.rb_deliver.Text = "Deliver"
        Me.rb_deliver.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.RadGroupBox1.Controls.Add(Me.rb_pickup)
        Me.RadGroupBox1.Controls.Add(Me.rb_deliver)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(387, 73)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(224, 26)
        Me.RadGroupBox1.TabIndex = 150
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel7.Location = New System.Drawing.Point(306, 79)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(80, 18)
        Me.RadLabel7.TabIndex = 150
        Me.RadLabel7.Text = "Hauling Type:"
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_approved.Location = New System.Drawing.Point(638, 0)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(315, 56)
        Me.btn_approved.TabIndex = 151
        Me.btn_approved.Text = "APPROVED SELECTED ITEM"
        '
        'btn_cancel_clear
        '
        Me.btn_cancel_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel_clear.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel_clear.Location = New System.Drawing.Point(638, 61)
        Me.btn_cancel_clear.Name = "btn_cancel_clear"
        Me.btn_cancel_clear.Size = New System.Drawing.Size(315, 56)
        Me.btn_cancel_clear.TabIndex = 152
        Me.btn_cancel_clear.Text = "CANCEL AND CLEAR ALL DATA SELECTED"
        '
        'txt_owner_name
        '
        Me.txt_owner_name.IsReadOnlyCaretVisible = True
        Me.txt_owner_name.Location = New System.Drawing.Point(374, 13)
        Me.txt_owner_name.Name = "txt_owner_name"
        Me.txt_owner_name.NullText = "<System Generated>"
        Me.txt_owner_name.Size = New System.Drawing.Size(237, 20)
        Me.txt_owner_name.TabIndex = 153
        '
        'Frm_canepoint_request_review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 496)
        Me.Controls.Add(Me.RadDock1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_canepoint_request_review"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_canepoint_request_review"
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        Me.DocumentWindow1.PerformLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        Me.ToolWindow1.PerformLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.lv_for_approval_list, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_dateneeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_lot_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_variety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_pickup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rb_deliver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_approved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel_clear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_owner_name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents lv_for_approval_list As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadTextBoxControl1 As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents dp_lot_no As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dt_dateneeded As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_variety As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents rb_deliver As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents rb_pickup As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_cancel_clear As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_approved As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_owner_name As Telerik.WinControls.UI.RadTextBoxControl
End Class

