﻿' UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
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


Public Class OfficeLocater
#Region "This code is for figuring out where Office should be launched from based on My.Settings."

    ' Create a public, shared string called pfPathString. This string is used in the app launch code when the user clicks the buttons.
    Public Shared pfPathString As String
    ' Create a public, shared string called titlebarProgramFilesModeString which is used to show whether or not the app is in "PF Mode" or "PF-x86 Mode".
    Public Shared titlebarProgramFilesModeString As String
    ' Create a public, shared string called fullLauncherCodeString which is used to combine all the other launcher code strings into one that's much shorter.
    Public Shared fullLauncherCodeString As String


#Region "pfPathString and pfPath sub."
    ' The pfPath sub is used to give pfPathString data.
    Public Shared Sub pfPath()

        ' This code looks at My.Settings.pathUsePFxEightySix and if it's set to True, pfPathString is set to " (x86)".
        ' However, if My.Settings.pathUsePFxEightySix is set to False, pfPathString is assigned an empty value.
        If My.Settings.cpuIsSixtyFourBit = True Then
            pfPathString = " (x86)"
            titlebarProgramFilesModeString = "PF-x86"
        ElseIf My.Settings.cpuIsSixtyFourBit = False Then
            pfPathString = String.Empty
            titlebarProgramFilesModeString = "PF"
        End If
    End Sub
#End Region

    Friend Shared Sub CheckOfficeDriveLocationLength()
        ' Check the Office drive location setting's length
        ' and change it back to C if needed.
        If Not My.Settings.officeDriveLocation.Length = 1 Then
            My.Settings.officeDriveLocation = "C"
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

#End Region
#Region "This code combines all the launcher strings into one string to make modification easier."
    ' With this sub I'll be able to shorten the length of the button_click event strings for the launcher buttons.
    Public Shared Sub combineStrings()

        ' What this does is take all the other strings above and put them into one string along with the "Program Files"
        ' and "Microsoft Office" directories.
        ' First we need to run the other subs.
        pfPath()

        ' Check how many characters are in My.Settings.officeDriveLocation.
        ' If it's not 1, reset it to C because that's not supposed to happen.
        ' This will prevent being sent to Google due to
        ' a modified config file containing https://google.com/search?q=
        ' for the officeDriveLocation, for example.
        ' Moved to its own sub for reference elsewhere.
        CheckOfficeDriveLocationLength()

        ' Then we need to combine them. First up is the user installed via Office 365/Click-to-Run
        ' and the user doesn't have Office 2013.
        If My.Settings.userHasOfficeThreeSixFive = True And Not My.Settings.userOfficeVersion = "15" And Not My.Settings.userOfficeVersion.Contains("nomsi") Then
            fullLauncherCodeString = My.Settings.officeDriveLocation & ":\Program Files" & pfPathString & "\Microsoft Office\root\Office" &
                My.Settings.userOfficeVersion & "\"

            ' If the user installed specifically Office 2013 and they used Office 365/Click-to-Run, then we have a special 
            ' string for that install method.
        ElseIf My.Settings.userOfficeVersion = "15" And My.Settings.userHasOfficeThreeSixFive = True Then
            fullLauncherCodeString = My.Settings.officeDriveLocation & ":\Program Files" & pfPathString & "\Microsoft Office 15\root\Office15\"

            ' Otherwise, if the user doesn't have Office 365, then create a different string. This string doesn't
            ' rely on the version of Office that's used; just if it's not installed via Office 365/C2R.
            ' Also make sure that "nomsi" isn't in the Office version string.
        ElseIf My.Settings.userHasOfficeThreeSixFive = False And Not My.Settings.userOfficeVersion.Contains("nomsi") Then
            fullLauncherCodeString = My.Settings.officeDriveLocation & ":\Program Files" & pfPathString & "\Microsoft Office\Office" &
                My.Settings.userOfficeVersion & "\"

            ' Office 2019 installs to the same folder as Office 2016, but doesn't have MSI installer support, so ignore the
            ' setting for My.Settings.userHasOfficeThreeSixFive.
        ElseIf My.Settings.userOfficeVersion.Contains("nomsi") Then
            ' If the version of Office in the config file contains "nomsi", Click-to-Run support is enforced, and
            ' the "Office(number)" path takes the version and replaces "nomsi" with nothing ("")
            ' This is mostly for Office 2019, but will help for future Office versions that have a different version
            ' folder, such as "Office17".
            fullLauncherCodeString = My.Settings.officeDriveLocation & ":\Program Files" & pfPathString & "\Microsoft Office\root\Office" &
                My.Settings.userOfficeVersion.Replace("nomsi", String.Empty) & "\"
        End If


        ' Update the debug labels on the main window.
        debugmodeStuff.updateDebugLabels()


    End Sub
#End Region

End Class
