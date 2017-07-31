'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2017  Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation.
'(Note that the copyright years include the years left out by the hyphen.)
'
'Please be aware that UXL Launcher is unofficial and not made by Microsoft.
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



' These imports are used for the log functionality.
Imports System.IO
Imports System

Public Class isolated_error_handler
    Public Shared Sub launcherErrorHandler()
        Try
            Process.Start(OfficeLocater.fullLauncherCodeString & LaunchApp.exeName)
        Catch ex As System.ComponentModel.Win32Exception
            ' If Microsoft Access isn't found in the folder the user chose in the Options window, ask them if they want to
            ' go to the Options window to change it.
            Dim msgResult As Integer = MessageBox.Show("We couldn't find " & LaunchApp.exeFriendlyName & " in the location specified in the Options window." &
            " Would you like to open the Options window to change your settings?" & vbCrLf &
                "" & vbCrLf &
                "Full error message: " & ex.Message, "Couldn't find file",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses to open the Options window, open the Options window to the General tab.
            If msgResult = DialogResult.Yes Then
                Dim forceOptionsWindowTab As New aaformOptionsWindow
                forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
                forceOptionsWindowTab.ShowDialog()
            End If
        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
    End Sub
End Class
