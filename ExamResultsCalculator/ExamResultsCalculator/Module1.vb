Module Module1

    Sub Main(args As String())
        Dim Result As Integer
        Dim Grade As String
        Console.WriteLine("Enter Exam Result (Marks out of 100)")
        Result = Console.ReadLine()
        Select Case Result
            Case > 80
                Grade = "A"
            Case > 70
                Grade = "B"
            Case > 60
                Grade = "C"
            Case > 50
                Grade = "D"
            Case > 40
                Grade = "E"
            Case Else
                Grade = "Fail"
        End Select
        Console.WriteLine("Your Mark (" & Result & ") is a " & Grade & " grade")
        Console.ReadLine()
    End Sub

End Module
