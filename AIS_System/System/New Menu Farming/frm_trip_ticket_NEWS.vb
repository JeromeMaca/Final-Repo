Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class Frm_trip_ticket_NEWS
    Dim sysmod As New System_mod
    Dim glomod As New global_mod
    Dim ctr As Integer = 0
    Dim ctr2 As Integer = 0

    Dim viewbyindividual_id As Integer = 0

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
            .Columns.Add("tt_no", "TRIP TICKET NO.")
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
            .Columns.Add("trip_no", "TRIP NUMBER")
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
            .Columns.Add("tt_no", "TRIP TICKET NO.")
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
            .Columns.Add("tt_no", "TRIP TICKET NO.")
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
            .Columns.Add("tt_no", "TRIP TICKET NO.")
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

    Private Sub Frm_trip_ticket_NEWS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        'glomod.dt = glomod.CreateDataTable("SELECT user_id,fullname FROM [agrikulto].[dbo].[v_ais_trip_ticket_request_form] GROUP BY user_id,fullname")

        'dp_viewbyuser.DisplayMember = "fullname"
        'dp_viewbyuser.ValueMember = "user_id"
        'dp_viewbyuser.DataSource = glomod.dt
        'dp_viewbyuser.CloseDropDown()
        'dp_viewbyuser.SelectedIndex = -1

        glomod.populate_dropdown(dp_viewbyuser, "SELECT fullname FROM [agrikulto].[dbo].[v_ais_trip_ticket_request_form] GROUP BY fullname")
        dp_viewbyuser.SelectedIndex = -1
    End Sub
    Private Sub menubtn_add_Click(sender As Object, e As EventArgs) Handles menubtn_add.Click
        Frm_request_form_add.Show()
        Frm_main.Enabled = False
    End Sub
    Private Sub menubtn_review_Click(sender As Object, e As EventArgs) Handles menubtn_review.Click
        If slct_id_req_hdr <= 0 Then
            RadMessageBox.Show("Select an Item on the list please to continue to next process.")
        Else
            request_form_view.for_approval_info()

            Frm_request_form_approve.Show()
            Frm_main.Enabled = False
        End If
    End Sub
    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menubtn_modify.Click
        Frm_request_form_update.Show()
        Frm_main.Enabled = False
    End Sub
    Private Sub lv_request_tt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_request_tt.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_menucontrol_tripticket_request.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub pvp1_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp1_tab.SelectedPageChanged

        If Me.pvp1_tab.SelectedPage Is pvp1_1 Then
            trip_ticket_request_form_column()
            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ",1,0,0", 10, "Loading...",
                                     "p_ais_trip_ticket_main_datas " & user_id & ",1,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")

        ElseIf Me.pvp1_tab.SelectedPage Is pvp1_2 Then
            'trip_ticket_accomplished_item_column()
            'request_form_view.trip_ticket_request_form_approved_data_load()

            'Me.lv_approved_request_item.GroupDescriptors.Clear()
            'Dim groupByType As New GroupDescriptor("trip_date")
            'Me.lv_approved_request_item.GroupDescriptors.Add(groupByType)

        End If
    End Sub

    Private Sub lv_request_tt_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_request_tt.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub menubtn_refresh_Click(sender As Object, e As EventArgs) Handles menubtn_refresh.Click
        If chk_viewall.CheckState = CheckState.Checked Then
            If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
                                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                glomod.data_item_grouping(lv_request_tt, "req_no")
            Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
                                        & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                glomod.data_item_grouping(lv_request_tt, "req_no")
            End If
        Else
            If viewbyindividual_id <> 0 Then
                If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                                 & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                Else
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                End If
            Else
                If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                                 & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                Else
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                End If
            End If
        End If
    End Sub

    Private Sub lv_request_tt_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_request_tt.SelectedItemChanged
        slct_id_req_hdr = glomod.selection_listview(lv_request_tt)
        'MsgBox(slct_id_req_hdr)
    End Sub

    Private Sub pv_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pv_tab.SelectedPageChanged
        'ctr2 += 1
        'If ctr2 >= 2 Then
        '    If Me.pv_tab.Pages.IndexOf(Me.pv_tab.SelectedPage).ToString() = "1" Then

        '        trip_ticket_scheduled_form_column()
        '        schedule_form_view.trip_ticket_listview_load()

        '        Me.lv_trip_ticket_scheduled.GroupDescriptors.Clear()
        '        Dim groupByType As New GroupDescriptor("trip_date")
        '        Me.lv_trip_ticket_scheduled.GroupDescriptors.Add(groupByType)
        '    ElseIf Me.pv_tab.Pages.IndexOf(Me.pv_tab.SelectedPage).ToString() = "2" Then

        '        trip_ticket_accomplished_form_column()
        '        accomplished_form_view.trip_ticket_accomplished_listview_load()
        '        Me.lv_accomplished_ticket.GroupDescriptors.Clear()
        '        Dim groupByType As New GroupDescriptor("trip_date")
        '        Me.lv_accomplished_ticket.GroupDescriptors.Add(groupByType)
        '    End If
        'End If


        If Me.pv_tab.SelectedPage Is pvp_2 Then

            'trip_ticket_scheduled_form_column()
            'schedule_form_view.trip_ticket_listview_load()

            'Me.lv_trip_ticket_scheduled.GroupDescriptors.Clear()
            'Dim groupByType As New GroupDescriptor("trip_date")
            'Me.lv_trip_ticket_scheduled.GroupDescriptors.Add(groupByType)
        ElseIf Me.pv_tab.SelectedPage Is pvp_3 Then

            'trip_ticket_accomplished_form_column()
            'accomplished_form_view.trip_ticket_accomplished_listview_load()
            'Me.lv_accomplished_ticket.GroupDescriptors.Clear()
            'Dim groupByType As New GroupDescriptor("trip_date")
            'Me.lv_accomplished_ticket.GroupDescriptors.Add(groupByType)
        End If
    End Sub

    Private Sub pvp2_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp2_tab.SelectedPageChanged
        If Me.pvp2_tab.SelectedPage Is pvp2_2 Then
            'Me.lv_trip_ticket_schedule_processed_data.Columns.Clear()
            'trip_ticket_schedule_processed_data_column()
            'schedule_form_view.trip_ticket_schedule_form_processed_data_load()

            'Me.lv_trip_ticket_schedule_processed_data.GroupDescriptors.Clear()
            'Dim groupByType As New GroupDescriptor("trip_date")
            'Me.lv_trip_ticket_schedule_processed_data.GroupDescriptors.Add(groupByType)
        End If
    End Sub

    Private Sub lv_trip_ticket_scheduled_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_trip_ticket_scheduled.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub
    Private Sub review_tripticket_schedule_Click(sender As Object, e As EventArgs) Handles review_tripticket_schedule.Click
        Frm_main.Enabled = False
        Frm_schedule_encoding.Show()

        schedule_form_view.trip_ticket_scheduled_slct_lv()
    End Sub
    Private Sub lv_trip_ticket_scheduled_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_trip_ticket_scheduled.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_tripticket_schedule.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_accomplished_ticket_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_accomplished_ticket.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_tripticket_accomplished.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles posting_review.Click
        If slct_id_req_hdr = Nothing Then
            RadMessageBox.Show("Select an Item please to proceed.")
            Exit Sub
        End If
        Frm_main.Enabled = False
        Frm_accomplished_posting.Show()
    End Sub

    Private Sub lv_accomplished_ticket_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_accomplished_ticket.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (e.CellElement).Data.Name = "grand_amount" Then
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

    Private Sub lv_accomplished_ticket_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_accomplished_ticket.SelectedItemChanged
        slct_id_req_hdr = Nothing
        If Me.lv_accomplished_ticket.SelectedItems.Count > 0 Then
            With Me.lv_accomplished_ticket.SelectedItems(0)
                slct_id_req_hdr = .SubItems(0)
                Frm_accomplished_posting.txt_trip_ticket_no.Text = .SubItems(3)
            End With
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles posting_refresh.Click
        accomplished_form_view.trip_ticket_accomplished_listview_load()
    End Sub

    Private Sub posting_Click(sender As Object, e As EventArgs) Handles posting.Click
        If slct_id_req_hdr = Nothing Then
            RadMessageBox.Show("Please select an item first to proceed.")
            Exit Sub
        End If

        sysmod.Update_posting_status(slct_id_req_hdr)
        sysmod.Update_after_posting(slct_id_req_hdr)

        accomplished_form_view.trip_ticket_accomplished_listview_load()
    End Sub

    Private Sub print_hardcopy_Click(sender As Object, e As EventArgs) Handles print_hardcopy.Click
        schedule_form_view.trip_ticket_scheduled_slct_lv()

        Frm_trip_ticket_schedule_report.Show()
        Frm_main.Enabled = False

    End Sub

    Private Sub refresh_schedule_list_Click(sender As Object, e As EventArgs) Handles refresh_schedule_list.Click
        schedule_form_view.trip_ticket_listview_load()
    End Sub

    Private Sub lv_approved_request_item_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_approved_request_item.CellFormatting
        request_form_view.lv_cellformatting(e)
    End Sub

    Private Sub lv_trip_ticket_schedule_processed_data_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_trip_ticket_schedule_processed_data.CellFormatting
        schedule_form_view.lv_cellformatting(e)
    End Sub
    Private Sub pvp3_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp3_tab.SelectedPageChanged
        If Me.pvp3_tab.SelectedPage Is pvp3_2 Then

            'Me.lv_accomplished_posted_data.Columns.Clear()
            'trip_ticket_accomplihed_posted_data_column()
            'accomplished_form_view.trip_ticket_accomplihed_form_posted_data_load()

            'Me.lv_accomplished_posted_data.GroupDescriptors.Clear()
            'Dim groupByType As New GroupDescriptor("trip_date")
            'Me.lv_accomplished_posted_data.GroupDescriptors.Add(groupByType)
        End If
    End Sub

    Private Sub lv_accomplished_posted_data_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_accomplished_posted_data.CellFormatting
        accomplished_form_view.lv_cellformatting(e)
    End Sub

    Private Sub lv_trip_ticket_scheduled_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_trip_ticket_scheduled.SelectedItemChanged
        'Frm_main.Enabled = False
        'Frm_schedule_encoding.Show()

        schedule_form_view.trip_ticket_scheduled_slct_lv()
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

    Private Sub lv_request_tt_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_request_tt.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub mcc_findaccount_EditorControl_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles mcc_findreqno.EditorControl.CellFormatting

    End Sub

    Private Sub btn_search_MouseHover(sender As Object, e As EventArgs) Handles btn_search.MouseHover, btn_remove_filter.MouseHover
        If sender Is btn_search Then
            glomod.btn_forecolor(btn_search, 0)
        Else
            glomod.btn_forecolor(btn_remove_filter, 0)
        End If
    End Sub

    Private Sub btn_remove_filter_MouseLeave(sender As Object, e As EventArgs) Handles btn_search.MouseLeave, btn_remove_filter.MouseLeave
        If sender Is btn_search Then
            glomod.btn_forecolor(btn_search, 1)
        Else
            glomod.btn_forecolor(btn_remove_filter, 1)
        End If
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
            dtp_datefrom.Value = Nothing
            dtp_dateto.Value = Nothing

            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ",0,0,0", 10, "Loading...",
                                   "p_ais_trip_ticket_main_datas " & user_id & ",0,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        Else
            dp_viewbyuser.Enabled = True
            dp_viewbyuser.Text = ""
            dtp_datefrom.Value = Nothing
            dtp_dateto.Value = Nothing

            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ",1,0,0", 10, "Loading...",
                     "p_ais_trip_ticket_main_datas " & user_id & ",1,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        End If
        chk_viewall.Enabled = True
    End Sub

    Private Sub dp_viewbyuser_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_viewbyuser.SelectedIndexChanged
        viewbyindividual_id = selection_dropdown("SELECT user_id FROM [agrikulto].[dbo].[v_ais_trip_ticket_request_form] WHERE fullname='" & dp_viewbyuser.Text & "'")

        If dp_viewbyuser.Text = "" Then
            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & user_id & ",1,0,0", 10, "Loading...",
                                 "p_ais_trip_ticket_main_datas " & user_id & ",1,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        Else
            glomod.populate_listview_progress_status(lv_request_tt, "p_ais_trip_ticket_main_datas " & viewbyindividual_id & ",1,0,0", 10, "Loading...",
                                    "p_ais_trip_ticket_main_datas " & viewbyindividual_id & ",1,1,0")
            glomod.data_item_grouping(lv_request_tt, "req_no")
        End If

        dtp_datefrom.Value = Nothing
        dtp_dateto.Value = Nothing
    End Sub

    Private Sub btn_remove_filter_Click(sender As Object, e As EventArgs) Handles btn_remove_filter.Click
        If dtp_datefrom.Value = Nothing Or dtp_dateto.Value = Nothing Then
            RadMessageBox.Show("Please provide all data field needed." & vbCrLf & "Start Date and End Date...", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If chk_viewall.CheckState = CheckState.Checked Then
            glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "','" & dtp_dateto.Value & "','',0", 10)
            glomod.data_item_grouping(lv_request_tt, "req_no")
        Else
            If viewbyindividual_id <> 0 Then
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "','" & dtp_dateto.Value & "','',0", 10)
                glomod.data_item_grouping(lv_request_tt, "req_no")
            Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "','" & dtp_dateto.Value & "','',0", 10)
                glomod.data_item_grouping(lv_request_tt, "req_no")
            End If
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If chk_viewall.CheckState = CheckState.Checked Then
            If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
                                         & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                glomod.data_item_grouping(lv_request_tt, "req_no")
            Else
                glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
                                    & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                glomod.data_item_grouping(lv_request_tt, "req_no")
            End If
        Else
            If viewbyindividual_id <> 0 Then
                If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                Else
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                         & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                End If
            Else
                If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                Else
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                         & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                End If
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
                If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
                                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                Else
                    glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",0,0,'" & dtp_datefrom.Value & "'" _
                                        & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                    glomod.data_item_grouping(lv_request_tt, "req_no")
                End If
            Else
                If viewbyindividual_id <> 0 Then
                    If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                        glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                                 & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                        glomod.data_item_grouping(lv_request_tt, "req_no")
                    Else
                        glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & viewbyindividual_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                        glomod.data_item_grouping(lv_request_tt, "req_no")
                    End If
                Else
                    If dtp_datefrom.Value <> Nothing Or dtp_dateto.Value <> Nothing Then
                        glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                                 & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',0", 10)
                        glomod.data_item_grouping(lv_request_tt, "req_no")
                    Else
                        glomod.populate_listview(lv_request_tt, "p_ais_trip_ticket_main_data_find " & user_id & ",1,0,'" & dtp_datefrom.Value & "'" _
                                             & ",'" & dtp_dateto.Value & "','" & mcc_findreqno.Text & "',1", 10)
                        glomod.data_item_grouping(lv_request_tt, "req_no")
                    End If
                End If
            End If
        End If
    End Sub
End Class
