﻿Imports Telerik.WinControls


Public Class Frm_main
    Dim sysmod As New System_mod
    Dim secmod As New security_mod

    Private Sub Frm_main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If RadMessageBox.Show("Are you sure you want to Close the System?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes
        sysmod.Server_time()

        Me.IsMdiContainer = True
        Me.raddock.AutoDetectMdiChildren = True

        'ACCESS
        'winform_class.enableddisabled_menuaccess(user_id)
    End Sub

    Private Sub subtripticket_Click(sender As Object, e As EventArgs) Handles subtripticket.Click
        ' winform_class.enableddisabled_menuaccess(user_id)
        Frm_trip_ticket_NEWS.Text = "Trip Tickets"
        Frm_trip_ticket_NEWS.MdiParent = Me
        Frm_trip_ticket_NEWS.Show()

    End Sub

    Private Sub subjobticket_Click(sender As Object, e As EventArgs) Handles subjobticket.Click
        'winform_class.enableddisabled_menuaccess(user_id)
        Frm_job_ticket_NEW.Text = "Job Tickets"
        Frm_job_ticket_NEW.MdiParent = Me
        Frm_job_ticket_NEW.Show()
    End Sub

    Private Sub subrequisition_Click(sender As Object, e As EventArgs)
        'winform_class.enableddisabled_menuaccess(user_id)
        'Frm_ris.Text = "Requisition And Issuance Slip"
        'Frm_ris.MdiParent = Me
        'Frm_ris.Show()
    End Sub

    Private Sub subcanepoint_Click(sender As Object, e As EventArgs) Handles subcanepoint.Click
        Frm_canepointreceipt_NEW.Text = "Cane Points"
        Frm_canepointreceipt_NEW.MdiParent = Me
        Frm_canepointreceipt_NEW.Show()
    End Sub


    'Data Maintenance
    'Private Sub subplanters_Click(sender As Object, e As EventArgs) Handles subplanters.Click
    '    Frm_planters.Text = "Planters Maintenace"
    '    Frm_planters.MdiParent = Me
    '    Frm_planters.Show()
    'End Sub

    Private Sub sublocations_Click(sender As Object, e As EventArgs) Handles sublocations.Click
        'winform_class.enableddisabled_menuaccess(user_id)
        Frm_master_list_location.Text = "Area Locations"
        Frm_master_list_location.MdiParent = Me
        Frm_master_list_location.Show()
    End Sub

    Private Sub suboperation_Click(sender As Object, e As EventArgs) Handles suboperation.Click
        winform_class.enableddisabled_menuaccess(user_id)
        Me.main_loadingpogressbar.Visibility = ElementVisibility.Visible
        Frm_master_list_work_operation.Text = "Work Operation"
        Frm_master_list_work_operation.MdiParent = Me
        Frm_master_list_work_operation.Show()
    End Sub

    Private Sub subequipment_Click(sender As Object, e As EventArgs) Handles subequipment.Click
        'winform_class.enableddisabled_menuaccess(user_id)
        Frm_master_list_equipment.Text = "Equipments"
        Frm_master_list_equipment.MdiParent = Me
        Frm_master_list_equipment.Show()
    End Sub

    Private Sub subimplementation_Click(sender As Object, e As EventArgs) Handles subimplementation.Click
        'winform_class.enableddisabled_menuaccess(user_id)
        Frm_masterlist_implements.Text = "Implements"
        Frm_masterlist_implements.MdiParent = Me
        Frm_masterlist_implements.Show()
    End Sub

    Private Sub subotheritem_Click(sender As Object, e As EventArgs) Handles subotheritem.Click
        ' winform_class.enableddisabled_menuaccess(user_id)
        Frm_master_list_other.Text = "Other"
        Frm_master_list_other.MdiParent = Me
        Frm_master_list_other.Show()
    End Sub

    Private Sub tp_timer_Tick(sender As Object, e As EventArgs) Handles tp_timer.Tick
        sysmod.Server_time()
    End Sub

    Private Sub menuitemlotstatus_Click(sender As Object, e As EventArgs) Handles menuitemlotstatus.Click
        ' winform_class.enableddisabled_menuaccess(user_id)
        Frm_lot_by_lot_monitoring.Text = "Lot Status Monitoring"
        Frm_lot_by_lot_monitoring.MdiParent = Me
        Frm_lot_by_lot_monitoring.Show()
    End Sub

    Private Sub menuitemtripticket_Click(sender As Object, e As EventArgs) Handles menuitemtripticket.Click
        winform_class.enableddisabled_menuaccess(user_id)
        Frm_trip_ticket_monitoring.Text = "Trip Ticket Monitoring"
        Frm_trip_ticket_monitoring.MdiParent = Me
        Frm_trip_ticket_monitoring.Show()
    End Sub
    Private Sub subuseraccount_Click(sender As Object, e As EventArgs) Handles subuseraccount.Click
        ' winform_class.enableddisabled_menuaccess(user_id)
        'Frm_user_control_maintenace.Text = "User Authorization Management"
        'Frm_user_control_maintenace.MdiParent = Me
        Frm_user_control_maintenace.Show()
        Me.Enabled = False

        ''''''''''USER CONTOL
    End Sub
End Class
