﻿' PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
' Can be used with standard Windows Forms applications with a few small changes.
' Copyright (C) 2019-2020 Drew Naylor.
' Microsoft Windows and all related words are copyright
' and trademark Microsoft Corporation.
' Microsoft is not affiliated with either PortableThemeEngine or Drew Naylor
' and does not endorse this software.
' Any other companies mentioned own their respective copyrights/trademarks.
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is part of PortableThemeEngine.
'
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

    'Friend Shared Function getWindowsThemeSettings() As String
    '    ' We need to read Computer\HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize\AppsUseLightTheme
    '    ' for this.

    '    Dim tempThemeSettingsValue As Object = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", "AppsUseLightTheme", Nothing)

    '    '    ' If the value has a 1 in it, then that means the
    '    '    ' light theme should be used.
    '    '    If tempThemeSettingsValue.ToString = "1" Then
    '    '        Return "Light"

    '    '        ' If the value has a 0 in it, then the dark theme
    '    '        ' should be used.
    '    '    ElseIf tempThemeSettingsValue.ToString = "0" Then
    '    '        Return "Dark"

    '    '        ' If some other value is there or the value doesn't exist,
    '    '        ' use the light theme.
    '    '    Else
    '    '        Return "Light"
    '    '    End If
    '    'End Function

    '    'Friend Shared Sub checkIfUserWantsToMatchTheme()
    '    '    ' If the user wants to have the theme match the Windows 10 theme settings,
    '    '    ' then do that.
    '    '    If My.Settings.matchWindows10ThemeSettings = True Then
    '    '        ' If the Windows 10 theme is Light, use Default.
    '    '        If getWindowsThemeSettings() = "Light" Then
    '    '            PortableThemeEngine.userTheme.LoadXml(My.Resources.DefaultTheme_XML)
    '    '            aaformMainWindow.themeApplier()

    '    '            ' Otherwise, load TenDark.
    '    '        ElseIf getWindowsThemeSettings() = "Dark" Then
    '    '            PortableThemeEngine.userTheme.LoadXml(My.Resources.TenDarkTheme_XML)
    '    '            aaformMainWindow.themeApplier()
    '    '        End If
    '    '    Else

    '    '        ' If the user doesn't want to match the Windows 10 theme,
    '    '        ' just move on.

    '    '        ' Choose the user's theme and apply it if the Windows
    '    '        ' settings won't be used.
    '    '        aaformMainWindow.themeChooser()
    '    '    End If
    '    End Sub

End Class
