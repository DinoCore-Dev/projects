' ============================================================
' Activity 1 - Act1_Activity202606241600
' Console basics and data types
' Author : Mangalili, Fhetz   |   BSIT 3B
' ============================================================
Module Module1

    Sub Main()
        ' program header
        Console.WriteLine("Activity202606241600")
        Console.WriteLine("Author: Mangalili, Fhetz")
        Console.WriteLine("Course Year Section: BSIT 3B")
        Console.WriteLine()

        ' String variable
        Dim theName As String = "Mangalili, Fhetz"
        Console.WriteLine("Hello " + theName)

        ' one variable for every basic data type
        Dim n1 As Integer = 0
        Dim n2 As Double = 0.0
        Dim isValid As Boolean = True
        Dim character As Char = "A"c
        Dim number1 As Integer = 12
        Dim number2 As Double = 12.12

        Console.WriteLine("n1        = " & n1.ToString())
        Console.WriteLine("n2        = " & n2.ToString())
        Console.WriteLine("isValid   = " & isValid.ToString())
        Console.WriteLine("character = " & character.ToString())
        Console.WriteLine("number1   = " & number1.ToString())
        Console.WriteLine("number2   = " & number2.ToString())
        Console.WriteLine()

        ' closing line with the name of the author
        Console.WriteLine("Prepared by: Mangalili, Fhetz  |  BSIT 3B")
        Console.ReadKey()
    End Sub

End Module
