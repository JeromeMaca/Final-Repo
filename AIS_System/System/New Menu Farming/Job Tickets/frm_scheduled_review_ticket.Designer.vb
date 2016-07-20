<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_scheduled_review_ticket
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
        Me.DocumentContainer2 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.rpt_job_ticket = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.ToolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.lbl_job_ticket_no = New Telerik.WinControls.UI.RadLabel()
        Me.btn_generate_report = New Telerik.WinControls.UI.RadButton()
        Me.lv_schedule = New Telerik.WinControls.UI.RadListView()
        Me.RadSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
        Me.ToolTabStrip6 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.lv_lots = New Telerik.WinControls.UI.RadListView()
        Me.ToolTabStrip5 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
        Me.lv_manpower = New Telerik.WinControls.UI.RadListView()
        Me.ToolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        Me.ToolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
        CType(Me.DocumentContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer2.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.ToolWindow2.SuspendLayout()
        CType(Me.lbl_job_ticket_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_generate_report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_schedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadSplitContainer2.SuspendLayout()
        CType(Me.ToolTabStrip6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip6.SuspendLayout()
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip3.SuspendLayout()
        Me.ToolWindow1.SuspendLayout()
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolTabStrip5.SuspendLayout()
        Me.ToolWindow3.SuspendLayout()
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DocumentContainer2
        '
        Me.DocumentContainer2.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer2.Name = "DocumentContainer2"
        '
        '
        '
        Me.DocumentContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentContainer2.SizeInfo.AbsoluteSize = New System.Drawing.Size(818, 365)
        Me.DocumentContainer2.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer2.SizeInfo.SplitterCorrection = New System.Drawing.Size(-748, -157)
        Me.DocumentContainer2.TabIndex = 3
        Me.DocumentContainer2.UseSplitterButtons = True
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
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(854, 614)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.rpt_job_ticket)
        Me.DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow1.Size = New System.Drawing.Size(842, 579)
        Me.DocumentWindow1.Text = "Generate Harcdcopy"
        Me.DocumentWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'rpt_job_ticket
        '
        Me.rpt_job_ticket.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rpt_job_ticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpt_job_ticket.Location = New System.Drawing.Point(0, 0)
        Me.rpt_job_ticket.Name = "rpt_job_ticket"
        Me.rpt_job_ticket.Size = New System.Drawing.Size(842, 579)
        Me.rpt_job_ticket.TabIndex = 0
        Me.rpt_job_ticket.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.ToolWindow2
        Me.RadDock1.Controls.Add(Me.RadSplitContainer2)
        Me.RadDock1.Controls.Add(Me.DocumentContainer2)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer2
        Me.RadDock1.Name = "RadDock1"
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDock1.Size = New System.Drawing.Size(1311, 624)
        Me.RadDock1.TabIndex = 1
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        Me.RadDock1.UseSplitterButtons = True
        '
        'ToolWindow2
        '
        Me.ToolWindow2.Caption = Nothing
        Me.ToolWindow2.Controls.Add(Me.lbl_job_ticket_no)
        Me.ToolWindow2.Controls.Add(Me.btn_generate_report)
        Me.ToolWindow2.Controls.Add(Me.lv_schedule)
        Me.ToolWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow2.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow2.Name = "ToolWindow2"
        Me.ToolWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow2.Size = New System.Drawing.Size(441, 137)
        Me.ToolWindow2.Text = "Job Ticket Scheduled"
        Me.ToolWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lbl_job_ticket_no
        '
        Me.lbl_job_ticket_no.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_job_ticket_no.BackColor = System.Drawing.Color.Transparent
        Me.lbl_job_ticket_no.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lbl_job_ticket_no.Location = New System.Drawing.Point(6, 7)
        Me.lbl_job_ticket_no.Name = "lbl_job_ticket_no"
        Me.lbl_job_ticket_no.Size = New System.Drawing.Size(97, 18)
        Me.lbl_job_ticket_no.TabIndex = 33
        Me.lbl_job_ticket_no.Text = "JOB TICKET NO.:"
        '
        'btn_generate_report
        '
        Me.btn_generate_report.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate_report.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btn_generate_report.Location = New System.Drawing.Point(328, 3)
        Me.btn_generate_report.Name = "btn_generate_report"
        Me.btn_generate_report.Size = New System.Drawing.Size(110, 24)
        Me.btn_generate_report.TabIndex = 1
        Me.btn_generate_report.Text = "Generate Report"
        '
        'lv_schedule
        '
        Me.lv_schedule.AllowColumnReorder = False
        Me.lv_schedule.AllowEdit = False
        Me.lv_schedule.AllowRemove = False
        Me.lv_schedule.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_schedule.ItemSpacing = -1
        Me.lv_schedule.Location = New System.Drawing.Point(3, 31)
        Me.lv_schedule.Name = "lv_schedule"
        Me.lv_schedule.SelectLastAddedItem = False
        Me.lv_schedule.Size = New System.Drawing.Size(435, 97)
        Me.lv_schedule.TabIndex = 0
        Me.lv_schedule.Text = "RadListView1"
        Me.lv_schedule.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadSplitContainer2
        '
        Me.RadSplitContainer2.Controls.Add(Me.ToolTabStrip6)
        Me.RadSplitContainer2.Controls.Add(Me.ToolTabStrip3)
        Me.RadSplitContainer2.Controls.Add(Me.ToolTabStrip5)
        Me.RadSplitContainer2.IsCleanUpTarget = True
        Me.RadSplitContainer2.Location = New System.Drawing.Point(5, 5)
        Me.RadSplitContainer2.Name = "RadSplitContainer2"
        Me.RadSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RadSplitContainer2.Padding = New System.Windows.Forms.Padding(5)
        '
        '
        '
        Me.RadSplitContainer2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadSplitContainer2.Size = New System.Drawing.Size(443, 614)
        Me.RadSplitContainer2.SizeInfo.AbsoluteSize = New System.Drawing.Size(443, 200)
        Me.RadSplitContainer2.SizeInfo.SplitterCorrection = New System.Drawing.Size(243, 0)
        Me.RadSplitContainer2.TabIndex = 7
        Me.RadSplitContainer2.TabStop = False
        Me.RadSplitContainer2.UseSplitterButtons = True
        '
        'ToolTabStrip6
        '
        Me.ToolTabStrip6.CanUpdateChildIndex = True
        Me.ToolTabStrip6.Controls.Add(Me.ToolWindow2)
        Me.ToolTabStrip6.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip6.Name = "ToolTabStrip6"
        '
        '
        '
        Me.ToolTabStrip6.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.ToolTabStrip6.SelectedIndex = 0
        Me.ToolTabStrip6.Size = New System.Drawing.Size(443, 161)
        Me.ToolTabStrip6.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.06717949!)
        Me.ToolTabStrip6.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -44)
        Me.ToolTabStrip6.TabIndex = 8
        Me.ToolTabStrip6.TabStop = False
        '
        'ToolTabStrip3
        '
        Me.ToolTabStrip3.CanUpdateChildIndex = True
        Me.ToolTabStrip3.Controls.Add(Me.ToolWindow1)
        Me.ToolTabStrip3.Location = New System.Drawing.Point(0, 165)
        Me.ToolTabStrip3.Name = "ToolTabStrip3"
        '
        '
        '
        Me.ToolTabStrip3.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.ToolTabStrip3.SelectedIndex = 0
        Me.ToolTabStrip3.Size = New System.Drawing.Size(443, 153)
        Me.ToolTabStrip3.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, -0.08102565!)
        Me.ToolTabStrip3.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, -53)
        Me.ToolTabStrip3.TabIndex = 9
        Me.ToolTabStrip3.TabStop = False
        '
        'ToolWindow1
        '
        Me.ToolWindow1.Caption = Nothing
        Me.ToolWindow1.Controls.Add(Me.lv_lots)
        Me.ToolWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow1.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow1.Name = "ToolWindow1"
        Me.ToolWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow1.Size = New System.Drawing.Size(441, 129)
        Me.ToolWindow1.Text = "Job Ticket Lots"
        Me.ToolWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_lots
        '
        Me.lv_lots.AllowColumnReorder = False
        Me.lv_lots.AllowEdit = False
        Me.lv_lots.AllowRemove = False
        Me.lv_lots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lots.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_lots.ItemSpacing = -1
        Me.lv_lots.Location = New System.Drawing.Point(3, 2)
        Me.lv_lots.Name = "lv_lots"
        Me.lv_lots.SelectLastAddedItem = False
        Me.lv_lots.Size = New System.Drawing.Size(435, 120)
        Me.lv_lots.TabIndex = 1
        Me.lv_lots.Text = "RadListView2"
        Me.lv_lots.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'ToolTabStrip5
        '
        Me.ToolTabStrip5.CanUpdateChildIndex = True
        Me.ToolTabStrip5.Controls.Add(Me.ToolWindow3)
        Me.ToolTabStrip5.Location = New System.Drawing.Point(0, 322)
        Me.ToolTabStrip5.Name = "ToolTabStrip5"
        '
        '
        '
        Me.ToolTabStrip5.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.ToolTabStrip5.SelectedIndex = 0
        Me.ToolTabStrip5.Size = New System.Drawing.Size(443, 292)
        Me.ToolTabStrip5.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0!, 0.1482051!)
        Me.ToolTabStrip5.SizeInfo.SplitterCorrection = New System.Drawing.Size(0, 218)
        Me.ToolTabStrip5.TabIndex = 7
        Me.ToolTabStrip5.TabStop = False
        '
        'ToolWindow3
        '
        Me.ToolWindow3.Caption = Nothing
        Me.ToolWindow3.Controls.Add(Me.lv_manpower)
        Me.ToolWindow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolWindow3.Location = New System.Drawing.Point(1, 22)
        Me.ToolWindow3.Name = "ToolWindow3"
        Me.ToolWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked
        Me.ToolWindow3.Size = New System.Drawing.Size(441, 268)
        Me.ToolWindow3.Text = "Job Ticket Manpowers"
        Me.ToolWindow3.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'lv_manpower
        '
        Me.lv_manpower.AllowColumnReorder = False
        Me.lv_manpower.AllowEdit = False
        Me.lv_manpower.AllowRemove = False
        Me.lv_manpower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_manpower.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_manpower.ItemSpacing = -1
        Me.lv_manpower.Location = New System.Drawing.Point(3, 3)
        Me.lv_manpower.Name = "lv_manpower"
        Me.lv_manpower.SelectLastAddedItem = False
        Me.lv_manpower.Size = New System.Drawing.Size(435, 252)
        Me.lv_manpower.TabIndex = 2
        Me.lv_manpower.Text = "RadListView3"
        Me.lv_manpower.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'ToolTabStrip4
        '
        Me.ToolTabStrip4.CanUpdateChildIndex = True
        Me.ToolTabStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip4.Name = "ToolTabStrip4"
        '
        '
        '
        Me.ToolTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip4.SelectedIndex = 0
        Me.ToolTabStrip4.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip4.TabIndex = 0
        Me.ToolTabStrip4.TabStop = False
        '
        'ToolTabStrip1
        '
        Me.ToolTabStrip1.CanUpdateChildIndex = True
        Me.ToolTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolTabStrip1.Name = "ToolTabStrip1"
        '
        '
        '
        Me.ToolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
        Me.ToolTabStrip1.SelectedIndex = 0
        Me.ToolTabStrip1.Size = New System.Drawing.Size(200, 200)
        Me.ToolTabStrip1.TabIndex = 0
        Me.ToolTabStrip1.TabStop = False
        '
        'Frm_scheduled_review_ticket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 624)
        Me.Controls.Add(Me.RadDock1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_scheduled_review_ticket"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_scheduled_review_ticket"
        CType(Me.DocumentContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer2.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.ToolWindow2.ResumeLayout(False)
        Me.ToolWindow2.PerformLayout()
        CType(Me.lbl_job_ticket_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_generate_report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_schedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadSplitContainer2.ResumeLayout(False)
        CType(Me.ToolTabStrip6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip6.ResumeLayout(False)
        CType(Me.ToolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip3.ResumeLayout(False)
        Me.ToolWindow1.ResumeLayout(False)
        CType(Me.lv_lots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolTabStrip5.ResumeLayout(False)
        Me.ToolWindow3.ResumeLayout(False)
        CType(Me.lv_manpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DocumentContainer2 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents ToolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents RadSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
    Friend WithEvents ToolTabStrip6 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents ToolTabStrip5 As Telerik.WinControls.UI.Docking.ToolTabStrip
    Friend WithEvents ToolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents lv_schedule As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_lots As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_manpower As Telerik.WinControls.UI.RadListView
    Friend WithEvents rpt_job_ticket As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents btn_generate_report As Telerik.WinControls.UI.RadButton
    Friend WithEvents lbl_job_ticket_no As Telerik.WinControls.UI.RadLabel
End Class

