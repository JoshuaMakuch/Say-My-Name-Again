'Joshua Makuch
'RCET0265
'Winter 2023
'Say My Name...Again
'https://github.com/JoshuaMakuch/Say-My-Name-Again.git

Option Explicit On
Option Strict On

Imports System
Imports System.Threading 'So that Thread.Sleep works to provide a delay


Module SayMyNameAgain
    Sub Main(args As String())

        Dim userName As String 'Moved variable initialization

        Console.WriteLine("Hello, what is your name?")

        userName = Console.ReadLine()

        If (userName = "Emily") Or (userName = "Joe") Then                      'These check the user's input to see if it is deserving of a special response
            Console.WriteLine($"Oh! Welcome back {userName}!")
        ElseIf (userName = "Joshua") Then                                       'This outputs a special response to my name
            Console.WriteLine($"Error 404: User {userName} DOES NOT EXIST")
        Else
            Console.WriteLine("Interesting, I've never heard of you before...") 'This outputs a response for anybody else
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
