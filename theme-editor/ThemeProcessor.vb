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
            themeSheet.LoadXml(themeInput)
        End If


    End Sub

End Class
