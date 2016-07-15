Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class schedule_jt_view
    Shared sysmod As New System_mod
    Shared glomod As New global_mod

    Shared Sub create_schedule_queued_data(lv As RadListView, query As String)
        Try
            lv.Items.Clear()
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If (sysmod.dr.HasRows) Then
                While (sysmod.dr.Read())
                    Dim list As New ListViewDataItem
                    list.SubItems.Add(sysmod.dr(1).ToString())
                    list.SubItems.Add(sysmod.dr(0).ToString())
                    list.SubItems.Add(sysmod.dr(2).ToString())
                    list.SubItems.Add(sysmod.dr(3).ToString())
                    list.SubItems.Add(sysmod.dr(4).ToString())
                    list.SubItems.Add(sysmod.dr(5).ToString())
                    list.SubItems.Add(sysmod.dr(6).ToString())

                    lv.Items.Add(list)
                End While
            End If

            sysmod.dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

End Class
