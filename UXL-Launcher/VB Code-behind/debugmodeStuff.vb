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



Public Class debugmodeStuff
    ' This document is used to contain all the debug labels and textboxes.
    Public Shared Sub showDebugLabels()
        If My.Settings.debugmodeShowLabels = True Then
            aaformMainWindow.debugLabelForAlwaysOnTop.Show()
            aaformMainWindow.debugLabelForofficeDriveLocation.Show()
            aaformMainWindow.debugLabelForcpuTypeString.Show()
            aaformMainWindow.debugLabelForofficeInstallMethodString.Show()
            aaformMainWindow.debugLabelForuserOfficeVersion.Show()
            aaformMainWindow.debugTextboxForFullLauncherCodeString.Show()
            aaformMainWindow.debugLabelForMSIInstall.Show()
            aaformMainWindow.debugLabelXmlThemeTitle.Show()
            aaformMainWindow.debugLabelXmlThemeDescription.Show()
            aaformMainWindow.debugLabelXmlThemeAuthor.Show()
            ' Theme tester buttons.
            aaformMainWindow.debugButtonDefaultThemeSetter.Show()
            aaformMainWindow.debugButtonTestThemeSetter.Show()

        ElseIf My.Settings.debugmodeShowLabels = False Then
            aaformMainWindow.debugLabelForAlwaysOnTop.Hide()
            aaformMainWindow.debugLabelForofficeDriveLocation.Hide()
            aaformMainWindow.debugLabelForcpuTypeString.Hide()
            aaformMainWindow.debugLabelForofficeInstallMethodString.Hide()
            aaformMainWindow.debugLabelForuserOfficeVersion.Hide()
            aaformMainWindow.debugTextboxForFullLauncherCodeString.Hide()
            aaformMainWindow.debugLabelForMSIInstall.Hide()
            aaformMainWindow.debugLabelXmlThemeTitle.Hide()
            aaformMainWindow.debugLabelXmlThemeDescription.Hide()
            aaformMainWindow.debugLabelXmlThemeAuthor.Hide()
            ' Theme tester buttons.
            aaformMainWindow.debugButtonDefaultThemeSetter.Hide()
            aaformMainWindow.debugButtonTestThemeSetter.Hide()
        End If
    End Sub
#Region "Update the debug labels on the main form."
    Public Shared Sub updateDebugLabels()
        ' Update the debug labels on the main window.

        ' Debug label for officeDriveLocation.
        aaformMainWindow.debugLabelForofficeDriveLocation.Text = "officeDriveLocation: " & My.Settings.officeDriveLocation
        ' Debug label for cpuTypeString.
        aaformMainWindow.debugLabelForcpuTypeString.Text = "cpuTypeString: " & OfficeLocater.cpuTypeString

        ' Debug label for officeInstallMethodString depending on the value of userHasOfficeThreeSixFive.
        If My.Settings.userHasOfficeThreeSixFive = True Then
            aaformMainWindow.debugLabelForofficeInstallMethodString.Text = "officeInstallMethodString: " & "\root"
        ElseIf My.Settings.userHasOfficeThreeSixFive = False Then
            aaformMainWindow.debugLabelForofficeInstallMethodString.Text = "officeInstallMethodString: " & ""
        End If

        ' Debug label for the Always On Top feature.
        aaformMainWindow.debugLabelForAlwaysOnTop.Text = "menubar button checkstate: " & aaformMainWindow.menubarAlwaysOnTopButton.CheckState & vbNewLine &
        "alwaysOnTop setting: " & My.Settings.alwaysOnTop & vbNewLine &
        "main window TopMost: " & aaformMainWindow.TopMost


        ' Debug label for userOfficeVersion.
        aaformMainWindow.debugLabelForuserOfficeVersion.Text = "userOfficeVersion: " & My.Settings.userOfficeVersion
        ' Debug label for MSIInstall.
        aaformMainWindow.debugLabelForMSIInstall.Text = "installedViaMSIPackage: " & My.Settings.installedViaMSIPackage
        ' Debug textbox for fullLauncherCodeString.
        aaformMainWindow.debugTextboxForFullLauncherCodeString.Text = OfficeLocater.fullLauncherCodeString

        ' Debug labels for theme titles and descriptions.
        aaformMainWindow.debugLabelXmlThemeTitle.Text = UXLLauncher_ThemeEngine.themeSheetTitle
        aaformMainWindow.debugLabelXmlThemeDescription.Text = UXLLauncher_ThemeEngine.themeSheetDescription

    End Sub
#End Region
End Class
