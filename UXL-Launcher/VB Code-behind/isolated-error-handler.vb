'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2020 Drew Naylor
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




Public Class isolated_error_handler
#Region "Regular app launching error handler code."
    Public Shared Sub launcherErrorHandler(Optional launcherErrorHandler_ExeName As String = "ExeToLaunch.exe", Optional launcherErrorHandler_ExeFriendlyName As String = "Application Name Here", Optional launcherErrorHandler_BypassConfiguredLocation As Boolean = False)
        ' If launcherErrorHandler_BypassConfiguredLocation is set to True, apps will
        ' just be launched with their name, like if you typed their filename into the
        ' Windows Run dialog box.
        ' See also: https://github.com/DrewNaylor/UXL-Launcher/issues/35
        If launcherErrorHandler_BypassConfiguredLocation = False Then
            ' Use the configured location if it's set to False.
            Try
                Process.Start(OfficeLocater.fullLauncherCodeString & launcherErrorHandler_ExeName)
            Catch ex As System.ComponentModel.Win32Exception
                ' If the program the user wants to launch isn't found in the folder the user chose
                ' in the Options window, ask them if they want to go to the Options window to change it.
                Dim msgResult As Integer = MessageBox.Show("We couldn't find " & launcherErrorHandler_ExeFriendlyName & " in the configured location." &
                " Would you like to open the Options window to change your settings?" & vbCrLf &
                    "" & vbCrLf &
                    "Full error message: " & ex.Message & vbCrLf &
                    vbCrLf &
                    "Configured location: " & OfficeLocater.fullLauncherCodeString, "Couldn't find " & launcherErrorHandler_ExeFriendlyName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Error)

                ' If the user chooses to open the Options window, open the Options window to the General tab.
                If msgResult = DialogResult.Yes Then
                    ' Open the Options window. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
                    Dim forceOptionsWindowTab As New aaformOptionsWindow
                    forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
                    forceOptionsWindowTab.ShowDialog(aaformMainWindow)
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

        ElseIf launcherErrorHandler_BypassConfiguredLocation = True Then
            ' If it's set to True, don't use the configured location.
            Try
                Process.Start(launcherErrorHandler_ExeName)
            Catch ex As System.ComponentModel.Win32Exception
                ' If the program the user wants to launch isn't found in the folder the user chose
                ' in the Options window, ask them if they want to go to the Options window to change it.
                Dim msgResult As Integer = MessageBox.Show("We couldn't find " & launcherErrorHandler_ExeFriendlyName & ". Maybe it's not installed?" & vbCrLf &
                "Would you like to open the Options window to change your settings?" & vbCrLf &
                    "" & vbCrLf &
                    "Full error message: " & ex.Message & vbCrLf &
                    vbCrLf &
                    "Bypassing the configured location was enabled for this app.", "Couldn't find " & launcherErrorHandler_ExeFriendlyName,
                MessageBoxButtons.YesNo, MessageBoxIcon.Error)

                ' If the user chooses to open the Options window, open the Options window to the General tab.
                If msgResult = DialogResult.Yes Then
                    ' Open the Options window. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
                    Dim forceOptionsWindowTab As New aaformOptionsWindow
                    forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
                    forceOptionsWindowTab.ShowDialog(aaformMainWindow)
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
        End If
    End Sub
#End Region

#Region "New file error handler code."
    Public Shared Sub newFileErrorHandler(Optional exeToLaunch As String = "exeToLaunch.exe", Optional launchArguments As String = "Launch Arguments", Optional exeFriendlyName As String = "EXE Friendly Name")
        ' First, create a ProcessStartInfo thing.
        ' Based on code from HideSettingsPages.
        ' https://github.com/DrewNaylor/HideSettingsPages

        Dim procNewFile As New ProcessStartInfo
        ' Now, get the file to launch.
        procNewFile.FileName = OfficeLocater.fullLauncherCodeString & exeToLaunch
        ' Assign start arguments.
        procNewFile.Arguments = launchArguments
        ' Try to start the program.
        Try
            Process.Start(procNewFile)
        Catch ex As System.ComponentModel.Win32Exception
            ' If the program the user wants to launch isn't found in the folder the user chose
            ' in the Options window, ask them if they want to go to the Options window to change it.
            Dim msgResult As Integer = MessageBox.Show("We couldn't find " & exeFriendlyName & " in the configured location." &
            " Would you like to open the Options window to change your settings?" & vbCrLf &
                "" & vbCrLf &
                "Full error message: " & ex.Message & vbCrLf &
                vbCrLf &
                "Configured location: " & OfficeLocater.fullLauncherCodeString, "Couldn't find " & exeFriendlyName, MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses to open the Options window, open the Options window to the General tab.
            If msgResult = DialogResult.Yes Then
                ' Open the Options window. Credit goes to this SO answer: <http://stackoverflow.com/a/2513186>
                Dim forceOptionsWindowTab As New aaformOptionsWindow
                forceOptionsWindowTab.tabcontrolOptionsWindow.SelectTab(0)
                forceOptionsWindowTab.ShowDialog(aaformMainWindow)
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
#End Region
End Class
