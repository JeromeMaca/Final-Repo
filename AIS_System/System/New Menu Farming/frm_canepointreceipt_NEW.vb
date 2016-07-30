Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Public Class Frm_canepointreceipt_NEW
    Private Sub conmenu_createrequest_Click(sender As Object, e As EventArgs) Handles conmenu_createrequest.Click
        Frm_main.Enabled = False
        Frm_canepoint_request.Show()
    End Sub

#Region "CANEPOINT LISTVIEW COLUMN"

#End Region
    Private Sub lv_request_tt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_request_tt.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_canepoint_request.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
