Public Interface iReposotory(Of T)
    ' I MADE IT
    ReadOnly Property Count As Integer
    Sub Add(item As T)
    Sub AddRange(item As IEnumerable(Of T))
    Sub Delete(item As T)
    Function FindById(ID As Integer) As T
    Function Findall() As IQueryable(Of T)
    Sub Commit()
End Interface
