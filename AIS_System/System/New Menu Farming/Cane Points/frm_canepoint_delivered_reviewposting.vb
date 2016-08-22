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
            .Columns.Add("no_canepoint", "No. of CANE POINT")
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

    Private Sub Frm_canepoint_delivered_reviewposting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_canepoint_delivered_reviewposting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lv_column_cutter_name()
    End Sub
End Class
