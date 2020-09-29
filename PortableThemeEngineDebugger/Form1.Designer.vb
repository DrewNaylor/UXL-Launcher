<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformThemeLoader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.textboxThemePath = New System.Windows.Forms.TextBox()
        Me.labelPathDescription = New System.Windows.Forms.Label()
        Me.buttonLoadTheme = New System.Windows.Forms.Button()
        Me.labelColorTester = New System.Windows.Forms.Label()
        Me.textboxColorTester = New System.Windows.Forms.TextBox()
        Me.buttonSetColor = New System.Windows.Forms.Button()
        Me.buttonResetColor = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching = New System.Windows.Forms.CheckBox()
        Me.radiobuttonMatchSystemTheme = New System.Windows.Forms.RadioButton()
        Me.groupboxContextMenuArea = New System.Windows.Forms.GroupBox()
        Me.panelContextMenuArea = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelContextMenuColors = New System.Windows.Forms.Label()
        Me.radiobuttonSelectFromThemeEngine = New System.Windows.Forms.RadioButton()
        Me.radiobuttonLoadFromXml = New System.Windows.Forms.RadioButton()
        Me.radiobuttonIsCustomTheme = New System.Windows.Forms.RadioButton()
        Me.checkboxAllowCustomThemes = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.groupboxContextMenuArea.SuspendLayout()
        Me.panelContextMenuArea.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textboxThemePath
        '
        Me.textboxThemePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxThemePath.Location = New System.Drawing.Point(9, 23)
        Me.textboxThemePath.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxThemePath.Name = "textboxThemePath"
        Me.textboxThemePath.Size = New System.Drawing.Size(353, 20)
        Me.textboxThemePath.TabIndex = 0
        Me.textboxThemePath.Text = "C:\Users\drewn\Documents\0GitHub\UXL-Launcher\PortableUXLLauncher_ThemeEngine\The" &
    "mes\TE2DotX_TenDarkTheme_XML.xml"
        '
        'labelPathDescription
        '
        Me.labelPathDescription.AutoSize = True
        Me.labelPathDescription.Location = New System.Drawing.Point(10, 7)
        Me.labelPathDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPathDescription.Name = "labelPathDescription"
        Me.labelPathDescription.Size = New System.Drawing.Size(67, 13)
        Me.labelPathDescription.TabIndex = 1
        Me.labelPathDescription.Text = "Theme path:"
        '
        'buttonLoadTheme
        '
        Me.buttonLoadTheme.Location = New System.Drawing.Point(9, 46)
        Me.buttonLoadTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonLoadTheme.Name = "buttonLoadTheme"
        Me.buttonLoadTheme.Size = New System.Drawing.Size(90, 26)
        Me.buttonLoadTheme.TabIndex = 1
        Me.buttonLoadTheme.Text = "Load theme"
        Me.buttonLoadTheme.UseVisualStyleBackColor = True
        '
        'labelColorTester
        '
        Me.labelColorTester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelColorTester.AutoSize = True
        Me.labelColorTester.Location = New System.Drawing.Point(10, 240)
        Me.labelColorTester.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelColorTester.Name = "labelColorTester"
        Me.labelColorTester.Size = New System.Drawing.Size(63, 13)
        Me.labelColorTester.TabIndex = 3
        Me.labelColorTester.Text = "Color tester:"
        '
        'textboxColorTester
        '
        Me.textboxColorTester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxColorTester.Location = New System.Drawing.Point(10, 257)
        Me.textboxColorTester.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxColorTester.Name = "textboxColorTester"
        Me.textboxColorTester.Size = New System.Drawing.Size(353, 20)
        Me.textboxColorTester.TabIndex = 6
        '
        'buttonSetColor
        '
        Me.buttonSetColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonSetColor.Location = New System.Drawing.Point(10, 280)
        Me.buttonSetColor.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonSetColor.Name = "buttonSetColor"
        Me.buttonSetColor.Size = New System.Drawing.Size(110, 24)
        Me.buttonSetColor.TabIndex = 7
        Me.buttonSetColor.Text = "Set statusbar color"
        Me.buttonSetColor.UseVisualStyleBackColor = True
        '
        'buttonResetColor
        '
        Me.buttonResetColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonResetColor.Location = New System.Drawing.Point(126, 280)
        Me.buttonResetColor.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonResetColor.Name = "buttonResetColor"
        Me.buttonResetColor.Size = New System.Drawing.Size(86, 24)
        Me.buttonResetColor.TabIndex = 8
        Me.buttonResetColor.Text = "Reset color"
        Me.buttonResetColor.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 312)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 11, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(371, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.checkboxSpecifyDarkThemeForSystemThemeMatching)
        Me.Panel1.Controls.Add(Me.radiobuttonMatchSystemTheme)
        Me.Panel1.Controls.Add(Me.groupboxContextMenuArea)
        Me.Panel1.Controls.Add(Me.radiobuttonSelectFromThemeEngine)
        Me.Panel1.Controls.Add(Me.radiobuttonLoadFromXml)
        Me.Panel1.Controls.Add(Me.radiobuttonIsCustomTheme)
        Me.Panel1.Controls.Add(Me.checkboxAllowCustomThemes)
        Me.Panel1.Controls.Add(Me.labelPathDescription)
        Me.Panel1.Controls.Add(Me.textboxThemePath)
        Me.Panel1.Controls.Add(Me.buttonResetColor)
        Me.Panel1.Controls.Add(Me.buttonLoadTheme)
        Me.Panel1.Controls.Add(Me.buttonSetColor)
        Me.Panel1.Controls.Add(Me.labelColorTester)
        Me.Panel1.Controls.Add(Me.textboxColorTester)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 312)
        Me.Panel1.TabIndex = 8
        '
        'checkboxSpecifyDarkThemeForSystemThemeMatching
        '
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.AutoSize = True
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.Location = New System.Drawing.Point(218, 184)
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.Name = "checkboxSpecifyDarkThemeForSystemThemeMatching"
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.Size = New System.Drawing.Size(117, 17)
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.TabIndex = 11
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.Text = "Specify dark theme"
        Me.checkboxSpecifyDarkThemeForSystemThemeMatching.UseVisualStyleBackColor = True
        '
        'radiobuttonMatchSystemTheme
        '
        Me.radiobuttonMatchSystemTheme.AutoSize = True
        Me.radiobuttonMatchSystemTheme.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radiobuttonMatchSystemTheme.Location = New System.Drawing.Point(202, 147)
        Me.radiobuttonMatchSystemTheme.Name = "radiobuttonMatchSystemTheme"
        Me.radiobuttonMatchSystemTheme.Size = New System.Drawing.Size(149, 30)
        Me.radiobuttonMatchSystemTheme.TabIndex = 10
        Me.radiobuttonMatchSystemTheme.TabStop = True
        Me.radiobuttonMatchSystemTheme.Text = "Match Windows 10 theme" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "settings"
        Me.radiobuttonMatchSystemTheme.UseVisualStyleBackColor = True
        '
        'groupboxContextMenuArea
        '
        Me.groupboxContextMenuArea.Controls.Add(Me.panelContextMenuArea)
        Me.groupboxContextMenuArea.Location = New System.Drawing.Point(9, 77)
        Me.groupboxContextMenuArea.Margin = New System.Windows.Forms.Padding(2)
        Me.groupboxContextMenuArea.Name = "groupboxContextMenuArea"
        Me.groupboxContextMenuArea.Padding = New System.Windows.Forms.Padding(2)
        Me.groupboxContextMenuArea.Size = New System.Drawing.Size(146, 65)
        Me.groupboxContextMenuArea.TabIndex = 9
        Me.groupboxContextMenuArea.TabStop = False
        Me.groupboxContextMenuArea.Text = "Context menu test area"
        '
        'panelContextMenuArea
        '
        Me.panelContextMenuArea.ContextMenuStrip = Me.ContextMenuStrip1
        Me.panelContextMenuArea.Controls.Add(Me.labelContextMenuColors)
        Me.panelContextMenuArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContextMenuArea.Location = New System.Drawing.Point(2, 15)
        Me.panelContextMenuArea.Margin = New System.Windows.Forms.Padding(2)
        Me.panelContextMenuArea.Name = "panelContextMenuArea"
        Me.panelContextMenuArea.Size = New System.Drawing.Size(142, 48)
        Me.panelContextMenuArea.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem3.Text = "ToolStripMenuItem3"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 22)
        Me.ToolStripMenuItem4.Text = "ToolStripMenuItem4"
        '
        'labelContextMenuColors
        '
        Me.labelContextMenuColors.AutoSize = True
        Me.labelContextMenuColors.Location = New System.Drawing.Point(3, 3)
        Me.labelContextMenuColors.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelContextMenuColors.Name = "labelContextMenuColors"
        Me.labelContextMenuColors.Size = New System.Drawing.Size(112, 39)
        Me.labelContextMenuColors.TabIndex = 0
        Me.labelContextMenuColors.Text = "Right-click anwhere in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here to test context" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "menu colors."
        '
        'radiobuttonSelectFromThemeEngine
        '
        Me.radiobuttonSelectFromThemeEngine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radiobuttonSelectFromThemeEngine.AutoSize = True
        Me.radiobuttonSelectFromThemeEngine.Location = New System.Drawing.Point(202, 47)
        Me.radiobuttonSelectFromThemeEngine.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonSelectFromThemeEngine.Name = "radiobuttonSelectFromThemeEngine"
        Me.radiobuttonSelectFromThemeEngine.Size = New System.Drawing.Size(160, 17)
        Me.radiobuttonSelectFromThemeEngine.TabIndex = 2
        Me.radiobuttonSelectFromThemeEngine.TabStop = True
        Me.radiobuttonSelectFromThemeEngine.Text = "Select theme (theme engine)"
        Me.radiobuttonSelectFromThemeEngine.UseVisualStyleBackColor = True
        '
        'radiobuttonLoadFromXml
        '
        Me.radiobuttonLoadFromXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radiobuttonLoadFromXml.AutoSize = True
        Me.radiobuttonLoadFromXml.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.radiobuttonLoadFromXml.Location = New System.Drawing.Point(202, 112)
        Me.radiobuttonLoadFromXml.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonLoadFromXml.Name = "radiobuttonLoadFromXml"
        Me.radiobuttonLoadFromXml.Size = New System.Drawing.Size(151, 30)
        Me.radiobuttonLoadFromXml.TabIndex = 5
        Me.radiobuttonLoadFromXml.TabStop = True
        Me.radiobuttonLoadFromXml.Text = "Load from XML (debugger;" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "forces ReturnOfNight)"
        Me.radiobuttonLoadFromXml.UseVisualStyleBackColor = True
        '
        'radiobuttonIsCustomTheme
        '
        Me.radiobuttonIsCustomTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radiobuttonIsCustomTheme.AutoSize = True
        Me.radiobuttonIsCustomTheme.Location = New System.Drawing.Point(202, 69)
        Me.radiobuttonIsCustomTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.radiobuttonIsCustomTheme.Name = "radiobuttonIsCustomTheme"
        Me.radiobuttonIsCustomTheme.Size = New System.Drawing.Size(120, 17)
        Me.radiobuttonIsCustomTheme.TabIndex = 3
        Me.radiobuttonIsCustomTheme.TabStop = True
        Me.radiobuttonIsCustomTheme.Text = "Apply custom theme"
        Me.radiobuttonIsCustomTheme.UseVisualStyleBackColor = True
        '
        'checkboxAllowCustomThemes
        '
        Me.checkboxAllowCustomThemes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkboxAllowCustomThemes.AutoSize = True
        Me.checkboxAllowCustomThemes.Location = New System.Drawing.Point(218, 90)
        Me.checkboxAllowCustomThemes.Margin = New System.Windows.Forms.Padding(2)
        Me.checkboxAllowCustomThemes.Name = "checkboxAllowCustomThemes"
        Me.checkboxAllowCustomThemes.Size = New System.Drawing.Size(125, 17)
        Me.checkboxAllowCustomThemes.TabIndex = 4
        Me.checkboxAllowCustomThemes.Text = "Allow custom themes"
        Me.checkboxAllowCustomThemes.UseVisualStyleBackColor = True
        '
        'aaformThemeLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(371, 334)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "aaformThemeLoader"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.groupboxContextMenuArea.ResumeLayout(False)
        Me.panelContextMenuArea.ResumeLayout(False)
        Me.panelContextMenuArea.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textboxThemePath As TextBox
    Friend WithEvents labelPathDescription As Label
    Friend WithEvents buttonLoadTheme As Button
    Friend WithEvents labelColorTester As Label
    Friend WithEvents textboxColorTester As TextBox
    Friend WithEvents buttonSetColor As Button
    Friend WithEvents buttonResetColor As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents checkboxAllowCustomThemes As CheckBox
    Friend WithEvents radiobuttonIsCustomTheme As RadioButton
    Friend WithEvents radiobuttonLoadFromXml As RadioButton
    Friend WithEvents radiobuttonSelectFromThemeEngine As RadioButton
    Friend WithEvents groupboxContextMenuArea As GroupBox
    Friend WithEvents panelContextMenuArea As Panel
    Friend WithEvents labelContextMenuColors As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents radiobuttonMatchSystemTheme As RadioButton
    Friend WithEvents checkboxSpecifyDarkThemeForSystemThemeMatching As CheckBox
End Class
