' UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
' Copyright (C) 2013-2021 Drew Naylor
' Microsoft Office and all related words are copyright
' and trademark Microsoft Corporation. More details in the About window.
' Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor
' and does not endorse this software.
' Any other companies mentioned own their respective copyrights/trademarks.
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is part of UXL Launcher
' (Program is also known as "Unified eXecutable Launcher." Not to be confused with
' other software titled "[Kindle] Unified Application Launcher",
' "UX Launcher" [an Android launcher], or "Ulauncher" [a Linux app launcher].)
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



Public Class aaformDebugLabels
    Private Sub aaformDebugLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Make sure the debug labels are up to date and don't have the
        ' default text after closing and re-opening the window.
        debugmodeStuff.updateDebugLabels()
        ' Show/hide areas as needed.
        debugmodeStuff.showDebugLabels()
        ' If the theme engine is enabled, re-apply the current theme to the debug
        ' window so it's more consistent and doesn't use the Default theme after
        ' closing and re-opening it.
        If aaformOptionsWindow.boolIsThemeEngineEnabled = True Then
            UXLLauncher_ThemeEngine.themeEngine_ApplyTheme(Me, aaformMainWindow.UXLToolstripRenderer)
        End If
    End Sub

    Private Sub debugButtonTestThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonTestThemeSetter.Click
        ' Attempt to apply the theme the user chose if the theme engine is enabled.
        ' Make sure the theme engine was enabled at application start
        ' so that the theme will be applied properly.
        If aaformOptionsWindow.boolIsThemeEngineEnabled = True AndAlso My.Settings.enableThemeEngine = True Then
            aaformMainWindow.themeChooser()
        End If
    End Sub

    Private Sub debugButtonDefaultThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonDefaultThemeSetter.Click
        ' Attempt to apply the default theme if the theme engine is enabled.
        ' Make sure the theme engine was enabled at application start
        ' so that the theme will be applied properly.
        If aaformOptionsWindow.boolIsThemeEngineEnabled = True AndAlso My.Settings.enableThemeEngine = True Then
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