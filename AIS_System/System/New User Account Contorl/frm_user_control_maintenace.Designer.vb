<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_user_control_maintenace
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
        Me.mcc_findaccount = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_useraccountlist = New Telerik.WinControls.UI.RadListView()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.cms_usermenu = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refreshuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.assignedpermissionuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.btn_search = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.mcc_findaccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_findaccount.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mcc_findaccount.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.lv_useraccountlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_data.Controls.Add(Me.btn_search)
        Me.gb_data.Controls.Add(Me.mcc_findaccount)
        Me.gb_data.Controls.Add(Me.RadPanel3)
        Me.gb_data.Controls.Add(Me.RadPanel2)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(-1, 62)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(801, 552)
        Me.gb_data.TabIndex = 1
        Me.gb_data.ThemeName = "Office2013Light"
        '
        'mcc_findaccount
        '
        Me.mcc_findaccount.DropDownMaxSize = New System.Drawing.Size(370, 400)
        Me.mcc_findaccount.DropDownMinSize = New System.Drawing.Size(370, 400)
        '
        'mcc_findaccount.NestedRadGridView
        '
        Me.mcc_findaccount.EditorControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcc_findaccount.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.mcc_findaccount.EditorControl.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcc_findaccount.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mcc_findaccount.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.mcc_findaccount.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.AllowColumnReorder = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.AllowDeleteRow = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.AutoGenerateColumns = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.EnableGrouping = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.ShowColumnHeaders = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.mcc_findaccount.EditorControl.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.mcc_findaccount.EditorControl.Name = "NestedRadGridView"
        Me.mcc_findaccount.EditorControl.ReadOnly = True
        '
        '
        '
        Me.mcc_findaccount.EditorControl.RootElement.Enabled = True
        Me.mcc_findaccount.EditorControl.ShowGroupPanel = False
        Me.mcc_findaccount.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.mcc_findaccount.EditorControl.TabIndex = 0
        Me.mcc_findaccount.EditorControl.ThemeName = "VisualStudio2012Dark"
        Me.mcc_findaccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.mcc_findaccount.Location = New System.Drawing.Point(56, 12)
        Me.mcc_findaccount.Name = "mcc_findaccount"
        Me.mcc_findaccount.NullText = "Find User Account   (Username or Fullname) "
        Me.mcc_findaccount.Size = New System.Drawing.Size(311, 39)
        Me.mcc_findaccount.TabIndex = 126
        Me.mcc_findaccount.TabStop = False
        Me.mcc_findaccount.ThemeName = "Office2013Light"
        CType(Me.mcc_findaccount.GetChildAt(0), Telerik.WinControls.UI.RadMultiColumnComboBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.ComboBoxEditorLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = ""
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).BackColor = System.Drawing.Color.White
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Find User Account   (Username or Fullname) "
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleLeft
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadArrowButtonElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadArrowButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.mcc_findaccount.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).Enabled = True
        '
        'RadPanel3
        '
        Me.RadPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel3.Controls.Add(Me.lv_useraccountlist)
        Me.RadPanel3.Location = New System.Drawing.Point(5, 58)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(791, 489)
        Me.RadPanel3.TabIndex = 0
        '
        'lv_useraccountlist
        '
        Me.lv_useraccountlist.AllowColumnReorder = False
        Me.lv_useraccountlist.AllowEdit = False
        Me.lv_useraccountlist.AllowRemove = False
        Me.lv_useraccountlist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_useraccountlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lv_useraccountlist.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_useraccountlist.ForeColor = System.Drawing.Color.Black
        Me.lv_useraccountlist.ItemSpacing = -1
        Me.lv_useraccountlist.Location = New System.Drawing.Point(3, 3)
        Me.lv_useraccountlist.Name = "lv_useraccountlist"
        Me.lv_useraccountlist.SelectLastAddedItem = False
        Me.lv_useraccountlist.ShowGridLines = True
        Me.lv_useraccountlist.Size = New System.Drawing.Size(785, 483)
        Me.lv_useraccountlist.TabIndex = 117
        Me.lv_useraccountlist.ThemeName = "VisualStudio2012Light"
        Me.lv_useraccountlist.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_useraccountlist.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.lv_useraccountlist.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.lv_useraccountlist.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.lv_useraccountlist.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.DetailListViewElement).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.lv_useraccountlist.GetChildAt(0).GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadScrollBarElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        CType(Me.lv_useraccountlist.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(5), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.lv_useraccountlist.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(5), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel2.Controls.Add(Me.PictureBox1)
        Me.RadPanel2.Location = New System.Drawing.Point(7, 12)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel2.TabIndex = 123
        '
        'cms_usermenu
        '
        Me.cms_usermenu.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refreshuser, Me.RadMenuSeparatorItem1, Me.assignedpermissionuser})
        Me.cms_usermenu.ThemeName = "Office2013Light"
        '
        'refreshuser
        '
        Me.refreshuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshuser.Name = "refreshuser"
        Me.refreshuser.Text = "Refresh Data"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'assignedpermissionuser
        '
        Me.assignedpermissionuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assignedpermissionuser.Name = "assignedpermissionuser"
        Me.assignedpermissionuser.Text = "User Assigned Permission"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(798, 62)
        Me.RadPanel1.TabIndex = 2
        Me.RadPanel1.Text = "USER ACCOUNT LIST"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.BackColor = System.Drawing.Color.Black
        Me.btn_search.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_search.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_search.Image = Global.AIS_System.My.Resources.Resources.Search
        Me.btn_search.Location = New System.Drawing.Point(367, 12)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(41, 39)
        Me.btn_search.TabIndex = 128
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AIS_System.My.Resources.Resources.Find_User_Male
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox1.TabIndex = 124
        Me.PictureBox1.TabStop = False
        '
        'Frm_user_control_maintenace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 613)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.gb_data)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_user_control_maintenace"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: User Account Window"
        Me.ThemeName = "Office2010Silver"
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        CType(Me.mcc_findaccount.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_findaccount.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mcc_findaccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.lv_useraccountlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_useraccountlist As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents cms_usermenu As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refreshuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents assignedpermissionuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_saveaccess As Telerik.WinControls.UI.RadButton
    Friend WithEvents mcc_findaccount As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents btn_search As Telerik.WinControls.UI.RadButton
End Class

