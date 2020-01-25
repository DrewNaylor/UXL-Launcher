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



Public Class aaformDebugLabels
    Private Sub aaformDebugLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub debugButtonTestThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonTestThemeSetter.Click
        ' Attempt to apply the theme the user chose.
        If My.Settings.enableThemeEngine = True Then
            aaformMainWindow.themeChooser()
        End If
    End Sub

    Private Sub debugButtonDefaultThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonDefaultThemeSetter.Click
        ' Attempt to apply the default theme.
        If My.Settings.enableThemeEngine = True Then
            UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.DefaultTheme_XML)
            aaformMainWindow.themeApplier()
            ' First make sure theme engine output is enabled.
            If My.Settings.debugmodeShowThemeEngineOutput = True Then
                Debug.WriteLine("userTheme:")
                ' Due to changes to the theme engine, I had to change
                ' how the theme engine outputs the user's theme file
                ' and it doesn't look as good as it used to, but this
                ' should be fine. "OuterXml" property from here:
                ' https://msdn.microsoft.com/en-us/library/system.xml.xmlnode.outerxml.aspx
                Debug.Print(UXLLauncher_ThemeEngine.userTheme.OuterXml)
            End If
        End If
    End Sub
End Class