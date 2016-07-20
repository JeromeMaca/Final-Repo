Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class job_ticket_schedule_report
    Inherits Telerik.Reporting.Report
    Public Sub New(id)
        InitializeComponent()

        Dim p_glomod As New print_global_module
        Dim str = "p_ais_job_ticket_scheduled_printing_info '" & id & "'"


        job_ticket_datasource.DataSource = p_glomod.dataset_fillingup(str, "scheduled_ticket_review_for_printing")
    End Sub
End Class