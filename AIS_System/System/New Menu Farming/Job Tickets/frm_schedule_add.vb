Public Class Frm_schedule_job_ticket_add
    Private Sub Frm_schedule_job_ticket_add_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub lv_schedule_add_hdr_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_schedule_add_hdr.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_schedule_add_menu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
