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



Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Xml
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Public Class ThemeEngine

    ' This file tells the theme engine what to color things. Theme engine is based on this Stack Overflow question: http://stackoverflow.com/q/199521
#Region "Set Theme via PortableThemeEngine."

    Public Shared Sub LoadThemeFromXML(ThemeInput As String, FormToApplyTo As Form, Optional FormToApplyToDOTcomponents As IContainer = Nothing, Optional ThemeName As String = "(Name not available)")
        'Dim themesDir As String = Directory.GetCurrentDirectory & "\Themes\"

        ThemeProperties.themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

        ' Try to load the XML file that's passed to this sub.
        ' Custom themes and builtin themes specified by name
        ' are loaded with SelectTheme().
        Try
            ThemeProperties.themeSheet.LoadXml(ThemeInput)
        Catch ex As XmlException
            ThemeProperties.themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
        End Try

        TE2DotXLoader.CheckEngineRuntimeVersionCompatibility(FormToApplyTo)

        ' Now that we're done figuring out what the properties are,
        ' we can put the colors on the controls.
        'MessageBox.Show("Back to themeenginemain. Theme colors can be applied now.")

        ApplyTheme(ThemeName, FormToApplyTo, FormToApplyToDOTcomponents)
    End Sub

    Friend Shared Sub ApplyTheme(ThemeName As String, FormToApplyTo As Form, FormToApplyToDOTcomponents As IContainer)

#Region "Set colors for controls."

        '        ' Look at all the controls in the form passed to the theme engine
        '        ' and change their theme.
        '        ' Code based on this VBForums post:
        '        ' http://www.vbforums.com/showthread.php?387308-Visit-Every-Control-on-a-Form-(includes-nested-controls-no-recursion)

        ' Placeholder form-applying code that's not ready yet.
        '        'formToApplyTo.BackColor = colorFlowLayoutPanelBackColor
        '        'formToApplyTo.ForeColor = colorFlowLayoutPanelForeColor


#Region "Now apply colors to controls in each form passed to the theme engine."
        Dim ctrl As Control = FormToApplyTo.GetNextControl(FormToApplyTo, True)
        Do Until ctrl Is Nothing
            'MessageBox.Show(ctrl.Name.ToString)

            If TypeOf ctrl Is GroupBox Then
                ' If the control is a groupbox, theme it as a groupbox.
                ctrl.BackColor = ThemeProperties.colorGroupBoxBackColor
                ctrl.ForeColor = ThemeProperties.colorGroupBoxForeColor

                'ElseIf TypeOf ctrl Is SplitContainer Then
                '    ' Split containers aren't yet fully supported and this is just a placeholder.
                '    ctrl.BackColor = colorFlowLayoutPanelBackColor
                '    ctrl.ForeColor = colorFlowLayoutPanelForeColor
                '    ' For split containers, we have to go through the controls inside
                '    ' them to change their colors.
                '    ctrl = ctrl.GetNextControl(ctrl, True)



            ElseIf TypeOf ctrl Is Button Then
                ' If the control is a button, theme it as a button.
                ' We have to define a button locally since "FlatStyle"
                ' isn't something that Control types have by default.
                Dim button As Button = CType(ctrl, Button)
                ' Set button BackColor (background color).
                button.BackColor = ThemeProperties.colorButtonBackColor
                ' Set button ForeColor (text color).
                button.ForeColor = ThemeProperties.colorButtonForeColor
                ' Set button style, whether that be flat, "Standard", or another
                ' supported style.
                button.FlatStyle = ThemeProperties.flatstyleButtonFlatStyle

                ' Set button flat appearance border color if flatstyleButtonFlatStyle = Flat.
                ' Note that this can be any valid HTML or system color, including "Nothing"
                ' ("Nothing" is the default value based on my testing).
                ' Using "Transparent" causes a System.NotSupportedException
                ' exception, so add a try...catch block and explain in the debug output.
                ' Actually, we're using an If statement to make sure it's not Transparent,
                ' but we're also keeping the Try...Catch block just in case there's
                ' another color that's not supported.
                Try
                    ' If the button border color is not Transparent, set it.
                    ' This avoids hitting the NotSupportedException,
                    ' but it's still staying there just in case something
                    ' else isn't a supported color.
                    If Not ThemeProperties.flatappearanceButtonBorderColor = Color.Transparent Then
                        button.FlatAppearance.BorderColor = ThemeProperties.flatappearanceButtonBorderColor
                    Else
                        ' Set the border color to the default.
                        ' If it's not set, it just uses the current
                        ' color, and that could be confusing to theme
                        ' designers. Resetting to Nothing is only
                        ' done if the theme supports TE1.02 or greater.
                        If ThemeProperties.themeSheetEngineRuntimeVersion >= Version.Parse("1.02") Then
                            button.FlatAppearance.BorderColor = Nothing
                        End If
                        themeSettingsInvalidMessage("System.NotSupportedException", "Buttons don't support a FlatAppearance" &
                                                    " BorderColor of Transparent.")
                    End If
                Catch ex As System.NotSupportedException
                    ' If the engine runtime version element in the theme is
                    ' set to 1.02 or greater, also set bordercolor
                    ' to "Nothing".

                    ' This is being done in an exception, so it should
                    ' work just fine in regular usage when things work.
                    If ThemeProperties.themeSheetEngineRuntimeVersion >= Version.Parse("1.02") Then
                        button.FlatAppearance.BorderColor = Nothing
                    End If
                    themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
                End Try

                ' Now change the color for when the mouse clicks down
                ' on a button and the flat appearance is set to flat.
                button.FlatAppearance.MouseDownBackColor = ThemeProperties.flatappearanceButtonMouseDownBackColor

                ' Change the color for when the mouse goes over
                ' a button and the flat appearance is set to flat.
                button.FlatAppearance.MouseOverBackColor = ThemeProperties.flatappearanceButtonMouseOverBackColor

            ElseIf TypeOf ctrl Is ComboBox Then

                Try ' Try to apply the dropdown backcolor.
                    ctrl.BackColor = ThemeProperties.colorDropdownBackColor
                Catch ex As ArgumentException
                    ' Now, make sure the background isn't transparent.
                    ' Dropdown boxes/comboboxes don't support transparent backgrounds.
                    ctrl.BackColor = Color.FromKnownColor(KnownColor.Window)
                End Try
                ' Now do the forecolor.
                ctrl.ForeColor = ThemeProperties.colorDropdownForeColor

            ElseIf TypeOf ctrl Is CheckBox Then
                ' If the control is a checkbox, theme it as such.
                ' CheckBox BackColor.
                ctrl.BackColor = ThemeProperties.colorCheckBoxBackColor
                ' CheckBox ForeColor.
                ctrl.ForeColor = ThemeProperties.colorCheckBoxForeColor

            ElseIf TypeOf ctrl Is FlowLayoutPanel Then
                ' If the control is a flowlayoutpanel, theme it as such.
                ' FlowLayoutPanel BackColor.
                ctrl.BackColor = ThemeProperties.colorFlowLayoutPanelBackColor
                ' FlowLayoutPanel ForeColor.
                ctrl.ForeColor = ThemeProperties.colorFlowLayoutPanelForeColor

            ElseIf TypeOf ctrl Is LinkLabel Then
                ' If the control is a LinkLabel, theme it appropriately.
                ' Define a linklabel locally since there are things it has
                ' that Control doesn't have by default.

                ' This needs to be above the "Label" entry as otherwise
                ' the colors won't apply to linklabels for the linkcolor
                ' and activelinkcolor properties.
                Dim linklabel As LinkLabel = CType(ctrl, LinkLabel)
                linklabel.BackColor = ThemeProperties.colorLinkLabelBackColor
                linklabel.ForeColor = ThemeProperties.colorLinkLabelForeColor
                linklabel.LinkColor = ThemeProperties.colorLinkLabelLinkColor
                linklabel.ActiveLinkColor = ThemeProperties.colorLinkLabelActiveLinkColor

            ElseIf TypeOf ctrl Is Label Then
                ' If the control is a label, theme it as a label.
                ' Set label BackColor (background color).
                ctrl.BackColor = ThemeProperties.colorLabelBackColor
                ' Set label ForeColor (text color).
                ctrl.ForeColor = ThemeProperties.colorLabelForeColor

            ElseIf TypeOf ctrl Is MenuStrip Then
                ' If the control is a menustrip (menu bar), theme it as such.

                ' Create a local variable to refer to the menustrip.
                Dim menustrip As MenuStrip = CType(ctrl, MenuStrip)
                menustrip.Renderer = ThemeProperties.toolstripProRenderer
                'MessageBox.Show(menustrip.Name.ToString)

                ' Set menustrip back color as apropriate.
                menustrip.BackColor = ThemeProperties.colorMenubarBackColor

                ' Look at each ToolStripMenuItem in the menustrip.
                For Each menuitem As ToolStripMenuItem In menustrip.Items
                    'MessageBox.Show(menuitem.Name.ToString)

                    If menuitem.Owner Is menustrip Then
                        ' If the owner of the menuitem is the menustrip,
                        ' theme it to match the menustrip.
                        'Debug.WriteLine(menuitem.Name)
                        menuitem.BackColor = ThemeProperties.colorMenubarBackColor
                        menuitem.ForeColor = ThemeProperties.colorMenuItemForeColor

                    End If
                Next

            ElseIf TypeOf ctrl Is TextBox Then
                ' If the control is a textbox, theme it as a textbox.
                ' Set textbox BackColor (background color).
                ' Make sure it's not a transparent color.
                If Not ThemeProperties.colorTextboxBackColor = Color.Transparent Then
                    ' Have a Try...Catch block to make sure we don't miss anything.
                    Try
                        ctrl.BackColor = ThemeProperties.colorTextboxBackColor
                    Catch ex As System.ArgumentException
                        ' Set the textbox to the default textbox backcolor.
                        ctrl.BackColor = ColorTranslator.FromHtml(ThemeProperties.defaultTextBoxBackColor)
                        ' Send an error to the theme engine output thing.
                        themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
                    End Try
                Else
                    ' If it's a transparent color, use the default property.
                    ctrl.BackColor = ColorTranslator.FromHtml(ThemeProperties.defaultTextBoxBackColor)
                    ' Output an error to the theme engine output code thing.
                    themeSettingsInvalidMessage("System.ArgumentException", "Textboxes do not support transparent background colors.")
                End If
                ' Set textbox ForeColor (text color).
                ctrl.ForeColor = ThemeProperties.colorTextboxForeColor

            ElseIf TypeOf ctrl Is RadioButton Then
                ' If the control is a radiobutton, theme it as such.
                ' RadioButton BackColor.
                ctrl.BackColor = ThemeProperties.colorRadioButtonBackColor
                ' RadioButton ForeColor.
                ctrl.ForeColor = ThemeProperties.colorRadioButtonForeColor

            ElseIf TypeOf ctrl Is StatusStrip Then
                ' Create a local variable and cast "ctrl" as a StatusStrip.
                Dim statusstrip As StatusStrip = CType(ctrl, StatusStrip)
                ' Apply the BackColor to the statusstrip variable created earlier.
                statusstrip.BackColor = ThemeProperties.colorStatusBarBackColor

                ' Look inside the controls that are in the statusstrip's items collection.
                For Each statusstripcontrol As ToolStripItem In statusstrip.Items
                    ' If an item is a toolstripstatuslabel, then theme it like one.
                    If TypeOf statusstripcontrol Is ToolStripStatusLabel Then
                        ' We have to create a local variable to refer to
                        ' the statuslabels, since otherwise we'd run into
                        ' an invalid cast exception.
                        Dim statuslabel As ToolStripStatusLabel = CType(statusstripcontrol, ToolStripStatusLabel)
                        ' Apply statuslabel BackColor.
                        statuslabel.BackColor = ThemeProperties.colorStatusLabelBackColor
                        ' Apply statuslabel ForeColor.
                        statuslabel.ForeColor = ThemeProperties.colorStatusLabelForeColor
                        ' Apply statuslabel BorderSides property.
                        statuslabel.BorderSides = ThemeProperties.propertyStatusLabelBorderSides
                        ' I was having some issues with setting the BorderStyle, so Try...Catch.
                        ' Ideally this wouldn't rely on a Try...Catch block, but I didn't
                        ' know of a better solution back then. Maybe there would be a better
                        ' solution for this.
                        Try
                            statuslabel.BorderStyle = ThemeProperties.propertyStatusLabelBorderStyle
                        Catch ex As System.ComponentModel.InvalidEnumArgumentException
                            ' It may be a good idea to output text talking about this exception if people run into it.
                            themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString)
                        End Try
                    End If
                    ' Move on to next control in the statusstrip.
                Next

            ElseIf TypeOf ctrl Is TabPage Then
                ' If the control is a tabpage, theme it as such.
                ' TabPage BackColor.
                ctrl.BackColor = ThemeProperties.colorTabPageBackColor
                ' TabPage ForeColor.
                ctrl.ForeColor = ThemeProperties.colorTabPageForeColor

            ElseIf TypeOf ctrl Is TableLayoutPanel Then
                ' If the control is a tablelayoutpanel, theme it as such.
                ' TableLayoutPanel BackColor.
                ctrl.BackColor = ThemeProperties.colorTableLayoutPanelBackColor
                ' TableLayoutPanel ForeColor.
                ctrl.ForeColor = ThemeProperties.colorTableLayoutPanelForeColor

                ' If the theme doesn't want to apply to the table layout panel
                ' in the About window About tab, apply the tab page back color
                ' and forecolor instead.
                If ctrl.Name = "tableLayoutPanelAboutAppTab" AndAlso ThemeProperties.useTableLayoutPanelColorInsideAboutAppTab = False Then
                    ctrl.BackColor = ThemeProperties.colorTabPageBackColor
                    ctrl.ForeColor = ThemeProperties.colorTabPageForeColor
                End If

            ElseIf TypeOf ctrl Is Panel Then
                ' Apply color to panels.
                ctrl.BackColor = ThemeProperties.colorPanelBackColor
                ctrl.ForeColor = ThemeProperties.colorPanelForeColor

            ElseIf TypeOf ctrl Is PictureBox AndAlso ctrl.Name = "pictureboxUXLBanner" Then
                ' Apply dark/light banners in the About window if the theme
                ' wants to.
                ' Create a local PictureBox control since "Image" isn't a thing in
                ' "Control" by default.
                Dim picturebox As PictureBox = CType(ctrl, PictureBox)
                picturebox.Image = ThemeProperties.bannerStyle


            End If ' End of If statement for checking to see what each control's type is.

            ' Get the next control in the tab order.
            ctrl = FormToApplyTo.GetNextControl(ctrl, True)
        Loop
#End Region

        ' This code works when it's in a form, but Me.components.Components
        ' is private, so this may be another thing to pass along in addition to forms.
        ' Make sure the components exist, as they're not required to be passed.
        If FormToApplyToDOTcomponents IsNot Nothing Then
            For Each component As Component In FormToApplyToDOTcomponents.Components
                If TypeOf component Is ContextMenuStrip Then
                    Dim contextmenustrip As ContextMenuStrip = CType(component, ContextMenuStrip)
                    contextmenustrip.Renderer = libportablethemeengine.ThemeProperties.toolstripProRenderer
                End If
            Next
        End If

        ' To allow theming components on multiple forms, something like this
        ' would need to be done:
        '
        ' Inside sub UXL_Launcher.aaformMainWindow.Load:
        '    Private Sub Me.Load()
        '       ...
        '       UXLLauncher_ThemeEngine.RunThemeEngine(Me, Me.components)
        '       forceOptionsWindowTab.RunThemeEngine()
        '       ...
        '    End Sub
        '
        ' Inside the Options window load sub:
        '     Friend Sub RunThemeEngine()
        '           UXLLauncher_ThemeEngine.RunThemeEngine(Me, Me.components)
        '     End Sub
        '
        ' Inside the UXLLauncher_ThemeEngine class:
        '     Friend Shared Sub RunThemeEngine(formToApplyTo As Form, componentsToApplyTo As ComponentModel.IContainer)
        '           libportablethemeengine.themeenginemain.LoadTheme("C:\Users\drewn\Documents\0GitHub\UXL-Launcher\UXL-Launcher\VB Code-behind\Themes\TE2DotX_TenDarkTheme_XML.xml", formToApplyTo, componentsToApplyTo)
        '     End Sub
        '


        ' Set color for the toolstrip pro renderer.
        ThemeProperties.toolstripProRenderer.BackColor = ThemeProperties.colorMenubarBackColor
        ThemeProperties.toolstripProRenderer.ForeColor = ThemeProperties.colorMenuItemForeColor
        ThemeProperties.toolstripProRenderer.DropdownBackColor = ThemeProperties.colorMenuItemBackColor
        ThemeProperties.toolstripProRenderer.ImageMarginGradientStartColor = ThemeProperties.colorMenuItemImageMarginGradientStartColor
        ThemeProperties.toolstripProRenderer.ImageMarginGradientEndColor = ThemeProperties.colorMenuItemImageMarginGradientEndColor
        ThemeProperties.toolstripProRenderer.TextHighlightColor = Color.FromKnownColor(KnownColor.ControlText)

#End Region
    End Sub ' End of ApplyTheme Sub.
#End Region

#Region "Start the theme engine and apply the user's theme."
    Public Shared Sub SelectTheme(ThemeName As String, FormToApplyTo As Form, Optional FormToApplyToDOTcomponents As IContainer = Nothing, Optional CustomThemePath As String = "")

        ' TODO: 
        ' Start Done
        ' ~~Add a sub to allow loading in an XML file from the calling app's My.Resources~~
        ' (the LoadThemeFromXML() sub can do this, just that the calling app has to pass the files itself),
        ' End Done
        ' another sub to allow loading in from a file on the hard drive or over the Internet
        ' (would have to be done with something like a LoadThemeFromThemesDir() sub, except it may be
        ' useful to allow the calling app to specify a folder to look for themes in and a theme
        ' filename; for example, a "\Themes" dir in the app's installation directory
        ' that has theme files that are loaded into a list the user can select from
        ' in the app's Options window; this "\Themes" dir should be set by the calling app
        ' as it could allow themes to be used from near the install dir, or from an AppData folder;
        ' this sub could be called "LoadThemeFromThemesDir()" or something, with the args being
        ' LoadThemeFromThemesDir(ThemeFilename As String, ThemesDir As String, FormToApplyTo As Form,
        ' FormToApplyToDOTcomponents As IContainer)),
        ' Start Done
        ' and ~~make this sub select from the built-in themes based on the theme name
        ' passed into it, just like UXL Launcher Theme Engine currently does~~ (already done).
        ' ~~Remember to pay attention to whether the calling app wants to allow custom themes or not~~ (already
        ' done as well).
        ' End Done
        ' TODO eventually since it could be more difficult:
        ' The custom themes folder idea above might be more difficult, so it would be a good idea to 
        ' maybe wait until PortableThemeEngine is at feature parity with the UXL Launcher Theme Engine.


        '        ' This documentation page helped a lot for getting this working:
        '        ' https://msdn.microsoft.com/en-us/library/system.xml.xmldocument.loadxml(v=vs.110).aspx

        ' Check if the calling app wants to match the system theme first.
        If matchWindows10ThemeSettings = True Then
            ' If the Windows 10 theme is Light, use Default.
            Select Case SystemThemeSettings.GetWindowsThemeSettings()
                Case "Light"
                    ThemeProperties.themeSheet.LoadXml(My.Resources.DefaultTheme_XML)

                ' Otherwise, load the default dark theme.
                Case "Dark"
                    ' Check if the theme specified in My.Settings.defaultDarkTheme is in the
                    ' list of available dark themes.
                    If My.Resources.darkthemesList.Contains(DefaultDarkTheme.ToString) AndAlso My.Resources.ResourceManager.GetString(DefaultDarkTheme & "Theme_XML") IsNot Nothing Then
                        ThemeProperties.themeSheet.LoadXml(My.Resources.ResourceManager.GetString(DefaultDarkTheme & "Theme_XML"))
                        ' Reset default dark theme back to ProDark in case an application wanted to override it but might not
                        ' in the future in the same session.
                        DefaultDarkTheme = "ProDark"
                    Else
                        ' If we can't find the specified theme, we'll just use ProDark,
                        ' which is the new default in version 2.1.
                        ThemeProperties.themeSheet.LoadXml(My.Resources.ProDarkTheme_XML)
                    End If
            End Select

            ' If the calling app doesn't want to match the Windows 10 theme,
            ' just move on.
        Else

            ' First, remove the double-quotes from the custom theme path.
            ' This was moved up here so that it can be referred to in other
            ' parts of this sub.
            Dim tempRemoveQuotesInCustomThemePath As String = CustomThemePath.Replace("""", "")

            Try ' Make sure the theme engine doesn't break.

                ' Add theme engine namespace.
                ThemeProperties.themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")


                ' Then we see if the userChosenTheme setting contains the word "Theme."
                ' If it does not, we just add "Theme_XML" to the end of the string.
                If Not ThemeName.EndsWith("Theme") And Not ThemeName = ("(Custom)") Then
                    ThemeProperties.themeSheet.LoadXml(My.Resources.ResourceManager.GetString(ThemeName & "Theme_XML"))
                    ' However, if it does, then we only add "_XML" to the string.
                ElseIf ThemeName.EndsWith("Theme") Then
                    ThemeProperties.themeSheet.LoadXml(My.Resources.ResourceManager.GetString(ThemeName & "_XML"))
                    ' If the user has a custom theme enabled, use that instead.
                ElseIf ThemeName = "(Custom)" Then
                    ' Make sure the theme path and file exists and custom themes are allowed
                    ' to be used.
                    If File.Exists(tempRemoveQuotesInCustomThemePath) And AllowCustomThemes = True Then
                        ThemeProperties.themeSheet.Load(tempRemoveQuotesInCustomThemePath)
                        ' Otherwise, just set the theme to use to the Default theme to make sure everything works.
                        ' Then we output that the custom theme file wasn't found if that's the problem, or if custom
                        ' themes are not allowed to be used.
                    ElseIf Not File.Exists(tempRemoveQuotesInCustomThemePath) Then
                        ThemeProperties.themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
                        ' If the theme engine output debug setting is enabled, output an error
                        ' in the Immediate Window or debug textbox if the custom theme file cannot be found.
                        themeSettingsInvalidMessage("UXLLauncher.ThemeEngine.FileNotFound_CustomTheme", "Couldn't find custom theme file.")
                    ElseIf AllowCustomThemes = False Then
                        ' If custom themes are not allowed to be used, use the Default theme and tell the
                        ' user in the debug output that they're not allowed.
                        ThemeProperties.themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
                        themeSettingsInvalidMessage("UXLLauncher.ThemeEngine.CustomThemesNotAllowed", "Custom themes are not allowed to be used." & vbCrLf &
                                                        "Please contact your administrator for further assistance.")
                    End If
                Else
                    ' If none of the above conditions apply, just load the Default theme.
                    ThemeProperties.themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
                End If
            Catch ex As System.ArgumentNullException
                ' If the theme name in My.Settings.userChosenTheme does not match one of the theme files
                ' included in My.Resources, the ArgumentNullException will be fired and the default theme
                ' will be used instead temporarily. The developer, user, or theme designer will be notified
                ' about this error in the Immediate Window.
                themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString, ThemeName, CustomThemePath)
                ThemeProperties.themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
            Catch ex As XmlException
                ' If there's an XmlException (which can occur if the selected theme has no
                ' root element), tell the user, developer, or theme designer
                ' and use the default theme.
                ThemeProperties.themeSheet.LoadXml(My.Resources.DefaultTheme_XML)
                themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString, ThemeName, CustomThemePath)
            Catch ex As System.UnauthorizedAccessException
                ' Also catch UnauthorizedAccessException.
                ' If this exception occurs, it may be because
                ' a file was accessed that's not allowed to be accessed,
                ' such as a file in the Windows directory.
                themeSettingsInvalidMessage(ex.GetType.ToString, ex.Message, ex.ToString, ThemeName, CustomThemePath)
            End Try

            ' After this is all done, we then write the settingsThemeName string and the actual XML document
            ' containing the theme to the Debugger/Immediate Window, if theme output is enabled. Note that
            ' this happens BEFORE any theme colors are applied.
            If ShowThemeEngineDebuggingOutput = True Then
                Debug.WriteLine("")
                Debug.WriteLine("")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name in config file:")
                Debug.WriteLine(ThemeName)
                Debug.WriteLine("")
                If ThemeName = "(Custom)" And File.Exists(tempRemoveQuotesInCustomThemePath) Then
                    ' Also output the configured custom theme's file path if the user has a custom theme and it exists.
                    Debug.WriteLine("")
                    Debug.WriteLine("Custom theme path:")
                    Debug.WriteLine(tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("Theme XML file:")
                Debug.WriteLine(ThemeProperties.themeSheet.OuterXml)

                ' Also output theme info for testing purposes.
                ' This will be used in the Options window soon.
                Debug.WriteLine("Output theme info via GetThemeFileInfo function:")
                ' First check that the theme to use is a custom theme.
                ' If it is, specify that it is.
                If ThemeName = "(Custom)" Then
                    Debug.WriteLine(GetThemeFileInfo(ThemeName, True, tempRemoveQuotesInCustomThemePath))
                Else
                    ' Otherwise, just write it out.
                    Debug.WriteLine(GetThemeFileInfo(ThemeName))
                End If


            End If
        End If
        ' Apply the theme after figuring out engine compatibility.
        TE2DotXLoader.CheckEngineRuntimeVersionCompatibility(FormToApplyTo)
        ApplyTheme(ThemeName, FormToApplyTo, FormToApplyToDOTcomponents)
    End Sub
#End Region

#Region "Theme Settings Invalid Message output code."
    Private Shared Sub themeSettingsInvalidMessage(exceptionType As String, Optional exceptionMessage As String = "(Not provided)", Optional fullException As String = "(Not provided)", Optional themeName As String = "(Not provided)", Optional customThemePath As String = "Not provided", Optional ForceOutput As Boolean = False)
        ' Tell the user, developer, or theme designer that there's a problem with the
        ' chosen theme or custom theme. This can range from not having a root element
        ' in the chosen theme to typing the theme incorrectly in the config file.

        ' This sub accepts parameters for choosing which exceptionType message to show.


        If ShowThemeEngineDebuggingOutput = True Or ForceOutput = True Then
            ' First, identify this block of text as part of the theme engine
            ' and that it's output for invalid theme settings.

            ' Second, remove the double-quotes from the custom theme path.
            ' This was copied here so that it can be refered to in other
            ' parts of this sub.
            Dim tempRemoveQuotesInCustomThemePath As String = customThemePath.Replace("""", "")

            Debug.WriteLine("")
            Debug.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////")
            Debug.WriteLine("PortableThemeEngine Version " & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString)
            Debug.WriteLine("Invalid Theme Settings Message Handler")
            Debug.WriteLine("--------------------------------------")
            Debug.WriteLine("Begin theme engine output:")
            Debug.WriteLine("")
            ' The following lines are commented out because I was having an issue with no output showing up.
            ' It turned out that this sub was still being called with "default" as its parameter instead of "(None)".
            'Debug.WriteLine("Parameters for this message handler:")
            'Debug.WriteLine("Exception type: " & exceptionType)
            'Debug.WriteLine("Exception message: " & exceptionMessage)

            If exceptionType.ToString = "UXLLauncher.ThemeEngine.FileNotFound_CustomTheme" Then
                ' If the custom theme file cannot be found, output it to the Immediate Window.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The theme was temporarily reset to the Default theme because the custom theme" & vbCrLf &
                            "file specified for My.Settings.userCustomThemePath wasn't found. Please ensure that" & vbCrLf &
                            "the filename below exists in the listed path. Double quotation marks in the custom theme" & vbCrLf &
                            "path are not supported and are automatically removed at runtime.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "UXLLauncher.ThemeEngine.CustomThemesNotAllowed" Then
                ' If custom themes are not supported, output it to the Immediate Window.
                Dim appName As String = My.Application.Info.ProductName.ToString
                Dim appFileName As String = My.Application.Info.AssemblyName.ToString
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("Your administrator has disabled custom themes from being used in " & appName & "." & vbCrLf &
                                "This may be due to data protection policies put in place by your organization." & vbCrLf &
                                vbCrLf &
                                "If you believe you've received this message in error, you can try to modify the" & vbCrLf &
                                "configuration files for " & appName & " located in this folder:" & vbCrLf &
                                My.Application.Info.DirectoryPath & vbCrLf &
                                "In this folder, you'll find a file named """ & appFileName & ".exe.config"". First," & vbCrLf &
                                "make a backup copy of this file. Next, open this file in your favorite text editor such as Notepad++." & vbCrLf &
                                "You should find an XML element that has a name likely similar to ""allowCustomThemes"" within the ""userSettings"" element." & vbCrLf &
                                "Below that setting XML element, you'll want to change the ""value"" from ""False"" to ""True""." & vbCrLf &
                                "Afterward, restart " & appName & ".")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "PortableThemeEngine.TestException" Then
                ' If the theme name specified in the config file for My.Settings.userChosenTheme doesn't match
                ' a theme file in My.Resources, give a message for this problem.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("""And then I said, 'Oatmeal, are you crazy?'""")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.ArgumentNullException" Then
                ' If the theme name specified in the config file for My.Settings.userChosenTheme doesn't match
                ' a theme file in My.Resources, give a message for this problem.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The theme was temporarily reset to the Default theme because the" & vbCrLf &
                            "theme name specified for themeName doesn't" & vbCrLf &
                            "match any theme files in My.Resources." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.ArgumentException" Then
                ' If the theme name specified in the config file for My.Settings.userChosenTheme doesn't match
                ' a theme file in My.Resources, give a message for this problem.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The TextBox BackColor property doesn't support the specified color.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.Xml.XmlException" Then
                ' If the theme doesn't have a root element and the exception "XmlException" is triggered,
                ' say that the chosen theme has no root element.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The theme was temporarily reset to the Default theme because either the" & vbCrLf &
                            "chosen theme that themeName is set to or the" & vbCrLf &
                            "custom theme specified in My.Settings.userCustomThemePath" & vbCrLf &
                            "doesn't have a root element or otherwise has invalid XML." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.ComponentModel.InvalidEnumArgumentException" Then
                ' If the theme's StatusLabel BorderStyle property can't be found, there's a weird
                ' exception for it, so that's what this is for.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The StatusLabel BorderStyle property could not be found" & vbCrLf &
                            "in the chosen theme file/custom theme listed below," & vbCrLf &
                            "but this shouldn't cause any problems." & vbCrLf &
                            "Please refer to the exception message above for more details.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.UnauthorizedAccessException" Then
                ' If the exception type is an unauthorized access exception, let the user know.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("Access to the custom theme file was denied.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            ElseIf exceptionType.ToString = "System.NotSupportedException" Then
                ' If the theme's property for Button FlatAppearance Border Color isn't supported by
                ' the Windows Forms Button control, then give a message for this problem.
                Debug.WriteLine("Exception: " & exceptionType)
                Debug.WriteLine("Exception message: " & exceptionMessage)
                Debug.WriteLine("")
                Debug.WriteLine("The Button FlatAppearance BorderColor property doesn't support the specified color.")
                Debug.WriteLine("")
                Debug.WriteLine("Theme name:" & vbCrLf & themeName)
                ' Only show custom theme path if the chosen theme is "(Custom)"
                If themeName = "(Custom)" Then
                    Debug.WriteLine("Custom theme path:" & vbCrLf & tempRemoveQuotesInCustomThemePath)
                End If
                Debug.WriteLine("")
                Debug.WriteLine("Full exception: " & vbCrLf & fullException)
                Debug.WriteLine("")

            Else
                ' If there's an input that's not listed here, say that it's not supported.
                Debug.WriteLine("Input not supported: " & exceptionType)
            End If

            ' End theme engine invalid settings output.
            Debug.WriteLine("")
            Debug.WriteLine("End theme engine output.")
            Debug.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////////////////")
        End If
    End Sub
#End Region

    Public Shared Sub OutputThemeEngineRuntimeVersionForDebugging()
        ' Show theme engine version that the theme wants to use in the Immediate Window
        ' if the proper setting is enabled.
        ' This can be used for debugging.
        If ShowThemeEngineDebuggingOutput = True Then
            Debug.WriteLine("")
            Debug.WriteLine("ThemeEngine RuntimeVersion string:")
            Debug.WriteLine(ThemeProperties.themeSheetEngineRuntimeVersion.ToString)
        End If
    End Sub

#Region "Get theme file info."

    ' TODO: Get this function working again for apps that may want to use it,
    ' but make it so that the calling app can choose whether to get one thing,
    ' or to get everything. Getting everything is done by not specifying
    ' a node to get info from.

    '    ' This code is based on this issue in the
    '    ' GitHub repository:
    '    ' https://github.com/DrewNaylor/UXL-Launcher/issues/113

    Public Shared Function GetThemeFileInfo(ThemeFile As String, Optional IsCustomTheme As Boolean = False, Optional ThemeFileLocation As String = "") As String
        ' This function takes the themeFile as input along with whether or not the themeFile
        ' is a custom theme and returns information from the file including the theme's
        ' title, author, description, and theme file version in one string for easy
        ' display such as in the Options window.
#Region "Objects to store theme info."
        Dim LocalThemeInfoFileReader As XmlDocument = New XmlDocument()
        ' Theme file information properties.
        Dim LocalThemeInfoTitle As String = "(Not provided)"
        Dim LocalThemeInfoAuthor As String = "(Not provided)"
        Dim LocalThemeInfoDescription As String = "(Not provided)"
        Dim LocalThemeInfoVersion As String = "(Not provided)"
        Dim LocalThemeInfoUseThemeEngineVersion As Version = Version.Parse("1.01")
        ' The completed string for use wherever it's needed.
        Dim LocalThemeInfoDetailsComplete As String = "Please wait..."
        ' Whether to clear the theme info details after getting them.
        ' This is used to determine if extra stuff should be shown along with it.
        Dim LocalClearThemeInfoBeforeAssigningFullString As Boolean = True
        ' Theme namespace manager.
        Dim LocalThemeInfoNamespaceManager As New XmlNamespaceManager(LocalThemeInfoFileReader.NameTable)
        LocalThemeInfoNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")
#End Region

#Region "Loading theme files."
        If IsCustomTheme = True Then
            ' Code to run if the selected theme is a custom theme.
            ' First, make sure the theme file exists.
            ' Make sure the theme path and file exists and custom themes are allowed
            ' to be used.
            If File.Exists(ThemeFileLocation) And AllowCustomThemes = True Then
                ' Load the custom theme file into the file reader.
                ' This behavior changed from TE1.x to TE2.x,
                ' so applications using TE2.x can just load in the
                ' theme file location into the string.
                Try
                    LocalThemeInfoFileReader.Load(ThemeFileLocation)
                Catch ex As Xml.XmlException
                    ' Catch XmlException.
                    ' This can be caused by using the "None" theme that
                    ' has purposefully invalid XML just to make sure there
                    ' aren't any problems in the theme engine that might
                    ' slip by when using valid XML.
                End Try
            ElseIf Not File.Exists(ThemeFileLocation) And AllowCustomThemes = True Then
                ' If the file doesn't exist but custom themes are allowed,
                ' say that the Default theme will be used temporarily.
                LocalThemeInfoDetailsComplete = "We couldn't find the custom theme file previously located below, so the Default theme will be used temporarily." & vbCrLf &
                                        ThemeFileLocation
                Return LocalThemeInfoDetailsComplete
            ElseIf AllowCustomThemes = False Then
                ' If custom themes aren't allowed, let the user know.
                LocalThemeInfoDetailsComplete = "Your administrator has disabled custom themes from being used in UXL Launcher, so the Default theme will be used temporarily." &
                                       " This may be due to data protection policies put in place by your organization." &
                                       " If you believe you've received this message in error and you're using UXL Launcher, you can either re-install it, or try to modify the" &
                                       " configuration files for UXL Launcher located in this folder:" & vbCrLf &
                                       My.Application.Info.DirectoryPath & vbCrLf & vbCrLf &
                                       "In this folder, you'll find a file named ""UXL-Launcher.exe.config"". First," &
                                       " make a backup copy of this file. Next, open this file in your favorite text editor such as Notepad++." &
                                       " You should find an XML element that has a name of ""allowCustomThemes"" within the ""userSettings"" element." &
                                       " Below that setting XML element, you'll want to change the ""value"" from ""False"" to ""True""." &
                                       " Afterward, restart UXL Launcher." & vbCrLf &
                                       "If you're using a different application, the steps above may work, or you may have to do something else."
                Return LocalThemeInfoDetailsComplete
            End If
        Else
            ' If the selected theme is a built-in theme, just load the file.
            ' Catch an exception if the root element is missing.
            ' This can be caused if the user tries to type in a specific name
            ' into the theme list in the Options window that doesn't match a
            ' theme file exactly.
            ' Make sure it's not Nothing.
            If ThemeFile IsNot Nothing Then

                Try
                    If Not ThemeFile.EndsWith("Theme") Then
                        ' If the input ends with "Theme", append "_XML" to it.
                        LocalThemeInfoFileReader.LoadXml(My.Resources.ResourceManager.GetString(ThemeFile & "Theme_XML"))
                    ElseIf ThemeFile.EndsWith("Theme_XML") Then
                        ' If it ends with "Theme_XML", just use it.
                        LocalThemeInfoFileReader.LoadXml(My.Resources.ResourceManager.GetString(ThemeFile))
                    Else
                        ' If it doesn't end with "Theme" or "Theme_XML", append "Theme_XML" to it.
                        LocalThemeInfoFileReader.LoadXml(My.Resources.ResourceManager.GetString(ThemeFile & "_XML"))
                    End If
                Catch ex As System.Xml.XmlException
                Catch ex As ArgumentNullException
                    ' Catch ArgumentNullExceptions if there isn't anything there.
                    LocalThemeInfoFileReader.LoadXml(My.Resources.DefaultTheme_XML)
                    ' Say we're using the default theme info if so.
                    ' Be sure to have this shown in the full string.
                    LocalClearThemeInfoBeforeAssigningFullString = False
                    LocalThemeInfoDetailsComplete = "We're using the Default theme's info since we couldn't find the specified theme name:" & vbCrLf &
                        ThemeFile & vbCrLf & vbCrLf
                End Try
            Else
                ' If the theme file is Nothing/hasn't been set,
                ' output the default theme info and say the file
                ' hasn't been specified.
                LocalThemeInfoFileReader.LoadXml(My.Resources.DefaultTheme_XML)
                ' Be sure to have this shown in the full string.
                LocalClearThemeInfoBeforeAssigningFullString = False
                LocalThemeInfoDetailsComplete = "We're using the Default theme's info since we couldn't find the specified theme name:" & vbCrLf &
                        ThemeFile & vbCrLf & vbCrLf
            End If
        End If
#End Region

        ' Now that loading is done, get the theme info.
        ' This code was copy-pasted from above to make work
        ' a bit easier.
#Region "Pull info from file."
#Region "Pull Title theme element from XML."

        ' Only pull the title element from XML if it exists.
        If LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", LocalThemeInfoNamespaceManager) IsNot Nothing Then
            LocalThemeInfoTitle = LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", LocalThemeInfoNamespaceManager).InnerText
        Else
            LocalThemeInfoTitle = "(No title specified)"
        End If
#End Region

#Region "Pull Description theme element from XML."
        ' Only pull the description element from XML if it exists.
        If LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", LocalThemeInfoNamespaceManager) IsNot Nothing Then
            LocalThemeInfoDescription = LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", LocalThemeInfoNamespaceManager).InnerText
        Else
            LocalThemeInfoDescription = "(No description specified)"
        End If
#End Region

#Region "Pull Author theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", LocalThemeInfoNamespaceManager) IsNot Nothing Then
            LocalThemeInfoAuthor = LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", LocalThemeInfoNamespaceManager).InnerText
        Else
            LocalThemeInfoAuthor = "(No author specified)"
        End If
#End Region

#Region "Pull Version theme element from XML."
        ' Only pull the Author element from XML if it exists.
        If LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", LocalThemeInfoNamespaceManager) IsNot Nothing Then
            LocalThemeInfoVersion = LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/Version[1]", LocalThemeInfoNamespaceManager).InnerText
        Else
            LocalThemeInfoVersion = "(No version specified)"
        End If
#End Region

#Region "Pull UseThemeEngineVersion element from XML."
        ' Use the new TE2.x attribute if it exists and it's 2.0 or greater.
        Dim TE2xEngineRuntimeVersionNode As XmlNode = LocalThemeInfoFileReader.SelectSingleNode("/UXL_Launcher_Theme/ThemeEngine", LocalThemeInfoNamespaceManager)
        ' If the node exists, check the attributes.
        If TE2xEngineRuntimeVersionNode IsNot Nothing Then
            ' If the RuntimeVersion attribute exists, check what it has in it.
            If TE2xEngineRuntimeVersionNode.Attributes("RuntimeVersion") IsNot Nothing Then
                ' Make a temporary version variable to compare to what's in the file.
                ' Try...Catch to make sure nothing bad happens.
                Dim tempVer As Version
                Try
                    tempVer = Version.Parse(TE2xEngineRuntimeVersionNode.Attributes("RuntimeVersion").Value)
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
                    ' If it's invalid, consider it a 1.x theme.
                    tempVer = Version.Parse("1.01")
                End Try
                Select Case tempVer.CompareTo(Version.Parse("2.0"))
                    Case 0
                        ' If the theme file is 2.0-compatible, use 2.0.
                        LocalThemeInfoUseThemeEngineVersion = Version.Parse("2.0")
                    Case 1
                        ' If the theme file says to use a newer version, use it.
                        LocalThemeInfoUseThemeEngineVersion = tempVer
                    Case -1
                        ' If the theme says to use an older version, treat it as a 1.x theme instead and fall back to TE1.x mode.
                        LocalThemeInfoUseThemeEngineVersion = GetTE1DotXThemeEngineRuntimeVersion(LocalThemeInfoFileReader, LocalThemeInfoNamespaceManager)
                End Select
            Else
                ' If the attribute is Nothing, fall back to TE1.x mode.
                LocalThemeInfoUseThemeEngineVersion = GetTE1DotXThemeEngineRuntimeVersion(LocalThemeInfoFileReader, LocalThemeInfoNamespaceManager)
            End If
        Else
            ' If the ThemeEngine node is Nothing, fall back to TE1.x mode.
            LocalThemeInfoUseThemeEngineVersion = GetTE1DotXThemeEngineRuntimeVersion(LocalThemeInfoFileReader, LocalThemeInfoNamespaceManager)
        End If


#End Region
#End Region

#Region "Put together theme info into one string."
        ' Put each string together into one string to present to the user.
        ' Reset it to be empty if desired.
        If LocalClearThemeInfoBeforeAssigningFullString = True Then
            LocalThemeInfoDetailsComplete = String.Empty
        End If
        LocalThemeInfoDetailsComplete = LocalThemeInfoDetailsComplete & "Title: " & LocalThemeInfoTitle & vbCrLf &
                               "Description: " & LocalThemeInfoDescription & vbCrLf &
                               "Version: " & LocalThemeInfoVersion & vbCrLf &
                               "Author: " & LocalThemeInfoAuthor & vbCrLf &
                               "Uses ThemeEngine runtime version " & LocalThemeInfoUseThemeEngineVersion.ToString & "."
#End Region

        ' In case the theme supports a version of the theme engine that's newer than
        ' the theme engine version being used currently, issue a warning.
        Select Case LocalThemeInfoUseThemeEngineVersion.CompareTo(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version)
            Case 0 Or -1 ' Same version or lower version; do nothing.
            Case 1 ' If it's newer, we issue a warning.
                LocalThemeInfoDetailsComplete = LocalThemeInfoDetailsComplete & vbCrLf & vbCrLf &
                    "Warning: This theme supports PortableThemeEngine version " & LocalThemeInfoUseThemeEngineVersion.ToString & ", which is newer than the version" & vbCrLf &
                    "of the theme engine currenty in use (version " & System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString & ", to be specific)." & vbCrLf &
                    "There may be some issues, but the theme should work for the most part."
        End Select
        ' Show the user the completed string.
        Return LocalThemeInfoDetailsComplete
    End Function

    Private Shared Function GetTE1DotXThemeEngineRuntimeVersion(ThemeFile As XmlDocument, ThemeNamespaceManager As XmlNamespaceManager) As Version
        ' TE1.x UseThemeEngineVersion fallback function.
        ' Only pull the UseThemeEngineVersion element from XML if it exists.
        If ThemeFile.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", ThemeNamespaceManager) IsNot Nothing Then
            ' Make a temporary version variable to compare to what's in the file.
            ' Don't crash with invalid version numbers.
            Dim tempVer As Version
            Try
                tempVer = Version.Parse(ThemeFile.SelectSingleNode("/UXL_Launcher_Theme/UseThemeEngineVersion[1]", ThemeNamespaceManager).InnerText)
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
                ' If it's invalid, consider it a 1.x theme.
                Return Version.Parse("1.01")
            End Try
            Select Case tempVer.CompareTo(Version.Parse("1.01"))
                Case 0
                    ' If the theme file says to use 1.01, use 1.01.
                    Return Version.Parse("1.01")
                Case 1
                    ' If the theme file says to use a newer version, use it.
                    Return tempVer
                Case -1
                    ' If the theme says to use an older version, use 1.01 instead.
                    Return Version.Parse("1.01")
            End Select
        Else
            ' If the theme engine runtime version thing doesn't exist, use 1.01.
            Return Version.Parse("1.01")
        End If
        ' If we somehow get out here, return Nothing to know something is wrong.
        Return Nothing
    End Function
#End Region


#Region "Theme engine-related properties."

    ' Some properties to control various theme engine functions.
    ' Safe color validation uses regex to make sure the color
    ' that's being applied to a given control is a valid HTML color.
    ' If it's not a valid HTML color, it's looked up in the system colors
    ' list. Disabling safe color validation enables fast color validation,
    ' which relies on an exception handler to make sure colors are valid like TE1.x.
    ' See more details in TE2DotXLoader.GetThemeColor.
    Private Shared _themeengineUseSafeColorValidation As Boolean = True
    ' Enabling TE1.x full compatibility mode causes forms not named "aaformMainWindow"
    ' to not be themed if the theme file doesn't support TE1.03 or greater.
    ' Default colors will be applied to forms of other names.
    ' Other TE1.x-related features that UXL Launcher relied on will also be enabled,
    ' but as of April 14, 2020, this is the only one.
    ' This is to allow TE2.x to eventually replace TE1.x in UXL Launcher.
    ' Please don't enable this unless you absolutely have to.
    ' The default is loose compatibility mode.
    ' Loose compatibility mode will have theme colors
    ' applied to any forms passed into the TE1.x shim and is what's
    ' recommended for most applications.
    Private Shared _compatibilityUseFullTE1DotXCompatibilityMode As Boolean = False
    ' Determine whether theme engine output is shown in the Immediate Window.
    ' This can be set by the calling application.
    Private Shared _debugmodeShowThemeEngineOutput As Boolean = False
    ' Whether custom themes are allowed by the calling app.
    Private Shared _themeengineAllowCustomThemes As Boolean = True
    ' Whether the calling app wants to match the Windows 10 theme or not.
    Private Shared _matchWindows10ThemeSettings As Boolean = False
    ' Default dark theme when the calling app wants to match the Windows 10 theme settings.
    Private Shared _defaultDarkTheme As String = "ProDark"

    ' Safe color validation.
    Public Shared Property UseSafeColorValidation() As Boolean
        Get
            Return _themeengineUseSafeColorValidation
        End Get
        Set(value As Boolean)
            _themeengineUseSafeColorValidation = value
        End Set
    End Property

    ' Whether to use full or loose compatibility mode for the TE1.x shim.
    Public Shared Property UseFullTE1DotXCompatibilityMode() As Boolean
        Get
            Return _compatibilityUseFullTE1DotXCompatibilityMode
        End Get
        Set(value As Boolean)
            _compatibilityUseFullTE1DotXCompatibilityMode = value
        End Set
    End Property

    ' Determine whether theme engine output is shown in the Immediate Window.
    ' This can be set by the calling application.
    Public Shared Property ShowThemeEngineDebuggingOutput() As Boolean
        Get
            Return _debugmodeShowThemeEngineOutput
        End Get
        Set(value As Boolean)
            _debugmodeShowThemeEngineOutput = value
        End Set
    End Property

    ' Determine whether custom themes are allowed to be loaded.
    ' This is set by the calling app.
    Public Shared Property AllowCustomThemes() As Boolean
        Get
            Return _themeengineAllowCustomThemes
        End Get
        Set(value As Boolean)
            _themeengineAllowCustomThemes = value
        End Set
    End Property

    ' Determine whether the theme engine should match the Windows 10 theme.
    ' This is set by the calling app.
    Public Shared Property MatchWindows10ThemeSettings() As Boolean
        Get
            Return _matchWindows10ThemeSettings
        End Get
        Set(value As Boolean)
            _matchWindows10ThemeSettings = value
        End Set
    End Property

    ' Default dark theme.
    Public Shared Property DefaultDarkTheme() As String
        Get
            Return _defaultDarkTheme
        End Get
        Set(value As String)
            _defaultDarkTheme = value
        End Set
    End Property

#End Region

End Class


#Region "The new menubar renderer. It's better than the old method."
' All credit for the original code professional toolstrip renderer
' code below goes to this VBForums post: 
' http://www.vbforums.com/showthread.php?581374-menustrip-amp-toolstrip-color&p=3590240&viewfull=1#post3590240

Public Class uxlProToolstripRenderer
    Inherits ToolStripProfessionalRenderer

    Private _BackColor As Color
    ' "_DropdownBackColor" determines the colors in the menubar dropdown.
    Private _DropdownBackColor As Color
    Private _ImageMarginGradientStartColor As Color
    Private _ImageMarginGradientEndColor As Color
    Private _ForeColor As Color
    Private _TextHighlightColor As Color

    ' Get and set the backcolor for the menubar.
    Public Property BackColor() As Color
        Get
            Return _BackColor
        End Get
        Set(ByVal value As Color)
            _BackColor = value
        End Set
    End Property

    ' Get and set the backcolor for menubar dropdown items.
    Public Property DropdownBackColor As Color
        Get
            Return _DropdownBackColor
        End Get
        Set(ByVal value As Color)
            _DropdownBackColor = value
        End Set
    End Property

    ' Get and set the start color for the gradients in menuitem image margins.
    Public Property ImageMarginGradientStartColor As Color
        Get
            Return _ImageMarginGradientStartColor
        End Get
        Set(ByVal value As Color)
            _ImageMarginGradientStartColor = value
        End Set
    End Property

    ' Get and set the end color for the gradients in menuitem image margins.
    Public Property ImageMarginGradientEndColor As Color
        Get
            Return _ImageMarginGradientEndColor
        End Get
        Set(ByVal value As Color)
            _ImageMarginGradientEndColor = value
        End Set
    End Property

    ' Get and set the text highlight color for the menubar.
    Public Property TextHighlightColor() As Color
        Get
            Return _TextHighlightColor
        End Get
        Set(ByVal value As Color)
            _TextHighlightColor = value
        End Set
    End Property

    ' Get and set the forecolor for the menubar.
    Public Property ForeColor() As Color
        Get
            Return _ForeColor
        End Get
        Set(ByVal value As Color)
            _ForeColor = value
        End Set
    End Property

    ' Change the colors for the menubar background.
    Protected Overrides Sub OnRenderToolStripBackground(ByVal e As ToolStripRenderEventArgs)
        MyBase.OnRenderToolStripBackground(e)
        Dim lightColor As Color = Me.BackColor
        Using b As New SolidBrush(lightColor)
            e.Graphics.FillRectangle(b, e.AffectedBounds)
        End Using
    End Sub

    ' Change the color for the menubar dropdowns.
    ' Based on the code "Step 3" here:
    ' http://www.vbforums.com/showthread.php?539578-Custom-VisualStudio2008-style-MenuStrip-and-ToolStrip-Renderer&p=3333808&viewfull=1#post3333808
    Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
        MyBase.OnRenderImageMargin(e)
        ' Colors and brushes for menuitem background color.
        Dim DropDownItemBackColor As Color = Me.DropdownBackColor
        Dim dropdownBrush As New SolidBrush(DropdownBackColor)
        ' Colors and brushes for image margin gradiant.
        Dim ImageMarginGradientBrush As New LinearGradientBrush(e.AffectedBounds, Me.ImageMarginGradientStartColor,
                                                                Me.ImageMarginGradientEndColor, LinearGradientMode.Horizontal)
        ' Make the menuitem background set to the theme's color.
        Dim itembgcolor As New Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height)
        ' Fill the background of the menuitem.
        e.Graphics.FillRectangle(dropdownBrush, itembgcolor)
        ' Fill the item image margin gradient.
        e.Graphics.FillRectangle(ImageMarginGradientBrush, e.AffectedBounds)
    End Sub

    ' Change the colors for the menubar text.
    Protected Overrides Sub OnRenderItemText(ByVal e As ToolStripItemTextRenderEventArgs)
        ' If the menuitem is selected or pressed, use the TextHighlightColor for its text color.
        If e.Item.Selected = True Or e.Item.Pressed = True Then
            e.TextColor = Me.TextHighlightColor
        Else
            ' Otherwise, just use its regular ForeColor for text color.
            e.TextColor = Me.ForeColor
        End If
        MyBase.OnRenderItemText(e)
    End Sub

    ' Make sure the button arrow is visible using the ForeColor property.
    Protected Overrides Sub OnRenderArrow(e As ToolStripArrowRenderEventArgs)
        ' If the menuitem is highlighted, make the arrow the same color
        ' as the menuitem's TextHighlightColor.
        If e.Item.Selected = True Or e.Item.Pressed = True Then
            e.ArrowColor = Me.TextHighlightColor
            ' If the menuitem is not highlighted, make the arrow the same
            ' color as the menuitem's forecolor.
        Else
            e.ArrowColor = Me.ForeColor
        End If
        MyBase.OnRenderArrow(e)
    End Sub
End Class
#End Region