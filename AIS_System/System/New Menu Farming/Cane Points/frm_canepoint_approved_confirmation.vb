Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class Frm_canepoint_approved_confirmation
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMNS"
    Sub lv_column_for_confirmation()
        lv_for_confirmation.Items.Clear()

        With lv_for_confirmation
            .Columns.Add("id", "ID")
            .Columns.Add("count", "#")
            .Columns.Add("canepoint_no", "CANE POINT NO.")
            .Columns.Add("date_needed", "CANE POINT DATE NEEDED")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 50
            .Columns("canepoint_no").Width = 150
            .Columns("date_needed").Width = 150

            .FullRowSelect = True
            .EnableGrouping = True
            .ShowGroups = True
            .MultiSelect = True
        End With
    End Sub
    Sub lv_column_cutter_name()
        lv_cuttersname.Columns.Clear()

        With lv_cuttersname
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("cutter_name", "CUTTER NAME")
            .Columns.Add("no_canepoint", "No. of CANE POINT")
            .Columns.Add("cutting_rate", "CUTTING RATE")
            .Columns.Add("cutter_cost", "CUTTER COST")
            '.Columns.Add("status", "STATUS")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 50
            .Columns("cutter_name").Width = 250
            .Columns("no_canepoint").Width = 150
            .Columns("cutting_rate").Width = 120
            .Columns("cutter_cost").Width = 120
            '.Columns("status").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region

    Private Sub Frm_canepoint_approved_confirmation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_canepoint_approved_confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_column_for_confirmation()
        lv_column_cutter_name()

        glomod.populate_listview(lv_for_confirmation, "p_ais_canepoint_main_datas 0,2", 3)
        'GROUPINGS
        glomod.data_item_grouping(lv_for_confirmation, "date_needed")
        'GROUP EXPANTION
        glomod.group_expantion(lv_for_confirmation.Groups.Count, lv_for_confirmation)
    End Sub

    Private Sub lv_for_confirmation_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_for_confirmation.CellFormatting,
            lv_cuttersname.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_for_confirmation_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_for_confirmation.VisualItemFormatting,
            lv_cuttersname.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub lv_for_confirmation_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_for_confirmation.SelectedItemChanged
        'ID SELECTION
        slct_id_confirmation = glomod.selection_listview(lv_for_confirmation)

        'LOAD CUTTERS NAME
        glomod.populate_listview(lv_cuttersname, " SELECT ROW_NUMBER() OVER (ORDER BY cutter_name ASC) #,id,cutter_name,ISNULL(replace(convert(nvarchar,convert(Money, no_of_canepoints),1),'.00',''),'-----')  as no_of_canepoints,cutting_cost,payables_to_cutter" _
                                                            & " FROM tbl_ais_canepoint_cutter_detail WHERE hdr_id='" & slct_id_confirmation & "' AND status_q=0 AND status=1 ORDER BY cutter_name ASC", 5)
        slct_id_confirmation = 0
    End Sub
End Class
