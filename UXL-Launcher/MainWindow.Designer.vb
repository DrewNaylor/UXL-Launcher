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
        Me.menubarHelpTopicsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.zseparatorHelpMenu = New System.Windows.Forms.ToolStripSeparator()
        Me.menubarAuthorsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarLicenseButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.menubarAboutButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.zotherstuffFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zotherstuffFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusbarMainWindow = New System.Windows.Forms.StatusStrip()
        Me.statusbarLabelWelcomeText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.flowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.groupboxStandardApps = New System.Windows.Forms.GroupBox()
        Me.buttonRunOneNote = New System.Windows.Forms.Button()
        Me.buttonRunOutlook = New System.Windows.Forms.Button()
        Me.buttonRunPowerPoint = New System.Windows.Forms.Button()
        Me.buttonRunExcel = New System.Windows.Forms.Button()
        Me.buttonRunWord = New System.Windows.Forms.Button()
        Me.pictureOneNoteIcon = New System.Windows.Forms.PictureBox()
        Me.pictureOutlookIcon = New System.Windows.Forms.PictureBox()
        Me.picturePowerpointIcon = New System.Windows.Forms.PictureBox()
        Me.pictureExcelIcon = New System.Windows.Forms.PictureBox()
        Me.pictureWordIcon = New System.Windows.Forms.PictureBox()
        Me.groupboxProApps = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buttonRunAccess = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pictureAccessIcon = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupboxExtraApps = New System.Windows.Forms.GroupBox()
        Me.menubarMainWindow.SuspendLayout()
        Me.statusbarMainWindow.SuspendLayout()
        Me.flowLayoutPanel.SuspendLayout()
        Me.groupboxStandardApps.SuspendLayout()
        CType(Me.pictureOneNoteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureOutlookIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturePowerpointIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureExcelIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureWordIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxProApps.SuspendLayout()
        CType(Me.pictureAccessIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menubarMainWindow
        '
        Me.menubarMainWindow.AutoSize = False
        Me.menubarMainWindow.BackColor = System.Drawing.SystemColors.Control
        Me.menubarMainWindow.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.menubarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarFileMenu, Me.menubarToolsMenu, Me.menubarHelpMenu})
        Me.menubarMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menubarMainWindow.Name = "menubarMainWindow"
        Me.menubarMainWindow.Size = New System.Drawing.Size(640, 23)
        Me.menubarMainWindow.TabIndex = 0
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(37, 19)
        Me.menubarFileMenu.Text = "&File"
        '
        'menubarExitButton
        '
        Me.menubarExitButton.Name = "menubarExitButton"
        Me.menubarExitButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.menubarExitButton.Size = New System.Drawing.Size(134, 22)
        Me.menubarExitButton.Text = "E&xit"
        '
        'menubarToolsMenu
        '
        Me.menubarToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarOptionsButton})
        Me.menubarToolsMenu.Name = "menubarToolsMenu"
        Me.menubarToolsMenu.Size = New System.Drawing.Size(48, 19)
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
        Me.menubarHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarHelpTopicsButton, Me.zseparatorHelpMenu, Me.menubarAuthorsButton, Me.menubarLicenseButton, Me.menubarAboutButton})
        Me.menubarHelpMenu.Name = "menubarHelpMenu"
        Me.menubarHelpMenu.Size = New System.Drawing.Size(44, 19)
        Me.menubarHelpMenu.Text = "&Help"
        '
        'menubarHelpTopicsButton
        '
        Me.menubarHelpTopicsButton.Name = "menubarHelpTopicsButton"
        Me.menubarHelpTopicsButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.menubarHelpTopicsButton.Size = New System.Drawing.Size(211, 22)
        Me.menubarHelpTopicsButton.Text = "&View Help Topics"
        '
        'zseparatorHelpMenu
        '
        Me.zseparatorHelpMenu.Name = "zseparatorHelpMenu"
        Me.zseparatorHelpMenu.Size = New System.Drawing.Size(208, 6)
        '
        'menubarAuthorsButton
        '
        Me.menubarAuthorsButton.Name = "menubarAuthorsButton"
        Me.menubarAuthorsButton.Size = New System.Drawing.Size(211, 22)
        Me.menubarAuthorsButton.Text = "A&uthors"
        '
        'menubarLicenseButton
        '
        Me.menubarLicenseButton.Name = "menubarLicenseButton"
        Me.menubarLicenseButton.Size = New System.Drawing.Size(211, 22)
        Me.menubarLicenseButton.Text = "&License"
        '
        'menubarAboutButton
        '
        Me.menubarAboutButton.Name = "menubarAboutButton"
        Me.menubarAboutButton.Size = New System.Drawing.Size(211, 22)
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
        'statusbarMainWindow
        '
        Me.statusbarMainWindow.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.statusbarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusbarLabelWelcomeText})
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 530)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.statusbarMainWindow.Size = New System.Drawing.Size(640, 22)
        Me.statusbarMainWindow.SizingGrip = False
        Me.statusbarMainWindow.TabIndex = 1
        Me.statusbarMainWindow.Text = "StatusStrip1"
        '
        'statusbarLabelWelcomeText
        '
        Me.statusbarLabelWelcomeText.BackColor = System.Drawing.Color.Transparent
        Me.statusbarLabelWelcomeText.Name = "statusbarLabelWelcomeText"
        Me.statusbarLabelWelcomeText.Size = New System.Drawing.Size(619, 17)
        Me.statusbarLabelWelcomeText.Text = "Welcome to UXL, the Unified eXecutable Launcher! Click the buttons to launch the " &
    "relevant app. Also, explore the UI."
        '
        'flowLayoutPanel
        '
        Me.flowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.flowLayoutPanel.Controls.Add(Me.groupboxStandardApps)
        Me.flowLayoutPanel.Controls.Add(Me.groupboxProApps)
        Me.flowLayoutPanel.Controls.Add(Me.groupboxExtraApps)
        Me.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel.Location = New System.Drawing.Point(0, 23)
        Me.flowLayoutPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.flowLayoutPanel.Name = "flowLayoutPanel"
        Me.flowLayoutPanel.Size = New System.Drawing.Size(640, 529)
        Me.flowLayoutPanel.TabIndex = 2
        '
        'groupboxStandardApps
        '
        Me.groupboxStandardApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunOneNote)
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunOutlook)
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunPowerPoint)
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunExcel)
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunWord)
        Me.groupboxStandardApps.Controls.Add(Me.pictureOneNoteIcon)
        Me.groupboxStandardApps.Controls.Add(Me.pictureOutlookIcon)
        Me.groupboxStandardApps.Controls.Add(Me.picturePowerpointIcon)
        Me.groupboxStandardApps.Controls.Add(Me.pictureExcelIcon)
        Me.groupboxStandardApps.Controls.Add(Me.pictureWordIcon)
        Me.groupboxStandardApps.Location = New System.Drawing.Point(16, 2)
        Me.groupboxStandardApps.Margin = New System.Windows.Forms.Padding(16, 2, 2, 2)
        Me.groupboxStandardApps.Name = "groupboxStandardApps"
        Me.groupboxStandardApps.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxStandardApps.Size = New System.Drawing.Size(190, 498)
        Me.groupboxStandardApps.TabIndex = 0
        Me.groupboxStandardApps.TabStop = False
        Me.groupboxStandardApps.Text = "Standard Apps"
        '
        'buttonRunOneNote
        '
        Me.buttonRunOneNote.Location = New System.Drawing.Point(63, 276)
        Me.buttonRunOneNote.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRunOneNote.Name = "buttonRunOneNote"
        Me.buttonRunOneNote.Size = New System.Drawing.Size(105, 50)
        Me.buttonRunOneNote.TabIndex = 9
        Me.buttonRunOneNote.Text = "Microsoft OneNote"
        Me.buttonRunOneNote.UseVisualStyleBackColor = True
        '
        'buttonRunOutlook
        '
        Me.buttonRunOutlook.Location = New System.Drawing.Point(63, 212)
        Me.buttonRunOutlook.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRunOutlook.Name = "buttonRunOutlook"
        Me.buttonRunOutlook.Size = New System.Drawing.Size(105, 50)
        Me.buttonRunOutlook.TabIndex = 8
        Me.buttonRunOutlook.Text = "Microsoft Outlook"
        Me.buttonRunOutlook.UseVisualStyleBackColor = True
        '
        'buttonRunPowerPoint
        '
        Me.buttonRunPowerPoint.Location = New System.Drawing.Point(63, 148)
        Me.buttonRunPowerPoint.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRunPowerPoint.Name = "buttonRunPowerPoint"
        Me.buttonRunPowerPoint.Size = New System.Drawing.Size(105, 50)
        Me.buttonRunPowerPoint.TabIndex = 7
        Me.buttonRunPowerPoint.Text = "Microsoft PowerPoint"
        Me.buttonRunPowerPoint.UseVisualStyleBackColor = True
        '
        'buttonRunExcel
        '
        Me.buttonRunExcel.Location = New System.Drawing.Point(63, 84)
        Me.buttonRunExcel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRunExcel.Name = "buttonRunExcel"
        Me.buttonRunExcel.Size = New System.Drawing.Size(105, 50)
        Me.buttonRunExcel.TabIndex = 6
        Me.buttonRunExcel.Text = "Microsoft Excel"
        Me.buttonRunExcel.UseVisualStyleBackColor = True
        '
        'buttonRunWord
        '
        Me.buttonRunWord.Location = New System.Drawing.Point(63, 20)
        Me.buttonRunWord.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRunWord.Name = "buttonRunWord"
        Me.buttonRunWord.Size = New System.Drawing.Size(105, 50)
        Me.buttonRunWord.TabIndex = 5
        Me.buttonRunWord.Text = "Microsoft Word"
        Me.buttonRunWord.UseVisualStyleBackColor = True
        '
        'pictureOneNoteIcon
        '
        Me.pictureOneNoteIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Onenote
        Me.pictureOneNoteIcon.Location = New System.Drawing.Point(7, 276)
        Me.pictureOneNoteIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureOneNoteIcon.Name = "pictureOneNoteIcon"
        Me.pictureOneNoteIcon.Size = New System.Drawing.Size(50, 50)
        Me.pictureOneNoteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureOneNoteIcon.TabIndex = 4
        Me.pictureOneNoteIcon.TabStop = False
        '
        'pictureOutlookIcon
        '
        Me.pictureOutlookIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Outlook
        Me.pictureOutlookIcon.Location = New System.Drawing.Point(7, 212)
        Me.pictureOutlookIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureOutlookIcon.Name = "pictureOutlookIcon"
        Me.pictureOutlookIcon.Size = New System.Drawing.Size(50, 50)
        Me.pictureOutlookIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureOutlookIcon.TabIndex = 3
        Me.pictureOutlookIcon.TabStop = False
        '
        'picturePowerpointIcon
        '
        Me.picturePowerpointIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Powerpoint
        Me.picturePowerpointIcon.Location = New System.Drawing.Point(7, 148)
        Me.picturePowerpointIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.picturePowerpointIcon.Name = "picturePowerpointIcon"
        Me.picturePowerpointIcon.Size = New System.Drawing.Size(50, 50)
        Me.picturePowerpointIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picturePowerpointIcon.TabIndex = 2
        Me.picturePowerpointIcon.TabStop = False
        '
        'pictureExcelIcon
        '
        Me.pictureExcelIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Excel
        Me.pictureExcelIcon.Location = New System.Drawing.Point(7, 84)
        Me.pictureExcelIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureExcelIcon.Name = "pictureExcelIcon"
        Me.pictureExcelIcon.Size = New System.Drawing.Size(50, 50)
        Me.pictureExcelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureExcelIcon.TabIndex = 1
        Me.pictureExcelIcon.TabStop = False
        '
        'pictureWordIcon
        '
        Me.pictureWordIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Word
        Me.pictureWordIcon.Location = New System.Drawing.Point(7, 20)
        Me.pictureWordIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureWordIcon.Name = "pictureWordIcon"
        Me.pictureWordIcon.Size = New System.Drawing.Size(50, 50)
        Me.pictureWordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureWordIcon.TabIndex = 0
        Me.pictureWordIcon.TabStop = False
        '
        'groupboxProApps
        '
        Me.groupboxProApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxProApps.Controls.Add(Me.Button1)
        Me.groupboxProApps.Controls.Add(Me.buttonRunAccess)
        Me.groupboxProApps.Controls.Add(Me.Button2)
        Me.groupboxProApps.Controls.Add(Me.pictureAccessIcon)
        Me.groupboxProApps.Controls.Add(Me.Button3)
        Me.groupboxProApps.Controls.Add(Me.PictureBox3)
        Me.groupboxProApps.Controls.Add(Me.PictureBox2)
        Me.groupboxProApps.Controls.Add(Me.PictureBox1)
        Me.groupboxProApps.Location = New System.Drawing.Point(224, 2)
        Me.groupboxProApps.Margin = New System.Windows.Forms.Padding(16, 2, 2, 2)
        Me.groupboxProApps.Name = "groupboxProApps"
        Me.groupboxProApps.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxProApps.Size = New System.Drawing.Size(190, 498)
        Me.groupboxProApps.TabIndex = 1
        Me.groupboxProApps.TabStop = False
        Me.groupboxProApps.Text = "Professional Apps"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 212)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 50)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Microsoft Outlook"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buttonRunAccess
        '
        Me.buttonRunAccess.Location = New System.Drawing.Point(63, 20)
        Me.buttonRunAccess.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRunAccess.Name = "buttonRunAccess"
        Me.buttonRunAccess.Size = New System.Drawing.Size(105, 50)
        Me.buttonRunAccess.TabIndex = 14
        Me.buttonRunAccess.Text = "Microsoft Access"
        Me.buttonRunAccess.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(63, 148)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 50)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Microsoft PowerPoint"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pictureAccessIcon
        '
        Me.pictureAccessIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Access
        Me.pictureAccessIcon.Location = New System.Drawing.Point(7, 20)
        Me.pictureAccessIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.pictureAccessIcon.Name = "pictureAccessIcon"
        Me.pictureAccessIcon.Size = New System.Drawing.Size(50, 50)
        Me.pictureAccessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureAccessIcon.TabIndex = 10
        Me.pictureAccessIcon.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(63, 84)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 50)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Microsoft Excel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.UXL_Launcher.My.Resources.Resources.Excel
        Me.PictureBox3.Location = New System.Drawing.Point(7, 84)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UXL_Launcher.My.Resources.Resources.Powerpoint
        Me.PictureBox2.Location = New System.Drawing.Point(7, 148)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UXL_Launcher.My.Resources.Resources.Outlook
        Me.PictureBox1.Location = New System.Drawing.Point(7, 212)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'groupboxExtraApps
        '
        Me.groupboxExtraApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxExtraApps.Location = New System.Drawing.Point(432, 2)
        Me.groupboxExtraApps.Margin = New System.Windows.Forms.Padding(16, 2, 2, 2)
        Me.groupboxExtraApps.Name = "groupboxExtraApps"
        Me.groupboxExtraApps.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxExtraApps.Size = New System.Drawing.Size(190, 498)
        Me.groupboxExtraApps.TabIndex = 2
        Me.groupboxExtraApps.TabStop = False
        Me.groupboxExtraApps.Text = "Extra Apps + Tools"
        '
        'aaformMainWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(640, 552)
        Me.Controls.Add(Me.statusbarMainWindow)
        Me.Controls.Add(Me.flowLayoutPanel)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.MaximizeBox = False
        Me.Name = "aaformMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UXL Launcher REMEMBER TO PUT 32-BIT OR 64-BIT MODE HERE"
        Me.menubarMainWindow.ResumeLayout(False)
        Me.menubarMainWindow.PerformLayout()
        Me.statusbarMainWindow.ResumeLayout(False)
        Me.statusbarMainWindow.PerformLayout()
        Me.flowLayoutPanel.ResumeLayout(False)
        Me.groupboxStandardApps.ResumeLayout(False)
        CType(Me.pictureOneNoteIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureOutlookIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturePowerpointIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureExcelIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureWordIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxProApps.ResumeLayout(False)
        CType(Me.pictureAccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents menubarAuthorsButton As ToolStripMenuItem
    Friend WithEvents menubarLicenseButton As ToolStripMenuItem
    Friend WithEvents menubarAboutButton As ToolStripMenuItem
    Friend WithEvents menubarHelpTopicsButton As ToolStripMenuItem
    Friend WithEvents zseparatorHelpMenu As ToolStripSeparator
    Friend WithEvents statusbarMainWindow As StatusStrip
    Friend WithEvents statusbarLabelWelcomeText As ToolStripStatusLabel
    Friend WithEvents flowLayoutPanel As FlowLayoutPanel
    Friend WithEvents groupboxStandardApps As GroupBox
    Friend WithEvents groupboxProApps As GroupBox
    Friend WithEvents groupboxExtraApps As GroupBox
    Friend WithEvents pictureWordIcon As PictureBox
    Friend WithEvents pictureExcelIcon As PictureBox
    Friend WithEvents picturePowerpointIcon As PictureBox
    Friend WithEvents pictureOutlookIcon As PictureBox
    Friend WithEvents pictureOneNoteIcon As PictureBox
    Friend WithEvents buttonRunWord As Button
    Friend WithEvents buttonRunExcel As Button
    Friend WithEvents buttonRunPowerPoint As Button
    Friend WithEvents buttonRunOutlook As Button
    Friend WithEvents buttonRunOneNote As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents buttonRunAccess As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pictureAccessIcon As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
