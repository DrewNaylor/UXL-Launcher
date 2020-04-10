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
    Private Shared _themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)

    ' Variables to store theme title, description, author, version.
    Private Shared _themeSheetTitle As String
    Private Shared _themeSheetDescription As String
    Private Shared _themeSheetAuthor As String
    Private Shared _themeSheetFileVersion As String

    ' Version variable to store theme engine runtime version the theme
    ' says it works with.
    Private Shared _themeSheetEngineRuntimeVersion As Version


    ' Variable to store the theme filename in.
    Private Shared _themeFileNameToLoad As String = ""

#Region "Define strings for controls and things in the XML document."

    ' Variable to store the toolstrip pro renderer in.
    Private Shared _toolstripProRenderer As uxlProToolstripRenderer = New uxlProToolstripRenderer

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

#Region "Theme properties."
#Region "Theme info."
    ' Theme XML file.
    Public Shared Property themeSheet() As XmlDocument
        Get
            Return _themeSheet
        End Get
        Set(value As XmlDocument)
            _themeSheet = value
        End Set
    End Property

    ' Theme filename. This is used to determine what theme the calling
    ' application wants to apply. One way it's used is to see
    ' if the theme is located in My.Resources.
    ' Equivelant to the old userChosenTheme variable, so basically
    ' it's the theme the user chose to load.
    Public Shared Property themeFileNameToLoad() As String
        Get
            Return _themeFileNameToLoad
        End Get
        Set(value As String)
            _themeFileNameToLoad = value
        End Set
    End Property

    ' Theme namespace manager.
    Public Shared Property themeNamespaceManager() As XmlNamespaceManager
        Get
            Return _themeNamespaceManager
        End Get
        Set(value As XmlNamespaceManager)
            _themeNamespaceManager = value
        End Set
    End Property

    ' Theme title.
    Public Shared Property themeSheetTitle() As String
        Get
            Return _themeSheetTitle
        End Get
        Set(value As String)
            _themeSheetTitle = value
        End Set
    End Property

    ' Theme description.
    Public Shared Property themeSheetDescription() As String
        Get
            Return _themeSheetDescription
        End Get
        Set(value As String)
            _themeSheetDescription = value
        End Set
    End Property

    ' Theme author.
    Public Shared Property themeSheetAuthor() As String
        Get
            Return _themeSheetAuthor
        End Get
        Set(value As String)
            _themeSheetAuthor = value
        End Set
    End Property

    ' Theme file version.
    Public Shared Property themeSheetFileVersion() As String
        Get
            Return _themeSheetFileVersion
        End Get
        Set(value As String)
            _themeSheetFileVersion = value
        End Set
    End Property

    ' Theme engine version that the theme is meant to work with.
    Public Shared Property themeSheetEngineRuntimeVersion() As Version
        Get
            Return _themeSheetEngineRuntimeVersion
        End Get
        Set(value As Version)
            _themeSheetEngineRuntimeVersion = value
        End Set
    End Property


#End Region

#Region "Theme controls."
    ' Toolstrip pro renderer.
    Public Shared Property toolstripProRenderer() As uxlProToolstripRenderer
        Get
            Return _toolstripProRenderer
        End Get
        Set(value As uxlProToolstripRenderer)
            _toolstripProRenderer = value
        End Set
    End Property

    ' About window banner style for UXL Launcher.
    Public Shared Property bannerStyle() As Drawing.Image
        Get
            Return _bannerStyle
        End Get
        Set(value As Drawing.Image)
            _bannerStyle = value
        End Set
    End Property

    ' Button back color.
    Public Shared Property colorButtonBackColor() As Color
        Get
            Return _colorButtonBackColor
        End Get
        Set(value As Color)
            _colorButtonBackColor = value
        End Set
    End Property

    ' Button fore color.
    Public Shared Property colorButtonForeColor() As Color
        Get
            Return _colorButtonForeColor
        End Get
        Set(value As Color)
            _colorButtonForeColor = value
        End Set
    End Property

    ' Button flatstyle.
    Public Shared Property flatstyleButtonFlatStyle() As FlatStyle
        Get
            Return _flatstyleButtonFlatStyle
        End Get
        Set(value As FlatStyle)
            _flatstyleButtonFlatStyle = value
        End Set
    End Property

    ' Button flatappearance border color.
    Public Shared Property flatappearanceButtonBorderColor() As Color
        Get
            Return _flatappearanceButtonBorderColor
        End Get
        Set(value As Color)
            _flatappearanceButtonBorderColor = value
        End Set
    End Property

    ' Button flatappearance mouseover back color.
    Public Shared Property flatappearanceButtonMouseOverBackColor() As Color
        Get
            Return _flatappearanceButtonMouseOverBackColor
        End Get
        Set(value As Color)
            _flatappearanceButtonMouseOverBackColor = value
        End Set
    End Property

    ' Button flatappearance mousedown back color.
    Public Shared Property flatappearanceButtonMouseDownBackColor() As Color
        Get
            Return _flatappearanceButtonMouseDownBackColor
        End Get
        Set(value As Color)
            _flatappearanceButtonMouseDownBackColor = value
        End Set
    End Property

    ' Checkbox back color.
    Public Shared Property colorCheckBoxBackColor() As Color
        Get
            Return _colorCheckBoxBackColor
        End Get
        Set(value As Color)
            _colorCheckBoxBackColor = value
        End Set
    End Property

    ' Checkbox fore color.
    Public Shared Property colorCheckBoxForeColor() As Color
        Get
            Return _colorCheckBoxForeColor
        End Get
        Set(value As Color)
            _colorCheckBoxForeColor = value
        End Set
    End Property

    ' Dropdown back color.
    Public Shared Property colorDropdownBackColor() As Color
        Get
            Return _colorDropdownBackColor
        End Get
        Set(value As Color)
            _colorDropdownBackColor = value
        End Set
    End Property

    ' Dropdown fore color.
    Public Shared Property colorDropdownForeColor() As Color
        Get
            Return _colorDropdownForeColor
        End Get
        Set(value As Color)
            _colorDropdownForeColor = value
        End Set
    End Property

    ' Groupbox back color.
    Public Shared Property colorGroupBoxBackColor() As Color
        Get
            Return _colorGroupBoxBackColor
        End Get
        Set(value As Color)
            _colorGroupBoxBackColor = value
        End Set
    End Property

    ' Groupbox fore color.
    Public Shared Property colorGroupBoxForeColor() As Color
        Get
            Return _colorGroupBoxForeColor
        End Get
        Set(value As Color)
            _colorGroupBoxForeColor = value
        End Set
    End Property

    ' FlowLayoutPanel back color.
    Public Shared Property colorFlowLayoutPanelBackColor() As Color
        Get
            Return _colorFlowLayoutPanelBackColor
        End Get
        Set(value As Color)
            _colorFlowLayoutPanelBackColor = value
        End Set
    End Property

    ' FlowLayoutPanel fore color.
    Public Shared Property colorFlowLayoutPanelForeColor() As Color
        Get
            Return _colorFlowLayoutPanelForeColor
        End Get
        Set(value As Color)
            _colorFlowLayoutPanelForeColor = value
        End Set
    End Property

    ' Menubar back color.
    Public Shared Property colorMenubarBackColor() As Color
        Get
            Return _colorMenubarBackColor
        End Get
        Set(value As Color)
            _colorMenubarBackColor = value
        End Set
    End Property

    ' Status Bar back color.
    Public Shared Property colorStatusBarBackColor() As Color
        Get
            Return _colorStatusBarBackColor
        End Get
        Set(value As Color)
            _colorStatusBarBackColor = value
        End Set
    End Property

    ' Label back color.
    Public Shared Property colorLabelBackColor() As Color
        Get
            Return _colorLabelBackColor
        End Get
        Set(value As Color)
            _colorLabelBackColor = value
        End Set
    End Property

    ' Label fore color.
    Public Shared Property colorLabelForeColor() As Color
        Get
            Return _colorLabelForeColor
        End Get
        Set(value As Color)
            _colorLabelForeColor = value
        End Set
    End Property

    ' LinkLabel back color.
    Public Shared Property colorLinkLabelBackColor() As Color
        Get
            Return _colorLinkLabelBackColor
        End Get
        Set(value As Color)
            _colorLinkLabelBackColor = value
        End Set
    End Property

    ' LinkLabel fore color.
    Public Shared Property colorLinkLabelForeColor() As Color
        Get
            Return _colorLinkLabelForeColor
        End Get
        Set(value As Color)
            _colorLinkLabelForeColor = value
        End Set
    End Property

    ' LinkLabel link color.
    Public Shared Property colorLinkLabelLinkColor() As Color
        Get
            Return _colorLinkLabelLinkColor
        End Get
        Set(value As Color)
            _colorLinkLabelLinkColor = value
        End Set
    End Property

    ' LinkLabel active link color.
    Public Shared Property colorLinkLabelActiveLinkColor() As Color
        Get
            Return _colorLinkLabelActiveLinkColor
        End Get
        Set(value As Color)
            _colorLinkLabelActiveLinkColor = value
        End Set
    End Property
#End Region

#End Region
End Class
