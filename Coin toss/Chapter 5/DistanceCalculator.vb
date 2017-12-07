Public Class DistanceCalculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dbldistanceTraveled
        Dim dblX = 0
        Do While dblX < CDbl(txtHours.Text)
            dblX = dblX + 1
            dbldistanceTraveled = (txtSpeed.Text) * dblX
            listResults.Items.Add(dblX + "         " + dbldistanceTraveled)
        Loop

    End Sub

End Class