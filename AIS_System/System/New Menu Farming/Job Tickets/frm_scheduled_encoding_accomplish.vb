﻿Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_scheduled_encoding_accomplish
    Dim glomod As New global_mod

#Region "LISTVIEW COLUMN"
    Sub s_lot_column()
        With lv_lots
            .Columns.Clear()

            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("lot_no", "LOT NUMBER")
            .Columns.Add("operation", "OPERATION PERFORMED")
            .Columns.Add("curr_area", "CURRENT AREA")
            .Columns.Add("actual_area", "ACTUAL AREA")
            .Columns.Add("undone_area", "UNFINISH AREA")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("lot_no").Width = 200
            .Columns("operation").Width = 270
            .Columns("curr_area").Width = 100
            .Columns("actual_area").Width = 100
            .Columns("undone_area").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub

    Sub s_manpower_column()
        With lv_manpowers
            .Columns.Clear()

            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("name", "FULLNAME")
            .Columns.Add("RT", "Hours Work RT")
            .Columns.Add("OT", "Hours Work OT")
            .Columns.Add("NT", "Hours Work NT")
            .Columns.Add("rate", "CHANGER RATE")
            .Columns.Add("ope_performed", "OPERATION PERFORMED")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("name").Width = 250
            .Columns("RT").Width = 90
            .Columns("OT").Width = 90
            .Columns("NT").Width = 90
            .Columns("rate").Width = 120
            .Columns("ope_performed").Width = 250

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_scheduled_encoding_accomplish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False


        s_lot_column() : s_manpower_column()
        glomod.populate_listview(lv_lots, "p_ais_job_ticket_encoding_retrieve '" & jt_slct_scheduled_id & "',1", 6)
        glomod.populate_listview(lv_manpowers, "p_ais_job_ticket_encoding_retrieve '" & jt_slct_scheduled_id & "',2", 7)
    End Sub

    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub
    Private Sub Frm_scheduled_encoding_accomplish_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub lv_lots_CellFormatting(sender As Object, e As UI.ListViewCellFormattingEventArgs) _
        Handles lv_lots.CellFormatting, lv_manpowers.CellFormatting

        glomod.lv_formats(e)
    End Sub

    Private Sub select_all_Click(sender As Object, e As EventArgs) Handles select_all.Click
        Dim lvitem As ListViewDataItem = Nothing
        For Each lvitem In lv_manpowers.Items
            lvitem.CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub deselect_all_Click(sender As Object, e As EventArgs) Handles deselect_all.Click
        Dim lvitem As ListViewDataItem = Nothing
        For Each lvitem In lv_manpowers.Items
            lvitem.CheckState = CheckState.Unchecked
        Next
    End Sub

    Private Sub lv_manpowers_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_manpowers.MouseDown
        cms_done = 2
        If e.Button = MouseButtons.Right Then
            cms_manpower.Show(Me, Me.PointToClient(MousePosition))
        End If

        select_all.Enabled = True
        deselect_all.Enabled = True
        seperator.Enabled = True
    End Sub
    Private Sub lv_lots_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_lots.MouseDown
        cms_done = 1
        If e.Button = MouseButtons.Right Then
            cms_manpower.Show(Me, Me.PointToClient(MousePosition))
        End If

        select_all.Enabled = False
        deselect_all.Enabled = False
        seperator.Enabled = False
    End Sub
    Private Sub done_selecting_Click(sender As Object, e As EventArgs) Handles done_selecting.Click
        If cms_done = 1 Then
            If lv_lots.SelectedItems.Count > 0 Then
                With lv_lots.SelectedItems(0)
                    txt_lotno.Text = .SubItems(2)
                    txt_operation.Text = .SubItems(3)
                    se_current_area.Value = .SubItems(4)
                    se_actual_area.Value = .SubItems(5)
                    se_remaining_area.Value = .SubItems(6)
                End With

                job_ticket_view.disabled_job_ticket_lots()
            Else
                txt_lotno.Text = ""
                txt_operation.Text = ""
                se_current_area.Value = 0.000
                se_actual_area.Value = 0.000
                se_remaining_area.Value = 0.000
            End If
        ElseIf cms_done = 2 Then
            txt_manpower_name.Text = ""
            Dim lvitem As ListViewDataItem = Nothing
            Dim i As Integer = 0

            While i < lv_manpowers.CheckedItems.Count
                With lv_manpowers.CheckedItems(i)
                    If lv_manpowers.CheckedItems.Count > 0 Then
                        If lv_manpowers.CheckedItems(i).CheckState = CheckState.Checked Then
                            If i <> 0 Then
                                txt_manpower_name.Text = txt_manpower_name.Text & ", " & .SubItems(2).ToString
                            Else
                                txt_manpower_name.Text = .SubItems(2).ToString
                            End If
                        End If
                    End If
                End With
                i += 1
            End While

            job_ticket_view.disabled_job_ticket_manpower()
        End If
    End Sub

    Private Sub btn_save_lots_Click(sender As Object, e As EventArgs) Handles btn_save_lots.Click
        job_ticket_view.enabled_job_ticket_lots()
        job_ticket_view.clear_field_job_ticket_lots()
    End Sub

    Private Sub btn_cancel_lots_Click(sender As Object, e As EventArgs) Handles btn_cancel_lots.Click
        job_ticket_view.enabled_job_ticket_lots()
        job_ticket_view.clear_field_job_ticket_lots()
    End Sub

    Private Sub btn_save_manpower_Click(sender As Object, e As EventArgs) Handles btn_save_manpower.Click
        job_ticket_view.enabled_job_ticket_manpower()
        job_ticket_view.clear_field_job_ticket_manpower()
    End Sub

    Private Sub btn_cancel_manpower_Click(sender As Object, e As EventArgs) Handles btn_cancel_manpower.Click
        job_ticket_view.enabled_job_ticket_manpower()
        job_ticket_view.clear_field_job_ticket_manpower()
    End Sub
End Class