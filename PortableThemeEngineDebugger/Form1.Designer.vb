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
        Me.SuspendLayout()
        '
        'textboxThemePath
        '
        Me.textboxThemePath.Location = New System.Drawing.Point(12, 24)
        Me.textboxThemePath.Name = "textboxThemePath"
        Me.textboxThemePath.Size = New System.Drawing.Size(400, 22)
        Me.textboxThemePath.TabIndex = 0
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
        'aaformThemeLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(424, 96)
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
End Class
