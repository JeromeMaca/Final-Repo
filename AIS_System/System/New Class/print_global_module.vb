Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports Telerik.WinControls
Imports Microsoft.Reporting.WinForms
Public Class print_global_module
    Public dbConn As SqlConnection
    Public connStr As String = My.Settings.Conn_string
    Public sqlCmd As New SqlCommand
    Public sqlDa As New SqlDataAdapter
    Public dt As New DataTable
    Public sqlDr As SqlDataReader
    Public strQuery As String = ""
    Public i As Integer = 0


    Public Sub useDB(ByVal sql As String)
        Try
            dbConn = New SqlConnection(connStr)
            sqlCmd = New SqlCommand(sql, dbConn)
            dbConn.Open()
        Catch ex As Exception
            RadMessageBox.Show("Please Contact your Database Administrator." + vbCrLf + ex.Message.ToString, "System Error! ", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Public Function dataset_fillingup(str As String, datatable_name As String) As All_ticket_dataset
        dbConn = New SqlConnection(connStr)
        sqlCmd = New SqlCommand(str, dbConn)
        sqlDa.SelectCommand = sqlCmd
        Using dsCustomers As New All_ticket_dataset()
            sqlDa.Fill(dsCustomers, datatable_name)
            Return dsCustomers
        End Using
    End Function

#Region "FOR REPORTS"
    Public Sub report_path(rpt As ReportViewer, rdlc_name As String)
        With rpt.LocalReport
            .ReportPath = rdlc_name & "" + ".rdlc"
            .DataSources.Clear()
        End With
    End Sub
#End Region

End Class
