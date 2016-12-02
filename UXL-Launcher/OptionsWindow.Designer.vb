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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformOptionsWindow))
        Me.tableLayoutPanelOptionsWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonSaveSettings = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.tabcontrolOptionsWindow = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxOfficeVersion = New System.Windows.Forms.GroupBox()
        Me.checkboxMSIInstallMethod = New System.Windows.Forms.CheckBox()
        Me.checkboxO365InstallMethod = New System.Windows.Forms.CheckBox()
        Me.labelUserHasThisOfficeVersion = New System.Windows.Forms.Label()
        Me.comboboxOfficeVersionSelector = New System.Windows.Forms.ComboBox()
        Me.labelOfficeVersionDescription = New System.Windows.Forms.Label()
        Me.groupboxOfficeLocation = New System.Windows.Forms.GroupBox()
        Me.buttonClearTextbox = New System.Windows.Forms.Button()
        Me.textboxOfficeDrive = New System.Windows.Forms.TextBox()
        Me.labelOfficeInstalledToDrive = New System.Windows.Forms.Label()
        Me.labelOfficeLocationDescription = New System.Windows.Forms.Label()
        Me.tabpageAdvanced = New System.Windows.Forms.TabPage()
        Me.groupboxCPUType = New System.Windows.Forms.GroupBox()
        Me.radiobuttonCPUIsQBit = New System.Windows.Forms.RadioButton()
        Me.radiobuttonCPUIs64Bit = New System.Windows.Forms.RadioButton()
        Me.radiobuttonCPUIs32Bit = New System.Windows.Forms.RadioButton()
        Me.buttonHelpMeCPUType = New System.Windows.Forms.Button()
        Me.labelCPUTypeDescription = New System.Windows.Forms.Label()
        Me.buttonTestSettings = New System.Windows.Forms.Button()
        Me.buttonDefaultSettings = New System.Windows.Forms.Button()
        Me.tableLayoutPanelOptionsWindow.SuspendLayout()
        Me.tabcontrolOptionsWindow.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxOfficeVersion.SuspendLayout()
        Me.groupboxOfficeLocation.SuspendLayout()
        Me.tabpageAdvanced.SuspendLayout()
        Me.groupboxCPUType.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanelOptionsWindow
        '
        Me.tableLayoutPanelOptionsWindow.ColumnCount = 5
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonSaveSettings, 4, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonCancel, 3, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.tabcontrolOptionsWindow, 0, 0)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonTestSettings, 1, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonDefaultSettings, 0, 1)
        Me.tableLayoutPanelOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelOptionsWindow.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanelOptionsWindow.Margin = New System.Windows.Forms.Padding(4)
        Me.tableLayoutPanelOptionsWindow.Name = "tableLayoutPanelOptionsWindow"
        Me.tableLayoutPanelOptionsWindow.RowCount = 2
        Me.tableLayoutPanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.0!))
        Me.tableLayoutPanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.tableLayoutPanelOptionsWindow.Size = New System.Drawing.Size(970, 788)
        Me.tableLayoutPanelOptionsWindow.TabIndex = 0
        '
        'buttonSaveSettings
        '
        Me.buttonSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonSaveSettings.AutoSize = True
        Me.buttonSaveSettings.Location = New System.Drawing.Point(814, 728)
        Me.buttonSaveSettings.Margin = New System.Windows.Forms.Padding(4, 4, 16, 4)
        Me.buttonSaveSettings.Name = "buttonSaveSettings"
        Me.buttonSaveSettings.Size = New System.Drawing.Size(140, 56)
        Me.buttonSaveSettings.TabIndex = 0
        Me.buttonSaveSettings.Text = "Save"
        Me.buttonSaveSettings.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonCancel.AutoSize = True
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Location = New System.Drawing.Point(662, 728)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(144, 56)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'tabcontrolOptionsWindow
        '
        Me.tableLayoutPanelOptionsWindow.SetColumnSpan(Me.tabcontrolOptionsWindow, 5)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageAdvanced)
        Me.tabcontrolOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptionsWindow.Location = New System.Drawing.Point(16, 16)
        Me.tabcontrolOptionsWindow.Margin = New System.Windows.Forms.Padding(16, 16, 16, 4)
        Me.tabcontrolOptionsWindow.Name = "tabcontrolOptionsWindow"
        Me.tabcontrolOptionsWindow.SelectedIndex = 0
        Me.tabcontrolOptionsWindow.Size = New System.Drawing.Size(938, 704)
        Me.tabcontrolOptionsWindow.TabIndex = 3
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeVersion)
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeLocation)
        Me.tabpageGeneral.Location = New System.Drawing.Point(8, 39)
        Me.tabpageGeneral.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageGeneral.Size = New System.Drawing.Size(922, 657)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxOfficeVersion
        '
        Me.groupboxOfficeVersion.Controls.Add(Me.checkboxMSIInstallMethod)
        Me.groupboxOfficeVersion.Controls.Add(Me.checkboxO365InstallMethod)
        Me.groupboxOfficeVersion.Controls.Add(Me.labelUserHasThisOfficeVersion)
        Me.groupboxOfficeVersion.Controls.Add(Me.comboboxOfficeVersionSelector)
        Me.groupboxOfficeVersion.Controls.Add(Me.labelOfficeVersionDescription)
        Me.groupboxOfficeVersion.Location = New System.Drawing.Point(6, 274)
        Me.groupboxOfficeVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.groupboxOfficeVersion.Name = "groupboxOfficeVersion"
        Me.groupboxOfficeVersion.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxOfficeVersion.Size = New System.Drawing.Size(912, 374)
        Me.groupboxOfficeVersion.TabIndex = 1
        Me.groupboxOfficeVersion.TabStop = False
        Me.groupboxOfficeVersion.Text = "What version of Microsoft Office do you use? How was it installed?"
        '
        'checkboxMSIInstallMethod
        '
        Me.checkboxMSIInstallMethod.AutoSize = True
        Me.checkboxMSIInstallMethod.Location = New System.Drawing.Point(71, 249)
        Me.checkboxMSIInstallMethod.Name = "checkboxMSIInstallMethod"
        Me.checkboxMSIInstallMethod.Size = New System.Drawing.Size(212, 29)
        Me.checkboxMSIInstallMethod.TabIndex = 4
        Me.checkboxMSIInstallMethod.Text = "I installed via MSI"
        Me.checkboxMSIInstallMethod.UseVisualStyleBackColor = True
        '
        'checkboxO365InstallMethod
        '
        Me.checkboxO365InstallMethod.AutoSize = True
        Me.checkboxO365InstallMethod.Location = New System.Drawing.Point(71, 213)
        Me.checkboxO365InstallMethod.Margin = New System.Windows.Forms.Padding(4)
        Me.checkboxO365InstallMethod.Name = "checkboxO365InstallMethod"
        Me.checkboxO365InstallMethod.Size = New System.Drawing.Size(273, 29)
        Me.checkboxO365InstallMethod.TabIndex = 3
        Me.checkboxO365InstallMethod.Text = "I installed via Office 365"
        Me.checkboxO365InstallMethod.UseVisualStyleBackColor = True
        '
        'labelUserHasThisOfficeVersion
        '
        Me.labelUserHasThisOfficeVersion.AutoSize = True
        Me.labelUserHasThisOfficeVersion.Location = New System.Drawing.Point(66, 133)
        Me.labelUserHasThisOfficeVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelUserHasThisOfficeVersion.Name = "labelUserHasThisOfficeVersion"
        Me.labelUserHasThisOfficeVersion.Size = New System.Drawing.Size(360, 25)
        Me.labelUserHasThisOfficeVersion.TabIndex = 2
        Me.labelUserHasThisOfficeVersion.Text = "I use this version of Microsoft Office:"
        '
        'comboboxOfficeVersionSelector
        '
        Me.comboboxOfficeVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOfficeVersionSelector.FormattingEnabled = True
        Me.comboboxOfficeVersionSelector.Location = New System.Drawing.Point(71, 162)
        Me.comboboxOfficeVersionSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxOfficeVersionSelector.Name = "comboboxOfficeVersionSelector"
        Me.comboboxOfficeVersionSelector.Size = New System.Drawing.Size(272, 33)
        Me.comboboxOfficeVersionSelector.TabIndex = 1
        '
        'labelOfficeVersionDescription
        '
        Me.labelOfficeVersionDescription.AutoSize = True
        Me.labelOfficeVersionDescription.Location = New System.Drawing.Point(247, 264)
        Me.labelOfficeVersionDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelOfficeVersionDescription.Name = "labelOfficeVersionDescription"
        Me.labelOfficeVersionDescription.Size = New System.Drawing.Size(529, 50)
        Me.labelOfficeVersionDescription.TabIndex = 0
        Me.labelOfficeVersionDescription.Text = "Choose the apropriate version and installation method" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "you used to install Micros" &
    "oft Office."
        '
        'groupboxOfficeLocation
        '
        Me.groupboxOfficeLocation.Controls.Add(Me.buttonClearTextbox)
        Me.groupboxOfficeLocation.Controls.Add(Me.textboxOfficeDrive)
        Me.groupboxOfficeLocation.Controls.Add(Me.labelOfficeInstalledToDrive)
        Me.groupboxOfficeLocation.Controls.Add(Me.labelOfficeLocationDescription)
        Me.groupboxOfficeLocation.Location = New System.Drawing.Point(6, 6)
        Me.groupboxOfficeLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.groupboxOfficeLocation.Name = "groupboxOfficeLocation"
        Me.groupboxOfficeLocation.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxOfficeLocation.Size = New System.Drawing.Size(912, 260)
        Me.groupboxOfficeLocation.TabIndex = 0
        Me.groupboxOfficeLocation.TabStop = False
        Me.groupboxOfficeLocation.Text = "Where is Microsoft Office located?"
        '
        'buttonClearTextbox
        '
        Me.buttonClearTextbox.AutoSize = True
        Me.buttonClearTextbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonClearTextbox.Location = New System.Drawing.Point(471, 158)
        Me.buttonClearTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonClearTextbox.Name = "buttonClearTextbox"
        Me.buttonClearTextbox.Size = New System.Drawing.Size(156, 35)
        Me.buttonClearTextbox.TabIndex = 3
        Me.buttonClearTextbox.Text = "Clear Textbox"
        Me.buttonClearTextbox.UseVisualStyleBackColor = True
        '
        'textboxOfficeDrive
        '
        Me.textboxOfficeDrive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxOfficeDrive.Location = New System.Drawing.Point(414, 160)
        Me.textboxOfficeDrive.Margin = New System.Windows.Forms.Padding(4)
        Me.textboxOfficeDrive.MaxLength = 1
        Me.textboxOfficeDrive.Name = "textboxOfficeDrive"
        Me.textboxOfficeDrive.ShortcutsEnabled = False
        Me.textboxOfficeDrive.Size = New System.Drawing.Size(36, 31)
        Me.textboxOfficeDrive.TabIndex = 2
        Me.textboxOfficeDrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelOfficeInstalledToDrive
        '
        Me.labelOfficeInstalledToDrive.AutoSize = True
        Me.labelOfficeInstalledToDrive.Location = New System.Drawing.Point(66, 164)
        Me.labelOfficeInstalledToDrive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelOfficeInstalledToDrive.Name = "labelOfficeInstalledToDrive"
        Me.labelOfficeInstalledToDrive.Size = New System.Drawing.Size(342, 25)
        Me.labelOfficeInstalledToDrive.TabIndex = 1
        Me.labelOfficeInstalledToDrive.Text = "I installed Microsoft Office to drive:"
        '
        'labelOfficeLocationDescription
        '
        Me.labelOfficeLocationDescription.AutoSize = True
        Me.labelOfficeLocationDescription.Location = New System.Drawing.Point(130, 68)
        Me.labelOfficeLocationDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelOfficeLocationDescription.Name = "labelOfficeLocationDescription"
        Me.labelOfficeLocationDescription.Size = New System.Drawing.Size(600, 25)
        Me.labelOfficeLocationDescription.TabIndex = 0
        Me.labelOfficeLocationDescription.Text = "Enter the drive you installed Microsoft Office to in the textbox."
        '
        'tabpageAdvanced
        '
        Me.tabpageAdvanced.Controls.Add(Me.groupboxCPUType)
        Me.tabpageAdvanced.Location = New System.Drawing.Point(8, 39)
        Me.tabpageAdvanced.Margin = New System.Windows.Forms.Padding(4)
        Me.tabpageAdvanced.Name = "tabpageAdvanced"
        Me.tabpageAdvanced.Padding = New System.Windows.Forms.Padding(4)
        Me.tabpageAdvanced.Size = New System.Drawing.Size(922, 657)
        Me.tabpageAdvanced.TabIndex = 1
        Me.tabpageAdvanced.Text = "Advanced"
        Me.tabpageAdvanced.UseVisualStyleBackColor = True
        '
        'groupboxCPUType
        '
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIsQBit)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIs64Bit)
        Me.groupboxCPUType.Controls.Add(Me.radiobuttonCPUIs32Bit)
        Me.groupboxCPUType.Controls.Add(Me.buttonHelpMeCPUType)
        Me.groupboxCPUType.Controls.Add(Me.labelCPUTypeDescription)
        Me.groupboxCPUType.Location = New System.Drawing.Point(6, 6)
        Me.groupboxCPUType.Margin = New System.Windows.Forms.Padding(4)
        Me.groupboxCPUType.Name = "groupboxCPUType"
        Me.groupboxCPUType.Padding = New System.Windows.Forms.Padding(4)
        Me.groupboxCPUType.Size = New System.Drawing.Size(912, 324)
        Me.groupboxCPUType.TabIndex = 0
        Me.groupboxCPUType.TabStop = False
        Me.groupboxCPUType.Text = "What edition of Windows do you run?"
        '
        'radiobuttonCPUIsQBit
        '
        Me.radiobuttonCPUIsQBit.AutoSize = True
        Me.radiobuttonCPUIsQBit.Location = New System.Drawing.Point(900, 320)
        Me.radiobuttonCPUIsQBit.Margin = New System.Windows.Forms.Padding(4)
        Me.radiobuttonCPUIsQBit.Name = "radiobuttonCPUIsQBit"
        Me.radiobuttonCPUIsQBit.Size = New System.Drawing.Size(412, 29)
        Me.radiobuttonCPUIsQBit.TabIndex = 4
        Me.radiobuttonCPUIsQBit.TabStop = True
        Me.radiobuttonCPUIsQBit.Text = "I'm running Quantum-bit Windows lawl."
        Me.radiobuttonCPUIsQBit.UseVisualStyleBackColor = True
        '
        'radiobuttonCPUIs64Bit
        '
        Me.radiobuttonCPUIs64Bit.AutoSize = True
        Me.radiobuttonCPUIs64Bit.ForeColor = System.Drawing.Color.Blue
        Me.radiobuttonCPUIs64Bit.Location = New System.Drawing.Point(66, 200)
        Me.radiobuttonCPUIs64Bit.Margin = New System.Windows.Forms.Padding(4)
        Me.radiobuttonCPUIs64Bit.Name = "radiobuttonCPUIs64Bit"
        Me.radiobuttonCPUIs64Bit.Size = New System.Drawing.Size(306, 29)
        Me.radiobuttonCPUIs64Bit.TabIndex = 3
        Me.radiobuttonCPUIs64Bit.TabStop = True
        Me.radiobuttonCPUIs64Bit.Text = "I'm running 64-bit Windows."
        Me.radiobuttonCPUIs64Bit.UseVisualStyleBackColor = True
        '
        'radiobuttonCPUIs32Bit
        '
        Me.radiobuttonCPUIs32Bit.AutoSize = True
        Me.radiobuttonCPUIs32Bit.ForeColor = System.Drawing.Color.Blue
        Me.radiobuttonCPUIs32Bit.Location = New System.Drawing.Point(66, 164)
        Me.radiobuttonCPUIs32Bit.Margin = New System.Windows.Forms.Padding(4)
        Me.radiobuttonCPUIs32Bit.Name = "radiobuttonCPUIs32Bit"
        Me.radiobuttonCPUIs32Bit.Size = New System.Drawing.Size(306, 29)
        Me.radiobuttonCPUIs32Bit.TabIndex = 2
        Me.radiobuttonCPUIs32Bit.TabStop = True
        Me.radiobuttonCPUIs32Bit.Text = "I'm running 32-bit Windows."
        Me.radiobuttonCPUIs32Bit.UseVisualStyleBackColor = True
        '
        'buttonHelpMeCPUType
        '
        Me.buttonHelpMeCPUType.Location = New System.Drawing.Point(720, 252)
        Me.buttonHelpMeCPUType.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonHelpMeCPUType.Name = "buttonHelpMeCPUType"
        Me.buttonHelpMeCPUType.Size = New System.Drawing.Size(184, 66)
        Me.buttonHelpMeCPUType.TabIndex = 1
        Me.buttonHelpMeCPUType.Text = "Help Me!"
        Me.buttonHelpMeCPUType.UseVisualStyleBackColor = True
        '
        'labelCPUTypeDescription
        '
        Me.labelCPUTypeDescription.AutoSize = True
        Me.labelCPUTypeDescription.Location = New System.Drawing.Point(66, 40)
        Me.labelCPUTypeDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCPUTypeDescription.Name = "labelCPUTypeDescription"
        Me.labelCPUTypeDescription.Size = New System.Drawing.Size(742, 100)
        Me.labelCPUTypeDescription.TabIndex = 0
        Me.labelCPUTypeDescription.Text = resources.GetString("labelCPUTypeDescription.Text")
        '
        'buttonTestSettings
        '
        Me.buttonTestSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonTestSettings.AutoSize = True
        Me.buttonTestSettings.Location = New System.Drawing.Point(147, 728)
        Me.buttonTestSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonTestSettings.Name = "buttonTestSettings"
        Me.buttonTestSettings.Size = New System.Drawing.Size(168, 56)
        Me.buttonTestSettings.TabIndex = 4
        Me.buttonTestSettings.Text = "Test Settings"
        Me.buttonTestSettings.UseVisualStyleBackColor = True
        '
        'buttonDefaultSettings
        '
        Me.buttonDefaultSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonDefaultSettings.AutoSize = True
        Me.buttonDefaultSettings.Location = New System.Drawing.Point(16, 728)
        Me.buttonDefaultSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonDefaultSettings.Name = "buttonDefaultSettings"
        Me.buttonDefaultSettings.Size = New System.Drawing.Size(122, 56)
        Me.buttonDefaultSettings.TabIndex = 2
        Me.buttonDefaultSettings.Text = "Defaults"
        Me.buttonDefaultSettings.UseVisualStyleBackColor = True
        '
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(970, 788)
        Me.Controls.Add(Me.tableLayoutPanelOptionsWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
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
    Friend WithEvents labelOfficeLocationDescription As Label
    Friend WithEvents labelOfficeInstalledToDrive As Label
    Friend WithEvents textboxOfficeDrive As TextBox
    Friend WithEvents buttonClearTextbox As Button
    Friend WithEvents groupboxOfficeVersion As GroupBox
    Friend WithEvents labelOfficeVersionDescription As Label
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
End Class
