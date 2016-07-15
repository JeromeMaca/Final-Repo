Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class Frm_schedule_job_ticket_add
    Dim sysmod As New System_mod
    Dim glomod As New global_mod

#Region "LISTVIEW COLUMN"
    Sub Queued_data_schedule_ticket()
        Me.lv_schedule_add_hdr.Columns.Clear()

        With Me.lv_schedule_add_hdr
            .Columns.Add("hdr_id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("oic", "SUPERVISED BY")
            .Columns.Add("lots_count", "No. of LOTS")
            .Columns.Add("manpower_count", "No. of MANPOWER")
            .Columns.Add("remarks", "REMARKS")

            .Columns("hdr_id").Width = 20
            .Columns("hdr_id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 180
            .Columns("oic").Width = 200
            .Columns("lots_count").Width = 100
            .Columns("manpower_count").Width = 120
            .Columns("remarks").Width = 200


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_add_hdr.EnableGrouping = True
            Me.lv_schedule_add_hdr.ShowGroups = True
        End With
    End Sub

    Sub Queued_data_lots_schedule()
        Me.lv_schedule_dtl_lots.Columns.Clear()

        With Me.lv_schedule_dtl_lots
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("loc", "LOCATION")
            .Columns.Add("lots", "LOT No.")
            .Columns.Add("operation", "WORK OPERATION")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("loc").Width = 170
            .Columns("lots").Width = 140
            .Columns("operation").Width = 250


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_dtl_lots.EnableGrouping = True
            Me.lv_schedule_dtl_lots.ShowGroups = True
        End With
    End Sub

    Sub Queued_data_manpower_schedule()
        Me.lv_schedule_dtl_manpower.Columns.Clear()

        With Me.lv_schedule_dtl_manpower
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("manpower", "MANPOWER NAME")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("manpower").Width = 500


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_dtl_manpower.EnableGrouping = True
            Me.lv_schedule_dtl_manpower.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_schedule_job_ticket_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Queued_data_schedule_ticket()
        Queued_data_lots_schedule()
        Queued_data_manpower_schedule()

        glomod.populate_dropdown(dp_oic, "SELECT DISTINCT officer_in_charge FROM tbl_ais_job_ticket_schedule_hdr ORDER BY officer_in_charge")

        schedule_jt_view.create_schedule_queued_data(lv_schedule_add_hdr, " EXEC p_ais_job_ticket_create_schedule_queued_data '" & user_id & "'", 6)


    End Sub
    Private Sub Frm_schedule_job_ticket_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub lv_schedule_add_hdr_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_schedule_add_hdr.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_schedule_add_menu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub btn_add_request_Click(sender As Object, e As EventArgs) Handles btn_add_request.Click
        Dim remarks As String
        If txt_remarks.Text <> "" Then
            remarks = txt_remarks.Text
        Else
            remarks = "--- No Remarks ---"
        End If
        sysmod.Add_scheduleform_jt(dt_dateneeded.Value, remarks, dp_oic.Text.ToUpper(), user_id)
        schedule_jt_view.create_schedule_queued_data(lv_schedule_add_hdr, " EXEC p_ais_job_ticket_create_schedule_queued_data '" & user_id & "'", 6)
    End Sub

    Private Sub lv_schedule_add_hdr_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_schedule_add_hdr.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub refresh_data_Click(sender As Object, e As EventArgs) Handles refresh_data.Click
        schedule_jt_view.create_schedule_queued_data(lv_schedule_add_hdr, " EXEC p_ais_job_ticket_create_schedule_queued_data '" & user_id & "'", 6)
    End Sub

    Private Sub assign_data_Click(sender As Object, e As EventArgs) Handles assign_data.Click
        glomod.populate_dropdown(dp_location, "SELECT DISTINCT location FROM v_ais_location_maindata WHERE location IS NOT NULL ORDER BY location")
        glomod.populate_dropdown(dp_operation, "SELECT DISTINCT operation FROM tbl_ais_work_operations ORDER BY operation")
        glomod.populate_dropdown(dp_manpower_name, "SELECT DISTINCT worker_name FROM tbl_ais_job_ticket_schedule_dtl_manpower ORDER BY worker_name")
    End Sub

    Private Sub dp_location_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_location.SelectedIndexChanged
        jt_slct_loc_id = glomod.selection_dropdown("SELECT TOP 1 loc_id as id FROM v_ais_location_maindata WHERE location ='" & dp_location.Text & "'")

        glomod.populate_dropdown(dp_lot_code, "SELECT new_lot_code FROM v_ais_location_maindata WHERE loc_id='" & jt_slct_loc_id & "' AND" _
                                                & " new_lot_code Is Not NULL GROUP BY new_lot_code ORDER BY len(new_lot_code)")
    End Sub
    Private Sub dp_lot_code_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_lot_code.SelectedIndexChanged
        jt_slct_lot_id = glomod.selection_dropdown("SELECT TOP 1 id FROM v_ais_location_maindata WHERE new_lot_code ='" & dp_lot_code.Text & "'")
    End Sub
    Private Sub btn_add_work_operation_Click(sender As Object, e As EventArgs) Handles btn_add_work_operation.Click
        sysmod.Add_loclotform_jt(jt_slct_lot_id, dp_operation.Text, lv_slct_id, user_id)
    End Sub

    Private Sub lv_schedule_add_hdr_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_schedule_add_hdr.SelectedItemChanged
        glomod.selection_listview(lv_schedule_add_hdr)


        schedule_jt_view.create_schedule_queued_data(lv_schedule_dtl_lots, " SELECT ROW_NUMBER() over (ORDER BY id ASC) as #" _
                                                        & ",id,location,lot_no,operation_performed FROM [tbl_ais_job_ticket_schedule_dtl_lots] WHERE hdr_id='" & lv_slct_id & "'", 4)
    End Sub

    Private Sub lv_schedule_dtl_lots_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_schedule_dtl_lots.CellFormatting
        glomod.lv_formats(e)
    End Sub
End Class
