Public Class Frm_schedule_job_ticket_add

#Region "LISTVIEW COLUMN"
    Sub Queued_data_schedule_ticket()
        Me.lv_schedule_add_hdr.Columns.Clear()

        With Me.lv_schedule_add_hdr
            .Columns.Add("hdr_id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("oic", "SUPERVISED BY")
            .Columns.Add("lots_count", "No. of LOTS")
            .Columns.Add("manpower_count", "No. of MANPOWER")
            .Columns.Add("remarks", "REMARKS")

            .Columns("hdr_id").Width = 20
            .Columns("hdr_id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 180
            .Columns("oic").Width = 200
            .Columns("lots_count").Width = 100
            .Columns("manpower_count").Width = 120
            .Columns("remarks").Width = 200


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_add_hdr.EnableGrouping = True
            Me.lv_schedule_add_hdr.ShowGroups = True
        End With
    End Sub

    Sub Queued_data_lots_schedule()
        Me.lv_schedule_dtl_lots.Columns.Clear()

        With Me.lv_schedule_dtl_lots
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("loc", "LOCATION")
            .Columns.Add("lots", "LOT No.")
            .Columns.Add("operation", "WORK OPERATION")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("loc").Width = 170
            .Columns("lots").Width = 140
            .Columns("operation").Width = 250


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_dtl_lots.EnableGrouping = True
            Me.lv_schedule_dtl_lots.ShowGroups = True
        End With
    End Sub

    Sub Queued_data_manpower_schedule()
        Me.lv_schedule_dtl_manpower.Columns.Clear()

        With Me.lv_schedule_dtl_manpower
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("manpower", "MANPOWER NAME")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("manpower").Width = 500


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_schedule_dtl_manpower.EnableGrouping = True
            Me.lv_schedule_dtl_manpower.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub Frm_schedule_job_ticket_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Queued_data_schedule_ticket()
        Queued_data_lots_schedule()
        Queued_data_manpower_schedule()
    End Sub
    Private Sub Frm_schedule_job_ticket_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub lv_schedule_add_hdr_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_schedule_add_hdr.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_schedule_add_menu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub btn_add_work_operation_Click(sender As Object, e As EventArgs) Handles btn_add_work_operation.Click
        Frm_lot_manpower_add_queue.Show()
        comm_lot_man = 1
        Frm_lot_manpower_add_queue.Text = "Adding Work Operation"
    End Sub

    Private Sub btn_add_manpower_name_Click(sender As Object, e As EventArgs) Handles btn_add_manpower_name.Click
        Frm_lot_manpower_add_queue.Show()
        comm_lot_man = 2
        Frm_lot_manpower_add_queue.Text = "Adding Manpower Name"
    End Sub

End Class
