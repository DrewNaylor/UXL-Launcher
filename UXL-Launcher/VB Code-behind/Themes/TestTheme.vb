'UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
'Copyright (C) 2013-2017  Drew Naylor
'Microsoft Office and all related words are copyright
'and trademark Microsoft Corporation.
'(Note that the copyright years include the years left out by the hyphen.)
'
'This file is part of UXL Launcher
'(Program is also known as "Unified eXecutable Launcher." Not to be confused with
'another software titled "[Kindle] Unified Application Launcher".)
'
'UXL Launcher is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'
'UXL Launcher is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with UXL Launcher.  If not, see <http://www.gnu.org/licenses/>.


Public Class UXLTheme_TestTheme

    ' This file tells the theme engine what to color things. Theme engine is from this Stack Overflow question: http://stackoverflow.com/q/199521
#Region "Set Test Theme."
    Public Shared Sub applyTheme_TestTheme()

        ' Create a short-form word for "Control."
        Dim ctrl As Control

        ' Colors as defined for this theme.
        Dim colorBackColorButton As Color = Color.Maroon
        Dim colorForeColorButton As Color = Color.White

        ' Look at all the buttons in the "Standard Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxStandardApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorBackColorButton
                button.ForeColor = colorForeColorButton
            End If
        Next

        ' Look at all the buttons in the "Professional Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxProApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorBackColorButton
                button.ForeColor = colorForeColorButton
            End If
        Next

        ' Look at all the buttons in the "Extra Apps + Tools" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxExtraApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorBackColorButton
                button.ForeColor = colorForeColorButton
            End If
        Next

        ' Set colors for the "Standard Apps" groupbox.
        aaformMainWindow.groupboxStandardApps.BackColor = Color.Green
        aaformMainWindow.groupboxStandardApps.ForeColor = Color.Blue
        ' Set colors for the "Professional Apps" groupbox.
        aaformMainWindow.groupboxProApps.BackColor = Color.Green
        aaformMainWindow.groupboxProApps.ForeColor = Color.Blue
        ' Set colors for the "Extra Apps + Tools" groupbox.
        aaformMainWindow.groupboxExtraApps.BackColor = Color.Green
        aaformMainWindow.groupboxExtraApps.ForeColor = Color.Blue

    End Sub
#End Region

#Region "Set Default Theme."
    'Apply Default Theme
    Public Shared Sub applyTheme_DefaultTheme()

        ' Create a short-form word for "Control."
        Dim ctrl As Control

        ' Look at all the buttons in the "Standard Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxStandardApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = Color.Empty
                button.ForeColor = Color.Empty
            End If


            aaformMainWindow.groupboxStandardApps.BackColor = Color.Transparent
            aaformMainWindow.groupboxStandardApps.ForeColor = Color.Empty


            'If (ctrl.GetType() Is GetType(CheckBox)) Then
            '    Dim chkbx As CheckBox = CType(ctrl, CheckBox)
            '    chkbx.Checked = False
            'End If
            'If (ctrl.GetType() Is GetType(ComboBox)) Then
            '    Dim cbobx As ComboBox = CType(ctrl, ComboBox)
            '    cbobx.SelectedIndex = -1
            'End If
            'If (ctrl.GetType() Is GetType(DateTimePicker)) Then
            '    Dim dtp As DateTimePicker = CType(ctrl, DateTimePicker)
            '    dtp.Value = Now()
            'End If
        Next
    End Sub
#End Region
End Class