Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class global_mod

    Public Sub group_count(e)
        Dim groupItem As BaseListViewGroupVisualItem = TryCast(e.VisualItem, BaseListViewGroupVisualItem)
        If groupItem IsNot Nothing Then
            groupItem.Text = groupItem.Data.Text + " ( " + DirectCast(groupItem.Data, ListViewDataItemGroup).Items.Count.ToString + " Record Count)"
            groupItem.Font = New Font("Segoe UI", 8.25, FontStyle.Bold)
        End If
    End Sub

End Class
