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
        'Dim str = "p_ais_job_ticket_scheduled_printing_info '" & id & "'"
        Dim ds1 = p_glomod.dataset_fillingup("SELECT REPLICATE('0', 6 - LEN(job_ticket_no)) + CAST(job_ticket_no AS varchar) as job_ticket_no,date_needed FROM tbl_ais_job_ticket_schedule_hdr WHERE id ='" & id & "'", "scheduled_ticket")
        Dim ds12 = p_glomod.dataset_fillingup("SELECT lot_no,location,operation_performed,curr_area FROM tbl_ais_job_ticket_schedule_dtl_lots WHERE hdr_id ='" & id & "'", "lots_ticket")
        ds1.Merge(ds12)


        job_ticket_objdatasource.DataSource = ds1
        job_ticket_objdatasource.DataMember = "scheduled_ticket"

        job_ticket_lots.DataSource = ds12
        job_ticket_lots.DataMember = "lots_ticket"
    End Sub
End Class