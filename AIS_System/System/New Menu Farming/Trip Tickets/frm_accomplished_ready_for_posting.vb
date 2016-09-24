Public Class Frm_accomplished_ready_for_posting
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Private Sub Frm_accomplished_ready_for_posting_Initialized(sender As Object, e As EventArgs) Handles MyBase.Initialized
        glomod.centering_form(Me)
    End Sub

    Private Sub Frm_accomplished_ready_for_posting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub
End Class
