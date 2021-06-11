' UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
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



Public Class debugmodeStuff
    ' This document is used to contain all the debug labels and textboxes.
    Public Shared Sub showDebugLabels()
        If My.Settings.debugmodeShowLabels = True Then
            ' Show the debug menu item if showing debug labels is enabled.
            aaformMainWindow.menubarDebugMenu.Visible = True

            ' Show theme debug labels if the theme engine was enabled
            ' on application startup.
            If My.Settings.enableThemeEngine = True AndAlso aaformOptionsWindow.boolIsThemeEngineEnabled = True Then
                aaformDebugLabels.groupboxThemeInfo.Show()

            ElseIf My.Settings.enableThemeEngine = False Or aaformOptionsWindow.boolIsThemeEngineEnabled = False Then
                ' If it's disabled at the moment, hide the
                ' theme debug labels and tester buttons.
                aaformDebugLabels.groupboxThemeInfo.Hide()

            End If

        ElseIf My.Settings.debugmodeShowLabels = False Then
            ' If debug labels aren't supposed to be shown, hide the debug menu.
            aaformMainWindow.menubarDebugMenu.Visible = False

        End If
    End Sub
#Region "Update the debug window labels."
    Public Shared Sub updateDebugLabels()
        ' Update the debug window labels.

        ' Debug label for officeDriveLocation.
        aaformDebugLabels.debugLabelForofficeDriveLocation.Text = "officeDriveLocation: " & My.Settings.officeDriveLocation
        ' Debug label for pfPathString.
        aaformDebugLabels.debugLabelForpfPathString.Text = "pfPathString: " & OfficeLocater.pfPathString

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
#End Region

    Public Shared Sub outputThemeEngineVersionToUse(themeEngineVersionToUse As Decimal)
        ' Show theme engine version that the theme wants to use in the Immediate Window
        ' if the proper setting is enabled.
        If My.Settings.debugmodeShowThemeEngineOutput = True Then
            Debug.WriteLine("")
            Debug.WriteLine("UseThemeEngineVersion string:")
            Debug.WriteLine(themeEngineVersionToUse)
        End If
    End Sub
End Class
