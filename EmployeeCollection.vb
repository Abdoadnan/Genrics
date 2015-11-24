Public Class EmployeeCollection

    Private _data As New ArrayList()

    Public Sub Add(value As Employee)
        _data.Add(value)
    End Sub

    Public ReadOnly Property Count As Integer
        Get
            Return _data.Count
        End Get
    End Property

    Default Public Property Item(index As Integer) As Employee
        Get
            Return CType(_data(index), Employee)
        End Get
        Set(value As Employee)
            _data(index) = value
        End Set
    End Property

End Class
