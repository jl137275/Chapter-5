Public Class RaceCarGame
    Dim intLightingCount As Integer
    Dim intMatorCount As Integer
    Dim intLuigiCount As Integer


    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount1, intCount2, intCount3 As Integer
        Dim rand As New Random

        Dim intscore As Integer = 1
        Dim intYouwin As Integer = 10

        For intCount1 = 60 To rand.Next(250) + 500
            picRacer1.Left = intCount1
        Next
        For intCount2 = 60 To rand.Next(250) + 500
            picRacer2.Left = intCount2
        Next
        For intCount3 = 60 To rand.Next(250) + 500
            picRacer3.Left = intCount3
        Next
        If intCount1 > intCount2 And intCount3 Then
            intLightingCount += 1
        ElseIf intCount2 > intCount1 And intCount3 Then
            intMatorCount += 1
        ElseIf intCount3 > intCount1 And intCount2 Then
            intLuigiCount += 1
        End If




    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class