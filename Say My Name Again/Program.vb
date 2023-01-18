'Joshua Makuch
'RCET0265
'Fall 2023
'Say My Name...Again
'https://github.com/JoshuaMakuch/Say-My-Name-Again.git
Imports System
Imports System.Threading

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello, what is your name?")
        Dim userName As String = Console.ReadLine()
        If (userName = "Emily") Or (userName = "Joe") Then
            Console.WriteLine($"Oh! Welcome back {userName}!") '
        Else
            Console.WriteLine("Interesting, I've never heard of you before...")
            Thread.Sleep(500)
            Console.WriteLine(".")
            Thread.Sleep(500)
            Console.WriteLine(".")
            Thread.Sleep(500)
            Console.WriteLine(".")
            Thread.Sleep(1000)
            Console.WriteLine($"Did you know your name contains the letter {userName.First()}")
        End If
    End Sub
End Module
