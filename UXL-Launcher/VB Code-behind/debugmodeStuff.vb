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



Public Class debugmodeStuff
    ' This document is used to contain all the debug labels and textboxes.
    Public Sub showDebugLabels()
        If My.Settings.debugmodeShowLabels = True Then
            aaformMainWindow.debugLabelForAlwaysOnTop.Show()
            aaformMainWindow.debugLabelForofficeDriveLocation.Show()
            aaformMainWindow.debugLabelForcpuTypeString.Show()
            aaformMainWindow.debugLabelForofficeInstallMethodString.Show()
            aaformMainWindow.debugLabelForuserOfficeVersion.Show()
            aaformMainWindow.debugLabelForcpuTypeString.Show()
            aaformMainWindow.debugLabelForcpuTypeString.Show()
            aaformMainWindow.debugLabelForcpuTypeString.Show()
        End If
    End Sub
End Class
