Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik

Public Class Frm_trip_ticket_NEWS
    Dim sysmod As New System_mod
    Dim glomod As New global_mod
    Dim ctr As Integer = 0
    Dim ctr2 As Integer = 0

    Dim viewbyindividual_id As Integer = 0 'FOR REQUEST
    Dim viewbyindividual_id_scheduled As Integer = 0 'FOR SCHEDULED

    Dim request_id As Integer = 0
    Dim scheduled_id As Integer = 0
    Dim accomplished_id As Integer = 0

#Region "LISTVIEW COLUMN"
    Sub trip_ticket_request_form_column()

        Me.lv_request_tt.Columns.Clear()

        With Me.lv_request_tt
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            '.Columns.Add("lot_id", "lot_id")
            .Columns.Add("count", "#")
            .Columns.Add("req_no", "REQUEST NUMBER")
            .Columns.Add("date_req", "DATE REQUESTED")
            .Columns.Add("date_needed", "DATE NEEDED")
            .Columns.Add("time_needed", "TIME NEEDED")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("operation", "WORK TO PERFORM")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("dtl_id", "DETAIL ID")



            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            '.Columns("lot_id").Width = 60
            '.Columns("lot_id").Visible = False
            .Columns("count").Width = 60
            .Columns("req_no").Width = 120
            .Columns("req_no").Visible = False
            .Columns("date_req").Width = 110
            .Columns("date_needed").Width = 110
            .Columns("time_needed").Width = 110
            .Columns("location").Width = 150
            .Columns("lot_no").Width = 120
            .Columns("operation").Width = 200
            .Columns("purpose").Width = 300
            .Columns("req_by").Width = 150
            .Columns("dtl_id").Width = 20
            .Columns("dtl_id").Visible = False



            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_request_tt.EnableGrouping = True
            Me.lv_request_tt.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_scheduled_form_column()

        Me.lv_trip_ticket_scheduled.Columns.Clear()

        With Me.lv_trip_ticket_scheduled
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("tt_no", "TICKET NUMBER")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")



            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_trip_ticket_scheduled.EnableGrouping = True
            Me.lv_trip_ticket_scheduled.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_accomplished_form_column()

        Me.lv_accomplished_ticket.Columns.Clear()

        With Me.lv_accomplished_ticket
            .Columns.Add("id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("trip_no", "TICKET NUMBER")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("work_done", "TRIP WORK ITEM DONE")
            .Columns.Add("operate_hrs", "TRIP TOTAL OPERATE HOURS")
            .Columns.Add("area_done", "TRIP TOTAL AREA DONE")
            .Columns.Add("grand_amount", "TRIP TICKET GRAND TOTAL AMOUNT")


            .Columns("id").Width = 60
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("trip_date").Width = 150
            .Columns("trip_no").Width = 150
            .Columns("location").Width = 180
            .Columns("work_done").Width = 180
            .Columns("operate_hrs").Width = 180
            .Columns("area_done").Width = 200
            .Columns("grand_amount").Width = 220

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_accomplished_ticket.EnableGrouping = True
            Me.lv_accomplished_ticket.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_accomplished_item_column()

        Me.lv_approved_request_item.Columns.Clear()

        With Me.lv_approved_request_item
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("req_no", "REQUEST NO.")
            .Columns.Add("tt_no", "TICKET NUMBER")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")


            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("req_no").Width = 130
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_approved_request_item.EnableGrouping = True
            Me.lv_approved_request_item.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_schedule_processed_data_column()

        Me.lv_trip_ticket_schedule_processed_data.Columns.Clear()

        With Me.lv_trip_ticket_schedule_processed_data
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("tt_no", "TICKET NUMBER")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")
            .Columns.Add("process_by", "PROCESSED BY")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150
            .Columns("process_by").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_trip_ticket_schedule_processed_data.EnableGrouping = True
            Me.lv_trip_ticket_schedule_processed_data.ShowGroups = True
        End With
    End Sub
    Sub trip_ticket_accomplihed_posted_data_column()

        Me.lv_accomplished_posted_data.Columns.Clear()

        With Me.lv_accomplished_posted_data
            .Columns.Add("id", "hdr_id")
            '.Columns.Add("dtl_id", "dtl_id")
            .Columns.Add("count", "#")
            .Columns.Add("tt_no", "TICKET NUMBER")
            .Columns.Add("trip_date", "TRIP DATE")
            .Columns.Add("location", "DESTINATION")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_no", "EQUIPMENT NO.")
            .Columns.Add("imple_code", "IMPLEMENT CODE")
            .Columns.Add("driver", "DRIVER")
            .Columns.Add("purpose", "PURPOSE")
            .Columns.Add("req_by", "REQUESTED BY")
            .Columns.Add("app_bt", "APPROVED BY")
            .Columns.Add("process_by", "PROCESSED BY")

            .Columns("id").Width = 60
            .Columns("id").Visible = False
            '.Columns("dtl_id").Width = 60
            '.Columns("dtl_id").Visible = False
            .Columns("count").Width = 60
            .Columns("tt_no").Width = 130
            .Columns("trip_date").Width = 100
            .Columns("location").Width = 100
            .Columns("equip_type").Width = 110
            .Columns("equip_no").Width = 100
            .Columns("imple_code").Width = 110
            .Columns("driver").Width = 120
            .Columns("purpose").Width = 250
            .Columns("req_by").Width = 150
            .Columns("app_bt").Width = 150
            .Columns("process_by").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_accomplished_posted_data.EnableGrouping = True
            Me.lv_accomplished_posted_data.ShowGroups = True
        End With
    End Sub
#End Region

    ''' <summary>
    ''' ''''''FLAG VIEW TYPE
    ''' view all = 0
    ''' by individual = 1
    ''' ''''''FLAG PURPOSE
    ''' retreiving = 0
    ''' counting = 1
    ''' ''''''FLAG FORM TYPE
    ''' request = 0
    ''' schedule = 1
    ''' accomplish = 2
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

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
                        For x As Integer = 0 To cms_menu_tripticket_request.Items.Count - 1
                            If cms_menu_tripticket_request.Items(x).Tag = i Then
                                If flag = True Then
                                    cms_menu_tripticket_request.Items(x).Enabled = True
                                Else
                                    cms_menu_tripticket_request.Items(x).Enabled = False
                                End If
                            End If
                        Next
                    ElseIf tag = 2 Then
                        '''''REQUEST
                        For x As Integer = 0 To cms_menu_tripticket_scheduled.Items.Count - 1
                            If cms_menu_tripticket_scheduled.Items(x).Tag = i Then
                                If flag = True Then
                                    cms_menu_tripticket_scheduled.Items(x).Enabled = True
                                Else
                                    cms_menu_tripticket_scheduled.Items(x).Enabled = False
                                End If
                            End If
                        Next

                    Else
                        '''''REQUEST
                        For x As Integer = 0 To cms_tripticket_accomplished.Items.Count - 1
                            If cms_tripticket_accomplished.Items(x).Tag = i Then
                                If flag = True Then
                                    cms_tripticket_accomplished.Items(x).Enabled = True
                                Else
                                    cms_tripticket_accomplished.Items(x).Enabled = False
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

    Private Sub Frm_trip_ticket_NEWS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes

        access_enabled_disabled("p_ais_main_access_validation_command '0','" & user_id & "','5'")

        If request_id <> 0 Then
            Me.pvp1_tab.Enabled = True

            menus_access_enabled_disabled("p_ais_main_access_validation_command '1','','','" & request_id & "'", 1)
        Else
            Me.pvp1_tab.Enabled = False
        End If

        If scheduled_id <> 0 Then
            Me.pvp2_tab.Enabled = True

            menus_access_enabled_disabled("p_ais_main_access_validation_command '1','','','" & scheduled_id & "'", 2)
        Else
            Me.pvp2_tab.Enabled = False
        End If

        If accomplished_id <> 0 Then
            Me.pvp3_tab.Enabled = True

            menus_access_enabled_disabled("p_ais_main_access_validation_command '1','','','" & accomplished_id & "'", 3)
        Else
            Me.pvp3_tab.Enabled = False
        End If

        trip_ticket_request_form_column()
        trip_ticket_scheduled_form_column()
        trip_ticket_accomplished_form_column()
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
                            request_id = sysmod.dr.Item(0)
                        Case 1
                            scheduled_id = sysmod.dr.Item(0)
                        Case 2
                            accomplished_id = sysmod.dr.Item(0)
                    End Select
                    i += 1
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lv_request_tt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_request_tt.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_menu_tripticket_request.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub pv_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pv_tab.SelectedPageChanged
        If pv_tab.SelectedPage Is pvp_1 Then
            glomod.populate_dropdown(dp_viewbyuser, "Select fullname FROM [agrikulto].[dbo].[v_ais_trip_ticket_request_form] GROUP BY fullname ORDER BY fullname")
            dp_viewbyuser.SelectedIndex = -1

            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ", 1, 0, 0", 11, "Loading...",
                         "p_ais_trip_ticket_main_datas " & user_id & ", 1, 1, 0")
            glomod.data_item_grouping(lv_request_tt, "req_no")


        ElseIf pv_tab.SelectedPage Is pvp_2 Then
            glomod.populate_dropdown(dp_viewindivindual_scheduled, "SELECT fullname FROM v_ais_trip_ticket_schedule_form  GROUP BY fullname ORDER BY fullname")
            dp_viewindivindual_scheduled.SelectedIndex = -1

            glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & user_id & "'", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',1,'" & user_id & "'")
            glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")
        ElseIf pv_tab.SelectedPage Is pvp_3 Then
            'v_ais_trip_ticket_accomplished_form
            glomod.populate_dropdown(dp_viewindividual_accomplish, "SELECT fullname FROM v_ais_trip_ticket_accomplished_form  GROUP BY fullname ORDER BY fullname")
            dp_viewindividual_accomplish.SelectedIndex = -1

            glomod.populate_listview_progress_status(lv_accomplished_ticket, "p_ais_trip_ticket_accomplished_datas '',0,0,'',''", 8, "Loading...",
                                                     "p_ais_trip_ticket_accomplished_datas '',1,0,'',''")

            glomod.data_item_grouping(lv_accomplished_ticket, "trip_date")
        End If
    End Sub

    Private Sub lv_request_tt_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_request_tt.CellFormatting,
            lv_trip_ticket_scheduled.CellFormatting, lv_accomplished_ticket.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_request_tt_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_request_tt.VisualItemFormatting,
            lv_trip_ticket_scheduled.VisualItemFormatting, lv_accomplished_ticket.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub lv_request_tt_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_request_tt.SelectedItemChanged
        slct_id_req_hdr = glomod.selection_listview(lv_request_tt)
        'MsgBox(slct_id_req_hdr)

        If lv_request_tt.SelectedItems.Count > 0 Then
            With lv_request_tt.SelectedItems(0)
                slct_id_req_dtl = .SubItems(11)
            End With
        End If
    End Sub

    Private Sub lv_trip_ticket_scheduled_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_trip_ticket_scheduled.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cms_menu_tripticket_scheduled.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_accomplished_ticket_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_accomplished_ticket.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_tripticket_accomplished.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub posting_Click(sender As Object, e As EventArgs)
        If slct_id_req_hdr = Nothing Then
            RadMessageBox.Show("Please select an item first to proceed.")
            Exit Sub
        End If

        sysmod.Update_posting_status(slct_id_req_hdr)
        sysmod.Update_after_posting(slct_id_req_hdr)

        accomplished_form_view.trip_ticket_accomplished_listview_load()
    End Sub


    Private Sub lv_accomplished_posted_data_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_accomplished_posted_data.SelectedItemChanged
        accomplished_form_view.Global_schedule_processed_data_selected()
        form_type = 2
    End Sub

    Private Sub lv_trip_ticket_schedule_processed_data_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_trip_ticket_schedule_processed_data.SelectedItemChanged
        schedule_form_view.Global_schedule_processed_data_selected()
        form_type = 1
    End Sub

    Private Sub lv_approved_request_item_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_approved_request_item.SelectedItemChanged
        request_form_view.Global_approve_request_data_selected()
        form_type = 0
    End Sub

    Private Sub lv_approved_request_item_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_approved_request_item.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_status.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub lv_trip_ticket_schedule_processed_data_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_trip_ticket_schedule_processed_data.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_status.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub lv_accomplished_posted_data_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_accomplished_posted_data.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_status.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
    Private Sub cmsmoredetails_Click(sender As Object, e As EventArgs) Handles cmsmoredetails.Click
        If slct_id_req_hdr = Nothing Then
            RadMessageBox.Show("Please select an record to proceed.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If
        Frm_main.Enabled = False
        Frm_form_status.Show()
    End Sub

    Private Sub btn_search_MouseHover(sender As Object, e As EventArgs) Handles btn_search.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_remove_filter_MouseLeave(sender As Object, e As EventArgs) Handles btn_search.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub dp_viewbyuser_KeyDown(sender As Object, e As KeyEventArgs) Handles dp_viewbyuser.KeyDown
        If e.KeyCode = Keys.Escape Then
            dp_viewbyuser.Text = ""
        End If
    End Sub
    Private Sub chk_viewall_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chk_viewall.ToggleStateChanged
        Application.DoEvents()

        If chk_viewall.CheckState = CheckState.Checked Then
            chk_viewall.Enabled = False
            dp_viewbyuser.Enabled = False
            dp_viewbyuser.Text = ""
            'dtp_datefrom.Value = Nothing
            'dtp_dateto.Value = Nothing

            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ",0,0,0", 11, "Loading...",
                                   "p_ais_trip_ticket_main_datas " & user_id & ",0,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        Else
            dp_viewbyuser.Enabled = True
            dp_viewbyuser.Text = ""
            'dtp_datefrom.Value = Nothing
            'dtp_dateto.Value = Nothing

            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ",1,0,0", 11, "Loading...",
                     "p_ais_trip_ticket_main_datas " & user_id & ",1,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        End If

        chk_viewall.Enabled = True
    End Sub

    Private Sub dp_viewbyuser_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_viewbyuser.SelectedIndexChanged
        viewbyindividual_id = selection_dropdown("SELECT user_id FROM [agrikulto].[dbo].[v_ais_trip_ticket_request_form] WHERE fullname='" & dp_viewbyuser.Text & "'")

        If dp_viewbyuser.Text = "" Then
            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ",1,0,0", 11, "Loading...",
                                 "p_ais_trip_ticket_main_datas " & user_id & ",1,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        Else
            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & viewbyindividual_id & ",1,0,0", 11, "Loading...",
                                    "p_ais_trip_ticket_main_datas " & viewbyindividual_id & ",1,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        End If

        'dtp_datefrom.Value = Nothing
        'dtp_dateto.Value = Nothing
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If chk_viewall.CheckState = CheckState.Checked Then
            'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
            '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
            '                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
            '    glomod.data_item_grouping(lv_request_tt, "req_no")
            'Else
            glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,''" _
                                    & ",'','" & mcc_findreqno.Text & "',1", 11)
            glomod.data_item_grouping(lv_request_tt, "req_no")
            'End If
        Else
            If viewbyindividual_id <> 0 Then
                'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                '                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
                '    glomod.data_item_grouping(lv_request_tt, "req_no")
                'Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,''" _
                         & ",'','" & mcc_findreqno.Text & "',1", 11)
                glomod.data_item_grouping(lv_request_tt, "req_no")
                'End If
            Else
                'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                '                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
                '    glomod.data_item_grouping(lv_request_tt, "req_no")
                'Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,''" _
                                         & ",'','" & mcc_findreqno.Text & "',1", 11)
                glomod.data_item_grouping(lv_request_tt, "req_no")
                'End If
            End If
        End If
    End Sub
    Function selection_dropdown(query As String)
        Dim has_id As Integer
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                has_id = sysmod.dr.Item("user_id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return has_id
    End Function

    Private Sub mcc_findreqno_KeyDown(sender As Object, e As KeyEventArgs) Handles mcc_findreqno.KeyDown
        If e.KeyCode = Keys.Escape Then
            mcc_findreqno.Text = ""

            If chk_viewall.CheckState = CheckState.Checked Then
                'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
                '                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
                '    glomod.data_item_grouping(lv_request_tt, "req_no")
                'Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,''" _
                                        & ",'','" & mcc_findreqno.Text & "',1", 11)
                glomod.data_item_grouping(lv_request_tt, "req_no")
                'End If
            Else
                If viewbyindividual_id <> 0 Then
                    'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                    '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                    '                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
                    '    glomod.data_item_grouping(lv_request_tt, "req_no")
                    'Else
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,''" _
                             & ",'','" & mcc_findreqno.Text & "',1", 11)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                    'End If
                Else
                    'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                    '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                    '                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
                    '    glomod.data_item_grouping(lv_request_tt, "req_no")
                    'Else
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,''" _
                                             & ",'','" & mcc_findreqno.Text & "',1", 11)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                    'End If
                End If
            End If
        End If
    End Sub

    Public Sub refresh_tripticket_request()
        If chk_viewall.CheckState = CheckState.Checked Then
            'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
            '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
            '                                 & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
            '    glomod.data_item_grouping(lv_request_tt, "req_no")
            'Else
            glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,''" _
                                        & ",'','" & mcc_findreqno.Text & "',1", 11)
            glomod.data_item_grouping(lv_request_tt, "req_no")
            'End If
        Else
            If viewbyindividual_id <> 0 Then
                'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                '                                 & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
                '    glomod.data_item_grouping(lv_request_tt, "req_no")
                'Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,''" _
                             & ",'','" & mcc_findreqno.Text & "',1", 11)
                glomod.data_item_grouping(lv_request_tt, "req_no")
                'End If
            Else
                'If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                '    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                '                                 & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 11)
                '    glomod.data_item_grouping(lv_request_tt, "req_no")
                'Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,''" _
                                             & ",'','" & mcc_findreqno.Text & "',1", 11)
                glomod.data_item_grouping(lv_request_tt, "req_no")
                'End If
            End If
        End If
    End Sub

    'TRIP TICKET REQUEST FORM
#Region "TRIP TICKET REQUEST"
    Private Sub mi_refresh_tt_Click(sender As Object, e As EventArgs) Handles mi_refresh_tt.Click
        refresh_tripticket_request()
    End Sub

    Private Sub mi_create_tt_Click(sender As Object, e As EventArgs) Handles mi_create_tt.Click
        Frm_request_form_add.Show()
        Frm_main.Enabled = False
    End Sub

    Private Sub mi_modify_tt_Click(sender As Object, e As EventArgs) Handles mi_modify_tt.Click
        Frm_request_form_update.Show()
        Frm_main.Enabled = False
    End Sub

    Private Sub mi_delete_tt_Click(sender As Object, e As EventArgs) Handles mi_delete_tt.Click
        glomod.delete_data("p_ais_trip_ticket_request_form_Deletion_cancellation '" & slct_id_req_hdr & "','" & slct_id_req_dtl & "',0")
        mi_refresh_tt.PerformClick()
    End Sub

    Private Sub mi_cancel_tt_Click(sender As Object, e As EventArgs) Handles mi_cancel_tt.Click
        If glomod.confirmation_msg() = Windows.Forms.DialogResult.Yes Then
            glomod.add_update_data("p_ais_trip_ticket_request_form_Deletion_cancellation '" & slct_id_req_hdr & "','" & slct_id_req_dtl & "',1")
        End If
        mi_refresh_tt.PerformClick()
    End Sub

    Private Sub mi_review_tt_Click(sender As Object, e As EventArgs) Handles mi_review_tt.Click
        If slct_id_req_hdr <= 0 Then
            RadMessageBox.Show("Select an Item on the list please to continue to next process.")
        Else
            request_form_view.for_approval_info(slct_id_req_dtl)
            Frm_request_form_approve.Show()
            Frm_main.Enabled = False
        End If
    End Sub

    Private Sub mcc_findreqno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mcc_findreqno.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
#End Region

    'TRIP TICKET SCHEDULED FORM
#Region "TRIP TICKCET SCHEDULED"
    Private Sub mi_refresh_schedule_Click(sender As Object, e As EventArgs) Handles mi_refresh_schedule.Click
        If chk_viewall_scheduled.CheckState = CheckState.Checked Then
            schedule_form_view.trip_ticket_listview_load("p_ais_trip_ticket_main_scheduled_data 0,'',0,''", lv_trip_ticket_scheduled)
        Else
            If viewbyindividual_id_scheduled <> 0 Then
                schedule_form_view.trip_ticket_listview_load("p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & viewbyindividual_id_scheduled & "'", lv_trip_ticket_scheduled)
            Else
                schedule_form_view.trip_ticket_listview_load("p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & user_id & "'", lv_trip_ticket_scheduled)
            End If

        End If
    End Sub

    Private Sub mi_review_printing_scheduled_Click(sender As Object, e As EventArgs) Handles mi_review_printing_scheduled.Click
        schedule_form_view.trip_ticket_scheduled_slct_lv()
        Frm_schedule_printing.Show()
        Frm_main.Enabled = False
    End Sub

    Private Sub mi_cancelled_scheduled_Click(sender As Object, e As EventArgs) Handles mi_cancelled_scheduled.Click
        schedule_form_view.trip_ticket_scheduled_slct_lv()

        If glomod.confirmation_msg() = Windows.Forms.DialogResult.Yes Then
            glomod.add_update_data("p_ais_trip_ticket_scheduled_cancelled '" & slct_id_hdr_schedule & "'")
        End If
    End Sub

    Private Sub mi_encoding_accom_scheduled_Click(sender As Object, e As EventArgs) Handles mi_encoding_accom_scheduled.Click
        Frm_main.Enabled = False
        Frm_schedule_encoding.Show()

        schedule_form_view.trip_ticket_scheduled_slct_lv()
    End Sub

    Private Sub mi_confirm_encoded_accom_scheduled_Click(sender As Object, e As EventArgs) Handles mi_confirm_encoded_accom_scheduled.Click
        Frm_main.Enabled = False
        Frm_schedule_confirm_posting.Show()
    End Sub

    Private Sub mi_refresh_accomplish_Click(sender As Object, e As EventArgs) Handles mi_refresh_accomplish.Click
        glomod.populate_listview_progress_status(lv_accomplished_ticket, "p_ais_trip_ticket_accomplished_datas '',0", 8, "Loading...", "p_ais_trip_ticket_accomplished_datas '',1")
    End Sub

    Private Sub mi_review_accomplished_Click(sender As Object, e As EventArgs) Handles mi_review_accomplished.Click
        Frm_main.Enabled = False
        Frm_accomplished_posting.Show()
    End Sub

    Private Sub chk_viewall_scheduled_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chk_viewall_scheduled.ToggleStateChanged
        Application.DoEvents()

        If chk_viewall_scheduled.CheckState = CheckState.Checked Then
            chk_viewall_scheduled.Enabled = False
            dp_viewindivindual_scheduled.Enabled = False
            dp_viewindivindual_scheduled.Text = ""
            'dtp_datefrom.Value = Nothing
            'dtp_dateto.Value = Nothing

            glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',0,''", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',0,''")
            glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")
        Else
            dp_viewindivindual_scheduled.Enabled = True
            dp_viewindivindual_scheduled.Text = ""
            'dtp_datefrom.Value = Nothing
            'dtp_dateto.Value = Nothing

            glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & user_id & "'", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',1,'" & user_id & "'")
            glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")
        End If

        chk_viewall_scheduled.Enabled = True
    End Sub

    Private Sub dp_viewindivindual_scheduled_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_viewindivindual_scheduled.SelectedIndexChanged
        viewbyindividual_id_scheduled = selection_dropdown("SELECT user_id FROM [agrikulto].[dbo].[v_ais_trip_ticket_schedule_form] WHERE fullname='" & dp_viewindivindual_scheduled.Text & "'")

        If dp_viewindivindual_scheduled.Text = "" Then
            glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & user_id & "'", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',1,'" & user_id & "'")
            glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")
        Else
            glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & viewbyindividual_id_scheduled & "'", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',1,'" & viewbyindividual_id_scheduled & "'")
            glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")
        End If

        viewbyindividual_id = 0
    End Sub

    Private Sub btn_search_scheduled_Click(sender As Object, e As EventArgs) Handles btn_search_scheduled.Click
        If chk_viewall_scheduled.CheckState = CheckState.Checked Then
            glomod.populate_listview(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 3,'',0,'','" & txt_search_scheduled.Text & "'", 11)
        Else
            If viewbyindividual_id_scheduled <> 0 Then
                glomod.populate_listview(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 3,'',1,'" & viewbyindividual_id_scheduled & "','" & txt_search_scheduled.Text & "'", 11)
            Else
                glomod.populate_listview(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 3,'',1,'" & user_id & "','" & txt_search_scheduled.Text & "'", 11)
            End If

        End If
    End Sub

    Private Sub txt_search_scheduled_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search_scheduled.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_search_scheduled_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_search_scheduled.KeyDown
        If e.KeyCode = Keys.Escape Then
            txt_search_scheduled.Text = ""

            If chk_viewall_scheduled.CheckState = CheckState.Checked Then
                glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',0,''", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',0,''")
                glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")

            Else
                If viewbyindividual_id_scheduled <> 0 Then
                    glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & viewbyindividual_id_scheduled & "'", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',1,'" & viewbyindividual_id_scheduled & "'")
                    glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")
                Else
                    glomod.populate_listview_progress_status(lv_trip_ticket_scheduled, "p_ais_trip_ticket_main_scheduled_data 0,'',1,'" & user_id & "'", 11, "Loading...",
                                                     "p_ais_trip_ticket_main_scheduled_data 1,'',1,'" & user_id & "'")
                    glomod.data_item_grouping(lv_trip_ticket_scheduled, "trip_date")
                End If
            End If
        End If
    End Sub
#End Region

End Class
