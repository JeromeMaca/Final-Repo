Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient

Public Class Frm_request_form_update
    Dim sysmod As New System_mod
    Dim glomod As New global_mod
    Dim ds As New DataSet()

    Dim loc_id As Integer = 0
    Dim lot_id As Integer = 0
    Dim workop_id As Integer = 0


    'If sender Is dp_location Then
    '        glomod.populate_dropdown(dp_location, "SELECT DISTINCT location FROM v_ais_location_maindata WHERE location IS NOT NULL ORDER BY location ASC")
    '    ElseIf sender Is dp_location_lot Then
    '        glomod.populate_dropdown(dp_location_lot, "SELECT ISNULL(new_lot_code,'NO LOT CODE DATA') new_lot_code FROM v_ais_location_maindata WHERE location='" & dp_location.Text & "' GROUP BY new_lot_code ORDER BY LEN(new_lot_code) ASC")
    '    Else
    '        glomod.populate_dropdown(dp_workoperations, "SELECT DISTINCT operation FROM tbl_ais_work_operations ORDER BY operation ASC")
    '    End If

    Private Sub Frm_request_form_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        Try
            sql = "p_ais_trip_ticket_main_datas_review_info '" & slct_id_req_dtl & "'"
            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                Using sqlCmd = New SqlCommand(sql, sqlCnn)
                    Dim sqlReader As SqlDataReader = sqlCmd.ExecuteReader()
                    While (sqlReader.Read())
                        txt_reqno.Text = sqlReader.Item("req_no")
                        dt_ST_date.Value = sqlReader.Item("date_req")
                        tp_ST_neededtime.Value = Convert.ToDateTime(sqlReader.Item("time_needed"))
                        dp_location.SelectedText = sqlReader.Item("location")
                        dp_location_lot.SelectedText = sqlReader.Item("new_lot_code")
                        dp_workoperations.SelectedText = sqlReader.Item("operation")
                        txt_ST_purpose.Text = sqlReader.Item("purpose")
                    End While
                End Using
                sqlCnn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Frm_request_form_update_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        Frm_trip_ticket_NEWS.refresh_tripticket_request()
    End Sub

    Private Sub btn_cancel_update_MouseHover(sender As Object, e As EventArgs) Handles btn_savechanges.MouseHover, btn_cancel_update.MouseHover
        If sender Is btn_savechanges Then
            glomod.btn_forecolor(btn_savechanges, 0)
        Else
            glomod.btn_forecolor(btn_cancel_update, 0)
        End If
    End Sub

    Private Sub btn_cancel_update_MouseLeave(sender As Object, e As EventArgs) Handles btn_savechanges.MouseLeave, btn_cancel_update.MouseLeave
        If sender Is btn_savechanges Then
            glomod.btn_forecolor(btn_savechanges, 1)
        Else
            glomod.btn_forecolor(btn_cancel_update, 1)
        End If
    End Sub

    Private Sub btn_cancel_update_Click(sender As Object, e As EventArgs) Handles btn_cancel_update.Click
        Me.Close()
    End Sub

    Private Sub btn_savechanges_Click(sender As Object, e As EventArgs) Handles btn_savechanges.Click
        Try
            sysmod.strQuery = "SELECT DISTINCT loc_id FROM v_ais_location_maindata WHERE location ='" & dp_location.Text & "'"
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                loc_id = sysmod.dr.Item("loc_id")
            End If
        Catch ex As Exception
        End Try

        lot_id = glomod.selection_dropdown("SELECT id FROM v_ais_location_maindata WHERE new_lot_code='" & dp_location_lot.Text & "'")
        workop_id = glomod.selection_dropdown("SELECT DISTINCT id FROM tbl_ais_work_operations WHERE operation='" & dp_workoperations.Text & "'")
        'MsgBox(loc_id.ToString + vbCrLf + lot_id.ToString + vbCrLf + workop_id.ToString)

        If glomod.confirmation_msg() = Windows.Forms.DialogResult.Yes Then
            If chk_updateinclude.CheckState = CheckState.Checked Then
                glomod.add_update_data("p_ais_trip_ticket_request_form_update '" & slct_id_req_hdr & "','" & slct_id_req_dtl & "','" & dt_ST_date.Value & "'" _
                                       & ",'" & tp_ST_neededtime.Value & "','" & loc_id & "','" & lot_id & "'" _
                                       & ",'" & workop_id & "','" & txt_ST_purpose.Text & "','1'")
            Else
                glomod.add_update_data("p_ais_trip_ticket_request_form_update '" & slct_id_req_hdr & "','" & slct_id_req_dtl & "',''" _
                           & ",'','','" & lot_id & "'" _
                           & ",'" & workop_id & "','','0'")
            End If
        End If
    End Sub

    Private Sub dp_location_PopupOpened(sender As Object, e As EventArgs) Handles dp_location.PopupOpened
        Dim text = dp_location.Text
        glomod.populate_dropdown(dp_location, "SELECT DISTINCT location FROM v_ais_location_maindata WHERE location IS NOT NULL ORDER BY location ASC")
        If dp_location.SelectedText = Nothing Then
            dp_location.Text = text
        End If
        'dp_location_lot.Text = Nothing
    End Sub

    Private Sub dp_location_lot_PopupOpened(sender As Object, e As EventArgs) Handles dp_location_lot.PopupOpened
        Dim text = dp_location_lot.Text
        glomod.populate_dropdown(dp_location_lot, "SELECT ISNULL(new_lot_code,'NO LOT CODE DATA') new_lot_code FROM v_ais_location_maindata WHERE location='" & dp_location.Text & "' GROUP BY new_lot_code ORDER BY LEN(new_lot_code) ASC")
        If dp_location_lot.SelectedText = Nothing Then
            dp_location_lot.Text = text
        End If
        'dp_workoperations.Text = Nothing
    End Sub

    Private Sub dp_workoperations_PopupOpened(sender As Object, e As EventArgs) Handles dp_workoperations.PopupOpened
        Dim text = dp_workoperations.Text
        glomod.populate_dropdown(dp_workoperations, "SELECT DISTINCT operation FROM tbl_ais_work_operations ORDER BY operation ASC")
        If dp_workoperations.SelectedText = Nothing Then
            dp_workoperations.Text = text
        End If
    End Sub
End Class
