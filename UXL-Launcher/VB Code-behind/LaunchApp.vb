'UXL Launcher - Launchers for Microsoft Office apps in one place.
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
        ' Launch Microsoft Access.
        Process.Start(My.Settings.officeDriveLocation & ":\Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office" & My.Settings.userOfficeVersion & "\MSACCESS.EXE")
    End Sub

    Public Shared Sub LaunchExcel()
        ' Launch Microsoft Excel.
        Process.Start(My.Settings.officeDriveLocation & ":\Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\EXCEL.EXE")
    End Sub

    Public Shared Sub LaunchInfopath()
        ' Launch Microsoft InfoPath.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\INFOPATH.EXE")
    End Sub

    Public Shared Sub LaunchOnenote()
        ' Launch Microsoft Onenote.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\ONENOTE.EXE")
    End Sub

    Public Shared Sub LaunchOutlook()
        ' Launch Microsoft Outlook.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\OUTLOOK.EXE")
    End Sub

    Public Shared Sub LaunchPowerpoint()
        ' Launch Microsoft Powerpoint.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\POWERPNT.EXE")
    End Sub

    Public Shared Sub LaunchSharepointWorkspace()
        ' Launch Microsoft SharePoint Workspace.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\GROOVE.EXE")
    End Sub

    Public Shared Sub LaunchPublisher()
        ' Launch Microsoft Publisher.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\MSPUB.EXE")
    End Sub

    Public Shared Sub LaunchWord()
        ' Launch Microsoft Word.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\WINWORD.EXE")
    End Sub

    Public Shared Sub LaunchQuery()
        ' Launch Microsoft Query.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\MSQRY32.EXE")
    End Sub

    Public Shared Sub LaunchClipOrganizer()
        ' Launch Microsoft Clip Organizer.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\MSTORE.EXE")
    End Sub

    Public Shared Sub LaunchPictureManager()
        ' Launch Microsoft Picture Manager.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\OIS.EXE")
    End Sub

    Public Shared Sub LaunchOnenoteQuickLaunch()
        ' Launch Microsoft OneNote Quick Launcher.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\ONENOTEM.EXE")
    End Sub

    Public Shared Sub LaunchOfficeLangPrefs()
        ' Launch Office Language Preferences.
        Process.Start(My.Settings.officeDriveLocation & ":Program Files" & OfficeLocater.cpuTypeString & "\Microsoft Office" & OfficeLocater.officeInstallMethodString & "\Office14\SETLANG.EXE")
    End Sub




#End Region
End Class
