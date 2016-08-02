﻿Imports System.Data.SqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_request
    Dim glomod As New global_mod
    Dim sysmod As New System_mod
    Dim tables As DataTable

#Region "LISTVIEW COLUMN"
    Sub create_data_canepoint_request()
        lv_created_canepoint_request.Columns.Clear()

        With lv_created_canepoint_request
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("r_barrio", "RECEIVING BARRIO")
            .Columns.Add("r_tobereceiveby", "RECEIVING OWNER")
            .Columns.Add("r_total_canepoints", "TOTAL CANEPOINTS")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 120
            .Columns("r_barrio").Width = 150
            .Columns("r_tobereceiveby").Width = 170
            .Columns("r_total_canepoints").Width = 130

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region
    Private Sub Frm_canepoint_request_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_canepoint_request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        dt_dateneeded.Value = server_datetime

        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False

        create_data_canepoint_request()
        dp_location.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT location FROM jcso.dbo.tbl_com_locations_ml ORDER BY location ASC", "location")
        dp_location.DisplayMember = "location"
        dp_location.Text = ""
        dp_receiving_owner.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT pl_name FROM jcso.dbo.tbl_com_planters_ml ORDER BY pl_name ASC", "pl_names")
        dp_receiving_owner.DisplayMember = "pl_name"
        dp_receiving_owner.Text = ""


        'glomod.populate_listview(lv_created_canepoint_request, "", 5)

        glomod.populate_listview_using_datatable(lv_created_canepoint_request, "p_ais_canepoint_request_data " & user_id & ",0", 5, "canepoint_adding")
    End Sub

    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub

    Private Sub btn_addqueued_Click(sender As Object, e As EventArgs) Handles btn_addqueued.Click
        glomod.add_update_data("p_ais_canepoints_add_request '" & dt_dateneeded.Value & "','" & dp_location.Text & "','" & dp_receiving_owner.Text & "'" _
                        & "," & se_total_canepoints.Value & "," & user_id & ",0")
        glomod.populate_listview_using_datatable(lv_created_canepoint_request, "p_ais_canepoint_request_data " & user_id & ",0", 5, "canepoint_adding")
    End Sub

    Private Sub lv_created_canepoint_request_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_created_canepoint_request.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_created_canepoint_request_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_created_canepoint_request.SelectedItemChanged
        slct_id_canepoint_add_request = glomod.selection_listview(lv_created_canepoint_request)
    End Sub

    Private Sub btn_deletequeued_Click(sender As Object, e As EventArgs) Handles btn_deletequeued.Click
        glomod.delete_data("p_ais_canepoint_delete_queued_data " & slct_id_canepoint_add_request & "")
        glomod.populate_listview_using_datatable(lv_created_canepoint_request, "p_ais_canepoint_request_data " & user_id & ",0", 5, "canepoint_adding")
    End Sub
End Class
