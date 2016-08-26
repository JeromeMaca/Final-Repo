Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel

Public Class Frm_user_control_maintenace
    Dim sysmod As New System_mod
    Dim glomod As New global_mod

#Region "LISTVIEW COLUMN"
    Sub userlist_listview_column()
        Me.lv_useraccountlist.Columns.Clear()

        With Me.lv_useraccountlist
            .Columns.Add("id", "")
            .Columns.Add("count", "#")
            .Columns.Add("username", "USERNAME")
            .Columns.Add("password", "PASSWORD")
            .Columns.Add("userfirstname", "USER FULLNAME")

            .Columns("id").Visible = False
            .Columns("count").Width = 60
            .Columns("username").Width = 180
            .Columns("password").Width = 180
            .Columns("userfirstname").Width = 350


            .FullRowSelect = True
            .ShowGroups = True
            .EnableGrouping = True
            .MultiSelect = False

        End With
    End Sub
#End Region
    Private Sub Frm_user_control_maintenace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'sysmod.Server_time()

        userlist_listview_column()

        glomod.populate_listview_progress_status(lv_useraccountlist, "p_ais_usercontrol_maintenance 0", 4, "Please Wait...", "p_ais_usercontrol_maintenance 1")
    End Sub

    Private Sub lv_useraccountlist_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_useraccountlist.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_usermenu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_useraccountlist_CellFormatting(sender As Object, e As UI.ListViewCellFormattingEventArgs) Handles lv_useraccountlist.CellFormatting
        user_maintenance_view.lv_cellformatting(e)
    End Sub

    Private Sub refreshuser_Click(sender As Object, e As EventArgs) Handles refreshuser.Click
        glomod.populate_listview(lv_useraccountlist, "p_ais_usercontrol_maintenance 0", 4)
    End Sub

    Private Sub lv_useraccountlist_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_useraccountlist.SelectedItemChanged
        user_maintenance_view.Global_selected(lv_useraccountlist)
    End Sub

    Private Sub assignedpermissionuser_Click(sender As Object, e As EventArgs) Handles assignedpermissionuser.Click
        Me.Enabled = False
        Frm_user_control_permission.Show()
    End Sub

    Private Sub Frm_user_control_maintenace_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub

    Private Sub btn_saveaccess_Click(sender As Object, e As EventArgs) Handles btn_saveaccess.Click
        If txt_searchuser.Text <> "" Then
            Dim word1 As String = ""
            Dim word2 As String = ""
            Dim word3 As String = ""
            Dim i As Integer = 0

            Dim words = txt_searchuser.Text.Split(" ".ToArray)

            While i < words.Length
                Select Case i
                    Case 0
                        word1 = words(i).ToString()
                    Case 1
                        word2 = words(i).ToString()
                    Case 2
                        word3 = words(i).ToString()
                End Select
                i += 1
            End While
            glomod.populate_listview(lv_useraccountlist, "p_ais_usercontrol_maintenance 2,'" & word1 & "','" & word2 & "','" & word3 & "'", 4)
        Else
            glomod.populate_listview(lv_useraccountlist, "p_ais_usercontrol_maintenance 0", 4)
        End If
    End Sub

    Private Sub txt_searchuser_TextChanged(sender As Object, e As EventArgs) Handles txt_searchuser.TextChanged
        If txt_searchuser.Text <> "" Then
            Dim word1 As String = ""
            Dim word2 As String = ""
            Dim word3 As String = ""
            Dim i As Integer = 0

            Dim words = txt_searchuser.Text.Split(" ".ToArray)

            While i < words.Length
                Select Case i
                    Case 0
                        word1 = words(i).ToString()
                    Case 1
                        word2 = words(i).ToString()
                    Case 2
                        word3 = words(i).ToString()
                End Select
                i += 1
            End While
            glomod.populate_listview(lv_useraccountlist, "p_ais_usercontrol_maintenance 2,'" & word1 & "','" & word2 & "','" & word3 & "'", 4)
        Else
            glomod.populate_listview(lv_useraccountlist, "p_ais_usercontrol_maintenance 0", 4)
        End If
    End Sub
End Class
