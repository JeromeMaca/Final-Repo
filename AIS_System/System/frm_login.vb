﻿Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports AIS_System.System_mod
Imports AIS_System.User_Accounts_view
Imports AIS_System.security_mod
Imports System.IO

Public Class frm_login

    Dim sysmod As New System_mod
    Dim useraccount As New User_Accounts_view
    Dim secmod As New security_mod
    Dim glomod As New global_mod
    Private Sub defaultT_Click(sender As Object, e As EventArgs) Handles defaultT.Click
        Me.ThemeName = ""
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub aqua_Click(sender As Object, e As EventArgs) Handles aqua.Click
        Me.ThemeName = "Aqua"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub desert_Click(sender As Object, e As EventArgs) Handles desert.Click
        Me.ThemeName = "Desert"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub breeze_Click(sender As Object, e As EventArgs) Handles breeze.Click
        Me.ThemeName = "Breeze"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub
    Private Sub MetroT_Click(sender As Object, e As EventArgs) Handles MetroT.Click
        Me.ThemeName = "TelerikMetro"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub MetroBT_Click(sender As Object, e As EventArgs) Handles MetroBT.Click
        Me.ThemeName = "TelerikMetroBlue"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub LightT_Click(sender As Object, e As EventArgs) Handles LightT.Click
        Me.ThemeName = "VisualStudio2012Light"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub DarkT_Click(sender As Object, e As EventArgs) Handles DarkT.Click
        Me.ThemeName = "VisualStudio2012Dark"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub LightT2_Click(sender As Object, e As EventArgs) Handles LightT2.Click
        Me.ThemeName = "Office2013Light"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub darkT2_Click(sender As Object, e As EventArgs) Handles darkT2.Click
        Me.ThemeName = "Office2013Dark"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub
    Private Sub win7_Click(sender As Object, e As EventArgs) Handles win7.Click
        Me.ThemeName = "Windows7"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub win8_Click(sender As Object, e As EventArgs) Handles win8.Click
        Me.ThemeName = "Windows8"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub office2010blue_Click(sender As Object, e As EventArgs) Handles office2010blue.Click
        Me.ThemeName = "Office2010Blue"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub office2010silver_Click(sender As Object, e As EventArgs) Handles office2010silver.Click
        Me.ThemeName = "Office2010Silver"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub office2010black_Click(sender As Object, e As EventArgs) Handles office2010black.Click
        Me.ThemeName = "Office2010Black"
        ThemeResolutionService.ApplicationThemeName = Me.ThemeName

        With My.Settings
            .global_themes = Me.ThemeName
            .Save()
        End With
    End Sub

    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeResolutionService.ApplicationThemeName = My.Settings.global_themes


        glomod.centering_form(Me)
        ' DECRYPTION

        'secmod.filepathtobedecrypt()
        'secmod.decryption()

        'If secmod.err_catcher <> 53 Then
        '    Dim ctr = 0
        '    ctr += 1
        '    If ctr = 1 Then
        '        Application.Restart()
        '    End If
        'End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click


        useraccount.logging_in(Replace(Trim(Me.txt_username.Text), "'", "`"), Replace(Trim(Me.txt_password.Text), "'", "`"))

        If msgstats = 2 Then
            glomod.msgbox_theme()
            RadMessageBox.Show(usermsg, "AIS: Successfully", MessageBoxButtons.OK, RadMessageIcon.Info)
            Frm_main.Show()
            Me.Hide()

            'ENCRYPTION

            'secmod.filepathtobeencrypt()
            'secmod.encryption()
        Else
            glomod.msgbox_theme()
            RadMessageBox.Show(usermsg, "AIS: Unsuccessful", MessageBoxButtons.OK, RadMessageIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub btn_database_Click(sender As Object, e As EventArgs) Handles btn_database.Click
        Frm_databaseConnection.Show()
        Me.Hide()
    End Sub

    Private Sub frm_login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.btn_login.PerformClick()
        End If
    End Sub

    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.btn_login.PerformClick()
        End If
    End Sub

    Private Sub btn_database_MouseHover(sender As Object, e As EventArgs) Handles btn_login.MouseHover, btn_database.MouseHover
        glomod.btn_forecolor(sender, 0)
    End Sub

    Private Sub btn_database_MouseLeave(sender As Object, e As EventArgs) Handles btn_login.MouseLeave, btn_database.MouseLeave
        glomod.btn_forecolor(sender, 1)
    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged, txt_password.TextChanged
        txt_username.TabStop = True
        txt_password.TabStop = True
        btn_login.TabStop = True
        btn_database.TabStop = True
        sbtn_themes.TabStop = True
    End Sub
End Class
