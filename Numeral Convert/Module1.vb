Module Module1
    Public UserInput As Integer
    Public Operation As String
    Public ReturnHome As String
    Sub Main()
        Console.Clear()
        Console.WriteLine("=====================================================")
        Console.WriteLine("Choose an operation to convert from now.")
        Console.WriteLine("1. Decimal")
        Console.WriteLine("2. Hex")
        Console.WriteLine("3. Binary")
        Console.WriteLine("=====================================================")
        Operation = Console.ReadLine
        Select Case Operation
            Case 1
                DecimalConv()
            Case 2
                HexConv()
            Case 3
                BinaryConv()
            Case Else
                Console.WriteLine("That is not a valid choose, press enter to reset.")
                Console.ReadLine()
                Main()
        End Select
    End Sub

    Sub DecimalConv()
        Console.Clear()
        Console.WriteLine("=====================================================")
        Console.WriteLine("Please enter a decimal value to convert now.")
        Console.WriteLine("=====================================================")
        UserInput = Console.ReadLine
        Console.Clear()
        Console.WriteLine("=====================================================")
        Console.WriteLine("Entered value: {0}", UserInput)
        Console.WriteLine("Hex Value: " + Hex(UserInput))
        Console.WriteLine("Binary Value: " + Convert.ToString(UserInput, 2))
        Console.WriteLine("Press enter to continue.")
        Console.WriteLine("=====================================================")
        Console.ReadLine()
        Home()
        Console.ReadLine()
    End Sub

    Sub HexConv()
        Console.Clear()
        Dim UserInputStr As String
        Console.WriteLine("=====================================================")
        Console.WriteLine("Please enter a hex value to convert now.")
        Console.WriteLine("=====================================================")
        UserInputStr = Console.ReadLine
        Console.Clear()
        Console.WriteLine("=====================================================")
        Console.WriteLine("Entered value: {0}", UserInputStr)
        UserInput = Convert.ToInt64(UserInputStr, 16)
        Console.WriteLine("Decimal Value: " + UserInput.ToString)
        Console.WriteLine("Binary Value: " + Convert.ToString(UserInput, 2))
        Console.WriteLine("Press enter to continue.")
        Console.WriteLine("=====================================================")
        Console.ReadLine()
        Home()
        Console.ReadLine()
    End Sub

    Sub BinaryConv()
        Console.Clear()
        Dim UserInputStr As String
        Console.WriteLine("=====================================================")
        Console.WriteLine("Please enter a Binary value to convert now.")
        Console.WriteLine("=====================================================")
        UserInputStr = Console.ReadLine
        Console.Clear()
        Console.WriteLine("=====================================================")
        Console.WriteLine("Entered value: {0}", UserInputStr)
        UserInput = Convert.ToInt32(UserInputStr, 2)
        Console.WriteLine("Hex Value: " + Hex(UserInput))
        Console.WriteLine("Decimal Value: " + Convert.ToString(UserInput))
        Console.WriteLine("Press enter to continue.")
        Console.WriteLine("=====================================================")
        Console.ReadLine()
        Home()
        Console.ReadLine()
    End Sub

    Sub Home()
        Console.Clear()
        Console.WriteLine("=====================================================")
        Console.WriteLine("Do you wish to return home or close the application?")
        Console.WriteLine("1. Home")
        Console.WriteLine("2. Exit")
        Console.WriteLine("=====================================================")
        ReturnHome = Console.ReadLine
        Select Case ReturnHome
            Case 1
                Main()
            Case 2
                End
            Case Else
                Console.WriteLine("That is not a valid choose, press enter to reset.")
                Console.ReadLine()
        End Select
    End Sub
End Module
