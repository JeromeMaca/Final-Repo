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
            glomod.populate_listview_progress_status(lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8, "Loading...",
                                       " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr A INNER JOIN tbl_ais_canepoint_signatories B ON A.id=B.hdr_id  WHERE B.requested_by='" & user_id & "' AND status = 1")
            glomod.data_item_grouping(lv_request_canepoint, "date_req")

            glomod.data_item_selected_zero(lv_request_canepoint, 1)
            slct_id_canepoint_main_request = 0
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
                                       " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr A INNER JOIN tbl_ais_canepoint_signatories B ON A.id=B.hdr_id  WHERE B.requested_by='" & user_id & "' AND status = 1")
        glomod.data_item_grouping(lv_request_canepoint, "date_req")

        glomod.data_item_selected_zero(lv_request_canepoint, 1)
        slct_id_canepoint_main_request = 0
    End Sub

    Private Sub conmenu_modifyrequest_Click(sender As Object, e As EventArgs) Handles conmenu_modifyrequest.Click
        Dim Frm_canepoint_request_update As New Frm_canepoint_request_update
        If slct_id_canepoint_main_request <> 0 Then
            Frm_main.Enabled = False



            Frm_canepoint_request_update.dp_location.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT location FROM jcso.dbo.tbl_com_locations_ml ORDER BY location ASC", "location")
            Frm_canepoint_request_update.dp_location.DisplayMember = "location"
            Frm_canepoint_request_update.dp_location.Text = ""
            Frm_canepoint_request_update.dp_receiving_owner.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT pl_name FROM jcso.dbo.tbl_com_planters_ml ORDER BY pl_name ASC", "pl_names")
            Frm_canepoint_request_update.dp_receiving_owner.DisplayMember = "pl_name"
            Frm_canepoint_request_update.dp_receiving_owner.Text = ""


            If lv_request_canepoint.SelectedItems.Count > 0 Then
                With lv_request_canepoint.SelectedItems(0)

                    Frm_canepoint_request_update.txt_req_no.Text = .SubItems(2)
                    Frm_canepoint_request_update.dt_dateneeded.Value = .SubItems(3)
                    Frm_canepoint_request_update.dp_location.SelectedText = .SubItems(4)
                    Frm_canepoint_request_update.dp_receiving_owner.SelectedText = .SubItems(5)
                    Frm_canepoint_request_update.se_total_canepoints.Value = .SubItems(6)
                    Frm_canepoint_request_update.txt_req_date.Text = .SubItems(7)
                    Frm_canepoint_request_update.txt_req_by.Text = .SubItems(8)
                End With
            End If

            Frm_canepoint_request_update.Show()
        Else
            RadMessageBox.Show("Selected an item to proceed.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub lv_request_canepoint_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_request_canepoint.SelectedItemChanged
        slct_id_canepoint_main_request = glomod.selection_listview(lv_request_canepoint)
    End Sub

    Private Sub conmenu_deleterequest_Click(sender As Object, e As EventArgs) Handles conmenu_deleterequest.Click
        glomod.delete_data("DELETE FROM tbl_ais_canepoint_hdr WHERE id='" & slct_id_canepoint_main_request & "'")

        If sysmod.msgb = 2 Then
            glomod.populate_listview(lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8)
            glomod.data_item_grouping(lv_request_canepoint, "date_req")

            glomod.data_item_selected_zero(lv_request_canepoint, 1)
            slct_id_canepoint_main_request = 0
        End If
    End Sub

    Private Sub conmenu_Cancelrequest_Click(sender As Object, e As EventArgs) Handles conmenu_Cancelrequest.Click
        If slct_id_canepoint_main_request <> 0 Then
            If (glomod.confirmation_msg()) = Windows.Forms.DialogResult.Yes Then
                glomod.add_update_data("UPDATE tbl_ais_canepoint_hdr SET status=10 WHERE id='" & slct_id_canepoint_main_request & "'")

                glomod.populate_listview(lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8)
                glomod.data_item_grouping(lv_request_canepoint, "date_req")

                glomod.data_item_selected_zero(lv_request_canepoint, 1)
                slct_id_canepoint_main_request = 0
            End If
        Else
            RadMessageBox.Show("Selected an item to proceed.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub conmenu_reviewrequest_Click(sender As Object, e As EventArgs) Handles conmenu_reviewrequest.Click
        Frm_main.Enabled = False
        Frm_canepoint_request_review.Show()
    End Sub
End Class
