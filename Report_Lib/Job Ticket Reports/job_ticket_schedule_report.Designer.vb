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
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup9 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.job_ticket_objdatasource = New Telerik.Reporting.ObjectDataSource()
        Me.All_ticket_dataset_review = New Report_Lib.All_ticket_dataset()
        Me.PageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.job_ticket_lots = New Telerik.Reporting.ObjectDataSource()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.List1 = New Telerik.Reporting.List()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.titleTextBox = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        CType(Me.All_ticket_dataset_review, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000012218952179R)
        Me.detail.Name = "detail"
        '
        'job_ticket_objdatasource
        '
        Me.job_ticket_objdatasource.DataSource = Me.All_ticket_dataset_review
        Me.job_ticket_objdatasource.Name = "job_ticket_objdatasource"
        '
        'All_ticket_dataset_review
        '
        Me.All_ticket_dataset_review.DataSetName = "All_ticket_dataset"
        Me.All_ticket_dataset_review.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PageFooterSection1
        '
        Me.PageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.PageFooterSection1.Name = "PageFooterSection1"
        '
        'job_ticket_lots
        '
        Me.job_ticket_lots.DataSource = GetType(Report_Lib.All_ticket_dataset.lots_ticketDataTable)
        Me.job_ticket_lots.Name = "job_ticket_lots"
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.7999997138977051R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel3, Me.List1, Me.TextBox22})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        '
        'Panel3
        '
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926R), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.3229565620422363R), Telerik.Reporting.Drawing.Unit.Inch(0.50000017881393433R))
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = False
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2708336114883423R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox12.Style.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox12.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox12.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox12.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Outset
        Me.TextBox12.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed
        Me.TextBox12.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.StyleName = ""
        Me.TextBox12.Value = "Remaining Area"
        '
        'TextBox9
        '
        Me.TextBox9.CanGrow = False
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox9.Style.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox9.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox9.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox9.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox9.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox9.Style.Font.Bold = True
        Me.TextBox9.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed
        Me.TextBox9.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.StyleName = ""
        Me.TextBox9.Value = "Actual Area"
        '
        'TextBox8
        '
        Me.TextBox8.CanGrow = False
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1770833730697632R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox8.Style.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox8.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox8.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox8.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox8.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed
        Me.TextBox8.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox8.Value = "Current Area"
        '
        'TextBox6
        '
        Me.TextBox6.CanGrow = False
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3437492847442627R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox6.Style.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox6.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox6.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox6.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox6.Style.Font.Bold = True
        Me.TextBox6.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed
        Me.TextBox6.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.TextBox6.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox6.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox6.Value = "Operation"
        '
        'TextBox3
        '
        Me.TextBox3.CanGrow = False
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5312495231628418R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox3.Style.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.TextBox3.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox3.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox3.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox3.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox3.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox3.Style.Font.Bold = True
        Me.TextBox3.Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Dashed
        Me.TextBox3.Style.LineWidth = Telerik.Reporting.Drawing.Unit.Inch(0.5R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "Lot No."
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = False
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2708336114883423R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox13.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox13.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox13.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox13.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.StyleName = ""
        '
        'TextBox11
        '
        Me.TextBox11.CanGrow = False
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox11.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox11.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox11.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox11.StyleName = ""
        '
        'TextBox5
        '
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1770846843719482R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox5.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox5.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox5.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox5.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox5.StyleName = ""
        Me.TextBox5.Value = "= Fields.curr_area"
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3437495231628418R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox10.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox10.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox10.StyleName = ""
        Me.TextBox10.Value = "= Fields.operation_performed"
        '
        'TextBox17
        '
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5312492847442627R), Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R))
        Me.TextBox17.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox17.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.[Double]
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.StyleName = ""
        Me.TextBox17.Value = "= Fields.lot_no"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.5312492847442627R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.3437495231628418R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.1770846843719482R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(0.99999988079071045R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(1.2708332538604736R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.2395833283662796R)))
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox11)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox13)
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox17)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox10)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox5)
        TableGroup1.Name = "tableGroup"
        TableGroup1.ReportItem = Me.TextBox3
        TableGroup2.Name = "tableGroup1"
        TableGroup2.ReportItem = Me.TextBox6
        TableGroup3.Name = "tableGroup2"
        TableGroup3.ReportItem = Me.TextBox8
        TableGroup4.Name = "group"
        TableGroup4.ReportItem = Me.TextBox9
        TableGroup5.Name = "group1"
        TableGroup5.ReportItem = Me.TextBox12
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.DataSource = Me.job_ticket_lots
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox17, Me.TextBox10, Me.TextBox5, Me.TextBox11, Me.TextBox13, Me.TextBox3, Me.TextBox6, Me.TextBox8, Me.TextBox9, Me.TextBox12})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.000039339065551757812R), Telerik.Reporting.Drawing.Unit.Inch(0R))
        Me.Table1.Name = "Table1"
        Me.Table1.NoDataStyle.Visible = True
        TableGroup6.Name = "detailTableGroup"
        Me.Table1.RowGroups.Add(TableGroup6)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(7.3229165077209473R), Telerik.Reporting.Drawing.Unit.Inch(0.4791666567325592R))
        '
        'List1
        '
        Me.List1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R)))
        Me.List1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R)))
        Me.List1.Body.SetCellContent(0, 0, Me.TextBox14)
        TableGroup7.Name = "group4"
        Me.List1.ColumnGroups.Add(TableGroup7)
        Me.List1.DataSource = Me.job_ticket_lots
        Me.List1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox14})
        Me.List1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.90007895231246948R), Telerik.Reporting.Drawing.Unit.Inch(0.099999904632568359R))
        Me.List1.Name = "List1"
        TableGroup9.Name = "group2"
        TableGroup8.ChildGroups.Add(TableGroup9)
        TableGroup8.Name = "DetailGroup"
        Me.List1.RowGroups.Add(TableGroup8)
        Me.List1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        '
        'TextBox14
        '
        Me.TextBox14.Multiline = False
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158R), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224R))
        Me.TextBox14.StyleName = ""
        Me.TextBox14.Value = "= Fields.location"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.7000001668930054R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.titleTextBox, Me.Panel2, Me.Panel1, Me.TextBox4, Me.TextBox2, Me.TextBox1, Me.TextBox15, Me.TextBox7})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
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
        'TextBox15
        '
        Me.TextBox15.Format = "{0:D}"
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5000786781311035R), Telerik.Reporting.Drawing.Unit.Inch(1.2979167699813843R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9228769540786743R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox15.Value = "= Fields.date_needed"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3938288688659668R), Telerik.Reporting.Drawing.Unit.Inch(1.312447190284729R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5812094211578369R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox7.Style.Color = System.Drawing.Color.Maroon
        Me.TextBox7.Value = "= Fields.job_ticket_no"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10003932565450668R), Telerik.Reporting.Drawing.Unit.Inch(0.099999748170375824R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.79996079206466675R), Telerik.Reporting.Drawing.Unit.Inch(0.19999997317790985R))
        Me.TextBox22.Style.Font.Bold = True
        Me.TextBox22.Style.Font.Italic = False
        Me.TextBox22.Style.Font.Name = "Times New Roman"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "Location:"
        '
        'job_ticket_schedule_report
        '
        Me.DataSource = Me.job_ticket_objdatasource
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.pageHeaderSection1, Me.detail, Me.PageFooterSection1, Me.ReportHeaderSection1})
        Me.Name = "job_ticket_schedule_report"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R), Telerik.Reporting.Drawing.Unit.Inch(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Inch(7.5R)
        CType(Me.All_ticket_dataset_review, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents All_ticket_dataset_review As All_ticket_dataset
    Friend WithEvents job_ticket_objdatasource As Telerik.Reporting.ObjectDataSource
    Friend WithEvents PageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents job_ticket_lots As Telerik.Reporting.ObjectDataSource
    Friend WithEvents ReportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents List1 As Telerik.Reporting.List
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents titleTextBox As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
End Class