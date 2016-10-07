Imports System.Web.UI.WebControls

Public Class Frm_mainreports

#Region "LISTVIEW COLUMN"
    Sub reportlist()
        lv_reportlist.Columns.Clear()

        With lv_reportlist
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("desc", "REPORT TITLE")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 40
            .Columns("desc").Width = 400

            .FullRowSelect = True
            '.ShowGridLines = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False
        End With
    End Sub
#End Region
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Private Sub Frm_mainreports_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_mainreports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.centering_form(Me)
        reportlist()

        glomod.populate_listview(lv_reportlist, "SELECT ROW_NUMBER() OVER (ORDER BY report_name) #,id,report_name FROM tbl_ais_main_report_list", 2)
    End Sub

    Private Sub lv_reportlist_CellFormatting(sender As Object, e As Telerik.WinControls.UI.ListViewCellFormattingEventArgs) Handles lv_reportlist.CellFormatting
        glomod.lv_formats(e)
    End Sub

    Private Sub btn_preview_Click(sender As Object, e As EventArgs) Handles btn_preview.Click
        Dim form_id As Integer = 0
        Dim lvitem As ListViewDataItem = Nothing
        Dim i As Integer = 0

        While i < lv_reportlist.CheckedItems.Count
            With lv_reportlist.CheckedItems(i)
                If lv_reportlist.CheckedItems.Count > 0 Then
                    If lv_reportlist.CheckedItems(i).CheckState = CheckState.Checked Then
                        'add_update_data("p_ais_trip_ticket_accomplished_posting '" & .SubItems(0).ToString & "',''")
                        form_id = .SubItems(0).ToString
                    End If
                End If
            End With
            i += 1

            'CORRESPONDING ID
            '
            '3   CULTIVATION
            '5   EMOD EQUIPMENT
            '6   EMOD GRAB LOADER
            '7   EMOD HARVESTER
            '4   HARVESTING & DELIVERY
            '2   LAND PREP. & PLANTING
            '1   OPERATION PERFORMED LOT BY LOT

            Select Case form_id
                Case 1
                    Frm_lotbylot.Text = "Lot by Lot Report"
                    Frm_lotbylot.MdiParent = Frm_main
                    Frm_lotbylot.Show()
                Case 2
                    Frm_landprep.Text = "Land Preparation & Planting Report"
                    Frm_landprep.MdiParent = Frm_main
                    Frm_landprep.Show()
                Case 3
                    Frm_cultivation.Text = "Cultivation Report"
                    Frm_cultivation.MdiParent = Frm_main
                    Frm_cultivation.Show()
                Case 4
                    frm_harvestingDelivery.Text = "Harveesting & Delivery Report"
                    frm_harvestingDelivery.MdiParent = Frm_main
                    frm_harvestingDelivery.Show()
                Case 5
                    Frm_emodequipment.Text = "EMOD Equipment Report"
                    Frm_emodequipment.MdiParent = Frm_main
                    Frm_emodequipment.Show()
                Case 6
                    Frm_emodgrabloader.Text = "EMOD Grab Loader Report"
                    Frm_emodgrabloader.MdiParent = Frm_main
                    Frm_emodgrabloader.Show()
                Case 7
                    Frm_emodaharvester.Text = "EMOD Harvester Report"
                    Frm_emodaharvester.MdiParent = Frm_main
                    Frm_emodaharvester.Show()
            End Select
        End While
        Me.Close()
    End Sub
End Class
