﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_job_ticket_for_processing_accomplishment
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
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.DocumentWindow3 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.lv_for_processing = New Telerik.WinControls.UI.RadListView()
        Me.lv_scheduled = New Telerik.WinControls.UI.RadListView()
        Me.lv_lots = New Telerik.WinControls.UI.RadListView()
        Me.lv_manpower = New Telerik.WinControls.UI.RadListView()
        Me.DocumentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.RadSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
        Me.DocumentTabStrip4 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip1.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        Me.DocumentWindow2.SuspendLayout()
        Me.DocumentWindow3.SuspendLayout()
        CType(Me.lv_for_processing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_scheduled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip2.SuspendLayout()
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip4.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.DocumentWindow3
        Me.RadDock1.Controls.Add(Me.RadSplitContainer1)
        Me.RadDock1.Controls.Add(Me.DocumentTabStrip4)
        Me.RadDock1.Controls.Add(Me.DocumentTabStrip2)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        Me.RadDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadDock1.Size = New System.Drawing.Size(1315, 647)
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        Me.RadDock1.UseSplitterButtons = True
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        Me.DocumentContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(629, 200)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-268, 0)
        Me.DocumentContainer1.UseSplitterButtons = True
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
        Me.ToolWindow1.Size = New System.Drawing.Size(260, 205)
        Me.ToolWindow1.Text = "Encoded Job Ticket (For Processing)"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
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
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(262, 229)
        Me.ToolTabStrip1.SizeInfo.AbsoluteSize = New System.Drawing.Size(262, 200)
        Me.ToolTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(62, 0)
        Me.ToolTabStrip1.TabIndex = 1
        Me.ToolTabStrip1.TabStop = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.lv_scheduled)
        Me.DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow1.Size = New System.Drawing.Size(1027, 194)
        Me.DocumentWindow1.Text = "Job Ticket Scheduled Information"
        Me.DocumentWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
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
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(1039, 229)
        Me.DocumentTabStrip1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.04186414!)
        Me.DocumentTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -27)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'DocumentWindow2
        '
        Me.DocumentWindow2.Controls.Add(Me.lv_lots)
        Me.DocumentWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow2.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow2.Name = "DocumentWindow2"
        Me.DocumentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow2.Size = New System.Drawing.Size(1293, 165)
        Me.DocumentWindow2.Text = "Job Ticket Lots Information"
        Me.DocumentWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'DocumentWindow3
        '
        Me.DocumentWindow3.Controls.Add(Me.lv_manpower)
        Me.DocumentWindow3.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow3.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow3.Name = "DocumentWindow3"
        Me.DocumentWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow3.Size = New System.Drawing.Size(1293, 165)
        Me.DocumentWindow3.Text = "Job Ticket Manpower Information"
        Me.DocumentWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_for_processing
        '
        Me.lv_for_processing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_for_processing.ItemSpacing = -1
        Me.lv_for_processing.Location = New System.Drawing.Point(6, 7)
        Me.lv_for_processing.Name = "lv_for_processing"
        Me.lv_for_processing.Size = New System.Drawing.Size(248, 193)
        Me.lv_for_processing.TabIndex = 0
        Me.lv_for_processing.Text = "RadListView1"
        Me.lv_for_processing.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'lv_scheduled
        '
        Me.lv_scheduled.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_scheduled.ItemSpacing = -1
        Me.lv_scheduled.Location = New System.Drawing.Point(3, 25)
        Me.lv_scheduled.Name = "lv_scheduled"
        Me.lv_scheduled.Size = New System.Drawing.Size(1022, 169)
        Me.lv_scheduled.TabIndex = 1
        Me.lv_scheduled.Text = "RadListView2"
        Me.lv_scheduled.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'lv_lots
        '
        Me.lv_lots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lots.ItemSpacing = -1
        Me.lv_lots.Location = New System.Drawing.Point(3, 35)
        Me.lv_lots.Name = "lv_lots"
        Me.lv_lots.Size = New System.Drawing.Size(1288, 129)
        Me.lv_lots.TabIndex = 2
        Me.lv_lots.Text = "RadListView3"
        Me.lv_lots.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'lv_manpower
        '
        Me.lv_manpower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_manpower.ItemSpacing = -1
        Me.lv_manpower.Location = New System.Drawing.Point(3, 25)
        Me.lv_manpower.Name = "lv_manpower"
        Me.lv_manpower.Size = New System.Drawing.Size(1287, 139)
        Me.lv_manpower.TabIndex = 3
        Me.lv_manpower.Text = "RadListView4"
        Me.lv_manpower.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'DocumentTabStrip2
        '
        Me.DocumentTabStrip2.CanUpdateChildIndex = True
        Me.DocumentTabStrip2.Controls.Add(Me.DocumentWindow3)
        Me.DocumentTabStrip2.Location = New System.Drawing.Point(5, 442)
        Me.DocumentTabStrip2.Name = "DocumentTabStrip2"
        '
        '
        '
        Me.DocumentTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip2.SelectedIndex = 0
        Me.DocumentTabStrip2.Size = New System.Drawing.Size(1305, 200)
        Me.DocumentTabStrip2.SizeInfo.AbsoluteSize = New System.Drawing.Size(406, 200)
        Me.DocumentTabStrip2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.05776364!)
        Me.DocumentTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(206, 37)
        Me.DocumentTabStrip2.TabIndex = 1
        Me.DocumentTabStrip2.TabStop = False
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
        Me.RadSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.RadSplitContainer1.Size = New System.Drawing.Size(1305, 229)
        Me.RadSplitContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(406, 200)
        Me.RadSplitContainer1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.05776364!)
        Me.RadSplitContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(206, 37)
        Me.RadSplitContainer1.TabIndex = 0
        Me.RadSplitContainer1.TabStop = False
        '
        'DocumentTabStrip4
        '
        Me.DocumentTabStrip4.CanUpdateChildIndex = True
        Me.DocumentTabStrip4.Controls.Add(Me.DocumentWindow2)
        Me.DocumentTabStrip4.Location = New System.Drawing.Point(5, 238)
        Me.DocumentTabStrip4.Name = "DocumentTabStrip4"
        '
        '
        '
        Me.DocumentTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.DocumentTabStrip4.SelectedIndex = 0
        Me.DocumentTabStrip4.Size = New System.Drawing.Size(1305, 200)
        Me.DocumentTabStrip4.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.04186414!)
        Me.DocumentTabStrip4.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -10)
        Me.DocumentTabStrip4.TabIndex = 2
        Me.DocumentTabStrip4.TabStop = False
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
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip1.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        Me.DocumentWindow2.ResumeLayout(False)
        Me.DocumentWindow3.ResumeLayout(False)
        CType(Me.lv_for_processing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_scheduled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip2.ResumeLayout(False)
        CType(Me.RadSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip4.ResumeLayout(False)
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
End Class

