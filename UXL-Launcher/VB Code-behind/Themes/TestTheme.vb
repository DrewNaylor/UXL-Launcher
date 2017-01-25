'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2017  Drew Naylor
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


Imports System.Xml

Public Class UXLTheme_TestTheme

    ' This file tells the theme engine what to color things. Theme engine is based on this Stack Overflow question: http://stackoverflow.com/q/199521
#Region "Set Test Theme."
    Public Shared Sub applyTheme_TestTheme()

#Region "Read XML Theme Document."
        ' Parse the test theme XML document and apply stuff that's in it.
        Dim themeSheet As XmlDocument = New XmlDocument()
        themeSheet.LoadXml(My.Resources.TestTheme_XML)

        Dim themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
        themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

        ' Create strings for theme title and description.
        Dim themeSheetTitle As String
        Dim themeSheetDescription As String

        ' Button colors:
        Dim colorButtonBackColor As Color
        Dim colorButtonForeColor As Color
        ' Groupbox colors:
        Dim colorGroupBoxBackColor As Color
        Dim colorGroupBoxForeColor As Color
        ' FlowLayoutPanel colors:
        Dim colorFlowLayoutPanelBackColor As Color
        Dim colorFlowLayoutPanelForeColor As Color
        ' Menubar and status bar colors:
        Dim colorMenubarAndStatusBarBackColor As Color
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


        ' Pull the title from XML.
        themeSheetTitle = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager).InnerText
        aaformMainWindow.debugLabelXmlThemeTitle.Text = themeSheetTitle

        ' Pull the description from XML.
        themeSheetDescription = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager).InnerText
        aaformMainWindow.debugLabelXmlThemeDescription.Text = themeSheetDescription

        ' Pull the Button colors from XML.
        colorButtonBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/BackColor[1]", themeNamespaceManager).InnerText)
        colorButtonForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the GroupBox colors from XML.
        colorGroupBoxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager).InnerText)
        colorGroupBoxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the FlowLayoutPanel colors from XML.
        colorFlowLayoutPanelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/BackColor[1]", themeNamespaceManager).InnerText)
        colorFlowLayoutPanelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the MenuBarAndStatusBar colors from XML.
        colorMenubarAndStatusBarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuBarAndStatusBar/BackColor[1]", themeNamespaceManager).InnerText)

        ' Pull the Label colors from XML.
        colorLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/BackColor[1]", themeNamespaceManager).InnerText)
        colorLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the TextBox colors from XML.
        colorTextboxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/BackColor[1]", themeNamespaceManager).InnerText)
        colorTextboxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the MenuItem colors from XML.
        colorMenuItemBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/BackColor[1]", themeNamespaceManager).InnerText)
        colorMenuItemForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the groupbox colors from XML.
        colorGroupBoxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager).InnerText)
        colorGroupBoxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/ForeColor[1]", themeNamespaceManager).InnerText)



#End Region

#Region "Define Colors and Short-words."
        ' Create a short-form word for "Control."
        Dim ctrl As Control
        ' Colors as defined for this theme.
        ' Button colors:
        'Dim colorButtonBackColor As Color = Color.Maroon
        'Dim colorButtonForeColor As Color = Color.White
#End Region

#Region "Set colors for controls in groupboxes."
        ' Look at all the buttons in the "Standard Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxStandardApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next


        ' Look at all the buttons in the "Professional Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxProApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next


        ' Look at all the buttons in the "Extra Apps + Tools" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxExtraApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next
#End Region

#Region "Set colors for menubar entries."
        ' Look at all the menubar entries in the main menubar and change their theme.
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarFileMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarViewMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarToolsMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarHelpMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
#End Region

#Region "Set colors for statusbar label and groupboxes."
        ' Set the colors for the status bar label.
        aaformMainWindow.statusbarLabelWelcomeText.BackColor = colorStatusLabelBackColor
        aaformMainWindow.statusbarLabelWelcomeText.ForeColor = colorStatusLabelForeColor


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
        'Set color for menubar and status bar.
        aaformMainWindow.menubarMainWindow.BackColor = colorMenubarAndStatusBarBackColor
        aaformMainWindow.statusbarMainWindow.BackColor = colorMenubarAndStatusBarBackColor
#End Region

    End Sub
#End Region

#Region "Set Default Theme."
    'Apply Default Theme
    Public Shared Sub applyTheme_DefaultTheme()

#Region "Define Colors and Short-words."
        ' Create a short-form word for "Control."
        Dim ctrl As Control

        ' Colors as defined for this theme.
        ' Button colors:
        Dim colorButtonBackColor As Color = Color.FromKnownColor(KnownColor.Transparent)
        Dim colorButtonForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)
        ' Groupbox colors:
        Dim colorGroupBoxBackColor As Color = Color.FromKnownColor(KnownColor.Transparent)
        Dim colorGroupBoxForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)
        ' FlowLayoutPanel colors:
        Dim colorFlowLayoutPanelBackColor As Color = Color.FromKnownColor(KnownColor.Window)
        Dim colorFlowLayoutPanelForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)
        ' Menubar and status bar colors:
        Dim colorMenubarAndStatusBarBackColor As Color = Color.FromKnownColor(KnownColor.Control)
        ' Label colors:
        Dim colorLabelBackColor As Color = Color.FromKnownColor(KnownColor.Transparent)
        Dim colorLabelForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)
        ' Textbox colors:
        Dim colorTextboxBackColor As Color = Color.FromKnownColor(KnownColor.Window)
        Dim colorTextboxForeColor As Color = Color.FromKnownColor(KnownColor.WindowText)
        ' Menubar entry colors:
        Dim colorMenuItemBackColor As Color = Color.FromKnownColor(KnownColor.Control)
        Dim colorMenuItemForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)
        ' Statusbar label colors:
        Dim colorStatusLabelBackColor As Color = Color.FromKnownColor(KnownColor.Transparent)
        Dim colorStatusLabelForeColor As Color = Color.FromKnownColor(KnownColor.ControlText)
#End Region

#Region "Set colors for controls in groupboxes."
        ' Look at all the buttons in the "Standard Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxStandardApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next

        ' Look at all the buttons in the "Professional Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxProApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next

        ' Look at all the buttons in the "Extra Apps + Tools" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxExtraApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next
#End Region

#Region "Set colors for menubar entries."
        ' Look at all the menubar entries in the main menubar and change their theme.
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarFileMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarViewMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarToolsMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarHelpMenu.DropDownItems
            tsMenuItem.BackColor = colorMenuItemBackColor
            tsMenuItem.ForeColor = colorMenuItemForeColor
        Next
#End Region

#Region "Set colors for statusbar label and groupboxes."
        ' Set the colors for the status bar label.
        aaformMainWindow.statusbarLabelWelcomeText.BackColor = colorStatusLabelBackColor
        aaformMainWindow.statusbarLabelWelcomeText.ForeColor = colorStatusLabelForeColor



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
        'Set color for menubar and status bar.
        aaformMainWindow.menubarMainWindow.BackColor = colorMenubarAndStatusBarBackColor
        aaformMainWindow.statusbarMainWindow.BackColor = colorMenubarAndStatusBarBackColor
#End Region

    End Sub
#End Region
End Class