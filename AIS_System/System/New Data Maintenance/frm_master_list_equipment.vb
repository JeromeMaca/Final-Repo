Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Imports Telerik.WinControls.Enumerations

Public Class Frm_master_list_equipment
    Dim sysmod As New System_mod
    Dim glomod As New global_mod
    Dim cur_group As String
    Dim grp As String
    Dim counter As Integer = 0

#Region "LISTVIEW COLUMN"
    Sub equipment_column()
        Me.lv_masterequipment.Columns.Clear()

        With Me.lv_masterequipment
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("ownername", "OWNER NAME")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_desc", "EQUIPMENT DESCRIPTION / PLATE NO.")


            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 40
            .Columns("ownername").Width = 280
            .Columns("equip_type").Width = 250
            .Columns("equip_desc").Width = 350

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_masterequipment.EnableGrouping = True
            Me.lv_masterequipment.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_master_list_equipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes

        'Farming_Operation.Server_time()
        equipment_column()
        equipment_masterlist_view.equipment_masterlist_listview("Loading ", "owner_name")
        glomod.data_item_grouping(lv_masterequipment, "ownername")
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If command_contxt = 1 Then
            sysmod.Add_equipmentmasterlist(dp_owner_slct_id, dp_type_slct_id, Replace(Trim(Me.txt_model.Text), "'", "`"))
        ElseIf command_contxt = 2 Then
            sysmod.Update_equipmentmasterlist(dp_owner_slct_id, dp_type_slct_id, Replace(Trim(Me.txt_model.Text), "'", "`"), slct_id)
        Else
            RadMessageBox.Show("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            RadMessageBox.Show(sysmod.msgS, "AIS: Successful", MessageBoxButtons.OK, RadMessageIcon.Info)
            equipment_masterlist_view.main_equipment_enabled()
            equipment_masterlist_view.equipment_masterlist_listview("Reloading ", "owner_name")
            glomod.data_item_grouping(lv_masterequipment, "ownername")

        Else
            RadMessageBox.Show(sysmod.msgS, "AIS: ERROR...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub lv_masterequipment_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_masterequipment.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_equipment.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub dp_owner_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_owner.SelectedIndexChanged
        equipment_masterlist_view.select_dp_owner_equipmain()
        equipment_masterlist_view.dp_equiptype_load()
    End Sub

    Private Sub dp_equiptype_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_equiptype.SelectedIndexChanged
        equipment_masterlist_view.select_dp_type_equipmain()
    End Sub

    'Private Sub dp_equipbrand_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs)
    '    equipment_masterlist_view.select_dp_brand_equipmain()
    'End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        equipment_masterlist_view.equipment_masterlist_listview("Reloading ", "owner_name")
        glomod.data_item_grouping(lv_masterequipment, "ownername")
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        equipment_masterlist_view.dp_owner_load()
        equipment_masterlist_view.main_equipment_disabled()

        command_contxt = 1
    End Sub

    Private Sub modify_Click(sender As Object, e As EventArgs) Handles modify.Click
        equipment_masterlist_view.dp_owner_load()

        If slct_id = Nothing Then
            RadMessageBox.Show("No selected data")
        Else
            command_contxt = 2
            equipment_masterlist_view.main_equipment_updatevalue()
            equipment_masterlist_view.main_equipment_disabled()
        End If
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        sysmod.Delete_equipmentmasterlist(slct_id)
        msgerror = Nothing
        equipment_masterlist_view.equipment_masterlist_listview("Reloading ", "owner_name")
        glomod.data_item_grouping(lv_masterequipment, "ownername")
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        equipment_masterlist_view.main_equipment_enabled()
    End Sub

    Private Sub lv_masterequipment_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_masterequipment.SelectedItemChanged
        equipment_masterlist_view.Global_main_equipment_selected()
    End Sub

    Private Sub combar_txt_search_TextChanged(sender As Object, e As EventArgs)
        ' equipment_masterlist_view.main_equipment_search(Trim(Me.combar_txt_search.Text), cur_group)
    End Sub

    Private Sub lv_masterequipment_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_masterequipment.CellFormatting
        equipment_masterlist_view.lv_formating(e)
    End Sub

    'Private Sub combar_dp_group_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs)
    '    counter += 1
    '    Me.lv_masterequipment.GroupDescriptors.Clear()
    '    Select Case Me.combar_dp_group.SelectedIndex
    '        Case 0
    '            cur_group = "owner_name"
    '            grp = "ownername "
    '        Case 1
    '            cur_group = "equipment_type"
    '            grp = "equip_type"
    '    End Select

    '    Dim groupByType As New GroupDescriptor(grp)
    '    Me.lv_masterequipment.GroupDescriptors.Add(groupByType)

    '    If counter > 1 Then
    '        equipment_masterlist_view.equipment_masterlist_listview("Reloading ", cur_group)
    '    End If
    'End Sub

    Private Sub lv_masterequipment_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_masterequipment.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub btn_cancel_MouseHover(sender As Object, e As EventArgs) Handles btn_search.MouseHover, btn_save.MouseHover, btn_cancel.MouseHover
        If sender Is btn_search Then
            glomod.btn_forecolor(btn_search, 0)
        ElseIf sender Is btn_save Then
            glomod.btn_forecolor(btn_save, 0)
        Else
            glomod.btn_forecolor(btn_cancel, 0)
        End If
    End Sub

    Private Sub btn_cancel_MouseLeave(sender As Object, e As EventArgs) Handles btn_search.MouseLeave, btn_save.MouseLeave, btn_cancel.MouseLeave
        If sender Is btn_search Then
            glomod.btn_forecolor(btn_search, 1)
        ElseIf sender Is btn_save Then
            glomod.btn_forecolor(btn_save, 1)
        Else
            glomod.btn_forecolor(btn_cancel, 1)
        End If
    End Sub
End Class
