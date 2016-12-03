'UXL Launcher - Launchers for Microsoft Office apps in one place.
'Copyright (C) 2013-2016  Drew Naylor
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



Public Class aaformAboutWindow
    Private Sub RealAboutWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.labelCopyright.Text = My.Application.Info.Copyright
        ' Me.textboxAppDescription.Text = My.Application.Info.Description
    End Sub
End Class