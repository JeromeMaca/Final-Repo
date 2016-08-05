Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Docking

Public Class Frm_canepoint_request_update

    Dim glomod As New global_mod
    Dim sysmod As New System_mod
    Dim resultvalidation As Integer = 0

#Region "OTHER FUNCTIONS"
    Private Sub clearcontrol()
        For Each ctrl As Control In RadGroupBox1.Controls
            If TypeOf (ctrl) Is RadDropDownList Then
                Dim a As RadDropDownList = ctrl
                a.Text = ""
                a.NullText = "<Required>"
            End If

            If TypeOf (ctrl) Is RadSpinEditor Then
                Dim a As RadSpinEditor = ctrl
                a.Value = 0
            End If

            If TypeOf (ctrl) Is RadDateTimePicker Then
                Dim a As RadDateTimePicker = ctrl
                a.Value = server_datetime
            End If
        Next
        resultvalidation = 0
    End Sub
    Private Sub validationcontrol()
        Dim i As Integer = 0
        Dim f As Integer = 0
        Dim g As Integer = 0
        For Each ctrl As Control In RadGroupBox1.Controls
            'For Each b As Control In ctrl.Controls
            If TypeOf (ctrl) Is RadSpinEditor Then
                Dim s As RadSpinEditor = ctrl

                If s.Value = 0 Then
                    'RadMessageBox.Show("Invalid Value for Canepoints Count", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Else
                    g += 1
                End If
            End If


            If TypeOf (ctrl) Is RadDropDownList Then
                Dim a As RadDropDownList = ctrl

                If a.Text = "" Or a.Text = "Null" Then
                    a.NullText = "REQUIRED DATA HERE!!!"
                    i += 1
                Else
                    If (f > 0 And i = 0 And g <> 0) Then
                        resultvalidation = 1
                    End If
                End If
                f += 1
            End If
            'Next
        Next
    End Sub
#End Region

    Private Sub Frm_canepoint_request_update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
    End Sub

    Private Sub Frm_canepoint_request_update_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True

        glomod.populate_listview(Frm_canepointreceipt_NEW.lv_request_canepoint, "p_ais_canepoint_main_datas " & user_id & ",0", 8)
        glomod.data_item_grouping(Frm_canepointreceipt_NEW.lv_request_canepoint, "date_req")

        glomod.data_item_selected_zero(Frm_canepointreceipt_NEW.lv_request_canepoint, 1)
        slct_id_canepoint_main_request = 0
    End Sub

    Private Sub btn_saveupdate_Click(sender As Object, e As EventArgs) Handles btn_saveupdate.Click
        validationcontrol()
        If resultvalidation = 1 Then
            If (glomod.confirmation_msg()) = Windows.Forms.DialogResult.Yes Then
                glomod.add_update_data("UPDATE tbl_ais_canepoint_hdr SET date_needed='" & dt_dateneeded.Value & "',receiving_barrio='" & dp_location.Text & "'" _
                                       & ",receiving_owner='" & dp_receiving_owner.Text & "',total_canepoint=" & se_total_canepoints.Value & " WHERE id = '" & slct_id_canepoint_main_request & "'")
                clearcontrol()
            End If
        Else
            If se_total_canepoints.Value <= 500 Or dp_location.Text = "" Or dp_receiving_owner.Text = "" Then
                RadMessageBox.Show("Some information field need to be fill in to proceed. or Canepoint Count value is not Valid.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        End If
        slct_id_canepoint_main_request = 0
    End Sub
End Class
