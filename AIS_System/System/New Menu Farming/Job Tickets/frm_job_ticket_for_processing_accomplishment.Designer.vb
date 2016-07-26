<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_job_ticket_for_processing_accomplishment
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
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.lv_for_processing = New Telerik.WinControls.UI.RadListView()
        Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.lv_scheduled = New Telerik.WinControls.UI.RadListView()
        Me.DocumentTabStrip4 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow3 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.lv_manpower = New Telerik.WinControls.UI.RadListView()
        Me.DocumentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.lv_lots = New Telerik.WinControls.UI.RadListView()
        Me.cms_for_processing = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.check_all = New Telerik.WinControls.UI.RadMenuItem()
        Me.uncheck_all = New Telerik.WinControls.UI.RadMenuItem()
        Me.divider = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.process_all = New Telerik.WinControls.UI.RadMenuItem()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.lv_for_processing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.lv_scheduled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip4.SuspendLayout()
        Me.DocumentWindow3.SuspendLayout()
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip2.SuspendLayout()
        Me.DocumentWindow2.SuspendLayout()
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.ToolWindow1
        Me.RadDock1.Controls.Add(Me.RadSplitContainer1)
        Me.RadDock1.Controls.Add(Me.DocumentTabStrip2)
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
        Me.RadDock1.Size = New System.Drawing.Size(1315, 647)
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        Me.RadDock1.UseSplitterButtons = True
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.lv_for_processing)
        Me.ToolWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(458, 381)
        Me.ToolWindow1.Text = "Encoded Job Ticket (For Processing)"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_for_processing
        '
        Me.lv_for_processing.AllowColumnReorder = False
        Me.lv_for_processing.AllowEdit = False
        Me.lv_for_processing.AllowRemove = False
        Me.lv_for_processing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_for_processing.ItemSpacing = -1
        Me.lv_for_processing.Location = New System.Drawing.Point(0, 0)
        Me.lv_for_processing.Name = "lv_for_processing"
        Me.lv_for_processing.SelectLastAddedItem = False
        Me.lv_for_processing.ShowCheckBoxes = True
        Me.lv_for_processing.Size = New System.Drawing.Size(458, 381)
        Me.lv_for_processing.TabIndex = 0
        Me.lv_for_processing.Text = "RadListView1"
        Me.lv_for_processing.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadSplitContainer1
        '
        Me.RadSplitContainer1.Controls.Add(Me.ToolTabStrip1)
        Me.RadSplitContainer1.Controls.Add(Me.DocumentContainer1)
        Me.RadSplitContainer1.IsCleanUpTarget = True
        Me.RadSplitContainer1.Location = New System.Drawing.Point(5, 5)
        Me.RadSplitContainer1.Name = "RadSplitContainer1"
        Me.RadSplitContainer1.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadSplitContainer1.Size = New System.Drawing.Size(1305, 405)
        Me.RadSplitContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 405)
        Me.RadSplitContainer1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.04186414!)
        Me.RadSplitContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -38)
        Me.RadSplitContainer1.TabIndex = 0
        Me.RadSplitContainer1.TabStop = False
        Me.RadSplitContainer1.UseSplitterButtons = True
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(460, 405)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(460, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(260, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip4)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        Me.DocumentContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(841, 200)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-466, 0)
        Me.DocumentContainer1.TabIndex = 2
        Me.DocumentContainer1.UseSplitterButtons = True
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
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(841, 163)
        Me.DocumentTabStrip1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.09351621!)
        Me.DocumentTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -49)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.lv_scheduled)
        Me.DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow1.Size = New System.Drawing.Size(829, 128)
        Me.DocumentWindow1.Text = "Job Ticket Scheduled Information"
        Me.DocumentWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_scheduled
        '
        Me.lv_scheduled.AllowColumnReorder = False
        Me.lv_scheduled.AllowEdit = False
        Me.lv_scheduled.AllowRemove = False
        Me.lv_scheduled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_scheduled.ItemSpacing = -1
        Me.lv_scheduled.Location = New System.Drawing.Point(0, 0)
        Me.lv_scheduled.Name = "lv_scheduled"
        Me.lv_scheduled.SelectLastAddedItem = False
        Me.lv_scheduled.Size = New System.Drawing.Size(829, 128)
        Me.lv_scheduled.TabIndex = 1
        Me.lv_scheduled.Text = "RadListView2"
        Me.lv_scheduled.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'DocumentTabStrip4
        '
        Me.DocumentTabStrip4.CanUpdateChildIndex = True
        Me.DocumentTabStrip4.Controls.Add(Me.DocumentWindow3)
        Me.DocumentTabStrip4.Location = New System.Drawing.Point(0, 167)
        Me.DocumentTabStrip4.Name = "DocumentTabStrip4"
        '
        '
        '
        Me.DocumentTabStrip4.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentTabStrip4.SelectedIndex = 0
        Me.DocumentTabStrip4.Size = New System.Drawing.Size(841, 238)
        Me.DocumentTabStrip4.SizeInfo.AbsoluteSize = New System.Drawing.Size(406, 200)
        Me.DocumentTabStrip4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.09351621!)
        Me.DocumentTabStrip4.SizeInfo.SplitterCorrection = New System.Drawing.Size(206, 59)
        Me.DocumentTabStrip4.TabIndex = 2
        Me.DocumentTabStrip4.TabStop = False
        '
        'DocumentWindow3
        '
        Me.DocumentWindow3.Controls.Add(Me.lv_manpower)
        Me.DocumentWindow3.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow3.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow3.Name = "DocumentWindow3"
        Me.DocumentWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow3.Size = New System.Drawing.Size(829, 203)
        Me.DocumentWindow3.Text = "Job Ticket Manpower Information"
        Me.DocumentWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_manpower
        '
        Me.lv_manpower.AllowColumnReorder = False
        Me.lv_manpower.AllowEdit = False
        Me.lv_manpower.AllowRemove = False
        Me.lv_manpower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_manpower.ItemSpacing = -1
        Me.lv_manpower.Location = New System.Drawing.Point(0, 0)
        Me.lv_manpower.Name = "lv_manpower"
        Me.lv_manpower.SelectLastAddedItem = False
        Me.lv_manpower.Size = New System.Drawing.Size(829, 203)
        Me.lv_manpower.TabIndex = 3
        Me.lv_manpower.Text = "RadListView4"
        Me.lv_manpower.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'DocumentTabStrip2
        '
        Me.DocumentTabStrip2.CanUpdateChildIndex = True
        Me.DocumentTabStrip2.Controls.Add(Me.DocumentWindow2)
        Me.DocumentTabStrip2.Location = New System.Drawing.Point(5, 414)
        Me.DocumentTabStrip2.Name = "DocumentTabStrip2"
        '
        '
        '
        Me.DocumentTabStrip2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentTabStrip2.SelectedIndex = 0
        Me.DocumentTabStrip2.Size = New System.Drawing.Size(1305, 228)
        Me.DocumentTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(200, 228)
        Me.DocumentTabStrip2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.04186414!)
        Me.DocumentTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 18)
        Me.DocumentTabStrip2.TabIndex = 1
        Me.DocumentTabStrip2.TabStop = False
        '
        'DocumentWindow2
        '
        Me.DocumentWindow2.Controls.Add(Me.lv_lots)
        Me.DocumentWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow2.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow2.Name = "DocumentWindow2"
        Me.DocumentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow2.Size = New System.Drawing.Size(1293, 193)
        Me.DocumentWindow2.Text = "Job Ticket Lots Information"
        Me.DocumentWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_lots
        '
        Me.lv_lots.AllowColumnReorder = False
        Me.lv_lots.AllowEdit = False
        Me.lv_lots.AllowRemove = False
        Me.lv_lots.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_lots.ItemSpacing = -1
        Me.lv_lots.Location = New System.Drawing.Point(0, 0)
        Me.lv_lots.Name = "lv_lots"
        Me.lv_lots.SelectLastAddedItem = False
        Me.lv_lots.Size = New System.Drawing.Size(1293, 193)
        Me.lv_lots.TabIndex = 2
        Me.lv_lots.Text = "RadListView3"
        Me.lv_lots.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'cms_for_processing
        '
        Me.cms_for_processing.Items.AddRange(New Telerik.WinControls.RadItem() {Me.check_all, Me.uncheck_all, Me.divider, Me.process_all})
        '
        'check_all
        '
        Me.check_all.Name = "check_all"
        Me.check_all.Text = "Check All Items"
        '
        'uncheck_all
        '
        Me.uncheck_all.Name = "uncheck_all"
        Me.uncheck_all.Text = "Uncheck All Items"
        '
        'divider
        '
        Me.divider.Name = "divider"
        Me.divider.Text = "RadMenuSeparatorItem1"
        Me.divider.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'process_all
        '
        Me.process_all.Name = "process_all"
        Me.process_all.Text = "Process All Check Item (Forward to Accomplished Data)"
        '
        'Frm_job_ticket_for_processing_accomplishment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 647)
        Me.Controls.Add(Me.RadDock1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_job_ticket_for_processing_accomplishment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_job_ticket_for_processing_accomplishment"
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.lv_for_processing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.lv_scheduled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip4.ResumeLayout(False)
        Me.DocumentWindow3.ResumeLayout(False)
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip2.ResumeLayout(False)
        Me.DocumentWindow2.ResumeLayout(False)
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentWindow3 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents lv_for_processing As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_scheduled As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_lots As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_manpower As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents DocumentTabStrip4 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentTabStrip2 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents cms_for_processing As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents check_all As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents uncheck_all As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents divider As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents process_all As Telerik.WinControls.UI.RadMenuItem
End Class

