Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_request_review

    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Dim resultvalidation As Integer = 0

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

#Region "CONTROLS"
    Sub clearfield()
        For Each ctrl As RadControl In RadDock1.Controls
            For Each c As Control In ctrl.Controls
                If TypeOf (c) Is DocumentTabStrip Then
                    For Each d As Control In c.Controls
                        If TypeOf (d) Is DocumentWindow Then
                            For Each dwc As Control In d.Controls
                                If TypeOf (dwc) Is RadDropDownList Or TypeOf (dwc) Is RadTextBoxControl Then
                                    dwc.Text = ""
                                End If

                                If TypeOf (dwc) Is RadDateTimePicker Then
                                    Dim a As RadDateTimePicker = dwc
                                    a.Value = server_datetime
                                End If

                                If TypeOf (dwc) Is RadGroupBox Then
                                    For Each e As Control In dwc.Controls
                                        If TypeOf (e) Is RadRadioButton Then
                                            Dim a As RadRadioButton = e
                                            If a.Name = "rb_deliver" Then
                                                a.IsChecked = True
                                            End If
                                        End If
                                    Next
                                End If


                                If TypeOf (dwc) Is RadMaskedEditBox Then
                                    If dwc.Name = "mask_canepoint_rate" Then
                                        dwc.Text = "0.50"
                                    ElseIf dwc.Name = "mask_hauling_rate" Then
                                        dwc.Text = "0.10"
                                    Else
                                        dwc.Text = "0.10"
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Sub enabledfield()
        For Each ctrl As RadControl In RadDock1.Controls
            For Each c As Control In ctrl.Controls
                If TypeOf (c) Is DocumentTabStrip Then
                    For Each d As Control In c.Controls
                        If TypeOf (d) Is DocumentWindow Then
                            For Each dwc As Control In d.Controls
                                If TypeOf (dwc) Is RadDropDownList Or TypeOf (dwc) Is RadDateTimePicker Or TypeOf (dwc) Is RadTextBoxControl Or TypeOf (dwc) Is RadGroupBox Or
                                    TypeOf (dwc) Is RadButton Or TypeOf (dwc) Is RadMaskedEditBox Then
                                    dwc.Enabled = True
                                End If
                            Next
                        End If
                    Next
                End If

                If TypeOf (c) Is ToolWindow Then
                    For Each dwc As Control In c.Controls
                        If TypeOf (dwc) Is RadListView Or TypeOf (dwc) Is RadTextBoxControl Then
                            dwc.Enabled = False
                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Sub disabledfield()
        For Each ctrl As RadControl In RadDock1.Controls
            For Each c As Control In ctrl.Controls
                If TypeOf (c) Is DocumentTabStrip Then
                    For Each d As Control In c.Controls
                        If TypeOf (d) Is DocumentWindow Then

                            For Each dwc As Control In d.Controls
                                If TypeOf (dwc) Is RadDropDownList Or TypeOf (dwc) Is RadDateTimePicker Or TypeOf (dwc) Is RadTextBoxControl Or
                                    TypeOf (dwc) Is RadGroupBox Or TypeOf (dwc) Is RadButton Or TypeOf (dwc) Is RadMaskedEditBox Then
                                    dwc.Enabled = False
                                End If
                            Next

                        End If
                    Next
                End If

                If TypeOf (c) Is ToolWindow Then
                    For Each dwc As Control In c.Controls
                        If TypeOf (dwc) Is RadListView Or TypeOf (dwc) Is RadTextBoxControl Then
                            dwc.Enabled = True
                        End If
                    Next
                End If
            Next
        Next
    End Sub

    Sub validatefield()
        For Each ctrl As RadControl In RadDock1.Controls
            For Each c As Control In ctrl.Controls
                If TypeOf (c) Is DocumentTabStrip Then
                    For Each d As Control In c.Controls
                        If TypeOf (d) Is DocumentWindow Then
                            For Each dwc As Control In d.Controls
                                If TypeOf (dwc) Is RadDropDownList Or TypeOf (dwc) Is RadTextBoxControl Then
                                    If dwc.Text = "" Then
                                        resultvalidation = 1
                                    End If
                                End If

                                If TypeOf (dwc) Is RadMaskedEditBox Then
                                    Dim a As RadMaskedEditBox = dwc
                                    If a.Name = "mask_canepoint_rate" Then
                                        If a.Value = "___" Or a.Text > "1.00" Then
                                            resultvalidation = 1
                                        End If
                                    ElseIf a.Name = "mask_hauling_rate" Then
                                        If a.Value = "___" Or a.Text > "1.00" Then
                                            resultvalidation = 1
                                        End If
                                    ElseIf a.Name = "mask_cutting_rate" Then
                                        If a.Value = "___" Or a.Text > "1.00" Then
                                            resultvalidation = 1
                                        End If
                                    End If
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        Next
    End Sub
#End Region
    Private Sub Frm_canepoint_request_review_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        canepoint_main_request()
        glomod.populate_listview_progress_status(Frm_canepointreceipt_NEW.lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8, "Loading...",
                                   " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr A INNER JOIN tbl_ais_canepoint_signatories B ON A.id=B.hdr_id  WHERE B.requested_by='" & user_id & "' AND status = 1")
        glomod.data_item_grouping(Frm_canepointreceipt_NEW.lv_request_canepoint, "date_req")

        glomod.data_item_selected_zero(Frm_canepointreceipt_NEW.lv_request_canepoint, 1)
        slct_id_canepoint_main_request = 0

    End Sub

    Private Sub Frm_canepoint_request_review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        dt_dateneeded.Value = server_datetime

        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False

        disabledfield()

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
        enabledfield()

        slct_id_canepoint_for_approval = glomod.selection_listview(lv_for_approval_list)

        If slct_id_canepoint_for_approval <> 0 Then
            dp_location.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT location FROM v_ais_location_maindata WHERE location IS NOT NULL ORDER BY location ASC", "location")
            dp_location.DisplayMember = "location"
            dp_location.Text = ""
        End If
    End Sub

    Private Sub dp_location_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_location.SelectedIndexChanged
        slct_id_location_for_approval = selection_dropdown("SELECT TOP 1 loc_id FROM v_ais_location_maindata WHERE location='" & dp_location.Text & "'")

        If slct_id_location_for_approval <> 0 Or slct_id_location_for_approval <> Nothing Then
            dp_lot_no.DataSource = glomod.populate_dropdown_using_datatable("SELECT new_lot_code FROM v_ais_location_maindata" _
                                                                            & " WHERE loc_id='" & slct_id_location_for_approval & "' GROUP BY new_lot_code ORDER BY LEN(new_lot_code) ASC", "locations")
            dp_lot_no.DisplayMember = "new_lot_code"
            dp_lot_no.Text = Nothing

            txt_owner_name.Text = ""
            txt_variety.Text = ""
        End If
    End Sub

    Private Sub dp_lot_no_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles dp_lot_no.SelectedIndexChanged
        If dp_lot_no.Text <> "" Then
            slct_id_lotno_for_approval = glomod.selection_dropdown("SELECT TOP 1 id FROM v_ais_location_maindata" _
                                                                                      & " WHERE new_lot_code='" & dp_lot_no.Text & "' GROUP BY new_lot_code,id ORDER BY LEN(new_lot_code) ASC")

            If slct_id_lotno_for_approval <> 0 Or slct_id_lotno_for_approval <> Nothing Then
                sysmod.strQuery = "SELECT TOP 1 pl_name,variety_desc,crop_year FROM v_ais_location_maindata" _
                            & " WHERE id='" & slct_id_lotno_for_approval & "' GROUP BY pl_name,variety_desc,crop_year"
                sysmod.useDB(sysmod.strQuery)
                sysmod.dr = sysmod.sqlCmd.ExecuteReader()

                txt_owner_name.Text = ""
                txt_variety.Text = ""

                If sysmod.dr.HasRows Then
                    While sysmod.dr.Read()
                        'txt_owner_name.Text = sysmod.dr.Item(0).ToString
                        'txt_variety.Text = sysmod.dr.Item(1).ToString

                        If sysmod.dr.Item(0).ToString = "" Then
                            txt_owner_name.Text = "No Data found to this field."
                        Else
                            txt_owner_name.Text = sysmod.dr.Item(0).ToString
                        End If

                        If sysmod.dr.Item(1).ToString = "" Then
                            txt_variety.Text = "No Data found to this field."
                        Else
                            txt_variety.Text = sysmod.dr.Item(1).ToString
                        End If

                        If sysmod.dr.Item(2).ToString = "" Then
                            txt_crop_year.Text = "No Data found to this field."
                        Else
                            txt_crop_year.Text = sysmod.dr.Item(2).ToString
                        End If
                    End While
                End If
                sysmod.dbConn.Close()
            End If
        End If
    End Sub

    Private Function selection_dropdown(query As String)
        Dim has_id As Integer
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                has_id = sysmod.dr.Item("loc_id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return has_id
    End Function

    Private Sub btn_cancel_clear_Click(sender As Object, e As EventArgs) Handles btn_cancel_clear.Click
        disabledfield()
        clearfield()

        glomod.populate_listview(lv_for_approval_list, "p_ais_canepoint_main_datas " & user_id & ",0", 6)
        glomod.data_item_grouping(lv_for_approval_list, "date_req")

        glomod.data_item_selected_zero(lv_for_approval_list, 1)
        slct_id_canepoint_main_request = 0
    End Sub

    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click
        Dim hauling_stats = 0

        validatefield()

        If resultvalidation <> 1 Then
            If slct_id_canepoint_for_approval <> Nothing Then
                If rb_deliver.IsChecked = True Then
                    hauling_stats = 1
                Else
                    hauling_stats = 0
                End If
                If rb_pickup.IsChecked = True Then
                    hauling_stats = 2
                Else
                    hauling_stats = 0
                End If

                glomod.add_update_data("p_ais_canepoint_main_approved_request " & slct_id_canepoint_for_approval & ",'" & dp_location.Text & "','" & txt_owner_name.Text & "','" & dp_lot_no.Text & "'" _
                                       & ", '" & txt_variety.Text & "','" & dt_dateneeded.Value & "'," & hauling_stats & "," & mask_canepoint_rate.Text & "," & mask_hauling_rate.Text & "," _
                                       & "" & user_id & ",'" & txt_crop_year.Text & "'")

                disabledfield()
                clearfield()
                glomod.populate_listview(lv_for_approval_list, "p_ais_canepoint_main_datas " & user_id & ",0", 6)
                glomod.data_item_grouping(lv_for_approval_list, "date_req")

                glomod.data_item_selected_zero(lv_for_approval_list, 1)
                slct_id_canepoint_main_request = 0
            End If
        Else
            RadMessageBox.Show("WRONG")
            resultvalidation = 0
        End If

    End Sub

    Private Sub rb_pickup_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rb_pickup.ToggleStateChanged
        If rb_pickup.IsChecked = True Then
            mask_hauling_rate.Text = "0.00"
            mask_hauling_rate.ReadOnly = True
        Else
            mask_hauling_rate.Text = "0.10"
            mask_hauling_rate.ReadOnly = False
        End If
    End Sub
End Class
