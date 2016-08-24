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
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_useraccountlist = New Telerik.WinControls.UI.RadListView()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_searchuser = New Telerik.WinControls.UI.RadTextBox()
        Me.cms_usermenu = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refreshuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.assignedpermissionuser = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.lv_useraccountlist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gb_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_data.Controls.Add(Me.RadPanel3)
        Me.gb_data.Controls.Add(Me.RadPanel2)
        Me.gb_data.Controls.Add(Me.txt_searchuser)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(-1, 62)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(801, 552)
        Me.gb_data.TabIndex = 1
        Me.gb_data.ThemeName = "Office2013Light"
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
        'txt_searchuser
        '
        Me.txt_searchuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchuser.Location = New System.Drawing.Point(56, 12)
        Me.txt_searchuser.Name = "txt_searchuser"
        Me.txt_searchuser.NullText = "Find User Account   (Username or Fullname) "
        '
        '
        '
        Me.txt_searchuser.RootElement.StretchVertically = True
        Me.txt_searchuser.Size = New System.Drawing.Size(352, 39)
        Me.txt_searchuser.TabIndex = 122
        '
        'cms_usermenu
        '
        Me.cms_usermenu.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refreshuser, Me.RadMenuSeparatorItem1, Me.assignedpermissionuser})
        Me.cms_usermenu.ThemeName = "Office2013Light"
        '
        'refreshuser
        '
        Me.refreshuser.Name = "refreshuser"
        Me.refreshuser.Text = "Refresh Data"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'assignedpermissionuser
        '
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
        Me.gb_data.PerformLayout()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.lv_useraccountlist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_searchuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lv_useraccountlist As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_searchuser As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents cms_usermenu As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refreshuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents assignedpermissionuser As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
End Class

