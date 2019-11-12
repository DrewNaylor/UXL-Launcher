﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.groupboxOfficeVersion = New System.Windows.Forms.GroupBox()
        Me.labelOfficeInstallMethodDescription = New System.Windows.Forms.Label()
        Me.checkboxO365InstallMethod = New System.Windows.Forms.CheckBox()
        Me.labelUserHasThisOfficeVersion = New System.Windows.Forms.Label()
        Me.comboboxOfficeVersionSelector = New System.Windows.Forms.ComboBox()
        Me.groupboxOfficeLocation = New System.Windows.Forms.GroupBox()
        Me.labelDriveTextboxLabel = New System.Windows.Forms.Label()
        Me.buttonClearDriveLetter = New System.Windows.Forms.Button()
        Me.textboxOfficeDrive = New System.Windows.Forms.TextBox()
        Me.labelOfficeInstalledToDrive = New System.Windows.Forms.Label()
        Me.tabpageAdvanced = New System.Windows.Forms.TabPage()
        Me.groupboxBypassConfiguredLocation = New System.Windows.Forms.GroupBox()
        Me.checkboxBypassConfiguredLocationForDeprecatedApps = New System.Windows.Forms.CheckBox()
        Me.labelBypassConfiguredLocation = New System.Windows.Forms.Label()
        Me.groupboxCPUType = New System.Windows.Forms.GroupBox()
        Me.labelRecommendedWindowsEdition = New System.Windows.Forms.Label()
        Me.radiobuttonCPUIsQBit = New System.Windows.Forms.RadioButton()
        Me.radiobuttonCPUIs64Bit = New System.Windows.Forms.RadioButton()
        Me.radiobuttonCPUIs32Bit = New System.Windows.Forms.RadioButton()
        Me.labelCPUTypeDescription = New System.Windows.Forms.Label()
        Me.tabpagePersonalization = New System.Windows.Forms.TabPage()
        Me.groupboxStatusbar = New System.Windows.Forms.GroupBox()
        Me.buttonClearFirstname = New System.Windows.Forms.Button()
        Me.labelFirstName = New System.Windows.Forms.Label()
        Me.textboxFirstname = New System.Windows.Forms.TextBox()
        Me.radiobuttonCustomStatusbarGreeting = New System.Windows.Forms.RadioButton()
        Me.radiobuttonDefaultStatusbarGreeting = New System.Windows.Forms.RadioButton()
        Me.labelCustomStatusbarGreeting = New System.Windows.Forms.Label()
        Me.groupboxAppearance = New System.Windows.Forms.GroupBox()
        Me.checkboxMatchWindows10ThemeSettings = New System.Windows.Forms.CheckBox()
        Me.labelCustomThemePath = New System.Windows.Forms.Label()
        Me.buttonCustomThemesBrowse = New System.Windows.Forms.Button()
        Me.textboxCustomThemePath = New System.Windows.Forms.TextBox()
        Me.labelThemeList = New System.Windows.Forms.Label()
        Me.comboboxThemeList = New System.Windows.Forms.ComboBox()
        Me.textboxThemeInfo = New System.Windows.Forms.TextBox()
        Me.checkboxEnableThemeEngine = New System.Windows.Forms.CheckBox()
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
        Me.groupboxOfficeVersion.SuspendLayout()
        Me.groupboxOfficeLocation.SuspendLayout()
        Me.tabpageAdvanced.SuspendLayout()
        Me.groupboxBypassConfiguredLocation.SuspendLayout()
        Me.groupboxCPUType.SuspendLayout()
        Me.tabpagePersonalization.SuspendLayout()
        Me.groupboxStatusbar.SuspendLayout()
        Me.groupboxAppearance.SuspendLayout()
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
        Me.buttonSaveSettings.TabIndex = 9
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
        Me.tabcontrolOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptionsWindow.Location = New System.Drawing.Point(8, 8)
        Me.tabcontrolOptionsWindow.Margin = New System.Windows.Forms.Padding(8, 8, 8, 2)
        Me.tabcontrolOptionsWindow.Name = "tabcontrolOptionsWindow"
        Me.tabcontrolOptionsWindow.SelectedIndex = 0
        Me.tabcontrolOptionsWindow.Size = New System.Drawing.Size(430, 352)
        Me.tabcontrolOptionsWindow.TabIndex = 1
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeVersion)
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeLocation)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabpageGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageGeneral.Size = New System.Drawing.Size(422, 326)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxOfficeVersion
        '
        Me.groupboxOfficeVersion.Controls.Add(Me.labelOfficeInstallMethodDescription)
        Me.groupboxOfficeVersion.Controls.Add(Me.checkboxO365InstallMethod)
        Me.groupboxOfficeVersion.Controls.Add(Me.labelUserHasThisOfficeVersion)
        Me.groupboxOfficeVersion.Controls.Add(Me.comboboxOfficeVersionSelector)
        Me.groupboxOfficeVersion.Location = New System.Drawing.Point(3, 137)
        Me.groupboxOfficeVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeVersion.Name = "groupboxOfficeVersion"
        Me.groupboxOfficeVersion.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeVersion.Size = New System.Drawing.Size(415, 187)
        Me.groupboxOfficeVersion.TabIndex = 1
        Me.groupboxOfficeVersion.TabStop = False
        Me.groupboxOfficeVersion.Text = "What version of Microsoft Office do you use? How was it installed?"
        '
        'labelOfficeInstallMethodDescription
        '
        Me.labelOfficeInstallMethodDescription.AutoSize = True
        Me.labelOfficeInstallMethodDescription.Location = New System.Drawing.Point(112, 93)
        Me.labelOfficeInstallMethodDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelOfficeInstallMethodDescription.Name = "labelOfficeInstallMethodDescription"
        Me.labelOfficeInstallMethodDescription.Size = New System.Drawing.Size(191, 13)
        Me.labelOfficeInstallMethodDescription.TabIndex = 5
        Me.labelOfficeInstallMethodDescription.Text = "My Microsoft Office installation method:"
        '
        'checkboxO365InstallMethod
        '
        Me.checkboxO365InstallMethod.AutoSize = True
        Me.checkboxO365InstallMethod.Location = New System.Drawing.Point(115, 108)
        Me.checkboxO365InstallMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxO365InstallMethod.Name = "checkboxO365InstallMethod"
        Me.checkboxO365InstallMethod.Size = New System.Drawing.Size(235, 17)
        Me.checkboxO365InstallMethod.TabIndex = 5
        Me.checkboxO365InstallMethod.Text = "Enable Office 365/Click-to-Run Compatibility"
        Me.tooltipO365InstallMethod.SetToolTip(Me.checkboxO365InstallMethod, resources.GetString("checkboxO365InstallMethod.ToolTip"))
        Me.checkboxO365InstallMethod.UseVisualStyleBackColor = True
        '
        'labelUserHasThisOfficeVersion
        '
        Me.labelUserHasThisOfficeVersion.AutoSize = True
        Me.labelUserHasThisOfficeVersion.Location = New System.Drawing.Point(112, 43)
        Me.labelUserHasThisOfficeVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelUserHasThisOfficeVersion.Name = "labelUserHasThisOfficeVersion"
        Me.labelUserHasThisOfficeVersion.Size = New System.Drawing.Size(178, 13)
        Me.labelUserHasThisOfficeVersion.TabIndex = 2
        Me.labelUserHasThisOfficeVersion.Text = "I use this version of Microsoft Office:"
        '
        'comboboxOfficeVersionSelector
        '
        Me.comboboxOfficeVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOfficeVersionSelector.FormattingEnabled = True
        Me.comboboxOfficeVersionSelector.Location = New System.Drawing.Point(115, 58)
        Me.comboboxOfficeVersionSelector.Margin = New System.Windows.Forms.Padding(2)
        Me.comboboxOfficeVersionSelector.Name = "comboboxOfficeVersionSelector"
        Me.comboboxOfficeVersionSelector.Size = New System.Drawing.Size(138, 21)
        Me.comboboxOfficeVersionSelector.TabIndex = 4
        '
        'groupboxOfficeLocation
        '
        Me.groupboxOfficeLocation.Controls.Add(Me.labelDriveTextboxLabel)
        Me.groupboxOfficeLocation.Controls.Add(Me.buttonClearDriveLetter)
        Me.groupboxOfficeLocation.Controls.Add(Me.textboxOfficeDrive)
        Me.groupboxOfficeLocation.Controls.Add(Me.labelOfficeInstalledToDrive)
        Me.groupboxOfficeLocation.Location = New System.Drawing.Point(3, 3)
        Me.groupboxOfficeLocation.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeLocation.Name = "groupboxOfficeLocation"
        Me.groupboxOfficeLocation.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxOfficeLocation.Size = New System.Drawing.Size(415, 130)
        Me.groupboxOfficeLocation.TabIndex = 0
        Me.groupboxOfficeLocation.TabStop = False
        Me.groupboxOfficeLocation.Text = "Where is Microsoft Office located?"
        '
        'labelDriveTextboxLabel
        '
        Me.labelDriveTextboxLabel.AutoSize = True
        Me.labelDriveTextboxLabel.Location = New System.Drawing.Point(113, 68)
        Me.labelDriveTextboxLabel.Name = "labelDriveTextboxLabel"
        Me.labelDriveTextboxLabel.Size = New System.Drawing.Size(32, 13)
        Me.labelDriveTextboxLabel.TabIndex = 4
        Me.labelDriveTextboxLabel.Text = "Drive"
        '
        'buttonClearDriveLetter
        '
        Me.buttonClearDriveLetter.AutoSize = True
        Me.buttonClearDriveLetter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonClearDriveLetter.Location = New System.Drawing.Point(174, 63)
        Me.buttonClearDriveLetter.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonClearDriveLetter.Name = "buttonClearDriveLetter"
        Me.buttonClearDriveLetter.Size = New System.Drawing.Size(41, 23)
        Me.buttonClearDriveLetter.TabIndex = 3
        Me.buttonClearDriveLetter.Text = "Clear"
        Me.buttonClearDriveLetter.UseVisualStyleBackColor = True
        '
        'textboxOfficeDrive
        '
        Me.textboxOfficeDrive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxOfficeDrive.Location = New System.Drawing.Point(150, 65)
        Me.textboxOfficeDrive.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxOfficeDrive.MaxLength = 1
        Me.textboxOfficeDrive.Name = "textboxOfficeDrive"
        Me.textboxOfficeDrive.ShortcutsEnabled = False
        Me.textboxOfficeDrive.Size = New System.Drawing.Size(20, 20)
        Me.textboxOfficeDrive.TabIndex = 2
        Me.textboxOfficeDrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelOfficeInstalledToDrive
        '
        Me.labelOfficeInstalledToDrive.AutoSize = True
        Me.labelOfficeInstalledToDrive.Location = New System.Drawing.Point(113, 44)
        Me.labelOfficeInstalledToDrive.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelOfficeInstalledToDrive.Name = "labelOfficeInstalledToDrive"
        Me.labelOfficeInstalledToDrive.Size = New System.Drawing.Size(188, 13)
        Me.labelOfficeInstalledToDrive.TabIndex = 1
        Me.labelOfficeInstalledToDrive.Text = "I installed Microsoft Office to this drive:"
        '
        'tabpageAdvanced
        '
        Me.tabpageAdvanced.Controls.Add(Me.groupboxBypassConfiguredLocation)
        Me.tabpageAdvanced.Controls.Add(Me.groupboxCPUType)
        Me.tabpageAdvanced.Location = New System.Drawing.Point(4, 22)
        Me.tabpageAdvanced.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageAdvanced.Name = "tabpageAdvanced"
        Me.tabpageAdvanced.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageAdvanced.Size = New System.Drawing.Size(422, 326)
        Me.tabpageAdvanced.TabIndex = 1
        Me.tabpageAdvanced.Text = "Advanced"
        Me.tabpageAdvanced.UseVisualStyleBackColor = True
        '
        'groupboxBypassConfiguredLocation
        '
        Me.groupboxBypassConfiguredLocation.Controls.Add(Me.checkboxBypassConfiguredLocationForDeprecatedApps)
        Me.groupboxBypassConfiguredLocation.Controls.Add(Me.labelBypassConfiguredLocation)
        Me.groupboxBypassConfiguredLocation.Location = New System.Drawing.Point(6, 171)
        Me.groupboxBypassConfiguredLocation.Name = "groupboxBypassConfiguredLocation"
        Me.groupboxBypassConfiguredLocation.Size = New System.Drawing.Size(411, 150)
        Me.groupboxBypassConfiguredLocation.TabIndex = 1
        Me.groupboxBypassConfiguredLocation.TabStop = False
        Me.groupboxBypassConfiguredLocation.Text = "Bypass configured location"
        '
        'checkboxBypassConfiguredLocationForDeprecatedApps
        '
        Me.checkboxBypassConfiguredLocationForDeprecatedApps.AutoSize = True
        Me.checkboxBypassConfiguredLocationForDeprecatedApps.Location = New System.Drawing.Point(55, 89)
        Me.checkboxBypassConfiguredLocationForDeprecatedApps.Name = "checkboxBypassConfiguredLocationForDeprecatedApps"
        Me.checkboxBypassConfiguredLocationForDeprecatedApps.Size = New System.Drawing.Size(307, 17)
        Me.checkboxBypassConfiguredLocationForDeprecatedApps.TabIndex = 1
        Me.checkboxBypassConfiguredLocationForDeprecatedApps.Text = "Bypass configured location for deprecated or removed apps"
        Me.checkboxBypassConfiguredLocationForDeprecatedApps.UseVisualStyleBackColor = True
        '
        'labelBypassConfiguredLocation
        '
        Me.labelBypassConfiguredLocation.AutoSize = True
        Me.labelBypassConfiguredLocation.Location = New System.Drawing.Point(52, 23)
        Me.labelBypassConfiguredLocation.Name = "labelBypassConfiguredLocation"
        Me.labelBypassConfiguredLocation.Size = New System.Drawing.Size(308, 52)
        Me.labelBypassConfiguredLocation.TabIndex = 0
        Me.labelBypassConfiguredLocation.Text = resources.GetString("labelBypassConfiguredLocation.Text")
        '
        'groupboxCPUType
        '
        Me.groupboxCPUType.Controls.Add(Me.labelRecommendedWindowsEdition)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIsQBit)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIs64Bit)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIs32Bit)
        Me.groupboxCPUType.Controls.Add(Me.labelCPUTypeDescription)
        Me.groupboxCPUType.Location = New System.Drawing.Point(3, 3)
        Me.groupboxCPUType.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxCPUType.Name = "groupboxCPUType"
        Me.groupboxCPUType.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxCPUType.Size = New System.Drawing.Size(415, 162)
        Me.groupboxCPUType.TabIndex = 0
        Me.groupboxCPUType.TabStop = False
        Me.groupboxCPUType.Text = "What edition of Windows do you run?"
        '
        'labelRecommendedWindowsEdition
        '
        Me.labelRecommendedWindowsEdition.AutoSize = True
        Me.labelRecommendedWindowsEdition.Location = New System.Drawing.Point(55, 83)
        Me.labelRecommendedWindowsEdition.Name = "labelRecommendedWindowsEdition"
        Me.labelRecommendedWindowsEdition.Size = New System.Drawing.Size(291, 65)
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
        'radiobuttonCPUIs64Bit
        '
        Me.radiobuttonCPUIs64Bit.AutoSize = True
        Me.radiobuttonCPUIs64Bit.Location = New System.Drawing.Point(58, 59)
        Me.radiobuttonCPUIs64Bit.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonCPUIs64Bit.Name = "radiobuttonCPUIs64Bit"
        Me.radiobuttonCPUIs64Bit.Size = New System.Drawing.Size(98, 17)
        Me.radiobuttonCPUIs64Bit.TabIndex = 3
        Me.radiobuttonCPUIs64Bit.TabStop = True
        Me.radiobuttonCPUIs64Bit.Text = "64-bit Windows"
        Me.radiobuttonCPUIs64Bit.UseVisualStyleBackColor = True
        '
        'radiobuttonCPUIs32Bit
        '
        Me.radiobuttonCPUIs32Bit.AutoSize = True
        Me.radiobuttonCPUIs32Bit.Location = New System.Drawing.Point(58, 41)
        Me.radiobuttonCPUIs32Bit.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonCPUIs32Bit.Name = "radiobuttonCPUIs32Bit"
        Me.radiobuttonCPUIs32Bit.Size = New System.Drawing.Size(98, 17)
        Me.radiobuttonCPUIs32Bit.TabIndex = 2
        Me.radiobuttonCPUIs32Bit.TabStop = True
        Me.radiobuttonCPUIs32Bit.Text = "32-bit Windows"
        Me.radiobuttonCPUIs32Bit.UseVisualStyleBackColor = True
        '
        'labelCPUTypeDescription
        '
        Me.labelCPUTypeDescription.AutoSize = True
        Me.labelCPUTypeDescription.Location = New System.Drawing.Point(55, 26)
        Me.labelCPUTypeDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelCPUTypeDescription.Name = "labelCPUTypeDescription"
        Me.labelCPUTypeDescription.Size = New System.Drawing.Size(229, 13)
        Me.labelCPUTypeDescription.TabIndex = 0
        Me.labelCPUTypeDescription.Text = "Choose which edition of Windows you're using:"
        '
        'tabpagePersonalization
        '
        Me.tabpagePersonalization.Controls.Add(Me.groupboxStatusbar)
        Me.tabpagePersonalization.Controls.Add(Me.groupboxAppearance)
        Me.tabpagePersonalization.Location = New System.Drawing.Point(4, 22)
        Me.tabpagePersonalization.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpagePersonalization.Name = "tabpagePersonalization"
        Me.tabpagePersonalization.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpagePersonalization.Size = New System.Drawing.Size(422, 326)
        Me.tabpagePersonalization.TabIndex = 2
        Me.tabpagePersonalization.Text = "Personalization"
        Me.tabpagePersonalization.UseVisualStyleBackColor = True
        '
        'groupboxStatusbar
        '
        Me.groupboxStatusbar.Controls.Add(Me.buttonClearFirstname)
        Me.groupboxStatusbar.Controls.Add(Me.labelFirstName)
        Me.groupboxStatusbar.Controls.Add(Me.textboxFirstname)
        Me.groupboxStatusbar.Controls.Add(Me.radiobuttonCustomStatusbarGreeting)
        Me.groupboxStatusbar.Controls.Add(Me.radiobuttonDefaultStatusbarGreeting)
        Me.groupboxStatusbar.Controls.Add(Me.labelCustomStatusbarGreeting)
        Me.groupboxStatusbar.Location = New System.Drawing.Point(6, 189)
        Me.groupboxStatusbar.Name = "groupboxStatusbar"
        Me.groupboxStatusbar.Size = New System.Drawing.Size(411, 132)
        Me.groupboxStatusbar.TabIndex = 1
        Me.groupboxStatusbar.TabStop = False
        Me.groupboxStatusbar.Text = "Statusbar"
        '
        'buttonClearFirstname
        '
        Me.buttonClearFirstname.Location = New System.Drawing.Point(320, 89)
        Me.buttonClearFirstname.Name = "buttonClearFirstname"
        Me.buttonClearFirstname.Size = New System.Drawing.Size(55, 23)
        Me.buttonClearFirstname.TabIndex = 5
        Me.buttonClearFirstname.Text = "Clear"
        Me.buttonClearFirstname.UseVisualStyleBackColor = True
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.Location = New System.Drawing.Point(6, 94)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(106, 13)
        Me.labelFirstName.TabIndex = 4
        Me.labelFirstName.Text = "Firstname/nickname:"
        '
        'textboxFirstname
        '
        Me.textboxFirstname.Location = New System.Drawing.Point(121, 91)
        Me.textboxFirstname.Name = "textboxFirstname"
        Me.textboxFirstname.Size = New System.Drawing.Size(193, 20)
        Me.textboxFirstname.TabIndex = 3
        '
        'radiobuttonCustomStatusbarGreeting
        '
        Me.radiobuttonCustomStatusbarGreeting.AutoSize = True
        Me.radiobuttonCustomStatusbarGreeting.Location = New System.Drawing.Point(7, 68)
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
        Me.radiobuttonDefaultStatusbarGreeting.Location = New System.Drawing.Point(7, 45)
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
        Me.labelCustomStatusbarGreeting.Location = New System.Drawing.Point(4, 16)
        Me.labelCustomStatusbarGreeting.Name = "labelCustomStatusbarGreeting"
        Me.labelCustomStatusbarGreeting.Size = New System.Drawing.Size(369, 26)
        Me.labelCustomStatusbarGreeting.TabIndex = 0
        Me.labelCustomStatusbarGreeting.Text = "You can choose to use a statusbar greeting personalized with your firstname" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or n" &
    "ickname, or to use the default. Your name will not be used to identify you."
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
        Me.groupboxAppearance.Location = New System.Drawing.Point(6, 4)
        Me.groupboxAppearance.Name = "groupboxAppearance"
        Me.groupboxAppearance.Size = New System.Drawing.Size(411, 184)
        Me.groupboxAppearance.TabIndex = 0
        Me.groupboxAppearance.TabStop = False
        Me.groupboxAppearance.Text = "Appearance"
        '
        'checkboxMatchWindows10ThemeSettings
        '
        Me.checkboxMatchWindows10ThemeSettings.AutoSize = True
        Me.checkboxMatchWindows10ThemeSettings.Location = New System.Drawing.Point(216, 93)
        Me.checkboxMatchWindows10ThemeSettings.Name = "checkboxMatchWindows10ThemeSettings"
        Me.checkboxMatchWindows10ThemeSettings.Size = New System.Drawing.Size(189, 17)
        Me.checkboxMatchWindows10ThemeSettings.TabIndex = 3
        Me.checkboxMatchWindows10ThemeSettings.Text = "Match Windows 10 theme settings"
        Me.tooltipMatchWindows10ThemeSettings.SetToolTip(Me.checkboxMatchWindows10ThemeSettings, "If the system theme is set to Light, then the Default theme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be applied on a" &
        "pp startup." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If the system theme is set to Dark, then the TenDark theme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will " &
        "be applied on app startup.")
        Me.checkboxMatchWindows10ThemeSettings.UseVisualStyleBackColor = True
        '
        'labelCustomThemePath
        '
        Me.labelCustomThemePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelCustomThemePath.AutoSize = True
        Me.labelCustomThemePath.Location = New System.Drawing.Point(213, 142)
        Me.labelCustomThemePath.Name = "labelCustomThemePath"
        Me.labelCustomThemePath.Size = New System.Drawing.Size(101, 13)
        Me.labelCustomThemePath.TabIndex = 6
        Me.labelCustomThemePath.Text = "Custom theme path:"
        '
        'buttonCustomThemesBrowse
        '
        Me.buttonCustomThemesBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonCustomThemesBrowse.Location = New System.Drawing.Point(336, 155)
        Me.buttonCustomThemesBrowse.Name = "buttonCustomThemesBrowse"
        Me.buttonCustomThemesBrowse.Size = New System.Drawing.Size(68, 23)
        Me.buttonCustomThemesBrowse.TabIndex = 5
        Me.buttonCustomThemesBrowse.Text = "Browse..."
        Me.buttonCustomThemesBrowse.UseVisualStyleBackColor = True
        '
        'textboxCustomThemePath
        '
        Me.textboxCustomThemePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxCustomThemePath.Location = New System.Drawing.Point(216, 158)
        Me.textboxCustomThemePath.Name = "textboxCustomThemePath"
        Me.textboxCustomThemePath.Size = New System.Drawing.Size(117, 20)
        Me.textboxCustomThemePath.TabIndex = 4
        Me.tooltipCustomThemePath.SetToolTip(Me.textboxCustomThemePath, "(Placeholder)")
        '
        'labelThemeList
        '
        Me.labelThemeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelThemeList.AutoSize = True
        Me.labelThemeList.Location = New System.Drawing.Point(213, 49)
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
        Me.comboboxThemeList.Location = New System.Drawing.Point(216, 65)
        Me.comboboxThemeList.Name = "comboboxThemeList"
        Me.comboboxThemeList.Size = New System.Drawing.Size(188, 21)
        Me.comboboxThemeList.TabIndex = 2
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
        Me.textboxThemeInfo.TabIndex = 1
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
        'buttonTestSettings
        '
        Me.buttonTestSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonTestSettings.AutoSize = True
        Me.buttonTestSettings.Location = New System.Drawing.Point(73, 364)
        Me.buttonTestSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonTestSettings.Name = "buttonTestSettings"
        Me.buttonTestSettings.Size = New System.Drawing.Size(77, 28)
        Me.buttonTestSettings.TabIndex = 7
        Me.buttonTestSettings.Text = "Test settings"
        Me.buttonTestSettings.UseVisualStyleBackColor = True
        '
        'buttonDefaultSettings
        '
        Me.buttonDefaultSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonDefaultSettings.AutoSize = True
        Me.buttonDefaultSettings.Location = New System.Drawing.Point(8, 364)
        Me.buttonDefaultSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonDefaultSettings.Name = "buttonDefaultSettings"
        Me.buttonDefaultSettings.Size = New System.Drawing.Size(59, 28)
        Me.buttonDefaultSettings.TabIndex = 6
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
        Me.groupboxOfficeVersion.ResumeLayout(False)
        Me.groupboxOfficeVersion.PerformLayout()
        Me.groupboxOfficeLocation.ResumeLayout(False)
        Me.groupboxOfficeLocation.PerformLayout()
        Me.tabpageAdvanced.ResumeLayout(False)
        Me.groupboxBypassConfiguredLocation.ResumeLayout(False)
        Me.groupboxBypassConfiguredLocation.PerformLayout()
        Me.groupboxCPUType.ResumeLayout(False)
        Me.groupboxCPUType.PerformLayout()
        Me.tabpagePersonalization.ResumeLayout(False)
        Me.groupboxStatusbar.ResumeLayout(False)
        Me.groupboxStatusbar.PerformLayout()
        Me.groupboxAppearance.ResumeLayout(False)
        Me.groupboxAppearance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tableLayoutPanelOptionsWindow As TableLayoutPanel
    Friend WithEvents buttonSaveSettings As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonDefaultSettings As Button
    Friend WithEvents tabcontrolOptionsWindow As TabControl
    Friend WithEvents tabpageGeneral As TabPage
    Friend WithEvents tabpageAdvanced As TabPage
    Friend WithEvents groupboxOfficeLocation As GroupBox
    Friend WithEvents labelOfficeInstalledToDrive As Label
    Friend WithEvents textboxOfficeDrive As TextBox
    Friend WithEvents buttonClearDriveLetter As Button
    Friend WithEvents groupboxOfficeVersion As GroupBox
    Friend WithEvents comboboxOfficeVersionSelector As ComboBox
    Friend WithEvents labelUserHasThisOfficeVersion As Label
    Friend WithEvents checkboxO365InstallMethod As CheckBox
    Friend WithEvents groupboxCPUType As GroupBox
    Friend WithEvents labelCPUTypeDescription As Label
    Friend WithEvents radiobuttonCPUIs32Bit As RadioButton
    Friend WithEvents radiobuttonCPUIs64Bit As RadioButton
    Friend WithEvents radiobuttonCPUIsQBit As RadioButton
    Friend WithEvents buttonTestSettings As Button
    Friend WithEvents labelOfficeInstallMethodDescription As Label
    Friend WithEvents tooltipO365InstallMethod As ToolTip
    Friend WithEvents labelDriveTextboxLabel As Label
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
    Friend WithEvents groupboxStatusbar As GroupBox
    Friend WithEvents labelCustomStatusbarGreeting As Label
    Friend WithEvents radiobuttonCustomStatusbarGreeting As RadioButton
    Friend WithEvents radiobuttonDefaultStatusbarGreeting As RadioButton
    Friend WithEvents textboxFirstname As TextBox
    Friend WithEvents labelFirstName As Label
    Friend WithEvents buttonClearFirstname As Button
    Friend WithEvents openfiledialogBrowseCustomThemeFile As OpenFileDialog
    Friend WithEvents labelRecommendedWindowsEdition As Label
    Friend WithEvents groupboxBypassConfiguredLocation As GroupBox
    Friend WithEvents labelBypassConfiguredLocation As Label
    Friend WithEvents checkboxBypassConfiguredLocationForDeprecatedApps As CheckBox
    Friend WithEvents tooltipCustomThemePath As ToolTip
    Friend WithEvents checkboxMatchWindows10ThemeSettings As CheckBox
    Friend WithEvents tooltipMatchWindows10ThemeSettings As ToolTip
End Class
