<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_user_control_permission
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
        Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "ID")
        Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "#")
        Dim ListViewDetailColumn3 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Report Title")
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.tv_useraccessmenu = New Telerik.WinControls.UI.RadTreeView()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_searchuser = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_availablereport = New Telerik.WinControls.UI.RadListView()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.c2 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c4 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c3 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.c11 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c9 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c7 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c10 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c8 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c6 = New Telerik.WinControls.UI.RadCheckBox()
        Me.c5 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.CustomShape1 = New Telerik.WinControls.OldShapeEditor.CustomShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_saveaccess = New Telerik.WinControls.UI.RadButton()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.tv_useraccessmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel4.SuspendLayout()
        CType(Me.lv_availablereport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.c11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_saveaccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_data.Controls.Add(Me.RadPanel2)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(2, 108)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(456, 509)
        Me.gb_data.TabIndex = 2
        Me.gb_data.ThemeName = "Office2013Light"
        '
        'RadPanel2
        '
        Me.RadPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel2.Controls.Add(Me.tv_useraccessmenu)
        Me.RadPanel2.Location = New System.Drawing.Point(5, 9)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(446, 498)
        Me.RadPanel2.TabIndex = 0
        '
        'tv_useraccessmenu
        '
        Me.tv_useraccessmenu.AllowPlusMinusAnimation = True
        Me.tv_useraccessmenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tv_useraccessmenu.AutoCheckChildNodes = False
        Me.tv_useraccessmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tv_useraccessmenu.CheckBoxes = True
        Me.tv_useraccessmenu.Font = New System.Drawing.Font("Segoe UI", 7.25!, System.Drawing.FontStyle.Bold)
        Me.tv_useraccessmenu.LineStyle = Telerik.WinControls.UI.TreeLineStyle.DashDot
        Me.tv_useraccessmenu.Location = New System.Drawing.Point(3, 3)
        Me.tv_useraccessmenu.Name = "tv_useraccessmenu"
        Me.tv_useraccessmenu.ShowLines = True
        Me.tv_useraccessmenu.Size = New System.Drawing.Size(440, 492)
        Me.tv_useraccessmenu.SpacingBetweenNodes = -1
        Me.tv_useraccessmenu.TabIndex = 123
        Me.tv_useraccessmenu.Text = "RadTreeView1"
        Me.tv_useraccessmenu.ThemeName = "VisualStudio2012Light"
        Me.tv_useraccessmenu.TriStateMode = True
        CType(Me.tv_useraccessmenu.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).AllowPlusMinusAnimation = True
        CType(Me.tv_useraccessmenu.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).ShowLines = True
        CType(Me.tv_useraccessmenu.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).LineStyle = Telerik.WinControls.UI.TreeLineStyle.DashDot
        CType(Me.tv_useraccessmenu.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).NodeSpacing = -1
        CType(Me.tv_useraccessmenu.GetChildAt(0), Telerik.WinControls.UI.RadTreeViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Controls.Add(Me.PictureBox1)
        Me.RadPanel3.Location = New System.Drawing.Point(7, 69)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel3.TabIndex = 125
        '
        'txt_searchuser
        '
        Me.txt_searchuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_searchuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchuser.Location = New System.Drawing.Point(56, 69)
        Me.txt_searchuser.Name = "txt_searchuser"
        Me.txt_searchuser.NullText = "User Fullname   (System Generated)"
        Me.txt_searchuser.ReadOnly = True
        '
        '
        '
        Me.txt_searchuser.RootElement.StretchVertically = True
        Me.txt_searchuser.Size = New System.Drawing.Size(641, 39)
        Me.txt_searchuser.TabIndex = 122
        Me.txt_searchuser.ThemeName = "Office2013Light"
        CType(Me.txt_searchuser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "User Fullname   (System Generated)"
        CType(Me.txt_searchuser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.txt_searchuser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.txt_searchuser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox2.Controls.Add(Me.btn_saveaccess)
        Me.RadGroupBox2.Controls.Add(Me.RadGroupBox4)
        Me.RadGroupBox2.Controls.Add(Me.RadGroupBox1)
        Me.RadGroupBox2.Controls.Add(Me.RadGroupBox3)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(462, 108)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(235, 507)
        Me.RadGroupBox2.TabIndex = 4
        Me.RadGroupBox2.Tag = "main_group"
        Me.RadGroupBox2.ThemeName = "Office2013Light"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Controls.Add(Me.RadPanel4)
        Me.RadGroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox4.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox4.HeaderText = "Transaction Command"
        Me.RadGroupBox4.Location = New System.Drawing.Point(-2, 271)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(240, 187)
        Me.RadGroupBox4.TabIndex = 126
        Me.RadGroupBox4.Text = "Transaction Command"
        CType(Me.RadGroupBox4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        CType(Me.RadGroupBox4.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadGroupBox4.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadGroupBox4.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'RadPanel4
        '
        Me.RadPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel4.Controls.Add(Me.lv_availablereport)
        Me.RadPanel4.Location = New System.Drawing.Point(3, 19)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(234, 165)
        Me.RadPanel4.TabIndex = 1
        '
        'lv_availablereport
        '
        Me.lv_availablereport.AllowColumnReorder = False
        Me.lv_availablereport.AllowEdit = False
        Me.lv_availablereport.AllowRemove = False
        Me.lv_availablereport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_availablereport.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        ListViewDetailColumn1.HeaderText = "ID"
        ListViewDetailColumn1.Visible = False
        ListViewDetailColumn1.Width = 20.0!
        ListViewDetailColumn2.HeaderText = "#"
        ListViewDetailColumn2.Width = 30.0!
        ListViewDetailColumn3.HeaderText = "Report Title"
        Me.lv_availablereport.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2, ListViewDetailColumn3})
        Me.lv_availablereport.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_availablereport.ForeColor = System.Drawing.Color.Black
        Me.lv_availablereport.ItemSpacing = -1
        Me.lv_availablereport.Location = New System.Drawing.Point(3, 3)
        Me.lv_availablereport.Name = "lv_availablereport"
        Me.lv_availablereport.SelectLastAddedItem = False
        Me.lv_availablereport.ShowGridLines = True
        Me.lv_availablereport.Size = New System.Drawing.Size(228, 159)
        Me.lv_availablereport.TabIndex = 117
        Me.lv_availablereport.ThemeName = "VisualStudio2012Light"
        Me.lv_availablereport.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_availablereport.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.lv_availablereport.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BorderBottomColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        CType(Me.lv_availablereport.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.lv_availablereport.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.DetailListViewElement).BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.lv_availablereport.GetChildAt(0).GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadScrollBarElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.lv_availablereport.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(5), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.lv_availablereport.GetChildAt(0).GetChildAt(0).GetChildAt(4).GetChildAt(5), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.c2)
        Me.RadGroupBox1.Controls.Add(Me.c1)
        Me.RadGroupBox1.Controls.Add(Me.c4)
        Me.RadGroupBox1.Controls.Add(Me.c3)
        Me.RadGroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox1.HeaderText = "Standard Command"
        Me.RadGroupBox1.Location = New System.Drawing.Point(-2, 7)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(240, 79)
        Me.RadGroupBox1.TabIndex = 6
        Me.RadGroupBox1.Tag = "standard"
        Me.RadGroupBox1.Text = "Standard Command"
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'c2
        '
        Me.c2.Enabled = False
        Me.c2.Location = New System.Drawing.Point(13, 48)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(98, 18)
        Me.c2.TabIndex = 4
        Me.c2.Text = "Create Option"
        Me.c2.ThemeName = "Office2013Light"
        '
        'c1
        '
        Me.c1.Enabled = False
        Me.c1.Location = New System.Drawing.Point(13, 28)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(104, 18)
        Me.c1.TabIndex = 3
        Me.c1.Text = "Refresh Option"
        Me.c1.ThemeName = "Office2013Light"
        '
        'c4
        '
        Me.c4.Enabled = False
        Me.c4.Location = New System.Drawing.Point(123, 48)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(106, 18)
        Me.c4.TabIndex = 2
        Me.c4.Text = "Remove Option"
        Me.c4.ThemeName = "Office2013Light"
        '
        'c3
        '
        Me.c3.Enabled = False
        Me.c3.Location = New System.Drawing.Point(123, 28)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(102, 18)
        Me.c3.TabIndex = 1
        Me.c3.Text = "Modify Option"
        Me.c3.ThemeName = "Office2013Light"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.c11)
        Me.RadGroupBox3.Controls.Add(Me.c9)
        Me.RadGroupBox3.Controls.Add(Me.c7)
        Me.RadGroupBox3.Controls.Add(Me.c10)
        Me.RadGroupBox3.Controls.Add(Me.c8)
        Me.RadGroupBox3.Controls.Add(Me.c6)
        Me.RadGroupBox3.Controls.Add(Me.c5)
        Me.RadGroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox3.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox3.HeaderText = "Transaction Command"
        Me.RadGroupBox3.Location = New System.Drawing.Point(-2, 88)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(240, 179)
        Me.RadGroupBox3.TabIndex = 125
        Me.RadGroupBox3.Tag = "transaction"
        Me.RadGroupBox3.Text = "Transaction Command"
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
        CType(Me.RadGroupBox3.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        '
        'c11
        '
        Me.c11.Enabled = False
        Me.c11.Location = New System.Drawing.Point(10, 147)
        Me.c11.Name = "c11"
        Me.c11.Size = New System.Drawing.Size(193, 18)
        Me.c11.TabIndex = 9
        Me.c11.Text = "Confirmation And Print Option"
        Me.c11.ThemeName = "Office2013Light"
        '
        'c9
        '
        Me.c9.Enabled = False
        Me.c9.Location = New System.Drawing.Point(10, 106)
        Me.c9.Name = "c9"
        Me.c9.Size = New System.Drawing.Size(234, 18)
        Me.c9.TabIndex = 6
        Me.c9.Text = "Review Encoded Accomplished Option"
        Me.c9.ThemeName = "Office2013Light"
        '
        'c7
        '
        Me.c7.Enabled = False
        Me.c7.Location = New System.Drawing.Point(10, 67)
        Me.c7.Name = "c7"
        Me.c7.Size = New System.Drawing.Size(157, 18)
        Me.c7.TabIndex = 8
        Me.c7.Text = "Review Approval Option"
        Me.c7.ThemeName = "Office2013Light"
        '
        'c10
        '
        Me.c10.Enabled = False
        Me.c10.Location = New System.Drawing.Point(10, 127)
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(184, 18)
        Me.c10.TabIndex = 7
        Me.c10.Text = "Review Accomplished Option"
        Me.c10.ThemeName = "Office2013Light"
        '
        'c8
        '
        Me.c8.Enabled = False
        Me.c8.Location = New System.Drawing.Point(10, 86)
        Me.c8.Name = "c8"
        Me.c8.Size = New System.Drawing.Size(199, 18)
        Me.c8.TabIndex = 4
        Me.c8.Text = "Encode Accomplishment Option"
        Me.c8.ThemeName = "Office2013Light"
        '
        'c6
        '
        Me.c6.Enabled = False
        Me.c6.Location = New System.Drawing.Point(10, 48)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(134, 18)
        Me.c6.TabIndex = 5
        Me.c6.Text = "Disapproved Option"
        Me.c6.ThemeName = "Office2013Light"
        '
        'c5
        '
        Me.c5.Enabled = False
        Me.c5.Location = New System.Drawing.Point(10, 28)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(117, 18)
        Me.c5.TabIndex = 3
        Me.c5.Text = "Cancelled Option"
        Me.c5.ThemeName = "Office2013Light"
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(700, 63)
        Me.RadPanel1.TabIndex = 5
        Me.RadPanel1.Text = "USER ACCESS LIST"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CustomShape1
        '
        Me.CustomShape1.Dimension = New System.Drawing.Rectangle(0, 0, 0, 0)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.AIS_System.My.Resources.Resources.Reviewer_Male
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_saveaccess
        '
        Me.btn_saveaccess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_saveaccess.BackColor = System.Drawing.Color.Black
        Me.btn_saveaccess.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_saveaccess.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_saveaccess.Image = Global.AIS_System.My.Resources.Resources.Save
        Me.btn_saveaccess.Location = New System.Drawing.Point(2, 466)
        Me.btn_saveaccess.Name = "btn_saveaccess"
        Me.btn_saveaccess.Size = New System.Drawing.Size(233, 39)
        Me.btn_saveaccess.TabIndex = 124
        Me.btn_saveaccess.Text = "Save User Access"
        Me.btn_saveaccess.ThemeName = "Office2013Dark"
        CType(Me.btn_saveaccess.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Global.AIS_System.My.Resources.Resources.Save
        CType(Me.btn_saveaccess.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Save User Access"
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_saveaccess.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'Frm_user_control_permission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 618)
        Me.Controls.Add(Me.RadPanel3)
        Me.Controls.Add(Me.txt_searchuser)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.gb_data)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_user_control_permission"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: User Account Window"
        Me.ThemeName = "Office2010Silver"
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.tv_useraccessmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel4.ResumeLayout(False)
        CType(Me.lv_availablereport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.c2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.c11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_saveaccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_searchuser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents tv_useraccessmenu As Telerik.WinControls.UI.RadTreeView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_saveaccess As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents c4 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c3 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c9 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c8 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c6 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c5 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c11 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c7 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c10 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CustomShape1 As Telerik.WinControls.OldShapeEditor.CustomShape
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lv_availablereport As Telerik.WinControls.UI.RadListView
    Friend WithEvents c2 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents c1 As Telerik.WinControls.UI.RadCheckBox
End Class

