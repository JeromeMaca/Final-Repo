Imports System.Data.SqlClient
Imports Telerik.WinControls

Public Class User_Accounts_view
    Dim sysmod As New System_mod
    Public Sub logging_in(username, password)
        Try
            If username = "" And password = "" Then
                'empno.Text = ""
                'req_empno.IsValid = False
                usermsg = "Enter your Username and Password"

            ElseIf password = "" Then
                'pword.Text = ""
                'req_pword.IsValid = False
                usermsg = "Enter your Password"
            ElseIf username = "" Then
                'empno.Text = ""
                'req_empno.IsValid = False
                'pword.Text = ""
                'req_pword.IsValid = False
                usermsg = "Enter your Username "
            Else
                Try
                    'Dim pwordhash = sysmod.GenerateHash(password)

                    sysmod.strQuery = "SELECT TOP 1 * FROM jcso.dbo.tbl_com_useraccounts WHERE username = '" & username & "' AND Password = '" & password & "'"
                    sysmod.useDB(sysmod.strQuery)
                    sysmod.resultNum = sysmod.sqlCmd.ExecuteScalar
                    If sysmod.resultNum <> 0 Then

                        sysmod.dr = sysmod.sqlCmd.ExecuteReader
                        sysmod.dr.Read()
                        Dim usern = sysmod.dr.Item("username").ToString()
                        Dim userp = sysmod.dr.Item("Password").ToString()
                        sysmod.dr.Close()
                        sysmod.sqlCmd.Dispose()
                        sysmod.dbConn.Close()

                        If usern = username And userp = password Then
                            sysmod.useDB(sysmod.strQuery)
                            sysmod.dr = sysmod.sqlCmd.ExecuteReader
                            sysmod.dr.Read()
                            user_id = sysmod.dr.Item("id").ToString()
                            Dim fullname = sysmod.dr.Item("fullname").ToString()
                            'Dim namel = sysmod.dr.Item("user_lname").ToString()
                            'Dim namef = sysmod.dr.Item("user_fname").ToString()
                            'Dim namem = sysmod.dr.Item("user_mname").ToString()

                            sysmod.dr.Close()
                            sysmod.sqlCmd.Dispose()
                            sysmod.dbConn.Close()

                            msgstats = 2
                            'usermsg = "Welcome: " & namel & ", " & namef & " " & namem & " " & vbCrLf & "You've Successfully Logging On."
                            'Frm_main.txt_fullname.Text = namel & ", " & namef & " " & namem

                            usermsg = "Welcome: " & fullname & " " & vbCrLf & "You've Successfully Logging On."
                            Frm_main.txt_fullname.Text = fullname
                        Else
                            usermsg = "The Username or Password you entered did not match any record in our data. Please double check and try again!"
                        End If
                    Else
                        usermsg = "The Username or Password you entered did not match any record in our data. Please double check and try again!"
                    End If
                Catch ex As Exception
                    RadMessageBox.Show(ex.Message.ToString)
                End Try

            End If
        Catch ex As SqlException
            RadMessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

End Class
