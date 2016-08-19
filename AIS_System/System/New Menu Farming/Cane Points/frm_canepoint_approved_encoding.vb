Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_approved_encoding
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Dim validation_result As Integer = 0
    Dim validation_result2 As Integer = 0
    Dim delivered_stats As Integer = 0

#Region "Other Options"
    Sub Ctrldisabled()
        For Each ctrl As RadControl In Me.Controls
            If TypeOf (ctrl) Is RadGroupBox Then
                If ctrl.Name = "RadGroupBox1" Then
                    For Each e As Control In ctrl.Controls
                        e.Enabled = False
                    Next
                End If

                If ctrl.Name = "RadGroupBox2" Then
                    For Each e As Control In ctrl.Controls
                        e.Enabled = True
                    Next
                End If
            End If
        Next
    End Sub
    Sub Ctrlenabled()
        For Each ctrl As RadControl In Me.Controls
            If TypeOf (ctrl) Is RadGroupBox Then
                If ctrl.Name = "RadGroupBox1" Then
                    For Each e As Control In ctrl.Controls
                        e.Enabled = True
                    Next
                End If

                If ctrl.Name = "RadGroupBox2" Then
                    For Each e As Control In ctrl.Controls
                        e.Enabled = False
                    Next
                End If
            End If
        Next
    End Sub

    Sub Ctrlvalidation()
        For Each ctrl As RadControl In Me.Controls
            If TypeOf (ctrl) Is RadGroupBox Then
                If ctrl.Name = "RadGroupBox1" Then
                    For Each e As Control In ctrl.Controls
                        If TypeOf (e) Is RadTextBox Then
                            Dim con_type As RadTextBox = e

                            If con_type.Text = "" Then
                                validation_result = 1
                                'con_type.NullText = "<Required Data>"
                            Else
                                validation_result = 0
                            End If
                        End If
                    Next
                End If
            End If
        Next
    End Sub


    Sub Ctrlvalidation2()
        For Each ctrl As RadControl In Me.Controls
            If TypeOf (ctrl) Is RadGroupBox Then
                If ctrl.Name = "RadGroupBox2" Then
                    For Each e As Control In ctrl.Controls
                        If TypeOf (e) Is RadMaskedEditBox Then
                            Dim con_type As RadMaskedEditBox = e

                            If con_type.Text = "" Or con_type.Text = "0" Then
                                validation_result2 = 1
                                'con_type.NullText = "<Required Data>"
                            Else
                                validation_result2 = 0
                            End If
                        End If

                        If TypeOf (e) Is RadDropDownList Then
                            Dim con_type As RadDropDownList = e

                            If con_type.Text = "" Then
                                validation_result2 = 1
                                'con_type.NullText = "<Required Data>"
                            Else
                                validation_result2 = 0
                            End If
                        End If
                    Next
                End If
            End If
        Next
    End Sub
#End Region

#Region "LISTVIEW COLUMN"
    Sub lv_columns()
        lv_cuttername_list.Columns.Clear()

        With lv_cuttername_list
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("cutter_name", "CUTTER NAME")
            .Columns.Add("no_canepoint", "No. of CANE POINT")
            .Columns.Add("cutting_rate", "CUTTING RATE")
            .Columns.Add("cutter_cost", "CUTTER COST")
            '.Columns.Add("status", "STATUS")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("cutter_name").Width = 200
            .Columns("no_canepoint").Width = 110
            .Columns("cutting_rate").Width = 80
            .Columns("cutter_cost").Width = 80
            '.Columns("status").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region

    Sub multi_process(use_no)
        Select Case use_no
            Case 1
                dp_cutter_name.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT cutter_name FROM tbl_ais_canepoint_cutter_detail ORDER BY cutter_name ASC", "cutter_name")
                dp_cutter_name.DisplayMember = "cutter_name"
                dp_cutter_name.Text = ""
            Case 2
                glomod.populate_listview(lv_cuttername_list, " SELECT ROW_NUMBER() OVER (ORDER BY cutter_name ASC) #,id,cutter_name,no_of_canepoints,cutting_cost,payables_to_cutter" _
                                                            & " FROM tbl_ais_canepoint_cutter_detail WHERE hdr_id='" & slct_id_canepoint_mainapproved & "' AND status_q=1 AND status=0 ORDER BY cutter_name ASC", 5)
                slct_id_cuttername = 0
        End Select
    End Sub
    Private Sub Frm_canepoint_approved_encoding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_columns()
    End Sub
    Private Sub Frm_canepoint_approved_encoding_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub btn_setup_Click(sender As Object, e As EventArgs) Handles btn_setup.Click
        If delivered_stats = 1 Then
            Ctrlvalidation()
            If validation_result <> 1 Then
                Ctrldisabled()
                ''''LOAD LISTVIEW
                multi_process(2)
            Else
                RadMessageBox.Show("Some information need to be fillin to proceed.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Else
            Ctrldisabled()
            ''''LOAD LISTVIEW
            multi_process(2)
        End If
        ''''''''''''LOAD DROP DOWN CUTTER NAME
        multi_process(1)
    End Sub

    Private Sub btn_cuttername_Click(sender As Object, e As EventArgs) Handles btn_cuttername.Click
        Ctrlenabled()
    End Sub

    Private Sub chk_delivered_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chk_delivered.ToggleStateChanged
        If chk_delivered.CheckState = CheckState.Checked Then
            delivered_stats = 1
        Else
            delivered_stats = 0
        End If
    End Sub

    Private Sub btn_addtolist_Click(sender As Object, e As EventArgs) Handles btn_addtolist.Click
        Ctrlvalidation2()
        If validation_result2 <> 1 Then
            Dim payables_cutter As Decimal

            payables_cutter = Val(txtmask_canepoint_no.Value) * Val(txtmask_cuttingrate.Text)

            glomod.add_update_data("INSERT tbl_ais_canepoint_cutter_detail(hdr_id,cutter_name,no_of_canepoints,cutting_cost,payables_to_cutter,status,status_q)" _
                               & " VALUES('" & slct_id_canepoint_mainapproved & "','" & dp_cutter_name.Text.ToUpper & "','" & txtmask_canepoint_no.Value & "'," _
                                & "'" & txtmask_cuttingrate.Text & "','" & payables_cutter & "',0,1)")
            ''''''''''''LOAD DROP DOWN CUTTER NAME
            multi_process(1)
            ''''''''''''LOAD LISTVIEW
            multi_process(2)

            dp_cutter_name.Focus()
        Else
            RadMessageBox.Show("Some information need to be fillin to proceed.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
    End Sub

    Private Sub lv_cuttername_list_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_cuttername_list.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub lv_cuttername_list_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_cuttername_list.SelectedItemChanged
        slct_id_cuttername = glomod.selection_listview(lv_cuttername_list)
    End Sub

    Private Sub btn_delete_queued_Click(sender As Object, e As EventArgs) Handles btn_delete_queued.Click
        If slct_id_cuttername <> 0 Then
            glomod.delete_data("DELETE tbl_ais_canepoint_cutter_detail WHERE id='" & slct_id_cuttername & "'")
        Else
            RadMessageBox.Show("There's no data selected for deletion.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End If
        ''''''''''''LOAD LISTVIEW
        multi_process(2)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        ''''''''''''LOAD LISTVIEW
        multi_process(2)
    End Sub

    Private Sub btn_save_all_Click(sender As Object, e As EventArgs) Handles btn_save_all.Click
        If (glomod.confirmation_msg) = DialogResult.Yes Then
            glomod.add_update_data("p_ais_canepoint_main_approved_encoding '" & slct_id_canepoint_mainapproved & "','" & dt_delivereddate.Value & "'" _
                                   & ",'" & txt_driver_name.Text & "','" & txt_truck_no.Text & "','" & user_id & "'")
            Ctrlenabled()
            ''''''''''''LOAD LISTVIEW
            multi_process(2)
        End If
    End Sub
End Class
