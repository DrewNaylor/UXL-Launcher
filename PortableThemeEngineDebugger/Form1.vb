Public Class aaformThemeLoader
    Private Sub buttonLoadTheme_Click(sender As Object, e As EventArgs) Handles buttonLoadTheme.Click
        libportablethemeengine.themeenginemain.LoadTheme(textboxThemePath.Text, Me)
        Me.Text = libportablethemeengine.ThemeProperties.colorButtonBackColor.ToString
        Me.BackColor = libportablethemeengine.ThemeProperties.colorButtonBackColor

    End Sub

    Private Sub buttonSetColor_Click(sender As Object, e As EventArgs) Handles buttonSetColor.Click
        Try
            Me.BackColor = ColorTranslator.FromHtml(textboxColorTester.Text)
        Catch ex As System.ArgumentException
        End Try
    End Sub

    Private Sub buttonResetColor_Click(sender As Object, e As EventArgs) Handles buttonResetColor.Click
        Me.BackColor = Color.FromKnownColor(KnownColor.Control)
    End Sub
End Class
