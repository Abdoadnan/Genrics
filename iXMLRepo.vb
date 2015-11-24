Imports Generics

Public Class iXMLRepo(Of T As IEntity)
    Implements iReposotory(Of T)
    ' By ABdo

    Private _Items As New Dictionary(Of Integer, T)

    Public ReadOnly Property Count As Integer Implements iReposotory(Of T).Count
        Get
            Return _Items.Count
        End Get
    End Property

    Public Sub Add(item As T) Implements iReposotory(Of T).Add
        _Items.Add(item.id, item)
    End Sub

    Public Sub AddRange(item As IEnumerable(Of T)) Implements iReposotory(Of T).AddRange
        For Each i In item
            Add(i)

        Next

    End Sub

    Public Sub Commit() Implements iReposotory(Of T).Commit
        Throw New NotImplementedException()
    End Sub

    Public Sub Delete(item As T) Implements iReposotory(Of T).Delete
        _Items.Remove(item.id)
    End Sub

    Public Function Findall() As IQueryable(Of T) Implements iReposotory(Of T).Findall
        Return _Items.Values.AsQueryable()
    End Function

    Public Function FindById(ID As Integer) As T Implements iReposotory(Of T).FindById
        Return _Items(ID)
    End Function
End Class
