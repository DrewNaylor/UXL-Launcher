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



Public Class TE2DotXLoader

    ' TODO: See TE1DotXLoaderShim.vb for a detailed TODO comment.
    ' The TE2.x theme loader will pull from attributes instead
    ' of XmlNode.InnerText.

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

End Class
