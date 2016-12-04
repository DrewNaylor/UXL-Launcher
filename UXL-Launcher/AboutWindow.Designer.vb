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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformAboutWindow))
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.tabcontrolAboutWindow = New System.Windows.Forms.TabControl()
        Me.tabpageAbout = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanelAboutApp = New System.Windows.Forms.TableLayoutPanel()
        Me.pictureboxUXLBanner = New System.Windows.Forms.PictureBox()
        Me.flowLayoutPanelButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.linkRepository = New System.Windows.Forms.LinkLabel()
        Me.linkUpdateCheck = New System.Windows.Forms.LinkLabel()
        Me.linkMyWebsite = New System.Windows.Forms.LinkLabel()
        Me.textboxAboutApp = New System.Windows.Forms.TextBox()
        Me.tabpageLicense = New System.Windows.Forms.TabPage()
        Me.webbrowserGPLViewer = New System.Windows.Forms.WebBrowser()
        Me.tabpageAcknowledgments = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.tableLayoutPanel.SuspendLayout()
        Me.tabcontrolAboutWindow.SuspendLayout()
        Me.tabpageAbout.SuspendLayout()
        Me.tableLayoutPanelAboutApp.SuspendLayout()
        CType(Me.pictureboxUXLBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flowLayoutPanelButtons.SuspendLayout()
        Me.tabpageLicense.SuspendLayout()
        Me.tabpageAcknowledgments.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.ColumnCount = 4
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.96255!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.37086!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60706!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 248.0!))
        Me.tableLayoutPanel.Controls.Add(Me.buttonClose, 3, 1)
        Me.tableLayoutPanel.Controls.Add(Me.tabcontrolAboutWindow, 0, 0)
        Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 2
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.20595!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.794055!))
        Me.tableLayoutPanel.Size = New System.Drawing.Size(1068, 942)
        Me.tableLayoutPanel.TabIndex = 0
        '
        'buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.AutoSize = True
        Me.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonClose.Location = New System.Drawing.Point(908, 884)
        Me.buttonClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(154, 52)
        Me.buttonClose.TabIndex = 0
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'tabcontrolAboutWindow
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.tabcontrolAboutWindow, 4)
        Me.tabcontrolAboutWindow.Controls.Add(Me.tabpageAbout)
        Me.tabcontrolAboutWindow.Controls.Add(Me.tabpageLicense)
        Me.tabcontrolAboutWindow.Controls.Add(Me.tabpageAcknowledgments)
        Me.tabcontrolAboutWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolAboutWindow.Location = New System.Drawing.Point(6, 6)
        Me.tabcontrolAboutWindow.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabcontrolAboutWindow.Name = "tabcontrolAboutWindow"
        Me.tabcontrolAboutWindow.SelectedIndex = 0
        Me.tabcontrolAboutWindow.Size = New System.Drawing.Size(1056, 866)
        Me.tabcontrolAboutWindow.TabIndex = 2
        '
        'tabpageAbout
        '
        Me.tabpageAbout.Controls.Add(Me.tableLayoutPanelAboutApp)
        Me.tabpageAbout.Location = New System.Drawing.Point(8, 39)
        Me.tabpageAbout.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabpageAbout.Name = "tabpageAbout"
        Me.tabpageAbout.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabpageAbout.Size = New System.Drawing.Size(1040, 819)
        Me.tabpageAbout.TabIndex = 0
        Me.tabpageAbout.Text = "About"
        Me.tabpageAbout.UseVisualStyleBackColor = True
        '
        'tableLayoutPanelAboutApp
        '
        Me.tableLayoutPanelAboutApp.ColumnCount = 3
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.49027!))
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.72374!))
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.98055!))
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.pictureboxUXLBanner, 0, 0)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.flowLayoutPanelButtons, 1, 5)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.textboxAboutApp, 1, 0)
        Me.tableLayoutPanelAboutApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelAboutApp.Location = New System.Drawing.Point(6, 6)
        Me.tableLayoutPanelAboutApp.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tableLayoutPanelAboutApp.Name = "tableLayoutPanelAboutApp"
        Me.tableLayoutPanelAboutApp.RowCount = 6
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.12469!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.96758!))
        Me.tableLayoutPanelAboutApp.Size = New System.Drawing.Size(1028, 807)
        Me.tableLayoutPanelAboutApp.TabIndex = 1
        '
        'pictureboxUXLBanner
        '
        Me.pictureboxUXLBanner.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureboxUXLBanner.Image = Global.UXL_Launcher.My.Resources.Resources.UXL_Launcher_Banner
        Me.pictureboxUXLBanner.Location = New System.Drawing.Point(6, 6)
        Me.pictureboxUXLBanner.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pictureboxUXLBanner.Name = "pictureboxUXLBanner"
        Me.tableLayoutPanelAboutApp.SetRowSpan(Me.pictureboxUXLBanner, 5)
        Me.pictureboxUXLBanner.Size = New System.Drawing.Size(321, 690)
        Me.pictureboxUXLBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureboxUXLBanner.TabIndex = 0
        Me.pictureboxUXLBanner.TabStop = False
        '
        'flowLayoutPanelButtons
        '
        Me.tableLayoutPanelAboutApp.SetColumnSpan(Me.flowLayoutPanelButtons, 2)
        Me.flowLayoutPanelButtons.Controls.Add(Me.linkRepository)
        Me.flowLayoutPanelButtons.Controls.Add(Me.linkUpdateCheck)
        Me.flowLayoutPanelButtons.Controls.Add(Me.linkMyWebsite)
        Me.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowLayoutPanelButtons.Location = New System.Drawing.Point(339, 708)
        Me.flowLayoutPanelButtons.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons"
        Me.flowLayoutPanelButtons.Size = New System.Drawing.Size(683, 93)
        Me.flowLayoutPanelButtons.TabIndex = 5
        '
        'linkRepository
        '
        Me.linkRepository.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkRepository.AutoSize = True
        Me.linkRepository.Location = New System.Drawing.Point(6, 20)
        Me.linkRepository.Margin = New System.Windows.Forms.Padding(6, 20, 6, 0)
        Me.linkRepository.Name = "linkRepository"
        Me.linkRepository.Size = New System.Drawing.Size(226, 25)
        Me.linkRepository.TabIndex = 1
        Me.linkRepository.TabStop = True
        Me.linkRepository.Text = "Visit GitHub repository"
        '
        'linkUpdateCheck
        '
        Me.linkUpdateCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkUpdateCheck.AutoSize = True
        Me.linkUpdateCheck.Location = New System.Drawing.Point(244, 20)
        Me.linkUpdateCheck.Margin = New System.Windows.Forms.Padding(6, 20, 6, 0)
        Me.linkUpdateCheck.Name = "linkUpdateCheck"
        Me.linkUpdateCheck.Size = New System.Drawing.Size(187, 25)
        Me.linkUpdateCheck.TabIndex = 0
        Me.linkUpdateCheck.TabStop = True
        Me.linkUpdateCheck.Text = "Check for updates"
        '
        'linkMyWebsite
        '
        Me.linkMyWebsite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.linkMyWebsite.AutoSize = True
        Me.linkMyWebsite.Location = New System.Drawing.Point(443, 20)
        Me.linkMyWebsite.Margin = New System.Windows.Forms.Padding(6, 20, 6, 0)
        Me.linkMyWebsite.Name = "linkMyWebsite"
        Me.linkMyWebsite.Size = New System.Drawing.Size(202, 25)
        Me.linkMyWebsite.TabIndex = 2
        Me.linkMyWebsite.TabStop = True
        Me.linkMyWebsite.Text = "Visit Drew's website"
        '
        'textboxAboutApp
        '
        Me.textboxAboutApp.BackColor = System.Drawing.SystemColors.Window
        Me.tableLayoutPanelAboutApp.SetColumnSpan(Me.textboxAboutApp, 2)
        Me.textboxAboutApp.Location = New System.Drawing.Point(345, 6)
        Me.textboxAboutApp.Margin = New System.Windows.Forms.Padding(12, 6, 6, 6)
        Me.textboxAboutApp.Multiline = True
        Me.textboxAboutApp.Name = "textboxAboutApp"
        Me.textboxAboutApp.ReadOnly = True
        Me.tableLayoutPanelAboutApp.SetRowSpan(Me.textboxAboutApp, 5)
        Me.textboxAboutApp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxAboutApp.Size = New System.Drawing.Size(674, 678)
        Me.textboxAboutApp.TabIndex = 0
        Me.textboxAboutApp.TabStop = False
        Me.textboxAboutApp.Text = resources.GetString("textboxAboutApp.Text")
        '
        'tabpageLicense
        '
        Me.tabpageLicense.Controls.Add(Me.webbrowserGPLViewer)
        Me.tabpageLicense.Location = New System.Drawing.Point(8, 39)
        Me.tabpageLicense.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabpageLicense.Name = "tabpageLicense"
        Me.tabpageLicense.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabpageLicense.Size = New System.Drawing.Size(1040, 819)
        Me.tabpageLicense.TabIndex = 1
        Me.tabpageLicense.Text = "License"
        Me.tabpageLicense.UseVisualStyleBackColor = True
        '
        'webbrowserGPLViewer
        '
        Me.webbrowserGPLViewer.AllowNavigation = False
        Me.webbrowserGPLViewer.AllowWebBrowserDrop = False
        Me.webbrowserGPLViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webbrowserGPLViewer.Location = New System.Drawing.Point(6, 6)
        Me.webbrowserGPLViewer.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.webbrowserGPLViewer.MinimumSize = New System.Drawing.Size(40, 40)
        Me.webbrowserGPLViewer.Name = "webbrowserGPLViewer"
        Me.webbrowserGPLViewer.ScriptErrorsSuppressed = True
        Me.webbrowserGPLViewer.Size = New System.Drawing.Size(1028, 807)
        Me.webbrowserGPLViewer.TabIndex = 0
        Me.webbrowserGPLViewer.Url = New System.Uri("", System.UriKind.Relative)
        '
        'tabpageAcknowledgments
        '
        Me.tabpageAcknowledgments.Controls.Add(Me.WebBrowser1)
        Me.tabpageAcknowledgments.Location = New System.Drawing.Point(8, 39)
        Me.tabpageAcknowledgments.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabpageAcknowledgments.Name = "tabpageAcknowledgments"
        Me.tabpageAcknowledgments.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tabpageAcknowledgments.Size = New System.Drawing.Size(1040, 819)
        Me.tabpageAcknowledgments.TabIndex = 2
        Me.tabpageAcknowledgments.Text = "Acknowledgments"
        Me.tabpageAcknowledgments.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(6, 6)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1028, 807)
        Me.WebBrowser1.TabIndex = 0
        '
        'aaformAboutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonClose
        Me.ClientSize = New System.Drawing.Size(1068, 942)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aaformAboutWindow"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "aaformAboutWindow"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        Me.tabcontrolAboutWindow.ResumeLayout(False)
        Me.tabpageAbout.ResumeLayout(False)
        Me.tableLayoutPanelAboutApp.ResumeLayout(False)
        Me.tableLayoutPanelAboutApp.PerformLayout()
        CType(Me.pictureboxUXLBanner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flowLayoutPanelButtons.ResumeLayout(False)
        Me.flowLayoutPanelButtons.PerformLayout()
        Me.tabpageLicense.ResumeLayout(False)
        Me.tabpageAcknowledgments.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tableLayoutPanel As TableLayoutPanel
    Friend WithEvents buttonClose As Button
    Friend WithEvents tabcontrolAboutWindow As TabControl
    Friend WithEvents tabpageAbout As TabPage
    Friend WithEvents tabpageLicense As TabPage
    Friend WithEvents pictureboxUXLBanner As PictureBox
    Friend WithEvents tableLayoutPanelAboutApp As TableLayoutPanel
    Friend WithEvents textboxAboutApp As TextBox
    Friend WithEvents tabpageAcknowledgments As TabPage
    Friend WithEvents flowLayoutPanelButtons As FlowLayoutPanel
    Friend WithEvents linkUpdateCheck As LinkLabel
    Friend WithEvents linkRepository As LinkLabel
    Friend WithEvents linkMyWebsite As LinkLabel
    Friend WithEvents webbrowserGPLViewer As WebBrowser
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
