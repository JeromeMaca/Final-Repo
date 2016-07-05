﻿Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports AIS_System.System_mod
Public Class other_masterlist_view
    Shared sysmod As New System_mod
#Region "PROGRESS STATUS"
    Shared Function progress_status(counting)
        sysmod.strQuery = counting
        sysmod.useDB(sysmod.strQuery)
        sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar

        Return sysmod.resultNum
    End Function
#End Region
    'REFRESH LISTVIEW
#Region "REFRESH LIST VIEW OTHER MASTERLIST"
    Shared Sub location_listview()
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY province order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
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

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try

    End Sub


    Shared Sub operation_category_listview(status_label)
        Try
            progrss_max = progress_status("SELECT COUNT(*) FROM tbl_ais_operation_category")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)


            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by cat_desc asc) as #,category_id,cat_desc FROM tbl_ais_operation_category"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)



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

        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub

    Shared Sub association_listview()
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            'sql = "SELECT  ROW_NUMBER() over (order by sub_desc asc) as #,id,sub_desc FROM tbl_ais_prod_internal_COOP WHERE sub_desc IS NOT Null"
            sql = "SELECT  ROW_NUMBER() over (order by sub_desc asc) as #,id,sub_desc FROM tbl_ais_location_association WHERE sub_desc IS NOT Null"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub variety_listview(status_label)
        Try

            progrss_max = progress_status("SELECT COUNT(*) FROM tbl_ais_cane_cultures")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)

            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by culture_desc asc) as #,id,culture_desc as variety FROM tbl_ais_cane_cultures"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)

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

        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub


    Shared Sub subcon_listview(status_label)
        Try
            progrss_max = progress_status("SELECT COUNT(*) FROM tbl_ais_owner_name")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)


            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by id_name,owner_name asc) as #,id,owner_name FROM tbl_ais_owner_name"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)

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

        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub

    Shared Sub equiptype_listview(status_label)
        Try
            progrss_max = progress_status("SELECT COUNT(*) FROM tbl_ais_equipment_type")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)


            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by equipment_type asc) as #,id,equipment_type FROM tbl_ais_equipment_type"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)

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

        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub

    Shared Sub equipbrand_listview()
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by equipment_brand asc) as #,id,equipment_brand FROM tbl_ais_equipment_brand"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub driver_listview(status_label)
        Try
            progrss_max = progress_status("SELECT COUNT(*) FROM tbl_ais_equipment_driver")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)

            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by driver_name asc) as #,id,driver_name FROM tbl_ais_equipment_driver"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)

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
        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub

    Shared Sub implementlist_listview(status_label)
        Try
            progrss_max = progress_status("SELECT COUNT(*) FROM tbl_ais_implement_list")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)

            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by description asc) as #,id,description FROM tbl_ais_implement_list"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)


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

        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub

    Shared Sub variety2_listview(status_label)
        Try
            progrss_max = progress_status("SELECT COUNT(*) FROM tbl_ais_cane_variety")

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)


            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by variety_desc asc) as #,id,variety_desc as variety FROM tbl_ais_cane_variety"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)

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
        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub
#End Region
    'SEARCHING ITEM
#Region "SEARCH DATA RECORD"
    Shared Sub location_search(search)
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY province order by province,municipality,location asc) as #,id,location,municipality,province" _
                & " FROM tbl_ais_location_list WHERE location LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
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

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub operation_category_search(search)
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by cat_desc asc) as #,category_id,cat_desc" _
                & " FROM tbl_ais_operation_category WHERE cat_desc LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub subcon_search(search)
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by id_name,owner_name asc) as #,id,owner_name FROM tbl_ais_owner_name WHERE owner_name LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub equiptype_search(search)
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by equipment_type asc) as #,id,equipment_type FROM tbl_ais_equipment_type WHERE equipment_type LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub equipbrande_search(search)
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by equipment_brand asc) as #,id,equipment_brand FROM tbl_ais_equipment_brand WHERE equipment_brand LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub driver_search(search)
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by driver_name asc) as #,id,driver_name FROM tbl_ais_equipment_driver WHERE driver_name LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub implementlist_search(search)
        Try
            sql = ""
            'sql = "SELECT  row_number() over (order by province,municipality,location asc) as #,id,location,municipality,province FROM tbl_ais_location_list"
            sql = "SELECT  ROW_NUMBER() over (order by description asc) as #,id,description FROM tbl_ais_implement_list WHERE description LIKE '%" & search & "%'"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_master_list_other.lv_other_masterlist.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())

                        Frm_master_list_other.lv_other_masterlist.Items.Add(list)
                    End While
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region
    'UPDATE DISPLAY DATA
#Region "UPDATE VALUE GET SHOW"
    Shared Sub location_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_loc_location.Text = .SubItems(2)
                Frm_master_list_other.txt_loc_municipality.Text = .SubItems(3)
                Frm_master_list_other.txt_loc_province.Text = .SubItems(4)
            End With
        End If
    End Sub

    Shared Sub operation_category_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_category_desc.Text = .SubItems(2)
            End With
        End If
    End Sub

    Shared Sub association_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_association.Text = .SubItems(2)
            End With
        End If
    End Sub

    Shared Sub variety_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_variety.Text = .SubItems(2)
            End With
        End If
    End Sub
    Shared Sub variety2_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_variety2.Text = .SubItems(2)
            End With
        End If
    End Sub
    Shared Sub subcon_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_subconname.Text = .SubItems(2)
            End With
        End If
    End Sub

    Shared Sub equiptype_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_equiptype.Text = .SubItems(2)
            End With
        End If
    End Sub

    Shared Sub equipbrand_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_equipbrand.Text = .SubItems(2)
            End With
        End If
    End Sub

    Shared Sub driver_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_driver_name.Text = .SubItems(2)
            End With
        End If
    End Sub

    Shared Sub implementlist_updatevalue()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                Frm_master_list_other.txt_impledescription.Text = .SubItems(2)
            End With
        End If
    End Sub
#End Region
    'SELECTED ITEM
#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_selected()
        If Frm_master_list_other.lv_other_masterlist.SelectedItems.Count > 0 Then
            With Frm_master_list_other.lv_other_masterlist.SelectedItems(0)
                slct_id = .SubItems(0)
            End With
        End If
    End Sub
#End Region
    'CLEAR FIELD
#Region "CLEAR FIELD"
    Shared Sub Location_clear_control()
        Frm_master_list_other.txt_loc_province.Text = ""
        Frm_master_list_other.txt_loc_municipality.Text = ""
        Frm_master_list_other.txt_loc_location.Text = ""
        'slct_id = Nothing
        'location_listview()
    End Sub

    Shared Sub Operation_category_clear_control()
        Frm_master_list_other.txt_category_desc.Text = ""
    End Sub

    Shared Sub association_clear_control()
        Frm_master_list_other.txt_association.Text = ""
    End Sub

    Shared Sub variety_clear_control()
        Frm_master_list_other.txt_variety.Text = ""
    End Sub
    Shared Sub variety2_clear_control()
        Frm_master_list_other.txt_variety2.Text = ""
    End Sub
    Shared Sub subcon_clear_control()
        Frm_master_list_other.txt_subconname.Text = ""
    End Sub
    Shared Sub equiptype_clear_control()
        Frm_master_list_other.txt_equiptype.Text = ""
    End Sub
    Shared Sub equipbrand_clear_control()
        Frm_master_list_other.txt_equipbrand.Text = ""
    End Sub
    Shared Sub driver_clear_control()
        Frm_master_list_other.txt_driver_name.Text = ""
    End Sub

    Shared Sub implementlist_clear_control()
        Frm_master_list_other.txt_impledescription.Text = ""
    End Sub
#End Region
    'ENABLED CONTROL
#Region "LOCATION ENABLED"
    Shared Sub enable_location()
        Frm_master_list_other.gb_location.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_loc_province.Focus()
    End Sub

    Shared Sub enabled_operation_category()
        Frm_master_list_other.gb_work_operation.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_category_desc.Focus()
    End Sub

    Shared Sub enabled_association()
        Frm_master_list_other.gb_association.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_association.Focus()
    End Sub


    Shared Sub enabled_variety()
        Frm_master_list_other.gb_variety.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_variety.Focus()
    End Sub

    Shared Sub enabled_variety2()
        Frm_master_list_other.gb_variety2menu.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_variety2.Focus()
    End Sub

    Shared Sub enabled_subcon()
        Frm_master_list_other.gb_subcon.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_subconname.Focus()
    End Sub

    Shared Sub enabled_equiptype()
        Frm_master_list_other.gb_equiptype.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_equiptype.Focus()
    End Sub

    Shared Sub enabled_equipbrand()
        Frm_master_list_other.gb_equipbrand.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_equipbrand.Focus()
    End Sub

    Shared Sub enabled_driver()
        Frm_master_list_other.gb_driver.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_driver_name.Focus()
    End Sub

    Shared Sub enabled_implementlist()
        Frm_master_list_other.gb_implemet_list.Enabled = True
        Frm_master_list_other.gb_global_savecancel.Enabled = True
        Frm_master_list_other.lv_other_masterlist.Enabled = False
        Frm_master_list_other.txt_impledescription.Focus()
    End Sub
#End Region
    'DISABLED CONTROL
#Region "LOCATION DISABLED"
    Shared Sub disabled_location()
        Location_clear_control()
        Frm_master_list_other.gb_location.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_operation_category()
        'Location_clear_control()
        Frm_master_list_other.gb_work_operation.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_association()
        'Location_clear_control()
        Frm_master_list_other.gb_association.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_variety()
        'Location_clear_control()
        Frm_master_list_other.gb_variety.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub
    Shared Sub disabled_variety2()
        'Location_clear_control()
        Frm_master_list_other.gb_variety2menu.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_subcon()
        'Location_clear_control()
        Frm_master_list_other.gb_subcon.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_equiptype()
        'Location_clear_control()
        Frm_master_list_other.gb_equiptype.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_equipbrand()
        'Location_clear_control()
        Frm_master_list_other.gb_equipbrand.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_driver()
        'Location_clear_control()
        Frm_master_list_other.gb_driver.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

    Shared Sub disabled_implementlist()
        'Location_clear_control()
        Frm_master_list_other.gb_implemet_list.Enabled = False
        Frm_master_list_other.gb_global_savecancel.Enabled = False
        Frm_master_list_other.lv_other_masterlist.Enabled = True
    End Sub

#End Region
End Class
