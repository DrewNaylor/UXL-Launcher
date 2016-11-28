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
        Me.buttonDefaultSettings = New System.Windows.Forms.Button()
        Me.buttonSaveSettings = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.tabcontrolOptionsWindow = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxOfficeVersion = New System.Windows.Forms.GroupBox()
        Me.checkboxUserHasO365 = New System.Windows.Forms.CheckBox()
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
        Me.buttonHelpMeCPUType = New System.Windows.Forms.Button()
        Me.labelCPUTypeDescription = New System.Windows.Forms.Label()
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
        Me.tableLayoutPanelOptionsWindow.ColumnCount = 4
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 490.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.tableLayoutPanelOptionsWindow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonDefaultSettings, 0, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonSaveSettings, 3, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.buttonCancel, 2, 1)
        Me.tableLayoutPanelOptionsWindow.Controls.Add(Me.tabcontrolOptionsWindow, 0, 0)
        Me.tableLayoutPanelOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelOptionsWindow.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanelOptionsWindow.Name = "tableLayoutPanelOptionsWindow"
        Me.tableLayoutPanelOptionsWindow.RowCount = 2
        Me.tableLayoutPanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.0!))
        Me.tableLayoutPanelOptionsWindow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.tableLayoutPanelOptionsWindow.Size = New System.Drawing.Size(970, 788)
        Me.tableLayoutPanelOptionsWindow.TabIndex = 0
        '
        'buttonDefaultSettings
        '
        Me.buttonDefaultSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonDefaultSettings.AutoSize = True
        Me.buttonDefaultSettings.Location = New System.Drawing.Point(15, 732)
        Me.buttonDefaultSettings.Margin = New System.Windows.Forms.Padding(3, 3, 20, 5)
        Me.buttonDefaultSettings.Name = "buttonDefaultSettings"
        Me.buttonDefaultSettings.Size = New System.Drawing.Size(134, 45)
        Me.buttonDefaultSettings.TabIndex = 2
        Me.buttonDefaultSettings.Text = "Defaults"
        Me.buttonDefaultSettings.UseVisualStyleBackColor = True
        '
        'buttonSaveSettings
        '
        Me.buttonSaveSettings.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonSaveSettings.AutoSize = True
        Me.buttonSaveSettings.Location = New System.Drawing.Point(821, 732)
        Me.buttonSaveSettings.Margin = New System.Windows.Forms.Padding(3, 3, 15, 5)
        Me.buttonSaveSettings.Name = "buttonSaveSettings"
        Me.buttonSaveSettings.Size = New System.Drawing.Size(134, 45)
        Me.buttonSaveSettings.TabIndex = 0
        Me.buttonSaveSettings.Text = "Save"
        Me.buttonSaveSettings.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.buttonCancel.AutoSize = True
        Me.buttonCancel.Location = New System.Drawing.Point(674, 732)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(134, 45)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'tabcontrolOptionsWindow
        '
        Me.tableLayoutPanelOptionsWindow.SetColumnSpan(Me.tabcontrolOptionsWindow, 4)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolOptionsWindow.Controls.Add(Me.tabpageAdvanced)
        Me.tabcontrolOptionsWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolOptionsWindow.Location = New System.Drawing.Point(15, 15)
        Me.tabcontrolOptionsWindow.Margin = New System.Windows.Forms.Padding(15, 15, 15, 3)
        Me.tabcontrolOptionsWindow.Name = "tabcontrolOptionsWindow"
        Me.tabcontrolOptionsWindow.SelectedIndex = 0
        Me.tabcontrolOptionsWindow.Size = New System.Drawing.Size(940, 706)
        Me.tabcontrolOptionsWindow.TabIndex = 3
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeVersion)
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeLocation)
        Me.tabpageGeneral.Location = New System.Drawing.Point(8, 39)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(924, 659)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'groupboxOfficeVersion
        '
        Me.groupboxOfficeVersion.Controls.Add(Me.checkboxUserHasO365)
        Me.groupboxOfficeVersion.Controls.Add(Me.labelUserHasThisOfficeVersion)
        Me.groupboxOfficeVersion.Controls.Add(Me.comboboxOfficeVersionSelector)
        Me.groupboxOfficeVersion.Controls.Add(Me.labelOfficeVersionDescription)
        Me.groupboxOfficeVersion.Location = New System.Drawing.Point(6, 274)
        Me.groupboxOfficeVersion.Name = "groupboxOfficeVersion"
        Me.groupboxOfficeVersion.Size = New System.Drawing.Size(911, 382)
        Me.groupboxOfficeVersion.TabIndex = 1
        Me.groupboxOfficeVersion.TabStop = False
        Me.groupboxOfficeVersion.Text = "What version of Microsoft Office do you use?"
        '
        'checkboxUserHasO365
        '
        Me.checkboxUserHasO365.AutoSize = True
        Me.checkboxUserHasO365.Location = New System.Drawing.Point(66, 212)
        Me.checkboxUserHasO365.Name = "checkboxUserHasO365"
        Me.checkboxUserHasO365.Size = New System.Drawing.Size(454, 29)
        Me.checkboxUserHasO365.TabIndex = 3
        Me.checkboxUserHasO365.Text = "I used Office 365 to install Microsoft Office."
        Me.checkboxUserHasO365.UseVisualStyleBackColor = True
        '
        'labelUserHasThisOfficeVersion
        '
        Me.labelUserHasThisOfficeVersion.AutoSize = True
        Me.labelUserHasThisOfficeVersion.ForeColor = System.Drawing.Color.Blue
        Me.labelUserHasThisOfficeVersion.Location = New System.Drawing.Point(66, 171)
        Me.labelUserHasThisOfficeVersion.Name = "labelUserHasThisOfficeVersion"
        Me.labelUserHasThisOfficeVersion.Size = New System.Drawing.Size(360, 25)
        Me.labelUserHasThisOfficeVersion.TabIndex = 2
        Me.labelUserHasThisOfficeVersion.Text = "I use this version of Microsoft Office:"
        '
        'comboboxOfficeVersionSelector
        '
        Me.comboboxOfficeVersionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOfficeVersionSelector.FormattingEnabled = True
        Me.comboboxOfficeVersionSelector.Location = New System.Drawing.Point(444, 168)
        Me.comboboxOfficeVersionSelector.Name = "comboboxOfficeVersionSelector"
        Me.comboboxOfficeVersionSelector.Size = New System.Drawing.Size(271, 33)
        Me.comboboxOfficeVersionSelector.TabIndex = 1
        '
        'labelOfficeVersionDescription
        '
        Me.labelOfficeVersionDescription.AutoSize = True
        Me.labelOfficeVersionDescription.Location = New System.Drawing.Point(66, 40)
        Me.labelOfficeVersionDescription.Name = "labelOfficeVersionDescription"
        Me.labelOfficeVersionDescription.Size = New System.Drawing.Size(755, 100)
        Me.labelOfficeVersionDescription.TabIndex = 0
        Me.labelOfficeVersionDescription.Text = resources.GetString("labelOfficeVersionDescription.Text")
        '
        'groupboxOfficeLocation
        '
        Me.groupboxOfficeLocation.Controls.Add(Me.buttonClearTextbox)
        Me.groupboxOfficeLocation.Controls.Add(Me.textboxOfficeDrive)
        Me.groupboxOfficeLocation.Controls.Add(Me.labelOfficeInstalledToDrive)
        Me.groupboxOfficeLocation.Controls.Add(Me.labelOfficeLocationDescription)
        Me.groupboxOfficeLocation.Location = New System.Drawing.Point(6, 6)
        Me.groupboxOfficeLocation.Name = "groupboxOfficeLocation"
        Me.groupboxOfficeLocation.Size = New System.Drawing.Size(912, 261)
        Me.groupboxOfficeLocation.TabIndex = 0
        Me.groupboxOfficeLocation.TabStop = False
        Me.groupboxOfficeLocation.Text = "Where is Microsoft Office located?"
        '
        'buttonClearTextbox
        '
        Me.buttonClearTextbox.AutoSize = True
        Me.buttonClearTextbox.Location = New System.Drawing.Point(502, 154)
        Me.buttonClearTextbox.Name = "buttonClearTextbox"
        Me.buttonClearTextbox.Size = New System.Drawing.Size(156, 45)
        Me.buttonClearTextbox.TabIndex = 3
        Me.buttonClearTextbox.Text = "Clear Textbox"
        Me.buttonClearTextbox.UseVisualStyleBackColor = True
        '
        'textboxOfficeDrive
        '
        Me.textboxOfficeDrive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxOfficeDrive.Location = New System.Drawing.Point(414, 161)
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
        Me.labelOfficeInstalledToDrive.ForeColor = System.Drawing.Color.Blue
        Me.labelOfficeInstalledToDrive.Location = New System.Drawing.Point(66, 164)
        Me.labelOfficeInstalledToDrive.Name = "labelOfficeInstalledToDrive"
        Me.labelOfficeInstalledToDrive.Size = New System.Drawing.Size(342, 25)
        Me.labelOfficeInstalledToDrive.TabIndex = 1
        Me.labelOfficeInstalledToDrive.Text = "I installed Microsoft Office to drive:"
        '
        'labelOfficeLocationDescription
        '
        Me.labelOfficeLocationDescription.AutoSize = True
        Me.labelOfficeLocationDescription.Location = New System.Drawing.Point(66, 40)
        Me.labelOfficeLocationDescription.Name = "labelOfficeLocationDescription"
        Me.labelOfficeLocationDescription.Size = New System.Drawing.Size(781, 100)
        Me.labelOfficeLocationDescription.TabIndex = 0
        Me.labelOfficeLocationDescription.Text = resources.GetString("labelOfficeLocationDescription.Text")
        '
        'tabpageAdvanced
        '
        Me.tabpageAdvanced.Controls.Add(Me.groupboxCPUType)
        Me.tabpageAdvanced.Location = New System.Drawing.Point(8, 39)
        Me.tabpageAdvanced.Name = "tabpageAdvanced"
        Me.tabpageAdvanced.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAdvanced.Size = New System.Drawing.Size(924, 659)
        Me.tabpageAdvanced.TabIndex = 1
        Me.tabpageAdvanced.Text = "Advanced"
        Me.tabpageAdvanced.UseVisualStyleBackColor = True
        '
        'groupboxCPUType
        '
        Me.groupboxCPUType.Controls.Add(Me.buttonHelpMeCPUType)
        Me.groupboxCPUType.Controls.Add(Me.labelCPUTypeDescription)
        Me.groupboxCPUType.Location = New System.Drawing.Point(6, 6)
        Me.groupboxCPUType.Name = "groupboxCPUType"
        Me.groupboxCPUType.Size = New System.Drawing.Size(912, 376)
        Me.groupboxCPUType.TabIndex = 0
        Me.groupboxCPUType.TabStop = False
        Me.groupboxCPUType.Text = "What edition of Windows do you run?"
        '
        'buttonHelpMeCPUType
        '
        Me.buttonHelpMeCPUType.Location = New System.Drawing.Point(202, 258)
        Me.buttonHelpMeCPUType.Name = "buttonHelpMeCPUType"
        Me.buttonHelpMeCPUType.Size = New System.Drawing.Size(185, 66)
        Me.buttonHelpMeCPUType.TabIndex = 1
        Me.buttonHelpMeCPUType.Text = "Help Me!"
        Me.buttonHelpMeCPUType.UseVisualStyleBackColor = True
        '
        'labelCPUTypeDescription
        '
        Me.labelCPUTypeDescription.AutoSize = True
        Me.labelCPUTypeDescription.Location = New System.Drawing.Point(66, 40)
        Me.labelCPUTypeDescription.Name = "labelCPUTypeDescription"
        Me.labelCPUTypeDescription.Size = New System.Drawing.Size(742, 100)
        Me.labelCPUTypeDescription.TabIndex = 0
        Me.labelCPUTypeDescription.Text = resources.GetString("labelCPUTypeDescription.Text")
        '
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
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
    Friend WithEvents checkboxUserHasO365 As CheckBox
    Friend WithEvents groupboxCPUType As GroupBox
    Friend WithEvents labelCPUTypeDescription As Label
    Friend WithEvents buttonHelpMeCPUType As Button
End Class
