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
        Me.SuspendLayout()
        '
        'textboxThemePath
        '
        Me.textboxThemePath.Location = New System.Drawing.Point(12, 24)
        Me.textboxThemePath.Name = "textboxThemePath"
        Me.textboxThemePath.Size = New System.Drawing.Size(400, 22)
        Me.textboxThemePath.TabIndex = 0
        Me.textboxThemePath.Text = "C:\Users\drewn\Documents\0GitHub\UXL-Launcher\UXL-Launcher\VB Code-behind\Themes\" &
    "TE2DotX_TenDarkTheme_XML.xml"
        '
        'labelPathDescription
        '
        Me.labelPathDescription.AutoSize = True
        Me.labelPathDescription.Location = New System.Drawing.Point(13, 4)
        Me.labelPathDescription.Name = "labelPathDescription"
        Me.labelPathDescription.Size = New System.Drawing.Size(88, 17)
        Me.labelPathDescription.TabIndex = 1
        Me.labelPathDescription.Text = "Theme path:"
        '
        'buttonLoadTheme
        '
        Me.buttonLoadTheme.Location = New System.Drawing.Point(12, 53)
        Me.buttonLoadTheme.Name = "buttonLoadTheme"
        Me.buttonLoadTheme.Size = New System.Drawing.Size(113, 32)
        Me.buttonLoadTheme.TabIndex = 2
        Me.buttonLoadTheme.Text = "Load theme"
        Me.buttonLoadTheme.UseVisualStyleBackColor = True
        '
        'labelColorTester
        '
        Me.labelColorTester.AutoSize = True
        Me.labelColorTester.Location = New System.Drawing.Point(12, 92)
        Me.labelColorTester.Name = "labelColorTester"
        Me.labelColorTester.Size = New System.Drawing.Size(85, 17)
        Me.labelColorTester.TabIndex = 3
        Me.labelColorTester.Text = "Color tester:"
        '
        'textboxColorTester
        '
        Me.textboxColorTester.Location = New System.Drawing.Point(12, 113)
        Me.textboxColorTester.Name = "textboxColorTester"
        Me.textboxColorTester.Size = New System.Drawing.Size(400, 22)
        Me.textboxColorTester.TabIndex = 4
        '
        'buttonSetColor
        '
        Me.buttonSetColor.Location = New System.Drawing.Point(12, 142)
        Me.buttonSetColor.Name = "buttonSetColor"
        Me.buttonSetColor.Size = New System.Drawing.Size(138, 30)
        Me.buttonSetColor.TabIndex = 5
        Me.buttonSetColor.Text = "Set button color"
        Me.buttonSetColor.UseVisualStyleBackColor = True
        '
        'buttonResetColor
        '
        Me.buttonResetColor.Location = New System.Drawing.Point(157, 142)
        Me.buttonResetColor.Name = "buttonResetColor"
        Me.buttonResetColor.Size = New System.Drawing.Size(108, 30)
        Me.buttonResetColor.TabIndex = 6
        Me.buttonResetColor.Text = "Reset color"
        Me.buttonResetColor.UseVisualStyleBackColor = True
        '
        'aaformThemeLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(424, 184)
        Me.Controls.Add(Me.buttonResetColor)
        Me.Controls.Add(Me.buttonSetColor)
        Me.Controls.Add(Me.textboxColorTester)
        Me.Controls.Add(Me.labelColorTester)
        Me.Controls.Add(Me.buttonLoadTheme)
        Me.Controls.Add(Me.labelPathDescription)
        Me.Controls.Add(Me.textboxThemePath)
        Me.Name = "aaformThemeLoader"
        Me.Text = "Form1"
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
End Class
