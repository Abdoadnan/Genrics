Imports Generics

Public MustInherit Class Shape
    Implements IXmlExport
    Implements IComparable(Of Shape)
    Implements IEntity

    Public Property Id As Integer Implements IEntity.id
    Public Property Name As String
    Public MustOverride ReadOnly Property Area As Double



    Public MustOverride Function GetXmlAsElement() As XElement Implements IXmlExport.GetXmlAsElement

    Public Overridable Function GetXmlAsString() As String Implements IXmlExport.GetXmlAsString
        Dim element = GetXmlAsElement()
        Return element.ToString()
    End Function

    Public Function CompareTo(other As Shape) As Integer Implements IComparable(Of Shape).CompareTo

        Dim Comvar = 0

        If Me.Area > other.Area Then
            Comvar = 1
        ElseIf Me.Area < other.Area
            Comvar = -1
        End If
        Return Comvar
    End Function
End Class
