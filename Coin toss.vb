Public Class Form1
    Dim headsTotal As Integer
    Dim tailTotal As Integer
    Private Sub btnEnterSales_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideup As Integer

        Dim rand As New Random

        intSideup = rand.Next(2)
        If intSideup = 0 Then
            picTails.Visible = True
            picHeads.Visible = False
            tailTotal = 1 + tailTotal

        Else
            picHeads.Visible = True
            picTails.Visible = False
            headsTotal = 1 + headsTotal
        End If

        lblHeadsTotal.Text = headsTotal.ToString
        lblTailsTotal.Text = tailTotal.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
