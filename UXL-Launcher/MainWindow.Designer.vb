<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.buttonRunPowerPoint = New System.Windows.Forms.Button()
        Me.buttonRunExcel = New System.Windows.Forms.Button()
        Me.buttonRunWord = New System.Windows.Forms.Button()
        Me.pictureOneNoteIcon = New System.Windows.Forms.PictureBox()
        Me.pictureOutlookIcon = New System.Windows.Forms.PictureBox()
        Me.picturePowerpointIcon = New System.Windows.Forms.PictureBox()
        Me.pictureExcelIcon = New System.Windows.Forms.PictureBox()
        Me.pictureWordIcon = New System.Windows.Forms.PictureBox()
        Me.groupboxProApps = New System.Windows.Forms.GroupBox()
        Me.groupboxExtraApps = New System.Windows.Forms.GroupBox()
        Me.buttonRunOutlook = New System.Windows.Forms.Button()
        Me.menubarMainWindow.SuspendLayout()
        Me.statusbarMainWindow.SuspendLayout()
        Me.flowLayoutPanel.SuspendLayout()
        Me.groupboxStandardApps.SuspendLayout()
        CType(Me.pictureOneNoteIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureOutlookIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturePowerpointIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureExcelIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureWordIcon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.menubarMainWindow.Padding = New System.Windows.Forms.Padding(12, 4, 0, 4)
        Me.menubarMainWindow.Size = New System.Drawing.Size(1280, 44)
        Me.menubarMainWindow.TabIndex = 0
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(64, 36)
        Me.menubarFileMenu.Text = "&File"
        '
        'menubarExitButton
        '
        Me.menubarExitButton.Name = "menubarExitButton"
        Me.menubarExitButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.menubarExitButton.Size = New System.Drawing.Size(237, 38)
        Me.menubarExitButton.Text = "E&xit"
        '
        'menubarToolsMenu
        '
        Me.menubarToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarOptionsButton})
        Me.menubarToolsMenu.Name = "menubarToolsMenu"
        Me.menubarToolsMenu.Size = New System.Drawing.Size(82, 36)
        Me.menubarToolsMenu.Text = "&Tools"
        '
        'menubarOptionsButton
        '
        Me.menubarOptionsButton.Name = "menubarOptionsButton"
        Me.menubarOptionsButton.Size = New System.Drawing.Size(214, 38)
        Me.menubarOptionsButton.Text = "&Options..."
        '
        'menubarHelpMenu
        '
        Me.menubarHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarHelpTopicsButton, Me.zseparatorHelpMenu, Me.menubarAuthorsButton, Me.menubarLicenseButton, Me.menubarAboutButton})
        Me.menubarHelpMenu.Name = "menubarHelpMenu"
        Me.menubarHelpMenu.Size = New System.Drawing.Size(77, 36)
        Me.menubarHelpMenu.Text = "&Help"
        '
        'menubarHelpTopicsButton
        '
        Me.menubarHelpTopicsButton.Name = "menubarHelpTopicsButton"
        Me.menubarHelpTopicsButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.menubarHelpTopicsButton.Size = New System.Drawing.Size(389, 38)
        Me.menubarHelpTopicsButton.Text = "&View Help Topics"
        '
        'zseparatorHelpMenu
        '
        Me.zseparatorHelpMenu.Name = "zseparatorHelpMenu"
        Me.zseparatorHelpMenu.Size = New System.Drawing.Size(386, 6)
        '
        'menubarAuthorsButton
        '
        Me.menubarAuthorsButton.Name = "menubarAuthorsButton"
        Me.menubarAuthorsButton.Size = New System.Drawing.Size(389, 38)
        Me.menubarAuthorsButton.Text = "A&uthors"
        '
        'menubarLicenseButton
        '
        Me.menubarLicenseButton.Name = "menubarLicenseButton"
        Me.menubarLicenseButton.Size = New System.Drawing.Size(389, 38)
        Me.menubarLicenseButton.Text = "&License"
        '
        'menubarAboutButton
        '
        Me.menubarAboutButton.Name = "menubarAboutButton"
        Me.menubarAboutButton.Size = New System.Drawing.Size(389, 38)
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
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 1025)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Padding = New System.Windows.Forms.Padding(0, 0, 14, 0)
        Me.statusbarMainWindow.Size = New System.Drawing.Size(1280, 37)
        Me.statusbarMainWindow.SizingGrip = False
        Me.statusbarMainWindow.TabIndex = 1
        Me.statusbarMainWindow.Text = "StatusStrip1"
        '
        'statusbarLabelWelcomeText
        '
        Me.statusbarLabelWelcomeText.BackColor = System.Drawing.Color.Transparent
        Me.statusbarLabelWelcomeText.Name = "statusbarLabelWelcomeText"
        Me.statusbarLabelWelcomeText.Size = New System.Drawing.Size(1259, 32)
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
        Me.flowLayoutPanel.Location = New System.Drawing.Point(0, 44)
        Me.flowLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.flowLayoutPanel.Name = "flowLayoutPanel"
        Me.flowLayoutPanel.Size = New System.Drawing.Size(1280, 1018)
        Me.flowLayoutPanel.TabIndex = 2
        '
        'groupboxStandardApps
        '
        Me.groupboxStandardApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunOutlook)
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunPowerPoint)
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunExcel)
        Me.groupboxStandardApps.Controls.Add(Me.buttonRunWord)
        Me.groupboxStandardApps.Controls.Add(Me.pictureOneNoteIcon)
        Me.groupboxStandardApps.Controls.Add(Me.pictureOutlookIcon)
        Me.groupboxStandardApps.Controls.Add(Me.picturePowerpointIcon)
        Me.groupboxStandardApps.Controls.Add(Me.pictureExcelIcon)
        Me.groupboxStandardApps.Controls.Add(Me.pictureWordIcon)
        Me.groupboxStandardApps.Location = New System.Drawing.Point(32, 4)
        Me.groupboxStandardApps.Margin = New System.Windows.Forms.Padding(32, 4, 4, 4)
        Me.groupboxStandardApps.Name = "groupboxStandardApps"
        Me.groupboxStandardApps.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxStandardApps.Size = New System.Drawing.Size(380, 958)
        Me.groupboxStandardApps.TabIndex = 0
        Me.groupboxStandardApps.TabStop = False
        Me.groupboxStandardApps.Text = "Standard Apps"
        '
        'buttonRunPowerPoint
        '
        Me.buttonRunPowerPoint.Location = New System.Drawing.Point(126, 284)
        Me.buttonRunPowerPoint.Name = "buttonRunPowerPoint"
        Me.buttonRunPowerPoint.Size = New System.Drawing.Size(210, 96)
        Me.buttonRunPowerPoint.TabIndex = 7
        Me.buttonRunPowerPoint.Text = "Microsoft PowerPoint"
        Me.buttonRunPowerPoint.UseVisualStyleBackColor = True
        '
        'buttonRunExcel
        '
        Me.buttonRunExcel.Location = New System.Drawing.Point(126, 161)
        Me.buttonRunExcel.Name = "buttonRunExcel"
        Me.buttonRunExcel.Size = New System.Drawing.Size(210, 96)
        Me.buttonRunExcel.TabIndex = 6
        Me.buttonRunExcel.Text = "Microsoft Excel"
        Me.buttonRunExcel.UseVisualStyleBackColor = True
        '
        'buttonRunWord
        '
        Me.buttonRunWord.Location = New System.Drawing.Point(126, 38)
        Me.buttonRunWord.Name = "buttonRunWord"
        Me.buttonRunWord.Size = New System.Drawing.Size(210, 96)
        Me.buttonRunWord.TabIndex = 5
        Me.buttonRunWord.Text = "Microsoft Word"
        Me.buttonRunWord.UseVisualStyleBackColor = True
        '
        'pictureOneNoteIcon
        '
        Me.pictureOneNoteIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Onenote
        Me.pictureOneNoteIcon.Location = New System.Drawing.Point(14, 530)
        Me.pictureOneNoteIcon.Name = "pictureOneNoteIcon"
        Me.pictureOneNoteIcon.Size = New System.Drawing.Size(100, 96)
        Me.pictureOneNoteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureOneNoteIcon.TabIndex = 4
        Me.pictureOneNoteIcon.TabStop = False
        '
        'pictureOutlookIcon
        '
        Me.pictureOutlookIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Outlook
        Me.pictureOutlookIcon.Location = New System.Drawing.Point(14, 407)
        Me.pictureOutlookIcon.Name = "pictureOutlookIcon"
        Me.pictureOutlookIcon.Size = New System.Drawing.Size(100, 96)
        Me.pictureOutlookIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureOutlookIcon.TabIndex = 3
        Me.pictureOutlookIcon.TabStop = False
        '
        'picturePowerpointIcon
        '
        Me.picturePowerpointIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Powerpoint
        Me.picturePowerpointIcon.Location = New System.Drawing.Point(14, 284)
        Me.picturePowerpointIcon.Name = "picturePowerpointIcon"
        Me.picturePowerpointIcon.Size = New System.Drawing.Size(100, 96)
        Me.picturePowerpointIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picturePowerpointIcon.TabIndex = 2
        Me.picturePowerpointIcon.TabStop = False
        '
        'pictureExcelIcon
        '
        Me.pictureExcelIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Excel
        Me.pictureExcelIcon.Location = New System.Drawing.Point(14, 161)
        Me.pictureExcelIcon.Name = "pictureExcelIcon"
        Me.pictureExcelIcon.Size = New System.Drawing.Size(100, 96)
        Me.pictureExcelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureExcelIcon.TabIndex = 1
        Me.pictureExcelIcon.TabStop = False
        '
        'pictureWordIcon
        '
        Me.pictureWordIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Word
        Me.pictureWordIcon.Location = New System.Drawing.Point(14, 38)
        Me.pictureWordIcon.Name = "pictureWordIcon"
        Me.pictureWordIcon.Size = New System.Drawing.Size(100, 96)
        Me.pictureWordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureWordIcon.TabIndex = 0
        Me.pictureWordIcon.TabStop = False
        '
        'groupboxProApps
        '
        Me.groupboxProApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxProApps.Location = New System.Drawing.Point(448, 4)
        Me.groupboxProApps.Margin = New System.Windows.Forms.Padding(32, 4, 4, 4)
        Me.groupboxProApps.Name = "groupboxProApps"
        Me.groupboxProApps.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxProApps.Size = New System.Drawing.Size(380, 958)
        Me.groupboxProApps.TabIndex = 1
        Me.groupboxProApps.TabStop = False
        Me.groupboxProApps.Text = "Professional Apps"
        '
        'groupboxExtraApps
        '
        Me.groupboxExtraApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxExtraApps.Location = New System.Drawing.Point(864, 4)
        Me.groupboxExtraApps.Margin = New System.Windows.Forms.Padding(32, 4, 4, 4)
        Me.groupboxExtraApps.Name = "groupboxExtraApps"
        Me.groupboxExtraApps.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxExtraApps.Size = New System.Drawing.Size(380, 958)
        Me.groupboxExtraApps.TabIndex = 2
        Me.groupboxExtraApps.TabStop = False
        Me.groupboxExtraApps.Text = "Extra Apps + Tools"
        '
        'buttonRunOutlook
        '
        Me.buttonRunOutlook.Location = New System.Drawing.Point(126, 407)
        Me.buttonRunOutlook.Name = "buttonRunOutlook"
        Me.buttonRunOutlook.Size = New System.Drawing.Size(210, 96)
        Me.buttonRunOutlook.TabIndex = 8
        Me.buttonRunOutlook.Text = "Microsoft Outlook"
        Me.buttonRunOutlook.UseVisualStyleBackColor = True
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 1062)
        Me.Controls.Add(Me.statusbarMainWindow)
        Me.Controls.Add(Me.flowLayoutPanel)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
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
End Class
