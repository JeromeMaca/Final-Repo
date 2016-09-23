Imports Telerik.WinControls

Public Class Frm_cancellation_reason
    Dim glomod As New global_mod

    Private Sub Frm_cancellation_reason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.centering_form(Me)
    End Sub

    Private Sub btn_cancel_MouseHover(sender As Object, e As EventArgs) Handles btn_cancel.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_cancel_MouseLeave(sender As Object, e As EventArgs) Handles btn_cancel.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub Frm_cancellation_reason_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        schedule_form_view.trip_ticket_schedule_header_data()
        Frm_schedule_encoding.Enabled = True
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If txt_remarks.Text = "" Then
            RadMessageBox.Show("Remarks is required to proceed cancellation.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        If glomod.confirmation_msg() = Windows.Forms.DialogResult.Yes Then
            glomod.add_update_data("  UPDATE tbl_ais_trip_ticket_schedule_dtl SET dtl_stats='10', remark='" & txt_remarks.Text & "' WHERE id='" & slct_id_dtl_schedule & "'")
        End If
    End Sub
End Class
