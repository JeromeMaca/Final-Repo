Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class Frm_user_control_permission
    Private Sub Frm_user_control_permission_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Frm_user_control_maintenace.Enabled = True
    End Sub

    Private Sub Frm_user_control_permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_maintenance_view.buildtree(user_maintenance_view.CreateDataTable, Me.tv_useraccessmenu, True)

        'FIND NODES
        For i As Integer = 0 To tv_useraccessmenu.Nodes.Count - 1
            user_maintenance_view.browseTreeNodes(tv_useraccessmenu.Nodes(i), 0)
        Next
    End Sub

    Private Sub tv_useraccessmenu_NodeFormatting(sender As Object, e As UI.TreeNodeFormattingEventArgs) Handles tv_useraccessmenu.NodeFormatting
        user_maintenance_view.tv_format(e)
    End Sub

    Private Sub btn_saveaccess_MouseHover(sender As Object, e As EventArgs) Handles btn_saveaccess.MouseHover
        btn_forecolor(btn_saveaccess, 0)
    End Sub

    Private Sub btn_saveaccess_MouseLeave(sender As Object, e As EventArgs) Handles btn_saveaccess.MouseLeave
        btn_forecolor(btn_saveaccess, 1)
    End Sub

    Sub btn_forecolor(btn As RadButton, type As Integer)
        If type = 0 Then
            'Mouse Over
            btn.ButtonElement.TextElement.ForeColor = Color.Black
            btn.ButtonElement.ButtonFillElement.BackColor = Color.White
        ElseIf type = 1 Then
            'Mouse Leave
            btn.ButtonElement.TextElement.ForeColor = Color.White
            btn.ButtonElement.ButtonFillElement.BackColor = Color.FromArgb(149, 165, 165)
        End If

    End Sub

End Class
