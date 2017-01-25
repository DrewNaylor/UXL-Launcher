'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2017  Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of UXL Launcher
'(Program is also known as "Unified eXecutable Launcher." Not to be confused with
'another software titled "[Kindle] Unified Application Launcher".)
'
'UXL Launcher is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'UXL Launcher is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with UXL Launcher.  If not, see <http://www.gnu.org/licenses/>.



Public Class aaformMainWindow

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Run the code in the combineStrings sub in OfficeLocater.vb
        OfficeLocater.combineStrings()

#Region "Start the theme engine and apply the user's theme."

        UXLLauncher_ThemeEngine.themeEngine_ChooseUserTheme()

#End Region

        ' Put text in the titlebar.
        Me.Text = "UXL Launcher Version " & My.Application.Info.Version.ToString & " (" & OfficeLocater.titlebarBitModeString & " Mode)"


#Region "Debug code for aaformMainWindow."
        ' Figure out whether or not to show the debug labels based on a setting.
        debugmodeStuff.showDebugLabels()

        ' Update the debug labels.
        debugmodeStuff.updateDebugLabels()
#End Region

#Region "Main form loading code for Always On Top menubar button."

        ' See if the Always On Top setting is set to true and if it is, then set
        ' the window to be on top of other windows.

        If My.Settings.alwaysOnTop = True Then
            menubarAlwaysOnTopButton.CheckState = CheckState.Checked
            Me.TopMost = True

            ' But if the Always On Top setting is false, then set the window to not
            ' be on top of other windows.

        ElseIf My.Settings.alwaysOnTop = False Then
            Me.TopMost = False
            menubarAlwaysOnTopButton.CheckState = CheckState.Unchecked
        End If
#End Region

    End Sub


#Region "Menubar code, including menubar buttons."

    Private Sub menubarExitButton_Click(sender As Object, e As EventArgs) Handles menubarExitButton.Click
        ' End the execution of the app.
        Me.Close()

    End Sub

    Private Sub menubarOptionsButton_Click(sender As Object, e As EventArgs) Handles menubarOptionsButton.Click
        ' Open the Options window. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceOptionsWindowTab As New aaformOptionsWindow
        forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
        forceOptionsWindowTab.ShowDialog()
    End Sub

#Region "Menubar button entry theming override."

    ' Create a Color variable to store the color of the menubar entry as it was before the mouse was moved over it.
    Public colorPreviousMenuColor As Color

#Region "Exit button"
    ' This code changes the color of the Exit button in the File menu when
    ' the mouse is moved over it so that it's readable.
    Private Sub menubarExitButton_MouseEnter(sender As Object, e As EventArgs) Handles menubarExitButton.MouseEnter
        colorPreviousMenuColor = menubarExitButton.ForeColor
        menubarExitButton.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    ' Change the Exit button in the File menu to what it was
    ' before we put the mouse over the entry.
    Private Sub menubarExitButton_MouseLeave(sender As Object, e As EventArgs) Handles menubarExitButton.MouseLeave
        menubarExitButton.ForeColor = colorPreviousMenuColor
    End Sub
#End Region

#Region "Always On Top button"
    ' This code changes the color of the Always On Top button in the View menu when
    ' the mouse is moved over it so that it's readable.
    Private Sub menubarAlwaysOnTopButton_MouseEnter(sender As Object, e As EventArgs) Handles menubarAlwaysOnTopButton.MouseEnter
        colorPreviousMenuColor = menubarAlwaysOnTopButton.ForeColor
        menubarAlwaysOnTopButton.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    ' Change the Always On Top button in the View menu to what it was
    ' before we put the mouse over the entry.
    Private Sub menubarAlwaysOnTopButton_MouseLeave(sender As Object, e As EventArgs) Handles menubarAlwaysOnTopButton.MouseLeave
        menubarAlwaysOnTopButton.ForeColor = colorPreviousMenuColor
    End Sub
#End Region

#Region "Office Language Preferences button."

    ' This code changes the color of the Office Language Preferences button in the Tools menu when
    ' the mouse is moved over it so that it's readable.
    Private Sub menubarOfficeLangPrefsButton_MouseEnter(sender As Object, e As EventArgs) Handles menubarOfficeLangPrefsButton.MouseEnter
        colorPreviousMenuColor = menubarOfficeLangPrefsButton.ForeColor
        menubarOfficeLangPrefsButton.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    ' Change the Office Language Preferences button in the Tools menu to what it was
    ' before we put the mouse over the entry.
    Private Sub menubarOfficeLangPrefsButton_MouseLeave(sender As Object, e As EventArgs) Handles menubarOfficeLangPrefsButton.MouseLeave
        menubarOfficeLangPrefsButton.ForeColor = colorPreviousMenuColor
    End Sub
#End Region

#Region "UXL Launcher Options button."

    ' This code changes the color of the Options button in the Tools menu when
    ' the mouse is moved over it so that it's readable.
    Private Sub menubarOptionsButton_MouseEnter(sender As Object, e As EventArgs) Handles menubarOptionsButton.MouseEnter
        colorPreviousMenuColor = menubarOptionsButton.ForeColor
        menubarOptionsButton.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
    End Sub

    ' Change the Options button in the Tools menu to what it was
    ' before we put the mouse over the entry.
    Private Sub menubarOptionsButton_MouseLeave(sender As Object, e As EventArgs) Handles menubarOptionsButton.MouseLeave
        menubarOptionsButton.ForeColor = colorPreviousMenuColor
    End Sub

#End Region

#End Region

#Region "Always On Top menubar button checkbox and stuff."
    Private Sub menubarAlwaysOnTopButton_Click(sender As Object, e As EventArgs) Handles menubarAlwaysOnTopButton.Click

        ' When the user clicks on the Always On Top menubar button, the following code will run.
        ' First, the app will see if the Always On Top menubar button is unchecked, then it will
        ' check the box for that button.
        ' Then, the app will check to see what My.Settings.alwaysOnTop is set to. If it's set to
        ' False, then the app will set it to True.
        ' After that, My.Settings will be saved.
        ' Later, a debugging label will be updated with the CheckState of the Always On Top button.

        If menubarAlwaysOnTopButton.CheckState = CheckState.Unchecked Then
            menubarAlwaysOnTopButton.CheckState = CheckState.Checked
            Me.TopMost = True
            If My.Settings.alwaysOnTop = False Then
                My.Settings.alwaysOnTop = True
            End If
            My.Settings.Save()
            My.Settings.Reload()

        ElseIf menubarAlwaysOnTopButton.CheckState = CheckState.Checked Then
            menubarAlwaysOnTopButton.CheckState = CheckState.Unchecked
            Me.TopMost = False
            If My.Settings.alwaysOnTop = True Then
                My.Settings.alwaysOnTop = False
            End If
            My.Settings.Save()
            My.Settings.Reload()

        End If

        ' Update the debug label for alwaysOnTop.
        ' Debug label for the Always On Top feature.
        debugLabelForAlwaysOnTop.Text = "menubar button checkstate: " & menubarAlwaysOnTopButton.CheckState & vbNewLine &
        "alwaysOnTop setting: " & My.Settings.alwaysOnTop & vbNewLine &
        "main window TopMost: " & Me.TopMost

    End Sub
#End Region
#End Region


#Region "App Launcher Code."

    Private Sub buttonRunAccess_Click(sender As Object, e As EventArgs) Handles buttonRunAccess.Click
        ' Run Microsoft Access.
        LaunchApp.LaunchAccess()
    End Sub

    Private Sub buttonRunExcel_Click(sender As Object, e As EventArgs) Handles buttonRunExcel.Click
        ' Run Microsoft Excel.
        LaunchApp.LaunchExcel()
    End Sub

    Private Sub buttonRunInfoPath_Click(sender As Object, e As EventArgs) Handles buttonRunInfoPath.Click
        ' Run Microsoft InfoPath.
        LaunchApp.LaunchInfopath()
    End Sub

    Private Sub buttonRunOneNote_Click(sender As Object, e As EventArgs) Handles buttonRunOneNote.Click
        ' Run Microsoft OneNote.
        LaunchApp.LaunchOnenote()
    End Sub

    Private Sub buttonRunOutlook_Click(sender As Object, e As EventArgs) Handles buttonRunOutlook.Click
        ' Run Microsoft Outlook.
        LaunchApp.LaunchOutlook()
    End Sub

    Private Sub buttonRunPowerPoint_Click(sender As Object, e As EventArgs) Handles buttonRunPowerPoint.Click
        ' Run Microsoft PowerPoint.
        LaunchApp.LaunchPowerpoint()
    End Sub

    Private Sub buttonRunSharePointWkSp_Click(sender As Object, e As EventArgs) Handles buttonRunSharePointWkSp.Click
        ' Run Microsoft SharePoint Workspace.
        LaunchApp.LaunchSharepointWorkspace()
    End Sub

    Private Sub buttonRunPublisher_Click(sender As Object, e As EventArgs) Handles buttonRunPublisher.Click
        ' Run Microsoft Publisher.
        LaunchApp.LaunchPublisher()
    End Sub

    Private Sub buttonRunWord_Click(sender As Object, e As EventArgs) Handles buttonRunWord.Click
        ' Run Microsoft Word.
        LaunchApp.LaunchWord()
    End Sub

    Private Sub buttonRunQuery_Click(sender As Object, e As EventArgs) Handles buttonRunQuery.Click
        ' Run Microsoft Query.
        LaunchApp.LaunchQuery()
    End Sub

    Private Sub buttonRunClipOrganizer_Click(sender As Object, e As EventArgs) Handles buttonRunClipOrganizer.Click
        ' Run Microsoft Clip Organizer.
        LaunchApp.LaunchClipOrganizer()
    End Sub

    Private Sub buttonRunPictureManager_Click(sender As Object, e As EventArgs) Handles buttonRunPictureManager.Click
        ' Run Microsoft Picture Manager.
        LaunchApp.LaunchPictureManager()
    End Sub

    Private Sub buttonRunOneNoteQuickLaunch_Click(sender As Object, e As EventArgs) Handles buttonRunOneNoteQuickLaunch.Click
        ' Run Microsoft OneNote Quick Launcher.
        LaunchApp.LaunchOnenoteQuickLaunch()
    End Sub

    Private Sub menubarOfficeLangPrefsButton_Click(sender As Object, e As EventArgs) Handles menubarOfficeLangPrefsButton.Click
        ' Run Office Language Preferences.
        LaunchApp.LaunchOfficeLangPrefs()
    End Sub
#End Region
#Region "Help menubar buttons."
    Private Sub menubarAboutButton_Click(sender As Object, e As EventArgs) Handles menubarAboutButton.Click
        ' Open the About window to About tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(0)
        forceAboutWindowTab.ShowDialog()
    End Sub

    Private Sub menubarLicenseButton_Click(sender As Object, e As EventArgs) Handles menubarLicenseButton.Click
        ' Open the About window to License tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(1)
        forceAboutWindowTab.ShowDialog()
    End Sub

    Private Sub menubarAuthorsButton_Click(sender As Object, e As EventArgs) Handles menubarAuthorsButton.Click
        ' Open the About window to Acknowledgements tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(2)
        forceAboutWindowTab.ShowDialog()
    End Sub

    Private Sub menubarHelpTopicsButton_Click(sender As Object, e As EventArgs) Handles menubarHelpTopicsButton.Click
        ' Go to the GitHub wiki.
        Process.Start("https://github.com/DrewNaylor/UXL-Launcher/wiki")
    End Sub


#End Region
#Region "Taskbar notification area launcher buttons."
    Private Sub notifyiconWord_Click(sender As Object, e As EventArgs) Handles notifyiconWord.Click
        ' Run Microsoft Word.
        LaunchApp.LaunchWord()
    End Sub

    Private Sub notifyiconExcel_Click(sender As Object, e As EventArgs) Handles notifyiconExcel.Click
        ' Run Microsoft Excel.
        LaunchApp.LaunchExcel()
    End Sub

    Private Sub notifyiconPowerpoint_Click(sender As Object, e As EventArgs) Handles notifyiconPowerpoint.Click
        ' Run Microsoft PowerPoint.
        LaunchApp.LaunchPowerpoint()
    End Sub

    Private Sub notifyiconOutlook_Click(sender As Object, e As EventArgs) Handles notifyiconOutlook.Click
        ' Run Microsoft Outlook.
        LaunchApp.LaunchOutlook()
    End Sub

    Private Sub notifyiconOnenote_Click(sender As Object, e As EventArgs) Handles notifyiconOnenote.Click
        ' Run Microsoft OneNote.
        LaunchApp.LaunchOnenote()
    End Sub

    Private Sub notifyiconAccess_Click(sender As Object, e As EventArgs) Handles notifyiconAccess.Click
        ' Run Microsoft Access.
        LaunchApp.LaunchAccess()
    End Sub

    Private Sub notifyiconPublisher_Click(sender As Object, e As EventArgs) Handles notifyiconPublisher.Click
        ' Run Microsoft Publisher.
        LaunchApp.LaunchPublisher()
    End Sub

    Private Sub notifyiconInfopath_Click(sender As Object, e As EventArgs) Handles notifyiconInfopath.Click
        ' Run Microsoft InfoPath.
        LaunchApp.LaunchInfopath()
    End Sub

    Private Sub notifyiconSharepointWkSp_Click(sender As Object, e As EventArgs) Handles notifyiconSharepointWkSp.Click
        ' Run Microsoft SharePoint Workspace.
        LaunchApp.LaunchSharepointWorkspace()
    End Sub

    Private Sub notifyiconExitApp_Click(sender As Object, e As EventArgs) Handles notifyiconExitApp.Click
        ' Exit UXL Launcher.
        Me.Close()
    End Sub

    Private Sub notifyiconUXLOptions_Click(sender As Object, e As EventArgs) Handles notifyiconUXLOptions.Click
        ' Open the Options window. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceOptionsWindowTab As New aaformOptionsWindow
        forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
        forceOptionsWindowTab.ShowDialog()
    End Sub

    Private Sub notifyiconOfficeLang_Click(sender As Object, e As EventArgs) Handles notifyiconOfficeLang.Click
        ' Run Office Language Preferences.
        LaunchApp.LaunchOfficeLangPrefs()
    End Sub

#End Region

#Region "Theme Tester Buttons."
    Private Sub debugButtonTestThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonTestThemeSetter.Click
        ' Attempt to apply the theme the user chose.
        UXLLauncher_ThemeEngine.themeEngine_ChooseUserTheme()
    End Sub

    Private Sub debugButtonDefaultThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonDefaultThemeSetter.Click
        ' Attempt to apply the default theme.
        UXLLauncher_ThemeEngine.userTheme = My.Resources.DefaultTheme_XML
        UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
    End Sub
#End Region

End Class
