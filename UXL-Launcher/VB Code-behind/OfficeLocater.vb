'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2018 Drew Naylor
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


Public Class OfficeLocater
#Region "This code is for figuring out where Office should be launched from based on My.Settings."

    ' Create a public, shared string called cpuTypeString. This string is used in the app launch code when the user clicks the buttons.
    Public Shared cpuTypeString As String
    ' Create a public, shared string called titlebarBitMode which is used to show whether or not the app is in "64-bit Mode" or "32-bit Mode."
    Public Shared titlebarBitModeString As String
    ' Create a public, shared string called fullLauncherCodeString which is used to combine all the other launcher code strings into one that's much shorter.
    Public Shared fullLauncherCodeString As String


#Region "cpuTypeString and cpuType sub."
    ' The cpuType sub is used to give cpuTypeString data.
    Public Shared Sub cpuType()
        ' Create a string called userCPUType which is only used in this sub.
        Dim cpuTypePrivateString As String

        ' This code looks at My.Settings.cpuIsSixtyFourBit and if it's set to True, userCPUType contains " (x86)" and cpuTypeString is set
        ' to the value of userCPUType to work around the inability to create and assign a value to a Public Shared string.
        'However, if My.Settings.cpuIsSixtyFourBit is set to False, userCPUType is assigned an empty value and so is cpuTypeString.
        If My.Settings.cpuIsSixtyFourBit = True Then
            cpuTypePrivateString = " (x86)"
            cpuTypeString = cpuTypePrivateString
            titlebarBitModeString = "64-bit"
        ElseIf My.Settings.cpuIsSixtyFourBit = False Then
            cpuTypePrivateString = ""
            cpuTypeString = cpuTypePrivateString
            titlebarBitModeString = "32-bit"
        End If
    End Sub
#End Region

#End Region
#Region "This code combines all the launcher strings into one string to make modification easier."
    ' With this sub I'll be able to shorten the length of the button_click event strings for the launcher buttons.
    Public Shared Sub combineStrings()
        ' This string is only used in this sub.
        Dim fullLauncherCodePrivateString As String

        ' What this does is take all the other strings above and put them into one string along with the "Program Files"
        ' and "Microsoft Office" directories.
        ' First we need to run the other subs.
        cpuType()

        ' Then we need to combine them. First up is the user installed via Office 365 and not via MSI package.
        If My.Settings.userHasOfficeThreeSixFive = True And My.Settings.userOfficeVersion = "14" _
            Or My.Settings.userHasOfficeThreeSixFive = True And My.Settings.userOfficeVersion = "16" Then
            fullLauncherCodePrivateString = My.Settings.officeDriveLocation & ":\Program Files" & cpuTypeString & "\Microsoft Office\root\Office" _
                & My.Settings.userOfficeVersion & "\"
            ' Make the public string equal to the private string.
            fullLauncherCodeString = fullLauncherCodePrivateString

            ' If the user installed specifically Office 2013 and they didn't use an MSI package, then we have a special 
            ' string for that install method.
        ElseIf My.Settings.userOfficeVersion = "15" And My.Settings.installedViaMSIPackage = False Then
            fullLauncherCodePrivateString = My.Settings.officeDriveLocation & ":\Program Files" & cpuTypeString & "\Microsoft Office 15\Root\Office15\"
            fullLauncherCodeString = fullLauncherCodePrivateString

            ' Otherwise, if the user doesn't have Office 365, then create a different string.
        ElseIf My.Settings.userHasOfficeThreeSixFive = False And My.Settings.userOfficeVersion = "14" _
            Or My.Settings.userHasOfficeThreeSixFive = False And My.Settings.userOfficeVersion = "16" _
            Or My.Settings.installedViaMSIPackage = True And My.Settings.userOfficeVersion = "15" Then
            fullLauncherCodePrivateString = My.Settings.officeDriveLocation & ":\Program Files" & cpuTypeString & "\Microsoft Office\Office" _
            & My.Settings.userOfficeVersion & "\"
            ' Make the public string equal to the private string.
            fullLauncherCodeString = fullLauncherCodePrivateString
        End If


        ' Update the debug labels on the main window.
        debugmodeStuff.updateDebugLabels()


    End Sub
#End Region

End Class
