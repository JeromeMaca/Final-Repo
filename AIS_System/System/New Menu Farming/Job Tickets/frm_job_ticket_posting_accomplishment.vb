Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_job_ticket_posting_accomplishment
    Dim glomod As New global_mod
    Dim sysmod As New System_mod
#Region "LISTVIEW COLUMN"
    Sub lv_posting_column()
        With lv_jobticket_for_posting
            .Columns.Clear()

            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("ticket_no", "TICKET NUMBER")
            .Columns.Add("oic", "OFFICER-IN-CHARGE")
            .Columns.Add("date_accom", "DATE ACCOMPLISHED")
            .Columns.Add("accom_by", "ACCOMPLISHED BY")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 50
            .Columns("ticket_no").Width = 100
            .Columns("oic").Width = 200
            .Columns("date_accom").Width = 120
            .Columns("accom_by").Width = 200

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With

    End Sub

    Sub lv_posting_column_sched_info()
        With lv_scheduled_info
            .Columns.Clear()

            .Columns.Add("ticket_no", "TICKET NUMBER")
            .Columns.Add("oic", "OFFICER-IN-CHARGE")
            .Columns.Add("remarks", "REMARKS")
            .Columns.Add("created_date", "DATE ACCOMPLISHED")
            .Columns.Add("created_by", "ACCOMPLISHED BY")
            .Columns.Add("date_accom", "DATE ACCOMPLISHED")
            .Columns.Add("accom_by", "ACCOMPLISHED BY")

            .Columns("ticket_no").Width = 100
            .Columns("oic").Width = 200
            .Columns("remarks").Width = 200
            .Columns("created_date").Width = 100
            .Columns("created_by").Width = 150
            .Columns("date_accom").Width = 100
            .Columns("accom_by").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub

    Sub lv_posting_column_lots_info()
        With lv_lots_info
            .Columns.Clear()

            .Columns.Add("lot", "TICKET NUMBER")
            .Columns.Add("oic", "OFFICER-IN-CHARGE")
            .Columns.Add("remarks", "REMARKS")
            .Columns.Add("created_date", "DATE ACCOMPLISHED")
            .Columns.Add("created_by", "ACCOMPLISHED BY")

            .Columns("ticket_no").Width = 100
            .Columns("oic").Width = 200
            .Columns("remarks").Width = 200
            .Columns("created_date").Width = 100
            .Columns("created_by").Width = 150

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            .EnableGrouping = True
            .ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_job_ticket_posting_accomplishment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_job_ticket_posting_accomplishment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False

        lv_posting_column() : lv_posting_column_sched_info()


        glomod.populate_listview(lv_jobticket_for_posting, "p_ais_job_ticket_for_posting '',1", 5)
    End Sub
    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub

    Private Sub lv_jobticket_for_posting_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_jobticket_for_posting.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_menu_posting.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_jobticket_for_posting_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) _
        Handles lv_jobticket_for_posting.CellFormatting, lv_scheduled_info.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub btn_post_all_Click(sender As Object, e As EventArgs) Handles btn_post_all.Click
        Dim lvitem As ListViewDataItem = Nothing
        Dim i As Integer = 0

        While i < lv_jobticket_for_posting.CheckedItems.Count
            With lv_jobticket_for_posting.CheckedItems(i)
                If lv_jobticket_for_posting.CheckedItems.Count > 0 Then
                    If lv_jobticket_for_posting.CheckedItems(i).CheckState = CheckState.Checked Then
                        MsgBox(.SubItems(0).ToString)
                    End If
                End If
            End With
            i += 1
        End While

    End Sub
    Private Sub lv_jobticket_for_posting_ItemMouseClick(sender As Object, e As ListViewItemEventArgs) Handles lv_jobticket_for_posting.ItemMouseClick
        'txt_jobticket_information.Text = ""
        jt_slct_scheduled_id = 0
        jt_slct_accomplihed_id = glomod.selection_listview(lv_jobticket_for_posting)

        glomod.populate_listview(lv_scheduled_info, "p_ais_job_ticket_for_posting " & jt_slct_accomplihed_id & ", 2", 6)
    End Sub

    'Public Function ohter_command(query)
    '    Dim hold_all As String = Nothing
    '    sysmod.strQuery = query
    '    sysmod.useDB(sysmod.strQuery)
    '    sysmod.dr = sysmod.sqlCmd.ExecuteReader()

    '    If (sysmod.dr.HasRows) Then
    '        While (sysmod.dr.Read())
    '            Dim a = sysmod.dr(0).ToString
    '            Dim b = sysmod.dr(1).ToString
    '            Dim c = sysmod.dr(2).ToString
    '            Dim d = sysmod.dr(3).ToString
    '            Dim e = sysmod.dr(4).ToString
    '            Dim f = sysmod.dr(5).ToString
    '            Dim g = sysmod.dr(6).ToString

    '            hold_all = "SCHEDULED TICKET" + vbCrLf + "    JOB TICKET NO.: " + vbCrLf + "         " + a + vbCrLf + "    OFFICER IN CHARGE: " + vbCrLf + "         " + c + vbCrLf + "    REMARKS: " + vbCrLf + "         " + b + vbCrLf + "    CREATED DATE: " _
    '                    + vbCrLf + "         " + d + vbCrLf + "    CREATED BY: " + vbCrLf + "         " + e + vbCrLf + "    DATE ACCOMPLISHED: " + vbCrLf + "         " + f + vbCrLf _
    '                    + "    ACCOMPLSHIED BY: " + vbCrLf + "         " + g + ""
    '        End While
    '    End If

    '    sysmod.dbConn.Close()

    '    Return hold_all
    'End Function
End Class
