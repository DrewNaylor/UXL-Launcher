'PortableThemeEngineDebugger - Simple application used to test PortableThemeEngine.
'Copyright (C) 2020 Drew Naylor. Licensed under Gnu GPLv3+.
'Any companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of PortableThemeEngineDebugger.
'
'PortableThemeEngineDebugger is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'PortableThemeEngineDebugger is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with PortableThemeEngineDebugger.  If not, see <http://www.gnu.org/licenses/>.



Public Class aaformThemeLoader
    Private Sub buttonLoadTheme_Click(sender As Object, e As EventArgs) Handles buttonLoadTheme.Click
        Dim startdate As DateTime = DateTime.Now
        libportablethemeengine.ThemeEngine.LoadThemeFromXML(My.Resources.ReturnOfNightTheme_XML, Me,)
        ' If it's a custom theme being entered into the theme path textbox,
        ' load it like one.
        'If checkboxIsCustomTheme.Checked = True Then
        '    ' Specify whether custom themes are allowed.
        '    libportablethemeengine.ThemeProperties.themeengineAllowCustomThemes = checkboxAllowCustomThemes.Checked
        '    Debug.WriteLine(libportablethemeengine.ThemeEngine.getThemeFileInfo(Nothing, True, textboxThemePath.Text))
        '    libportablethemeengine.ThemeEngine.SelectTheme("(Custom)", Me,, textboxThemePath.Text)
        'Else
        '    Debug.WriteLine(libportablethemeengine.ThemeEngine.GetThemeFileInfo(textboxThemePath.Text, False))
        '    libportablethemeengine.ThemeEngine.SelectTheme(textboxThemePath.Text, Me,)
        'End If
        Dim enddate As DateTime = DateTime.Now
        Debug.WriteLine("Theme engine took " & (enddate - startdate).Milliseconds & " milliseconds to run.")
        Me.Text = libportablethemeengine.ThemeProperties.colorButtonBackColor.ToString
        'Try
        '    ' Setting the form to ButtonBackColor.
        '    ' Don't worry if it says it can't use transparent colors.
        '    Me.BackColor = libportablethemeengine.ThemeProperties.colorButtonBackColor

        'Catch ex As System.ArgumentException
        '    Debug.WriteLine("That's the debugger's main window saying it can't apply transparent colors to forms.")
        'End Try
        'buttonLoadTheme.BackColor = libportablethemeengine.ThemeProperties.colorButtonBackColor



    End Sub

    Private Sub buttonSetColor_Click(sender As Object, e As EventArgs) Handles buttonSetColor.Click
        Try
            'Me.BackColor = ColorTranslator.FromHtml(textboxColorTester.Text)
            If textboxColorTester.Text.ToLowerInvariant = "nothing" Then
                StatusStrip1.BackColor = Nothing
            Else
                StatusStrip1.BackColor = ColorTranslator.FromHtml(textboxColorTester.Text)
            End If

        Catch ex As System.ArgumentException
        End Try

        MessageBox.Show(StatusStrip1.BackColor.ToString)
    End Sub

    Private Sub buttonResetColor_Click(sender As Object, e As EventArgs) Handles buttonResetColor.Click
        Me.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub
End Class
