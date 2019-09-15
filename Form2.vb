Public Class Form2
    Public playerOne As String = "Player 1"
    Public playerTwo As String = "Player 2"

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        playerOne = txtPlay1.Text
        playerTwo = txtPlay2.Text

        MessageBox.Show(playerOne)
        MessageBox.Show(playerTwo)

    End Sub


End Class