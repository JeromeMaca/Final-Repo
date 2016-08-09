Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Public Class Frm_canepoint_aprroved_reviewandprinting

    Dim sysmod As New System_mod
    Dim glomod As New global_mod
    Private Sub Frm_canepoint_aprroved_reviewandprinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        'Me.ReportViewer1.RefreshReport()

        review_data()
    End Sub

    Private Sub Frm_canepoint_aprroved_reviewandprinting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub


    Sub review_data()
        Dim i As Integer = 0
        sysmod.strQuery = "p_ais_canepoint_main_approved_reviewandprinting " & slct_id_canepoint_mainapproved & ""
        sysmod.useDB(sysmod.strQuery)
        sysmod.dr = sysmod.sqlCmd.ExecuteReader()

        If sysmod.dr.HasRows Then
            While sysmod.dr.Read()
                Dim str_resut = sysmod.dr.Item(0).ToString()
                Select Case i
                    Case 0
                        txt_cp_no.Text = str_resut
                    Case 1
                        txt_dateneeded.Text = str_resut
                    Case 2
                        txt_receivingbarrio.Text = str_resut
                    Case 3
                        txt_receivingowner.Text = str_resut
                    Case 4
                        txt_total_canepoint_count.Text = str_resut
                    Case 5
                        txt_source_barrio.Text = str_resut
                    Case 6
                        txt_source_owner.Text = str_resut
                    Case 7
                        txt_source_lotno.Text = str_resut
                    Case 8
                        txt_source_variety.Text = str_resut
                    Case 9
                        txt_validity_date.Text = str_resut
                    Case 10
                        txt_canepointcost.Text = str_resut
                    Case 11
                        txt_haulingcost.Text = str_resut
                    Case 12
                        txt_receivables.Text = str_resut
                End Select

                i += 1
            End While
        End If
        sysmod.dbConn.Close()
    End Sub
End Class
