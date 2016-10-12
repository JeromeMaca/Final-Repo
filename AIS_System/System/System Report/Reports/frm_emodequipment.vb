Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class Frm_emodequipment
    Dim print_glomod As New print_global_module
    Dim glomod As New global_mod

    Dim dbConn As SqlConnection
    Dim connStr As String = My.Settings.Conn_string
    Dim sqlCmd As New SqlCommand
    Dim sqlDa As New SqlDataAdapter
    Dim dt As New DataTable
    Dim sqlDr As SqlDataReader
    Dim strQuery As String = ""
    Dim i As Integer = 0

    Sub view_report()
        rv_emod_tractors.ProcessingMode = ProcessingMode.Local

        With rv_emod_tractors.LocalReport
            .ReportPath = "System\All Reports RDLC\main_reports_emod_tractors.rdlc"
        End With

        Dim dsCustomers As Main_Reports = dataset_fillingup("p_ais_main_report_emod_tractors '0'", "emodtractors_report")
        Dim datasource As New ReportDataSource("emodtractors_report", dsCustomers.Tables("emodtractors_report"))


        With rv_emod_tractors
            .LocalReport.DataSources.Clear()
            .LocalReport.DataSources.Add(datasource)
            .LocalReport.Refresh()
        End With

        With rv_emod_tractors
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

    Private Sub Frm_emodequipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glomod.populate_dropdown(dp_cropyear, "SELECT DISTINCT crop_year FROM v_ais_location_maindata ORDER BY crop_year DESC")
    End Sub

    Private Sub dp_cropyear_SelectedValueChanged(sender As Object, e As EventArgs) Handles dp_cropyear.SelectedValueChanged
        Dim year = dp_cropyear.Text.Split("-").ToArray

        For i As Integer = 0 To year.Length - 0
            MsgBox(year(i).ToString)
        Next
    End Sub

    Private Sub dp_cropyear_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles dp_cropyear.SelectedIndexChanged
        Dim start_year As String = ""
        Dim year = dp_cropyear.Text.Split("-").ToArray

        For i As Integer = 0 To year.Length - 1
            If i = 1 Then
                If year(0) < year(1) Then
                    start_year = year(0).ToString
                End If
            End If
        Next

        startdate_as_of = "January 1, " & start_year & ""
    End Sub

    Private Sub btn_preview_Click(sender As Object, e As EventArgs) Handles btn_preview.Click
        view_report()
    End Sub
End Class
