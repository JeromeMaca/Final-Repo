Imports Telerik.WinControls
Imports System.Data.SqlClient
Public Class Frm_job_ticket_for_processing_accomplishment

#Region "LISTVIEW COLUMN"
    Sub for_processing_column()
        With lv_for_processing
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("job_ticket_no", "TICKET NO")
            .Columns.Add("supervised_by", "SUPPERVISED BY")

            .Columns("id").Width = 0
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("job_ticket_no").Width = 150
            .Columns("supervised_by").Width = 250

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub

    Sub scheduled_column()
        With lv_scheduled
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("date_needed", "DATE NEEDED")
            .Columns.Add("reamrks", "REMARKS")
            .Columns.Add("encoded_date", "ENCODED DATE")
            .Columns.Add("encoded_by", "ENCODED BY")



            .Columns("id").Width = 0
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_needed").Width = 120
            .Columns("reamrks").Width = 250
            .Columns("encoded_date").Width = 120
            .Columns("encoded_by").Width = 300

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub

    Sub lots_column()
        With lv_lots
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("crop_class", "CROP CLASS")
            .Columns.Add("lot_owner", "LOT OWNER")
            .Columns.Add("operation", "OPERATION TO PERFORMEND")
            .Columns.Add("curr_area", "CURRENT AREA")
            .Columns.Add("actual_area", "ACTUAL AREA")
            .Columns.Add("area_remaining", "REMAINING AREA")

            .Columns("id").Width = 0
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("location").Width = 200
            .Columns("lot_no").Width = 150
            .Columns("crop_class").Width = 150
            .Columns("lot_owner").Width = 150
            .Columns("operation").Width = 150
            .Columns("curr_area").Width = 150
            .Columns("actual_area").Width = 150
            .Columns("area_remaining").Width = 150


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub

    Sub manpower_column()
        With lv_manpower
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("worker_name", "WORKER NAME")
            .Columns.Add("hw_rt", "RT")
            .Columns.Add("hw_ot", "OT")
            .Columns.Add("hw_nt", "NT")
            .Columns.Add("change_rate", "CHANGE RATE")
            .Columns.Add("performed", "OPERATION PERFORMED")

            .Columns("id").Width = 0
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("worker_name").Width = 200
            .Columns("hw_rt").Width = 80
            .Columns("hw_ot").Width = 80
            .Columns("hw_nt").Width = 80
            .Columns("change_rate").Width = 100
            .Columns("performed").Width = 250


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region
    Private Sub Frm_job_ticket_for_processing_accomplishment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_job_ticket_for_processing_accomplishment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes

        for_processing_column() : scheduled_column() : lots_column() : manpower_column()
    End Sub
End Class
