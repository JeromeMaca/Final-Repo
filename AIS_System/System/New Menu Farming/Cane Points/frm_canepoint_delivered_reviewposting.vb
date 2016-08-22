Imports Telerik.WinControls

Public Class Frm_canepoint_delivered_reviewposting
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

#Region "LISTVIEW COLUMN"
    Sub lv_column_cutter_name()
        lv_cuttersname.Columns.Clear()

        With lv_cuttersname
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("cutter_name", "CUTTER NAME")
            .Columns.Add("no_canepoint", "NO. OF CANE POINT")
            .Columns.Add("cutting_rate", "CUTTING RATE")
            .Columns.Add("cutter_cost", "CUTTER COST")
            '.Columns.Add("status", "STATUS")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 50
            .Columns("cutter_name").Width = 250
            .Columns("no_canepoint").Width = 150
            .Columns("cutting_rate").Width = 120
            .Columns("cutter_cost").Width = 120
            '.Columns("status").Width = 100

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region

#Region "RETREIVING CANEPOINT INFO"
    Sub retreive_info(query)
        sysmod.strQuery = query
        sysmod.useDB(sysmod.strQuery)
        sysmod.dr = sysmod.sqlCmd.ExecuteReader

        If sysmod.dr.HasRows Then
            'Dim Frm_canepoint_approved_confirmation As New Frm_canepoint_approved_confirmation
            While (sysmod.dr.Read())
                txt_canepoint_no.Text = sysmod.dr.Item("canepoint_no").ToString
                txt_dateneeded.Text = sysmod.dr.Item("date_needed").ToString
                txt_receiving_barrio.Text = sysmod.dr.Item("receiving_barrio").ToString
                txt_receiving_owner.Text = sysmod.dr.Item("receiving_owner").ToString
                txt_total_canepoint_need.Text = sysmod.dr.Item("total_canepoint").ToString
                txt_source_barrio.Text = sysmod.dr.Item("source_bario").ToString
                txt_source_owner.Text = sysmod.dr.Item("source_owner").ToString
                txt_source_lotno.Text = sysmod.dr.Item("lot_no").ToString
                txt_source_crop_class.Text = sysmod.dr.Item("crop_class").ToString
                txt_validity_date.Text = sysmod.dr.Item("validity_date").ToString
                txt_hauling_date.Text = sysmod.dr.Item("hauling_date").ToString
                txt_hauling_driver.Text = sysmod.dr.Item("hauling_driver").ToString
                txt_hauling_truck_no.Text = sysmod.dr.Item("hauling_truckno").ToString
                txt_canepoint_rate.Text = sysmod.dr.Item("canepoint_cost").ToString
                txt_hauling_rate.Text = sysmod.dr.Item("hauling_cost").ToString
                txt_total_receving.Text = sysmod.dr.Item("receiving_cost").ToString
                txt_date_requested.Text = sysmod.dr.Item("date_requested").ToString
                txt_requestedby.Text = sysmod.dr.Item("requested_name").ToString
                txt_date_approved.Text = sysmod.dr.Item("date_approved").ToString
                txt_approvedby.Text = sysmod.dr.Item("approved_name").ToString
                txt_date_encoded.Text = sysmod.dr.Item("date_encoded").ToString
                txt_encodedby.Text = sysmod.dr.Item("encoded_name").ToString
                txt_date_confirmed.Text = sysmod.dr.Item("date_confirmed").ToString
                txt_confirmedby.Text = sysmod.dr.Item("confirmed_name").ToString
            End While
        End If
    End Sub
#End Region


#Region "OTHER SPECIAL COMMAND"
    Function Entry_validation(query As String)
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar
            sysmod.dbConn.Close()



        Catch ex As Exception
            If ex.Message <> Nothing Then
                sysmod.msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        Return sysmod.resultNum
    End Function
#End Region

    Sub multi_process(process_no)
        Select Case process_no
            Case 0
                'POPULATE LISTVIEW
                glomod.populate_listview(lv_cuttersname, "p_ais_canepoint_delivered '" & slct_id_canepoint_maindelivered & "',1", 5)
            Case 1
                'RETRIEVE DATA EACH BOXES
                retreive_info("p_ais_canepoint_delivered '" & slct_id_canepoint_maindelivered & "',0")
        End Select
    End Sub

    Private Sub Frm_canepoint_delivered_reviewposting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        glomod.populate_listview_progress_status(Frm_canepointreceipt_NEW.lv_delivered_canepoint, "p_ais_canepoint_main_datas '',4", 20, "Loading...",
                           " SELECT COUNT(*) FROM tbl_ais_canepoint_hdr WHERE status =3")
        glomod.data_item_grouping(Frm_canepointreceipt_NEW.lv_delivered_canepoint, "date_req")
    End Sub

    Private Sub Frm_canepoint_delivered_reviewposting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_column_cutter_name()

        'POPULATE LISTVIEW
        multi_process(0)
        'RETRIEVE DATA EACH BOXES
        multi_process(1)
    End Sub

    Private Sub lv_cuttersname_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles lv_cuttersname.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        'POPULATE LISTVIEW
        multi_process(0)
        'RETRIEVE DATA EACH BOXES
        multi_process(1)
    End Sub

    Private Sub btn_posting_Click(sender As Object, e As EventArgs) Handles btn_posting.Click
        Dim result = Entry_validation("SELECT COUNT(*) FROM tbl_ais_canepoint_hdr WHERE id='" & slct_id_canepoint_maindelivered & "' AND status='9'")


        If result <> 0 Then
            RadMessageBox.Show("This data was already posted.", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf result = 0 Then
            glomod.add_update_data("p_ais_canepoint_delivered '" & slct_id_canepoint_maindelivered & "',2,'" & user_id & "'")
        End If
    End Sub


End Class
