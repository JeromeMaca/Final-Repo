Imports Microsoft.Reporting.WinForms

Public Class Frm_schedule_printing
    Dim sysmod As New System_mod
    Dim glomod As New global_mod
    Dim print_glomod As New print_global_module

    Private Sub Frm_schedule_printing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        review_data(slct_id_hdr_schedule)
        view_report(slct_id_hdr_schedule)
    End Sub

    Private Sub Frm_schedule_printing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Frm_main.Enabled = True
    End Sub


    Sub review_data(id)
        Try
            Dim i As Integer = 0
            sysmod.strQuery = "p_ais_trip_ticket_main_scheduled_data 2,'" & id & "'"
            sysmod.useDB(sysmod.strQuery)
            sysmod.dr = sysmod.sqlCmd.ExecuteReader()

            If sysmod.dr.HasRows Then
                sysmod.dr.Read()
                For i = 0 To 9
                    Dim str_resut = sysmod.dr.Item(i).ToString()
                    Select Case i
                        Case 0
                            txt_tripticket_no.Text = str_resut
                        Case 1
                            txt_tripdate.Text = str_resut
                        Case 2
                            txt_destination.Text = str_resut
                        Case 3
                            txt_equipment_type.Text = str_resut
                        Case 4
                            txt_equipment_no.Text = str_resut
                        Case 5
                            txt_implement_code.Text = str_resut
                        Case 6
                            txt_driver.Text = str_resut
                        Case 7
                            txt_purpose.Text = str_resut
                        Case 8
                            txt_requestedby.Text = str_resut
                        Case 9
                            txt_approvedby.Text = str_resut
                    End Select
                Next

            End If
            sysmod.dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Sub view_report(id)
        rp_trip_ticket_scheduled.ProcessingMode = ProcessingMode.Local

        With rp_trip_ticket_scheduled.LocalReport
            .ReportPath = "System\All Reports RDLC\trip_ticket_printing_hardcopy.rdlc"
        End With

        Dim dsCustomers As All_ticket_dataset = print_glomod.dataset_fillingup("p_ais_trip_ticket_main_printing_hardcopy '" & id & "'", "tripticket_scheduled")
        Dim datasource As New ReportDataSource("tripticket_scheduled", dsCustomers.Tables("tripticket_scheduled"))


        With rp_trip_ticket_scheduled
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(datasource)
            .LocalReport.Refresh()
        End With

        With rp_trip_ticket_scheduled
            .SetDisplayMode(DisplayMode.PrintLayout)
            '.SetDisplayMode(DisplayMode.Normal)
            .ZoomMode = ZoomMode.PageWidth
        End With
    End Sub
End Class
