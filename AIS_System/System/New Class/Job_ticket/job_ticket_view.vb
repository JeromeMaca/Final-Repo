Imports Telerik.WinControls.UI

Public Class job_ticket_view
#Region "CLEAR FIELD"
    Shared Sub clear_field_job_ticket_lots()
        For Each tx As Control In Frm_scheduled_encoding_accomplish.gb_lots_menu.Controls
            If TypeOf (tx) Is RadTextBox = True Then
                tx.Text = ""
            End If
        Next

        With Frm_scheduled_encoding_accomplish
            .se_current_area.Value = 0
            .se_actual_area.Value = 0
            .se_remaining_area.Value = 0
        End With
    End Sub

    Shared Sub clear_field_job_ticket_manpower()
        For Each tx As Control In Frm_scheduled_encoding_accomplish.gb_manpower_menu.Controls
            If TypeOf (tx) Is RadTextBox = True Then
                tx.Text = ""
            End If
        Next

        With Frm_scheduled_encoding_accomplish
            .se_hourwork_rt.Value = 0
            .se_hourwork_ot.Value = 0
            .se_hourwork_ot.Value = 0
            '.se_changerate.Value = 0
        End With
    End Sub
#End Region
End Class
