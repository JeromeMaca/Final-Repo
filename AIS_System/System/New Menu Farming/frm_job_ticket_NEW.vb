Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Public Class Frm_job_ticket_NEW
    Dim sysmod As New System_mod
    Dim glomod As New global_mod

    Dim scheduled_id As Integer = 0
    Dim accomplished_id As Integer = 0

#Region "LISTVIEW COLUMN"
    Sub job_ticket_schedule_column()

        Me.lv_schedule_jt.Columns.Clear()

        With lv_schedule_jt
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "JOB TICKET NO")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("oic", "SUPERVISED BY")
            .Columns.Add("lots_count", "NO. LOTS")
            .Columns.Add("manpower_count", "NO. MANPOWER")
            .Columns.Add("operation_count", "NO. OPERATION")
            .Columns.Add("remarks", "REMARKS")
            .Columns.Add("date_c", "DATE CREATED")
            .Columns.Add("created_by", "CREATED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("ticket_no").Width = 100
            .Columns("date_req").Width = 100
            .Columns("oic").Width = 200
            .Columns("lots_count").Width = 100
            .Columns("manpower_count").Width = 100
            .Columns("operation_count").Width = 100
            .Columns("remarks").Width = 200
            .Columns("date_c").Width = 150
            .Columns("created_by").Width = 240


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub


    Sub job_ticket_accomplished_column()

        Me.lv_accomplished_jt.Columns.Clear()

        With lv_accomplished_jt
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "JOB TICKET NO")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("oic", "SUPERVISED BY")
            .Columns.Add("lots_count", "NO. LOTS")
            .Columns.Add("manpower_count", "NO. MANPOWER")
            .Columns.Add("operation_count", "NO. OPERATION")
            .Columns.Add("remarks", "REMARKS")
            .Columns.Add("date_process", "DATE PROCESSED")
            .Columns.Add("processed_by", "PROCESSED AND ENCODED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("ticket_no").Width = 100
            .Columns("date_req").Width = 120
            .Columns("oic").Width = 200
            .Columns("lots_count").Width = 100
            .Columns("manpower_count").Width = 100
            .Columns("operation_count").Width = 100
            .Columns("remarks").Width = 200
            .Columns("date_process").Width = 150
            .Columns("processed_by").Width = 200


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub
#End Region

    Sub menus_access_enabled_disabled(query As String, tag As Integer)
        Dim i As Integer = 0
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()

                For i = 0 To 12
                    Dim flag = sysmod.dr.Item(i)

                    If tag = 1 Then
                        '''''REQUEST
                        For x As Integer = 0 To cms_schedule_jobticket.Items.Count - 1
                            If cms_schedule_jobticket.Items(x).Tag = i Then
                                If flag = True Then
                                    cms_schedule_jobticket.Items(x).Enabled = True
                                Else
                                    cms_schedule_jobticket.Items(x).Enabled = False
                                End If
                            End If
                        Next
                    ElseIf tag = 2 Then
                        '''''REQUEST
                        For x As Integer = 0 To cms_accom_jobticket.Items.Count - 1
                            If cms_accom_jobticket.Items(x).Tag = i Then
                                If flag = True Then
                                    cms_accom_jobticket.Items(x).Enabled = True
                                Else
                                    cms_accom_jobticket.Items(x).Enabled = False
                                End If
                            End If
                        Next

                    End If

                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Sub access_enabled_disabled(query As String)
        Dim i As Integer = 0
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                While (sysmod.dr.Read())
                    Select Case i
                        Case 0
                            scheduled_id = sysmod.dr.Item(0)
                        Case 1
                            accomplished_id = sysmod.dr.Item(0)
                    End Select
                    i += 1
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub create_schedule_Click(sender As Object, e As EventArgs) Handles create_schedule.Click
        Frm_main.Enabled = False
        jt_control_create_modify = 1
        Frm_schedule_job_ticket_add.Show()
    End Sub

    Private Sub Frm_job_ticket_NEW_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()


        access_enabled_disabled("p_ais_main_access_validation_command '0','" & user_id & "','6'")

        If scheduled_id <> 0 Then
            Me.pvp1_tab.Enabled = True

            menus_access_enabled_disabled("p_ais_main_access_validation_command '1','','','" & scheduled_id & "'", 1)
        Else
            Me.pvp1_tab.Enabled = False
        End If

        If accomplished_id <> 0 Then
            Me.pvp2_tab.Enabled = True

            menus_access_enabled_disabled("p_ais_main_access_validation_command '1','','','" & accomplished_id & "'", 2)
        Else
            Me.pvp2_tab.Enabled = False
        End If



        'pvp_tab.SelectedPage = pvp_1
    End Sub

    Private Sub lv_schedule_jt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_schedule_jt.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_schedule_jobticket.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub pvp_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp_tab.SelectedPageChanged
        If pvp_tab.SelectedPage Is pvp_1 Then
            job_ticket_schedule_column()

            glomod.populate_listview(lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
            glomod.data_item_grouping(lv_schedule_jt, "date_req")

            If lv_schedule_jt.Items.Count > 0 Then
                lv_schedule_jt.SelectedItem = lv_schedule_jt.Items(0)
            End If

        Else
            job_ticket_accomplished_column()

            glomod.populate_listview(lv_accomplished_jt, sysmod.job_ticket_listview_data("ACCOMPLISHED_DATA", user_id), 10)
            glomod.data_item_grouping(lv_accomplished_jt, "date_req")

            If lv_accomplished_jt.Items.Count > 0 Then
                lv_accomplished_jt.SelectedItem = lv_accomplished_jt.Items(0)
            End If

        End If
    End Sub

    Private Sub lv_schedule_jt_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) _
        Handles lv_schedule_jt.CellFormatting, lv_accomplished_jt.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_schedule_jt_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) _
        Handles lv_schedule_jt.VisualItemFormatting, lv_accomplished_jt.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub refresh_schedule_Click(sender As Object, e As EventArgs) Handles refresh_schedule.Click
        glomod.populate_listview(lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
    End Sub
    Private Sub refresh_accomplished_data_Click(sender As Object, e As EventArgs) Handles refresh_accomplished_data.Click
        glomod.populate_listview(lv_accomplished_jt, sysmod.job_ticket_listview_data("ACCOMPLISHED_DATA", user_id), 10)
        jt_slct_accomplihed_id = 0
    End Sub
    Private Sub review_schedule_Click(sender As Object, e As EventArgs) Handles review_schedule.Click
        'APPROVAL PURPOSE
        Frm_main.Enabled = False
        Frm_scheduled_review_ticket.Show()
    End Sub

    Private Sub modify_schedule_Click(sender As Object, e As EventArgs) Handles modify_schedule.Click
        If jt_slct_scheduled_id <> 0 Then
            Frm_main.Enabled = False
            jt_control_create_modify = 2

            If lv_schedule_jt.SelectedItems.Count > 0 Then
                With lv_schedule_jt.SelectedItems(0)
                    Frm_schedule_job_ticket_add.Text = Frm_schedule_job_ticket_add.Text & "  JOB TICKET NO.: " & .SubItems(2)
                End With
            End If

            Frm_schedule_job_ticket_add.Show()
        Else
            RadMessageBox.Show("No selected item cannot proceed.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub lv_schedule_jt_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_schedule_jt.SelectedItemChanged
        jt_slct_scheduled_id = glomod.selection_listview(lv_schedule_jt)
    End Sub

    Private Sub cancel_schedule_Click(sender As Object, e As EventArgs) Handles cancel_schedule.Click
        If RadMessageBox.Show("Are you sure you want to cancel the selected Job Ticket Schuled?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
            glomod.add_update_data("UPDATE tbl_ais_job_ticket_schedule_hdr SET date_cancelled = GETDATE(),cancelled_by = '" & user_id & "',status = 10 WHERE id = '" & jt_slct_scheduled_id & "'")

            glomod.populate_listview(lv_schedule_jt, sysmod.job_ticket_listview_data("SCHEDULED_DATA", user_id), 10)
            jt_slct_scheduled_id = 0
        End If
    End Sub

    Private Sub accomplished_encoding_Click(sender As Object, e As EventArgs) Handles accomplished_encoding.Click
        Frm_main.Enabled = False
        Frm_scheduled_encoding_accomplish.Show()
    End Sub

    Private Sub accomplished_schedule_Click(sender As Object, e As EventArgs) Handles accomplished_schedule.Click
        Frm_main.Enabled = False
        Frm_job_ticket_for_processing_accomplishment.Show()
    End Sub

    Private Sub lv_accomplished_jt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_accomplished_jt.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_accom_jobticket.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub review_accomplished_data_Click(sender As Object, e As EventArgs) Handles review_accomplished_data.Click
        Frm_main.Enabled = False
        Frm_job_ticket_posting_accomplishment.Show()
    End Sub

    Private Sub print_schedule_Click(sender As Object, e As EventArgs) Handles print_schedule.Click
        Frm_main.Enabled = False
        Frm_job_ticket_scheduled_printing.Show()
    End Sub
End Class
