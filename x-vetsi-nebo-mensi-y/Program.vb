Imports System

Module Program
    Sub Main()
        Console.WriteLine("Ur�ete, zda je X v�t�� nebo men�� ne� Y.")
        Console.Write("Zadej prom�nnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej prom�nnou Y: ")
        Dim y = Console.ReadLine()

        If x > y Then
            Console.WriteLine("X je v�t�� ne� Y.")
        ElseIf x < y Then
            Console.WriteLine("X je men�� ne� Y.")
        Else
            Console.WriteLine("X je rovno Y.")
        End If

        Main()

    End Sub
End Module
