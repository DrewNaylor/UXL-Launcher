<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaformAboutWindow
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

    Friend WithEvents tabelLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pictureboxUXLBanner As System.Windows.Forms.PictureBox
    Friend WithEvents LabelProductName As System.Windows.Forms.Label
    Friend WithEvents LabelVersion As System.Windows.Forms.Label
    Friend WithEvents labelCompanyName As System.Windows.Forms.Label
    Friend WithEvents textboxAppDescription As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents labelCopyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformAboutWindow))
        Me.tabelLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.pictureboxUXLBanner = New System.Windows.Forms.PictureBox()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.labelCompanyName = New System.Windows.Forms.Label()
        Me.textboxAppDescription = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.tabelLayoutPanel.SuspendLayout()
        CType(Me.pictureboxUXLBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabelLayoutPanel
        '
        Me.tabelLayoutPanel.ColumnCount = 2
        Me.tabelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.0!))
        Me.tabelLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0!))
        Me.tabelLayoutPanel.Controls.Add(Me.pictureboxUXLBanner, 0, 0)
        Me.tabelLayoutPanel.Controls.Add(Me.LabelProductName, 1, 0)
        Me.tabelLayoutPanel.Controls.Add(Me.LabelVersion, 1, 1)
        Me.tabelLayoutPanel.Controls.Add(Me.labelCopyright, 1, 2)
        Me.tabelLayoutPanel.Controls.Add(Me.labelCompanyName, 1, 3)
        Me.tabelLayoutPanel.Controls.Add(Me.textboxAppDescription, 1, 4)
        Me.tabelLayoutPanel.Controls.Add(Me.OKButton, 1, 5)
        Me.tabelLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelLayoutPanel.Location = New System.Drawing.Point(9, 9)
        Me.tabelLayoutPanel.Name = "tabelLayoutPanel"
        Me.tabelLayoutPanel.RowCount = 6
        Me.tabelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tabelLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.tabelLayoutPanel.Size = New System.Drawing.Size(396, 258)
        Me.tabelLayoutPanel.TabIndex = 0
        '
        'pictureboxUXLBanner
        '
        Me.pictureboxUXLBanner.BackColor = System.Drawing.SystemColors.Window
        Me.pictureboxUXLBanner.Image = CType(resources.GetObject("pictureboxUXLBanner.Image"), System.Drawing.Image)
        Me.pictureboxUXLBanner.Location = New System.Drawing.Point(3, 3)
        Me.pictureboxUXLBanner.Name = "pictureboxUXLBanner"
        Me.tabelLayoutPanel.SetRowSpan(Me.pictureboxUXLBanner, 6)
        Me.pictureboxUXLBanner.Size = New System.Drawing.Size(124, 252)
        Me.pictureboxUXLBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxUXLBanner.TabIndex = 0
        Me.pictureboxUXLBanner.TabStop = False
        '
        'LabelProductName
        '
        Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductName.Location = New System.Drawing.Point(136, 0)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelProductName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(257, 17)
        Me.LabelProductName.TabIndex = 0
        Me.LabelProductName.Text = "Product Name"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVersion
        '
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(136, 25)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelVersion.MaximumSize = New System.Drawing.Size(0, 17)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(257, 17)
        Me.LabelVersion.TabIndex = 0
        Me.LabelVersion.Text = "Version"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelCopyright
        '
        Me.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelCopyright.Location = New System.Drawing.Point(136, 50)
        Me.labelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.labelCopyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(257, 17)
        Me.labelCopyright.TabIndex = 0
        Me.labelCopyright.Text = "Copyright"
        Me.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelCompanyName
        '
        Me.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelCompanyName.Location = New System.Drawing.Point(136, 75)
        Me.labelCompanyName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.labelCompanyName.MaximumSize = New System.Drawing.Size(0, 17)
        Me.labelCompanyName.Name = "labelCompanyName"
        Me.labelCompanyName.Size = New System.Drawing.Size(257, 17)
        Me.labelCompanyName.TabIndex = 0
        Me.labelCompanyName.Text = "Company Name"
        Me.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textboxAppDescription
        '
        Me.textboxAppDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxAppDescription.Location = New System.Drawing.Point(136, 103)
        Me.textboxAppDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.textboxAppDescription.Multiline = True
        Me.textboxAppDescription.Name = "textboxAppDescription"
        Me.textboxAppDescription.ReadOnly = True
        Me.textboxAppDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textboxAppDescription.Size = New System.Drawing.Size(257, 123)
        Me.textboxAppDescription.TabIndex = 0
        Me.textboxAppDescription.TabStop = False
        Me.textboxAppDescription.Text = resources.GetString("textboxAppDescription.Text")
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(318, 232)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "&OK"
        '
        'aaformAboutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(414, 276)
        Me.Controls.Add(Me.tabelLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformAboutWindow"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About UXL Launcher"
        Me.tabelLayoutPanel.ResumeLayout(False)
        Me.tabelLayoutPanel.PerformLayout()
        CType(Me.pictureboxUXLBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
