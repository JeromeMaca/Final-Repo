Public Class Frm_lot_manpower_add_queue

#Region "LISTVIEW COLUMN"
    Sub adding_lots_manpowers_column()
        Me.lv_lot_man_data.Columns.Clear()

        With Me.lv_lot_man_data
            .Columns.Add("hdr_id", "hdr_id")
            .Columns.Add("count", "#")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("time_req", "TIME NEEDED")
            .Columns.Add("code", "LOT CODE")
            .Columns.Add("location", "LOCATION")
            .Columns.Add("owner_name", "PLANTER NAME")
            .Columns.Add("operation", "WORK OPERATION")

            .Columns("hdr_id").Width = 20
            .Columns("hdr_id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 180
            .Columns("time_req").Width = 100
            .Columns("code").Width = 200
            .Columns("location").Width = 200


            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

            Me.lv_lot_man_data.EnableGrouping = True
            Me.lv_lot_man_data.ShowGroups = True
        End With
    End Sub
#End Region
    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        MsgBox(comm_lot_man)
    End Sub

    Private Sub Frm_lot_manpower_add_queue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
