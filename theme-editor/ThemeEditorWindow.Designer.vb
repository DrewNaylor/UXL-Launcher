﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.comboboxControlSelector = New System.Windows.Forms.ComboBox()
        Me.uiBackColorLabel = New System.Windows.Forms.Label()
        Me.uiForeColorLabel = New System.Windows.Forms.Label()
        Me.uiBackColorTextbox = New System.Windows.Forms.TextBox()
        Me.uiForeColorTextbox = New System.Windows.Forms.TextBox()
        Me.uiControlToThemeLabel = New System.Windows.Forms.Label()
        Me.propertygridAdvanced = New System.Windows.Forms.PropertyGrid()
        Me.flowlayoutpanelPropertyList = New System.Windows.Forms.FlowLayoutPanel()
        Me.uiMenuItemImageMarginStartLabel = New System.Windows.Forms.Label()
        Me.uiMenuItemImageMarginStartTextbox = New System.Windows.Forms.TextBox()
        Me.uiMenuItemImageMarginEndLabel = New System.Windows.Forms.Label()
        Me.uiMenuItemImageMarginEndTextbox = New System.Windows.Forms.TextBox()
        Me.uiStatusLabelBorderSidesLabel = New System.Windows.Forms.Label()
        Me.uiStatusLabelBorderSidesDropdown = New System.Windows.Forms.ComboBox()
        Me.uiStatusLabelBorderStyleLabel = New System.Windows.Forms.Label()
        Me.uiStatusLabelBorderStyleDropdown = New System.Windows.Forms.ComboBox()
        Me.labelButtonFlatStyle = New System.Windows.Forms.Label()
        Me.dropdownButtonFlatStyle = New System.Windows.Forms.ComboBox()
        Me.labelButtonFlatAppearanceBorderColor = New System.Windows.Forms.Label()
        Me.textboxButtonFlatAppearanceBorderColor = New System.Windows.Forms.TextBox()
        Me.labelPickControl = New System.Windows.Forms.Label()
        Me.menustripMenubar = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripToolbar = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tabcontrolThemeEditor = New System.Windows.Forms.TabControl()
        Me.tabpageControls = New System.Windows.Forms.TabPage()
        Me.tabpageThemeInfo = New System.Windows.Forms.TabPage()
        Me.dropdownThemeEngineRuntimeVersion = New System.Windows.Forms.ComboBox()
        Me.labelThemeEngineRuntimeVersion = New System.Windows.Forms.Label()
        Me.textboxThemeAuthor = New System.Windows.Forms.TextBox()
        Me.labelThemeAuthor = New System.Windows.Forms.Label()
        Me.textboxThemeVersion = New System.Windows.Forms.TextBox()
        Me.labelThemeVersion = New System.Windows.Forms.Label()
        Me.textboxThemeDescription = New System.Windows.Forms.TextBox()
        Me.labelThemeDescription = New System.Windows.Forms.Label()
        Me.textboxThemeTitle = New System.Windows.Forms.TextBox()
        Me.labelThemeTitle = New System.Windows.Forms.Label()
        Me.openfiledialogOpenTheme = New System.Windows.Forms.OpenFileDialog()
        Me.flowlayoutpanelPropertyList.SuspendLayout()
        Me.menustripMenubar.SuspendLayout()
        Me.toolstripToolbar.SuspendLayout()
        Me.tabcontrolThemeEditor.SuspendLayout()
        Me.tabpageControls.SuspendLayout()
        Me.tabpageThemeInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboboxControlSelector
        '
        Me.comboboxControlSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxControlSelector.FormattingEnabled = True
        Me.comboboxControlSelector.Items.AddRange(New Object() {"Button", "FlowLayoutPanel", "GroupBox", "Label", "MenuBar", "MenuItem", "StatusBar", "StatusLabel", "TextBox"})
        Me.comboboxControlSelector.Location = New System.Drawing.Point(13, 23)
        Me.comboboxControlSelector.Name = "comboboxControlSelector"
        Me.comboboxControlSelector.Size = New System.Drawing.Size(268, 21)
        Me.comboboxControlSelector.Sorted = True
        Me.comboboxControlSelector.TabIndex = 0
        '
        'uiBackColorLabel
        '
        Me.uiBackColorLabel.AutoSize = True
        Me.uiBackColorLabel.Location = New System.Drawing.Point(3, 0)
        Me.uiBackColorLabel.Name = "uiBackColorLabel"
        Me.uiBackColorLabel.Size = New System.Drawing.Size(59, 13)
        Me.uiBackColorLabel.TabIndex = 1
        Me.uiBackColorLabel.Text = "BackColor:"
        '
        'uiForeColorLabel
        '
        Me.uiForeColorLabel.AutoSize = True
        Me.uiForeColorLabel.Location = New System.Drawing.Point(3, 39)
        Me.uiForeColorLabel.Name = "uiForeColorLabel"
        Me.uiForeColorLabel.Size = New System.Drawing.Size(55, 13)
        Me.uiForeColorLabel.TabIndex = 2
        Me.uiForeColorLabel.Text = "ForeColor:"
        '
        'uiBackColorTextbox
        '
        Me.uiBackColorTextbox.Location = New System.Drawing.Point(3, 16)
        Me.uiBackColorTextbox.Name = "uiBackColorTextbox"
        Me.uiBackColorTextbox.Size = New System.Drawing.Size(265, 20)
        Me.uiBackColorTextbox.TabIndex = 4
        '
        'uiForeColorTextbox
        '
        Me.uiForeColorTextbox.Location = New System.Drawing.Point(3, 55)
        Me.uiForeColorTextbox.Name = "uiForeColorTextbox"
        Me.uiForeColorTextbox.Size = New System.Drawing.Size(265, 20)
        Me.uiForeColorTextbox.TabIndex = 5
        '
        'uiControlToThemeLabel
        '
        Me.uiControlToThemeLabel.AutoSize = True
        Me.uiControlToThemeLabel.Location = New System.Drawing.Point(7, 2)
        Me.uiControlToThemeLabel.Name = "uiControlToThemeLabel"
        Me.uiControlToThemeLabel.Size = New System.Drawing.Size(87, 13)
        Me.uiControlToThemeLabel.TabIndex = 7
        Me.uiControlToThemeLabel.Text = "Control to theme:"
        '
        'propertygridAdvanced
        '
        Me.propertygridAdvanced.BackColor = System.Drawing.SystemColors.Window
        Me.propertygridAdvanced.Location = New System.Drawing.Point(311, 19)
        Me.propertygridAdvanced.Name = "propertygridAdvanced"
        Me.propertygridAdvanced.Size = New System.Drawing.Size(258, 306)
        Me.propertygridAdvanced.TabIndex = 9999
        '
        'flowlayoutpanelPropertyList
        '
        Me.flowlayoutpanelPropertyList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flowlayoutpanelPropertyList.AutoScroll = True
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiBackColorLabel)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiBackColorTextbox)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiForeColorLabel)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiForeColorTextbox)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiMenuItemImageMarginStartLabel)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiMenuItemImageMarginStartTextbox)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiMenuItemImageMarginEndLabel)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiMenuItemImageMarginEndTextbox)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiStatusLabelBorderSidesLabel)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiStatusLabelBorderSidesDropdown)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiStatusLabelBorderStyleLabel)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.uiStatusLabelBorderStyleDropdown)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.labelButtonFlatStyle)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.dropdownButtonFlatStyle)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.labelButtonFlatAppearanceBorderColor)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.textboxButtonFlatAppearanceBorderColor)
        Me.flowlayoutpanelPropertyList.Controls.Add(Me.labelPickControl)
        Me.flowlayoutpanelPropertyList.Location = New System.Drawing.Point(10, 45)
        Me.flowlayoutpanelPropertyList.Name = "flowlayoutpanelPropertyList"
        Me.flowlayoutpanelPropertyList.Size = New System.Drawing.Size(294, 280)
        Me.flowlayoutpanelPropertyList.TabIndex = 9
        '
        'uiMenuItemImageMarginStartLabel
        '
        Me.uiMenuItemImageMarginStartLabel.AutoSize = True
        Me.uiMenuItemImageMarginStartLabel.Location = New System.Drawing.Point(2, 78)
        Me.uiMenuItemImageMarginStartLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.uiMenuItemImageMarginStartLabel.Name = "uiMenuItemImageMarginStartLabel"
        Me.uiMenuItemImageMarginStartLabel.Size = New System.Drawing.Size(160, 13)
        Me.uiMenuItemImageMarginStartLabel.TabIndex = 6
        Me.uiMenuItemImageMarginStartLabel.Text = "ImageMarginGradient StartColor:"
        '
        'uiMenuItemImageMarginStartTextbox
        '
        Me.uiMenuItemImageMarginStartTextbox.Location = New System.Drawing.Point(2, 93)
        Me.uiMenuItemImageMarginStartTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.uiMenuItemImageMarginStartTextbox.Name = "uiMenuItemImageMarginStartTextbox"
        Me.uiMenuItemImageMarginStartTextbox.Size = New System.Drawing.Size(266, 20)
        Me.uiMenuItemImageMarginStartTextbox.TabIndex = 7
        '
        'uiMenuItemImageMarginEndLabel
        '
        Me.uiMenuItemImageMarginEndLabel.AutoSize = True
        Me.uiMenuItemImageMarginEndLabel.Location = New System.Drawing.Point(2, 115)
        Me.uiMenuItemImageMarginEndLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.uiMenuItemImageMarginEndLabel.Name = "uiMenuItemImageMarginEndLabel"
        Me.uiMenuItemImageMarginEndLabel.Size = New System.Drawing.Size(157, 13)
        Me.uiMenuItemImageMarginEndLabel.TabIndex = 8
        Me.uiMenuItemImageMarginEndLabel.Text = "ImageMarginGradient EndColor:"
        '
        'uiMenuItemImageMarginEndTextbox
        '
        Me.uiMenuItemImageMarginEndTextbox.Location = New System.Drawing.Point(2, 130)
        Me.uiMenuItemImageMarginEndTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.uiMenuItemImageMarginEndTextbox.Name = "uiMenuItemImageMarginEndTextbox"
        Me.uiMenuItemImageMarginEndTextbox.Size = New System.Drawing.Size(266, 20)
        Me.uiMenuItemImageMarginEndTextbox.TabIndex = 9
        '
        'uiStatusLabelBorderSidesLabel
        '
        Me.uiStatusLabelBorderSidesLabel.AutoSize = True
        Me.uiStatusLabelBorderSidesLabel.Location = New System.Drawing.Point(2, 152)
        Me.uiStatusLabelBorderSidesLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.uiStatusLabelBorderSidesLabel.Name = "uiStatusLabelBorderSidesLabel"
        Me.uiStatusLabelBorderSidesLabel.Size = New System.Drawing.Size(67, 13)
        Me.uiStatusLabelBorderSidesLabel.TabIndex = 10
        Me.uiStatusLabelBorderSidesLabel.Text = "BorderSides:"
        '
        'uiStatusLabelBorderSidesDropdown
        '
        Me.uiStatusLabelBorderSidesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uiStatusLabelBorderSidesDropdown.FormattingEnabled = True
        Me.uiStatusLabelBorderSidesDropdown.Items.AddRange(New Object() {"None", "Top", "Bottom", "Left", "Right", "All"})
        Me.uiStatusLabelBorderSidesDropdown.Location = New System.Drawing.Point(2, 167)
        Me.uiStatusLabelBorderSidesDropdown.Margin = New System.Windows.Forms.Padding(2)
        Me.uiStatusLabelBorderSidesDropdown.Name = "uiStatusLabelBorderSidesDropdown"
        Me.uiStatusLabelBorderSidesDropdown.Size = New System.Drawing.Size(266, 21)
        Me.uiStatusLabelBorderSidesDropdown.TabIndex = 14
        '
        'uiStatusLabelBorderStyleLabel
        '
        Me.uiStatusLabelBorderStyleLabel.AutoSize = True
        Me.uiStatusLabelBorderStyleLabel.Location = New System.Drawing.Point(2, 190)
        Me.uiStatusLabelBorderStyleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.uiStatusLabelBorderStyleLabel.Name = "uiStatusLabelBorderStyleLabel"
        Me.uiStatusLabelBorderStyleLabel.Size = New System.Drawing.Size(64, 13)
        Me.uiStatusLabelBorderStyleLabel.TabIndex = 12
        Me.uiStatusLabelBorderStyleLabel.Text = "BorderStyle:"
        '
        'uiStatusLabelBorderStyleDropdown
        '
        Me.uiStatusLabelBorderStyleDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uiStatusLabelBorderStyleDropdown.FormattingEnabled = True
        Me.uiStatusLabelBorderStyleDropdown.Items.AddRange(New Object() {"Adjust", "Bump", "Etched", "Flat", "Raised", "RaisedInner", "RaisedOuter", "Sunken", "SunkenInner", "SunkenOuter"})
        Me.uiStatusLabelBorderStyleDropdown.Location = New System.Drawing.Point(2, 205)
        Me.uiStatusLabelBorderStyleDropdown.Margin = New System.Windows.Forms.Padding(2)
        Me.uiStatusLabelBorderStyleDropdown.Name = "uiStatusLabelBorderStyleDropdown"
        Me.uiStatusLabelBorderStyleDropdown.Size = New System.Drawing.Size(266, 21)
        Me.uiStatusLabelBorderStyleDropdown.TabIndex = 15
        '
        'labelButtonFlatStyle
        '
        Me.labelButtonFlatStyle.AutoSize = True
        Me.labelButtonFlatStyle.Location = New System.Drawing.Point(2, 228)
        Me.labelButtonFlatStyle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelButtonFlatStyle.Name = "labelButtonFlatStyle"
        Me.labelButtonFlatStyle.Size = New System.Drawing.Size(84, 13)
        Me.labelButtonFlatStyle.TabIndex = 16
        Me.labelButtonFlatStyle.Text = "Button FlatStyle:"
        '
        'dropdownButtonFlatStyle
        '
        Me.dropdownButtonFlatStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropdownButtonFlatStyle.FormattingEnabled = True
        Me.dropdownButtonFlatStyle.Items.AddRange(New Object() {"Standard", "Flat"})
        Me.dropdownButtonFlatStyle.Location = New System.Drawing.Point(2, 243)
        Me.dropdownButtonFlatStyle.Margin = New System.Windows.Forms.Padding(2)
        Me.dropdownButtonFlatStyle.Name = "dropdownButtonFlatStyle"
        Me.dropdownButtonFlatStyle.Size = New System.Drawing.Size(266, 21)
        Me.dropdownButtonFlatStyle.TabIndex = 17
        '
        'labelButtonFlatAppearanceBorderColor
        '
        Me.labelButtonFlatAppearanceBorderColor.AutoSize = True
        Me.labelButtonFlatAppearanceBorderColor.Location = New System.Drawing.Point(2, 266)
        Me.labelButtonFlatAppearanceBorderColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelButtonFlatAppearanceBorderColor.Name = "labelButtonFlatAppearanceBorderColor"
        Me.labelButtonFlatAppearanceBorderColor.Size = New System.Drawing.Size(177, 13)
        Me.labelButtonFlatAppearanceBorderColor.TabIndex = 18
        Me.labelButtonFlatAppearanceBorderColor.Text = "Button FlatAppearance BorderColor:"
        '
        'textboxButtonFlatAppearanceBorderColor
        '
        Me.textboxButtonFlatAppearanceBorderColor.Location = New System.Drawing.Point(2, 281)
        Me.textboxButtonFlatAppearanceBorderColor.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxButtonFlatAppearanceBorderColor.Name = "textboxButtonFlatAppearanceBorderColor"
        Me.textboxButtonFlatAppearanceBorderColor.Size = New System.Drawing.Size(266, 20)
        Me.textboxButtonFlatAppearanceBorderColor.TabIndex = 19
        '
        'labelPickControl
        '
        Me.labelPickControl.AutoSize = True
        Me.labelPickControl.Location = New System.Drawing.Point(2, 303)
        Me.labelPickControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPickControl.Name = "labelPickControl"
        Me.labelPickControl.Size = New System.Drawing.Size(277, 13)
        Me.labelPickControl.TabIndex = 20
        Me.labelPickControl.Text = "Please pick a control to theme from the dropdown above."
        '
        'menustripMenubar
        '
        Me.menustripMenubar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menustripMenubar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustripMenubar.Location = New System.Drawing.Point(0, 0)
        Me.menustripMenubar.Name = "menustripMenubar"
        Me.menustripMenubar.Size = New System.Drawing.Size(578, 24)
        Me.menustripMenubar.TabIndex = 10
        Me.menustripMenubar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator2, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(135, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(135, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'toolstripToolbar
        '
        Me.toolstripToolbar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton})
        Me.toolstripToolbar.Location = New System.Drawing.Point(0, 24)
        Me.toolstripToolbar.Name = "toolstripToolbar"
        Me.toolstripToolbar.Size = New System.Drawing.Size(578, 27)
        Me.toolstripToolbar.TabIndex = 11
        Me.toolstripToolbar.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'tabcontrolThemeEditor
        '
        Me.tabcontrolThemeEditor.Controls.Add(Me.tabpageControls)
        Me.tabcontrolThemeEditor.Controls.Add(Me.tabpageThemeInfo)
        Me.tabcontrolThemeEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolThemeEditor.Location = New System.Drawing.Point(0, 51)
        Me.tabcontrolThemeEditor.Margin = New System.Windows.Forms.Padding(2)
        Me.tabcontrolThemeEditor.Name = "tabcontrolThemeEditor"
        Me.tabcontrolThemeEditor.SelectedIndex = 0
        Me.tabcontrolThemeEditor.Size = New System.Drawing.Size(578, 356)
        Me.tabcontrolThemeEditor.TabIndex = 10000
        '
        'tabpageControls
        '
        Me.tabpageControls.Controls.Add(Me.uiControlToThemeLabel)
        Me.tabpageControls.Controls.Add(Me.comboboxControlSelector)
        Me.tabpageControls.Controls.Add(Me.flowlayoutpanelPropertyList)
        Me.tabpageControls.Controls.Add(Me.propertygridAdvanced)
        Me.tabpageControls.Location = New System.Drawing.Point(4, 22)
        Me.tabpageControls.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageControls.Name = "tabpageControls"
        Me.tabpageControls.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageControls.Size = New System.Drawing.Size(570, 330)
        Me.tabpageControls.TabIndex = 0
        Me.tabpageControls.Text = "Controls"
        Me.tabpageControls.UseVisualStyleBackColor = True
        '
        'tabpageThemeInfo
        '
        Me.tabpageThemeInfo.Controls.Add(Me.dropdownThemeEngineRuntimeVersion)
        Me.tabpageThemeInfo.Controls.Add(Me.labelThemeEngineRuntimeVersion)
        Me.tabpageThemeInfo.Controls.Add(Me.textboxThemeAuthor)
        Me.tabpageThemeInfo.Controls.Add(Me.labelThemeAuthor)
        Me.tabpageThemeInfo.Controls.Add(Me.textboxThemeVersion)
        Me.tabpageThemeInfo.Controls.Add(Me.labelThemeVersion)
        Me.tabpageThemeInfo.Controls.Add(Me.textboxThemeDescription)
        Me.tabpageThemeInfo.Controls.Add(Me.labelThemeDescription)
        Me.tabpageThemeInfo.Controls.Add(Me.textboxThemeTitle)
        Me.tabpageThemeInfo.Controls.Add(Me.labelThemeTitle)
        Me.tabpageThemeInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabpageThemeInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.tabpageThemeInfo.Name = "tabpageThemeInfo"
        Me.tabpageThemeInfo.Padding = New System.Windows.Forms.Padding(2)
        Me.tabpageThemeInfo.Size = New System.Drawing.Size(570, 330)
        Me.tabpageThemeInfo.TabIndex = 1
        Me.tabpageThemeInfo.Text = "Theme info"
        Me.tabpageThemeInfo.UseVisualStyleBackColor = True
        '
        'dropdownThemeEngineRuntimeVersion
        '
        Me.dropdownThemeEngineRuntimeVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropdownThemeEngineRuntimeVersion.FormattingEnabled = True
        Me.dropdownThemeEngineRuntimeVersion.Items.AddRange(New Object() {"1.01", "1.02", "1.03", "2.0"})
        Me.dropdownThemeEngineRuntimeVersion.Location = New System.Drawing.Point(11, 254)
        Me.dropdownThemeEngineRuntimeVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.dropdownThemeEngineRuntimeVersion.Name = "dropdownThemeEngineRuntimeVersion"
        Me.dropdownThemeEngineRuntimeVersion.Size = New System.Drawing.Size(155, 21)
        Me.dropdownThemeEngineRuntimeVersion.TabIndex = 20
        '
        'labelThemeEngineRuntimeVersion
        '
        Me.labelThemeEngineRuntimeVersion.AutoSize = True
        Me.labelThemeEngineRuntimeVersion.Location = New System.Drawing.Point(9, 237)
        Me.labelThemeEngineRuntimeVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelThemeEngineRuntimeVersion.Name = "labelThemeEngineRuntimeVersion"
        Me.labelThemeEngineRuntimeVersion.Size = New System.Drawing.Size(152, 13)
        Me.labelThemeEngineRuntimeVersion.TabIndex = 19
        Me.labelThemeEngineRuntimeVersion.Text = "Theme engine runtime version:"
        '
        'textboxThemeAuthor
        '
        Me.textboxThemeAuthor.Location = New System.Drawing.Point(9, 214)
        Me.textboxThemeAuthor.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxThemeAuthor.Name = "textboxThemeAuthor"
        Me.textboxThemeAuthor.Size = New System.Drawing.Size(237, 20)
        Me.textboxThemeAuthor.TabIndex = 18
        '
        'labelThemeAuthor
        '
        Me.labelThemeAuthor.AutoSize = True
        Me.labelThemeAuthor.Location = New System.Drawing.Point(6, 198)
        Me.labelThemeAuthor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelThemeAuthor.Name = "labelThemeAuthor"
        Me.labelThemeAuthor.Size = New System.Drawing.Size(76, 13)
        Me.labelThemeAuthor.TabIndex = 17
        Me.labelThemeAuthor.Text = "Theme author:"
        '
        'textboxThemeVersion
        '
        Me.textboxThemeVersion.Location = New System.Drawing.Point(9, 174)
        Me.textboxThemeVersion.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxThemeVersion.Name = "textboxThemeVersion"
        Me.textboxThemeVersion.Size = New System.Drawing.Size(237, 20)
        Me.textboxThemeVersion.TabIndex = 16
        '
        'labelThemeVersion
        '
        Me.labelThemeVersion.AutoSize = True
        Me.labelThemeVersion.Location = New System.Drawing.Point(6, 158)
        Me.labelThemeVersion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelThemeVersion.Name = "labelThemeVersion"
        Me.labelThemeVersion.Size = New System.Drawing.Size(80, 13)
        Me.labelThemeVersion.TabIndex = 15
        Me.labelThemeVersion.Text = "Theme version:"
        '
        'textboxThemeDescription
        '
        Me.textboxThemeDescription.Location = New System.Drawing.Point(9, 59)
        Me.textboxThemeDescription.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxThemeDescription.Multiline = True
        Me.textboxThemeDescription.Name = "textboxThemeDescription"
        Me.textboxThemeDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxThemeDescription.Size = New System.Drawing.Size(442, 94)
        Me.textboxThemeDescription.TabIndex = 14
        '
        'labelThemeDescription
        '
        Me.labelThemeDescription.AutoSize = True
        Me.labelThemeDescription.Location = New System.Drawing.Point(6, 43)
        Me.labelThemeDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelThemeDescription.Name = "labelThemeDescription"
        Me.labelThemeDescription.Size = New System.Drawing.Size(97, 13)
        Me.labelThemeDescription.TabIndex = 13
        Me.labelThemeDescription.Text = "Theme description:"
        '
        'textboxThemeTitle
        '
        Me.textboxThemeTitle.Location = New System.Drawing.Point(9, 19)
        Me.textboxThemeTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxThemeTitle.Name = "textboxThemeTitle"
        Me.textboxThemeTitle.Size = New System.Drawing.Size(442, 20)
        Me.textboxThemeTitle.TabIndex = 12
        '
        'labelThemeTitle
        '
        Me.labelThemeTitle.AutoSize = True
        Me.labelThemeTitle.Location = New System.Drawing.Point(6, 2)
        Me.labelThemeTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelThemeTitle.Name = "labelThemeTitle"
        Me.labelThemeTitle.Size = New System.Drawing.Size(62, 13)
        Me.labelThemeTitle.TabIndex = 11
        Me.labelThemeTitle.Text = "Theme title:"
        '
        'openfiledialogOpenTheme
        '
        Me.openfiledialogOpenTheme.FileName = "OpenFileDialog1"
        Me.openfiledialogOpenTheme.Title = "Open theme file"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(578, 407)
        Me.Controls.Add(Me.tabcontrolThemeEditor)
        Me.Controls.Add(Me.toolstripToolbar)
        Me.Controls.Add(Me.menustripMenubar)
        Me.MainMenuStrip = Me.menustripMenubar
        Me.Name = "aaformMainWindow"
        Me.Text = "PortableThemeEngine Theme Editor"
        Me.flowlayoutpanelPropertyList.ResumeLayout(False)
        Me.flowlayoutpanelPropertyList.PerformLayout()
        Me.menustripMenubar.ResumeLayout(False)
        Me.menustripMenubar.PerformLayout()
        Me.toolstripToolbar.ResumeLayout(False)
        Me.toolstripToolbar.PerformLayout()
        Me.tabcontrolThemeEditor.ResumeLayout(False)
        Me.tabpageControls.ResumeLayout(False)
        Me.tabpageControls.PerformLayout()
        Me.tabpageThemeInfo.ResumeLayout(False)
        Me.tabpageThemeInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comboboxControlSelector As ComboBox
    Friend WithEvents uiBackColorLabel As Label
    Friend WithEvents uiForeColorLabel As Label
    Friend WithEvents uiBackColorTextbox As TextBox
    Friend WithEvents uiForeColorTextbox As TextBox
    Friend WithEvents uiControlToThemeLabel As Label
    Friend WithEvents propertygridAdvanced As PropertyGrid
    Friend WithEvents flowlayoutpanelPropertyList As FlowLayoutPanel
    Friend WithEvents menustripMenubar As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolstripToolbar As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents uiMenuItemImageMarginStartLabel As Label
    Friend WithEvents uiMenuItemImageMarginStartTextbox As TextBox
    Friend WithEvents uiMenuItemImageMarginEndLabel As Label
    Friend WithEvents uiMenuItemImageMarginEndTextbox As TextBox
    Friend WithEvents uiStatusLabelBorderSidesLabel As Label
    Friend WithEvents uiStatusLabelBorderStyleLabel As Label
    Friend WithEvents uiStatusLabelBorderSidesDropdown As ComboBox
    Friend WithEvents uiStatusLabelBorderStyleDropdown As ComboBox
    Friend WithEvents tabcontrolThemeEditor As TabControl
    Friend WithEvents tabpageControls As TabPage
    Friend WithEvents tabpageThemeInfo As TabPage
    Friend WithEvents dropdownThemeEngineRuntimeVersion As ComboBox
    Friend WithEvents labelThemeEngineRuntimeVersion As Label
    Friend WithEvents textboxThemeAuthor As TextBox
    Friend WithEvents labelThemeAuthor As Label
    Friend WithEvents textboxThemeVersion As TextBox
    Friend WithEvents labelThemeVersion As Label
    Friend WithEvents textboxThemeDescription As TextBox
    Friend WithEvents labelThemeDescription As Label
    Friend WithEvents textboxThemeTitle As TextBox
    Friend WithEvents labelThemeTitle As Label
    Friend WithEvents labelButtonFlatStyle As Label
    Friend WithEvents dropdownButtonFlatStyle As ComboBox
    Friend WithEvents labelButtonFlatAppearanceBorderColor As Label
    Friend WithEvents textboxButtonFlatAppearanceBorderColor As TextBox
    Friend WithEvents openfiledialogOpenTheme As OpenFileDialog
    Friend WithEvents labelPickControl As Label
End Class
