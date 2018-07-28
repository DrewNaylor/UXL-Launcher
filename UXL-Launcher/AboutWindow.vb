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

Public Class aaformAboutWindow
#Region "Code that runs when the About window is opened."
    Private Sub RealAboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create a string with the BuildDate.txt file.
        Dim BuildDateString As String = My.Resources.BuildDate
        BuildDateString = BuildDateString.TrimEnd(CType(vbCrLf, Char()))

        ' Put the text in the About box on launch.
        textboxAboutApp.Text = ("UXL Launcher - Unified eXecutable Launcher" & vbCrLf &
"Version " & My.Application.Info.Version.ToString & " " & My.Resources.isStable & My.Resources.appVersionCodename & vbCrLf &
"App compiled at UTC: " & BuildDateString & vbCrLf &
My.Resources.UXLLauncherInfo_TXT.Replace(vbLf, vbCrLf) & vbCrLf & vbCrLf & ' UXL Launcher info for the About window such as copyright stuff.
My.Resources.separator & vbCrLf & vbCrLf & ' separator line.
"UXL Launcher Theme Engine" & vbCrLf &
"Version " & My.Resources.themeEngineVersion & vbCrLf & ' Theme engine info.
My.Resources.ThemeEngineInfo_TXT.Replace(vbLf, vbCrLf) & vbCrLf & vbCrLf &
My.Resources.separator & vbCrLf & vbCrLf & ' separator line.
My.Resources.ApplauncherIconsInfo_TXT.Replace(vbLf, vbCrLf) ' Icon set for UXL Launcher info.
) '  The Replace(vbLf, vbCrLf) function is required for text to have Windows line endings if building from downloading the master branch code from GitHub.


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