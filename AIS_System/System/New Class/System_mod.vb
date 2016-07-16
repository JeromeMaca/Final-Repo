﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class System_mod
    Public dbConn As New SqlConnection
    'Public ConnStrOut As String = My.Settings.Conn_strings_out 'OTHER DATABASE
    Public connStr As String = My.Settings.Conn_string 'OWN DATABASE
    Public sqlCmd As New SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public tbl As New DataTable
    Public i As Integer
    Public strQuery As String = ""

    Public msgb As Integer
    Public msgS As String
    Public resultNum As Integer = 0

    Public Sub useDB(ByVal sql As String)
        Try
            dbConn = New SqlConnection(connStr)
            sqlCmd = New SqlCommand(sql, dbConn)
            dbConn.Open()

        Catch ex As Exception
            RadMessageBox.Show("Please Contact your Database Administrator." + vbCrLf + ex.Message.ToString, "System Error! ", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Public Sub Server_time()
        Try
            sql = ""
            sql = "SELECT GETDATE()AS datetime,YEAR(getdate()) as yearnow, YEAR(getdate())+ 1 AS yearplusone, YEAR(getdate())+1 as fut_year,YEAR(getdate())+2 as fut_year_plusone"

            Using sqlCnn = New SqlConnection(My.Settings.Conn_string)
                sqlCnn.Open()
                sqlCmd = New SqlCommand(sql, sqlCnn)

                Using sqlReader As SqlDataReader = sqlCmd.ExecuteReader()

                    sqlReader.Read()
                    server_datetime = sqlReader.Item("datetime")
                    fiscal_year = sqlReader.Item("yearnow") & "-" & sqlReader.Item("yearplusone")
                    future_crop_year = sqlReader.Item("fut_year") & "-" & sqlReader.Item("fut_year_plusone")
                End Using
                sqlCmd.Connection.Close()
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message)
        End Try

        Frm_main.txt_actualtime.Text = server_datetime.ToString("MMMM dd yyyy hh:mm:ss tt")
        Frm_main.txt_fiscal.Text = "Crop Year. " & " " & fiscal_year
    End Sub

    Public Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function

    'RADLISTVIEW COLUMN/ITEM FORMATTING
#Region "RAD LISTVIEW FORMATTING"
    Public Sub RadLV_format_global(e)
        'WHOLE HEAD ITEM
        If TypeOf e.CellElement Is DetailListViewHeaderCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleLeft
        Else
            e.CellElement.ResetValue(LightVisualElement.TextAlignmentProperty, Telerik.WinControls.ValueResetFlags.Local)
        End If


        'SPECIFIC NAME HEAD

        'If (e.CellElement).Data.Name = "Count" Then
        '    If (TypeOf e.CellElement Is DetailListViewHeaderCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        '    End If

        '    If (TypeOf e.CellElement Is DetailListViewDataCellElement) Then
        '        e.CellElement.TextAlignment = ContentAlignment.MiddleCenter
        '    End If
        'End If
    End Sub
#End Region

    'OTHER MASTERLIST
#Region "OTHER MASTERLIST"

#Region "OTHER MASTERLIST LOCATION"
    Sub Add_location(prov, mun, loc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_location_list(location,municipality,province) VALUES('" + loc + "','" + mun + "', '" + prov + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_location(prov, mun, loc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_location_list SET province='" & prov & "',municipality ='" & mun & "', location='" & loc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_location(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = MsgBoxResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_location_list WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub
#End Region
    'OPERATION CATEGORY
#Region "OTHER MASTERLIST OPERATION CATEGORY"
    Sub Add_operation_category(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_operation_category(cat_desc) VALUES('" + desc + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_operation_category(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_operation_category SET cat_desc='" & desc & "' WHERE category_id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub
    Sub Delete_operation_category(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_operation_category WHERE category_id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub
#End Region
    'ASSOCIATION
#Region "OTHER MASTERLIST ASSOCIATION"
    Sub Update_association(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_location_association SET sub_desc='" & desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub
#End Region
    'VARIETY / CULTURE
#Region "OTHER MASTERLIST VARIETY"
    Sub Add_variety(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_cane_cultures(culture_desc) VALUES('" + desc + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Add_variety2(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_cane_variety(variety_desc) VALUES('" + desc + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_variety(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_cane_cultures SET culture_desc='" & desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Update_variety2(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_cane_variety SET variety_desc='" & desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_variety(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_cane_cultures WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Sub Delete_variety2(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_cane_variety WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

#End Region
    'SUB CONTRACTOR NAME
#Region "OTHER MASTERLIST SUB CONTRACTOR"
    Sub Add_subcon(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_owner_name(owner_name,id_name) VALUES('" + desc + "','4')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_subcon(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_owner_name SET owner_name='" & desc & "' WHERE id='" & id & "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_subcon(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_owner_name WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub


#End Region

    'EQUIPMENT TYPE
#Region "OTHER MASTERLIST EQUIPMENT TYPE"
    Sub Add_equiptype(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_equipment_type(equipment_type) VALUES('" + desc + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_equiptype(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_equipment_type SET equipment_type='" & desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_equiptype(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_equipment_type WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub


#End Region

    'EQUIPMENT BRAND
#Region "OTHER MASTERLIST EQUIPMENT BRAND"
    Sub Add_equipbrand(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_equipment_brand(equipment_brand) VALUES('" + desc + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_equipbrand(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_equipment_brand SET equipment_brand='" & desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_equipbrand(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_equipment_brand WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub


#End Region

    'EQUIPMENT DRIVER
#Region "OTHER MASTERLIST EQUIPMENT DRIVER"
    Sub Add_driver(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_equipment_driver(driver_name,status) VALUES('" + desc + "','0')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_driver(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_equipment_driver SET driver_name='" & desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_driver(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_equipment_driver WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub


#End Region

    'IMPLEMENT LISST
#Region "OTHER MASTERLIST IMPLEMENT LIST"
    Sub Add_implementlist(desc)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "INSERT INTO tbl_ais_implement_list(description) VALUES('" + desc + "')"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_implementlist(desc, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_implement_list SET description='" & desc & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_implementlist(id)
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_implement_list WHERE id =" & slct_id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If
                other_masterlist_view.location_listview()
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            slct_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub


#End Region
#End Region

    'LOCATION MAIN MASTERLIST
#Region "LOCATION MASTERLIST"

    'MAIN LOCATION
#Region "MAIN LOCATION"
    Sub Add_mainlocation(loc_id, pl_id, assoc_id, old_lot_code, new_lot_code, total_area, cult_id, var_id, soil_id, crop_year, user_id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_main_location_add '" & loc_id & "','" & pl_id & "', '" & assoc_id & "','" & old_lot_code & "','" & new_lot_code & "'" _
                                & ",'" & total_area & "','" & cult_id & "','" & var_id & "','" & soil_id & "','" & crop_year & "','" & user_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_mainlocation(loc_id, pl_id, assoc_id, old_lcode, new_lcode, tot_area, cult_id, var_id, soil_id, crop_year, user_id, item_id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_main_location_update '" & loc_id & "','" & pl_id & "', '" & assoc_id & "','" & old_lcode & "','" & new_lcode & "','" & tot_area & "'" _
                              & ",'" & cult_id & "','" & var_id & "','" & soil_id & "','" & crop_year & "','" & user_id & "','" & item_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_main_loc(id)
        Dim s = """"
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "DELETE FROM tbl_ais_prd_estimates WHERE id =" & id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                    RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)

                    slct_id = Nothing
                End If
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            msgerror = ex.Message.ToString

            If msgerror = "The DELETE statement conflicted with the REFERENCE constraint " & s & "FK_tbl_ais_location_info_tbl_ais_location" & s & ". The conflict occurred in database " & s & "AIS_Database" & s & ", table " & s & "dbo.tbl_ais_location_info" & s & ", column 'lot_id'." & vbCrLf & "The statement has been terminated." Then
                RadMessageBox.Show("Unabled to delete this item because of Data Independency.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Try
    End Sub
#End Region

    'LOCATION INFO
#Region "LOCATION INFO"
    Sub Add_locationinfo(lot_id, date_planted, ownership, variety_id, asso_id, wat_source, fiscal_year, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_insert_location_info_update_main_location '" & lot_id & "','" & date_planted & "','" & ownership & "'," _
                    & "'" & variety_id & "','" & asso_id & "','" & wat_source & "','" & fiscal_year & "','" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_locationinfo(date_planted, ownership, variety_id, asso_id, wat_source, fiscal_year, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_location_info_update '" & date_planted & "','" & ownership & "'," _
                    & "'" & variety_id & "','" & asso_id & "','" & wat_source & "','" & fiscal_year & "','" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As Exception
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to update selected data."
        Else
            msgS = "Successfully Update selected data."
        End If
    End Sub

    Sub Delete_locationinfo(id)
        Dim s = """"
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "p_ais_location_info_delete " & id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                    RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)


                    location_masterlist_view.location_info_listview()
                    slct_id = Nothing
                End If
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            msgerror = ex.Message.ToString

            If msgerror = "The DELETE statement conflicted with the REFERENCE constraint " & s & "FK_tbl_ais_location_info_tbl_ais_location" & s & ". The conflict occurred in database " & s & "AIS_Database" & s & ", table " & s & "dbo.tbl_ais_location_info" & s & ", column 'lot_id'." & vbCrLf & "The statement has been terminated." Then
                RadMessageBox.Show("Unabled to delete this item because of Data Independency.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Try
    End Sub
#End Region

#End Region

    'EQUIPMWNT MASTERLIST
#Region "EQUIPMENT MASTERLIST"

    Sub Add_equipmentmasterlist(owner_id, type_id, model)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_equipment_masterlist_add '" & owner_id & "','" & type_id & "','" & model & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_equipmentmasterlist(owner_id, type_id, model, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_equipment_masterlist_update '" & owner_id & "','" & type_id & "','" & model & "','" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Delete_equipmentmasterlist(id)
        Dim s = """"
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "p_ais_equipment_masterlist_delete " & id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                    RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)

                    slct_id = Nothing
                End If
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            msgerror = ex.Message.ToString

            If msgerror = "The DELETE statement conflicted with the REFERENCE constraint " & s & "FK_tbl_ais_location_info_tbl_ais_location" & s & ". The conflict occurred in database " & s & "AIS_Database" & s & ", table " & s & "dbo.tbl_ais_location_info" & s & ", column 'lot_id'." & vbCrLf & "The statement has been terminated." Then
                RadMessageBox.Show("Unabled to delete this item because of Data Independency.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Try
    End Sub
#End Region

    'IMPLEMENT MASTERLIST
#Region "IMPLEMENT MASTERLIST"

    Sub Add_implementmasterlist(owner_id, imple_id, code, descr)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_implement_masterlist_add '" & owner_id & "','" & imple_id & "', '" & code & "','" & descr & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_implementmasterlist(owner_id, imple_id, code, descr, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_implement_masterlist_update '" & owner_id & "','" & imple_id & "', '" & code & "','" & descr & "','" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Delete_implementmasterlist(id)
        Dim s = """"
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "p_ais_implement_masterlist_delete " & id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With


                    RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)

                    slct_id = Nothing
                End If
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            msgerror = ex.Message.ToString

            If msgerror = "The DELETE statement conflicted with the REFERENCE constraint " & s & "FK_tbl_ais_location_info_tbl_ais_location" & s & ". The conflict occurred in database " & s & "AIS_Database" & s & ", table " & s & "dbo.tbl_ais_location_info" & s & ", column 'lot_id'." & vbCrLf & "The statement has been terminated." Then
                RadMessageBox.Show("Unabled to delete this item because of Data Independency.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Try
    End Sub
#End Region

    'WORK OPERATION MASTERLIST
#Region "WORK OPERATION MASTERLIST"

    Sub Add_workooperationmasterlist(cat_id, operation, unit, rate)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_workoperation_masterlist_add '" & cat_id & "','" & operation & "', '" & unit & "','" & rate & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Update_workoperationmasterlist(cat_id, operation, unit, rate, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_workoperation_masterlist_update '" & cat_id & "','" & operation & "', '" & unit & "','" & rate & "','" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Delete_workoperationmasterlist(id)
        Dim s = """"
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "p_ais_workoperation_masterlist_delete " & id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                    RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)

                    slct_id = Nothing
                End If
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            msgerror = ex.Message.ToString

            If msgerror = "The DELETE statement conflicted with the REFERENCE constraint " & s & "FK_tbl_ais_location_info_tbl_ais_location" & s & ". The conflict occurred in database " & s & "AIS_Database" & s & ", table " & s & "dbo.tbl_ais_location_info" & s & ", column 'lot_id'." & vbCrLf & "The statement has been terminated." Then
                RadMessageBox.Show("Unabled to delete this item because of Data Independency.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Try
    End Sub
#End Region

    'TRIP TICKET
#Region "TRIP TICKET"

#Region "REQUEST FORM"
    Sub Add_requestform(date_req, lot_id, order_id, work_ope_id, userid, needtime, purpose, loc_id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "EXEC p_ais_trip_ticket_request_form_add '" & date_req & "','" & lot_id & "', '" & order_id & "','" & work_ope_id & "','" & userid & "','0','" & needtime & "','" & purpose & "','" & loc_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Delete_request_queued_data(cond, dtl_id, hdr_id, userid)
        Dim s = """"
        Try
            If cond = 0 Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "p_ais_trip_ticket_request_form_delete '" & cond & "','" & hdr_id & "','" & dtl_id & "','" & userid & "'"
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                    RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)


                    request_form_view.requested_form_listview()
                    slct_id = Nothing
                End If
            Else
                If slct_id_req_hdr <> Nothing And slct_id_req_dtl <> Nothing Then
                    If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        dbConn = New SqlConnection(connStr)
                        With sqlCmd
                            .Connection = dbConn
                            .CommandText = "p_ais_trip_ticket_request_form_delete '" & cond & "','" & hdr_id & "','" & dtl_id & "','" & userid & "'"
                            dbConn.Open()
                            .ExecuteNonQuery()
                            dbConn.Close()
                        End With

                        RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)


                        request_form_view.requested_form_listview()
                        slct_id = Nothing
                    End If
                Else
                    RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                End If
            End If



        Catch ex As Exception
            msgerror = ex.Message.ToString

            If msgerror = "The DELETE statement conflicted with the REFERENCE constraint " & s & "FK_tbl_ais_trip_ticket_request_dtl_tbl_ais_trip_ticket_request_hdr" & s & ". The conflict occurred in database " & s & "AIS_Database" & s & ", table " & s & "dbo.tbl_ais_trip_ticket_request_dtl" & s & ", column 'req_hdr_id'." & vbCrLf & "The statement has been terminated." & vbCrLf & "Unexpected error occurred!" Then
                RadMessageBox.Show("Unabled to delete this item because of Data Independency.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Try
    End Sub

    Sub Update_requestform(cat_id, operation, unit, rate, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_workoperation_masterlist_update '" & cat_id & "','" & operation & "', '" & unit & "','" & rate & "','" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub Delete_requestform(id)
        Dim s = """"
        Try
            If slct_id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "p_ais_workoperation_masterlist_delete " & id
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                    RadMessageBox.Show("Successfully deleted the item", "Successfull", MessageBoxButtons.OK, RadMessageIcon.Info)


                    'operation_masterlist_view.work_operation_listview()
                    slct_id = Nothing
                End If
            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
        Catch ex As Exception
            msgerror = ex.Message.ToString

            If msgerror = "The DELETE statement conflicted with the REFERENCE constraint " & s & "FK_tbl_ais_location_info_tbl_ais_location" & s & ". The conflict occurred in database " & s & "AIS_Database" & s & ", table " & s & "dbo.tbl_ais_location_info" & s & ", column 'lot_id'." & vbCrLf & "The statement has been terminated." Then
                RadMessageBox.Show("Unabled to delete this item because of Data Independency.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End Try
    End Sub

    Sub confirm_requestform(user_id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_trip_ticket_request_form_confirm '" & user_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Creating A Request."
        End If
    End Sub
#End Region

#Region "APPROVAL REQUEST"
    Sub approve_request(
                       hdr_id, dtl_id,
                       lot_id, reg_no, trip_ticket_no, trip_date, equip_desc, equipt_type, imple_desc, imple_code,
                       driver, purpose, need_date, need_time, requested_by, approved_by, lot_no, work_operation,
                       approval_equip_id, approval_imple_id, driver_id, user_ids
                       )
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_trip_ticket_approval_add '" & hdr_id & "','" & dtl_id & "','" & lot_id & "','" & reg_no & "','" & trip_ticket_no & "','" & trip_date & "','" & equip_desc & "','" & equipt_type & "','" & imple_desc & "'" _
                                    & ",'" & imple_code & "','" & driver & "','" & purpose & "','" & need_date & "','" & need_time & "','" & requested_by & "','" & approved_by & "','" & lot_no & "'" _
                                    & ",'" & work_operation & "','" & approval_equip_id & "','" & approval_imple_id & "','" & driver_id & "','" & user_ids & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to Approved the selected request."
        Else
            msgS = "Successfully Approved a the selected request."
        End If
    End Sub
#End Region

#Region "PROCESS TRIP TICKET SCHEDULE"
    Sub Update_schedule_dtl(id, started, stopped, operate_hrs, area_done)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_trip_ticket_schedule_dtl SET dtl_stats=1,time_started='" & started & "',time_stopped='" & stopped & "',operate_hours='" & operate_hrs & "'" _
                            & " ,area_done='" & area_done & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With

            sqlCmd.Connection.Close()

        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub count_schedule_dtl(id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "SELECT COUNT(*) FROM v_ais_trip_ticket_schedule_form WHERE hdr_id ='" & id & "' AND dtl_stats='0'"
                dbConn.Open()
                count_remain = .ExecuteScalar()
                dbConn.Close()
            End With

            sqlCmd.Connection.Close()
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
    End Sub

    Sub process_accomplisht(user, hdr, et_out, et_in, arriv, depart, remarks, work_accept, note_by)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "P_AIS_TRIP_TICKET_SCHEDULE_PROCESS '" & user & "','" & hdr & "','" & et_out & "','" & et_in & "','" & arriv & "','" & depart & "','" & remarks & "'" _
                                & ",'" & work_accept & "','" & note_by & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With

            sqlCmd.Connection.Close()
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
    End Sub
#End Region

#Region "ACCOMPLISHED TO BE POST"
    Sub Update_accomplished_review_form(rate_area, total_amount, id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_trip_ticket_schedule_dtl SET rate_per_area='" & rate_area & "', amount='" & total_amount & "' WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify a Data."
        Else
            msgS = "Successfully Modified aa Data."
        End If
    End Sub

    Sub Update_posting_status(id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_trip_ticket_schedule_dtl SET post_status='1' WHERE hdr_id='" & id & "' AND dtl_stats ='2'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify a Data."
        Else
            msgS = "Successfully Modified aa Data."
        End If
    End Sub
    Sub Update_after_posting(id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "UPDATE tbl_ais_trip_ticket_schedule_hdr SET posted_by='" & Frm_main.txt_fullname.Text & "',posted_date=GETDATE() WHERE id='" & id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify a Data."
        Else
            msgS = "Successfully Modified aa Data."
        End If
    End Sub
#End Region
#End Region

    'JOB TICKET
#Region "JOB TICKET"

#Region "CREATE SCHEDULE"
    Sub Add_scheduleform_jt(dateneed, remarks, oic, uid)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "EXEC p_ais_job_ticket_schedule_adding_queue 1,'" & dateneed & "','" & remarks & "','" & oic & "',0,0,0,0,'" & uid & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            RadMessageBox.Show("Successfully Added a New Data.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Sub Add_loclotform_jt(lot_id, operation, hdr_id, uid)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "EXEC p_ais_job_ticket_schedule_adding_queue 2,'','','','" & lot_id & "','" & operation & "','','" & hdr_id & "','" & uid & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            RadMessageBox.Show("Successfully Added a New Data.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Sub Add_manpower_jt(worker_name, hdr_id, uid)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "EXEC p_ais_job_ticket_schedule_adding_queue 3,'','','','','','" & worker_name & "','" & hdr_id & "','" & uid & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            RadMessageBox.Show("Successfully Added a New Data.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Sub Save_queued_lots_manpower_jt(hdr_id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "EXEC p_ais_job_ticket_create_schedule_save_queued_lots_manpower '" & hdr_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            RadMessageBox.Show("Successfully Saved all Data.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

    Sub Save_queued_schedule_data_jt(user_id)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "EXEC p_ais_job_ticket_create_schedule_save_queued_schedule_data '" & user_id & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
                global_error_catcher = ex.Message.ToString
            End If
        End Try
        If msgb = 1 Then
            RadMessageBox.Show(global_error_catcher, "ERROR...", MessageBoxButtons.OK, RadMessageIcon.Error)
        Else
            RadMessageBox.Show("Successfully Saved all Data.", "Operation Done...", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

#End Region
#End Region

    'USER CONTROL
#Region "USER ACCOUNT CONTROL"
    Sub Add_useraccount(username, password, fname, mname, lname, usertype, encodername, index)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_usercontrol_add_modify '" & username & "','" & password & "', '" & fname & "','" & mname & "','" & lname & "','" & usertype & "','" & encodername & "','1','','" & index & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to save a New Data."
        Else
            msgS = "Successfully Added a New Data."
        End If
    End Sub

    Sub update_useraccount(username, password, fname, mname, lname, usertype, encodername, id, index)
        Try
            dbConn = New SqlConnection(connStr)
            With sqlCmd
                .Connection = dbConn
                .CommandText = "p_ais_usercontrol_add_modify '" & username & "','" & password & "', '" & fname & "','" & mname & "','" & lname & "','" & usertype & "','" & encodername & "','2','" & id & "','" & index & "'"
                dbConn.Open()
                .ExecuteNonQuery()
                dbConn.Close()
            End With
        Catch ex As SqlException
            If ex.Message <> Nothing Then
                msgb = 1
            End If
        End Try
        If msgb = 1 Then
            msgS = "Error!!! Unable to Modify Data."
        Else
            msgS = "Successfully Modified a Data."
        End If
    End Sub

    Sub delete_useraccount(id)
        Try
            If id <> Nothing Then
                If RadMessageBox.Show("Are you sure you want to delete selected record?", "WARNING!", MessageBoxButtons.YesNo, RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    dbConn = New SqlConnection(connStr)
                    With sqlCmd
                        .Connection = dbConn
                        .CommandText = "p_ais_usercontrol_add_modify '','','','','','','','3','" & id & "'"
                        dbConn.Open()
                        .ExecuteNonQuery()
                        dbConn.Close()
                    End With

                End If

            Else
                RadMessageBox.Show("No Data Selected.", "AIS: Warning", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            End If
            usercontrol_id = Nothing
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString(), "Reccommend Administrator Assistant", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub
#End Region



End Class
