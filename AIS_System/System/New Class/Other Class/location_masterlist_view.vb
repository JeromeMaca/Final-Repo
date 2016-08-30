Imports System.Data.SqlClient
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
#Region "LOAD GLOBAL MAIN DROP DOWN MENU"
    Shared Sub main_global_dropdown(dp_control As RadDropDownList, str_table As String, str_column As String, str_where As String, str_where_column As String, tag As Integer)
        Try
            dp_control.Items.Clear()
            sql = ""
            If str_where <> "" And tag = 0 Then
                sql = "SELECT " & str_column & " FROM " & str_table & " WHERE " & str_where_column & " ='" & str_where & "' GROUP BY " & str_column & " ORDER BY " & str_column & " ASC"
            ElseIf str_where <> "" And tag <> 0 Then
                sql = "SELECT " & str_column & " FROM " & str_table & " WHERE " & str_where_column & " LIKE '%" & str_where & "%' GROUP BY " & str_column & " ORDER BY " & str_column & " ASC"
            Else
                sql = "SELECT " & str_column & " FROM " & str_table & " GROUP BY " & str_column & " ORDER BY " & str_column & " ASC"
            End If

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("" & str_column & "")
                        If desc <> " " Then
                            dp_control.Items.Add(desc)
                        Else
                            dp_control.Items.Add("---")
                        End If

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
    Shared Sub main_global_select_dp_desc(text_control As RadTextBox, table As String, column_where As String, column_id As String, column_code As String, where As String, tag_mark As String)
        Try
            sql = ""
            If column_id <> "" And tag_mark <> "" And column_code <> "" Then
                sql = "SELECT TOP 1 " & column_id & "," & column_code & " FROM " & table & " WHERE " & column_where & "='" & Replace(where, "'", "`") & "' AND " & column_code & " IS NOT NULL"
            Else
                sql = "SELECT TOP 1 " & column_code & " FROM " & table & " WHERE " & column_where & "='" & Replace(where, "'", "`") & "' AND " & column_code & " IS NOT NULL"
            End If

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    If (sqlReader.HasRows) Then

                        While sqlReader.Read()
                            Select Case tag_mark
                                Case 0
                                    slct_id_locationdesc = sqlReader.Item("" & column_id & "")
                                Case 1
                                    slct_id_plantername = sqlReader.Item("" & column_id & "")
                            End Select
                            text_control.Text = sqlReader.Item("" & column_code & "")
                        End While
                    Else
                        text_control.Text = "---"
                    End If
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

    Shared Function main_global_id_select_dp__desc(tbl, column_id, column_where, where)
        Try
            Dim result As String
            sql = ""
            sql = "SELECT TOP 1 " & column_id & " FROM " & tbl & " WHERE " & column_where & "='" & Replace(where, "'", "`") & "' AND " & column_id & " IS NOT NULL"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    If sqlReader.HasRows Then
                        While sqlReader.Read
                            result = sqlReader.Item("id")
                        End While
                    End If
                End Using
            End Using

            Return result
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Function
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
    Shared Sub main_loc_updatevalue(mun As RadDropDownList, loc As RadDropDownList, pl As RadDropDownList, old_c As RadTextBox, new_c As RadTextBox,
                                    assoc As RadDropDownList, croclass As RadDropDownList, vari As RadDropDownList, area As RadSpinEditor)
        If Frm_master_list_location.lv_masterlocation.SelectedItems.Count > 0 Then
            With Frm_master_list_location.lv_masterlocation.SelectedItems(0)
                .Text = .Text
                'Dim d As New Frm_master_list_location
                mun.SelectedValue = .SubItems(8)
                loc.SelectedValue = .SubItems(6)
                pl.SelectedText = .SubItems(10)
                main_global_dropdown(pl, "jcso.dbo.tbl_com_planters_ml", "pl_name", pl.Text, "pl_name", 1)
                pl.SelectedValue = .SubItems(10)
                old_c.Text = .SubItems(3)
                new_c.Text = .SubItems(4)
                assoc.SelectedValue = .SubItems(11)
                croclass.SelectedValue = .SubItems(12)
                vari.SelectedValue = .SubItems(13)
                area.Value = .SubItems(15)
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
            .dp_municipality.SelectedIndex = -1
            .dp_locations.SelectedIndex = -1
            .dp_planter_name.SelectedIndex = -1
            .dp_association.SelectedIndex = -1
            .dp_crop_class.SelectedIndex = -1
            .dp_cane_variety.SelectedIndex = -1
            .dp_soil_type.SelectedIndex = -1
            .txt_crop_year.Text = ""
            .txt_mun_code.Text = ""
            .txt_loc_code.Text = ""
            .txt_pl_code.Text = ""
            .txt_new_lot_code.Text = ""
            .txt_old_lot_code.Text = ""
            .sp_area.Value = 0
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

End Class
