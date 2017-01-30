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


Imports System.Drawing.Drawing2D
Imports System.Xml

Public Class UXLLauncher_ThemeEngine

    ' This file tells the theme engine what to color things. Theme engine is based on this Stack Overflow question: http://stackoverflow.com/q/199521
#Region "Set Theme via UXL Launcher Theme Engine."

    ' Make a variable that differs based on what theme is chosen.
    Public Shared userTheme As String
    ' Create strings for theme title, description, and author.
    Public Shared themeSheetTitle As String
    Public Shared themeSheetDescription As String
    Public Shared themeSheetAuthor As String

    Public Shared Sub themeEngine_ApplyTheme()

#Region "Read XML Theme Document."
        ' Parse the test theme XML document and apply stuff that's in it.
        Dim themeSheet As XmlDocument = New XmlDocument()
        themeSheet.LoadXml(userTheme)

        Dim themeNamespaceManager As New XmlNamespaceManager(themeSheet.NameTable)
        themeNamespaceManager.AddNamespace("uxl", "https://drewnaylor.github.io/xml")

#Region "Define strings for controls and things in the XML document."

        ' Button colors:
        Dim colorButtonBackColor As Color
        Dim colorButtonForeColor As Color
        ' Groupbox colors:
        Dim colorGroupBoxBackColor As Color
        Dim colorGroupBoxForeColor As Color
        ' FlowLayoutPanel colors:
        Dim colorFlowLayoutPanelBackColor As Color
        Dim colorFlowLayoutPanelForeColor As Color
        ' Menubar colors:
        Dim colorMenubarBackColor As Color
        ' Status Bar colors:
        Dim colorStatusBarBackColor As Color
        ' Label colors:
        Dim colorLabelBackColor As Color
        Dim colorLabelForeColor As Color
        ' Textbox colors:
        Dim colorTextboxBackColor As Color
        Dim colorTextboxForeColor As Color
        ' Menubar entry colors:
        Dim colorMenuItemBackColor As Color
        Dim colorMenuItemForeColor As Color
        ' Statusbar label colors:
        Dim colorStatusLabelBackColor As Color
        Dim colorStatusLabelForeColor As Color
        ' Other statusbar label properties
        Dim propertyStatusLabelBorderSides As ToolStripStatusLabelBorderSides
        Dim propertyStatusLabelBorderStyle As Border3DStyle
#End Region

#Region "Pull theme colors from XML documents."

#Region "Try/Catch block for Title theme element."
        ' Try to pull the title from XML.
        Try
            themeSheetTitle = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Title[1]", themeNamespaceManager).InnerText
            aaformMainWindow.debugLabelXmlThemeTitle.Text = themeSheetTitle

        Catch ex As NullReferenceException
            ' If the Title tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper Title XML element for the theme's Title displayed in the Options window." & vbCrLf &
            "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher. We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If
        End Try
#End Region

#Region "Try/Catch block for Description theme element."
        ' Try to pull the description from XML.
        Try
            themeSheetDescription = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Description[1]", themeNamespaceManager).InnerText
            aaformMainWindow.debugLabelXmlThemeDescription.Text = themeSheetDescription


        Catch ex As NullReferenceException
            ' If the Description tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper Description XML element for the theme's Description displayed in the Options window." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If

        End Try
#End Region

#Region "Try/Catch block for Author theme element."
        ' Try to pull the Author from XML.
        Try
            themeSheetAuthor = themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Author[1]", themeNamespaceManager).InnerText
            aaformMainWindow.debugLabelXmlThemeAuthor.Text = themeSheetAuthor

        Catch ex As NullReferenceException
            ' If the Author tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper Author XML element for the theme's Author displayed in the Options window." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "Try/Catch block for Button theme element."
        ' Try to pull the Button colors from XML.
#Region "Button BackColor"
        Try
            colorButtonBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/BackColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the Button BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper Button BackColor XML element for the BackColor property on the Button control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "Button ForeColor"

        Try
            ' Try to pull button forecolor from XML
            colorButtonForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Button/ForeColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the Button ForeColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper Button ForeColor XML element for the ForeColor property on the Button control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#End Region

#Region "GroupBox BackColor"

        ' Try to pull the GroupBox BackColor from XML.
        Try
            colorGroupBoxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/BackColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the GroupBox BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper GroupBox BackColor XML element for the BackColor property on the GroupBox control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
        If msgResult = DialogResult.Yes Then
            Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
        End If
        End Try

#End Region

#Region "GroupBox ForeColor."
        ' Try to pull the GroupBox ForeColor from XML.
        Try
            colorGroupBoxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/GroupBox/ForeColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the GroupBox ForeColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper GroupBox ForeColor XML element for the ForeColor property on the GroupBox control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "FlowLayoutPanel BackColor."
        Try
            ' Try to pull the FlowLayoutPanel BackColor from XML.
            colorFlowLayoutPanelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/BackColor[1]", themeNamespaceManager).InnerText)

        Catch ex As NullReferenceException
            ' If the FlowLayoutPanel BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper FlowLayoutPanel BackColor XML element for the BackColor property on the FlowLayoutPanel control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
        If msgResult = DialogResult.Yes Then
            Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
        End If
        End Try
#End Region

#Region "FlowLayoutPanel ForeColor"
        ' Try to pull the FlowLayoutPanel ForeColor from XML.
        Try
            colorFlowLayoutPanelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/FlowLayoutPanel/ForeColor[1]", themeNamespaceManager).InnerText)

        Catch ex As NullReferenceException
            ' If the FlowLayoutPanel ForeColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper FlowLayoutPanel ForeColor XML element for the ForeColor property on the FlowLayoutPanel control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "MenuBar BackColor"
        ' Try to pull the MenuBar colors from XML. Although this element isn't used due to the custom Professional Renderer, there was
        ' a problem with the menubar being properly set when switching themes so it's still here. The BackColor value of MenuItem
        ' overrides the BackColor value of MenuBar.
        Try
            colorMenubarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuBar/BackColor[1]", themeNamespaceManager).InnerText)

        Catch ex As NullReferenceException
            ' If the MenuBar BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper MenuBar BackColor XML element for the BackColor property on the MenuBar control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "StatusBar BackColor."
        ' Try to pull the StatusBar colors from XML.
        Try
            colorStatusBarBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusBar/BackColor[1]", themeNamespaceManager).InnerText)

        Catch ex As NullReferenceException
            ' If the StatusBar BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper StatusBar BackColor XML element for the BackColor property on the StatusBar control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "Label BackColor"
        ' Try to pull the Label BackColor from XML.
        Try
            colorLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/BackColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the Label BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper Label BackColor XML element for the BackColor property on the Label control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "Label ForeColor"
        ' Try to pull the Label ForeColor from XML.
        Try
            colorLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/Label/ForeColor[1]", themeNamespaceManager).InnerText)

        Catch ex As NullReferenceException
            ' If the Label ForeColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper Label ForeColor XML element for the ForeColor property on the Label control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "TextBox BackColor."
        ' Try to pull the TextBox BackColor from XML.
        Try
            colorTextboxBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/BackColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the TextBox BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper TextBox BackColor XML element for the BackColor property on the TextBox control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "TextBox ForeColor."
        ' Try to pull the TextBox ForeColor from XML.
        Try
            colorTextboxForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/TextBox/ForeColor[1]", themeNamespaceManager).InnerText)

        Catch ex As NullReferenceException
            ' If the TextBox ForeColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper TextBox ForeColor XML element for the ForeColor property on the TextBox control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "MenuItem BackColor"
        ' Try to pull the MenuItem BackColor from XML.
        Try
            colorMenuItemBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/BackColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the MenuItem BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper MenuItem BackColor XML element for the BackColor property on the MenuItem control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "MenuItem ForeColor."
        ' Try to pull the MenuItem ForeColor from XML.
        Try
            colorMenuItemForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/MenuItem/ForeColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the MenuItem ForeColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper MenuItem ForeColor XML element for the ForeColor property on the MenuItem control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "StatusLabel BackColor."
        ' Try to pull the StatusLabel BackColor from XML.
        Try
            colorStatusLabelBackColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BackColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the StatusLabel BackColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper StatusLabel BackColor XML element for the BackColor property on the StatusLabel control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

#Region "StatusLabel ForeColor."
        ' Try to pull the StatusLabel ForeColor from XML.
        Try
            colorStatusLabelForeColor = ColorTranslator.FromHtml(themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/ForeColor[1]", themeNamespaceManager).InnerText)


        Catch ex As NullReferenceException
            ' If the StatusLabel ForeColor tag is missing, then ask the user if they want to set their theme to Default in My.Settings
            ' and reload the Default theme, use the Default theme for this session only, or close UXL Launcher.
            Dim msgResult As Integer = MessageBox.Show("It appears that the chosen theme is missing a proper StatusLabel ForeColor XML element for the ForeColor property on the StatusLabel control." & vbCrLf &
                "Would you like to update your chosen theme settings to the Default theme and attempt to load the Default theme for UXL Launcher?" & vbCrLf &
                "" & vbCrLf &
               "Click ""Yes"" to update your chosen theme settings to the Default theme and restart UXL Launcher." & vbCrLf & "We will attempt to use the Default theme until you change your theme in the Options window." & vbCrLf &
                "" & vbCrLf &
                "Click ""No"" to close UXL Launcher." & vbCrLf &
                "" & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "Theme missing XML element",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)

            ' If the user chooses reset their chosen theme to Default, set My.Settings.userChosenTheme to Default and restart.
            If msgResult = DialogResult.Yes Then
                My.Settings.userChosenTheme = "Default"
                ' Save settings.
                My.Settings.Save()
                Application.Restart()
            ElseIf msgResult = DialogResult.No Then
                aaformMainWindow.Close()
            End If

        Catch ex As Exception
            ' If another error shows up, then we can't handle it yet and ask the user if they want to file a
            ' bug report.
            Dim msgResult As Integer = MessageBox.Show("An error occurred that we can't handle yet. Would you like to file a bug report online?" & vbCrLf & "Before clicking ""Yes,"" please write down what you were doing" & vbCrLf & "when the error occurred along with the text below" &
                " and use that to fill out the bug report." & vbCrLf &
                "" & vbCrLf &
                "Error message: " & vbCrLf & ex.Message & vbCrLf & "Error type:" & vbCrLf & ex.GetType.ToString, "I just don't know what went wrong!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            ' If the user chooses to file a bug report online, go to the GitHub Issues "New Issue."
            If msgResult = DialogResult.Yes Then
                Process.Start("https://github.com/DrewNaylor/UXL-Launcher/issues/new")
            End If
        End Try
#End Region

        ' Pull other StatusLabel stuff from XML.
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderSides[1]", themeNamespaceManager).InnerText = "All" Then
            propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.All
        Else
            propertyStatusLabelBorderSides = ToolStripStatusLabelBorderSides.None
        End If
        If themeSheet.SelectSingleNode("/UXL_Launcher_Theme/Theme_Colors/StatusLabel/BorderStyle[1]", themeNamespaceManager).InnerText = "SunkenInner" Then
            propertyStatusLabelBorderStyle = Border3DStyle.SunkenInner
        Else
            propertyStatusLabelBorderStyle = Border3DStyle.Flat
        End If

#Region "Define Short-words."
        ' Create a short-form word for "Control."
        Dim ctrl As Control
#End Region

#Region "Set colors for controls in groupboxes."
        ' Look at all the buttons in the "Standard Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxStandardApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Standard Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next


        ' Look at all the buttons in the "Professional Apps" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxProApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Professional Apps" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next


        ' Look at all the buttons in the "Extra Apps + Tools" groupbox and change their theme.
        For Each ctrl In aaformMainWindow.groupboxExtraApps.Controls
            If (ctrl.GetType() Is GetType(Button)) Then
                Dim button As Button = CType(ctrl, Button)
                button.BackColor = colorButtonBackColor
                button.ForeColor = colorButtonForeColor
            End If
            ' Look at all the labels in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(Label)) Then
                Dim label As Label = CType(ctrl, Label)
                label.BackColor = colorLabelBackColor
                label.ForeColor = colorLabelForeColor
            End If
            ' Look at all the textboxes in the "Extra Apps + Tools" groupbox and change their theme.
            If (ctrl.GetType() Is GetType(TextBox)) Then
                Dim textbox As TextBox = CType(ctrl, TextBox)
                textbox.BackColor = colorTextboxBackColor
                textbox.ForeColor = colorTextboxForeColor
            End If
        Next
#End Region

#Region "Set colors for menubar entries."

        ' Set color for menubar.
        aaformMainWindow.UXLToolstripRenderer.BackColor = colorMenuItemBackColor
        aaformMainWindow.UXLToolstripRenderer.ForeColor = colorMenuItemForeColor
        aaformMainWindow.UXLToolstripRenderer.TextHighlightColor = Color.FromKnownColor(KnownColor.ControlText)

#End Region


#Region "Set colors for statusbar label and groupboxes."

        ' Set colors for the "Standard Apps" groupbox.
        aaformMainWindow.groupboxStandardApps.BackColor = colorGroupBoxBackColor
        aaformMainWindow.groupboxStandardApps.ForeColor = colorGroupBoxForeColor
        ' Set colors for the "Professional Apps" groupbox.
        aaformMainWindow.groupboxProApps.BackColor = colorGroupBoxBackColor
        aaformMainWindow.groupboxProApps.ForeColor = colorGroupBoxForeColor
        ' Set colors for the "Extra Apps + Tools" groupbox.
        aaformMainWindow.groupboxExtraApps.BackColor = colorGroupBoxBackColor
        aaformMainWindow.groupboxExtraApps.ForeColor = colorGroupBoxForeColor
        ' Set color for the Flow Layout Panel.
        aaformMainWindow.flowLayoutPanel.BackColor = colorFlowLayoutPanelBackColor
        aaformMainWindow.flowLayoutPanel.ForeColor = colorFlowLayoutPanelForeColor
        ' Set color for status bar.
        aaformMainWindow.statusbarMainWindow.BackColor = colorStatusBarBackColor
        ' Set color for menubar.
        aaformMainWindow.menubarMainWindow.BackColor = colorMenubarBackColor
        ' Set the colors for the status bar label.
        aaformMainWindow.statusbarLabelWelcomeText.BackColor = colorStatusLabelBackColor
        aaformMainWindow.statusbarLabelWelcomeText.ForeColor = colorStatusLabelForeColor
        ' Set other properties for StatusLabel.
        aaformMainWindow.statusbarLabelWelcomeText.BorderSides = propertyStatusLabelBorderSides
        aaformMainWindow.statusbarLabelWelcomeText.BorderStyle = propertyStatusLabelBorderStyle



#End Region

    End Sub
#End Region
#End Region

#Region "Start the theme engine and apply the user's theme."
    Public Shared Sub themeEngine_ChooseUserTheme()

        ' Choose the proper theme based on what the user chose.
        If My.Settings.userChosenTheme = "Test" Then
            userTheme = My.Resources.TestTheme_XML

        ElseIf My.Settings.userChosenTheme = "Default" Then
            userTheme = My.Resources.DefaultTheme_XML

        ElseIf My.Settings.userChosenTheme = "Eyesore" Then
            userTheme = My.Resources.EyesoreTheme_XML
        Else
            userTheme = My.Resources.DefaultTheme_XML
        End If

        ' Apply the theme.
        UXLLauncher_ThemeEngine.themeEngine_ApplyTheme()
    End Sub
#End Region
#End Region
End Class


#Region "The new menubar renderer. It's better than the old method."
' All credit for the original code professional toolstrip renderer
' code below goes to this VBForums post: 
' http://www.vbforums.com/showthread.php?581374-menustrip-amp-toolstrip-color&p=3590240&viewfull=1#post3590240

Public Class uxlProToolstripRenderer
    Inherits ToolStripProfessionalRenderer

    Private _BackColor As Color
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

    ' Get and set the forecolor for the menubar.
    Public Property TextHighlightColor() As Color
        Get
            Return _TextHighlightColor
        End Get
        Set(ByVal value As Color)
            _TextHighlightColor = value
        End Set
    End Property

    ' Get and set the text highlight color for the menubar.
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
        Dim lightColor As Color = ControlPaint.Light(Me.BackColor)
        Using b As New LinearGradientBrush(e.AffectedBounds, lightColor, lightColor, LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(b, e.AffectedBounds)
        End Using
    End Sub

    ' Change the colors for the menubar text.
    Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
        If e.Item.Selected = True Then
            e.TextColor = _TextHighlightColor
        Else
            e.TextColor = _ForeColor
        End If
        MyBase.OnRenderItemText(e)
    End Sub
End Class
#End Region