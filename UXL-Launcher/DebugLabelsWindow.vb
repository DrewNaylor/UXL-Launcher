Public Class aaformDebugLabels
    Private Sub aaformDebugLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub debugButtonTestThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonTestThemeSetter.Click
        ' Attempt to apply the theme the user chose.
        If My.Settings.enableThemeEngine = True Then
            aaformMainWindow.themeChooser()
        End If
    End Sub

    Private Sub debugButtonDefaultThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonDefaultThemeSetter.Click
        ' Attempt to apply the default theme.
        If My.Settings.enableThemeEngine = True Then
            UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.DefaultTheme_XML)
            aaformMainWindow.themeApplier()
            ' First make sure theme engine output is enabled.
            If My.Settings.debugmodeShowThemeEngineOutput = True Then
                Debug.WriteLine("userTheme:")
                ' Due to changes to the theme engine, I had to change
                ' how the theme engine outputs the user's theme file
                ' and it doesn't look as good as it used to, but this
                ' should be fine. "OuterXml" property from here:
                ' https://msdn.microsoft.com/en-us/library/system.xml.xmlnode.outerxml.aspx
                Debug.Print(UXLLauncher_ThemeEngine.userTheme.OuterXml)
            End If
        End If
    End Sub
End Class