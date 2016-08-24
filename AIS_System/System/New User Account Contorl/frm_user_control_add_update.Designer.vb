<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_user_control_add_update
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
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_username = New Telerik.WinControls.UI.RadTextBox()
        Me.dp_usertype = New Telerik.WinControls.UI.RadDropDownList()
        Me.txt_lname = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_mname = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_fname = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_confirm_pass = New Telerik.WinControls.UI.RadTextBox()
        Me.txt_password = New Telerik.WinControls.UI.RadTextBox()
        Me.btn_saveuser = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.object_a9afc368_fddb_44bf_98c3_c83652c6977d = New Telerik.WinControls.RootRadElement()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_usertype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_confirm_pass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_saveuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_menu.Controls.Add(Me.RadButton1)
        Me.gb_menu.Controls.Add(Me.txt_username)
        Me.gb_menu.Controls.Add(Me.dp_usertype)
        Me.gb_menu.Controls.Add(Me.txt_lname)
        Me.gb_menu.Controls.Add(Me.txt_mname)
        Me.gb_menu.Controls.Add(Me.txt_fname)
        Me.gb_menu.Controls.Add(Me.txt_confirm_pass)
        Me.gb_menu.Controls.Add(Me.txt_password)
        Me.gb_menu.Controls.Add(Me.btn_saveuser)
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(0, 54)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(336, 432)
        Me.gb_menu.TabIndex = 2
        Me.gb_menu.ThemeName = "Office2013Light"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(88, 21)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.NullText = "<User Name Here>"
        '
        '
        '
        Me.txt_username.RootElement.StretchVertically = True
        Me.txt_username.Size = New System.Drawing.Size(233, 38)
        Me.txt_username.TabIndex = 141
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_username.ThemeName = "Office2013Light"
        '
        'dp_usertype
        '
        Me.dp_usertype.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_usertype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_usertype.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.dp_usertype.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        RadListDataItem1.Enabled = False
        RadListDataItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem1.Text = "SYSTEM DMINISTRATOR"
        RadListDataItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem2.Text = "ADMINISTRATOR"
        RadListDataItem2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem3.Text = "MANAGER"
        RadListDataItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem4.Text = "FINANCE"
        RadListDataItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem5.Text = "FARM MANAGER"
        RadListDataItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem6.Text = "FARM SUPERVISOR"
        RadListDataItem6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        RadListDataItem7.Text = "BASIC USER"
        RadListDataItem7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.dp_usertype.Items.Add(RadListDataItem1)
        Me.dp_usertype.Items.Add(RadListDataItem2)
        Me.dp_usertype.Items.Add(RadListDataItem3)
        Me.dp_usertype.Items.Add(RadListDataItem4)
        Me.dp_usertype.Items.Add(RadListDataItem5)
        Me.dp_usertype.Items.Add(RadListDataItem6)
        Me.dp_usertype.Items.Add(RadListDataItem7)
        Me.dp_usertype.Location = New System.Drawing.Point(88, 285)
        Me.dp_usertype.Name = "dp_usertype"
        Me.dp_usertype.NullText = "<Required>"
        '
        '
        '
        Me.dp_usertype.RootElement.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.dp_usertype.RootElement.StretchVertically = True
        Me.dp_usertype.Size = New System.Drawing.Size(233, 38)
        Me.dp_usertype.TabIndex = 139
        Me.dp_usertype.ThemeName = "Office2013Light"
        CType(Me.dp_usertype.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        CType(Me.dp_usertype.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadDropDownListEditableAreaElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "<Required>"
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(0), Telerik.WinControls.Primitives.BorderPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(2), Telerik.WinControls.UI.StackLayoutElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadDropDownListEditableAreaElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = True
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.dp_usertype.GetChildAt(0).GetChildAt(3).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(88, 241)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.NullText = "<Last Name Here>"
        '
        '
        '
        Me.txt_lname.RootElement.StretchVertically = True
        Me.txt_lname.Size = New System.Drawing.Size(233, 38)
        Me.txt_lname.TabIndex = 136
        Me.txt_lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_lname.ThemeName = "Office2013Light"
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(88, 197)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.NullText = "<Middle Name Here>"
        '
        '
        '
        Me.txt_mname.RootElement.StretchVertically = True
        Me.txt_mname.Size = New System.Drawing.Size(233, 38)
        Me.txt_mname.TabIndex = 134
        Me.txt_mname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_mname.ThemeName = "Office2013Light"
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(88, 153)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.NullText = "<First Name Here>"
        '
        '
        '
        Me.txt_fname.RootElement.StretchVertically = True
        Me.txt_fname.Size = New System.Drawing.Size(233, 38)
        Me.txt_fname.TabIndex = 132
        Me.txt_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_fname.ThemeName = "Office2013Light"
        '
        'txt_confirm_pass
        '
        Me.txt_confirm_pass.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_confirm_pass.Location = New System.Drawing.Point(88, 109)
        Me.txt_confirm_pass.Name = "txt_confirm_pass"
        Me.txt_confirm_pass.NullText = "<Confirm Password Here>"
        '
        '
        '
        Me.txt_confirm_pass.RootElement.StretchVertically = True
        Me.txt_confirm_pass.Size = New System.Drawing.Size(233, 38)
        Me.txt_confirm_pass.TabIndex = 130
        Me.txt_confirm_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_confirm_pass.ThemeName = "Office2013Light"
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(88, 65)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.NullText = "<New Password Here>"
        '
        '
        '
        Me.txt_password.RootElement.StretchVertically = True
        Me.txt_password.Size = New System.Drawing.Size(233, 38)
        Me.txt_password.TabIndex = 128
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.ThemeName = "Office2013Light"
        '
        'btn_saveuser
        '
        Me.btn_saveuser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_saveuser.BackColor = System.Drawing.Color.Black
        Me.btn_saveuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_saveuser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_saveuser.Location = New System.Drawing.Point(5, 336)
        Me.btn_saveuser.Name = "btn_saveuser"
        Me.btn_saveuser.Size = New System.Drawing.Size(327, 45)
        Me.btn_saveuser.TabIndex = 123
        Me.btn_saveuser.Text = "Save User"
        Me.btn_saveuser.ThemeName = "Office2013Dark"
        CType(Me.btn_saveuser.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Save User"
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.OuterInnerBorders
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_saveuser.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(336, 54)
        Me.RadPanel1.TabIndex = 141
        Me.RadPanel1.Text = "USER MAINTENANCE CONTROL"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.RadPanel1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'object_a9afc368_fddb_44bf_98c3_c83652c6977d
        '
        Me.object_a9afc368_fddb_44bf_98c3_c83652c6977d.Name = "object_a9afc368_fddb_44bf_98c3_c83652c6977d"
        Me.object_a9afc368_fddb_44bf_98c3_c83652c6977d.StretchHorizontally = True
        Me.object_a9afc368_fddb_44bf_98c3_c83652c6977d.StretchVertically = True
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(5, 382)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(327, 45)
        Me.RadButton1.TabIndex = 142
        Me.RadButton1.Text = "RadButton1"
        Me.RadButton1.ThemeName = "Office2013Dark"
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.RadButton1.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        '
        'Frm_user_control_add_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(336, 486)
        Me.Controls.Add(Me.RadPanel1)
        Me.Controls.Add(Me.gb_menu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_user_control_add_update"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: User Window"
        Me.ThemeName = "Office2010Silver"
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.txt_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_usertype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_confirm_pass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_saveuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dp_usertype As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents txt_lname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_mname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_fname As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_confirm_pass As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents txt_password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btn_saveuser As Telerik.WinControls.UI.RadButton
    Friend WithEvents object_a9afc368_fddb_44bf_98c3_c83652c6977d As Telerik.WinControls.RootRadElement
    Friend WithEvents txt_username As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

