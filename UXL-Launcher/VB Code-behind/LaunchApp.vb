﻿' UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
' Copyright (C) 2013-2021 Drew Naylor
' Microsoft Office and all related words are copyright
' and trademark Microsoft Corporation. More details in the About window.
' Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor
' and does not endorse this software.
' Any other companies mentioned own their respective copyrights/trademarks.
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is part of UXL Launcher
' (Program is also known as "Unified eXecutable Launcher." Not to be confused with
' other software titled "[Kindle] Unified Application Launcher",
' "UX Launcher" [an Android launcher], or "Ulauncher" [a Linux app launcher].)
'
'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.


Public Class LaunchApp
#Region "The code in this region is for launching the apps when buttons are pressed."
#Region "Microsoft Access Launcher Code."
    Public Shared Sub LaunchAccess()
        ' Launch Microsoft Access. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        isolated_error_handler.launcherErrorHandler("MSACCESS.EXE", "Microsoft Access", My.Settings.bypassConfiguredLocationForAllApps)

    End Sub
#End Region
#Region "Microsoft Excel Launcher Code."
    Public Shared Sub LaunchExcel()
        ' Launch Microsoft Excel. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        isolated_error_handler.launcherErrorHandler("EXCEL.EXE", "Microsoft Excel", My.Settings.bypassConfiguredLocationForAllApps)

    End Sub
#End Region
#Region "Microsoft InfoPath Launcher Code."
    Public Shared Sub LaunchInfopath()
        ' Launch Microsoft Infopath. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        If My.Settings.bypassConfiguredLocationForDeprecatedApps = True Or My.Settings.bypassConfiguredLocationForAllApps = True Then
            isolated_error_handler.launcherErrorHandler("INFOPATH.EXE", "Microsoft InfoPath", True)
            ' Otherwise, don't.
        Else
            isolated_error_handler.launcherErrorHandler("INFOPATH.EXE", "Microsoft InfoPath")
        End If

    End Sub
#End Region
#Region "Microsoft OneNote Launcher Code."
    Public Shared Sub LaunchOnenote()
        ' Launch Microsoft Onenote. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        If My.Settings.bypassConfiguredLocationForDeprecatedApps = True Or My.Settings.bypassConfiguredLocationForAllApps = True Then
            isolated_error_handler.launcherErrorHandler("ONENOTE.EXE", "Microsoft OneNote", True)
            ' Otherwise, don't.
        Else
            isolated_error_handler.launcherErrorHandler("ONENOTE.EXE", "Microsoft OneNote")
        End If

    End Sub
#End Region
#Region "Microsoft Outlook Launcher Code."
    Public Shared Sub LaunchOutlook()
        ' Launch Microsoft Outlook. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        isolated_error_handler.launcherErrorHandler("OUTLOOK.EXE", "Microsoft Outlook", My.Settings.bypassConfiguredLocationForAllApps)

    End Sub
#End Region
#Region "Microsoft PowerPoint Launcher Code."
    Public Shared Sub LaunchPowerpoint()
        ' Launch Microsoft Powerpoint. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        isolated_error_handler.launcherErrorHandler("POWERPNT.EXE", "Microsoft PowerPoint", My.Settings.bypassConfiguredLocationForAllApps)

    End Sub
#End Region
#Region "Microsoft SharePoint Workspace Launcher Code."
    Public Shared Sub LaunchSharepointWorkspace()
        ' Launch Microsoft Sharepoint Workspace. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        If My.Settings.bypassConfiguredLocationForDeprecatedApps = True Or My.Settings.bypassConfiguredLocationForAllApps = True Then
            isolated_error_handler.launcherErrorHandler("GROOVE.EXE", "Microsoft SharePoint Workspace", True)
            ' Otherwise, don't.
        Else
            isolated_error_handler.launcherErrorHandler("GROOVE.EXE", "Microsoft SharePoint Workspace")
        End If
    End Sub
#End Region
#Region "Microsoft Publisher Launcher Code."
    Public Shared Sub LaunchPublisher()
        ' Launch Microsoft Publisher. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        isolated_error_handler.launcherErrorHandler("MSPUB.EXE", "Microsoft Publisher", My.Settings.bypassConfiguredLocationForAllApps)

    End Sub
#End Region
#Region "Microsoft Word Launcher Code."
    Public Shared Sub LaunchWord()
        ' Launch Microsoft Word. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        isolated_error_handler.launcherErrorHandler("WINWORD.EXE", "Microsoft Word", My.Settings.bypassConfiguredLocationForAllApps)

    End Sub
#End Region
#Region "Microsoft Query Launcher Code."
    Public Shared Sub LaunchQuery()
        ' Launch Microsoft Query. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        isolated_error_handler.launcherErrorHandler("MSQRY32.EXE", "Microsoft Query")
    End Sub
#End Region
#Region "Microsoft Clip Organizer Launcher Code."
    Public Shared Sub LaunchClipOrganizer()
        ' Launch Microsoft Clip Organizer. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        isolated_error_handler.launcherErrorHandler("MSTORE.EXE", "Microsoft Clip Organizer")
    End Sub
#End Region
#Region "Microsoft Office Picture Manager Launcher Code."
    Public Shared Sub LaunchPictureManager()
        ' Launch Microsoft Office Picture Manager. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        ' If the user wants to bypass the configured location, do so.
        If My.Settings.bypassConfiguredLocationForDeprecatedApps = True Or My.Settings.bypassConfiguredLocationForAllApps = True Then
            isolated_error_handler.launcherErrorHandler("OIS.EXE", "Microsoft Office Picture Manager", True)
            ' Otherwise, don't.
        Else
            isolated_error_handler.launcherErrorHandler("OIS.EXE", "Microsoft Office Picture Manager")
        End If
    End Sub
#End Region
#Region "Microsoft OneNote Quick Launch Launcher Code."
    Public Shared Sub LaunchOnenoteQuickLaunch()
        ' Launch Microsoft OneNote Quick Launcher. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        isolated_error_handler.launcherErrorHandler("ONENOTEM.EXE", "Microsoft OneNote Quick Launch")
    End Sub
#End Region
#Region "Office Language Preferences Launcher Code."
    Public Shared Sub LaunchOfficeLangPrefs()
        ' Launch Office Language Preferences. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        isolated_error_handler.launcherErrorHandler("SETLANG.EXE", "Office Language Preferences")
    End Sub
#End Region
#End Region

#Region "New files area"
#Region "Word"
    Public Shared Sub NewWordDoc()
        ' Create a new Word document.
        isolated_error_handler.newFileErrorHandler("WINWORD.EXE", "/w", "Microsoft Word")
    End Sub
#End Region
#Region "Excel"
    Public Shared Sub NewExcelWorkbook()
        ' Create a new Excel workbook.
        isolated_error_handler.newFileErrorHandler("EXCEL.EXE", "/m", "Microsoft Excel")
    End Sub
#End Region
#Region "PowerPoint"
    Public Shared Sub NewPPTPresentation()
        ' Create a new PowerPoint presentation.
        isolated_error_handler.newFileErrorHandler("POWERPNT.EXE", "/b", "Microsoft PowerPoint")
    End Sub
#End Region
#Region "Outlook - New Email"
    Public Shared Sub NewOutlookEmail()
        ' Create a new Outlook email.
        isolated_error_handler.newFileErrorHandler("OUTLOOK.EXE", "/c ipm.note", "Microsoft Outlook")
    End Sub
#End Region
#Region "Outlook - New Contact"
    Public Shared Sub NewOutlookContact()
        ' Create a new Outlook contact.
        isolated_error_handler.newFileErrorHandler("OUTLOOK.EXE", "/c ipm.contact", "Microsoft Outlook")
    End Sub
#End Region
#Region "Publisher"
    Public Shared Sub NewPublisherPublication()
        ' Create a new Publisher publication.
        isolated_error_handler.newFileErrorHandler("MSPUB.EXE", "/b", "Microsoft Publisher")
    End Sub
#End Region
#End Region
End Class
