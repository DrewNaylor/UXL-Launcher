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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flowlayoutpanelPropertyList.SuspendLayout()
        Me.menustripMenubar.SuspendLayout()
        Me.toolstripToolbar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboboxControlSelector
        '
        Me.comboboxControlSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxControlSelector.FormattingEnabled = True
        Me.comboboxControlSelector.Items.AddRange(New Object() {"Button", "FlowLayoutPanel", "GroupBox", "Label", "MenuBar", "MenuItem", "StatusBar", "StatusLabel", "TextBox"})
        Me.comboboxControlSelector.Location = New System.Drawing.Point(13, 23)
        Me.comboboxControlSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxControlSelector.Name = "comboboxControlSelector"
        Me.comboboxControlSelector.Size = New System.Drawing.Size(316, 24)
        Me.comboboxControlSelector.Sorted = True
        Me.comboboxControlSelector.TabIndex = 0
        '
        'uiBackColorLabel
        '
        Me.uiBackColorLabel.AutoSize = True
        Me.uiBackColorLabel.Location = New System.Drawing.Point(4, 0)
        Me.uiBackColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uiBackColorLabel.Name = "uiBackColorLabel"
        Me.uiBackColorLabel.Size = New System.Drawing.Size(76, 17)
        Me.uiBackColorLabel.TabIndex = 1
        Me.uiBackColorLabel.Text = "BackColor:"
        '
        'uiForeColorLabel
        '
        Me.uiForeColorLabel.AutoSize = True
        Me.uiForeColorLabel.Location = New System.Drawing.Point(4, 47)
        Me.uiForeColorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uiForeColorLabel.Name = "uiForeColorLabel"
        Me.uiForeColorLabel.Size = New System.Drawing.Size(74, 17)
        Me.uiForeColorLabel.TabIndex = 2
        Me.uiForeColorLabel.Text = "ForeColor:"
        '
        'uiBackColorTextbox
        '
        Me.uiBackColorTextbox.Location = New System.Drawing.Point(4, 21)
        Me.uiBackColorTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.uiBackColorTextbox.Name = "uiBackColorTextbox"
        Me.uiBackColorTextbox.Size = New System.Drawing.Size(312, 22)
        Me.uiBackColorTextbox.TabIndex = 4
        '
        'uiForeColorTextbox
        '
        Me.uiForeColorTextbox.Location = New System.Drawing.Point(4, 68)
        Me.uiForeColorTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.uiForeColorTextbox.Name = "uiForeColorTextbox"
        Me.uiForeColorTextbox.Size = New System.Drawing.Size(312, 22)
        Me.uiForeColorTextbox.TabIndex = 5
        '
        'uiControlToThemeLabel
        '
        Me.uiControlToThemeLabel.AutoSize = True
        Me.uiControlToThemeLabel.Location = New System.Drawing.Point(9, 3)
        Me.uiControlToThemeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uiControlToThemeLabel.Name = "uiControlToThemeLabel"
        Me.uiControlToThemeLabel.Size = New System.Drawing.Size(116, 17)
        Me.uiControlToThemeLabel.TabIndex = 7
        Me.uiControlToThemeLabel.Text = "Control to theme:"
        '
        'propertygridAdvanced
        '
        Me.propertygridAdvanced.BackColor = System.Drawing.SystemColors.Window
        Me.propertygridAdvanced.Location = New System.Drawing.Point(352, 23)
        Me.propertygridAdvanced.Margin = New System.Windows.Forms.Padding(4)
        Me.propertygridAdvanced.Name = "propertygridAdvanced"
        Me.propertygridAdvanced.Size = New System.Drawing.Size(348, 383)
        Me.propertygridAdvanced.TabIndex = 9999
        '
        'flowlayoutpanelPropertyList
        '
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
        Me.flowlayoutpanelPropertyList.Location = New System.Drawing.Point(13, 56)
        Me.flowlayoutpanelPropertyList.Margin = New System.Windows.Forms.Padding(4)
        Me.flowlayoutpanelPropertyList.Name = "flowlayoutpanelPropertyList"
        Me.flowlayoutpanelPropertyList.Size = New System.Drawing.Size(331, 350)
        Me.flowlayoutpanelPropertyList.TabIndex = 9
        '
        'uiMenuItemImageMarginStartLabel
        '
        Me.uiMenuItemImageMarginStartLabel.AutoSize = True
        Me.uiMenuItemImageMarginStartLabel.Location = New System.Drawing.Point(3, 94)
        Me.uiMenuItemImageMarginStartLabel.Name = "uiMenuItemImageMarginStartLabel"
        Me.uiMenuItemImageMarginStartLabel.Size = New System.Drawing.Size(215, 17)
        Me.uiMenuItemImageMarginStartLabel.TabIndex = 6
        Me.uiMenuItemImageMarginStartLabel.Text = "ImageMarginGradient StartColor:"
        '
        'uiMenuItemImageMarginStartTextbox
        '
        Me.uiMenuItemImageMarginStartTextbox.Location = New System.Drawing.Point(3, 114)
        Me.uiMenuItemImageMarginStartTextbox.Name = "uiMenuItemImageMarginStartTextbox"
        Me.uiMenuItemImageMarginStartTextbox.Size = New System.Drawing.Size(313, 22)
        Me.uiMenuItemImageMarginStartTextbox.TabIndex = 7
        '
        'uiMenuItemImageMarginEndLabel
        '
        Me.uiMenuItemImageMarginEndLabel.AutoSize = True
        Me.uiMenuItemImageMarginEndLabel.Location = New System.Drawing.Point(3, 139)
        Me.uiMenuItemImageMarginEndLabel.Name = "uiMenuItemImageMarginEndLabel"
        Me.uiMenuItemImageMarginEndLabel.Size = New System.Drawing.Size(210, 17)
        Me.uiMenuItemImageMarginEndLabel.TabIndex = 8
        Me.uiMenuItemImageMarginEndLabel.Text = "ImageMarginGradient EndColor:"
        '
        'uiMenuItemImageMarginEndTextbox
        '
        Me.uiMenuItemImageMarginEndTextbox.Location = New System.Drawing.Point(3, 159)
        Me.uiMenuItemImageMarginEndTextbox.Name = "uiMenuItemImageMarginEndTextbox"
        Me.uiMenuItemImageMarginEndTextbox.Size = New System.Drawing.Size(313, 22)
        Me.uiMenuItemImageMarginEndTextbox.TabIndex = 9
        '
        'uiStatusLabelBorderSidesLabel
        '
        Me.uiStatusLabelBorderSidesLabel.AutoSize = True
        Me.uiStatusLabelBorderSidesLabel.Location = New System.Drawing.Point(3, 184)
        Me.uiStatusLabelBorderSidesLabel.Name = "uiStatusLabelBorderSidesLabel"
        Me.uiStatusLabelBorderSidesLabel.Size = New System.Drawing.Size(90, 17)
        Me.uiStatusLabelBorderSidesLabel.TabIndex = 10
        Me.uiStatusLabelBorderSidesLabel.Text = "BorderSides:"
        '
        'uiStatusLabelBorderSidesDropdown
        '
        Me.uiStatusLabelBorderSidesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uiStatusLabelBorderSidesDropdown.FormattingEnabled = True
        Me.uiStatusLabelBorderSidesDropdown.Items.AddRange(New Object() {"None", "Top", "Bottom", "Left", "Right", "All"})
        Me.uiStatusLabelBorderSidesDropdown.Location = New System.Drawing.Point(3, 204)
        Me.uiStatusLabelBorderSidesDropdown.Name = "uiStatusLabelBorderSidesDropdown"
        Me.uiStatusLabelBorderSidesDropdown.Size = New System.Drawing.Size(313, 24)
        Me.uiStatusLabelBorderSidesDropdown.TabIndex = 14
        '
        'uiStatusLabelBorderStyleLabel
        '
        Me.uiStatusLabelBorderStyleLabel.AutoSize = True
        Me.uiStatusLabelBorderStyleLabel.Location = New System.Drawing.Point(3, 231)
        Me.uiStatusLabelBorderStyleLabel.Name = "uiStatusLabelBorderStyleLabel"
        Me.uiStatusLabelBorderStyleLabel.Size = New System.Drawing.Size(86, 17)
        Me.uiStatusLabelBorderStyleLabel.TabIndex = 12
        Me.uiStatusLabelBorderStyleLabel.Text = "BorderStyle:"
        '
        'uiStatusLabelBorderStyleDropdown
        '
        Me.uiStatusLabelBorderStyleDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.uiStatusLabelBorderStyleDropdown.FormattingEnabled = True
        Me.uiStatusLabelBorderStyleDropdown.Items.AddRange(New Object() {"Adjust", "Bump", "Etched", "Flat", "Raised", "RaisedInner", "RaisedOuter", "Sunken", "SunkenInner", "SunkenOuter"})
        Me.uiStatusLabelBorderStyleDropdown.Location = New System.Drawing.Point(3, 251)
        Me.uiStatusLabelBorderStyleDropdown.Name = "uiStatusLabelBorderStyleDropdown"
        Me.uiStatusLabelBorderStyleDropdown.Size = New System.Drawing.Size(313, 24)
        Me.uiStatusLabelBorderStyleDropdown.TabIndex = 15
        '
        'menustripMenubar
        '
        Me.menustripMenubar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menustripMenubar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustripMenubar.Location = New System.Drawing.Point(0, 0)
        Me.menustripMenubar.Name = "menustripMenubar"
        Me.menustripMenubar.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.menustripMenubar.Size = New System.Drawing.Size(723, 28)
        Me.menustripMenubar.TabIndex = 10
        Me.menustripMenubar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator2, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(162, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(162, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'toolstripToolbar
        '
        Me.toolstripToolbar.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton})
        Me.toolstripToolbar.Location = New System.Drawing.Point(0, 28)
        Me.toolstripToolbar.Name = "toolstripToolbar"
        Me.toolstripToolbar.Size = New System.Drawing.Size(723, 27)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 440)
        Me.TabControl1.TabIndex = 10000
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.uiControlToThemeLabel)
        Me.TabPage1.Controls.Add(Me.comboboxControlSelector)
        Me.TabPage1.Controls.Add(Me.flowlayoutpanelPropertyList)
        Me.TabPage1.Controls.Add(Me.propertygridAdvanced)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(715, 411)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Controls"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.TextBox3)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(715, 411)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Theme info"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1.01", "1.02", "1.03", "2.0"})
        Me.ComboBox1.Location = New System.Drawing.Point(14, 317)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Label5"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(11, 267)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(295, 22)
        Me.TextBox4.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Label4"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 217)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(295, 22)
        Me.TextBox3.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Label3"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 74)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(552, 116)
        Me.TextBox2.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Label2"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(552, 22)
        Me.TextBox1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(723, 495)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.toolstripToolbar)
        Me.Controls.Add(Me.menustripMenubar)
        Me.MainMenuStrip = Me.menustripMenubar
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "aaformMainWindow"
        Me.Text = "PortableThemeEngine Theme Editor"
        Me.flowlayoutpanelPropertyList.ResumeLayout(False)
        Me.flowlayoutpanelPropertyList.PerformLayout()
        Me.menustripMenubar.ResumeLayout(False)
        Me.menustripMenubar.PerformLayout()
        Me.toolstripToolbar.ResumeLayout(False)
        Me.toolstripToolbar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
