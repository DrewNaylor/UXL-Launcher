'PortableThemeEngineDebugger - Simple application used to test PortableThemeEngine.
'Copyright (C) 2020-2021 Drew Naylor. Licensed under Apache License 2.0.
'Any companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of PortableThemeEngineDebugger.
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



Public Class aaformThemeLoader
    Private Sub buttonLoadTheme_Click(sender As Object, e As EventArgs) Handles buttonLoadTheme.Click
        ' Get current time to see how long this takes.
        Dim startdate As DateTime = DateTime.Now

        ' If it's a custom theme being entered into the theme path textbox,
        ' load it like one.
        If radiobuttonIsCustomTheme.Checked = True Then

            ' Specify whether custom themes are allowed.
            If checkboxAllowCustomThemes.Checked = True Then
                libportablethemeengine.ThemeEngine.AllowCustomThemes = True
            Else
                libportablethemeengine.ThemeEngine.AllowCustomThemes = False
            End If

            ' Don't use full TE1.x compatibility mode.
            libportablethemeengine.ThemeEngine.UseFullTE1DotXCompatibilityMode = False

            ' Show theme engine debug output.
            libportablethemeengine.ThemeEngine.ShowThemeEngineDebuggingOutput = True

            ' This is a custom theme so it's named "(Custom)", is applied to this form ("Me"), the
            ' example context menu gets it applied too as it's part of the form's components ("Me.components"),
            ' and the path for the custom theme we're applying is in
            ' the textbox.
            libportablethemeengine.ThemeEngine.SelectTheme("(Custom)", Me, Me.components, textboxThemePath.Text)

        ElseIf radiobuttonSelectFromThemeEngine.Checked = True Then

            ' We're not applying a custom theme, but we still want to show debug output.
            libportablethemeengine.ThemeEngine.ShowThemeEngineDebuggingOutput = True

            ' We want to apply the theme that's specified in the textbox to this form.
            ' Be sure to apply it to the context menu, which is part of the form's components ("Me.components").
            ' This theme is stored in libportablethemeengine.
            libportablethemeengine.ThemeEngine.SelectTheme(textboxThemePath.Text, Me, Me.components)

        ElseIf radiobuttonLoadFromXml.Checked = True Then

            ' We need to load a theme from the theme engine debugger itself.
            ' Show debug output.
            libportablethemeengine.ThemeEngine.ShowThemeEngineDebuggingOutput = True

            ' Now load the theme. You can change the name of the resource to whatever
            ' you want according to your own project, it just has to be an XML resource.
            ' Currently only ReturnOfNight is available.
            ' Be sure to apply it to the context menu, which is part of the form's components ("Me.components").
            libportablethemeengine.ThemeEngine.LoadThemeFromXML(My.Resources.ReturnOfNightTheme_XML, Me, Me.components)

        ElseIf radiobuttonMatchSystemTheme.Checked = True Then

            ' If the radiobutton for matching the system theme is checked,
            ' we'll match the system theme.

            ' Show debug output.
            libportablethemeengine.ThemeEngine.ShowThemeEngineDebuggingOutput = True

            If checkboxSpecifyDarkThemeForSystemThemeMatching.Checked = False Then
                ' Don't override the default but do match the theme.
                libportablethemeengine.ThemeEngine.MatchWindows10ThemeSettings = True
                libportablethemeengine.ThemeEngine.SelectTheme("This should be optional in case the user wants to match the theme.", Me, Me.components)
            Else
                ' User wants to match the theme and override the default, so
                ' we'll do that.
                libportablethemeengine.ThemeEngine.MatchWindows10ThemeSettings = True
                libportablethemeengine.ThemeEngine.DarkThemeForSystemThemeMatching = textboxThemePath.Text
                libportablethemeengine.ThemeEngine.SelectTheme("This shouldn't matter, either.", Me, Me.components)
            End If

            ' Turn off matching system theme settings in case the user chooses another option.
            libportablethemeengine.ThemeEngine.MatchWindows10ThemeSettings = False

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AddedButton As Button = libportablethemeengine.PreThemedControls.ThemedButton
        AddedButton.Text = "test"

        FlowLayoutPanel1.Controls.Add(AddedButton)
    End Sub
End Class
