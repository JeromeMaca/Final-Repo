Imports Telerik.WinControls
Imports Telerik.WinControls.UI.Docking

Public Class Frm_scheduled_encoding_accomplish
    Private Sub Frm_scheduled_encoding_accomplish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()

        Dim service As DragDropService = RadDock1.GetService(Of DragDropService)()
        AddHandler service.Starting, AddressOf service_Starting
    End Sub

    Sub service_Starting(ByVal sender As Object, ByVal e As StateServiceStartingEventArgs)
        e.Cancel = True
    End Sub
    Private Sub Frm_scheduled_encoding_accomplish_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub
End Class
