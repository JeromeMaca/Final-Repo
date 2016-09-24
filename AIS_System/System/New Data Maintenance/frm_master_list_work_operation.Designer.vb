<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_master_list_work_operation
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
        Me.components = New System.ComponentModel.Container()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_masteriworkoperation = New Telerik.WinControls.UI.RadListView()
        Me.btn_search = New Telerik.WinControls.UI.RadButton()
        Me.mcc_workoperation = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_workoperation = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_unitmeasure = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.dp_operationcategory = New Telerik.WinControls.UI.RadDropDownList()
        Me.txt_ratecost = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.cms_workoperation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.refresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.add = New System.Windows.Forms.ToolStripMenuItem()
        Me.modify = New System.Windows.Forms.ToolStripMenuItem()
        Me.remove = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.object_7b872dcd_e2a3_4d82_bd3c_9289c4e87357 = New Telerik.WinControls.RootRadElement()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel7.SuspendLayout()
        CType(Me.lv_masteriworkoperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_workoperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_workoperation.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_workoperation.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_workoperation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_unitmeasure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_operationcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ratecost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms_workoperation.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.Controls.Add(Me.RadLabel1)
        Me.gb_data.Controls.Add(Me.RadPanel7)
        Me.gb_data.Controls.Add(Me.btn_search)
        Me.gb_data.Controls.Add(Me.mcc_workoperation)
        Me.gb_data.Controls.Add(Me.RadPanel6)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(332, 45)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(922, 567)
        Me.gb_data.TabIndex = 11
        Me.gb_data.ThemeName = "Office2013Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(5, 543)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(324, 18)
        Me.RadLabel1.TabIndex = 133
        Me.RadLabel1.Text = "NOTE:  Mouse Right Click into the list to show more option."
        '
        'RadPanel7
        '
        Me.RadPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel7.Controls.Add(Me.lv_masteriworkoperation)
        Me.RadPanel7.Location = New System.Drawing.Point(5, 50)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(912, 490)
        Me.RadPanel7.TabIndex = 132
        Me.RadPanel7.Text = "RadPanel7"
        '
        'lv_masteriworkoperation
        '
        Me.lv_masteriworkoperation.AllowColumnReorder = False
        Me.lv_masteriworkoperation.AllowEdit = False
        Me.lv_masteriworkoperation.AllowRemove = False
        Me.lv_masteriworkoperation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_masteriworkoperation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lv_masteriworkoperation.EnableGrouping = True
        Me.lv_masteriworkoperation.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_masteriworkoperation.ForeColor = System.Drawing.Color.Black
        Me.lv_masteriworkoperation.HeaderHeight = 40.0!
        Me.lv_masteriworkoperation.HotTracking = False
        Me.lv_masteriworkoperation.ItemSpacing = -1
        Me.lv_masteriworkoperation.Location = New System.Drawing.Point(2, 2)
        Me.lv_masteriworkoperation.Name = "lv_masteriworkoperation"
        Me.lv_masteriworkoperation.SelectLastAddedItem = False
        Me.lv_masteriworkoperation.ShowGroups = True
        Me.lv_masteriworkoperation.Size = New System.Drawing.Size(908, 486)
        Me.lv_masteriworkoperation.TabIndex = 30
        Me.lv_masteriworkoperation.TabStop = False
        Me.lv_masteriworkoperation.Text = "RadListView1"
        Me.lv_masteriworkoperation.ThemeName = "VisualStudio2012Light"
        Me.lv_masteriworkoperation.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_masteriworkoperation.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.White
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Black
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_search.Image = Global.AIS_System.My.Resources.Resources.Search
        Me.btn_search.Location = New System.Drawing.Point(365, 5)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(41, 39)
        Me.btn_search.TabIndex = 131
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
        'mcc_workoperation
        '
        Me.mcc_workoperation.DropDownMaxSize = New System.Drawing.Size(370, 400)
        Me.mcc_workoperation.DropDownMinSize = New System.Drawing.Size(370, 400)
        '
        'mcc_workoperation.NestedRadGridView
        '
        Me.mcc_workoperation.EditorControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcc_workoperation.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcc_workoperation.EditorControl.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcc_workoperation.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcc_workoperation.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcc_workoperation.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.AllowColumnReorder = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.AllowDeleteRow = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.AutoGenerateColumns = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.ShowColumnHeaders = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcc_workoperation.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcc_workoperation.EditorControl.Name = "NestedRadGridView"
        Me.mcc_workoperation.EditorControl.ReadOnly = True
        '
        '
        '
        Me.mcc_workoperation.EditorControl.RootElement.Enabled = True
        Me.mcc_workoperation.EditorControl.ShowGroupPanel = False
        Me.mcc_workoperation.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcc_workoperation.EditorControl.TabIndex = 0
        Me.mcc_workoperation.EditorControl.ThemeName = "VisualStudio2012Dark"
        Me.mcc_workoperation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.mcc_workoperation.Location = New System.Drawing.Point(54, 5)
        Me.mcc_workoperation.Name = "mcc_workoperation"
        Me.mcc_workoperation.NullText = "Find Work Operation  (Anything)"
        Me.mcc_workoperation.Size = New System.Drawing.Size(311, 39)
        Me.mcc_workoperation.TabIndex = 130
        Me.mcc_workoperation.TabStop = False
        Me.mcc_workoperation.ThemeName = "Office2013Light"
        CType(Me.mcc_workoperation.GetChildAt(0), Telerik.WinControls.UI.RadMultiColumnComboBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.ComboBoxEditorLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = ""
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.White
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Find Work Operation  (Anything)"
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadArrowButtonElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadArrowButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.mcc_workoperation.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).Enabled = True
        '
        'RadPanel6
        '
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Location = New System.Drawing.Point(5, 5)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel6.TabIndex = 129
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.Controls.Add(Me.RadPanel9)
        Me.gb_menu.Controls.Add(Me.RadPanel8)
        Me.gb_menu.Controls.Add(Me.RadPanel5)
        Me.gb_menu.Controls.Add(Me.txt_workoperation)
        Me.gb_menu.Controls.Add(Me.RadPanel4)
        Me.gb_menu.Controls.Add(Me.txt_unitmeasure)
        Me.gb_menu.Controls.Add(Me.RadPanel3)
        Me.gb_menu.Controls.Add(Me.RadPanel2)
        Me.gb_menu.Controls.Add(Me.btn_cancel)
        Me.gb_menu.Controls.Add(Me.btn_save)
        Me.gb_menu.Controls.Add(Me.dp_operationcategory)
        Me.gb_menu.Controls.Add(Me.txt_ratecost)
        Me.gb_menu.Enabled = False
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(3, 45)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(323, 567)
        Me.gb_menu.TabIndex = 10
        Me.gb_menu.ThemeName = "Office2013Light"
        '
        'RadPanel9
        '
        Me.RadPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel9.ForeColor = System.Drawing.Color.White
        Me.RadPanel9.Location = New System.Drawing.Point(193, 249)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(116, 39)
        Me.RadPanel9.TabIndex = 134
        Me.RadPanel9.Text = "Rate Cost  (Required)"
        '
        'RadPanel8
        '
        Me.RadPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel8.Location = New System.Drawing.Point(12, 249)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel8.TabIndex = 133
        '
        'RadPanel5
        '
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel5.ForeColor = System.Drawing.Color.White
        Me.RadPanel5.Location = New System.Drawing.Point(0, 5)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(323, 39)
        Me.RadPanel5.TabIndex = 132
        Me.RadPanel5.Text = "Information Needed"
        Me.RadPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_workoperation
        '
        Me.txt_workoperation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_workoperation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_workoperation.Location = New System.Drawing.Point(61, 129)
        Me.txt_workoperation.Name = "txt_workoperation"
        Me.txt_workoperation.NullText = "Work Operation Here  (Required)"
        Me.txt_workoperation.ReadOnly = True
        '
        '
        '
        Me.txt_workoperation.RootElement.StretchVertically = True
        Me.txt_workoperation.Size = New System.Drawing.Size(248, 39)
        Me.txt_workoperation.TabIndex = 131
        Me.txt_workoperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_workoperation.ThemeName = "Office2013Light"
        CType(Me.txt_workoperation.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Work Operation Here  (Required)"
        CType(Me.txt_workoperation.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.txt_workoperation.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.txt_workoperation.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Location = New System.Drawing.Point(12, 190)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel4.TabIndex = 130
        '
        'txt_unitmeasure
        '
        Me.txt_unitmeasure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_unitmeasure.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unitmeasure.Location = New System.Drawing.Point(61, 190)
        Me.txt_unitmeasure.Name = "txt_unitmeasure"
        Me.txt_unitmeasure.NullText = "Unit Measure  (Required)"
        Me.txt_unitmeasure.ReadOnly = True
        '
        '
        '
        Me.txt_unitmeasure.RootElement.StretchVertically = True
        Me.txt_unitmeasure.Size = New System.Drawing.Size(248, 39)
        Me.txt_unitmeasure.TabIndex = 129
        Me.txt_unitmeasure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_unitmeasure.ThemeName = "Office2013Light"
        CType(Me.txt_unitmeasure.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Unit Measure  (Required)"
        CType(Me.txt_unitmeasure.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.txt_unitmeasure.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.txt_unitmeasure.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Location = New System.Drawing.Point(12, 129)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel3.TabIndex = 128
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Location = New System.Drawing.Point(12, 69)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel2.TabIndex = 127
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.Black
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancel.Image = Global.AIS_System.My.Resources.Resources.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(165, 522)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(153, 39)
        Me.btn_cancel.TabIndex = 126
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
        Me.btn_save.Location = New System.Drawing.Point(6, 522)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(153, 39)
        Me.btn_save.TabIndex = 125
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
        'dp_operationcategory
        '
        Me.dp_operationcategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_operationcategory.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp_operationcategory.Location = New System.Drawing.Point(61, 69)
        Me.dp_operationcategory.Name = "dp_operationcategory"
        Me.dp_operationcategory.NullText = "Select Operation Category  (Required)"
        '
        '
        '
        Me.dp_operationcategory.RootElement.StretchVertically = True
        Me.dp_operationcategory.Size = New System.Drawing.Size(248, 39)
        Me.dp_operationcategory.TabIndex = 31
        Me.dp_operationcategory.ThemeName = "Office2013Light"
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Select Operation Category  (Required)"
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).StretchHorizontally = False
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).StretchVertically = False
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Image = Nothing
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.dp_operationcategory.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txt_ratecost
        '
        Me.txt_ratecost.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ratecost.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ratecost.Location = New System.Drawing.Point(61, 249)
        Me.txt_ratecost.Name = "txt_ratecost"
        Me.txt_ratecost.NullText = "Rate Cost (Required)"
        '
        '
        '
        Me.txt_ratecost.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        Me.txt_ratecost.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        Me.txt_ratecost.RootElement.StretchVertically = True
        Me.txt_ratecost.Size = New System.Drawing.Size(132, 39)
        Me.txt_ratecost.TabIndex = 43
        Me.txt_ratecost.Text = "0"
        Me.txt_ratecost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_ratecost.ThemeName = "Office2013Light"
        CType(Me.txt_ratecost.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "0"
        CType(Me.txt_ratecost.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Rate Cost (Required)"
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).MinSize = New System.Drawing.Size(0, 0)
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.txt_ratecost.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).StretchVertically = True
        '
        'cms_workoperation
        '
        Me.cms_workoperation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.refresh, Me.add, Me.modify, Me.remove})
        Me.cms_workoperation.Name = "cms_addcategory"
        Me.cms_workoperation.Size = New System.Drawing.Size(174, 92)
        '
        'refresh
        '
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(173, 22)
        Me.refresh.Text = "Refresh Data"
        '
        'add
        '
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(173, 22)
        Me.add.Text = "Add Operation"
        '
        'modify
        '
        Me.modify.Name = "modify"
        Me.modify.Size = New System.Drawing.Size(173, 22)
        Me.modify.Text = "Modify Operation"
        '
        'remove
        '
        Me.remove.Name = "remove"
        Me.remove.Size = New System.Drawing.Size(173, 22)
        Me.remove.Text = "Remove Operation"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1256, 44)
        Me.RadPanel1.TabIndex = 12
        Me.RadPanel1.Text = "ALL FARMING OPERATION LIST"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'object_7b872dcd_e2a3_4d82_bd3c_9289c4e87357
        '
        Me.object_7b872dcd_e2a3_4d82_bd3c_9289c4e87357.Name = "object_7b872dcd_e2a3_4d82_bd3c_9289c4e87357"
        Me.object_7b872dcd_e2a3_4d82_bd3c_9289c4e87357.StretchHorizontally = True
        Me.object_7b872dcd_e2a3_4d82_bd3c_9289c4e87357.StretchVertically = True
        '
        'Frm_master_list_work_operation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 614)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.gb_data)
        Me.Controls.Add(Me.gb_menu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Name = "Frm_master_list_work_operation"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "AIS: Farming Operation"
        Me.ThemeName = "Office2010Silver"
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel7.ResumeLayout(False)
        CType(Me.lv_masteriworkoperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_workoperation.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_workoperation.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_workoperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_workoperation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_unitmeasure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_operationcategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ratecost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms_workoperation.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lv_masteriworkoperation As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents dp_operationcategory As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txt_ratecost As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents cms_workoperation As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents refresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents add As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents modify As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents remove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents object_7b872dcd_e2a3_4d82_bd3c_9289c4e87357 As Telerik.WinControls.RootRadElement
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_unitmeasure As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_workoperation As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_search As Telerik.WinControls.UI.RadButton
    Friend WithEvents mcc_workoperation As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class

