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

    Private Sub lv_for_approval_list_ItemMouseDoubleClick(sender As Object, e As UI.ListViewItemEventArgs) Handles lv_for_approval_list.ItemMouseDoubleClick
        slct_id_canepoint_for_approval = glomod.selection_listview(lv_for_approval_list)

        If slct_id_canepoint_for_approval <> 0 Then
            dp_location.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT location FROM jcso.dbo.tbl_com_locations_ml ORDER BY location ASC", "location")
            dp_location.DisplayMember = "location"
            dp_location.Text = ""
        End If
    End Sub

    Private Sub dp_location_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_location.SelectedIndexChanged
        slct_id_location_for_approval = selection_dropdown("SELECT TOP 1 lo_id FROM jcso.dbo.tbl_com_locations_ml WHERE location='" & dp_location.Text & "'")

        If slct_id_location_for_approval <> 0 Or slct_id_location_for_approval <> Nothing Then
            dp_lot_no.DataSource = glomod.populate_dropdown_using_datatable("SELECT new_lot_code FROM jcso.dbo.tbl_prd_estimates" _
                                                                            & " WHERE loc_id='" & slct_id_location_for_approval & "' GROUP BY new_lot_code ORDER BY LEN(new_lot_code) ASC", "locations")
            dp_lot_no.DisplayMember = "new_lot_code"
            dp_lot_no.Text = ""
        End If
    End Sub

    Private Sub dp_lot_no_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_lot_no.SelectedIndexChanged
        slct_id_lotno_for_approval = glomod.selection_dropdown("SELECT id FROM jcso.dbo.tbl_prd_estimates" _
                                                                            & " WHERE loc_id='" & slct_id_location_for_approval & "' GROUP BY new_lot_code ORDER BY LEN(new_lot_code) ASC")
    End Sub

    Private Function selection_dropdown(query As String)
        Dim has_id As Integer
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                has_id = sysmod.dr.Item("lo_id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return has_id
    End Function


End Class
