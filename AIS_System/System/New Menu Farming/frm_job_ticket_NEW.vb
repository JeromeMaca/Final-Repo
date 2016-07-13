Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports System.Data.SqlClient
Public Class Frm_job_ticket_NEW
    Dim mymod As New System_mod

    Private Sub create_schedule_Click(sender As Object, e As EventArgs) Handles create_schedule.Click
        Frm_main.Enabled = False
        Frm_schedule_job_ticket_add.Show()
    End Sub

    Private Sub Frm_job_ticket_NEW_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Farming_Operation.Server_time()
    End Sub

    Private Sub lv_schedule_jt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_schedule_jt.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_schedule_jobticket.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
