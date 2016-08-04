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
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.DocumentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.dp_location = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.se_total_canepoints = New Telerik.WinControls.UI.RadSpinEditor()
        Me.btn_addqueued = New Telerik.WinControls.UI.RadButton()
        Me.dp_receiving_owner = New Telerik.WinControls.UI.RadDropDownList()
        Me.dt_dateneeded = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip3 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.btn_deletequeued = New Telerik.WinControls.UI.RadButton()
        Me.btn_saveall = New Telerik.WinControls.UI.RadButton()
        Me.lv_created_canepoint_request = New Telerik.WinControls.UI.RadListView()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.se_total_canepoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_addqueued, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_receiving_owner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_dateneeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.RadDock1.Size = New System.Drawing.Size(658, 519)
        Me.RadDock1.SplitterWidth = 0
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.RadLabel4)
        Me.ToolWindow1.Controls.Add(Me.dp_location)
        Me.ToolWindow1.Controls.Add(Me.RadLabel3)
        Me.ToolWindow1.Controls.Add(Me.se_total_canepoints)
        Me.ToolWindow1.Controls.Add(Me.btn_addqueued)
        Me.ToolWindow1.Controls.Add(Me.dp_receiving_owner)
        Me.ToolWindow1.Controls.Add(Me.dt_dateneeded)
        Me.ToolWindow1.Controls.Add(Me.RadLabel1)
        Me.ToolWindow1.Controls.Add(Me.RadLabel2)
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(646, 94)
        Me.ToolWindow1.Text = "Fillup Data"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'RadLabel4
        '
        Me.RadLabel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(6, 11)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel4.TabIndex = 132
        Me.RadLabel4.Text = "Date Needed:"
        '
        'dp_location
        '
        Me.dp_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_location.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dp_location.Location = New System.Drawing.Point(67, 37)
        Me.dp_location.Name = "dp_location"
        Me.dp_location.NullText = "<Required>"
        '
        '
        '
        Me.dp_location.RootElement.StretchVertically = True
        Me.dp_location.Size = New System.Drawing.Size(216, 20)
        Me.dp_location.TabIndex = 134
        '
        'RadLabel3
        '
        Me.RadLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(6, 39)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel3.TabIndex = 135
        Me.RadLabel3.Text = "Location:"
        '
        'se_total_canepoints
        '
        Me.se_total_canepoints.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.se_total_canepoints.Location = New System.Drawing.Point(459, 34)
        Me.se_total_canepoints.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.se_total_canepoints.Name = "se_total_canepoints"
        Me.se_total_canepoints.ShowUpDownButtons = False
        Me.se_total_canepoints.Size = New System.Drawing.Size(181, 20)
        Me.se_total_canepoints.TabIndex = 138
        Me.se_total_canepoints.TabStop = False
        Me.se_total_canepoints.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.se_total_canepoints.ThousandsSeparator = True
        '
        'btn_addqueued
        '
        Me.btn_addqueued.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_addqueued.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_addqueued.Location = New System.Drawing.Point(498, 60)
        Me.btn_addqueued.Name = "btn_addqueued"
        Me.btn_addqueued.Size = New System.Drawing.Size(142, 27)
        Me.btn_addqueued.TabIndex = 140
        Me.btn_addqueued.Text = "Add To Queued Data"
        '
        'dp_receiving_owner
        '
        Me.dp_receiving_owner.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.dp_receiving_owner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_receiving_owner.Location = New System.Drawing.Point(400, 9)
        Me.dp_receiving_owner.Name = "dp_receiving_owner"
        Me.dp_receiving_owner.NullText = "<Required>"
        '
        '
        '
        Me.dp_receiving_owner.RootElement.StretchVertically = True
        Me.dp_receiving_owner.Size = New System.Drawing.Size(240, 20)
        Me.dp_receiving_owner.TabIndex = 136
        '
        'dt_dateneeded
        '
        Me.dt_dateneeded.Location = New System.Drawing.Point(91, 11)
        Me.dt_dateneeded.Name = "dt_dateneeded"
        Me.dt_dateneeded.Size = New System.Drawing.Size(192, 20)
        Me.dt_dateneeded.TabIndex = 133
        Me.dt_dateneeded.TabStop = False
        Me.dt_dateneeded.Text = "Monday, December 28, 2015"
        Me.dt_dateneeded.Value = New Date(2015, 12, 28, 0, 0, 0, 0)
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(301, 11)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(99, 18)
        Me.RadLabel1.TabIndex = 137
        Me.RadLabel1.Text = "To be Receive By:"
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(301, 35)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(147, 18)
        Me.RadLabel2.TabIndex = 139
        Me.RadLabel2.Text = "Cane Point Count Needed:"
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
        Me.ToolTabStrip1.Size = New System.Drawing.Size(648, 118)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 118)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -82)
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
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 387)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 82)
        Me.DocumentContainer1.SplitterWidth = 0
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
        Me.DocumentTabStrip3.Size = New System.Drawing.Size(648, 391)
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
        Me.DocumentWindow2.Size = New System.Drawing.Size(636, 356)
        Me.DocumentWindow2.Text = "Queued Data"
        '
        'btn_deletequeued
        '
        Me.btn_deletequeued.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_deletequeued.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_deletequeued.Location = New System.Drawing.Point(1, 326)
        Me.btn_deletequeued.Name = "btn_deletequeued"
        Me.btn_deletequeued.Size = New System.Drawing.Size(146, 27)
        Me.btn_deletequeued.TabIndex = 142
        Me.btn_deletequeued.Text = "Delete Check Queued Data"
        '
        'btn_saveall
        '
        Me.btn_saveall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_saveall.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_saveall.Location = New System.Drawing.Point(507, 326)
        Me.btn_saveall.Name = "btn_saveall"
        Me.btn_saveall.Size = New System.Drawing.Size(128, 27)
        Me.btn_saveall.TabIndex = 141
        Me.btn_saveall.Text = "Save All Queued Data"
        '
        'lv_created_canepoint_request
        '
        Me.lv_created_canepoint_request.AllowColumnReorder = False
        Me.lv_created_canepoint_request.AllowEdit = False
        Me.lv_created_canepoint_request.AllowRemove = False
        Me.lv_created_canepoint_request.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_created_canepoint_request.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_created_canepoint_request.ItemSpacing = -1
        Me.lv_created_canepoint_request.Location = New System.Drawing.Point(0, 3)
        Me.lv_created_canepoint_request.Name = "lv_created_canepoint_request"
        Me.lv_created_canepoint_request.SelectLastAddedItem = False
        Me.lv_created_canepoint_request.Size = New System.Drawing.Size(635, 317)
        Me.lv_created_canepoint_request.TabIndex = 131
        Me.lv_created_canepoint_request.Text = "RadListView1"
        Me.lv_created_canepoint_request.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'Frm_canepoint_request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 519)
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
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        Me.ToolWindow1.PerformLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.se_total_canepoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_addqueued, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_receiving_owner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_dateneeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip2 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents btn_deletequeued As Telerik.WinControls.UI.RadButton
    Friend WithEvents btn_saveall As Telerik.WinControls.UI.RadButton
    Friend WithEvents lv_created_canepoint_request As Telerik.WinControls.UI.RadListView
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents dp_location As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents se_total_canepoints As Telerik.WinControls.UI.RadSpinEditor
    Friend WithEvents btn_addqueued As Telerik.WinControls.UI.RadButton
    Friend WithEvents dp_receiving_owner As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents dt_dateneeded As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentTabStrip3 As Telerik.WinControls.UI.Docking.DocumentTabStrip
End Class

