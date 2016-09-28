<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_job_ticket_cancellation
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
        Me.gb_manpower_data = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_schedule_dtl_manpower = New Telerik.WinControls.UI.RadListView()
        Me.gb_manpower_menu = New Telerik.WinControls.UI.RadGroupBox()
        Me.btn_delete_manpower_queued_data = New Telerik.WinControls.UI.RadButton()
        Me.dp_manpower_name = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.btn_add_manpower_name = New Telerik.WinControls.UI.RadButton()
        CType(Me.gb_manpower_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_manpower_data.SuspendLayout()
        CType(Me.lv_schedule_dtl_manpower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_manpower_menu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_manpower_menu.SuspendLayout()
        CType(Me.btn_delete_manpower_queued_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dp_manpower_name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add_manpower_name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb_manpower_data
        '
        Me.gb_manpower_data.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_manpower_data.Controls.Add(Me.lv_schedule_dtl_manpower)
        Me.gb_manpower_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gb_manpower_data.HeaderText = ""
        Me.gb_manpower_data.Location = New System.Drawing.Point(0, 52)
        Me.gb_manpower_data.Name = "gb_manpower_data"
        Me.gb_manpower_data.Size = New System.Drawing.Size(754, 328)
        Me.gb_manpower_data.TabIndex = 7
        '
        'lv_schedule_dtl_manpower
        '
        Me.lv_schedule_dtl_manpower.AllowColumnReorder = False
        Me.lv_schedule_dtl_manpower.AllowEdit = False
        Me.lv_schedule_dtl_manpower.AllowRemove = False
        Me.lv_schedule_dtl_manpower.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_schedule_dtl_manpower.ItemSpacing = -1
        Me.lv_schedule_dtl_manpower.Location = New System.Drawing.Point(5, 6)
        Me.lv_schedule_dtl_manpower.Name = "lv_schedule_dtl_manpower"
        Me.lv_schedule_dtl_manpower.SelectLastAddedItem = False
        Me.lv_schedule_dtl_manpower.Size = New System.Drawing.Size(744, 317)
        Me.lv_schedule_dtl_manpower.TabIndex = 2
        Me.lv_schedule_dtl_manpower.Text = "RadListView1"
        Me.lv_schedule_dtl_manpower.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'gb_manpower_menu
        '
        Me.gb_manpower_menu.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.gb_manpower_menu.Controls.Add(Me.btn_delete_manpower_queued_data)
        Me.gb_manpower_menu.Controls.Add(Me.dp_manpower_name)
        Me.gb_manpower_menu.Controls.Add(Me.RadLabel6)
        Me.gb_manpower_menu.Controls.Add(Me.btn_add_manpower_name)
        Me.gb_manpower_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.gb_manpower_menu.HeaderText = ""
        Me.gb_manpower_menu.Location = New System.Drawing.Point(0, 0)
        Me.gb_manpower_menu.Name = "gb_manpower_menu"
        Me.gb_manpower_menu.Size = New System.Drawing.Size(754, 52)
        Me.gb_manpower_menu.TabIndex = 6
        '
        'btn_delete_manpower_queued_data
        '
        Me.btn_delete_manpower_queued_data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete_manpower_queued_data.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete_manpower_queued_data.Location = New System.Drawing.Point(635, 18)
        Me.btn_delete_manpower_queued_data.Name = "btn_delete_manpower_queued_data"
        Me.btn_delete_manpower_queued_data.Size = New System.Drawing.Size(111, 27)
        Me.btn_delete_manpower_queued_data.TabIndex = 119
        Me.btn_delete_manpower_queued_data.Text = "DELETE ITEM QUEUED"
        '
        'dp_manpower_name
        '
        Me.dp_manpower_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dp_manpower_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dp_manpower_name.Location = New System.Drawing.Point(10, 25)
        Me.dp_manpower_name.Name = "dp_manpower_name"
        Me.dp_manpower_name.NullText = "<ex. jerome macadangdang>"
        '
        '
        '
        Me.dp_manpower_name.RootElement.StretchVertically = True
        Me.dp_manpower_name.Size = New System.Drawing.Size(487, 20)
        Me.dp_manpower_name.TabIndex = 118
        '
        'RadLabel6
        '
        Me.RadLabel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(10, 5)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(217, 18)
        Me.RadLabel6.TabIndex = 117
        Me.RadLabel6.Text = "Add Manpower:  (Firsrtname Lastname)"
        '
        'btn_add_manpower_name
        '
        Me.btn_add_manpower_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add_manpower_name.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.btn_add_manpower_name.Location = New System.Drawing.Point(532, 18)
        Me.btn_add_manpower_name.Name = "btn_add_manpower_name"
        Me.btn_add_manpower_name.Size = New System.Drawing.Size(101, 27)
        Me.btn_add_manpower_name.TabIndex = 115
        Me.btn_add_manpower_name.Text = "ADD TO QUEUE"
        '
        'Frm_job_ticket_cancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 380)
        Me.Controls.Add(Me.gb_manpower_data)
        Me.Controls.Add(Me.gb_manpower_menu)
        Me.Name = "Frm_job_ticket_cancellation"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Frm_job_ticket_cancellation"
        CType(Me.gb_manpower_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_manpower_data.ResumeLayout(False)
        CType(Me.lv_schedule_dtl_manpower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_manpower_menu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_manpower_menu.ResumeLayout(False)
        Me.gb_manpower_menu.PerformLayout()
        CType(Me.btn_delete_manpower_queued_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dp_manpower_name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add_manpower_name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_manpower_data As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lv_schedule_dtl_manpower As Telerik.WinControls.UI.RadListView
    Friend WithEvents gb_manpower_menu As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents btn_delete_manpower_queued_data As Telerik.WinControls.UI.RadButton
    Friend WithEvents dp_manpower_name As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents btn_add_manpower_name As Telerik.WinControls.UI.RadButton
End Class

