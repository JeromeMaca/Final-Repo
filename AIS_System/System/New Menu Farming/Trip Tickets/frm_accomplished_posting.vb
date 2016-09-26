Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class Frm_accomplished_posting
    Dim sysmod As New System_mod
    Dim glomod As New global_mod

#Region "LISTVIEW COLUMN"
    Sub trip_ticket_schetrip_ticket_posting_column()

        Me.lv_posting.Columns.Clear()

        With Me.lv_posting
            .Columns.Add("id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("work_operation", "WORK OPERATION")
            .Columns.Add("hours_work", "WORK HOUR/s")
            .Columns.Add("area_finish", "AREA DONE")
            .Columns.Add("rate", "RATE PER AREA")
            .Columns.Add("amount", "TOTAL AMOUNT")
            .Columns.Add("gamount", "GRAND TOTAL AMOUNT")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 30
            .Columns("lot_no").Width = 130
            .Columns("work_operation").Width = 230
            .Columns("hours_work").Width = 130
            .Columns("area_finish").Width = 120
            .Columns("rate").Width = 120
            .Columns("amount").Width = 120
            .Columns("gamount").Width = 150
            .Columns("gamount").Visible = False

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_posting.EnableGrouping = True
            Me.lv_posting.ShowGroups = True
        End With
    End Sub

    Sub trip_ticket_for_posting_list()
        Me.lv_for_posting.Columns.Clear()

        With lv_for_posting
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "TICKET NUMBER")
            .Columns.Add("trip_date", "TRIP DATE")


            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 50
            .Columns("ticket_no").Width = 130
            .Columns("trip_date").Width = 130


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_for_posting.EnableGrouping = True
            Me.lv_for_posting.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_accomplished_posting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
        glomod.centering_form(Me)

        trip_ticket_for_posting_list()
        trip_ticket_schetrip_ticket_posting_column()
        accomplished_form_view.accomplished_posting_listview_load()

        glomod.populate_listview(lv_for_posting, "p_ais_trip_ticket_schedule_for_posting", 3)
        glomod.data_item_grouping(lv_for_posting, "trip_date")
        glomod.group_expantion(lv_for_posting.Groups.Count, lv_for_posting)
    End Sub

    Private Sub Frm_accomplished_posting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Me.txt_trip_ticket_no.Text = Nothing
        slct_id_req_hdr = Nothing
        accomplished_form_view.trip_ticket_accomplished_listview_load()
        Frm_main.Enabled = True
    End Sub

    Private Sub lv_posting_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_posting.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (e.CellElement).Data.Name = "amount" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            End If
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        accomplished_form_view.clear_field_posting()
        If Me.lv_posting.SelectedItems.Count > 0 Then
            With Me.lv_posting.SelectedItems(0)
                slct_id_req_dtl = .SubItems(0)

                Me.txt_lotno.Text = .SubItems(2)
                Me.txt_operation_performed.Text = .SubItems(3)
                Me.se_area_finish.Value = .SubItems(5)
                'area_done is equal to total rate per area
                area_done = .SubItems(6)

                Me.txt_totalamount.Text = Val(Me.se_area_finish.Value) * Val(area_done)

            End With
        End If


        If slct_id_req_dtl = Nothing Then
            RadMessageBox.Show("Please select an item in the list to be update.")
            Exit Sub
        End If

        Me.gb_data.Enabled = False
        Me.gb_menu.Enabled = True


    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        accomplished_form_view.accomplished_posting_listview_load()

        Me.gb_data.Enabled = True
        Me.gb_menu.Enabled = False
        accomplished_form_view.clear_field_posting()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        sysmod.Update_accomplished_review_form(Me.se_area_finish.Value, Me.txt_totalamount.Value, slct_id_req_dtl)
        accomplished_form_view.accomplished_posting_listview_load()

        Me.gb_data.Enabled = True
        Me.gb_menu.Enabled = False
        accomplished_form_view.clear_field_posting()
    End Sub

    Private Sub se_area_finish_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.txt_totalamount.Text = Val(area_done) * Val(Me.se_area_finish.Value)
            Me.btn_save.Focus()
        End If
    End Sub

    Private Sub btn_update_MouseHover(sender As Object, e As EventArgs) Handles btn_update.MouseHover, btn_save.MouseHover, btn_cancel.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_update_MouseLeave(sender As Object, e As EventArgs) Handles btn_update.MouseLeave, btn_save.MouseLeave, btn_cancel.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub lv_for_posting_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_for_posting.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_for_posting_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_for_posting.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub lv_for_posting_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_for_posting.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_check_uncheck.Show(Me, PointToClient(MousePosition))
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        glomod.populate_listview(lv_for_posting, "p_ais_trip_ticket_schedule_for_posting", 3)
    End Sub

    Private Sub check_all_Click(sender As Object, e As EventArgs) Handles check_all.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_posting.Items
            lvitems.CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub uncheck_all_Click(sender As Object, e As EventArgs) Handles uncheck_all.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_posting.Items
            lvitems.CheckState = CheckState.Unchecked
        Next
    End Sub

    Private Sub btn_process_all_Click(sender As Object, e As EventArgs) Handles btn_process_all.Click
        If lv_for_posting.CheckedItems.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to change the status of all the check item into Delivered Cane Points?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim lvitem As ListViewDataItem = Nothing
                Dim i As Integer = 0

                While i < lv_for_posting.CheckedItems.Count
                    With lv_for_posting.CheckedItems(i)
                        If lv_for_posting.CheckedItems.Count > 0 Then
                            If lv_for_posting.CheckedItems(i).CheckState = CheckState.Checked Then
                                'add_update_data("p_ais_trip_ticket_schedule_confirm_encoded_data '" & user_id & "','" & .SubItems(0).ToString & "'")
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

                For Each lvitem In lv_for_posting.Items
                    lvitem.CheckState = CheckState.Unchecked
                Next
            End If
        Else
            RadMessageBox.Show("Please Check an item to be process.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
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
End Class
