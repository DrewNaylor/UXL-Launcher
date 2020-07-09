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
        ' Get current time to see how long this takes.
        Dim startdate As DateTime = DateTime.Now

        ' You can load themes directly from XML with the next line, just change it
        ' as you need.
        'libportablethemeengine.ThemeEngine.LoadThemeFromXML(My.Resources.ReturnOfNightTheme_XML, Me)

        ' If it's a custom theme being entered into the theme path textbox,
        ' load it like one.
        If radiobuttonIsCustomTheme.Checked = True Then

            ' Specify whether custom themes are allowed.
            libportablethemeengine.ThemeEngine.AllowCustomThemes = True

            ' Don't use full TE1.x compatibility mode.
            libportablethemeengine.ThemeEngine.UseFullTE1DotXCompatibilityMode = False

            ' Show theme engine debug output.
            libportablethemeengine.ThemeEngine.ShowThemeEngineDebuggingOutput = True

            ' This is a custom theme, so it's named "(Custom)", is applied to this form ("Me"), there
            ' are no components on this form to theme (that would be things like
            ' Windows Forms context menus), and the path for the custom theme we're applying is in
            ' the textbox.
            libportablethemeengine.ThemeEngine.SelectTheme("(Custom)", Me,, textboxThemePath.Text)

        Else

            ' We're not applying a custom theme, but we still want to show debug output.
            libportablethemeengine.ThemeEngine.ShowThemeEngineDebuggingOutput = True

            ' We want to apply the theme that's specified in the textbox to this form.
            ' This theme is stored in libportablethemeengine.
            libportablethemeengine.ThemeEngine.SelectTheme(textboxThemePath.Text, Me)

        End If

        ' Get the end date for calculating how long it took to run.
        Dim enddate As DateTime = DateTime.Now
        Debug.WriteLine("Theme engine took " & (enddate - startdate).Milliseconds & " milliseconds to run.")

        ' Change the titlebar text to the button backcolor that the theme engine applied.
        Me.Text = libportablethemeengine.ThemeProperties.colorButtonBackColor.ToString

    End Sub

    Private Sub buttonSetColor_Click(sender As Object, e As EventArgs) Handles buttonSetColor.Click
        Try
            ' If the user typed in "Nothing", set the back color of the
            ' statusbar to "Nothing".
            If textboxColorTester.Text.ToLowerInvariant = "nothing" Then
                StatusStrip1.BackColor = Nothing
            Else
                StatusStrip1.BackColor = ColorTranslator.FromHtml(textboxColorTester.Text)
            End If

        Catch ex As Exception
            MessageBox.Show("The color """ & textboxColorTester.Text & """ can't be used as a StatusStrip BackColor." & vbCrLf &
                            vbCrLf &
                            "Exception message: " & ex.Message)
        End Try

        MessageBox.Show("Current statusbar backcolor: " & StatusStrip1.BackColor.ToString)
    End Sub

    Private Sub buttonResetColor_Click(sender As Object, e As EventArgs) Handles buttonResetColor.Click
        ' Reset statusbar backcolor.
        StatusStrip1.BackColor = Nothing
    End Sub
End Class
