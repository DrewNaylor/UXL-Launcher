'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2018 Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation.
'(Note that the copyright years include the years left out by the hyphen.)
'
'Please be aware that UXL Launcher is unofficial and not made by Microsoft.
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

    Public Shared exeFriendlyName As String

#Region "Microsoft Access Launcher Code."
    Public Shared Sub LaunchAccess()
        ' Launch Microsoft Access. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Access"
        isolated_error_handler.launcherErrorHandler("MSACCESS.EXE")
    End Sub
#End Region
#Region "Microsoft Excel Launcher Code."
    Public Shared Sub LaunchExcel()
        ' Launch Microsoft Excel. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Excel"
        isolated_error_handler.launcherErrorHandler("EXCEL.EXE")
    End Sub
#End Region
#Region "Microsoft InfoPath Launcher Code."
    Public Shared Sub LaunchInfopath()
        ' Launch Microsoft Infopath. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft InfoPath"
        isolated_error_handler.launcherErrorHandler("INFOPATH.EXE")
    End Sub
#End Region
#Region "Microsoft OneNote Launcher Code."
    Public Shared Sub LaunchOnenote()
        ' Launch Microsoft Onenote. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft OneNote"
        isolated_error_handler.launcherErrorHandler("ONENOTE.EXE")
    End Sub
#End Region
#Region "Microsoft Outlook Launcher Code."
    Public Shared Sub LaunchOutlook()
        ' Launch Microsoft Outlook. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Outlook"
        isolated_error_handler.launcherErrorHandler("OUTLOOK.EXE")
    End Sub
#End Region
#Region "Microsoft PowerPoint Launcher Code."
    Public Shared Sub LaunchPowerpoint()
        ' Launch Microsoft Powerpoint. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft PowerPoint"
        isolated_error_handler.launcherErrorHandler("POWERPNT.EXE")
    End Sub
#End Region
#Region "Microsoft SharePoint Workspace Launcher Code."
    Public Shared Sub LaunchSharepointWorkspace()
        ' Launch Microsoft Sharepoint Workspace. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft SharePoint Workspace"
        isolated_error_handler.launcherErrorHandler("GROOVE.EXE")
    End Sub
#End Region
#Region "Microsoft Publisher Launcher Code."
    Public Shared Sub LaunchPublisher()
        ' Launch Microsoft Publisher. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Publisher"
        isolated_error_handler.launcherErrorHandler("MSPUB.EXE")
    End Sub
#End Region
#Region "Microsoft Word Launcher Code."
    Public Shared Sub LaunchWord()
        ' Launch Microsoft Word. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Word"
        isolated_error_handler.launcherErrorHandler("WINWORD.EXE")
    End Sub
#End Region
#Region "Microsoft Query Launcher Code."
    Public Shared Sub LaunchQuery()
        ' Launch Microsoft Query. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Query"
        isolated_error_handler.launcherErrorHandler("MSQRY32.EXE")
    End Sub
#End Region
#Region "Microsoft Clip Organizer Launcher Code."
    Public Shared Sub LaunchClipOrganizer()
        ' Launch Microsoft Clip Organizer. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Clip Organizer"
        isolated_error_handler.launcherErrorHandler("MSTORE.EXE")
    End Sub
#End Region
#Region "Microsoft Office Picture Manager Launcher Code."
    Public Shared Sub LaunchPictureManager()
        ' Launch Microsoft Office Picture Manager. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft Office Picture Manager"
        isolated_error_handler.launcherErrorHandler("OIS.EXE", "Microsoft Office Picture Manager")
    End Sub
#End Region
#Region "Microsoft OneNote Quick Launch Launcher Code."
    Public Shared Sub LaunchOnenoteQuickLaunch()
        ' Launch Microsoft OneNote Quick Launcher. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Microsoft OneNote Quick Launch"
        isolated_error_handler.launcherErrorHandler("ONENOTEM.EXE", "Microsoft OneNote Quick Launch")
    End Sub
#End Region
#Region "Office Language Preferences Launcher Code."
    Public Shared Sub LaunchOfficeLangPrefs()
        ' Launch Office Language Preferences. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeFriendlyName = "Office Language Preferences"
        isolated_error_handler.launcherErrorHandler("SETLANG.EXE")
    End Sub
#End Region
#End Region
End Class
