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



Public Class themeengine_ErrorMessageBox

    Public Shared Sub themeengineError()
        ' Instead of using Try...Catch for the theme engine when checking
        ' to see if an element exists in the XML document, I'm just going
        ' to use an If statement then call messageboxes.

        ' If the Description tag is missing, then ask the user if they want to set their theme to Default in My.Settings
        ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
        Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper " & UXLLauncher_ThemeEngine.themeErrorElementName & " XML element for the theme's Description displayed in the Options window." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher.", "title", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
        If msgResult = DialogResult.Yes And UXLLauncher_ThemeEngine.safetynetThemeSheet = "1" Then
            My.Settings.userChosenTheme = "Default"
            ' Save settings.
            My.Settings.Save()
            Application.Restart()

        ElseIf msgResult = DialogResult.Yes And UXLLauncher_ThemeEngine.safetynetThemeSheet IsNot "1" Then
            ' If the user clicked Yes but the safetynetThemeSheet isn't "1," kill the app so it doesn't crash
            ' their computer.
            MessageBox.Show("safetynetThemeSheet isn't set to 1. Check to ensure themeSheet.LoadXML and related code is not commented out. Aborting...")
            Process.Start("taskkill", "/F /IM UXL-Launcher.exe")

        ElseIf msgResult = DialogResult.No And UXLLauncher_ThemeEngine.safetynetThemeSheet IsNot "1" Then
            ' If the safteynetThemeSheet didn't get updated to "1," use TaskKill to immediately
            ' terminate all instances of UXL-Launcher.exe so that it doesn't lock up the user's computer.

            ' Only problem with using taskkill is that a CMD window will briefly show up, but
            ' this should only show up if the safetynetThemeSheet wasn't updated to "1"
            ' which would only happen if someone didn't allow the code at the top of
            ' themeEngine_ApplyTheme() to run where the XML document is loaded.
            Process.Start("taskkill", "/F /IM UXL-Launcher.exe")
        ElseIf msgResult = DialogResult.No Then
            ' Otherwise, just exit the app.
            Application.Exit()

        End If

    End Sub

End Class
