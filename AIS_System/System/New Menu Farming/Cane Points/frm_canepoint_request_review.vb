Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_request_review

    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Private Sub Frm_canepoint_request_review_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub Frm_canepoint_request_review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'dt_dateneeded.Value = server_datetime

        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting

        Dim menuService As ContextMenuService = Me.RadDock1.GetService(Of ContextMenuService)()
        menuService.AllowDocumentContextMenu = False
    End Sub
    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub
End Class
