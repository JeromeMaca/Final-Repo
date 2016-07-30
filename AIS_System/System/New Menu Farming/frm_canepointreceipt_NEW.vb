Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Public Class Frm_canepointreceipt_NEW

#Region "CANEPOINT LISTVIEW COLUMN"

#End Region
    Private Sub lv_request_tt_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_request_tt.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_canepoint_request.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub
End Class
