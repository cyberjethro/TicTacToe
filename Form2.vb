Public Class Form2
    Public playerOne As String = "Player 1"
    Public playerTwo As String = "Player 2"

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerOne = txtPlay1.Text
        playerTwo = txtPlay2.Text

        Form1.lblPlay1.Text = playerOne
        Form1.lblPlay2.Text = playerTwo

        Me.Hide()

    End Sub


End Class