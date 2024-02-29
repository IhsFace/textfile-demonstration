Imports System.IO

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim strTestScores As String
        Dim strNames As String
        Dim ExampleFile As StreamReader = File.OpenText("TestScoresData.txt")

        lstData.Items.Clear()

        For i = 0 To 4
            strNames = ExampleFile.ReadLine()
            strTestScores = ExampleFile.ReadLine()
            lstData.Items.Add(strNames & " " & strTestScores)
        Next

        ExampleFile.Close()
    End Sub

    Private Sub btnReadUnknownLengthFile_Click(sender As Object, e As EventArgs) Handles btnReadUnknownLengthFile.Click
        Dim ExampleFile As StreamWriter = File.AppendText("TestScoresData.txt")
        Dim strName As String = InputBox("Enter the name to add", "Add name")

        ExampleFile.WriteLine(strName)

        Dim intScore As Integer = InputBox("Enter the test score to add", "Add score")

        ExampleFile.WriteLine(intScore)
        MessageBox.Show("The name and score has been added to the text file")
        ExampleFile.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim NamesFile As StreamReader = File.OpenText("TestScoresData.txt")

        lstData.Items.Clear()

        Dim strName As String
        Dim strScore As String

        Do While NamesFile.Peek <> -1
            strName = NamesFile.ReadLine()
            strScore = NamesFile.ReadLine()
            lstData.Items.Add(strName & " " & strScore)
        Loop

        NamesFile.Close()
    End Sub
End Class
