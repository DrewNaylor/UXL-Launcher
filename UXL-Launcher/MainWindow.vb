﻿'UXL Launcher - Launchers for Microsoft Office apps in one place.
'Copyright (C) 2013-2016  Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of UXL Launcher
'(Program is also known as "Unified eXecutable Launcher." Not to be confused with
'another software titled "[Kindle] Unified Application Launcher".)
'
'UXL Launcher is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'UXL Launcher is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with UXL Launcher.  If not, see <http://www.gnu.org/licenses/>.



Public Class aaformMainWindow
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create a string with the BuildDate.txt file.
        Dim BuildDateString As String = My.Resources.BuildDate

        ' Hide the debugging labels.
        debugLabelForAlwaysOnTop.Hide()

#Region "Debug code for aaformMainWindow."

        ' Debug label for the Always On Top feature.
        debugLabelForAlwaysOnTop.Text = "menubar button checkstate: " & menubarAlwaysOnTopButton.CheckState & vbNewLine &
        "alwaysOnTop setting: " & My.Settings.alwaysOnTop & vbNewLine &
        "main window TopMost: " & Me.TopMost

        ' Debug label for cpuTypeString.


#End Region

#Region "Main form loading code for Always On Top menubar button."

        ' See if the Always On Top setting is set to true and if it is, then set
        ' the window to be on top of other windows.

        If My.Settings.alwaysOnTop = True Then
            menubarAlwaysOnTopButton.CheckState = CheckState.Checked
            Me.TopMost = True

            ' But if the Always On Top setting is false, then set the window to not
            ' be on top of other windows.

        ElseIf My.Settings.alwaysOnTop = False Then
            Me.TopMost = False
            menubarAlwaysOnTopButton.CheckState = CheckState.Unchecked
        End If
#End Region

    End Sub


#Region "Menubar code, including menubar buttons."

    Private Sub menubarExitButton_Click(sender As Object, e As EventArgs) Handles menubarExitButton.Click
        ' End the execution of the app.
        Me.Close()

    End Sub

    Private Sub menubarOptionsButton_Click(sender As Object, e As EventArgs) Handles menubarOptionsButton.Click
        ' Open the Options window.
        aaformOptionsWindow.ShowDialog()
    End Sub

#Region "Always On Top menubar button checkbox and stuff."
    Private Sub menubarAlwaysOnTopButton_Click(sender As Object, e As EventArgs) Handles menubarAlwaysOnTopButton.Click

        ' When the user clicks on the Always On Top menubar button, the following code will run.
        ' First, the app will see if the Always On Top menubar button is unchecked, then it will
        ' check the box for that button.
        ' Then, the app will check to see what My.Settings.alwaysOnTop is set to. If it's set to
        ' False, then the app will set it to True.
        ' After that, My.Settings will be saved.
        ' Later, a debugging label will be updated with the CheckState of the Always On Top button.

        If menubarAlwaysOnTopButton.CheckState = CheckState.Unchecked Then
            menubarAlwaysOnTopButton.CheckState = CheckState.Checked
            Me.TopMost = True
            If My.Settings.alwaysOnTop = False Then
                My.Settings.alwaysOnTop = True
            End If
            My.Settings.Save()
            My.Settings.Reload()

        ElseIf menubarAlwaysOnTopButton.CheckState = CheckState.Checked Then
            menubarAlwaysOnTopButton.CheckState = CheckState.Unchecked
            Me.TopMost = False
            If My.Settings.alwaysOnTop = True Then
                My.Settings.alwaysOnTop = False
            End If
            My.Settings.Save()
            My.Settings.Reload()

        End If

        ' Debug label for the Always On Top feature.
        debugLabelForAlwaysOnTop.Text = "menubar button checkstate: " & menubarAlwaysOnTopButton.CheckState & vbNewLine &
        "alwaysOnTop setting: " & My.Settings.alwaysOnTop & vbNewLine &
        "main window TopMost: " & Me.TopMost

    End Sub
#End Region
#End Region


#Region "App Launcher Code."

    Private Sub buttonRunAccess_Click(sender As Object, e As EventArgs) Handles buttonRunAccess.Click
        ' Run Microsoft Access.
        LaunchApp.LaunchAccess()
    End Sub

    Private Sub buttonRunExcel_Click(sender As Object, e As EventArgs) Handles buttonRunExcel.Click
        ' Run Microsoft Excel.
        LaunchApp.LaunchExcel()
    End Sub

    Private Sub buttonRunInfoPath_Click(sender As Object, e As EventArgs) Handles buttonRunInfoPath.Click
        ' Run Microsoft InfoPath.
        LaunchApp.LaunchInfopath()
    End Sub

    Private Sub buttonRunOneNote_Click(sender As Object, e As EventArgs) Handles buttonRunOneNote.Click
        ' Run Microsoft OneNote.
        LaunchApp.LaunchOnenote()
    End Sub

    Private Sub buttonRunOutlook_Click(sender As Object, e As EventArgs) Handles buttonRunOutlook.Click
        ' Run Microsoft Outlook.
        LaunchApp.LaunchOutlook()
    End Sub

    Private Sub buttonRunPowerPoint_Click(sender As Object, e As EventArgs) Handles buttonRunPowerPoint.Click
        ' Run Microsoft PowerPoint.
        LaunchApp.LaunchPowerpoint()
    End Sub

    Private Sub buttonRunSharePointWkSp_Click(sender As Object, e As EventArgs) Handles buttonRunSharePointWkSp.Click
        ' Run Microsoft SharePoint Workspace.
        LaunchApp.LaunchSharepointWorkspace()
    End Sub

    Private Sub buttonRunPublisher_Click(sender As Object, e As EventArgs) Handles buttonRunPublisher.Click
        ' Run Microsoft Publisher.
        LaunchApp.LaunchPublisher()
    End Sub

    Private Sub buttonRunWord_Click(sender As Object, e As EventArgs) Handles buttonRunWord.Click
        ' Run Microsoft Word.
        LaunchApp.LaunchWord()
    End Sub

    Private Sub buttonRunQuery_Click(sender As Object, e As EventArgs) Handles buttonRunQuery.Click
        ' Run Microsoft Query.
        LaunchApp.LaunchQuery()
    End Sub

    Private Sub buttonRunClipOrganizer_Click(sender As Object, e As EventArgs) Handles buttonRunClipOrganizer.Click
        ' Run Microsoft Clip Organizer.
        LaunchApp.LaunchClipOrganizer()
    End Sub

    Private Sub buttonRunPictureManager_Click(sender As Object, e As EventArgs) Handles buttonRunPictureManager.Click
        ' Run Microsoft Picture Manager.
        LaunchApp.LaunchPictureManager()
    End Sub

    Private Sub buttonRunOneNoteQuickLaunch_Click(sender As Object, e As EventArgs) Handles buttonRunOneNoteQuickLaunch.Click
        ' Run Microsoft OneNote Quick Launcher.
        LaunchApp.LaunchOnenoteQuickLaunch()
    End Sub

    Private Sub menubarOfficeLangPrefsButton_Click(sender As Object, e As EventArgs) Handles menubarOfficeLangPrefsButton.Click
        ' Run Office Language Preferences.
        LaunchApp.LaunchOfficeLangPrefs
    End Sub




#End Region


End Class
