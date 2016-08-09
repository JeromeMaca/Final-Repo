<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_canepoint_aprroved_reviewandprinting
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
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.txt_cp_no = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_dateneeded = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_receivingbarrio = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_receivingowner = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_total_canepoint_count = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_source_barrio = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_source_owner = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_source_lotno = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_source_variety = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_validity_date = New Telerik.WinControls.UI.RadTextBoxControl()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.txt_canepointcost = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.txt_receivables = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.txt_haulingcost = New CurrencyTextBox.CurrencyTextBox(Me.components)
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.rp_viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.txt_cp_no, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dateneeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_receivingbarrio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_receivingowner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_canepoint_count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_source_barrio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_source_owner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_source_lotno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_source_variety, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_validity_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_canepointcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_receivables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_haulingcost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.RadPanel1)
        Me.RadGroupBox1.Controls.Add(Me.txt_haulingcost)
        Me.RadGroupBox1.Controls.Add(Me.txt_receivables)
        Me.RadGroupBox1.Controls.Add(Me.txt_canepointcost)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel13)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel12)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel11)
        Me.RadGroupBox1.Controls.Add(Me.txt_validity_date)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel10)
        Me.RadGroupBox1.Controls.Add(Me.txt_source_variety)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel9)
        Me.RadGroupBox1.Controls.Add(Me.txt_source_lotno)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel8)
        Me.RadGroupBox1.Controls.Add(Me.txt_source_owner)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel7)
        Me.RadGroupBox1.Controls.Add(Me.txt_source_barrio)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.txt_total_canepoint_count)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel5)
        Me.RadGroupBox1.Controls.Add(Me.txt_receivingowner)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.txt_receivingbarrio)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.txt_dateneeded)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.txt_cp_no)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(324, 538)
        Me.RadGroupBox1.TabIndex = 0
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.rp_viewer)
        Me.RadGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(324, 0)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(731, 538)
        Me.RadGroupBox2.TabIndex = 1
        '
        'txt_cp_no
        '
        Me.txt_cp_no.IsReadOnly = True
        Me.txt_cp_no.IsReadOnlyCaretVisible = True
        Me.txt_cp_no.Location = New System.Drawing.Point(151, 159)
        Me.txt_cp_no.Name = "txt_cp_no"
        Me.txt_cp_no.NullText = "<System Generated>"
        Me.txt_cp_no.Size = New System.Drawing.Size(158, 20)
        Me.txt_cp_no.TabIndex = 155
        '
        'RadLabel2
        '
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(16, 161)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(129, 18)
        Me.RadLabel2.TabIndex = 154
        Me.RadLabel2.Text = "Canepoint Control No.:"
        '
        'txt_dateneeded
        '
        Me.txt_dateneeded.IsReadOnly = True
        Me.txt_dateneeded.IsReadOnlyCaretVisible = True
        Me.txt_dateneeded.Location = New System.Drawing.Point(101, 186)
        Me.txt_dateneeded.Name = "txt_dateneeded"
        Me.txt_dateneeded.NullText = "<System Generated>"
        Me.txt_dateneeded.Size = New System.Drawing.Size(208, 20)
        Me.txt_dateneeded.TabIndex = 157
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(16, 189)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(79, 18)
        Me.RadLabel1.TabIndex = 156
        Me.RadLabel1.Text = "Date Needed:"
        '
        'txt_receivingbarrio
        '
        Me.txt_receivingbarrio.IsReadOnly = True
        Me.txt_receivingbarrio.IsReadOnlyCaretVisible = True
        Me.txt_receivingbarrio.Location = New System.Drawing.Point(118, 213)
        Me.txt_receivingbarrio.Name = "txt_receivingbarrio"
        Me.txt_receivingbarrio.NullText = "<System Generated>"
        Me.txt_receivingbarrio.Size = New System.Drawing.Size(191, 20)
        Me.txt_receivingbarrio.TabIndex = 159
        '
        'RadLabel3
        '
        Me.RadLabel3.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(16, 216)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(96, 18)
        Me.RadLabel3.TabIndex = 158
        Me.RadLabel3.Text = "Receiving Barrio:"
        '
        'txt_receivingowner
        '
        Me.txt_receivingowner.IsReadOnly = True
        Me.txt_receivingowner.IsReadOnlyCaretVisible = True
        Me.txt_receivingowner.Location = New System.Drawing.Point(118, 240)
        Me.txt_receivingowner.Name = "txt_receivingowner"
        Me.txt_receivingowner.NullText = "<System Generated>"
        Me.txt_receivingowner.Size = New System.Drawing.Size(191, 20)
        Me.txt_receivingowner.TabIndex = 157
        '
        'RadLabel4
        '
        Me.RadLabel4.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(16, 242)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(99, 18)
        Me.RadLabel4.TabIndex = 156
        Me.RadLabel4.Text = "Receiving Owner:"
        '
        'txt_total_canepoint_count
        '
        Me.txt_total_canepoint_count.IsReadOnly = True
        Me.txt_total_canepoint_count.IsReadOnlyCaretVisible = True
        Me.txt_total_canepoint_count.Location = New System.Drawing.Point(147, 267)
        Me.txt_total_canepoint_count.Name = "txt_total_canepoint_count"
        Me.txt_total_canepoint_count.NullText = "<System Generated>"
        Me.txt_total_canepoint_count.Size = New System.Drawing.Size(162, 20)
        Me.txt_total_canepoint_count.TabIndex = 161
        Me.txt_total_canepoint_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadLabel5
        '
        Me.RadLabel5.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel5.Location = New System.Drawing.Point(16, 268)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(125, 18)
        Me.RadLabel5.TabIndex = 160
        Me.RadLabel5.Text = "Number of Canepoint:"
        '
        'txt_source_barrio
        '
        Me.txt_source_barrio.IsReadOnly = True
        Me.txt_source_barrio.IsReadOnlyCaretVisible = True
        Me.txt_source_barrio.Location = New System.Drawing.Point(101, 294)
        Me.txt_source_barrio.Name = "txt_source_barrio"
        Me.txt_source_barrio.NullText = "<System Generated>"
        Me.txt_source_barrio.Size = New System.Drawing.Size(208, 20)
        Me.txt_source_barrio.TabIndex = 163
        '
        'RadLabel6
        '
        Me.RadLabel6.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(16, 295)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(81, 18)
        Me.RadLabel6.TabIndex = 162
        Me.RadLabel6.Text = "Source Barrio:"
        '
        'txt_source_owner
        '
        Me.txt_source_owner.IsReadOnly = True
        Me.txt_source_owner.IsReadOnlyCaretVisible = True
        Me.txt_source_owner.Location = New System.Drawing.Point(105, 321)
        Me.txt_source_owner.Name = "txt_source_owner"
        Me.txt_source_owner.NullText = "<System Generated>"
        Me.txt_source_owner.Size = New System.Drawing.Size(204, 20)
        Me.txt_source_owner.TabIndex = 165
        '
        'RadLabel7
        '
        Me.RadLabel7.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel7.Location = New System.Drawing.Point(16, 321)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(84, 18)
        Me.RadLabel7.TabIndex = 164
        Me.RadLabel7.Text = "Source Owner:"
        '
        'txt_source_lotno
        '
        Me.txt_source_lotno.IsReadOnly = True
        Me.txt_source_lotno.IsReadOnlyCaretVisible = True
        Me.txt_source_lotno.Location = New System.Drawing.Point(105, 355)
        Me.txt_source_lotno.Name = "txt_source_lotno"
        Me.txt_source_lotno.NullText = "<System Generated>"
        Me.txt_source_lotno.Size = New System.Drawing.Size(204, 20)
        Me.txt_source_lotno.TabIndex = 157
        '
        'RadLabel8
        '
        Me.RadLabel8.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel8.Location = New System.Drawing.Point(16, 357)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(85, 18)
        Me.RadLabel8.TabIndex = 156
        Me.RadLabel8.Text = "Source Lot No:"
        '
        'txt_source_variety
        '
        Me.txt_source_variety.IsReadOnly = True
        Me.txt_source_variety.IsReadOnlyCaretVisible = True
        Me.txt_source_variety.Location = New System.Drawing.Point(105, 388)
        Me.txt_source_variety.Name = "txt_source_variety"
        Me.txt_source_variety.NullText = "<System Generated>"
        Me.txt_source_variety.Size = New System.Drawing.Size(204, 20)
        Me.txt_source_variety.TabIndex = 167
        '
        'RadLabel9
        '
        Me.RadLabel9.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel9.Location = New System.Drawing.Point(16, 390)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(87, 18)
        Me.RadLabel9.TabIndex = 166
        Me.RadLabel9.Text = "Source Variety:"
        '
        'txt_validity_date
        '
        Me.txt_validity_date.IsReadOnly = True
        Me.txt_validity_date.IsReadOnlyCaretVisible = True
        Me.txt_validity_date.Location = New System.Drawing.Point(151, 415)
        Me.txt_validity_date.Name = "txt_validity_date"
        Me.txt_validity_date.NullText = "<System Generated>"
        Me.txt_validity_date.Size = New System.Drawing.Size(158, 20)
        Me.txt_validity_date.TabIndex = 157
        '
        'RadLabel10
        '
        Me.RadLabel10.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel10.Location = New System.Drawing.Point(16, 415)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(136, 18)
        Me.RadLabel10.TabIndex = 156
        Me.RadLabel10.Text = "Canepoint Validity Date:"
        '
        'RadLabel11
        '
        Me.RadLabel11.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel11.Location = New System.Drawing.Point(113, 443)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(90, 18)
        Me.RadLabel11.TabIndex = 168
        Me.RadLabel11.Text = "Canepoint Cost:"
        '
        'RadLabel12
        '
        Me.RadLabel12.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel12.Location = New System.Drawing.Point(125, 469)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(78, 18)
        Me.RadLabel12.TabIndex = 157
        Me.RadLabel12.Text = "Hauling Cost:"
        '
        'RadLabel13
        '
        Me.RadLabel13.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel13.Location = New System.Drawing.Point(132, 494)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(71, 18)
        Me.RadLabel13.TabIndex = 157
        Me.RadLabel13.Text = "Receivables:"
        '
        'txt_canepointcost
        '
        Me.txt_canepointcost.Location = New System.Drawing.Point(209, 441)
        Me.txt_canepointcost.Name = "txt_canepointcost"
        Me.txt_canepointcost.ReadOnly = True
        Me.txt_canepointcost.Size = New System.Drawing.Size(100, 20)
        Me.txt_canepointcost.TabIndex = 170
        Me.txt_canepointcost.Text = "₱0.00"
        Me.txt_canepointcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_receivables
        '
        Me.txt_receivables.Location = New System.Drawing.Point(209, 493)
        Me.txt_receivables.Name = "txt_receivables"
        Me.txt_receivables.ReadOnly = True
        Me.txt_receivables.Size = New System.Drawing.Size(100, 20)
        Me.txt_receivables.TabIndex = 171
        Me.txt_receivables.Text = "₱0.00"
        Me.txt_receivables.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_haulingcost
        '
        Me.txt_haulingcost.Location = New System.Drawing.Point(209, 467)
        Me.txt_haulingcost.Name = "txt_haulingcost"
        Me.txt_haulingcost.ReadOnly = True
        Me.txt_haulingcost.Size = New System.Drawing.Size(100, 20)
        Me.txt_haulingcost.TabIndex = 170
        Me.txt_haulingcost.Text = "₱0.00"
        Me.txt_haulingcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadPanel1
        '
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RadPanel1.Location = New System.Drawing.Point(2, 18)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(320, 135)
        Me.RadPanel1.TabIndex = 172
        '
        'rp_viewer
        '
        Me.rp_viewer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rp_viewer.Location = New System.Drawing.Point(5, 4)
        Me.rp_viewer.Name = "rp_viewer"
        Me.rp_viewer.Size = New System.Drawing.Size(721, 529)
        Me.rp_viewer.TabIndex = 0
        '
        'Frm_canepoint_aprroved_reviewandprinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 538)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_canepoint_aprroved_reviewandprinting"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_canepoint_aprroved_reviewandprinting"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.txt_cp_no, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dateneeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_receivingbarrio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_receivingowner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_canepoint_count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_source_barrio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_source_owner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_source_lotno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_source_variety, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_validity_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_canepointcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_receivables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_haulingcost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents txt_cp_no As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_haulingcost As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents txt_receivables As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents txt_canepointcost As CurrencyTextBox.CurrencyTextBox
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_validity_date As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_source_variety As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_source_lotno As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_source_owner As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_source_barrio As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_total_canepoint_count As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_receivingowner As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_receivingbarrio As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txt_dateneeded As Telerik.WinControls.UI.RadTextBoxControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents rp_viewer As Microsoft.Reporting.WinForms.ReportViewer
End Class

