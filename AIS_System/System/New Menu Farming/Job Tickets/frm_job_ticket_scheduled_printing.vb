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
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "TICKET NO.")
            .Columns.Add("date_n", "DATE NEEDED")
            .Columns.Add("supervised", "SUPERVISED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 50
            .Columns("ticket_no").Width = 100
            .Columns("date_n").Width = 100
            .Columns("supervised").Width = 160

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub

#End Region

    Private Sub Frm_scheduled_review_ticket_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_job_ticket_scheduled_printing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.centering_form(Me)
        scheduled_column()

        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1',''", 4)
        glomod.data_item_grouping(lv_schedule, "date_n")
    End Sub

    Private Sub btn_generate_report_Click(sender As Object, e As EventArgs) Handles btn_generate_report.Click
        rpt_job_ticket.Reset()

        Dim hdr_id = glomod.selection_listview(lv_schedule)
        rpt_job_ticket.ProcessingMode = ProcessingMode.Local

        With rpt_job_ticket.LocalReport
            .ReportPath = "System\All Reports RDLC\job_ticket_printing_hardcopy.rdlc"
        End With

        Dim dsCustomers As All_ticket_dataset = print_glomod.dataset_fillingup("Select [id]" _
                                                                                & ", REPLICATE('0', 6 - LEN([job_ticket_no])) + CAST([job_ticket_no] AS varchar)  [job_ticket_no]" _
                                                                                & ",[date_needed],[remarks],[officer_in_charge] FROM [agrikulto].[dbo].[tbl_ais_job_ticket_schedule_hdr]" _
                                                                                & " WHERE id='" & hdr_id & "'", "scheduled_ticket")
        Dim datasource As New ReportDataSource("scheduled_ticket", dsCustomers.Tables("scheduled_ticket"))

        Dim dsCustomers1 As All_ticket_dataset = print_glomod.dataset_fillingup("SELECT [lot_no],[location],[operation_performed],[curr_area]" _
                                                                                & " FROM [agrikulto].[dbo].[tbl_ais_job_ticket_schedule_dtl_lots]" _
                                                                                & " WHERE hdr_id='" & hdr_id & "'", "lots_ticket")
        Dim datasource1 As New ReportDataSource("lots_ticket", dsCustomers1.Tables("lots_ticket"))

        With rpt_job_ticket
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(datasource)
            .LocalReport.DataSources.Add(datasource1)
            .LocalReport.Refresh()
        End With

        With rpt_job_ticket
            .SetDisplayMode(DisplayMode.PrintLayout)
            '.SetDisplayMode(DisplayMode.Normal)
            .ZoomMode = ZoomMode.PageWidth
        End With
    End Sub

    Private Sub lv_schedule_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles lv_schedule.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_schedule_VisualItemFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewVisualItemEventArgs) Handles lv_schedule.VisualItemFormatting
        glomod.group_count(e)
    End Sub
End Class
