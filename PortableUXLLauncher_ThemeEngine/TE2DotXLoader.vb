'PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
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
Imports System.Text.RegularExpressions
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

    Friend Shared Function PullNumbersAndDotsRegex(InputVersion As String) As String
        ' Store the theme engine runtime version from the file.
        ' First make sure there are only numbers.

        ' Make a pattern for the regex.
        ' We're escaping the dot as a literal.
        ' The carrat starts from the beginning, and it
        ' gets only numbers and periods. The asterisk
        ' makes it look through everything.
        Dim VersionPattern As String = "^[0-9\.]*$"
        ' Make a regex that we'll use with the above patters.
        Dim VersionRegexWithPattern As New Regex(VersionPattern)
        ' Parse the resulting regex and pull out what matches.
        Dim cleaned As String = ""

        ' Pulling only numbers and periods from the engine version
        ' runtime value is based on this SO answer:
        ' https://stackoverflow.com/a/17432187
        For Each character As Char In InputVersion
            If VersionRegexWithPattern.IsMatch(character) = True Then
                cleaned = cleaned & character
            End If
        Next
        'MessageBox.Show("cleaned: " & cleaned)
        Return cleaned
    End Function

    Friend Shared Sub CheckEngineRuntimeVersionCompatibility(formToApplyTo As Form)

        ' Assign variable for TE runtime version node.
        Dim ThemeEngineNode As XmlNode = ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/ThemeEngine")

        If ThemeEngineNode IsNot Nothing Then
            ' If the theme engine node exists, check what's in the runtime
            ' version attribute.

            ' Make a variable to store the runtime version.
            'MessageBox.Show(ThemeEngineNode.Attributes("RuntimeVersion").Value.ToString)
            Dim TERuntimeVersionInThemeFile As Version

            ' Make a version variable to store the theme engine version we want to compare to.
            Dim TE2xVersion As Version = Version.Parse("2.0")

            ' Make sure the version in the file is valid.
            ' If it were easy to not use a try...catch block,
            ' I would, but I couldn't figure out how not to.
            Try
                TERuntimeVersionInThemeFile = Version.Parse(PullNumbersAndDotsRegex(ThemeEngineNode.Attributes("RuntimeVersion").Value.ToString))
                ' FormatException:
                ' The version isn't written correctly. Could possibly
                ' be something like "1..2".
                ' OverflowException:
                ' Version specified in theme file is too big for Int32.
                ' ArgumentException:
                ' There's either no value or it's not formatted correctly.
                ' Exception:
                ' Catch all the above for easier code changing.
            Catch ex As Exception
                ' If it's invalid, consider it a 1.x theme.
                TERuntimeVersionInThemeFile = Version.Parse("1.01")
            End Try

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
                    TE1DotXLoaderShim.AssignProperties(formToApplyTo)

            End Select
        Else
            ' There's no runtime version node, so fall back to
            ' loading like TE1.x did with UseThemeEngineVersion.
            TE1DotXLoaderShim.AssignProperties(formToApplyTo)
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
        Select Case GetPropertySafe("AboutWindow", "BannerStyle", LoadFromAttribute).ToLowerInvariant
            Case "dark"
                ThemeProperties.bannerStyle = My.Resources.DARK_UXL_Launcher_Banner
            Case Else
                ThemeProperties.bannerStyle = My.Resources.UXL_Launcher_Banner
        End Select

        ' Button properties.
        ' Assign the Button backcolor property.
        ThemeProperties.colorButtonBackColor = GetThemeColor("Button", "BackColor", LoadFromAttribute)
        'MessageBox.Show("button back color: " & ThemeProperties.colorButtonBackColor.ToString)

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

        ' Assign Button FlatAppearance BorderColor.
        ' Make sure the theme supports it.
        'MessageBox.Show("About to get FlatAppearance ButtonBorderColor. Please place breakpoints.")
        ThemeProperties.flatappearanceButtonBorderColor = GetThemeColor("Button", "FlatAppearance/BorderColor", False)
        'MessageBox.Show("flat appearance button border color: " & ThemeProperties.flatappearanceButtonBorderColor.ToString)

        ' Set Button FlatAppearance MouseDown color.
        ThemeProperties.flatappearanceButtonMouseDownBackColor = GetThemeColor("Button", "FlatAppearance/MouseDownBackColor", False)
        'MessageBox.Show("flat appearance button mousedown color: " & ThemeProperties.flatappearanceButtonMouseDownBackColor.ToString)

        ' Set Button FlatAppearance MouseOver color.
        ThemeProperties.flatappearanceButtonMouseOverBackColor = GetThemeColor("Button", "FlatAppearance/MouseOverBackColor", False)
        'MessageBox.Show("flat appearance button mouseover color: " & ThemeProperties.flatappearanceButtonMouseOverBackColor.ToString)

        ' Assign Checkbox backcolor property.
        ThemeProperties.colorCheckBoxBackColor = GetThemeColor("CheckBox", "BackColor", LoadFromAttribute)

        ' Assign Checkbox forecolor property.
        ThemeProperties.colorCheckBoxForeColor = GetThemeColor("CheckBox", "ForeColor", LoadFromAttribute)

        ' Assign Dropdown/combobox backcolor property.
        ThemeProperties.colorDropdownBackColor = GetThemeColor("Dropdown", "BackColor", LoadFromAttribute)

        ' Assign Dropdown/combobox forecolor property.
        ThemeProperties.colorDropdownForeColor = GetThemeColor("Dropdown", "ForeColor", LoadFromAttribute)

        ' Assign Groupbox backcolor property.
        ThemeProperties.colorGroupBoxBackColor = GetThemeColor("GroupBox", "BackColor", LoadFromAttribute)

        ' Assign Groupbox forecolor property.
        ThemeProperties.colorGroupBoxForeColor = GetThemeColor("GroupBox", "ForeColor", LoadFromAttribute)

        ' Assign FlowLayoutPanel backcolor property.
        ThemeProperties.colorFlowLayoutPanelBackColor = GetThemeColor("FlowLayoutPanel", "BackColor", LoadFromAttribute)

        ' Assign FlowLayoutPanel forecolor property.
        ThemeProperties.colorFlowLayoutPanelForeColor = GetThemeColor("FlowLayoutPanel", "ForeColor", LoadFromAttribute)

        ' Assign Label backcolor property.
        ThemeProperties.colorLabelBackColor = GetThemeColor("Label", "BackColor", LoadFromAttribute)

        ' Assign Label forecolor property.
        ThemeProperties.colorLabelForeColor = GetThemeColor("Label", "ForeColor", LoadFromAttribute)

        ' Assign LinkLabel ActiveLinkColor property.
        ' Don't load link colors from attributes since there's kinda
        ' a lot in the LinkLabel section.
        ThemeProperties.colorLinkLabelActiveLinkColor = GetThemeColor("LinkLabel", "ActiveLinkColor", False)

        ' Assign LinkLabel LinkColor property.
        ' Don't load link colors from attributes since there's kinda
        ' a lot in the LinkLabel section.
        ThemeProperties.colorLinkLabelLinkColor = GetThemeColor("LinkLabel", "LinkColor", False)

        ' Assign LinkLabel BackColor property.
        ' Don't load link colors from attributes since there's kinda
        ' a lot in the LinkLabel section.
        ThemeProperties.colorLinkLabelBackColor = GetThemeColor("LinkLabel", "BackColor", False)

        ' Assign LinkLabel ForeColor property.
        ' Don't load link colors from attributes since there's kinda
        ' a lot in the LinkLabel section.
        ' LinkLabel ForeColors are only shown if the LinkLabel LinkArea
        ' property is set to be less than the entire linklabel so that
        ' a regular label is shown in the area not covered by the LinkArea.
        ThemeProperties.colorLinkLabelForeColor = GetThemeColor("LinkLabel", "ForeColor", False)

        ' Assign Panel BackColor property.
        ThemeProperties.colorPanelBackColor = GetThemeColor("Panel", "BackColor", LoadFromAttribute)

        ' Assign Panel ForeColor property.
        ThemeProperties.colorPanelForeColor = GetThemeColor("Panel", "ForeColor", LoadFromAttribute)

        ' Assign RadioButton BackColor property.
        ThemeProperties.colorRadioButtonBackColor = GetThemeColor("RadioButton", "BackColor", LoadFromAttribute)

        ' Assign RadioButton ForeColor property.
        ThemeProperties.colorRadioButtonForeColor = GetThemeColor("RadioButton", "ForeColor", LoadFromAttribute)

        ' Assign TableLayoutPanel BackColor property.
        ThemeProperties.colorTableLayoutPanelBackColor = GetThemeColor("TableLayoutPanel", "BackColor", LoadFromAttribute)

        ' Assign TableLayoutPanel ForeColor property.
        ThemeProperties.colorTableLayoutPanelForeColor = GetThemeColor("TableLayoutPanel", "ForeColor", LoadFromAttribute)

        ' Assign TableLayoutPanel ApplyToAboutWindowAboutTabTLP property.
        ' This won't be pulled from an attribute since that could make it messier.
        ' If the theme says to use this in the About window's
        ' About tab for the tableLayoutPanelAboutAppTab control,
        ' apply colorTableLayoutPanelBackColor to it.
        ' Otherwise, just use the colorTabPageBackColor
        ' and have the table layout panel inherit it.
        If GetPropertySafe("TableLayoutPanel", "ApplyToAboutWindowAboutTabTLP", False).ToLowerInvariant = "true" Then
            ThemeProperties.useTableLayoutPanelColorInsideAboutAppTab = True
        Else
            ThemeProperties.useTableLayoutPanelColorInsideAboutAppTab = False
        End If

        ' Assign TabPage BackColor property.
        ThemeProperties.colorTabPageBackColor = GetThemeColor("TabPage", "BackColor", LoadFromAttribute)

        ' Assign TabPage ForeColor property.
        ThemeProperties.colorTabPageForeColor = GetThemeColor("TabPage", "ForeColor", LoadFromAttribute)

        ' Assign TextBox BackColor property.
        ThemeProperties.colorTextboxBackColor = GetThemeColor("TextBox", "BackColor", LoadFromAttribute)

        ' Assign TextBox ForeColor property.
        ThemeProperties.colorTextboxForeColor = GetThemeColor("TextBox", "ForeColor", LoadFromAttribute)

        ' Assign MenuItem BackColor property.
        ThemeProperties.colorMenuItemBackColor = GetThemeColor("MenuItem", "BackColor", LoadFromAttribute)

        ' Assign MenuItem ForeColor property.
        ThemeProperties.colorMenuItemForeColor = GetThemeColor("MenuItem", "ForeColor", LoadFromAttribute)

        ' Assign MenuItem Image Margin Gradient Start Color property.
        ' This isn't being loaded from an attribute as it could be messy.
        ThemeProperties.colorMenuItemImageMarginGradientStartColor = GetThemeColor("MenuItem", "ImageMarginGradient/StartColor", False)

        ' Assign MenuItem Image Margin Gradient End Color property.
        ' This isn't being loaded from an attribute as it could be messy.
        ThemeProperties.colorMenuItemImageMarginGradientEndColor = GetThemeColor("MenuItem", "ImageMarginGradient/EndColor", False)

        ' Assign MenuBar BackColor property.
        ThemeProperties.colorMenubarBackColor = GetThemeColor("MenuBar", "BackColor", LoadFromAttribute)

        ' Assign StatusBar backcolor property.
        ThemeProperties.colorStatusBarBackColor = GetThemeColor("StatusBar", "BackColor", LoadFromAttribute)

        ' Assign StatusLabel ForeColor property.
        ThemeProperties.colorStatusLabelForeColor = GetThemeColor("StatusLabel", "ForeColor", LoadFromAttribute)

        ' Assign StatusLabel BackColor property.
        ThemeProperties.colorStatusLabelBackColor = GetThemeColor("StatusLabel", "BackColor", LoadFromAttribute)

        ' Assign StatusLabel BorderSides property.
        ' Not loading from an attribute so it doesn't get messy.
        Select Case GetPropertySafe("StatusLabel", "BackColor", False).ToLowerInvariant
            Case "all"
                ThemeProperties.propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.All
            Case "top"
                ThemeProperties.propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Top
            Case "left"
                ThemeProperties.propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Left
            Case "bottom"
                ThemeProperties.propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Bottom
            Case "right"
                ThemeProperties.propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Right
            Case Else
                ThemeProperties.propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.None
        End Select

        ' Assign StatusLabel BorderStyle property.
        ' Not loading from an attribute so it doesn't get messy.
        Select Case GetPropertySafe("StatusLabel", "BorderStyle", False).ToLowerInvariant
            Case "adjust"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.Adjust
            Case "bump"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.Bump
            Case "etched"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.Etched
            Case "raised"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.Raised
            Case "raisedinner"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.RaisedInner
            Case "raisedouter"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.RaisedOuter
            Case "sunken"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.Sunken
            Case "sunkeninner"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.SunkenInner
            Case "sunkenouter"
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.SunkenOuter
            Case Else
                ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.Flat
        End Select


    End Sub

    Private Shared Function ThemeSupportsFeature(NodeName As String, Optional PropertyToCheck As String = Nothing, Optional CheckCompatibility As Boolean = True) As Boolean
        ' See if a particular feature is supported in a
        ' version of the theme engine.
        ' If the version the file is using
        ' is lower than the parsed version, the default
        ' value will be used instead.

        ' Only check for compatibility if the feature requests it,
        ' as this takes a lot of time.

        If CheckCompatibility = True Then

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
                                            'MessageBox.Show("Node name: " & NodeName & vbCrLf &
                                            '"Property name: " & PropertyToCheck & vbCrLf &
                                            '"Version theme file wants to use: " & ThemeProperties.themeSheetEngineRuntimeVersion.ToString & vbCrLf &
                                            '"First version to have this feature: " & ver.ToString, "Version matches theme file runtime version")
                                            Return True
                                        Case 1 ' Theme supports a version that's newer than the version the feature was introduced in.
                                            'MessageBox.Show("Node name: " & NodeName & vbCrLf &
                                            '"Property name: " & PropertyToCheck & vbCrLf &
                                            '"Version theme file wants to use: " & ThemeProperties.themeSheetEngineRuntimeVersion.ToString & vbCrLf &
                                            '"First version to have this feature: " & ver.ToString, "Theme file runtime version is newer than when the feature was introduced")
                                            Return True
                                        Case -1 ' Theme doesn't support the version the feature was introduced in.
                                            'MessageBox.Show("Node name: " & NodeName & vbCrLf &
                                            '"Property name: " & PropertyToCheck & vbCrLf &
                                            '"Version theme file wants to use: " & ThemeProperties.themeSheetEngineRuntimeVersion.ToString & vbCrLf &
                                            '"First version to have this feature: " & ver.ToString, "Theme file runtime version doesn't support feature")
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
        Else
            ' Feature didn't request a compatibility check,
            ' so assume it's compatible across all versions.
            Return True
        End If

    End Function

    Friend Shared Sub AssignThemeInfoProperties()
        ' Grab theme title.
        ThemeProperties.themeSheetTitle = GetPropertySafe("Title", "", False, False)
        'MessageBox.Show(ThemeProperties.themeSheetTitle)

        ' Grab theme description.
        ThemeProperties.themeSheetDescription = GetPropertySafe("Description", "", False, False)
        'MessageBox.Show(ThemeProperties.themeSheetDescription)

        ' Grab theme author.
        ThemeProperties.themeSheetAuthor = GetPropertySafe("Author", "", False, False)
        'MessageBox.Show(ThemeProperties.themeSheetAuthor)

        ' Grab theme file version.
        ThemeProperties.themeSheetFileVersion = GetPropertySafe("Version", "", False, False)
        'MessageBox.Show(ThemeProperties.themeSheetFileVersion)
    End Sub

    Private Shared Function GetThemeColor(ControlName As String, ControlProperty As String, Optional LoadFromAttribute As Boolean = False) As Color
        ' Grab the color for the control from the theme.
        ' Make sure it's a valid color first.
        ' Based off this SO answer:
        ' https://stackoverflow.com/a/40681176

        ' Put the theme's color value into a variable for easy access.
        Dim ColorFromTheme As String = GetPropertySafe(ControlName, ControlProperty, LoadFromAttribute)
        ''MessageBox.Show(ColorFromTheme)
        If IsColorValid(ColorFromTheme) Then
            ' If the color is a valid HTML or system color,
            ' return the color.
            ' One situation where this could be confusing is
            ' if the theme has something like #3 instead of
            ' #363636. In this case, a color with alpha
            ' transparency will be returned, and it might be
            ' confusing. May be a good idea to make sure it has
            ' a length of 3 numbers or 6 numbers.
            'MessageBox.Show(ColorFromTheme)
            Return ColorTranslator.FromHtml(ColorFromTheme)
        ElseIf Not IsColorValid(ColorFromTheme) AndAlso GetDefaultValue(ControlName, ControlProperty) = "Nothing" Then
            ' If it's not valid and the default value is Nothing, return Nothing.
            Return Nothing
        Else
            ' Otherwise just return Nothing if the default is "LiteralNothing".
            ' This is the case for the default statusbar backcolor in 1.03 and above.
            If GetDefaultValue(ControlName, ControlProperty) = "LiteralNothing" Then
                Return Nothing
            Else
                ' The default's not "LiteralNothing", so return the default color.
                Return ColorTranslator.FromHtml(GetDefaultValue(ControlName, ControlProperty))
            End If
        End If
    End Function

    Friend Shared Function GetDefaultValue(NodeName As String, PropertyToCheck As String) As String
        ' If a default value is different between theme engine versions, this
        ' can choose between the defaults.

        Const defaultAboutWindowBannerStyle As String = "Light"

        Const defaultButtonBackColor As String = "Transparent"
        Const defaultButtonForeColor As String = "ControlText"
        Const defaultButtonFlatStyle As String = "Standard"
        Const defaultButtonFlatAppearanceBorderColor As String = "Nothing"
        Const defaultButtonFlatAppearanceMouseDownBackColor As String = "Nothing"
        Const defaultButtonFlatAppearanceMouseOverBackColor As String = "Nothing"

        Const defaultCheckboxBackColor As String = "Transparent"
        Const defaultCheckboxForeColor As String = "ControlText"

        Const defaultDropdownBackColor As String = "Window"
        Const defaultDropdownForeColor As String = "ControlText"

        Const defaultGroupBoxBackColor As String = "Transparent"
        Const defaultGroupBoxForeColor As String = "ControlText"

        Const defaultFlowLayoutPanelBackColor As String = "Window"
        Const defaultFlowLayoutPanelForeColor As String = "ControlText"

        Const defaultStatusBar1Dot03BackColor As String = "Nothing"
        Const defaultStatusBarOriginalBackColor = "Control"

        Const defaultLabelBackColor As String = "Transparent"
        Const defaultLabelForeColor As String = "ControlText"

        Const defaultLinkLabelActiveLinkColor As String = "Red"
        Const defaultLinkLabelLinkColor As String = "#0000FF"
        Const defaultLinkLabelBackColor As String = "Transparent"
        Const defaultLinkLabelForeColor As String = "ControlText"

        Const defaultPanelBackColor As String = "Control"
        Const defaultPanelForeColor As String = "ControlText"

        Const defaultRadioButtonBackColor As String = "Transparent"
        Const defaultRadioButtonForeColor As String = "ControlText"

        Const defaultTableLayoutPanelBackColor As String = "Control"
        Const defaultTableLayoutPanelForeColor As String = "ControlText"
        Const defaultTableLayoutPanelApplyToAboutWindowAboutTabTLP As String = "False"

        Const defaultTabPageBackColor As String = "Window"
        Const defaultTabPageForeColor As String = "ControlText"

        Const defaultTextBoxBackColor As String = "Window"
        Const defaultTextBoxForeColor As String = "WindowText"

        Const defaultMenuItemBackColor As String = "Window"
        Const defaultMenuItemForeColor As String = "ControlText"
        Const defaultMenuItemImageMarginGradientStartColor As String = "#FCFCFC"
        Const defaultMenuItemImageMarginGradientEndColor As String = "#F1F1F1"

        Const defaultMenuBarBackColor As String = "Control"

        Const defaultStatusLabelBackColor As String = "Transparent"
        Const defaultStatusLabelForeColor As String = "ControlText"
        Const defaultStatusLabelBorderSides As String = "None"
        Const defaultStatusLabelBorderStyle As String = "Flat"

        Const defaultThemeTitle As String = "(No title specified)"
        Const defaultThemeDescription As String = "(No description specified)"
        Const defaultThemeAuthor As String = "(No author specified)"
        Const defaultThemeVersion As String = "(No version specified)"



        Dim starttime As DateTime = DateTime.Now

        Select Case NodeName
            ' If the node name matches what we want to look at,
            ' check if the property matches.
            Case "AboutWindow"
                ' Check about window defaults.
                Select Case PropertyToCheck
                    Case "BannerStyle"
                        Return defaultAboutWindowBannerStyle
                End Select
            Case "Button"
                Select Case PropertyToCheck
                    ' Check the button's requested properties.
                    Case "BackColor"
                        Return defaultButtonBackColor
                    Case "ForeColor"
                        Return defaultButtonForeColor
                    Case "FlatStyle"
                        Return defaultButtonFlatStyle
                    Case "FlatAppearance/BorderColor"
                        Return defaultButtonFlatAppearanceBorderColor
                    Case "FlatAppearance/MouseDownBackColor"
                        Return defaultButtonFlatAppearanceMouseDownBackColor
                    Case "FlatAppearance/MouseOverBackColor"
                        Return defaultButtonFlatAppearanceMouseOverBackColor
                End Select
            Case "CheckBox"
                ' We're looking at the requested checkbox properties.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultCheckboxBackColor
                    Case "ForeColor"
                        Return defaultCheckboxForeColor
                End Select
            Case "Dropdown"
                ' We're looking through the dropdowns/comboboxes.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultDropdownBackColor
                    Case "ForeColor"
                        Return defaultDropdownForeColor
                End Select
            Case "GroupBox"
                ' Check the groupbox defaults
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultGroupBoxBackColor
                    Case "ForeColor"
                        Return defaultGroupBoxForeColor
                End Select
            Case "FlowLayoutPanel"
                ' Check flow layout panel defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultFlowLayoutPanelBackColor
                    Case "ForeColor"
                        Return defaultFlowLayoutPanelForeColor
                End Select
            Case "StatusBar"
                ' Check statusbar defaults.
                ' These differ between versions, so check that too.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Dim VersionWhenDefaultChanged As Version = Version.Parse("1.03")
                        Select Case VersionWhenDefaultChanged.CompareTo(ThemeProperties.themeSheetEngineRuntimeVersion)
                            Case 0 ' If it's the same version, return the new default in 1.03.
                                Return defaultStatusBar1Dot03BackColor
                            Case 1 ' If it's newer than 1.03, return the 1.03 default.
                                Return defaultStatusBar1Dot03BackColor
                            Case -1 ' If it's older than 1.03, return the original default.
                                Return defaultStatusBarOriginalBackColor
                        End Select
                End Select
            Case "Label"
                ' Check label defaults and return them.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultLabelBackColor
                    Case "ForeColor"
                        Return defaultLabelForeColor
                End Select
            Case "LinkLabel"
                ' Check linklabel defaults.
                Select Case PropertyToCheck
                    Case "ActiveLinkColor"
                        Return defaultLinkLabelActiveLinkColor
                    Case "LinkColor"
                        ' TE1.x used Color.FromArgb(0, 0, 255)
                        ' to get the blue color, but #0000FF is effectively
                        ' the same since it's also pure blue.
                        Return defaultLinkLabelLinkColor
                    Case "BackColor"
                        Return defaultLinkLabelBackColor
                    Case "ForeColor"
                        ' ForeColor only shows up if the LinkArea property
                        ' is less than the entire length of the linklabel.
                        Return defaultLinkLabelForeColor
                End Select
            Case "Panel"
                ' Check panel defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultPanelBackColor
                    Case "ForeColor"
                        Return defaultPanelForeColor
                End Select
            Case "RadioButton"
                'Check radiobutton defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultRadioButtonBackColor
                    Case "ForeColor"
                        Return defaultRadioButtonForeColor
                End Select
            Case "TableLayoutPanel"
                ' Check tablelayoutpanel defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultTableLayoutPanelBackColor
                    Case "ForeColor"
                        Return defaultTableLayoutPanelForeColor
                    Case "ApplyToAboutWindowAboutTabTLP"
                        Return defaultTableLayoutPanelApplyToAboutWindowAboutTabTLP
                End Select
            Case "TabPage"
                ' Check tabpage defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultTabPageBackColor
                    Case "ForeColor"
                        Return defaultTabPageForeColor
                End Select
            Case "TextBox"
                ' Check textbox defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultTextBoxBackColor
                    Case "ForeColor"
                        Return defaultTextBoxForeColor
                End Select
            Case "MenuItem"
                ' Check menuitem defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultMenuItemBackColor
                    Case "ForeColor"
                        Return defaultMenuItemForeColor
                    Case "ImageMarginGradient/StartColor"
                        Return defaultMenuItemImageMarginGradientStartColor
                    Case "ImageMarginGradient/EndColor"
                        Return defaultMenuItemImageMarginGradientEndColor
                End Select
            Case "MenuBar"
                ' Check menubar defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultMenuBarBackColor
                End Select
            Case "StatusLabel"
                ' Check statuslabel defaults.
                Select Case PropertyToCheck
                    Case "BackColor"
                        Return defaultStatusLabelBackColor
                    Case "ForeColor"
                        Return defaultStatusLabelForeColor
                    Case "BorderSides"
                        Return defaultStatusLabelBorderSides
                    Case "BorderStyle"
                        Return defaultStatusLabelBorderStyle
                End Select
            Case "Title"
                ' Check title defaults.
                Return defaultThemeTitle
            Case "Description"
                ' Check description defaults.
                Return defaultThemeDescription
            Case "Author"
                ' Check author defaults.
                Return defaultThemeAuthor
            Case "Version"
                ' Check version defaults.
                Return defaultThemeVersion
        End Select

        '' Define some variables for holding an XML document and a namespace manager.
        'Dim DefaultValuesVerDiff As XmlDocument = New XmlDocument()
        'Dim NamespaceManager As New XmlNamespaceManager(DefaultValuesVerDiff.NameTable)

        '' Add namespace.
        'NamespaceManager.AddNamespace("verdiffdefault", "https://drewnaylor.github.io/xml")

        '' Load in the default values list.
        'DefaultValuesVerDiff.LoadXml(My.Resources.DefaultValuesVersionDiff)

        'For Each DefaultNode As XmlNode In DefaultValuesVerDiff.SelectSingleNode("/DefaultValuesList")

        '    ' Look at each node in the default values list.
        '    ' These are the "<Default>" nodes.
        '    'Debug.WriteLine("DefaultNode attribute For: " & DefaultNode.Attributes("For").Value)
        '    If NodeName = DefaultNode.Attributes("For").Value AndAlso PropertyToCheck = DefaultNode.Attributes("PropertyName").Value Then

        '        ' If the default node's "For" attribute matches the node we're looking at,
        '        ' and the property we want to check matching the node's "PropertyName" attribute,
        '        ' we have the right one, so look at the nodes in that one.
        '        For Each DiffNode As XmlNode In DefaultNode
        '            Select Case DiffNode.NodeType
        '                ' Need to make sure the XML node is an element and not a comment.
        '                Case XmlNodeType.Element
        '                    ' Create a version variable that stores the "RuntimeVersion" attribute of
        '                    ' the current "<Diff>" node.
        '                    Dim ver As Version = Version.Parse(DiffNode.Attributes("RuntimeVersion").Value)

        '                    ' Compare the theme engine runtime version that the theme it says supports
        '                    ' to the version number in the "RuntimeVersion" attribute in the current
        '                    ' "<Diff>" node.
        '                    Select Case ThemeProperties.themeSheetEngineRuntimeVersion.CompareTo(ver)
        '                        Case 0
        '                            ' The "RuntimeVersion" matches the version that the theme file says
        '                            ' it works with. Return this value.

        '                            Return DiffNode.Attributes("Value").Value
        '                        Case 1
        '                            ' The "RuntimeVersion" is older than the version of the theme engine
        '                            ' that the theme file says it works with. Return this value.

        '                            Return DiffNode.Attributes("Value").Value
        '                        Case -1
        '                            ' The "RuntimeVersion" is newer than the version the theme engine works with.
        '                            ' Go to the next node and try again.
        '                            ' Theme doesn't support the version the feature was introduced in.
        '                            DiffNode = DiffNode.NextSibling
        '                    End Select

        '                Case XmlNodeType.Comment
        '                    ' If the XML node is a comment, go to the next <Diff> node.
        '                    If DiffNode.NextSibling IsNot Nothing Then
        '                        DiffNode = DiffNode.NextSibling
        '                    End If
        '                Case Else
        '                    ' Go to the next node.
        '                    If DiffNode.NextSibling IsNot Nothing Then
        '                        DiffNode = DiffNode.NextSibling
        '                    End If
        '            End Select
        '        Next ' Read next "<Diff>" node.
        '    Else
        '        'Debug.WriteLine("NodeName: " & NodeName)
        '        'Debug.WriteLine("PropertyToCheck: " & PropertyToCheck)
        '        ' If it doesn't match, go to the next node and try again.
        '        Dim endtime As DateTime = DateTime.Now
        '        Debug.WriteLine("Default value grabber took " & (endtime - starttime).Milliseconds & " ms to run.")
        '        DefaultNode = DefaultNode.NextSibling
        '    End If
        'Next

        Dim endtime As DateTime = DateTime.Now
        Debug.WriteLine("Default value grabber took " & (endtime - starttime).Milliseconds & " ms to run.")
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
            ''MessageBox.Show(Pattern)
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

    Friend Shared Function GetPropertySafe(DesiredNode As String, NodeAttribute As String, Optional LoadFromAttribute As Boolean = True, Optional UseThemeColorPrefix As Boolean = True, Optional CheckCompatibility As Boolean = True) As String

        ' Define a root prefix to start looking in.
        Dim RootPrefix As String = "/UXL_Launcher_Theme/"

        ' Make sure the theme supports this feature.
        ''MessageBox.Show("DesiredNode: " & DesiredNode & vbCrLf &
        '                "NodeAttribute: " & NodeAttribute)
        ' This is only checked if the feature requests compatibility checking
        ' as this is a rather expensive operation.
        Dim starttime As DateTime = DateTime.Now
        If ThemeSupportsFeature(DesiredNode, NodeAttribute, CheckCompatibility) = True Then
            Dim endtime As DateTime = DateTime.Now
            Debug.WriteLine("Compatibility checker took " & (endtime - starttime).Milliseconds & " ms to run.")

            If LoadFromAttribute = True AndAlso UseThemeColorPrefix = True Then
                ' If the theme wants to load the property from an attribute, do so.
                ' This is typically the case with themes that support TE2.x,
                ' although there are some situations where we don't want to load stuff
                ' from an attribute, such as for the description.
                Return GetAttribute(RootPrefix & "Theme_Colors/" & DesiredNode, DesiredNode, NodeAttribute)
            ElseIf LoadFromAttribute = False AndAlso UseThemeColorPrefix = True Then
                ' Assume that the theme doesn't want to load a property from an attribute,
                ' but that the property we want to get is in the theme colors section.
                ' This is often the case for things like the Button FlatAppearance section.
                Return GetInnerText(RootPrefix & "Theme_Colors/" & DesiredNode & "/" & NodeAttribute, DesiredNode, NodeAttribute)
            Else
                ' Otherwise, assume the theme wants to load properties from a node's InnerText.
                ' It's assumed that this isn't in the theme colors section.
                ' This would be used in cases where we're trying
                ' to get theme information like the title or description.
                Return GetInnerText(RootPrefix & DesiredNode & NodeAttribute, DesiredNode, NodeAttribute)
            End If

        Else
            ' If we can't get the property from the theme, get the default value.
            Return GetDefaultValue(DesiredNode, NodeAttribute)
        End If
    End Function

    Private Shared Function GetAttribute(NodePath As String, NodeName As String, AttributeName As String) As String
        ' TODO: Check to make sure the requested attribute is supported in
        ' the version of the theme engine the theme is requesting to use.
        ' See also https://github.com/DrewNaylor/UXL-Launcher/issues/170

        If ThemeProperties.themeSheet.SelectSingleNode(NodePath, ThemeProperties.themeNamespaceManager) IsNot Nothing Then
            ' If the node exists, store it in a variable to make the code easier to read.
            Dim FullNodePath As XmlNode = ThemeProperties.themeSheet.SelectSingleNode(NodePath, ThemeProperties.themeNamespaceManager)
            If FullNodePath.Attributes(AttributeName) IsNot Nothing Then
                ' If the attribute exists and is compatible with the version of the theme engine
                ' the theme wants to use, return the attribute.
                Return FullNodePath.Attributes(AttributeName).Value
            Else
                ' Otherwise, return the default value.
                Return GetDefaultValue(NodeName, AttributeName)
            End If
        Else
            ' If the node does not exist, return the default value.
            Return GetDefaultValue(NodeName, AttributeName)
        End If

    End Function

    Private Shared Function GetInnerText(NodePath As String, NodeName As String, NodeAttribute As String) As String
        ' TODO: Check to make sure the requested node innertext is supported in
        ' the version of the theme engine the theme is requesting to use.
        ' See also https://github.com/DrewNaylor/UXL-Launcher/issues/170

        ' Create a variable to store a forward slash char
        ' for trimming from the end of the node just in
        ' case one somehow ended up there, such as if
        ' no node attribute was passed to the GetPropertySafe
        ' function.
        Dim ForwardSlash As Char = CChar("/")
        If ThemeProperties.themeSheet.SelectSingleNode(NodePath.TrimEnd(ForwardSlash), ThemeProperties.themeNamespaceManager) IsNot Nothing Then
            ' First check if the node exists.
            ' If it does exist, create a variable to store the node innertext.
            Dim NodeInnerText As String = ThemeProperties.themeSheet.SelectSingleNode(NodePath, ThemeProperties.themeNamespaceManager).InnerText.ToString
            If NodeInnerText IsNot Nothing Then
                ' If the node exists and is compatible with the version of the theme engine
                ' the theme wants to use, return the innertext.
                Return NodeInnerText
            Else
                ' Otherwise, return the default value.
                Return GetDefaultValue(NodeName, NodeAttribute)
            End If
        Else
            ' If the node doesn't exist, return the default value.
            Return GetDefaultValue(NodeName, NodeAttribute)
        End If
    End Function

End Class
