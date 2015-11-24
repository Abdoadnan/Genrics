Module Module1

    Sub Main()
        Dim rand As New Random()
        Dim inop As Integer = 0

        'Dim shapes As New List(Of Shape)
        Dim shapes As New iXMLRepo(Of Shape)
        For i = 1 To 10
            Dim shape As Shape
            Dim name = "Shape" & i
            Dim value = rand.Next(1, 20)
            If i Mod 2 = 0 Then
                shape = New Square(id:=i, name:=name, side:=value)
            Else
                shape = New Circle(id:=i, name:=name, radius:=value)
            End If
            inop = value
            shapes.Add(shape)
        Next
        'shapes.Sort()

        Dim som As String = ""
        For Each shape In shapes.Findall()
            Dim parts As String() = shape.GetType().ToString().Split(New Char() {"."c}) ' Split on Charchter
            Console.WriteLine(shape.Name & ": " & shape.Area & ": " & parts(1))
        Next

        Dim u As New Utils()
        ''''''''''Class shapes MUST implement Icomparable interface and then create Generic class with MAx(of T) func
        'Dim max = u.MAX(shapes(1), shapes(2)) '''''''' Compare Shpes Type 
        'Dim max = u.MAX(10, 20) ''''''''' Compare Integers as well 
        'Console.WriteLine("Max Area is {0}, Area is {1} ", max.Name, max.Area)
        Dim em1 As New Employee(15, "ABDO", True)
        Dim em2 As New Employee(20, "ANA", True)
        Dim max = u.MAX(em1, em2) ''''''''' Compare Employee Class 
        Console.WriteLine("This is the Big one  {0} , Name is {1} ", max.Id, max.Name)

        Dim u2 As New Utils()
        Dim ret = u2.GETTY(em1)

        Dim dop = shapes.FindById(inop)
        Console.WriteLine("Area is   {0} , Name is {1}, Type is {2} ", dop.Area, dop.Name, dop.GetType().ToString())
    End Sub

End Module

