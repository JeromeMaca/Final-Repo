Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Frm_lotbylot
    Dim print_glomod As New print_global_module

    Dim dbConn As SqlConnection
    Dim connStr As String = My.Settings.Conn_string
    Dim sqlCmd As New SqlCommand
    Dim sqlDa As New SqlDataAdapter
    Dim dt As New DataTable
    Dim sqlDr As SqlDataReader
    Dim strQuery As String = ""
    Dim i As Integer = 0

    Private Sub btn_preview_Click(sender As Object, e As EventArgs) Handles btn_preview.Click
        view_report()
    End Sub

    Sub view_report()
        rv_lotbylot.ProcessingMode = ProcessingMode.Local

        With rv_lotbylot.LocalReport
            .ReportPath = "System\All Reports RDLC\main_reports_lotbylot.rdlc"
        End With

        Dim dsCustomers As Main_Reports = dataset_fillingup("p_ais_main_report_lotbylot", "lotbylot_report")
        Dim datasource As New ReportDataSource("lotbylot_report", dsCustomers.Tables("lotbylot_report"))


        With rv_lotbylot
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(datasource)
            .LocalReport.Refresh()
        End With

        With rv_lotbylot
            .SetDisplayMode(DisplayMode.PrintLayout)
            '.SetDisplayMode(DisplayMode.Normal)
            .ZoomMode = ZoomMode.PageWidth
        End With
    End Sub

    Function dataset_fillingup(str As String, datatable_name As String) As Main_Reports
        dbConn = New SqlConnection(connStr)
        sqlCmd = New SqlCommand(str, dbConn)
        sqlDa.SelectCommand = sqlCmd
        Using dsCustomers As New Main_Reports()
            sqlDa.Fill(dsCustomers, datatable_name)
            Return dsCustomers
        End Using
    End Function
End Class
