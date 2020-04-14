Public Class aaformThemeLoader
    Private Sub buttonLoadTheme_Click(sender As Object, e As EventArgs) Handles buttonLoadTheme.Click
        Dim startdate As DateTime = DateTime.Now
        libportablethemeengine.ThemeEngine.LoadTheme(textboxThemePath.Text, Me,)
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
