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
        Me.radiobuttonSelectFromThemeEngine = New System.Windows.Forms.RadioButton()
        Me.radiobuttonLoadFromXml = New System.Windows.Forms.RadioButton()
        Me.radiobuttonIsCustomTheme = New System.Windows.Forms.RadioButton()
        Me.checkboxAllowCustomThemes = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textboxThemePath
        '
        Me.textboxThemePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxThemePath.Location = New System.Drawing.Point(11, 29)
        Me.textboxThemePath.Name = "textboxThemePath"
        Me.textboxThemePath.Size = New System.Drawing.Size(400, 22)
        Me.textboxThemePath.TabIndex = 0
        Me.textboxThemePath.Text = "C:\Users\drewn\Documents\0GitHub\UXL-Launcher\PortableUXLLauncher_ThemeEngine\The" &
    "mes\TE2DotX_TenDarkTheme_XML.xml"
        '
        'labelPathDescription
        '
        Me.labelPathDescription.AutoSize = True
        Me.labelPathDescription.Location = New System.Drawing.Point(12, 9)
        Me.labelPathDescription.Name = "labelPathDescription"
        Me.labelPathDescription.Size = New System.Drawing.Size(88, 17)
        Me.labelPathDescription.TabIndex = 1
        Me.labelPathDescription.Text = "Theme path:"
        '
        'buttonLoadTheme
        '
        Me.buttonLoadTheme.Location = New System.Drawing.Point(11, 58)
        Me.buttonLoadTheme.Name = "buttonLoadTheme"
        Me.buttonLoadTheme.Size = New System.Drawing.Size(113, 32)
        Me.buttonLoadTheme.TabIndex = 1
        Me.buttonLoadTheme.Text = "Load theme"
        Me.buttonLoadTheme.UseVisualStyleBackColor = True
        '
        'labelColorTester
        '
        Me.labelColorTester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelColorTester.AutoSize = True
        Me.labelColorTester.Location = New System.Drawing.Point(12, 190)
        Me.labelColorTester.Name = "labelColorTester"
        Me.labelColorTester.Size = New System.Drawing.Size(85, 17)
        Me.labelColorTester.TabIndex = 3
        Me.labelColorTester.Text = "Color tester:"
        '
        'textboxColorTester
        '
        Me.textboxColorTester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxColorTester.Location = New System.Drawing.Point(12, 211)
        Me.textboxColorTester.Name = "textboxColorTester"
        Me.textboxColorTester.Size = New System.Drawing.Size(400, 22)
        Me.textboxColorTester.TabIndex = 6
        '
        'buttonSetColor
        '
        Me.buttonSetColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonSetColor.Location = New System.Drawing.Point(12, 240)
        Me.buttonSetColor.Name = "buttonSetColor"
        Me.buttonSetColor.Size = New System.Drawing.Size(138, 30)
        Me.buttonSetColor.TabIndex = 7
        Me.buttonSetColor.Text = "Set statusbar color"
        Me.buttonSetColor.UseVisualStyleBackColor = True
        '
        'buttonResetColor
        '
        Me.buttonResetColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonResetColor.Location = New System.Drawing.Point(157, 240)
        Me.buttonResetColor.Name = "buttonResetColor"
        Me.buttonResetColor.Size = New System.Drawing.Size(108, 30)
        Me.buttonResetColor.TabIndex = 8
        Me.buttonResetColor.Text = "Reset color"
        Me.buttonResetColor.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 279)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(424, 25)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Panel1
        '
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
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 279)
        Me.Panel1.TabIndex = 8
        '
        'radiobuttonSelectFromThemeEngine
        '
        Me.radiobuttonSelectFromThemeEngine.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radiobuttonSelectFromThemeEngine.AutoSize = True
        Me.radiobuttonSelectFromThemeEngine.Location = New System.Drawing.Point(208, 57)
        Me.radiobuttonSelectFromThemeEngine.Name = "radiobuttonSelectFromThemeEngine"
        Me.radiobuttonSelectFromThemeEngine.Size = New System.Drawing.Size(211, 21)
        Me.radiobuttonSelectFromThemeEngine.TabIndex = 2
        Me.radiobuttonSelectFromThemeEngine.TabStop = True
        Me.radiobuttonSelectFromThemeEngine.Text = "Select theme (theme engine)"
        Me.radiobuttonSelectFromThemeEngine.UseVisualStyleBackColor = True
        '
        'radiobuttonLoadFromXml
        '
        Me.radiobuttonLoadFromXml.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radiobuttonLoadFromXml.AutoSize = True
        Me.radiobuttonLoadFromXml.Location = New System.Drawing.Point(208, 138)
        Me.radiobuttonLoadFromXml.Name = "radiobuttonLoadFromXml"
        Me.radiobuttonLoadFromXml.Size = New System.Drawing.Size(200, 21)
        Me.radiobuttonLoadFromXml.TabIndex = 5
        Me.radiobuttonLoadFromXml.TabStop = True
        Me.radiobuttonLoadFromXml.Text = "Load from XML (debugger)"
        Me.radiobuttonLoadFromXml.UseVisualStyleBackColor = True
        '
        'radiobuttonIsCustomTheme
        '
        Me.radiobuttonIsCustomTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radiobuttonIsCustomTheme.AutoSize = True
        Me.radiobuttonIsCustomTheme.Location = New System.Drawing.Point(208, 84)
        Me.radiobuttonIsCustomTheme.Name = "radiobuttonIsCustomTheme"
        Me.radiobuttonIsCustomTheme.Size = New System.Drawing.Size(156, 21)
        Me.radiobuttonIsCustomTheme.TabIndex = 3
        Me.radiobuttonIsCustomTheme.TabStop = True
        Me.radiobuttonIsCustomTheme.Text = "Apply custom theme"
        Me.radiobuttonIsCustomTheme.UseVisualStyleBackColor = True
        '
        'checkboxAllowCustomThemes
        '
        Me.checkboxAllowCustomThemes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkboxAllowCustomThemes.AutoSize = True
        Me.checkboxAllowCustomThemes.Location = New System.Drawing.Point(208, 111)
        Me.checkboxAllowCustomThemes.Name = "checkboxAllowCustomThemes"
        Me.checkboxAllowCustomThemes.Size = New System.Drawing.Size(161, 21)
        Me.checkboxAllowCustomThemes.TabIndex = 4
        Me.checkboxAllowCustomThemes.Text = "Allow custom themes"
        Me.checkboxAllowCustomThemes.UseVisualStyleBackColor = True
        '
        'aaformThemeLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(424, 304)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "aaformThemeLoader"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
End Class
