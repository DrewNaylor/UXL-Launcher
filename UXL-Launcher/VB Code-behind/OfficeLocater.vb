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


Public Class OfficeLocater
#Region "This code is for figuring out where Office should be launched from based on My.Settings."

    Public Shared cpuTypeString As String

    Public Shared Sub cpuType()
        Dim userCPUType As String

        If My.Settings.cpuIsSixtyFourBit = True Then
            userCPUType = " (x86)"
            cpuTypeString = userCPUType
        ElseIf My.Settings.cpuIsSixtyFourBit Then
            userCPUType = ""
            cpuTypeString = userCPUType
        End If

    End Sub

#End Region
End Class
