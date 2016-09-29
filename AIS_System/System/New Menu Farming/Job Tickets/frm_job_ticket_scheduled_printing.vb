Imports Microsoft.Reporting.WinForms
Imports Telerik.WinControls.UI.Docking

Public Class Frm_job_ticket_scheduled_printing



    Dim glomod As New global_mod
    Dim sysmod As New System_mod
    Dim print_glomod As New print_global_module

#Region "LISTVIEW COLUMNS"
    Sub scheduled_column()
        lv_schedule.Columns.Clear()

        With lv_schedule
            .Columns.Add("id", "id")
            .Columns.Add("count", "ROW NO.")
            .Columns.Add("date_n", "DATE NEEDED")
            .Columns.Add("supervised", "SUPERVISED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 80
            .Columns("date_n").Width = 150
            .Columns("supervised").Width = 200

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub

    Sub lots_column()
        lv_lots.Columns.Clear()

        With lv_lots
            .Columns.Add("id", "id")
            .Columns.Add("count", "ROW NO.")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("work_operation", "WORK OPERATION")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 80
            .Columns("lot_no").Width = 150
            .Columns("work_operation").Width = 200

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub

    Sub manpower_column()
        lv_manpower.Columns.Clear()

        With lv_manpower
            .Columns.Add("id", "id")
            .Columns.Add("count", "ROW NO.")
            .Columns.Add("manpower", "MANPOWER NAMES")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 80
            .Columns("manpower").Width = 350

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub
#End Region
    Private Sub Frm_scheduled_review_ticket_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        rpt_job_ticket.Reset()
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_job_ticket_scheduled_printing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False

        scheduled_column() : lots_column() : manpower_column()

        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1','" & jt_slct_scheduled_id & "'", 3)
        glomod.populate_listview(lv_lots, "p_ais_job_ticket_scheduled_printing '2','" & jt_slct_scheduled_id & "'", 3)
        glomod.populate_listview(lv_manpower, "p_ais_job_ticket_scheduled_printing '3','" & jt_slct_scheduled_id & "'", 2)
    End Sub
    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub

    Private Sub lv_manpower_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles _
            lv_schedule.CellFormatting, lv_manpower.CellFormatting, lv_lots.CellFormatting

        glomod.lv_formats(e)
    End Sub

    Private Sub btn_generate_report_Click(sender As Object, e As EventArgs) Handles btn_generate_report.Click
        rpt_job_ticket.ProcessingMode = ProcessingMode.Local

        With rpt_job_ticket.LocalReport
            .ReportPath = "System\All Reports RDLC\job_ticket_printing_hardcopy.rdlc"
        End With

        Dim dsCustomers As All_ticket_dataset = print_glomod.dataset_fillingup("Select [id]" _
                                                                                & ", REPLICATE('0', 6 - LEN([job_ticket_no])) + CAST([job_ticket_no] AS varchar)  [job_ticket_no]" _
                                                                                & ",[date_needed],[remarks],[officer_in_charge] FROM [agrikulto].[dbo].[tbl_ais_job_ticket_schedule_hdr]" _
                                                                                & " WHERE id='" & jt_slct_scheduled_id & "'", "scheduled_ticket")
        Dim datasource As New ReportDataSource("scheduled_ticket", dsCustomers.Tables("scheduled_ticket"))

        Dim dsCustomers1 As All_ticket_dataset = print_glomod.dataset_fillingup("SELECT [lot_no],[location],[operation_performed],[curr_area]" _
                                                                                & " FROM [agrikulto].[dbo].[tbl_ais_job_ticket_schedule_dtl_lots]" _
                                                                                & " WHERE hdr_id='" & jt_slct_scheduled_id & "'", "lots_ticket")
        Dim datasource1 As New ReportDataSource("lots_ticket", dsCustomers1.Tables("lots_ticket"))


        Dim dsCustomers2 As All_ticket_dataset = print_glomod.dataset_fillingup("SELECT [worker_name]" _
                                                                                & " FROM [agrikulto].[dbo].[tbl_ais_job_ticket_schedule_dtl_manpower]" _
                                                                                & " WHERE hdr_id='" & jt_slct_scheduled_id & "'", "manpower_ticket")
        Dim datasource2 As New ReportDataSource("manpower_ticket", dsCustomers2.Tables("manpower_ticket"))

        With rpt_job_ticket
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(datasource)
            .LocalReport.DataSources.Add(datasource1)
            .LocalReport.DataSources.Add(datasource2)
            .LocalReport.Refresh()
        End With

        With rpt_job_ticket
            .SetDisplayMode(DisplayMode.PrintLayout)
            '.SetDisplayMode(DisplayMode.Normal)
            .ZoomMode = ZoomMode.PageWidth
        End With
    End Sub
End Class
