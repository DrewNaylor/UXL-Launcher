﻿'PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
'Can be used with standard Windows Forms applications with a few small changes.
'Copyright (C) 2019-2020 Drew Naylor. Licensed under Gnu GPLv3+.
'Any companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of PortableThemeEngine.
'
'PortableThemeEngine is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'PortableThemeEngine is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with PortableThemeEngine.  If not, see <http://www.gnu.org/licenses/>.



Imports System.Xml

Public Class TE2DotXLoader

    ' TODO: See TE1DotXLoaderShim.vb for a detailed TODO comment.
    ' The TE2.x theme loader will pull from attributes instead
    ' of XmlNode.InnerText.
    ' Some properties may still be pulled from XmlNode.InnerText
    ' if it makes sense, such as <Title> and <Description>.

    ' Example of how to read attributes:

    'For Each characterNode As XmlNode In xmlFileToSearch.SelectSingleNode("/root/characterCodeSection")
    '     ' Underscores are replaced with and symbols so that they match how HTML expects
    '     ' character codes to look. The underscores are necessary for now as XML complains
    '     ' when they're in the file, so this is a workaround.
    '     textboxOutput.AppendText(characterNode.Attributes("name").Value.ToString & ": " & characterNode.Attributes("code").Value.Replace("_", "&") & vbCrLf)
    'Next

    ' Above code copied from HTML Character Code Acquisition Program.
    ' Will require very different XML node stuff.
    ' xmlFileToSearch is an XmlDocument, just like the themeSheet.

    Friend Shared Sub CheckEngineRuntimeVersionCompatibility()

        ' Assign variable for TE runtime version node.
        Dim ThemeEngineNode As XmlNode = ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/ThemeEngine")

        If ThemeEngineNode IsNot Nothing Then
            ' If the theme engine node exists, check what's in the runtime
            ' version attribute.

            ' Make a variable to store the runtime version.
            Dim TERuntimeVersionInThemeFile As New Version(ThemeEngineNode.Attributes("RuntimeVersion").ToString)

            ' Make a version variable to store the theme engine version we want to compare to.
            Dim TE2xVersion As New Version("2.0")

            ' Check what the theme has in the attribute against the
            ' base version number of TE2.x.
            Select Case TERuntimeVersionInThemeFile.CompareTo(TE2xVersion)
                Case 0 ' Theme says to use TE2.x.
                    ' Load theme in the TE2.x loader.
                    ThemeProperties.themeSheetEngineRuntimeVersion = TERuntimeVersionInThemeFile
                    AssignProperties()
                Case 1 ' Theme says to use TE2.x.
                    ' Load theme in the TE2.x loader.
                    ThemeProperties.themeSheetEngineRuntimeVersion = TERuntimeVersionInThemeFile
                    AssignProperties()
                Case -1 ' Theme says to use TE1.x.
                    ' Load theme in the TE1.x loader shim.
                    TE1DotXLoaderShim.AssignProperties()

            End Select
        Else
            ' There's no runtime version node, so fall back to
            ' loading like TE1.x did with UseThemeEngineVersion.
            TE1DotXLoaderShim.AssignProperties()
        End If
    End Sub

    Friend Shared Sub AssignProperties()

    End Sub

    Private Shared Sub GetAttributes()

    End Sub

End Class
