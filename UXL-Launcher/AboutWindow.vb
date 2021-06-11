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
My.Resources.ApplauncherIconsInfo_TXT.Replace(vbLf, vbCrLf) & vbCrLf & vbCrLf & ' Icon set for UXL Launcher info.
My.Resources.separator & vbCrLf & vbCrLf & ' separator line.
My.Resources.libscrollswitchtabs_TXT.Replace(vbLf, vbCrLf) ' libscrollswitchtabs.
        ) '  The Replace(vbLf, vbCrLf) function is required for text to have Windows line endings if building from downloading the master branch code from GitHub.


        ' Load the license in the RichTextBox control.
        rtftextboxLicense.Text = My.Resources.apache2_0_txt
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

    Private Sub tabcontrolAboutWindow_MouseWheel(sender As Object, e As MouseEventArgs) Handles tabcontrolAboutWindow.MouseWheel
        ' Switch tabs on scroll.
        libscrollswitchtabs.ScrollSwitchTabs.switch(tabcontrolAboutWindow, e)
    End Sub

End Class