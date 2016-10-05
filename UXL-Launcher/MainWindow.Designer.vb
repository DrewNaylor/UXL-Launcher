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
        Me.groupboxProApps = New System.Windows.Forms.GroupBox()
        Me.menubarMainWindow.SuspendLayout()
        Me.statusbarMainWindow.SuspendLayout()
        Me.flowLayoutPanel.SuspendLayout()
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
        Me.menubarMainWindow.Size = New System.Drawing.Size(1412, 44)
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
        Me.statusbarMainWindow.Size = New System.Drawing.Size(1412, 37)
        Me.statusbarMainWindow.TabIndex = 1
        Me.statusbarMainWindow.Text = "StatusStrip1"
        '
        'statusbarLabelWelcomeText
        '
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
        Me.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanel.Location = New System.Drawing.Point(0, 44)
        Me.flowLayoutPanel.Name = "flowLayoutPanel"
        Me.flowLayoutPanel.Size = New System.Drawing.Size(1412, 981)
        Me.flowLayoutPanel.TabIndex = 2
        '
        'groupboxStandardApps
        '
        Me.groupboxStandardApps.Location = New System.Drawing.Point(10, 3)
        Me.groupboxStandardApps.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.groupboxStandardApps.Name = "groupboxStandardApps"
        Me.groupboxStandardApps.Size = New System.Drawing.Size(380, 958)
        Me.groupboxStandardApps.TabIndex = 0
        Me.groupboxStandardApps.TabStop = False
        Me.groupboxStandardApps.Text = "Standard Apps"
        '
        'groupboxProApps
        '
        Me.groupboxProApps.Location = New System.Drawing.Point(426, 3)
        Me.groupboxProApps.Margin = New System.Windows.Forms.Padding(33, 3, 3, 3)
        Me.groupboxProApps.Name = "groupboxProApps"
        Me.groupboxProApps.Size = New System.Drawing.Size(380, 958)
        Me.groupboxProApps.TabIndex = 1
        Me.groupboxProApps.TabStop = False
        Me.groupboxProApps.Text = "Professional Apps"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1412, 1062)
        Me.Controls.Add(Me.flowLayoutPanel)
        Me.Controls.Add(Me.statusbarMainWindow)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "aaformMainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UXL Launcher REMEMBER TO PUT 32-BIT OR 64-BIT MODE HERE"
        Me.menubarMainWindow.ResumeLayout(False)
        Me.menubarMainWindow.PerformLayout()
        Me.statusbarMainWindow.ResumeLayout(False)
        Me.statusbarMainWindow.PerformLayout()
        Me.flowLayoutPanel.ResumeLayout(False)
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
End Class
