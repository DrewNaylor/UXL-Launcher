<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.menubarMainWindow = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuthorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelWhiteBackPanel = New System.Windows.Forms.Panel()
        Me.statusStripMainWindow = New System.Windows.Forms.StatusStrip()
        Me.statusStripLabelWelcomeText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.groupboxExtraApps = New System.Windows.Forms.GroupBox()
        Me.groupboxProApps = New System.Windows.Forms.GroupBox()
        Me.groupboxStandardApps = New System.Windows.Forms.GroupBox()
        Me.menubarMainWindow.SuspendLayout()
        Me.panelWhiteBackPanel.SuspendLayout()
        Me.statusStripMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'menubarMainWindow
        '
        Me.menubarMainWindow.BackColor = System.Drawing.SystemColors.Control
        Me.menubarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuButton, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menubarMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menubarMainWindow.Name = "menubarMainWindow"
        Me.menubarMainWindow.Size = New System.Drawing.Size(696, 24)
        Me.menubarMainWindow.TabIndex = 0
        Me.menubarMainWindow.Text = "MenuStrip1"
        '
        'FileToolStripMenuButton
        '
        Me.FileToolStripMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuButton.Name = "FileToolStripMenuButton"
        Me.FileToolStripMenuButton.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuButton.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AuthorsToolStripMenuItem, Me.LicenseToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AuthorsToolStripMenuItem
        '
        Me.AuthorsToolStripMenuItem.Name = "AuthorsToolStripMenuItem"
        Me.AuthorsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AuthorsToolStripMenuItem.Text = "Authors"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'panelWhiteBackPanel
        '
        Me.panelWhiteBackPanel.BackColor = System.Drawing.Color.White
        Me.panelWhiteBackPanel.Controls.Add(Me.statusStripMainWindow)
        Me.panelWhiteBackPanel.Controls.Add(Me.groupboxExtraApps)
        Me.panelWhiteBackPanel.Controls.Add(Me.groupboxProApps)
        Me.panelWhiteBackPanel.Controls.Add(Me.groupboxStandardApps)
        Me.panelWhiteBackPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelWhiteBackPanel.Location = New System.Drawing.Point(0, 24)
        Me.panelWhiteBackPanel.Name = "panelWhiteBackPanel"
        Me.panelWhiteBackPanel.Size = New System.Drawing.Size(696, 518)
        Me.panelWhiteBackPanel.TabIndex = 1
        '
        'statusStripMainWindow
        '
        Me.statusStripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusStripLabelWelcomeText})
        Me.statusStripMainWindow.Location = New System.Drawing.Point(0, 496)
        Me.statusStripMainWindow.Name = "statusStripMainWindow"
        Me.statusStripMainWindow.Size = New System.Drawing.Size(696, 22)
        Me.statusStripMainWindow.TabIndex = 0
        Me.statusStripMainWindow.Text = "StatusStrip1"
        '
        'statusStripLabelWelcomeText
        '
        Me.statusStripLabelWelcomeText.BackColor = System.Drawing.Color.Transparent
        Me.statusStripLabelWelcomeText.Name = "statusStripLabelWelcomeText"
        Me.statusStripLabelWelcomeText.Size = New System.Drawing.Size(619, 17)
        Me.statusStripLabelWelcomeText.Text = "Welcome to UXL, the Unified eXecutable Launcher! Click the buttons to launch the " &
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
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 542)
        Me.Controls.Add(Me.panelWhiteBackPanel)
        Me.Controls.Add(Me.menubarMainWindow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menubarMainWindow
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UXL Launcher REMEMBER TO PUT 32-BIT OR 64-BIT MODE HERE"
        Me.menubarMainWindow.ResumeLayout(False)
        Me.menubarMainWindow.PerformLayout()
        Me.panelWhiteBackPanel.ResumeLayout(False)
        Me.panelWhiteBackPanel.PerformLayout()
        Me.statusStripMainWindow.ResumeLayout(False)
        Me.statusStripMainWindow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menubarMainWindow As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuButton As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelWhiteBackPanel As Panel
    Friend WithEvents AuthorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents statusStripMainWindow As StatusStrip
    Friend WithEvents statusStripLabelWelcomeText As ToolStripStatusLabel
    Friend WithEvents groupboxStandardApps As GroupBox
    Friend WithEvents groupboxProApps As GroupBox
    Friend WithEvents groupboxExtraApps As GroupBox
End Class
