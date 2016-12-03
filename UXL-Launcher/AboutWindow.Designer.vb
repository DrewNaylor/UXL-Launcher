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
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.buttonClose = New System.Windows.Forms.Button()
        Me.buttonUpdateCheck = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tableLayoutPanelAboutApp = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86.0!))
        Me.tableLayoutPanel.Controls.Add(Me.buttonClose, 3, 1)
        Me.tableLayoutPanel.Controls.Add(Me.buttonUpdateCheck, 2, 1)
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
        Me.buttonUpdateCheck.Location = New System.Drawing.Point(337, 445)
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
        Me.tableLayoutPanelAboutApp.ColumnCount = 2
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.49027!))
        Me.tableLayoutPanelAboutApp.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.50973!))
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.PictureBox1, 0, 0)
        Me.tableLayoutPanelAboutApp.Controls.Add(Me.Label1, 1, 0)
        Me.tableLayoutPanelAboutApp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanelAboutApp.Location = New System.Drawing.Point(3, 3)
        Me.tableLayoutPanelAboutApp.Name = "tableLayoutPanelAboutApp"
        Me.tableLayoutPanelAboutApp.RowCount = 5
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
        Me.tableLayoutPanelAboutApp.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tableLayoutPanelAboutApp.Size = New System.Drawing.Size(514, 401)
        Me.tableLayoutPanelAboutApp.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UXL_Launcher.My.Resources.Resources.UXL_Launcher_Banner
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.tableLayoutPanelAboutApp.SetRowSpan(Me.PictureBox1, 4)
        Me.PictureBox1.Size = New System.Drawing.Size(160, 334)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
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
    Friend WithEvents Label1 As Label
End Class
