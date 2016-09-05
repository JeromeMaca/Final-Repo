Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports AIS_System.System_mod
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Telerik.WinControls.UI

Public Class Frm_user_control_maintenace
    Dim sysmod As New System_mod
    Dim glomod As New global_mod

    Dim search_id As Integer = 0

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

#Region "FOR MULTI DROP DOWN SEARCH"
    Sub fill_search_mcc()
        Dim gridViewControl As RadGridView = Me.mcc_findaccount.EditorControl
        gridViewControl.MasterTemplate.AutoGenerateColumns = False
        gridViewControl.Columns.Add(New GridViewTextBoxColumn("id"))
        gridViewControl.Columns.Add(New GridViewTextBoxColumn("username"))
        gridViewControl.Columns.Add(New GridViewTextBoxColumn("fullname"))
        gridViewControl.Columns("id").Width = 20
        gridViewControl.Columns("id").IsVisible = False
        gridViewControl.Columns("username").Width = 150
        gridViewControl.Columns("fullname").Width = 400


        Dim usernames = Me.mcc_findaccount.Columns("username")
        usernames.TextAlignment = ContentAlignment.MiddleCenter
        Dim fullnames = Me.mcc_findaccount.Columns("fullname")
        fullnames.TextAlignment = ContentAlignment.MiddleLeft

        Me.mcc_findaccount.MultiColumnComboBoxElement.DropDownWidth = 400
        Me.mcc_findaccount.MultiColumnComboBoxElement.DropDownHeight = 400

        'mcc_findaccount.AutoSizeDropDownToBestFit = True
        'mcc_findaccount.BestFitColumns(True, True)

        mcc_findaccount.DisplayMember = "fullname"
        mcc_findaccount.ValueMember = "id"
        mcc_findaccount.DataSource = CreateDataTable()

        mcc_findaccount.AutoFilter = True
        Dim compositeFilter As New CompositeFilterDescriptor()
        Dim username As New FilterDescriptor("username", FilterOperator.Contains, "")
        Dim fullname As New FilterDescriptor("fullname", FilterOperator.Contains, "")
        compositeFilter.FilterDescriptors.Add(username)
        compositeFilter.FilterDescriptors.Add(fullname)
        compositeFilter.LogicalOperator = FilterLogicalOperator.[Or]
        mcc_findaccount.EditorControl.FilterDescriptors.Add(compositeFilter)


        mcc_findaccount.Text = ""
    End Sub
#End Region
    Private Sub Frm_user_control_maintenace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        Try
            fill_search_mcc()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
        End Try

        userlist_listview_column()
        glomod.populate_listview_progress_status(lv_useraccountlist, "p_ais_usercontrol_maintenance 0", 4, "Please Wait...", "p_ais_usercontrol_maintenance 1")
    End Sub

    Public Function CreateDataTable() As DataTable
        Dim dt As New DataTable()
        Try
            sql = ""
            sql = "p_ais_usercontrol_maintenance 3"


            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using SqlDataAdapter As New SqlDataAdapter
                    sqlCmd.Connection = sqlCnn
                    SqlDataAdapter.SelectCommand = sqlCmd
                    SqlDataAdapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception

        End Try
        Return dt
    End Function


    Private Sub lv_useraccountlist_MouseDown(sender As Object, e As MouseEventArgs) Handles lv_useraccountlist.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.cms_usermenu.Show(Me, Me.PointToClient(MousePosition))
        End If
    End Sub

    Private Sub lv_useraccountlist_CellFormatting(sender As Object, e As UI.ListViewCellFormattingEventArgs) Handles lv_useraccountlist.CellFormatting
        user_maintenance_view.lv_cellformatting(e)
    End Sub

    Private Sub refreshuser_Click(sender As Object, e As EventArgs) Handles refreshuser.Click
        mcc_findaccount.Text = ""
        glomod.populate_listview(lv_useraccountlist, "p_ais_usercontrol_maintenance 0", 4)
    End Sub

    Private Sub lv_useraccountlist_SelectedItemChanged(sender As Object, e As EventArgs) Handles lv_useraccountlist.SelectedItemChanged
        usercontrol_id = glomod.selection_listview(lv_useraccountlist)
    End Sub

    Private Sub assignedpermissionuser_Click(sender As Object, e As EventArgs) Handles assignedpermissionuser.Click
        If lv_useraccountlist.SelectedItems.Count > 0 Then
            'Dim Frm_user_control_permission As New Frm_user_control_permission
            With lv_useraccountlist.SelectedItems(0)
                Frm_user_control_permission.txt_searchuser.Text = "USERNAME:  (" + .SubItems(2) + ") -  FULLNAME:  (" + .SubItems(4) + ")"
            End With
        End If

        Me.Enabled = False
        Frm_user_control_permission.Show()
    End Sub

    Private Sub Frm_user_control_maintenace_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        ' Dim frm = New Frm_main
        Frm_main.access_enabled()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        search_id = mcc_findaccount.SelectedValue

        If search_id <> Nothing Then
            glomod.populate_listview(lv_useraccountlist, "p_ais_usercontrol_maintenance 2,'" & search_id & "'", 4)
        End If
    End Sub

    Private Sub mcc_findaccount_DropDownClosed(sender As Object, args As RadPopupClosedEventArgs) Handles mcc_findaccount.DropDownClosed
        btn_search.PerformClick()
    End Sub

    Private Sub mcc_findaccount_EditorControl_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles mcc_findaccount.EditorControl.CellFormatting
        If (TypeOf e.CellElement.RowElement Is GridDataRowElement) Then
            e.CellElement.DrawFill = False
            e.CellElement.DrawBorder = False
        Else
            e.CellElement.ResetValue(LightVisualElement.DrawBorderProperty, Telerik.WinControls.ValueResetFlags.Local)
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If
    End Sub

    Private Sub mcc_findaccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcc_findaccount.SelectedIndexChanged
        btn_search.PerformClick()
    End Sub

    Private Sub mcc_findaccount_KeyUp(sender As Object, e As KeyEventArgs) Handles mcc_findaccount.KeyUp
        If e.KeyCode = Keys.Escape Then
            mcc_findaccount.Text = ""
            search_id = Nothing
            refreshuser.PerformClick()
            lv_useraccountlist.Focus()
        End If
    End Sub

    Private Sub mcc_findaccount_Leave(sender As Object, e As EventArgs) Handles mcc_findaccount.Leave
        If mcc_findaccount.Text = "" Then
            mcc_findaccount.Text = ""
            search_id = Nothing
            refreshuser.PerformClick()
            lv_useraccountlist.Focus()
        End If
    End Sub

    Private Sub btn_search_MouseHover(sender As Object, e As EventArgs) Handles btn_search.MouseHover
        glomod.btn_forecolor(btn_search, 0)
    End Sub

    Private Sub btn_search_MouseLeave(sender As Object, e As EventArgs) Handles btn_search.MouseLeave
        glomod.btn_forecolor(btn_search, 1)
    End Sub
End Class
