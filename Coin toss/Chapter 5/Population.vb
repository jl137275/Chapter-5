Public Class Population

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDays.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intcount As Integer
        Dim dbltotal As Double
        lstOutput.Items.Add("Day Approximate Population")
        lstOutput.Items.Add("--------------------------")
        dbltotal = 2
        intcount = 1

        lstOutput.Items.Add(intcount.ToString + " " + dbltotal.ToString)

        For intcount = intcount + 1 To cboDays.Text
            dbltotal = (CDbl(txtIncreasePct.Text * dbltotal) / 100) + dbltotal
            lstOutput.Items.Add(intcount.ToString + " " + dbltotal.ToString)
        Next

    End Sub
End Class