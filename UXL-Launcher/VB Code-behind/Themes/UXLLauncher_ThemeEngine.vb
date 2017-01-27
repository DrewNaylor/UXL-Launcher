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


Imports System.Drawing.Drawing2D
Imports System.Xml

Public Class UXLLauncher_ThemeEngine

    ' This file tells the theme engine what to color things. Theme engine is based on this Stack Overflow question: http://stackoverflow.com/q/199521
#Region "Set Theme via UXL Launcher Theme Engine."

    ' Make a variable that differs based on what theme is chosen.
    Public Shared userTheme As String
    ' Create strings for theme title, description, and author.
    Public Shared themeSheetTitle As String
    Public Shared themeSheetDescription As String
    Public Shared themeSheetAuthor As String

    Public Shared Sub themeEngine_ApplyTheme()

#Region "Read XML Theme Document."
        ' Parse the test theme XML document and apply stuff that's in it.
        Dim themeSheet As XmlDocument = New XmlDocument()
        themeSheet.LoadXml(userTheme)

        Dim themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
        themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

#Region "Define strings for controls and things in the XML document."

        ' Button colors:
        Dim colorButtonBackColor As Color
        Dim colorButtonForeColor As Color
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

#Region "Pull theme colors from XML documents."
        ' Pull the title from XML.
        themeSheetTitle = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager).InnerText
        aaformMainWindow.debugLabelXmlThemeTitle.Text = themeSheetTitle

        ' Pull the description from XML.
        themeSheetDescription = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager).InnerText
        aaformMainWindow.debugLabelXmlThemeDescription.Text = themeSheetDescription

        ' Pull the author from XML.
        themeSheetAuthor = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager).InnerText
        aaformMainWindow.debugLabelXmlThemeAuthor.Text = themeSheetAuthor


        ' Pull the Button colors from XML.
        colorButtonBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/BackColor[1]", themeNamespaceManager).InnerText)
        colorButtonForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the GroupBox colors from XML.
        colorGroupBoxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager).InnerText)
        colorGroupBoxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the FlowLayoutPanel colors from XML.
        colorFlowLayoutPanelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/BackColor[1]", themeNamespaceManager).InnerText)
        colorFlowLayoutPanelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the MenuBar colors from XML.
        colorMenubarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuBar/BackColor[1]", themeNamespaceManager).InnerText)

        ' Pull the StatusBar colors from XML.
        colorStatusBarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager).InnerText)


        ' Pull the Label colors from XML.
        colorLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/BackColor[1]", themeNamespaceManager).InnerText)
        colorLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the TextBox colors from XML.
        colorTextboxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/BackColor[1]", themeNamespaceManager).InnerText)
        colorTextboxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the MenuItem colors from XML.
        colorMenuItemBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/BackColor[1]", themeNamespaceManager).InnerText)
        colorMenuItemForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull the StatusLabel colors from XML.
        colorStatusLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BackColor[1]", themeNamespaceManager).InnerText)
        colorStatusLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/ForeColor[1]", themeNamespaceManager).InnerText)

        ' Pull other StatusLabel stuff from XML.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderSides[1]", themeNamespaceManager).InnerText = "All" Then
            propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.All
        Else
            propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.None
        End If
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderStyle[1]", themeNamespaceManager).InnerText = "SunkenInner" Then
            propertyStatusLabelBorderStyle = Border3DStyle.SunkenInner
        Else
            propertyStatusLabelBorderStyle = Border3DStyle.Flat
        End If


#End Region

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
        '        ' Look at all the menubar entries in the main menubar and change their theme.
        '        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarMainWindow.Items
        '            tsMenuItem.BackColor = colorMenuItemBackColor
        '            tsMenuItem.ForeColor = colorMenuItemForeColor
        '        Next
        '        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarViewMenu.DropDownItems
        '            tsMenuItem.BackColor = colorMenuItemBackColor
        '            tsMenuItem.ForeColor = colorMenuItemForeColor
        '        Next
        '        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarToolsMenu.DropDownItems
        '            tsMenuItem.BackColor = colorMenuItemBackColor
        '            tsMenuItem.ForeColor = colorMenuItemForeColor
        '        Next
        '        For Each tsMenuItem As ToolStripItem In aaformMainWindow.menubarHelpMenu.DropDownItems
        '            tsMenuItem.BackColor = colorMenuItemBackColor
        '            tsMenuItem.ForeColor = colorMenuItemForeColor
        '        Next
#End Region

        ' Set color for menubar.
        aaformMainWindow.UXLToolstripRenderer.BackColor = colorMenuItemBackColor

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
        ' Set color for menubar and status bar.
        aaformMainWindow.menubarMainWindow.BackColor = colorMenubarBackColor
        aaformMainWindow.statusbarMainWindow.BackColor = colorStatusBarBackColor
        ' Set the colors for the status bar label.
        aaformMainWindow.statusbarLabelWelcomeText.BackColor = colorStatusLabelBackColor
        aaformMainWindow.statusbarLabelWelcomeText.ForeColor = colorStatusLabelForeColor
        ' Set other properties for StatusLabel.
        aaformMainWindow.statusbarLabelWelcomeText.BorderSides = propertyStatusLabelBorderSides
        aaformMainWindow.statusbarLabelWelcomeText.BorderStyle = propertyStatusLabelBorderStyle



#End Region

    End Sub
#End Region

#Region "Start the theme engine and apply the user's theme."
    Public Shared Sub themeEngine_ChooseUserTheme()

        ' Choose the proper theme based on what the user chose.
        If My.Settings.userChosenTheme = "Test" Then
            userTheme = My.Resources.TestTheme_XML

        ElseIf My.Settings.userChosenTheme = "Default" Then
            userTheme = My.Resources.DefaultTheme_XML

        ElseIf My.Settings.userChosenTheme = "Eyesore" Then
            userTheme = My.Resources.EyesoreTheme_XML
        Else

            userTheme = My.Resources.DefaultTheme_XML
        End If

        ' Apply the theme.
        UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
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
    Public Property ForeColor() As Color
        Get
            Return _ForeColor
        End Get
        Set(ByVal value As Color)
            _ForeColor = value
        End Set
    End Property

    Protected Overrides Sub OnRenderToolStripBackground(ByVal e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBackground(e)
        Dim lightColor As Color = ControlPaint.Light(Me.BackColor)
        Using b As New LinearGradientBrush(e.AffectedBounds, lightColor, lightColor, LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(b, e.AffectedBounds)
        End Using
    End Sub
End Class
#End Region