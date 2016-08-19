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

    Sub canepoint_main_approved()
        lv_aprroved_canepoint.Columns.Clear()

        With lv_aprroved_canepoint
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("req_no", "CANEPOINT NO.")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("r_barrio", "RECEIVING BARRIO")
            .Columns.Add("r_tobereceiveby", "RECEIVING OWNER")
            .Columns.Add("r_total_canepoints", "TOTAL CANEPOINTS")
            .Columns.Add("r_canecost", "CANEPOINT COST")
            .Columns.Add("r_haulcost", "HAULING COST")
            .Columns.Add("r_receivablecost", "RECEIVABLE COST")
            .Columns.Add("date_requested", "REQUESTRED DATE")
            .Columns.Add("requested_name", "REQUESTRED BY")
            .Columns.Add("date_approved", "APPROVED DATE")
            .Columns.Add("approver_name", "APPROVED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("req_no").Width = 100
            .Columns("date_req").Width = 150
            .Columns("r_barrio").Width = 200
            .Columns("r_tobereceiveby").Width = 200
            .Columns("r_total_canepoints").Width = 150
            .Columns("r_canecost").Width = 150
            .Columns("r_haulcost").Width = 150
            .Columns("r_receivablecost").Width = 150
            .Columns("date_requested").Width = 150
            .Columns("requested_name").Width = 200
            .Columns("date_approved").Width = 150
            .Columns("approver_name").Width = 200

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub

    Sub canepoint_main_delivered()
        lv_delivered_canepoint.Columns.Clear()

        With lv_delivered_canepoint
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("canep_no", "CANEPOINT NO.")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("r_barrio", "RECEIVING BARRIO")
            .Columns.Add("r_tobereceiveby", "RECEIVING OWNER")
            .Columns.Add("r_total_canepoints", "TOTAL CANEPOINTS")
            .Columns.Add("s_barrio", "SOURCE BARRIO")
            .Columns.Add("s_owner", "SOURCE OWNER")
            .Columns.Add("s_lotno", "SOURCE LOT NO.")
            .Columns.Add("s_cropclass", "SOURCE CROP CLASS")
            .Columns.Add("s_cropyear", "SOURCE CROP YEAR")
            .Columns.Add("validity_date", "CANE POINT VALIDITY")
            .Columns.Add("canepoint_cost", "VANE POINT COST")
            .Columns.Add("hauling_cost", "HAULING COST")
            .Columns.Add("receiving_cost", "RECEIVABLE COST")
            .Columns.Add("hauling_driver", "HAULING DRIVER")
            .Columns.Add("hauling_truckno", "TRUCK NO.")
            .Columns.Add("hauling_date", "HAULING DATE")
            .Columns.Add("no_of_cutter", "NO. OF CUTTERS")
            .Columns.Add("total_cutter_payment", "TOTAL CUTTER PAYMENT")



            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("canep_no").Width = 100
            .Columns("date_req").Width = 100
            .Columns("r_barrio").Width = 130
            .Columns("r_tobereceiveby").Width = 150
            .Columns("r_total_canepoints").Width = 120
            .Columns("s_barrio").Width = 130
            .Columns("s_owner").Width = 150
            .Columns("s_lotno").Width = 100
            .Columns("s_cropclass").Width = 120
            .Columns("s_cropyear").Width = 120
            .Columns("validity_date").Width = 120
            .Columns("canepoint_cost").Width = 120
            .Columns("hauling_cost").Width = 120
            .Columns("receiving_cost").Width = 120
            .Columns("hauling_driver").Width = 150
            .Columns("hauling_truckno").Width = 100
            .Columns("hauling_date").Width = 100
            .Columns("no_of_cutter").Width = 100
            .Columns("total_cutter_payment").Width = 150

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

            glomod.data_item_selected_zero(lv_request_canepoint, 0)
            slct_id_canepoint_main_request = 0
        ElseIf pv_tab.SelectedPage Is pvp_2 Then
            canepoint_main_approved()
            glomod.populate_listview_progress_status(lv_aprroved_canepoint, "p_ais_canepoint_main_datas " & user_id & ",1", 13, "Loading...",
                               " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr A INNER JOIN tbl_ais_canepoint_signatories B ON A.id=B.hdr_id  WHERE B.requested_by='" & user_id & "' AND status = 2")
            glomod.data_item_grouping(lv_aprroved_canepoint, "date_req")

            'glomod.data_item_selected_zero(lv_aprroved_canepoint, 1)
            'slct_id_canepoint_main_request = 0
        Else
            canepoint_main_delivered()
            glomod.populate_listview_progress_status(lv_delivered_canepoint, "p_ais_canepoint_main_datas '',4", 20, "Loading...",
                             " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr WHERE status =3")
            glomod.data_item_grouping(lv_delivered_canepoint, "date_req")

            'glomod.data_item_selected_zero(lv_delivered_canepoint, 1)
            'slct_id_canepoint_main_request = 0

        End If
    End Sub

    Private Sub lv_request_canepoint_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_request_canepoint.CellFormatting _
        , lv_aprroved_canepoint.CellFormatting, lv_delivered_canepoint.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_request_canepoint_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_request_canepoint.VisualItemFormatting _
        , lv_aprroved_canepoint.VisualItemFormatting, lv_delivered_canepoint.VisualItemFormatting
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
            RadMessageBox.Show("Select an item to proceed.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
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
            RadMessageBox.Show("Select an item to proceed.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If

    End Sub

    Private Sub conmenu_reviewrequest_Click(sender As Object, e As EventArgs) Handles conmenu_reviewrequest.Click
        Frm_main.Enabled = False
        Frm_canepoint_request_review.Show()
    End Sub

    Private Sub lv_aprroved_canepoint_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_aprroved_canepoint.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_canepoint_approved.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub review_Click(sender As Object, e As EventArgs) Handles review.Click
        If slct_id_canepoint_mainapproved <> 0 Then
            Frm_main.Enabled = False

            Frm_canepoint_aprroved_reviewandprinting.Show()
        Else
            RadMessageBox.Show("Select an item to proceed.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub lv_aprroved_canepoint_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_aprroved_canepoint.SelectedItemChanged
        slct_id_canepoint_mainapproved = glomod.selection_listview(lv_aprroved_canepoint)
    End Sub

    Private Sub encoding_Click(sender As Object, e As EventArgs) Handles encoding.Click
        Dim Frm_canepoint_approved_encoding As New Frm_canepoint_approved_encoding
        If slct_id_canepoint_mainapproved <> 0 Then
            Frm_main.Enabled = False

            If lv_aprroved_canepoint.SelectedItems.Count > 0 Then
                With lv_aprroved_canepoint.SelectedItems(0)
                    Frm_canepoint_approved_encoding.txt_canepoint_no.Text = .SubItems(2)
                End With
            End If

            Frm_canepoint_approved_encoding.Show()
        Else
            RadMessageBox.Show("Select an item to proceed.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub confirmation_Click(sender As Object, e As EventArgs) Handles confirmation.Click
        Frm_main.Enabled = False
        Frm_canepoint_approved_confirmation.Show()
    End Sub

    Private Sub refresh_approved_list_Click(sender As Object, e As EventArgs) Handles refresh_approved_list.Click
        glomod.populate_listview_progress_status(lv_aprroved_canepoint, "p_ais_canepoint_main_datas " & user_id & ",1", 13, "Loading...",
                             " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr A INNER JOIN tbl_ais_canepoint_signatories B ON A.id=B.hdr_id  WHERE B.requested_by='" & user_id & "' AND status = 2")
        glomod.data_item_grouping(lv_aprroved_canepoint, "date_req")

        glomod.data_item_selected_zero(lv_aprroved_canepoint, 1)
        slct_id_canepoint_main_request = 0
    End Sub

    Private Sub lv_delivered_canepoint_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_delivered_canepoint.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_canepoint_delivered.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
