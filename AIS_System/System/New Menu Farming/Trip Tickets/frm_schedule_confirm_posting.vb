Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class Frm_schedule_confirm_posting
    Dim glomod As New global_mod
    Dim sysmod As New System_mod


#Region "LISTVIEW COLUMN"
    Sub column_listconfirmation()
        Me.lv_for_confirmation.Columns.Clear()
        With Me.lv_for_confirmation
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("tripticket_no", "TRIP TICKET NO")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 30
            .Columns("trip_date").Width = 120
            .Columns("tripticket_no").Width = 160

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_for_confirmation.EnableGrouping = True
            Me.lv_for_confirmation.ShowGroups = True
        End With
    End Sub

    Sub column_lotinformation()
        Me.lv_lot_information.Columns.Clear()
        With Me.lv_lot_information
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NO")
            .Columns.Add("owner_name", "LOT OWNER")
            .Columns.Add("curr_area", "CURRENT AREA")
            .Columns.Add("work_start", "WORK START")
            .Columns.Add("work_stop", "WORK STOP")
            .Columns.Add("operate_hrs", "OPERATE HOUR/s")
            .Columns.Add("area_finish", "AREA FINISH")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 30
            .Columns("lot_no").Width = 120
            .Columns("owner_name").Width = 220
            .Columns("curr_area").Width = 100
            .Columns("work_start").Width = 100
            .Columns("work_stop").Width = 100
            .Columns("operate_hrs").Width = 110
            .Columns("area_finish").Width = 100

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

    Sub execution_server(query)
        Dim i As Integer = 0
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If (sysmod.dr.HasRows) Then
                sysmod.dr.Read()

                For i = 0 To 6
                    Dim info = sysmod.dr.Item(i).ToString

                    Select Case i
                        Case 0
                            txt_ticketno.Text = info
                        Case 1
                            tp_e_timeout.Value = info
                        Case 2
                            tp_e_timein.Value = info
                        Case 3
                            tp_ja_timein.Value = info
                        Case 4
                            tp_ja_timeout.Value = info
                        Case 5
                            txt_loc.Text = info
                        Case 6
                            txt_work_operation.Text = info
                    End Select
                Next
            End If
            sysmod.dbConn.Close()
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString, "AIS: Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub
    Private Sub Frm_schedule_confirm_posting_Initialized(sender As Object, e As EventArgs) Handles MyBase.Initialized
        glomod.centering_form(Me)
    End Sub

    Private Sub Frm_schedule_confirm_posting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_schedule_confirm_posting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        column_listconfirmation() : column_lotinformation()

        glomod.populate_listview(lv_for_confirmation, "p_ais_trip_ticket_schedule_form_confirmation '',0", 3)
    End Sub

    Private Sub lv_for_confirmation_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_for_confirmation.SelectedItemChanged
        Dim id As Integer = 0

        txt_ticketno.Text = ""
        tp_e_timeout.Value = Nothing
        tp_e_timein.Value = Nothing
        tp_ja_timein.Value = Nothing
        tp_ja_timeout.Value = Nothing
        txt_loc.Text = ""
        txt_work_operation.Text = Nothing


        id = glomod.selection_listview(lv_for_confirmation)
        glomod.populate_listview(lv_lot_information, "p_ais_trip_ticket_schedule_form_confirmation '" & id & "',1", 8)
        execution_server("p_ais_trip_ticket_schedule_form_confirmation '" & id & "',2")
    End Sub

    Private Sub lv_lot_information_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_lot_information.CellFormatting, lv_for_confirmation.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub btn_process_all_MouseHover(sender As Object, e As EventArgs) Handles btn_process_all.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_process_all_MouseLeave(sender As Object, e As EventArgs) Handles btn_process_all.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub lv_for_confirmation_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_for_confirmation.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_check_uncheck.Show(Me, PointToClient(MousePosition))
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        glomod.populate_listview(lv_for_confirmation, "p_ais_trip_ticket_schedule_form_confirmation '',0", 3)
    End Sub

    Private Sub checkall_Click(sender As Object, e As EventArgs) Handles checkall.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_confirmation.Items
            lvitems.CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub uncheckall_Click(sender As Object, e As EventArgs) Handles uncheckall.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_confirmation.Items
            lvitems.CheckState = CheckState.Unchecked
        Next
    End Sub

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

    Private Sub btn_process_all_Click(sender As Object, e As EventArgs) Handles btn_process_all.Click
        If lv_for_confirmation.CheckedItems.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to change the status of all the check item into Delivered Cane Points?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim lvitem As ListViewDataItem = Nothing
                Dim i As Integer = 0

                While i < lv_for_confirmation.CheckedItems.Count
                    With lv_for_confirmation.CheckedItems(i)
                        If lv_for_confirmation.CheckedItems.Count > 0 Then
                            If lv_for_confirmation.CheckedItems(i).CheckState = CheckState.Checked Then
                                add_update_data("UPDATE tbl_ais_trip_ticket_schedule_hdr SET status=2,accomplished_date=GETDATE(),accomplished_by='" & user_id & "' WHERE id='" & .SubItems(0).ToString & "'")
                            End If
                        End If
                    End With
                    i += 1
                End While

                If sysmod.msgb = 1 Then
                    RadMessageBox.Show(global_error_catcher, "ERROR...Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
                Else
                    RadMessageBox.Show("Successfully performed the operation without errors.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
                    refresh.PerformClick()
                End If

                For Each lvitem In lv_for_confirmation.Items
                    lvitem.CheckState = CheckState.Unchecked
                Next
            End If
        Else
            RadMessageBox.Show("Please Check an item to be process.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub
End Class
