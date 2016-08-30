<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_masterlist_implements
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
        Dim TableViewDefinition24 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_masterimplement = New Telerik.WinControls.UI.RadListView()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_desc = New Telerik.WinControls.UI.RadTextBox()
        Me.dp_implelist = New Telerik.WinControls.UI.RadDropDownList()
        Me.dp_owner = New Telerik.WinControls.UI.RadDropDownList()
        Me.txt_code = New Telerik.WinControls.UI.RadTextBox()
        Me.cms_implement = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.add = New System.Windows.Forms.ToolStripMenuItem()
        Me.modify = New System.Windows.Forms.ToolStripMenuItem()
        Me.remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.btn_search = New Telerik.WinControls.UI.RadButton()
        Me.mcc_equipments = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.lv_masterimplement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.txt_desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_implelist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_owner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_implement.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel7.SuspendLayout()
        CType(Me.btn_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_equipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_equipments.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_equipments.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.RadLabel3)
        Me.gb_data.Controls.Add(Me.btn_search)
        Me.gb_data.Controls.Add(Me.mcc_equipments)
        Me.gb_data.Controls.Add(Me.RadPanel6)
        Me.gb_data.Controls.Add(Me.RadPanel7)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(349, 43)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(964, 537)
        Me.gb_data.TabIndex = 9
        Me.gb_data.ThemeName = "Office2013Light"
        '
        'lv_masterimplement
        '
        Me.lv_masterimplement.AllowColumnReorder = False
        Me.lv_masterimplement.AllowEdit = False
        Me.lv_masterimplement.AllowRemove = False
        Me.lv_masterimplement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_masterimplement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lv_masterimplement.EnableGrouping = True
        Me.lv_masterimplement.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_masterimplement.ForeColor = System.Drawing.Color.Black
        Me.lv_masterimplement.HeaderHeight = 40.0!
        Me.lv_masterimplement.HotTracking = False
        Me.lv_masterimplement.ItemSpacing = -1
        Me.lv_masterimplement.Location = New System.Drawing.Point(1, 1)
        Me.lv_masterimplement.Name = "lv_masterimplement"
        Me.lv_masterimplement.SelectLastAddedItem = False
        Me.lv_masterimplement.ShowGroups = True
        Me.lv_masterimplement.Size = New System.Drawing.Size(955, 456)
        Me.lv_masterimplement.TabIndex = 30
        Me.lv_masterimplement.TabStop = False
        Me.lv_masterimplement.Text = "RadListView1"
        Me.lv_masterimplement.ThemeName = "VisualStudio2012Light"
        Me.lv_masterimplement.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_masterimplement.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.RadPanel8)
        Me.gb_menu.Controls.Add(Me.RadPanel4)
        Me.gb_menu.Controls.Add(Me.RadPanel2)
        Me.gb_menu.Controls.Add(Me.RadPanel3)
        Me.gb_menu.Controls.Add(Me.RadPanel5)
        Me.gb_menu.Controls.Add(Me.btn_cancel)
        Me.gb_menu.Controls.Add(Me.btn_save)
        Me.gb_menu.Controls.Add(Me.txt_desc)
        Me.gb_menu.Controls.Add(Me.dp_implelist)
        Me.gb_menu.Controls.Add(Me.dp_owner)
        Me.gb_menu.Controls.Add(Me.txt_code)
        Me.gb_menu.Enabled = False
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(-1, 43)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(349, 537)
        Me.gb_menu.TabIndex = 8
        Me.gb_menu.ThemeName = "Office2013Light"
        '
        'txt_desc
        '
        Me.txt_desc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_desc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_desc.Location = New System.Drawing.Point(58, 260)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.NullText = "Implement Description Here  (Required)"
        '
        '
        '
        Me.txt_desc.RootElement.StretchVertically = True
        Me.txt_desc.Size = New System.Drawing.Size(274, 39)
        Me.txt_desc.TabIndex = 42
        Me.txt_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_desc.ThemeName = "Office2013Light"
        CType(Me.txt_desc.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
        CType(Me.txt_desc.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Implement Description Here  (Required)"
        CType(Me.txt_desc.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.txt_desc.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        '
        'dp_implelist
        '
        Me.dp_implelist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_implelist.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dp_implelist.Location = New System.Drawing.Point(58, 134)
        Me.dp_implelist.Name = "dp_implelist"
        Me.dp_implelist.NullText = "Select Implement (Required)"
        '
        '
        '
        Me.dp_implelist.RootElement.StretchVertically = True
        Me.dp_implelist.Size = New System.Drawing.Size(274, 39)
        Me.dp_implelist.TabIndex = 23
        Me.dp_implelist.ThemeName = "Office2013Light"
        CType(Me.dp_implelist.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_implelist.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Select Implement (Required)"
        CType(Me.dp_implelist.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_implelist.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_implelist.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        '
        'dp_owner
        '
        Me.dp_owner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_owner.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.dp_owner.Location = New System.Drawing.Point(58, 73)
        Me.dp_owner.Name = "dp_owner"
        Me.dp_owner.NullText = "Select Implement Owner (Required)"
        '
        '
        '
        Me.dp_owner.RootElement.StretchVertically = True
        Me.dp_owner.Size = New System.Drawing.Size(274, 39)
        Me.dp_owner.TabIndex = 1
        Me.dp_owner.ThemeName = "Office2013Light"
        CType(Me.dp_owner.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_owner.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Select Implement Owner (Required)"
        CType(Me.dp_owner.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_owner.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_owner.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        '
        'txt_code
        '
        Me.txt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_code.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_code.Location = New System.Drawing.Point(58, 198)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.NullText = "Implement Code Here  (Required)"
        '
        '
        '
        Me.txt_code.RootElement.StretchVertically = True
        Me.txt_code.Size = New System.Drawing.Size(184, 39)
        Me.txt_code.TabIndex = 17
        Me.txt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_code.ThemeName = "Office2013Light"
        '
        'cms_implement
        '
        Me.cms_implement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.refresh, Me.add, Me.modify, Me.remove})
        Me.cms_implement.Name = "cms_addcategory"
        Me.cms_implement.Size = New System.Drawing.Size(179, 92)
        '
        'refresh
        '
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(178, 22)
        Me.refresh.Text = "Refresh Data"
        '
        'add
        '
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(178, 22)
        Me.add.Text = "Add Implement"
        '
        'modify
        '
        Me.modify.Name = "modify"
        Me.modify.Size = New System.Drawing.Size(178, 22)
        Me.modify.Text = "Modify Implement"
        '
        'remove
        '
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(178, 22)
        Me.remove.Text = "Remove Implement"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1314, 44)
        Me.RadPanel1.TabIndex = 14
        Me.RadPanel1.Text = "ALL FARMING IMPLEMENT LIST"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.Black
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancel.Image = Global.AIS_System.My.Resources.Resources.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(176, 494)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(168, 39)
        Me.btn_cancel.TabIndex = 130
        Me.btn_cancel.Text = "Cancel Changes"
        Me.btn_cancel.ThemeName = "Office2013Dark"
        CType(Me.btn_cancel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.AIS_System.My.Resources.Resources.Cancel
        CType(Me.btn_cancel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Cancel Changes"
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackColor = System.Drawing.Color.Black
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_save.Image = Global.AIS_System.My.Resources.Resources.Save
        Me.btn_save.Location = New System.Drawing.Point(5, 494)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(168, 39)
        Me.btn_save.TabIndex = 129
        Me.btn_save.Text = "Save Operation"
        Me.btn_save.ThemeName = "Office2013Dark"
        CType(Me.btn_save.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.AIS_System.My.Resources.Resources.Save
        CType(Me.btn_save.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Save Operation"
        CType(Me.btn_save.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_save.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_save.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_save.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel7
        '
        Me.RadPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Controls.Add(Me.lv_masterimplement)
        Me.RadPanel7.Location = New System.Drawing.Point(5, 52)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(957, 458)
        Me.RadPanel7.TabIndex = 137
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Black
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_search.Image = Global.AIS_System.My.Resources.Resources.Search
        Me.btn_search.Location = New System.Drawing.Point(365, 7)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(41, 39)
        Me.btn_search.TabIndex = 140
        Me.btn_search.ThemeName = "Office2013Dark"
        CType(Me.btn_search.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.AIS_System.My.Resources.Resources.Search
        CType(Me.btn_search.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = ""
        CType(Me.btn_search.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_search.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(3.0!, 0!)
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_search.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_search.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_search.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_search.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_search.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_search.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_search.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_search.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_search.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'mcc_equipments
        '
        Me.mcc_equipments.DropDownMaxSize = New System.Drawing.Size(370, 400)
        Me.mcc_equipments.DropDownMinSize = New System.Drawing.Size(370, 400)
        '
        'mcc_equipments.NestedRadGridView
        '
        Me.mcc_equipments.EditorControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcc_equipments.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcc_equipments.EditorControl.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcc_equipments.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcc_equipments.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcc_equipments.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcc_equipments.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcc_equipments.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcc_equipments.EditorControl.MasterTemplate.AllowColumnReorder = False
        Me.mcc_equipments.EditorControl.MasterTemplate.AllowDeleteRow = False
        Me.mcc_equipments.EditorControl.MasterTemplate.AutoGenerateColumns = False
        Me.mcc_equipments.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcc_equipments.EditorControl.MasterTemplate.ShowColumnHeaders = False
        Me.mcc_equipments.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcc_equipments.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition24
        Me.mcc_equipments.EditorControl.Name = "NestedRadGridView"
        Me.mcc_equipments.EditorControl.ReadOnly = True
        '
        '
        '
        Me.mcc_equipments.EditorControl.RootElement.Enabled = True
        Me.mcc_equipments.EditorControl.ShowGroupPanel = False
        Me.mcc_equipments.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcc_equipments.EditorControl.TabIndex = 0
        Me.mcc_equipments.EditorControl.ThemeName = "VisualStudio2012Dark"
        Me.mcc_equipments.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.mcc_equipments.Location = New System.Drawing.Point(54, 7)
        Me.mcc_equipments.Name = "mcc_equipments"
        Me.mcc_equipments.NullText = "Find Farming Implement (Anything)"
        Me.mcc_equipments.Size = New System.Drawing.Size(311, 39)
        Me.mcc_equipments.TabIndex = 139
        Me.mcc_equipments.TabStop = False
        Me.mcc_equipments.ThemeName = "Office2013Light"
        CType(Me.mcc_equipments.GetChildAt(0), Telerik.WinControls.UI.RadMultiColumnComboBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.ComboBoxEditorLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = ""
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.White
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Find Farming Implement (Anything)"
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadArrowButtonElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadArrowButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.mcc_equipments.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).Enabled = True
        '
        'RadPanel6
        '
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Location = New System.Drawing.Point(5, 7)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel6.TabIndex = 138
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(6, 514)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(324, 18)
        Me.RadLabel3.TabIndex = 141
        Me.RadLabel3.Text = "NOTE:  Mouse Right Click into the list to show more option."
        '
        'RadPanel5
        '
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel5.ForeColor = System.Drawing.Color.White
        Me.RadPanel5.Location = New System.Drawing.Point(3, 7)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(341, 39)
        Me.RadPanel5.TabIndex = 135
        Me.RadPanel5.Text = "Information Needed"
        Me.RadPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Location = New System.Drawing.Point(9, 73)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel3.TabIndex = 136
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Location = New System.Drawing.Point(9, 134)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel2.TabIndex = 137
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Location = New System.Drawing.Point(9, 198)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel4.TabIndex = 138
        '
        'RadPanel8
        '
        Me.RadPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel8.Location = New System.Drawing.Point(9, 260)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel8.TabIndex = 139
        '
        'Frm_masterlist_implements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1314, 583)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.gb_data)
        Me.Controls.Add(Me.gb_menu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Name = "Frm_masterlist_implements"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "AIS: Farming Implement"
        Me.ThemeName = "Office2010Silver"
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.lv_masterimplement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.txt_desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_implelist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_owner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_implement.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel7.ResumeLayout(False)
        CType(Me.btn_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_equipments.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_equipments.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_equipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lv_masterimplement As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_desc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents dp_implelist As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dp_owner As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txt_code As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cms_implement As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents remove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_search As Telerik.WinControls.UI.RadButton
    Friend WithEvents mcc_equipments As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
End Class

