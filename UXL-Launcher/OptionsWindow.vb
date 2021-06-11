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



Imports System.Xml

Public Class aaformOptionsWindow

    ' Create a boolean variable that sees if the theme engine is enabled.
    ' It's used when saving the settings to see if the theme engine should
    ' update the theme if this variable and the related My.Settings
    ' value are equal. If not, it won't update.

    ' This is set to False by default and set to the related My.Settings
    ' value on application start.
    Friend Shared boolIsThemeEngineEnabled As Boolean = False

#Region "Code to run when opening the Options window."

    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "Recommended Windows edition selection label"
        ' This updates the text for the label that tells the user
        ' which Windows edition radio button is the one to select.

        ' First, check to see if the OS is 32-bit or 64-bit.
        If Environment.Is64BitOperatingSystem = True Then
            ' If the OS is 64-bit, recommend the user to click
            ' 64-bit Windows.
            labelRecommendedWindowsEdition.Text = "Your installation of Windows is 64-bit, so you'll probably want to" & vbCrLf &
                "select ""Program Files"" if you're using any of the configurations listed for it." & vbCrLf &
                "" & vbCrLf &
                "If you're using 32-bit Office on 64-bit Windows, you'll need to select" & vbCrLf &
                "the ""Program Files (x86)"" option."
        Else
            ' If the OS isn't 64-bit, recommend the 32-bit option.
            labelRecommendedWindowsEdition.Text = "Your installation of Windows is 32-bit, so only ""Program Files"" can be used."
        End If
#End Region

#Region "Load the settings from My.Settings."
#Region "Drive letters."
#Region "Set drive letter dropdown to available drives."
        ' Refresh drive letter list.
        RefreshDriveLetters()
#End Region
#Region "Set drive letters in the dropdown."
        ' Fill drive letters in the list.
        FillDriveLettersBasedOnSettings()
#End Region
#End Region

        ' Load the user's settings for My.Settings.userHasOfficeThreeSixFive when the Options window loads.
        ' Simplified from original "If" statement.
        checkboxO365InstallMethod.Checked = My.Settings.userHasOfficeThreeSixFive

        ' Determine which radio button to check for bypassing configured location.
        ' Check the one for all compatible apps if My.Settings.bypassConfiguredLocationForAllApps = True,
        ' check the deprecated/removed apps one if My.Settings.bypassConfiguredLocationForDeprecatedApps = True,
        ' or else check the one to not bypass configured location.
        If My.Settings.bypassConfiguredLocationForAllApps = True Then
            radiobuttonBypassConfiguredLocationAllApps.Checked = True
        ElseIf My.Settings.bypassConfiguredLocationForDeprecatedApps = True Then
            radiobuttonBypassConfiguredLocationDeprecatedApps.Checked = True
        Else
            radiobuttonDontBypassConfiguredLocation.Checked = True
        End If

#Region "Personalization tab."
        ' Load the settings for the Personalization tab.

#Region "Theme Engine settings."
        ' First, see if the theme engine is enabled, and check or uncheck the checkbox.
        ' Simplified from the original "If" statement.
        checkboxEnableThemeEngine.Checked = My.Settings.enableThemeEngine

        ' The theme info controls are updated in the enableOrDisableThemeEngineOptionsWindowControls() sub.
        ' The updating doesn't include the custom theme textbox or the theme list, so do that now.

        ' First, define a delimiter to split the theme list string.
        Dim delimiter As Char = ","c
        ' Second, if the user's chosen theme isn't in My.Resources.themeList_TXT,
        ' append the name of their chosen theme to a string that includes the
        ' actual theme list.
        Dim themeListAppendUserThemeName As String = My.Resources.themeList_TXT
        If Not My.Resources.themeList_TXT.Contains(My.Settings.userChosenTheme) Then
            ' This will add a comma to the end of the string, a new line, and
            ' the current name of the user's theme, if necessary.
            ' Only needed if the user's chosen theme isn't in the theme list.
            themeListAppendUserThemeName = My.Resources.themeList_TXT & "," & vbCrLf &
                                           My.Settings.userChosenTheme
        Else
            ' If the theme list does contain the chosen theme,
            ' just use the theme list.
            themeListAppendUserThemeName = My.Resources.themeList_TXT
        End If
        ' Third, get the theme list as a string without blank lines.
        Dim themeListNotSplit As String = themeListAppendUserThemeName.Replace(vbCrLf, "")
        ' Fourth, split the theme list with the delimiter.
        Dim themeListSplit() As String = themeListNotSplit.Split(delimiter)

        ' Set the theme list datasource to nothing so that
        ' the Options window can be opened more than once per session.
        ' If this isn't done, the app crashes because the datasource is
        ' being modified after it's already set. This allows the Options
        ' window to be themed.
        comboboxThemeList.DataSource = Nothing

        ' Add the range of the split theme list string
        ' to the combobox theme list.
        comboboxThemeList.Items.AddRange(themeListSplit)
        ' Assign the data source of the combobox to the
        ' split theme list string.
        comboboxThemeList.DataSource = themeListSplit
        ' Set the text of the theme list combobox to the
        ' user's chosen theme.
        comboboxThemeList.Text = My.Settings.userChosenTheme
        ' Set the custom theme path textbox to the user's
        ' configured custom theme path.
        textboxCustomThemePath.Text = My.Settings.userCustomThemePath.Replace("""", "")

        ' Check or uncheck the checkbox to use Windows 10 theme settings as needed.
        checkboxMatchWindows10ThemeSettings.Checked = My.Settings.matchWindows10ThemeSettings

        ' Next, enable (or disable, based on user settings) and update the controls.
        enableOrDisableThemeEngineOptionsWindowControls()
#End Region
#Region "Default dark theme."
        ' Load in the settings for default dark theme.
        ' Get the list of dark themes from My.Resources.
        Dim DarkThemesListString() As String = My.Resources.darkthemesList.Split(delimiter)

        ' Clear the dark theme list.
        comboboxDarkThemesForSystemThemeMatchingList.Items.Clear()

        For Each DarkTheme As String In DarkThemesListString
            ' Look in the list of dark themes and add them to the list.
            comboboxDarkThemesForSystemThemeMatchingList.Items.Add(DarkTheme)
        Next

        If Not comboboxDarkThemesForSystemThemeMatchingList.Items.Contains(My.Settings.darkthemeForSystemThemeMatching.ToString) Then
            ' If the specified dark theme isn't in the list, then set the selected dark theme
            ' to ProDark, since that's the default.
            comboboxDarkThemesForSystemThemeMatchingList.SelectedItem = "ProDark"
        Else
            ' Otherwise it's in the list, so select it.
            comboboxDarkThemesForSystemThemeMatchingList.SelectedItem = My.Settings.darkthemeForSystemThemeMatching
        End If
#End Region
#Region "Custom statusbar greeting."
        If My.Settings.userUseCustomStatusbarGreeting = True Then
            ' If the settings are configured to use a custom statusbar greeting,
            ' check the radio button that says to use them.
            radiobuttonCustomStatusbarGreeting.Checked = True
        Else
            ' Otherwise, say that the default greeting is used.
            radiobuttonDefaultStatusbarGreeting.Checked = True
        End If
        ' Now load the user's firstname/nickname for the
        ' personalized statusbar greeting textbox.
        textboxFirstname.Text = My.Settings.userFirstNameForCustomStatusbarGreeting
#End Region
#End Region
#End Region

#Region "Set the DataSource of the comboboxOfficeVersionSelector to a string."
        ' First, see if the user's Office version set in the config file
        ' is contained in My.Resources.supportedOfficeVersionList.
        ' If not, add it to a list.
        If My.Resources.supportedOfficeVersionList.Contains(My.Settings.userOfficeVersion) Then
            ' Create a string with the regular list if the version
            ' in the config file is contained within the supported
            ' version list.
            Dim officeVersionsAvailableString As String() =
                        New String() {"Microsoft Office 2010",
                        "Microsoft Office 2013", "Microsoft Office 2016", "Microsoft Office 2019"}
            comboboxOfficeVersionSelector.DataSource = officeVersionsAvailableString
        ElseIf Not My.Resources.supportedOfficeVersionList.Contains(My.Settings.userOfficeVersion) Then
            ' Otherwise, if the user's configured Office version isn't in the list,
            ' add an extra item to the list.
            Dim officeVersionsAvailableString As String() =
                        New String() {"Microsoft Office 2010",
                        "Microsoft Office 2013", "Microsoft Office 2016", "Microsoft Office 2019", "Office" & My.Settings.userOfficeVersion}
            comboboxOfficeVersionSelector.DataSource = officeVersionsAvailableString
        Else
            ' If neither If statement works, just use the supported list.
            Dim officeVersionsAvailableString As String() =
            New String() {"Microsoft Office 2010",
            "Microsoft Office 2013", "Microsoft Office 2016", "Microsoft Office 2019"}
            comboboxOfficeVersionSelector.DataSource = officeVersionsAvailableString
        End If
#End Region

        ' Load the user's settings for My.Settings.userOfficeVersion when the Options window loads.
        If My.Settings.userOfficeVersion = "14" Then
            comboboxOfficeVersionSelector.Text = "Microsoft Office 2010"
        ElseIf My.Settings.userOfficeVersion = "15" Then
            comboboxOfficeVersionSelector.Text = "Microsoft Office 2013"
        ElseIf My.Settings.userOfficeVersion = "16" Then
            comboboxOfficeVersionSelector.Text = "Microsoft Office 2016"
        ElseIf My.Settings.userOfficeVersion = "16nomsi" Then
            comboboxOfficeVersionSelector.Text = "Microsoft Office 2019"
            ' If none of the values match, just use "Office(version number)"
        Else
            ' Now, set the dropdown box to the non-supported Office version.
            comboboxOfficeVersionSelector.Text = "Office" & My.Settings.userOfficeVersion
        End If

        ' Load the user's settings for My.Settings.cpuIsSixtyFourBit.
        If My.Settings.cpuIsSixtyFourBit = True Then
            radiobuttonUseProgramFilesX86.Checked = True
        ElseIf My.Settings.cpuIsSixtyFourBit = False Then
            radiobuttonUseProgramFiles.Checked = True
        End If

    End Sub
#End Region

#Region "Code that runs when the user clicks the Defaults button."
    Private Sub buttonDefaultSettings_Click(sender As Object, e As EventArgs) Handles buttonDefaultSettings.Click
        ' Reset the "Office Install Drive" to drive C.
        comboboxDriveSelector.Text = "C"

        ' Reset the Office Version Selector to Office 2010.
        comboboxOfficeVersionSelector.Text = "Microsoft Office 2019"

        ' Reset the Office 365 checkbox to unchecked.
        checkboxO365InstallMethod.Checked = False

        ' Reset the PFPath radio buttons to "Program Files".
        radiobuttonUseProgramFiles.Checked = True

        ' Reset the theme to use to Default.
        comboboxThemeList.Text = "Default"

        ' Reset the custom theme path to empty.
        textboxCustomThemePath.Clear()

        ' Reset the theme engine enabled status to disabled.
        checkboxEnableThemeEngine.Checked = False

        ' Reset the match Windows 10 theme settings checkbox to unchecked.
        checkboxMatchWindows10ThemeSettings.Checked = False

        ' Reset the default dark theme dropdown to ProDark.
        comboboxDarkThemesForSystemThemeMatchingList.SelectedItem = "ProDark"

        ' Reset the personalized statusbar firstname/nickname
        ' textbox to empty.
        textboxFirstname.Clear()

        ' Reset the radio button that's checked for personalized
        ' or default statusbar greeting to the default greeting
        ' one.
        radiobuttonDefaultStatusbarGreeting.Checked = True

        ' Reset the bypass configured location for deprecated or
        ' removed apps radio buttons to have the "Don't bypass"
        ' one checked.
        radiobuttonDontBypassConfiguredLocation.Checked = True


        '
        ' This space reserved for more settings.
        '
        '


        MessageBox.Show("Values reset to default. Click the Save button to save changes." & vbCrLf & "Note that Always On Top will" &
                        " not be reset to its default value," & vbCrLf & "along with any other settings modified outside this window." & vbCrLf &
                        "Some settings may require a restart of UXL Launcher, such as enabling or disabling the theme engine.", "Reset UXL Launcher settings",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    End Sub
#End Region

#Region "Get drive letters."
    Private Function GetDriveLetters() As List(Of String)
        ' Basing my code/copying off the answer for getting ready drives here:
        ' https://social.msdn.microsoft.com/Forums/vstudio/en-US/4605ebb2-fc2c-4166-9c42-9025c20eaa1e/populate-combo-box-with-drive-letters
        Dim DriveLettersList As New List(Of String)

        For Each Drive As System.IO.DriveInfo In IO.DriveInfo.GetDrives
            ' Go through the list of drives and add their name
            ' to the list if they're ready.
            If Drive.IsReady = True Then
                DriveLettersList.Add(Drive.Name)
            End If
        Next

        ' Return the list.
        Return DriveLettersList
    End Function

    Private Sub RefreshDriveLetters()
        ' Clear the drive letter list.
        comboboxDriveSelector.Items.Clear()

        For Each DriveLetter As String In GetDriveLetters()
            ' Get the drive letters of all active drives and remove the ":\".
            comboboxDriveSelector.Items.Add(DriveLetter.Replace(":\", String.Empty))
        Next
    End Sub

    Private Sub FillDriveLettersBasedOnSettings()
        ' Make sure the value in here is valid, or else
        ' change the setting to "C" to prevent visual weirdness
        ' when an invalid value show up but does nothing.
        OfficeLocater.CheckOfficeDriveLocationLength()

        ' If the drive the user wants to use isn't available in the dropdown,
        ' add it to the dropdown.
        If Not comboboxDriveSelector.Items.Contains(My.Settings.officeDriveLocation.ToUpperInvariant) Then
            comboboxDriveSelector.Items.Add(My.Settings.officeDriveLocation.ToUpperInvariant)
            ' Sort the list so it doesn't look bad.
            comboboxDriveSelector.Sorted = True
        End If

        ' Select the drive letter in the drive letter dropdown box.
        comboboxDriveSelector.Text = My.Settings.officeDriveLocation
    End Sub

    Private Sub CheckIfDriveIsAvailable(DriveLetter As String)
        ' Check if the drive is available and
        ' show a label if it's not.
        If Not IO.Directory.Exists(DriveLetter & ":\") Then
            labelDriveNotAvailable.Show()
        Else
            labelDriveNotAvailable.Hide()
        End If
    End Sub
#End Region

#Region "Code that runs when the user clicks the Save button."
    Private Sub buttonSaveSettings_Click(sender As Object, e As EventArgs) Handles buttonSaveSettings.Click
        ' Moved saving code to its own sub so that closing the Options
        ' window isn't required when saving.
        ' Make sure it was successful before closing the window.
        If saveStuff() = 0 Then
            Me.Close()
        End If

    End Sub

    Private Function saveStuff() As Integer
        ' Look at the length of the text in the "Office Install Drive" textbox and if there is no text in it then kindly tell the
        ' user they need to type in one drive letter.
        'If SomeIssueHere Then

        ' Return 1, which means there's a problem.
        ' When this happens, code that uses this function
        ' will exit and not continue.

        ' This if...else statement will only be used if there's
        ' something that would use it, but at the moment, it is
        ' considered... irrelevant.
        'Return 1
        'Else
        '
        ' This space reserved for more settings.
        '
        '

#Region "Things to save to My.Settings."
        ' Set My.Settings.officeDriveLocation to the text in textboxOfficeDrive.
        My.Settings.officeDriveLocation = comboboxDriveSelector.Text

        ' My.Settings.userHasOfficeThreeSixFive will be set based on 
        ' the .Checked state of the checkboxO365InstallMethod.
        ' Simplified from original "If" statement.
        My.Settings.userHasOfficeThreeSixFive = checkboxO365InstallMethod.Checked

        ' Set My.Settings.userOfficeVersion to a string based on whatever
        ' comboboxOfficeVersionSelector.Text is set to.
        If comboboxOfficeVersionSelector.Text = "Microsoft Office 2010" Then
            My.Settings.userOfficeVersion = "14"
        ElseIf comboboxOfficeVersionSelector.Text = "Microsoft Office 2013" Then
            My.Settings.userOfficeVersion = "15"
        ElseIf comboboxOfficeVersionSelector.Text = "Microsoft Office 2016" Then
            My.Settings.userOfficeVersion = "16"
        ElseIf comboboxOfficeVersionSelector.Text = "Microsoft Office 2019" Then
            My.Settings.userOfficeVersion = "16nomsi"
        Else
            ' If none of the above Office versions are listed in the dropdown
            ' box, just save the current My.Settings.userOfficeVersion to
            ' itself.
            My.Settings.userOfficeVersion = My.Settings.userOfficeVersion
        End If

        ' Set My.Settings.cpuIsSixtyFourBit to True or False depending on the radio buttons.
        If radiobuttonUseProgramFiles.Checked = True Then
            My.Settings.cpuIsSixtyFourBit = False
        ElseIf radiobuttonUseProgramFilesX86.Checked = True Then
            My.Settings.cpuIsSixtyFourBit = True
        ElseIf radiobuttonCPUIsQBit.Checked = True Then
            ' Focus the "Advanced" tab.
            tabcontrolOptionsWindow.SelectedIndex = 1
            MessageBox.Show("Why do you have a quantum CPU?" & vbCrLf & "(Your currently saved settings will be re-applied because Qubits don't exist for consumers yet.)" & vbCrLf & "(Thank you for finding this hidden radio button!)", "Qubits don't exist for consumers yet.", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            ' Now set the radio buttons to current user settings.
            If My.Settings.cpuIsSixtyFourBit = True Then
                radiobuttonUseProgramFilesX86.Checked = True
                My.Settings.cpuIsSixtyFourBit = True
            ElseIf My.Settings.cpuIsSixtyFourBit = False Then
                radiobuttonUseProgramFiles.Checked = True
                My.Settings.cpuIsSixtyFourBit = False
            End If
        End If

        ' Set My.Settings.enableThemeEngine to True or False based on the checkbox.
        ' Simplified from original "If" statement.
        My.Settings.enableThemeEngine = checkboxEnableThemeEngine.Checked

        ' Set My.Settings.matchWindows10ThemeSettings to True or False based on the checkbox.
        My.Settings.matchWindows10ThemeSettings = checkboxMatchWindows10ThemeSettings.Checked

        ' Save dark theme for system theme matching setting.
        My.Settings.darkthemeForSystemThemeMatching = comboboxDarkThemesForSystemThemeMatchingList.Text

        ' Set My.Settings.userChosenTheme to the text in the theme list dropdown box.
        My.Settings.userChosenTheme = comboboxThemeList.Text

        ' Set My.Settings.userCustomThemePath to the custom theme path textbox.
        My.Settings.userCustomThemePath = textboxCustomThemePath.Text

        ' Set My.Settings.userUseCustomStatusbarGreeting to True or False based
        ' on which radio button is selected.
        If radiobuttonDefaultStatusbarGreeting.Checked = True Then
            My.Settings.userUseCustomStatusbarGreeting = False
        ElseIf radiobuttonCustomStatusbarGreeting.Checked = True Then
            My.Settings.userUseCustomStatusbarGreeting = True
        End If

        ' Set the My.Settings value for the user's firstname/nickname
        ' for personalized statusbar greetings to the textbox
        ' for the name.
        My.Settings.userFirstNameForCustomStatusbarGreeting = textboxFirstname.Text

        ' Save the status of whether to bypass the configured location for
        ' deprecated or removed apps, or all compatible apps.
        My.Settings.bypassConfiguredLocationForDeprecatedApps = radiobuttonBypassConfiguredLocationDeprecatedApps.Checked
        My.Settings.bypassConfiguredLocationForAllApps = radiobuttonBypassConfiguredLocationAllApps.Checked

#End Region

#Region "This is where the settings get saved and things update."
        ' Save settings.
        My.Settings.Save()
        My.Settings.Reload()
        ' Update the user's theme if the theme engine is enabled
        ' and the boolean variable set at the beginning of this
        ' class is set to True.
        If My.Settings.enableThemeEngine = True And boolIsThemeEngineEnabled = True Then

            ' If the user wants to match the Windows 10 theme, then do so,
            ' but if not, then the user's chosen theme will be used instead.
            ' Code moved to its own sub to make editing easier.
            WindowsThemeSettings.checkIfUserWantsToMatchTheme()

        End If
        ' Update the fullLauncherCodeString.
        OfficeLocater.combineStrings()
        ' Update the text in the main window's titlebar.
        aaformMainWindow.updateTitlebarText()
        ' Update main window statusbar label text.
        aaformMainWindow.updateStatusbarText()
        ' Tell the user that settings were saved.
        MessageBox.Show("Settings saved." & vbCrLf &
                        "Some settings may require a restart of UXL Launcher, such as turning the theme engine on or off.", "Save settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
#End Region

        ' Ask the user if they want to restart the application if they
        ' changed something that requires a restart to take effect,
        ' such as if they turned the theme engine on or off.
        If Not boolIsThemeEngineEnabled = My.Settings.enableThemeEngine AndAlso AskToRestartAfterThemeEngineStatusChange = True Then
            Dim msgResult As Integer = MessageBox.Show("Theme engine status changed. Restart UXL Launcher now?", "Save settings",
                MessageBoxButtons.YesNo)
            ' If the user chooses to restart, then we'll restart.
            If msgResult = DialogResult.Yes Then
                Application.Restart()
            Else
                ' If the user clicks "No", then don't bother them after this.
                AskToRestartAfterThemeEngineStatusChange = False
            End If
        End If
        ' Saving was successful.
        ' Return 0.
        ' Fortunately, this was just to save
        ' settings, rather than the entire world.
        Return 0
        'End If
    End Function

    ' Don't bug the user to restart if they clicked "No" in the restart messagebox.
    Dim AskToRestartAfterThemeEngineStatusChange As Boolean = True
#End Region

#Region "Code that runs when the user clicks the Cancel button."
    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        ' Cancel out of the Options window and reload the user's settings
        My.Settings.Reload()
        Me.Close()
    End Sub
#End Region

#Region "Code that runs when the user clicks the 'Test Settings' button."
    Private Sub buttonTestSettings_Click(sender As Object, e As EventArgs) Handles buttonTestSettings.Click
        ' When the user clicks the "Test Settings" button, tell them exactly what will happen
        ' then save the settings and attempt to launch the Office Language Preferences. Using
        ' variables to determine the button the user pressed is what this Stack Overflow answer
        ' suggested: <http://stackoverflow.com/a/2256926>

        Dim msgResult As Integer = MessageBox.Show("Would you like to test your UXL Launcher settings?" &
                        " This will save your settings and attempt to find the Office Language Preferences app" &
                        " in the location configured based on your settings." & vbCrLf &
                        "" & vbCrLf &
                        "If you choose to test your settings and the file is found, a message saying this will appear and you shouldn't have to change your settings. " &
                        "However, you might need to adjust your settings if you see a message saying that we couldn't find the file." & vbCrLf &
                        "" & vbCrLf &
                        "The Options window will close after your settings are saved.",
                        "Test settings", MessageBoxButtons.YesNo)
        If msgResult = DialogResult.Yes Then
            ' Save the user's settings first before testing.
            ' Make sure saving the settings was successful first.
            If saveStuff() = 0 Then
                ' Hide the Options window so it doesn't get in the way.
                Me.Hide()
                ' Now, try to see if SETLANG.EXE is located in the configured directory.
                ' If it is found, show the user a few of the file's properties.
                ' See also this issue: https://github.com/DrewNaylor/UXL-Launcher/issues/96
                If My.Computer.FileSystem.FileExists(OfficeLocater.fullLauncherCodeString & "SETLANG.EXE") Then
                    ' If the file for Office Language Preferences was found, tell the user.
                    MessageBox.Show(Me, "Office Language Preferences has been found in the configured location." &
                                " You shouldn't have to change your Office-related settings further unless you encounter problems or upgrade Office." & vbCrLf &
                                vbCrLf &
                                "Configured location: " & OfficeLocater.fullLauncherCodeString,
                                "Test settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' If it's not found, let the user know and give them the option to open
                    ' the Options window to change their settings if they want to.
                    Dim msgResultDidntFindOfficeLangPrefs As Integer = MessageBox.Show(Me, "We couldn't find Office Language Preferences in the configured location." &
                                                                                   " Would you like to open the Options window to change your settings?" & vbCrLf &
                                                                                   vbCrLf &
                                                                                   "Configured location: " & OfficeLocater.fullLauncherCodeString,
                                                                                   "Test settings", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

                    ' If the user clicks "Yes", show the Options window. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
                    If msgResultDidntFindOfficeLangPrefs = DialogResult.Yes Then
                        Me.Show()

                    Else
                        ' If the user doesn't want to open the Options window, make
                        ' sure that it's closed.
                        Me.Close()
                    End If
                End If
            Else
                ' If we couldn't save the settings, don't test them.
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "Personalization tab."
#Region "Code that runs when theme list text updates."
    Private Sub comboboxThemeList_TextChanged(sender As Object, e As EventArgs) Handles comboboxThemeList.TextChanged
        ' When the theme list combobox text changes, get the info
        ' for the theme that's currently selected in the combobox.

        ' Code moved into its own sub to make calling easier.
        updateThemeInfo()
    End Sub
    Private Sub comboboxThemeList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxThemeList.SelectedIndexChanged
        ' This code is related to the comboboxThemeList_TextChanged
        ' event handler above.

        ' When the theme list combobox selected index changes
        ' by the user doing something such as pressing
        ' the up and down arrow keys, get the info
        ' for the theme that's currently selected in the combobox.
        updateThemeInfo()
    End Sub

    Private Sub updateThemeInfo()
        ' This code was moved into its own sub to make
        ' calling it from other places easier.
        ' Basically, this code takes the text currently
        ' in the theme list combobox and gets the theme info
        ' for that theme and shows it to the user in the theme
        ' info text box.
        ' First, see if the theme list textbox isn't custom.

        If Not comboboxThemeList.Text = "(Custom)" Then
            ' First, disable the custom theme path textbox and the "Browse..."
            ' button if the theme list combobox isn't "(Custom)"
            textboxCustomThemePath.Enabled = False
            buttonCustomThemesBrowse.Enabled = False

            ' If it's not "(Custom)", send the text to the getThemeInfo function.
            ' "Theme_XML" may need to be added to the theme text first.

            ' Create a temporary XML document.
            Dim tempXml As XmlDocument = New XmlDocument
            ' Create a temporary string that adds "Theme_XML" or "_XML" as needed.
            Dim tempThemeXmlFileType As String = ""
            ' Load into the XML document the correct theme file.

            ' If the theme name doesn't end with "Theme" and "_XML",
            ' add "Theme_XML".
            If Not comboboxThemeList.Text.EndsWith("Theme") And Not comboboxThemeList.Text.EndsWith("_XML") Then
                tempThemeXmlFileType = "Theme_XML"
                ' Otherwise, if there's no "_XML" at the end, add it.
            ElseIf comboboxThemeList.Text.EndsWith("Theme") Then
                tempThemeXmlFileType = "_XML"
            Else
                ' Otherwise, just make the string empty.
                tempThemeXmlFileType = ""
            End If

            ' First, catch ArgumentNullException exceptions if, say,
            ' the text in the theme list combobox isn't exactly correct
            ' and doesn't match the theme file name.
            Try
                tempXml.LoadXml(My.Resources.ResourceManager.GetString(comboboxThemeList.Text & tempThemeXmlFileType))
            Catch ex As System.ArgumentNullException
                ' Also catch XmlException.
                ' This can be caused by using the "None" theme that
                ' has purposefully invalid XML just to make sure there
                ' aren't any problems in the theme engine that might
                ' slip by when using valid XML.
            Catch ex As System.Xml.XmlException
            End Try
            ' Put the theme info into the theme info textbox.
            textboxThemeInfo.Text = UXLLauncher_ThemeEngine.getThemeFileInfo(tempXml, False, "")

            ' If the theme list textbox is "(Custom)", then use the custom theme path.
        ElseIf comboboxThemeList.Text = "(Custom)" Then
            ' First, enable the custom theme path textbox and the "Browse..."
            ' button if the theme list combobox is "(Custom)" as long as custom
            ' themes are allowed.
            If My.Settings.allowCustomThemes = True AndAlso checkboxMatchWindows10ThemeSettings.Checked = False Then
                textboxCustomThemePath.Enabled = True
                buttonCustomThemesBrowse.Enabled = True
            Else
                textboxCustomThemePath.Enabled = False
                buttonCustomThemesBrowse.Enabled = False
            End If

            ' If it is "(Custom)", send the custom theme path below the theme list
            ' to the getThemeInfo function.

            ' This code has been moved to the sub below to be able to call it from
            ' two places when needed.
            ' Make sure there's text in the custom theme path box before changing
            ' the text in the details textbox.
            customThemePathInfoUpdater()

        End If
    End Sub

    Private Sub customThemePathInfoUpdater()
        ' This code is the ElseIf comboboxThemeList.Text = "(Custom)"
        ' theme info textbox updater from above, but moved here so that
        ' it can also be called from the custom theme path textbox
        ' TextChanged event.

        ' First, update the tooltip for this textbox.
        tooltipCustomThemePath.SetToolTip(textboxCustomThemePath, textboxCustomThemePath.Text)

        ' Next, make sure that the theme list is only using custom themes.
        If comboboxThemeList.Text = "(Custom)" Then
            ' Only update the text if there's something in the custom theme path textbox.
            If textboxCustomThemePath.Text.Length > 0 Or My.Settings.allowCustomThemes = False Then
                ' Create a temporary XML document.
                Dim tempXml As XmlDocument = New XmlDocument
                ' Also create a temporary string that removes quotation marks.
                ' This string takes the current text in the custom theme path
                ' textbox and creates a new string replacing double-quotes.
                Dim tempRemoveQuotesInPath As String = textboxCustomThemePath.Text.Replace("""", "")
                ' Also replace text currently in the textbox with a string
                ' that doesn't have double quotes.
                textboxCustomThemePath.Text = tempRemoveQuotesInPath
                ' Load into the XML document the correct theme file
                ' if it exists.
                If System.IO.File.Exists(tempRemoveQuotesInPath) Then
                    Try
                        tempXml.Load(tempRemoveQuotesInPath)
                        ' Catch XmlException.
                        ' This can be caused by using the "None" theme that
                        ' has purposefully invalid XML just to make sure there
                        ' aren't any problems in the theme engine that might
                        ' slip by when using valid XML.
                    Catch ex As System.Xml.XmlException
                        ' Also catch UnauthorizedAccessException.
                        ' If this exception occurs, it may be because
                        ' a file was accessed that's not allowed to be accessed,
                        ' such as a file in the Windows directory.
                    Catch ex As System.UnauthorizedAccessException
                    End Try
                End If
                ' Get the theme's info.
                textboxThemeInfo.Text = UXLLauncher_ThemeEngine.getThemeFileInfo(tempXml, True, tempRemoveQuotesInPath)
            Else
                ' Nothing in the textbox, so let the user know how they can use a custom theme.
                textboxThemeInfo.Text = "You can use a custom theme by clicking Browse... and picking a custom theme file from the file system or by pasting the custom theme path in the custom theme path textbox."
            End If
        End If
    End Sub

    Private Sub textboxCustomThemePath_TextChanged(sender As Object, e As EventArgs) Handles textboxCustomThemePath.TextChanged
        ' When text in the custom theme path textbox is changed,
        ' update the theme info textbox.

        ' Code is in its own sub to make calling easier.
        customThemePathInfoUpdater()
    End Sub
#End Region
#Region "Code that runs when enabling/disabling theme engine checkbox."
    Private Sub checkboxEnableThemeEngine_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxEnableThemeEngine.CheckedChanged
        ' Enable or disable the theme engine-related controls when
        ' the checkbox is checked or unchecked, respectively.
        ' Afterward, update relevant controls.

        ' Code moved to its own sub to make calling easier.
        enableOrDisableThemeEngineOptionsWindowControls()
    End Sub

    Private Sub enableOrDisableThemeEngineOptionsWindowControls()
        ' This sub enables or disables the theme engine-related
        ' controls in the Options window based on whether the
        ' checkbox to enable the theme engine is enabled or not.
        If checkboxEnableThemeEngine.Checked = True Then
            ' If it's checked, enable the controls.
            comboboxThemeList.Enabled = True
            checkboxMatchWindows10ThemeSettings.Enabled = True
            textboxCustomThemePath.Enabled = True
            buttonCustomThemesBrowse.Enabled = True
            ' Now, update theme-related controls.
            updateThemeInfo()
        Else
            ' Otherwise, disable the controls.
            comboboxThemeList.Enabled = False
            checkboxMatchWindows10ThemeSettings.Enabled = False
            textboxCustomThemePath.Enabled = False
            buttonCustomThemesBrowse.Enabled = False
            textboxThemeInfo.Text = "The UXL Launcher Theme Engine is disabled. When enabled, it allows you to change the colors of the UXL Launcher main window and Quickmenu (the system tray icon context menu) via predefined or custom themes."
        End If

        ' When checking this box, the theme list dropdown will be disabled
        ' since the theme will be changed at startup based on the Windows 10
        ' settings.
        If checkboxMatchWindows10ThemeSettings.Checked = True Then
            comboboxThemeList.Enabled = False
            textboxCustomThemePath.Enabled = False
            buttonCustomThemesBrowse.Enabled = False
            ' Now, update theme-related controls.
            updateThemeInfo()
        ElseIf checkboxMatchWindows10ThemeSettings.Checked = True And checkboxEnableThemeEngine.Checked = True Then
            comboboxThemeList.Enabled = True
            textboxCustomThemePath.Enabled = True
            buttonCustomThemesBrowse.Enabled = True
            ' Now, update theme-related controls.
            updateThemeInfo()
        End If
    End Sub

#End Region

    Private Sub checkboxMatchWindows10ThemeSettings_CheckedChanged(sender As Object, e As EventArgs) Handles checkboxMatchWindows10ThemeSettings.CheckedChanged
        ' When checking this box, the theme list dropdown will be disabled
        ' since the theme will be changed at startup based on the Windows 10
        ' settings.

        ' Code moved to its own sub to make calling easier.
        enableOrDisableThemeEngineOptionsWindowControls()
    End Sub

#Region "Code that runs when clicking the Browse... button next to the custom theme path."
    Private Sub buttonCustomThemesBrowse_Click(sender As Object, e As EventArgs) Handles buttonCustomThemesBrowse.Click
        ' When the user clicks the "Browse..." button, show an open file dialog
        ' that allows the user to browse to the theme file they want to use as
        ' a custom theme and update the custom theme path textbox with their new
        ' theme choice.
        If openfiledialogBrowseCustomThemeFile.ShowDialog = DialogResult.OK Then
            textboxCustomThemePath.Text = openfiledialogBrowseCustomThemeFile.FileName
        End If
    End Sub
#End Region
#Region "Custom statusbar greeting controls."
#Region "Clicking the radio buttons for use default greeting or use custom greeting."
    Private Sub radiobuttonCustomStatusbarGreeting_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonCustomStatusbarGreeting.CheckedChanged
        ' When the CheckChanged event fires on this control,
        ' either enable or disable the firstname/nickname
        ' textbox and the "Clear" button.

        ' This is the sub for the "Use personalized greeting"
        ' radio button.

        ' Code moved to its own sub for easier modification.
        enableOrDisableCustomStatusbarGreetingControls()
    End Sub

    Private Sub radiobuttonDefaultStatusbarGreeting_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonDefaultStatusbarGreeting.CheckedChanged
        ' When the CheckChanged event fires on this control,
        ' either enable or disable the firstname/nickname
        ' textbox and the "Clear" button.

        ' This is the sub for the "Use default greeting"
        ' radio button.

        ' Code moved to its own sub for easier modification.
        enableOrDisableCustomStatusbarGreetingControls()
    End Sub

    Private Sub enableOrDisableCustomStatusbarGreetingControls()
        ' When the CheckChanged event fires on the related controls,
        ' either enable or disable the firstname/nickname
        ' textbox and the "Clear" button.
        If radiobuttonCustomStatusbarGreeting.Checked = True Then
            ' If the radio button to use the custom statusbar greeting
            ' is checked, enable the firstname/nickname textbox and
            ' the "Clear" button.
            textboxFirstname.Enabled = True
            buttonClearFirstname.Enabled = True
        Else
            ' Otherwise, disable those controls.
            textboxFirstname.Enabled = False
            buttonClearFirstname.Enabled = False
        End If
    End Sub
#End Region
#Region "Clicking the Clear button next to the firstname textbox."
    Private Sub buttonClearFirstname_Click(sender As Object, e As EventArgs) Handles buttonClearFirstname.Click
        ' When this button is clicked, the firstname/nickname textbox
        ' will be cleared and the focus will be set to the textbox.
        textboxFirstname.Clear()
        textboxFirstname.Focus()
    End Sub


#End Region
#End Region
#End Region

    Private Sub comboboxOfficeVersionSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxOfficeVersionSelector.SelectedIndexChanged
        If comboboxOfficeVersionSelector.SelectedIndex = 3 Then
            ' Office versions newer than 2016 don't support MSI
            ' and default to C2R, so this checkbox is not necessary.
            labelOffice365Compatibility.Hide()
            checkboxO365InstallMethod.Hide()
        Else
            ' Office versions older than 2019 support MSI
            ' so this checkbox may be necessary.
            labelOffice365Compatibility.Show()
            checkboxO365InstallMethod.Show()
        End If
    End Sub

    Private Sub tabcontrolOptionsWindow_MouseWheel(sender As Object, e As MouseEventArgs) Handles tabcontrolOptionsWindow.MouseWheel
        ' Switch tabs on scroll.
        libscrollswitchtabs.ScrollSwitchTabs.switch(tabcontrolOptionsWindow, e)
    End Sub

    Private Sub buttonRefreshDriveLetterList_Click(sender As Object, e As EventArgs) Handles buttonRefreshDriveLetterList.Click
        ' Refresh the drive letters list with currently-available drive letters.
        RefreshDriveLetters()
        ' Fill the list of drive letters and set the selected letter based on the
        ' settings.
        FillDriveLettersBasedOnSettings()
    End Sub

    Private Sub comboboxDriveSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxDriveSelector.SelectedIndexChanged
        ' Send the currently-selected drive letter to the
        ' code that hides or shows the "drive available"
        ' label.
        CheckIfDriveIsAvailable(comboboxDriveSelector.Text)
    End Sub

    Private Sub buttonUpgradeSettings_Click(sender As Object, e As EventArgs) Handles buttonUpgradeSettings.Click
        ' Ask the user if they want to migrate their settings from the previous version.
        Dim msgResult As Integer = MessageBox.Show("Would you like to migrate your settings from the previous version? This will overwrite your current settings. We'll restart when it's done.",
                        "Migrate settings", MessageBoxButtons.YesNo)
        If msgResult = DialogResult.Yes Then
            ' If they say yes, upgrade their settings and stuff.
            My.Settings.Upgrade()
            My.Settings.Save()
            My.Settings.Reload()
            ' Settings are now migrated.
            MessageBox.Show("Settings migrated. We'll restart when you click OK.", "Migrate settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' We still have to restart for them to take effect.
            Application.Restart()
        Else
            ' If they say no, tell them that they weren't migrated.
            MessageBox.Show("Settings not migrated.", "Migrate settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class