<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_job_ticket_posting_accomplishment
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
        Me.RadDock1 = New Telerik.WinControls.UI.Docking.RadDock()
        Me.DocumentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.txt_search = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.lv_jobticket_for_posting = New Telerik.WinControls.UI.RadListView()
        Me.btn_post_all = New Telerik.WinControls.UI.RadButton()
        Me.DocumentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
        Me.DocumentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentTabStrip2 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
        Me.DocumentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
        Me.cms_menu_posting = New Telerik.WinControls.UI.RadContextMenu(Me.components)
        Me.refresh = New Telerik.WinControls.UI.RadMenuItem()
        Me.RadMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
        Me.check = New Telerik.WinControls.UI.RadMenuItem()
        Me.uncheck = New Telerik.WinControls.UI.RadMenuItem()
        Me.lv_mapower_info = New Telerik.WinControls.UI.RadListView()
        Me.lv_lots_info = New Telerik.WinControls.UI.RadListView()
        Me.lv_scheduled_info = New Telerik.WinControls.UI.RadListView()
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadDock1.SuspendLayout()
        Me.DocumentWindow2.SuspendLayout()
        CType(Me.txt_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_jobticket_for_posting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_post_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentContainer1.SuspendLayout()
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip1.SuspendLayout()
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DocumentTabStrip2.SuspendLayout()
        Me.DocumentWindow1.SuspendLayout()
        CType(Me.lv_mapower_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_lots_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lv_scheduled_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDock1
        '
        Me.RadDock1.ActiveWindow = Me.DocumentWindow2
        Me.RadDock1.Controls.Add(Me.DocumentContainer1)
        Me.RadDock1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDock1.IsCleanUpTarget = True
        Me.RadDock1.Location = New System.Drawing.Point(0, 0)
        Me.RadDock1.MainDocumentContainer = Me.DocumentContainer1
        Me.RadDock1.Name = "RadDock1"
        '
        '
        '
        Me.RadDock1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.RadDock1.Size = New System.Drawing.Size(1309, 677)
        Me.RadDock1.TabIndex = 0
        Me.RadDock1.TabStop = False
        Me.RadDock1.Text = "RadDock1"
        '
        'DocumentWindow2
        '
        Me.DocumentWindow2.Controls.Add(Me.txt_search)
        Me.DocumentWindow2.Controls.Add(Me.RadLabel3)
        Me.DocumentWindow2.Controls.Add(Me.lv_jobticket_for_posting)
        Me.DocumentWindow2.Controls.Add(Me.btn_post_all)
        Me.DocumentWindow2.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow2.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow2.Name = "DocumentWindow2"
        Me.DocumentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow2.Size = New System.Drawing.Size(552, 632)
        Me.DocumentWindow2.Text = "Job Ticket List for Posting"
        Me.DocumentWindow2.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(148, 8)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.NullText = "<Optional>"
        Me.txt_search.Size = New System.Drawing.Size(222, 20)
        Me.txt_search.TabIndex = 110
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(3, 9)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(146, 18)
        Me.RadLabel3.TabIndex = 109
        Me.RadLabel3.Text = "Search Job Ticket Number"
        '
        'lv_jobticket_for_posting
        '
        Me.lv_jobticket_for_posting.AllowColumnReorder = False
        Me.lv_jobticket_for_posting.AllowEdit = False
        Me.lv_jobticket_for_posting.AllowRemove = False
        Me.lv_jobticket_for_posting.CheckOnClickMode = Telerik.WinControls.UI.CheckOnClickMode.FirstClick
        Me.lv_jobticket_for_posting.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lv_jobticket_for_posting.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_jobticket_for_posting.ItemSpacing = -1
        Me.lv_jobticket_for_posting.Location = New System.Drawing.Point(0, 34)
        Me.lv_jobticket_for_posting.Name = "lv_jobticket_for_posting"
        Me.lv_jobticket_for_posting.SelectLastAddedItem = False
        Me.lv_jobticket_for_posting.ShowCheckBoxes = True
        Me.lv_jobticket_for_posting.Size = New System.Drawing.Size(552, 550)
        Me.lv_jobticket_for_posting.TabIndex = 0
        Me.lv_jobticket_for_posting.Text = "RadListView1"
        Me.lv_jobticket_for_posting.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'btn_post_all
        '
        Me.btn_post_all.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_post_all.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btn_post_all.Location = New System.Drawing.Point(0, 584)
        Me.btn_post_all.Name = "btn_post_all"
        Me.btn_post_all.Size = New System.Drawing.Size(552, 48)
        Me.btn_post_all.TabIndex = 111
        Me.btn_post_all.Text = "Post All Check Item"
        '
        'DocumentContainer1
        '
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip1)
        Me.DocumentContainer1.Controls.Add(Me.DocumentTabStrip2)
        Me.DocumentContainer1.Name = "DocumentContainer1"
        '
        '
        '
        Me.DocumentContainer1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
        Me.DocumentContainer1.UseSplitterButtons = True
        '
        'DocumentTabStrip1
        '
        Me.DocumentTabStrip1.CanUpdateChildIndex = True
        Me.DocumentTabStrip1.Controls.Add(Me.DocumentWindow2)
        Me.DocumentTabStrip1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentTabStrip1.Name = "DocumentTabStrip1"
        '
        '
        '
        Me.DocumentTabStrip1.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentTabStrip1.SelectedIndex = 0
        Me.DocumentTabStrip1.Size = New System.Drawing.Size(564, 667)
        Me.DocumentTabStrip1.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.06447875!, 0!)
        Me.DocumentTabStrip1.SizeInfo.SplitterCorrection = New System.Drawing.Size(-84, 0)
        Me.DocumentTabStrip1.TabIndex = 0
        Me.DocumentTabStrip1.TabStop = False
        '
        'DocumentTabStrip2
        '
        Me.DocumentTabStrip2.CanUpdateChildIndex = True
        Me.DocumentTabStrip2.Controls.Add(Me.DocumentWindow1)
        Me.DocumentTabStrip2.Location = New System.Drawing.Point(568, 0)
        Me.DocumentTabStrip2.Name = "DocumentTabStrip2"
        '
        '
        '
        Me.DocumentTabStrip2.RootElement.MinSize = New System.Drawing.Size(0, 0)
        Me.DocumentTabStrip2.SelectedIndex = 0
        Me.DocumentTabStrip2.Size = New System.Drawing.Size(731, 667)
        Me.DocumentTabStrip2.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.06447875!, 0!)
        Me.DocumentTabStrip2.SizeInfo.SplitterCorrection = New System.Drawing.Size(84, 0)
        Me.DocumentTabStrip2.TabIndex = 1
        Me.DocumentTabStrip2.TabStop = False
        '
        'DocumentWindow1
        '
        Me.DocumentWindow1.Controls.Add(Me.lv_scheduled_info)
        Me.DocumentWindow1.Controls.Add(Me.lv_lots_info)
        Me.DocumentWindow1.Controls.Add(Me.lv_mapower_info)
        Me.DocumentWindow1.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None
        Me.DocumentWindow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocumentWindow1.Location = New System.Drawing.Point(6, 29)
        Me.DocumentWindow1.Name = "DocumentWindow1"
        Me.DocumentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument
        Me.DocumentWindow1.Size = New System.Drawing.Size(719, 632)
        Me.DocumentWindow1.Text = "Job Ticket Information"
        Me.DocumentWindow1.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.None
        '
        'cms_menu_posting
        '
        Me.cms_menu_posting.Items.AddRange(New Telerik.WinControls.RadItem() {Me.refresh, Me.RadMenuSeparatorItem1, Me.check, Me.uncheck})
        '
        'refresh
        '
        Me.refresh.Name = "refresh"
        Me.refresh.Text = "Refresh Data"
        '
        'RadMenuSeparatorItem1
        '
        Me.RadMenuSeparatorItem1.Name = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.Text = "RadMenuSeparatorItem1"
        Me.RadMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'check
        '
        Me.check.Name = "check"
        Me.check.Text = "Check all"
        '
        'uncheck
        '
        Me.uncheck.Name = "uncheck"
        Me.uncheck.Text = "Uncheck all"
        '
        'lv_mapower_info
        '
        Me.lv_mapower_info.AllowColumnReorder = False
        Me.lv_mapower_info.AllowEdit = False
        Me.lv_mapower_info.AllowRemove = False
        Me.lv_mapower_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lv_mapower_info.ItemSpacing = -1
        Me.lv_mapower_info.Location = New System.Drawing.Point(0, 423)
        Me.lv_mapower_info.Name = "lv_mapower_info"
        Me.lv_mapower_info.SelectLastAddedItem = False
        Me.lv_mapower_info.Size = New System.Drawing.Size(719, 209)
        Me.lv_mapower_info.TabIndex = 0
        Me.lv_mapower_info.Text = "RadListView1"
        Me.lv_mapower_info.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'lv_lots_info
        '
        Me.lv_lots_info.AllowColumnReorder = False
        Me.lv_lots_info.AllowEdit = False
        Me.lv_lots_info.AllowRemove = False
        Me.lv_lots_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lv_lots_info.ItemSpacing = -1
        Me.lv_lots_info.Location = New System.Drawing.Point(0, 214)
        Me.lv_lots_info.Name = "lv_lots_info"
        Me.lv_lots_info.SelectLastAddedItem = False
        Me.lv_lots_info.Size = New System.Drawing.Size(719, 209)
        Me.lv_lots_info.TabIndex = 1
        Me.lv_lots_info.Text = "RadListView2"
        Me.lv_lots_info.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'lv_scheduled_info
        '
        Me.lv_scheduled_info.AllowColumnReorder = False
        Me.lv_scheduled_info.AllowEdit = False
        Me.lv_scheduled_info.AllowRemove = False
        Me.lv_scheduled_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lv_scheduled_info.ItemSpacing = -1
        Me.lv_scheduled_info.Location = New System.Drawing.Point(0, 5)
        Me.lv_scheduled_info.Name = "lv_scheduled_info"
        Me.lv_scheduled_info.SelectLastAddedItem = False
        Me.lv_scheduled_info.Size = New System.Drawing.Size(719, 209)
        Me.lv_scheduled_info.TabIndex = 2
        Me.lv_scheduled_info.Text = "RadListView3"
        Me.lv_scheduled_info.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'Frm_job_ticket_posting_accomplishment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 677)
        Me.Controls.Add(Me.RadDock1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_job_ticket_posting_accomplishment"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_job_ticket_posting_accomplishment"
        CType(Me.RadDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadDock1.ResumeLayout(False)
        Me.DocumentWindow2.ResumeLayout(False)
        Me.DocumentWindow2.PerformLayout()
        CType(Me.txt_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_jobticket_for_posting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_post_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentContainer1.ResumeLayout(False)
        CType(Me.DocumentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip1.ResumeLayout(False)
        CType(Me.DocumentTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DocumentTabStrip2.ResumeLayout(False)
        Me.DocumentWindow1.ResumeLayout(False)
        CType(Me.lv_mapower_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_lots_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lv_scheduled_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadDock1 As Telerik.WinControls.UI.Docking.RadDock
    Friend WithEvents DocumentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
    Friend WithEvents DocumentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents DocumentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
    Friend WithEvents DocumentTabStrip2 As Telerik.WinControls.UI.Docking.DocumentTabStrip
    Friend WithEvents lv_jobticket_for_posting As Telerik.WinControls.UI.RadListView
    Friend WithEvents txt_search As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_post_all As Telerik.WinControls.UI.RadButton
    Friend WithEvents cms_menu_posting As Telerik.WinControls.UI.RadContextMenu
    Friend WithEvents refresh As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents RadMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
    Friend WithEvents check As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents uncheck As Telerik.WinControls.UI.RadMenuItem
    Friend WithEvents lv_scheduled_info As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_lots_info As Telerik.WinControls.UI.RadListView
    Friend WithEvents lv_mapower_info As Telerik.WinControls.UI.RadListView
End Class

