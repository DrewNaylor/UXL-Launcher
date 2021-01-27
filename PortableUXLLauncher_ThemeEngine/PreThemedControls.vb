Public Class PreThemedControls

    Public Shared Function ThemedButton() As Windows.Forms.Button

        Dim PreThemedButton As New Windows.Forms.Button

        ' Make sure a theme is loaded.
        If ThemeProperties.themeSheet.OuterXml.Length = 0 Then

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
