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
        Me.buttonUpdateCheck = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanelAboutApp = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelProductName = New System.Windows.Forms.Label()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.textboxAppDescription = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.tableLayoutPanelAboutApp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.ColumnCount = 4
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.96255!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.37086!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.60706!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.tableLayoutPanel.Controls.Add(Me.buttonClose, 3, 1)
        Me.tableLayoutPanel.Controls.Add(Me.TabControl1, 0, 0)
        Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 2
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.20595!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.794055!))
        Me.tableLayoutPanel.Size = New System.Drawing.Size(534, 471)
        Me.tableLayoutPanel.TabIndex = 0
        '
        'buttonClose
        '
        Me.buttonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonClose.AutoSize = True
        Me.buttonClose.Location = New System.Drawing.Point(457, 445)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.Size = New System.Drawing.Size(74, 23)
        Me.buttonClose.TabIndex = 0
        Me.buttonClose.Text = "Close"
        Me.buttonClose.UseVisualStyleBackColor = True
        '
        'buttonUpdateCheck
        '
        Me.buttonUpdateCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonUpdateCheck.AutoSize = True
        Me.buttonUpdateCheck.Location = New System.Drawing.Point(405, 375)
        Me.buttonUpdateCheck.Name = "buttonUpdateCheck"
        Me.buttonUpdateCheck.Size = New System.Drawing.Size(106, 23)
        Me.buttonUpdateCheck.TabIndex = 1
        Me.buttonUpdateCheck.Text = "Check for Updates"
        Me.buttonUpdateCheck.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.tableLayoutPanel.SetColumnSpan(Me.TabControl1, 4)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(528, 433)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tableLayoutPanelAboutApp)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(520, 407)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tableLayoutPanelAboutApp
        '
        Me.tableLayoutPanelAboutApp.ColumnCount = 3
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.66018!))
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.42023!))
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.98444!))
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.buttonUpdateCheck, 2, 5)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.LabelProductName, 1, 0)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.LabelVersion, 1, 1)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.labelCopyright, 1, 2)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.textboxAppDescription, 1, 4)
        Me.tableLayoutPanelAboutApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelAboutApp.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanelAboutApp.Name = "tableLayoutPanelAboutApp"
        Me.tableLayoutPanelAboutApp.RowCount = 6
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.374999!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.08333!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.41667!))
        Me.tableLayoutPanelAboutApp.Size = New System.Drawing.Size(514, 401)
        Me.tableLayoutPanelAboutApp.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UXL_Launcher.My.Resources.Resources.UXL_Launcher_Banner
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.tableLayoutPanelAboutApp.SetRowSpan(Me.PictureBox1, 5)
        Me.PictureBox1.Size = New System.Drawing.Size(105, 334)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelProductName
        '
        Me.LabelProductName.AutoSize = True
        Me.tableLayoutPanelAboutApp.SetColumnSpan(Me.LabelProductName, 2)
        Me.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelProductName.Location = New System.Drawing.Point(117, 0)
        Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelProductName.Name = "LabelProductName"
        Me.LabelProductName.Size = New System.Drawing.Size(394, 37)
        Me.LabelProductName.TabIndex = 1
        Me.LabelProductName.Text = "Product Name"
        Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVersion
        '
        Me.LabelVersion.AutoSize = True
        Me.tableLayoutPanelAboutApp.SetColumnSpan(Me.LabelVersion, 2)
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(117, 37)
        Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(394, 37)
        Me.LabelVersion.TabIndex = 2
        Me.LabelVersion.Text = "Version"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labelCopyright
        '
        Me.labelCopyright.AutoSize = True
        Me.tableLayoutPanelAboutApp.SetColumnSpan(Me.labelCopyright, 2)
        Me.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelCopyright.Location = New System.Drawing.Point(117, 74)
        Me.labelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(394, 37)
        Me.labelCopyright.TabIndex = 3
        Me.labelCopyright.Text = "Copyright"
        Me.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'textboxAppDescription
        '
        Me.tableLayoutPanelAboutApp.SetColumnSpan(Me.textboxAppDescription, 2)
        Me.textboxAppDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxAppDescription.Location = New System.Drawing.Point(117, 151)
        Me.textboxAppDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.textboxAppDescription.Multiline = True
        Me.textboxAppDescription.Name = "textboxAppDescription"
        Me.textboxAppDescription.Size = New System.Drawing.Size(394, 202)
        Me.textboxAppDescription.TabIndex = 4
        Me.textboxAppDescription.Text = resources.GetString("textboxAppDescription.Text")
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(520, 407)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'aaformAboutWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(534, 471)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Name = "aaformAboutWindow"
        Me.Text = "RealAboutWindow"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.tableLayoutPanelAboutApp.ResumeLayout(False)
        Me.tableLayoutPanelAboutApp.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tableLayoutPanel As TableLayoutPanel
    Friend WithEvents buttonClose As Button
    Friend WithEvents buttonUpdateCheck As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tableLayoutPanelAboutApp As TableLayoutPanel
    Friend WithEvents LabelProductName As Label
    Friend WithEvents LabelVersion As Label
    Friend WithEvents labelCopyright As Label
    Friend WithEvents textboxAppDescription As TextBox
End Class
