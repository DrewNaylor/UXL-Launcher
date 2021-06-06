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
        Me.groupboxMigrateSettings = New System.Windows.Forms.GroupBox()
        Me.labelMigrateSettings = New System.Windows.Forms.Label()
        Me.buttonUpgradeSettings = New System.Windows.Forms.Button()
        Me.buttonTestSettings = New System.Windows.Forms.Button()
        Me.buttonDefaultSettings = New System.Windows.Forms.Button()
        Me.tooltipO365InstallMethod = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipSystemInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.openfiledialogBrowseCustomThemeFile = New System.Windows.Forms.OpenFileDialog()
        Me.tooltipCustomThemePath = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipMatchWindows10ThemeSettings = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.groupboxMigrateSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanelOptionsWindow
        '
        Me.tableLayoutPanelOptionsWindow.ColumnCount = 5
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
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
        Me.tableLayoutPanelOptionsWindow.Size = New System.Drawing.Size(558, 492)
        Me.tableLayoutPanelOptionsWindow.TabIndex = 0
        '
        'buttonSaveSettings
        '
        Me.buttonSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonSaveSettings.AutoSize = True
        Me.buttonSaveSettings.Location = New System.Drawing.Point(460, 454)
        Me.buttonSaveSettings.Margin = New System.Windows.Forms.Padding(2, 2, 10, 2)
        Me.buttonSaveSettings.Name = "buttonSaveSettings"
        Me.buttonSaveSettings.Size = New System.Drawing.Size(88, 35)
        Me.buttonSaveSettings.TabIndex = 7
        Me.buttonSaveSettings.Text = "Save"
        Me.buttonSaveSettings.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonCancel.AutoSize = True
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(366, 454)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(90, 35)
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
        Me.tabcontrolOptionsWindow.Location = New System.Drawing.Point(10, 10)
        Me.tabcontrolOptionsWindow.Margin = New System.Windows.Forms.Padding(10, 10, 10, 2)
        Me.tabcontrolOptionsWindow.Name = "tabcontrolOptionsWindow"
        Me.tabcontrolOptionsWindow.SelectedIndex = 0
        Me.tabcontrolOptionsWindow.Size = New System.Drawing.Size(538, 440)
        Me.tabcontrolOptionsWindow.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxBypassConfiguredLocation)
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeVersion)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageGeneral.Size = New System.Drawing.Size(530, 411)
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
        Me.groupboxBypassConfiguredLocation.Location = New System.Drawing.Point(5, 184)
        Me.groupboxBypassConfiguredLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxBypassConfiguredLocation.Name = "groupboxBypassConfiguredLocation"
        Me.groupboxBypassConfiguredLocation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxBypassConfiguredLocation.Size = New System.Drawing.Size(519, 219)
        Me.groupboxBypassConfiguredLocation.TabIndex = 2
        Me.groupboxBypassConfiguredLocation.TabStop = False
        Me.groupboxBypassConfiguredLocation.Text = "Bypass configured location"
        '
        'radiobuttonBypassConfiguredLocationAllApps
        '
        Me.radiobuttonBypassConfiguredLocationAllApps.AutoSize = True
        Me.radiobuttonBypassConfiguredLocationAllApps.Location = New System.Drawing.Point(51, 161)
        Me.radiobuttonBypassConfiguredLocationAllApps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonBypassConfiguredLocationAllApps.Name = "radiobuttonBypassConfiguredLocationAllApps"
        Me.radiobuttonBypassConfiguredLocationAllApps.Size = New System.Drawing.Size(273, 21)
        Me.radiobuttonBypassConfiguredLocationAllApps.TabIndex = 2
        Me.radiobuttonBypassConfiguredLocationAllApps.TabStop = True
        Me.radiobuttonBypassConfiguredLocationAllApps.Text = "Bypass configured location for all apps"
        Me.radiobuttonBypassConfiguredLocationAllApps.UseVisualStyleBackColor = True
        '
        'radiobuttonBypassConfiguredLocationDeprecatedApps
        '
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.AutoSize = True
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Location = New System.Drawing.Point(51, 132)
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Name = "radiobuttonBypassConfiguredLocationDeprecatedApps"
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Size = New System.Drawing.Size(390, 21)
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.TabIndex = 2
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.TabStop = True
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.Text = "Bypass configured location for deprecated/removed apps"
        Me.radiobuttonBypassConfiguredLocationDeprecatedApps.UseVisualStyleBackColor = True
        '
        'radiobuttonDontBypassConfiguredLocation
        '
        Me.radiobuttonDontBypassConfiguredLocation.AutoSize = True
        Me.radiobuttonDontBypassConfiguredLocation.Location = New System.Drawing.Point(51, 104)
        Me.radiobuttonDontBypassConfiguredLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonDontBypassConfiguredLocation.Name = "radiobuttonDontBypassConfiguredLocation"
        Me.radiobuttonDontBypassConfiguredLocation.Size = New System.Drawing.Size(235, 21)
        Me.radiobuttonDontBypassConfiguredLocation.TabIndex = 2
        Me.radiobuttonDontBypassConfiguredLocation.TabStop = True
        Me.radiobuttonDontBypassConfiguredLocation.Text = "Don't bypass configured location"
        Me.radiobuttonDontBypassConfiguredLocation.UseVisualStyleBackColor = True
        '
        'labelBypassConfiguredLocation
        '
        Me.labelBypassConfiguredLocation.AutoSize = True
        Me.labelBypassConfiguredLocation.Location = New System.Drawing.Point(48, 35)
        Me.labelBypassConfiguredLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelBypassConfiguredLocation.Name = "labelBypassConfiguredLocation"
        Me.labelBypassConfiguredLocation.Size = New System.Drawing.Size(457, 68)
        Me.labelBypassConfiguredLocation.TabIndex = 0
        Me.labelBypassConfiguredLocation.Text = resources.GetString("labelBypassConfiguredLocation.Text")
        '
        'groupboxOfficeVersion
        '
        Me.groupboxOfficeVersion.Controls.Add(Me.labelOffice365Compatibility)
        Me.groupboxOfficeVersion.Controls.Add(Me.checkboxO365InstallMethod)
        Me.groupboxOfficeVersion.Controls.Add(Me.labelUserHasThisOfficeVersion)
        Me.groupboxOfficeVersion.Controls.Add(Me.comboboxOfficeVersionSelector)
        Me.groupboxOfficeVersion.Location = New System.Drawing.Point(5, 5)
        Me.groupboxOfficeVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeVersion.Name = "groupboxOfficeVersion"
        Me.groupboxOfficeVersion.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeVersion.Size = New System.Drawing.Size(519, 174)
        Me.groupboxOfficeVersion.TabIndex = 1
        Me.groupboxOfficeVersion.TabStop = False
        Me.groupboxOfficeVersion.Text = "Microsoft Office versions + C2R"
        '
        'labelOffice365Compatibility
        '
        Me.labelOffice365Compatibility.AutoSize = True
        Me.labelOffice365Compatibility.Location = New System.Drawing.Point(95, 80)
        Me.labelOffice365Compatibility.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelOffice365Compatibility.Name = "labelOffice365Compatibility"
        Me.labelOffice365Compatibility.Size = New System.Drawing.Size(360, 34)
        Me.labelOffice365Compatibility.TabIndex = 6
        Me.labelOffice365Compatibility.Text = "Most people install Office from Office 365/Microsoft 365," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "so you may need to che" &
    "ck this box:"
        '
        'checkboxO365InstallMethod
        '
        Me.checkboxO365InstallMethod.AutoSize = True
        Me.checkboxO365InstallMethod.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxO365InstallMethod.Location = New System.Drawing.Point(99, 115)
        Me.checkboxO365InstallMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxO365InstallMethod.Name = "checkboxO365InstallMethod"
        Me.checkboxO365InstallMethod.Size = New System.Drawing.Size(307, 38)
        Me.checkboxO365InstallMethod.TabIndex = 1
        Me.checkboxO365InstallMethod.Text = "Enable Office 365/Click-to-Run Compatibility" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Always enabled for 2019 and above)" &
    ""
        Me.tooltipO365InstallMethod.SetToolTip(Me.checkboxO365InstallMethod, resources.GetString("checkboxO365InstallMethod.ToolTip"))
        Me.checkboxO365InstallMethod.UseVisualStyleBackColor = True
        '
        'labelUserHasThisOfficeVersion
        '
        Me.labelUserHasThisOfficeVersion.AutoSize = True
        Me.labelUserHasThisOfficeVersion.Location = New System.Drawing.Point(95, 20)
        Me.labelUserHasThisOfficeVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelUserHasThisOfficeVersion.Name = "labelUserHasThisOfficeVersion"
        Me.labelUserHasThisOfficeVersion.Size = New System.Drawing.Size(352, 17)
        Me.labelUserHasThisOfficeVersion.TabIndex = 2
        Me.labelUserHasThisOfficeVersion.Text = "Please select your installed version of Microsoft Office:"
        '
        'comboboxOfficeVersionSelector
        '
        Me.comboboxOfficeVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOfficeVersionSelector.FormattingEnabled = True
        Me.comboboxOfficeVersionSelector.Location = New System.Drawing.Point(99, 39)
        Me.comboboxOfficeVersionSelector.Margin = New System.Windows.Forms.Padding(2)
        Me.comboboxOfficeVersionSelector.Name = "comboboxOfficeVersionSelector"
        Me.comboboxOfficeVersionSelector.Size = New System.Drawing.Size(172, 24)
        Me.comboboxOfficeVersionSelector.TabIndex = 0
        '
        'tabpageAdvanced
        '
        Me.tabpageAdvanced.Controls.Add(Me.groupboxOfficeLocation)
        Me.tabpageAdvanced.Controls.Add(Me.groupboxCPUType)
        Me.tabpageAdvanced.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAdvanced.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageAdvanced.Name = "tabpageAdvanced"
        Me.tabpageAdvanced.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageAdvanced.Size = New System.Drawing.Size(530, 411)
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
        Me.groupboxOfficeLocation.Location = New System.Drawing.Point(5, 5)
        Me.groupboxOfficeLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeLocation.Name = "groupboxOfficeLocation"
        Me.groupboxOfficeLocation.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeLocation.Size = New System.Drawing.Size(519, 152)
        Me.groupboxOfficeLocation.TabIndex = 0
        Me.groupboxOfficeLocation.TabStop = False
        Me.groupboxOfficeLocation.Text = "Root drive path"
        '
        'labelDriveNotAvailable
        '
        Me.labelDriveNotAvailable.AutoSize = True
        Me.labelDriveNotAvailable.Location = New System.Drawing.Point(160, 106)
        Me.labelDriveNotAvailable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDriveNotAvailable.Name = "labelDriveNotAvailable"
        Me.labelDriveNotAvailable.Size = New System.Drawing.Size(130, 17)
        Me.labelDriveNotAvailable.TabIndex = 5
        Me.labelDriveNotAvailable.Text = "*Drive not available"
        '
        'buttonRefreshDriveLetterList
        '
        Me.buttonRefreshDriveLetterList.Location = New System.Drawing.Point(222, 75)
        Me.buttonRefreshDriveLetterList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonRefreshDriveLetterList.Name = "buttonRefreshDriveLetterList"
        Me.buttonRefreshDriveLetterList.Size = New System.Drawing.Size(72, 29)
        Me.buttonRefreshDriveLetterList.TabIndex = 1
        Me.buttonRefreshDriveLetterList.Text = "Refresh"
        Me.buttonRefreshDriveLetterList.UseVisualStyleBackColor = True
        '
        'comboboxDriveSelector
        '
        Me.comboboxDriveSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDriveSelector.FormattingEnabled = True
        Me.comboboxDriveSelector.Location = New System.Drawing.Point(164, 76)
        Me.comboboxDriveSelector.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboboxDriveSelector.Name = "comboboxDriveSelector"
        Me.comboboxDriveSelector.Size = New System.Drawing.Size(50, 24)
        Me.comboboxDriveSelector.TabIndex = 0
        '
        'labelDriveTextboxLabel
        '
        Me.labelDriveTextboxLabel.AutoSize = True
        Me.labelDriveTextboxLabel.Location = New System.Drawing.Point(116, 80)
        Me.labelDriveTextboxLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDriveTextboxLabel.Name = "labelDriveTextboxLabel"
        Me.labelDriveTextboxLabel.Size = New System.Drawing.Size(41, 17)
        Me.labelDriveTextboxLabel.TabIndex = 4
        Me.labelDriveTextboxLabel.Text = "Drive"
        '
        'labelOfficeInstalledToDrive
        '
        Me.labelOfficeInstalledToDrive.AutoSize = True
        Me.labelOfficeInstalledToDrive.Location = New System.Drawing.Point(116, 51)
        Me.labelOfficeInstalledToDrive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelOfficeInstalledToDrive.Name = "labelOfficeInstalledToDrive"
        Me.labelOfficeInstalledToDrive.Size = New System.Drawing.Size(304, 17)
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
        Me.groupboxCPUType.Location = New System.Drawing.Point(5, 162)
        Me.groupboxCPUType.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxCPUType.Name = "groupboxCPUType"
        Me.groupboxCPUType.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxCPUType.Size = New System.Drawing.Size(519, 240)
        Me.groupboxCPUType.TabIndex = 1
        Me.groupboxCPUType.TabStop = False
        Me.groupboxCPUType.Text = "Program Files path"
        '
        'labelRecommendedWindowsEdition
        '
        Me.labelRecommendedWindowsEdition.AutoSize = True
        Me.labelRecommendedWindowsEdition.Location = New System.Drawing.Point(45, 126)
        Me.labelRecommendedWindowsEdition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelRecommendedWindowsEdition.Name = "labelRecommendedWindowsEdition"
        Me.labelRecommendedWindowsEdition.Size = New System.Drawing.Size(495, 85)
        Me.labelRecommendedWindowsEdition.TabIndex = 5
        Me.labelRecommendedWindowsEdition.Text = resources.GetString("labelRecommendedWindowsEdition.Text")
        '
        'radiobuttonCPUIsQBit
        '
        Me.radiobuttonCPUIsQBit.AutoSize = True
        Me.radiobuttonCPUIsQBit.Location = New System.Drawing.Point(562, 200)
        Me.radiobuttonCPUIsQBit.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonCPUIsQBit.Name = "radiobuttonCPUIsQBit"
        Me.radiobuttonCPUIsQBit.Size = New System.Drawing.Size(575, 21)
        Me.radiobuttonCPUIsQBit.TabIndex = 4
        Me.radiobuttonCPUIsQBit.TabStop = True
        Me.radiobuttonCPUIsQBit.Text = "I'm running Quantum-bit Windows lawl. (Thank you for finding this hidden radio bu" &
    "tton!)"
        Me.radiobuttonCPUIsQBit.UseVisualStyleBackColor = True
        '
        'radiobuttonUseProgramFilesX86
        '
        Me.radiobuttonUseProgramFilesX86.AutoSize = True
        Me.radiobuttonUseProgramFilesX86.Location = New System.Drawing.Point(49, 88)
        Me.radiobuttonUseProgramFilesX86.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonUseProgramFilesX86.Name = "radiobuttonUseProgramFilesX86"
        Me.radiobuttonUseProgramFilesX86.Size = New System.Drawing.Size(357, 21)
        Me.radiobuttonUseProgramFilesX86.TabIndex = 2
        Me.radiobuttonUseProgramFilesX86.TabStop = True
        Me.radiobuttonUseProgramFilesX86.Text = "Program Files (x86): 32-bit Office on 64-bit Windows"
        Me.radiobuttonUseProgramFilesX86.UseVisualStyleBackColor = True
        '
        'radiobuttonUseProgramFiles
        '
        Me.radiobuttonUseProgramFiles.AutoSize = True
        Me.radiobuttonUseProgramFiles.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radiobuttonUseProgramFiles.Location = New System.Drawing.Point(49, 45)
        Me.radiobuttonUseProgramFiles.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonUseProgramFiles.Name = "radiobuttonUseProgramFiles"
        Me.radiobuttonUseProgramFiles.Size = New System.Drawing.Size(465, 38)
        Me.radiobuttonUseProgramFiles.TabIndex = 2
        Me.radiobuttonUseProgramFiles.TabStop = True
        Me.radiobuttonUseProgramFiles.Text = "Program Files: 64-bit Office on 64-bit Windows," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "32-bit Office on 32-bit Windows," &
    " or 32-bit Office 2013 from Office 365"
        Me.radiobuttonUseProgramFiles.UseVisualStyleBackColor = True
        '
        'labelPFPathDescription
        '
        Me.labelPFPathDescription.AutoSize = True
        Me.labelPFPathDescription.Location = New System.Drawing.Point(45, 26)
        Me.labelPFPathDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPFPathDescription.Name = "labelPFPathDescription"
        Me.labelPFPathDescription.Size = New System.Drawing.Size(375, 17)
        Me.labelPFPathDescription.TabIndex = 0
        Me.labelPFPathDescription.Text = "Select the Program Files path used by your copy of Office:"
        '
        'tabpagePersonalization
        '
        Me.tabpagePersonalization.Controls.Add(Me.groupboxDefaultDarkTheme)
        Me.tabpagePersonalization.Controls.Add(Me.groupboxAppearance)
        Me.tabpagePersonalization.Location = New System.Drawing.Point(4, 25)
        Me.tabpagePersonalization.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpagePersonalization.Name = "tabpagePersonalization"
        Me.tabpagePersonalization.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpagePersonalization.Size = New System.Drawing.Size(530, 411)
        Me.tabpagePersonalization.TabIndex = 2
        Me.tabpagePersonalization.Text = "Theme"
        Me.tabpagePersonalization.UseVisualStyleBackColor = True
        '
        'groupboxDefaultDarkTheme
        '
        Me.groupboxDefaultDarkTheme.Controls.Add(Me.comboboxDarkThemesForSystemThemeMatchingList)
        Me.groupboxDefaultDarkTheme.Controls.Add(Me.labelDefaultDarkThemeDescription)
        Me.groupboxDefaultDarkTheme.Location = New System.Drawing.Point(5, 261)
        Me.groupboxDefaultDarkTheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxDefaultDarkTheme.Name = "groupboxDefaultDarkTheme"
        Me.groupboxDefaultDarkTheme.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxDefaultDarkTheme.Size = New System.Drawing.Size(519, 140)
        Me.groupboxDefaultDarkTheme.TabIndex = 1
        Me.groupboxDefaultDarkTheme.TabStop = False
        Me.groupboxDefaultDarkTheme.Text = "Dark theme for system theme matching"
        '
        'comboboxDarkThemesForSystemThemeMatchingList
        '
        Me.comboboxDarkThemesForSystemThemeMatchingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDarkThemesForSystemThemeMatchingList.FormattingEnabled = True
        Me.comboboxDarkThemesForSystemThemeMatchingList.Location = New System.Drawing.Point(19, 68)
        Me.comboboxDarkThemesForSystemThemeMatchingList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboboxDarkThemesForSystemThemeMatchingList.Name = "comboboxDarkThemesForSystemThemeMatchingList"
        Me.comboboxDarkThemesForSystemThemeMatchingList.Size = New System.Drawing.Size(243, 24)
        Me.comboboxDarkThemesForSystemThemeMatchingList.TabIndex = 6
        '
        'labelDefaultDarkThemeDescription
        '
        Me.labelDefaultDarkThemeDescription.AutoSize = True
        Me.labelDefaultDarkThemeDescription.Location = New System.Drawing.Point(15, 46)
        Me.labelDefaultDarkThemeDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelDefaultDarkThemeDescription.Name = "labelDefaultDarkThemeDescription"
        Me.labelDefaultDarkThemeDescription.Size = New System.Drawing.Size(485, 17)
        Me.labelDefaultDarkThemeDescription.TabIndex = 0
        Me.labelDefaultDarkThemeDescription.Text = "When matching system theme settings is enabled, we'll use this dark theme:"
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
        Me.groupboxAppearance.Location = New System.Drawing.Point(5, 5)
        Me.groupboxAppearance.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxAppearance.Name = "groupboxAppearance"
        Me.groupboxAppearance.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxAppearance.Size = New System.Drawing.Size(519, 250)
        Me.groupboxAppearance.TabIndex = 0
        Me.groupboxAppearance.TabStop = False
        Me.groupboxAppearance.Text = "Theme configuration"
        '
        'checkboxMatchWindows10ThemeSettings
        '
        Me.checkboxMatchWindows10ThemeSettings.AutoSize = True
        Me.checkboxMatchWindows10ThemeSettings.Location = New System.Drawing.Point(9, 54)
        Me.checkboxMatchWindows10ThemeSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkboxMatchWindows10ThemeSettings.Name = "checkboxMatchWindows10ThemeSettings"
        Me.checkboxMatchWindows10ThemeSettings.Size = New System.Drawing.Size(212, 21)
        Me.checkboxMatchWindows10ThemeSettings.TabIndex = 1
        Me.checkboxMatchWindows10ThemeSettings.Text = "Match system theme settings"
        Me.tooltipMatchWindows10ThemeSettings.SetToolTip(Me.checkboxMatchWindows10ThemeSettings, resources.GetString("checkboxMatchWindows10ThemeSettings.ToolTip"))
        Me.checkboxMatchWindows10ThemeSettings.UseVisualStyleBackColor = True
        '
        'labelCustomThemePath
        '
        Me.labelCustomThemePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelCustomThemePath.AutoSize = True
        Me.labelCustomThemePath.Location = New System.Drawing.Point(5, 194)
        Me.labelCustomThemePath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCustomThemePath.Name = "labelCustomThemePath"
        Me.labelCustomThemePath.Size = New System.Drawing.Size(134, 17)
        Me.labelCustomThemePath.TabIndex = 6
        Me.labelCustomThemePath.Text = "Custom theme path:"
        '
        'buttonCustomThemesBrowse
        '
        Me.buttonCustomThemesBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCustomThemesBrowse.Location = New System.Drawing.Point(159, 210)
        Me.buttonCustomThemesBrowse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonCustomThemesBrowse.Name = "buttonCustomThemesBrowse"
        Me.buttonCustomThemesBrowse.Size = New System.Drawing.Size(85, 29)
        Me.buttonCustomThemesBrowse.TabIndex = 5
        Me.buttonCustomThemesBrowse.Text = "Browse..."
        Me.buttonCustomThemesBrowse.UseVisualStyleBackColor = True
        '
        'textboxCustomThemePath
        '
        Me.textboxCustomThemePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxCustomThemePath.Location = New System.Drawing.Point(9, 214)
        Me.textboxCustomThemePath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxCustomThemePath.Name = "textboxCustomThemePath"
        Me.textboxCustomThemePath.Size = New System.Drawing.Size(145, 22)
        Me.textboxCustomThemePath.TabIndex = 4
        Me.tooltipCustomThemePath.SetToolTip(Me.textboxCustomThemePath, "(Placeholder)")
        '
        'labelThemeList
        '
        Me.labelThemeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelThemeList.AutoSize = True
        Me.labelThemeList.Location = New System.Drawing.Point(5, 79)
        Me.labelThemeList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelThemeList.Name = "labelThemeList"
        Me.labelThemeList.Size = New System.Drawing.Size(77, 17)
        Me.labelThemeList.TabIndex = 3
        Me.labelThemeList.Text = "Theme list:"
        '
        'comboboxThemeList
        '
        Me.comboboxThemeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboboxThemeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxThemeList.FormattingEnabled = True
        Me.comboboxThemeList.Location = New System.Drawing.Point(9, 99)
        Me.comboboxThemeList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comboboxThemeList.Name = "comboboxThemeList"
        Me.comboboxThemeList.Size = New System.Drawing.Size(234, 24)
        Me.comboboxThemeList.TabIndex = 2
        '
        'textboxThemeInfo
        '
        Me.textboxThemeInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxThemeInfo.Location = New System.Drawing.Point(256, 49)
        Me.textboxThemeInfo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxThemeInfo.Multiline = True
        Me.textboxThemeInfo.Name = "textboxThemeInfo"
        Me.textboxThemeInfo.ReadOnly = True
        Me.textboxThemeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxThemeInfo.Size = New System.Drawing.Size(253, 189)
        Me.textboxThemeInfo.TabIndex = 6
        Me.textboxThemeInfo.Text = "Theme description goes here at runtime."
        '
        'checkboxEnableThemeEngine
        '
        Me.checkboxEnableThemeEngine.AutoSize = True
        Me.checkboxEnableThemeEngine.Location = New System.Drawing.Point(9, 25)
        Me.checkboxEnableThemeEngine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.checkboxEnableThemeEngine.Name = "checkboxEnableThemeEngine"
        Me.checkboxEnableThemeEngine.Size = New System.Drawing.Size(448, 21)
        Me.checkboxEnableThemeEngine.TabIndex = 0
        Me.checkboxEnableThemeEngine.Text = "Enable UXL Launcher Theme Engine (requires application restart)"
        Me.checkboxEnableThemeEngine.UseVisualStyleBackColor = True
        '
        'tabpageStatusbar
        '
        Me.tabpageStatusbar.Controls.Add(Me.groupboxStatusbar)
        Me.tabpageStatusbar.Location = New System.Drawing.Point(4, 25)
        Me.tabpageStatusbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageStatusbar.Name = "tabpageStatusbar"
        Me.tabpageStatusbar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageStatusbar.Size = New System.Drawing.Size(530, 411)
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
        Me.groupboxStatusbar.Location = New System.Drawing.Point(5, 5)
        Me.groupboxStatusbar.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxStatusbar.Name = "groupboxStatusbar"
        Me.groupboxStatusbar.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxStatusbar.Size = New System.Drawing.Size(519, 150)
        Me.groupboxStatusbar.TabIndex = 2
        Me.groupboxStatusbar.TabStop = False
        Me.groupboxStatusbar.Text = "Greeting"
        '
        'buttonClearFirstname
        '
        Me.buttonClearFirstname.Location = New System.Drawing.Point(440, 111)
        Me.buttonClearFirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonClearFirstname.Name = "buttonClearFirstname"
        Me.buttonClearFirstname.Size = New System.Drawing.Size(69, 29)
        Me.buttonClearFirstname.TabIndex = 4
        Me.buttonClearFirstname.Text = "Clear"
        Me.buttonClearFirstname.UseVisualStyleBackColor = True
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.Location = New System.Drawing.Point(15, 116)
        Me.labelFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(138, 17)
        Me.labelFirstName.TabIndex = 4
        Me.labelFirstName.Text = "Firstname/nickname:"
        '
        'textboxFirstname
        '
        Me.textboxFirstname.Location = New System.Drawing.Point(159, 112)
        Me.textboxFirstname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.textboxFirstname.Name = "textboxFirstname"
        Me.textboxFirstname.Size = New System.Drawing.Size(273, 22)
        Me.textboxFirstname.TabIndex = 3
        '
        'radiobuttonCustomStatusbarGreeting
        '
        Me.radiobuttonCustomStatusbarGreeting.AutoSize = True
        Me.radiobuttonCustomStatusbarGreeting.Location = New System.Drawing.Point(16, 84)
        Me.radiobuttonCustomStatusbarGreeting.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonCustomStatusbarGreeting.Name = "radiobuttonCustomStatusbarGreeting"
        Me.radiobuttonCustomStatusbarGreeting.Size = New System.Drawing.Size(258, 21)
        Me.radiobuttonCustomStatusbarGreeting.TabIndex = 2
        Me.radiobuttonCustomStatusbarGreeting.TabStop = True
        Me.radiobuttonCustomStatusbarGreeting.Text = "Use personalized statusbar greeting"
        Me.radiobuttonCustomStatusbarGreeting.UseVisualStyleBackColor = True
        '
        'radiobuttonDefaultStatusbarGreeting
        '
        Me.radiobuttonDefaultStatusbarGreeting.AutoSize = True
        Me.radiobuttonDefaultStatusbarGreeting.Location = New System.Drawing.Point(16, 55)
        Me.radiobuttonDefaultStatusbarGreeting.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radiobuttonDefaultStatusbarGreeting.Name = "radiobuttonDefaultStatusbarGreeting"
        Me.radiobuttonDefaultStatusbarGreeting.Size = New System.Drawing.Size(220, 21)
        Me.radiobuttonDefaultStatusbarGreeting.TabIndex = 1
        Me.radiobuttonDefaultStatusbarGreeting.TabStop = True
        Me.radiobuttonDefaultStatusbarGreeting.Text = "Use default statusbar greeting"
        Me.radiobuttonDefaultStatusbarGreeting.UseVisualStyleBackColor = True
        '
        'labelCustomStatusbarGreeting
        '
        Me.labelCustomStatusbarGreeting.AutoSize = True
        Me.labelCustomStatusbarGreeting.Location = New System.Drawing.Point(12, 19)
        Me.labelCustomStatusbarGreeting.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCustomStatusbarGreeting.Name = "labelCustomStatusbarGreeting"
        Me.labelCustomStatusbarGreeting.Size = New System.Drawing.Size(494, 34)
        Me.labelCustomStatusbarGreeting.TabIndex = 0
        Me.labelCustomStatusbarGreeting.Text = "You can choose to use a statusbar greeting personalized with your firstname" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or n" &
    "ickname, or to use the default. Your name will not be used to identify you."
        '
        'tabpageMaintenance
        '
        Me.tabpageMaintenance.Controls.Add(Me.groupboxMigrateSettings)
        Me.tabpageMaintenance.Location = New System.Drawing.Point(4, 25)
        Me.tabpageMaintenance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageMaintenance.Name = "tabpageMaintenance"
        Me.tabpageMaintenance.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabpageMaintenance.Size = New System.Drawing.Size(530, 411)
        Me.tabpageMaintenance.TabIndex = 4
        Me.tabpageMaintenance.Text = "Maintenance"
        Me.tabpageMaintenance.UseVisualStyleBackColor = True
        '
        'groupboxMigrateSettings
        '
        Me.groupboxMigrateSettings.Controls.Add(Me.labelMigrateSettings)
        Me.groupboxMigrateSettings.Controls.Add(Me.buttonUpgradeSettings)
        Me.groupboxMigrateSettings.Location = New System.Drawing.Point(5, 5)
        Me.groupboxMigrateSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxMigrateSettings.Name = "groupboxMigrateSettings"
        Me.groupboxMigrateSettings.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxMigrateSettings.Size = New System.Drawing.Size(519, 146)
        Me.groupboxMigrateSettings.TabIndex = 2
        Me.groupboxMigrateSettings.TabStop = False
        Me.groupboxMigrateSettings.Text = "Migrate settings"
        '
        'labelMigrateSettings
        '
        Me.labelMigrateSettings.AutoSize = True
        Me.labelMigrateSettings.Location = New System.Drawing.Point(8, 20)
        Me.labelMigrateSettings.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelMigrateSettings.Name = "labelMigrateSettings"
        Me.labelMigrateSettings.Size = New System.Drawing.Size(455, 68)
        Me.labelMigrateSettings.TabIndex = 1
        Me.labelMigrateSettings.Text = resources.GetString("labelMigrateSettings.Text")
        '
        'buttonUpgradeSettings
        '
        Me.buttonUpgradeSettings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonUpgradeSettings.Location = New System.Drawing.Point(7, 92)
        Me.buttonUpgradeSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonUpgradeSettings.Name = "buttonUpgradeSettings"
        Me.buttonUpgradeSettings.Size = New System.Drawing.Size(504, 48)
        Me.buttonUpgradeSettings.TabIndex = 0
        Me.buttonUpgradeSettings.Text = "Migrate settings (overwrites current settings and requires restart)"
        Me.buttonUpgradeSettings.UseVisualStyleBackColor = True
        '
        'buttonTestSettings
        '
        Me.buttonTestSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonTestSettings.AutoSize = True
        Me.buttonTestSettings.Location = New System.Drawing.Point(90, 454)
        Me.buttonTestSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonTestSettings.Name = "buttonTestSettings"
        Me.buttonTestSettings.Size = New System.Drawing.Size(99, 35)
        Me.buttonTestSettings.TabIndex = 9
        Me.buttonTestSettings.Text = "Test settings"
        Me.buttonTestSettings.UseVisualStyleBackColor = True
        '
        'buttonDefaultSettings
        '
        Me.buttonDefaultSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonDefaultSettings.AutoSize = True
        Me.buttonDefaultSettings.Location = New System.Drawing.Point(4, 454)
        Me.buttonDefaultSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonDefaultSettings.Name = "buttonDefaultSettings"
        Me.buttonDefaultSettings.Size = New System.Drawing.Size(81, 35)
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
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(558, 492)
        Me.Controls.Add(Me.tableLayoutPanelOptionsWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.groupboxMigrateSettings.ResumeLayout(False)
        Me.groupboxMigrateSettings.PerformLayout()
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
    Friend WithEvents groupboxMigrateSettings As GroupBox
End Class
