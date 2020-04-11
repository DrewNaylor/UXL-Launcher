Public Class aaformThemeLoader
    Private Sub buttonLoadTheme_Click(sender As Object, e As EventArgs) Handles buttonLoadTheme.Click
        libportablethemeengine.themeenginemain.LoadTheme(textboxThemePath.Text, Me)
        Me.Text = libportablethemeengine.ThemeProperties.colorButtonBackColor.ToString
        Try
            'Me.BackColor = libportablethemeengine.ThemeProperties.colorButtonBackColor
            buttonLoadTheme.BackColor = libportablethemeengine.ThemeProperties.colorButtonBackColor
        Catch ex As System.ArgumentException
        End Try

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
