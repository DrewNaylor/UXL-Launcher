Public Class aaformThemeLoader
    Private Sub buttonLoadTheme_Click(sender As Object, e As EventArgs) Handles buttonLoadTheme.Click
        libportablethemeengine.themeenginemain.LoadTheme(textboxThemePath.Text, Me)
        buttonLoadTheme.BackColor = libportablethemeengine.ThemeProperties.colorButtonBackColor
    End Sub
End Class
