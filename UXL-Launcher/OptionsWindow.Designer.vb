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
        Me.tableLayoutPanelOptionsWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonSaveSettings = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.tabcontrolOptionsWindow = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxOfficeVersion = New System.Windows.Forms.GroupBox()
        Me.labelOfficeInstallMethodDescription = New System.Windows.Forms.Label()
        Me.checkboxMSIInstallMethod = New System.Windows.Forms.CheckBox()
        Me.checkboxO365InstallMethod = New System.Windows.Forms.CheckBox()
        Me.labelUserHasThisOfficeVersion = New System.Windows.Forms.Label()
        Me.comboboxOfficeVersionSelector = New System.Windows.Forms.ComboBox()
        Me.groupboxOfficeLocation = New System.Windows.Forms.GroupBox()
        Me.labelDriveTextboxLabel = New System.Windows.Forms.Label()
        Me.buttonClearTextbox = New System.Windows.Forms.Button()
        Me.textboxOfficeDrive = New System.Windows.Forms.TextBox()
        Me.labelOfficeInstalledToDrive = New System.Windows.Forms.Label()
        Me.tabpageAdvanced = New System.Windows.Forms.TabPage()
        Me.groupboxCPUType = New System.Windows.Forms.GroupBox()
        Me.linklabelWindowsEditionLearnMore = New System.Windows.Forms.LinkLabel()
        Me.radiobuttonCPUIsQBit = New System.Windows.Forms.RadioButton()
        Me.radiobuttonCPUIs64Bit = New System.Windows.Forms.RadioButton()
        Me.radiobuttonCPUIs32Bit = New System.Windows.Forms.RadioButton()
        Me.buttonHelpMeCPUType = New System.Windows.Forms.Button()
        Me.labelCPUTypeDescription = New System.Windows.Forms.Label()
        Me.tabpagePersonalization = New System.Windows.Forms.TabPage()
        Me.buttonTestSettings = New System.Windows.Forms.Button()
        Me.buttonDefaultSettings = New System.Windows.Forms.Button()
        Me.tooltipMSIInstallMethodWorkaround = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipO365InstallMethod = New System.Windows.Forms.ToolTip(Me.components)
        Me.tooltipSystemInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.groupboxAppearance = New System.Windows.Forms.GroupBox()
        Me.tableLayoutPanelOptionsWindow.SuspendLayout()
        Me.tabcontrolOptionsWindow.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxOfficeVersion.SuspendLayout()
        Me.groupboxOfficeLocation.SuspendLayout()
        Me.tabpageAdvanced.SuspendLayout()
        Me.groupboxCPUType.SuspendLayout()
        Me.tabpagePersonalization.SuspendLayout()
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
        Me.buttonSaveSettings.TabIndex = 0
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
        Me.buttonCancel.TabIndex = 1
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
        Me.tabcontrolOptionsWindow.TabIndex = 3
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
        Me.groupboxOfficeVersion.Controls.Add(Me.checkboxMSIInstallMethod)
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
        'checkboxMSIInstallMethod
        '
        Me.checkboxMSIInstallMethod.AutoSize = True
        Me.checkboxMSIInstallMethod.Location = New System.Drawing.Point(115, 126)
        Me.checkboxMSIInstallMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxMSIInstallMethod.Name = "checkboxMSIInstallMethod"
        Me.checkboxMSIInstallMethod.Size = New System.Drawing.Size(109, 17)
        Me.checkboxMSIInstallMethod.TabIndex = 4
        Me.checkboxMSIInstallMethod.Text = "I installed via MSI"
        Me.tooltipMSIInstallMethodWorkaround.SetToolTip(Me.checkboxMSIInstallMethod, "This option is only used when Office 2013 is chosen above." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Leave this unchecked " &
        "if you don't know what the MSI install" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "method for Microsoft Office is.")
        Me.checkboxMSIInstallMethod.UseVisualStyleBackColor = True
        '
        'checkboxO365InstallMethod
        '
        Me.checkboxO365InstallMethod.AutoSize = True
        Me.checkboxO365InstallMethod.Location = New System.Drawing.Point(115, 108)
        Me.checkboxO365InstallMethod.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxO365InstallMethod.Name = "checkboxO365InstallMethod"
        Me.checkboxO365InstallMethod.Size = New System.Drawing.Size(139, 17)
        Me.checkboxO365InstallMethod.TabIndex = 3
        Me.checkboxO365InstallMethod.Text = "I installed via Office 365"
        Me.tooltipO365InstallMethod.SetToolTip(Me.checkboxO365InstallMethod, "If you're using Office 2016, there's a good chance you installed via Office 365." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you're using Office 2010, you probably didn't install via Office 365.")
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
        Me.comboboxOfficeVersionSelector.TabIndex = 1
        '
        'groupboxOfficeLocation
        '
        Me.groupboxOfficeLocation.Controls.Add(Me.labelDriveTextboxLabel)
        Me.groupboxOfficeLocation.Controls.Add(Me.buttonClearTextbox)
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
        'buttonClearTextbox
        '
        Me.buttonClearTextbox.AutoSize = True
        Me.buttonClearTextbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonClearTextbox.Location = New System.Drawing.Point(183, 63)
        Me.buttonClearTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonClearTextbox.Name = "buttonClearTextbox"
        Me.buttonClearTextbox.Size = New System.Drawing.Size(82, 23)
        Me.buttonClearTextbox.TabIndex = 3
        Me.buttonClearTextbox.Text = "Clear Textbox"
        Me.buttonClearTextbox.UseVisualStyleBackColor = True
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
        'groupboxCPUType
        '
        Me.groupboxCPUType.Controls.Add(Me.linklabelWindowsEditionLearnMore)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIsQBit)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIs64Bit)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIs32Bit)
        Me.groupboxCPUType.Controls.Add(Me.buttonHelpMeCPUType)
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
        'linklabelWindowsEditionLearnMore
        '
        Me.linklabelWindowsEditionLearnMore.AutoSize = True
        Me.linklabelWindowsEditionLearnMore.LinkArea = New System.Windows.Forms.LinkArea(120, 13)
        Me.linklabelWindowsEditionLearnMore.Location = New System.Drawing.Point(93, 93)
        Me.linklabelWindowsEditionLearnMore.Name = "linklabelWindowsEditionLearnMore"
        Me.linklabelWindowsEditionLearnMore.Size = New System.Drawing.Size(190, 55)
        Me.linklabelWindowsEditionLearnMore.TabIndex = 5
        Me.linklabelWindowsEditionLearnMore.TabStop = True
        Me.linklabelWindowsEditionLearnMore.Text = "The ""View system info"" button will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "be replaced with a label that directly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "shows" &
    " your Windows edition" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in version 3.2. Learn more..."
        Me.linklabelWindowsEditionLearnMore.UseCompatibleTextRendering = True
        '
        'radiobuttonCPUIsQBit
        '
        Me.radiobuttonCPUIsQBit.AutoSize = True
        Me.radiobuttonCPUIsQBit.Location = New System.Drawing.Point(450, 160)
        Me.radiobuttonCPUIsQBit.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonCPUIsQBit.Name = "radiobuttonCPUIsQBit"
        Me.radiobuttonCPUIsQBit.Size = New System.Drawing.Size(207, 17)
        Me.radiobuttonCPUIsQBit.TabIndex = 4
        Me.radiobuttonCPUIsQBit.TabStop = True
        Me.radiobuttonCPUIsQBit.Text = "I'm running Quantum-bit Windows lawl."
        Me.radiobuttonCPUIsQBit.UseVisualStyleBackColor = True
        '
        'radiobuttonCPUIs64Bit
        '
        Me.radiobuttonCPUIs64Bit.AutoSize = True
        Me.radiobuttonCPUIs64Bit.Location = New System.Drawing.Point(96, 74)
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
        Me.radiobuttonCPUIs32Bit.Location = New System.Drawing.Point(96, 56)
        Me.radiobuttonCPUIs32Bit.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonCPUIs32Bit.Name = "radiobuttonCPUIs32Bit"
        Me.radiobuttonCPUIs32Bit.Size = New System.Drawing.Size(98, 17)
        Me.radiobuttonCPUIs32Bit.TabIndex = 2
        Me.radiobuttonCPUIs32Bit.TabStop = True
        Me.radiobuttonCPUIs32Bit.Text = "32-bit Windows"
        Me.radiobuttonCPUIs32Bit.UseVisualStyleBackColor = True
        '
        'buttonHelpMeCPUType
        '
        Me.buttonHelpMeCPUType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonHelpMeCPUType.Location = New System.Drawing.Point(306, 125)
        Me.buttonHelpMeCPUType.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonHelpMeCPUType.Name = "buttonHelpMeCPUType"
        Me.buttonHelpMeCPUType.Size = New System.Drawing.Size(105, 33)
        Me.buttonHelpMeCPUType.TabIndex = 1
        Me.buttonHelpMeCPUType.Text = "View system info"
        Me.tooltipSystemInfo.SetToolTip(Me.buttonHelpMeCPUType, "Open the System Info page in the Control Panel.")
        Me.buttonHelpMeCPUType.UseVisualStyleBackColor = True
        '
        'labelCPUTypeDescription
        '
        Me.labelCPUTypeDescription.AutoSize = True
        Me.labelCPUTypeDescription.Location = New System.Drawing.Point(93, 41)
        Me.labelCPUTypeDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelCPUTypeDescription.Name = "labelCPUTypeDescription"
        Me.labelCPUTypeDescription.Size = New System.Drawing.Size(229, 13)
        Me.labelCPUTypeDescription.TabIndex = 0
        Me.labelCPUTypeDescription.Text = "Choose which edition of Windows you're using:"
        '
        'tabpagePersonalization
        '
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
        'buttonTestSettings
        '
        Me.buttonTestSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonTestSettings.AutoSize = True
        Me.buttonTestSettings.Location = New System.Drawing.Point(73, 364)
        Me.buttonTestSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonTestSettings.Name = "buttonTestSettings"
        Me.buttonTestSettings.Size = New System.Drawing.Size(77, 28)
        Me.buttonTestSettings.TabIndex = 4
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
        Me.buttonDefaultSettings.TabIndex = 2
        Me.buttonDefaultSettings.Text = "Defaults"
        Me.buttonDefaultSettings.UseVisualStyleBackColor = True
        '
        'groupboxAppearance
        '
        Me.groupboxAppearance.Location = New System.Drawing.Point(6, 4)
        Me.groupboxAppearance.Name = "groupboxAppearance"
        Me.groupboxAppearance.Size = New System.Drawing.Size(411, 184)
        Me.groupboxAppearance.TabIndex = 0
        Me.groupboxAppearance.TabStop = False
        Me.groupboxAppearance.Text = "Appearance"
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
        Me.groupboxCPUType.ResumeLayout(False)
        Me.groupboxCPUType.PerformLayout()
        Me.tabpagePersonalization.ResumeLayout(False)
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
    Friend WithEvents buttonClearTextbox As Button
    Friend WithEvents groupboxOfficeVersion As GroupBox
    Friend WithEvents comboboxOfficeVersionSelector As ComboBox
    Friend WithEvents labelUserHasThisOfficeVersion As Label
    Friend WithEvents checkboxO365InstallMethod As CheckBox
    Friend WithEvents groupboxCPUType As GroupBox
    Friend WithEvents labelCPUTypeDescription As Label
    Friend WithEvents buttonHelpMeCPUType As Button
    Friend WithEvents radiobuttonCPUIs32Bit As RadioButton
    Friend WithEvents radiobuttonCPUIs64Bit As RadioButton
    Friend WithEvents radiobuttonCPUIsQBit As RadioButton
    Friend WithEvents buttonTestSettings As Button
    Friend WithEvents checkboxMSIInstallMethod As CheckBox
    Friend WithEvents labelOfficeInstallMethodDescription As Label
    Friend WithEvents tooltipMSIInstallMethodWorkaround As ToolTip
    Friend WithEvents tooltipO365InstallMethod As ToolTip
    Friend WithEvents labelDriveTextboxLabel As Label
    Friend WithEvents tooltipSystemInfo As ToolTip
    Friend WithEvents linklabelWindowsEditionLearnMore As LinkLabel
    Friend WithEvents tabpagePersonalization As TabPage
    Friend WithEvents groupboxAppearance As GroupBox
End Class
