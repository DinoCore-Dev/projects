' ============================================================
' Activity 2 - Act2 Celcius-Fahrenheit Converter
' Name input and temperature conversion
' Author : Lucena, Lyka Joy   |   BSIT 3B
' ============================================================
Module Module1

    Sub Main()
        ' program header
        Console.WriteLine("Act2 Celcius-Fahrenheit Converter")
        Console.WriteLine("Author: Lucena, Lyka Joy")
        Console.WriteLine("Course Year Section: BSIT 3B")
        Console.WriteLine()

        Console.Write("Hello world")
        Console.ReadLine()

        Dim lastName As String = ""
        Dim firstName As String = ""

        Console.Write("Enter Lastname: ")
        lastName = Console.ReadLine()
        Console.Write("Enter Firstname: ")
        firstName = Console.ReadLine()

        Console.WriteLine("Your Lastname is " + lastName)
        Console.WriteLine("Your Firstname is " + firstName)
        Console.ReadLine()

        ' Converter 1: Celsius to Fahrenheit
        Console.WriteLine("--- Celsius to Fahrenheit Converter ---" & vbNewLine)
        Console.Write("Enter Celsius: ")
        Dim celsiusInput As Decimal = Convert.ToDecimal(Console.ReadLine())
        Dim fahrenheitResult As Decimal = (celsiusInput * 1.8) + 32
        Console.WriteLine("Result in Fahrenheit: " & fahrenheitResult)
        Console.ReadLine()

        ' Converter 2: Fahrenheit to Celsius
        Console.WriteLine("--- Fahrenheit to Celsius Converter ---" & vbNewLine)
        Console.Write("Enter Fahrenheit: ")
        Dim fahrenheitInput As Decimal = Convert.ToDecimal(Console.ReadLine())
        Dim celsiusResult As Decimal = (fahrenheitInput - 32) / 1.8
        Console.WriteLine("Result in Celsius: " & celsiusResult)

        ' closing line with the name of the author
        Console.WriteLine()
        Console.WriteLine("Activity 2 completed by: Lucena, Lyka Joy  |  BSIT 3B")
        Console.ReadLine()

    End Sub

End Module
