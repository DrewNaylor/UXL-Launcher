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

    Friend Shared Sub AssignControlProperties(Optional LoadFromAttribute As Boolean = True)
        ' This part goes through the theme file and
        ' assigns stuff to each of the properties.
        ' "LoadFromAttributes" is used to determine
        ' whether the item should load from attributes.
        ' Typically this would be False if the theme is
        ' a TE1.x theme being loaded through the shim.

        ' Assign theme info properties.
        AssignThemeInfoProperties()

        ' About window banner style.
        Select Case GetPropertySafe("AboutWindow", "BannerStyle")
            Case "Dark"
                ThemeProperties.bannerStyle = My.Resources.DARK_UXL_Launcher_Banner
            Case Else
                ThemeProperties.bannerStyle = My.Resources.UXL_Launcher_Banner
        End Select

        ' Button properties.
        ' Assign the Button backcolor property.
        ThemeProperties.colorButtonBackColor = GetThemeColor("Button", "BackColor", LoadFromAttribute)
        MessageBox.Show("button back color: " & ThemeProperties.colorButtonBackColor.ToString)


        ' Assign Button forecolor property.
        ThemeProperties.colorButtonForeColor = GetThemeColor("Button", "ForeColor", LoadFromAttribute)

        ' Set Button FlatStyle property.
        Select Case GetPropertySafe("Button", "FlatStyle", LoadFromAttribute)
            Case "Standard"
                ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Standard
            Case "Flat"
                ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Flat
            Case Else
                ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Standard
        End Select

        ' Get default statusbar backcolor.
        ThemeProperties.colorStatusBarBackColor = GetThemeColor("StatusBar", "BackColor")
        MessageBox.Show("statusbar backcolor: " & ThemeProperties.colorStatusBarBackColor.ToString)


        ' Assign Button FlatAppearance BorderColor.
        ' Make sure the theme supports it.
        MessageBox.Show("About to get FlatAppearance ButtonBorderColor. Please place breakpoints.")
        ThemeProperties.flatappearanceButtonBorderColor = GetThemeColor("Button", "FlatAppearance/BorderColor", False)
        MessageBox.Show("flat appearance button border color: " & ThemeProperties.flatappearanceButtonBorderColor.ToString)

        ' Set Button FlatAppearance MouseOver color.
        ThemeProperties.flatappearanceButtonMouseOverBackColor = GetThemeColor("Button", "FlatAppearance/MouseOverBackColor", False)
        MessageBox.Show("flat appearance button mouseover color: " & ThemeProperties.flatappearanceButtonMouseOverBackColor.ToString)

        ' Set Button FlatAppearance MouseDown color.
        ThemeProperties.flatappearanceButtonMouseDownBackColor = GetThemeColor("Button", "FlatAppearance/MouseDownBackColor", False)
        MessageBox.Show("flat appearance button mousedown color: " & ThemeProperties.flatappearanceButtonMouseDownBackColor.ToString)





    End Sub

    Private Shared Function ThemeSupportsFeature(NodeName As String, Optional PropertyToCheck As String = Nothing) As Boolean
        ' See if a particular feature is supported in a
        ' version of the theme engine.
        ' If the version the file is using
        ' is lower than the parsed version, the default
        ' value will be used instead.

        Dim VersionCompatibilityListSheet As XmlDocument = New XmlDocument()
        Dim NamespaceManager As New XmlNamespaceManager(VersionCompatibilityListSheet.NameTable)

        NamespaceManager.AddNamespace("vercompat", "https://drewnaylor.github.io/xml")

        VersionCompatibilityListSheet.LoadXml(My.Resources.VersionCompatibility)

        For Each FeatureNode As XmlNode In VersionCompatibilityListSheet.SelectSingleNode("/FeatureList")
            ' Check inside each node that specifies one feature.
            ' A feature is defined as something that the theme engine
            ' can use, for example to change the color of something.
            Select Case FeatureNode.NodeType
                ' Check the node type that we're looking at.
                Case XmlNodeType.Element
                    ' If the Xml node is an element, we can look in there.
                    Select Case FeatureNode.Attributes("For").Value
                        Case NodeName
                            ' If the feature node's "For" attribute matches the NodeName
                            ' that we want to check, see if the "Property" value matches
                            ' the property we want to check.
                            If PropertyToCheck = FeatureNode.Attributes("Property").Value Then
                                ' If the "Property" attribute matches the property we want to check,
                                ' define a version number used for comparison.
                                Dim ver As Version = Version.Parse(FeatureNode.Attributes("VersionIntroduced").Value)
                                ' The version we're defining is the version number stored in the matching
                                ' node's "VersionIntroduced" node.
                                Select Case ThemeProperties.themeSheetEngineRuntimeVersion.CompareTo(ver)
                                    Case 0 ' Theme works with the same version the feature was introduced in.
                                        MessageBox.Show("Node name: " & NodeName & vbCrLf &
                                                        "Property name: " & PropertyToCheck & vbCrLf &
                                                        "Version theme file wants to use: " & ThemeProperties.themeSheetEngineRuntimeVersion.ToString & vbCrLf &
                                                        "First version to have this feature: " & ver.ToString, "Version matches theme file runtime version")
                                        Return True
                                    Case 1 ' Theme supports a version that's newer than the version the feature was introduced in.
                                        MessageBox.Show("Node name: " & NodeName & vbCrLf &
                                                        "Property name: " & PropertyToCheck & vbCrLf &
                                                        "Version theme file wants to use: " & ThemeProperties.themeSheetEngineRuntimeVersion.ToString & vbCrLf &
                                                        "First version to have this feature: " & ver.ToString, "Theme file runtime version is newer than when the feature was introduced")
                                        Return True
                                    Case -1 ' Theme doesn't support the version the feature was introduced in.
                                        MessageBox.Show("Node name: " & NodeName & vbCrLf &
                                                        "Property name: " & PropertyToCheck & vbCrLf &
                                                        "Version theme file wants to use: " & ThemeProperties.themeSheetEngineRuntimeVersion.ToString & vbCrLf &
                                                        "First version to have this feature: " & ver.ToString, "Theme file runtime version doesn't support feature")
                                        Return False
                                End Select ' Done seeing if the theme file supports a given feature.
                            End If ' Done checking the property value.

                        Case Else
                            If FeatureNode.ParentNode.LastChild IsNot Nothing Then
                                ' If we're not at the end of XML file, go to the next
                                ' sibling of the feature node and keep looking.
                                FeatureNode = FeatureNode.NextSibling
                            Else
                                ' Return True if the last child is nothing.
                                Return True
                            End If
                    End Select
                Case XmlNodeType.Comment
                    If FeatureNode.NextSibling IsNot Nothing Then
                        ' If the XML node is a comment, just move on to the next
                        ' node and check again.
                        FeatureNode = FeatureNode.NextSibling
                    Else
                        ' If there is no next node after this, return True
                        ' since it's assumed that the feature is supported.
                        Return True
                    End If
                Case Else
                    ' If it's another kind of XML node, return True.
                    Return True
            End Select
        Next
    End Function

    Friend Shared Sub AssignThemeInfoProperties()
        ' Grab theme title.
        ThemeProperties.themeSheetTitle = GetPropertySafe("Title", "", False, False)
        MessageBox.Show(ThemeProperties.themeSheetTitle)

        ' Grab theme description.
        ThemeProperties.themeSheetDescription = GetPropertySafe("Description", "", False, False)
        MessageBox.Show(ThemeProperties.themeSheetDescription)

        ' Grab theme author.
        ThemeProperties.themeSheetAuthor = GetPropertySafe("Author", "", False, False)
        MessageBox.Show(ThemeProperties.themeSheetAuthor)

        ' Grab theme file version.
        ThemeProperties.themeSheetFileVersion = GetPropertySafe("Version", "", False, False)
        MessageBox.Show(ThemeProperties.themeSheetFileVersion)
    End Sub

    Friend Shared Function GetThemeColor(ControlName As String, ControlProperty As String, Optional LoadFromAttribute As Boolean = False) As Color
        ' Grab the color for the control from the theme.
        ' Make sure it's a valid color first.
        ' Based off this SO answer:
        ' https://stackoverflow.com/a/40681176

        Dim DefaultValue As String = GetDefaultValueVersionVariant(ControlName, ControlProperty)

        ' Put the theme's color value into a variable for easy access.
        Dim ColorFromTheme As String = GetPropertySafe(ControlName, ControlProperty, LoadFromAttribute)
        'MessageBox.Show(ColorFromTheme)
        If IsColorValid(ColorFromTheme) Then
            ' If the color is a valid HTML or system color,
            ' return the color.
            ' One situation where this could be confusing is
            ' if the theme has something like #3 instead of
            ' #363636. In this case, a color with alpha
            ' transparency will be returned, and it might be
            ' confusing. May be a good idea to make sure it has
            ' a length of 3 numbers or 6 numbers.
            MessageBox.Show(ColorFromTheme)
            Return ColorTranslator.FromHtml(ColorFromTheme)
        ElseIf Not IsColorValid(ColorFromTheme) AndAlso DefaultValue = "Nothing" Then
            ' If it's not valid and the default value is Nothing, return Nothing.
            Return Nothing
        Else
            ' Otherwise just return Nothing if the default is "LiteralNothing".
            ' This is the case for the default statusbar backcolor in 1.03 and above.
            If DefaultValue = "LiteralNothing" Then
                Return Nothing
            Else
                ' The default's not "LiteralNothing", so return the default color.
                Return ColorTranslator.FromHtml(DefaultValue)
            End If
        End If
    End Function

    Private Shared Function GetDefaultValueVersionVariant(NodeName As String, PropertyToCheck As String) As String
        ' If a default value is different between theme engine versions, this
        ' can choose between the defaults.

        ' Define some variables for holding an XML document and a namespace manager.
        Dim DefaultValuesVerDiff As XmlDocument = New XmlDocument()
        Dim NamespaceManager As New XmlNamespaceManager(DefaultValuesVerDiff.NameTable)

        ' Add namespace.
        NamespaceManager.AddNamespace("verdiffdefault", "https://drewnaylor.github.io/xml")

        ' Load in the default values list.
        DefaultValuesVerDiff.LoadXml(My.Resources.DefaultValuesVersionDiff)

        For Each DefaultNode As XmlNode In DefaultValuesVerDiff.SelectSingleNode("/DefaultValuesList")

            ' Look at each node in the default values list.
            ' These are the "<Default>" nodes.
            If NodeName = DefaultNode.Attributes("For").Value AndAlso PropertyToCheck = DefaultNode.Attributes("PropertyName").Value Then

                ' If the default node's "For" attribute matches the node we're looking at,
                ' and the property we want to check matching the node's "PropertyName" attribute,
                ' we have the right one, so look at the nodes in that one.
                For Each DiffNode As XmlNode In DefaultNode
                    Select Case DiffNode.NodeType
                        ' Need to make sure the XML node is an element and not a comment.
                        Case XmlNodeType.Element
                            ' Create a version variable that stores the "RuntimeVersion" attribute of
                            ' the current "<Diff>" node.
                            Dim ver As Version = Version.Parse(DiffNode.Attributes("RuntimeVersion").Value)

                            ' Compare the theme engine runtime version that the theme it says supports
                            ' to the version number in the "RuntimeVersion" attribute in the current
                            ' "<Diff>" node.
                            Select Case ThemeProperties.themeSheetEngineRuntimeVersion.CompareTo(ver)
                                Case 0
                                    ' The "RuntimeVersion" matches the version that the theme file says
                                    ' it works with. Return this value.
                                    Return DiffNode.Attributes("Value").Value
                                Case 1
                                    ' The "RuntimeVersion" is older than the version of the theme engine
                                    ' that the theme file says it works with. Return this value.
                                    Return DiffNode.Attributes("Value").Value
                                Case -1
                                    ' The "RuntimeVersion" is newer than the version the theme engine works with.
                                    ' Go to the next node and try again.
                                    ' Theme doesn't support the version the feature was introduced in.
                                    DiffNode = DiffNode.NextSibling
                            End Select

                        Case XmlNodeType.Comment
                            ' If the XML node is a comment, go to the next <Diff> node.
                            If DiffNode.NextSibling IsNot Nothing Then
                                DiffNode = DiffNode.NextSibling
                            End If
                        Case Else
                            ' Go to the next node.
                            If DiffNode.NextSibling IsNot Nothing Then
                                DiffNode = DiffNode.NextSibling
                            End If
                    End Select
                Next ' Read next "<Diff>" node.
            Else
                ' If it doesn't match, go to the next node and try again.
                DefaultNode = DefaultNode.NextSibling
            End If
        Next

    End Function

    Private Shared Function IsHexCodeLengthValid(HexCode As String) As Boolean
        ' Simple function to make sure a hex code is
        ' either three or six numbers long.
        ' The cases below are the length plus one because
        ' of the hash/pound symbol.
        Select Case HexCode.Length
            Case 4
                Return True
            Case 7
                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Shared Function IsColorValid(InputColor As String) As Boolean
        ' Color validator used in GetThemeColor().
        ' Based off this SO answer:
        ' https://stackoverflow.com/a/40681176

        ' Replace 0x in the input color with #, if it starts with it.
        ' Make sure the input color exists.
        If InputColor IsNot Nothing Then
            Dim SwitchToHashSymbol As String = InputColor
            If SwitchToHashSymbol.StartsWith("0x") Then
                SwitchToHashSymbol = InputColor.Replace("0x", "#")
            End If

            ' Regex pattern. Mostly copied from answer.
            Dim Pattern As String = "^#[0-9A-F]{1," & SwitchToHashSymbol.Length & "}$"
            'MessageBox.Show(Pattern)
            ' Make a new regex with a pattern.
            Dim RegexWithPattern As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex(Pattern)

            If SwitchToHashSymbol.StartsWith("#") AndAlso RegexWithPattern.IsMatch(SwitchToHashSymbol) = True AndAlso IsHexCodeLengthValid(SwitchToHashSymbol) Then
                ' If the input color is a valid HTML color,
                ' has a RegEx match, and it's a valid length
                ' of three or six numbers, return True.
                Return True
            ElseIf Not SwitchToHashSymbol.StartsWith("#") Then
                ' If it's not a valid HTML color,
                ' look through the known colors.
                For Each systemcolor As KnownColor In [Enum].GetValues(GetType(KnownColor))
                    If systemcolor.ToString = SwitchToHashSymbol Then
                        ' If a system color matches the input color,
                        ' then it's valid.
                        Return True
                    End If
                Next ' Next system color.
            Else
                ' Otherwise, it's assumed to be invalid.
                Return False
            End If
        Else
            ' If the color does not exist, it's invalid.
            Return False
        End If
    End Function

    Friend Shared Function GetPropertySafe(DesiredNode As String, NodeAttribute As String, Optional LoadFromAttribute As Boolean = True, Optional UseThemeColorPrefix As Boolean = True) As String

        ' Define a root prefix to start looking in.
        Dim RootPrefix As String = "/UXL_Launcher_Theme/"

        ' Make sure the theme supports this feature.
        'MessageBox.Show("DesiredNode: " & DesiredNode & vbCrLf &
        '                "NodeAttribute: " & NodeAttribute)
        If ThemeSupportsFeature(DesiredNode, NodeAttribute) = True Then

            If LoadFromAttribute = True AndAlso UseThemeColorPrefix = True Then
                ' If the theme wants to load the property from an attribute, do so.
                ' This is typically the case with themes that support TE2.x,
                ' although there are some situations where we don't want to load stuff
                ' from an attribute, such as for the description.
                Return GetAttribute(RootPrefix & "Theme_Colors/" & DesiredNode, NodeAttribute, GetDefaultValueVersionVariant(DesiredNode, NodeAttribute))
            ElseIf LoadFromAttribute = False AndAlso UseThemeColorPrefix = True Then
                ' Assume that the theme doesn't want to load a property from an attribute,
                ' but that the property we want to get is in the theme colors section.
                ' This is often the case for things like the Button FlatAppearance section.
                Return GetInnerText(RootPrefix & "Theme_Colors/" & DesiredNode & "/" & NodeAttribute, GetDefaultValueVersionVariant(DesiredNode, NodeAttribute))
            Else
                ' Otherwise, assume the theme wants to load properties from a node's InnerText.
                ' It's assumed that this isn't in the theme colors section.
                ' This would be used in cases where we're trying
                ' to get theme information like the title or description.
                Return GetInnerText(RootPrefix & DesiredNode & NodeAttribute, GetDefaultValueVersionVariant(DesiredNode, NodeAttribute))
            End If

        Else
            ' If we can't get the property from the theme, get the default value.
            Return GetDefaultValueVersionVariant(DesiredNode, NodeAttribute)
        End If
    End Function

    Private Shared Function GetAttribute(NodeName As String, AttributeName As String, DefaultValue As String) As String
        ' TODO: Check to make sure the requested attribute is supported in
        ' the version of the theme engine the theme is requesting to use.
        ' See also https://github.com/DrewNaylor/UXL-Launcher/issues/170

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
