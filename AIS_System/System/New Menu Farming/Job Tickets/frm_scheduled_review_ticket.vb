Imports Microsoft.Reporting.WinForms
Imports Report_Lib
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_scheduled_review_ticket
    Dim glomod As New global_mod
    Dim sysmod As New System_mod
    Dim print_glomod As New print_global_module

#Region "LISTVIEW COLUMN"
    Sub job_ticket_for_approval_column()
        lv_for_approval.Columns.Clear()
        With lv_for_approval
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "JOB TICKET NO")
            .Columns.Add("date_req", "DATE NEEDED")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("ticket_no").Width = 140
            .Columns("date_req").Width = 140

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub

    Sub job_ticket_approval_detail()
        lv_ticket_detail.Columns.Clear()
        With lv_ticket_detail
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("lotowner", "LOT OWNER")
            .Columns.Add("lotvariety", "LOT VARIETY")
            .Columns.Add("lotoperation", "WORK OPEARATION")
            .Columns.Add("lotcurrarea", "CURRENT AREA")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("location").Width = 140
            .Columns("lot_no").Width = 120
            .Columns("lotowner").Width = 140
            .Columns("lotvariety").Width = 100
            .Columns("lotoperation").Width = 140
            .Columns("lotcurrarea").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
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
                            txt_jobticket.Text = info
                        Case 1
                            dt_dateneeded.Value = info
                        Case 2
                            txt_remarks.Text = info
                        Case 3
                            txt_oic.Text = info
                        Case 4
                            se_manpower_no.Value = info
                        Case 5
                            txt_requesteddate.Text = info
                        Case 6
                            txt_requestedby.Text = info
                    End Select
                Next
            End If
            sysmod.dbConn.Close()
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString, "AIS: Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
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

    Private Sub Frm_scheduled_review_ticket_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        glomod.populate_listview(Frm_job_ticket_NEW.lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_scheduled_review_ticket_Initialized(sender As Object, e As EventArgs) Handles MyBase.Initialized
        glomod.centering_form(Me)
    End Sub

    Private Sub Frm_scheduled_review_ticket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        job_ticket_for_approval_column()
        job_ticket_approval_detail()

        glomod.populate_listview(lv_for_approval, "p_ais_job_ticket_scheduled_for_approval 0,''", 3)
        glomod.data_item_grouping(lv_for_approval, "date_req")
    End Sub

    Private Sub btn_process_all_Click(sender As Object, e As EventArgs) Handles btn_process_all.Click
        If lv_for_approval.CheckedItems.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to change the status of all the check item into Delivered Cane Points?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim lvitem As ListViewDataItem = Nothing
                Dim i As Integer = 0

                While i < lv_for_approval.CheckedItems.Count
                    With lv_for_approval.CheckedItems(i)
                        If lv_for_approval.CheckedItems.Count > 0 Then
                            If lv_for_approval.CheckedItems(i).CheckState = CheckState.Checked Then
                                add_update_data("p_ais_job_ticket_scheduled_approval '" & user_id & "','" & .SubItems(0).ToString & "'")
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

                For Each lvitem In lv_for_approval.Items
                    lvitem.CheckState = CheckState.Unchecked
                Next
            End If
        Else
            RadMessageBox.Show("Please Check an item to be process.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub lv_ticket_detail_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles lv_ticket_detail.CellFormatting,
            lv_for_approval.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_ticket_detail_VisualItemFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewVisualItemEventArgs) Handles lv_ticket_detail.VisualItemFormatting,
            lv_for_approval.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub lv_for_approval_ItemMouseClick(sender As Object, e As Telerik.WinControls.UI.ListViewItemEventArgs) Handles lv_for_approval.ItemMouseClick
        Dim lvitem = lv_for_approval.SelectedItem

        If lvitem.CheckState = CheckState.Checked Then
            jt_slct_scheduled_id = glomod.selection_listview(lv_for_approval)
            If jt_slct_scheduled_id = Nothing Then
                RadMessageBox.Show("Select an Item please to proceed.")
                Exit Sub
            End If
            execution_server("p_ais_job_ticket_schedule_approval '0','" & jt_slct_scheduled_id & "'")
            glomod.populate_listview(lv_ticket_detail, "p_ais_job_ticket_schedule_approval '1','" & jt_slct_scheduled_id & "'", 7)
            'accomplished_form_view.accomplished_posting_listview_load()
        Else
            lv_ticket_detail.Items.Clear()
            For Each ctr As Control In RadGroupBox3.Controls
                If TypeOf (ctr) Is RadTextBox Then
                    ctr.Text = ""
                End If

                If TypeOf (ctr) Is RadDateTimePicker Then
                    Dim c As RadDateTimePicker = ctr
                    c.Value = Nothing
                End If

                If TypeOf (ctr) Is RadSpinEditor Then
                    Dim c As RadSpinEditor = ctr
                    c.Value = 0
                End If
            Next
        End If
    End Sub

    Private Sub lv_for_approval_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_for_approval.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_check_uncheck.Show(Me, PointToClient(MousePosition))
        End If
    End Sub

    Private Sub btn_process_all_MouseHover(sender As Object, e As EventArgs) Handles btn_process_all.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_process_all_MouseLeave(sender As Object, e As EventArgs) Handles btn_process_all.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        glomod.populate_listview(lv_for_approval, "p_ais_job_ticket_scheduled_for_approval 0,''", 3)
    End Sub

    Private Sub check_all_Click(sender As Object, e As EventArgs) Handles check_all.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_approval.Items
            lvitems.CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub uncheck_all_Click(sender As Object, e As EventArgs) Handles uncheck_all.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_approval.Items
            lvitems.CheckState = CheckState.Unchecked
        Next
    End Sub
End Class
