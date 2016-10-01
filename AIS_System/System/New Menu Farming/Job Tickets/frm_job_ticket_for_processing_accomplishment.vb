Imports Telerik.WinControls
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI

Public Class Frm_job_ticket_for_processing_accomplishment
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub for_processing_column()
        With lv_for_processing
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("job_ticket_no", "TICKET NO")
            .Columns.Add("supervised_by", "SUPPERVISED BY")

            .Columns("id").Width = 0
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("job_ticket_no").Width = 100
            .Columns("supervised_by").Width = 150

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
            .Columns("count").Width = 40
            .Columns("location").Width = 150
            .Columns("lot_no").Width = 150
            .Columns("crop_class").Width = 150
            .Columns("lot_owner").Width = 150
            .Columns("operation").Width = 180
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
            .Columns("performed").Width = 260


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
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
    Private Sub Frm_job_ticket_for_processing_accomplishment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        jt_slct_scheduled_id = 0
        glomod.populate_listview(Frm_job_ticket_NEW.lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
    End Sub

    Private Sub Frm_job_ticket_for_processing_accomplishment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.centering_form(Me)
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        for_processing_column() : scheduled_column() : lots_column() : manpower_column()

        glomod.populate_listview(lv_for_processing, "p_ais_job_ticket_for_processing '',1", 3)
    End Sub

    Private Sub lv_manpower_CellFormatting(sender As Object, e As UI.ListViewCellFormattingEventArgs) Handles lv_scheduled.CellFormatting,
        lv_manpower.CellFormatting, lv_lots.CellFormatting, lv_for_processing.CellFormatting

        glomod.lv_formats(e)
    End Sub

    Private Sub lv_for_processing_ItemMouseClick(sender As Object, e As UI.ListViewItemEventArgs) Handles lv_for_processing.ItemMouseClick
        job_ticket_id_for_processing = glomod.selection_listview(lv_for_processing)

        glomod.populate_listview(lv_scheduled, "p_ais_job_ticket_for_processing '" & job_ticket_id_for_processing & "',2", 5)
        glomod.populate_listview(lv_manpower, "p_ais_job_ticket_for_processing '" & job_ticket_id_for_processing & "',4", 7)
        glomod.populate_listview(lv_lots, "p_ais_job_ticket_for_processing '" & job_ticket_id_for_processing & "',3", 9)

    End Sub

    Private Sub lv_for_processing_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_for_processing.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_for_processing.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub check_all_Click(sender As Object, e As EventArgs) Handles check_all.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_processing.Items
            lvitems.CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub uncheck_all_Click(sender As Object, e As EventArgs) Handles uncheck_all.Click
        Dim lvitems As ListViewDataItem = Nothing

        For Each lvitems In lv_for_processing.Items
            lvitems.CheckState = CheckState.Unchecked
        Next
    End Sub

    Private Sub btn_process_all_Click(sender As Object, e As EventArgs) Handles btn_process_all.Click
        If lv_for_processing.CheckedItems.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to change the status of all the check item into Accomplished Ticket?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim lvitem As ListViewDataItem = Nothing
                Dim i As Integer = 0

                While i < lv_for_processing.CheckedItems.Count
                    With lv_for_processing.CheckedItems(i)
                        If lv_for_processing.CheckedItems.Count > 0 Then
                            If lv_for_processing.CheckedItems(i).CheckState = CheckState.Checked Then
                                add_update_data("p_ais_job_ticket_forwanrd_to_accomplishement " & .SubItems(0).ToString & "," & user_id & "")
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

                For Each lvitem In lv_for_processing.Items
                    lvitem.CheckState = CheckState.Unchecked
                Next

                glomod.populate_listview(lv_for_processing, "p_ais_job_ticket_for_processing '',1", 3)
            End If
        Else
            RadMessageBox.Show("Please Check an item to be process.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        glomod.populate_listview(lv_for_processing, "p_ais_job_ticket_for_processing '',1", 3)
    End Sub

    Private Sub lv_for_processing_ItemMouseDoubleClick(sender As Object, e As ListViewItemEventArgs) Handles lv_for_processing.ItemMouseDoubleClick
        If lv_for_processing.SelectedItems.Count > 0 Then
            If lv_for_processing.SelectedItems(0).CheckState = CheckState.Checked Then
                lv_for_processing.SelectedItems(0).CheckState = CheckState.Unchecked
            Else
                lv_for_processing.SelectedItems(0).CheckState = CheckState.Checked
            End If
        End If
    End Sub
End Class
