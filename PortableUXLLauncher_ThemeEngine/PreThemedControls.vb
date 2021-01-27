' PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
' Can be used with standard Windows Forms applications.
' Copyright (C) 2019-2021 Drew Naylor.
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



Imports System.Drawing

Public Class PreThemedControls

    Public Shared Function ThemedButton() As Windows.Forms.Button

        Dim PreThemedButton As New Windows.Forms.Button

        ' Make sure a theme is loaded.
        If ThemeProperties.themeSheet.OuterXml.Length = 0 Then
            ' If it's not, load the default button properties.
            ThemeProperties.colorButtonBackColor = ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue("Button", "BackColor"))
            ThemeProperties.colorButtonForeColor = ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue("Button", "ForeColor"))
            ThemeProperties.flatstyleButtonFlatStyle = Windows.Forms.FlatStyle.Standard
            ThemeProperties.flatappearanceButtonBorderColor = Nothing
            ThemeProperties.flatappearanceButtonMouseDownBackColor = Nothing
            ThemeProperties.flatappearanceButtonMouseOverBackColor = Nothing
        End If

        ' Assign the pre-themed button properties.
        PreThemedButton.BackColor = ThemeProperties.colorButtonBackColor
        PreThemedButton.ForeColor = ThemeProperties.colorButtonForeColor
        PreThemedButton.FlatStyle = ThemeProperties.flatstyleButtonFlatStyle
        'Windows.Forms.MessageBox.Show(ThemeProperties.flatstyleButtonFlatStyle.ToString)
        'Windows.Forms.MessageBox.Show(ThemeProperties.themeSheet.OuterXml.ToString)
        If PreThemedButton.FlatStyle = Windows.Forms.FlatStyle.Flat Then
            ' If it's meant to be flat, do the flat appearance stuff.
            PreThemedButton.FlatAppearance.BorderColor = ThemeProperties.flatappearanceButtonBorderColor
            PreThemedButton.FlatAppearance.MouseDownBackColor = ThemeProperties.flatappearanceButtonMouseDownBackColor
            PreThemedButton.FlatAppearance.MouseOverBackColor = ThemeProperties.flatappearanceButtonMouseOverBackColor
        End If

        Return PreThemedButton

    End Function


End Class
