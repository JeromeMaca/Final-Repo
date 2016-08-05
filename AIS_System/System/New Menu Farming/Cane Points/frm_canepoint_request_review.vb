Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_request_review

    Dim glomod As New global_mod
    Dim sysmod As New System_mod

#Region "CANEPOINT LISTVIEW COLUMN"
    Sub canepoint_main_request()
        lv_for_approval_list.Columns.Clear()

        With lv_for_approval_list
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("req_no", "REQUEST NO.")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("r_barrio", "RECEIVING BARRIO")
            .Columns.Add("r_tobereceiveby", "RECEIVING OWNER")
            .Columns.Add("r_total_canepoints", "TOTAL CANEPOINTS")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("req_no").Width = 100
            .Columns("date_req").Width = 150
            .Columns("r_barrio").Width = 200
            .Columns("r_tobereceiveby").Width = 230
            .Columns("r_total_canepoints").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region
    Private Sub Frm_canepoint_request_review_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_canepoint_request_review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        dt_dateneeded.Value = server_datetime

        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False


        canepoint_main_request()
        glomod.populate_listview(lv_for_approval_list, "p_ais_canepoint_main_datas " & user_id & ",0", 6)
        glomod.data_item_grouping(lv_for_approval_list, "date_req")

        glomod.data_item_selected_zero(lv_for_approval_list, 1)
        slct_id_canepoint_main_request = 0
    End Sub
    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub

    Private Sub lv_for_approval_list_CellFormatting(sender As Object, e As UI.ListViewCellFormattingEventArgs) Handles lv_for_approval_list.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_for_approval_list_VisualItemFormatting(sender As Object, e As UI.ListViewVisualItemEventArgs) Handles lv_for_approval_list.VisualItemFormatting
        glomod.group_count(e)
    End Sub
End Class
