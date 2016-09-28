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
        Me.gb_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_cancel = New Telerik.WinControls.UI.RadButton()
        Me.btn_save = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel9 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel8 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_totalamount = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadPanel29 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel4 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_operation_performed = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel28 = New Telerik.WinControls.UI.RadPanel()
        Me.se_area_finish = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadPanel10 = New Telerik.WinControls.UI.RadPanel()
        Me.txt_lotno = New Telerik.WinControls.UI.RadTextBox()
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_for_posting = New Telerik.WinControls.UI.RadListView()
        Me.btn_process_all = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel31 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        Me.lv_posting = New Telerik.WinControls.UI.RadListView()
        Me.btn_update = New Telerik.WinControls.UI.RadButton()
        Me.txt_grandtotal = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel5 = New Telerik.WinControls.UI.RadPanel()
        Me.gb_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.object_88b57ef6_c361_44ff_b0db_992eab9474c3 = New Telerik.WinControls.RootRadElement()
        Me.cms_check_uncheck = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refresh = New Telerik.WinControls.UI.RadMenuItem()
        Me.sep_1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.check_all = New Telerik.WinControls.UI.RadMenuItem()
        Me.uncheck_all = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_menu.SuspendLayout()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_totalamount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_operation_performed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.se_area_finish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lotno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel7.SuspendLayout()
        CType(Me.lv_for_posting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel3.SuspendLayout()
        CType(Me.lv_posting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_grandtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_data.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_menu
        '
        Me.gb_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_menu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_menu.Controls.Add(Me.btn_cancel)
        Me.gb_menu.Controls.Add(Me.btn_save)
        Me.gb_menu.Controls.Add(Me.RadPanel9)
        Me.gb_menu.Controls.Add(Me.RadPanel8)
        Me.gb_menu.Controls.Add(Me.txt_totalamount)
        Me.gb_menu.Controls.Add(Me.RadPanel29)
        Me.gb_menu.Controls.Add(Me.RadPanel4)
        Me.gb_menu.Controls.Add(Me.txt_operation_performed)
        Me.gb_menu.Controls.Add(Me.RadPanel28)
        Me.gb_menu.Controls.Add(Me.se_area_finish)
        Me.gb_menu.Controls.Add(Me.RadPanel10)
        Me.gb_menu.Controls.Add(Me.txt_lotno)
        Me.gb_menu.Enabled = False
        Me.gb_menu.HeaderText = ""
        Me.gb_menu.Location = New System.Drawing.Point(340, 473)
        Me.gb_menu.Name = "gb_menu"
        Me.gb_menu.Size = New System.Drawing.Size(890, 100)
        Me.gb_menu.TabIndex = 120
        Me.gb_menu.ThemeName = "Office2013Light"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.BackColor = System.Drawing.Color.Black
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_cancel.Location = New System.Drawing.Point(640, 54)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(245, 39)
        Me.btn_cancel.TabIndex = 182
        Me.btn_cancel.Text = "CANCEL CHANGES"
        Me.btn_cancel.ThemeName = "Office2013Dark"
        CType(Me.btn_cancel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_cancel.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "CANCEL CHANGES"
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
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_cancel.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_save.Location = New System.Drawing.Point(640, 9)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(245, 39)
        Me.btn_save.TabIndex = 181
        Me.btn_save.Text = "SAVE CHANGES"
        Me.btn_save.ThemeName = "Office2013Dark"
        CType(Me.btn_save.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_save.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "SAVE CHANGES"
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
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_save.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_save.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_save.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel9
        '
        Me.RadPanel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel9.ForeColor = System.Drawing.Color.White
        Me.RadPanel9.Location = New System.Drawing.Point(481, 54)
        Me.RadPanel9.Name = "RadPanel9"
        Me.RadPanel9.Size = New System.Drawing.Size(94, 39)
        Me.RadPanel9.TabIndex = 180
        Me.RadPanel9.Text = "Rate Cost "
        Me.RadPanel9.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel8
        '
        Me.RadPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel8.Location = New System.Drawing.Point(319, 54)
        Me.RadPanel8.Name = "RadPanel8"
        Me.RadPanel8.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel8.TabIndex = 179
        '
        'txt_totalamount
        '
        Me.txt_totalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_totalamount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totalamount.Location = New System.Drawing.Point(368, 54)
        Me.txt_totalamount.Name = "txt_totalamount"
        Me.txt_totalamount.NullText = "Rate Cost (Required)"
        '
        '
        '
        Me.txt_totalamount.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        Me.txt_totalamount.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        Me.txt_totalamount.RootElement.StretchVertically = True
        Me.txt_totalamount.Size = New System.Drawing.Size(113, 39)
        Me.txt_totalamount.TabIndex = 178
        Me.txt_totalamount.Text = "₱0.00"
        Me.txt_totalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_totalamount.ThemeName = "Office2013Light"
        CType(Me.txt_totalamount.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "₱0.00"
        CType(Me.txt_totalamount.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Rate Cost (Required)"
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).MinSize = New System.Drawing.Size(0, 0)
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.txt_totalamount.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).StretchVertically = True
        '
        'RadPanel29
        '
        Me.RadPanel29.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel29.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel29.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel29.ForeColor = System.Drawing.Color.White
        Me.RadPanel29.Location = New System.Drawing.Point(481, 9)
        Me.RadPanel29.Name = "RadPanel29"
        Me.RadPanel29.Size = New System.Drawing.Size(94, 39)
        Me.RadPanel29.TabIndex = 177
        Me.RadPanel29.Text = "Area Finish"
        Me.RadPanel29.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel4
        '
        Me.RadPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel4.Location = New System.Drawing.Point(5, 54)
        Me.RadPanel4.Name = "RadPanel4"
        Me.RadPanel4.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel4.TabIndex = 138
        '
        'txt_operation_performed
        '
        Me.txt_operation_performed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_operation_performed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_operation_performed.Location = New System.Drawing.Point(54, 54)
        Me.txt_operation_performed.Name = "txt_operation_performed"
        Me.txt_operation_performed.NullText = "Operation Performed  (System Generated)"
        Me.txt_operation_performed.ReadOnly = True
        '
        '
        '
        Me.txt_operation_performed.RootElement.StretchVertically = True
        Me.txt_operation_performed.Size = New System.Drawing.Size(259, 39)
        Me.txt_operation_performed.TabIndex = 137
        Me.txt_operation_performed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_operation_performed.ThemeName = "Office2013Light"
        '
        'RadPanel28
        '
        Me.RadPanel28.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel28.Location = New System.Drawing.Point(319, 9)
        Me.RadPanel28.Name = "RadPanel28"
        Me.RadPanel28.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel28.TabIndex = 176
        '
        'se_area_finish
        '
        Me.se_area_finish.DecimalPlaces = 3
        Me.se_area_finish.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se_area_finish.Location = New System.Drawing.Point(363, 9)
        Me.se_area_finish.Name = "se_area_finish"
        '
        '
        '
        Me.se_area_finish.RootElement.StretchVertically = True
        Me.se_area_finish.Size = New System.Drawing.Size(118, 39)
        Me.se_area_finish.TabIndex = 175
        Me.se_area_finish.TabStop = False
        Me.se_area_finish.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.se_area_finish.ThemeName = "Office2013Light"
        '
        'RadPanel10
        '
        Me.RadPanel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel10.Location = New System.Drawing.Point(5, 9)
        Me.RadPanel10.Name = "RadPanel10"
        Me.RadPanel10.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel10.TabIndex = 136
        '
        'txt_lotno
        '
        Me.txt_lotno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lotno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_lotno.Location = New System.Drawing.Point(54, 9)
        Me.txt_lotno.Name = "txt_lotno"
        Me.txt_lotno.NullText = "Lot Number  (System Generated)"
        Me.txt_lotno.ReadOnly = True
        '
        '
        '
        Me.txt_lotno.RootElement.StretchVertically = True
        Me.txt_lotno.Size = New System.Drawing.Size(259, 39)
        Me.txt_lotno.TabIndex = 135
        Me.txt_lotno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_lotno.ThemeName = "Office2013Light"
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel2.ForeColor = System.Drawing.Color.White
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(1229, 51)
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
        Me.RadGroupBox1.Controls.Add(Me.RadPanel7)
        Me.RadGroupBox1.Controls.Add(Me.btn_process_all)
        Me.RadGroupBox1.Controls.Add(Me.RadPanel31)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(2, 51)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(334, 526)
        Me.RadGroupBox1.TabIndex = 122
        Me.RadGroupBox1.ThemeName = "Office2013Light"
        '
        'RadPanel7
        '
        Me.RadPanel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Controls.Add(Me.lv_for_posting)
        Me.RadPanel7.Location = New System.Drawing.Point(0, 46)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(334, 433)
        Me.RadPanel7.TabIndex = 183
        '
        'lv_for_posting
        '
        Me.lv_for_posting.AllowEdit = False
        Me.lv_for_posting.AllowRemove = False
        Me.lv_for_posting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_for_posting.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick
        Me.lv_for_posting.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_for_posting.ItemSpacing = -1
        Me.lv_for_posting.Location = New System.Drawing.Point(1, 1)
        Me.lv_for_posting.Name = "lv_for_posting"
        Me.lv_for_posting.SelectLastAddedItem = False
        Me.lv_for_posting.ShowCheckBoxes = True
        Me.lv_for_posting.ShowGridLines = True
        Me.lv_for_posting.Size = New System.Drawing.Size(332, 431)
        Me.lv_for_posting.TabIndex = 1
        Me.lv_for_posting.ThemeName = "VisualStudio2012Light"
        Me.lv_for_posting.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_for_posting.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'btn_process_all
        '
        Me.btn_process_all.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_process_all.BackColor = System.Drawing.Color.Black
        Me.btn_process_all.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_process_all.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_process_all.Location = New System.Drawing.Point(0, 483)
        Me.btn_process_all.Name = "btn_process_all"
        Me.btn_process_all.Size = New System.Drawing.Size(334, 40)
        Me.btn_process_all.TabIndex = 175
        Me.btn_process_all.Text = "POST ALL CHECK DATA"
        Me.btn_process_all.ThemeName = "Office2013Dark"
        CType(Me.btn_process_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_process_all.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "POST ALL CHECK DATA"
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
        Me.RadPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadPanel1.ForeColor = System.Drawing.Color.White
        Me.RadPanel1.Location = New System.Drawing.Point(5, 5)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(883, 39)
        Me.RadPanel1.TabIndex = 174
        Me.RadPanel1.Text = "TICKET DETAIL"
        Me.RadPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel3
        '
        Me.RadPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Controls.Add(Me.lv_posting)
        Me.RadPanel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadPanel3.ForeColor = System.Drawing.Color.White
        Me.RadPanel3.Location = New System.Drawing.Point(5, 45)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(883, 328)
        Me.RadPanel3.TabIndex = 175
        Me.RadPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lv_posting
        '
        Me.lv_posting.AllowEdit = False
        Me.lv_posting.AllowRemove = False
        Me.lv_posting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_posting.Font = New System.Drawing.Font("Segoe UI", 7.75!, System.Drawing.FontStyle.Bold)
        Me.lv_posting.ItemSpacing = -1
        Me.lv_posting.Location = New System.Drawing.Point(1, 1)
        Me.lv_posting.Name = "lv_posting"
        Me.lv_posting.SelectLastAddedItem = False
        Me.lv_posting.ShowGridLines = True
        Me.lv_posting.Size = New System.Drawing.Size(881, 326)
        Me.lv_posting.TabIndex = 0
        Me.lv_posting.ThemeName = "VisualStudio2012Light"
        Me.lv_posting.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        CType(Me.lv_posting.GetChildAt(0), Telerik.WinControls.UI.RadListViewElement).BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.BackColor = System.Drawing.Color.Black
        Me.btn_update.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_update.Location = New System.Drawing.Point(6, 377)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(172, 39)
        Me.btn_update.TabIndex = 176
        Me.btn_update.Text = "MODIFY DATA"
        Me.btn_update.ThemeName = "Office2013Dark"
        CType(Me.btn_update.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_update.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "MODIFY DATA"
        CType(Me.btn_update.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_update.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_update.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_update.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_update.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_update.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'txt_grandtotal
        '
        Me.txt_grandtotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_grandtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_grandtotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grandtotal.Location = New System.Drawing.Point(671, 377)
        Me.txt_grandtotal.Name = "txt_grandtotal"
        Me.txt_grandtotal.NullText = "Rate Cost (Required)"
        '
        '
        '
        Me.txt_grandtotal.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        Me.txt_grandtotal.RootElement.FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        Me.txt_grandtotal.RootElement.StretchVertically = True
        Me.txt_grandtotal.Size = New System.Drawing.Size(113, 39)
        Me.txt_grandtotal.TabIndex = 181
        Me.txt_grandtotal.Text = "₱0.00"
        Me.txt_grandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_grandtotal.ThemeName = "Office2013Light"
        CType(Me.txt_grandtotal.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).Text = "₱0.00"
        CType(Me.txt_grandtotal.GetChildAt(0), Telerik.WinControls.UI.RadTextBoxElement).StretchVertically = True
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "Rate Cost (Required)"
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).StretchVertically = False
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentContent
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).MinSize = New System.Drawing.Size(0, 0)
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.txt_grandtotal.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.FillPrimitive).StretchVertically = True
        '
        'RadPanel6
        '
        Me.RadPanel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Location = New System.Drawing.Point(622, 377)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel6.TabIndex = 182
        '
        'RadPanel5
        '
        Me.RadPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel5.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel5.ForeColor = System.Drawing.Color.White
        Me.RadPanel5.Location = New System.Drawing.Point(784, 377)
        Me.RadPanel5.Name = "RadPanel5"
        Me.RadPanel5.Size = New System.Drawing.Size(104, 39)
        Me.RadPanel5.TabIndex = 183
        Me.RadPanel5.Text = "Grand Total Cost"
        Me.RadPanel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gb_data
        '
        Me.gb_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.gb_data.Controls.Add(Me.RadPanel5)
        Me.gb_data.Controls.Add(Me.RadPanel6)
        Me.gb_data.Controls.Add(Me.txt_grandtotal)
        Me.gb_data.Controls.Add(Me.btn_update)
        Me.gb_data.Controls.Add(Me.RadPanel3)
        Me.gb_data.Controls.Add(Me.RadPanel1)
        Me.gb_data.HeaderText = ""
        Me.gb_data.Location = New System.Drawing.Point(339, 51)
        Me.gb_data.Name = "gb_data"
        Me.gb_data.Size = New System.Drawing.Size(891, 421)
        Me.gb_data.TabIndex = 119
        Me.gb_data.ThemeName = "Office2013Light"
        '
        'object_88b57ef6_c361_44ff_b0db_992eab9474c3
        '
        Me.object_88b57ef6_c361_44ff_b0db_992eab9474c3.Name = "object_88b57ef6_c361_44ff_b0db_992eab9474c3"
        Me.object_88b57ef6_c361_44ff_b0db_992eab9474c3.StretchHorizontally = True
        Me.object_88b57ef6_c361_44ff_b0db_992eab9474c3.StretchVertically = True
        '
        'cms_check_uncheck
        '
        Me.cms_check_uncheck.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refresh, Me.sep_1, Me.check_all, Me.uncheck_all})
        Me.cms_check_uncheck.ThemeName = "Office2013Light"
        '
        'refresh
        '
        Me.refresh.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh.Name = "refresh"
        Me.refresh.Text = "Refresh List"
        '
        'sep_1
        '
        Me.sep_1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.sep_1.Name = "sep_1"
        Me.sep_1.Text = "RadMenuSeparatorItem1"
        Me.sep_1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'check_all
        '
        Me.check_all.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.check_all.Name = "check_all"
        Me.check_all.Text = "Check All"
        '
        'uncheck_all
        '
        Me.uncheck_all.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.uncheck_all.Name = "uncheck_all"
        Me.uncheck_all.Text = "Uncheck All"
        '
        'Frm_accomplished_posting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 577)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadPanel2)
        Me.Controls.Add(Me.gb_menu)
        Me.Controls.Add(Me.gb_data)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_accomplished_posting"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIS: Trip Ticket Accomplished"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.gb_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_menu.ResumeLayout(False)
        Me.gb_menu.PerformLayout()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_save, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_totalamount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_operation_performed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.se_area_finish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lotno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel7.ResumeLayout(False)
        CType(Me.lv_for_posting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_process_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel3.ResumeLayout(False)
        CType(Me.lv_posting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_grandtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_data.ResumeLayout(False)
        Me.gb_data.PerformLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gb_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_process_all As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel31 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel4 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_operation_performed As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel10 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_lotno As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadPanel29 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel28 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents se_area_finish As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents RadPanel9 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel8 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents txt_totalamount As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents btn_save As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_cancel As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_for_posting As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents lv_posting As Telerik.WinControls.UI.RadListView
    Friend WithEvents btn_update As Telerik.WinControls.UI.RadButton
    Friend WithEvents txt_grandtotal As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel5 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents gb_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents object_88b57ef6_c361_44ff_b0db_992eab9474c3 As Telerik.WinControls.RootRadElement
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents cms_check_uncheck As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refresh As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents sep_1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents check_all As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents uncheck_all As Telerik.WinControls.UI.RadMenuItem
End Class

