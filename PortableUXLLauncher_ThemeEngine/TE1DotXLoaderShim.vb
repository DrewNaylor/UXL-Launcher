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



Public Class TE1DotXLoaderShim

    ' TODO: This file will load in TE1.x themes by assigning
    ' properties in ThemeProperties to XmlNode.InnerText values, just
    ' like TE1.x does.
    '
    ' How a TE1.x theme is determined is if the theme doesn't
    ' have an attribute saying what theme engine runtime version it's for.
    '
    ' Example: <UseThemeEngineVersion>1.03</UseThemeEngineVersion> in TE1.x
    ' or <ThemeEngine runtimeVersion="2.0"> in TE2.x themes; themes lacking
    ' the TE2.x-style attribute will be assumed to be TE1.x.
    '
    ' The determination will be made in the theme loading code, then
    ' if necessary, it'll be passed here for processing.
    ' Afterward, it'll go back to the code to change the control colors.

End Class
