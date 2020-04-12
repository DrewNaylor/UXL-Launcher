﻿'PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
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

Public Class TE1DotXLoaderShim
    Friend Shared Sub AssignProperties(formToApplyTo As Form)

        ' Theme isn't a TE2.x theme, so load it with the TE1.x shim.

        ' Assign variable for TE runtime version node.
        Dim ThemeEngineNode As XmlNode = ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion")

        ' Set the engine runtime version to 1.01 if it's less than that.
        If ThemeEngineNode IsNot Nothing Then

            ' Store the theme engine runtime version from the file.
            Dim TERuntimeVersionInThemeFile As Version = Version.Parse(ThemeEngineNode.InnerText.ToString)

            ' Make a version variable to store the theme engine version we want to compare to.
            Dim TE1xMinVersion As Version = Version.Parse("1.01")

            Select Case TERuntimeVersionInThemeFile.CompareTo(TE1xMinVersion)
                Case 0 ' The theme file wants to use Theme Engine version 1.01.
                    ThemeProperties.themeSheetEngineRuntimeVersion = Version.Parse(TE1xMinVersion.ToString)
                Case 1 ' The theme file wants to use a theme engine version newer than 1.01.
                    ThemeProperties.themeSheetEngineRuntimeVersion = Version.Parse(TERuntimeVersionInThemeFile.ToString)
                Case -1 ' The theme file has a version smaller than 1.01, so it'll be forced to 1.01.
                    ThemeProperties.themeSheetEngineRuntimeVersion = Version.Parse("1.01")
            End Select

        Else

            ' If there's no theme engine runtime version, set it to 1.01.
            ThemeProperties.themeSheetEngineRuntimeVersion = Version.Parse("1.01")
        End If

        MessageBox.Show(ThemeProperties.themeSheetEngineRuntimeVersion.ToString)
        If ThemeProperties.compatibilityUseFullTE1DotXCompatibilityMode = False Then
            ' If the calling app wants to use loose compatibility mode, get the
            ' theme engine runtime version the theme wants to use and send it
            ' back to the TE2.x loader.

            ' Load up the theme file and get its properties if loose compatibility is enabled.
            TE2DotXLoader.AssignControlProperties(False)

        Else
            ' Calling application wants to use full TE1.x compatibility mode,
            ' so make sure the form that's passed into the theme engine
            ' can be themed.

#Region "Apply default colors to forms not supported by TE1.02 or lower."
            ' Apply default colors to forms that aren't supported by TE1.02 or lower.
            If formToApplyTo.Name IsNot "aaformMainWindow" Then
                Select Case ThemeProperties.themeSheetEngineRuntimeVersion.CompareTo("1.03")
                    Case -1
                        ' If the theme doesn't support TE1.03, apply defaults.
                        ' Default button colors.
                        ThemeProperties.colorButtonBackColor = Color.FromKnownColor(KnownColor.Transparent)
                        ThemeProperties.colorButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)
                        ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Standard
                        ThemeProperties.flatappearanceButtonBorderColor = Nothing

                        ' Default TableLayoutPanel colors.
                        ThemeProperties.colorTableLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Control)
                        ThemeProperties.colorTableLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default TabPage colors.
                        ThemeProperties.colorTabPageBackColor = Color.FromKnownColor(KnownColor.Window)
                        ThemeProperties.colorTabPageForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default GroupBox colors.
                        ThemeProperties.colorGroupBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
                        ThemeProperties.colorGroupBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default Label colors.
                        ThemeProperties.colorLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
                        ThemeProperties.colorLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default Textbox colors.
                        ThemeProperties.colorTextboxBackColor = Color.FromKnownColor(KnownColor.Window)
                        ThemeProperties.colorTextboxForeColor = Color.FromKnownColor(KnownColor.WindowText)

                        ' Default RadioButton colors.
                        ThemeProperties.colorRadioButtonBackColor = Color.FromKnownColor(KnownColor.Transparent)
                        ThemeProperties.colorRadioButtonForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default Checkbox colors.
                        ThemeProperties.colorCheckBoxBackColor = Color.FromKnownColor(KnownColor.Transparent)
                        ThemeProperties.colorCheckBoxForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default Dropdown box/ComboBox colors.
                        ThemeProperties.colorDropdownBackColor = Color.FromKnownColor(KnownColor.Window)
                        ThemeProperties.colorDropdownForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default LinkLabel colors.
                        ThemeProperties.colorLinkLabelBackColor = Color.FromKnownColor(KnownColor.Transparent)
                        ThemeProperties.colorLinkLabelForeColor = Color.FromKnownColor(KnownColor.ControlText)
                        ThemeProperties.colorLinkLabelLinkColor = Color.FromArgb(0, 0, 255)
                        ThemeProperties.colorLinkLabelActiveLinkColor = Color.FromKnownColor(KnownColor.Red)

                        ' Default Panel colors.
                        ThemeProperties.colorPanelBackColor = Color.FromKnownColor(KnownColor.Control)
                        ThemeProperties.colorPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)

                        ' Default About window banner.
                        ThemeProperties.bannerStyle = My.Resources.UXL_Launcher_Banner

                        'Default FlowLayoutPanel colors.
                        ThemeProperties.colorFlowLayoutPanelBackColor = Color.FromKnownColor(KnownColor.Window)
                        ThemeProperties.colorFlowLayoutPanelForeColor = Color.FromKnownColor(KnownColor.ControlText)
                End Select
            End If
#End Region

        End If

    End Sub

    ' TODO: This file will load in TE1.x themes by assigning
    ' properties in ThemeProperties to XmlNode.InnerText values, just
    ' like TE1.x does.
    '
    ' How a TE1.x theme is determined is if the theme doesn't
    ' have an attribute saying what theme engine runtime version it's for.
    '
    ' Example: <UseThemeEngineVersion>1.03</UseThemeEngineVersion> in TE1.x
    ' or <ThemeEngine RuntimeVersion="2.0"> in TE2.x themes; themes lacking
    ' the TE2.x-style attribute will be assumed to be TE1.x.
    '
    ' The determination will be made in the theme loading code, then
    ' if necessary, it'll be passed here for processing.
    ' Afterward, it'll go back to the code to change the control colors.
    '
    ' The following function can be used to simplify the amount of code
    ' needed to assign the properties:

    'Private Shared Function NodeReader(inputNode As String, defaultValue As String) As String
    '    ' Get theme info and return it to the calling code.
    '    If ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/" & inputNode & "[1]", ThemeProperties.themeNamespaceManager) IsNot Nothing Then
    '        Return ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/" & inputNode & "[1]", ThemeProperties.themeNamespaceManager).InnerText
    '    Else
    '        Return defaultValue
    '    End If
    'End Function

    ' Above code block is copied from the theme editor since it's
    ' rather useful there.

    ' Example of how to use:

    'ThemeProperties.themecontrolButtonBackColor = NodeReader("Theme_Colors/Button/BackColor", "Transparent")

    ' Modification will likely be required.

End Class
