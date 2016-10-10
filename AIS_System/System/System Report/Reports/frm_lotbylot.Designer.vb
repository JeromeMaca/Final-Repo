<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_lotbylot
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
        Me.RadPanel2 = New Telerik.WinControls.UI.RadPanel()
        Me.btn_preview = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox4 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.rv_lotbylot = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dtp_datefrom = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadPanel7 = New Telerik.WinControls.UI.RadPanel()
        Me.dp_viewbyuser = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadPanel6 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel21 = New Telerik.WinControls.UI.RadPanel()
        Me.RadPanel3 = New Telerik.WinControls.UI.RadPanel()
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox4.SuspendLayout()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.dtp_datefrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_viewbyuser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPanel2
        '
        Me.RadPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel2.ForeColor = System.Drawing.Color.White
        Me.RadPanel2.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel2.Name = "RadPanel2"
        Me.RadPanel2.Size = New System.Drawing.Size(1104, 44)
        Me.RadPanel2.TabIndex = 163
        Me.RadPanel2.Text = "LOT BY LOT REPORTS"
        Me.RadPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_preview
        '
        Me.btn_preview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_preview.BackColor = System.Drawing.Color.Black
        Me.btn_preview.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_preview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_preview.Location = New System.Drawing.Point(949, 47)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(155, 37)
        Me.btn_preview.TabIndex = 180
        Me.btn_preview.Text = "REPORT PREVIEW"
        Me.btn_preview.ThemeName = "Office2013Dark"
        CType(Me.btn_preview.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = Nothing
        CType(Me.btn_preview.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "REPORT PREVIEW"
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).ForeColor = System.Drawing.Color.Black
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Layouts.ImageAndTextLayoutPanel).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchHorizontally = False
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).StretchVertically = False
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ImageLayout = System.Windows.Forms.ImageLayout.None
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).DefaultSize = New System.Drawing.Size(20, 20)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).FitToSizeMode = Telerik.WinControls.RadFitToSizeMode.FitToParentBounds
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Enabled = True
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ShouldPaint = True
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ClipDrawing = False
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).ScaleTransform = New System.Drawing.SizeF(1.0!, 1.0!)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).AngleTransform = 0!
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).PositionOffset = New System.Drawing.SizeF(15.0!, 0!)
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Shadow = Nothing
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(1).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Alignment = System.Drawing.ContentAlignment.MiddleCenter
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.SingleBorder
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).LeftColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).TopColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).RightColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).BottomColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(106, Byte), Integer))
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.[Default]
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders
        CType(Me.btn_preview.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox3.Controls.Add(Me.RadGroupBox4)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(0, 87)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(1104, 427)
        Me.RadGroupBox3.TabIndex = 179
        Me.RadGroupBox3.ThemeName = "TelerikMetroBlue"
        '
        'RadGroupBox4
        '
        Me.RadGroupBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadGroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.RadGroupBox4.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadGroupBox4.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
        Me.RadGroupBox4.HeaderText = "Report Preview"
        Me.RadGroupBox4.Location = New System.Drawing.Point(5, 9)
        Me.RadGroupBox4.Name = "RadGroupBox4"
        Me.RadGroupBox4.Size = New System.Drawing.Size(1094, 413)
        Me.RadGroupBox4.TabIndex = 10
        Me.RadGroupBox4.Text = "Report Preview"
        Me.RadGroupBox4.ThemeName = "VisualStudio2012Light"
        '
        'RadPanel1
        '
        Me.RadPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel1.Controls.Add(Me.rv_lotbylot)
        Me.RadPanel1.Location = New System.Drawing.Point(0, 21)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1094, 392)
        Me.RadPanel1.TabIndex = 130
        '
        'rv_lotbylot
        '
        Me.rv_lotbylot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rv_lotbylot.Location = New System.Drawing.Point(0, 0)
        Me.rv_lotbylot.Name = "rv_lotbylot"
        Me.rv_lotbylot.Size = New System.Drawing.Size(1094, 392)
        Me.rv_lotbylot.TabIndex = 0
        '
        'dtp_datefrom
        '
        Me.dtp_datefrom.Culture = New System.Globalization.CultureInfo("en-PH")
        Me.dtp_datefrom.CustomFormat = "M D,YYYY"
        Me.dtp_datefrom.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.dtp_datefrom.Location = New System.Drawing.Point(416, 46)
        Me.dtp_datefrom.Name = "dtp_datefrom"
        Me.dtp_datefrom.NullText = "Filter By Date Needed  (Start)"
        '
        '
        '
        Me.dtp_datefrom.RootElement.StretchVertically = True
        Me.dtp_datefrom.Size = New System.Drawing.Size(187, 39)
        Me.dtp_datefrom.TabIndex = 184
        Me.dtp_datefrom.TabStop = False
        Me.dtp_datefrom.ThemeName = "Office2013Light"
        Me.dtp_datefrom.Value = New Date(CType(0, Long))
        '
        'RadPanel7
        '
        Me.RadPanel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel7.Location = New System.Drawing.Point(369, 46)
        Me.RadPanel7.Name = "RadPanel7"
        Me.RadPanel7.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel7.TabIndex = 183
        '
        'dp_viewbyuser
        '
        Me.dp_viewbyuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_viewbyuser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp_viewbyuser.Location = New System.Drawing.Point(48, 46)
        Me.dp_viewbyuser.Name = "dp_viewbyuser"
        Me.dp_viewbyuser.NullText = "CropYear   (Required)"
        '
        '
        '
        Me.dp_viewbyuser.RootElement.StretchVertically = True
        Me.dp_viewbyuser.Size = New System.Drawing.Size(211, 39)
        Me.dp_viewbyuser.TabIndex = 181
        Me.dp_viewbyuser.ThemeName = "Office2013Light"
        CType(Me.dp_viewbyuser.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        CType(Me.dp_viewbyuser.GetChildAt(0), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadDropDownListEditableAreaElement).DrawText = False
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).TextOrientation = System.Windows.Forms.Orientation.Horizontal
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Text = ""
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadDropDownTextBoxElement).StretchVertically = True
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).NullText = "CropYear   (Required)"
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(0).GetChildAt(0).GetChildAt(0), Telerik.WinControls.UI.RadTextBoxItem).PositionOffset = New System.Drawing.SizeF(0!, 0!)
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadDropDownListArrowButtonElement).PositionOffset = New System.Drawing.SizeF(5.0!, 0!)
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).StretchHorizontally = False
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).StretchVertically = False
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.ArrowPrimitive).PositionOffset = New System.Drawing.SizeF(-3.0!, 0!)
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Image = Nothing
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(2).GetChildAt(1).GetChildAt(4), Telerik.WinControls.Primitives.ImagePrimitive).Visibility = Telerik.WinControls.ElementVisibility.Visible
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Alignment = System.Drawing.ContentAlignment.TopLeft
        CType(Me.dp_viewbyuser.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadDropDownListElement).Visibility = Telerik.WinControls.ElementVisibility.Hidden
        '
        'RadPanel6
        '
        Me.RadPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel6.Location = New System.Drawing.Point(0, 46)
        Me.RadPanel6.Name = "RadPanel6"
        Me.RadPanel6.Size = New System.Drawing.Size(49, 39)
        Me.RadPanel6.TabIndex = 182
        '
        'RadPanel21
        '
        Me.RadPanel21.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel21.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel21.ForeColor = System.Drawing.Color.White
        Me.RadPanel21.Location = New System.Drawing.Point(603, 46)
        Me.RadPanel21.Name = "RadPanel21"
        Me.RadPanel21.Size = New System.Drawing.Size(67, 39)
        Me.RadPanel21.TabIndex = 185
        Me.RadPanel21.Text = "As of Date"
        Me.RadPanel21.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadPanel3
        '
        Me.RadPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(149, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.RadPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadPanel3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadPanel3.ForeColor = System.Drawing.Color.White
        Me.RadPanel3.Location = New System.Drawing.Point(260, 46)
        Me.RadPanel3.Name = "RadPanel3"
        Me.RadPanel3.Size = New System.Drawing.Size(89, 39)
        Me.RadPanel3.TabIndex = 186
        Me.RadPanel3.Text = "Crop Year"
        Me.RadPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_lotbylot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 513)
        Me.Controls.Add(Me.RadPanel3)
        Me.Controls.Add(Me.RadPanel21)
        Me.Controls.Add(Me.dtp_datefrom)
        Me.Controls.Add(Me.RadPanel7)
        Me.Controls.Add(Me.dp_viewbyuser)
        Me.Controls.Add(Me.RadPanel6)
        Me.Controls.Add(Me.btn_preview)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadPanel2)
        Me.Name = "Frm_lotbylot"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_lotbylot"
        Me.ThemeName = "VisualStudio2012Light"
        CType(Me.RadPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.RadGroupBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox4.ResumeLayout(False)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        CType(Me.dtp_datefrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_viewbyuser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadPanel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents btn_preview As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox4 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rv_lotbylot As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtp_datefrom As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadPanel7 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents dp_viewbyuser As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadPanel6 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel21 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadPanel3 As Telerik.WinControls.UI.RadPanel
End Class

