Imports System.Drawing

Public Class PreThemedControls

    Public Shared Function ThemedButton() As Windows.Forms.Button

        Dim PreThemedButton As New Windows.Forms.Button

        ' Make sure a theme is loaded.
        If ThemeProperties.themeSheet.OuterXml.Length = 0 Then
            ' If it's not, load the default button properties.
            ThemeProperties.colorButtonBackColor = ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue("Button", "BackColor"))
            ThemeProperties.colorButtonForeColor = ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue("Button", "ForeColor"))
            ThemeProperties.flatstyleButtonFlatStyle = CType(TE2DotXLoader.GetDefaultValue("Button", "FlatStyle"), Windows.Forms.FlatStyle)
            ThemeProperties.flatappearanceButtonBorderColor = ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue("Button", "FlatAppearance/BorderColor"))
            ThemeProperties.flatappearanceButtonMouseDownBackColor = ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue("Button", "FlatAppearance/MouseDownBackColor"))
            ThemeProperties.flatappearanceButtonMouseOverBackColor = ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue("Button", "FlatAppearance/MouseOverBackColor"))
        End If

        PreThemedButton.BackColor = ThemeProperties.colorButtonBackColor
        PreThemedButton.ForeColor = ThemeProperties.colorButtonForeColor
        PreThemedButton.FlatStyle = ThemeProperties.flatstyleButtonFlatStyle
        Windows.Forms.MessageBox.Show(ThemeProperties.flatstyleButtonFlatStyle.ToString)
        Windows.Forms.MessageBox.Show(ThemeProperties.themeSheet.OuterXml.ToString)
        If PreThemedButton.FlatStyle = Windows.Forms.FlatStyle.Flat Then
            PreThemedButton.FlatAppearance.BorderColor = ThemeProperties.flatappearanceButtonBorderColor
            PreThemedButton.FlatAppearance.MouseDownBackColor = ThemeProperties.flatappearanceButtonMouseDownBackColor
            PreThemedButton.FlatAppearance.MouseOverBackColor = ThemeProperties.flatappearanceButtonMouseOverBackColor
        End If

        Return PreThemedButton

    End Function


End Class
