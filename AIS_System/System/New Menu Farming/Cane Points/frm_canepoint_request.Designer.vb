<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_canepoint_request
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
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.btn_addqueued = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.dt_dateneeded = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip3 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.btn_deletequeued = New Telerik.WinControls.UI.RadButton()
        Me.btn_saveall = New Telerik.WinControls.UI.RadButton()
        Me.lv_created_canepoint_request = New Telerik.WinControls.UI.RadListView()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.DocumentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.btn_addqueued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_dateneeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip3.SuspendLayout()
        Me.DocumentWindow2.SuspendLayout()
        CType(Me.btn_deletequeued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_saveall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_created_canepoint_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.DocumentWindow2
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
        Me.RadDock1.Size = New System.Drawing.Size(642, 523)
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        Me.RadDock1.UseSplitterButtons = True
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.btn_addqueued)
        Me.ToolWindow1.Controls.Add(Me.RadLabel2)
        Me.ToolWindow1.Controls.Add(Me.RadSpinEditor1)
        Me.ToolWindow1.Controls.Add(Me.RadDropDownList1)
        Me.ToolWindow1.Controls.Add(Me.RadLabel1)
        Me.ToolWindow1.Controls.Add(Me.dp_location)
        Me.ToolWindow1.Controls.Add(Me.RadLabel3)
        Me.ToolWindow1.Controls.Add(Me.dt_dateneeded)
        Me.ToolWindow1.Controls.Add(Me.RadLabel4)
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(630, 97)
        Me.ToolWindow1.Text = "Fillup Information"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'btn_addqueued
        '
        Me.btn_addqueued.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_addqueued.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_addqueued.Location = New System.Drawing.Point(502, 62)
        Me.btn_addqueued.Name = "btn_addqueued"
        Me.btn_addqueued.Size = New System.Drawing.Size(119, 27)
        Me.btn_addqueued.TabIndex = 116
        Me.btn_addqueued.Text = "Add To Queued Data"
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(313, 36)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(147, 18)
        Me.RadLabel2.TabIndex = 115
        Me.RadLabel2.Text = "Cane Point Count Needed:"
        '
        'RadSpinEditor1
        '
        Me.RadSpinEditor1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadSpinEditor1.Location = New System.Drawing.Point(464, 34)
        Me.RadSpinEditor1.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.RadSpinEditor1.Name = "RadSpinEditor1"
        Me.RadSpinEditor1.ShowUpDownButtons = False
        Me.RadSpinEditor1.Size = New System.Drawing.Size(157, 20)
        Me.RadSpinEditor1.TabIndex = 114
        Me.RadSpinEditor1.TabStop = False
        Me.RadSpinEditor1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.RadSpinEditor1.ThousandsSeparator = True
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RadDropDownList1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RadDropDownList1.Location = New System.Drawing.Point(401, 9)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.NullText = "<Required>"
        '
        '
        '
        Me.RadDropDownList1.RootElement.StretchVertically = True
        Me.RadDropDownList1.Size = New System.Drawing.Size(220, 20)
        Me.RadDropDownList1.TabIndex = 112
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(313, 13)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(82, 18)
        Me.RadLabel1.TabIndex = 113
        Me.RadLabel1.Text = "Requested By:"
        '
        'dp_location
        '
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.Location = New System.Drawing.Point(71, 35)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "<Required>"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(236, 20)
        Me.dp_location.TabIndex = 110
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(10, 37)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel3.TabIndex = 111
        Me.RadLabel3.Text = "Location:"
        '
        'dt_dateneeded
        '
        Me.dt_dateneeded.Location = New System.Drawing.Point(95, 9)
        Me.dt_dateneeded.Name = "dt_dateneeded"
        Me.dt_dateneeded.Size = New System.Drawing.Size(212, 20)
        Me.dt_dateneeded.TabIndex = 35
        Me.dt_dateneeded.TabStop = False
        Me.dt_dateneeded.Text = "Monday, December 28, 2015"
        Me.dt_dateneeded.Value = New Date(2015, 12, 28, 0, 0, 0, 0)
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(10, 9)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel4.TabIndex = 34
        Me.RadLabel4.Text = "Date Needed:"
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
        Me.ToolTabStrip1.Size = New System.Drawing.Size(632, 121)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 121)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -79)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip3)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(415, 388)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-246, -57)
        Me.DocumentContainer1.TabIndex = 2
        '
        'DocumentTabStrip3
        '
        Me.DocumentTabStrip3.CanUpdateChildIndex = True
        Me.DocumentTabStrip3.Controls.Add(Me.DocumentWindow2)
        Me.DocumentTabStrip3.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip3.Name = "DocumentTabStrip3"
        '
        '
        '
        Me.DocumentTabStrip3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentTabStrip3.SelectedIndex = 0
        Me.DocumentTabStrip3.Size = New System.Drawing.Size(632, 388)
        Me.DocumentTabStrip3.TabIndex = 0
        Me.DocumentTabStrip3.TabStop = False
        '
        'DocumentWindow2
        '
        Me.DocumentWindow2.Controls.Add(Me.btn_deletequeued)
        Me.DocumentWindow2.Controls.Add(Me.btn_saveall)
        Me.DocumentWindow2.Controls.Add(Me.lv_created_canepoint_request)
        Me.DocumentWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow2.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow2.Name = "DocumentWindow2"
        Me.DocumentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow2.Size = New System.Drawing.Size(620, 353)
        Me.DocumentWindow2.Text = "Added Data Queued"
        Me.DocumentWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'btn_deletequeued
        '
        Me.btn_deletequeued.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_deletequeued.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_deletequeued.Location = New System.Drawing.Point(1, 326)
        Me.btn_deletequeued.Name = "btn_deletequeued"
        Me.btn_deletequeued.Size = New System.Drawing.Size(146, 27)
        Me.btn_deletequeued.TabIndex = 118
        Me.btn_deletequeued.Text = "Delete Check Queued Data"
        '
        'btn_saveall
        '
        Me.btn_saveall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_saveall.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_saveall.Location = New System.Drawing.Point(492, 326)
        Me.btn_saveall.Name = "btn_saveall"
        Me.btn_saveall.Size = New System.Drawing.Size(128, 27)
        Me.btn_saveall.TabIndex = 117
        Me.btn_saveall.Text = "Save All Queued Data"
        '
        'lv_created_canepoint_request
        '
        Me.lv_created_canepoint_request.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_created_canepoint_request.Location = New System.Drawing.Point(0, 0)
        Me.lv_created_canepoint_request.Name = "lv_created_canepoint_request"
        Me.lv_created_canepoint_request.Size = New System.Drawing.Size(620, 322)
        Me.lv_created_canepoint_request.TabIndex = 0
        Me.lv_created_canepoint_request.Text = "RadListView1"
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
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(865, 97)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow1.Location = New System.Drawing.Point(4, 4)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow1.Size = New System.Drawing.Size(857, 89)
        Me.DocumentWindow1.Text = "DocumentWindow1"
        '
        'DocumentTabStrip2
        '
        Me.DocumentTabStrip2.CanUpdateChildIndex = True
        Me.DocumentTabStrip2.Location = New System.Drawing.Point(419, 0)
        Me.DocumentTabStrip2.Name = "DocumentTabStrip2"
        '
        '
        '
        Me.DocumentTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip2.Size = New System.Drawing.Size(446, 233)
        Me.DocumentTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(446, 200)
        Me.DocumentTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(246, 0)
        Me.DocumentTabStrip2.TabIndex = 1
        Me.DocumentTabStrip2.TabStop = False
        '
        'Frm_canepoint_request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 523)
        Me.Controls.Add(Me.RadDock1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_canepoint_request"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_canepoint_request"
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        Me.ToolWindow1.PerformLayout()
        CType(Me.btn_addqueued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_dateneeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip3.ResumeLayout(False)
        Me.DocumentWindow2.ResumeLayout(False)
        CType(Me.btn_deletequeued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_saveall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_created_canepoint_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentTabStrip3 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip2 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents dt_dateneeded As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadSpinEditor1 As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents btn_addqueued As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_created_canepoint_request As Telerik.WinControls.UI.RadListView
    Friend WithEvents btn_deletequeued As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_saveall As Telerik.WinControls.UI.RadButton
End Class

