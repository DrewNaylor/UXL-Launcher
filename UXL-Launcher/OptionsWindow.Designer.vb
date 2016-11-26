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
        Me.labelComingSoon = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelComingSoon
        '
        Me.labelComingSoon.AutoSize = True
        Me.labelComingSoon.Location = New System.Drawing.Point(198, 164)
        Me.labelComingSoon.Name = "labelComingSoon"
        Me.labelComingSoon.Size = New System.Drawing.Size(71, 13)
        Me.labelComingSoon.TabIndex = 0
        Me.labelComingSoon.Text = "Coming soon."
        '
        'aaformOptionsWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(485, 394)
        Me.Controls.Add(Me.labelComingSoon)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformOptionsWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelComingSoon As Label
End Class
