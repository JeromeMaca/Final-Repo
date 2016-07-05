Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports Telerik.WinControls.Data
Public Class Frm_master_list_work_operation
    Dim sysmod As New System_mod
    Dim glomod As New global_mod
    Dim cur_group As String

#Region "LISTVIEW COLUMN"
    Sub work_operation_column()
        Me.lv_masteriworkoperation.Columns.Clear()

        With Me.lv_masteriworkoperation
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("category", "Operation Category")
            .Columns.Add("operation", "Oeparation Description")
            .Columns.Add("unit", "Unit Measure")
            .Columns.Add("rate", "Rate Cost")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 150
            .Columns("category").Width = 150
            .Columns("operation").Width = 230
            .Columns("unit").Width = 220
            .Columns("rate").Width = 350




            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_masteriworkoperation.EnableGrouping = True
            Me.lv_masteriworkoperation.ShowGroups = True
        End With
    End Sub
#End Region

    Private Sub lv_masteriworkoperation_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_masteriworkoperation.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_workoperation.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub Frm_master_list_work_operation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        work_operation_column()
        Me.combar_dp_group.SelectedIndex = 0

        'progrss_max = operation_masterlist_view.progress_status()


        operation_masterlist_view.work_operation_listview("Loading ")
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        command_contxt = 1

        operation_masterlist_view.main_workoperation_disabled()
        operation_masterlist_view.dp_owner_load()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        operation_masterlist_view.main_workoperation_enabled()
        operation_masterlist_view.operation_clear_field()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click

        operation_masterlist_view.work_operation_listview("Refreshing ")
    End Sub

    Private Sub modify_Click(sender As Object, e As EventArgs) Handles modify.Click
        If slct_id = Nothing Then
            RadMessageBox.Show("No selected data")
        Else
            operation_masterlist_view.dp_owner_load()
            command_contxt = 2
            operation_masterlist_view.main_work_operation_updatevalue()
            operation_masterlist_view.main_workoperation_disabled()
        End If
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        sysmod.Delete_workoperationmasterlist(slct_id)
        operation_masterlist_view.work_operation_listview("Refreshing ")
        msgerror = Nothing
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If command_contxt = 1 Then
            sysmod.Add_workooperationmasterlist(dp_cat_slct_id, Replace(Trim(Me.txt_workoperation.Text), "'", "`"), Replace(Trim(Me.txt_unitmeasure.Text), "'", "`"), Trim(Me.txt_ratecost.Value))
        ElseIf command_contxt = 2 Then
            sysmod.Update_workoperationmasterlist(dp_cat_slct_id, Replace(Trim(Me.txt_workoperation.Text), "'", "`"), Replace(Trim(Me.txt_unitmeasure.Text), "'", "`"), Trim(Me.txt_ratecost.Value), slct_id)
        Else
            RadMessageBox.Show("No command... need administrator assistant")
            Exit Sub
        End If

        If sysmod.msgb <> 1 Then
            RadMessageBox.Show(sysmod.msgS, "AIS: Successful", MessageBoxButtons.OK, RadMessageIcon.Info)
            operation_masterlist_view.main_workoperation_enabled()
            operation_masterlist_view.operation_clear_field()
            operation_masterlist_view.work_operation_listview("Refreshing ")
        Else
            RadMessageBox.Show(sysmod.msgS, "AIS: ERROR...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub lv_masteriworkoperation_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_masteriworkoperation.CellFormatting
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (e.CellElement).Data.Name = "Count" Then
            If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If

            If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
                e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
            End If
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub combar_dp_group_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles combar_dp_group.SelectedIndexChanged
        Me.lv_masteriworkoperation.GroupDescriptors.Clear()
        Select Case Me.combar_dp_group.SelectedIndex
            Case 0
                cur_group = "category "
        End Select

        Dim groupByType As New GroupDescriptor(cur_group)
        Me.lv_masteriworkoperation.GroupDescriptors.Add(groupByType)
    End Sub

    Private Sub dp_operationcategory_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_operationcategory.SelectedIndexChanged
        operation_masterlist_view.main_category_select_dp_owner()
    End Sub
    Private Sub txt_ratecost_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_ratecost.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Me.btn_save.Focus()
        End Select
    End Sub

    Private Sub lv_masteriworkoperation_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_masteriworkoperation.SelectedItemChanged
        operation_masterlist_view.Global_work_operation_masterlist_selected()
    End Sub

    Private Sub lv_masteriworkoperation_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_masteriworkoperation.VisualItemFormatting
        glomod.group_count(e)
    End Sub
End Class
