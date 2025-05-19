
Module modMain

    Sub Main()
        Dim objCOMPlus As New FRAME_4_7_2.COMPlusServices()

        Console.WriteLine(objCOMPlus.DoTransaction())
        Console.ReadLine()

    End Sub

End Module
