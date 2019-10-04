'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2019 Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation. More details in the About window.
'Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor
'and does not endorse this software.
'Any other companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of UXL Launcher
'(Program is also known as "Unified eXecutable Launcher." Not to be confused with
'other software titled "[Kindle] Unified Application Launcher",
'"UX Launcher" [an Android launcher], or "Ulauncher" [a Linux app launcher].)
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



Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Xml

Public Class UXLLauncher_ThemeEngine

    ' This file tells the theme engine what to color things. Theme engine is based on this Stack Overflow question: http://stackoverflow.com/q/199521
#Region "Set Theme via UXL Launcher Theme Engine."

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
    Friend Shared themeSheetUseThemeEngineVersion As Decimal

    Public Shared Sub themeEngine_ApplyTheme()
#Region "Read XML Theme Document."
        ' Parse the test theme XML document and apply stuff that's in it.
        Dim themeSheet As XmlDocument = New XmlDocument()

        ' Load the user's theme. If it's not able to be used, just load the default theme.
        Try
            If userTheme IsNot Nothing Then
                themeSheet = (userTheme)
            Else
                themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
            End If
        Catch ex As XmlException
            themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
            themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString & vbCrLf & "(Also, this code is near the top" &
                                        "of the ApplyTheme code and it doesn't usually get hit.)")
            ' Complain to the user if the chosen theme doesn't have a root element.
            MessageBox.Show("There was a problem trying to load the " &
                            My.Settings.userChosenTheme & " theme." & vbCrLf &
                            "Please notify the theme's author of the message below." & vbCrLf & vbCrLf & vbCrLf &
                            "Theme file chosen:" & vbCrLf & My.Settings.userChosenTheme & vbCrLf & vbCrLf &
                            "Error message: " & vbCrLf & ex.Message & vbCrLf &
                            vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "UXL Launcher Theme Engine",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
        themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

#Region "Define strings for controls and things in the XML document."

        ' About window Banner style (Dark or Light):
        Dim bannerStyle As Image
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
                    debugmodeStuff.outputThemeEngineVersionToUse(themeSheetUseThemeEngineVersion)

                    ' If the version of the theme engine to be used as specified in the theme file is greater than or equal to 1.01,
                    ' set it to whatever the version is specified in the theme file.
                ElseIf CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText) >= 1.01 Then
                    themeSheetUseThemeEngineVersion = CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText)
                    debugmodeStuff.updateDebugLabels()
                    debugmodeStuff.outputThemeEngineVersionToUse(themeSheetUseThemeEngineVersion)
                End If
            Else
                ' If the XML element is missing, manually force the value to be 1.01.
                themeSheetUseThemeEngineVersion = CDec(1.01)
                debugmodeStuff.updateDebugLabels()
                debugmodeStuff.outputThemeEngineVersionToUse(themeSheetUseThemeEngineVersion)
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
            debugmodeStuff.updateDebugLabels()
        Else
            themeSheetTitle = "(No title specified)"
            debugmodeStuff.updateDebugLabels()
        End If
#End Region

#Region "Pull Description theme element from XML."
        ' Only pull the description element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetDescription = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager).InnerText
            debugmodeStuff.updateDebugLabels()
        Else
            themeSheetDescription = "(No description specified)"
            debugmodeStuff.updateDebugLabels()
        End If
#End Region

#Region "Pull Author theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetAuthor = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager).InnerText
            debugmodeStuff.updateDebugLabels()
        Else
            themeSheetAuthor = "(No author specified)"
            debugmodeStuff.updateDebugLabels()
        End If
#End Region

#Region "Pull Version theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetFileVersion = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", themeNamespaceManager).InnerText
            debugmodeStuff.updateDebugLabels()
        Else
            themeSheetFileVersion = "(No version specified)"
            debugmodeStuff.updateDebugLabels()
        End If
#End Region

#Region "About window Banner Style"
        ' Only look at the banner style if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/AboutWindow/BannerStyle[1]", themeNamespaceManager) IsNot Nothing Then
            ' If the theme says to use the "Dark" banner, use it.
            If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/AboutWindow/BannerStyle[1]", themeNamespaceManager).InnerText = "Dark" Then
                bannerStyle = My.Resources.DARK_UXL_Launcher_Banner
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                    debugmodeStuff.updateDebugLabels()
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
                    debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't a valid HTML color, just replace it with the default.
            Catch ex As Exception
                colorCheckBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorCheckboxBackColor = Color.FromKnownColor(KnownColor.Transparent)
        End If
#End Region

#Region "CheckBox ForeColor"
        ' Only pull the CheckBox ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/CheckBox/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorCheckBoxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/CheckBox/ForeColor[1]", themeNamespaceManager).InnerText)
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                    debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
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
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't valid, just replace it with the default.
            Catch ex As Exception
                propertyStatusLabelBorderStyle = Border3DStyle.Flat
            End Try
        End If
#End Region

#Region "Set colors for controls in groupboxes."

        '        ' Set color for the Flow Layout Panel.
        aaformMainWindow.flowLayoutPanel.BackColor = colorFlowLayoutPanelBackColor
        aaformMainWindow.flowLayoutPanel.ForeColor = colorFlowLayoutPanelForeColor

        ' Look at all the controls in the main window FlowLayoutPanel and change their theme.
        For Each groupbox As Control In aaformMainWindow.flowLayoutPanel.Controls
            ' Change colors in groupboxes.
            If (groupbox.GetType() Is GetType(GroupBox)) Then
                ' Change groupbox colors.
                groupbox.BackColor = colorGroupBoxBackColor
                groupbox.ForeColor = colorGroupBoxForeColor

                For Each groupboxControl In groupbox.Controls
                    ' If the control within the groupbox is a Button,
                    ' change the button's theme colors.
                    If (groupboxControl.GetType() Is GetType(Button)) Then
                        Dim button As Button = CType(groupboxControl, Button)
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

                        ' If the control in the groupbox is a label,
                        ' change the label's colors.
                    ElseIf (groupboxControl.GetType() Is GetType(Label)) Then
                        Dim label As Label = CType(groupboxControl, Label)
                        ' Set label BackColor (background color).
                        label.BackColor = colorLabelBackColor
                        ' Set label ForeColor (text color).
                        label.ForeColor = colorLabelForeColor
                        ' Look at all the textboxes in all the groupboxes and change their theme.
                    ElseIf (groupboxControl.GetType() Is GetType(TextBox)) Then
                        Dim textbox As TextBox = CType(groupboxControl, TextBox)
                        ' Set textbox BackColor (background color).
                        textbox.BackColor = colorTextboxBackColor
                        ' Set textbox ForeColor (text color).
                        textbox.ForeColor = colorTextboxForeColor
                    End If
                Next
            End If
            ' Go to next control, known as "groupbox" here.
        Next


#End Region

#Region "Set colors for menubar entries."

        ' Set color for menubar.
        aaformMainWindow.UXLToolstripRenderer.BackColor = colorMenubarBackColor
        aaformMainWindow.UXLToolstripRenderer.ForeColor = colorMenuItemForeColor
        aaformMainWindow.UXLToolstripRenderer.DropdownBackColor = colorMenuItemBackColor
        aaformMainWindow.UXLToolstripRenderer.ImageMarginGradientStartColor = colorMenuItemImageMarginGradientStartColor
        aaformMainWindow.UXLToolstripRenderer.ImageMarginGradientEndColor = colorMenuItemImageMarginGradientEndColor
        aaformMainWindow.UXLToolstripRenderer.TextHighlightColor = Color.FromKnownColor(KnownColor.ControlText)

        ' Sometimes the menubar forecolor doesn't update, so I'm forcing the items to update their colors.
        aaformMainWindow.menubarFileMenu.ForeColor = colorMenuItemForeColor
        aaformMainWindow.menubarViewMenu.ForeColor = colorMenuItemForeColor
        aaformMainWindow.menubarToolsMenu.ForeColor = colorMenuItemForeColor
        aaformMainWindow.menubarHelpMenu.ForeColor = colorMenuItemForeColor

#End Region


#Region "Set colors for statusbar label and menubar."

        ' Set color for status bar.
        aaformMainWindow.statusbarMainWindow.BackColor = colorStatusBarBackColor
        ' Set color for menubar.
        aaformMainWindow.menubarMainWindow.BackColor = colorMenubarBackColor
        ' Set the colors for the status bar label.
        aaformMainWindow.statusbarLabelWelcomeText.BackColor = colorStatusLabelBackColor
        aaformMainWindow.statusbarLabelWelcomeText.ForeColor = colorStatusLabelForeColor
        ' Set other properties for StatusLabel.
        aaformMainWindow.statusbarLabelWelcomeText.BorderSides = propertyStatusLabelBorderSides
        ' I was having some issues with setting the BorderStyle, so Try...Catch.
        Try
            aaformMainWindow.statusbarLabelWelcomeText.BorderStyle = propertyStatusLabelBorderStyle
        Catch ex As System.ComponentModel.InvalidEnumArgumentException
            ' It may be a good idea to output text talking about this exception if people run into it.
            themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
        End Try

#End Region

#Region "Theming for theme files compatible with TE 1.03 or greater."
#Region "About window and Theme file supports TE 1.03"
        If themeSheetUseThemeEngineVersion >= 1.03 Then
            ' BackColor and ForeColor for buttons.
            aaformMainWindow.forceAboutWindowTab.buttonClose.BackColor = colorButtonBackColor
            aaformMainWindow.forceAboutWindowTab.buttonClose.ForeColor = colorButtonForeColor
            ' FlatStyle. BorderColor is in the Try...Catch block.
            aaformMainWindow.forceAboutWindowTab.buttonClose.FlatStyle = flatstyleButtonFlatStyle
            ' Set button flat appearance border color if flatstyleButtonFlatStyle = Flat.
            ' Note that this can be any valid HTML or system color, including "Nothing"
            ' ("Nothing" is the default value based on my testing).
            ' Using "Transparent" causes a System.NotSupportedException
            ' exception, so add a try...catch block and explain in the debug output.
            Try
                aaformMainWindow.forceAboutWindowTab.buttonClose.FlatAppearance.BorderColor = flatappearanceButtonBorderColor
            Catch ex As System.NotSupportedException
                ' Also set bordercolor to "Nothing".
                aaformMainWindow.forceAboutWindowTab.buttonClose.FlatAppearance.BorderColor = Nothing
                ' Show an error about the NotSupportedException.
                themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
            End Try

            ' Now change the color for when the mouse clicks down
            ' on a button and the flat appearance is set to flat.
            aaformMainWindow.forceAboutWindowTab.buttonClose.FlatAppearance.MouseDownBackColor = flatappearanceButtonMouseDownBackColor

            ' Change the color for when the mouse goes over
            ' a button and the flat appearance is set to flat.
            aaformMainWindow.forceAboutWindowTab.buttonClose.FlatAppearance.MouseOverBackColor = flatappearanceButtonMouseOverBackColor

            ' BackColor for FlowLayoutPanels.
            aaformMainWindow.forceAboutWindowTab.flowLayoutPanelLinkLabels.BackColor = colorFlowLayoutPanelBackColor
            ' And FlowLayoutPanel ForeColors.
            aaformMainWindow.forceAboutWindowTab.flowLayoutPanelLinkLabels.ForeColor = colorFlowLayoutPanelForeColor

            ' Textbox fore/backcolors.
            aaformMainWindow.forceAboutWindowTab.textboxAboutApp.BackColor = colorTextboxBackColor
            aaformMainWindow.forceAboutWindowTab.textboxAboutApp.ForeColor = colorTextboxForeColor

            ' TableLayoutPanel fore/backcolors.
            ' Note: DO NOT apply the colors to the tableLayoutPanelAboutApp control as this one uses the TabControl color.
            ' Only apply the colors to the tableLayoutPanel control.
            aaformMainWindow.forceAboutWindowTab.tableLayoutPanel.ForeColor = colorTableLayoutPanelForeColor
            aaformMainWindow.forceAboutWindowTab.tableLayoutPanel.BackColor = colorTableLayoutPanelBackColor
            If useTableLayoutPanelColorInsideAboutAppTab = True Then
                aaformMainWindow.forceAboutWindowTab.tableLayoutPanelAboutAppTab.ForeColor = colorTableLayoutPanelForeColor
                aaformMainWindow.forceAboutWindowTab.tableLayoutPanelAboutAppTab.BackColor = colorTableLayoutPanelBackColor
            Else
                aaformMainWindow.forceAboutWindowTab.tableLayoutPanelAboutAppTab.ForeColor = colorTabPageForeColor
                aaformMainWindow.forceAboutWindowTab.tableLayoutPanelAboutAppTab.BackColor = colorTabPageBackColor
            End If

            ' TabPage fore/backcolors.
            ' Can be done at once like the control loop for the main window above.
            For Each tab As TabPage In aaformMainWindow.forceAboutWindowTab.tabcontrolAboutWindow.Controls
                ' If the control is a TabPage, theme it appropriately.
                tab.BackColor = colorTabPageBackColor
                tab.ForeColor = colorTabPageForeColor
            Next ' Go to the next TabPage.

            ' About tab banner style (dark or light).
            aaformMainWindow.forceAboutWindowTab.pictureboxUXLBanner.Image = bannerStyle

            ' LinkLabel colors.
            ' Can be done at once like the control loop for the main window above.
            For Each link As LinkLabel In aaformMainWindow.forceAboutWindowTab.flowLayoutPanelLinkLabels.Controls
                ' If the control is a LinkLabel, theme it appropriately.
                link.BackColor = colorLinkLabelBackColor
                link.ForeColor = colorLinkLabelForeColor
                link.LinkColor = colorLinkLabelLinkColor
                link.ActiveLinkColor = colorLinkLabelActiveLinkColor
            Next ' Go to the next LinkLabel.
#End Region

#Region "Options window theming for theme files supporting 1.03"
            ' Theme the Options window's table layout panel.
            aaformMainWindow.forceOptionsWindowTab.tableLayoutPanelOptionsWindow.BackColor = colorTableLayoutPanelBackColor
            aaformMainWindow.forceOptionsWindowTab.tableLayoutPanelOptionsWindow.ForeColor = colorTableLayoutPanelForeColor

            ' Theme the buttons at the bottom of the Options window.
            For Each tablelayoutpanelControl As Control In aaformMainWindow.forceOptionsWindowTab.tableLayoutPanelOptionsWindow.Controls
                If (tablelayoutpanelControl.GetType() Is GetType(Button)) Then
                    Dim reallyIsButtonControl As Button = CType(tablelayoutpanelControl, Button)
                    ' Button backcolors and forecolors.
                    reallyIsButtonControl.BackColor = colorButtonBackColor
                    reallyIsButtonControl.ForeColor = colorButtonForeColor
                    ' FlatStyle. BorderColor is in the Try...Catch block.
                    ' This requires casting a control as a button.
                    reallyIsButtonControl.FlatStyle = flatstyleButtonFlatStyle

                    ' Set button flat appearance border color if flatstyleButtonFlatStyle = Flat.
                    ' Note that this can be any valid HTML or system color, including "Nothing"
                    ' ("Nothing" is the default value based on my testing).
                    ' Using "Transparent" causes a System.NotSupportedException
                    ' exception, so add a try...catch block and explain in the debug output.
                    Try
                        reallyIsButtonControl.FlatAppearance.BorderColor = flatappearanceButtonBorderColor

                    Catch ex As System.NotSupportedException
                        ' Also set bordercolor to "Nothing".
                        reallyIsButtonControl.FlatAppearance.BorderColor = Nothing

                        ' Show an error about the NotSupportedException.
                        themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
                    End Try

                    ' Now change the color for when the mouse clicks down
                    ' on a button and the flat appearance is set to flat.
                    reallyIsButtonControl.FlatAppearance.MouseDownBackColor = flatappearanceButtonMouseDownBackColor

                    ' Change the color for when the mouse goes over
                    ' a button and the flat appearance is set to flat.
                    reallyIsButtonControl.FlatAppearance.MouseOverBackColor = flatappearanceButtonMouseOverBackColor

                End If
                ' Start working our way into the Options window, layer by layer.
                ' First, theme the tab pages.
                For Each tabControl As Control In tablelayoutpanelControl.Controls
                    If (tabControl.GetType() Is GetType(TabPage)) Then
                        tabControl.BackColor = colorTabPageBackColor
                        tabControl.ForeColor = colorTabPageForeColor
                    End If
                    ' Next, theme the groupboxes.
                    For Each tabpageControl As Control In tabControl.Controls
                        If (tabpageControl.GetType() Is GetType(GroupBox)) Then
                            tabpageControl.BackColor = colorGroupBoxBackColor
                            tabpageControl.ForeColor = colorGroupBoxForeColor
                        End If

                        ' Next, theme inside the groupboxes.
                        For Each groupboxControl As Control In tabpageControl.Controls
                            ' Theme the buttons. Button FlatStyle needs casting, though.
                            If (groupboxControl.GetType() Is GetType(Button)) Then
                                Dim reallyIsButtonControl As Button = CType(groupboxControl, Button)
                                reallyIsButtonControl.BackColor = colorButtonBackColor
                                reallyIsButtonControl.ForeColor = colorButtonForeColor
                                reallyIsButtonControl.FlatStyle = flatstyleButtonFlatStyle

                                ' Set button flat appearance border color if flatstyleButtonFlatStyle = Flat.
                                ' Note that this can be any valid HTML or system color, including "Nothing"
                                ' ("Nothing" is the default value based on my testing).
                                ' Using "Transparent" causes a System.NotSupportedException
                                ' exception, so add a try...catch block and explain in the debug output.
                                Try
                                    reallyIsButtonControl.FlatAppearance.BorderColor = flatappearanceButtonBorderColor

                                Catch ex As System.NotSupportedException
                                    ' Also set bordercolor to "Nothing".
                                    reallyIsButtonControl.FlatAppearance.BorderColor = Nothing

                                    ' Show an error about the NotSupportedException.
                                    themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
                                End Try


                                ' Now change the color for when the mouse clicks down
                                ' on a button and the flat appearance is set to flat.
                                reallyIsButtonControl.FlatAppearance.MouseDownBackColor = flatappearanceButtonMouseDownBackColor

                                ' Change the color for when the mouse goes over
                                ' a button and the flat appearance is set to flat.
                                reallyIsButtonControl.FlatAppearance.MouseOverBackColor = flatappearanceButtonMouseOverBackColor


                                ' Theme the labels.
                            ElseIf (groupboxControl.GetType() Is GetType(Label)) Then
                                groupboxControl.BackColor = colorLabelBackColor
                                groupboxControl.ForeColor = colorLabelForeColor

                                ' Theme the textboxes.
                            ElseIf (groupboxControl.GetType() Is GetType(TextBox)) Then
                                groupboxControl.BackColor = colorTextboxBackColor
                                groupboxControl.ForeColor = colorTextboxForeColor

                                ' Theme the radio buttons.
                            ElseIf (groupboxControl.GetType() Is GetType(RadioButton)) Then
                                groupboxControl.BackColor = colorRadioButtonBackColor
                                groupboxControl.ForeColor = colorRadioButtonForeColor

                                ' Theme the checkboxes.
                            ElseIf (groupboxControl.GetType() Is GetType(CheckBox)) Then
                                groupboxControl.BackColor = colorCheckBoxBackColor
                                groupboxControl.ForeColor = colorCheckBoxForeColor

                                ' Theme the dropdown boxes.
                            ElseIf (groupboxControl.GetType() Is GetType(ComboBox)) Then

                                Try ' Try to apply the dropdown backcolor.
                                    groupboxControl.BackColor = colorDropdownBackColor
                                Catch ex As ArgumentException
                                    ' Now, make sure the background isn't transparent.
                                    ' Dropdown boxes/comboboxes don't support transparent backgrounds.
                                    groupboxControl.BackColor = Color.FromKnownColor(KnownColor.Window)
                                End Try
                                ' Now do the forecolor.
                                groupboxControl.ForeColor = colorDropdownForeColor
                            End If

                        Next ' Next control inside groupboxes.
                    Next ' Next groupbox.
                Next ' Next tabpage.
            Next ' Next button at the bottom of the Options window.
#End Region

#Region "About window and theme doesn't support TE 1.03"
        Else
            ' If the theme doesn't support TE 1.03, set all control stuff to defaults.
            ' BackColor and ForeColor for buttons.
            aaformMainWindow.forceAboutWindowTab.buttonClose.BackColor = Color.Transparent
            aaformMainWindow.forceAboutWindowTab.buttonClose.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            ' FlatStyle.
            aaformMainWindow.forceAboutWindowTab.buttonClose.FlatStyle = FlatStyle.Standard
            ' Also set Button FlatStyle bordercolor to "Nothing".
            aaformMainWindow.forceAboutWindowTab.buttonClose.FlatAppearance.BorderColor = Nothing


            ' BackColor for FlowLayoutPanels.
            aaformMainWindow.forceAboutWindowTab.flowLayoutPanelLinkLabels.BackColor = Color.FromKnownColor(KnownColor.Window)
            ' And FlowLayoutPanel ForeColors.
            aaformMainWindow.forceAboutWindowTab.flowLayoutPanelLinkLabels.ForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Textbox fore/backcolors.
            aaformMainWindow.forceAboutWindowTab.textboxAboutApp.BackColor = Color.FromKnownColor(KnownColor.Window)
            aaformMainWindow.forceAboutWindowTab.textboxAboutApp.ForeColor = Color.FromKnownColor(KnownColor.WindowText)

            ' TableLayoutPanel fore/backcolors.
            ' Note: DO NOT apply the colors to the tableLayoutPanelAboutApp control as this one uses the TabControl color.
            ' Only apply the colors to the tableLayoutPanel control.
            aaformMainWindow.forceAboutWindowTab.tableLayoutPanel.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            aaformMainWindow.forceAboutWindowTab.tableLayoutPanel.BackColor = Color.FromKnownColor(KnownColor.Control)
            aaformMainWindow.forceAboutWindowTab.tableLayoutPanelAboutAppTab.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            aaformMainWindow.forceAboutWindowTab.tableLayoutPanelAboutAppTab.BackColor = Color.FromKnownColor(KnownColor.Window)

            ' TabPage fore/backcolors.
            ' Can be done at once like the control loop for the main window above.
            For Each tab As TabPage In aaformMainWindow.forceAboutWindowTab.tabcontrolAboutWindow.Controls
                ' If the control is a TabPage, theme it appropriately.
                tab.BackColor = Color.FromKnownColor(KnownColor.Window)
                tab.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
            Next ' Go to the next TabPage.

            ' About tab banner style (dark or light).
            aaformMainWindow.forceAboutWindowTab.pictureboxUXLBanner.Image = My.Resources.UXL_Launcher_Banner

            ' LinkLabel colors.
            ' Can be done at once like the control loop for the main window above.
            For Each link As LinkLabel In aaformMainWindow.forceAboutWindowTab.flowLayoutPanelLinkLabels.Controls
                ' If the control is a LinkLabel, theme it appropriately.
                link.BackColor = Color.FromKnownColor(KnownColor.Transparent)
                link.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                link.LinkColor = Color.FromArgb(0, 0, 255)
                link.ActiveLinkColor = Color.FromKnownColor(KnownColor.Red)
            Next ' Go to the next LinkLabel.
#End Region

#Region "Options window and theme doesn't support TE 1.03"
            ' Theme the Options window's table layout panel.
            aaformMainWindow.forceOptionsWindowTab.tableLayoutPanelOptionsWindow.BackColor = Color.FromKnownColor(KnownColor.Control)
            aaformMainWindow.forceOptionsWindowTab.tableLayoutPanelOptionsWindow.ForeColor = Color.FromKnownColor(KnownColor.ControlText)

            ' Theme the buttons at the bottom of the Options window.
            For Each tablelayoutpanelControl As Control In aaformMainWindow.forceOptionsWindowTab.tableLayoutPanelOptionsWindow.Controls
                If (tablelayoutpanelControl.GetType() Is GetType(Button)) Then
                    Dim reallyIsButtonControl As Button = CType(tablelayoutpanelControl, Button)
                    ' Button backcolors and forecolors.
                    reallyIsButtonControl.BackColor = Color.Transparent
                    reallyIsButtonControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                    ' FlatStyle. BorderColor is in the Try...Catch block.
                    ' This requires casting a control as a button.
                    reallyIsButtonControl.FlatStyle = FlatStyle.Standard

                    ' Set button flat appearance border color to "Nothing".

                    reallyIsButtonControl.FlatAppearance.BorderColor = Nothing

                End If
                ' Start working our way into the Options window, layer by layer.
                ' First, theme the tab pages.
                For Each tabControl As Control In tablelayoutpanelControl.Controls
                    If (tabControl.GetType() Is GetType(TabPage)) Then
                        tabControl.BackColor = Color.FromKnownColor(KnownColor.Window)
                        tabControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                    End If
                    ' Next, theme the groupboxes.
                    For Each tabpageControl As Control In tabControl.Controls
                        If (tabpageControl.GetType() Is GetType(GroupBox)) Then
                            tabpageControl.BackColor = Color.FromKnownColor(KnownColor.Transparent)
                            tabpageControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                        End If

                        ' Next, theme inside the groupboxes.
                        For Each groupboxControl As Control In tabpageControl.Controls
                            ' Theme the buttons. Button FlatStyle needs casting, though.
                            If (groupboxControl.GetType() Is GetType(Button)) Then

                                Dim reallyIsButtonControl As Button = CType(groupboxControl, Button)
                                reallyIsButtonControl.BackColor = Color.Transparent
                                reallyIsButtonControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                                reallyIsButtonControl.FlatStyle = FlatStyle.Standard

                                ' Set button flat appearance border color to "Nothing".
                                reallyIsButtonControl.FlatAppearance.BorderColor = Nothing


                                ' Theme the labels.
                            ElseIf (groupboxControl.GetType() Is GetType(Label)) Then
                                groupboxControl.BackColor = Color.FromKnownColor(KnownColor.Transparent)
                                groupboxControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)

                                ' Theme the textboxes.
                            ElseIf (groupboxControl.GetType() Is GetType(TextBox)) Then
                                groupboxControl.BackColor = Color.FromKnownColor(KnownColor.Window)
                                groupboxControl.ForeColor = Color.FromKnownColor(KnownColor.WindowText)

                                ' Theme the radio buttons.
                            ElseIf (groupboxControl.GetType() Is GetType(RadioButton)) Then
                                groupboxControl.BackColor = Color.FromKnownColor(KnownColor.Transparent)
                                groupboxControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)

                                ' Theme the checkboxes.
                            ElseIf (groupboxControl.GetType() Is GetType(CheckBox)) Then
                                groupboxControl.BackColor = Color.FromKnownColor(KnownColor.Transparent)
                                groupboxControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)

                                ' Theme the dropdown boxes.
                            ElseIf (groupboxControl.GetType() Is GetType(ComboBox)) Then

                                'Reset the dropdown backcolor.
                                groupboxControl.BackColor = Color.FromKnownColor(KnownColor.Window)

                                ' Now do the forecolor.
                                groupboxControl.ForeColor = Color.FromKnownColor(KnownColor.ControlText)
                            End If
                        Next ' Next control inside groupboxes.
                    Next ' Next groupbox.
                Next ' Next tabpage.
            Next ' Next button at the bottom of the Options window.
#End Region


        End If
#End Region

    End Sub
#End Region
#End Region

#Region "Start the theme engine and apply the user's theme."
    Public Shared Sub themeEngine_ChooseUserTheme()

        ' This documentation page helped a lot for getting this working:
        ' https://msdn.microsoft.com/en-us/library/system.xml.xmldocument.loadxml(v=vs.110).aspx

        ' First, remove the double-quotes from the custom theme path.
        ' This was moved up here so that it can be refered to in other
        ' parts of this sub.
        Dim tempRemoveQuotesInCustomThemePath As String = My.Settings.userCustomThemePath.Replace("""", "")

        Try ' Make sure the theme engine doesn't break.

            ' If the user wants to have the theme match the Windows 10 theme settings,
            ' then do that.
            If 

            ' Then we see if the userChosenTheme setting contains the word "Theme."
                ' If it does not, we just add "Theme_XML" to the end of the string.
                If Not My.Settings.userChosenTheme.Contains("Theme") And Not My.Settings.userChosenTheme = ("(Custom)") Then
                userTheme.LoadXml(My.Resources.ResourceManager.GetString(My.Settings.userChosenTheme & "Theme_XML"))
                ' However, if it does, then we only add "_XML" to the string.
            ElseIf My.Settings.userChosenTheme.Contains("Theme") Then
                userTheme.LoadXml(My.Resources.ResourceManager.GetString(My.Settings.userChosenTheme & "_XML"))
                ' If the user has a custom theme enabled, use that instead.
            ElseIf My.Settings.userChosenTheme = "(Custom)" Then
                ' Make sure the theme path and file exists and custom themes are allowed
                ' to be used.
                If File.Exists(tempRemoveQuotesInCustomThemePath) And My.Settings.allowCustomThemes = True Then
                    userTheme.Load(tempRemoveQuotesInCustomThemePath)
                    ' Otherwise, just set the theme to use to the Default theme to make sure everything works.
                    ' Then we output that the custom theme file wasn't found if that's the problem, or if custom
                    ' themes are not allowed to be used.
                ElseIf Not File.Exists(tempRemoveQuotesInCustomThemePath) Then
                    userTheme.LoadXml(My.Resources.DefaultTheme_XML)
                    ' If the theme engine output debug setting is enabled, output an error
                    ' in the Immediate Window or debug textbox if the custom theme file cannot be found.
                    themeSettingsInvalidMessage("UXLLauncher.ThemeEngine.FileNotFound_CustomTheme", "Couldn't find custom theme file.")
                ElseIf My.Settings.allowCustomThemes = False Then
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
        If My.Settings.debugmodeShowThemeEngineOutput = True Then
            Debug.WriteLine("")
            Debug.WriteLine("")
            Debug.WriteLine("")
            Debug.WriteLine("Theme name in config file:")
            Debug.WriteLine(My.Settings.userChosenTheme)
            Debug.WriteLine("")
            If My.Settings.userChosenTheme = "(Custom)" And File.Exists(tempRemoveQuotesInCustomThemePath) Then
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
            If My.Settings.userChosenTheme = "(Custom)" Then
                Debug.WriteLine(getThemeFileInfo(userTheme, True, tempRemoveQuotesInCustomThemePath))
            Else
                ' Otherwise, just write it out.
                Debug.WriteLine(getThemeFileInfo(userTheme))
            End If


        End If

        ' Apply the theme.
        UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
    End Sub
#End Region
#End Region

#Region "Theme Settings Invalid Message output code."
    Private Shared Sub themeSettingsInvalidMessage(exceptionType As String, Optional exceptionMessage As String = "(Not provided)", Optional fullException As String = "(Not provided)")
        ' Tell the user, developer, or theme designer that there's a problem with the
        ' chosen theme or custom theme. This can range from not having a root element
        ' in the chosen theme to typing the theme incorrectly in the config file.

        ' This sub accepts parameters for choosing which exceptionType message to show.


        If My.Settings.debugmodeShowThemeEngineOutput = True Then
            ' First, identify this block of text as part of the theme engine
            ' and that it's output for invalid theme settings.

            ' Second, remove the double-quotes from the custom theme path.
            ' This was copied here so that it can be refered to in other
            ' parts of this sub.
            Dim tempRemoveQuotesInCustomThemePath As String = My.Settings.userCustomThemePath.Replace("""", "")

            Debug.WriteLine("")
            Debug.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////")
            Debug.WriteLine("UXL Launcher Theme Engine Version " & My.Resources.themeEngineVersion)
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
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If My.Settings.userChosenTheme = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "UXLLauncher.ThemeEngine.CustomThemesNotAllowed" Then
                ' If custom themes are not supported, output it to the Immediate Window.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("Your administrator has disabled custom themes from being used in UXL Launcher." & vbCrLf &
                                "This may be due to data protection policies put in place by your organization." & vbCrLf &
                                vbCrLf &
                                "If you believe you've received this message in error, you can try to modify the" & vbCrLf &
                                "configuration files for UXL Launcher located in this folder:" & vbCrLf &
                                My.Application.Info.DirectoryPath & vbCrLf &
                                "In this folder, you'll find a file named ""UXL-Launcher.exe.config"". First," & vbCrLf &
                                "make a backup copy of this file. Next, open this file in your favorite text editor such as Notepad++." & vbCrLf &
                                "You should find an XML element that has a name of ""allowCustomThemes"" within the ""userSettings"" element." & vbCrLf &
                                "Below that setting XML element, you'll want to change the ""value"" from ""False"" to ""True""." & vbCrLf &
                                "Afterward, restart UXL Launcher.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If My.Settings.userChosenTheme = "(Custom)" Then
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
                            "theme name specified for My.Settings.userChosenTheme doesn't" & vbCrLf &
                            "match any theme files in My.Resources." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If My.Settings.userChosenTheme = "(Custom)" Then
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
                            "chosen theme that My.Settings.userChosenTheme is set to or the" & vbCrLf &
                            "custom theme specified in My.Settings.userCustomThemePath" & vbCrLf &
                            "doesn't have a root element or otherwise has malformed XML." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If My.Settings.userChosenTheme = "(Custom)" Then
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
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If My.Settings.userChosenTheme = "(Custom)" Then
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
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If My.Settings.userChosenTheme = "(Custom)" Then
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
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If My.Settings.userChosenTheme = "(Custom)" Then
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

#Region "Get theme file info."
    ' This code is based on this issue in the
    ' GitHub repository:
    ' https://github.com/DrewNaylor/UXL-Launcher/issues/113

    Public Shared Function getThemeFileInfo(themeFile As XmlDocument, Optional isCustomTheme As Boolean = False, Optional themeFileLocation As String = "") As String
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
            If File.Exists(themeFileLocation) And My.Settings.allowCustomThemes = True Then
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
            ElseIf Not File.Exists(themeFileLocation) And My.Settings.allowCustomThemes = True Then
                ' If the file doesn't exist but custom themes are allowed,
                ' say that the Default theme will be used temporarily.
                themeDetailsComplete = "We couldn't find the custom theme file previously located below, so the Default theme will be used temporarily." & vbCrLf &
                                        themeFileLocation
                Return themeDetailsComplete
            ElseIf My.Settings.allowCustomThemes = False Then
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