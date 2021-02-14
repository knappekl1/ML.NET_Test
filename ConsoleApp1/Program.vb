Imports System
Imports ConsoleApp1ML.Model
Module Program
    Sub Main(args As String())

        'Add input data
        Dim Input As New ModelInput() With {.Message = "You have WON our mega prize- call 445-345-984", .Length = "45"}

        Dim result As ModelOutput = ConsumeModel.Predict(Input)

        Dim MsgType As String = result.Prediction


        Console.WriteLine($"Text: {Input.Message} Type: {MsgType}")

    End Sub
End Module
