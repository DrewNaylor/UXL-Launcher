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
        Me.flowlayoutpanelPropertyList.SuspendLayout()
        Me.menustripMenubar.SuspendLayout()
        Me.toolstripToolbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'comboboxControlSelector
        '
        Me.comboboxControlSelector.FormattingEnabled = True
        Me.comboboxControlSelector.Items.AddRange(New Object() {"Button", "GroupBox", "FlowLayoutPanel", "StatusBar", "Label", "TextBox", "MenuItem", "MenuBar", "StatusLabel"})
        Me.comboboxControlSelector.Location = New System.Drawing.Point(20, 91)
        Me.comboboxControlSelector.Margin = New System.Windows.Forms.Padding(4)
        Me.comboboxControlSelector.Name = "comboboxControlSelector"
        Me.comboboxControlSelector.Size = New System.Drawing.Size(316, 24)
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
        Me.uiControlToThemeLabel.Location = New System.Drawing.Point(16, 71)
        Me.uiControlToThemeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.uiControlToThemeLabel.Name = "uiControlToThemeLabel"
        Me.uiControlToThemeLabel.Size = New System.Drawing.Size(116, 17)
        Me.uiControlToThemeLabel.TabIndex = 7
        Me.uiControlToThemeLabel.Text = "Control to theme:"
        '
        'propertygridAdvanced
        '
        Me.propertygridAdvanced.Location = New System.Drawing.Point(359, 91)
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
        Me.flowlayoutpanelPropertyList.Location = New System.Drawing.Point(20, 124)
        Me.flowlayoutpanelPropertyList.Margin = New System.Windows.Forms.Padding(4)
        Me.flowlayoutpanelPropertyList.Name = "flowlayoutpanelPropertyList"
        Me.flowlayoutpanelPropertyList.Size = New System.Drawing.Size(331, 350)
        Me.flowlayoutpanelPropertyList.TabIndex = 9
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
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(723, 495)
        Me.Controls.Add(Me.toolstripToolbar)
        Me.Controls.Add(Me.flowlayoutpanelPropertyList)
        Me.Controls.Add(Me.propertygridAdvanced)
        Me.Controls.Add(Me.uiControlToThemeLabel)
        Me.Controls.Add(Me.comboboxControlSelector)
        Me.Controls.Add(Me.menustripMenubar)
        Me.MainMenuStrip = Me.menustripMenubar
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "aaformMainWindow"
        Me.Text = "theme editor for PortableThemeEngine"
        Me.flowlayoutpanelPropertyList.ResumeLayout(False)
        Me.flowlayoutpanelPropertyList.PerformLayout()
        Me.menustripMenubar.ResumeLayout(False)
        Me.menustripMenubar.PerformLayout()
        Me.toolstripToolbar.ResumeLayout(False)
        Me.toolstripToolbar.PerformLayout()
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
End Class
