Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class Frm_emodequipment
    Dim glomod As New global_mod
    Dim sysmod As New System_mod

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

    End Sub
End Class
