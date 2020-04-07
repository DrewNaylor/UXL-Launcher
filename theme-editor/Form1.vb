Public Class Form1
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged

    End Sub
End Class


Public Class ControlProperties
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


End Class