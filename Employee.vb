Imports Generics

Public Class Employee
    Implements IXmlExport
    Implements IComparable(Of Employee)
    Implements IEntity

    Private _name As String
    Private _birthDate As DateTime

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If Not String.IsNullOrEmpty(value) Then
                _name = value
            End If
        End Set
    End Property

    Public ReadOnly Property Age As Integer
        Get
            Dim diff = DateTime.Now - _birthDate
            Return diff.Days \ 365
        End Get
    End Property

    Public Property Id As Integer Implements IEntity.id
    Public Property Salaried As Boolean

    Public Sub New()
        Name = "<empty>"
        Salaried = False
    End Sub

    Public Sub New(ByVal id As Integer,
        ByVal name As String,
        ByVal salaried As Boolean)

        Me.Id = id
        Me.Name = name
        Me.Salaried = salaried
    End Sub

    Public Function GetDescription()
        Return String.Format(
            "{0} is{1} a salaried employee",
            Name, IIf(Salaried, "", " not"))
    End Function

    Public Function GetXmlAsString() As String Implements IXmlExport.GetXmlAsString
        Dim element = GetXmlAsElement()
        Return element.ToString()
    End Function

    Public Function GetXmlAsElement() As XElement Implements IXmlExport.GetXmlAsElement
        Dim element As New XElement("Employee",
            New XAttribute("Id", Id),
            New XAttribute("Name", Name),
            New XAttribute("Salaried", Salaried))
        Return element
    End Function

    Public Function CompareTo(other As Employee) As Integer Implements IComparable(Of Employee).CompareTo
        Dim Res As Integer = 0

        If Me.Id > other.Id Then
            Res = 1
        ElseIf Me.Id < other.Id
            Res = -1
        End If
        Return Res
    End Function
End Class
