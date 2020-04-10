'PortableThemeEngine Theme Editor - Theme editor for editing PortableThemeEngine themes.
'Copyright (C) 2020 Drew Naylor. Licensed under Gnu GPLv3+.
'Any companies mentioned own their respective copyrights/trademarks.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of PortableThemeEngine Theme Editor
'
'PortableThemeEngine Theme Editor is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'PortableThemeEngine Theme Editor is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with PortableThemeEngine Theme Editor.  If not, see <http://www.gnu.org/licenses/>.



Imports System.Xml

Public Class ThemeProcessor

    Friend Shared Sub LoadTheme(themeInput As String, Optional isFilename As Boolean = True)
        ' Try to load the theme. We'll assume it's a file first before
        ' loading it as an XmlDocument.
        If isFilename = True AndAlso System.IO.File.Exists(themeInput) Then
            ThemeProperties.themeSheet.Load(themeInput)
        Else
            ThemeProperties.themeSheet.LoadXml(My.Resources.NewBlankTheme_TE1Dot01)
        End If

        ' Most of this is based on the PortableThemeEngine theme loading code.
        ' Create a namespace manager, and add a namespace to it.
        ThemeProperties.themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

        ' Get the theme title from the XML file.
        ThemeProperties.themeinfoTitle = NodeReader("Title", "(No Title specified)")

        ' Get theme description from XML file.
        ThemeProperties.themeinfoDescription = NodeReader("Description", "(No Description specified)")

        ' Get theme version from XML file.
        ThemeProperties.themeinfoVersion = NodeReader("Version", "(No Version specified)")

        ' Get theme author.
        ThemeProperties.themeinfoAuthor = NodeReader("Author", "(No Author specified)")

        ' Get theme engine version to use.
        ' The theme engine can benefit from this code, so it'll
        ' be put into there eventually.
        ' First check to see if it's a decimal and if it can be parsed.
        If Decimal.TryParse(NodeReader("UseThemeEngineVersion", "(No UseThemeEngineVersion specified)"), CDec(1.01)) = True Then
            ' If it is a decimal, then cast it as one and check if it's less than 1.01.
            If CDec(NodeReader("UseThemeEngineVersion", "(No UseThemeEngineVersion specified)")) < 1.01 Then
                ' If it is, then set the theme engine runtime version to 1.01.
                ThemeProperties.themeinfoUseThemeEngineVersion = "1.01"
            ElseIf CDec(NodeReader("UseThemeEngineVersion", "(No UseThemeEngineVersion specified)")) >= 1.01 Then
                ' Otherwise, it's equal to or larger than 1.01, so just load whatever it is.
                ThemeProperties.themeinfoUseThemeEngineVersion = NodeReader("UseThemeEngineVersion", "(No UseThemeEngineVersion specified)")
            End If
        Else
            ' If it can't be parsed as a decimal, then set the theme engine runtime version to 1.01.
            ThemeProperties.themeinfoUseThemeEngineVersion = "1.01"
        End If

        ' Get button backcolor.
        ThemeProperties.themecontrolButtonBackColor = NodeReader("Theme_Colors/Button/BackColor", "Transparent")

        ' Get button forecolor.
        ThemeProperties.themecontrolButtonForeColor = NodeReader("Theme_Colors/Button/ForeColor", "ControlText")

        ' Get button flatstyle.
        ThemeProperties.themecontrolButtonFlatStyle = NodeReader("Theme_Colors/Button/FlatStyle", "Standard")
        ' If the button flatstyle is neither Flat nor Standard, set it to Standard.
        If Not ThemeProperties.themecontrolButtonFlatStyle = "Flat" Or ThemeProperties.themecontrolButtonFlatStyle = "Standard" Then
            ThemeProperties.themecontrolButtonFlatStyle = "Standard"
        End If

        ' Get button flatstyle bordercolor.
        ThemeProperties.themecontrolButtonFlatAppearanceBorderColor = NodeReader("Theme_Colors/Button/FlatAppearance/BorderColor", "Nothing")

        ' Get flowlayoutpanel backcolor.
        ThemeProperties.themecontrolFlowayoutpanelBackColor = NodeReader("Theme_Colors/FlowLayoutPanel/BackColor", "Transparent")

        ' Get flowlayoutpanel forecolor.
        ThemeProperties.themecontrolFlowayoutpanelForeColor = NodeReader("Theme_Colors/FlowLayoutPanel/ForeColor", "ControlText")

        ' Get groupbox backcolor.
        ThemeProperties.themecontrolGroupboxBackColor = NodeReader("Theme_Colors/GroupBox/BackColor", "Transparent")

        ' Get groupbox forecolor.
        ThemeProperties.themecontrolGroupboxForeColor = NodeReader("Theme_Colors/GroupBox/ForeColor", "ControlText")

        ' Get label backcolor.
        ThemeProperties.themecontrolLabelBackColor = NodeReader("Theme_Colors/Label/BackColor", "Transparent")

        ' Get label forecolor.
        ThemeProperties.themecontrolLabelForeColor = NodeReader("Theme_Colors/Label/ForeColor", "ControlText")

        ' Get menubar backcolor.
        ThemeProperties.themecontrolMenubarBackColor = NodeReader("Theme_Colors/MenuBar/BackColor", "Control")

        ' Get menuitem backcolor.
        ThemeProperties.themecontrolMenuitemBackColor = NodeReader("Theme_Colors/MenuItem/BackColor", "Window")

        ' Get menuitem forecolor.
        ThemeProperties.themecontrolMenuitemForeColor = NodeReader("Theme_Colors/MenuItem/ForeColor", "ControlText")

        ' Get menuitem ImageMarginGradient StartColor.
        ThemeProperties.themecontrolMenuitemImageMarginGradientStartColor = NodeReader("Theme_Colors/MenuItem/ImageMarginGradient/StartColor", "0xFCFCFC")

        ' Get menuitem ImageMarginGradient EndColor.
        ThemeProperties.themecontrolMenuitemImageMarginGradientEndColor = NodeReader("Theme_Colors/MenuItem/ImageMarginGradient/EndColor", "0xF1F1F1")

        ' Get statusbar backcolor.
        ThemeProperties.themecontrolStatusbarBackColor = NodeReader("Theme_Colors/StatusBar/BackColor", "Window")

        ' Get statuslabel backcolor.
        ThemeProperties.themecontrolStatuslabelBackColor = NodeReader("Theme_Colors/StatusLabel/BackColor", "Transparent")

        ' Get statuslabel backcolor.
        ThemeProperties.themecontrolStatuslabelForeColor = NodeReader("Theme_Colors/StatusLabel/ForeColor", "ControlText")

        ' Get statuslabel bordersides.
        ThemeProperties.themecontrolStatuslabelBorderSides = NodeReader("Theme_Colors/StatusLabel/BorderSides", "None")

        ' Get statuslabel borderstyle.
        ThemeProperties.themecontrolStatuslabelBorderStyle = NodeReader("Theme_Colors/StatusLabel/BorderStyle", "Flat")

        ' Get textbox backcolor.
        ThemeProperties.themecontrolTextboxBackColor = NodeReader("Theme_Colors/TextBox/BackColor", "Window")

        ' Get textbox backcolor.
        ThemeProperties.themecontrolTextboxForeColor = NodeReader("Theme_Colors/TextBox/ForeColor", "WindowText")


        'MessageBox.Show(ThemeProperties.themeinfoTitle)
        'MessageBox.Show(ThemeProperties.themeinfoDescription)
        'MessageBox.Show(ThemeProperties.themeinfoVersion)
        'MessageBox.Show(ThemeProperties.themeinfoAuthor)
        'MessageBox.Show(ThemeProperties.themeinfoUseThemeEngineVersion)

        'MessageBox.Show(ThemeProperties.themecontrolButtonBackColor)
        'MessageBox.Show(ThemeProperties.themecontrolButtonForeColor)
        'MessageBox.Show(ThemeProperties.themecontrolButtonFlatStyle)

    End Sub

    Private Shared Function NodeReader(inputNode As String, defaultValue As String) As String
        ' Get theme info and return it to the calling code.
        If ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/" & inputNode & "[1]", ThemeProperties.themeNamespaceManager) IsNot Nothing Then
            Return ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/" & inputNode & "[1]", ThemeProperties.themeNamespaceManager).InnerText
        Else
            Return defaultValue
        End If
    End Function

End Class
