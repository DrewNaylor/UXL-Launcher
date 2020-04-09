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
        ' Create a new XmlDocument to load the theme into.
        Dim themeSheet As XmlDocument = New XmlDocument()

        ' Try to load the theme. We'll assume it's a file first before
        ' loading it as an XmlDocument.
        If isFilename = True AndAlso System.IO.File.Exists(themeInput) Then
            themeSheet.Load(themeInput)
        End If

        ' Most of this is based on the PortableThemeEngine theme loading code.
        ' Create a namespace manager, and add a namespace to it.
        Dim themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
        themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

        ' Get the theme title from the XML file.
        ThemeProperties.themeinfoTitle = NodeReader("Title", themeSheet, themeNamespaceManager, "(No Title specified)")

        ' Get theme description from XML file.
        ThemeProperties.themeinfoDescription = NodeReader("Description", themeSheet, themeNamespaceManager, "(No Description specified)")

        ' Get theme version from XML file.
        ThemeProperties.themeinfoVersion = NodeReader("Version", themeSheet, themeNamespaceManager, "(No Version specified)")

        ' Get theme author.
        ThemeProperties.themeinfoAuthor = NodeReader("Author", themeSheet, themeNamespaceManager, "(No Author specified)")

        ' Get theme engine version to use.
        ' The theme engine can benefit from this code, so it'll
        ' be put into there eventually.
        ' First check to see if it's a decimal and if it can be parsed.
        If Decimal.TryParse(NodeReader("UseThemeEngineVersion", themeSheet, themeNamespaceManager, "(No UseThemeEngineVersion specified)"), CDec(1.01)) = True Then
            ' If it is a decimal, then cast it as one and check if it's less than 1.01.
            If CDec(NodeReader("UseThemeEngineVersion", themeSheet, themeNamespaceManager, "(No UseThemeEngineVersion specified)")) < 1.01 Then
                ' If it is, then set the theme engine runtime version to 1.01.
                ThemeProperties.themeinfoUseThemeEngineVersion = "1.01"
            ElseIf CDec(NodeReader("UseThemeEngineVersion", themeSheet, themeNamespaceManager, "(No UseThemeEngineVersion specified)")) >= 1.01 Then
                ' Otherwise, it's equal to or larger than 1.01, so just load whatever it is.
                ThemeProperties.themeinfoUseThemeEngineVersion = NodeReader("UseThemeEngineVersion", themeSheet, themeNamespaceManager, "(No UseThemeEngineVersion specified)")
            End If
        Else
            ' If it can't be parsed as a decimal, then set the theme engine runtime version to 1.01.
            ThemeProperties.themeinfoUseThemeEngineVersion = "1.01"
        End If

        ' Get button backcolor.
        ThemeProperties.themecontrolButtonBackColor = NodeReader("Theme_Colors/Button/BackColor", themeSheet, themeNamespaceManager, "Transparent")

        ' Get button forecolor.
        ThemeProperties.themecontrolButtonForeColor = NodeReader("Theme_Colors/Button/ForeColor", themeSheet, themeNamespaceManager, "ControlText")

        ' Get button flatstyle.
        ThemeProperties.themecontrolButtonFlatStyle = NodeReader("Theme_Colors/Button/FlatStyle", themeSheet, themeNamespaceManager, "Standard")
        ' If the button flatstyle is neither Flat nor Standard, set it to Standard.
        If Not ThemeProperties.themecontrolButtonFlatStyle = "Flat" Or ThemeProperties.themecontrolButtonFlatStyle = "Standard" Then
            ThemeProperties.themecontrolButtonFlatStyle = "Standard"
        End If

        ' Get button flatstyle bordercolor.
        ThemeProperties.themecontrolButtonFlatAppearanceBorderColor = NodeReader("Theme_Colors/Button/FlatAppearance/BorderColor", themeSheet, themeNamespaceManager, "Nothing")

        ' Get groupbox backcolor.
        ThemeProperties.themecontrolGroupboxBackColor = NodeReader("Theme_Colors/GroupBox/BackColor", themeSheet, themeNamespaceManager, "Nothing")



        MessageBox.Show(ThemeProperties.themeinfoTitle)
        MessageBox.Show(ThemeProperties.themeinfoDescription)
        MessageBox.Show(ThemeProperties.themeinfoVersion)
        MessageBox.Show(ThemeProperties.themeinfoAuthor)
        MessageBox.Show(ThemeProperties.themeinfoUseThemeEngineVersion)

        MessageBox.Show(ThemeProperties.themecontrolButtonBackColor)
        MessageBox.Show(ThemeProperties.themecontrolButtonForeColor)
        MessageBox.Show(ThemeProperties.themecontrolButtonFlatStyle)

    End Sub

    Private Shared Function NodeReader(inputNode As String, inputThemeSheet As XmlDocument, inputThemeNamespaceManager As XmlNamespaceManager, defaultValue As String) As String
        ' Get theme info and return it to the calling code.
        If inputThemeSheet.SelectSingleNode("/UXL_Launcher_Theme/" & inputNode & "[1]", inputThemeNamespaceManager) IsNot Nothing Then
            Return inputThemeSheet.SelectSingleNode("/UXL_Launcher_Theme/" & inputNode & "[1]", inputThemeNamespaceManager).InnerText
        Else
            Return defaultValue
        End If
    End Function

End Class
