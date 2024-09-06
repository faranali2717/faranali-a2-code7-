Imports System.Console
'Create an automatic percent calculator that a teacher could use after an exam. The 
'teacher will enter the total number Of marks And the raw score. The form them calculates 
'the percentage(to two decimal places).

Module Program
    Sub Main()
        Dim per, totalnum, rawnum As Double
        WriteLine("enter total number and marks obtain")
        totalnum = ReadLine()
        rawnum = ReadLine()
        per = (rawnum / totalnum) * 100
        WriteLine("percentage obtain: " & per)
        ReadKey()


    End Sub
End Module
