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



Public Class WindowsThemeSettings

    ' This class is used for getting the Windows 10 system theme settings.
    ' It returns Dark for the dark theme and Light for the light theme.

    Friend Shared Function getWindowsThemeSettings() As String
        ' We need to read Computer\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize\AppsUseLightTheme
        ' for this.

        Dim tempThemeSettingsValue As Object = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", Nothing)

        ' If the value has a 1 in it, then that means the
        ' light theme should be used.
        If tempThemeSettingsValue.ToString = "1" Then
            Return "Light"

            ' If the value has a 0 in it, then the dark theme
            ' should be used.
        ElseIf tempThemeSettingsValue.ToString = "0" Then
            Return "Dark"

            ' If some other value is there or the value doesn't exist,
            ' use the light theme.
        Else
            Return "Light"
        End If
    End Function

    Friend Shared Sub checkIfUserWantsToMatchTheme()
        ' If the user wants to have the theme match the Windows 10 theme settings,
        ' then do that.
        If My.Settings.matchWindows10ThemeSettings = True Then
            ' If the Windows 10 theme is Light, use Default.
            If getWindowsThemeSettings() = "Light" Then
                UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.DefaultTheme_XML)
                aaformMainWindow.themeApplier()

                ' Otherwise, load the dark theme for system theme matching.
                ' This falls back to ProDark if we can't find it.
            ElseIf getWindowsThemeSettings = "Dark" Then
                ' Check if the theme specified in My.Settings.darkthemeForSystemThemeMatching is in the
                ' list of available dark themes.
                If My.Resources.darkthemesList.Contains(My.Settings.darkthemeForSystemThemeMatching.ToString) AndAlso My.Resources.ResourceManager.GetString(My.Settings.darkthemeForSystemThemeMatching & "Theme_XML") IsNot Nothing Then
                    UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.ResourceManager.GetString(My.Settings.darkthemeForSystemThemeMatching & "Theme_XML"))
                Else
                    UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.ProDarkTheme_XML)
                End If
                aaformMainWindow.themeApplier()
                End If
            Else

            ' If the user doesn't want to match the Windows 10 theme,
            ' just move on.

            ' Choose the user's theme and apply it if the Windows
            ' settings won't be used.
            aaformMainWindow.themeChooser()
        End If
    End Sub

End Class
