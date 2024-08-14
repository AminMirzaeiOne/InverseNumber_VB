' Module declaration
Module Module1

    ' Main program entry point
    Sub Main()

        ' Declare variables for original number, digit, and reversed number
        Dim x, r, s As Integer

        ' Set console foreground color to cyan for user prompt
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt user to enter a number
        System.Console.Write("Pls Enter Number: ")

        ' Set console foreground color to yellow for user input
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the entered number as an integer and store it in x
        x = System.Convert.ToInt32(Console.ReadLine())

        ' Initialize the reversed number (s) to 0
        s = 0

        ' Loop to extract digits and build the reversed number
        Do While x > 0
            ' Extract the last digit (remainder) from x
            r = x Mod 10

            ' Append the digit to the reversed number (s) and shift existing digits left by 1 (multiply by 10)
            s = s * 10 + r

            ' Remove the last digit from x for the next iteration
            x = x \ 10
        Loop

        ' Newline character for better formatting
        System.Console.WriteLine()

        ' Set console foreground color to blue for reversed number output
        System.Console.ForegroundColor = ConsoleColor.Blue

        ' Display a message before the reversed number
        System.Console.Write("Reverse Number Is: ")

        ' Set console background and foreground colors for reversed number display
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White

        ' Print the reversed number (s)
        System.Console.WriteLine(s)

        ' Reset console colors to default
        System.Console.ResetColor()

        ' Set console foreground color to magenta for separator line
        System.Console.ForegroundColor = ConsoleColor.Magenta

        ' Print a separator line
        System.Console.WriteLine("-----------------------")

        ' Set console foreground color to red for programmer information
        System.Console.ForegroundColor = ConsoleColor.Red

        ' Print programmer information including GitHub username
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Wait for user to press any key before closing the console
        System.Console.ReadKey()

    End Sub

End Module
