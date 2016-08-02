Imports System.Data.SqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_request
    Dim glomod As New global_mod
    Dim sysmod As New System_mod
    Dim tables As DataTable

#Region "LISTVIEW COLUMN"
    Sub create_data_canepoint_request()
        lv_created_canepoint_request.Columns.Clear()

        With lv_created_canepoint_request
            .Columns.Add("id", "id")
            .Columns.Add("count", "#")
            .Columns.Add("date_req", "DATE NEEDED")
            .Columns.Add("r_barrio", "RECEIVING BARRIO")
            .Columns.Add("r_tobereceiveby", "RECEIVING OWNER")
            .Columns.Add("r_total_canepoints", "TOTAL CANEPOINTS")

            .Columns("id").Width = 20
            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("date_req").Width = 120
            .Columns("r_barrio").Width = 150
            .Columns("r_tobereceiveby").Width = 150
            .Columns("r_total_canepoints").Width = 120

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

    Private Sub Frm_canepoint_request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        dt_dateneeded.Value = server_datetime

        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False

        create_data_canepoint_request()

        ''glomod.populate_dropdown(dp_location, "SELECT DISTINCT location FROM jcso.dbo.tbl_com_locations_ml ORDER BY location ASC")

        dp_location.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT location FROM jcso.dbo.tbl_com_locations_ml ORDER BY location ASC", "location")
        dp_location.DisplayMember = "location"
        dp_location.Text = ""
        dp_receiving_owner.DataSource = glomod.populate_dropdown_using_datatable("SELECT DISTINCT pl_name FROM jcso.dbo.tbl_com_planters_ml ORDER BY pl_name ASC", "pl_names")
        dp_receiving_owner.DisplayMember = "pl_name"
        dp_receiving_owner.Text = ""

        'Dim dsCustomers As canepoint_ds = glomod.populate_dropdown_using_datatable("SELECT DISTINCT pl_name FROM jcso.dbo.tbl_com_planters_ml ORDER BY pl_name ASC", "pl_name")
    End Sub

    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub
End Class
