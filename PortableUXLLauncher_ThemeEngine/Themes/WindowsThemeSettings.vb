'PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
'Can be used with standard Windows Forms applications with a few small changes.
'Copyright (C) 2019-2020 Drew Naylor. Licensed under Gnu GPLv3+.
'Any companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of PortableThemeEngine.
'
'PortableThemeEngine is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'PortableThemeEngine is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with PortableThemeEngine.  If not, see <http://www.gnu.org/licenses/>.



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

    '    'Friend Shared Sub checkIfUserWantsToMatchTheme()
    '    '    ' If the user wants to have the theme match the Windows 10 theme settings,
    '    '    ' then do that.
    '    '    ' This should be done by a theme engine property.
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
