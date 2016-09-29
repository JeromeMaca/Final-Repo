Imports System.Data.SqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_scheduled_encoding_accomplish
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"

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
            .Columns("count").Width = 40
            .Columns("ticket_no").Width = 80
            .Columns("date_n").Width = 80
            .Columns("supervised").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub

    Sub s_lot_column()
        With lv_lots
            .Columns.Clear()

            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("operation", "OPERATION PERFORMED")
            .Columns.Add("curr_area", "CURRENT AREA")
            .Columns.Add("actual_area", "ACTUAL AREA")
            .Columns.Add("undone_area", "UNFINISH AREA")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("lot_no").Width = 110
            .Columns("operation").Width = 160
            .Columns("curr_area").Width = 100
            .Columns("actual_area").Width = 100
            .Columns("undone_area").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub

    Sub s_manpower_column()
        With lv_manpowers
            .Columns.Clear()

            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("name", "FULLNAME")
            .Columns.Add("RT", "Work RT")
            .Columns.Add("OT", "Work OT")
            .Columns.Add("NT", "Work NT")
            .Columns.Add("rate", "RATE")
            .Columns.Add("ope_performed", "OPERATION PERFORMED")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("name").Width = 140
            .Columns("RT").Width = 60
            .Columns("OT").Width = 60
            .Columns("NT").Width = 60
            .Columns("rate").Width = 100
            .Columns("ope_performed").Width = 140

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

#Region "LOADING LV"
    Sub listview_loading_lots(id)
        glomod.populate_listview(lv_lots, "p_ais_job_ticket_encoding_retrieve '" & id & "',1", 6)
    End Sub

    Sub listview_loading_manpower(id)
        glomod.populate_listview(lv_manpowers, "p_ais_job_ticket_encoding_retrieve '" & id & "',2", 7)
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


    Sub diabled_all_ctrl()
        For Each ctr As Control In gb_lots_menu.Controls
            If TypeOf (ctr) Is RadTextBox Or TypeOf (ctr) Is RadSpinEditor Or TypeOf (ctr) Is RadButton Then
                ctr.Enabled = False
            End If
        Next

        For Each ctr2 As Control In gb_manpower_menu.Controls
            If TypeOf (ctr2) Is RadTextBox Or TypeOf (ctr2) Is RadSpinEditor Or TypeOf (ctr2) Is RadButton Or TypeOf (ctr2) Is CurrencyTextBox.CurrencyTextBox Then
                ctr2.Enabled = False
            End If
        Next
    End Sub


#End Region

    Private Sub Frm_scheduled_encoding_accomplish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.centering_form(Me)

        s_lot_column() : s_manpower_column()
        scheduled_column()

        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1',''", 4)
        glomod.data_item_grouping(lv_schedule, "date_n")
    End Sub

    Private Sub Frm_scheduled_encoding_accomplish_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        jt_slct_scheduled_id = 0
        glomod.populate_listview(Frm_job_ticket_NEW.lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
    End Sub

    Private Sub btn_save_lots_Click(sender As Object, e As EventArgs)
        glomod.add_update_data("p_ais_job_ticket_encoding_accomplishment '" & job_ticket_lotid_encoding & "'," & se_actual_area.Value & "," & se_remaining_area.Value & ",0,0,0,0,0,1,'" & user_id & "'")

        job_ticket_view.clear_field_job_ticket_lots()
        listview_loading_lots(jt_slct_approved_id)
    End Sub

    Private Sub btn_cancel_lots_Click(sender As Object, e As EventArgs)
        job_ticket_view.clear_field_job_ticket_lots()
    End Sub

    Private Sub btn_save_manpower_Click(sender As Object, e As EventArgs)

        Dim lvitem As ListViewDataItem = Nothing
        Dim i As Integer = 0

        While i < lv_manpowers.CheckedItems.Count
            With lv_manpowers.CheckedItems(i)
                If lv_manpowers.CheckedItems.Count > 0 Then
                    If lv_manpowers.CheckedItems(i).CheckState = CheckState.Checked Then
                        add_update_data("p_ais_job_ticket_encoding_accomplishment '" & .SubItems(0).ToString & "',0,0," & se_hourwork_rt.Value & "," & se_hourwork_nt.Value & "," & se_hourwork_ot.Value & "," _
                                               & "" & se_changerate.Value & ",'" & txt_ope_performed.Text & "',2,'" & user_id & "'")
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
        job_ticket_view.clear_field_job_ticket_manpower()

        For Each lvitem In lv_manpowers.Items
            lvitem.CheckState = CheckState.Unchecked
        Next

        listview_loading_manpower(jt_slct_approved_id)
    End Sub

    Private Sub btn_cancel_manpower_Click(sender As Object, e As EventArgs)
        'job_ticket_view.enabled_job_ticket_manpower()
        job_ticket_view.clear_field_job_ticket_manpower()
    End Sub

    Private Sub lv_lots_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_lots.SelectedItemChanged
        job_ticket_lotid_encoding = glomod.selection_listview(lv_lots)
    End Sub

    Private Sub se_actual_area_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If se_current_area.Value < se_actual_area.Value Then
                RadMessageBox.Show("Actual area value is not posible.", "ERROR", MessageBoxButtons.OK, RadMessageIcon.Error)
            Else
                se_remaining_area.Value = Val(se_current_area.Value) - Val(se_actual_area.Value)
            End If

        End If
    End Sub

    Private Sub lv_manpowers_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_schedule.CellFormatting, lv_manpowers.CellFormatting, lv_lots.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_manpowers_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_schedule.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub btn_encoding_Click(sender As Object, e As EventArgs) Handles btn_encoding.Click
        jt_slct_approved_id = glomod.selection_listview(lv_schedule)

        If jt_slct_approved_id <> 0 Then
            listview_loading_lots(jt_slct_approved_id)
            listview_loading_manpower(jt_slct_approved_id)

            lv_schedule.Enabled = False
            btn_encoding.Enabled = False
            gb_encoding.Enabled = True

            diabled_all_ctrl()
        Else
            RadMessageBox.Show("Select an item to proceed.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1',''", 4)

        lv_schedule.Enabled = True
        btn_encoding.Enabled = True
        gb_encoding.Enabled = False
    End Sub
End Class