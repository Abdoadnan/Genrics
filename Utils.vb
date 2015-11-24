Public Class Utils

    Public Function MAX(Of T As IComparable(Of T))(A As T, B As T) As T
        Return IIf(A.CompareTo(B) > 0, A, B)
    End Function

    Public Function GETTY(Of T As Class)(obj As T) As String
        ' i can add AS Class or as structure 
        Dim res As String = ""
        res = obj.GetType().ToString()
        Return res
    End Function
End Class
