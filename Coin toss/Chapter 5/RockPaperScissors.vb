Public Class RockPaperScissors
    Dim PlayerCount1 As Integer = 0
    Dim compcount As Integer = 0

    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        Dim Num As Integer
        Const Rock = 1
        Const Paper = 2
        Const Scissors = 3

        Num = CInt((3 * Rnd()))

        If RockRadioButton.Checked And Num = Rock Then
            lblresult.Text = "Computer chose Rock too. Tie!"

        ElseIf RockRadioButton.Checked And Num = Paper Then
            lblresult.Text = "Computer chose Paper. You Lose."
            compcount += 1

        ElseIf RockRadioButton.Checked And Num = Scissors Then
            lblresult.Text = "Computer chose Scissors. You Win."
            PlayerCount1 = PlayerCount1 + 1

        ElseIf PaperRadioButton.Checked And Num = Rock Then
            lblresult.Text = "Computer chose Rock. You Win."
            PlayerCount1 = PlayerCount1 + 1
        ElseIf PaperRadioButton.Checked And Num = Scissors Then
            lblresult.Text = "Computer chose Scissors. You Lose."
            compcount += 1
        ElseIf PaperRadioButton.Checked And Num = Paper Then
            lblresult.Text = "Computer chose Paper too. Tie!"


        ElseIf ScissorsRadioButton.Checked And Num = Rock Then
            lblresult.Text = "Computer chose Rock. You Lose."
            compcount += 1
        ElseIf ScissorsRadioButton.Checked And Num = Paper Then
            lblresult.Text = "Computer chose Paper. You Win."
            PlayerCount1 = PlayerCount1 + 1
        ElseIf ScissorsRadioButton.Checked And Num = Scissors Then
            lblresult.Text = "Computer chose Scissors too. Tie!"
        End If
        lblCPU.Text = compcount.ToString
        lblPlayerWins.Text = PlayerCount1.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
