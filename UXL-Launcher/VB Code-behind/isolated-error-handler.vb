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
