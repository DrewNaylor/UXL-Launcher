'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2020 Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation. More details in the About window.
'Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of UXL Launcher
'(Program is also known as "Unified eXecutable Launcher." Not to be confused with
'other software titled "[Kindle] Unified Application Launcher",
'"UX Launcher" [an Android launcher], or "Ulauncher" [a Linux app launcher].)
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
            aaformMainWindow.menubarDebugMenu.Visible = True

            aaformDebugLabels.debugLabelForAlwaysOnTop.Show()
            aaformDebugLabels.debugLabelForofficeDriveLocation.Show()
            aaformDebugLabels.debugLabelForcpuTypeString.Show()
            aaformDebugLabels.debugLabelForofficeInstallMethodString.Show()
            aaformDebugLabels.debugLabelForuserOfficeVersion.Show()
            aaformDebugLabels.debugTextboxForFullLauncherCodeString.Show()
            aaformDebugLabels.debugLabelForUserHasOfficeThreeSixFive.Show()
            ' Show theme debug labels if the theme engine is enabled.
            If My.Settings.enableThemeEngine = True Then
                aaformDebugLabels.debugLabelXmlThemeTitle.Show()
                aaformDebugLabels.debugLabelXmlThemeDescription.Show()
                aaformDebugLabels.debugLabelXmlThemeAuthor.Show()
                aaformDebugLabels.debugLabelXmlThemeFileVersion.Show()
                aaformDebugLabels.debugLabelXmlThemeUseThemeEngineVersion.Show()
                ' Show theme tester buttons if the theme engine is enabled.
                aaformDebugLabels.debugButtonDefaultThemeSetter.Show()
                aaformDebugLabels.debugButtonTestThemeSetter.Show()
            ElseIf My.Settings.enableThemeEngine = False Then
                ' Otherwise, hide the theme debug labels and tester buttons.
                aaformDebugLabels.debugButtonDefaultThemeSetter.Hide()
                aaformDebugLabels.debugButtonTestThemeSetter.Hide()
                ' Theme debug labels hiding.
                aaformDebugLabels.debugLabelXmlThemeTitle.Hide()
                aaformDebugLabels.debugLabelXmlThemeDescription.Hide()
                aaformDebugLabels.debugLabelXmlThemeAuthor.Hide()
                aaformDebugLabels.debugLabelXmlThemeFileVersion.Hide()
                aaformDebugLabels.debugLabelXmlThemeUseThemeEngineVersion.Hide()
            End If

        ElseIf My.Settings.debugmodeShowLabels = False Then
            aaformMainWindow.menubarDebugMenu.Visible = False

            aaformDebugLabels.debugLabelForAlwaysOnTop.Hide()
            aaformDebugLabels.debugLabelForofficeDriveLocation.Hide()
            aaformDebugLabels.debugLabelForcpuTypeString.Hide()
            aaformDebugLabels.debugLabelForofficeInstallMethodString.Hide()
            aaformDebugLabels.debugLabelForuserOfficeVersion.Hide()
            aaformDebugLabels.debugTextboxForFullLauncherCodeString.Hide()
            aaformDebugLabels.debugLabelForUserHasOfficeThreeSixFive.Hide()
            ' Theme tester buttons.
            aaformDebugLabels.debugButtonDefaultThemeSetter.Hide()
            aaformDebugLabels.debugButtonTestThemeSetter.Hide()
            ' Theme debug labels hiding.
            aaformDebugLabels.debugLabelXmlThemeTitle.Hide()
            aaformDebugLabels.debugLabelXmlThemeDescription.Hide()
            aaformDebugLabels.debugLabelXmlThemeAuthor.Hide()
            aaformDebugLabels.debugLabelXmlThemeFileVersion.Hide()
            aaformDebugLabels.debugLabelXmlThemeUseThemeEngineVersion.Hide()
        End If
    End Sub
#Region "Update the debug labels on the main form."
    Public Shared Sub updateDebugLabels()
        ' Update the debug labels on the main window.

        ' Debug label for officeDriveLocation.
        aaformDebugLabels.debugLabelForofficeDriveLocation.Text = "officeDriveLocation: " & My.Settings.officeDriveLocation
        ' Debug label for cpuTypeString.
        aaformDebugLabels.debugLabelForcpuTypeString.Text = "cpuTypeString: " & OfficeLocater.cpuTypeString

        ' Debug label for officeInstallMethodString depending on the value of userHasOfficeThreeSixFive.
        If My.Settings.userHasOfficeThreeSixFive = True Then
            aaformDebugLabels.debugLabelForofficeInstallMethodString.Text = "officeInstallMethodString: " & "\root"
        ElseIf My.Settings.userHasOfficeThreeSixFive = False Then
            aaformDebugLabels.debugLabelForofficeInstallMethodString.Text = "officeInstallMethodString: " & ""
        End If

        ' Debug label for the Always On Top feature.
        aaformDebugLabels.debugLabelForAlwaysOnTop.Text = "menubar button checkstate: " & aaformMainWindow.menubarAlwaysOnTopButton.CheckState & vbNewLine &
        "alwaysOnTop setting: " & My.Settings.alwaysOnTop & vbNewLine &
        "main window TopMost: " & aaformMainWindow.TopMost


        ' Debug label for userOfficeVersion.
        aaformDebugLabels.debugLabelForuserOfficeVersion.Text = "userOfficeVersion: " & My.Settings.userOfficeVersion
        ' Debug label for userHasOfficeThreeSixFive.
        aaformDebugLabels.debugLabelForUserHasOfficeThreeSixFive.Text = "userHasOfficeThreeSixFive: " & My.Settings.userHasOfficeThreeSixFive
        ' Debug textbox for fullLauncherCodeString.
        aaformDebugLabels.debugTextboxForFullLauncherCodeString.Text = OfficeLocater.fullLauncherCodeString

        ' Debug labels for theme titles and descriptions.
        aaformDebugLabels.debugLabelXmlThemeTitle.Text = "Title string: " & UXLLauncher_ThemeEngine.themeSheetTitle
        aaformDebugLabels.debugLabelXmlThemeDescription.Text = "Description string: " & UXLLauncher_ThemeEngine.themeSheetDescription
        aaformDebugLabels.debugLabelXmlThemeAuthor.Text = "Author string: " & UXLLauncher_ThemeEngine.themeSheetAuthor
        aaformDebugLabels.debugLabelXmlThemeFileVersion.Text = "File version string: " & UXLLauncher_ThemeEngine.themeSheetFileVersion
        aaformDebugLabels.debugLabelXmlThemeUseThemeEngineVersion.Text = "UseThemeEngineVersion string: " &
            CType(UXLLauncher_ThemeEngine.themeSheetUseThemeEngineVersion, String)

    End Sub

    Public Shared Sub outputThemeEngineVersionToUse(themeEngineVersionToUse As Decimal)
        ' Show theme engine version that the theme wants to use in the Immediate Window
        ' if the proper setting is enabled.
        If My.Settings.debugmodeShowThemeEngineOutput = True Then
            Debug.WriteLine("")
            Debug.WriteLine("UseThemeEngineVersion string:")
            Debug.WriteLine(themeEngineVersionToUse)
        End If
    End Sub
#End Region
End Class
