Public Class Form1
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "Button" Then
            TextBox1.Text = buttonBackColor
            TextBox2.Text = buttonForeColor
        ElseIf ComboBox1.Text = "Label" Then
            TextBox1.Text = labelBackColor
            TextBox2.Text = labelForeColor
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text = "Button" Then
            buttonBackColor = TextBox1.Text
        ElseIf ComboBox1.Text = "Label" Then
            labelBackColor = TextBox1.Text
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