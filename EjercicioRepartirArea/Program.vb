Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World! a repartir áreas" + vbCrLf)

        Dim Lista As New ArrayList
        Dim num As Integer = 1
        Dim areaH As Integer
        Dim areaW As Integer
        Dim areaTotal As Integer
        Dim sumaValores As Integer
        Dim proporcion As Integer

        Console.WriteLine("Introduce una lista de números positivos:")
        While num > 0
            num = Console.ReadLine()
            If num > 0 Then
                Lista.Add(num)
            ElseIf num < 0 Then
                Console.WriteLine("No introduzcas números negativos")
            End If
        End While

        Console.WriteLine("")
        For x = 0 To Lista.Count - 1
            Console.Write($"{Lista(x)}" + ", ")
        Next
        Console.WriteLine("")

        Console.WriteLine(vbCrLf + "Introduce el valor del área en cm:")
        Console.Write("Altura(h):")
        areaH = Console.ReadLine()
        Console.Write("Anchura(w):")
        areaW = Console.ReadLine

        areaTotal = areaH * areaW

        Console.WriteLine(vbCrLf + $"Valor de la altura: {areaH} cm")
        Console.WriteLine(vbCrLf + $"Valor de la anchura: {areaW} cm")
        Console.WriteLine(vbCrLf + $"Valor total del área: {areaTotal} cm")

        For x = 0 To Lista.Count - 1
            sumaValores += Lista(x)
        Next

        proporcion = areaTotal \ sumaValores

        Console.WriteLine(vbCrLf + $"Proporción entre valores: {proporcion}")

        For x = 0 To Lista.Count - 1
            Lista(x) *= proporcion
        Next

        Console.WriteLine("")
        For x = 0 To Lista.Count - 1
            Console.Write($"{Lista(x)}" + ", ")
        Next
        Console.WriteLine("")
    End Sub
End Module
