' PortableThemeEngine - Theme engine based off the UXL Launcher Theme Engine.
' Can be used with standard Windows Forms applications.
' Copyright (C) 2019-2020 Drew Naylor.
' Microsoft Windows and all related words are copyright
' and trademark Microsoft Corporation.
' Microsoft is not affiliated with either PortableThemeEngine or Drew Naylor
' and does not endorse this software.
' Any other companies mentioned own their respective copyrights/trademarks.
' (Note that the copyright years include the years left out by the hyphen.)
'
' This file is part of PortableThemeEngine.
'
'
'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at
'
'     http://www.apache.org/licenses/LICENSE-2.0
'
'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.



Imports System.Drawing
Imports System.Windows.Forms
Imports System.Xml


Friend Class TE1DotXLoaderShim
    Friend Shared Sub AssignProperties(formToApplyTo As Form)

        ' Theme isn't a TE2.x theme, so load it with the TE1.x shim.

        ' Assign variable for TE runtime version node.
        Dim ThemeEngineNode As XmlNode = ThemeProperties.themeSheet.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion", ThemeProperties.themeNamespaceManager)

        ' Set the engine runtime version to 1.01 if it's less than that.
        If ThemeEngineNode IsNot Nothing Then

            ' Store the theme engine runtime version from the file.
            ' First make sure there are only numbers.
            Dim CleanedVersion As String = TE2DotXLoader.PullNumbersAndDotsRegex(ThemeEngineNode.InnerText.ToString)

            ' Tried to make sure it was a valid version, but I keep running into
            ' potential edge cases with the code I was trying to write,
            ' so I'm just catching the exception for now.
            Dim TERuntimeVersionInThemeFile As Version
            Try
                TERuntimeVersionInThemeFile = Version.Parse(CleanedVersion)
                ' FormatException:
                ' The version isn't written correctly. Could possibly
                ' be something like "1..2".
                ' OverflowException:
                ' Version specified in theme file is too big for Int32.
                ' ArgumentException:
                ' There's either no value or it's not formatted correctly.
                ' Exception:
                ' Catch all the above for easier code changing.
            Catch ex As Exception
                ' If it's invalid, set it to the lowest number for TE1.x themes.
                TERuntimeVersionInThemeFile = Version.Parse("1.01")
            End Try

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

        'MessageBox.Show(ThemeProperties.themeSheetEngineRuntimeVersion.ToString)
        If ThemeEngine.UseFullTE1DotXCompatibilityMode = False Then
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
                Select Case ThemeProperties.themeSheetEngineRuntimeVersion.CompareTo(Version.Parse("1.03"))
                    Case 0 ' If the theme wants to use TE1.03, apply as usual.
                        TE2DotXLoader.AssignControlProperties(False)
                    Case 1 ' If the theme wants to use a newer version than TE1.03, apply as usual.
                        TE2DotXLoader.AssignControlProperties(False)
                    Case -1
                        ' If the theme doesn't support TE1.03, apply defaults.
                        ' Default button colors.
                        ThemeProperties.colorButtonBackColor = GetDefaultColor("Button", "BackColor")
                        ThemeProperties.colorButtonForeColor = GetDefaultColor("Button", "ForeColor")
                        ThemeProperties.flatstyleButtonFlatStyle = FlatStyle.Standard
                        ThemeProperties.flatappearanceButtonBorderColor = Nothing
                        ThemeProperties.flatappearanceButtonMouseDownBackColor = Nothing
                        ThemeProperties.flatappearanceButtonMouseOverBackColor = Nothing

                        ' Default TableLayoutPanel colors.
                        ThemeProperties.colorTableLayoutPanelBackColor = GetDefaultColor("TableLayoutPanel", "BackColor")
                        ThemeProperties.colorTableLayoutPanelForeColor = GetDefaultColor("TableLayoutPanel", "ForeColor")

                        ' Default TabPage colors.
                        ThemeProperties.colorTabPageBackColor = GetDefaultColor("TabPage", "BackColor")
                        ThemeProperties.colorTabPageForeColor = GetDefaultColor("TabPage", "ForeColor")

                        ' Default GroupBox colors.
                        ThemeProperties.colorGroupBoxBackColor = GetDefaultColor("GroupBox", "BackColor")
                        ThemeProperties.colorGroupBoxForeColor = GetDefaultColor("GroupBox", "ForeColor")

                        ' Default Label colors.
                        ThemeProperties.colorLabelBackColor = GetDefaultColor("Label", "BackColor")
                        ThemeProperties.colorLabelForeColor = GetDefaultColor("Label", "ForeColor")

                        ' Default Textbox colors.
                        ThemeProperties.colorTextboxBackColor = GetDefaultColor("TextBox", "BackColor")
                        ThemeProperties.colorTextboxForeColor = GetDefaultColor("TextBox", "ForeColor")

                        ' Default RadioButton colors.
                        ThemeProperties.colorRadioButtonBackColor = GetDefaultColor("RadioButton", "BackColor")
                        ThemeProperties.colorRadioButtonForeColor = GetDefaultColor("RadioButton", "ForeColor")

                        ' Default Checkbox colors.
                        ThemeProperties.colorCheckBoxBackColor = GetDefaultColor("CheckBox", "BackColor")
                        ThemeProperties.colorCheckBoxForeColor = GetDefaultColor("CheckBox", "ForeColor")

                        ' Default Dropdown box/ComboBox colors.
                        ThemeProperties.colorDropdownBackColor = GetDefaultColor("Dropdown", "BackColor")
                        ThemeProperties.colorDropdownForeColor = GetDefaultColor("Dropdown", "ForeColor")

                        ' Default LinkLabel colors.
                        ThemeProperties.colorLinkLabelBackColor = GetDefaultColor("LinkLabel", "BackColor")
                        ThemeProperties.colorLinkLabelForeColor = GetDefaultColor("LinkLabel", "ForeColor")
                        ThemeProperties.colorLinkLabelLinkColor = GetDefaultColor("LinkLabel", "LinkColor")
                        ThemeProperties.colorLinkLabelActiveLinkColor = GetDefaultColor("LinkLabel", "ActiveLinkColor")

                        ' Default Panel colors.
                        ThemeProperties.colorPanelBackColor = GetDefaultColor("Panel", "BackColor")
                        ThemeProperties.colorPanelForeColor = GetDefaultColor("Panel", "ForeColor")

                        ' Default About window banner.
                        ThemeProperties.bannerStyle = My.Resources.UXL_Launcher_Banner

                        'Default FlowLayoutPanel colors.
                        ThemeProperties.colorFlowLayoutPanelBackColor = GetDefaultColor("FlowLayoutPanel", "BackColor")
                        ThemeProperties.colorFlowLayoutPanelForeColor = GetDefaultColor("FlowLayoutPanel", "ForeColor")

                        ' Default statusbar colors.
                        Select Case Version.Parse("1.03").CompareTo(ThemeProperties.themeSheetEngineRuntimeVersion)
                            Case 0 ' If the version is 1.03, use the new default of Nothing for statusbar backcolor.
                                ThemeProperties.colorStatusBarBackColor = Nothing
                            Case 1 ' If the version is newer than 1.03, also use Nothing.
                                ThemeProperties.colorStatusBarBackColor = Nothing
                            Case -1 ' If the version is older than 1.03, use the original default.
                                ThemeProperties.colorStatusBarBackColor = GetDefaultColor("StatusBar", "BackColor")
                        End Select

                        ' Default statuslabel colors and properties.
                        ThemeProperties.colorStatusLabelBackColor = GetDefaultColor("StatusLabel", "BackColor")
                        ThemeProperties.colorStatusLabelForeColor = GetDefaultColor("StatusLabel", "ForeColor")
                        ThemeProperties.propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.None
                        ThemeProperties.propertyStatusLabelBorderStyle = Border3DStyle.Flat
                End Select

            Else
                ' Get the theme colors for this form since it's named "aaformMainWindow".
                TE2DotXLoader.AssignControlProperties(False)
            End If
#End Region

        End If

        ' Now that we're done figuring out what the properties are,
        ' we can put the colors on the controls.
        ' At this point, the code will go back to ThemeEngine.LoadTheme,
        ' so applying colors will have to be done after the comment there
        ' saying that colors can be applied.

    End Sub

    Private Shared Function GetDefaultColor(ControlName As String, ControlProperty As String) As Color
        ' This will use the GetDefaultValueVersionVariant in the TE2DotXLoader to get
        ' default colors more easily.
        Return ColorTranslator.FromHtml(TE2DotXLoader.GetDefaultValue(ControlName, ControlProperty))
    End Function
End Class
