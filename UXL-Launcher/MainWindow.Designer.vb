﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformMainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformMainWindow))
        Me.menubarMainWindow = New System.Windows.Forms.MenuStrip()
        Me.menubarFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarExitButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarOptionsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarAuthorsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarLicenseButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarAboutButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.zotherstuffFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zotherstuffFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelWhiteBackPanel = New System.Windows.Forms.Panel()
        Me.statusbarMainWindow = New System.Windows.Forms.StatusStrip()
        Me.statusbarLabelWelcomeText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.groupboxExtraApps = New System.Windows.Forms.GroupBox()
        Me.groupboxProApps = New System.Windows.Forms.GroupBox()
        Me.groupboxStandardApps = New System.Windows.Forms.GroupBox()
        Me.menubarMainWindow.SuspendLayout()
        Me.panelWhiteBackPanel.SuspendLayout()
        Me.statusbarMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'menubarMainWindow
        '
        Me.menubarMainWindow.BackColor = System.Drawing.SystemColors.Control
        Me.menubarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFileMenu, Me.menubarToolsMenu, Me.menubarHelpMenu})
        Me.menubarMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menubarMainWindow.Name = "menubarMainWindow"
        Me.menubarMainWindow.Size = New System.Drawing.Size(696, 24)
        Me.menubarMainWindow.TabIndex = 0
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(37, 20)
        Me.menubarFileMenu.Text = "&File"
        '
        'menubarExitButton
        '
        Me.menubarExitButton.Name = "menubarExitButton"
        Me.menubarExitButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.menubarExitButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarExitButton.Text = "E&xit"
        '
        'menubarToolsMenu
        '
        Me.menubarToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarOptionsButton})
        Me.menubarToolsMenu.Name = "menubarToolsMenu"
        Me.menubarToolsMenu.Size = New System.Drawing.Size(48, 20)
        Me.menubarToolsMenu.Text = "&Tools"
        '
        'menubarOptionsButton
        '
        Me.menubarOptionsButton.Name = "menubarOptionsButton"
        Me.menubarOptionsButton.Size = New System.Drawing.Size(125, 22)
        Me.menubarOptionsButton.Text = "&Options..."
        '
        'menubarHelpMenu
        '
        Me.menubarHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarAuthorsButton, Me.menubarLicenseButton, Me.menubarAboutButton})
        Me.menubarHelpMenu.Name = "menubarHelpMenu"
        Me.menubarHelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.menubarHelpMenu.Text = "&Help"
        '
        'menubarAuthorsButton
        '
        Me.menubarAuthorsButton.Name = "menubarAuthorsButton"
        Me.menubarAuthorsButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarAuthorsButton.Text = "A&uthors"
        '
        'menubarLicenseButton
        '
        Me.menubarLicenseButton.Name = "menubarLicenseButton"
        Me.menubarLicenseButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarLicenseButton.Text = "&License"
        '
        'menubarAboutButton
        '
        Me.menubarAboutButton.Name = "menubarAboutButton"
        Me.menubarAboutButton.Size = New System.Drawing.Size(152, 22)
        Me.menubarAboutButton.Text = "&About"
        '
        'zotherstuffFileToolStripMenuItem
        '
        Me.zotherstuffFileToolStripMenuItem.Name = "zotherstuffFileToolStripMenuItem"
        Me.zotherstuffFileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.zotherstuffFileToolStripMenuItem.Text = "File"
        '
        'zotherstuffFileToolStripMenuItem1
        '
        Me.zotherstuffFileToolStripMenuItem1.Name = "zotherstuffFileToolStripMenuItem1"
        Me.zotherstuffFileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.zotherstuffFileToolStripMenuItem1.Text = "File"
        '
        'panelWhiteBackPanel
        '
        Me.panelWhiteBackPanel.BackColor = System.Drawing.Color.White
        Me.panelWhiteBackPanel.Controls.Add(Me.statusbarMainWindow)
        Me.panelWhiteBackPanel.Controls.Add(Me.groupboxExtraApps)
        Me.panelWhiteBackPanel.Controls.Add(Me.groupboxProApps)
        Me.panelWhiteBackPanel.Controls.Add(Me.groupboxStandardApps)
        Me.panelWhiteBackPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelWhiteBackPanel.Location = New System.Drawing.Point(0, 24)
        Me.panelWhiteBackPanel.Name = "panelWhiteBackPanel"
        Me.panelWhiteBackPanel.Size = New System.Drawing.Size(696, 518)
        Me.panelWhiteBackPanel.TabIndex = 1
        '
        'statusbarMainWindow
        '
        Me.statusbarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusbarLabelWelcomeText})
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 496)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Size = New System.Drawing.Size(696, 22)
        Me.statusbarMainWindow.TabIndex = 0
        Me.statusbarMainWindow.Text = "StatusStrip1"
        '
        'statusbarLabelWelcomeText
        '
        Me.statusbarLabelWelcomeText.BackColor = System.Drawing.Color.Transparent
        Me.statusbarLabelWelcomeText.Name = "statusbarLabelWelcomeText"
        Me.statusbarLabelWelcomeText.Size = New System.Drawing.Size(619, 17)
        Me.statusbarLabelWelcomeText.Text = "Welcome to UXL, the Unified eXecutable Launcher! Click the buttons to launch the " &
    "relevent app. Also, explore the UI."
        '
        'groupboxExtraApps
        '
        Me.groupboxExtraApps.Location = New System.Drawing.Point(437, 2)
        Me.groupboxExtraApps.Name = "groupboxExtraApps"
        Me.groupboxExtraApps.Size = New System.Drawing.Size(190, 491)
        Me.groupboxExtraApps.TabIndex = 3
        Me.groupboxExtraApps.TabStop = False
        Me.groupboxExtraApps.Text = "Extra Apps + Tools"
        '
        'groupboxProApps
        '
        Me.groupboxProApps.Location = New System.Drawing.Point(223, 2)
        Me.groupboxProApps.Name = "groupboxProApps"
        Me.groupboxProApps.Size = New System.Drawing.Size(190, 491)
        Me.groupboxProApps.TabIndex = 2
        Me.groupboxProApps.TabStop = False
        Me.groupboxProApps.Text = "Professional Apps"
        '
        'groupboxStandardApps
        '
        Me.groupboxStandardApps.Location = New System.Drawing.Point(8, 2)
        Me.groupboxStandardApps.Name = "groupboxStandardApps"
        Me.groupboxStandardApps.Size = New System.Drawing.Size(190, 491)
        Me.groupboxStandardApps.TabIndex = 1
        Me.groupboxStandardApps.TabStop = False
        Me.groupboxStandardApps.Text = "Standard Apps"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 542)
        Me.Controls.Add(Me.panelWhiteBackPanel)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Name = "aaformMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UXL Launcher REMEMBER TO PUT 32-BIT OR 64-BIT MODE HERE"
        Me.menubarMainWindow.ResumeLayout(False)
        Me.menubarMainWindow.PerformLayout()
        Me.panelWhiteBackPanel.ResumeLayout(False)
        Me.panelWhiteBackPanel.PerformLayout()
        Me.statusbarMainWindow.ResumeLayout(False)
        Me.statusbarMainWindow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menubarMainWindow As MenuStrip
    Friend WithEvents zotherstuffFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents zotherstuffFileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents menubarFileMenu As ToolStripMenuItem
    Friend WithEvents menubarToolsMenu As ToolStripMenuItem
    Friend WithEvents menubarHelpMenu As ToolStripMenuItem
    Friend WithEvents menubarExitButton As ToolStripMenuItem
    Friend WithEvents menubarOptionsButton As ToolStripMenuItem
    Friend WithEvents panelWhiteBackPanel As Panel
    Friend WithEvents menubarAuthorsButton As ToolStripMenuItem
    Friend WithEvents menubarLicenseButton As ToolStripMenuItem
    Friend WithEvents menubarAboutButton As ToolStripMenuItem
    Friend WithEvents statusbarMainWindow As StatusStrip
    Friend WithEvents statusbarLabelWelcomeText As ToolStripStatusLabel
    Friend WithEvents groupboxStandardApps As GroupBox
    Friend WithEvents groupboxProApps As GroupBox
    Friend WithEvents groupboxExtraApps As GroupBox
End Class
