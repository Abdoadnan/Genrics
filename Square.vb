Public Class Square
    Inherits Shape

    Private _side As Integer

    Public Overrides ReadOnly Property Area As Double
        Get
            Return _side ^ 2
        End Get
    End Property

    Public Sub New(id As Integer, name As String, side As Integer)
        Me.Id = id
        Me.Name = name
        _side = side
    End Sub

    Public Overrides Function GetXmlAsElement() As XElement
        Dim element As New XElement("Square", _
            New XAttribute("Id", Id), _
            New XAttribute("Name", Name), _
            New XAttribute("Side", _side))
        Return element
    End Function
End Class
