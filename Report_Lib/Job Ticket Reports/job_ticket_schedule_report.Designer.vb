Partial Class job_ticket_schedule_report

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.All_ticket_dataset_jt = New Report_Lib.All_ticket_dataset()
        Me.job_ticket_datasource = New Telerik.Reporting.ObjectDataSource()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        CType(Me.All_ticket_dataset_jt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.8000000715255737R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.Panel2, Me.Panel1, Me.TextBox4, Me.TextBox2, Me.TextBox1, Me.TextBox3, Me.TextBox5})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.59999990463256836R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel3})
        Me.detail.Name = "detail"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.40000024437904358R)
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'All_ticket_dataset_jt
        '
        Me.All_ticket_dataset_jt.DataSetName = "All_ticket_dataset"
        Me.All_ticket_dataset_jt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'job_ticket_datasource
        '
        Me.job_ticket_datasource.DataSource = Me.All_ticket_dataset_jt
        Me.job_ticket_datasource.Name = "job_ticket_datasource"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(0.2291666716337204R))
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.4999995231628418R), Telerik.Reporting.Drawing.Unit.Inch(0.4479166567325592R))
        Me.titleTextBox.Style.Font.Bold = True
        Me.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(25.0R)
        Me.titleTextBox.Style.LineColor = System.Drawing.Color.Maroon
        Me.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.titleTextBox.StyleName = "Title"
        Me.titleTextBox.Value = "AGRIKULTO, INC."
        '
        'Panel2
        '
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.4999995231628418R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        Me.Panel2.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel2.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel2.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'Panel1
        '
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0R), Telerik.Reporting.Drawing.Unit.Inch(1.1000000238418579R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.4791660308837891R), Telerik.Reporting.Drawing.Unit.Inch(0.0520833320915699R))
        Me.Panel1.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.Panel1.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        Me.Panel1.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.0R), Telerik.Reporting.Drawing.Unit.Inch(1.2979167699813843R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.50000005960464478R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox4.Style.Font.Bold = True
        Me.TextBox4.Style.Font.Name = "Times New Roman"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "Date:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.09375R), Telerik.Reporting.Drawing.Unit.Inch(1.2979167699813843R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000000715255737R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Italic = False
        Me.TextBox2.Style.Font.Name = "Times New Roman"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "Job Ticket No:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.6979167461395264R), Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0000002384185791R), Telerik.Reporting.Drawing.Unit.Inch(0.29996046423912048R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Calibri Light"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "TRIP TICKET SCHEDULE"
        '
        'TextBox3
        '
        Me.TextBox3.Format = "{0:D}"
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5000786781311035R), Telerik.Reporting.Drawing.Unit.Inch(1.2979167699813843R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox3.Value = "= Fields.date_needed"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3938288688659668R), Telerik.Reporting.Drawing.Unit.Inch(1.2979167699813843R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0061714649200439R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox5.Value = "= Fields.job_ticket_no"
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.09375R), Telerik.Reporting.Drawing.Unit.Inch(0.047916729003190994R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.306251049041748R), Telerik.Reporting.Drawing.Unit.Inch(0.4791666567325592R))
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.5729165077209473R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.1770834922790527R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.1770834922790527R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.99999994039535522R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.99999994039535522R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox12)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox7)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox9)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox13)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox15)
        TableGroup1.Name = "tableGroup"
        TableGroup1.ReportItem = Me.TextBox6
        TableGroup2.Name = "tableGroup1"
        TableGroup2.ReportItem = Me.TextBox8
        TableGroup3.Name = "tableGroup2"
        TableGroup3.ReportItem = Me.TextBox10
        TableGroup4.Name = "group"
        TableGroup4.ReportItem = Me.TextBox11
        TableGroup5.Name = "group1"
        TableGroup5.ReportItem = Me.TextBox14
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.DataSource = Me.job_ticket_datasource
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6, Me.TextBox8, Me.TextBox10, Me.TextBox12, Me.TextBox7, Me.TextBox9, Me.TextBox11, Me.TextBox13, Me.TextBox14, Me.TextBox15})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757812R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Table1.Name = "Table1"
        TableGroup6.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup6.Name = "detailTableGroup"
        Me.Table1.RowGroups.Add(TableGroup6)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.9270834922790527R), Telerik.Reporting.Drawing.Unit.Inch(0.4791666567325592R))
        '
        'TextBox6
        '
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5729166269302368R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox6.Value = "lot_no"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1770833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox8.Value = "operation_performed"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1770833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox10.Value = "curr_area"
        '
        'TextBox12
        '
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5729166269302368R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox12.StyleName = ""
        Me.TextBox12.Value = "= Fields.lot_no"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0062105655670166R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1770834922790527R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox7.StyleName = ""
        Me.TextBox7.Value = "= Fields.operation_performed"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.0062105655670166R), Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R))
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1770834922790527R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox9.StyleName = ""
        Me.TextBox9.Value = "= Fields.curr_area"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox11.StyleName = ""
        '
        'TextBox13
        '
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox13.StyleName = ""
        '
        'TextBox14
        '
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox14.StyleName = ""
        '
        'TextBox15
        '
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox15.StyleName = ""
        '
        'job_ticket_schedule_report
        '
        Me.DataSource = Me.job_ticket_datasource
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "job_ticket_schedule_report"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.5R)
        CType(Me.All_ticket_dataset_jt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents All_ticket_dataset_jt As All_ticket_dataset
    Friend WithEvents job_ticket_datasource As Telerik.Reporting.ObjectDataSource
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
End Class