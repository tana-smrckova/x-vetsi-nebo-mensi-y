Imports System

Module Program
    Sub Main()
        Console.WriteLine("Urèete, zda je X vìtší nebo menší než Y.")
        Console.Write("Zadej promìnnou X: ")
        Dim x = Console.ReadLine()
        Console.Write("Zadej promìnnou Y: ")
        Dim y = Console.ReadLine()

        If x > y Then
            Console.WriteLine("X je vìtší než Y.")
        ElseIf x < y Then
            Console.WriteLine("X je menší než Y.")
        Else
            Console.WriteLine("X je rovno Y.")
        End If

        Main()

    End Sub
End Module
