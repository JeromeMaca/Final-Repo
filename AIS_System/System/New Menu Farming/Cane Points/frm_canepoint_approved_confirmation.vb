Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

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
            .Columns("count").Width = 40
            .Columns("canepoint_no").Width = 140
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

#Region "RETREIVING CANEPOINT INFO"
    Sub retreive_info(query)
        sysmod.strQuery = query
        sysmod.useDB(sysmod.strQuery)
        sysmod.dr = sysmod.sqlCmd.ExecuteReader

        If sysmod.dr.HasRows Then
            'Dim Frm_canepoint_approved_confirmation As New Frm_canepoint_approved_confirmation
            While (sysmod.dr.Read())
                txt_canepoint_no.Text = sysmod.dr.Item("canepoint_no").ToString
                txt_dateneeded.Text = sysmod.dr.Item("date_needed").ToString
                txt_receiving_barrio.Text = sysmod.dr.Item("receiving_barrio").ToString
                txt_receiving_owner.Text = sysmod.dr.Item("receiving_owner").ToString
                txt_total_canepoint_need.Text = sysmod.dr.Item("total_canepoint").ToString
                txt_source_barrio.Text = sysmod.dr.Item("source_bario").ToString
                txt_source_owner.Text = sysmod.dr.Item("source_owner").ToString
                txt_source_lotno.Text = sysmod.dr.Item("lot_no").ToString
                txt_source_crop_class.Text = sysmod.dr.Item("crop_class").ToString
                txt_validity_date.Text = sysmod.dr.Item("validity_date").ToString
                txt_hauling_date.Text = sysmod.dr.Item("hauling_date").ToString
                txt_hauling_driver.Text = sysmod.dr.Item("hauling_driver").ToString
                txt_hauling_truck_no.Text = sysmod.dr.Item("hauling_truckno").ToString
                txt_canepoint_rate.Text = sysmod.dr.Item("canepoint_cost").ToString
                txt_hauling_rate.Text = sysmod.dr.Item("hauling_cost").ToString
                txt_total_receving.Text = sysmod.dr.Item("receiving_cost").ToString
            End While
        End If
    End Sub
#End Region

#Region "OTHER SPECIAL COMMAND"
    Sub add_update_data(query As String)
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.sqlCmd.ExecuteNonQuery()
            sysmod.dbConn.Close()

        Catch ex As Exception
            If ex.Message <> Nothing Then
                sysmod.msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
    End Sub
#End Region

    Sub Ctrlclearfield()
        'For Each ctrl As Control In RadDock1.Controls
        '    For Each a As Control In ctrl.Controls
        '        If TypeOf (a) Is DocumentTabStrip Then
        For Each B As Control In Me.Controls
            If TypeOf (B) Is RadGroupBox Then
                For Each C As Control In B.Controls
                    C.Text = ""
                Next

                For Each C As Control In B.Controls
                    If TypeOf (C) Is RadListView Then
                        Dim lv As RadListView = C
                        lv.Items.Clear()
                    End If
                Next
            End If
        Next
        '        End If
        '    Next
        'Next
    End Sub
    Private Sub Frm_canepoint_approved_confirmation_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_canepoint_approved_confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_column_for_confirmation()
        lv_column_cutter_name()

        glomod.populate_listview(lv_for_confirmation, "p_ais_canepoint_main_datas 0,2", 3)
        'GROUPINGS
        'glomod.data_item_grouping(lv_for_confirmation, "date_needed")
        ''GROUP EXPANTION
        'glomod.group_expantion(lv_for_confirmation.Groups.Count, lv_for_confirmation)
    End Sub

    Private Sub lv_for_confirmation_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_for_confirmation.CellFormatting, lv_cuttersname.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_for_confirmation_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_cuttersname.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub lv_for_confirmation_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_for_confirmation.SelectedItemChanged
        'ID SELECTION
        slct_id_confirmation = glomod.selection_listview(lv_for_confirmation)

        'LOAD CUTTERS NAME
        glomod.populate_listview(lv_cuttersname, " SELECT ROW_NUMBER() OVER (ORDER BY cutter_name ASC) #,id,cutter_name,ISNULL(replace(convert(nvarchar,convert(Money, no_of_canepoints),1),'.00',''),'-----')  as no_of_canepoints,cutting_cost,payables_to_cutter" _
                                                            & " FROM tbl_ais_canepoint_cutter_detail WHERE hdr_id='" & slct_id_confirmation & "' AND status_q=0 AND status=1 ORDER BY cutter_name ASC", 5)


        retreive_info("p_ais_canepoint_main_datas '" & slct_id_confirmation & "',3")

        slct_id_confirmation = 0
    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        If btn_check.Text = "Check All Item" Then
            btn_check.Text = "Uncheck All Item"

            Dim lvitems As ListViewDataItem = Nothing

            For Each lvitems In lv_for_confirmation.Items
                lvitems.CheckState = CheckState.Checked
            Next
        Else
            btn_check.Text = "Check All Item"

            Dim lvitems As ListViewDataItem = Nothing

            For Each lvitems In lv_for_confirmation.Items
                lvitems.CheckState = CheckState.Unchecked
            Next
        End If
    End Sub

    Private Sub btn_save_all_Click(sender As Object, e As EventArgs) Handles btn_save_all.Click
        If lv_for_confirmation.CheckedItems.Count > 0 Then
            If RadMessageBox.Show("Are you sure you want to change the status of all the check item into Delivered Cane Points?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim lvitem As ListViewDataItem = Nothing
                Dim i As Integer = 0

                While i < lv_for_confirmation.CheckedItems.Count
                    With lv_for_confirmation.CheckedItems(i)
                        If lv_for_confirmation.CheckedItems.Count > 0 Then
                            If lv_for_confirmation.CheckedItems(i).CheckState = CheckState.Checked Then
                                add_update_data("p_ais_canepoint_main_approved_confirmation " & .SubItems(0).ToString & ",'" & user_id & "'")
                            End If
                        End If
                    End With
                    i += 1
                End While

                If sysmod.msgb = 1 Then
                    RadMessageBox.Show(global_error_catcher, "ERROR...Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
                Else
                    RadMessageBox.Show("Successfully performed the operation without errors.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Ctrlclearfield()
                End If

                For Each lvitem In lv_for_confirmation.Items
                    lvitem.CheckState = CheckState.Unchecked
                Next

                glomod.populate_listview(lv_for_confirmation, "p_ais_canepoint_main_datas 0,2", 3)
                'GROUPINGS
                glomod.data_item_grouping(lv_for_confirmation, "date_needed")
                'GROUP EXPANTION
                glomod.group_expantion(lv_for_confirmation.Groups.Count, lv_for_confirmation)
            End If
        Else
            RadMessageBox.Show("Please Check an item to be process.", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_save_all_MouseHover(sender As Object, e As EventArgs) Handles btn_save_all.MouseHover, btn_check.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_save_all_MouseLeave(sender As Object, e As EventArgs) Handles btn_save_all.MouseLeave, btn_check.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub
End Class
