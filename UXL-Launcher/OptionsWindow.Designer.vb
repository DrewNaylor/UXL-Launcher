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
        Me.tableLayoutPanelOptionsWindow = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonDefaultSettings = New System.Windows.Forms.Button()
        Me.buttonSaveSettings = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.tabcontrolOptionsWindow = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.groupboxOfficeLocation = New System.Windows.Forms.GroupBox()
        Me.buttonClearTextbox = New System.Windows.Forms.Button()
        Me.textboxOfficeDrive = New System.Windows.Forms.TextBox()
        Me.labelOfficeInstalledToDrive = New System.Windows.Forms.Label()
        Me.labelOfficeLocationDescription = New System.Windows.Forms.Label()
        Me.tabpageAdvanced = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanelOptionsWindow.SuspendLayout()
        Me.tabcontrolOptionsWindow.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.groupboxOfficeLocation.SuspendLayout()
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
        Me.tabpageGeneral.Controls.Add(Me.groupboxOfficeLocation)
        Me.tabpageGeneral.Location = New System.Drawing.Point(8, 39)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(924, 659)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
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
        Me.buttonClearTextbox.Location = New System.Drawing.Point(462, 128)
        Me.buttonClearTextbox.Name = "buttonClearTextbox"
        Me.buttonClearTextbox.Size = New System.Drawing.Size(156, 45)
        Me.buttonClearTextbox.TabIndex = 3
        Me.buttonClearTextbox.Text = "Clear Textbox"
        Me.buttonClearTextbox.UseVisualStyleBackColor = True
        '
        'textboxOfficeDrive
        '
        Me.textboxOfficeDrive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxOfficeDrive.Location = New System.Drawing.Point(374, 135)
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
        Me.labelOfficeInstalledToDrive.Location = New System.Drawing.Point(26, 138)
        Me.labelOfficeInstalledToDrive.Name = "labelOfficeInstalledToDrive"
        Me.labelOfficeInstalledToDrive.Size = New System.Drawing.Size(342, 25)
        Me.labelOfficeInstalledToDrive.TabIndex = 1
        Me.labelOfficeInstalledToDrive.Text = "I installed Microsoft Office to drive:"
        '
        'labelOfficeLocationDescription
        '
        Me.labelOfficeLocationDescription.AutoSize = True
        Me.labelOfficeLocationDescription.Location = New System.Drawing.Point(21, 39)
        Me.labelOfficeLocationDescription.Name = "labelOfficeLocationDescription"
        Me.labelOfficeLocationDescription.Size = New System.Drawing.Size(597, 75)
        Me.labelOfficeLocationDescription.TabIndex = 0
        Me.labelOfficeLocationDescription.Text = "Please enter the drive you installed Microsoft Office to below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Special characte" &
    "rs are not permitted. Click the Clear Textbox" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "button to clear the textbox."
        '
        'tabpageAdvanced
        '
        Me.tabpageAdvanced.Location = New System.Drawing.Point(8, 39)
        Me.tabpageAdvanced.Name = "tabpageAdvanced"
        Me.tabpageAdvanced.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAdvanced.Size = New System.Drawing.Size(924, 659)
        Me.tabpageAdvanced.TabIndex = 1
        Me.tabpageAdvanced.Text = "Advanced"
        Me.tabpageAdvanced.UseVisualStyleBackColor = True
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
        Me.groupboxOfficeLocation.ResumeLayout(False)
        Me.groupboxOfficeLocation.PerformLayout()
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
End Class
