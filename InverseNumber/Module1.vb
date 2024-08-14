Module Module1

    Sub Main()

        Dim x, r, s As Integer
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Number: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        x = System.Convert.ToInt32(Console.ReadLine())

        s = 0

        Do
            r = x Mod 10

            s = s * 10 + r

            x = x \ 10
        Loop While x > 0

        System.Console.WriteLine()

        System.Console.ForegroundColor = ConsoleColor.Blue
        System.Console.Write("Reverse Number Is: ")
        System.Console.BackgroundColor = ConsoleColor.Blue
        System.Console.ForegroundColor = ConsoleColor.White
        System.Console.WriteLine(s)

        System.Console.ResetColor()

        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        System.Console.ReadKey()

    End Sub

End Module
