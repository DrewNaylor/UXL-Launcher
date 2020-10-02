<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformOptionsWindow
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformOptionsWindow))
        Me.tableLayoutPanelOptionsWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonSaveSettings = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.tabcontrolOptionsWindow = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxBypassConfiguredLocation = New System.Windows.Forms.GroupBox()
        Me.radiobuttonBypassConfiguredLocationAllApps = New System.Windows.Forms.RadioButton()
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps = New System.Windows.Forms.RadioButton()
        Me.radiobuttonDontBypassConfiguredLocation = New System.Windows.Forms.RadioButton()
        Me.labelBypassConfiguredLocation = New System.Windows.Forms.Label()
        Me.groupboxOfficeVersion = New System.Windows.Forms.GroupBox()
        Me.labelOffice365Compatibility = New System.Windows.Forms.Label()
        Me.checkboxO365InstallMethod = New System.Windows.Forms.CheckBox()
        Me.labelUserHasThisOfficeVersion = New System.Windows.Forms.Label()
        Me.comboboxOfficeVersionSelector = New System.Windows.Forms.ComboBox()
        Me.tabpageAdvanced = New System.Windows.Forms.TabPage()
        Me.groupboxOfficeLocation = New System.Windows.Forms.GroupBox()
        Me.labelDriveNotAvailable = New System.Windows.Forms.Label()
        Me.buttonRefreshDriveLetterList = New System.Windows.Forms.Button()
        Me.comboboxDriveSelector = New System.Windows.Forms.ComboBox()
        Me.labelDriveTextboxLabel = New System.Windows.Forms.Label()
        Me.labelOfficeInstalledToDrive = New System.Windows.Forms.Label()
        Me.groupboxCPUType = New System.Windows.Forms.GroupBox()
        Me.labelRecommendedWindowsEdition = New System.Windows.Forms.Label()
        Me.radiobuttonCPUIsQBit = New System.Windows.Forms.RadioButton()
        Me.radiobuttonUseProgramFilesX86 = New System.Windows.Forms.RadioButton()
        Me.radiobuttonUseProgramFiles = New System.Windows.Forms.RadioButton()
        Me.labelPFPathDescription = New System.Windows.Forms.Label()
        Me.tabpagePersonalization = New System.Windows.Forms.TabPage()
        Me.groupboxDefaultDarkTheme = New System.Windows.Forms.GroupBox()
        Me.comboboxDarkThemesForSystemThemeMatchingList = New System.Windows.Forms.ComboBox()
        Me.labelDefaultDarkThemeDescription = New System.Windows.Forms.Label()
        Me.groupboxAppearance = New System.Windows.Forms.GroupBox()
        Me.checkboxMatchWindows10ThemeSettings = New System.Windows.Forms.CheckBox()
        Me.labelCustomThemePath = New System.Windows.Forms.Label()
        Me.buttonCustomThemesBrowse = New System.Windows.Forms.Button()
        Me.textboxCustomThemePath = New System.Windows.Forms.TextBox()
        Me.labelThemeList = New System.Windows.Forms.Label()
        Me.comboboxThemeList = New System.Windows.Forms.ComboBox()
        Me.textboxThemeInfo = New System.Windows.Forms.TextBox()
        Me.checkboxEnableThemeEngine = New System.Windows.Forms.CheckBox()
        Me.tabpageStatusbar = New System.Windows.Forms.TabPage()
        Me.groupboxStatusbar = New System.Windows.Forms.GroupBox()
        Me.buttonClearFirstname = New System.Windows.Forms.Button()
        Me.labelFirstName = New System.Windows.Forms.Label()
        Me.textboxFirstname = New System.Windows.Forms.TextBox()
        Me.radiobuttonCustomStatusbarGreeting = New System.Windows.Forms.RadioButton()
        Me.radiobuttonDefaultStatusbarGreeting = New System.Windows.Forms.RadioButton()
        Me.labelCustomStatusbarGreeting = New System.Windows.Forms.Label()
        Me.tabpageMaintenance = New System.Windows.Forms.TabPage()
        Me.buttonUpgradeSettings = New System.Windows.Forms.Button()
        Me.buttonTestSettings = New System.Windows.Forms.Button()
        Me.buttonDefaultSettings = New System.Windows.Forms.Button()
        Me.tooltipO365InstallMethod = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipSystemInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.openfiledialogBrowseCustomThemeFile = New System.Windows.Forms.OpenFileDialog()
        Me.tooltipCustomThemePath = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipMatchWindows10ThemeSettings = New System.Windows.Forms.ToolTip(Me.components)
        Me.labelMigrateSettings = New System.Windows.Forms.Label()
        Me.tableLayoutPanelOptionsWindow.SuspendLayout()
        Me.tabcontrolOptionsWindow.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxBypassConfiguredLocation.SuspendLayout()
        Me.groupboxOfficeVersion.SuspendLayout()
        Me.tabpageAdvanced.SuspendLayout()
        Me.groupboxOfficeLocation.SuspendLayout()
        Me.groupboxCPUType.SuspendLayout()
        Me.tabpagePersonalization.SuspendLayout()
        Me.groupboxDefaultDarkTheme.SuspendLayout()
        Me.groupboxAppearance.SuspendLayout()
        Me.tabpageStatusbar.SuspendLayout()
        Me.groupboxStatusbar.SuspendLayout()
        Me.tabpageMaintenance.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanelOptionsWindow
        '
        Me.tableLayoutPanelOptionsWindow.ColumnCount = 5
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonSaveSettings, 4, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonCancel, 3, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.tabcontrolOptionsWindow, 0, 0)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonTestSettings, 1, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonDefaultSettings, 0, 1)
        Me.tableLayoutPanelOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelOptionsWindow.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanelOptionsWindow.Margin = New System.Windows.Forms.Padding(2)
        Me.tableLayoutPanelOptionsWindow.Name = "tableLayoutPanelOptionsWindow"
        Me.tableLayoutPanelOptionsWindow.RowCount = 2
        Me.tableLayoutPanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.0!))
        Me.tableLayoutPanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.tableLayoutPanelOptionsWindow.Size = New System.Drawing.Size(446, 394)
        Me.tableLayoutPanelOptionsWindow.TabIndex = 0
        '
        'buttonSaveSettings
        '
        Me.buttonSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonSaveSettings.AutoSize = True
        Me.buttonSaveSettings.Location = New System.Drawing.Point(368, 364)
        Me.buttonSaveSettings.Margin = New System.Windows.Forms.Padding(2, 2, 8, 2)
        Me.buttonSaveSettings.Name = "buttonSaveSettings"
        Me.buttonSaveSettings.Size = New System.Drawing.Size(70, 28)
        Me.buttonSaveSettings.TabIndex = 7
        Me.buttonSaveSettings.Text = "Save"
        Me.buttonSaveSettings.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonCancel.AutoSize = True
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(292, 364)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(72, 28)
        Me.buttonCancel.TabIndex = 8
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'tabcontrolOptionsWindow
        '
        Me.tableLayoutPanelOptionsWindow.SetColumnSpan(Me.tabcontrolOptionsWindow, 5)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageAdvanced)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpagePersonalization)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageStatusbar)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageMaintenance)
        Me.tabcontrolOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptionsWindow.Location = New System.Drawing.Point(8, 8)
        Me.tabcontrolOptionsWindow.Margin = New System.Windows.Forms.Padding(8, 8, 8, 2)
        Me.tabcontrolOptionsWindow.Name = "tabcontrolOptionsWindow"
        Me.tabcontrolOptionsWindow.SelectedIndex = 0
        Me.tabcontrolOptionsWindow.Size = New System.Drawing.Size(430, 352)
        Me.tabcontrolOptionsWindow.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxBypassConfiguredLocation)
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeVersion)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabpageGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageGeneral.Size = New System.Drawing.Size(422, 326)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "Versions + Compatibility"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxBypassConfiguredLocation
        '
        Me.groupboxBypassConfiguredLocation.Controls.Add(Me.radiobuttonBypassConfiguredLocationAllApps)
        Me.groupboxBypassConfiguredLocation.Controls.Add(Me.radiobuttonBypassConfiguredLocationDeprecatedApps)
        Me.groupboxBypassConfiguredLocation.Controls.Add(Me.radiobuttonDontBypassConfiguredLocation)
        Me.groupboxBypassConfiguredLocation.Controls.Add(Me.labelBypassConfiguredLocation)
        Me.groupboxBypassConfiguredLocation.Location = New System.Drawing.Point(4, 147)
        Me.groupboxBypassConfiguredLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxBypassConfiguredLocation.Name = "groupboxBypassConfiguredLocation"
        Me.groupboxBypassConfiguredLocation.Size = New System.Drawing.Size(415, 175)
        Me.groupboxBypassConfiguredLocation.TabIndex = 2
        Me.groupboxBypassConfiguredLocation.TabStop = False
        Me.groupboxBypassConfiguredLocation.Text = "Bypass configured location"
        '
        'radiobuttonBypassConfiguredLocationAllApps
        '
        Me.radiobuttonBypassConfiguredLocationAllApps.AutoSize = True
        Me.radiobuttonBypassConfiguredLocationAllApps.Location = New System.Drawing.Point(41, 129)
        Me.radiobuttonBypassConfiguredLocationAllApps.Name = "radiobuttonBypassConfiguredLocationAllApps"
        Me.radiobuttonBypassConfiguredLocationAllApps.Size = New System.Drawing.Size(206, 17)
        Me.radiobuttonBypassConfiguredLocationAllApps.TabIndex = 2
        Me.radiobuttonBypassConfiguredLocationAllApps.TabStop = True
        Me.radiobuttonBypassConfiguredLocationAllApps.Text = "Bypass configured location for all apps"
        Me.radiobuttonBypassConfiguredLocationAllApps.UseVisualStyleBackColor = True
        '
        'radiobuttonBypassConfiguredLocationDeprecatedApps
        '
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.AutoSize = True
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Location = New System.Drawing.Point(41, 106)
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Name = "radiobuttonBypassConfiguredLocationDeprecatedApps"
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Size = New System.Drawing.Size(296, 17)
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.TabIndex = 2
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.TabStop = True
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Text = "Bypass configured location for deprecated/removed apps"
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.UseVisualStyleBackColor = True
        '
        'radiobuttonDontBypassConfiguredLocation
        '
        Me.radiobuttonDontBypassConfiguredLocation.AutoSize = True
        Me.radiobuttonDontBypassConfiguredLocation.Location = New System.Drawing.Point(41, 83)
        Me.radiobuttonDontBypassConfiguredLocation.Name = "radiobuttonDontBypassConfiguredLocation"
        Me.radiobuttonDontBypassConfiguredLocation.Size = New System.Drawing.Size(179, 17)
        Me.radiobuttonDontBypassConfiguredLocation.TabIndex = 2
        Me.radiobuttonDontBypassConfiguredLocation.TabStop = True
        Me.radiobuttonDontBypassConfiguredLocation.Text = "Don't bypass configured location"
        Me.radiobuttonDontBypassConfiguredLocation.UseVisualStyleBackColor = True
        '
        'labelBypassConfiguredLocation
        '
        Me.labelBypassConfiguredLocation.AutoSize = True
        Me.labelBypassConfiguredLocation.Location = New System.Drawing.Point(38, 28)
        Me.labelBypassConfiguredLocation.Name = "labelBypassConfiguredLocation"
        Me.labelBypassConfiguredLocation.Size = New System.Drawing.Size(339, 52)
        Me.labelBypassConfiguredLocation.TabIndex = 0
        Me.labelBypassConfiguredLocation.Text = resources.GetString("labelBypassConfiguredLocation.Text")
        '
        'groupboxOfficeVersion
        '
        Me.groupboxOfficeVersion.Controls.Add(Me.labelOffice365Compatibility)
        Me.groupboxOfficeVersion.Controls.Add(Me.checkboxO365InstallMethod)
        Me.groupboxOfficeVersion.Controls.Add(Me.labelUserHasThisOfficeVersion)
        Me.groupboxOfficeVersion.Controls.Add(Me.comboboxOfficeVersionSelector)
        Me.groupboxOfficeVersion.Location = New System.Drawing.Point(4, 4)
        Me.groupboxOfficeVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeVersion.Name = "groupboxOfficeVersion"
        Me.groupboxOfficeVersion.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeVersion.Size = New System.Drawing.Size(415, 139)
        Me.groupboxOfficeVersion.TabIndex = 1
        Me.groupboxOfficeVersion.TabStop = False
        Me.groupboxOfficeVersion.Text = "Microsoft Office versions + C2R"
        '
        'labelOffice365Compatibility
        '
        Me.labelOffice365Compatibility.AutoSize = True
        Me.labelOffice365Compatibility.Location = New System.Drawing.Point(76, 64)
        Me.labelOffice365Compatibility.Name = "labelOffice365Compatibility"
        Me.labelOffice365Compatibility.Size = New System.Drawing.Size(272, 26)
        Me.labelOffice365Compatibility.TabIndex = 6
        Me.labelOffice365Compatibility.Text = "Most people install Office from Office 365/Microsoft 365," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "so you may need to che" &
    "ck this box:"
        '
        'checkboxO365InstallMethod
        '
        Me.checkboxO365InstallMethod.AutoSize = True
        Me.checkboxO365InstallMethod.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxO365InstallMethod.Location = New System.Drawing.Point(79, 92)
        Me.checkboxO365InstallMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxO365InstallMethod.Name = "checkboxO365InstallMethod"
        Me.checkboxO365InstallMethod.Size = New System.Drawing.Size(235, 30)
        Me.checkboxO365InstallMethod.TabIndex = 1
        Me.checkboxO365InstallMethod.Text = "Enable Office 365/Click-to-Run Compatibility" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Always enabled for 2019 and above)" &
    ""
        Me.tooltipO365InstallMethod.SetToolTip(Me.checkboxO365InstallMethod, resources.GetString("checkboxO365InstallMethod.ToolTip"))
        Me.checkboxO365InstallMethod.UseVisualStyleBackColor = True
        '
        'labelUserHasThisOfficeVersion
        '
        Me.labelUserHasThisOfficeVersion.AutoSize = True
        Me.labelUserHasThisOfficeVersion.Location = New System.Drawing.Point(76, 16)
        Me.labelUserHasThisOfficeVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelUserHasThisOfficeVersion.Name = "labelUserHasThisOfficeVersion"
        Me.labelUserHasThisOfficeVersion.Size = New System.Drawing.Size(263, 13)
        Me.labelUserHasThisOfficeVersion.TabIndex = 2
        Me.labelUserHasThisOfficeVersion.Text = "Please select your installed version of Microsoft Office:"
        '
        'comboboxOfficeVersionSelector
        '
        Me.comboboxOfficeVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOfficeVersionSelector.FormattingEnabled = True
        Me.comboboxOfficeVersionSelector.Location = New System.Drawing.Point(79, 31)
        Me.comboboxOfficeVersionSelector.Margin = New System.Windows.Forms.Padding(2)
        Me.comboboxOfficeVersionSelector.Name = "comboboxOfficeVersionSelector"
        Me.comboboxOfficeVersionSelector.Size = New System.Drawing.Size(138, 21)
        Me.comboboxOfficeVersionSelector.TabIndex = 0
        '
        'tabpageAdvanced
        '
        Me.tabpageAdvanced.Controls.Add(Me.groupboxOfficeLocation)
        Me.tabpageAdvanced.Controls.Add(Me.groupboxCPUType)
        Me.tabpageAdvanced.Location = New System.Drawing.Point(4, 22)
        Me.tabpageAdvanced.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageAdvanced.Name = "tabpageAdvanced"
        Me.tabpageAdvanced.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageAdvanced.Size = New System.Drawing.Size(422, 326)
        Me.tabpageAdvanced.TabIndex = 1
        Me.tabpageAdvanced.Text = "Root Path"
        Me.tabpageAdvanced.UseVisualStyleBackColor = True
        '
        'groupboxOfficeLocation
        '
        Me.groupboxOfficeLocation.Controls.Add(Me.labelDriveNotAvailable)
        Me.groupboxOfficeLocation.Controls.Add(Me.buttonRefreshDriveLetterList)
        Me.groupboxOfficeLocation.Controls.Add(Me.comboboxDriveSelector)
        Me.groupboxOfficeLocation.Controls.Add(Me.labelDriveTextboxLabel)
        Me.groupboxOfficeLocation.Controls.Add(Me.labelOfficeInstalledToDrive)
        Me.groupboxOfficeLocation.Location = New System.Drawing.Point(4, 4)
        Me.groupboxOfficeLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeLocation.Name = "groupboxOfficeLocation"
        Me.groupboxOfficeLocation.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeLocation.Size = New System.Drawing.Size(415, 122)
        Me.groupboxOfficeLocation.TabIndex = 0
        Me.groupboxOfficeLocation.TabStop = False
        Me.groupboxOfficeLocation.Text = "Root drive path"
        '
        'labelDriveNotAvailable
        '
        Me.labelDriveNotAvailable.AutoSize = True
        Me.labelDriveNotAvailable.Location = New System.Drawing.Point(128, 85)
        Me.labelDriveNotAvailable.Name = "labelDriveNotAvailable"
        Me.labelDriveNotAvailable.Size = New System.Drawing.Size(99, 13)
        Me.labelDriveNotAvailable.TabIndex = 5
        Me.labelDriveNotAvailable.Text = "*Drive not available"
        '
        'buttonRefreshDriveLetterList
        '
        Me.buttonRefreshDriveLetterList.Location = New System.Drawing.Point(178, 59)
        Me.buttonRefreshDriveLetterList.Name = "buttonRefreshDriveLetterList"
        Me.buttonRefreshDriveLetterList.Size = New System.Drawing.Size(58, 23)
        Me.buttonRefreshDriveLetterList.TabIndex = 1
        Me.buttonRefreshDriveLetterList.Text = "Refresh"
        Me.buttonRefreshDriveLetterList.UseVisualStyleBackColor = True
        '
        'comboboxDriveSelector
        '
        Me.comboboxDriveSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDriveSelector.FormattingEnabled = True
        Me.comboboxDriveSelector.Location = New System.Drawing.Point(131, 61)
        Me.comboboxDriveSelector.Name = "comboboxDriveSelector"
        Me.comboboxDriveSelector.Size = New System.Drawing.Size(41, 21)
        Me.comboboxDriveSelector.TabIndex = 0
        '
        'labelDriveTextboxLabel
        '
        Me.labelDriveTextboxLabel.AutoSize = True
        Me.labelDriveTextboxLabel.Location = New System.Drawing.Point(93, 64)
        Me.labelDriveTextboxLabel.Name = "labelDriveTextboxLabel"
        Me.labelDriveTextboxLabel.Size = New System.Drawing.Size(32, 13)
        Me.labelDriveTextboxLabel.TabIndex = 4
        Me.labelDriveTextboxLabel.Text = "Drive"
        '
        'labelOfficeInstalledToDrive
        '
        Me.labelOfficeInstalledToDrive.AutoSize = True
        Me.labelOfficeInstalledToDrive.Location = New System.Drawing.Point(93, 41)
        Me.labelOfficeInstalledToDrive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelOfficeInstalledToDrive.Name = "labelOfficeInstalledToDrive"
        Me.labelOfficeInstalledToDrive.Size = New System.Drawing.Size(228, 13)
        Me.labelOfficeInstalledToDrive.TabIndex = 1
        Me.labelOfficeInstalledToDrive.Text = "Please choose the drive you installed Office to:"
        '
        'groupboxCPUType
        '
        Me.groupboxCPUType.Controls.Add(Me.labelRecommendedWindowsEdition)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIsQBit)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonUseProgramFilesX86)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonUseProgramFiles)
        Me.groupboxCPUType.Controls.Add(Me.labelPFPathDescription)
        Me.groupboxCPUType.Location = New System.Drawing.Point(4, 130)
        Me.groupboxCPUType.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxCPUType.Name = "groupboxCPUType"
        Me.groupboxCPUType.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxCPUType.Size = New System.Drawing.Size(415, 192)
        Me.groupboxCPUType.TabIndex = 1
        Me.groupboxCPUType.TabStop = False
        Me.groupboxCPUType.Text = "Program Files path"
        '
        'labelRecommendedWindowsEdition
        '
        Me.labelRecommendedWindowsEdition.AutoSize = True
        Me.labelRecommendedWindowsEdition.Location = New System.Drawing.Point(36, 101)
        Me.labelRecommendedWindowsEdition.Name = "labelRecommendedWindowsEdition"
        Me.labelRecommendedWindowsEdition.Size = New System.Drawing.Size(369, 65)
        Me.labelRecommendedWindowsEdition.TabIndex = 5
        Me.labelRecommendedWindowsEdition.Text = resources.GetString("labelRecommendedWindowsEdition.Text")
        '
        'radiobuttonCPUIsQBit
        '
        Me.radiobuttonCPUIsQBit.AutoSize = True
        Me.radiobuttonCPUIsQBit.Location = New System.Drawing.Point(450, 160)
        Me.radiobuttonCPUIsQBit.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonCPUIsQBit.Name = "radiobuttonCPUIsQBit"
        Me.radiobuttonCPUIsQBit.Size = New System.Drawing.Size(432, 17)
        Me.radiobuttonCPUIsQBit.TabIndex = 4
        Me.radiobuttonCPUIsQBit.TabStop = True
        Me.radiobuttonCPUIsQBit.Text = "I'm running Quantum-bit Windows lawl. (Thank you for finding this hidden radio bu" &
    "tton!)"
        Me.radiobuttonCPUIsQBit.UseVisualStyleBackColor = True
        '
        'radiobuttonUseProgramFilesX86
        '
        Me.radiobuttonUseProgramFilesX86.AutoSize = True
        Me.radiobuttonUseProgramFilesX86.Location = New System.Drawing.Point(39, 70)
        Me.radiobuttonUseProgramFilesX86.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonUseProgramFilesX86.Name = "radiobuttonUseProgramFilesX86"
        Me.radiobuttonUseProgramFilesX86.Size = New System.Drawing.Size(268, 17)
        Me.radiobuttonUseProgramFilesX86.TabIndex = 2
        Me.radiobuttonUseProgramFilesX86.TabStop = True
        Me.radiobuttonUseProgramFilesX86.Text = "Program Files (x86): 32-bit Office on 64-bit Windows"
        Me.radiobuttonUseProgramFilesX86.UseVisualStyleBackColor = True
        '
        'radiobuttonUseProgramFiles
        '
        Me.radiobuttonUseProgramFiles.AutoSize = True
        Me.radiobuttonUseProgramFiles.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radiobuttonUseProgramFiles.Location = New System.Drawing.Point(39, 36)
        Me.radiobuttonUseProgramFiles.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonUseProgramFiles.Name = "radiobuttonUseProgramFiles"
        Me.radiobuttonUseProgramFiles.Size = New System.Drawing.Size(350, 30)
        Me.radiobuttonUseProgramFiles.TabIndex = 2
        Me.radiobuttonUseProgramFiles.TabStop = True
        Me.radiobuttonUseProgramFiles.Text = "Program Files: 64-bit Office on 64-bit Windows," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "32-bit Office on 32-bit Windows," &
    " or 32-bit Office 2013 from Office 365"
        Me.radiobuttonUseProgramFiles.UseVisualStyleBackColor = True
        '
        'labelPFPathDescription
        '
        Me.labelPFPathDescription.AutoSize = True
        Me.labelPFPathDescription.Location = New System.Drawing.Point(36, 21)
        Me.labelPFPathDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPFPathDescription.Name = "labelPFPathDescription"
        Me.labelPFPathDescription.Size = New System.Drawing.Size(280, 13)
        Me.labelPFPathDescription.TabIndex = 0
        Me.labelPFPathDescription.Text = "Select the Program Files path used by your copy of Office:"
        '
        'tabpagePersonalization
        '
        Me.tabpagePersonalization.Controls.Add(Me.groupboxDefaultDarkTheme)
        Me.tabpagePersonalization.Controls.Add(Me.groupboxAppearance)
        Me.tabpagePersonalization.Location = New System.Drawing.Point(4, 22)
        Me.tabpagePersonalization.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpagePersonalization.Name = "tabpagePersonalization"
        Me.tabpagePersonalization.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpagePersonalization.Size = New System.Drawing.Size(422, 326)
        Me.tabpagePersonalization.TabIndex = 2
        Me.tabpagePersonalization.Text = "Theme"
        Me.tabpagePersonalization.UseVisualStyleBackColor = True
        '
        'groupboxDefaultDarkTheme
        '
        Me.groupboxDefaultDarkTheme.Controls.Add(Me.comboboxDarkThemesForSystemThemeMatchingList)
        Me.groupboxDefaultDarkTheme.Controls.Add(Me.labelDefaultDarkThemeDescription)
        Me.groupboxDefaultDarkTheme.Location = New System.Drawing.Point(4, 194)
        Me.groupboxDefaultDarkTheme.Name = "groupboxDefaultDarkTheme"
        Me.groupboxDefaultDarkTheme.Size = New System.Drawing.Size(415, 127)
        Me.groupboxDefaultDarkTheme.TabIndex = 1
        Me.groupboxDefaultDarkTheme.TabStop = False
        Me.groupboxDefaultDarkTheme.Text = "Dark theme for system theme matching"
        '
        'comboboxDarkThemesForSystemThemeMatchingList
        '
        Me.comboboxDarkThemesForSystemThemeMatchingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDarkThemesForSystemThemeMatchingList.FormattingEnabled = True
        Me.comboboxDarkThemesForSystemThemeMatchingList.Location = New System.Drawing.Point(15, 61)
        Me.comboboxDarkThemesForSystemThemeMatchingList.Name = "comboboxDarkThemesForSystemThemeMatchingList"
        Me.comboboxDarkThemesForSystemThemeMatchingList.Size = New System.Drawing.Size(195, 21)
        Me.comboboxDarkThemesForSystemThemeMatchingList.TabIndex = 6
        '
        'labelDefaultDarkThemeDescription
        '
        Me.labelDefaultDarkThemeDescription.AutoSize = True
        Me.labelDefaultDarkThemeDescription.Location = New System.Drawing.Point(12, 44)
        Me.labelDefaultDarkThemeDescription.Name = "labelDefaultDarkThemeDescription"
        Me.labelDefaultDarkThemeDescription.Size = New System.Drawing.Size(390, 13)
        Me.labelDefaultDarkThemeDescription.TabIndex = 0
        Me.labelDefaultDarkThemeDescription.Text = "When matching Windows 10 theme settings is enabled, we'll use this dark theme:"
        '
        'groupboxAppearance
        '
        Me.groupboxAppearance.Controls.Add(Me.checkboxMatchWindows10ThemeSettings)
        Me.groupboxAppearance.Controls.Add(Me.labelCustomThemePath)
        Me.groupboxAppearance.Controls.Add(Me.buttonCustomThemesBrowse)
        Me.groupboxAppearance.Controls.Add(Me.textboxCustomThemePath)
        Me.groupboxAppearance.Controls.Add(Me.labelThemeList)
        Me.groupboxAppearance.Controls.Add(Me.comboboxThemeList)
        Me.groupboxAppearance.Controls.Add(Me.textboxThemeInfo)
        Me.groupboxAppearance.Controls.Add(Me.checkboxEnableThemeEngine)
        Me.groupboxAppearance.Location = New System.Drawing.Point(4, 4)
        Me.groupboxAppearance.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxAppearance.Name = "groupboxAppearance"
        Me.groupboxAppearance.Size = New System.Drawing.Size(415, 184)
        Me.groupboxAppearance.TabIndex = 0
        Me.groupboxAppearance.TabStop = False
        Me.groupboxAppearance.Text = "Appearance"
        '
        'checkboxMatchWindows10ThemeSettings
        '
        Me.checkboxMatchWindows10ThemeSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkboxMatchWindows10ThemeSettings.AutoSize = True
        Me.checkboxMatchWindows10ThemeSettings.Location = New System.Drawing.Point(220, 92)
        Me.checkboxMatchWindows10ThemeSettings.Name = "checkboxMatchWindows10ThemeSettings"
        Me.checkboxMatchWindows10ThemeSettings.Size = New System.Drawing.Size(189, 17)
        Me.checkboxMatchWindows10ThemeSettings.TabIndex = 2
        Me.checkboxMatchWindows10ThemeSettings.Text = "Match Windows 10 theme settings"
        Me.tooltipMatchWindows10ThemeSettings.SetToolTip(Me.checkboxMatchWindows10ThemeSettings, resources.GetString("checkboxMatchWindows10ThemeSettings.ToolTip"))
        Me.checkboxMatchWindows10ThemeSettings.UseVisualStyleBackColor = True
        '
        'labelCustomThemePath
        '
        Me.labelCustomThemePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelCustomThemePath.AutoSize = True
        Me.labelCustomThemePath.Location = New System.Drawing.Point(217, 142)
        Me.labelCustomThemePath.Name = "labelCustomThemePath"
        Me.labelCustomThemePath.Size = New System.Drawing.Size(101, 13)
        Me.labelCustomThemePath.TabIndex = 6
        Me.labelCustomThemePath.Text = "Custom theme path:"
        '
        'buttonCustomThemesBrowse
        '
        Me.buttonCustomThemesBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCustomThemesBrowse.Location = New System.Drawing.Point(340, 155)
        Me.buttonCustomThemesBrowse.Name = "buttonCustomThemesBrowse"
        Me.buttonCustomThemesBrowse.Size = New System.Drawing.Size(68, 23)
        Me.buttonCustomThemesBrowse.TabIndex = 4
        Me.buttonCustomThemesBrowse.Text = "Browse..."
        Me.buttonCustomThemesBrowse.UseVisualStyleBackColor = True
        '
        'textboxCustomThemePath
        '
        Me.textboxCustomThemePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxCustomThemePath.Location = New System.Drawing.Point(220, 158)
        Me.textboxCustomThemePath.Name = "textboxCustomThemePath"
        Me.textboxCustomThemePath.Size = New System.Drawing.Size(117, 20)
        Me.textboxCustomThemePath.TabIndex = 3
        Me.tooltipCustomThemePath.SetToolTip(Me.textboxCustomThemePath, "(Placeholder)")
        '
        'labelThemeList
        '
        Me.labelThemeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelThemeList.AutoSize = True
        Me.labelThemeList.Location = New System.Drawing.Point(217, 49)
        Me.labelThemeList.Name = "labelThemeList"
        Me.labelThemeList.Size = New System.Drawing.Size(58, 13)
        Me.labelThemeList.TabIndex = 3
        Me.labelThemeList.Text = "Theme list:"
        '
        'comboboxThemeList
        '
        Me.comboboxThemeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxThemeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxThemeList.FormattingEnabled = True
        Me.comboboxThemeList.Location = New System.Drawing.Point(220, 65)
        Me.comboboxThemeList.Name = "comboboxThemeList"
        Me.comboboxThemeList.Size = New System.Drawing.Size(188, 21)
        Me.comboboxThemeList.TabIndex = 1
        '
        'textboxThemeInfo
        '
        Me.textboxThemeInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxThemeInfo.Location = New System.Drawing.Point(7, 49)
        Me.textboxThemeInfo.Multiline = True
        Me.textboxThemeInfo.Name = "textboxThemeInfo"
        Me.textboxThemeInfo.ReadOnly = True
        Me.textboxThemeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxThemeInfo.Size = New System.Drawing.Size(203, 129)
        Me.textboxThemeInfo.TabIndex = 5
        Me.textboxThemeInfo.Text = "Theme description goes here at runtime."
        '
        'checkboxEnableThemeEngine
        '
        Me.checkboxEnableThemeEngine.AutoSize = True
        Me.checkboxEnableThemeEngine.Location = New System.Drawing.Point(7, 20)
        Me.checkboxEnableThemeEngine.Name = "checkboxEnableThemeEngine"
        Me.checkboxEnableThemeEngine.Size = New System.Drawing.Size(335, 17)
        Me.checkboxEnableThemeEngine.TabIndex = 0
        Me.checkboxEnableThemeEngine.Text = "Enable UXL Launcher Theme Engine (requires application restart)"
        Me.checkboxEnableThemeEngine.UseVisualStyleBackColor = True
        '
        'tabpageStatusbar
        '
        Me.tabpageStatusbar.Controls.Add(Me.groupboxStatusbar)
        Me.tabpageStatusbar.Location = New System.Drawing.Point(4, 22)
        Me.tabpageStatusbar.Name = "tabpageStatusbar"
        Me.tabpageStatusbar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageStatusbar.Size = New System.Drawing.Size(422, 326)
        Me.tabpageStatusbar.TabIndex = 3
        Me.tabpageStatusbar.Text = "Statusbar"
        Me.tabpageStatusbar.UseVisualStyleBackColor = True
        '
        'groupboxStatusbar
        '
        Me.groupboxStatusbar.Controls.Add(Me.buttonClearFirstname)
        Me.groupboxStatusbar.Controls.Add(Me.labelFirstName)
        Me.groupboxStatusbar.Controls.Add(Me.textboxFirstname)
        Me.groupboxStatusbar.Controls.Add(Me.radiobuttonCustomStatusbarGreeting)
        Me.groupboxStatusbar.Controls.Add(Me.radiobuttonDefaultStatusbarGreeting)
        Me.groupboxStatusbar.Controls.Add(Me.labelCustomStatusbarGreeting)
        Me.groupboxStatusbar.Location = New System.Drawing.Point(4, 4)
        Me.groupboxStatusbar.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxStatusbar.Name = "groupboxStatusbar"
        Me.groupboxStatusbar.Size = New System.Drawing.Size(415, 130)
        Me.groupboxStatusbar.TabIndex = 2
        Me.groupboxStatusbar.TabStop = False
        Me.groupboxStatusbar.Text = "Greeting"
        '
        'buttonClearFirstname
        '
        Me.buttonClearFirstname.Location = New System.Drawing.Point(339, 100)
        Me.buttonClearFirstname.Name = "buttonClearFirstname"
        Me.buttonClearFirstname.Size = New System.Drawing.Size(55, 23)
        Me.buttonClearFirstname.TabIndex = 4
        Me.buttonClearFirstname.Text = "Clear"
        Me.buttonClearFirstname.UseVisualStyleBackColor = True
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.Location = New System.Drawing.Point(25, 105)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(106, 13)
        Me.labelFirstName.TabIndex = 4
        Me.labelFirstName.Text = "Firstname/nickname:"
        '
        'textboxFirstname
        '
        Me.textboxFirstname.Location = New System.Drawing.Point(140, 102)
        Me.textboxFirstname.Name = "textboxFirstname"
        Me.textboxFirstname.Size = New System.Drawing.Size(193, 20)
        Me.textboxFirstname.TabIndex = 3
        '
        'radiobuttonCustomStatusbarGreeting
        '
        Me.radiobuttonCustomStatusbarGreeting.AutoSize = True
        Me.radiobuttonCustomStatusbarGreeting.Location = New System.Drawing.Point(26, 79)
        Me.radiobuttonCustomStatusbarGreeting.Name = "radiobuttonCustomStatusbarGreeting"
        Me.radiobuttonCustomStatusbarGreeting.Size = New System.Drawing.Size(193, 17)
        Me.radiobuttonCustomStatusbarGreeting.TabIndex = 2
        Me.radiobuttonCustomStatusbarGreeting.TabStop = True
        Me.radiobuttonCustomStatusbarGreeting.Text = "Use personalized statusbar greeting"
        Me.radiobuttonCustomStatusbarGreeting.UseVisualStyleBackColor = True
        '
        'radiobuttonDefaultStatusbarGreeting
        '
        Me.radiobuttonDefaultStatusbarGreeting.AutoSize = True
        Me.radiobuttonDefaultStatusbarGreeting.Location = New System.Drawing.Point(26, 56)
        Me.radiobuttonDefaultStatusbarGreeting.Name = "radiobuttonDefaultStatusbarGreeting"
        Me.radiobuttonDefaultStatusbarGreeting.Size = New System.Drawing.Size(166, 17)
        Me.radiobuttonDefaultStatusbarGreeting.TabIndex = 1
        Me.radiobuttonDefaultStatusbarGreeting.TabStop = True
        Me.radiobuttonDefaultStatusbarGreeting.Text = "Use default statusbar greeting"
        Me.radiobuttonDefaultStatusbarGreeting.UseVisualStyleBackColor = True
        '
        'labelCustomStatusbarGreeting
        '
        Me.labelCustomStatusbarGreeting.AutoSize = True
        Me.labelCustomStatusbarGreeting.Location = New System.Drawing.Point(10, 15)
        Me.labelCustomStatusbarGreeting.Name = "labelCustomStatusbarGreeting"
        Me.labelCustomStatusbarGreeting.Size = New System.Drawing.Size(369, 26)
        Me.labelCustomStatusbarGreeting.TabIndex = 0
        Me.labelCustomStatusbarGreeting.Text = "You can choose to use a statusbar greeting personalized with your firstname" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or n" &
    "ickname, or to use the default. Your name will not be used to identify you."
        '
        'tabpageMaintenance
        '
        Me.tabpageMaintenance.Controls.Add(Me.labelMigrateSettings)
        Me.tabpageMaintenance.Controls.Add(Me.buttonUpgradeSettings)
        Me.tabpageMaintenance.Location = New System.Drawing.Point(4, 22)
        Me.tabpageMaintenance.Name = "tabpageMaintenance"
        Me.tabpageMaintenance.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageMaintenance.Size = New System.Drawing.Size(422, 326)
        Me.tabpageMaintenance.TabIndex = 4
        Me.tabpageMaintenance.Text = "Maintenance"
        Me.tabpageMaintenance.UseVisualStyleBackColor = True
        '
        'buttonUpgradeSettings
        '
        Me.buttonUpgradeSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonUpgradeSettings.Location = New System.Drawing.Point(7, 49)
        Me.buttonUpgradeSettings.Name = "buttonUpgradeSettings"
        Me.buttonUpgradeSettings.Size = New System.Drawing.Size(409, 38)
        Me.buttonUpgradeSettings.TabIndex = 0
        Me.buttonUpgradeSettings.Text = "Migrate/upgrade settings"
        Me.buttonUpgradeSettings.UseVisualStyleBackColor = True
        '
        'buttonTestSettings
        '
        Me.buttonTestSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonTestSettings.AutoSize = True
        Me.buttonTestSettings.Location = New System.Drawing.Point(71, 364)
        Me.buttonTestSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonTestSettings.Name = "buttonTestSettings"
        Me.buttonTestSettings.Size = New System.Drawing.Size(79, 28)
        Me.buttonTestSettings.TabIndex = 9
        Me.buttonTestSettings.Text = "Test settings"
        Me.buttonTestSettings.UseVisualStyleBackColor = True
        '
        'buttonDefaultSettings
        '
        Me.buttonDefaultSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonDefaultSettings.AutoSize = True
        Me.buttonDefaultSettings.Location = New System.Drawing.Point(2, 364)
        Me.buttonDefaultSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonDefaultSettings.Name = "buttonDefaultSettings"
        Me.buttonDefaultSettings.Size = New System.Drawing.Size(65, 28)
        Me.buttonDefaultSettings.TabIndex = 10
        Me.buttonDefaultSettings.Text = "Defaults"
        Me.buttonDefaultSettings.UseVisualStyleBackColor = True
        '
        'tooltipO365InstallMethod
        '
        Me.tooltipO365InstallMethod.AutoPopDelay = 32766
        Me.tooltipO365InstallMethod.InitialDelay = 500
        Me.tooltipO365InstallMethod.ReshowDelay = 100
        '
        'openfiledialogBrowseCustomThemeFile
        '
        Me.openfiledialogBrowseCustomThemeFile.Filter = "XML Files (*.xml)|*.xml|Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.openfiledialogBrowseCustomThemeFile.Title = "Browse for a custom theme"
        '
        'tooltipCustomThemePath
        '
        Me.tooltipCustomThemePath.AutoPopDelay = 5000
        Me.tooltipCustomThemePath.InitialDelay = 500
        Me.tooltipCustomThemePath.ReshowDelay = 100
        '
        'tooltipMatchWindows10ThemeSettings
        '
        Me.tooltipMatchWindows10ThemeSettings.AutoPopDelay = 10000
        Me.tooltipMatchWindows10ThemeSettings.InitialDelay = 500
        Me.tooltipMatchWindows10ThemeSettings.ReshowDelay = 100
        '
        'labelMigrateSettings
        '
        Me.labelMigrateSettings.AutoSize = True
        Me.labelMigrateSettings.Location = New System.Drawing.Point(7, 7)
        Me.labelMigrateSettings.Name = "labelMigrateSettings"
        Me.labelMigrateSettings.Size = New System.Drawing.Size(308, 39)
        Me.labelMigrateSettings.TabIndex = 1
        Me.labelMigrateSettings.Text = "You can migrate your settings from the previous version if you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "declined on first" &
    " startup. Please be aware that this requires the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "new version to be installed to" &
    " the same place as the old version."
        '
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(446, 394)
        Me.Controls.Add(Me.tableLayoutPanelOptionsWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformOptionsWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.tableLayoutPanelOptionsWindow.ResumeLayout(False)
        Me.tableLayoutPanelOptionsWindow.PerformLayout()
        Me.tabcontrolOptionsWindow.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.groupboxBypassConfiguredLocation.ResumeLayout(False)
        Me.groupboxBypassConfiguredLocation.PerformLayout()
        Me.groupboxOfficeVersion.ResumeLayout(False)
        Me.groupboxOfficeVersion.PerformLayout()
        Me.tabpageAdvanced.ResumeLayout(False)
        Me.groupboxOfficeLocation.ResumeLayout(False)
        Me.groupboxOfficeLocation.PerformLayout()
        Me.groupboxCPUType.ResumeLayout(False)
        Me.groupboxCPUType.PerformLayout()
        Me.tabpagePersonalization.ResumeLayout(False)
        Me.groupboxDefaultDarkTheme.ResumeLayout(False)
        Me.groupboxDefaultDarkTheme.PerformLayout()
        Me.groupboxAppearance.ResumeLayout(False)
        Me.groupboxAppearance.PerformLayout()
        Me.tabpageStatusbar.ResumeLayout(False)
        Me.groupboxStatusbar.ResumeLayout(False)
        Me.groupboxStatusbar.PerformLayout()
        Me.tabpageMaintenance.ResumeLayout(False)
        Me.tabpageMaintenance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tableLayoutPanelOptionsWindow As TableLayoutPanel
    Friend WithEvents buttonSaveSettings As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonDefaultSettings As Button
    Friend WithEvents tabcontrolOptionsWindow As TabControl
    Friend WithEvents tabpageGeneral As TabPage
    Friend WithEvents tabpageAdvanced As TabPage
    Friend WithEvents groupboxOfficeVersion As GroupBox
    Friend WithEvents comboboxOfficeVersionSelector As ComboBox
    Friend WithEvents labelUserHasThisOfficeVersion As Label
    Friend WithEvents checkboxO365InstallMethod As CheckBox
    Friend WithEvents groupboxCPUType As GroupBox
    Friend WithEvents labelPFPathDescription As Label
    Friend WithEvents radiobuttonUseProgramFiles As RadioButton
    Friend WithEvents radiobuttonUseProgramFilesX86 As RadioButton
    Friend WithEvents radiobuttonCPUIsQBit As RadioButton
    Friend WithEvents buttonTestSettings As Button
    Friend WithEvents tooltipO365InstallMethod As ToolTip
    Friend WithEvents tooltipSystemInfo As ToolTip
    Friend WithEvents tabpagePersonalization As TabPage
    Friend WithEvents groupboxAppearance As GroupBox
    Friend WithEvents checkboxEnableThemeEngine As CheckBox
    Friend WithEvents textboxThemeInfo As TextBox
    Friend WithEvents comboboxThemeList As ComboBox
    Friend WithEvents labelThemeList As Label
    Friend WithEvents buttonCustomThemesBrowse As Button
    Friend WithEvents textboxCustomThemePath As TextBox
    Friend WithEvents labelCustomThemePath As Label
    Friend WithEvents openfiledialogBrowseCustomThemeFile As OpenFileDialog
    Friend WithEvents labelRecommendedWindowsEdition As Label
    Friend WithEvents tooltipCustomThemePath As ToolTip
    Friend WithEvents checkboxMatchWindows10ThemeSettings As CheckBox
    Friend WithEvents tooltipMatchWindows10ThemeSettings As ToolTip
    Friend WithEvents groupboxBypassConfiguredLocation As GroupBox
    Friend WithEvents radiobuttonBypassConfiguredLocationAllApps As RadioButton
    Friend WithEvents radiobuttonBypassConfiguredLocationDeprecatedApps As RadioButton
    Friend WithEvents radiobuttonDontBypassConfiguredLocation As RadioButton
    Friend WithEvents labelBypassConfiguredLocation As Label
    Friend WithEvents groupboxOfficeLocation As GroupBox
    Friend WithEvents comboboxDriveSelector As ComboBox
    Friend WithEvents labelDriveTextboxLabel As Label
    Friend WithEvents labelOfficeInstalledToDrive As Label
    Friend WithEvents tabpageStatusbar As TabPage
    Friend WithEvents groupboxStatusbar As GroupBox
    Friend WithEvents buttonClearFirstname As Button
    Friend WithEvents labelFirstName As Label
    Friend WithEvents textboxFirstname As TextBox
    Friend WithEvents radiobuttonCustomStatusbarGreeting As RadioButton
    Friend WithEvents radiobuttonDefaultStatusbarGreeting As RadioButton
    Friend WithEvents labelCustomStatusbarGreeting As Label
    Friend WithEvents groupboxDefaultDarkTheme As GroupBox
    Friend WithEvents labelDefaultDarkThemeDescription As Label
    Friend WithEvents comboboxDarkThemesForSystemThemeMatchingList As ComboBox
    Friend WithEvents labelOffice365Compatibility As Label
    Friend WithEvents buttonRefreshDriveLetterList As Button
    Friend WithEvents labelDriveNotAvailable As Label
    Friend WithEvents tabpageMaintenance As TabPage
    Friend WithEvents buttonUpgradeSettings As Button
    Friend WithEvents labelMigrateSettings As Label
End Class
