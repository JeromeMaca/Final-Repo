Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

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
            .Columns.Add("manpower_count", "MANPOWER")
            .Columns.Add("lots_count", "LOCATION LOT")
            .Columns.Add("operation_count", "OPERATION")
            .Columns.Add("remarks", "REMARKS")
            .Columns.Add("stats", "ITEM STATUS")

            .Columns("hdr_id").Width = 20
            .Columns("hdr_id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 150
            .Columns("oic").Width = 200
            .Columns("manpower_count").Width = 90
            .Columns("lots_count").Width = 90
            .Columns("operation_count").Width = 90
            .Columns("remarks").Width = 200
            .Columns("stats").Width = 120


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
            .Columns.Add("lots", "LOT NO")
            .Columns.Add("operation", "WORK OPERATION")
            .Columns.Add("stats", "ITEM STATUS")


            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("loc").Width = 170
            .Columns("lots").Width = 140
            .Columns("operation").Width = 250
            .Columns("stats").Width = 120


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_dtl_lots.EnableGrouping = True
            Me.lv_schedule_dtl_lots.ShowGroups = True
        End With
    End Sub

    'Sub Queued_data_manpower_schedule()
    '    Me.lv_schedule_dtl_manpower.Columns.Clear()

    '    With Me.lv_schedule_dtl_manpower
    '        .Columns.Add("id", "id")
    '        .Columns.Add("count", "#")
    '        .Columns.Add("manpower", "MANPOWER NAME")
    '        .Columns.Add("stats", "ITEM STATUS")

    '        .Columns("id").Width = 20
    '        .Columns("id").Visible = False
    '        .Columns("count").Width = 60
    '        .Columns("manpower").Width = 330
    '        .Columns("stats").Width = 120


    '        .FullRowSelect = True
    '        '.ShowGridLines = True
    '        .ShowGroups = True
    '        .EnableGrouping = True
    '        .MultiSelect = False

    '        Me.lv_schedule_dtl_manpower.EnableGrouping = True
    '        Me.lv_schedule_dtl_manpower.ShowGroups = True
    '    End With
    'End Sub
#End Region

    Sub processed(comm_control)
        Select Case comm_control
            Case 0 'FORM LOAD
                Queued_data_schedule_ticket() : Queued_data_lots_schedule()
                ' Queued_data_manpower_schedule()
                processed(2)
            Case 1 'BTN_ADD_REQUEST
                Dim remarks As String
                If txt_remarks.Text <> "" Then : remarks = txt_remarks.Text : Else remarks = "--- No Remarks ---" : End If

                If jt_control_create_modify = 1 Then
                    sysmod.Add_scheduleform_jt(dt_dateneeded.Value, remarks.ToUpper(), dp_oic.Text.ToUpper(), user_id, se_manpower_no.Value)
                Else
                    glomod.add_update_data("UPDATE tbl_ais_job_ticket_schedule_hdr SET date_needed ='" & dt_dateneeded.Value & "',remarks = '" & txt_remarks.Text & "'" _
                                        & ",officer_in_charge = '" & dp_oic.Text & "',modify_date = getdate(),m_uid = '" & user_id & "' WHERE id = '" & jt_slct_scheduled_id & "'")
                End If

                processed(2)
            Case 2 'CMS_REFRESH_DATA
                If jt_control_create_modify = 1 Then
                    btn_add_request.Text = "ADD TO QUEUED"
                    btn_save_all_queued_schedule.Visible = True
                    btn_save_all_queued_schedule.Visible = True
                    queued_schedule_data_id = Nothing
                    glomod.populate_listview(lv_schedule_add_hdr, " EXEC p_ais_job_ticket_create_schedule_queued_data '" & user_id & "',1,''", 8)
                Else
                    btn_add_request.Text = "UPDATE TO QUEUED"
                    btn_save_all_queued_schedule.Visible = False
                    btn_save_all_queued_schedule.Visible = False
                    queued_schedule_data_id = Nothing
                    glomod.populate_listview(lv_schedule_add_hdr, " EXEC p_ais_job_ticket_create_schedule_queued_data '" & user_id & "',2,'" & jt_slct_scheduled_id & "'", 8)
                End If

            Case 3 'CMS_ASSIGN_LOT_MANPOWER
                glomod.populate_dropdown(dp_location, "SELECT DISTINCT location FROM v_ais_location_maindata WHERE location IS NOT NULL ORDER BY location")
                glomod.populate_dropdown(dp_operation, "SELECT DISTINCT operation FROM tbl_ais_work_operations ORDER BY operation")

                'glomod.populate_dropdown(dp_manpower_name, "SELECT DISTINCT worker_name FROM tbl_ais_job_ticket_schedule_dtl_manpower ORDER BY worker_name")
            Case 4 'DROPDOWN LOCATION
                jt_slct_loc_id = glomod.selection_dropdown("SELECT TOP 1 loc_id as id FROM v_ais_location_maindata WHERE location ='" & dp_location.Text & "'")

                glomod.populate_dropdown(dp_lot_code, "SELECT new_lot_code FROM v_ais_location_maindata WHERE loc_id='" & jt_slct_loc_id & "' AND" _
                                                        & " new_lot_code Is Not NULL GROUP BY new_lot_code ORDER BY len(new_lot_code)")
            Case 5 'DROPDOWN LOT_CODE
                jt_slct_lot_id = glomod.selection_dropdown("SELECT TOP 1 id FROM v_ais_location_maindata WHERE new_lot_code ='" & dp_lot_code.Text & "'")
            Case 6 'BTN_ADD_WORK_OPERATION
                sysmod.Add_loclotform_jt(jt_slct_lot_id, dp_operation.Text, queued_schedule_data_id, user_id)
                glomod.populate_listview(lv_schedule_dtl_lots, " SELECT ROW_NUMBER() over (ORDER BY id ASC) as #" _
                                                                & ",id,location,lot_no,operation_performed,(case status_q WHEN 0 THEN 'QUEUED DATA' WHEN 1 THEN 'SAVED DATA' END)" _
                                                                   & " Status_q FROM [tbl_ais_job_ticket_schedule_dtl_lots] WHERE hdr_id='" & queued_schedule_data_id & "'", 5)
            Case 7 'LISTVIEW SELECTION_HDR
                queued_schedule_data_id = glomod.selection_listview(lv_schedule_add_hdr)
                glomod.populate_listview(lv_schedule_dtl_lots, " SELECT ROW_NUMBER() over (ORDER BY id ASC) as #" _
                                                                & ",id,location,lot_no,operation_performed,(case status_q WHEN 0 THEN 'QUEUED DATA' WHEN 1 THEN 'SAVED DATA' END)" _
                                                                   & " Status_q FROM [tbl_ais_job_ticket_schedule_dtl_lots] WHERE hdr_id='" & queued_schedule_data_id & "'", 5)

                'glomod.populate_listview(lv_schedule_dtl_manpower, " SELECT ROW_NUMBER() over (ORDER BY id ASC) as #,id,worker_name" _
                                                '& ",(case status_q WHEN 0 THEN 'QUEUED DATA' WHEN 1 THEN 'SAVED DATA' END) Status_q FROM [tbl_ais_job_ticket_schedule_dtl_manpower] WHERE hdr_id='" & queued_schedule_data_id & "'", 3)
            Case 8 'DROPDOWN OFFICER IN CHARGE
                glomod.populate_dropdown(dp_oic, "SELECT DISTINCT officer_in_charge FROM tbl_ais_job_ticket_schedule_hdr ORDER BY officer_in_charge")
            Case 9 'BTN_ADD_MANPOWER
                'sysmod.Add_manpower_jt(dp_manpower_name.Text.ToUpper(), queued_schedule_data_id, user_id)
               ' glomod.populate_listview(lv_schedule_dtl_manpower, " SELECT ROW_NUMBER() over (ORDER BY id ASC) as #,id,worker_name" _
                                               ' & ",(case status_q WHEN 0 THEN 'QUEUED DATA' WHEN 1 THEN 'SAVED DATA' END) Status_q FROM [tbl_ais_job_ticket_schedule_dtl_manpower] WHERE hdr_id='" & queued_schedule_data_id & "'", 3)
            Case 10 'DROPDOWN MANPOWER NAMES
               ' glomod.populate_dropdown(dp_manpower_name, "SELECT DISTINCT worker_name FROM tbl_ais_job_ticket_schedule_dtl_manpower ORDER BY worker_name")
            Case 11 'SAVE ALL QUEUED LOTS AND MANPOWET
                sysmod.Save_queued_lots_manpower_jt(queued_schedule_data_id)
                processed(2)
            Case 12 'SAVE ALL SCHEDULE QUEUED
                sysmod.Save_queued_schedule_data_jt(user_id)
                processed(2)
        End Select
    End Sub

    Private Sub Frm_schedule_job_ticket_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        jt_slct_scheduled_id = 0
        glomod.populate_listview(Frm_job_ticket_NEW.lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
    End Sub
    Private Sub lv_schedule_add_hdr_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_schedule_add_hdr.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_schedule_add_menu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub lv_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_schedule_add_hdr.CellFormatting, lv_schedule_dtl_lots.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub Frm_schedule_job_ticket_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.centering_form(Me)
        processed(0)
    End Sub

    Private Sub btn_add_request_Click(sender As Object, e As EventArgs) Handles btn_add_request.Click
        processed(1)
        processed(8)
    End Sub
    Private Sub refresh_data_Click(sender As Object, e As EventArgs) Handles refresh_data.Click
        processed(2)
    End Sub
    Private Sub assign_data_Click(sender As Object, e As EventArgs) Handles assign_data.Click
        gb_createjobticket.Enabled = False
        processed(3)
        gb_assignlots.Enabled = True
    End Sub
    Private Sub dp_location_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_location.SelectedIndexChanged
        processed(4)
    End Sub
    Private Sub dp_lot_code_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_lot_code.SelectedIndexChanged
        processed(5)
    End Sub
    Private Sub btn_add_work_operation_Click(sender As Object, e As EventArgs) Handles btn_add_work_operation.Click
        processed(6)
    End Sub
    Private Sub lv_schedule_add_hdr_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_schedule_add_hdr.SelectedItemChanged
        If jt_control_create_modify = 1 Then
            processed(7)
        Else
            processed(7)
            If lv_schedule_add_hdr.SelectedItems.Count > 0 Then
                With lv_schedule_add_hdr.SelectedItems(0)
                    dt_dateneeded.Value = .SubItems(2)
                    txt_remarks.Text = .SubItems(7)
                    dp_oic.Text = .SubItems(3)
                End With
            Else
                dt_dateneeded.Value = Date.Now
                txt_remarks.Text = Nothing
                dp_oic.Text = Nothing
            End If
        End If

        If lv_schedule_dtl_lots.Items.Count > 0 Then
            lv_schedule_dtl_lots.SelectedItem = lv_schedule_dtl_lots.Items(0)
        End If
    End Sub
    Private Sub dp_oic_TabIndexChanged(sender As Object, e As EventArgs) Handles dp_operation.TabIndexChanged
        processed(8)
    End Sub
    'Private Sub btn_add_manpower_name_Click(sender As Object, e As EventArgs)
    '    processed(9)
    '    processed(10)
    'End Sub

    Private Sub btn_save_all_assignmanlot_queued_Click(sender As Object, e As EventArgs) Handles btn_save_all_assignmanlot_queued.Click
        processed(11)
        gb_createjobticket.Enabled = True
        gb_assignlots.Enabled = False
    End Sub

    Private Sub btn_save_all_queued_schedule_Click(sender As Object, e As EventArgs) Handles btn_save_all_queued_schedule.Click
        processed(12)
        processed(8)
    End Sub

    Private Sub btn_delete_queued_schedule_data_Click(sender As Object, e As EventArgs) Handles btn_delete_queued_schedule_data.Click
        If queued_schedule_data_id <> 0 Then
            glomod.delete_data(sysmod.delete_query_queued_schedule_data_jt(1, queued_schedule_data_id))
            processed(2)
            processed(8)
        Else
            RadMessageBox.Show("Select an item to be deleted...", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub btn_delete_lots_queued_data_Click(sender As Object, e As EventArgs) Handles btn_delete_lots_queued_data.Click
        If queued_schedule_data_id <> 0 Then
            glomod.delete_data(sysmod.delete_query_queued_schedule_data_jt(2, queued_lots_id))
            glomod.populate_listview(lv_schedule_dtl_lots, " SELECT ROW_NUMBER() over (ORDER BY id ASC) as #" _
                                                                & ",id,location,lot_no,operation_performed,(case status_q WHEN 0 THEN 'QUEUED DATA' WHEN 1 THEN 'SAVED DATA' END)" _
                                                                   & " Status_q FROM [tbl_ais_job_ticket_schedule_dtl_lots] WHERE hdr_id='" & queued_schedule_data_id & "'", 5)
        Else
            RadMessageBox.Show("Select an item to be deleted...", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub lv_schedule_dtl_lots_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_schedule_dtl_lots.SelectedItemChanged
        queued_lots_id = glomod.selection_listview(lv_schedule_dtl_lots)
    End Sub

    Private Sub btn_delete_lots_queued_data_MouseHover(sender As Object, e As EventArgs) Handles btn_save_all_queued_schedule.MouseHover,
            btn_save_all_assignmanlot_queued.MouseHover, btn_delete_queued_schedule_data.MouseHover, btn_delete_lots_queued_data.MouseHover,
            btn_add_work_operation.MouseHover, btn_add_request.MouseHover, btn_cancel_assigning.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_delete_lots_queued_data_MouseLeave(sender As Object, e As EventArgs) Handles btn_save_all_queued_schedule.MouseLeave,
            btn_save_all_assignmanlot_queued.MouseLeave, btn_delete_queued_schedule_data.MouseLeave, btn_delete_lots_queued_data.MouseLeave,
            btn_add_work_operation.MouseLeave, btn_add_request.MouseLeave, btn_cancel_assigning.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub btn_cancel_assigning_Click(sender As Object, e As EventArgs) Handles btn_cancel_assigning.Click
        gb_assignlots.Enabled = False
        gb_createjobticket.Enabled = True
    End Sub
End Class
