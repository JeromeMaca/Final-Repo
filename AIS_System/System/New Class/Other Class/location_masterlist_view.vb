﻿Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel

Public Class location_masterlist_view
    Shared sysmod As New System_mod
#Region "PROGRESS STATUS"
    Shared Function progress_status(counting)
        sysmod.strQuery = counting
        sysmod.useDB(sysmod.strQuery)
        sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar

        Return sysmod.resultNum
    End Function
#End Region

#Region "FORMATTING"
    Shared Sub lv_formating(e)
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        If (TypeOf e.CellElement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub
#End Region

#Region "MAIN LOCATION"
#Region "LOAD LOCATION MAIN DROP DOWN MENU"
    Shared Sub main_loc_dropdown_desc()
        Try
            Frm_master_list_location.cb_loc_desc.Items.Clear()
            Frm_master_list_location_info.dp_locationinfo_desc.Items.Clear()
            sql = ""
            sql = "SELECT location FROM tbl_ais_location_list ORDER BY location ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("location")
                        Frm_master_list_location.cb_loc_desc.Items.Add(desc)
                        Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub


    Shared Sub loc_info_dropdown_desc(param)
        Try
            Frm_master_list_location_info.dp_lotnumber.Items.Clear()
            sql = ""
            sql = "SELECT code FROM tbl_ais_location WHERE location_id='" & param & "' AND info_id IS NULL ORDER BY code ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("code")
                        Frm_master_list_location_info.dp_lotnumber.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub


    Shared Sub loc_info_dropdown_culture()
        Try
            Frm_master_list_location_info.dp_variety.Items.Clear()
            sql = ""
            sql = "SELECT variety FROM tbl_ais_location_variety ORDER BY variety ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("variety")
                        Frm_master_list_location_info.dp_variety.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub loc_info_dropdown_association()
        Try
            Frm_master_list_location_info.dp_association.Items.Clear()
            sql = ""
            'sql = "SELECT sub_desc FROM tbl_ais_prod_internal_COOP WHERE sub_desc IS NOT NULL ORDER BY sub_desc ASC"

            sql = "SELECT sub_desc FROM tbl_ais_location_association WHERE sub_desc IS NOT NULL ORDER BY sub_desc ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("sub_desc")
                        Frm_master_list_location_info.dp_association.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub load_location_pager(crop_year)
        Try
            Frm_master_list_location.pager_list.Items.Clear()
            sql = ""
            'sql = "SELECT sub_desc FROM tbl_ais_prod_internal_COOP WHERE sub_desc IS NOT NULL ORDER BY sub_desc ASC"

            sql = "p_ais_lotcode_retrieving_COUNTS_GROUP '" & crop_year & "'"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("pagers")
                        Frm_master_list_location.pager_list.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub load_crop_year()
        Try
            Frm_master_list_location.combar_dp_sortby.Items.Clear()
            sql = ""
            sql = "EXEC p_ais_lotcode_retrieving_CROP_YEAR"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("crop_year")
                        Frm_master_list_location.combar_dp_sortby.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "DROP DOWN SELECT ITEM"
    Shared Sub main_loc_select_dp_desc()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location_list WHERE location='" + Trim(Frm_master_list_location.cb_loc_desc.Text) + "' OR location='" & Trim(Frm_master_list_location_info.dp_locationinfo_desc.Text) & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    slct_id_locationdesc = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                RadMessageBox.Show(ex.Message)
            End If
        End Try
    End Sub

    Shared Sub info_loc_select_dp_lot()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location WHERE code='" + Trim(Frm_master_list_location_info.dp_lotnumber.Text) + "' AND location_id='" & slct_id_locationdesc & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    slct_id_locationinfodesc = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                RadMessageBox.Show(ex.Message)
            End If
        End Try
    End Sub


    Shared Sub info_loc_select_dp_variety()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location_variety WHERE variety='" + Trim(Frm_master_list_location_info.dp_variety.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    slct_id_variety = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                RadMessageBox.Show(ex.Message)
            End If
        End Try
    End Sub

    Shared Sub info_loc_select_dp_association()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location_association WHERE sub_desc='" + Trim(Frm_master_list_location_info.dp_association.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    slct_id_association = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                RadMessageBox.Show(ex.Message)
            End If
        End Try
    End Sub
#End Region

#Region "MAIN LOCATION LISTVIEW"
    Shared Sub main_location_listview(status_label, top_select, data_from, data_to, data_group, minimum_prog, crop_year)
        Try

            progrss_max = progress_status("EXEC p_ais_lotcode_retrieving_COUNTS " & top_select & ",'" & crop_year & "'")

            Frm_main.main_loadingpogressbar.Minimum = minimum_prog
            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            'Frm_main.main_loadingpogressbar.Minimum = minimum_prog
            Frm_main.main_loadingpogressbar.Value1 = minimum_prog
            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)

            sql = ""
            'sql = "EXEC p_test_debugging"
            sql = "EXEC p_ais_lotcode_retrieving " & data_from & "," & data_to & ",'" & data_group & "','" & crop_year & "'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_location.lv_masterlocation.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())

                        If (sqlReader(3).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(3).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(4).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(4).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(5).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(5).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(6).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(6).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If

                        If (sqlReader(7).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(7).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(8).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(8).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(9).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(9).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(10).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(10).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(11).ToString()) <> " " Then
                            list.SubItems.Add(sqlReader(11).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(12).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(12).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(13).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(13).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(14).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(14).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(15).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(15).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(16).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(16).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If

                        Frm_master_list_location.lv_masterlocation.Items.Add(list)

                        Frm_main.main_loadingpogressbar.Value1 += 1
                        minimum_prog += 1
                        Frm_main.main_stats_tracker.Text = status_label & minimum_prog & " Out of " & progrss_max & " Records"
                        Application.DoEvents()
                    End While
                    Frm_main.main_stats_tracker.Text = "Completed..."
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
        slct_id = Nothing

        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Minimum = 0
        Frm_main.main_loadingpogressbar.Value1 = 0
        Frm_main.main_loadingpogressbar.Value2 = 0
    End Sub

#End Region

    'SELECTED ITEM LISTVIEW
#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_loc_masterlist_selected()
        If Frm_master_list_location.lv_masterlocation.SelectedItems.Count > 0 Then
            With Frm_master_list_location.lv_masterlocation.SelectedItems(0)
                slct_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region

    'UPDATE VALUE
#Region "main_loc_updatevalue"
    Shared Sub main_loc_updatevalue()
        If Frm_master_list_location.lv_masterlocation.SelectedItems.Count > 0 Then
            With Frm_master_list_location.lv_masterlocation.SelectedItems(0)
                .Text = .Text
                'Frm_master_list_location.cb_loc_desc.SelectedValue = .SubItems(3)
                'Frm_master_list_location.txt_code.Text = .SubItems(2)
                'Frm_master_list_location.sp_area.Value = .SubItems(4)
                'Frm_master_list_location.dp_soiltype.SelectedValue = .SubItems(5)
                'Frm_master_list_location.txt_ownername.Text = .SubItems(8)
            End With
        End If
    End Sub
#End Region

    'DISABLED
#Region "main_location_disabled"
    Shared Sub main_loc_disabled()
        With Frm_master_list_location
            .cp_panelmaintenance.IsExpanded = True
            .gb_menu.Enabled = True
            .gb_data.Enabled = False
        End With
    End Sub
#End Region


#Region "main_location_enabled"
    Shared Sub main_loc_enabled()
        With Frm_master_list_location
            .cp_panelmaintenance.IsExpanded = False
            .gb_menu.Enabled = False
            .gb_data.Enabled = True
            '.txt_code.Text = ""
            .txt_ownername.Text = ""
            .sp_area.Value = 0
            '.dp_soiltype.SelectedIndex = -1
            .cb_loc_desc.SelectedIndex = -1
            '.dp_soiltype.SelectedText = Nothing
            .cb_loc_desc.Text = Nothing
        End With
    End Sub
#End Region

#Region "main_loc_searching"
    Shared Sub main_location_search(search_word)
        Try
            sql = ""
            If search_word <> "" Then
                sql = "SELECT  TOP 50 ROW_NUMBER() over (PARTITION BY location ORDER BY location,code asc) as #,id,code,location,area,soil_type,CONVERT(VARCHAR(12), date_planted, 107) as date_planted,ownership,owner_name,sub_desc,variety,water_source,fiscal_year FROM v_ais_location_maindata " _
                    & " WHERE (location LIKE '%" & search_word & "%') OR (code LIKE '%" & search_word & "%') "
            Else
                sql = "SELECT ROW_NUMBER() over (PARTITION BY location ORDER BY location,code asc) as #,id,code,location,area,soil_type,CONVERT(VARCHAR(12), date_planted, 107) as date_planted,ownership,owner_name,sub_desc,variety,water_source,fiscal_year FROM v_ais_location_maindata " _
                   & " WHERE (location LIKE '%" & search_word & "%') OR (code LIKE '%" & search_word & "%') "
            End If

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_location.lv_masterlocation.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())

                        If (sqlReader(6).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(6).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(7).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(7).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(8).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(8).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(9).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(9).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(10).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(10).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(11).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(11).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If
                        If (sqlReader(12).ToString()) <> "" Then
                            list.SubItems.Add(sqlReader(12).ToString())
                            'list.BackColor = Color.FromArgb(193, 255, 193)
                        Else
                            'list.BackColor = Color.FromArgb(250, 250, 210)
                            list.SubItems.Add("---")
                        End If

                        Frm_master_list_location.lv_masterlocation.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region
#End Region

    'LOCATION INFO
#Region "location_info_listview"


#Region "LOCATION INFO LISTVIEW "
    Shared Sub location_info_listview()
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY location ORDER BY location,code asc) as #,info_id,code,location,CONVERT(VARCHAR(12), date_planted, 107) as date_planted,ownership,sub_desc,variety,water_source,fiscal_year FROM v_ais_location_maindata WHERE info_id IS NOT NULL"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_location_info.lv_loc_info.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())
                        list.SubItems.Add(sqlReader(9).ToString())


                        Frm_master_list_location_info.lv_loc_info.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
        slct_id = Nothing
    End Sub

#End Region

#Region "LOCATION INFO GROUP LISTVIEW"
    Shared Sub group_lv(gp_name)
        Dim groupByType As New GroupDescriptor(New SortDescriptor() {New SortDescriptor(gp_name, ListSortDirection.Ascending)})
        Frm_master_list_location_info.lv_loc_info.GroupDescriptors.Add(groupByType)
    End Sub
#End Region

#Region "LOCATION INFO DISABLED"
    Shared Sub loc_info_disabled()
        With Frm_master_list_location_info
            .gb_menu.Enabled = True
            .gb_data.Enabled = False
        End With
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_loc_info_selected()
        If Frm_master_list_location_info.lv_loc_info.SelectedItems.Count > 0 Then
            With Frm_master_list_location_info.lv_loc_info.SelectedItems(0)
                slct_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#Region "LOCATION INFO UPDATEVALUE"
    Shared Sub loc_info_updatevalue()
        If Frm_master_list_location_info.lv_loc_info.SelectedItems.Count > 0 Then
            With Frm_master_list_location_info.lv_loc_info.SelectedItems(0)
                Frm_master_list_location_info.dp_locationinfo_desc.SelectedValue = .SubItems(3)
                Frm_master_list_location_info.dp_lotnumber.Text = .SubItems(2)
                Frm_master_list_location_info.dt_dateplanted.Value = .SubItems(4)
                Frm_master_list_location_info.dp_ownership.SelectedValue = .SubItems(5)
                Frm_master_list_location_info.dp_association.SelectedValue = .SubItems(6)
                Frm_master_list_location_info.dp_variety.SelectedValue = .SubItems(7)
                Frm_master_list_location_info.txt_fiscalyear.Text = .SubItems(9)

                If .SubItems(8) = True Then
                    Frm_master_list_location_info.rb_yes.IsChecked = True
                Else
                    Frm_master_list_location_info.rb_no.IsChecked = True
                End If
            End With
        End If

        Frm_master_list_location_info.dp_locationinfo_desc.Enabled = False
        Frm_master_list_location_info.dp_lotnumber.Enabled = False
    End Sub
#End Region

#Region "LOCATION INFO ENABLED"
    Shared Sub loc_info_enabled()
        With Frm_master_list_location_info
            .gb_menu.Enabled = False
            .gb_data.Enabled = True

            For Each t As Control In Frm_master_list_location_info.gb_menu.Controls
                If TypeOf (t) Is RadDropDownList = True Then
                    t.Text = ""
                End If
            Next

            For Each tx As Control In Frm_master_list_location_info.gb_menu.Controls
                If TypeOf (tx) Is RadTextBox = True Then
                    tx.Text = ""
                End If
            Next
            For Each dt As Control In Frm_master_list_location_info.gb_menu.Controls
                If TypeOf (dt) Is RadDateTimePicker = True Then
                    dt.Text = Frm_main.txt_actualtime.Text
                End If
            Next


        End With
    End Sub
#End Region

#End Region

    'SPLIT LOT CODE LOCATION
#Region "DIVIDED LOT CODE"

#Region "COMBO BOX LOAD"

    Shared Sub dp_load_location()
        Try
            Frm_masterlist_location_addexisting.dp_loc_desc.Items.Clear()
            sql = ""
            sql = "SELECT location FROM tbl_ais_location_list ORDER BY location ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("location")
                        Frm_masterlist_location_addexisting.dp_loc_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub dp_load_code(loc_id As String, f As Frm_masterlist_location_addexisting)
        Try
            f.dp_lot_code.Items.Clear()
            sql = ""
            sql = "SELECT code FROM tbl_ais_location WHERE location_id='" & loc_id & "' ORDER BY code ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("code")
                        f.dp_lot_code.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub Get_current_area(code_id As String, f As Frm_masterlist_location_addexisting)
        Try
            sql = ""
            sql = "SELECT area FROM tbl_ais_location WHERE id='" & code_id & "' ORDER BY code ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        f.txt_current_area.Text = sqlReader.Item("area")
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "COMBO BOX SELECTED ITEM"

    Shared Sub loc_select_dp_desc(loc_desc)
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location_list WHERE location='" + loc_desc + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    slct_id_locationdesc = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                RadMessageBox.Show(ex.Message)
            End If
        End Try
    End Sub

    Shared Sub code_select_dp_desc(code_desc)
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_location WHERE code='" + code_desc + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    slct_id_code = sqlReader.Item("id")
                End Using
            End Using
        Catch ex As Exception
            If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
                Exit Sub
            Else
                RadMessageBox.Show(ex.Message)
            End If
        End Try
    End Sub
#End Region

#End Region
End Class
