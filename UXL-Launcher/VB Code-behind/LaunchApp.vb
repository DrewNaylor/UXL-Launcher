'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2017  Drew Naylor
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

    Public Shared exeName As String

#Region "Microsoft Access Launcher Code."
    Public Shared Sub LaunchAccess()
        ' Launch Microsoft Access. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "MSACCESS.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft Excel Launcher Code."
    Public Shared Sub LaunchExcel()
        ' Launch Microsoft Excel. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "EXCEL.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft InfoPath Launcher Code."
    Public Shared Sub LaunchInfopath()
        ' Launch Microsoft Infopath. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "INFOPATH.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft OneNote Launcher Code."
    Public Shared Sub LaunchOnenote()
        ' Launch Microsoft Onenote. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "ONENOTE.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft Outlook Launcher Code."
    Public Shared Sub LaunchOutlook()
        ' Launch Microsoft Outlook. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "OUTLOOK.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft PowerPoint Launcher Code."
    Public Shared Sub LaunchPowerpoint()
        ' Launch Microsoft Powerpoint. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "POWERPNT.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft SharePoint Workspace Launcher Code."
    Public Shared Sub LaunchSharepointWorkspace()
        ' Launch Microsoft Sharepoint Workspace. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "GROOVE.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft Publisher Launcher Code."
    Public Shared Sub LaunchPublisher()
        ' Launch Microsoft Publisher. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "MSPUB.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft Word Launcher Code."
    Public Shared Sub LaunchWord()
        ' Launch Microsoft Word. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "WINWORD.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft Query Launcher Code."
    Public Shared Sub LaunchQuery()
        ' Launch Microsoft Query. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "MSQRY32.EXE"
            isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft Clip Organizer Launcher Code."
    Public Shared Sub LaunchClipOrganizer()
        ' Launch Microsoft Clip Organizer. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "MSTORE.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft Picture Manager Launcher Code."
    Public Shared Sub LaunchPictureManager()
        ' Launch Microsoft Picture Manager. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "OIS.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Microsoft OneNote Quick Launch Launcher Code."
    Public Shared Sub LaunchOnenoteQuickLaunch()
        ' Launch Microsoft OneNote Quick Launcher. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "ONENOTEM.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#Region "Office Language Preferences Launcher Code."
    Public Shared Sub LaunchOfficeLangPrefs()
        ' Launch Office Language Preferences. Try...Catch code source here: <http://www.homeandlearn.co.uk/NET/nets5p4.html>
        exeName = "SETLANG.EXE"
        isolated_error_handler.launcherErrorHandler()
    End Sub
#End Region
#End Region
End Class
