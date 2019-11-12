'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2019 Drew Naylor
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
                UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()

                ' Otherwise, load TenDark.
            ElseIf getWindowsThemeSettings = "Dark" Then
                UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.TenDarkTheme_XML)
                UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
            End If
        Else

            ' If the user doesn't want to match the Windows 10 theme,
            ' just move on.

            ' Choose the user's theme and apply it if the Windows
            ' settings won't be used.
            UXLLauncher_ThemeEngine.themeEngine_ChooseUserTheme()
        End If
    End Sub

End Class
