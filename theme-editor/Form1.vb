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
    Private Sub comboboxControlSelector_TextChanged(sender As Object, e As EventArgs) Handles comboboxControlSelector.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            ' Show textbox for backcolor.
            uiBackColorTextbox.Show()
            ' Show textbox for forecolor.
            uiForeColorTextbox.Show()
            ' Show label for backcolor.
            uiBackColorLabel.Show()
            ' Show label for forecolor.
            uiForeColorLabel.Show()
            ' Update backcolor and forecolor textboxes with
            ' the button's properties.
            uiBackColorTextbox.Text = buttonBackColor
            uiForeColorTextbox.Text = buttonForeColor

        ElseIf comboboxControlSelector.Text = "GroupBox" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            uiBackColorTextbox.Text = groupboxBackColor
            uiForeColorTextbox.Text = groupboxForeColor

        ElseIf comboboxControlSelector.Text = "FlowLayoutPanel" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            uiBackColorTextbox.Text = flowlayoutpanelBackColor
            uiForeColorTextbox.Text = flowlayoutpanelForeColor

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
            ' Update backcolor textbox with statusbar's backcolor.
            uiBackColorTextbox.Text = statusbarBackColor

        ElseIf comboboxControlSelector.Text = "Label" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            uiBackColorTextbox.Text = labelBackColor
            uiForeColorTextbox.Text = labelForeColor

        ElseIf comboboxControlSelector.Text = "TextBox" Then
            uiBackColorTextbox.Show()
            uiForeColorTextbox.Show()
            uiBackColorLabel.Show()
            uiForeColorLabel.Show()
            uiBackColorTextbox.Text = textboxBackColor
            uiForeColorTextbox.Text = textboxForeColor
        End If
    End Sub

    Private Sub uiBackColorTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiBackColorTextbox.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            buttonBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "GroupBox" Then
            groupboxBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "FlowLayoutPanel" Then
            flowlayoutpanelBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "StatusBar" Then
            statusbarBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            labelBackColor = uiBackColorTextbox.Text
        End If
    End Sub

    Private Sub uiForeColorTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiForeColorTextbox.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            buttonForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "GroupBox" Then
            groupboxForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "FlowLayoutPanel" Then
            flowlayoutpanelForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            labelForeColor = uiForeColorTextbox.Text
        End If
    End Sub

    Private _buttonBackColor As String = "Transparent"
    Private _buttonForeColor As String = "ControlText"
    Private _groupboxBackColor As String = "Transparent"
    Private _groupboxForeColor As String = "ControlText"
    Private _flowlayoutpanelBackColor As String = "Transparent"
    Private _flowlayoutpanelForeColor As String = "ControlText"
    Private _statusbarBackColor As String = "LiteralNothing"
    Private _labelBackColor As String = "Transparent"
    Private _labelForeColor As String = "ControlText"
    Private _textboxBackColor As String = "Window"
    Private _textboxForeColor As String = "WindowText"
    Private _menuitemBackColor As String = "Window"
    Private _menuitemForeColor As String = "ControlText"
    Private _menuitemImageMarginGradientStartColor As String = "0xFCFCFC"
    Private _menuitemImageMarginGradientEndColor As String = "0xF1F1F1"
    Private _menubarBackColor As String = "Control"
    Private _statuslabelBackColor As String = "Transparent"
    Private _statuslabelForeColor As String = "ControlText"
    Private _statuslabelBorderSides As String = "None"
    Private _statuslabelBorderStyle As String = "Flat"



    Public Property buttonBackColor() As String
        Get
            Return _buttonBackColor
        End Get
        Set(value As String)
            _buttonBackColor = value
        End Set
    End Property

    Public Property buttonForeColor() As String
        Get
            Return _buttonForeColor
        End Get
        Set(value As String)
            _buttonForeColor = value
        End Set
    End Property

    Public Property groupboxBackColor() As String
        Get
            Return _groupboxBackColor
        End Get
        Set(value As String)
            _groupboxBackColor = value
        End Set
    End Property

    Public Property groupboxForeColor() As String
        Get
            Return _groupboxForeColor
        End Get
        Set(value As String)
            _groupboxForeColor = value
        End Set
    End Property

    Public Property flowlayoutpanelBackColor() As String
        Get
            Return _flowlayoutpanelBackColor
        End Get
        Set(value As String)
            _flowlayoutpanelBackColor = value
        End Set
    End Property

    Public Property flowlayoutpanelForeColor() As String
        Get
            Return _flowlayoutpanelForeColor
        End Get
        Set(value As String)
            _flowlayoutpanelForeColor = value
        End Set
    End Property

    Public Property statusbarBackColor() As String
        Get
            Return _statusbarBackColor
        End Get
        Set(value As String)
            _statusbarBackColor = value
        End Set
    End Property

    Public Property labelBackColor() As String
        Get
            Return _labelBackColor
        End Get
        Set(value As String)
            _labelBackColor = value
        End Set
    End Property

    Public Property labelForeColor() As String
        Get
            Return _labelForeColor
        End Get
        Set(value As String)
            _labelForeColor = value
        End Set
    End Property

    Public Property textboxForeColor() As String
        Get
            Return _textboxForeColor
        End Get
        Set(value As String)
            _textboxForeColor = value
        End Set
    End Property

    Public Property textboxBackColor() As String
        Get
            Return _textboxBackColor
        End Get
        Set(value As String)
            _textboxBackColor = value
        End Set
    End Property

    Public Property menuitemBackColor() As String
        Get
            Return _menuitemBackColor
        End Get
        Set(value As String)
            _menuitemBackColor = value
        End Set
    End Property

    Public Property menuitemForeColor() As String
        Get
            Return _menuitemForeColor
        End Get
        Set(value As String)
            _menuitemForeColor = value
        End Set
    End Property

    Public Property menuitemImageMarginGradientStartColor() As String
        Get
            Return _menuitemImageMarginGradientStartColor
        End Get
        Set(value As String)
            _menuitemImageMarginGradientStartColor = value
        End Set
    End Property

    Public Property menuitemImageMarginGradientEndColor() As String
        Get
            Return _menuitemImageMarginGradientEndColor
        End Get
        Set(value As String)
            _menuitemImageMarginGradientEndColor = value
        End Set
    End Property
End Class