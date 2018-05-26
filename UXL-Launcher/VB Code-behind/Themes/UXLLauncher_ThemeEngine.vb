'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2018 Drew Naylor
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
            Debug.WriteLine(ex.Message)
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

        ' Button colors:
        Dim colorButtonBackColor As Color
        Dim colorButtonForeColor As Color
        Dim flatstyleButtonFlatStyle As FlatStyle ' If flatstyleButtonFlatStyle is "= Flat", the flatstyle is Flat. Standard is "FlatStyle = FlatStyle.Standard".
        Dim flatappearanceButtonBorderColor As Color ' The border of the buttons if "FlatStyle = FlatStyle.Flat".
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
        ' Textbox colors:
        Dim colorTextboxBackColor As Color
        Dim colorTextboxForeColor As Color
        ' Menubar entry colors:
        Dim colorMenuItemBackColor As Color
        Dim colorMenuItemForeColor As Color
        ' Statusbar label colors:
        Dim colorStatusLabelBackColor As Color
        Dim colorStatusLabelForeColor As Color
        ' Other statusbar label properties
        Dim propertyStatusLabelBorderSides As ToolStripStatusLabelBorderSides
        Dim propertyStatusLabelBorderStyle As Border3DStyle
#End Region

#Region "Pull theme colors and other elements from XML documents."

#Region "Pull UseThemeEngineVersion element from XML."

        ' Only pull the UseThemeEngineVersion element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager) IsNot Nothing Then
            ' If the version of the theme engine to be used as specified in the theme file is less than 1.01, set it to 1.01.
            If CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText) < 1.01 Then
                themeSheetUseThemeEngineVersion = CDec(1.01)
                debugmodeStuff.outputThemeVersionToUse(themeSheetUseThemeEngineVersion)

                ' If the version of the theme engine to be used as specified in the theme file is greater than or equal to 1.01,
                ' set it to whatever the version is specified in the theme file.
            ElseIf CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText) >= 1.01 Then
                themeSheetUseThemeEngineVersion = CDec(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", themeNamespaceManager).InnerText)
                debugmodeStuff.updateDebugLabels()
                debugmodeStuff.outputThemeVersionToUse(themeSheetUseThemeEngineVersion)
            End If
        Else
            ' If the XML element is missing, manually force the value to be 1.01.
            themeSheetUseThemeEngineVersion = CDec(1.01)
            debugmodeStuff.updateDebugLabels()
            debugmodeStuff.outputThemeVersionToUse(themeSheetUseThemeEngineVersion)
        End If

#End Region

#Region "Pull Title theme element from XML."

        ' Only pull the title element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetTitle = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager).InnerText
            debugmodeStuff.updateDebugLabels()
        Else
            themeSheetTitle = ""
            debugmodeStuff.updateDebugLabels()
        End If
#End Region

#Region "Pull Description theme element from XML."
        ' Only pull the description element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetDescription = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager).InnerText
            debugmodeStuff.updateDebugLabels()
        Else
            themeSheetDescription = ""
            debugmodeStuff.updateDebugLabels()
        End If
#End Region

#Region "Pull Author theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager) IsNot Nothing Then
            themeSheetAuthor = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager).InnerText
            debugmodeStuff.updateDebugLabels()
        Else
            themeSheetAuthor = ""
            debugmodeStuff.updateDebugLabels()
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't valid, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            flatappearanceButtonBorderColor = Nothing
        End If
#End Region

#End Region

#Region "GroupBox BackColor"
        ' Only pull the GroupBox BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorGroupBoxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager).InnerText)
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorFlowLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "StatusBar BackColor."
        ' Only pull the StatusBar BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorStatusBarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager).InnerText)
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorStatusBarBackColor = Color.FromKnownColor(KnownColor.Control)
        End If
#End Region

#Region "Label BackColor"
        ' Only pull the Label BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/BackColor[1]", themeNamespaceManager).InnerText)
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
        End If
#End Region

#Region "TextBox BackColor."
        ' Only pull the TextBox BackColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/BackColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorTextboxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/BackColor[1]", themeNamespaceManager).InnerText)
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                colorMenubarBackColor = colorMenuItemBackColor
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
            End Try
        Else
            ' If the element doesn't exist, overwrite it with the Default theme's value.
            colorMenuItemBackColor = Color.FromKnownColor(KnownColor.Window)
        End If
#End Region

#Region "MenuItem ForeColor."
        ' Only pull the MenuItem ForeColor element from XML if it exists.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ForeColor[1]", themeNamespaceManager) IsNot Nothing Then
            Try
                colorMenuItemForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ForeColor[1]", themeNamespaceManager).InnerText)
                debugmodeStuff.updateDebugLabels()
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't a valid HTML color, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't valid, just ignore it.
            Catch ex As Exception
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
                ' If the element isn't valid, just ignore it.
            Catch ex As Exception
            End Try
        End If
#End Region

#Region "Define Short-words."
        ' Create a short-form word for "Control."
        Dim ctrl As Control
#End Region

#Region "Set colors for controls in groupboxes."
        ' Look at all the buttons in the "Standard Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxStandardApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
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
                button.FlatAppearance.BorderColor = flatappearanceButtonBorderColor
            End If
            ' Look at all the labels in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                ' Set label BackColor (background color).
                label.BackColor = colorLabelBackColor
                ' Set label ForeColor (text color).
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                ' Set textbox BackColor (background color).
                textbox.BackColor = colorTextboxBackColor
                ' Set textbox ForeColor (text color).
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next


        ' Look at all the buttons in the "Professional Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxProApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
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
                button.FlatAppearance.BorderColor = flatappearanceButtonBorderColor
            End If
            ' Look at all the labels in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                ' Set label BackColor (background color).
                label.BackColor = colorLabelBackColor
                ' Set label ForeColor (text color).
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                ' Set textbox BackColor (background color).
                textbox.BackColor = colorTextboxBackColor
                ' Set textbox ForeColor (text color).
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next


        ' Look at all the buttons in the "Extra Apps + Tools" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxExtraApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
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
                button.FlatAppearance.BorderColor = flatappearanceButtonBorderColor
            End If
            ' Look at all the labels in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                ' Set label BackColor (background color).
                label.BackColor = colorLabelBackColor
                ' Set label ForeColor (text color).
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                ' Set textbox BackColor (background color).
                textbox.BackColor = colorTextboxBackColor
                ' Set textbox ForeColor (text color).
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next
#End Region

#Region "Set colors for menubar entries."

        ' Set color for menubar.
        aaformMainWindow.UXLToolstripRenderer.BackColor = colorMenuItemBackColor
        aaformMainWindow.UXLToolstripRenderer.ForeColor = colorMenuItemForeColor
        aaformMainWindow.UXLToolstripRenderer.TextHighlightColor = Color.FromKnownColor(KnownColor.ControlText)

#End Region


#Region "Set colors for statusbar label and groupboxes."

        ' Set colors for the "Standard Apps" groupbox.
        aaformMainWindow.groupboxStandardApps.BackColor = colorGroupBoxBackColor
        aaformMainWindow.groupboxStandardApps.ForeColor = colorGroupBoxForeColor
        ' Set colors for the "Professional Apps" groupbox.
        aaformMainWindow.groupboxProApps.BackColor = colorGroupBoxBackColor
        aaformMainWindow.groupboxProApps.ForeColor = colorGroupBoxForeColor
        ' Set colors for the "Extra Apps + Tools" groupbox.
        aaformMainWindow.groupboxExtraApps.BackColor = colorGroupBoxBackColor
        aaformMainWindow.groupboxExtraApps.ForeColor = colorGroupBoxForeColor
        ' Set color for the Flow Layout Panel.
        aaformMainWindow.flowLayoutPanel.BackColor = colorFlowLayoutPanelBackColor
        aaformMainWindow.flowLayoutPanel.ForeColor = colorFlowLayoutPanelForeColor
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

    End Sub
#End Region
#End Region

#Region "Start the theme engine and apply the user's theme."
    Public Shared Sub themeEngine_ChooseUserTheme()

        ' This documentation page helped a lot for getting this working:
        ' https://msdn.microsoft.com/en-us/library/system.xml.xmldocument.loadxml(v=vs.110).aspx

        Try ' Make sure the theme engine doesn't break.

            ' Then we see if the userChosenTheme setting contains the word "Theme."
            ' If it does not, we just add "Theme_XML" to the end of the string.
            If Not My.Settings.userChosenTheme.Contains("Theme") And Not My.Settings.userChosenTheme = ("(Custom)") Then
                userTheme.LoadXml(My.Resources.ResourceManager.GetString(My.Settings.userChosenTheme & "Theme_XML"))
                ' However, if it does, then we only add "_XML" to the string.
            ElseIf My.Settings.userChosenTheme.Contains("Theme") Then
                userTheme.LoadXml(My.Resources.ResourceManager.GetString(My.Settings.userChosenTheme & "_XML"))
                ' If the user has a custom theme enabled, use that instead.
                ' Make sure the theme path and file exists.
            ElseIf My.Settings.userChosenTheme = "(Custom)" And File.Exists(My.Settings.userCustomThemePath) Then
                userTheme.Load(My.Settings.userCustomThemePath)
                ' Otherwise, just set the theme to use to the Default theme to make sure everything works.
            ElseIf My.Settings.userChosenTheme = "(Custom)" And Not File.Exists(My.Settings.userCustomThemePath) Then
                userTheme.LoadXml(My.Resources.DefaultTheme_XML)
                ' If the theme engine output debug setting is enabled, output an error
                ' in the Immediate Window or debug textbox if the custom theme file cannot be found.
                themeSettingsInvalidMessage("UXLLauncher.ThemeEngine.FileNotFound_CustomTheme", "Couldn't find custom theme file.")
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
            If My.Settings.userChosenTheme = "(Custom)" And File.Exists(My.Settings.userCustomThemePath) Then
                ' Also output the configured custom theme's file path if the user has a custom theme and it exists.
                Debug.WriteLine("")
                Debug.WriteLine("Custom theme path:")
                Debug.WriteLine(My.Settings.userCustomThemePath.ToString)
            End If
            Debug.WriteLine("Theme XML file:")
            Debug.WriteLine(userTheme)
        End If

        ' Apply the theme.
        UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
    End Sub
#End Region
#End Region

#Region "Theme Settings Invalid Message output code."
    Private Shared Sub themeSettingsInvalidMessage(exceptionType As String, Optional exceptionMessage As String = "(None provided)", Optional fullException As String = "(None provided)")
        ' Tell the user, developer, or theme designer that there's a problem with the
        ' chosen theme or custom theme. This can range from not having a root element
        ' in the chosen theme to typing the theme incorrectly in the config file.

        ' This sub accepts parameters for choosing which exceptionType message to show.


        If My.Settings.debugmodeShowThemeEngineOutput = True Then
            ' First, identify this block of text as part of the theme engine
            ' and that it's output for invalid theme settings.

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
                            "the filename below exists in the listed path. Quotation marks in the custom theme" & vbCrLf &
                            "path are not supported.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                Debug.WriteLine("Custom theme path:" & vbCrLf & My.Settings.userCustomThemePath)
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
                Debug.WriteLine("Custom theme path:" & vbCrLf & My.Settings.userCustomThemePath)
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
                Debug.WriteLine("Custom theme path:" & vbCrLf & My.Settings.userCustomThemePath)
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.ComponentModel.InvalidEnumArgumentException" Then
                ' If the theme doesn't have a root element and the exception "XmlException" is triggered,
                ' say that the chosen theme has no root element.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The StatusLabel BorderStyle property could not be found" & vbCrLf &
                            "in the chosen custom theme file listed below," & vbCrLf &
                            "but this shouldn't cause any problems." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & My.Settings.userChosenTheme)
                Debug.WriteLine("Custom theme path:" & vbCrLf & My.Settings.userCustomThemePath)
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

End Class


#Region "The new menubar renderer. It's better than the old method."
' All credit for the original code professional toolstrip renderer
' code below goes to this VBForums post: 
' http://www.vbforums.com/showthread.php?581374-menustrip-amp-toolstrip-color&p=3590240&viewfull=1#post3590240

Public Class uxlProToolstripRenderer
    Inherits ToolStripProfessionalRenderer

    Private _BackColor As Color
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

    ' Get and set the forecolor for the menubar.
    Public Property TextHighlightColor() As Color
        Get
            Return _TextHighlightColor
        End Get
        Set(ByVal value As Color)
            _TextHighlightColor = value
        End Set
    End Property

    ' Get and set the text highlight color for the menubar.
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
        Dim lightColor As Color = ControlPaint.Light(Me.BackColor)
        Using b As New LinearGradientBrush(e.AffectedBounds, lightColor, lightColor, LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(b, e.AffectedBounds)
        End Using
    End Sub

    ' Change the colors for the menubar text.
    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        If e.Item.Selected = True Then
            e.TextColor = _TextHighlightColor
        Else
            e.TextColor = _ForeColor
        End If
        MyBase.OnRenderItemText(e)
    End Sub
End Class
#End Region