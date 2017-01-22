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



Imports System.ComponentModel

Public Class aaformAboutWindow
#Region "Code that runs when the About window is opened."
    Private Sub RealAboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#Region "Always on Top override code for dialog boxes."
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


        ' Create a string with the BuildDate.txt file.
        Dim BuildDateString As String = My.Resources.BuildDate

        ' Put the text in the About box on launch.
        textboxAboutApp.Text = ("UXL Launcher - Unified eXecutable Launcher" & vbCrLf &
"Version " & My.Application.Info.Version.ToString & " Git - Codename ""Personalizationizer 3000""" & vbCrLf &
"App compiled at UTC: " & BuildDateString &
"Copyright (C) 2013-2017  Drew Naylor" & vbCrLf &
"" & vbCrLf &
"UXL Launcher provides launchers for most Microsoft Office apps in one place." & vbCrLf &
"" & vbCrLf &
"License notice:" & vbCrLf &
"UXL Launcher is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by" &
" the Free Software Foundation, either version 3 of the License, or (at your option) any later version." & vbCrLf &
"" & vbCrLf &
"UXL Launcher is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details." & vbCrLf &
"" & vbCrLf &
"You should have received a copy of the GNU General Public License along with UXL Launcher. If not, see <http://www.gnu.org/licenses/>." & vbCrLf &
"" & vbCrLf &
"Drew is not intending on infringing on Microsoft" & "'" & "s copyrights, so UXL Launcher is only a shortcut application." & vbCrLf &
"" & vbCrLf &
"Copyright notice: Office, Microsoft Office, Word, Excel, PowerPoint, And all related words (by MSFT) are Copyright [a long time ago]-[sometime in the future] Microsoft Corp. All Rights Reserved for Microsoft" & "'" & "s copyrights." & vbCrLf &
"Any other companies mentioned own their respective copyrights/trademarks.")


        ' Load the GPL document in the WebBrowser control.
        webbrowserGPLViewer.DocumentText = My.Resources.gpl_3_0_standalone
        ' Load the Acknowledgments HTML document in the WebBrowser Acknowledgments control.
        webbrowserAcknowledgmentsViewer.DocumentText = My.Resources.Acknowledgments
        ' Load the GPL document in the RTF Textbox control.
        rtftextboxLicense.Rtf = My.Resources.gpl_RTF
        ' Load the Acknowledgements document in the RTF Textbox control.
        rtftextboxAcknowledgements.Rtf = My.Resources.Acknowledgements_RTF

    End Sub
#End Region
#Region "Code to run when clicking the link to go to the GitHub repository."
    Private Sub linkRepository_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRepository.LinkClicked
        ' Open the GitHub repository.
        Process.Start("https://github.com/DrewNaylor/UXL-Launcher")
    End Sub
#End Region
#Region "Code to run when clicking the link to check for updates."
    Private Sub linkUpdateCheck_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkUpdateCheck.LinkClicked
        ' Go to the Releases page.
        Process.Start("https://github.com/DrewNaylor/UXL-Launcher/releases/latest")
    End Sub
#End Region
#Region "Code to run when clicking the link to go to my website."
    Private Sub linkMyWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkMyWebsite.LinkClicked
        ' Go to my website.
        Process.Start("http://drewnaylor.github.io")
    End Sub
#End Region
#Region "Code to run when closing the About window."
    Private Sub aaformAboutWindow_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

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
#Region "Code to run when clicking links in the RTF documents."
    Private Sub rtftextboxLicense_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtftextboxLicense.LinkClicked
        ' When the user clicks a link in the RTF License rich textbox, go to that
        ' page in the default browser if the user chooses to visit the
        ' page in the messagebox.
        Dim msgResult As Integer = MessageBox.Show("Are you sure you want open this link?" & vbCrLf &
                "" & vbCrLf &
                e.LinkText, "UXL Launcher",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If the user chooses to open the link, navigate the default browser there.
        If msgResult = DialogResult.Yes Then
            Process.Start(e.LinkText)
        End If
    End Sub

    Private Sub rtftextboxAcknowledgements_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles rtftextboxAcknowledgements.LinkClicked
        ' When the user clicks a link in the RTF License rich textbox, go to that
        ' page in the default browser if the user chooses to visit the
        ' page in the messagebox.
        Dim msgResult As Integer = MessageBox.Show("Are you sure you want open this link?" & vbCrLf &
                "" & vbCrLf &
                e.LinkText, "UXL Launcher",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' If the user chooses to open the link, navigate the default browser there.
        If msgResult = DialogResult.Yes Then
            Process.Start(e.LinkText)
        End If
    End Sub
#End Region

End Class