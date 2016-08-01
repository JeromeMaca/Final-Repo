Public Class Frm_canepoint_request
#Region "LISTVIEW COLUMN"
    Sub create_data_canepoit_request()

        Me.lv_created_canepoint_request.Columns.Clear()

        With Me.lv_created_canepoint_request
            .Columns.Add("hdr_id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("oic", "SUPERVISED BY")
            .Columns.Add("lots_count", "No. of LOTS")
            .Columns.Add("manpower_count", "No. of MANPOWER")
            .Columns.Add("operation_count", "No. of OPERATION")
            .Columns.Add("remarks", "REMARKS")
            .Columns.Add("stats", "ITEM STATUS")

            .Columns("hdr_id").Width = 20
            .Columns("hdr_id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 180
            .Columns("oic").Width = 200
            .Columns("lots_count").Width = 100
            .Columns("manpower_count").Width = 120
            .Columns("operation_count").Width = 120
            .Columns("remarks").Width = 200
            .Columns("stats").Width = 120


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region
    Private Sub Frm_canepoint_request_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub
End Class
