Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Report_Lib

Public Class global_mod
    Dim sysmod As New System_mod

    Public dbConn As SqlConnection
    Public connStr As String = My.Settings.Conn_string
    Public sqlCmd As New SqlCommand
    Public sqlDa As New SqlDataAdapter
    Public dt As New DataTable
    Public sqlDr As SqlDataReader
    Public strQuery As String = ""
    Public i As Integer = 0
    Public canepoint_ds As DataSet

    Public Function populate_dropdown_using_datatable(str As String, tbl_name As String)
        Try
            sysmod.strQuery = str
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()
            Dim table_data As New DataTable(tbl_name)
            table_data.Load(sysmod.dr)
            sysmod.dbConn.Close()
            dt = table_data
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
        Return dt
    End Function

    Public Sub populate_listview_using_datatable(lv As RadListView, query As String, lv_column_count As Integer, tbl_name As String)
        Try
            Dim ctr As Integer = 0
            Dim i As Integer
            lv.Items.Clear()
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()
            Dim table_data As New DataTable(tbl_name)
            table_data.Load(sysmod.dr)

            For Each row As DataRow In table_data.Rows
                Dim list As New ListViewDataItem
                For i = 0 To lv_column_count
                    ctr += 1
                    If ctr = 1 Then
                        i = 1
                    ElseIf ctr = 2 Then
                        i = 0
                    ElseIf ctr = 3 Then
                        i = 2
                    End If

                    If (row(i).ToString) <> "" Then
                        list.SubItems.Add(row(i).ToString())
                    Else
                        list.SubItems.Add("-----")
                    End If
                Next
                ctr = 0
                lv.Items.Add(List)
            Next

            sysmod.dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        queued_schedule_data = Nothing
    End Sub
    'LISTVIEW GROUP EXPAND TRUE/FALSE
    Public Sub group_expantion(groupt_count As String, listv As RadListView)
        Dim ctr = 0
        Dim insss As Integer = groupt_count
        While (ctr < insss)
            If ctr = 0 Then
                listv.Groups(0).Expanded = True
            Else
                listv.Groups(ctr).Expanded = False
            End If
            ctr += 1
        End While
    End Sub
    'LISTVIEW GROUP COUNT
    Public Sub group_count(e)
        Dim groupItem As BaseListViewGroupVisualItem = TryCast(e.VisualItem, BaseListViewGroupVisualItem)
        If groupItem IsNot Nothing Then
            groupItem.Text = groupItem.Data.Text + " ( " + DirectCast(groupItem.Data, ListViewDataItemGroup).Items.Count.ToString + " Record Count)"
            groupItem.Font = New Font("Segoe UI", 8.25, FontStyle.Bold)
        End If
    End Sub
    'LISTVIEW GROUPINGS
    Public Sub data_item_grouping(lv As RadListView, lv_cloumn_group As String)
        lv.GroupDescriptors.Clear()
        Dim groupByType As New GroupDescriptor(lv_cloumn_group)
        lv.GroupDescriptors.Add(groupByType)
    End Sub
    'LISTVIEW SELECT ITEM (0) AFTER LOADING
    Public Sub data_item_selected_zero(lv As RadListView, flag As Integer)
        If flag = 0 Then
            If lv.Items.Count > 0 Then
                lv.SelectedItem = lv.Items(0)
            End If
        Else
            If lv.Items.Count > 0 Then
                lv.SelectedItem = Nothing
            End If
        End If
    End Sub
    'LISTVIEW FROMATING
    Public Sub lv_formats(e)
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
    'BASIC DROP DOWN LIST LOADING DATA
    Public Sub populate_dropdown(dp As RadDropDownList, query As String)
        Try
            dp.Items.Clear()
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                While sysmod.dr.Read
                    Dim desc = sysmod.dr.Item(0)
                    dp.Items.Add(desc)
                End While
            End If

            sysmod.dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    'SELECTION DROW DOWN ID
    Public Function selection_dropdown(query As String)
        Dim has_id As Integer
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                has_id = sysmod.dr.Item("id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return has_id
    End Function

    'SELECTION LISTVIEW ID
    Public Function selection_listview(lv As RadListView)
        If lv.SelectedItems.Count > 0 Then
            With lv.SelectedItems(0)
                queued_schedule_data = .SubItems(0)
            End With
        End If

        Return queued_schedule_data
    End Function

    'POPLATE LISTVIEW
    Public Sub populate_listview(lv As RadListView, query As String, lv_column_count As Integer)
        Try
            Dim ctr As Integer = 0
            Dim i As Integer
            lv.Items.Clear()
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If (sysmod.dr.HasRows) Then
                While (sysmod.dr.Read())
                    Try
                        Dim list As New ListViewDataItem

                        For i = 0 To lv_column_count
                            ctr += 1
                            If ctr = 1 Then
                                i = 1
                            ElseIf ctr = 2 Then
                                i = 0
                            ElseIf ctr = 3 Then
                                i = 2
                            End If

                            If (sysmod.dr(i).ToString) <> "" Then
                                list.SubItems.Add(sysmod.dr(i).ToString())
                            Else
                                list.SubItems.Add("-----")
                            End If

                        Next


                        ctr = 0
                        lv.Items.Add(list)

                    Catch ex As Exception
                        RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
                    End Try
                End While
            End If

            sysmod.dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        queued_schedule_data = Nothing
    End Sub

    'CONFIRMATION MESSAGE FOR THE ACTION 
    Public Function confirmation_msg()
       RETURN RadMessageBox.Show("Are you sure you want to take this action and make changes to all the data presented in the list?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question)
    End Function

    'ADD UPDATE RECORDS
    Public Sub add_update_data(query As String)
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.sqlCmd.ExecuteNonQuery()
            sysmod.dbConn.Close()

        Catch ex As Exception
            If ex.Message <> Nothing Then
                sysmod.msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If sysmod.msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            RadMessageBox.Show("Successfully performed the operation without errors.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    'DELETE RECORDS
    Public Sub delete_data(query As String)
        Try
            If RadMessageBox.Show("Are you sure you want to permanent delete the selected data?", "WARNING...", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                sysmod.strQuery = query
                sysmod.useDB(sysmod.strQuery)
                sysmod.sqlCmd.ExecuteNonQuery()
                sysmod.dbConn.Close()

                RadMessageBox.Show("Successfully performed the operation without errors.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
                sysmod.msgb = 2
            End If
        Catch ex As Exception
            If ex.Message <> Nothing Then
                sysmod.msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If sysmod.msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
    End Sub





    ''' <summary>
    ''' '''''''''''''''''''''''''''''''''''''''''DUMMMMMMYYYY POPULATION
    ''' </summary>
    ''' <param name="userid"></param>
    ''' <returns></returns>

#Region "PROGRESS STATUS"
    Public Function progress_status(str)
        sysmod.strQuery = str
        sysmod.useDB(sysmod.strQuery)
        sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar

        Return sysmod.resultNum
    End Function
#End Region

    Public Sub populate_listview_progress_status(lv As RadListView, query As String, lv_column_count As Integer, status_label As String, strmax As String)
        Try
            Dim ctr As Integer = 0
            Dim i As Integer

            progrss_max = progress_status(strmax)

            Frm_main.main_loadingpogressbar.Maximum = progrss_max
            Frm_main.main_loadingpogressbar.Minimum = 0

            ' Frm_main.docCon.Enabled = False
            Dim ctr_prog As Integer = 0
            Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
            progrss_min = (Val(1) / Val(progrss_max)) * Val(100)

            lv.Items.Clear()
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If (sysmod.dr.HasRows) Then
                While (sysmod.dr.Read())
                    Try
                        Dim list As New ListViewDataItem

                        For i = 0 To lv_column_count
                            ctr += 1
                            If ctr = 1 Then
                                i = 1
                            ElseIf ctr = 2 Then
                                i = 0
                            ElseIf ctr = 3 Then
                                i = 2
                            End If

                            If (sysmod.dr(i).ToString) <> "" Then
                                list.SubItems.Add(sysmod.dr(i).ToString())
                            Else
                                list.SubItems.Add("-----")
                            End If

                        Next
                        ctr = 0
                        lv.Items.Add(list)


                        Frm_main.main_loadingpogressbar.Value1 += 1
                        ctr_prog += 1
                        Frm_main.main_stats_tracker.Text = status_label & ctr_prog & " Out of " & progrss_max & " Records"
                        Application.DoEvents()

                    Catch ex As Exception
                        RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
                    End Try
                End While

                Frm_main.main_stats_tracker.Text = "Completed..."
            End If

            sysmod.dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        queued_schedule_data = Nothing

        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
        ' Frm_main.docCon.Enabled = True
        Frm_main.main_loadingpogressbar.Value1 = 0
    End Sub

    ''''DUMMY LISTVIEW WITH DATA TABLE

    'Public Sub populate_listview_using_datatable_dummy(lv As RadListView, query As String, lv_column_count As Integer, tbl_name As String, status_label As String)
    '    Try
    '        Dim ctr As Integer = 0
    '        Dim i As Integer


    '        progrss_max = progress_status(user_id)

    '        Frm_main.main_loadingpogressbar.Maximum = progrss_max
    '        Frm_main.main_loadingpogressbar.Minimum = 0

    '        ' Frm_main.docCon.Enabled = False
    '        Dim ctr_prog As Integer = 0
    '        Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Visible
    '        progrss_min = (Val(1) / Val(progrss_max)) * Val(100)


    '        lv.Items.Clear()
    '        sysmod.strQuery = query
    '        sysmod.useDB(sysmod.strQuery)
    '        sysmod.dr = sysmod.sqlCmd.ExecuteReader()
    '        Dim table_data As New DataTable(tbl_name)
    '        table_data.Load(sysmod.dr)

    '        For Each row As DataRow In table_data.Rows
    '            Dim list As New ListViewDataItem
    '            For i = 0 To lv_column_count
    '                ctr += 1
    '                If ctr = 1 Then
    '                    i = 1
    '                ElseIf ctr = 2 Then
    '                    i = 0
    '                ElseIf ctr = 3 Then
    '                    i = 2
    '                End If

    '                If (row(i).ToString) <> "" Then
    '                    list.SubItems.Add(row(i).ToString())
    '                Else
    '                    list.SubItems.Add("-----")
    '                End If
    '            Next
    '            ctr = 0
    '            lv.Items.Add(list)

    '            Frm_main.main_loadingpogressbar.Value1 += 1
    '            ctr_prog += 1
    '            Frm_main.main_stats_tracker.Text = status_label & ctr_prog & " Out of " & progrss_max & " Records"
    '            Application.DoEvents()
    '        Next
    '        Frm_main.main_stats_tracker.Text = "Completed..."
    '        sysmod.dbConn.Close()
    '    Catch ex As SqlException
    '        RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
    '    End Try

    '    queued_schedule_data = Nothing

    '    Frm_main.main_loadingpogressbar.Visibility = Telerik.WinControls.ElementVisibility.Hidden
    '    ' Frm_main.docCon.Enabled = True
    '    Frm_main.main_loadingpogressbar.Value1 = 0
    'End Sub
End Class
