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



Imports System.Drawing
Imports System.Windows.Forms
Imports System.Xml

Public Class ThemeProperties

    ' Define a variable to store the theme sheet.
    Private Shared _themeSheet As XmlDocument = New XmlDocument()
    ' Variable to store the theme namespace manager.
    ' TODO: Uncomment this next line for later use when
    ' assigning properties.
    Private Shared _themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
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
    Private Shared _themeName As String = ""

#Region "Define strings for controls and things in the XML document."

    ' About window Banner style (Dark or Light):
    Private Shared _bannerStyle As Drawing.Image
    ' Button colors:
    Private Shared _colorButtonBackColor As Color
    Private Shared _colorButtonForeColor As Color
    Private Shared _flatstyleButtonFlatStyle As FlatStyle ' If flatstyleButtonFlatStyle is "= Flat", the flatstyle is Flat. Standard is "FlatStyle = FlatStyle.Standard".
    Private Shared _flatappearanceButtonBorderColor As Color ' The border of the buttons if "FlatStyle = FlatStyle.Flat".
    Private Shared _flatappearanceButtonMouseOverBackColor As Color ' The color of the buttons on mouseover if "FlatStyle = FlatStyle.Flat".
    Private Shared _flatappearanceButtonMouseDownBackColor As Color ' The color of the buttons on mousedown if "FlatStyle = FlatStyle.Flat".
    ' Checkbox colors:
    Private Shared _colorCheckBoxBackColor As Color
    Private Shared _colorCheckBoxForeColor As Color
    ' Checkbox colors:
    Private Shared _colorDropdownBackColor As Color
    Private Shared _colorDropdownForeColor As Color
    ' Groupbox colors:
    Private Shared _colorGroupBoxBackColor As Color
    Private Shared _colorGroupBoxForeColor As Color
    ' FlowLayoutPanel colors:
    Private Shared _colorFlowLayoutPanelBackColor As Color
    Private Shared _colorFlowLayoutPanelForeColor As Color
    ' Menubar colors:
    Private Shared _colorMenubarBackColor As Color
    ' Status Bar colors:
    Private Shared _colorStatusBarBackColor As Color
    ' Label colors:
    Private Shared _colorLabelBackColor As Color
    Private Shared _colorLabelForeColor As Color
    ' LinkLabel colors:
    Private Shared _colorLinkLabelBackColor As Color ' used for link's background color.
    Private Shared _colorLinkLabelForeColor As Color ' used for non-link text.
    Private Shared _colorLinkLabelLinkColor As Color ' used for the link's usual color when not clicking it.
    Private Shared _colorLinkLabelActiveLinkColor As Color ' used when clicking on a link.
    ' Radio Button colors:
    Private Shared _colorRadioButtonBackColor As Color
    Private Shared _colorRadioButtonForeColor As Color
    ' TableLayoutPanel colors:
    Private Shared _colorTableLayoutPanelBackColor As Color
    Private Shared _colorTableLayoutPanelForeColor As Color
    ' If the theme says to use this in the About window's
    ' About tab for the tableLayoutPanelAboutAppTab control,
    ' apply colorTableLayoutPanelBackColor to it.
    ' Otherwise, just use the colorTabPageBackColor
    ' and have the table layout panel inherit it.
    Private Shared _useTableLayoutPanelColorInsideAboutAppTab As Boolean = False
    ' TabPage colors:
    Private Shared _colorTabPageBackColor As Color
    Private Shared _colorTabPageForeColor As Color
    ' Textbox colors:
    Private Shared _colorTextboxBackColor As Color
    Private Shared _colorTextboxForeColor As Color
    ' Menubar entry colors:
    Private Shared _colorMenuItemBackColor As Color
    Private Shared _colorMenuItemForeColor As Color
    ' Menubar item margin colors:
    Private Shared _colorMenuItemImageMarginGradientStartColor As Color
    Private Shared _colorMenuItemImageMarginGradientEndColor As Color
    ' Statusbar label colors:
    Private Shared _colorStatusLabelBackColor As Color
    Private Shared _colorStatusLabelForeColor As Color
    ' Other statusbar label properties
    Private Shared _propertyStatusLabelBorderSides As ToolStripStatusLabelBorderSides
    Private Shared _propertyStatusLabelBorderStyle As Border3DStyle
#End Region

End Class
