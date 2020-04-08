Public Class aaformMainWindow
    Private Sub comboboxControlSelector_TextChanged(sender As Object, e As EventArgs) Handles comboboxControlSelector.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            textboxBackColor.Text = buttonBackColor
            textboxForeColor.Text = buttonForeColor
        ElseIf comboboxControlSelector.Text = "Label" Then
            textboxBackColor.Text = labelBackColor
            textboxForeColor.Text = labelForeColor
        End If
    End Sub

    Private Sub textboxBackColor_TextChanged(sender As Object, e As EventArgs) Handles textboxBackColor.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            buttonBackColor = textboxBackColor.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            labelBackColor = textboxBackColor.Text
        End If
    End Sub

    Private Sub textboxForeColor_TextChanged(sender As Object, e As EventArgs) Handles textboxForeColor.TextChanged
        If comboboxControlSelector.Text = "Button" Then
            buttonForeColor = textboxForeColor.Text
        ElseIf comboboxControlSelector.Text = "Label" Then
            labelForeColor = textboxForeColor.Text
        End If
    End Sub

    Private _buttonBackColor As String = "Transparent"
    Private _buttonForeColor As String = "ControlText"
    Private _labelBackColor As String = "Transparent"
    Private _labelForeColor As String = "ControlText"

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