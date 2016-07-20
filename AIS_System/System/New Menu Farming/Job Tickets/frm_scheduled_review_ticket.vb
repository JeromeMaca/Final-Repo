Imports Report_Lib
Public Class Frm_scheduled_review_ticket
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

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
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_scheduled_review_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scheduled_column() : lots_column() : manpower_column()

        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1','" & jt_slct_scheduled_id & "'", 3)
        glomod.populate_listview(lv_lots, "p_ais_job_ticket_scheduled_printing '2','" & jt_slct_scheduled_id & "'", 3)
        glomod.populate_listview(lv_manpower, "p_ais_job_ticket_scheduled_printing '3','" & jt_slct_scheduled_id & "'", 2)
    End Sub

    Private Sub lv_manpower_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles _
            lv_schedule.CellFormatting, lv_manpower.CellFormatting, lv_lots.CellFormatting

        glomod.lv_formats(e)
    End Sub

    Private Sub btn_generate_report_Click(sender As Object, e As EventArgs) Handles btn_generate_report.Click
        Dim instanceReportSource = New Telerik.Reporting.InstanceReportSource()
        instanceReportSource.ReportDocument = New job_ticket_schedule_report(jt_slct_scheduled_id)
        rpt_job_ticket.ReportSource = instanceReportSource
        rpt_job_ticket.RefreshReport()
    End Sub
End Class
