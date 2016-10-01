Imports System.Data.SqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_scheduled_encoding_accomplish
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Dim slct_lots_id As Integer = 0
    Dim slct_manpower_id As Integer = 0
    Dim command_id As Integer = 0

#Region "LISTVIEW COLUMN"

    Sub scheduled_column()
        lv_schedule.Columns.Clear()

        With lv_schedule
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "TICKET NO.")
            .Columns.Add("date_n", "DATE NEEDED")
            .Columns.Add("supervised", "SUPERVISED BY")
            .Columns.Add("status", "ENCODED")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 30
            .Columns("ticket_no").Width = 75
            .Columns("date_n").Width = 80
            .Columns("supervised").Width = 150
            .Columns("status").Width = 55

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

    Sub enabled_ctrl_lots()
        For Each ctr As Control In gb_lots_menu.Controls
            If TypeOf (ctr) Is RadTextBox Or TypeOf (ctr) Is RadSpinEditor Or TypeOf (ctr) Is RadButton Then
                ctr.Enabled = True
            End If
        Next
    End Sub
    Sub enabled_ctrl_manpower()
        For Each ctr2 As Control In gb_manpower_menu.Controls
            If TypeOf (ctr2) Is RadTextBox Or TypeOf (ctr2) Is RadSpinEditor Or TypeOf (ctr2) Is RadButton Or TypeOf (ctr2) Is CurrencyTextBox.CurrencyTextBox Then
                ctr2.Enabled = True
            End If
        Next
    End Sub
    Sub disabled_ctrl_lots()
        For Each ctr As Control In gb_lots_menu.Controls
            If TypeOf (ctr) Is RadTextBox Or TypeOf (ctr) Is RadSpinEditor Or TypeOf (ctr) Is RadButton Then
                ctr.Enabled = False
            End If
        Next
    End Sub

    Sub disabled_ctrl_manpower()
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

        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1',''", 5)
        glomod.data_item_grouping(lv_schedule, "date_n")
    End Sub

    Private Sub Frm_scheduled_encoding_accomplish_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        jt_slct_scheduled_id = 0
        glomod.populate_listview(Frm_job_ticket_NEW.lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
    End Sub

    Private Sub btn_save_lots_Click(sender As Object, e As EventArgs) Handles btn_save_lots.Click
        glomod.add_update_data("p_ais_job_ticket_encoding_accomplishment '" & slct_lots_id & "'," & se_actual_area.Value & "," & se_remaining_area.Value & ",0,0,0,0,0,1,'" & user_id & "'")

        '''''''VALIDATION FOR ENCODED STATUS
        add_update_data("p_ais_job_ticket_encoding_validation_status '" & jt_slct_approved_id & "','1'")

        job_ticket_view.clear_field_job_ticket_lots()
        listview_loading_lots(jt_slct_approved_id)
        lv_lots.Enabled = True
        disabled_ctrl_lots()
    End Sub

    Private Sub btn_cancel_lots_Click(sender As Object, e As EventArgs) Handles btn_cancel_lots.Click
        job_ticket_view.clear_field_job_ticket_lots()
        lv_lots.Enabled = True
        disabled_ctrl_lots()
    End Sub

    Private Sub btn_save_manpower_Click(sender As Object, e As EventArgs) Handles btn_save_manpower.Click
        If command_id = 1 Then
            add_update_data("p_ais_job_ticket_encoding_accomplishment '',0,0," & se_hourwork_rt.Value & "," & se_hourwork_nt.Value & "," & se_hourwork_ot.Value & "," _
                                      & "" & se_changerate.Value & ",'" & Replace(txt_ope_performed.Text.ToUpper, "'", "`") & "',2,'" & user_id & "','" & jt_slct_approved_id & "','" & Replace(txt_manpower_names.Text.ToUpper, "'", "`") & "'")
            If RadMessageBox.Show("Add another manpower?", "Information", MessageBoxButtons.YesNo, RadMessageIcon.Info) = Windows.Forms.DialogResult.Yes Then
                txt_manpower_names.Focus()

                job_ticket_view.clear_field_job_ticket_manpower()
                listview_loading_manpower(jt_slct_approved_id)
                Exit Sub
            End If
        Else
            add_update_data("p_ais_job_ticket_encoding_accomplishment '" & slct_manpower_id & "',0,0," & se_hourwork_rt.Value & "," & se_hourwork_nt.Value & "," & se_hourwork_ot.Value & "," _
                                      & "" & se_changerate.Value & ",'" & txt_ope_performed.Text & "',3,'" & user_id & "'")

            job_ticket_view.clear_field_job_ticket_manpower()
            listview_loading_manpower(jt_slct_approved_id)
        End If


        '''''''VALIDATION FOR ENCODED STATUS
        add_update_data("p_ais_job_ticket_encoding_validation_status '" & jt_slct_approved_id & "','1'")

        job_ticket_view.clear_field_job_ticket_manpower()
        listview_loading_manpower(jt_slct_approved_id)

        disabled_ctrl_manpower()
        lv_manpowers.Enabled = True
        command_id = 0
    End Sub

    Private Sub btn_cancel_manpower_Click(sender As Object, e As EventArgs) Handles btn_cancel_manpower.Click
        'job_ticket_view.enabled_job_ticket_manpower()
        job_ticket_view.clear_field_job_ticket_manpower()
        lv_manpowers.Enabled = True
        disabled_ctrl_manpower()
        command_id = 0
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
            btn_mark_encoded.Enabled = False
            gb_encoding.Enabled = True

            diabled_all_ctrl()
        Else
            RadMessageBox.Show("Select an item to proceed.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back_selection.Click
        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1',''", 5)
        lv_lots.Items.Clear()
        lv_manpowers.Items.Clear()

        lv_schedule.Enabled = True
        btn_encoding.Enabled = True
        btn_mark_encoded.Enabled = True
        gb_encoding.Enabled = False
    End Sub

    Private Sub lv_lots_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_manpowers.MouseDown, lv_lots.MouseDown, lv_schedule.MouseDown
        If sender Is lv_lots Then
            If e.Button = MouseButtons.Right Then
                cms_encoding_lots.Show(Me, PointToClient(MousePosition))
            End If
        ElseIf sender Is lv_schedule Then
            If e.Button = MouseButtons.Right Then
                cms_for_encoding.Show(Me, PointToClient(MousePosition))
            End If
        Else
            If e.Button = MouseButtons.Right Then
                cms_encoding_manpower.Show(Me, PointToClient(MousePosition))
            End If
        End If
    End Sub

    Private Sub lots_encode_Click(sender As Object, e As EventArgs) Handles lots_encode.Click
        slct_lots_id = glomod.selection_listview(lv_lots)

        If slct_lots_id = 0 Or slct_lots_id = Nothing Then
            RadMessageBox.Show("Select lots item to be encode.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If lv_lots.SelectedItems.Count > 0 Then
            With lv_lots.SelectedItems(0)
                txt_lotno.Text = .SubItems(2)
                se_current_area.Value = .SubItems(4)
            End With
        End If
        enabled_ctrl_lots()
        lv_lots.Enabled = False
        se_actual_area.Select()
    End Sub

    Private Sub lots_refresh_Click(sender As Object, e As EventArgs) Handles lots_refresh.Click
        listview_loading_lots(jt_slct_approved_id)
    End Sub

    Private Sub manpower_refresh_Click(sender As Object, e As EventArgs) Handles manpower_refresh.Click
        listview_loading_manpower(jt_slct_approved_id)
    End Sub

    Private Sub manpower_input_Click(sender As Object, e As EventArgs) Handles manpower_input.Click
        slct_manpower_id = glomod.selection_listview(lv_manpowers)
        enabled_ctrl_manpower()
        lv_manpowers.Enabled = False
        txt_manpower_names.Select()
        command_id = 1
    End Sub

    Private Sub manpower_update_Click(sender As Object, e As EventArgs) Handles manpower_update.Click
        slct_manpower_id = glomod.selection_listview(lv_manpowers)

        If slct_manpower_id = 0 Or slct_manpower_id = Nothing Then
            RadMessageBox.Show("Select Manpower item to be update.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If lv_manpowers.SelectedItems.Count > 0 Then
            With lv_manpowers.SelectedItems(0)
                txt_manpower_names.Text = .SubItems(2)
                se_hourwork_rt.Value = .SubItems(3)
                se_hourwork_ot.Value = .SubItems(4)
                se_hourwork_nt.Value = .SubItems(5)
                se_changerate.Text = .SubItems(6)
                txt_ope_performed.Text = .SubItems(7)
            End With
        End If

        enabled_ctrl_manpower()
        lv_manpowers.Enabled = False
        txt_manpower_names.Select()
        command_id = 2
    End Sub

    Private Sub btn_encoding_MouseHover(sender As Object, e As EventArgs) Handles btn_save_manpower.MouseHover, btn_save_lots.MouseHover,
            btn_encoding.MouseHover, btn_cancel_manpower.MouseHover, btn_cancel_lots.MouseHover, btn_back_selection.MouseHover, btn_mark_encoded.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_encoding_MouseLeave(sender As Object, e As EventArgs) Handles btn_save_manpower.MouseLeave, btn_save_lots.MouseLeave,
            btn_encoding.MouseLeave, btn_cancel_manpower.MouseLeave, btn_cancel_lots.MouseLeave, btn_back_selection.MouseLeave, btn_mark_encoded.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub se_actual_area_ValueChanged(sender As Object, e As EventArgs) Handles se_actual_area.ValueChanged
        If se_current_area.Value < se_actual_area.Value Then
            RadMessageBox.Show("Actual Area value must less than the Current Area value.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            se_actual_area.Value = 0
            Exit Sub
        Else
            If se_actual_area.Value > 0 Then
                se_remaining_area.Value = Val(se_current_area.Value) - Val(se_actual_area.Value)
            End If
        End If

        se_actual_area.Focus()
    End Sub

    Private Sub encoding_refresh_Click(sender As Object, e As EventArgs) Handles encoding_refresh.Click
        glomod.populate_listview(lv_schedule, "p_ais_job_ticket_scheduled_printing '1',''", 5)
    End Sub

    Private Sub encoding_checkall_Click(sender As Object, e As EventArgs) Handles encoding_checkall.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_schedule.Items
            lvitems.CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub encoding_uncheckall_Click(sender As Object, e As EventArgs) Handles encoding_uncheckall.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_schedule.Items
            lvitems.CheckState = CheckState.Unchecked
        Next
    End Sub

    Private Sub lv_schedule_ItemCheckedChanged(sender As Object, e As ListViewItemEventArgs) Handles lv_schedule.ItemCheckedChanged
        Dim lvitem = lv_schedule.SelectedItem
        If lvitem.CheckState = CheckState.Checked Then
            Dim status As String = Nothing

            If lv_schedule.SelectedItems.Count > 0 Then
                With lv_schedule.SelectedItems(0)
                    status = .SubItems(5)
                End With
            End If

            If status = "FALSE" Then
                lvitem.CheckState = CheckState.Unchecked
                RadMessageBox.Show("This action is not posible because there no accomplishment data encoded yet.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_mark_encoded_Click(sender As Object, e As EventArgs) Handles btn_mark_encoded.Click
        If lv_schedule.CheckedItems.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to change the status of all the check item into Delivered Cane Points?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim lvitem As ListViewDataItem = Nothing
                Dim i As Integer = 0

                While i < lv_schedule.CheckedItems.Count
                    With lv_schedule.CheckedItems(i)
                        If lv_schedule.CheckedItems.Count > 0 Then
                            If lv_schedule.CheckedItems(i).CheckState = CheckState.Checked Then
                                add_update_data("p_ais_job_ticket_encoding_validation_status '" & .SubItems(0).ToString & "','2','" & user_id & "'")
                            End If
                        End If
                    End With
                    i += 1
                End While

                If sysmod.msgb = 1 Then
                    RadMessageBox.Show(global_error_catcher, "ERROR...Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
                Else
                    RadMessageBox.Show("Successfully performed the operation without errors.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
                    encoding_refresh.PerformClick()
                    'lv_posting.Items.Clear()
                End If

                For Each lvitem In lv_schedule.Items
                    lvitem.CheckState = CheckState.Unchecked
                Next
            End If
        Else
            RadMessageBox.Show("Please Check an item to be process.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub
End Class