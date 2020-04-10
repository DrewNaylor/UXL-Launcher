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



Imports System.Xml

Public Class ThemeProperties

    ' Define a variable to store the theme sheet.
    Private Shared _themeSheet As XmlDocument = New XmlDocument()
    ' Variable to store the theme namespace manager.
    ' TODO: Uncomment this next line for later use when
    ' assigning properties.
    'Private Shared _themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
    ' Variables to store theme title, description, author, version.
    Private Shared _themeSheetTitle As String
    Private Shared _themeSheetDescription As String
    Private Shared _themeSheetAuthor As String
    Private Shared _themeSheetFileVersion As String
    ' Version variable to store theme engine runtime version the theme
    ' says it works with.
    Private Shared _themeSheetEngineRuntimeVersion As Version

    ' Variable to store the toolstrip pro renderer in.
    Private Shared _toolstripProRenderer As uxlProToolstripRenderer = New uxlProToolstripRenderer

    ' Variable to store the theme name in.
    Private Shared _themeName As String



End Class
