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

    ' Create a public, shared string called cpuTypeString. This string is used in the app launch code when the user clicks the buttons.
    Public Shared cpuTypeString As String
    ' Create a public, shared string called officeVersionString which is used in the app launch code when the user clicks the buttons.
    Public Shared officeInstallMethodString As String


#Region "cpuTypeString and cpuType sub."
    ' The cpuType sub is used to give cpuTypeString data.
    Public Shared Sub cpuType()
        ' Create a string called userCPUType which is only used in this sub.
        Dim userCPUType As String

        ' This code looks at My.Settings.cpuIsSixtyFourBit and if it's set to True, userCPUType contains " (x86)" and cpuTypeString is set
        ' to the value of userCPUType to work around the inability to create and assign a value to a Public Shared string.
        'However, if My.Settings.cpuIsSixtyFourBit is set to False, userCPUType is assigned an empty value and so is cpuTypeString.
        If My.Settings.cpuIsSixtyFourBit = True Then
            userCPUType = " (x86)"
            cpuTypeString = userCPUType
        ElseIf My.Settings.cpuIsSixtyFourBit Then
            userCPUType = ""
            cpuTypeString = userCPUType
        End If
    End Sub
#End Region
#Region "officeInstallMethodString and officeInst sub."
    ' The officeVer sub is used to give officeVersionString data.
    Public Shared Sub officeInst()
        Dim userOfficeInst As String






    End Sub






#End Region
#End Region
End Class
