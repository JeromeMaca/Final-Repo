<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_lot_manpower_add_queue
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
        Me.RadGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
        Me.lv_lot_man_data = New Telerik.WinControls.UI.RadListView()
        Me.RadGroupBox6 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_ST_purpose = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox5.SuspendLayout()
        CType(Me.lv_lot_man_data, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox6.SuspendLayout()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox5
        '
        Me.RadGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox5.Controls.Add(Me.lv_lot_man_data)
        Me.RadGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox5.HeaderText = ""
        Me.RadGroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox5.Name = "RadGroupBox5"
        Me.RadGroupBox5.Size = New System.Drawing.Size(464, 466)
        Me.RadGroupBox5.TabIndex = 7
        '
        'lv_lot_man_data
        '
        Me.lv_lot_man_data.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_lot_man_data.ItemSpacing = -1
        Me.lv_lot_man_data.Location = New System.Drawing.Point(5, 41)
        Me.lv_lot_man_data.Name = "lv_lot_man_data"
        Me.lv_lot_man_data.Size = New System.Drawing.Size(454, 420)
        Me.lv_lot_man_data.TabIndex = 2
        Me.lv_lot_man_data.Text = "lv_lot_man_data"
        Me.lv_lot_man_data.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView
        '
        'RadGroupBox6
        '
        Me.RadGroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox6.Controls.Add(Me.RadButton3)
        Me.RadGroupBox6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadGroupBox6.HeaderText = ""
        Me.RadGroupBox6.Location = New System.Drawing.Point(0, 466)
        Me.RadGroupBox6.Name = "RadGroupBox6"
        Me.RadGroupBox6.Size = New System.Drawing.Size(464, 41)
        Me.RadGroupBox6.TabIndex = 6
        '
        'RadButton3
        '
        Me.RadButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadButton3.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.RadButton3.Location = New System.Drawing.Point(341, 6)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(118, 30)
        Me.RadButton3.TabIndex = 115
        Me.RadButton3.Text = "Save to Queued Data"
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.txt_ST_purpose)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(464, 41)
        Me.RadGroupBox1.TabIndex = 8
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(6, 10)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel1.TabIndex = 107
        Me.RadLabel1.Text = "Search Data:"
        '
        'txt_ST_purpose
        '
        Me.txt_ST_purpose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ST_purpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ST_purpose.ForeColor = System.Drawing.Color.Black
        Me.txt_ST_purpose.Location = New System.Drawing.Point(85, 9)
        Me.txt_ST_purpose.Name = "txt_ST_purpose"
        Me.txt_ST_purpose.NullText = "<Optional>"
        Me.txt_ST_purpose.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_ST_purpose.Size = New System.Drawing.Size(367, 20)
        Me.txt_ST_purpose.TabIndex = 0
        '
        'Frm_lot_manpower_add_queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 507)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Controls.Add(Me.RadGroupBox5)
        Me.Controls.Add(Me.RadGroupBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_lot_manpower_add_queue"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_lot_manpower_add_queue"
        Me.TopMost = True
        CType(Me.RadGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox5.ResumeLayout(False)
        CType(Me.lv_lot_man_data, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox6.ResumeLayout(False)
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ST_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGroupBox5 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents lv_lot_man_data As Telerik.WinControls.UI.RadListView
    Friend WithEvents RadGroupBox6 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_ST_purpose As Telerik.WinControls.UI.RadTextBox
End Class

