Public Class IntCollection

    Private _data As New ArrayList()

    Public Sub Add(value As Integer)
        _data.Add(value)
    End Sub

    Public ReadOnly Property Count As Integer
        Get
            Return _data.Count
        End Get
    End Property

    Default Public Property Item(index As Integer) As Integer
        Get
            Return CType(_data(index), Integer)
        End Get
        Set(value As Integer)
            _data(index) = value
        End Set
    End Property

End Class
