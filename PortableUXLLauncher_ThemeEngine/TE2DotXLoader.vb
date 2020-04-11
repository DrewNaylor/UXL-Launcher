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



Imports System.Drawing
Imports System.Windows.Forms
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
            MessageBox.Show(ThemeEngineNode.Attributes("RuntimeVersion").Value.ToString)
            Dim TERuntimeVersionInThemeFile As Version = Version.Parse(ThemeEngineNode.Attributes("RuntimeVersion").Value.ToString)

            ' Make a version variable to store the theme engine version we want to compare to.
            Dim TE2xVersion As Version = Version.Parse("2.0")

            ' Check what the theme has in the attribute against the
            ' base version number of TE2.x.
            Select Case TERuntimeVersionInThemeFile.CompareTo(TE2xVersion)
                Case 0 ' Theme says to use TE2.x.
                    ' Load theme in the TE2.x loader.
                    ThemeProperties.themeSheetEngineRuntimeVersion = TERuntimeVersionInThemeFile
                    AssignControlProperties()
                Case 1 ' Theme says to use TE2.x.
                    ' Load theme in the TE2.x loader.
                    ThemeProperties.themeSheetEngineRuntimeVersion = TERuntimeVersionInThemeFile
                    AssignControlProperties()
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

    Friend Shared Sub AssignControlProperties(Optional LoadFromAttribute As Boolean = False)
        ' This part goes through the theme file and
        ' assigns stuff to each of the properties.
        ' "LoadFromAttributes" is used to determine
        ' whether the item should load from attributes.
        ' Typically this would be False if the theme is
        ' a TE1.x theme being loaded through the shim.

        ' Assign theme info properties.
        AssignThemeInfoProperties()

        ' Button properties.
        ' Assign the Button backcolor property.
        ThemeProperties.colorButtonBackColor = GetThemeColor("Button", "BackColor", "Transparent", LoadFromAttribute)
        MessageBox.Show(ThemeProperties.colorButtonBackColor.ToString)


        ' Assign Button forecolor property.
        ThemeProperties.colorButtonForeColor = GetThemeColor("Button", "ForeColor", "ControlText", LoadFromAttribute)
        MessageBox.Show(ThemeProperties.colorButtonForeColor.ToString)

        ' Set Button FlatStyle property.
        Select Case GetPropertySafe("Button", "FlatStyle", "Standard", LoadFromAttribute)
            Case "Standard"
                ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Standard
            Case "Flat"
                ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Flat
            Case Else
                ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Standard
        End Select

        ' Assign Button FlatAppearance BorderColor.
        ThemeProperties.flatappearanceButtonBorderColor = GetThemeColor("Button", "FlatAppearance/BorderColor", "Nothing", LoadFromAttribute)

        ' Set Button FlatAppearance MouseOver color.
        ThemeProperties.flatappearanceButtonMouseOverBackColor = GetThemeColor("Button", "FlatAppearance/MouseOverBackColor", "Nothing", LoadFromAttribute)
        MessageBox.Show(ThemeProperties.colorButtonBackColor.ToString)



    End Sub

    Friend Shared Sub AssignThemeInfoProperties()
        ' Grab theme title.
        ThemeProperties.themeSheetTitle = GetPropertySafe("Title", "", "(No title specified)", False, False)

        ' Grab theme description.
        ThemeProperties.themeSheetDescription = GetPropertySafe("Description", "", "(No description specified)", False, False)

        ' Grab theme author.
        ThemeProperties.themeSheetAuthor = GetPropertySafe("Author", "", "(No author specified)", False, False)

        ' Grab theme file version.
        ThemeProperties.themeSheetFileVersion = GetPropertySafe("Version", "", "(No version specified)", False, False)
    End Sub

    Friend Shared Function GetThemeColor(ControlName As String, ControlProperty As String, DefaultValue As String, Optional LoadFromAttribute As Boolean = True) As Color
        If LoadFromAttribute = True Then
            ' If the theme wants to load the color from an attribute, do so.
            ' This is typically used for themes that support TE2.x.
            ' Make sure it's a valid color first.
            ' Based off this SO answer:
            ' https://stackoverflow.com/a/40681176
            Dim ColorFromTheme As String = GetPropertySafe(ControlName, ControlProperty, DefaultValue)
            If IsColorValid(ColorFromTheme) Then
                Return ColorTranslator.FromHtml(ColorFromTheme)
            ElseIf Not IsColorValid(ColorFromTheme) AndAlso DefaultValue = "Nothing" Then
                Return Nothing
            Else
                Return ColorTranslator.FromHtml(DefaultValue)
            End If
        Else
            ' Otherwise, assume the theme wants to load from a node's InnerText.
            Dim ColorFromTheme As String = GetPropertySafe(ControlName, ControlProperty, DefaultValue)
            If IsColorValid(ColorFromTheme) Then
                Return ColorTranslator.FromHtml(ColorFromTheme)
            ElseIf Not IsColorValid(ColorFromTheme) AndAlso DefaultValue = "Nothing" Then
                Return Nothing
            Else
                Return ColorTranslator.FromHtml(DefaultValue)
            End If
        End If
    End Function

    Private Shared Function IsColorValid(InputColor As String) As Boolean
        Dim Pattern As String = "^#[0-9A-F]{1,6}$"
        Dim RegexWithPattern As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(Pattern)
        If RegexWithPattern.IsMatch(InputColor) Then
            Return True
        ElseIf Not RegexWithPattern.IsMatch(InputColor) Then
            For Each systemcolor As KnownColor In [Enum].GetValues(GetType(KnownColor))
                If systemcolor.ToString = InputColor Then
                    Return True
                End If
            Next
        Else
            Return False
        End If

    End Function

    Friend Shared Function GetPropertySafe(DesiredNode As String, NodeAttribute As String, DefaultValue As String, Optional LoadFromAttribute As Boolean = True, Optional UseThemeColorPrefix As Boolean = True) As String

        ' Define a root prefix to start looking in.
        Dim RootPrefix As String = "/UXL_Launcher_Theme/"

        If LoadFromAttribute = True AndAlso UseThemeColorPrefix = True Then
            ' If the theme wants to load the property from an attribute, do so.
            ' This is typically the case with themes that support TE2.x,
            ' although there are some situations where we don't want to load stuff
            ' from an attribute, such as for the description.
            Return GetAttribute(RootPrefix & "Theme_Colors/" & DesiredNode, NodeAttribute, DefaultValue)
        ElseIf LoadFromAttribute = False AndAlso UseThemeColorPrefix = True Then
            ' Assume that the theme doesn't want to load a property from an attribute,
            ' but that the property we want to get is in the theme colors section.
            ' This is often the case for things like the Button FlatAppearance section.
            Return GetInnerText(RootPrefix & "Theme_Colors/" & DesiredNode & "/" & NodeAttribute, DefaultValue)
        Else
            ' Otherwise, assume the theme wants to load properties from a node's InnerText.
            ' It's assumed that this isn't in the theme colors section.
            ' This would be used in cases where we're trying
            ' to get theme information like the title or description.
            Return GetInnerText(RootPrefix & DesiredNode & NodeAttribute, DefaultValue)
        End If
    End Function

    Private Shared Function GetAttribute(NodeName As String, AttributeName As String, DefaultValue As String) As String
        ' TODO: Check to make sure the requested attribute is supported in
        ' the version of the theme engine the theme is requesting to use.
        ' See also https://github.com/DrewNaylor/UXL-Launcher/issues/170
        MessageBox.Show(NodeName)
        If ThemeProperties.themeSheet.SelectSingleNode(NodeName, ThemeProperties.themeNamespaceManager) IsNot Nothing Then
            ' If the node exists, store it in a variable to make the code easier to read.
            Dim NodePath As XmlNode = ThemeProperties.themeSheet.SelectSingleNode(NodeName, ThemeProperties.themeNamespaceManager)
            If NodePath.Attributes(AttributeName) IsNot Nothing Then
                ' If the attribute exists and is compatible with the version of the theme engine
                ' the theme wants to use, return the attribute.
                Return NodePath.Attributes(AttributeName).Value
            Else
                ' Otherwise, return the default value.
                Return DefaultValue
            End If
        Else
            ' If the node does not exist, return the default value.
            Return DefaultValue
        End If

    End Function

    Private Shared Function GetInnerText(Node As String, DefaultValue As String) As String
        ' TODO: Check to make sure the requested node innertext is supported in
        ' the version of the theme engine the theme is requesting to use.
        ' See also https://github.com/DrewNaylor/UXL-Launcher/issues/170

        MessageBox.Show(Node)
        ' Create a variable to store a forward slash char
        ' for trimming from the end of the node just in
        ' case one somehow ended up there, such as if
        ' no node attribute was passed to the GetPropertySafe
        ' function.
        Dim ForwardSlash As Char = CChar("/")
        If ThemeProperties.themeSheet.SelectSingleNode(Node.TrimEnd(ForwardSlash), ThemeProperties.themeNamespaceManager) IsNot Nothing Then
            ' First check if the node exists.
            ' If it does exist, create a variable to store the node innertext.
            Dim NodeInnerText As String = ThemeProperties.themeSheet.SelectSingleNode(Node, ThemeProperties.themeNamespaceManager).InnerText.ToString
            If NodeInnerText IsNot Nothing Then
                ' If the node exists and is compatible with the version of the theme engine
                ' the theme wants to use, return the innertext.
                Return NodeInnerText
            Else
                ' Otherwise, return the default value.
                Return DefaultValue
            End If
        Else
            ' If the node doesn't exist, return the default value.
            Return DefaultValue
        End If
    End Function

End Class
