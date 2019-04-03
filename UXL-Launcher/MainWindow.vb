'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2019 Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation. More details in the About window.
'Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of UXL Launcher
'(Program is also known as "Unified eXecutable Launcher." Not to be confused with
'other software titled "[Kindle] Unified Application Launcher",
'"UX Launcher" [an Android launcher], or "Ulauncher" [a Linux app launcher].)
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



Imports System.Xml

Public Class aaformMainWindow

    ' Create the renderer for the toolstrip:
    Public Shared UXLToolstripRenderer As New uxlProToolstripRenderer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Run the code in the combineStrings sub in OfficeLocater.vb
        ' This has to be run before changing the titlebar text because
        ' part of the titlebar uses the OfficeLocater.titlebarBitModeString
        ' string.
        OfficeLocater.combineStrings()

        ' Put text in the titlebar.
        ' Placing this code here ensures the titlebar isn't as
        ' likely to get messed up and not have its proper text
        ' as opposed to running it after running the theme engine
        ' and having problems with the theme engine.
        ' Previously, if the theme engine had problems, the titlebar
        ' text wouldn't have been set properly here.

        ' It was moved into its own sub to make it easier to update.
        updateTitlebarText()

        ' Update main window statusbar label text.
        updateStatusbarText()

        ' Set the Options window boolean variable for the theme engine
        ' to My.Settings.enableThemeEngine.
        ' This ensures that the theme engine isn't used by accident when
        ' saving settings in the Options window.
        aaformOptionsWindow.boolIsThemeEngineEnabled = My.Settings.enableThemeEngine

#Region "Start the theme engine."

        ' If the user wants to use the theme engine, then use it.
        If My.Settings.enableThemeEngine = True Then

            ' If the theme engine is enabled, make the 
            ' Revert to Default Theme button visible
            ' and enabled.
            menubarRevertThemeButton.Visible = True
            menubarRevertThemeButton.Enabled = True

            ' Next, choose the user's theme and apply it.
            UXLLauncher_ThemeEngine.themeEngine_ChooseUserTheme()

            ' Then, give the menubar a renderer.
            menubarMainWindow.Renderer = UXLToolstripRenderer
            contextmenuNotifyicon.Renderer = UXLToolstripRenderer
        Else

            ' If the theme engine is disabled, make the
            ' Revert to Default Theme button invisible
            ' and disable it so that Ctrl + 0 doesn't
            ' do anything if the theme engine is
            ' disabled.
            menubarRevertThemeButton.Visible = False
            menubarRevertThemeButton.Enabled = False
        End If


#End Region

#Region "Debug code for aaformMainWindow."
        ' Figure out whether or not to show the debug labels based on a setting.
        debugmodeStuff.showDebugLabels()

        ' Update the debug labels.
        debugmodeStuff.updateDebugLabels()
#End Region

#Region "Main form loading code for Always On Top menubar button and window properties."

        ' See if the Always On Top setting is set to true and if it is,
        ' then set the window to be on top of other windows
        ' and check the checkbox in the "Always On Top" menubar button.

        If My.Settings.alwaysOnTop = True Then
            Me.TopMost = True
            menubarAlwaysOnTopButton.CheckState = CheckState.Checked
            debugmodeStuff.updateDebugLabels()

            ' But if the Always On Top setting is false, then set the window
            ' to not be on top of other windows.

        ElseIf My.Settings.alwaysOnTop = False Then
            Me.TopMost = False
            menubarAlwaysOnTopButton.CheckState = CheckState.Unchecked
            debugmodeStuff.updateDebugLabels()
        End If
#End Region

#Region "Main form loading code for Hide When Minimized menubar button."

        ' See if the Hide When Minimized setting is set to true and if it is,
        ' check the checkbox in the "Hide When Minimized" menubar button.

        If My.Settings.hideWhenMinimized = True Then
            menubarHideWhenMinimizedButton.CheckState = CheckState.Checked

            ' Otherwise, if it's false, make the "Hide When Minimized" checkbox
            ' be unchecked.
        ElseIf My.Settings.hideWhenMinimized = False Then
            menubarHideWhenMinimizedButton.CheckState = CheckState.Unchecked
        End If

#End Region
        ' End of Form1_Load sub.
    End Sub
#Region "Update statusbar text."
    Friend Sub updateStatusbarText()
        ' This sub updates the statusbar text based on whether the
        ' user wants to use the default statusbar greeting or
        ' to use a custom one personalized with their firstname
        ' or nickname.
        If My.Settings.userUseCustomStatusbarGreeting = False Then
            ' If the setting is false, use the default greeting.
            statusbarLabelWelcomeText.Text = "Welcome to UXL Launcher, the Unified eXecutable Launcher! Click the app names to launch them and explore the UI."
        ElseIf My.Settings.userUseCustomStatusbarGreeting = True Then
            ' If the setting is true, use a personalized greeting.
            statusbarLabelWelcomeText.Text = "Welcome back to UXL Launcher, " & My.Settings.userFirstNameForCustomStatusbarGreeting & "!"
        End If
    End Sub
#End Region

#Region "Update titlebar text."
    Friend Sub updateTitlebarText()
        ' When called, this updates the titlebar text of the main window.
        ' Moved into its own sub so that it can be updated in one place.
        Me.Text = "UXL Launcher Version " & My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString &
    " (" & My.Resources.isStable & ", " & OfficeLocater.titlebarBitModeString & " Mode)"
    End Sub
#End Region

#Region "Hide when minimized code."
    Private Sub aaformMainWindow_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' If the user has "Hide When Minimized" enabled, hide the window when they minimize it.
        ' Code based on this sample code: 
        ' https://www.aspsnippets.com/Articles/Minimize-Windows-Forms-WinForms-Application-to-System-Tray-using-C-And-VBNet.aspx

        If My.Settings.hideWhenMinimized = True Then
            If WindowState = FormWindowState.Minimized Then
                ShowInTaskbar = False
                Me.Hide()
            End If
        End If

    End Sub

    Private Sub notifyiconTaskbarLaunchers_DoubleClick(sender As Object, e As EventArgs) Handles notifyiconTaskbarLaunchers.DoubleClick
        ' When the user double-clicks on the notification icon, show the main window again.
        ' Code based on this sample code:
        ' https://www.aspsnippets.com/Articles/Minimize-Windows-Forms-WinForms-Application-to-System-Tray-using-C-And-VBNet.aspx

        ' The code that was here was moved to the showMainWindowFromQuickmenu sub, or whatever
        ' the name of the sub that appears below is.

        showMainWindowFromQuickmenu()
    End Sub

    Private Sub showMainWindowFromQuickmenu()
        ' Show UXL Launcher. Useful if "Hide When Minimized" is enabled.
        ' When the user clicks on the "Show UXL Launcher" Quickmenu menu entry
        ' or double-clicks on the notification icon, show the main window again.
        ' Code based on this sample code:
        ' https://www.aspsnippets.com/Articles/Minimize-Windows-Forms-WinForms-Application-to-System-Tray-using-C-And-VBNet.aspx

        ' First, the window needs to be shown on the desktop, in the taskbar, and
        ' with a regular window state.
        Me.Show()
        ShowInTaskbar = True
        WindowState = FormWindowState.Normal
        ' If the main window is behind another window, it needs to be brought to the front
        ' and the focus needs to be set to the main window as well.
        Me.TopMost = True
        Me.Focus()
        ' Don't set the main window to not be on top if Always On Top is enabled.
        If My.Settings.alwaysOnTop = False Then
            Me.TopMost = False
        End If
    End Sub

    Private Sub notifyiconShowApp_Click(sender As Object, e As EventArgs) Handles notifyiconShowApp.Click
        ' Show UXL Launcher. Useful if "Hide When Minimized" is enabled.
        ' When the user double-clicks on the notification icon, show the main window again.
        ' Code based on this sample code:
        ' https://www.aspsnippets.com/Articles/Minimize-Windows-Forms-WinForms-Application-to-System-Tray-using-C-And-VBNet.aspx

        ' The code that was here was moved to the showMainWindowFromQuickmenu sub, or whatever
        ' the name of the sub that appears below is.

        showMainWindowFromQuickmenu()
    End Sub
#End Region

#Region "Menubar code, including menubar buttons."

#Region "File menu"
    Private Sub menubarExitButton_Click(sender As Object, e As EventArgs) Handles menubarExitButton.Click
        ' End the execution of the app.
        Me.Close()

    End Sub

    Private Sub menubarOpenButton_Click(sender As Object, e As EventArgs) Handles menubarOpenButton.Click
        ' Show the "Open..." dialog and open the file if the user
        ' wants to. Process.Start opens the file in the default app
        ' for that file type.
        If openfiledialogOpenDocument.ShowDialog = DialogResult.OK Then
            ' If the user clicks the "OK" button, open the file.
            ' Make sure that the file isn't executable before running it.
            ' Assign filename in open file dialog to string.
            Dim fileName As String = openfiledialogOpenDocument.FileName.ToUpperInvariant
            ' Now, make sure the list of unsafe extensions does NOT contain
            ' this file's extension.
            ' If it does, don't open it, and tell the user if that setting is
            ' enabled.
            If My.Resources.unsafeExtensions_TXT.Contains(IO.Path.GetExtension(fileName)) Then
                If My.Settings.showUnsafeFileExtensionBlockedMessage = True Then
                    MessageBox.Show(Me, "The file """ & openfiledialogOpenDocument.FileName & """ was blocked from being opened because """ & IO.Path.GetExtension(openfiledialogOpenDocument.FileName) & """ is a potentially unsafe extension.", "Open", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                ' If the file name's extension isn't in the list of blocked extensions,
                ' then use Process.Start to open the file.
                ' Catch System.ComponentModel.Win32Exception exceptions, common if
                ' a file extension doesn't have a program assigned to it.
                Try
                    Process.Start(fileName)
                Catch ex As System.ComponentModel.Win32Exception
                    MessageBox.Show(Me, "The file extension """ & IO.Path.GetExtension(openfiledialogOpenDocument.FileName) & """ doesn't have a program assigned to it. You can use the ""Open with..."" menu to select a program to open it with." & vbCrLf & vbCrLf &
                                    "File name and path: " & openfiledialogOpenDocument.FileName, "Open")
                End Try
            End If
        End If
    End Sub

#Region "New submenu"

#Region "Microsoft Word document"
    ' Create new Word document.
    Private Sub menuitemNewWordDoc_Click(sender As Object, e As EventArgs) Handles menuitemNewWordDoc.Click
        ' When the user clicks this button, run Word to create a new document.
        LaunchApp.NewWordDoc()
    End Sub
#End Region
#Region "Microsoft Excel workbook"
    Private Sub menuitemNewExcelWorkbook_Click(sender As Object, e As EventArgs) Handles menuitemNewExcelWorkbook.Click
        ' When the user clicks this button, run Excel to create a new workbook.
        LaunchApp.NewExcelWorkbook()
    End Sub
#End Region
#Region "Microsoft PowerPoint presentation"
    Private Sub menuitemNewPPTPresentation_Click(sender As Object, e As EventArgs) Handles menuitemNewPPTPresentation.Click
        ' When the user clicks this button, run PowerPoint to create a new presentation.
        LaunchApp.NewPPTPresentation()
    End Sub
#End Region
#Region "Microsoft Outlook email"
    Private Sub menuitemNewOutlookEmail_Click(sender As Object, e As EventArgs) Handles menuitemNewOutlookEmail.Click
        ' When the user clicks this button, run Outlook to create a new email.
        LaunchApp.NewOutlookEmail()
    End Sub
#End Region
#Region "Microsoft Outlook contact"
    Private Sub menuitemNewOutlookContact_Click(sender As Object, e As EventArgs) Handles menuitemNewOutlookContact.Click
        ' When the user clicks this button, run Outlook to create a new contact.
        LaunchApp.NewOutlookContact()
    End Sub
#End Region
#Region "Microsoft Publisher publication"
    Private Sub menuitemNewPublisherPublication_Click(sender As Object, e As EventArgs) Handles menuitemNewPublisherPublication.Click
        ' When the user clicks this button, run Publisher to create a new publication.
        LaunchApp.NewPublisherPublication()
    End Sub
#End Region

#End Region
#End Region

    Private Sub menubarOptionsButton_Click(sender As Object, e As EventArgs) Handles menubarOptionsButton.Click
        ' Open the Options window. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceOptionsWindowTab As New aaformOptionsWindow
        forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
        forceOptionsWindowTab.ShowDialog(Me)
    End Sub

#Region "Help menubar buttons."
    Private Sub menubarAboutButton_Click(sender As Object, e As EventArgs) Handles menubarAboutButton.Click
        ' Open the About window to About tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(0)
        forceAboutWindowTab.ShowDialog(Me)
    End Sub

    Private Sub menubarLicenseButton_Click(sender As Object, e As EventArgs) Handles menubarLicenseButton.Click
        ' Open the About window to License tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(1)
        forceAboutWindowTab.ShowDialog(Me)
    End Sub

    Private Sub menubarAuthorsButton_Click(sender As Object, e As EventArgs) Handles menubarAuthorsButton.Click
        ' Open the About window to Acknowledgements tab. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
        Dim forceAboutWindowTab As New aaformAboutWindow
        forceAboutWindowTab.tabcontrolAboutWindow.SelectTab(2)
        forceAboutWindowTab.ShowDialog(Me)
    End Sub

    Private Sub menubarHelpTopicsButton_Click(sender As Object, e As EventArgs) Handles menubarHelpTopicsButton.Click
        ' Go to the GitHub wiki.
        Process.Start("https://github.com/DrewNaylor/UXL-Launcher/wiki")
    End Sub
#End Region

#Region "Revert to Default Theme button."
    Private Sub menubarRevertThemeButton_Click(sender As Object, e As EventArgs) Handles menubarRevertThemeButton.Click
        ' Attempt to revert to the default theme.
        If My.Settings.enableThemeEngine = True Then
            UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.DefaultTheme_XML)
            UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
        End If
    End Sub
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
        debugmodeStuff.updateDebugLabels()

    End Sub
#End Region

#Region "Hide When Minimized menubar button checkbox and stuff."
    Private Sub menubarHideWhenMinimizedButton_Click(sender As Object, e As EventArgs) Handles menubarHideWhenMinimizedButton.Click
        ' When the user clicks on the Hide When Minimized menubar button, the following code will run.
        ' First, the app will see if the Hide When Minimized menubar button is unchecked, then it will
        ' check the box for that button.
        ' Then, the app will check to see what My.Settings.hideWhenMinimized is set to. If it's set to
        ' False, then the app will set it to True, and the other way if it's set to True.
        ' After that, My.Settings will be saved.

        If menubarHideWhenMinimizedButton.CheckState = CheckState.Unchecked Then
            menubarHideWhenMinimizedButton.CheckState = CheckState.Checked
            If My.Settings.hideWhenMinimized = False Then
                My.Settings.hideWhenMinimized = True
            End If
            My.Settings.Save()
            My.Settings.Reload()

        ElseIf menubarHideWhenMinimizedButton.CheckState = CheckState.Checked Then
            menubarHideWhenMinimizedButton.CheckState = CheckState.Unchecked
            If My.Settings.hideWhenMinimized = True Then
                My.Settings.hideWhenMinimized = False
            End If
            My.Settings.Save()
            My.Settings.Reload()

        End If
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
        forceOptionsWindowTab.ShowDialog(Me)
    End Sub

    Private Sub notifyiconOfficeLang_Click(sender As Object, e As EventArgs) Handles notifyiconOfficeLang.Click
        ' Run Office Language Preferences.
        LaunchApp.LaunchOfficeLangPrefs()
    End Sub

#End Region

#Region "Theme Tester Buttons."
    Private Sub debugButtonTestThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonTestThemeSetter.Click
        ' Attempt to apply the theme the user chose.
        If My.Settings.enableThemeEngine = True Then
            UXLLauncher_ThemeEngine.themeEngine_ChooseUserTheme()
        End If
    End Sub

    Private Sub debugButtonDefaultThemeSetter_Click(sender As Object, e As EventArgs) Handles debugButtonDefaultThemeSetter.Click
        ' Attempt to apply the default theme.
        If My.Settings.enableThemeEngine = True Then
            UXLLauncher_ThemeEngine.userTheme.LoadXml(My.Resources.DefaultTheme_XML)
            UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
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
#End Region

End Class
