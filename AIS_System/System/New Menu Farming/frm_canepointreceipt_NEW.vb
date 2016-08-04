Imports System.Data.SqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class Frm_canepointreceipt_NEW

    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Private Sub conmenu_createrequest_Click(sender As Object, e As EventArgs) Handles conmenu_createrequest.Click
        Frm_main.Enabled = False
        Frm_canepoint_request.Show()
    End Sub

#Region "CANEPOINT LISTVIEW COLUMN"
    Sub canepoint_main_request()
        lv_request_canepoint.Columns.Clear()

        '        #
        '        id
        '        req_no
        '        date_needed
        '        receiving_barrio
        '        receiving_owner
        '        total_canepoint
        '        date_requested
        '        fullname

        With lv_request_canepoint
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("req_no", "REQUEST NO.")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("r_barrio", "RECEIVING BARRIO")
            .Columns.Add("r_tobereceiveby", "RECEIVING OWNER")
            .Columns.Add("r_total_canepoints", "TOTAL CANEPOINTS")
            .Columns.Add("date_requested", "REQUESTRED DATE")
            .Columns.Add("requested_name", "REQUESTRED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("req_no").Width = 100
            .Columns("date_req").Width = 150
            .Columns("r_barrio").Width = 200
            .Columns("r_tobereceiveby").Width = 200
            .Columns("r_total_canepoints").Width = 150
            .Columns("date_requested").Width = 150
            .Columns("requested_name").Width = 200

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region

    Private Sub Frm_canepointreceipt_NEW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
    End Sub

    Private Sub lv_request_tt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_request_canepoint.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_canepoint_request.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub pv_tab_SelectedPageChanged(sender As Object, e As EventArgs) Handles pv_tab.SelectedPageChanged
        If pv_tab.SelectedPage Is pvp_1 Then
            canepoint_main_request()

            'glomod.populate_listview_using_datatable(lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8, "canepoint_main_requested_data")
            glomod.populate_listview_progress_status(lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8, "Loading...",
                                       " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr A INNER JOIN tbl_ais_canepoint_signatories B ON A.id=B.hdr_id  WHERE B.requested_by='" & user_id & "'")
            glomod.data_item_grouping(lv_request_canepoint, "date_req")
        ElseIf pv_tab.SelectedPage Is pvp_2 Then
            MsgBox("APPROVED CANE POINT")
        Else
            MsgBox("DELIVERED CANEPOINT")
        End If
    End Sub

    Private Sub lv_request_canepoint_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_request_canepoint.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_request_canepoint_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_request_canepoint.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub conmenu_refresh_Click(sender As Object, e As EventArgs) Handles conmenu_refresh.Click
        glomod.populate_listview_progress_status(lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8, "Loading...",
                                       " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr A INNER JOIN tbl_ais_canepoint_signatories B ON A.id=B.hdr_id  WHERE B.requested_by='" & user_id & "'")
        glomod.data_item_grouping(lv_request_canepoint, "date_req")
    End Sub
End Class
