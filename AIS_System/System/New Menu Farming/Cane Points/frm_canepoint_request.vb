﻿Imports System.Data.SqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_request
    Dim glomod As New global_mod
    Dim sysmod As New System_mod
    Dim tables As DataTable

    Dim resultvalidation As Integer = 0

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

#Region "OTHER FUNCTIONS"
    Private Sub clearcontrol()
        For Each ctrl As Control In Me.Controls
            For Each c As Control In ctrl.Controls
                If TypeOf (c) Is ToolWindow Then
                    For Each b As Control In c.Controls
                        If TypeOf (b) Is RadDropDownList Then
                            Dim a As RadDropDownList = b
                            a.Text = ""
                            a.NullText = "<Required>"
                        End If

                        If TypeOf (b) Is RadSpinEditor Then
                            Dim a As RadSpinEditor = b
                            a.Value = 0
                        End If

                        If TypeOf (b) Is RadDateTimePicker Then
                            Dim a As RadDateTimePicker = b
                            a.Value = server_datetime
                        End If
                    Next
                End If
            Next
        Next

        resultvalidation = 0
    End Sub
    Private Sub validationcontrol()
        Dim i As Integer = 0
        Dim f As Integer = 0
        Dim g As Integer = 0
        For Each ctrl As Control In Me.Controls
            For Each c As Control In ctrl.Controls
                If TypeOf (c) Is RadGroupBox Then
                    For Each b As Control In c.Controls
                        If TypeOf (b) Is RadSpinEditor Then
                            Dim s As RadSpinEditor = b

                            If s.Value = 0 Then
                                'RadMessageBox.Show("Invalid Value for Canepoints Count", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                            Else
                                g += 1
                            End If
                        End If


                        If TypeOf (b) Is RadDropDownList Then
                            Dim a As RadDropDownList = b

                            If a.Text = "" Or a.Text = "Null" Then
                                a.NullText = "REQUIRED DATA HERE!!!"
                                i += 1
                            Else
                                If (f > 0 And i = 0 And g <> 0) Then
                                    resultvalidation = 1
                                End If
                            End If
                            f += 1
                        End If
                    Next
                End If
            Next
        Next
    End Sub
#End Region

    Private Sub Frm_canepoint_request_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        glomod.populate_listview(Frm_canepointreceipt_NEW.lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8)
        glomod.data_item_grouping(Frm_canepointreceipt_NEW.lv_request_canepoint, "date_req")

        glomod.data_item_selected_zero(Frm_canepointreceipt_NEW.lv_request_canepoint, 1)
        slct_id_canepoint_main_request = 0

        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_canepoint_request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        dt_dateneeded.Value = server_datetime

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

    Private Sub btn_addqueued_Click(sender As Object, e As EventArgs) Handles btn_addqueued.Click
        validationcontrol()

        If resultvalidation = 1 Then
            If (RadMessageBox.Show("Are you sure you want to take this action.", "Warning", MessageBoxButtons.YesNo, RadMessageIcon.Info)) = Windows.Forms.DialogResult.Yes Then
                glomod.add_update_data("p_ais_canepoints_add_request '" & dt_dateneeded.Value & "','" & dp_location.Text & "','" & dp_receiving_owner.Text & "'" _
                                                 & "," & se_total_canepoints.Value & "," & user_id & ",0")
                glomod.populate_listview_using_datatable(lv_created_canepoint_request, "p_ais_canepoint_request_data " & user_id & ",0", 5, "canepoint_adding")
                clearcontrol()
            End If
        Else
            If se_total_canepoints.Value <= 500 Or dp_location.Text = "" Or dp_receiving_owner.Text = "" Then
                RadMessageBox.Show("Some information field need to be fill in to proceed. or Canepoint Count value is not Valid.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        End If
        slct_id_canepoint_add_request = Nothing
    End Sub

    Private Sub lv_created_canepoint_request_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_created_canepoint_request.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_created_canepoint_request_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_created_canepoint_request.SelectedItemChanged
        slct_id_canepoint_add_request = glomod.selection_listview(lv_created_canepoint_request)
    End Sub

    Private Sub btn_deletequeued_Click(sender As Object, e As EventArgs)
        If slct_id_canepoint_add_request = Nothing Or slct_id_canepoint_add_request = 0 Then
            RadMessageBox.Show("Select an data item to proceed.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        glomod.delete_data("p_ais_canepoint_delete_queued_data " & slct_id_canepoint_add_request & "")
        glomod.populate_listview_using_datatable(lv_created_canepoint_request, "p_ais_canepoint_request_data " & user_id & ",0", 5, "canepoint_adding")
        slct_id_canepoint_add_request = Nothing
    End Sub

    Private Sub btn_saveall_Click(sender As Object, e As EventArgs) Handles btn_saveall.Click
        If lv_created_canepoint_request.Items.Count <= 0 Then
            RadMessageBox.Show("There's no queued data for processing.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If (glomod.confirmation_msg) = Windows.Forms.DialogResult.Yes Then
            glomod.add_update_data("p_ais_canepoints_add_request '','','',0,'" & user_id & "',1")
            glomod.populate_listview_using_datatable(lv_created_canepoint_request, "p_ais_canepoint_request_data " & user_id & ",0", 5, "canepoint_adding")
            slct_id_canepoint_add_request = Nothing
        End If

    End Sub

    Private Sub btn_deletequeued_MouseHover(sender As Object, e As EventArgs) Handles btn_saveall.MouseHover, btn_deletequeued.MouseHover, btn_addqueued.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_deletequeued_MouseLeave(sender As Object, e As EventArgs) Handles btn_saveall.MouseLeave, btn_deletequeued.MouseLeave, btn_addqueued.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub
End Class
