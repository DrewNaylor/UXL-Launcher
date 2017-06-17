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



' These imports are used for the log functionality.
Imports System
Imports System.IO
Public Class UXL_Launcher_Error_Logging
    ' This class allows UXL Launcher to log errors to a text file.
    ' It'll only log the date and time along with the error message,
    ' error message type, stack trace, (other important error info,)
    ' whether Windows is 32-bit or 64-bit, the Office version chosen,
    ' whether the user said Windows was 32-bit or 64-bit, Office drive
    ' location, whether the user said it was installed via 365/CTR or MSI,
    ' whether alwaysOnTop is enabled, and maybe other settings as I add them.
    ' All this logging depends on what I want to log in the other parts of this app.

    Friend Shared Sub uxlLogger(logMessage As String, write As TextWriter)

    End Sub

End Class
