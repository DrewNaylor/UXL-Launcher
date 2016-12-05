﻿'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
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


Public Class LaunchApp
#Region "The code in this region is for launching the apps when buttons are pressed."


    Public Shared Sub LaunchAccess()
        ' Launch Microsoft Access. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        Try
            Process.Start(OfficeLocater.fullLauncherCodeString & "MSACCESS.EXE")
            'Catch ex As System.ComponentModel.Win32Exception
            ' If Microsoft Access isn't found in the folder the user chose in the Options window, ask them if they want to
            ' go to the Options window to change it.
            'Dim msgResult As Integer = MessageBox.Show("We couldn't find Microsoft Access in the location specified in the Options window." &
            '" Would you like to open the Options window to change your settings?", "Couldn't find file",
            'MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses to open the Options window, open the Options window to the General tab.
            'If msgResult = DialogResult.Yes Then
            'Dim forceOptionsWindowTab As New aaformOptionsWindow
            'forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
            'forceOptionsWindowTab.ShowDialog()
            'End If
        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet." & vbCrLf &
                "Would you like to file a bug report online?", "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
    End Sub

    Public Shared Sub LaunchExcel()
        ' Launch Microsoft Excel.
        Process.Start(OfficeLocater.fullLauncherCodeString & "EXCEL.EXE")
    End Sub

    Public Shared Sub LaunchInfopath()
        ' Launch Microsoft InfoPath.
        Process.Start(OfficeLocater.fullLauncherCodeString & "INFOPATH.EXE")
    End Sub

    Public Shared Sub LaunchOnenote()
        ' Launch Microsoft Onenote.
        Process.Start(OfficeLocater.fullLauncherCodeString & "ONENOTE.EXE")
    End Sub

    Public Shared Sub LaunchOutlook()
        ' Launch Microsoft Outlook.
        Process.Start(OfficeLocater.fullLauncherCodeString & "OUTLOOK.EXE")
    End Sub

    Public Shared Sub LaunchPowerpoint()
        ' Launch Microsoft Powerpoint.
        Process.Start(OfficeLocater.fullLauncherCodeString & "POWERPNT.EXE")
    End Sub

    Public Shared Sub LaunchSharepointWorkspace()
        ' Launch Microsoft SharePoint Workspace.
        Process.Start(OfficeLocater.fullLauncherCodeString & "GROOVE.EXE")
    End Sub

    Public Shared Sub LaunchPublisher()
        ' Launch Microsoft Publisher.
        Process.Start(OfficeLocater.fullLauncherCodeString & "MSPUB.EXE")
    End Sub

    Public Shared Sub LaunchWord()
        ' Launch Microsoft Word.
        Process.Start(OfficeLocater.fullLauncherCodeString & "WINWORD.EXE")
    End Sub

    Public Shared Sub LaunchQuery()
        ' Launch Microsoft Query.
        Process.Start(OfficeLocater.fullLauncherCodeString & "MSQRY32.EXE")
    End Sub

    Public Shared Sub LaunchClipOrganizer()
        ' Launch Microsoft Clip Organizer.
        Process.Start(OfficeLocater.fullLauncherCodeString & "MSTORE.EXE")
    End Sub

    Public Shared Sub LaunchPictureManager()
        ' Launch Microsoft Picture Manager.
        Process.Start(OfficeLocater.fullLauncherCodeString & "OIS.EXE")
    End Sub

    Public Shared Sub LaunchOnenoteQuickLaunch()
        ' Launch Microsoft OneNote Quick Launcher.
        Process.Start(OfficeLocater.fullLauncherCodeString & "ONENOTEM.EXE")
    End Sub

    Public Shared Sub LaunchOfficeLangPrefs()
        ' Launch Office Language Preferences.
        Process.Start(OfficeLocater.fullLauncherCodeString & "SETLANG.EXE")
    End Sub




#End Region
End Class
