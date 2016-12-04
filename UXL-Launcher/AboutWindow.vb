'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
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



Public Class aaformAboutWindow
#Region "Code that runs when the About window is opened."
    Private Sub RealAboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Create a string with the BuildDate.txt file.
        Dim BuildDateString As String = My.Resources.BuildDate

        ' Put the text in the About box on launch.
        textboxAboutApp.Text = ("UXL Launcher - Unified eXecutable Launcher
Version  & My.Application.Info.Version.ToString & - Codename ""New Change""
        App compiled at UTC  & BuildDateString

        My.Application.Info.Copyright
        UXL Launcher provides launchers for most Microsoft Office apps in one place.
License notice:
UXL Launcher is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

UXL Launcher is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with UXL Launcher.  If not, see <http://www.gnu.org/licenses/>." & vbCrLf &
"I am not intending on infringing on Microsoft" & "'" & "s copyrights, so this is only a shortcut application.
Copyright notice Office, Microsoft Office, Word, Excel, PowerPoint, And all related words (by MSFT) are Copyright [a long time ago]-[sometime in the future] Microsoft Corp. All Rights Reserved for Microsoft" & "'" & "s copyrights.")


        ' Load the GPL document in the WebBrowser control.
        webbrowserGPLViewer.DocumentText = My.Resources.gpl_3_0_standalone
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

End Class