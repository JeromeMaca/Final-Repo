Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_job_ticket_posting_accomplishment
    Dim glomod As New global_mod
    Dim sysmod As New System_mod
#Region "LISTVIEW COLUMN"
    Sub lv_posting_column()
        With lv_jobticket_for_posting
            .Columns.Clear()

            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "TICKET NUMBER")
            .Columns.Add("oic", "OFFICER-IN-CHARGE")
            .Columns.Add("date_accom", "DATE ACCOMPLISHED")
            .Columns.Add("accom_by", "ACCOMPLISHED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("ticket_no").Width = 100
            .Columns("oic").Width = 200
            .Columns("date_accom").Width = 120
            .Columns("accom_by").Width = 200
            .Columns("date_accom").Visible = False
            .Columns("accom_by").Visible = False

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With

    End Sub

    Sub lv_posting_column_sched_info()
        With lv_scheduled_info
            .Columns.Clear()

            .Columns.Add("ticket_no", "TICKET NUMBER")
            .Columns.Add("oic", "OFFICER-IN-CHARGE")
            .Columns.Add("remarks", "REMARKS")
            .Columns.Add("created_date", "DATE REQUESTED")
            .Columns.Add("created_by", "REQUESTED BY")
            .Columns.Add("date_accom", "DATE ACCOMPLISHED")
            .Columns.Add("accom_by", "ACCOMPLISHED BY")

            .Columns("ticket_no").Width = 100
            .Columns("oic").Width = 150
            .Columns("remarks").Width = 150
            .Columns("created_date").Width = 120
            .Columns("created_by").Width = 150
            .Columns("date_accom").Width = 120
            .Columns("accom_by").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub

    Sub lv_posting_column_lots_info()
        With lv_lots_info
            .Columns.Clear()

            .Columns.Add("blank", "")
            .Columns.Add("ope_performed", "OPERATION PERFORMED")
            .Columns.Add("curr_area", "CURRENT AREA")
            .Columns.Add("actual_area", "ACTUAL AREA")
            .Columns.Add("remaining_area", "REMAINING AREA")
            .Columns.Add("lot_no", "lotno_ownername")

            .Columns("blank").Width = 5
            .Columns("blank").Visible = False
            .Columns("ope_performed").Width = 200
            .Columns("curr_area").Width = 100
            .Columns("actual_area").Width = 100
            .Columns("remaining_area").Width = 100
            .Columns("lot_no").Width = 150
            .Columns("lot_no").Visible = False

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub

    Sub lv_posting_column_manpower_info()
        With lv_mapower_info
            .Columns.Clear()
            .Columns.Add("name", "MANPOWER NAME")
            .Columns.Add("rt", "HOUR (RT)")
            .Columns.Add("ot", "HOURS (OT)")
            .Columns.Add("nt", "HOURS (NT)")
            .Columns.Add("rate", "CHANGE RATE")
            .Columns.Add("in_op_pe", "OPERATION PERFORMED")

            .Columns("name").Width = 250
            .Columns("rt").Width = 100
            .Columns("ot").Width = 100
            .Columns("nt").Width = 100
            .Columns("rate").Width = 100
            .Columns("in_op_pe").Width = 200

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub
#End Region

#Region "OTHER SPECIAL COMMAND"
    Sub add_update_data(query As String)
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.sqlCmd.ExecuteNonQuery()
            sysmod.dbConn.Close()

        Catch ex As Exception
            If ex.Message <> Nothing Then
                sysmod.msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
    End Sub
#End Region

    Private Sub Frm_job_ticket_posting_accomplishment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        'job_ticket_accomplished_column()

        glomod.populate_listview(Frm_job_ticket_NEW.lv_accomplished_jt, sysmod.job_ticket_listview_data("ACCOMPLISHED_DATA", user_id), 10)
        glomod.data_item_grouping(Frm_job_ticket_NEW.lv_accomplished_jt, "date_req")

        If Frm_job_ticket_NEW.lv_accomplished_jt.Items.Count > 0 Then
            Frm_job_ticket_NEW.lv_accomplished_jt.SelectedItem = Frm_job_ticket_NEW.lv_accomplished_jt.Items(0)
        End If
    End Sub

    Private Sub Frm_job_ticket_posting_accomplishment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.centering_form(Me)
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes

        lv_posting_column() : lv_posting_column_sched_info() : lv_posting_column_lots_info() : lv_posting_column_manpower_info()


        glomod.populate_listview(lv_jobticket_for_posting, "p_ais_job_ticket_for_posting '',1", 5)
        glomod.data_item_selected_zero(lv_jobticket_for_posting, 0)
    End Sub

    Private Sub lv_jobticket_for_posting_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_jobticket_for_posting.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_menu_posting.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_jobticket_for_posting_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) _
        Handles lv_jobticket_for_posting.CellFormatting, lv_scheduled_info.CellFormatting, lv_lots_info.CellFormatting, lv_mapower_info.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub btn_post_all_Click(sender As Object, e As EventArgs) Handles btn_post_all.Click
        Dim lvitem As ListViewDataItem = Nothing
        Dim i As Integer = 0

        While i < lv_jobticket_for_posting.CheckedItems.Count
            With lv_jobticket_for_posting.CheckedItems(i)
                If lv_jobticket_for_posting.CheckedItems.Count > 0 Then
                    If lv_jobticket_for_posting.CheckedItems(i).CheckState = CheckState.Checked Then
                        add_update_data("p_ais_job_ticket_for_posting " & .SubItems(0).ToString & ",5," & user_id & "")
                    End If
                End If
            End With
            i += 1
        End While


        If sysmod.msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            RadMessageBox.Show("Successfully performed the operation without errors.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

        'job_ticket_view.enabled_job_ticket_manpower()
        'job_ticket_view.clear_field_job_ticket_manpower()

        For Each lvitem In lv_jobticket_for_posting.Items
            lvitem.CheckState = CheckState.Unchecked
        Next

        glomod.populate_listview(lv_jobticket_for_posting, "p_ais_job_ticket_for_posting '',1", 5)
        glomod.data_item_selected_zero(lv_jobticket_for_posting, 0)
    End Sub

    Private Sub lv_lots_info_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_lots_info.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        glomod.populate_listview(lv_jobticket_for_posting, "p_ais_job_ticket_for_posting '',1", 5)
        glomod.data_item_selected_zero(lv_jobticket_for_posting, 0)
    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        Dim lv As ListViewDataItem

        For Each lv In lv_jobticket_for_posting.Items
            lv.CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub uncheck_Click(sender As Object, e As EventArgs) Handles uncheck.Click
        Dim lv As ListViewDataItem

        For Each lv In lv_jobticket_for_posting.Items
            lv.CheckState = CheckState.Unchecked
        Next
    End Sub

    Private Sub lv_jobticket_for_posting_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_jobticket_for_posting.SelectedItemChanged
        jt_slct_scheduled_id = 0
        jt_slct_accomplihed_id = glomod.selection_listview(lv_jobticket_for_posting)

        glomod.populate_listview(lv_scheduled_info, "p_ais_job_ticket_for_posting " & jt_slct_accomplihed_id & ", 2", 6)
        glomod.data_item_selected_zero(lv_scheduled_info, 0)

        glomod.populate_listview(lv_lots_info, "p_ais_job_ticket_for_posting " & jt_slct_accomplihed_id & ", 3", 5)
        glomod.data_item_grouping(lv_lots_info, "lot_no")
        glomod.data_item_selected_zero(lv_lots_info, 0)

        glomod.populate_listview(lv_mapower_info, "p_ais_job_ticket_for_posting " & jt_slct_accomplihed_id & ", 4", 5)
        glomod.data_item_selected_zero(lv_mapower_info, 0)
    End Sub
End Class
