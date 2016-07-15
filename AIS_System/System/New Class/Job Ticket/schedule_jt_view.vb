Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class schedule_jt_view
    Shared sysmod As New System_mod
    Shared glomod As New global_mod

    Shared Sub create_schedule_queued_data(lv As RadListView, query As String, lv_column_count As Integer)
        Try
            Dim ctr As Integer = 0
            Dim i As Integer
            lv.Items.Clear()
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If (sysmod.dr.HasRows) Then
                While (sysmod.dr.Read())
                    Dim list As New ListViewDataItem

                    For i = 0 To lv_column_count
                        ctr += 1
                        If ctr = 1 Then
                            i = 1
                        ElseIf ctr = 2 Then
                            i = 0
                        ElseIf ctr = 3 Then
                            i = 2
                        End If

                        list.SubItems.Add(sysmod.dr(i).ToString())
                    Next

                    ctr = 0
                    lv.Items.Add(list)
                End While
            End If

            sysmod.dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub
End Class
