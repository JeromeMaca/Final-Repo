Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class Frm_user_control_permission
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Dim node_id As Integer = 0
    Dim command_load As Boolean = False

    Sub add_update_data(query As String)
        Try
            sysmod.strQuery = query
            sysmod.useDB(sysmod.strQuery)
            sysmod.sqlCmd.ExecuteNonQuery()
            sysmod.dbConn.Close()

        Catch ex As Exception
            If ex.Message <> Nothing Then
                sysmod.msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If sysmod.msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
            'Else
            '    RadMessageBox.Show("Successfully performed the operation without errors.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Private Sub Frm_user_control_permission_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        add_update_data("p_ais_usercontrol_useraccount_access '" & usercontrol_id & "','0','" & user_id & "','0','0','0','0','0','0','0','0','0','0','0','0','0','1','0','0'")
        Frm_user_control_maintenace.Enabled = True
    End Sub

    Private Sub Frm_user_control_permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        add_update_data("p_ais_usercontrol_useraccount_access '" & usercontrol_id & "','0','" & user_id & "','0','0','0','0','0','0','0','0','0','0','0','0','0','2','0','0'")

        glomod.dt = user_maintenance_view.CreateDataTable()
        tv_useraccessmenu.DisplayMember = "description"
        tv_useraccessmenu.ParentMember = "hierarchy1"
        tv_useraccessmenu.ChildMember = "id"
        tv_useraccessmenu.ValueMember = "id"
        tv_useraccessmenu.DataSource = glomod.dt
        tv_useraccessmenu.ExpandAll()

        'MsgBox(usercontrol_id)
        ctrl_disabled()
        btn_retreived.PerformClick()
    End Sub

    'Private Sub tv_useraccessmenu_NodeFormatting(sender As Object, e As UI.TreeNodeFormattingEventArgs) Handles tv_useraccessmenu.NodeFormatting
    '    user_maintenance_view.tv_format(e)
    'End Sub

    Private Sub btn_saveaccess_MouseHover(sender As Object, e As EventArgs) Handles btn_saveaccess.MouseHover
        glomod.btn_forecolor(btn_saveaccess, 0)
    End Sub

    Private Sub btn_saveaccess_MouseLeave(sender As Object, e As EventArgs) Handles btn_saveaccess.MouseLeave
        glomod.btn_forecolor(btn_saveaccess, 1)
    End Sub

    Private Sub btn_saveaccess_Click(sender As Object, e As EventArgs) Handles btn_saveaccess.Click
        glomod.add_update_data("p_ais_usercontrol_useraccount_access '" & usercontrol_id & "','0','" & user_id & "','0','0','0','0','0','0','0','0','0','0','0','0','0','1','0','0'")
    End Sub

    Sub existiong_account_access(id_node As Integer, tnode As RadTreeNode, flag As Boolean)
        sysmod.strQuery = "SELECT enabled_status,can_refresh,can_create,can_modify,can_remove,can_disapproved,can_review_approval,can_cancel,can_print," _
                    & "can_encode,can_review_encoded,can_review_accomplished,can_view_individual,can_view_all FROM tbl_ais_main_useraccess_account WHERE access_list_id='" & id_node & "'" _
                    & " And username_id='" & usercontrol_id & "'"


        sysmod.useDB(sysmod.strQuery)
        sysmod.dr = sysmod.sqlCmd.ExecuteReader()

        If sysmod.dr.HasRows Then
            While (sysmod.dr.Read())
                If flag = True Then
                    tnode.Checked = sysmod.dr.Item("enabled_status")
                End If

                If command_load <> True Then
                    c1.Checked = sysmod.dr.Item("can_refresh")

                    c2.Checked = sysmod.dr.Item("can_create")

                    c3.Checked = sysmod.dr.Item("can_modify")

                    c4.Checked = sysmod.dr.Item("can_remove")

                    c5.Checked = sysmod.dr.Item("can_cancel")

                    c6.Checked = sysmod.dr.Item("can_disapproved")

                    c7.Checked = sysmod.dr.Item("can_review_approval")

                    c8.Checked = sysmod.dr.Item("can_encode")

                    c9.Checked = sysmod.dr.Item("can_review_encoded")

                    c10.Checked = sysmod.dr.Item("can_review_accomplished")

                    c11.Checked = sysmod.dr.Item("can_print")

                    c12.Checked = sysmod.dr.Item("can_view_individual")

                    c13.Checked = sysmod.dr.Item("Can_view_all")
                End If

            End While
        End If
        sysmod.dbConn.Close()
    End Sub


#Region "CONTROL AVAILABILITY"
    Sub ctrl_disabled()
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is RadGroupBox Then
                If ctrl.Tag = "main_group" Then
                    For Each a As Control In ctrl.Controls
                        If TypeOf (a) Is RadGroupBox Then
                            If a.Tag = "standard" Then
                                For Each s As Control In a.Controls
                                    Dim ss As RadCheckBox = s
                                    ss.CheckState = CheckState.Unchecked
                                    s.Enabled = False
                                Next
                            End If
                            If a.Tag = "transaction" Then
                                For Each t As Control In a.Controls
                                    Dim tt As RadCheckBox = t
                                    tt.CheckState = CheckState.Unchecked
                                    t.Enabled = False
                                Next
                            End If
                        End If
                    Next
                End If
            End If
        Next
    End Sub

    Sub ctrl_readonly()
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is RadGroupBox Then
                If ctrl.Tag = "main_group" Then
                    For Each a As Control In ctrl.Controls
                        If TypeOf (a) Is RadGroupBox Then
                            If a.Tag = "standard" Then
                                For Each s As Control In a.Controls
                                    Dim ss As RadCheckBox = s
                                    ss.ReadOnly = True
                                    's.Enabled = False
                                Next
                            End If
                            If a.Tag = "transaction" Then
                                For Each t As Control In a.Controls
                                    Dim tt As RadCheckBox = t
                                    tt.ReadOnly = True
                                    't.Enabled = False
                                Next
                            End If
                        End If
                    Next
                End If
            End If
        Next
    End Sub

    Sub ctrl_readwrite()
        For Each ctrl As Control In Me.Controls
            If TypeOf (ctrl) Is RadGroupBox Then
                If ctrl.Tag = "main_group" Then
                    For Each a As Control In ctrl.Controls
                        If TypeOf (a) Is RadGroupBox Then
                            If a.Tag = "standard" Then
                                For Each s As Control In a.Controls
                                    Dim ss As RadCheckBox = s
                                    ss.ReadOnly = False
                                    's.Enabled = False
                                Next
                            End If
                            If a.Tag = "transaction" Then
                                For Each t As Control In a.Controls
                                    Dim tt As RadCheckBox = t
                                    tt.ReadOnly = False
                                    't.Enabled = False
                                Next
                            End If
                        End If
                    Next
                End If
            End If
        Next
    End Sub
#End Region

#Region "ACCESSLIST AVAILABLE"
    Sub access_availabled()
        Dim ctr As Integer = 0
        Dim i As Integer = 0
        sysmod.strQuery = "SELECT can_refresh, can_create, can_modify, can_remove, can_cancel, can_disapproved, can_review_approval" _
                       & ", can_encode, can_review_encoded, can_review_accomplished, can_print,can_view_individual,can_view_all FROM tbl_ais_main_useraccess_list WHERE id='" & node_id & "'"
        sysmod.useDB(sysmod.strQuery)
        sysmod.dr = sysmod.sqlCmd.ExecuteReader()
        If sysmod.dr.HasRows Then
            Dim table_data As New DataTable()
            table_data.Load(sysmod.dr)

            'ctrl_disabled()

            For Each row As DataRow In table_data.Rows
                For i = 0 To 12
                    If (row(i)) <> False Then
                        Select Case (i)
                            Case 0
                                c1.Enabled = True
                            Case 1
                                c2.Enabled = True
                            Case 2
                                c3.Enabled = True
                            Case 3
                                c4.Enabled = True
                            Case 4
                                c5.Enabled = True
                            Case 5
                                c6.Enabled = True
                            Case 6
                                c7.Enabled = True
                            Case 7
                                c8.Enabled = True
                            Case 8
                                c9.Enabled = True
                            Case 9
                                c10.Enabled = True
                            Case 10
                                c11.Enabled = True
                            Case 11
                                c12.Enabled = True
                            Case 12
                                c13.Enabled = True
                        End Select
                    Else
                        Select Case (i)
                            Case 0
                                c1.Enabled = False
                            Case 1
                                c2.Enabled = False
                            Case 2
                                c3.Enabled = False
                            Case 3
                                c4.Enabled = False
                            Case 4
                                c5.Enabled = False
                            Case 5
                                c6.Enabled = False
                            Case 6
                                c7.Enabled = False
                            Case 7
                                c8.Enabled = False
                            Case 8
                                c9.Enabled = False
                            Case 9
                                c10.Enabled = False
                            Case 10
                                c11.Enabled = False
                            Case 11
                                c12.Enabled = False
                            Case 12
                                c13.Enabled = False
                        End Select
                    End If
                Next
            Next
        End If
        sysmod.dr.Close()
        sysmod.dbConn.Close()
    End Sub
#End Region

    Private Sub tv_useraccessmenu_NodeCheckedChanged(sender As Object, e As TreeNodeCheckedEventArgs) Handles tv_useraccessmenu.NodeCheckedChanged
        node_id = e.Node.Value
    End Sub

    Private Sub c11_CheckStateChanged(sender As Object, e As EventArgs) Handles c9.CheckStateChanged, c8.CheckStateChanged,
                c7.CheckStateChanged, c6.CheckStateChanged, c5.CheckStateChanged, c4.CheckStateChanged, c3.CheckStateChanged,
                c2.CheckStateChanged, c11.CheckStateChanged, c10.CheckStateChanged, c1.CheckStateChanged, c12.CheckStateChanged,
                c13.CheckStateChanged

        If sender Is c1 Then
            If c1.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_refresh',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_refresh',0")
            End If
        End If
        If sender Is c2 Then
            If c2.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_create',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_create',0")
            End If
        End If
        If sender Is c3 Then
            If c3.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_modify',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_modify',0")
            End If
        End If
        If sender Is c4 Then
            If c4.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_remove',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_remove',0")
            End If
        End If
        If sender Is c5 Then
            If c5.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_cancel',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_cancel',0")
            End If
        End If
        If sender Is c6 Then
            If c6.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_disapproved',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_disapproved',0")
            End If
        End If
        If sender Is c7 Then
            If c7.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_review_approval',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_review_approval',0")
            End If
        End If
        If sender Is c8 Then
            If c8.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_encode',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_encode',0")
            End If
        End If
        If sender Is c9 Then
            If c9.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_review_encoded',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_review_encoded',0")
            End If
        End If
        If sender Is c10 Then
            If c10.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_review_accomplished',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_review_accomplished',0")
            End If
        End If
        If sender Is c11 Then
            If c11.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_print',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_print',0")
            End If
        End If
        If sender Is c12 Then
            If c12.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_view_individual',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_view_individual',0")
            End If
        End If
        If sender Is c13 Then
            If c13.Checked = True Then
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_view_all',1")
            Else
                add_update_data("p_ais_usercontrol_useraccount_access_options '" & usercontrol_id & "','" & node_id & "','can_view_all',0")
            End If
        End If
    End Sub

    Private Sub tv_useraccessmenu_NodeMouseClick(sender As Object, e As RadTreeViewEventArgs) Handles tv_useraccessmenu.NodeMouseClick
        node_id = e.Node.Value

        If (e.Node.Level <> 0) Or (e.Node.Level = 0) Then
            If e.Node.CheckState = CheckState.Checked Or e.Node.CheckState = CheckState.Indeterminate Then
                access_availabled()
                existiong_account_access(node_id, Nothing, False)
                'e.Node.CheckState = CheckState.Unchecked
                Exit Sub
            End If

            ctrl_disabled()
            'e.Node.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub tv_useraccessmenu_MouseDown(sender As Object, e As MouseEventArgs) Handles tv_useraccessmenu.MouseDown
        If e.Button = MouseButtons.Right Then
            cms_command.Show(Me, PointToClient(MousePosition))
        End If
    End Sub

    Private Sub Enabled_Click(sender As Object, e As EventArgs) Handles Enabled.Click
        tv_useraccessmenu.SelectedNode.Checked = True
        access_availabled()
        add_update_data("p_ais_usercontrol_useraccount_access '" & usercontrol_id & "','" & node_id & "','" & user_id & "','0','0','0','0','0','0','0','0','0','0','0','1','1','0','0','0'")
    End Sub

    Private Sub Disabled_Click(sender As Object, e As EventArgs) Handles Disabled.Click
        tv_useraccessmenu.SelectedNode.Checked = False
        ctrl_disabled()
        add_update_data("p_ais_usercontrol_useraccount_access '" & usercontrol_id & "','" & node_id & "','" & user_id & "','0','0','0','0','0','0','0','0','0','0','0','0','1','0','0','0'")
        node_id = Nothing
    End Sub

    Private Sub btn_retreived_Click(sender As Object, e As EventArgs) Handles btn_retreived.Click
        command_load = True
        Dim nodes As RadTreeNodeCollection = tv_useraccessmenu.Nodes
        For Each n As RadTreeNode In nodes
            existiong_account_access(n.Value, n, True)
            For Each tn As RadTreeNode In n.Nodes
                existiong_account_access(tn.Value, tn, True)
                For Each tns As RadTreeNode In tn.Nodes
                    existiong_account_access(tns.Value, tns, True)
                Next
            Next
        Next

        command_load = False
    End Sub
End Class
