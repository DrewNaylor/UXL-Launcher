﻿'PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
'Can be used with standard Windows Forms applications with a few small changes.
'Copyright (C) 2019 Drew Naylor. Licensed under Gnu GPLv3+.
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



Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Xml
Imports System.Windows.Forms
Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing

Public Class themeenginemain

    ' This file tells the theme engine what to color things. Theme engine is based on this Stack Overflow question: http://stackoverflow.com/q/199521
#Region "Set Theme via PortableThemeEngine."

    ' Make a variable that differs based on what theme is chosen.
    Public Shared userTheme As XmlDocument = New XmlDocument()
    ' Create strings for theme title, description, and author.
    Public Shared themeSheetTitle As String
    Public Shared themeSheetDescription As String
    Public Shared themeSheetAuthor As String
    ' This is the version number for the theme file itself. Not to
    ' be confused with the decimal below known as themeSheetUseThemeEngineVersion.
    Public Shared themeSheetFileVersion As String
    ' Create string for version of Theme Engine the theme is compatible with.
    Public Shared themeSheetUseThemeEngineVersion As Decimal

    ' Create a variable for the toolstrip pro renderer.
    Public Shared toolstripProRenderer As uxlProToolstripRenderer = New uxlProToolstripRenderer
    ' Create a string to store the theme name.
    Public Shared themeName As String = ""

    ' Specify whether to output debug info.
    Friend Shared enableDebugOutput As Boolean = My.Settings.enableDebugOutput


    Public Shared Sub LoadTheme(themeInput As String, formToApplyTo As Form, Optional isFilename As Boolean = True)
        Dim themesDir As String = Directory.GetCurrentDirectory & "\Themes\"

        If isFilename = True AndAlso File.Exists(themesDir & themeInput) Then
            userTheme.Load(themesDir & themeInput)
        ElseIf isFilename = True AndAlso Not File.Exists(themesDir & themeInput) Then
            userTheme.LoadXml(My.Resources.DefaultTheme_XML)
        ElseIf isFilename = False Then
            userTheme.LoadXml(themeInput)
        End If
        ApplyTheme(themeName, formToApplyTo)
    End Sub

    Public Shared Sub ApplyTheme(themeName As String, formToApplyTo As Form)
#Region "Read XML Theme Document."
        '' Parse the test theme XML document and apply stuff that's in it.
        Dim themeSheet As XmlDocument = userTheme

        '' Load the user's theme. If it's not able to be used, just load the default theme.
        'Try
        '    If userTheme IsNot Nothing Then
        '        themeSheet = (userTheme)
        '    Else
        '        themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
        '    End If
        'Catch ex As XmlException
        '    themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
        '    themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString & vbCrLf & "(Also, this code is near the top" &
        '                                "of the ApplyTheme code and it doesn't usually get hit.)")
        '    ' Complain to the user if the chosen theme doesn't have a root element.
        '    MessageBox.Show("There was a problem trying to load the " &
        '                    themeName & " theme." & vbCrLf &
        '                    "Please notify the theme's author of the message below." & vbCrLf & vbCrLf & vbCrLf &
        '                    "Theme file chosen:" & vbCrLf & themeName & vbCrLf & vbCrLf &
        '                    "Error message: " & vbCrLf & ex.Message & vbCrLf &
        '                    vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "PortableThemeEngine",
        '                    MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

        Dim themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
        themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

#Region "Define strings for controls and things in the XML document."

        ' About window Banner style (Dark or Light):
        Dim bannerStyle As Drawing.Image
        ' Button colors:
        Dim colorButtonBackColor As Color
        Dim colorButtonForeColor As Color
        Dim flatstyleButtonFlatStyle As FlatStyle ' If flatstyleButtonFlatStyle is "= Flat", the flatstyle is Flat. Standard is "FlatStyle = FlatStyle.Standard".
        Dim flatappearanceButtonBorderColor As Color ' The border of the buttons if "FlatStyle = FlatStyle.Flat".
        Dim flatappearanceButtonMouseOverBackColor As Color ' The color of the buttons on mouseover if "FlatStyle = FlatStyle.Flat".
        Dim flatappearanceButtonMouseDownBackColor As Color ' The color of the buttons on mousedown if "FlatStyle = FlatStyle.Flat".
        ' Checkbox colors:
        Dim colorCheckBoxBackColor As Color
        Dim colorCheckBoxForeColor As Color
        ' Checkbox colors:
        Dim colorDropdownBackColor As Color
        Dim colorDropdownForeColor As Color
        ' Groupbox colors:
        Dim colorGroupBoxBackColor As Color
        Dim colorGroupBoxForeColor As Color
        ' FlowLayoutPanel colors:
        Dim colorFlowLayoutPanelBackColor As Color
        Dim colorFlowLayoutPanelForeColor As Color
        ' Menubar colors:
        Dim colorMenubarBackColor As Color
        ' Status Bar colors:
        Dim colorStatusBarBackColor As Color
        ' Label colors:
        Dim colorLabelBackColor As Color
        Dim colorLabelForeColor As Color
        ' LinkLabel colors:
        Dim colorLinkLabelBackColor As Color ' used for link's background color.
        Dim colorLinkLabelForeColor As Color ' used for non-link text.
        Dim colorLinkLabelLinkColor As Color ' used for the link's usual color when not clicking it.
        Dim colorLinkLabelActiveLinkColor As Color ' used when clicking on a link.
        ' Radio Button colors:
        Dim colorRadioButtonBackColor As Color
        Dim colorRadioButtonForeColor As Color
        ' TableLayoutPanel colors:
        Dim colorTableLayoutPanelBackColor As Color
        Dim colorTableLayoutPanelForeColor As Color
        ' If the theme says to use this in the About window's
        ' About tab for the tableLayoutPanelAboutAppTab control,
        ' apply colorTableLayoutPanelBackColor to it.
        ' Otherwise, just use the colorTabPageBackColor
        ' and have the table layout panel inherit it.
        Dim useTableLayoutPanelColorInsideAboutAppTab As Boolean = False
        ' TabPage colors:
        Dim colorTabPageBackColor As Color
        Dim colorTabPageForeColor As Color
        ' Textbox colors:
        Dim colorTextboxBackColor As Color
        Dim colorTextboxForeColor As Color
        ' Menubar entry colors:
        Dim colorMenuItemBackColor As Color
        Dim colorMenuItemForeColor As Color
        ' Menubar item margin colors:
        Dim colorMenuItemImageMarginGradientStartColor As Color
        Dim colorMenuItemImageMarginGradientEndColor As Color
        ' Statusbar label colors:
        Dim colorStatusLabelBackColor As Color
        Dim colorStatusLabelForeColor As Color
        ' Other statusbar label properties
        Dim propertyStatusLabelBorderSides As ToolStripStatusLabelBorderSides
        Dim propertyStatusLabelBorderStyle As Border3DStyle
#End Region

#Region "Pull theme colors and other elements from XML documents."

#Region "Pull UseThemeEngineVersion element from XML."

        ' If the value in the theme file isn't a decimal,
        ' set it to 1.01 in the Catch part of this Try...Catch block.
        ' See also https://github.com/DrewNaylor/UXL-Launcher/issues/126
        Try
            ' Only pull the UseThemeEngineVersion element from XML if it exists.
            If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager) IsNot Nothing Then
                ' If the version of the theme engine to be used as specified in the theme file is less than 1.01, set it to 1.01.
                If CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText) < 1.01 Then
                    themeSheetUseThemeEngineVersion = CDec(1.01)
                    outputThemeEngineVersionToUse(themeSheetUseThemeEngineVersion)

                    ' If the version of the theme engine to be used as specified in the theme file is greater than or equal to 1.01,
                    ' set it to whatever the version is specified in the theme file.
                ElseIf CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText) >= 1.01 Then
                    themeSheetUseThemeEngineVersion = CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText)

                    outputThemeEngineVersionToUse(themeSheetUseThemeEngineVersion)
                End If
            Else
                ' If the XML element is missing, manually force the value to be 1.01.
                themeSheetUseThemeEngineVersion = CDec(1.01)

                outputThemeEngineVersionToUse(themeSheetUseThemeEngineVersion)
            End If
        Catch ex As System.InvalidCastException
            ' Catch invalid numbers as referenced in this issue:
            ' https://github.com/DrewNaylor/UXL-Launcher/issues/126
            ' This will force the themeSheetUseThemeEngineVersion decimal to be
            ' set to be 1.01 if this exception occurs.

            themeSheetUseThemeEngineVersion = CDec(1.01)
        End Try

#End Region

#Region "Pull Title theme element from XML."

        ' Only pull the title element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetTitle = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager).InnerText

        Else
            themeSheetTitle = "(No title specified)"

        End If
#End Region

#Region "Pull Description theme element from XML."
        ' Only pull the description element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetDescription = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager).InnerText

        Else
            themeSheetDescription = "(No description specified)"

        End If
#End Region

#Region "Pull Author theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetAuthor = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager).InnerText

        Else
            themeSheetAuthor = "(No author specified)"

        End If
#End Region

#Region "Pull Version theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetFileVersion = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", themeNamespaceManager).InnerText

        Else
            themeSheetFileVersion = "(No version specified)"

        End If
#End Region

#Region "About window Banner Style"
        ' Only look at the banner style if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/AboutWindow/BannerStyle[1]", themeNamespaceManager) IsNot Nothing Then
            ' If the theme says to use the "Dark" banner, use it.
            If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/AboutWindow/BannerStyle[1]", themeNamespaceManager).InnerText = "Dark" Then
                bannerStyle = My.Resources.DARK_UXL_Launcher_Banner

            Else
                ' If the element is something else, use the regular banner.
                bannerStyle = My.Resources.UXL_Launcher_Banner
            End If
        Else
            ' Otherwise, make sure it's set if it's not in the theme.
            bannerStyle = My.Resources.UXL_Launcher_Banner
        End If
#End Region

#Region "Pull Button theme element from XML."
        ' Try to pull the Button colors from XML.
#Region "Button BackColor"
        ' Only pull the Button BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorButtonBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorButtonBackColor = Color.Transparent
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorButtonBackColor = Color.Transparent
        End If
#End Region

#Region "Button ForeColor"
        ' Only pull the Button ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorButtonForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "Button flat style"
        ' Only pull the Button BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatStyle[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                ' See what the theme file has flat style set up as. Currently, only "Flat" and "Standard" are supported.
                If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatStyle[1]", themeNamespaceManager).InnerText = "Flat" Then
                    flatstyleButtonFlatStyle = FlatStyle.Flat
                Else
                    flatstyleButtonFlatStyle = FlatStyle.Standard
                End If

                ' If the element isn't valid, just replace it with the default.
            Catch ex As Exception
                flatstyleButtonFlatStyle = FlatStyle.Standard
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            flatstyleButtonFlatStyle = FlatStyle.Standard
        End If
#End Region

#Region "Button flat appearance border color"
        ' Only pull the Button FlatAppearance BorderColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatAppearance/BorderColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                flatappearanceButtonBorderColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatAppearance/BorderColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                flatappearanceButtonBorderColor = Nothing
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            flatappearanceButtonBorderColor = Nothing
        End If
#End Region

#Region "Button flat appearance mousedown color (TE 1.03 or greater)"
        ' Make sure the theme file is set to use ThemeEngine 1.03 or higher.
        If themeSheetUseThemeEngineVersion >= 1.03 Then

            ' Only pull the Button FlatAppearance MouseDownBackColor element from XML if it exists.
            If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatAppearance/MouseDownBackColor[1]", themeNamespaceManager) IsNot Nothing Then
                Try
                    flatappearanceButtonMouseDownBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatAppearance/MouseDownBackColor[1]", themeNamespaceManager).InnerText)

                    ' If the element isn't a valid HTML color, just replace it with the default.
                Catch ex As Exception
                    flatappearanceButtonMouseDownBackColor = Nothing
                End Try
            Else
                ' If the element doesn't exist, overwrite it with the Default theme's value.
                flatappearanceButtonMouseDownBackColor = Nothing
            End If
        Else
            ' If the theme file is set to use something lower than 1.03,
            ' use the default value.
            flatappearanceButtonMouseDownBackColor = Nothing
        End If
#End Region

#Region "Button flat appearance mouseover color (TE 1.03 or greater)"
        ' Make sure the theme file is set to use ThemeEngine 1.03 or higher.
        If themeSheetUseThemeEngineVersion >= 1.03 Then

            ' Only pull the Button FlatAppearance MouseOverBackColor element from XML if it exists.
            If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatAppearance/MouseOverBackColor[1]", themeNamespaceManager) IsNot Nothing Then
                Try
                    flatappearanceButtonMouseOverBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/FlatAppearance/MouseOverBackColor[1]", themeNamespaceManager).InnerText)

                    ' If the element isn't a valid HTML color, just replace it with the default.
                Catch ex As Exception
                    flatappearanceButtonMouseOverBackColor = Nothing
                End Try
            Else
                ' If the element doesn't exist, overwrite it with the Default theme's value.
                flatappearanceButtonMouseOverBackColor = Nothing
            End If
        Else
            ' If the theme file is set to use something lower than 1.03,
            ' use the default value.
            flatappearanceButtonMouseOverBackColor = Nothing
        End If
#End Region

#End Region

#Region "CheckBox BackColor"
        ' Only pull the Checkbox BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/CheckBox/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorCheckBoxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/CheckBox/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorCheckBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorCheckBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
        End If
#End Region

#Region "CheckBox ForeColor"
        ' Only pull the CheckBox ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/CheckBox/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorCheckBoxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/CheckBox/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorCheckBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorCheckBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "Dropdown BackColor"
        ' Only pull the Dropdown BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Dropdown/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorDropdownBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Dropdown/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorDropdownBackColor = Color.FromKnownColor(KnownColor.Window)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorDropdownBackColor = Color.FromKnownColor(KnownColor.Window)
        End If
#End Region

#Region "Dropdown ForeColor"
        ' Only pull the Dropdown ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Dropdown/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorDropdownForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Dropdown/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorDropdownForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorDropdownForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "GroupBox BackColor"
        ' Only pull the GroupBox BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorGroupBoxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorGroupBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorGroupBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
        End If
#End Region

#Region "GroupBox ForeColor."
        ' Only pull the GroupBox ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorGroupBoxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorGroupBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorGroupBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "FlowLayoutPanel BackColor."
        ' Only pull the FlowLayoutPanel BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorFlowLayoutPanelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorFlowLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Window)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorFlowLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Window)
        End If
#End Region

#Region "FlowLayoutPanel ForeColor"
        ' Only pull the FlowLayoutPanel ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorFlowLayoutPanelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorFlowLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorFlowLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "StatusBar BackColor."
        ' Only pull the StatusBar BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            ' If the node exists and if it has "LiteralNothing" in the inner text, then we literally set the
            ' color for the statusbar back color to "Nothing".
            ' This makes it so that the statusbar appears like it would if the theme engine were turned off.
            ' Only used if the theme is compatible with TE1.03 or greater.
            If themeSheetUseThemeEngineVersion >= 1.03 AndAlso themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager).InnerText = "LiteralNothing" Then
                colorStatusBarBackColor = Nothing

                ' If the theme doesn't want to use "Nothing" as a color, then 
                ' use the color it says to use.
            ElseIf Not themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager).InnerText = "LiteralNothing" Then
                Try
                    colorStatusBarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager).InnerText)

                    ' If the element isn't a valid HTML color, just replace it with the default.
                Catch ex As Exception
                    colorStatusBarBackColor = Color.FromKnownColor(KnownColor.Control)
                End Try
            Else
                ' If the element doesn't exist, overwrite it with the Default theme's value.
                colorStatusBarBackColor = Color.FromKnownColor(KnownColor.Control)
            End If
        End If
#End Region

#Region "Label BackColor"
        ' Only pull the Label BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
        End If
#End Region

#Region "Label ForeColor"
        ' Only pull the Label ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "LinkLabel ActiveLinkColor"
        ' Only pull the LinkLabel ActiveLinkColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/ActiveLinkColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorLinkLabelActiveLinkColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/ActiveLinkColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorLinkLabelActiveLinkColor = Color.FromKnownColor(KnownColor.Red)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorLinkLabelActiveLinkColor = Color.FromKnownColor(KnownColor.Red)
        End If
#End Region

#Region "LinkLabel LinkColor"
        ' Only pull the LinkLabel LinkColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/LinkColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorLinkLabelLinkColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/LinkColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorLinkLabelLinkColor = Color.FromArgb(0, 0, 255)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorLinkLabelLinkColor = Color.FromArgb(0, 0, 255)
        End If
#End Region

#Region "LinkLabel BackColor"
        ' Only pull the LinkLabel BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorLinkLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorLinkLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorLinkLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
        End If
#End Region

#Region "LinkLabel ForeColor"
        ' Only pull the LinkLabel ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorLinkLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/LinkLabel/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorLinkLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorLinkLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "Radio Button BackColor"
        ' Only pull the Radio Button BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/RadioButton/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorRadioButtonBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/RadioButton/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorRadioButtonBackColor = Color.FromKnownColor(KnownColor.Transparent)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorRadioButtonBackColor = Color.FromKnownColor(KnownColor.Transparent)
        End If
#End Region

#Region "Radio Button ForeColor"
        ' Only pull the Radio Button ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/RadioButton/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorRadioButtonForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/RadioButton/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorRadioButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorRadioButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "TableLayoutPanel BackColor"
        ' Only pull the TableLayoutPanel ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TableLayoutPanel/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorTableLayoutPanelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TableLayoutPanel/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorTableLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Control)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorTableLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Control)
        End If
#End Region

#Region "TableLayoutPanel ApplyToAboutWindowAboutTabTLP"
        ' Only pull the TableLayoutPanel ApplyToAboutWindowAboutTabTLP element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TableLayoutPanel/ApplyToAboutWindowAboutTabTLP[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                useTableLayoutPanelColorInsideAboutAppTab = CBool(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TableLayoutPanel/ApplyToAboutWindowAboutTabTLP[1]", themeNamespaceManager).InnerText.ToString)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                useTableLayoutPanelColorInsideAboutAppTab = False
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            useTableLayoutPanelColorInsideAboutAppTab = False
        End If
#End Region

#Region "TableLayoutPanel ForeColor"
        ' Only pull the TableLayoutPanel ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TableLayoutPanel/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorTableLayoutPanelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TableLayoutPanel/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorTableLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorTableLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "TabPage BackColor"
        ' Only pull the FlowLayoutPanel ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TabPage/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorTabPageBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TabPage/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorTabPageBackColor = Color.FromKnownColor(KnownColor.Window)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorTabPageBackColor = Color.FromKnownColor(KnownColor.Window)
        End If
#End Region

#Region "TabPage ForeColor"
        ' Only pull the FlowLayoutPanel ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TabPage/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorTabPageForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TabPage/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorTabPageForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorTabPageForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "TextBox BackColor."
        ' Only pull the TextBox BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorTextboxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorTextboxBackColor = Color.FromKnownColor(KnownColor.Window)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorTextboxBackColor = Color.FromKnownColor(KnownColor.Window)
        End If
#End Region

#Region "TextBox ForeColor."
        ' Only pull the TextBox ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorTextboxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorTextboxForeColor = Color.FromKnownColor(KnownColor.WindowText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorTextboxForeColor = Color.FromKnownColor(KnownColor.WindowText)
        End If
#End Region

#Region "MenuItem BackColor"
        ' Only pull the MenuItem BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorMenuItemBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorMenuItemBackColor = Color.FromKnownColor(KnownColor.Window)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorMenuItemBackColor = Color.FromKnownColor(KnownColor.Window)
        End If
#End Region

#Region "MenuItem Image margin background gradient"
#Region "Start color"
        ' Only pull the MenuItem Image Margin Gradient Start Color element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ImageMarginGradient/StartColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorMenuItemImageMarginGradientStartColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ImageMarginGradient/StartColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorMenuItemImageMarginGradientStartColor = ColorTranslator.FromHtml("0xFCFCFC")
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorMenuItemImageMarginGradientStartColor = ColorTranslator.FromHtml("0xFCFCFC")
        End If
#End Region
#Region "End color"
        ' Only pull the MenuItem Image Margin Gradient End Color element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ImageMarginGradient/EndColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorMenuItemImageMarginGradientEndColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ImageMarginGradient/EndColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorMenuItemImageMarginGradientEndColor = ColorTranslator.FromHtml("0xF1F1F1")
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorMenuItemImageMarginGradientEndColor = ColorTranslator.FromHtml("0xF1F1F1")
        End If
#End Region
#End Region

#Region "MenuBar BackColor"
        ' Only pull the MenuBar BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuBar/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorMenubarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuBar/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorMenubarBackColor = Color.FromKnownColor(KnownColor.Control)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorMenubarBackColor = Color.FromKnownColor(KnownColor.Control)
        End If
#End Region

#Region "MenuItem ForeColor."
        ' Only pull the MenuItem ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorMenuItemForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorMenuItemForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorMenuItemForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "StatusLabel BackColor."
        ' Only pull the StatusLabel BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorStatusLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BackColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorStatusLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorStatusLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
        End If
#End Region

#Region "StatusLabel ForeColor."
        ' Only pull the StatusLabel ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorStatusLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/ForeColor[1]", themeNamespaceManager).InnerText)

                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorStatusLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorStatusLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "StatusLabel BorderSides."
        ' Only pull the StatusLabel BorderSides element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderSides[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                Dim tempBorderSidesXMLValue As String
                tempBorderSidesXMLValue = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderSides[1]", themeNamespaceManager).InnerText
                ' Because I can't find an easy way to set propertyStatusLabelBorderSides to the XML element directly, I have to set it with a string comparison.
                If tempBorderSidesXMLValue = "All" Then
                    propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.All
                ElseIf tempBorderSidesXMLValue = "Top" Then
                    propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Top
                ElseIf tempBorderSidesXMLValue = "Left" Then
                    propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Left
                ElseIf tempBorderSidesXMLValue = "Bottom" Then
                    propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Bottom
                ElseIf tempBorderSidesXMLValue = "Right" Then
                    propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.Right
                    ' If the theme file has something else, then we'll just set it to None.
                Else
                    propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.None
                End If

                ' If the element isn't valid, just replace it with the default.
            Catch ex As Exception
                propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.None
            End Try
        End If
#End Region

#Region "StatusLabel BorderStyle."
        ' Only pull the StatusLabel BorderStyle element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderStyle[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                Dim tempBorderStyleXMLValue As String
                tempBorderStyleXMLValue = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderStyle[1]", themeNamespaceManager).InnerText
                ' Because I can't find an easy way to set propertyStatusLabelBorderSides to the XML element directly, I have to set it with a string comparison.
                If tempBorderStyleXMLValue = "Adjust" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.Adjust
                ElseIf tempBorderStyleXMLValue = "Bump" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.Bump
                ElseIf tempBorderStyleXMLValue = "Etched" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.Etched
                ElseIf tempBorderStyleXMLValue = "Raised" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.Raised
                ElseIf tempBorderStyleXMLValue = "RaisedInner" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.RaisedInner
                ElseIf tempBorderStyleXMLValue = "RaisedOuter" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.RaisedOuter
                ElseIf tempBorderStyleXMLValue = "Sunken" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.Sunken
                ElseIf tempBorderStyleXMLValue = "SunkenInner" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.SunkenInner
                ElseIf tempBorderStyleXMLValue = "SunkenOuter" Then
                    propertyStatusLabelBorderStyle = Border3DStyle.SunkenOuter
                    ' If the theme file has something else, then we'll just set it to Flat.
                Else
                    propertyStatusLabelBorderStyle = Border3DStyle.Flat
                End If

                ' If the element isn't valid, just replace it with the default.
            Catch ex As Exception
                propertyStatusLabelBorderStyle = Border3DStyle.Flat
            End Try
        End If
#End Region

#Region "Set colors for controls."

        ' Look at all the controls in the form passed to the theme engine
        ' and change their theme.
        ' Code based on this VBForums post:
        ' http://www.vbforums.com/showthread.php?387308-Visit-Every-Control-on-a-Form-(includes-nested-controls-no-recursion)

        'formToApplyTo.BackColor = colorFlowLayoutPanelBackColor
        'formToApplyTo.ForeColor = colorFlowLayoutPanelForeColor

#Region "Apply default colors to forms not supported by TE1.02 or lower."
        ' Apply default colors to forms that aren't supported by TE1.02 or lower.
        If formToApplyTo.Name = "aaformAboutWindow" AndAlso themeSheetUseThemeEngineVersion < 1.03 Or formToApplyTo.Name = "aaformOptionsWindow" AndAlso themeSheetUseThemeEngineVersion < 1.03 Then
            ' If the theme doesn't support TE1.03, apply defaults.
            ' Default button colors.
            colorButtonBackColor = Color.FromKnownColor(KnownColor.Transparent)
            colorButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)
            flatstyleButtonFlatStyle = FlatStyle.Standard
            flatappearanceButtonBorderColor = Nothing

            ' Default TableLayoutPanel colors.
            colorTableLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Control)
            colorTableLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Default TabPage colors.
            colorTabPageBackColor = Color.FromKnownColor(KnownColor.Window)
            colorTabPageForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Default GroupBox colors.
            colorGroupBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
            colorGroupBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Default Label colors.
            colorLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
            colorLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Default Textbox colors.
            colorTextboxBackColor = Color.FromKnownColor(KnownColor.Window)
            colorTextboxForeColor = Color.FromKnownColor(KnownColor.WindowText)

            ' Default RadioButton colors.
            colorRadioButtonBackColor = Color.FromKnownColor(KnownColor.Transparent)
            colorRadioButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Default Checkbox colors.
            colorCheckBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
            colorCheckBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Default Dropdown box/ComboBox colors.
            colorDropdownBackColor = Color.FromKnownColor(KnownColor.Window)
            colorDropdownForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Default LinkLabel colors.
            colorLinkLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
            colorLinkLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
            colorLinkLabelLinkColor = Color.FromArgb(0, 0, 255)
            colorLinkLabelActiveLinkColor = Color.FromKnownColor(KnownColor.Red)

            ' Default About window banner.
            bannerStyle = My.Resources.UXL_Launcher_Banner

            'Default FlowLayoutPanel colors.
            colorFlowLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Window)
            colorFlowLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "Now apply colors to controls in each form passed to the theme engine."
        Dim ctrl As Control = formToApplyTo.GetNextControl(formToApplyTo, True)
        Do Until ctrl Is Nothing
            'MessageBox.Show(ctrl.Name.ToString)

            If TypeOf ctrl Is GroupBox Then
                ' If the control is a groupbox, theme it as a groupbox.
                ctrl.BackColor = colorGroupBoxBackColor
                ctrl.ForeColor = colorGroupBoxForeColor

                'ElseIf TypeOf ctrl Is SplitContainer Then
                '    ' Split containers aren't yet fully supported and this is just a placeholder.
                '    ctrl.BackColor = colorFlowLayoutPanelBackColor
                '    ctrl.ForeColor = colorFlowLayoutPanelForeColor
                '    ' For split containers, we have to go through the controls inside
                '    ' them to change their colors.
                '    ctrl = ctrl.GetNextControl(ctrl, True)



            ElseIf TypeOf ctrl Is Button Then
                ' If the control is a button, theme it as a button.
                ' We have to define a button locally since "FlatStyle"
                ' isn't something that Control types have by default.
                Dim button As Button = CType(ctrl, Button)
                ' Set button BackColor (background color).
                button.BackColor = colorButtonBackColor
                ' Set button ForeColor (text color).
                button.ForeColor = colorButtonForeColor
                ' Set button style, whether that be flat, "Standard", or another
                ' supported style.
                button.FlatStyle = flatstyleButtonFlatStyle

                ' Set button flat appearance border color if flatstyleButtonFlatStyle = Flat.
                ' Note that this can be any valid HTML or system color, including "Nothing"
                ' ("Nothing" is the default value based on my testing).
                ' Using "Transparent" causes a System.NotSupportedException
                ' exception, so add a try...catch block and explain in the debug output.
                Try
                    button.FlatAppearance.BorderColor = flatappearanceButtonBorderColor
                Catch ex As System.NotSupportedException
                    ' If the useThemeEngineVersion element in the theme is
                    ' greater than or equal to 1.02, also set bordercolor
                    ' to "Nothing".

                    ' This is being done in an exception, so it should
                    ' work just fine in regular usage when things work.
                    If themeSheetUseThemeEngineVersion >= 1.02 Then
                        button.FlatAppearance.BorderColor = Nothing
                    End If
                    themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
                End Try

                ' Now change the color for when the mouse clicks down
                ' on a button and the flat appearance is set to flat.
                button.FlatAppearance.MouseDownBackColor = flatappearanceButtonMouseDownBackColor

                ' Change the color for when the mouse goes over
                ' a button and the flat appearance is set to flat.
                button.FlatAppearance.MouseOverBackColor = flatappearanceButtonMouseOverBackColor

            ElseIf TypeOf ctrl Is ComboBox Then

                Try ' Try to apply the dropdown backcolor.
                    ctrl.BackColor = colorDropdownBackColor
                Catch ex As ArgumentException
                    ' Now, make sure the background isn't transparent.
                    ' Dropdown boxes/comboboxes don't support transparent backgrounds.
                    ctrl.BackColor = Color.FromKnownColor(KnownColor.Window)
                End Try
                ' Now do the forecolor.
                ctrl.ForeColor = colorDropdownForeColor

            ElseIf TypeOf ctrl Is CheckBox Then
                ' If the control is a checkbox, theme it as such.
                ' CheckBox BackColor.
                ctrl.BackColor = colorCheckBoxBackColor
                ' CheckBox ForeColor.
                ctrl.ForeColor = colorCheckBoxForeColor

            ElseIf TypeOf ctrl Is FlowLayoutPanel Then
                ' If the control is a flowlayoutpanel, theme it as such.
                ' FlowLayoutPanel BackColor.
                ctrl.BackColor = colorFlowLayoutPanelBackColor
                ' FlowLayoutPanel ForeColor.
                ctrl.ForeColor = colorFlowLayoutPanelForeColor

            ElseIf TypeOf ctrl Is LinkLabel Then
                ' If the control is a LinkLabel, theme it appropriately.
                ' Define a linklabel locally since there are things it has
                ' that Control doesn't have by default.

                ' This needs to be above the "Label" entry as otherwise
                ' the colors won't apply to linklabels for the linkcolor
                ' and activelinkcolor properties.
                Dim linklabel As LinkLabel = CType(ctrl, LinkLabel)
                linklabel.BackColor = colorLinkLabelBackColor
                linklabel.ForeColor = colorLinkLabelForeColor
                linklabel.LinkColor = colorLinkLabelLinkColor
                linklabel.ActiveLinkColor = colorLinkLabelActiveLinkColor

            ElseIf TypeOf ctrl Is Label Then
                ' If the control is a label, theme it as a label.
                ' Set label BackColor (background color).
                ctrl.BackColor = colorLabelBackColor
                ' Set label ForeColor (text color).
                ctrl.ForeColor = colorLabelForeColor

            ElseIf TypeOf ctrl Is MenuStrip Then
                ' If the control is a menustrip (menu bar), theme it as such.

                ' Create a local variable to refer to the menustrip.
                Dim menustrip As MenuStrip = CType(ctrl, MenuStrip)

                'MessageBox.Show(menustrip.Name.ToString)

                ' Set menustrip back color as apropriate.
                menustrip.BackColor = colorMenubarBackColor


                ' Set color for the toolstrip pro renderer.
                toolstripProRenderer.BackColor = colorMenubarBackColor
                toolstripProRenderer.ForeColor = colorMenuItemForeColor
                toolstripProRenderer.DropdownBackColor = colorMenuItemBackColor
                toolstripProRenderer.ImageMarginGradientStartColor = colorMenuItemImageMarginGradientStartColor
                toolstripProRenderer.ImageMarginGradientEndColor = colorMenuItemImageMarginGradientEndColor
                toolstripProRenderer.TextHighlightColor = Color.FromKnownColor(KnownColor.ControlText)

                ' Look at each ToolStripMenuItem in the menustrip.
                For Each menuitem As ToolStripMenuItem In menustrip.Items
                    'MessageBox.Show(menuitem.Name.ToString)

                    If menuitem.Owner Is menustrip Then
                        ' If the owner of the menuitem is the menustrip,
                        ' theme it to match the menustrip.
                        menuitem.BackColor = colorMenubarBackColor
                        menuitem.ForeColor = colorMenuItemForeColor

                    Else
                        ' Otherwise, theme it as a dropdown since its
                        ' owner isn't the menustrip.
                        menuitem.BackColor = colorMenuItemBackColor
                        menuitem.ForeColor = colorMenuItemForeColor

                    End If
                Next

            ElseIf TypeOf ctrl Is TextBox Then
                ' If the control is a textbox, theme it as a textbox.
                ' Set textbox BackColor (background color).
                ctrl.BackColor = colorTextboxBackColor
                ' Set textbox ForeColor (text color).
                ctrl.ForeColor = colorTextboxForeColor

            ElseIf TypeOf ctrl Is RadioButton Then
                ' If the control is a radiobutton, theme it as such.
                ' RadioButton BackColor.
                ctrl.BackColor = colorRadioButtonBackColor
                ' RadioButton ForeColor.
                ctrl.ForeColor = colorRadioButtonForeColor

            ElseIf TypeOf ctrl Is StatusStrip Then
                ' Create a local variable and cast "ctrl" as a StatusStrip.
                Dim statusstrip As StatusStrip = CType(ctrl, StatusStrip)
                ' Apply the BackColor to the statusstrip variable created earlier.
                statusstrip.BackColor = colorStatusBarBackColor

                ' Look inside the controls that are in the statusstrip's items collection.
                For Each statusstripcontrol As ToolStripItem In statusstrip.Items
                    ' If an item is a toolstripstatuslabel, then theme it like one.
                    If TypeOf statusstripcontrol Is ToolStripStatusLabel Then
                        ' We have to create a local variable to refer to
                        ' the statuslabels, since otherwise we'd run into
                        ' an invalid cast exception.
                        Dim statuslabel As ToolStripStatusLabel = CType(statusstripcontrol, ToolStripStatusLabel)
                        ' Apply statuslabel BackColor.
                        statuslabel.BackColor = colorStatusLabelBackColor
                        ' Apply statuslabel ForeColor.
                        statuslabel.ForeColor = colorStatusLabelForeColor
                        ' Apply statuslabel BorderSides property.
                        statuslabel.BorderSides = propertyStatusLabelBorderSides
                        ' I was having some issues with setting the BorderStyle, so Try...Catch.
                        ' Ideally this wouldn't rely on a Try...Catch block, but I didn't
                        ' know of a better solution back then. Maybe there would be a better
                        ' solution for this.
                        Try
                            statuslabel.BorderStyle = propertyStatusLabelBorderStyle
                        Catch ex As System.ComponentModel.InvalidEnumArgumentException
                            ' It may be a good idea to output text talking about this exception if people run into it.
                            themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
                        End Try
                    End If
                    ' Move on to next control in the statusstrip.
                Next

            ElseIf TypeOf ctrl Is TabPage Then
                ' If the control is a tabpage, theme it as such.
                ' TabPage BackColor.
                ctrl.BackColor = colorTabPageBackColor
                ' TabPage ForeColor.
                ctrl.ForeColor = colorTabPageForeColor

            ElseIf TypeOf ctrl Is TableLayoutPanel Then
                ' If the control is a tablelayoutpanel, theme it as such.
                ' TableLayoutPanel BackColor.
                ctrl.BackColor = colorTableLayoutPanelBackColor
                ' TableLayoutPanel ForeColor.
                ctrl.ForeColor = colorTableLayoutPanelForeColor

                ' If the theme doesn't want to apply to the table layout panel
                ' in the About window About tab, apply the tab page back color
                ' and forecolor instead.
                If ctrl.Name = "tableLayoutPanelAboutAppTab" AndAlso useTableLayoutPanelColorInsideAboutAppTab = False Then
                    ctrl.BackColor = colorTabPageBackColor
                    ctrl.ForeColor = colorTabPageForeColor
                End If

                'ElseIf TypeOf ctrl Is Panel Then
                '    ' Panels aren't yet fully supported and this is just a placeholder.
                '    ctrl.BackColor = colorTableLayoutPanelBackColor
                '    ctrl.ForeColor = colorTableLayoutPanelForeColor

            ElseIf TypeOf ctrl Is PictureBox AndAlso ctrl.Name = "pictureboxUXLBanner" Then
                ' Apply dark/light banners in the About window if the theme
                ' wants to.
                ' Create a local PictureBox control since "Image" isn't a thing in
                ' "Control" by default.
                Dim picturebox As PictureBox = CType(ctrl, PictureBox)
                picturebox.Image = bannerStyle


            End If ' End of If statement for checking to see what each control's type is.

            ' Get the next control in the tab order.
            ctrl = formToApplyTo.GetNextControl(ctrl, True)
        Loop
#End Region
#End Region
    End Sub ' End of ApplyTheme Sub.
#End Region
#End Region

#Region "Start the theme engine and apply the user's theme."
    Public Shared Sub themeEngine_ChooseUserTheme(themeName As String, formToApplyTo As Form, toolstripProRenderer As uxlProToolstripRenderer, Optional customThemePath As String = "", Optional allowCustomThemes As Boolean = True)

        ' This documentation page helped a lot for getting this working:
        ' https://msdn.microsoft.com/en-us/library/system.xml.xmldocument.loadxml(v=vs.110).aspx

        ' First, remove the double-quotes from the custom theme path.
        ' This was moved up here so that it can be refered to in other
        ' parts of this sub.
        Dim tempRemoveQuotesInCustomThemePath As String = customThemePath.Replace("""", "")

        Try ' Make sure the theme engine doesn't break.


            ' Then we see if the userChosenTheme setting contains the word "Theme."
            ' If it does not, we just add "Theme_XML" to the end of the string.
            If Not themeName.Contains("Theme") And Not themeName = ("(Custom)") Then
                userTheme.LoadXml(My.Resources.ResourceManager.GetString(themeName & "Theme_XML"))
                ' However, if it does, then we only add "_XML" to the string.
            ElseIf themeName.Contains("Theme") Then
                userTheme.LoadXml(My.Resources.ResourceManager.GetString(themeName & "_XML"))
                ' If the user has a custom theme enabled, use that instead.
            ElseIf themeName = "(Custom)" Then
                ' Make sure the theme path and file exists and custom themes are allowed
                ' to be used.
                If File.Exists(tempRemoveQuotesInCustomThemePath) And allowCustomThemes = True Then
                    userTheme.Load(tempRemoveQuotesInCustomThemePath)
                    ' Otherwise, just set the theme to use to the Default theme to make sure everything works.
                    ' Then we output that the custom theme file wasn't found if that's the problem, or if custom
                    ' themes are not allowed to be used.
                ElseIf Not File.Exists(tempRemoveQuotesInCustomThemePath) Then
                    userTheme.LoadXml(My.Resources.DefaultTheme_XML)
                    ' If the theme engine output debug setting is enabled, output an error
                    ' in the Immediate Window or debug textbox if the custom theme file cannot be found.
                    themeSettingsInvalidMessage("UXLLauncher.ThemeEngine.FileNotFound_CustomTheme", "Couldn't find custom theme file.")
                ElseIf allowCustomThemes = False Then
                    ' If custom themes are not allowed to be used, use the Default theme and tell the
                    ' user in the debug output that they're not allowed.
                    userTheme.LoadXml(My.Resources.DefaultTheme_XML)
                    themeSettingsInvalidMessage("UXLLauncher.ThemeEngine.CustomThemesNotAllowed", "Custom themes are not allowed to be used." & vbCrLf &
                                                "Please contact your administrator for further assistance.")
                End If
            Else
                ' If none of the above conditions apply, just load the Default theme.
                userTheme.LoadXml(My.Resources.DefaultTheme_XML)
            End If
        Catch ex As System.ArgumentNullException
            ' If the theme name in My.Settings.userChosenTheme does not match one of the theme files
            ' included in My.Resources, the ArgumentNullException will be fired and the default theme
            ' will be used instead temporarily. The developer, user, or theme designer will be notified
            ' about this error in the Immediate Window.
            themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
            userTheme.LoadXml(My.Resources.DefaultTheme_XML)
        Catch ex As XmlException
            ' If there's an XmlException (which can occur if the selected theme has no
            ' root element), tell the user, developer, or theme designer
            ' and use the default theme.
            userTheme.LoadXml(My.Resources.DefaultTheme_XML)
            themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
        Catch ex As System.UnauthorizedAccessException
            ' Also catch UnauthorizedAccessException.
            ' If this exception occurs, it may be because
            ' a file was accessed that's not allowed to be accessed,
            ' such as a file in the Windows directory.
            themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
        End Try

        ' After this is all done, we then write the settingsThemeName string and the actual XML document
        ' containing the theme to the Debugger/Immediate Window, if theme output is enabled. Note that
        ' this happens BEFORE any theme colors are applied.
        If enableDebugOutput = True Then
            Debug.WriteLine("")
            Debug.WriteLine("")
            Debug.WriteLine("")
            Debug.WriteLine("Theme name in config file:")
            Debug.WriteLine(themeName)
            Debug.WriteLine("")
            If themeName = "(Custom)" And File.Exists(tempRemoveQuotesInCustomThemePath) Then
                ' Also output the configured custom theme's file path if the user has a custom theme and it exists.
                Debug.WriteLine("")
                Debug.WriteLine("Custom theme path:")
                Debug.WriteLine(tempRemoveQuotesInCustomThemePath)
            End If
            Debug.WriteLine("Theme XML file:")
            Debug.WriteLine(userTheme.OuterXml)

            ' Also output theme info for testing purposes.
            ' This will be used in the Options window soon.
            Debug.WriteLine("getThemeFileInfo function.")
            ' First check that the theme to use is a custom theme.
            ' If it is, specify that it is.
            If themeName = "(Custom)" Then
                Debug.WriteLine(getThemeFileInfo(userTheme, True, tempRemoveQuotesInCustomThemePath))
            Else
                ' Otherwise, just write it out.
                Debug.WriteLine(getThemeFileInfo(userTheme))
            End If


        End If

        ' Apply the theme.
        themeenginemain.ApplyTheme(themeName, formToApplyTo)
    End Sub
#End Region
#End Region

#Region "Theme Settings Invalid Message output code."
    Private Shared Sub themeSettingsInvalidMessage(exceptionType As String, Optional exceptionMessage As String = "(Not provided)", Optional fullException As String = "(Not provided)", Optional themeName As String = "(Not provided)", Optional customThemePath As String = "Not provided")
        ' Tell the user, developer, or theme designer that there's a problem with the
        ' chosen theme or custom theme. This can range from not having a root element
        ' in the chosen theme to typing the theme incorrectly in the config file.

        ' This sub accepts parameters for choosing which exceptionType message to show.


        If enableDebugOutput = True Then
            ' First, identify this block of text as part of the theme engine
            ' and that it's output for invalid theme settings.

            ' Second, remove the double-quotes from the custom theme path.
            ' This was copied here so that it can be refered to in other
            ' parts of this sub.
            Dim tempRemoveQuotesInCustomThemePath As String = customThemePath.Replace("""", "")

            Debug.WriteLine("")
            Debug.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////")
            Debug.WriteLine("PortableThemeEngine Version " & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString)
            Debug.WriteLine("Invalid Theme Settings Message Handler")
            Debug.WriteLine("--------------------------------------")
            Debug.WriteLine("Begin theme engine output:")
            Debug.WriteLine("")
            ' The following lines are commented out because I was having an issue with no output showing up.
            ' It turned out that this sub was still being called with "default" as its parameter instead of "(None)".
            'Debug.WriteLine("Parameters for this message handler:")
            'Debug.WriteLine("Exception type: " & exceptionType)
            'Debug.WriteLine("Exception message: " & exceptionMessage)

            If exceptionType.ToString = "UXLLauncher.ThemeEngine.FileNotFound_CustomTheme" Then
                ' If the custom theme file cannot be found, output it to the Immediate Window.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The theme was temporarily reset to the Default theme because the custom theme" & vbCrLf &
                            "file specified for My.Settings.userCustomThemePath wasn't found. Please ensure that" & vbCrLf &
                            "the filename below exists in the listed path. Double quotation marks in the custom theme" & vbCrLf &
                            "path are not supported and are automatically removed at runtime.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "UXLLauncher.ThemeEngine.CustomThemesNotAllowed" Then
                ' If custom themes are not supported, output it to the Immediate Window.
                Dim appName As String = My.Application.Info.ProductName.ToString
                Dim appFileName As String = My.Application.Info.AssemblyName.ToString
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("Your administrator has disabled custom themes from being used in " & appName & "." & vbCrLf &
                                "This may be due to data protection policies put in place by your organization." & vbCrLf &
                                vbCrLf &
                                "If you believe you've received this message in error, you can try to modify the" & vbCrLf &
                                "configuration files for " & appName & " located in this folder:" & vbCrLf &
                                My.Application.Info.DirectoryPath & vbCrLf &
                                "In this folder, you'll find a file named """ & appFileName & ".exe.config"". First," & vbCrLf &
                                "make a backup copy of this file. Next, open this file in your favorite text editor such as Notepad++." & vbCrLf &
                                "You should find an XML element that has a name likely similar to ""allowCustomThemes"" within the ""userSettings"" element." & vbCrLf &
                                "Below that setting XML element, you'll want to change the ""value"" from ""False"" to ""True""." & vbCrLf &
                                "Afterward, restart " & appName & ".")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "PortableThemeEngine.TestException" Then
                ' If the theme name specified in the config file for My.Settings.userChosenTheme doesn't match
                ' a theme file in My.Resources, give a message for this problem.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("""And then I said, 'Oatmeal, are you crazy?'""")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.ArgumentNullException" Then
                ' If the theme name specified in the config file for My.Settings.userChosenTheme doesn't match
                ' a theme file in My.Resources, give a message for this problem.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The theme was temporarily reset to the Default theme because the" & vbCrLf &
                            "theme name specified for themeName doesn't" & vbCrLf &
                            "match any theme files in My.Resources." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.Xml.XmlException" Then
                ' If the theme doesn't have a root element and the exception "XmlException" is triggered,
                ' say that the chosen theme has no root element.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The theme was temporarily reset to the Default theme because either the" & vbCrLf &
                            "chosen theme that themeName is set to or the" & vbCrLf &
                            "custom theme specified in My.Settings.userCustomThemePath" & vbCrLf &
                            "doesn't have a root element or otherwise has malformed XML." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.ComponentModel.InvalidEnumArgumentException" Then
                ' If the theme's StatusLabel BorderStyle property can't be found, there's a weird
                ' exception for it, so that's what this is for.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The StatusLabel BorderStyle property could not be found" & vbCrLf &
                            "in the chosen theme file/custom theme listed below," & vbCrLf &
                            "but this shouldn't cause any problems." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.UnauthorizedAccessException" Then
                ' If the exception type is an unauthorized access exception, let the user know.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("Access to the custom theme file was denied.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.NotSupportedException" Then
                ' If the theme's property for Button FlatAppearance Border Color isn't supported by
                ' the Windows Forms Button control, then give a message for this problem.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The Button FlatAppearance BorderColor property doesn't support the specified color.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            Else
                ' If there's an input that's not listed here, say that it's not supported.
                Debug.WriteLine("Input not supported: " & exceptionType)
            End If

            ' End theme engine invalid settings output.
            Debug.WriteLine("")
            Debug.WriteLine("End theme engine output.")
            Debug.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////")
        End If
    End Sub
#End Region

    Private Shared Sub outputThemeEngineVersionToUse(themeEngineVersionToUse As Decimal)
        ' Show theme engine version that the theme wants to use in the Immediate Window
        ' if the proper setting is enabled.
        If enableDebugOutput = True Then
            Debug.WriteLine("")
            Debug.WriteLine("UseThemeEngineVersion string:")
            Debug.WriteLine(themeEngineVersionToUse)
        End If
    End Sub

#Region "Get theme file info."
    ' This code is based on this issue in the
    ' GitHub repository:
    ' https://github.com/DrewNaylor/UXL-Launcher/issues/113

    Public Shared Function getThemeFileInfo(themeFile As XmlDocument, Optional isCustomTheme As Boolean = False, Optional themeFileLocation As String = "", Optional allowCustomThemes As Boolean = True) As String
        ' This function takes the themeFile as input along with whether or not the themeFile
        ' is a custom theme and returns information from the file including the theme's
        ' title, author, description, and theme file version in one string for easy
        ' display such as in the Options window.
#Region "Objects to store theme info."
        Dim themeFileReader As XmlDocument = New XmlDocument()
        ' Theme file information properties.
        Dim themeTitle As String = "(Not provided)"
        Dim themeAuthor As String = "(Not provided)"
        Dim themeDescription As String = "(Not provided)"
        Dim themeVersion As String = "(Not provided)"
        Dim themeUseThemeEngineVersion As Decimal = CDec(1.01)
        ' The completed string for use wherever it's needed.
        Dim themeDetailsComplete As String = "Please wait..."
        ' Theme namespace manager.
        Dim themeNamespaceManager As New XmlNamespaceManager(themeFileReader.NameTable)
        themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")
#End Region

#Region "Loading theme files."
        If isCustomTheme = True Then
            ' Code to run if the selected theme is a custom theme.
            ' First, make sure the theme file exists.
            ' Make sure the theme path and file exists and custom themes are allowed
            ' to be used.
            If File.Exists(themeFileLocation) And allowCustomThemes = True Then
                ' Load the custom theme file into the file reader.
                Try
                    themeFileReader.LoadXml(themeFile.OuterXml)
                Catch ex As Xml.XmlException
                    ' Catch XmlException.
                    ' This can be caused by using the "None" theme that
                    ' has purposefully invalid XML just to make sure there
                    ' aren't any problems in the theme engine that might
                    ' slip by when using valid XML.
                End Try
            ElseIf Not File.Exists(themeFileLocation) And allowCustomThemes = True Then
                ' If the file doesn't exist but custom themes are allowed,
                ' say that the Default theme will be used temporarily.
                themeDetailsComplete = "We couldn't find the custom theme file previously located below, so the Default theme will be used temporarily." & vbCrLf &
                                        themeFileLocation
                Return themeDetailsComplete
            ElseIf allowCustomThemes = False Then
                ' If custom themes aren't allowed, let the user know.
                themeDetailsComplete = "Your administrator has disabled custom themes from being used in UXL Launcher, so the Default theme will be used temporarily." &
                                       " This may be due to data protection policies put in place by your organization." &
                                       " If you believe you've received this message in error, you can try to modify the" &
                                       " configuration files for UXL Launcher located in this folder:" & vbCrLf &
                                       My.Application.Info.DirectoryPath & vbCrLf & vbCrLf &
                                       "In this folder, you'll find a file named ""UXL-Launcher.exe.config"". First," &
                                       " make a backup copy of this file. Next, open this file in your favorite text editor such as Notepad++." &
                                       " You should find an XML element that has a name of ""allowCustomThemes"" within the ""userSettings"" element." &
                                       " Below that setting XML element, you'll want to change the ""value"" from ""False"" to ""True""." &
                                       " Afterward, restart UXL Launcher."
                Return themeDetailsComplete
            End If
        Else
            ' If the selected theme is a built-in theme, just load the file.
            ' Catch an exception if the root element is missing.
            ' This can be caused if the user tries to type in a specific name
            ' into the theme list in the Options window that doesn't match a
            ' theme file exactly.
            Try
                themeFileReader.LoadXml(themeFile.OuterXml)
            Catch ex As System.Xml.XmlException
            End Try
        End If
#End Region

        ' Now that loading is done, get the theme info.
        ' This code was copy-pasted from above to make work
        ' a bit easier.
#Region "Pull info from file."
#Region "Pull Title theme element from XML."

        ' Only pull the title element from XML if it exists.
        If themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager) IsNot Nothing Then
            themeTitle = themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager).InnerText
        Else
            themeTitle = "(No title specified)"
        End If
#End Region

#Region "Pull Description theme element from XML."
        ' Only pull the description element from XML if it exists.
        If themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager) IsNot Nothing Then
            themeDescription = themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager).InnerText
        Else
            themeDescription = "(No description specified)"
        End If
#End Region

#Region "Pull Author theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager) IsNot Nothing Then
            themeAuthor = themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager).InnerText
        Else
            themeAuthor = "(No author specified)"
        End If
#End Region

#Region "Pull Version theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", themeNamespaceManager) IsNot Nothing Then
            themeVersion = themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", themeNamespaceManager).InnerText
        Else
            themeVersion = "(No version specified)"
        End If
#End Region

#Region "Pull UseThemeEngineVersion element from XML."
        ' Only pull the UseThemeEngineVersion element from XML if it exists.
        If themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager) IsNot Nothing Then
            ' If the version of the theme engine to be used as specified in the theme file is less than 1.01, set it to 1.01.
            If CDec(themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText) < 1.01 Then
                themeUseThemeEngineVersion = CDec(1.01)

                ' If the version of the theme engine to be used as specified in the theme file is greater than or equal to 1.01,
                ' set it to whatever the version is specified in the theme file.
            ElseIf CDec(themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText) >= 1.01 Then
                themeUseThemeEngineVersion = CDec(themeFileReader.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText)
            End If
        Else
            ' If the XML element is missing, manually force the value to be 1.01.
            themeSheetUseThemeEngineVersion = CDec(1.01)
        End If
#End Region
#End Region

#Region "Put together theme info into one string."
        ' Put each string together into one string to present to the user.
        themeDetailsComplete = "Title: " & themeTitle & vbCrLf &
                               "Description: " & themeDescription & vbCrLf &
                               "Version: " & themeVersion & vbCrLf &
                               "Author: " & themeAuthor & vbCrLf &
                               "Theme Engine version to use: " & themeUseThemeEngineVersion
#End Region
        ' Show the user the completed string.
        Return themeDetailsComplete
    End Function
#End Region

End Class


#Region "The new menubar renderer. It's better than the old method."
' All credit for the original code professional toolstrip renderer
' code below goes to this VBForums post: 
' http://www.vbforums.com/showthread.php?581374-menustrip-amp-toolstrip-color&p=3590240&viewfull=1#post3590240

Public Class uxlProToolstripRenderer
    Inherits ToolStripProfessionalRenderer

    Private _BackColor As Color
    ' "_DropdownBackColor" determines the colors in the menubar dropdown.
    Private _DropdownBackColor As Color
    Private _ImageMarginGradientStartColor As Color
    Private _ImageMarginGradientEndColor As Color
    Private _ForeColor As Color
    Private _TextHighlightColor As Color

    ' Get and set the backcolor for the menubar.
    Public Property BackColor() As Color
        Get
            Return _BackColor
        End Get
        Set(ByVal value As Color)
            _BackColor = value
        End Set
    End Property

    ' Get and set the backcolor for menubar dropdown items.
    Public Property DropdownBackColor As Color
        Get
            Return _DropdownBackColor
        End Get
        Set(ByVal value As Color)
            _DropdownBackColor = value
        End Set
    End Property

    ' Get and set the start color for the gradients in menuitem image margins.
    Public Property ImageMarginGradientStartColor As Color
        Get
            Return _ImageMarginGradientStartColor
        End Get
        Set(ByVal value As Color)
            _ImageMarginGradientStartColor = value
        End Set
    End Property

    ' Get and set the end color for the gradients in menuitem image margins.
    Public Property ImageMarginGradientEndColor As Color
        Get
            Return _ImageMarginGradientEndColor
        End Get
        Set(ByVal value As Color)
            _ImageMarginGradientEndColor = value
        End Set
    End Property

    ' Get and set the text highlight color for the menubar.
    Public Property TextHighlightColor() As Color
        Get
            Return _TextHighlightColor
        End Get
        Set(ByVal value As Color)
            _TextHighlightColor = value
        End Set
    End Property

    ' Get and set the forecolor for the menubar.
    Public Property ForeColor() As Color
        Get
            Return _ForeColor
        End Get
        Set(ByVal value As Color)
            _ForeColor = value
        End Set
    End Property

    ' Change the colors for the menubar background.
    Protected Overrides Sub OnRenderToolStripBackground(ByVal e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBackground(e)
        Dim lightColor As Color = Me.BackColor
        Using b As New SolidBrush(lightColor)
            e.Graphics.FillRectangle(b, e.AffectedBounds)
        End Using
    End Sub

    ' Change the color for the menubar dropdowns.
    ' Based on the code "Step 3" here:
    ' http://www.vbforums.com/showthread.php?539578-Custom-VisualStudio2008-style-MenuStrip-and-ToolStrip-Renderer&p=3333808&viewfull=1#post3333808
    Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
        MyBase.OnRenderImageMargin(e)
        ' Colors and brushes for menuitem background color.
        Dim DropDownItemBackColor As Color = Me.DropdownBackColor
        Dim dropdownBrush As New SolidBrush(DropdownBackColor)
        ' Colors and brushes for image margin gradiant.
        Dim ImageMarginGradientBrush As New LinearGradientBrush(e.AffectedBounds, Me.ImageMarginGradientStartColor,
                                                                Me.ImageMarginGradientEndColor, LinearGradientMode.Horizontal)
        ' Make the menuitem background set to the theme's color.
        Dim itembgcolor As New Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height)
        ' Fill the background of the menuitem.
        e.Graphics.FillRectangle(dropdownBrush, itembgcolor)
        ' Fill the item image margin gradient.
        e.Graphics.FillRectangle(ImageMarginGradientBrush, e.AffectedBounds)
    End Sub

    ' Change the colors for the menubar text.
    Protected Overrides Sub OnRenderItemText(ByVal e As ToolStripItemTextRenderEventArgs)
        ' If the menuitem is selected or pressed, use the TextHighlightColor for its text color.
        If e.Item.Selected = True Or e.Item.Pressed = True Then
            e.TextColor = Me.TextHighlightColor
        Else
            ' Otherwise, just use its regular ForeColor for text color.
            e.TextColor = Me.ForeColor
        End If
        MyBase.OnRenderItemText(e)
    End Sub

    ' Make sure the button arrow is visible using the ForeColor property.
    Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
        ' If the menuitem is highlighted, make the arrow the same color
        ' as the menuitem's TextHighlightColor.
        If e.Item.Selected = True Or e.Item.Pressed = True Then
            e.ArrowColor = Me.TextHighlightColor
            ' If the menuitem is not highlighted, make the arrow the same
            ' color as the menuitem's forecolor.
        Else
            e.ArrowColor = Me.ForeColor
        End If
        MyBase.OnRenderArrow(e)
    End Sub
End Class
#End Region