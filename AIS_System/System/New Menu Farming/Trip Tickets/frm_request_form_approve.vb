Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Frm_request_form_approve

    Dim ctr As Integer = 0
    Dim driver As String
    Dim sysmod As New System_mod
    Dim glomod As New global_mod


#Region "LISTVIEW COLUMN"
    Sub equipment_column()
        Me.lv_equipments.Columns.Clear()

        With Me.lv_equipments
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("onwer_name", "EQUIPMENT OWNER")
            .Columns.Add("equip_type", "EQUIPMENT TYPE")
            .Columns.Add("equip_desc", "EQUIPMENT DESCRIPTION")
            .Columns.Add("status", "STATUS")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 60
            .Columns("onwer_name").Width = 250
            .Columns("onwer_name").Visible = False
            .Columns("equip_type").Width = 180
            .Columns("equip_desc").Width = 200
            .Columns("status").Width = 120


            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_equipments.EnableGrouping = True
            Me.lv_equipments.ShowGroups = True
        End With
    End Sub

    Sub implement_column()
        Me.lv_implements.Columns.Clear()

        With Me.lv_implements
            .Columns.Add("Id", "")
            .Columns.Add("Count", "#")
            .Columns.Add("onwer_name", "IMPLEMENT OWNER")
            .Columns.Add("imple_desc", "IMPLEMENT TYPE")
            .Columns.Add("code", "CODE")
            .Columns.Add("status", "STATUS")

            .Columns("Id").Width = 0
            .Columns("Id").Visible = False
            .Columns("Count").Width = 60
            .Columns("onwer_name").Width = 200
            .Columns("onwer_name").Visible = False
            .Columns("imple_desc").Width = 300
            .Columns("code").Width = 80
            .Columns("status").Width = 120

            .FullRowSelect = True
            '.ShowGridLines = True
            .MultiSelect = False

            Me.lv_implements.EnableGrouping = True
            Me.lv_implements.ShowGroups = True
        End With
    End Sub
#End Region

    Sub processing(query)
        Dim i As Integer = 0
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                For i = 0 To 4
                    Dim desc = sysmod.dr.Item(i)
                    Select Case i
                        Case 0
                            txt_equipment_type.Text = desc
                        Case 1
                            txt_equipment_no.Text = desc
                        Case 2
                            txt_implement_type.Text = desc
                        Case 3
                            txt_imple_no.Text = desc
                        Case 4
                            dp_driver.Text = desc
                    End Select
                Next

                'DISABLED
                pvp_aprroval_request.Enabled = False
            Else
                'ENABLED
                pvp_aprroval_request.Enabled = True
            End If

            sysmod.dbConn.Close()
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub Frm_request_form_approve_Initialized(sender As Object, e As EventArgs) Handles MyBase.Initialized
        glomod.centering_form(Me)
    End Sub
    Private Sub Frm_request_form_approve_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        processing("p_ais_trip_ticket_request_foorm_approval_info '" & hdr_id_approval & "'")

        request_form_view.dp_driver_load()
        request_form_view.driver_validity()

        If driver_validitys <> 0 Then
            Me.dp_driver.Enabled = False
            driver_id = Nothing
            Me.dp_driver.NullText = "<Already assigned a Driver>"
        End If
    End Sub

    Private Sub Frm_request_form_approve_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
        Frm_trip_ticket_NEWS.refresh_tripticket_request()
    End Sub

    Private Sub pvp_aprroval_request_SelectedPageChanged(sender As Object, e As EventArgs) Handles pvp_aprroval_request.SelectedPageChanged
        If pvp_aprroval_request.SelectedPage Is pvp_page1 Then
            equipment_column()
            request_form_view.load_listview_equipment("SELECT ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,equip_desc) as #,id,owner_name,equipment_type,equip_desc,status FROM v_ais_equipment_masterlist", lv_equipments)
            glomod.data_item_grouping(lv_equipments, "onwer_name")
        ElseIf pvp_aprroval_request.SelectedPage Is pvp_page2 Then
            implement_column()
            request_form_view.load_listview_implement("Select ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,imple_desc ASC) As #,id,owner_name,code,imple_desc,status FROM v_ais_implement_masterlist ORDER BY imple_desc ASC", lv_implements)
            glomod.data_item_grouping(lv_implements, "onwer_name")
        End If

    End Sub

    Private Sub lv_equipments_CellFormatting(sender As Object, e As ListViewCellFormattingEventArgs) Handles lv_equipments.CellFormatting, lv_implements.CellFormatting
        glomod.lv_formats(e)
    End Sub

    'Private Sub lv_equipments_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_equipments.SelectedItemChanged
    '    request_form_view.equipment_slct_listview()
    'End Sub

    'Private Sub lv_implements_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_implements.SelectedItemChanged
    '    request_form_view.implement_slct_listview()
    'End Sub

    Private Sub btn_lockin_equipment_Click(sender As Object, e As EventArgs) Handles btn_lockin_equipment.Click
        request_form_view.approval_equip_id()


        If Me.btn_lockin_equipment.Text = "LOCK IN" Then
            request_form_view.equipment_slct_listview()
            If Me.txt_equipment_type.Text = "" Then
                RadMessageBox.Show("Select Equipment Please.")
                Me.txt_equipment_type.Text = ""
                Me.txt_equipment_no.Text = ""
                Exit Sub
            End If
            If equip_stats = "NOT AVAILABLE" Then
                RadMessageBox.Show("The selected Equipment is Not Available.")
                Me.txt_equipment_type.Text = ""
                Me.txt_equipment_no.Text = ""
                Exit Sub
            End If
            Me.btn_lockin_equipment.Text = "LOCK OUT"
            Me.lv_equipments.Enabled = False
        Else
            Me.txt_equipment_type.Text = ""
            Me.txt_equipment_no.Text = ""
            Me.btn_lockin_equipment.Text = "LOCK IN"
            Me.lv_equipments.Enabled = True
            approval_equip_ids = Nothing
        End If
    End Sub
    Private Sub btn_lock_in_implement_Click(sender As Object, e As EventArgs) Handles btn_lock_in_implement.Click
        request_form_view.approval_imple_id()

        If Me.btn_lock_in_implement.Text = "LOCK IN" Then
            request_form_view.implement_slct_listview()
            If Me.txt_implement_type.Text = "" Then
                RadMessageBox.Show("Select Implement Please.")
                Me.txt_implement_type.Text = ""
                Me.txt_imple_no.Text = ""
                Exit Sub
            End If
            If imple_stats = "NOT AVAILABLE" Then
                RadMessageBox.Show("The selected Implement is Not Available.")
                Me.txt_implement_type.Text = ""
                Me.txt_imple_no.Text = ""
                Exit Sub
            End If
            Me.btn_lock_in_implement.Text = "LOCK OUT"
            Me.lv_implements.Enabled = False
        Else
            Me.txt_implement_type.Text = ""
            Me.txt_imple_no.Text = ""
            Me.btn_lock_in_implement.Text = "LOCK IN"
            Me.lv_implements.Enabled = True
            approval_imple_ids = Nothing
        End If
    End Sub
    Private Sub btn_refresh_equipment_Click(sender As Object, e As EventArgs) Handles btn_refresh_equipment.Click
        'request_form_view.equipment_listview()
        request_form_view.load_listview_equipment("SELECT ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,equip_desc) as #,id,owner_name,equipment_type,equip_desc,status FROM v_ais_equipment_masterlist", lv_equipments)
    End Sub

    Private Sub btn_refresh_implement_Click(sender As Object, e As EventArgs) Handles btn_refresh_implement.Click
        'request_form_view.implement_listview()
        request_form_view.load_listview_implement("Select ROW_NUMBER() over (PARTITION BY owner_name ORDER BY owner_name,imple_desc ASC) As #,id,owner_name,code,imple_desc,status FROM v_ais_implement_masterlist ORDER BY imple_desc ASC", lv_implements)
    End Sub

    Private Sub dp_driver_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs)
        request_form_view.driver()
    End Sub

    Private Sub btn_ST_save_Click(sender As Object, e As EventArgs) Handles btn_ST_save.Click
        Try
            If Me.dp_driver.NullText = "<Already assigned a Driver>" Then
                driver = ""
            Else
                driver = Me.dp_driver.SelectedItem.ToString
            End If
            driver_id = glomod.selection_dropdown("SELECT id FROM tbl_ais_equipment_driver WHERE driver_name='" & dp_driver.Text & "'")
            update_driver_stats("UPDATE tbl_ais_equipment_driver SET status=1 WHERE driver_name='" & dp_driver.Text & "'")

            sysmod.approve_request(hdr_id_approval, dtl_id_approval, lot_id_approval, Replace(Trim(Me.txt_reqno.Text), "'", "`"), "", dt_ST_date.Value, Replace(Trim(Me.txt_equipment_type.Text), "'", "`") _
                                   , Replace(Trim(Me.txt_equipment_no.Text), "'", "`"), Replace(Trim(Me.txt_implement_type.Text), "'", "`"), Replace(Trim(Me.txt_imple_no.Text), "'", "`") _
                                   , driver, Replace(Trim(Me.txt_ST_purpose.Text), "'", "`"), dt_ST_neededdate.Value, tp_ST_neededtime.Value _
                                   , Replace(Trim(Me.txt_ST_requestedby.Text), "'", "`"), Replace(Trim(Frm_main.txt_fullname.Text), "'", "`"), Replace(Trim(Me.txt_lotno.Text), "'", "`") _
                                   , Replace(Trim(Me.txt_workoperation.Text), "'", "`"), approval_equip_ids, approval_imple_ids, driver_id, user_id)

            If sysmod.msgb <> 1 Then
                RadMessageBox.Show(sysmod.msgS, "AIS: DONE.", MessageBoxButtons.OK, RadMessageIcon.Info)
                request_form_view.requested_form_listview()
            Else
                RadMessageBox.Show(sysmod.msgS, "AIS: ERROR...", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Sub update_driver_stats(query)
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.sqlCmd.ExecuteNonQuery()
            sysmod.dbConn.Close()

        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub lv_equipments_VisualItemFormatting(sender As Object, e As ListViewVisualItemEventArgs) Handles lv_equipments.VisualItemFormatting, lv_implements.VisualItemFormatting
        glomod.group_count(e)
    End Sub

    Private Sub btn_ST_unsave_Click(sender As Object, e As EventArgs) Handles btn_ST_unsave.Click
        RadMessageBox.Show("Coming Soon", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub btn_ST_unsave_MouseHover(sender As Object, e As EventArgs) Handles btn_ST_unsave.MouseHover, btn_ST_save.MouseHover, btn_lockin_equipment.MouseHover,
         btn_lock_in_implement.MouseHover, btn_refresh_equipment.MouseHover, btn_refresh_implement.MouseHover

        If sender Is btn_ST_save Then
            glomod.btn_forecolor(btn_ST_save, 0)
        ElseIf sender Is btn_ST_unsave Then
            glomod.btn_forecolor(btn_ST_unsave, 0)
        ElseIf sender Is btn_lockin_equipment Then
            glomod.btn_forecolor(btn_lockin_equipment, 0)
        ElseIf sender Is btn_lock_in_implement Then
            glomod.btn_forecolor(btn_lock_in_implement, 0)
        ElseIf sender Is btn_refresh_equipment Then
            glomod.btn_forecolor(btn_refresh_equipment, 0)
        Else
            glomod.btn_forecolor(btn_refresh_implement, 0)
        End If
    End Sub

    Private Sub btn_ST_unsave_MouseLeave(sender As Object, e As EventArgs) Handles btn_ST_unsave.MouseLeave, btn_ST_save.MouseLeave, btn_lockin_equipment.MouseLeave,
       btn_lock_in_implement.MouseLeave, btn_refresh_equipment.MouseLeave, btn_refresh_implement.MouseLeave

        If sender Is btn_ST_save Then
            glomod.btn_forecolor(btn_ST_save, 1)
        ElseIf sender Is btn_ST_unsave Then
            glomod.btn_forecolor(btn_ST_unsave, 1)
        ElseIf sender Is btn_lockin_equipment Then
            glomod.btn_forecolor(btn_lockin_equipment, 1)
        ElseIf sender Is btn_lock_in_implement Then
            glomod.btn_forecolor(btn_lock_in_implement, 1)
        ElseIf sender Is btn_refresh_equipment Then
            glomod.btn_forecolor(btn_refresh_equipment, 1)
        Else
            glomod.btn_forecolor(btn_refresh_implement, 1)
        End If
    End Sub
End Class
