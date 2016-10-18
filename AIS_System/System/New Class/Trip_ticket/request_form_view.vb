Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.Data
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Public Class request_form_view

    Shared dbConn As New SqlConnection
    'Public ConnStrOut As String = My.Settings.Conn_strings_out 'OTHER DATABASE
    Shared connStr As String = My.Settings.Conn_string 'OWN DATABASE
    Shared sqlCmd As New SqlCommand
    Shared dr As SqlDataReader
    Shared da As New SqlDataAdapter
    Shared tbl As New DataTable
    Shared i As Integer
    Shared strQuery As String = ""

    Shared msgb As Integer
    Shared msgS As String
    Shared resultNum As Integer = 0

    Shared Sub useDB(ByVal sql As String)
        Try
            dbConn = New SqlConnection(connStr)
            sqlCmd = New SqlCommand(sql, dbConn)
            dbConn.Open()

        Catch ex As Exception
            RadMessageBox.Show("Please Contact your Database Administrator." + vbCrLf + ex.Message.ToString, "System Error! ", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub


#Region "LISTVIEW FORMATTING CELL"
    Shared Sub lv_cellformatting(e)
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter

        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        'If (e.CellElement).Data.Name = "grand_amount" Then
        '    If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleRight
        '        e.CellElement.BackColor = Color.Red
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty)
        '    End If

        '    If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleRight
        '    End If
        'End If

        If (TypeOf e.Cellelement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

    End Sub
#End Region

#Region "TRIP TICKET REQUEST FORM CREATE"
#Region "LOAD DROP DOWN"
    Shared Sub dp_location_load()
        Try
            Frm_request_form_add.dp_location.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT location FROM v_ais_location_maindata WHERE location IS NOT NULL ORDER BY location ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("location")
                        Frm_request_form_add.dp_location.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub dp_lot_code_load(loc)
        Try
            Frm_request_form_add.dp_location_lot.Items.Clear()
            sql = ""
            sql = "SELECT ISNULL(new_lot_code,'NO LOT CODE DATA') new_lot_code FROM v_ais_location_maindata WHERE location='" & loc & "' GROUP BY new_lot_code ORDER BY LEN(new_lot_code) ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("new_lot_code")
                        Frm_request_form_add.dp_location_lot.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub dp_operation_load()
        Try
            Frm_request_form_add.dp_workoperations.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT operation FROM tbl_ais_work_operations ORDER BY operation ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("operation")
                        Frm_request_form_add.dp_workoperations.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
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
    Shared Sub request_slct_dp_location(loc_desc)
        Try
            sql = ""
            sql = "SELECT loc_id FROM v_ais_location_maindata WHERE location='" & loc_desc & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    If sqlReader.HasRows Then
                        sqlReader.Read()
                        dp_loc_id = sqlReader.Item("loc_id")
                    Else
                        dp_loc_id = 0
                    End If
                End Using
            End Using
        Catch ex As Exception
            'If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
            '    Exit Sub
            'Else
            RadMessageBox.Show(ex.Message)
            'End If
        End Try
    End Sub

    Shared Sub request_slct_dp_lot(code)
        Try
            sql = ""
            sql = "SELECT id,pl_name,old_lot_code FROM v_ais_location_maindata WHERE new_lot_code='" & code & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    If sqlReader.HasRows Then
                        sqlReader.Read()
                        dp_lot_id = sqlReader.Item("id")
                        Frm_request_form_add.txt_planter.Text = sqlReader.Item("pl_name").ToString
                        Frm_request_form_add.txt_oldlotno.Text = sqlReader.Item("old_lot_code").ToString
                    Else
                        dp_lot_id = 0
                        Frm_request_form_add.txt_planter.Text = "NO RECORD FOUND!"
                        Frm_request_form_add.txt_oldlotno.Text = "NO RECORD FOUND!"
                    End If
                End Using
            End Using
        Catch ex As Exception
            'If ex.Message.ToString = "Invalid attempt to read when no data is present." Then
            '    Exit Sub
            'Else
            RadMessageBox.Show(ex.Message)
            'End If
        End Try
    End Sub

    Shared Sub request_slct_dp_work_operation(desc)
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_work_operations WHERE operation='" & desc & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    sqlReader.Read()
                    req_cat_id = sqlReader.Item("id")
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

#Region "HIDDEN VALUE SELECT"
    Shared Sub request_order_idcode()
        Try
            sql = ""
            sql = " Select DatePart(YEAR,getdate()) as Year,RIGHT('00' + CAST(DATEPART(MONTH,getdate()) AS VARCHAR(2)) ,2)as Month," _
                     & " RIGHT('00' + CAST(DATEPART(DAY,getdate()) AS VARCHAR(2)) ,2)as Day,RIGHT('00' + CAST(DATEPART(HOUR,getdate()) AS VARCHAR(2)) ,2)as Hour," _
                     & " RIGHT('00' + CAST(DATEPART(MINUTE,getdate()) AS VARCHAR(2)) ,2)as Minutes,RIGHT('00' + CAST(DATEPART(SECOND,getdate()) AS VARCHAR(2)) ,2)as Seconds," _
                    & " RIGHT('00' + CAST(DATEPART(DAY,getdate()) AS VARCHAR(2)) ,2)as Milliseconds"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    sqlReader.Read()
                    order_no = sqlReader.Item("Year") & sqlReader.Item("Month") & sqlReader.Item("Day") & sqlReader.Item("Hour") & sqlReader.Item("Minutes") & sqlReader.Item("Seconds") & sqlReader.Item("Milliseconds")
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

    Shared Sub request_req_no()
        Try
            sql = ""
            sql = " Select DatePart(YEAR,getdate()) as Year,RIGHT('00' + CAST(DATEPART(MONTH,getdate()) AS VARCHAR(2)) ,2)as Month," _
                     & " RIGHT('00' + CAST(DATEPART(DAY,getdate()) AS VARCHAR(2)) ,2)as Day,RIGHT('00' + CAST(DATEPART(HOUR,getdate()) AS VARCHAR(2)) ,2)as Hour," _
                     & " RIGHT('00' + CAST(DATEPART(MINUTE,getdate()) AS VARCHAR(2)) ,2)as Minutes,RIGHT('00' + CAST(DATEPART(SECOND,getdate()) AS VARCHAR(2)) ,2)as Seconds"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader
                    sqlReader.Read()
                    req_number = sqlReader.Item("Year") & sqlReader.Item("Month") & sqlReader.Item("Day") & sqlReader.Item("Hour") & sqlReader.Item("Minutes") & sqlReader.Item("Seconds")
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

#Region "TRIP TICKET REQUEST FORM LISTVIEW"
    Shared Sub requested_form_listview()
        Try
            sql = ""
            If Frm_request_form_add.chk_group.Checked = True Then
                sql = "SELECT  ROW_NUMBER() over (PARTITION BY new_lot_code ORDER BY date_req DESC,new_lot_code,operation,pl_name ASC) as #" _
                    & ",id,dtl_id,CONVERT(VARCHAR(12), date_req, 107) as date_req,time_needed,new_lot_code,location,pl_name,operation FROM v_ais_trip_ticket_request_form WHERE user_id ='" & user_id & "'" _
                     & "AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()"
            Else
                sql = "SELECT  ROW_NUMBER() over (PARTITION BY location ORDER BY date_req DESC,new_lot_code,operation,pl_name ASC) as #" _
                    & ",id,dtl_id,CONVERT(VARCHAR(12), date_req, 107) as date_req,time_needed,new_lot_code,location,pl_name,operation FROM v_ais_trip_ticket_request_form WHERE user_id ='" & user_id & "'" _
                    & "AND req_no IS NULL AND stats = '0' AND date_created BETWEEN CONVERT(VARCHAR(12), GETDATE()) AND  GETDATE()"
            End If

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_request_form_add.lv_queued.Items.Clear()
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)
                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())

                        Frm_request_form_add.lv_queued.Items.Add(list)
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
    'SELECTED ITEM LISTVIEW
#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_loc_masterlist_selected()
        If Frm_request_form_add.lv_queued.SelectedItems.Count > 0 Then
            With Frm_request_form_add.lv_queued.SelectedItems(0)
                slct_id_req_hdr = .SubItems(1)
                slct_id_req_dtl = .SubItems(0)
            End With
        End If
    End Sub
#End Region

#End Region

#Region "TRIP TICKET REQUEST FORM LIST"

#Region "REQUEST FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_listview_load()
        Dim frm = New Frm_trip_ticket_NEWS
        Try
            sql = ""
            sql = "SELECT  ROW_NUMBER() over (PARTITION BY req_no ORDER BY CONVERT(VARCHAR(12), date_req, 107) DESC,LEN(new_lot_code),operation ASC) as #" _
                    & ",id,dtl_id,lot_id,req_no,CONVERT(VARCHAR(12), date_created, 107) as date_created,CONVERT(VARCHAR(12), date_req, 107)" _
                    & " as date_req,time_needed,location,new_lot_code,operation,purpose,fullname FROM v_ais_trip_ticket_request_form" _
                     & " WHERE req_no IS NOT NULL AND stats = '0' AND dtl_status ='0' ORDER BY date_req DESC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                frm.lv_request_tt.Items.Clear()

                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    While (sqlReader.Read())
                        Dim list As New ListViewDataItem
                        list.SubItems.Add(sqlReader(1).ToString())
                        list.SubItems.Add(sqlReader(2).ToString())
                        list.SubItems.Add(sqlReader(3).ToString())
                        list.SubItems.Add(sqlReader(0).ToString())
                        list.SubItems.Add(sqlReader(4).ToString())
                        list.SubItems.Add(sqlReader(5).ToString())
                        list.SubItems.Add(sqlReader(6).ToString())
                        list.SubItems.Add(sqlReader(7).ToString())
                        list.SubItems.Add(sqlReader(8).ToString())
                        list.SubItems.Add(sqlReader(9).ToString())
                        list.SubItems.Add(sqlReader(10).ToString())
                        list.SubItems.Add(sqlReader(11).ToString())
                        list.SubItems.Add(sqlReader(12).ToString())

                        frm.lv_request_tt.Items.Add(list)
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

#End Region

#Region "TRIP TICKET REQUEST FORM APPROVAL"

#Region "LOAD DROP DOWN"
    Shared Sub dp_driver_load()
        Try
            Frm_request_form_add.dp_location.Items.Clear()
            sql = ""
            sql = "SELECT DISTINCT(driver_name) FROM tbl_ais_equipment_driver WHERE status ='0' ORDER BY driver_name ASC"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    Frm_request_form_approve.dp_driver.BeginUpdate()

                    While (sqlReader.Read())
                        Dim desc = sqlReader.Item("driver_name")
                        Frm_request_form_approve.dp_driver.Items.Add(desc)
                        'Frm_master_list_location_info.dp_locationinfo_desc.Items.Add(desc)
                    End While

                    Frm_request_form_approve.dp_driver.EndUpdate()
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "LOAD LISTVIEW EQUIPMENT"
    Shared Sub load_listview_equipment(ByRef strQuery As String, ByRef lv As RadListView)
        Try
            lv.Items.Clear()
            useDB(strQuery)
            dr = sqlCmd.ExecuteReader()

            lv.Items.EndUpdate()
            While (dr.Read())
                Dim list As New ListViewDataItem
                list.SubItems.Add(dr(1).ToString())
                list.SubItems.Add(dr(0).ToString())
                list.SubItems.Add(dr(2).ToString())
                list.SubItems.Add(dr(3).ToString())
                list.SubItems.Add(dr(4).ToString())

                Dim e_q = dr(5).ToString()

                If e_q = True Then
                    list.SubItems.Add("NOT AVAILABLE")
                Else
                    list.SubItems.Add("AVAILABLE")
                End If
                lv.Items.Add(list)
            End While

            'Dim table_data As New DataTable()
            'table_data.Load(dr)

            'For Each row As DataRow In table_data.Rows
            '    lv.Items.BeginUpdate()
            '    Dim list As New ListViewDataItem
            '    list.SubItems.Add(row(1).ToString())
            '    list.SubItems.Add(row(0).ToString())
            '    list.SubItems.Add(row(2).ToString())
            '    list.SubItems.Add(row(3).ToString())
            '    list.SubItems.Add(row(4).ToString())

            '    Dim e_q = row(5).ToString()

            '    If e_q = True Then
            '        list.SubItems.Add("NOT AVAILABLE")
            '    Else
            '        list.SubItems.Add("AVAILABLE")
            '    End If
            '    lv.Items.Add(list)
            'Next

            lv.Items.EndUpdate()
            dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        slct_id = Nothing
    End Sub


    Shared Sub load_listview_implement(strQuery As String, lv As RadListView)
        Try
            lv.Items.Clear()
            useDB(strQuery)
            dr = sqlCmd.ExecuteReader()

            lv.Items.EndUpdate()
            While (dr.Read())
                Dim list As New ListViewDataItem
                list.SubItems.Add(dr(1).ToString())
                list.SubItems.Add(dr(0).ToString())
                list.SubItems.Add(dr(2).ToString())
                list.SubItems.Add(dr(4).ToString())
                list.SubItems.Add(dr(3).ToString())

                Dim e_q = dr(5).ToString()

                If e_q = True Then
                    list.SubItems.Add("NOT AVAILABLE")
                Else
                    list.SubItems.Add("AVAILABLE")
                End If

                lv.Items.Add(list)
            End While

            'Dim table_data As New DataTable()
            'table_data.Load(dr)

            'For Each row As DataRow In table_data.Rows
            '    lv.Items.BeginUpdate()
            '    Dim list As New ListViewDataItem
            '    list.SubItems.Add(row(1).ToString())
            '    list.SubItems.Add(row(0).ToString())
            '    list.SubItems.Add(row(2).ToString())
            '    list.SubItems.Add(row(4).ToString())
            '    list.SubItems.Add(row(3).ToString())

            '    Dim e_q = row(5).ToString()

            '    If e_q = True Then
            '        list.SubItems.Add("NOT AVAILABLE")
            '    Else
            '        list.SubItems.Add("AVAILABLE")
            '    End If

            '    lv.Items.Add(list)
            '    lv.Items.EndUpdate()
            'Next


            lv.Items.EndUpdate()
            dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
        slct_id = Nothing
    End Sub
#End Region

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub equipment_slct_listview()
        If Frm_request_form_approve.lv_equipments.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_equipments.SelectedItems(0)
                Frm_request_form_approve.txt_equipment_type.Text = .SubItems(4)
                Frm_request_form_approve.txt_equipment_no.Text = .SubItems(3)
                equip_stats = .SubItems(5)
            End With
        End If
    End Sub

    Shared Sub approval_equip_id()
        If Frm_request_form_approve.lv_equipments.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_equipments.SelectedItems(0)
                approval_equip_ids = .SubItems(0)
            End With
        End If
    End Sub

    Shared Sub implement_slct_listview()
        If Frm_request_form_approve.lv_implements.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_implements.SelectedItems(0)
                Frm_request_form_approve.txt_implement_type.Text = .SubItems(3)
                Frm_request_form_approve.txt_imple_no.Text = .SubItems(4)
                imple_stats = .SubItems(5)
            End With
        End If
    End Sub

    Shared Sub approval_imple_id()
        If Frm_request_form_approve.lv_implements.SelectedItems.Count > 0 Then
            With Frm_request_form_approve.lv_implements.SelectedItems(0)
                approval_imple_ids = .SubItems(0)
            End With
        End If
    End Sub
    ''' <summary>
    ''' RETRIEVING INFO. FOR REVIEWing APPROVAL
    ''' </summary>
    ''' <remarks></remarks>
    Shared Sub for_approval_info(id)
        Try
            sql = "p_ais_trip_ticket_main_datas_review_info '" & id & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    dtl_id_approval = sqlReader.Item("dtl_id")
                    lot_id_approval = sqlReader.Item("lot_id")
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


        If Frm_trip_ticket_NEWS.lv_request_tt.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_request_tt.SelectedItems(0)
                hdr_id_approval = .SubItems(0)

                Frm_request_form_approve.txt_reqno.Text = .SubItems(2)
                Frm_request_form_approve.dt_ST_date.Value = .SubItems(3)
                Frm_request_form_approve.txt_ST_purpose.Text = .SubItems(9)
                Frm_request_form_approve.txt_distenation.Text = .SubItems(6)
                Frm_request_form_approve.dt_ST_neededdate.Value = .SubItems(4)
                Frm_request_form_approve.tp_ST_neededtime.Value = .SubItems(5).ToString
                Frm_request_form_approve.txt_ST_requestedby.Text = .SubItems(10)
                Frm_request_form_approve.txt_lotno.Text = .SubItems(7)
                Frm_request_form_approve.txt_workoperation.Text = .SubItems(8)
            End With
        End If
    End Sub
#End Region

#Region "DROP DOWN SELECT ITEM"
    Shared Sub driver()
        Try
            sql = ""
            sql = "SELECT id FROM tbl_ais_equipment_driver WHERE driver_name='" + Trim(Frm_request_form_approve.dp_driver.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    driver_id = sqlReader.Item("id")
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

#Region "VALIDITY FOR DUPLICATE HEADER"
    Shared Sub driver_validity()
        Try
            sql = ""
            sql = "SELECT COUNT(id) FROM tbl_ais_trip_ticket_schedule_hdr WHERE reg_no='" + Trim(Frm_request_form_approve.txt_reqno.Text) + "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader

                    sqlReader.Read()
                    driver_validitys = sqlReader.Item(0)
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

#Region "TRIP TICKET REQUEST FORM APPROVED ITEM LIST"

#Region "APROVED ITEM LIST REQUEST FORM LISTVIEW LOAD"
    Shared Sub trip_ticket_request_form_approved_data_load()
        Try
            sql = ""
            sql = "SELECT ROW_NUMBER() over ( PARTITION BY trip_date ORDER BY CONVERT(VARCHAR(12), hdr_create_date, 107) DESC) as #," _
                     & "hdr_id,REPLICATE('0', 6 - LEN(reg_no)) + CAST(reg_no AS varchar) AS reg_no," _
                      & "REPLICATE('0', 6 - LEN(trip_ticket_no)) + CAST(trip_ticket_no AS varchar) AS trip_ticket_no," _
                       & "CONVERT(VARCHAR(12), trip_date, 107) as trip_date,location, equip_desc, equip_type, imple_code," _
                        & "driver, purpose, requested_by, approved_by FROM v_ais_trip_ticket_schedule_form " _
                         & " GROUP BY hdr_create_date,hdr_id,reg_no,trip_ticket_no,trip_date,location, equip_desc, equip_type, imple_code," _
                          & "driver, purpose, requested_by, approved_by"

            'WHERE dtl_stats <> 2

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)

                Frm_trip_ticket_NEWS.lv_approved_request_item.Items.Clear()

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
                        list.SubItems.Add(sqlReader(10).ToString())
                        list.SubItems.Add(sqlReader(11).ToString())
                        list.SubItems.Add(sqlReader(12).ToString())

                        Frm_trip_ticket_NEWS.lv_approved_request_item.Items.Add(list)
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

#Region "SELECTED ITEM LISTVIEW"
    Shared Sub Global_approve_request_data_selected()
        If Frm_trip_ticket_NEWS.lv_approved_request_item.SelectedItems.Count > 0 Then
            With Frm_trip_ticket_NEWS.lv_approved_request_item.SelectedItems(0)
                slct_id_req_hdr = .SubItems(0)
            End With
        End If
    End Sub
#End Region
#End Region

End Class
