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
        Me.buttonRunSharePointWkSp = New System.Windows.Forms.Button()
        Me.buttonRunAccess = New System.Windows.Forms.Button()
        Me.buttonRunInfoPath = New System.Windows.Forms.Button()
        Me.pictureAccessIcon = New System.Windows.Forms.PictureBox()
        Me.buttonRunPublisher = New System.Windows.Forms.Button()
        Me.picturePublisherIcon = New System.Windows.Forms.PictureBox()
        Me.pictureInfoPathIcon = New System.Windows.Forms.PictureBox()
        Me.pictureSharepointIcon = New System.Windows.Forms.PictureBox()
        Me.groupboxExtraApps = New System.Windows.Forms.GroupBox()
        Me.buttonRunOneNoteQuickLaunch = New System.Windows.Forms.Button()
        Me.pictureQueryIcon = New System.Windows.Forms.PictureBox()
        Me.buttonRunQuery = New System.Windows.Forms.Button()
        Me.pictureOneNoteQuickLaunchIcon = New System.Windows.Forms.PictureBox()
        Me.buttonRunPictureManager = New System.Windows.Forms.Button()
        Me.picturePictureManagerIcon = New System.Windows.Forms.PictureBox()
        Me.pictureClipOrganizerIcon = New System.Windows.Forms.PictureBox()
        Me.buttonRunClipOrganizer = New System.Windows.Forms.Button()
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
        CType(Me.picturePublisherIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureInfoPathIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureSharepointIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxExtraApps.SuspendLayout()
        CType(Me.pictureQueryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureOneNoteQuickLaunchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picturePictureManagerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureClipOrganizerIcon, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.menubarMainWindow.Size = New System.Drawing.Size(1280, 46)
        Me.menubarMainWindow.TabIndex = 0
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'menubarFileMenu
        '
        Me.menubarFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menubarExitButton})
        Me.menubarFileMenu.Name = "menubarFileMenu"
        Me.menubarFileMenu.Size = New System.Drawing.Size(64, 38)
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
        Me.menubarToolsMenu.Size = New System.Drawing.Size(82, 38)
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
        Me.menubarHelpMenu.Size = New System.Drawing.Size(77, 38)
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
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 1067)
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
        Me.flowLayoutPanel.Location = New System.Drawing.Point(0, 46)
        Me.flowLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.flowLayoutPanel.Name = "flowLayoutPanel"
        Me.flowLayoutPanel.Size = New System.Drawing.Size(1280, 1058)
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
        Me.groupboxStandardApps.Location = New System.Drawing.Point(32, 4)
        Me.groupboxStandardApps.Margin = New System.Windows.Forms.Padding(32, 4, 4, 4)
        Me.groupboxStandardApps.Name = "groupboxStandardApps"
        Me.groupboxStandardApps.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxStandardApps.Size = New System.Drawing.Size(380, 996)
        Me.groupboxStandardApps.TabIndex = 0
        Me.groupboxStandardApps.TabStop = False
        Me.groupboxStandardApps.Text = "Standard Apps"
        '
        'buttonRunOneNote
        '
        Me.buttonRunOneNote.Location = New System.Drawing.Point(126, 552)
        Me.buttonRunOneNote.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunOneNote.Name = "buttonRunOneNote"
        Me.buttonRunOneNote.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunOneNote.TabIndex = 9
        Me.buttonRunOneNote.Text = "Microsoft OneNote"
        Me.buttonRunOneNote.UseVisualStyleBackColor = True
        '
        'buttonRunOutlook
        '
        Me.buttonRunOutlook.Location = New System.Drawing.Point(126, 424)
        Me.buttonRunOutlook.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunOutlook.Name = "buttonRunOutlook"
        Me.buttonRunOutlook.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunOutlook.TabIndex = 8
        Me.buttonRunOutlook.Text = "Microsoft Outlook"
        Me.buttonRunOutlook.UseVisualStyleBackColor = True
        '
        'buttonRunPowerPoint
        '
        Me.buttonRunPowerPoint.Location = New System.Drawing.Point(126, 296)
        Me.buttonRunPowerPoint.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunPowerPoint.Name = "buttonRunPowerPoint"
        Me.buttonRunPowerPoint.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunPowerPoint.TabIndex = 7
        Me.buttonRunPowerPoint.Text = "Microsoft PowerPoint"
        Me.buttonRunPowerPoint.UseVisualStyleBackColor = True
        '
        'buttonRunExcel
        '
        Me.buttonRunExcel.Location = New System.Drawing.Point(126, 168)
        Me.buttonRunExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunExcel.Name = "buttonRunExcel"
        Me.buttonRunExcel.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunExcel.TabIndex = 6
        Me.buttonRunExcel.Text = "Microsoft Excel"
        Me.buttonRunExcel.UseVisualStyleBackColor = True
        '
        'buttonRunWord
        '
        Me.buttonRunWord.Location = New System.Drawing.Point(126, 40)
        Me.buttonRunWord.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunWord.Name = "buttonRunWord"
        Me.buttonRunWord.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunWord.TabIndex = 5
        Me.buttonRunWord.Text = "Microsoft Word"
        Me.buttonRunWord.UseVisualStyleBackColor = True
        '
        'pictureOneNoteIcon
        '
        Me.pictureOneNoteIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Onenote
        Me.pictureOneNoteIcon.Location = New System.Drawing.Point(14, 552)
        Me.pictureOneNoteIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureOneNoteIcon.Name = "pictureOneNoteIcon"
        Me.pictureOneNoteIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureOneNoteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureOneNoteIcon.TabIndex = 4
        Me.pictureOneNoteIcon.TabStop = False
        '
        'pictureOutlookIcon
        '
        Me.pictureOutlookIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Outlook
        Me.pictureOutlookIcon.Location = New System.Drawing.Point(14, 424)
        Me.pictureOutlookIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureOutlookIcon.Name = "pictureOutlookIcon"
        Me.pictureOutlookIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureOutlookIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureOutlookIcon.TabIndex = 3
        Me.pictureOutlookIcon.TabStop = False
        '
        'picturePowerpointIcon
        '
        Me.picturePowerpointIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Powerpoint
        Me.picturePowerpointIcon.Location = New System.Drawing.Point(14, 296)
        Me.picturePowerpointIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picturePowerpointIcon.Name = "picturePowerpointIcon"
        Me.picturePowerpointIcon.Size = New System.Drawing.Size(100, 100)
        Me.picturePowerpointIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picturePowerpointIcon.TabIndex = 2
        Me.picturePowerpointIcon.TabStop = False
        '
        'pictureExcelIcon
        '
        Me.pictureExcelIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Excel
        Me.pictureExcelIcon.Location = New System.Drawing.Point(14, 168)
        Me.pictureExcelIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureExcelIcon.Name = "pictureExcelIcon"
        Me.pictureExcelIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureExcelIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureExcelIcon.TabIndex = 1
        Me.pictureExcelIcon.TabStop = False
        '
        'pictureWordIcon
        '
        Me.pictureWordIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Word
        Me.pictureWordIcon.Location = New System.Drawing.Point(14, 40)
        Me.pictureWordIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureWordIcon.Name = "pictureWordIcon"
        Me.pictureWordIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureWordIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureWordIcon.TabIndex = 0
        Me.pictureWordIcon.TabStop = False
        '
        'groupboxProApps
        '
        Me.groupboxProApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxProApps.Controls.Add(Me.buttonRunSharePointWkSp)
        Me.groupboxProApps.Controls.Add(Me.buttonRunAccess)
        Me.groupboxProApps.Controls.Add(Me.buttonRunInfoPath)
        Me.groupboxProApps.Controls.Add(Me.pictureAccessIcon)
        Me.groupboxProApps.Controls.Add(Me.buttonRunPublisher)
        Me.groupboxProApps.Controls.Add(Me.picturePublisherIcon)
        Me.groupboxProApps.Controls.Add(Me.pictureInfoPathIcon)
        Me.groupboxProApps.Controls.Add(Me.pictureSharepointIcon)
        Me.groupboxProApps.Location = New System.Drawing.Point(448, 4)
        Me.groupboxProApps.Margin = New System.Windows.Forms.Padding(32, 4, 4, 4)
        Me.groupboxProApps.Name = "groupboxProApps"
        Me.groupboxProApps.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxProApps.Size = New System.Drawing.Size(380, 996)
        Me.groupboxProApps.TabIndex = 1
        Me.groupboxProApps.TabStop = False
        Me.groupboxProApps.Text = "Professional Apps"
        '
        'buttonRunSharePointWkSp
        '
        Me.buttonRunSharePointWkSp.Location = New System.Drawing.Point(126, 424)
        Me.buttonRunSharePointWkSp.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunSharePointWkSp.Name = "buttonRunSharePointWkSp"
        Me.buttonRunSharePointWkSp.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunSharePointWkSp.TabIndex = 17
        Me.buttonRunSharePointWkSp.Text = "Microsoft SharePoint Workspace"
        Me.buttonRunSharePointWkSp.UseVisualStyleBackColor = True
        '
        'buttonRunAccess
        '
        Me.buttonRunAccess.Location = New System.Drawing.Point(126, 40)
        Me.buttonRunAccess.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunAccess.Name = "buttonRunAccess"
        Me.buttonRunAccess.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunAccess.TabIndex = 14
        Me.buttonRunAccess.Text = "Microsoft Access"
        Me.buttonRunAccess.UseVisualStyleBackColor = True
        '
        'buttonRunInfoPath
        '
        Me.buttonRunInfoPath.Location = New System.Drawing.Point(126, 296)
        Me.buttonRunInfoPath.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunInfoPath.Name = "buttonRunInfoPath"
        Me.buttonRunInfoPath.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunInfoPath.TabIndex = 16
        Me.buttonRunInfoPath.Text = "Microsoft InfoPath"
        Me.buttonRunInfoPath.UseVisualStyleBackColor = True
        '
        'pictureAccessIcon
        '
        Me.pictureAccessIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Access
        Me.pictureAccessIcon.Location = New System.Drawing.Point(14, 40)
        Me.pictureAccessIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureAccessIcon.Name = "pictureAccessIcon"
        Me.pictureAccessIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureAccessIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureAccessIcon.TabIndex = 10
        Me.pictureAccessIcon.TabStop = False
        '
        'buttonRunPublisher
        '
        Me.buttonRunPublisher.Location = New System.Drawing.Point(126, 168)
        Me.buttonRunPublisher.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunPublisher.Name = "buttonRunPublisher"
        Me.buttonRunPublisher.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunPublisher.TabIndex = 15
        Me.buttonRunPublisher.Text = "Microsoft Publisher"
        Me.buttonRunPublisher.UseVisualStyleBackColor = True
        '
        'picturePublisherIcon
        '
        Me.picturePublisherIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Publisher
        Me.picturePublisherIcon.Location = New System.Drawing.Point(14, 168)
        Me.picturePublisherIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picturePublisherIcon.Name = "picturePublisherIcon"
        Me.picturePublisherIcon.Size = New System.Drawing.Size(100, 100)
        Me.picturePublisherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picturePublisherIcon.TabIndex = 11
        Me.picturePublisherIcon.TabStop = False
        '
        'pictureInfoPathIcon
        '
        Me.pictureInfoPathIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Infopath
        Me.pictureInfoPathIcon.Location = New System.Drawing.Point(14, 296)
        Me.pictureInfoPathIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureInfoPathIcon.Name = "pictureInfoPathIcon"
        Me.pictureInfoPathIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureInfoPathIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureInfoPathIcon.TabIndex = 12
        Me.pictureInfoPathIcon.TabStop = False
        '
        'pictureSharepointIcon
        '
        Me.pictureSharepointIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Sharepoint_Workspace
        Me.pictureSharepointIcon.Location = New System.Drawing.Point(14, 424)
        Me.pictureSharepointIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureSharepointIcon.Name = "pictureSharepointIcon"
        Me.pictureSharepointIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureSharepointIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureSharepointIcon.TabIndex = 13
        Me.pictureSharepointIcon.TabStop = False
        '
        'groupboxExtraApps
        '
        Me.groupboxExtraApps.BackColor = System.Drawing.Color.Transparent
        Me.groupboxExtraApps.Controls.Add(Me.buttonRunOneNoteQuickLaunch)
        Me.groupboxExtraApps.Controls.Add(Me.pictureQueryIcon)
        Me.groupboxExtraApps.Controls.Add(Me.buttonRunQuery)
        Me.groupboxExtraApps.Controls.Add(Me.pictureOneNoteQuickLaunchIcon)
        Me.groupboxExtraApps.Controls.Add(Me.buttonRunPictureManager)
        Me.groupboxExtraApps.Controls.Add(Me.picturePictureManagerIcon)
        Me.groupboxExtraApps.Controls.Add(Me.pictureClipOrganizerIcon)
        Me.groupboxExtraApps.Controls.Add(Me.buttonRunClipOrganizer)
        Me.groupboxExtraApps.Location = New System.Drawing.Point(864, 4)
        Me.groupboxExtraApps.Margin = New System.Windows.Forms.Padding(32, 4, 4, 4)
        Me.groupboxExtraApps.Name = "groupboxExtraApps"
        Me.groupboxExtraApps.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxExtraApps.Size = New System.Drawing.Size(380, 996)
        Me.groupboxExtraApps.TabIndex = 2
        Me.groupboxExtraApps.TabStop = False
        Me.groupboxExtraApps.Text = "Extra Apps + Tools"
        '
        'buttonRunOneNoteQuickLaunch
        '
        Me.buttonRunOneNoteQuickLaunch.Location = New System.Drawing.Point(126, 424)
        Me.buttonRunOneNoteQuickLaunch.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunOneNoteQuickLaunch.Name = "buttonRunOneNoteQuickLaunch"
        Me.buttonRunOneNoteQuickLaunch.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunOneNoteQuickLaunch.TabIndex = 25
        Me.buttonRunOneNoteQuickLaunch.Text = "OneNote Quick Launch"
        Me.buttonRunOneNoteQuickLaunch.UseVisualStyleBackColor = True
        '
        'pictureQueryIcon
        '
        Me.pictureQueryIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Microsoft_Query
        Me.pictureQueryIcon.Location = New System.Drawing.Point(14, 40)
        Me.pictureQueryIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureQueryIcon.Name = "pictureQueryIcon"
        Me.pictureQueryIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureQueryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureQueryIcon.TabIndex = 18
        Me.pictureQueryIcon.TabStop = False
        '
        'buttonRunQuery
        '
        Me.buttonRunQuery.Location = New System.Drawing.Point(126, 40)
        Me.buttonRunQuery.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunQuery.Name = "buttonRunQuery"
        Me.buttonRunQuery.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunQuery.TabIndex = 22
        Me.buttonRunQuery.Text = "Microsoft Query"
        Me.buttonRunQuery.UseVisualStyleBackColor = True
        '
        'pictureOneNoteQuickLaunchIcon
        '
        Me.pictureOneNoteQuickLaunchIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Onenote
        Me.pictureOneNoteQuickLaunchIcon.Location = New System.Drawing.Point(14, 424)
        Me.pictureOneNoteQuickLaunchIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureOneNoteQuickLaunchIcon.Name = "pictureOneNoteQuickLaunchIcon"
        Me.pictureOneNoteQuickLaunchIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureOneNoteQuickLaunchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureOneNoteQuickLaunchIcon.TabIndex = 21
        Me.pictureOneNoteQuickLaunchIcon.TabStop = False
        '
        'buttonRunPictureManager
        '
        Me.buttonRunPictureManager.Location = New System.Drawing.Point(126, 296)
        Me.buttonRunPictureManager.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunPictureManager.Name = "buttonRunPictureManager"
        Me.buttonRunPictureManager.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunPictureManager.TabIndex = 24
        Me.buttonRunPictureManager.Text = "Microsoft Picture Manager"
        Me.buttonRunPictureManager.UseVisualStyleBackColor = True
        '
        'picturePictureManagerIcon
        '
        Me.picturePictureManagerIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Picture_Manager
        Me.picturePictureManagerIcon.Location = New System.Drawing.Point(14, 296)
        Me.picturePictureManagerIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.picturePictureManagerIcon.Name = "picturePictureManagerIcon"
        Me.picturePictureManagerIcon.Size = New System.Drawing.Size(100, 100)
        Me.picturePictureManagerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picturePictureManagerIcon.TabIndex = 20
        Me.picturePictureManagerIcon.TabStop = False
        '
        'pictureClipOrganizerIcon
        '
        Me.pictureClipOrganizerIcon.Image = Global.UXL_Launcher.My.Resources.Resources.Clip_Organizer
        Me.pictureClipOrganizerIcon.Location = New System.Drawing.Point(14, 170)
        Me.pictureClipOrganizerIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.pictureClipOrganizerIcon.Name = "pictureClipOrganizerIcon"
        Me.pictureClipOrganizerIcon.Size = New System.Drawing.Size(100, 100)
        Me.pictureClipOrganizerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureClipOrganizerIcon.TabIndex = 19
        Me.pictureClipOrganizerIcon.TabStop = False
        '
        'buttonRunClipOrganizer
        '
        Me.buttonRunClipOrganizer.Location = New System.Drawing.Point(126, 168)
        Me.buttonRunClipOrganizer.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonRunClipOrganizer.Name = "buttonRunClipOrganizer"
        Me.buttonRunClipOrganizer.Size = New System.Drawing.Size(210, 100)
        Me.buttonRunClipOrganizer.TabIndex = 23
        Me.buttonRunClipOrganizer.Text = "Microsoft Clip Organizer"
        Me.buttonRunClipOrganizer.UseVisualStyleBackColor = True
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1280, 1104)
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
        Me.groupboxProApps.ResumeLayout(False)
        CType(Me.pictureAccessIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturePublisherIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureInfoPathIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureSharepointIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxExtraApps.ResumeLayout(False)
        CType(Me.pictureQueryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureOneNoteQuickLaunchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picturePictureManagerIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureClipOrganizerIcon, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents buttonRunSharePointWkSp As Button
    Friend WithEvents buttonRunAccess As Button
    Friend WithEvents buttonRunInfoPath As Button
    Friend WithEvents pictureAccessIcon As PictureBox
    Friend WithEvents buttonRunPublisher As Button
    Friend WithEvents picturePublisherIcon As PictureBox
    Friend WithEvents pictureInfoPathIcon As PictureBox
    Friend WithEvents pictureSharepointIcon As PictureBox
    Friend WithEvents buttonRunOneNoteQuickLaunch As Button
    Friend WithEvents pictureQueryIcon As PictureBox
    Friend WithEvents buttonRunQuery As Button
    Friend WithEvents pictureOneNoteQuickLaunchIcon As PictureBox
    Friend WithEvents buttonRunPictureManager As Button
    Friend WithEvents picturePictureManagerIcon As PictureBox
    Friend WithEvents pictureClipOrganizerIcon As PictureBox
    Friend WithEvents buttonRunClipOrganizer As Button
End Class
