Public Class aaformMainWindow
    Private Sub comboboxControlSelector_TextChanged(sender As Object, e As EventArgs) Handles comboboxControlSelector.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            uiBackColorTextbox.Text = buttonBackColor
            uiForeColorTextbox.Text = buttonForeColor
        ElseIf comboboxControlSelector.Text = "Label" Then
            uiBackColorTextbox.Text = labelBackColor
            uiForeColorTextbox.Text = labelForeColor
        End If
    End Sub

    Private Sub uiBackColorTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiBackColorTextbox.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            buttonBackColor = uiBackColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            labelBackColor = uiBackColorTextbox.Text
        End If
    End Sub

    Private Sub uiForeColorTextbox_TextChanged(sender As Object, e As EventArgs) Handles uiForeColorTextbox.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            buttonForeColor = uiForeColorTextbox.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            labelForeColor = uiForeColorTextbox.Text
        End If
    End Sub

    Private _buttonBackColor As String = "Transparent"
    Private _buttonForeColor As String = "ControlText"
    Private _groupboxBackColor As String = "Transparent"
    Private _groupboxForeColor As String = "ControlText"
    Private _flowlayoutpanelBackColor As String = "Transparent"
    Private _flowlayoutpanelForeColor As String = "ControlText"
    Private _statusbarBackColor As String = "LiteralNothing"
    Private _labelBackColor As String = "Transparent"
    Private _labelForeColor As String = "ControlText"
    Private _textboxBackColor As String = "Window"
    Private _textboxForeColor As String = "WindowText"
    Private _menuitemBackColor As String = "Window"
    Private _menuitemForeColor As String = "ControlText"
    Private _menuitemImageMarginGradientStartColor As String = "0xFCFCFC"
    Private _menuitemImageMarginGradientEndColor As String = "0xF1F1F1"
    Private _menubarBackColor As String = "Control"
    Private _statuslabelBackColor As String = "Transparent"
    Private _statuslabelForeColor As String = "ControlText"
    Private _statuslabelBorderSides As String = "None"
    Private _statuslabelBorderStyle As String = "Flat"



    Public Property buttonBackColor() As String
        Get
            Return _buttonBackColor
        End Get
        Set(value As String)
            _buttonBackColor = value
        End Set
    End Property

    Public Property buttonForeColor() As String
        Get
            Return _buttonForeColor
        End Get
        Set(value As String)
            _buttonForeColor = value
        End Set
    End Property

    Public Property labelBackColor() As String
        Get
            Return _labelBackColor
        End Get
        Set(value As String)
            _labelBackColor = value
        End Set
    End Property

    Public Property labelForeColor() As String
        Get
            Return _labelForeColor
        End Get
        Set(value As String)
            _labelForeColor = value
        End Set
    End Property
End Class