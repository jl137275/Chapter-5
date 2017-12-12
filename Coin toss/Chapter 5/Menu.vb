Public Class Menu

    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim Box = New Form1()
        Box.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim Box = New RockPaperScissors()
        Box.ShowDialog()
    End Sub

    Private Sub btnRaceCarGame_Click(sender As Object, e As EventArgs) Handles btnRaceCarGame.Click
        Dim box = New RaceCarGame()
        box.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New SumOfNumbers()
        box.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim box = New DistanceCalculator()
        box.ShowDialog()
    End Sub

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim box = New Population()
        box.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim box = New RandomNumberGuessingGame()
        box.ShowDialog()
    End Sub
End Class