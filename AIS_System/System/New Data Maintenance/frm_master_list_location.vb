Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class Frm_master_list_location
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub location_column()
        Me.lv_masterlocation.Columns.Clear()

        With Me.lv_masterlocation
            .Columns.Add("Id", "")
            .Columns.Add("Count_row", "Row No.")
            .Columns.Add("Count_group", "Group No.")
            .Columns.Add("old_lot_code", "OLD LOT CODE")
            .Columns.Add("new_lot_code", "NEW LOT CODE")
            .Columns.Add("loc_code", "LOCATION CODE")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("mun_code", "MUNICIPALITY CODE")
            .Columns.Add("municipality", "MUNICIPALITY")
            .Columns.Add("pl_code", "PLANTER CODE")
            .Columns.Add("pl_name", "PLANTER NAME")
            .Columns.Add("assoc", "ASSOCIATION")
            .Columns.Add("culture", "CROP CLASS")
            .Columns.Add("variety", "CANE VARIETY")
            .Columns.Add("soil", "SOIL TYPE")
            .Columns.Add("tot_area", "TOTAL AREA")
            .Columns.Add("crop_year", "CROP YEAR")

            .Columns("Id").Width = 10
            .Columns("Id").Visible = False
            .Columns("Count_row").Width = 50
            '.Columns("Count_row").Visible = False
            .Columns("Count_group").Width = 60
            .Columns("old_lot_code").Width = 100
            .Columns("new_lot_code").Width = 100
            .Columns("loc_code").Width = 90
            .Columns("location").Width = 150
            .Columns("mun_code").Width = 90
            .Columns("municipality").Width = 150
            .Columns("pl_code").Width = 90
            .Columns("pl_name").Width = 160
            .Columns("assoc").Width = 150
            .Columns("culture").Width = 110
            .Columns("variety").Width = 110
            .Columns("soil").Width = 100
            .Columns("tot_area").Width = 80
            .Columns("crop_year").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_masterlocation.EnableGrouping = True
            Me.lv_masterlocation.ShowGroups = True
        End With
    End Sub
#End Region

    Private Sub Frm_master_list_location_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
        location_column()

        Me.cp_panelmaintenance.IsExpanded = False

        ' location_masterlist_view.load_location_pager()
        'location_masterlist_view.main_loc_dropdown_desc()
        'location_masterlist_view.main_location_listview("Loading ")
        location_masterlist_view.load_crop_year()

        Me.combar_dp_sortby.SelectedIndex = 1

        'Me.combar_dp_group.SelectedIndex = 0
        'Me.pager_list.SelectedIndex = 0

    End Sub


    Private Sub pager_list_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles pager_list.SelectedIndexChanged
        If Me.pager_list.SelectedIndex = 0 Then
            top_slct = 80
            datafrom = top_slct - 79
            datato = top_slct
        Else
            top_slct = (Me.pager_list.SelectedIndex * 80) + 80
            datafrom = top_slct - 79
            datato = top_slct
        End If

        location_masterlist_view.main_location_listview("Loading ", top_slct, datafrom, datato, datagroup, (datafrom - 1), crop_y)

        Dim groupByType As New GroupDescriptor(datagroup)
        Me.lv_masterlocation.GroupDescriptors.Add(groupByType)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If command_contxt = 1 Then
            ' sysmod.Add_mainlocation(Replace(Trim(Me.txt_code.Text), "'", "`"), slct_id_locationdesc, sp_area.Value, Trim(Me.dp_soiltype.SelectedItem.ToString), Replace(Trim(Me.txt_ownername.Text), "'", "`"))
        ElseIf command_contxt = 2 Then
            'sysmod.Update_mainlocation(slct_id, slct_id_locationdesc, Replace(Trim(Me.txt_code.Text), "'", "`"), sp_area.Value, Trim(Me.dp_soiltype.SelectedItem.Text), Replace(Trim(Me.txt_ownername.Text), "'", "`"))
        Else
            RadMessageBox.Show("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            RadMessageBox.Show(sysmod.msgS, "AIS: Successful", MessageBoxButtons.OK, RadMessageIcon.Info)
            'location_masterlist_view.main_location_listview("Refreshing ")
            location_masterlist_view.main_loc_enabled()
        Else
            RadMessageBox.Show(sysmod.msgS, "AIS: ERROR...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    'Private Sub btn_location_info_Click(sender As Object, e As EventArgs) Handles btn_location_info.Click
    '    Frm_main.Enabled = False
    '    Frm_master_list_location_info.Show()
    'End Sub

    Private Sub cb_loc_desc_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs)
        location_masterlist_view.main_loc_select_dp_desc()
    End Sub


    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        'location_masterlist_view.main_location_listview("Refreshing ")
    End Sub

    'Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
    '    command_contxt = 1

    '    location_masterlist_view.main_loc_disabled()
    'End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        If slct_id = Nothing Then
            RadMessageBox.Show("No selected data")
        Else
            command_contxt = 2
            location_masterlist_view.main_loc_updatevalue()
            location_masterlist_view.main_loc_disabled()
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        sysmod.Delete_main_loc(slct_id)


        'location_masterlist_view.main_location_listview("Refreshing ")
        msgerror = Nothing
    End Sub

    Private Sub lv_masterlocation_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_masterlocation.CellFormatting
        location_masterlist_view.lv_formating(e)
    End Sub

    Private Sub lv_masterlocation_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_masterlocation.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_locationMaster.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_masterlocation_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_masterlocation.SelectedItemChanged
        location_masterlist_view.Global_loc_masterlist_selected()
    End Sub

    Private Sub combar_txt_search_TextChanged(sender As Object, e As EventArgs)
        location_masterlist_view.main_location_search(Replace(Trim(combar_txt_search.Text), "'", "`"))
    End Sub

    Private Sub btn_asc_Click(sender As Object, e As EventArgs)
        Me.lv_masterlocation.SortDescriptors.Clear()
        Me.lv_masterlocation.EnableSorting = True
        Dim sort = New SortDescriptor(sortsss, ListSortDirection.Ascending)
        Me.lv_masterlocation.SortDescriptors.Add(sort)

    End Sub

    Private Sub btn_desc_Click(sender As Object, e As EventArgs)

        Me.lv_masterlocation.SortDescriptors.Clear()
        Me.lv_masterlocation.EnableSorting = True
        Dim sort = New SortDescriptor(sortsss, ListSortDirection.Descending)
        Me.lv_masterlocation.SortDescriptors.Add(sort)
    End Sub

    Private Sub AddNewlyLotCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewlyLotCodeToolStripMenuItem.Click
        command_contxt = 1
        location_masterlist_view.main_loc_disabled()
    End Sub

    Private Sub AddNewLotCodeWithExistingCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewLotCodeWithExistingCodeToolStripMenuItem.Click
        Frm_main.Enabled = False
        Frm_masterlist_location_addexisting.Show()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        location_masterlist_view.main_loc_enabled()
    End Sub

    Private Sub combar_dp_group_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles combar_dp_group.SelectedIndexChanged

        'location_masterlist_view.load_location_pager(crop_y)


        Me.lv_masterlocation.GroupDescriptors.Clear()

        Select Case combar_dp_group.SelectedIndex
            Case 0
                gp = "location"
                datagroup = "location"
            Case 1
                gp = "municipality"
                datagroup = "municipality"
            Case 2
                gp = "pl_name"
                datagroup = "pl_name"
            Case 3
                gp = "assoc"
                datagroup = "D.description"
            Case 4
                gp = "culture"
                datagroup = "E.culture_desc"
        End Select

        Dim groupByType As New GroupDescriptor(gp)
        Me.lv_masterlocation.GroupDescriptors.Add(groupByType)

        Me.pager_list.SelectedIndex = 0
    End Sub

    Private Sub combar_dp_sortby_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles combar_dp_sortby.SelectedIndexChanged
        crop_y = Me.combar_dp_sortby.SelectedItem.ToString
        location_masterlist_view.load_location_pager(crop_y)

        Me.combar_dp_group.SelectedIndex = 0
        Me.pager_list.SelectedIndex = 0

    End Sub
End Class
