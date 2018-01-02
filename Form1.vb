'********************************
' Greg Pina
' .Net Programming 101 - 401
' Homework 4 State Abbreviations
' 9/18/17 LATE
'**********************************


Public Class StateAbbreviations
    Private Sub btnVirgina_Click(sender As Object, e As EventArgs) Handles btnVirgina.Click
        lblAnswer.Text = "VA"
    End Sub

    Private Sub btnNorthCarolina_Click(sender As Object, e As EventArgs) Handles btnNorthCarolina.Click
        lblAnswer.Text = "NC"
    End Sub

    Private Sub btnSouthCarolina_Click(sender As Object, e As EventArgs) Handles btnSouthCarolina.Click
        lblAnswer.Text = "SC"
    End Sub

    Private Sub btnGeorgia_Click(sender As Object, e As EventArgs) Handles btnGeorgia.Click
        lblAnswer.Text = "GA"
    End Sub

    Private Sub btnAlabama_Click(sender As Object, e As EventArgs) Handles btnAlabama.Click
        lblAnswer.Text = "AL"
    End Sub

    Private Sub btnFLorida_Click(sender As Object, e As EventArgs) Handles btnFLorida.Click
        lblAnswer.Text = "FL"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
