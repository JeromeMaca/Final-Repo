Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel
Imports Telerik.WinControls.UI

Public Class Frm_user_control_permission
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

    Dim node_id As Integer = 0
    Private Sub Frm_user_control_permission_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Frm_user_control_maintenace.Enabled = True
    End Sub

    Private Sub Frm_user_control_permission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.dt = user_maintenance_view.CreateDataTable()

        tv_useraccessmenu.DisplayMember = "description"
        tv_useraccessmenu.ParentMember = "hierarchy1"
        tv_useraccessmenu.ChildMember = "id"
        tv_useraccessmenu.ValueMember = "id"
        tv_useraccessmenu.DataSource = glomod.dt

        tv_useraccessmenu.ExpandAll()

        'MsgBox(usercontrol_id)
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
        RadMessageBox.Show("NICE! Working Dude.", "NICE", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub tv_useraccessmenu_NodeMouseClick(sender As Object, e As RadTreeViewEventArgs) Handles tv_useraccessmenu.NodeMouseClick
        If (e.Node.Level <> 0) Or (e.Node.Level = 0) Then
            If e.Node.CheckState = CheckState.Checked Or e.Node.CheckState = CheckState.Indeterminate Then
                e.Node.CheckState = CheckState.Unchecked
                ctrl_disabled()
                Exit Sub
            End If
            e.Node.CheckState = CheckState.Checked
            'MsgBox(e.Node.Text & vbCrLf & e.Node.Value)
            node_id = e.Node.Value
            access_availabled()
        End If
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
#End Region

#Region "ACCESSLIST AVAILABLE"
    Sub access_availabled()
        Dim ctr As Integer = 0
        Dim i As Integer = 0
        sysmod.strQuery = "SELECT can_refresh,can_create,can_modify,can_remove,can_cancel,can_disapproved,can_review_approval" _
                       & ",can_encode,can_review_encoded,can_review_accomplished,can_print FROM tbl_ais_main_useraccess_list WHERE id='" & node_id & "'"
        sysmod.useDB(sysmod.strQuery)
        sysmod.dr = sysmod.sqlCmd.ExecuteReader()
        If sysmod.dr.HasRows Then
            Dim table_data As New DataTable()
            table_data.Load(sysmod.dr)

            ctrl_disabled()

            For Each row As DataRow In table_data.Rows
                For i = 0 To 10
                    'MsgBox(row(i).ToString)
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
                        End Select
                    End If
                Next
            Next
        End If
        sysmod.dbConn.Close()
    End Sub
#End Region
End Class
