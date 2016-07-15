Imports System.Data.SqlClient
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class global_mod
    Dim sysmod As New System_mod
    Public Sub group_count(e)
        Dim groupItem As BaseListViewGroupVisualItem = TryCast(e.VisualItem, BaseListViewGroupVisualItem)
        If groupItem IsNot Nothing Then
            groupItem.Text = groupItem.Data.Text + " ( " + DirectCast(groupItem.Data, ListViewDataItemGroup).Items.Count.ToString + " Record Count)"
            groupItem.Font = New Font("Segoe UI", 8.25, FontStyle.Bold)
        End If
    End Sub
    'LISTVIEW FROMATING
    Public Sub lv_formats(e)
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter

        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If

        If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        End If

        'If (e.CellElement).Data.Name = "grand_amount" Then
        '    If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleRight
        '        e.CellElement.BackColor = Color.Red
        '    Else
        '        e.CellElement.ResetValue(LightVisualElement.BackColorProperty)
        '    End If

        '    If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleRight
        '    End If
        'End If

        If (TypeOf e.Cellelement Is DetailListViewCellElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub
    'BASIC DROP DOWN LIST LOADING DATA
    Public Sub populate_dropdown(dp As RadDropDownList, query As String)
        Try
            dp.Items.Clear()
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                While sysmod.dr.Read
                    Dim desc = sysmod.dr.Item(0)
                    dp.Items.Add(desc)
                End While
            End If

            sysmod.dbConn.Close()
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Public Function selection_dropdown(query As String)
        Dim has_id As Integer
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                has_id = sysmod.dr.Item("id")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return has_id
    End Function

    Public Sub selection_listview(lv As RadListView)
        If lv.SelectedItems.Count > 0 Then
            With lv.SelectedItems(0)
                lv_slct_id = .SubItems(0)
            End With
        End If
    End Sub
End Class
