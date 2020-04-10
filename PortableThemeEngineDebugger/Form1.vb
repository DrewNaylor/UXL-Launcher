Public Class aaformThemeLoader
    Private Sub buttonLoadTheme_Click(sender As Object, e As EventArgs) Handles buttonLoadTheme.Click
        libportablethemeengine.themeenginemain.LoadTheme(textboxThemePath.Text, Me)
    End Sub
End Class
