'UXL Launcher - Launchers for Microsoft Office apps in one place.
'Copyright (C) 2013-2016  Drew Naylor
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



Imports System.ComponentModel

Public Class aaformOptionsWindow


#Region "Code to run when opening the Options window."

    Private Sub OptionsWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

#Region "Always On Top override code for opening dialog boxes."
        ' If Always On Top is turned on, then turn it off when the Options window is opened.

        If My.Settings.alwaysOnTop = True Then
            aaformMainWindow.TopMost = False
        ElseIf My.Settings.alwaysOnTop = False Then
            aaformMainWindow.TopMost = False
        End If

        ' Debug labels for Always On Top code on the main form.
        aaformMainWindow.debugLabelForAlwaysOnTop.Text = "menubar button checkstate: " & aaformMainWindow.menubarAlwaysOnTopButton.CheckState & vbNewLine &
        "alwaysOnTop setting: " & My.Settings.alwaysOnTop & vbNewLine &
        "main window TopMost: " & aaformMainWindow.TopMost
#End Region

#Region "Load the settings from My.Settings."
        ' Load the user's settings for officeDriveLocation when the Options window loads.
        textboxOfficeDrive.Text = My.Settings.officeDriveLocation

        ' Load the user's settings for userHasOfficeThreeSixFive when the Options window loads.
        If My.Settings.userHasOfficeThreeSixFive = True Then
            checkboxUserHasO365.Checked = True
        ElseIf My.Settings.userHasOfficeThreeSixFive = False Then
            checkboxUserHasO365.Checked = False
        End If
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


#Region "Code to run when closing the Options window."

    Private Sub aaformOptionsWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


#Region "Always On Top override code for closing dialog boxes, including debug code."

        ' When the Options window is closing, tell the main window to be Always On Top if My.Settings.alwaysOnTop is set to True.
        If My.Settings.alwaysOnTop = True Then
            aaformMainWindow.TopMost = True
        ElseIf My.Settings.alwaysOnTop = False Then
            aaformMainWindow.TopMost = False
        End If

        ' Debug label for the Always On Top feature.
        aaformMainWindow.debugLabelForAlwaysOnTop.Text = "menubar button checkstate: " & aaformMainWindow.menubarAlwaysOnTopButton.CheckState & vbNewLine &
        "alwaysOnTop setting: " & My.Settings.alwaysOnTop & vbNewLine &
        "main window TopMost: " & aaformMainWindow.TopMost
    End Sub



#End Region
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
        checkboxUserHasO365.Checked = False

        ' Reset the CPUType radio buttons to 64-bit.
        radiobuttonCPUIs64Bit.Checked = True

        '
        ' This space reserved for more settings.
        '
        '


        MessageBox.Show("Values reset to default. Click the Save button to save changes." & vbCrLf & "Note that Always On Top will not be reset to its default value.", "Reset UXL Launcher settings", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

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

            If comboboxOfficeVersionSelector.Text = "Microsoft Office 2010" And checkboxUserHasO365.Checked = True _
                Or comboboxOfficeVersionSelector.Text = "Microsoft Office 2016" And checkboxUserHasO365.Checked = False Then
                MessageBox.Show("Note that the combination of the Microsoft Office version you chose and installation method are untested and might not work properly." _
                                , "Potentially incompatible settings detected!" _
                                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
#End Region

#Region "Things to save to My.Settings."
            ' Set My.Settings.officeDriveLocation to the text in textboxOfficeDrive.
            My.Settings.officeDriveLocation = textboxOfficeDrive.Text

            ' My.Settings.userHasOfficeThreeSixFive will be set based on 
            ' the .Checked state of the checkboxUserHasO365.
            If checkboxUserHasO365.Checked = True Then
                My.Settings.userHasOfficeThreeSixFive = True
            ElseIf checkboxUserHasO365.Checked = False Then
                My.Settings.userHasOfficeThreeSixFive = False
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
                MessageBox.Show("Why do you have a quantum CPU?", "Q-Bits don't exist for consumers yet.", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                If My.Settings.cpuIsSixtyFourBit = True Then
                    radiobuttonCPUIs64Bit.Checked = True
                    My.Settings.cpuIsSixtyFourBit = True
                ElseIf My.Settings.cpuIsSixtyFourBit = False Then
                    radiobuttonCPUIs32Bit.Checked = True
                    My.Settings.cpuIsSixtyFourBit = False
                End If
            End If
#End Region

#Region "This is where the settings get saved."
            ' Save settings.
            My.Settings.Save()
            My.Settings.Reload()
            ' Update the fullLauncherCodeString.
            OfficeLocater.combineStrings()
            ' Update the text in the main window's titlebar.
            aaformMainWindow.Text = "UXL Launcher Version " & My.Application.Info.Version.ToString & " (" & OfficeLocater.titlebarBitModeString & " Mode)"
            ' Tell the user that settings were saved.
            MessageBox.Show("Settings saved.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
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

#Region "Code that runs when the user clicks the 'Help Me!' button on the Advanced tab."
    Private Sub buttonHelpMeCPUType_Click(sender As Object, e As EventArgs) Handles buttonHelpMeCPUType.Click
        ' Open the System Properties Control Panel page.
        Process.Start("control.exe", "system")
    End Sub
#End Region
#Region "Code that runs when the user clicks the 'Test Settings' button."
    Private Sub buttonTestSettings_Click(sender As Object, e As EventArgs) Handles buttonTestSettings.Click
        ' When the user clicks the "Test Settings" button, tell them exactly what will happen
        ' then save the settings and attempt to launch the Office Language Preferences.
        MessageBox.Show("When you click the OK button your settings will be saved." & vbCrLf &
                        "" & vbCrLf &
                        "Afterward we will attempt to launch the Office Language Preferences application." & vbCrLf &
                        "" & vbCrLf &
                        "If no message appears, assume that it worked." & vbCrLf &
                        "" & vbCrLf &
                        "If an error message appears saying something about File not Found, you might need to adjust your settings. " & vbCrLf &
                        "" & vbCrLf &
                        "If the Office Language Preferences application appears," & vbCrLf &
                        "you can just close it." & vbCrLf &
                        "" & vbCrLf &
                        "The Options window will close when the Office Language Preferences window appears.",
                        "UXL Settings Test", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        buttonSaveSettings.PerformClick()
        LaunchApp.LaunchOfficeLangPrefs()
    End Sub
#End Region

End Class