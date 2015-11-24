Public Class Circle
    Inherits Shape

    Private _radius As Integer

    Public Overrides ReadOnly Property Area As Double
        Get
            Return _radius ^ 2
        End Get
    End Property

    Public Sub New(id As Integer, name As String, radius As Integer)
        Me.Id = id
        Me.Name = name
        _radius = radius
    End Sub

    Public Overrides Function GetXmlAsElement() As XElement
        Dim element As New XElement("Circle", _
            New XAttribute("Id", Id), _
            New XAttribute("Name", Name), _
            New XAttribute("Radius", _radius))
        Return element
    End Function
End Class
