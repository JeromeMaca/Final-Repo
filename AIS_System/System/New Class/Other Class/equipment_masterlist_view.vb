Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class equipment_masterlist_view
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

    'DROP DOWN
#Region "LOAD DROP DOWN"
    Shared Sub dp_owner_load()
        Try
            Frm_master_list_equipment.dp_owner.Items.Clear()
            sql = ""
            sql = "SELECT owner_name FROM tbl_ais_owner_name ORDER BY id ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("owner_name")
                        Frm_master_list_equipment.dp_owner.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub dp_equiptype_load()
        Try
            Frm_master_list_equipment.dp_equiptype.Items.Clear()
            sql = ""
            sql = "SELECT equipment_type FROM tbl_ais_equipment_type ORDER BY equipment_type ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("equipment_type")
                        Frm_master_list_equipment.dp_equiptype.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    'Shared Sub dp_equipbrand_load()
    '    Try
    '        Frm_master_list_equipment.dp_equipbrand.Items.Clear()
    '        sql = ""
    '        sql = "SELECT equipment_brand FROM tbl_ais_equipment_brand ORDER BY equipment_brand ASC"

    '        Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
    '            sqlCnn.Open()
    '            Using sqlCmd = New SqlCommand(sql, sqlCnn)
    '                Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
    '                While (sqlReader.Read())
    '                    Dim desc = sqlReader.Item("equipment_brand")
    '                    Frm_master_list_equipment.dp_equipbrand.Items.Add(desc)
    '                    'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
    '                End While
    '            End Using
    '            sqlCnn.Close()
    '        End Using
    '    Catch ex As Exception
    '        RadMessageBox.Show(ex.Message)
    '    End Try
    'End Sub
#End Region

    'SELECT DROPDOWN
#Region "SELECT DROP DOWN"
    Shared Sub select_dp_owner_equipmain()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_owner_name WHERE owner_name='" + Trim(Frm_master_list_equipment.dp_owner.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_owner_slct_id = sqlReader.Item("id")
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

    Shared Sub select_dp_type_equipmain()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_equipment_type WHERE equipment_type='" + Trim(Frm_master_list_equipment.dp_equiptype.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dp_type_slct_id = sqlReader.Item("id")
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

    'Shared Sub select_dp_brand_equipmain()
    '    Try
    '        sql = ""
    '        sql = "SELECT id FROM tbl_ais_equipment_brand WHERE equipment_brand='" + Trim(Frm_master_list_equipment.dp_equipbrand.Text) + "'"
    '        Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
    '            sqlCnn.Open()
    '            Using sqlCmd = New SqlCommand(sql, sqlCnn)
    '                Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

    '                sqlReader.Read()
    '                dp_brand_slct_id = sqlReader.Item("id")
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
    '            Exit Sub
    '        Else
    '            RadMessageBox.Show(ex.Message)
    '        End If
    '    End Try
    'End Sub
#End Region

    'LISTVIEW LOAD
#Region "LISTVIEWLOAD"
    Shared Sub equipment_masterlist_listview(status_label, curr_group)
        Try

            progrss_max = progress_status("SELECT COUNT(*) FROM v_ais_equipment_masterlist")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)


            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY " & curr_group & " ORDER BY owner_name,equipment_type,equip_desc asc) as #," _
                    & "id,owner_name,equipment_type,equip_desc FROM v_ais_equipment_masterlist"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_equipment.lv_masterequipment.Items.Clear()
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


                        Frm_master_list_equipment.lv_masterequipment.Items.Add(list)


                        Frm_main.main_loadingpogressbar.Value1 += 1
                        ctr += 1
                        Frm_main.main_stats_tracker.Text = status_label & ctr & " Out of " & progrss_max & " Records"
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
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub
#End Region

#Region "MAIN EQUIPMENT DISABLED"
    Shared Sub main_equipment_disabled()
        With Frm_master_list_equipment
            .gb_menu.Enabled = True
            .gb_data.Enabled = False
        End With
    End Sub
#End Region

#Region "MAIN EQUIPMENT ENABLED"
    Shared Sub main_equipment_enabled()
        With Frm_master_list_equipment
            .gb_menu.Enabled = False
            .gb_data.Enabled = True

            For Each t As Control In Frm_master_list_equipment.gb_menu.Controls
                If TypeOf (t) Is RadDropDownList = True Then
                    t.Text = ""
                End If
            Next

            For Each tx As Control In Frm_master_list_equipment.gb_menu.Controls
                If TypeOf (tx) Is RadTextBox = True Then
                    tx.Text = ""
                End If
            Next
            For Each dt As Control In Frm_master_list_equipment.gb_menu.Controls
                If TypeOf (dt) Is RadDateTimePicker = True Then
                    dt.Text = Frm_main.txt_actualtime.Text
                End If
            Next
        End With
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_main_equipment_selected()
        If Frm_master_list_equipment.lv_masterequipment.SelectedItems.Count > 0 Then
            With Frm_master_list_equipment.lv_masterequipment.SelectedItems(0)
                slct_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#Region "MAIN EQUIPMENT UPDATEVALUE"
    Shared Sub main_equipment_updatevalue()
        If Frm_master_list_equipment.lv_masterequipment.SelectedItems.Count > 0 Then
            With Frm_master_list_equipment.lv_masterequipment.SelectedItems(0)
                Frm_master_list_equipment.dp_owner.SelectedValue = .SubItems(2)
                Frm_master_list_equipment.dp_equiptype.SelectedValue = .SubItems(3)
                Frm_master_list_equipment.txt_model.Text = .SubItems(4)

            End With
        End If
    End Sub
#End Region

#Region "main_equipment_searching"
    Shared Sub main_equipment_search(search_word, curr_group)
        Try
            sql = ""

            If search_word <> Nothing Then
                sql = "SELECT TOP 20 ROW_NUMBER() over (PARTITION BY " & curr_group & " ORDER BY owner_name,equipment_type,equip_desc asc) as #," _
                        & "id,owner_name,equipment_type,equip_desc FROM v_ais_equipment_masterlist WHERE equip_desc LIKE '%" & search_word & "%' OR equipment_type LIKE '%" & search_word & "%'"
            Else
                sql = "SELECT ROW_NUMBER() over (PARTITION BY " & curr_group & " ORDER BY owner_name,equipment_type,equip_desc asc) as #," _
                        & "id,owner_name,equipment_type,equip_desc FROM v_ais_equipment_masterlist WHERE equip_desc LIKE '%" & search_word & "%' OR equipment_type LIKE '%" & search_word & "%'"
            End If



            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_equipment.lv_masterequipment.Items.Clear()
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

                        Frm_master_list_equipment.lv_masterequipment.Items.Add(list)
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

End Class
