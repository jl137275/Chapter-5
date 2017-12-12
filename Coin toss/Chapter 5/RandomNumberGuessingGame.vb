Public Class RandomNumberGuessingGame

    Dim counter As Integer
    Dim CG As Integer
    Dim intWins As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim number As New Random
        CG = number.Next(100) + 1
        counter = 0
        TextBox1.Text = ("")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Dim UG As Integer
        UG = CInt(TextBox1.Text)
        counter = counter + 1
        Try
            If UG = CG Then
                MessageBox.Show("You guessed my number!")
            ElseIf UG < CG Then
                MessageBox.Show("Too low, try again.")
            ElseIf UG < CG Then
                MessageBox.Show("Too high, try again.")
            End If
            lblWins.Text = intWins.ToString("n")
        Catch E1 As InvalidCastException
            MessageBox.Show("Please enter a number and try again.")
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim R As DialogResult
        R = MessageBox.Show("Are you sure you want to quit?", "Game Quit", MessageBoxButtons.YesNo)
        If R = Windows.Forms.DialogResult.No Then
            btnNewGame.PerformClick()
        ElseIf R = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class