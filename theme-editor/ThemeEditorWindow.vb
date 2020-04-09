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



Public Class aaformMainWindow
    Private Sub comboboxControlSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxControlSelector.SelectedIndexChanged
        If comboboxControlSelector.Text = "Button" Then
            ' Show textbox for backcolor.
            uiBackColorTextbox.Show()
            ' Show textbox for forecolor.
            uiForeColorTextbox.Show()
            ' Show label for backcolor.
            uiBackColorLabel.Show()
            ' Show label for forecolor.
            uiForeColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Show button controls.
            hideButtonControls(False)

            ' Update backcolor and forecolor textboxes with
            ' the button's properties.
            uiBackColorTextbox.Text = ThemeProperties.themecontrolButtonBackColor
            uiForeColorTextbox.Text = ThemeProperties.themecontrolButtonForeColor

            ' Update flatstyle dropdown and bordercolor textbox
            ' with relevant properties.
            dropdownButtonFlatStyle.Text = ThemeProperties.themecontrolButtonFlatStyle
            textboxButtonFlatAppearanceBorderColor.Text = ThemeProperties.themecontrolButtonFlatAppearanceBorderColor

        ElseIf comboboxControlSelector.Text = "GroupBox" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Hide button controls.
            hideButtonControls(True)

            uiBackColorTextbox.Text = ThemeProperties.themecontrolGroupboxBackColor
            uiForeColorTextbox.Text = ThemeProperties.themecontrolGroupboxForeColor

        ElseIf comboboxControlSelector.Text = "FlowLayoutPanel" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Hide button controls.
            hideButtonControls(True)

            uiBackColorTextbox.Text = ThemeProperties.themecontrolFlowayoutpanelBackColor
            uiForeColorTextbox.Text = ThemeProperties.themecontrolFlowayoutpanelForeColor

        ElseIf comboboxControlSelector.Text = "StatusBar" Then
            ' Show backcolor textbox.
            uiBackColorTextbox.Show()
            ' Hide forecolor textbox since statusbars
            ' don't support forecolors in the theme engine.
            uiForeColorTextbox.Hide()
            ' Hide forecolor label since the textbox is hidden.
            uiForeColorLabel.Hide()
            ' Show backcolor label.
            uiBackColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Hide button controls.
            hideButtonControls(True)

            ' Update backcolor textbox with statusbar's backcolor.
            uiBackColorTextbox.Text = ThemeProperties.themecontrolStatusbarBackColor

        ElseIf comboboxControlSelector.Text = "Label" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Hide button controls.
            hideButtonControls(True)

            uiBackColorTextbox.Text = ThemeProperties.themecontrolLabelBackColor
            uiForeColorTextbox.Text = ThemeProperties.themecontrolLabelForeColor

        ElseIf comboboxControlSelector.Text = "TextBox" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Hide button controls.
            hideButtonControls(True)

            uiBackColorTextbox.Text = ThemeProperties.themecontrolTextboxBackColor
            uiForeColorTextbox.Text = ThemeProperties.themecontrolTextboxForeColor

        ElseIf comboboxControlSelector.Text = "MenuItem" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            ' Show image margin controls.
            hideImageMarginControls(False)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Hide button controls.
            hideButtonControls(True)

            ' Update textboxes with menuitem stuff.
            uiBackColorTextbox.Text = ThemeProperties.themecontrolMenuitemBackColor
            uiForeColorTextbox.Text = ThemeProperties.themecontrolMenuitemForeColor

            uiMenuItemImageMarginEndTextbox.Text = ThemeProperties.themecontrolMenuitemImageMarginGradientEndColor
            uiMenuItemImageMarginStartTextbox.Text = ThemeProperties.themecontrolMenuitemImageMarginGradientStartColor

        ElseIf comboboxControlSelector.Text = "MenuBar" Then
            ' Show backcolor textbox.
            uiBackColorTextbox.Show()
            ' Hide forecolor textbox since statusbars
            ' don't support forecolors in the theme engine.
            uiForeColorTextbox.Hide()
            ' Hide forecolor label since the textbox is hidden.
            uiForeColorLabel.Hide()
            ' Show backcolor label.
            uiBackColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Hide statuslabel controls.
            hideStatusLabelControls(True)

            ' Hide button controls.
            hideButtonControls(True)

            ' Update backcolor textbox with statusbar's backcolor.
            uiBackColorTextbox.Text = ThemeProperties.themecontrolMenubarBackColor

        ElseIf comboboxControlSelector.Text = "StatusLabel" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            ' Hide image margin controls.
            hideImageMarginControls(True)

            ' Show statuslabel controls.
            hideStatusLabelControls(False)

            ' Hide button controls.
            hideButtonControls(True)



            ' Update textboxes with statuslabel stuff.
            uiBackColorTextbox.Text = ThemeProperties.themecontrolStatuslabelBackColor
            uiForeColorTextbox.Text = ThemeProperties.themecontrolStatuslabelForeColor

            uiStatusLabelBorderSidesDropdown.Text = ThemeProperties.themecontrolStatuslabelBorderSides
            uiStatusLabelBorderStyleDropdown.Text = ThemeProperties.themecontrolStatuslabelBorderStyle
        End If
    End Sub

    Private Sub hideImageMarginControls(Optional hideControls As Boolean = True)
        If hideControls = True Then
            ' Hide label for menuitem image margin start.
            uiMenuItemImageMarginStartLabel.Hide()
            ' Hide textbox for menuitem image margin start.
            uiMenuItemImageMarginStartTextbox.Hide()
            ' Hide label for menuitem image margin end.
            uiMenuItemImageMarginEndLabel.Hide()
            ' Hide textbox for image margin end.
            uiMenuItemImageMarginEndTextbox.Hide()
        ElseIf hideControls = False Then
            ' Show label for menuitem image margin start.
            uiMenuItemImageMarginStartLabel.Show()
            ' Show textbox for menuitem image margin start.
            uiMenuItemImageMarginStartTextbox.Show()
            ' Show label for menuitem image margin end.
            uiMenuItemImageMarginEndLabel.Show()
            ' Show textbox for image margin end.
            uiMenuItemImageMarginEndTextbox.Show()
        End If
    End Sub

    Private Sub hideStatusLabelControls(Optional hideControls As Boolean = True)
        If hideControls = True Then
            ' Hide label for statuslabel bordersides.
            uiStatusLabelBorderSidesLabel.Hide()
            ' Hide dropdown for statuslabel bordersides.
            uiStatusLabelBorderSidesDropdown.Hide()
            ' Hide label for statuslabel borderstyle.
            uiStatusLabelBorderStyleLabel.Hide()
            ' Hide dropdown for statuslabel borderstyle.
            uiStatusLabelBorderStyleDropdown.Hide()
        ElseIf hideControls = False Then
            ' Show label for statuslabel bordersides.
            uiStatusLabelBorderSidesLabel.Show()
            ' Show dropdown for statuslabel bordersides.
            uiStatusLabelBorderSidesDropdown.Show()
            ' Show label for statuslabel borderstyle.
            uiStatusLabelBorderStyleLabel.Show()
            ' Show dropdown for statuslabel borderstyle.
            uiStatusLabelBorderStyleDropdown.Show()
        End If
    End Sub

    Private Sub hideButtonControls(Optional hideControls As Boolean = True)
        If hideControls = True Then
            ' Hide label for button flatstyle.
            labelButtonFlatStyle.Hide()
            ' Hide dropdown for button flatstyle.
            dropdownButtonFlatStyle.Hide()
            ' Hide label for button flatstyle bordercolor.
            labelButtonFlatAppearanceBorderColor.Hide()
            ' Hide textbox for button flatstyle bordercolor.
            textboxButtonFlatAppearanceBorderColor.Hide()
        ElseIf hideControls = False Then
            ' Show label for button flatstyle.
            labelButtonFlatStyle.Show()
            ' Show dropdown for button flatstyle.
            dropdownButtonFlatStyle.Show()
            ' Show label for button flatstyle bordercolor.
            labelButtonFlatAppearanceBorderColor.Show()
            ' Show textbox for button flatstyle bordercolor.
            textboxButtonFlatAppearanceBorderColor.Show()
        End If
    End Sub

    Private Sub uiBackColorTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiBackColorTextbox.TextChanged
        ' Save what's entered into the BackColor textbox
        ' into the relevant property depending on what's
        ' in the Control selector.
        If comboboxControlSelector.Text = "Button" Then
            ThemeProperties.themecontrolButtonBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "GroupBox" Then
            ThemeProperties.themecontrolGroupboxBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "FlowLayoutPanel" Then
            ThemeProperties.themecontrolFlowayoutpanelBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "StatusBar" Then
            ThemeProperties.themecontrolStatusbarBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            ThemeProperties.themecontrolLabelBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "TextBox" Then
            ThemeProperties.themecontrolTextboxBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "MenuItem" Then
            ThemeProperties.themecontrolMenuitemBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "MenuBar" Then
            ThemeProperties.themecontrolMenubarBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "StatusLabel" Then
            ThemeProperties.themecontrolStatuslabelBackColor = uiBackColorTextbox.Text
        End If
    End Sub

    Private Sub uiForeColorTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiForeColorTextbox.TextChanged
        ' Save what's entered into the ForeColor textbox
        ' into the relevant property depending on what's
        ' in the Control selector.
        If comboboxControlSelector.Text = "Button" Then
            ThemeProperties.themecontrolButtonForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "GroupBox" Then
            ThemeProperties.themecontrolGroupboxForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "FlowLayoutPanel" Then
            ThemeProperties.themecontrolFlowayoutpanelForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            ThemeProperties.themecontrolLabelForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "TextBox" Then
            ThemeProperties.themecontrolTextboxForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "MenuItem" Then
            ThemeProperties.themecontrolMenuitemForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "StatusLabel" Then
            ThemeProperties.themecontrolStatuslabelForeColor = uiForeColorTextbox.Text
        End If
    End Sub

    Private Sub uiMenuItemImageMarginEndTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiMenuItemImageMarginEndTextbox.TextChanged
        ' Save what's entered in the ImageMarginEnd textbox
        ' into the menuitem image margin gradient end color
        ' property.
        ThemeProperties.themecontrolMenuitemImageMarginGradientEndColor = uiMenuItemImageMarginEndTextbox.Text
    End Sub

    Private Sub uiMenuItemImageMarginStartTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiMenuItemImageMarginStartTextbox.TextChanged
        ' Update image margin gradient start color property
        ' when the textbox is updated.
        ThemeProperties.themecontrolMenuitemImageMarginGradientStartColor = uiMenuItemImageMarginStartTextbox.Text
    End Sub

    Private Sub uiStatusLabelBorderStyleDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uiStatusLabelBorderStyleDropdown.SelectedIndexChanged
        ' Update statuslabel border style property
        ' when the user chooses something from the list.
        ThemeProperties.themecontrolStatuslabelBorderStyle = uiStatusLabelBorderStyleDropdown.Text
    End Sub

    Private Sub uiStatusLabelBorderSidesDropdown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles uiStatusLabelBorderSidesDropdown.SelectedIndexChanged
        ' Update statuslabel border sides property
        ' when the user chooses something from the list.
        ThemeProperties.themecontrolStatuslabelBorderSides = uiStatusLabelBorderSidesDropdown.Text

        ' Enable or disable BorderStyle dropdown depending on if
        ' the user chose "None" or not.
        If ThemeProperties.themecontrolStatuslabelBorderSides = "None" Then
            uiStatusLabelBorderStyleDropdown.Enabled = False
        Else
            uiStatusLabelBorderStyleDropdown.Enabled = True
        End If
    End Sub

    Private Sub textboxThemeTitle_TextChanged(sender As Object, e As EventArgs) Handles textboxThemeTitle.TextChanged
        ' Save theme title into its property.
        ThemeProperties.themeinfoTitle = textboxThemeTitle.Text
    End Sub

    Private Sub textboxThemeDescription_TextChanged(sender As Object, e As EventArgs) Handles textboxThemeDescription.TextChanged
        'Save theme description into its property.
        ThemeProperties.themeinfoDescription = textboxThemeDescription.Text
    End Sub

    Private Sub textboxThemeVersion_TextChanged(sender As Object, e As EventArgs) Handles textboxThemeVersion.TextChanged
        ' Save theme version into its property.
        ThemeProperties.themeinfoVersion = textboxThemeVersion.Text
    End Sub

    Private Sub textboxThemeAuthor_TextChanged(sender As Object, e As EventArgs) Handles textboxThemeAuthor.TextChanged
        ' Save theme author into its property.
        ThemeProperties.themeinfoAuthor = textboxThemeAuthor.Text
    End Sub

    Private Sub dropdownThemeEngineRuntimeVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropdownThemeEngineRuntimeVersion.SelectedIndexChanged
        ' Save the theme engine runtime version into its property.
        ThemeProperties.themeinfoUseThemeEngineVersion = dropdownThemeEngineRuntimeVersion.Text
    End Sub

    Private Sub dropdownButtonFlatStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropdownButtonFlatStyle.SelectedIndexChanged
        ' Save the button flat style value to its property.
        ThemeProperties.themecontrolButtonFlatStyle = dropdownButtonFlatStyle.Text

        ' Enable or disable button flatstyle border color textbox based on 
        ' what's in the flatstyle property.
        If ThemeProperties.themecontrolButtonFlatStyle = "Flat" Then
            textboxButtonFlatAppearanceBorderColor.Enabled = True
        Else
            textboxButtonFlatAppearanceBorderColor.Enabled = False
        End If
    End Sub

    Private Sub textboxButtonFlatAppearanceBorderColor_TextChanged(sender As Object, e As EventArgs) Handles textboxButtonFlatAppearanceBorderColor.TextChanged
        ' Save the button flat style border color into its property.
        ThemeProperties.themecontrolButtonFlatAppearanceBorderColor = textboxButtonFlatAppearanceBorderColor.Text
    End Sub

    Private Sub aaformMainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ThemeProcessor.LoadTheme("C:\Users\drewn\Documents\0GitHub\UXL-Launcher\UXL-Launcher\VB Code-behind\Themes\TenDarkTheme_XML.xml")
    End Sub
End Class

Public Class ThemeProperties

    ' Theme properties.
    Private Shared _themeinfoTitle As String = "Untitled"
    Private Shared _themeinfoDescription As String = "Theme description goes here."
    Private Shared _themeinfoAuthor As String = "Author"
    Private Shared _themeinfoVersion As String = "1.0"
    Private Shared _themeinfoUseThemeEngineVersion As String = "1.01"
    ' Control properties.
    Private Shared _themecontrolButtonBackColor As String = "Transparent"
    Private Shared _themecontrolButtonForeColor As String = "ControlText"
    Private Shared _themecontrolButtonFlatStyle As String = "Standard"
    Private Shared _themecontrolButtonFlatAppearanceBorderColor As String = "Nothing"
    Private Shared _themecontrolGroupboxBackColor As String = "Transparent"
    Private Shared _themecontrolGroupboxForeColor As String = "ControlText"
    Private Shared _themecontrolFlowlayoutpanelBackColor As String = "Transparent"
    Private Shared _themecontrolFlowlayoutpanelForeColor As String = "ControlText"
    Private Shared _themecontrolStatusbarBackColor As String = "Control"
    Private Shared _themecontrolLabelBackColor As String = "Transparent"
    Private Shared _themecontrolLabelForeColor As String = "ControlText"
    Private Shared _themecontrolTextboxBackColor As String = "Window"
    Private Shared _themecontrolTextboxForeColor As String = "WindowText"
    Private Shared _themecontrolMenuitemBackColor As String = "Window"
    Private Shared _themecontrolMenuitemForeColor As String = "ControlText"
    Private Shared _themecontrolMenuitemImageMarginGradientStartColor As String = "0xFCFCFC"
    Private Shared _themecontrolMenuitemImageMarginGradientEndColor As String = "0xF1F1F1"
    Private Shared _themecontrolMenubarBackColor As String = "Control"
    Private Shared _themecontrolStatuslabelBackColor As String = "Transparent"
    Private Shared _themecontrolStatuslabelForeColor As String = "ControlText"
    Private Shared _themecontrolStatuslabelBorderSides As String = "None"
    Private Shared _themecontrolStatuslabelBorderStyle As String = "Flat"

    ' Theme properties.
    Public Shared Property themeinfoTitle() As String
        Get
            Return ThemeProperties._themeinfoTitle
        End Get
        Set(value As String)
            ThemeProperties._themeinfoTitle = value
        End Set
    End Property

    Public Shared Property themeinfoDescription() As String
        Get
            Return _themeinfoDescription
        End Get
        Set(value As String)
            _themeinfoDescription = value
        End Set
    End Property

    Public Shared Property themeinfoAuthor() As String
        Get
            Return _themeinfoAuthor
        End Get
        Set(value As String)
            _themeinfoAuthor = value
        End Set
    End Property

    Public Shared Property themeinfoVersion() As String
        Get
            Return _themeinfoVersion
        End Get
        Set(value As String)
            _themeinfoVersion = value
        End Set
    End Property

    Public Shared Property themeinfoUseThemeEngineVersion() As String
        Get
            Return _themeinfoUseThemeEngineVersion
        End Get
        Set(value As String)
            _themeinfoUseThemeEngineVersion = value
        End Set
    End Property

    ' Control properties.
    Public Shared Property themecontrolButtonBackColor() As String
        Get
            Return _themecontrolButtonBackColor
        End Get
        Set(value As String)
            _themecontrolButtonBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolButtonForeColor() As String
        Get
            Return _themecontrolButtonForeColor
        End Get
        Set(value As String)
            _themecontrolButtonForeColor = value
        End Set
    End Property

    Public Shared Property themecontrolButtonFlatStyle() As String
        Get
            Return _themecontrolButtonFlatStyle
        End Get
        Set(value As String)
            _themecontrolButtonFlatStyle = value
        End Set
    End Property

    Public Shared Property themecontrolButtonFlatAppearanceBorderColor() As String
        Get
            Return _themecontrolButtonFlatAppearanceBorderColor
        End Get
        Set(value As String)
            _themecontrolButtonFlatAppearanceBorderColor = value
        End Set
    End Property

    Public Shared Property themecontrolGroupboxBackColor() As String
        Get
            Return _themecontrolGroupboxBackColor
        End Get
        Set(value As String)
            _themecontrolGroupboxBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolGroupboxForeColor() As String
        Get
            Return _themecontrolGroupboxForeColor
        End Get
        Set(value As String)
            _themecontrolGroupboxForeColor = value
        End Set
    End Property

    Public Shared Property themecontrolFlowayoutpanelBackColor() As String
        Get
            Return _themecontrolFlowlayoutpanelBackColor
        End Get
        Set(value As String)
            _themecontrolFlowlayoutpanelBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolFlowayoutpanelForeColor() As String
        Get
            Return _themecontrolFlowlayoutpanelForeColor
        End Get
        Set(value As String)
            _themecontrolFlowlayoutpanelForeColor = value
        End Set
    End Property

    Public Shared Property themecontrolStatusbarBackColor() As String
        Get
            Return _themecontrolStatusbarBackColor
        End Get
        Set(value As String)
            _themecontrolStatusbarBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolLabelBackColor() As String
        Get
            Return _themecontrolLabelBackColor
        End Get
        Set(value As String)
            _themecontrolLabelBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolLabelForeColor() As String
        Get
            Return _themecontrolLabelForeColor
        End Get
        Set(value As String)
            _themecontrolLabelForeColor = value
        End Set
    End Property

    Public Shared Property themecontrolTextboxForeColor() As String
        Get
            Return _themecontrolTextboxForeColor
        End Get
        Set(value As String)
            _themecontrolTextboxForeColor = value
        End Set
    End Property

    Public Shared Property themecontrolTextboxBackColor() As String
        Get
            Return _themecontrolTextboxBackColor
        End Get
        Set(value As String)
            _themecontrolTextboxBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolMenuitemBackColor() As String
        Get
            Return _themecontrolMenuitemBackColor
        End Get
        Set(value As String)
            _themecontrolMenuitemBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolMenuitemForeColor() As String
        Get
            Return _themecontrolMenuitemForeColor
        End Get
        Set(value As String)
            _themecontrolMenuitemForeColor = value
        End Set
    End Property

    Public Shared Property themecontrolMenuitemImageMarginGradientStartColor() As String
        Get
            Return _themecontrolMenuitemImageMarginGradientStartColor
        End Get
        Set(value As String)
            _themecontrolMenuitemImageMarginGradientStartColor = value
        End Set
    End Property

    Public Shared Property themecontrolMenuitemImageMarginGradientEndColor() As String
        Get
            Return _themecontrolMenuitemImageMarginGradientEndColor
        End Get
        Set(value As String)
            _themecontrolMenuitemImageMarginGradientEndColor = value
        End Set
    End Property

    Public Shared Property themecontrolMenubarBackColor() As String
        Get
            Return _themecontrolMenubarBackColor
        End Get
        Set(value As String)
            _themecontrolMenubarBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolStatuslabelBackColor() As String
        Get
            Return _themecontrolStatuslabelBackColor
        End Get
        Set(value As String)
            _themecontrolStatuslabelBackColor = value
        End Set
    End Property

    Public Shared Property themecontrolStatuslabelForeColor() As String
        Get
            Return _themecontrolStatuslabelForeColor
        End Get
        Set(value As String)
            _themecontrolStatuslabelForeColor = value
        End Set
    End Property

    Public Shared Property themecontrolStatuslabelBorderSides() As String
        Get
            Return _themecontrolStatuslabelBorderSides
        End Get
        Set(value As String)
            _themecontrolStatuslabelBorderSides = value
        End Set
    End Property

    Public Shared Property themecontrolStatuslabelBorderStyle() As String
        Get
            Return _themecontrolStatuslabelBorderStyle
        End Get
        Set(value As String)
            _themecontrolStatuslabelBorderStyle = value
        End Set
    End Property
End Class