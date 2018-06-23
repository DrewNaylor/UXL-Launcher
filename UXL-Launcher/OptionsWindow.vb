'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2018 Drew Naylor
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



Imports System.ComponentModel
Imports System.Xml

Public Class aaformOptionsWindow

    ' Create a boolean variable that sees if the theme engine is enabled.
    ' It's used when saving the settings to see if the theme engine should
    ' update the theme if this variable and the related My.Settings
    ' value are equal. If not, it won't update.
    Dim boolIsThemeEngineEnabled As Boolean = My.Settings.enableThemeEngine

#Region "Code to run when opening the Options window."

    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load



#Region "Load the settings from My.Settings."
        ' Load the user's settings for My.Settings.officeDriveLocation when the Options window loads.
        textboxOfficeDrive.Text = My.Settings.officeDriveLocation

        ' Load the user's settings for My.Settings.userHasOfficeThreeSixFive when the Options window loads.
        If My.Settings.userHasOfficeThreeSixFive = True Then
            checkboxO365InstallMethod.Checked = True
        ElseIf My.Settings.userHasOfficeThreeSixFive = False Then
            checkboxO365InstallMethod.Checked = False
        End If

        ' Load the user's settings for My.Settings.installedViaMSIPackage.
        If My.Settings.installedViaMSIPackage = True Then
            checkboxMSIInstallMethod.Checked = True
        ElseIf My.Settings.installedViaMSIPackage = False Then
            checkboxMSIInstallMethod.Checked = False
        End If

#Region "Personalization tab."
        ' Load the settings for the Personalization tab.

#Region "Theme Engine settings."
        ' First, see if the theme engine is enabled.
        If My.Settings.enableThemeEngine = True Then
            ' If it is, check the "Enable Theme Engine" checkbox.
            checkboxEnableThemeEngine.Checked = True
        ElseIf My.Settings.enableThemeEngine = False Then
            ' If it's not enabled, uncheck the checkbox.
            checkboxEnableThemeEngine.Checked = False
        End If

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

        ' Next, enable (or disable, based on user settings) and update the controls.
        enableOrDisableThemeEngineOptionsWindowControls()
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
        ' Create the string for the comboboxOfficeVersionSelector and
        ' set the DataSource of the combobox to that string.
        Dim officeVersionsAvailableString As String() =
            New String() {"Microsoft Office 2010",
            "Microsoft Office 2013", "Microsoft Office 2016"}
        comboboxOfficeVersionSelector.DataSource = officeVersionsAvailableString
#End Region

        ' Load the user's settings for My.Settings.userOfficeVersion when the Options window loads.
        If My.Settings.userOfficeVersion = "14" Then
            comboboxOfficeVersionSelector.Text = "Microsoft Office 2010"
        ElseIf My.Settings.userOfficeVersion = "15" Then
            comboboxOfficeVersionSelector.Text = "Microsoft Office 2013"
        ElseIf My.Settings.userOfficeVersion = "16" Then
            comboboxOfficeVersionSelector.Text = "Microsoft Office 2016"
        End If

        ' Load the user's settings for My.Settings.cpuIsSixtyFourBit.
        If My.Settings.cpuIsSixtyFourBit = True Then
            radiobuttonCPUIs64Bit.Checked = True
        ElseIf My.Settings.cpuIsSixtyFourBit = False Then
            radiobuttonCPUIs32Bit.Checked = True
        End If

    End Sub
#End Region



#Region "Code that runs when the user types stuff in the textboxOfficeDrive."
    Private Sub textboxOfficeDrive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxOfficeDrive.KeyPress
        ' This sub is to make sure that people are only entering letters. Credit goes to this post on Stack Overflow
        ' for this solution.  <http://stackoverflow.com/a/31161593>
        ' 
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then

            'Display a message box when the user presses characters that aren't allowed.
            e.Handled = True
            MessageBox.Show("This textbox only accepts letters such as A, B, C etc." & vbCrLf & "Click the Clear Textbox button to empty the textbox." _
                            & vbCrLf & "The textbox contents will be reset to drive C.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            'Change the textbox for choosing the drive Office is installed on back to drive C.
            textboxOfficeDrive.Text = "C"
        End If
    End Sub
#End Region

#Region "Code that runs when the user clicks the Defaults button."
    Private Sub buttonDefaultSettings_Click(sender As Object, e As EventArgs) Handles buttonDefaultSettings.Click
        ' Reset the "Office Install Drive" to drive C.
        textboxOfficeDrive.Text = "C"

        ' Reset the Office Version Selector to Office 2010.
        comboboxOfficeVersionSelector.Text = "Microsoft Office 2010"

        ' Reset the Office 365 checkbox to unchecked.
        checkboxO365InstallMethod.Checked = False

        ' Reset the CPUType radio buttons to 64-bit.
        radiobuttonCPUIs64Bit.Checked = True

        ' Reset the MSI Install Method to unchecked.
        checkboxMSIInstallMethod.Checked = False

        ' Reset the theme to use to Default.
        comboboxThemeList.Text = "Default"

        ' Reset the custom theme path to empty.
        textboxCustomThemePath.Clear()

        ' Reset the theme engine enabled status to disabled.
        checkboxEnableThemeEngine.Checked = False

        ' Reset the personalized statusbar firstname/nickname
        ' textbox to empty.
        textboxFirstname.Clear()

        ' Reset the radio button that's checked for personalized
        ' or default statusbar greeting to the default greeting
        ' one.
        radiobuttonDefaultStatusbarGreeting.Checked = True



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

#Region "Code that runs when the user clicks the Save button."
    Private Sub buttonSaveSettings_Click(sender As Object, e As EventArgs) Handles buttonSaveSettings.Click

        ' Look at the length of the text in the "Office Install Drive" textbox and if there is no text in it then kindly tell the
        ' user they need to type in one drive letter.
        If textboxOfficeDrive.Text.Length = 0 Then
            MessageBox.Show("You must type one letter into the drive letter text box.", "Textbox length requirement not met", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' After telling them that, reset the "Office Install Drive" textbox to default.
            textboxOfficeDrive.Text = "C"
        Else
            '
            ' This space reserved for more settings.
            '
            '
#Region "Determine whether or not the settings the user chose are potentially incompatible."

            ' If the Office Version Selector combobox is set to Office 2010 and the Office 365 checkbox is checked
            ' or the Office Version Selector combobox is set to Office 2016 and the Office 365 checkbox is UNchecked,
            ' then tell the user that the combination isn't tested and might not work.

            If comboboxOfficeVersionSelector.Text = "Microsoft Office 2010" And checkboxO365InstallMethod.Checked = True Then
                MessageBox.Show("Note that the combination of the Microsoft Office version you chose and installation method are untested and might not work properly." _
                                , "Potentially incompatible settings detected" _
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
#End Region

#Region "Things to save to My.Settings."
            ' Set My.Settings.officeDriveLocation to the text in textboxOfficeDrive.
            My.Settings.officeDriveLocation = textboxOfficeDrive.Text

            ' My.Settings.userHasOfficeThreeSixFive will be set based on 
            ' the .Checked state of the checkboxO365InstallMethod.
            If checkboxO365InstallMethod.Checked = True Then
                My.Settings.userHasOfficeThreeSixFive = True
            ElseIf checkboxO365InstallMethod.Checked = False Then
                My.Settings.userHasOfficeThreeSixFive = False
            End If

            ' My.Settings.installedViaMSIPackage will be set based on
            ' the .Checked state of the checkboxMSIInstallMethod.
            If checkboxMSIInstallMethod.Checked = True Then
                My.Settings.installedViaMSIPackage = True
            ElseIf checkboxMSIInstallMethod.Checked = False Then
                My.Settings.installedViaMSIPackage = False
            End If

            ' Set My.Settings.userOfficeVersion to a string based on whatever
            ' comboboxOfficeVersionSelector.Text is set to.
            If comboboxOfficeVersionSelector.Text = "Microsoft Office 2010" Then
                My.Settings.userOfficeVersion = "14"
            ElseIf comboboxOfficeVersionSelector.Text = "Microsoft Office 2013" Then
                My.Settings.userOfficeVersion = "15"
            ElseIf comboboxOfficeVersionSelector.Text = "Microsoft Office 2016" Then
                My.Settings.userOfficeVersion = "16"
            End If

            ' Set My.Settings.cpuIsSixtyFourBit to True or False depending on the radio buttons.
            If radiobuttonCPUIs32Bit.Checked = True Then
                My.Settings.cpuIsSixtyFourBit = False
            ElseIf radiobuttonCPUIs64Bit.Checked = True Then
                My.Settings.cpuIsSixtyFourBit = True
            ElseIf radiobuttonCPUIsQBit.Checked = True Then
                MessageBox.Show("Why do you have a quantum CPU?", "Qubits don't exist for consumers yet.", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                If My.Settings.cpuIsSixtyFourBit = True Then
                    radiobuttonCPUIs64Bit.Checked = True
                    My.Settings.cpuIsSixtyFourBit = True
                ElseIf My.Settings.cpuIsSixtyFourBit = False Then
                    radiobuttonCPUIs32Bit.Checked = True
                    My.Settings.cpuIsSixtyFourBit = False
                End If
            End If

            ' Set My.Settings.enableThemeEngine to True or False based on the checkbox.
            If checkboxEnableThemeEngine.Checked = True Then
                My.Settings.enableThemeEngine = True
            ElseIf checkboxEnableThemeEngine.Checked = False Then
                ' If it's unchecked, set the My.Settings variable to False.
                My.Settings.enableThemeEngine = False
            End If

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

#End Region

#Region "This is where the settings get saved and things update."
            ' Save settings.
            My.Settings.Save()
            My.Settings.Reload()
            ' Update the user's theme if the theme engine is enabled
            ' and the boolean variable set at the beginning of this
            ' class is set to True.
            If My.Settings.enableThemeEngine = True And boolIsThemeEngineEnabled = True Then
                UXLLauncher_ThemeEngine.themeEngine_ChooseUserTheme()
            End If
            ' Update the fullLauncherCodeString.
            OfficeLocater.combineStrings()
            ' Update the text in the main window's titlebar.
            aaformMainWindow.Text = "UXL Launcher Version " & My.Application.Info.Version.ToString & " (" & My.Resources.isStable & ", " & OfficeLocater.titlebarBitModeString & " Mode)"
            ' Tell the user that settings were saved.
            MessageBox.Show("Settings saved." & vbCrLf &
                        "Some settings may require a restart of UXL Launcher, such as enabling or disabling the theme engine.", "Save settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
#End Region
            Me.Close()
        End If
    End Sub
#End Region

#Region "Code that runs when the user clicks the Cancel button."
    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        ' Cancel out of the Options window and reload the user's settings
        My.Settings.Reload()
        Me.Close()
    End Sub
#End Region

#Region "Code that runs when the user clicks the Clear Textbox button."
    Private Sub buttonClearTextbox_Click(sender As Object, e As EventArgs) Handles buttonClearTextbox.Click
        ' Clear the OfficeDrive textbox and set focus to it.
        textboxOfficeDrive.Text = ""
        textboxOfficeDrive.Select()
    End Sub
#End Region

#Region "Code that runs when the user clicks the 'View system info' button on the Advanced tab."
    Private Sub buttonHelpMeCPUType_Click(sender As Object, e As EventArgs) Handles buttonHelpMeCPUType.Click
        ' When the user clicks the "View system info" button, tell them exactly what will happen
        ' then open the System Info page in the Control Panel. Using
        ' variables to determine the button the user pressed is what this Stack Overflow answer
        ' suggested: <http://stackoverflow.com/a/2256926>
        Dim msgResult As Integer = MessageBox.Show("Would you like to open the System Info page in the Control Panel?" & vbCrLf &
                        "" & vbCrLf &
                        "If you see " & """32-bit Operating System""" & " in the System Info page, choose the 32-bit Windows option in the Options window." & vbCrLf &
                        "" & vbCrLf &
                        "If you see " & """64-bit Operating System""" & " in the System Info page, choose the 64-bit Windows option in the Options window.",
                        "View system info", MessageBoxButtons.YesNo)
        If msgResult = DialogResult.Yes Then
            ' Open the System Properties Control Panel page if the user clicked Yes.
            Process.Start("control.exe", "system")
        End If
    End Sub
#End Region

#Region "Code that runs when the user clicks the 'Test Settings' button."
    Private Sub buttonTestSettings_Click(sender As Object, e As EventArgs) Handles buttonTestSettings.Click
        ' When the user clicks the "Test Settings" button, tell them exactly what will happen
        ' then save the settings and attempt to launch the Office Language Preferences. Using
        ' variables to determine the button the user pressed is what this Stack Overflow answer
        ' suggested: <http://stackoverflow.com/a/2256926>

        Dim msgResult As Integer = MessageBox.Show("Would you like to test your UXL Launcher settings?" &
                        " This will save your settings and attempt to launch the Office Language Options app." & vbCrLf &
                        "" & vbCrLf &
                        "If you choose to test your settings and no message appears, assume that it worked. " &
                        "However, you might need to adjust your settings if you see a message saying that we couldn't find the file." & vbCrLf &
                        "" & vbCrLf &
                        "Close the Office Language Preferences window if it appears." & vbCrLf &
                        "" & vbCrLf &
                        "The Options window will close after your settings are saved.",
                        "Test settings", MessageBoxButtons.YesNo)
        If msgResult = DialogResult.Yes Then
            buttonSaveSettings.PerformClick()
            Me.Hide()
            LaunchApp.LaunchOfficeLangPrefs()
        End If
    End Sub
#End Region

#Region "Workaround Microsoft's weird decision to put Office 2013 C2R in a different folder from MSI and change available checkboxes."
    Private Sub comboboxOfficeVersionSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxOfficeVersionSelector.SelectedIndexChanged
        ' When the user chooses their Office version, if the version is set to Office 2013, 
        ' make the Office 365 install method checkbox get disabled and show the MSI install
        ' method checkbox. If Office 2013 isn't selected, then hide the MSI install method
        ' checkbox and enable the Office 365 install method checkbox.
        If comboboxOfficeVersionSelector.Text = "Microsoft Office 2013" Then
            checkboxO365InstallMethod.Enabled = False
            checkboxMSIInstallMethod.Enabled = True
        Else
            checkboxO365InstallMethod.Enabled = True
            checkboxMSIInstallMethod.Enabled = False
        End If
    End Sub
#End Region

#Region "Windows edition choice linklabel."
    Private Sub linklabelWindowsEditionLearnMore_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabelWindowsEditionLearnMore.LinkClicked
        ' Send the user to the information page for the Windows edition radiobuttons.
        Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/115#issuecomment-395917017")
    End Sub
#End Region

#Region "Linklabel for the 365/MSI install method checkboxes."
    Private Sub linklabelCheckboxesToBeCombined_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklabelCheckboxesToBeCombined.LinkClicked
        ' Send the user to the information page for the checkboxes
        ' that will be combined.
        Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/100#issuecomment-395926431")
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
            If My.Settings.allowCustomThemes = True Then
                textboxCustomThemePath.Enabled = True
                buttonCustomThemesBrowse.Enabled = True
            End If

            ' If it is "(Custom)", send the custom theme path below the theme list
            ' to the getThemeInfo function.

            ' This code has been moved to the sub below to be able to call it from
            ' two places when needed.
            customThemePathInfoUpdater()

        End If
    End Sub

    Private Sub customThemePathInfoUpdater()
        ' This code is the ElseIf comboboxThemeList.Text = "(Custom)"
        ' theme info textbox updater from above, but moved here so that
        ' it can also be called from the custom theme path textbox
        ' TextChanged event.

        ' First, make sure that the theme list is only using custom themes.
        If comboboxThemeList.Text = "(Custom)" Then
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
            textboxCustomThemePath.Enabled = True
            buttonCustomThemesBrowse.Enabled = True
            ' Now, update theme-related controls.
            updateThemeInfo()
        Else
            ' Otherwise, disable the controls.
            comboboxThemeList.Enabled = False
            textboxCustomThemePath.Enabled = False
            buttonCustomThemesBrowse.Enabled = False
            textboxThemeInfo.Text = "The UXL Launcher Theme Engine is disabled. When enabled, it allows you to change the colors of the UXL Launcher main window and Quickmenu (the system tray icon context menu) via predefined or custom themes."
        End If
    End Sub
#End Region
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

End Class